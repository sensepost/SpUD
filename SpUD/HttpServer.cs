using System;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Web;
using System.Web.Hosting;
using com.sensepost.SPUDHelperClasses;

namespace com.sensepost.SPUD
{
    public class HttpServer
    {
        #region Private Class Variables
        frm_main g_main;
        #endregion

        #region Public Class Variables
        public Thread g_HttpThread;
        //public System.Net.HttpListener g_HttpListener;
        HttpListenerWrapper g_HttpListener;
        public volatile bool g_running;
        #endregion

        #region Class Instantiation
        public HttpServer(frm_main the_main)
        {
            this.g_main = the_main;
            this.g_main.LogTheEvent("APP-HTTP", "DEBUG", "HTTP Server Class Instantiated");
            this.g_running = false;
        }
        #endregion

        #region Utility Methods
        public void StartTheServer()
        {
            this.g_main.LogTheEvent("APP-HTTP", "DEBUG", "Starting HTTP Worker Threads");
            g_HttpThread = new Thread(new ThreadStart(this.ProcessRequests));
            g_HttpThread.Name = "Main Http Process Thread";
            g_HttpThread.Start();
            g_running = true;
        }

        public void StopTheServer()
        {
            this.g_main.LogTheEvent("APP-HTTP", "DEBUG", "Stopping HTTP Worker Threads");
            g_running = false;
            try
            {
                g_HttpListener.Stop();
                g_HttpListener.Stop();
                g_HttpThread.Abort();
            }
            catch (Exception e)
            {
                this.g_main.LogTheEvent("APP-HTTP", "ERROR", "Exception:" + e.Message.ToString().Replace("\r", "").Replace("\n", "||").Replace("\t", ""));
            }
        }
        #endregion

        #region The Main Thread Process
        public void ProcessRequests()
        {
            string[] prefixes = new string[1];
            prefixes[0] = "http://*:61532/";

            // For debugging, there is a bit of a hack to get the thing working...
            // You need a directory c:\TestWebService
            // This directory must contain the service.asmx app.
            // Need directory c:\TestWebService\bin
            // this must contain the compiled libraries of the application...
            // So, to bedug...
            // Uncomment the lines indicating the "WWWROOT" marked debug below.
            // Comment the lines indicating the "WWWROOT" marked prod below.
            // Make all changes to the app and build.
            // Copy all output from bin\debug to c:\TestWebService\bin
            // Copy service.asmx to C:\TestWebService
            // run the app...

            

            // Production line - uncomment before building for installer.  Comment before debugging.
            g_HttpListener = (HttpListenerWrapper)ApplicationHost.CreateApplicationHost(typeof(HttpListenerWrapper), "/", Directory.GetCurrentDirectory()) as HttpListenerWrapper;
            // Debug line - comment vefore building for installer.  uncomment before debugging.
            //g_HttpListener = (HttpListenerWrapper)ApplicationHost.CreateApplicationHost(typeof(HttpListenerWrapper), "/", "C:\\TestWebService") as HttpListenerWrapper;
            // Production line - uncomment before building for installer.  Comment before debugging.
            g_HttpListener.Configure(prefixes, "/", Directory.GetCurrentDirectory());
            // Debug line - comment vefore building for installer.  uncomment before debugging.
            //g_HttpListener.Configure(prefixes, "/", "C:\\TestWebService");

            // Other Stuff Here...
            //System.Diagnostics.Debug.WriteLine("START1");
            //g_HttpListener.InitializeLifetimeService();
            //System.Diagnostics.Debug.WriteLine("START2");
            //g_HttpListener.InitializeLifetimeService();
            g_HttpListener.Start();
            this.g_main.LogTheEvent("APP-HTTP", "DEBUG", "HTTP Worker Thread Listening");
            while (g_running)
            {
                //System.Diagnostics.Debug.WriteLine("MOOHERE1");
                if (!g_running) break;
                try
                {
                    //System.Diagnostics.Debug.WriteLine("MOOHERE2");
                    this.g_main.LogTheEvent("APP-HTTP", "DEBUG", "Request Loop");
                    //System.Diagnostics.Debug.WriteLine("MOOHERE3");
                    //System.Diagnostics.Debug.WriteLine("MOOHERE4");
                    g_HttpListener.ProcessRequest();
                    // The previous line is where it all falls down...
                    //System.Diagnostics.Debug.WriteLine("MOOHERE5");
                    //System.Diagnostics.Debug.WriteLine("MOOHERE6");
                    try
                    {
                        //System.Diagnostics.Debug.WriteLine("MOOHERE7");
                        //System.Diagnostics.Debug.WriteLine("MOOHERE8");
                        this.g_HttpListener.Start();
                        //System.Diagnostics.Debug.WriteLine("MOOHERE9");
                        //System.Diagnostics.Debug.WriteLine("MOOHEREA");
                    }
                    catch
                    {
                        //System.Diagnostics.Debug.WriteLine("MOOHEREB");
                    }
                    //System.Diagnostics.Debug.WriteLine("MOOHEREC");
                    //System.Diagnostics.Debug.WriteLine("MOOHERED");
                }
                catch (Exception e)
                {
                    this.g_main.LogTheEvent("APP-HTTP", "ERROR", "Exception:" + e.Message.ToString().Replace("\r", "").Replace("\n", "|||").Replace("\t", ""));
                    //System.Diagnostics.Debug.WriteLine("MOOHEREE");
                }
            }
        }

        /*public virtual bool theProcessRequest()
        {
            try
            {
                this.g_HttpListener.TestService = "TEST";
                System.Diagnostics.Debug.WriteLine(this.g_HttpListener.TestService);
                System.Diagnostics.Debug.WriteLine("TEST SET");
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("TEST EXCEPTION");
                this.g_HttpListener.Start();
            }
            try
            {
                this.g_HttpListener.ProcessRequest();
                System.Diagnostics.Debug.WriteLine("PROCESS SET");
                return true;
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("PROCESS EXCEPTION");
                return false;
            }
        }*/
        #endregion
    }
}
