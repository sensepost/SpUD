using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using com.sensepost.SPUDHelperClasses;
using Microsoft.Win32;

// The namespace.  'nuff said...
namespace com.sensepost.SPUD
{
    #region Delegate Items
    public delegate void Del_Form_Show(System.Windows.Forms.Form myctl, bool myshw);
    public delegate void Del_Form_XanY(System.Windows.Forms.Form myctl, int x, int y);
    public delegate void Del_Form_Focs(System.Windows.Forms.Form myctl);
    #endregion

    // The class.  'nuff said...
    public partial class frm_main : Form
    {
        #region Private Class Variables
        private frm_advresbrs the_src;
        private frm_quicksearch the_qus;
        private frm_notify the_not;
        private frm_logview the_log;
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
        private bool b_cfshow;
        private bool b_qsshow;
        private bool b_abshow;
        private bool b_nfshow;
        private bool b_lfshow;
        private String sz_not_label;
        private String sz_query;
        private int n_start;
        private int n_length;
        #endregion

        #region Public Class Variables

        #region Delegate Items
        public Del_Form_Show del_frm_show;
        public Del_Form_XanY del_frm_xany;
        public Del_Form_Focs del_frm_focs;
        #endregion

        #region The HttpServer Objects
        public HttpServer g_HttpServer;
        #endregion

        #region API Key Objects

        #region Google API
        //public volatile Boolean g_usegoogle;
        //public volatile Boolean g_gaura;
        //public volatile Boolean g_gapi;
        //public volatile String g_gapikey;
        //public volatile Boolean g_ggooglehack;
        #endregion

        #region Live API
        //public volatile Boolean g_uselive;
        //public String g_lapikey;
        //public volatile Boolean g_lgooglehack;
        #endregion

        #region Yahoo API
        //public volatile Boolean g_useyahoo;
        //public volatile String g_yapikey;
        //public volatile Boolean g_ygooglehack;
        #endregion

        #endregion

        #region SOAP Variable Objects
        public volatile com.sensepost.web.obj.StructuredResult all_results;
        #endregion

        #region The Log File Objects
        public volatile log_file log_main;
        #endregion

        #endregion

        #region Main Class Instantiation
        public frm_main()
        {
            InitializeComponent();
            // We try and delete the log file...
            try
            {
                File.Delete(Directory.GetCurrentDirectory() + "\\main.log");
            }
            catch { }
            this.log_main = new log_file(Directory.GetCurrentDirectory() + "\\main.log", true);
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Initialising SYSTRAY Form");
            this.b_abshow = false;
            this.b_qsshow = false;
            this.b_nfshow = false;
            this.b_cfshow = false;
            this.b_lfshow = false;
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Initialising Quick Search Form");
            the_qus = new frm_quicksearch(this);
            the_qus.Hide();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Initialising Notify Form");
            the_not = new frm_notify(this);
            the_not.Hide();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Reading Configuration");
            GetTheConfig();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Starting HTTP Server Thread");
            StartTheServer();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Initialising Result Form");
            the_src = new frm_advresbrs(this);
            the_src.Hide();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Initialising Log Viewer Form");
            the_log = new frm_logview(this);
            the_log.Hide();
            this.ShowInTaskbar = false;
            all_results = new global::com.sensepost.SPUD.com.sensepost.web.obj.StructuredResult();
            this.sz_query = "";
            this.sz_not_label = "";
            this.del_frm_show = new Del_Form_Show(this.Dtg_Frm_Shw);
            this.del_frm_xany = new Del_Form_XanY(this.Dtg_Frm_XnY);
            this.del_frm_focs = new Del_Form_Focs(this.Dtg_Frm_Foc);
            this.mit_cfg.PerformClick();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Initialising Keyboard Hooks");
            Program.kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(kh_KeyIntercepted);
        }
        #endregion

        #region Control Target Voids
        private void chk_usegoogle_CheckedChanged(object sender, EventArgs e)
        {
            bool AmIEnabled = chk_usegoogle.Checked;
            foreach (System.Windows.Forms.Control ctl in cfg_google.Controls)
                if (ctl.Name != "chk_usegoogle") ctl.Enabled = AmIEnabled;
            Api_Variables.s_google = AmIEnabled;
            Api_Variables.s_ggh = chk_ggooglehack.Checked;
            Api_Variables.s_gkey = txt_gapikey.Text;
        }

        private void chk_usermsnliveapi_CheckedChanged(object sender, EventArgs e)
        {
            bool AmIEnabled = chk_usermsnliveapi.Checked;
            foreach (System.Windows.Forms.Control ctl in cfg_live.Controls)
                if (ctl.Name != "chk_usermsnliveapi") ctl.Enabled = AmIEnabled;
            Api_Variables.s_live = AmIEnabled;
            Api_Variables.s_lgh = chk_lgooglehack.Checked;
            Api_Variables.s_lkey = txt_lapikey.Text;
        }

        private void chk_useyahooapi_CheckedChanged(object sender, EventArgs e)
        {
            bool AmIEnabled = chk_useyahooapi.Checked;
            foreach (System.Windows.Forms.Control ctl in cfg_yahoo.Controls)
                if (ctl.Name != "chk_useyahooapi") ctl.Enabled = AmIEnabled;
            Api_Variables.s_yahoo = AmIEnabled;
            Api_Variables.s_ygh = chk_ygooglehack.Checked;
            Api_Variables.s_ykey = txt_yapikey.Text;
        }

        private void rdo_gapi_CheckedChanged(object sender, EventArgs e)
        {
            bool AmIEnabled = rdo_gapi.Checked;
            lbl_gapikey.Enabled = AmIEnabled;
            txt_gapikey.Enabled = AmIEnabled;
        }

        private void rdo_gaura_CheckedChanged(object sender, EventArgs e)
        {
            bool AmIEnabled = rdo_gapi.Checked;
            lbl_gapikey.Enabled = AmIEnabled;
            txt_gapikey.Enabled = AmIEnabled;
            if (AmIEnabled) Api_Variables.s_gaura = false;
            else Api_Variables.s_gaura = true;
        }

        private void frm_main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState) Hide();
        }

        private void ico_notify_DoubleClick(object sender, EventArgs e)
        {
            HideQsForm();
            ShowAbForm();
            //the_src = new frm_advresbrs(this);
            //the_src.Show();
        }

        private void mit_cfg_Click(object sender, EventArgs e)
        {
            ShowCfForm();
            //Show();
            //WindowState = FormWindowState.Normal;
        }

        private void mit_ext_Click(object sender, EventArgs e)
        {
            ShutMeDown();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            HideCfForm();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SaveTheConfig();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Config Saved");
            GetTheConfig();
            HideCfForm();
        }

        private void txt_gapikey_TextChanged(object sender, EventArgs e)
        {
            Api_Variables.s_gkey = txt_gapikey.Text;
        }

        private void txt_lapikey_TextChanged(object sender, EventArgs e)
        {
            Api_Variables.s_lkey = txt_lapikey.Text;
        }

        private void txt_yapikey_TextChanged(object sender, EventArgs e)
        {
            Api_Variables.s_ykey = txt_yapikey.Text;
        }

        private void mit_src_Click(object sender, EventArgs e)
        {
            ShowAbForm();
        }

        private void ico_notify_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString().ToLower() == "left" && e.Clicks > 1)
            {
                HideQsForm();
                ShowAbForm();
            }
            else if (e.Button.ToString().ToLower() == "left" && e.Clicks == 1)
            {
                ShowQsForm();
            }
            else return;
        }

        private void frm_main_Shown(object sender, EventArgs e)
        {
            btn_Cancel.PerformClick();
        }

        private void mit_Log_Click(object sender, EventArgs e)
        {
            ShowLfForm();
        }
        #endregion

        #region Utility Functions
        private void ShutMeDown()
        {
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Shutdown Event Triggered");
            HideAbForm();
            HideCfForm();
            HideQsForm();
            HideNsForm();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Stopping HTTP Server");
            g_HttpServer.StopTheServer();
            this.Dispose();
            Application.Exit();
        }

        public void StartTheServer()
        {
            g_HttpServer = new HttpServer(this);
            g_HttpServer.StartTheServer();
        }

        private void GetTheConfig()
        {
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
            if (this.g_google) this.chk_usegoogle.Checked = true;
            else this.chk_usegoogle.Checked = false;
            if (this.g_gaura)
            {
                this.rdo_gaura.Checked = true;
                this.rdo_gapi.Checked = false;
            }
            else
            {
                this.rdo_gaura.Checked = false;
                this.rdo_gapi.Checked = true;
            }
            if (this.g_ggh) chk_ggooglehack.Checked = true;
            else chk_ggooglehack.Checked = false;
            if (this.g_live) this.chk_usermsnliveapi.Checked = true;
            else this.chk_usermsnliveapi.Checked = false;
            if (this.g_lgh) chk_lgooglehack.Checked = true;
            else chk_lgooglehack.Checked = false;
            if (this.g_yahoo) this.chk_useyahooapi.Checked = true;
            else this.chk_useyahooapi.Checked = false;
            if (this.g_ygh) chk_ygooglehack.Checked = true;
            else chk_ygooglehack.Checked = false;
            this.txt_gapikey.Text = this.g_gkey;
            this.txt_lapikey.Text = this.g_lkey;
            this.txt_yapikey.Text = this.g_ykey;
            String sz_CC1 = "Current Google Config:GE:" + this.g_google.ToString() + ":GA:" + this.g_gaura.ToString() + ":GG:" + this.g_ggh.ToString();
            String sz_CC2 = "Current MSN Live Config:LE:" + this.g_live.ToString() + ":LG:" + this.g_lgh.ToString();
            String sz_CC3 = "Current Yahoo Config:YE:" + this.g_yahoo.ToString() + ":YG:" + this.g_ygh.ToString();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", sz_CC1);
            this.log_main.LogEvent("APP-MAIN", "DEBUG", sz_CC2);
            this.log_main.LogEvent("APP-MAIN", "DEBUG", sz_CC3);
        }

        private void SaveTheConfig()
        {
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Saving Config");
            String g_1 = "";
            String g_2 = "";
            String g_3 = "";
            String g_4 = "";
            String l_1 = "";
            String l_2 = "";
            String l_3 = "";
            String y_1 = "";
            String y_2 = "";
            String y_3 = "";
            // Get the google stuff...
            if (chk_usegoogle.Checked) g_1 = "1";
            else g_1 = "0";
            if (rdo_gaura.Checked) g_2 = "1";
            else g_2 = "0";
            if (chk_ggooglehack.Checked) g_3 = "1";
            else g_3 = "0";
            g_4 = txt_gapikey.Text;
            // Write the google stuff...
            RegSet("G_EN", g_1);
            RegSet("G_AU", g_2);
            RegSet("G_GH", g_3);
            RegSet("G_KY", g_4);
            // Get the Live Stuff...
            if (chk_usermsnliveapi.Checked) l_1 = "1";
            else l_1 = "0";
            if (chk_lgooglehack.Checked) l_2 = "1";
            else l_2 = "0";
            l_3 = txt_lapikey.Text;
            // Write the Live stuff...
            RegSet("L_EN", l_1);
            RegSet("L_GH", l_2);
            RegSet("L_KY", l_3);
            // Get the Yahoo Stuff...
            if (chk_useyahooapi.Checked) y_1 = "1";
            else y_1 = "0";
            if (chk_ygooglehack.Checked) y_2 = "1";
            else y_2 = "0";
            y_3 = txt_yapikey.Text;
            // Write the Yahoo stuff...
            RegSet("Y_EN", y_1);
            RegSet("Y_GH", y_2);
            RegSet("Y_KY", y_3);
        }

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

        #region Public Child Form Methods
        public void ShowAbForm()
        {
            if (!this.b_abshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Result Form Shown");
                this.Invoke(this.del_frm_show, new Object[] { this.the_src, true });
                this.b_abshow = true;
            }
        }
        public void HideAbForm()
        {
            if (this.b_abshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Result Form Hidden");
                this.Invoke(this.del_frm_show, new Object[] { this.the_src, false });
                this.b_abshow = false;
            }
        }
        public void ShowLfForm()
        {
            if (!this.b_lfshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Log Viewer Form Shown");
                this.Invoke(this.del_frm_show, new Object[] { this.the_log, true });
                this.b_lfshow = true;
            }
        }
        public void HideLfForm()
        {
            if (this.b_lfshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Log Viewer Form Hidden");
                this.Invoke(this.del_frm_show, new Object[] { this.the_log, false });
                this.b_lfshow = false;
            }
        }
        public void ShowQsForm()
        {
            if (!this.b_qsshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Quick Search Form Shown");
                System.Drawing.Size s_win = SystemInformation.PrimaryMonitorMaximizedWindowSize;
                int n_w = s_win.Width;
                int n_h = s_win.Height;
                n_w = n_w - this.the_qus.Width - 10;
                n_h = n_h - this.the_qus.Height - 10;
                this.Invoke(this.del_frm_xany, new Object[] { this.the_qus, n_w, n_h });
                this.Invoke(this.del_frm_show, new Object[] { this.the_qus, true });
                this.b_qsshow = true;
            }
        }
        public void HideQsForm()
        {
            if (this.b_qsshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Quick Search Form Hidden");
                this.Invoke(this.del_frm_show, new Object[] { this.the_qus, false });
                this.b_qsshow = false;
            }
        }
        public void ShowNfForm()
        {
            if (!this.b_nfshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Notify Form Shown");
                System.Drawing.Size s_win = SystemInformation.PrimaryMonitorMaximizedWindowSize;
                int n_w = s_win.Width;
                int n_h = s_win.Height;
                n_w = n_w - this.the_not.Width - 10;
                n_h = n_h - this.the_not.Height - 10;
                this.Invoke(this.del_frm_xany, new Object[] { this.the_not, n_w, n_h });
                this.Invoke(this.del_frm_show, new Object[] { this.the_not, true });
                this.b_nfshow = true;
            }
        }
        public void HideNsForm()
        {
            if (this.b_nfshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Notify Form Hidden");
                this.Invoke(this.del_frm_show, new Object[] { this.the_not, false });
                this.b_nfshow = false;
            }
        }
        public void HideCfForm()
        {
            if (this.b_cfshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Config Form Hidden");
                this.Hide();
                this.Visible = false;
                this.b_cfshow = false;
                WindowState = FormWindowState.Minimized;
            }
        }
        public void ShowCfForm()
        {
            if (!this.b_cfshow)
            {
                this.log_main.LogEvent("APP-MAIN", "DEBUG", "Config Form Shown");
                WindowState = FormWindowState.Normal;
                System.Drawing.Size s_win = SystemInformation.PrimaryMonitorMaximizedWindowSize;
                int n_w = s_win.Width;
                int n_h = s_win.Height;
                n_w = n_w - this.Width - 10;
                n_h = n_h - this.Height - 10;
                this.Top = n_h;
                this.Left = n_w;
                this.Show();
                this.Visible = true;
                this.b_cfshow = true;
            }
        }
        public void StartQsSearch(String the_query)
        {
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "New Search - " + the_query);
            HideQsForm();
            ShowNfForm();
            this.sz_not_label = "SensePost SPUD : Searching... " + the_query;
            //the_not.TextToDisplay = "Searching...";
            //ShowAbForm();
            this.log_main.LogEvent("APP-MAIN", "DEBUG", "Starting SOAP Search Process");
            this.the_src.StartSearching(the_query);
           
        }
        public void LogTheEvent(String s_s, String s_l, String s_d)
        {
            this.log_main.LogEvent(s_s, s_l, s_d);
        }
        #endregion

        #region Public Properties
        #region Read-Write Properties
        public bool ShowingQuickSearchDialog
        {
            get { return this.b_qsshow; }
            set { this.b_qsshow = value; }
        }
        public bool ShowingNotifyDialog
        {
            get { return this.b_nfshow; }
            set { this.b_nfshow = value; }
        }
        public bool ShowingBrowserDialig
        {
            get { return this.b_abshow; }
            set { this.b_abshow = value; }
        }
        public int ResultStart
        {
            get { return this.n_start; }
            set { this.n_start = value; }
        }
        public int ResultLength
        {
            get { return this.n_length; }
            set { this.n_length = value; }
        }
        public String ResultQuery
        {
            get { return this.sz_query; }
            set { this.sz_query = value; }
        }
        public String NotifyText
        {
            get { return this.sz_not_label; }
            set { this.sz_not_label = value; }
        }
        #endregion

        #region Read-Only Properties
        public Boolean UseGoogle
        {
            get { return this.g_google; }
        }

        public Boolean UseLive
        {
            get { return this.g_live; }
        }

        public Boolean UseYahoo
        {
            get { return this.g_yahoo; }
        }
        #endregion
        #endregion

        #region Delegate Targets
        private void Dtg_Frm_Shw(System.Windows.Forms.Form myctl, bool myshw)
        {
            if (myshw) myctl.Show();
            else myctl.Hide();
        }

        private void Dtg_Frm_XnY(System.Windows.Forms.Form myctl, int x, int y)
        {
            myctl.Top = y;
            myctl.Left = x;
        }

        private void Dtg_Frm_Foc(System.Windows.Forms.Form myctl)
        {
            myctl.Focus();
        }
        #endregion

        #region Keyboard Hooks
        private void kh_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            if (e.KeyName.ToLower() == "f11") this.ShowQsForm();
            else if (e.KeyName.ToLower() == "f12") this.ShowAbForm();
        }
        #endregion

    }
}