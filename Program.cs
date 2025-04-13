#define ENABLEMACRO

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TTMulti.Forms;
using TTMulti.Properties;

namespace TTMulti
{
    static class Program
    {
        private const string URI = "http://127.0.0.1:12525/";
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

        private static void StartLocalHttpServer()
        {
            Task.Run(() => {
                var listener = new HttpListener();
                listener.Prefixes.Add(URI);
                listener.Start();
                Console.WriteLine("Server running at " + URI);

                while (true)
                {
                    Thread.Sleep(5);
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
                var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding);
                string requestBody = reader.ReadToEnd();
                if (path == "/assign")
                {
                    HandleAssign(context, requestBody);
                }
                else if (path == "/unassign")
                {
                    foreach (var instanceAllController in Multicontroller.Instance.AllControllers)
                    {
                        instanceAllController.WindowHandle = IntPtr.Zero;
                    }
                }
                else if (path == "/mode")
                {
                    ModeChangeRequest modeChangeRequest = null;
                    try
                    {
                        modeChangeRequest = JsonConvert.DeserializeObject<ModeChangeRequest>(requestBody);
                    }
                    catch (Exception e)
                    {
                        ReturnError(context, "Could not parse provided mode");
                    }
                    string substate = modeChangeRequest.Substate;
                    switch (substate)
                    {
                        case "quad":
                            Multicontroller.Instance.QuadMode = true;
                            break;

                        case "allgroups":
                            Multicontroller.Instance.AllGroupsMode = true;
                            break;
                        
                        case "reset":
                            Multicontroller.Instance.AllGroupsMode = false;
                            Multicontroller.Instance.QuadMode = false;
                            break;
                        default:
                            ReturnError(context, "Could not parse substate " + substate);
                            return;
                    }
                    Multicontroller.Instance.CurrentMode = modeChangeRequest.Mode;
                    Multicontroller.Instance.Refresh();
                    AssignObjectToReturnContext(context, "Assigned mode " + modeChangeRequest.Mode + " with substate " + substate);
                }
                else
                {
                    context.Response.StatusCode = 404;
                }
            }

            context.Response.OutputStream.Close();
        }
        private static void HandleAssign(HttpListenerContext context, string requestBody)
        {

            var windowAssignRequest = JsonConvert.DeserializeObject<WindowAssignRequest>(requestBody);
            var matchingControllers = Multicontroller.Instance.AllControllerPairs.Select(pair =>
                    GetControllersForDirection(pair, windowAssignRequest.Pair))
                .Where(controller => controller.GroupNumber == windowAssignRequest.GroupNumber)
                .Where(controller => controller.PairNumber == 1);
            var targetController = matchingControllers.First();
            if (matchingControllers.Count() != 1)
            {
                ReturnError(context, "Could not find controller in group " + windowAssignRequest.GroupNumber +
                                     " on the " + windowAssignRequest.Pair);
            }
            else
            {
                targetController.WindowHandle = new IntPtr(windowAssignRequest.HWnd);
                AssignObjectToReturnContext(context, targetController);
            }
        }

        private static void ReturnError(HttpListenerContext context, string errorMessage)
        {

            context.Response.StatusCode = 422;
            byte[] buffer = Encoding.UTF8.GetBytes(errorMessage);

            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.OutputStream.Close();
        }
        private static void AssignObjectToReturnContext(HttpListenerContext context, Object obj)
        {
            context.Response.StatusCode = 200;
            string message = JsonConvert.SerializeObject(obj);
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
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


        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }

}
