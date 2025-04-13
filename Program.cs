#define ENABLEMACRO

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
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

            if (context.Request.HttpMethod == "POST")
            {
                if (path == "/controllers")
                {
                    var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding);
                    string requestBody = reader.ReadToEnd();
                    
                    var windowAssignRequest = JsonConvert.DeserializeObject<WindowAssignRequest>(requestBody);
                    var matchingControllers = Multicontroller.Instance.AllControllerPairs.Select(pair =>
                            GetControllersForDirection(pair, windowAssignRequest.Pair))
                        .Where(controller => controller.GroupNumber == windowAssignRequest.GroupNumber);
                    var targetController = matchingControllers.First();
                    if (matchingControllers.Count() != 1)
                    {
                        context.Response.StatusCode = 422;
                        string message = "Could not find controller in group " + windowAssignRequest.GroupNumber +
                                         " on the " + windowAssignRequest.Pair;
                        byte[] buffer = Encoding.UTF8.GetBytes(message);

                        context.Response.ContentType = "application/json";
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                        context.Response.OutputStream.Close();
                    }
                    else
                    {
                        context.Response.StatusCode = 200;
                        string message = JsonConvert.SerializeObject(targetController);
                        byte[] buffer = Encoding.UTF8.GetBytes(message);
                        targetController.WindowHandle = new IntPtr(windowAssignRequest.HWnd);
                        context.Response.ContentType = "application/json";
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                        context.Response.OutputStream.Close();   
                    }
                }
                else
                {
                    context.Response.StatusCode = 404;
                }
            }

            context.Response.OutputStream.Close();
        }

        private static ToontownController GetControllersForDirection(ControllerPair controllerPair, PairDirection pair)
        {
            if (pair == PairDirection.Left)
            {
                return controllerPair.LeftController;
            }

            return controllerPair.RightController;
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

    internal class WindowAssignRequest
    {
        public int GroupNumber { get; }
        public int HWnd { get; }
        public PairDirection Pair { get; }

        public WindowAssignRequest(int groupNumber, int hWnd, PairDirection pair)
        {
            GroupNumber = groupNumber;
            HWnd = hWnd;
            Pair = pair;
        }
    }

    internal enum PairDirection
    {
        Left,
        Right
    }
}
