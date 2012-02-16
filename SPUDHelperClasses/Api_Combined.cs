using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using Microsoft.Win32;

// The namespace... 'nuff said...
namespace com.sensepost.SPUDHelperClasses
{
    // The class.  'nuff said...
    public class Api_Combined
    {
        #region Private Class Variables
        private StructuredQuery g_query;
        private StructuredResult g_result;
        private bool g_google;
        private bool g_gaura;
        private bool g_ggh;
        private String g_gkey;
        private bool g_live;
        private bool g_lgh;
        private String g_lkey;
        private bool g_yahoo;
        private bool g_ygh;
        private String g_ykey;
        // Google Thread items...
        //private Thread thr_google;
        //private volatile bool run_google;
        //private volatile StructuredEngineResult res_google;
        // Live Thread items...
        //private Thread thr_live;
        //private volatile bool run_live;
        //private volatile StructuredEngineResult res_live;
        // Yahoo Thread items...
        //private Thread thr_yahoo;
        //private volatile bool run_yahoo;
        //private volatile StructuredEngineResult res_yahoo;
        #endregion

        #region Class instantiation
        // Class instantiation
        public Api_Combined()
        {
            this.g_query    = new StructuredQuery();
            this.g_result   = new StructuredResult();
            this.g_google   = this.RegGoogle();
            this.g_gaura    = this.RegGAura();
            this.g_ggh      = this.RegGGh();
            this.g_gkey     = this.RegGKey();
            this.g_live     = this.RegLive();
            this.g_lgh      = this.RegLGH();
            this.g_lkey     = this.RegLKey();
            this.g_yahoo    = this.RegYahoo();
            this.g_ygh      = this.RegYGH();
            this.g_ykey     = this.RegYKey();
            //this.run_google = false;
            //this.run_live = false;
            //this.run_yahoo = false;
        }

        // Class instantiation - Override 1
        public Api_Combined(StructuredQuery c_query)
        {
            this.g_result = new StructuredResult();
            this.g_google = this.RegGoogle();
            this.g_gaura = this.RegGAura();
            this.g_ggh = this.RegGGh();
            this.g_gkey = this.RegGKey();
            this.g_live = this.RegLive();
            this.g_lgh = this.RegLGH();
            this.g_lkey = this.RegLKey();
            this.g_yahoo = this.RegYahoo();
            this.g_ygh = this.RegYGH();
            this.g_ykey = this.RegYKey();
            this.g_query = c_query;
            this.g_result = new StructuredResult();
        }
        #endregion

        #region Private Methods
        private bool RegGoogle()
        {
            String val = RegGet("G_EN", "1");
            if (val == "1") return true;
            else return false;
        }

        private bool RegGAura()
        {
            String val = RegGet("G_AU", "0");
            if (val == "1") return true;
            else return false;
        }

        private bool RegGGh()
        {
            String val = RegGet("G_GH", "1");
            if (val == "1") return true;
            else return false;
        }

        private String RegGKey()
        {
            String val = RegGet("G_KY", "Your Google API Key Here...");
            return val;
        }

        private bool RegLive()
        {
            String val = RegGet("L_EN", "1");
            if (val == "1") return true;
            else return false;
        }

        private bool RegLGH()
        {
            String val = RegGet("L_GH", "0");
            if (val == "1") return true;
            else return false;
        }

        private String RegLKey()
        {
            String val = RegGet("L_KY", "Your MSN Live Search API Key Here...");
            return val;
        }

        private bool RegYahoo()
        {
            String val = RegGet("Y_EN", "1");
            if (val == "1") return true;
            else return false;
        }

        private bool RegYGH()
        {
            String val = RegGet("Y_GH", "1");
            if (val == "1") return true;
            else return false;
        }

        private String RegYKey()
        {
            String val = RegGet("Y_KY", "Your! Yahoo! API! Key! Here!...");
            return val;
        }

        private void RegSet(String Key, String Value)
        {
            try
            {
                RegistryKey OurKey = Registry.CurrentUser;
                OurKey = OurKey.OpenSubKey("SOFTWARE", true);
                OurKey.CreateSubKey("SensePost");
                OurKey.CreateSubKey(@"SensePost\Spud");
                RegistryKey NewKey = Registry.CurrentUser;
                NewKey = NewKey.OpenSubKey(@"SOFTWARE\SensePost\Spud", true);
                NewKey.SetValue(Key, Value);
                NewKey.Close();
            }
            catch { }
        }

        private String RegGet(String Key, String DefaultValue)
        {
            String Returner = "";
            RegistryKey NewKey = Registry.CurrentUser;
            try
            {
                NewKey = NewKey.OpenSubKey(@"SOFTWARE\SensePost\Spud", true);
                Returner = NewKey.GetValue(Key).ToString();
                NewKey.Close();
            }
            catch
            {
                RegSet(Key, DefaultValue);
                Returner = DefaultValue;
            }
            return Returner;
        }
        #endregion

        #region Public Properties (Get:Set)
        public StructuredQuery ApiQuery
        {
            get { return this.g_query; }
            set { this.g_query = value; }
        }

        public StructuredResult ApiResult
        {
            get { return this.g_result; }
            set { this.g_result = value; }
        }
        #endregion

        #region Public Methods
        public StructuredResult GetTheResults()
        {
            Collection<StructuredResultElement> ResultItems = new Collection<StructuredResultElement>();
            int TotalGoogle = 0;
            int TotalLive = 0;
            int TotalYahoo = 0;
            // We check if the google search option is enabled
            if (this.g_google)
            {
                // We check if this is a Google Hack Query and whether the Google Hack option is enabled or not
                if ((this.g_query.QueryGoogleHack && this.g_ggh) || (!this.g_query.QueryGoogleHack))
                {
                    Api_G the_obj = new Api_G(this.g_gkey, this.g_query.QueryString, this.g_query.QueryStart, this.g_query.QueryLength, this.g_gaura);
                    StructuredEngineResult resultitem = the_obj.GetResults();
                    TotalGoogle = resultitem.ResultTotal;
                    foreach (StructuredResultElement res_itm in resultitem.ResultItems) ResultItems.Add(res_itm);
                }
            }
            // We check if the MSN Live search option is enaled
            if (this.g_live)
            {
                // We check if this is a Google Hack Query and whether the Google Hack option is enabled or not
                if ((this.g_query.QueryGoogleHack && this.g_lgh) || (!this.g_query.QueryGoogleHack))
                {
                    Api_L the_obj = new Api_L(this.g_lkey, this.g_query.QueryString, this.g_query.QueryStart, this.g_query.QueryLength);
                    StructuredEngineResult resultitem = the_obj.GetResults();
                    TotalLive = resultitem.ResultTotal;
                    foreach (StructuredResultElement res_itm in resultitem.ResultItems) ResultItems.Add(res_itm);
                }
            }
            // We check if the Yahoo search option is enabled
            if (this.g_yahoo)
            {
                // We check if this is a Google Hack Query and whether the Google Hack option is enabled or not
                if ((this.g_query.QueryGoogleHack && this.g_ygh) || (!this.g_query.QueryGoogleHack))
                {
                    Api_Y the_obj = new Api_Y(this.g_ykey, this.g_query.QueryString, this.g_query.QueryStart, this.g_query.QueryLength);
                    StructuredEngineResult resultitem = the_obj.GetResults();
                    TotalYahoo = resultitem.ResultTotal;
                    foreach (StructuredResultElement res_itm in resultitem.ResultItems) ResultItems.Add(res_itm);
                }
            }
            g_result.ResultStart = g_query.QueryStart;
            g_result.ResultEnd = g_query.QueryLength;
            g_result.ResultQueryString = g_query.QueryString;
            g_result.ResultTotal = TotalGoogle + TotalLive + TotalYahoo;
            g_result.ResultItems = ResultItems;
            g_result.ResultGoogleTotal = TotalGoogle;
            g_result.ResultLiveTotal = TotalLive;
            g_result.ResultYahooTotal = TotalYahoo;
            return this.g_result;
        }

        public void StartGoogleThread()
        {
        }

        public void StartYahooThread()
        {
        }

        public void StartLiveThread()
        {
        }

        #endregion
    }
}
