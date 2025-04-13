#define ENABLEMACRO

using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

using TTMulti.Forms;
using TTMulti.Properties;

namespace TTMulti
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
            }

            if (Settings.Default.runAsAdministrator)
            {
                if (args.Length == 0 || args[0] != "--runasadmin")
                {
                    if (TryRunAsAdmin())
                    {
                        return;
                    }
                }
            }

            StartLocalHttpServer();
            Application.Run(new MulticontrollerWnd());
        }
        private static void StartLocalHttpServer()
        {
            Task.Run(() =>
            {
                var listener = new HttpListener();
                listener.Prefixes.Add("http://127.0.0.1:12525/");
                listener.Start();
                Console.WriteLine("Server running at http://127.0.0.1:12525/");

                while (true)
                {
                    var context = listener.GetContext(); 
                    Task.Run(() => HandleRequest(context)); 
                }
            });
        }
        
        private static void HandleRequest(HttpListenerContext context)
        {
            string path = context.Request.Url.AbsolutePath;

            if (path == "/controllers")
            {
                string json = JsonConvert.SerializeObject(Multicontroller.Instance.AllControllers);
                byte[] buffer = Encoding.UTF8.GetBytes(json);

                context.Response.ContentType = "application/json";
                context.Response.ContentLength64 = buffer.Length;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.OutputStream.Close();
            }
            else
            {
                context.Response.StatusCode = 404;
            }

            context.Response.OutputStream.Close();
        }

        internal static bool TryRunAsAdmin()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase);
            processInfo.Arguments = "--runasadmin";
            processInfo.UseShellExecute = true;
            processInfo.Verb = "runas";

            try
            {
                Process.Start(processInfo);
                return true;
            }
            catch
            {
                Settings.Default.runAsAdministrator = false;
                Settings.Default.Save();
                return false;
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
