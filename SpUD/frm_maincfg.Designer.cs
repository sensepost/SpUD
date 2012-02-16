namespace com.sensepost.SPUD
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_configmain = new System.Windows.Forms.Panel();
            this.pnl_cfgpage = new System.Windows.Forms.TabControl();
            this.cfg_google = new System.Windows.Forms.TabPage();
            this.chk_usegoogle = new DotNetSkin.SkinControls.SkinCheckBox();
            this.chk_ggooglehack = new DotNetSkin.SkinControls.SkinCheckBox();
            this.grp_gapi = new System.Windows.Forms.GroupBox();
            this.txt_gapikey = new System.Windows.Forms.TextBox();
            this.lbl_gapikey = new System.Windows.Forms.Label();
            this.rdo_gaura = new DotNetSkin.SkinControls.SkinRadioButton();
            this.rdo_gapi = new DotNetSkin.SkinControls.SkinRadioButton();
            this.cfg_live = new System.Windows.Forms.TabPage();
            this.chk_lgooglehack = new DotNetSkin.SkinControls.SkinCheckBox();
            this.grp_lapi = new System.Windows.Forms.GroupBox();
            this.txt_lapikey = new System.Windows.Forms.TextBox();
            this.lbl_lapikey = new System.Windows.Forms.Label();
            this.chk_usermsnliveapi = new DotNetSkin.SkinControls.SkinCheckBox();
            this.cfg_yahoo = new System.Windows.Forms.TabPage();
            this.chk_ygooglehack = new DotNetSkin.SkinControls.SkinCheckBox();
            this.grp_yapi = new System.Windows.Forms.GroupBox();
            this.txt_yapikey = new System.Windows.Forms.TextBox();
            this.lbl_yapikey = new System.Windows.Forms.Label();
            this.chk_useyahooapi = new DotNetSkin.SkinControls.SkinCheckBox();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ico_notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.men_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mit_src = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mit_cfg = new System.Windows.Forms.ToolStripMenuItem();
            this.mit_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mit_ext = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_main.SuspendLayout();
            this.pnl_configmain.SuspendLayout();
            this.pnl_cfgpage.SuspendLayout();
            this.cfg_google.SuspendLayout();
            this.grp_gapi.SuspendLayout();
            this.cfg_live.SuspendLayout();
            this.grp_lapi.SuspendLayout();
            this.cfg_yahoo.SuspendLayout();
            this.grp_yapi.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.men_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pnl_configmain);
            this.pnl_main.Controls.Add(this.pnl_Bottom);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(413, 244);
            this.pnl_main.TabIndex = 0;
            // 
            // pnl_configmain
            // 
            this.pnl_configmain.Controls.Add(this.pnl_cfgpage);
            this.pnl_configmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_configmain.Location = new System.Drawing.Point(0, 0);
            this.pnl_configmain.Name = "pnl_configmain";
            this.pnl_configmain.Size = new System.Drawing.Size(413, 208);
            this.pnl_configmain.TabIndex = 2;
            // 
            // pnl_cfgpage
            // 
            this.pnl_cfgpage.Controls.Add(this.cfg_google);
            this.pnl_cfgpage.Controls.Add(this.cfg_live);
            this.pnl_cfgpage.Controls.Add(this.cfg_yahoo);
            this.pnl_cfgpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cfgpage.Location = new System.Drawing.Point(0, 0);
            this.pnl_cfgpage.Name = "pnl_cfgpage";
            this.pnl_cfgpage.SelectedIndex = 0;
            this.pnl_cfgpage.Size = new System.Drawing.Size(413, 208);
            this.pnl_cfgpage.TabIndex = 0;
            // 
            // cfg_google
            // 
            this.cfg_google.BackColor = System.Drawing.SystemColors.Control;
            this.cfg_google.Controls.Add(this.chk_usegoogle);
            this.cfg_google.Controls.Add(this.chk_ggooglehack);
            this.cfg_google.Controls.Add(this.grp_gapi);
            this.cfg_google.Controls.Add(this.rdo_gaura);
            this.cfg_google.Controls.Add(this.rdo_gapi);
            this.cfg_google.Location = new System.Drawing.Point(4, 22);
            this.cfg_google.Name = "cfg_google";
            this.cfg_google.Padding = new System.Windows.Forms.Padding(3);
            this.cfg_google.Size = new System.Drawing.Size(405, 182);
            this.cfg_google.TabIndex = 0;
            this.cfg_google.Text = "Google API";
            // 
            // chk_usegoogle
            // 
            this.chk_usegoogle.AutoSize = true;
            this.chk_usegoogle.BackColor = System.Drawing.Color.Transparent;
            this.chk_usegoogle.Checked = true;
            this.chk_usegoogle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_usegoogle.Location = new System.Drawing.Point(6, 6);
            this.chk_usegoogle.Name = "chk_usegoogle";
            this.chk_usegoogle.Size = new System.Drawing.Size(120, 17);
            this.chk_usegoogle.TabIndex = 0;
            this.chk_usegoogle.Text = "Use the Google API";
            this.chk_usegoogle.UseVisualStyleBackColor = true;
            this.chk_usegoogle.CheckedChanged += new System.EventHandler(this.chk_usegoogle_CheckedChanged);
            // 
            // chk_ggooglehack
            // 
            this.chk_ggooglehack.AutoSize = true;
            this.chk_ggooglehack.BackColor = System.Drawing.Color.Transparent;
            this.chk_ggooglehack.Checked = true;
            this.chk_ggooglehack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ggooglehack.Location = new System.Drawing.Point(6, 141);
            this.chk_ggooglehack.Name = "chk_ggooglehack";
            this.chk_ggooglehack.Size = new System.Drawing.Size(210, 17);
            this.chk_ggooglehack.TabIndex = 5;
            this.chk_ggooglehack.Text = "This API is suitable for Google Hacking";
            this.chk_ggooglehack.UseVisualStyleBackColor = true;
            // 
            // grp_gapi
            // 
            this.grp_gapi.Controls.Add(this.txt_gapikey);
            this.grp_gapi.Controls.Add(this.lbl_gapikey);
            this.grp_gapi.Location = new System.Drawing.Point(6, 75);
            this.grp_gapi.Name = "grp_gapi";
            this.grp_gapi.Size = new System.Drawing.Size(391, 60);
            this.grp_gapi.TabIndex = 3;
            this.grp_gapi.TabStop = false;
            this.grp_gapi.Text = "Google API Key Settings";
            // 
            // txt_gapikey
            // 
            this.txt_gapikey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gapikey.Enabled = false;
            this.txt_gapikey.Location = new System.Drawing.Point(139, 23);
            this.txt_gapikey.Name = "txt_gapikey";
            this.txt_gapikey.Size = new System.Drawing.Size(228, 20);
            this.txt_gapikey.TabIndex = 4;
            this.txt_gapikey.Text = "Your Google API Key here...";
            this.txt_gapikey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_gapikey.TextChanged += new System.EventHandler(this.txt_gapikey_TextChanged);
            // 
            // lbl_gapikey
            // 
            this.lbl_gapikey.AutoSize = true;
            this.lbl_gapikey.Enabled = false;
            this.lbl_gapikey.Location = new System.Drawing.Point(6, 26);
            this.lbl_gapikey.Name = "lbl_gapikey";
            this.lbl_gapikey.Size = new System.Drawing.Size(102, 13);
            this.lbl_gapikey.TabIndex = 0;
            this.lbl_gapikey.Text = "My Google API Key:";
            // 
            // rdo_gaura
            // 
            this.rdo_gaura.AutoSize = true;
            this.rdo_gaura.BackColor = System.Drawing.Color.Transparent;
            this.rdo_gaura.Checked = true;
            this.rdo_gaura.Location = new System.Drawing.Point(6, 29);
            this.rdo_gaura.Name = "rdo_gaura";
            this.rdo_gaura.Size = new System.Drawing.Size(168, 17);
            this.rdo_gaura.TabIndex = 1;
            this.rdo_gaura.TabStop = true;
            this.rdo_gaura.Text = "I Dont have a Google API Key";
            this.rdo_gaura.UseVisualStyleBackColor = true;
            this.rdo_gaura.CheckedChanged += new System.EventHandler(this.rdo_gaura_CheckedChanged);
            // 
            // rdo_gapi
            // 
            this.rdo_gapi.AutoSize = true;
            this.rdo_gapi.BackColor = System.Drawing.Color.Transparent;
            this.rdo_gapi.Location = new System.Drawing.Point(6, 52);
            this.rdo_gapi.Name = "rdo_gapi";
            this.rdo_gapi.Size = new System.Drawing.Size(144, 17);
            this.rdo_gapi.TabIndex = 2;
            this.rdo_gapi.Text = "I Have a Google API Key";
            this.rdo_gapi.UseVisualStyleBackColor = true;
            this.rdo_gapi.CheckedChanged += new System.EventHandler(this.rdo_gapi_CheckedChanged);
            // 
            // cfg_live
            // 
            this.cfg_live.BackColor = System.Drawing.SystemColors.Control;
            this.cfg_live.Controls.Add(this.chk_lgooglehack);
            this.cfg_live.Controls.Add(this.grp_lapi);
            this.cfg_live.Controls.Add(this.chk_usermsnliveapi);
            this.cfg_live.Location = new System.Drawing.Point(4, 22);
            this.cfg_live.Name = "cfg_live";
            this.cfg_live.Padding = new System.Windows.Forms.Padding(3);
            this.cfg_live.Size = new System.Drawing.Size(405, 182);
            this.cfg_live.TabIndex = 1;
            this.cfg_live.Text = "MSN Live Search API";
            // 
            // chk_lgooglehack
            // 
            this.chk_lgooglehack.AutoSize = true;
            this.chk_lgooglehack.BackColor = System.Drawing.Color.Transparent;
            this.chk_lgooglehack.Location = new System.Drawing.Point(6, 95);
            this.chk_lgooglehack.Name = "chk_lgooglehack";
            this.chk_lgooglehack.Size = new System.Drawing.Size(210, 17);
            this.chk_lgooglehack.TabIndex = 4;
            this.chk_lgooglehack.Text = "This API is suitable for Google Hacking";
            this.chk_lgooglehack.UseVisualStyleBackColor = true;
            // 
            // grp_lapi
            // 
            this.grp_lapi.Controls.Add(this.txt_lapikey);
            this.grp_lapi.Controls.Add(this.lbl_lapikey);
            this.grp_lapi.Location = new System.Drawing.Point(6, 29);
            this.grp_lapi.Name = "grp_lapi";
            this.grp_lapi.Size = new System.Drawing.Size(391, 60);
            this.grp_lapi.TabIndex = 2;
            this.grp_lapi.TabStop = false;
            this.grp_lapi.Text = "MSN Live Search API Key Settings";
            // 
            // txt_lapikey
            // 
            this.txt_lapikey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lapikey.Location = new System.Drawing.Point(139, 23);
            this.txt_lapikey.Name = "txt_lapikey";
            this.txt_lapikey.Size = new System.Drawing.Size(228, 20);
            this.txt_lapikey.TabIndex = 3;
            this.txt_lapikey.Text = "Your MSN Live Search API Key here...";
            this.txt_lapikey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lapikey.TextChanged += new System.EventHandler(this.txt_lapikey_TextChanged);
            // 
            // lbl_lapikey
            // 
            this.lbl_lapikey.AutoSize = true;
            this.lbl_lapikey.Location = new System.Drawing.Point(6, 26);
            this.lbl_lapikey.Name = "lbl_lapikey";
            this.lbl_lapikey.Size = new System.Drawing.Size(88, 13);
            this.lbl_lapikey.TabIndex = 0;
            this.lbl_lapikey.Text = "My Live API Key:";
            // 
            // chk_usermsnliveapi
            // 
            this.chk_usermsnliveapi.AutoSize = true;
            this.chk_usermsnliveapi.BackColor = System.Drawing.Color.Transparent;
            this.chk_usermsnliveapi.Checked = true;
            this.chk_usermsnliveapi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_usermsnliveapi.Location = new System.Drawing.Point(6, 6);
            this.chk_usermsnliveapi.Name = "chk_usermsnliveapi";
            this.chk_usermsnliveapi.Size = new System.Drawing.Size(170, 17);
            this.chk_usermsnliveapi.TabIndex = 1;
            this.chk_usermsnliveapi.Text = "Use the MSN Live Search API";
            this.chk_usermsnliveapi.UseVisualStyleBackColor = true;
            this.chk_usermsnliveapi.CheckedChanged += new System.EventHandler(this.chk_usermsnliveapi_CheckedChanged);
            // 
            // cfg_yahoo
            // 
            this.cfg_yahoo.BackColor = System.Drawing.SystemColors.Control;
            this.cfg_yahoo.Controls.Add(this.chk_ygooglehack);
            this.cfg_yahoo.Controls.Add(this.grp_yapi);
            this.cfg_yahoo.Controls.Add(this.chk_useyahooapi);
            this.cfg_yahoo.Location = new System.Drawing.Point(4, 22);
            this.cfg_yahoo.Name = "cfg_yahoo";
            this.cfg_yahoo.Size = new System.Drawing.Size(405, 182);
            this.cfg_yahoo.TabIndex = 2;
            this.cfg_yahoo.Text = "Yahoo! API!";
            // 
            // chk_ygooglehack
            // 
            this.chk_ygooglehack.AutoSize = true;
            this.chk_ygooglehack.BackColor = System.Drawing.Color.Transparent;
            this.chk_ygooglehack.Checked = true;
            this.chk_ygooglehack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ygooglehack.Location = new System.Drawing.Point(6, 95);
            this.chk_ygooglehack.Name = "chk_ygooglehack";
            this.chk_ygooglehack.Size = new System.Drawing.Size(210, 17);
            this.chk_ygooglehack.TabIndex = 3;
            this.chk_ygooglehack.Text = "This API is suitable for Google Hacking";
            this.chk_ygooglehack.UseVisualStyleBackColor = true;
            // 
            // grp_yapi
            // 
            this.grp_yapi.Controls.Add(this.txt_yapikey);
            this.grp_yapi.Controls.Add(this.lbl_yapikey);
            this.grp_yapi.Location = new System.Drawing.Point(6, 29);
            this.grp_yapi.Name = "grp_yapi";
            this.grp_yapi.Size = new System.Drawing.Size(391, 60);
            this.grp_yapi.TabIndex = 1;
            this.grp_yapi.TabStop = false;
            this.grp_yapi.Text = "Yahoo! API! Key! Settings!";
            // 
            // txt_yapikey
            // 
            this.txt_yapikey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yapikey.Location = new System.Drawing.Point(139, 23);
            this.txt_yapikey.Name = "txt_yapikey";
            this.txt_yapikey.Size = new System.Drawing.Size(228, 20);
            this.txt_yapikey.TabIndex = 2;
            this.txt_yapikey.Text = "Your! Yahoo! API! Key! Here!...";
            this.txt_yapikey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_yapikey.TextChanged += new System.EventHandler(this.txt_yapikey_TextChanged);
            // 
            // lbl_yapikey
            // 
            this.lbl_yapikey.AutoSize = true;
            this.lbl_yapikey.Location = new System.Drawing.Point(6, 26);
            this.lbl_yapikey.Name = "lbl_yapikey";
            this.lbl_yapikey.Size = new System.Drawing.Size(111, 13);
            this.lbl_yapikey.TabIndex = 0;
            this.lbl_yapikey.Text = "My! Yahoo! API! Key!:";
            // 
            // chk_useyahooapi
            // 
            this.chk_useyahooapi.AutoSize = true;
            this.chk_useyahooapi.BackColor = System.Drawing.Color.Transparent;
            this.chk_useyahooapi.Checked = true;
            this.chk_useyahooapi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_useyahooapi.Location = new System.Drawing.Point(6, 6);
            this.chk_useyahooapi.Name = "chk_useyahooapi";
            this.chk_useyahooapi.Size = new System.Drawing.Size(127, 17);
            this.chk_useyahooapi.TabIndex = 0;
            this.chk_useyahooapi.Text = "Use! the! yahoo! API!";
            this.chk_useyahooapi.UseVisualStyleBackColor = true;
            this.chk_useyahooapi.CheckedChanged += new System.EventHandler(this.chk_useyahooapi_CheckedChanged);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Bottom.Controls.Add(this.btn_Cancel);
            this.pnl_Bottom.Controls.Add(this.btn_OK);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 208);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(413, 36);
            this.pnl_Bottom.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(335, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(254, 6);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "My Live API Key:";
            // 
            // ico_notify
            // 
            this.ico_notify.BalloonTipText = "SensePost Unified Discovery";
            this.ico_notify.BalloonTipTitle = "SensePost Unified Discovery";
            this.ico_notify.ContextMenuStrip = this.men_main;
            this.ico_notify.Icon = ((System.Drawing.Icon)(resources.GetObject("ico_notify.Icon")));
            this.ico_notify.Text = "SensePost Unified Discovery";
            this.ico_notify.Visible = true;
            this.ico_notify.DoubleClick += new System.EventHandler(this.ico_notify_DoubleClick);
            this.ico_notify.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ico_notify_MouseDown);
            // 
            // men_main
            // 
            this.men_main.BackColor = System.Drawing.SystemColors.Control;
            this.men_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mit_src,
            this.toolStripMenuItem3,
            this.mit_cfg,
            this.mit_Log,
            this.toolStripMenuItem1,
            this.mit_ext});
            this.men_main.Name = "men_main";
            this.men_main.Size = new System.Drawing.Size(149, 104);
            // 
            // mit_src
            // 
            this.mit_src.Name = "mit_src";
            this.mit_src.Size = new System.Drawing.Size(148, 22);
            this.mit_src.Text = "Search... [F12]";
            this.mit_src.Click += new System.EventHandler(this.mit_src_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // mit_cfg
            // 
            this.mit_cfg.Name = "mit_cfg";
            this.mit_cfg.Size = new System.Drawing.Size(148, 22);
            this.mit_cfg.Text = "Configure SPUD";
            this.mit_cfg.Click += new System.EventHandler(this.mit_cfg_Click);
            // 
            // mit_Log
            // 
            this.mit_Log.Name = "mit_Log";
            this.mit_Log.Size = new System.Drawing.Size(148, 22);
            this.mit_Log.Text = "View Log File";
            this.mit_Log.Click += new System.EventHandler(this.mit_Log_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // mit_ext
            // 
            this.mit_ext.Name = "mit_ext";
            this.mit_ext.Size = new System.Drawing.Size(148, 22);
            this.mit_ext.Text = "Exit";
            this.mit_ext.Click += new System.EventHandler(this.mit_ext_Click);
            // 
            // frm_main
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(413, 244);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.Opacity = 0.75;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SPUD";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.frm_main_Resize);
            this.Shown += new System.EventHandler(this.frm_main_Shown);
            this.pnl_main.ResumeLayout(false);
            this.pnl_configmain.ResumeLayout(false);
            this.pnl_cfgpage.ResumeLayout(false);
            this.cfg_google.ResumeLayout(false);
            this.cfg_google.PerformLayout();
            this.grp_gapi.ResumeLayout(false);
            this.grp_gapi.PerformLayout();
            this.cfg_live.ResumeLayout(false);
            this.cfg_live.PerformLayout();
            this.grp_lapi.ResumeLayout(false);
            this.grp_lapi.PerformLayout();
            this.cfg_yahoo.ResumeLayout(false);
            this.cfg_yahoo.PerformLayout();
            this.grp_yapi.ResumeLayout(false);
            this.grp_yapi.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.men_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_configmain;
        private System.Windows.Forms.TabControl pnl_cfgpage;
        private System.Windows.Forms.TabPage cfg_google;
        private DotNetSkin.SkinControls.SkinCheckBox chk_ggooglehack;
        private System.Windows.Forms.GroupBox grp_gapi;
        private System.Windows.Forms.TextBox txt_gapikey;
        private System.Windows.Forms.Label lbl_gapikey;
        private DotNetSkin.SkinControls.SkinRadioButton rdo_gaura;
        private DotNetSkin.SkinControls.SkinRadioButton rdo_gapi;
        private System.Windows.Forms.TabPage cfg_live;
        private System.Windows.Forms.TabPage cfg_yahoo;
        private System.Windows.Forms.Panel pnl_Bottom;
        private DotNetSkin.SkinControls.SkinCheckBox chk_usegoogle;
        private DotNetSkin.SkinControls.SkinCheckBox chk_lgooglehack;
        private System.Windows.Forms.GroupBox grp_lapi;
        private System.Windows.Forms.TextBox txt_lapikey;
        private System.Windows.Forms.Label lbl_lapikey;
        private DotNetSkin.SkinControls.SkinCheckBox chk_usermsnliveapi;
        private DotNetSkin.SkinControls.SkinCheckBox chk_ygooglehack;
        private System.Windows.Forms.GroupBox grp_yapi;
        private System.Windows.Forms.TextBox txt_yapikey;
        private System.Windows.Forms.Label lbl_yapikey;
        private DotNetSkin.SkinControls.SkinCheckBox chk_useyahooapi;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.NotifyIcon ico_notify;
        private System.Windows.Forms.ContextMenuStrip men_main;
        private System.Windows.Forms.ToolStripMenuItem mit_cfg;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mit_ext;
        private System.Windows.Forms.ToolStripMenuItem mit_src;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mit_Log;
    }
}

