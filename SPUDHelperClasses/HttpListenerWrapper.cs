using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Web;

namespace com.sensepost.SPUDHelperClasses
{
    public class HttpListenerWrapper : MarshalByRefObject
    {
        private HttpListener _listener;
        private string _virtualDir;
        private string _physicalDir;

        public void Configure(string[] prefixes, string vdir, string pdir)
        {
            _virtualDir = vdir;
            _physicalDir = pdir;
            _listener = new HttpListener();

            foreach (string prefix in prefixes)
                _listener.Prefixes.Add(prefix);
        }
        public void Start()
        {
            _listener.Start();
        }
        public void Stop()
        {
            _listener.Stop();
        }

        public void ProcessRequest()
        {
            try
            {
                HttpListenerContext ctx = _listener.GetContext();
                HttpListenerWorkerRequest workerRequest = new HttpListenerWorkerRequest(ctx, _virtualDir, _physicalDir);
                HttpRuntime.ProcessRequest(workerRequest);
                try
                {
                    _listener.Start();
                    //System.Diagnostics.Debug.WriteLine("TRY");
                }
                catch
                {
                    //System.Diagnostics.Debug.WriteLine("CAUGHT");
                }
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
        }

        public override object InitializeLifetimeService()
        {
            //System.Diagnostics.Debug.WriteLine("MOO!!!!");
            return null;
        }
    }
}
