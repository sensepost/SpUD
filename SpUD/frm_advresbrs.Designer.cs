namespace com.sensepost.SPUD
{
    partial class frm_advresbrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_advresbrs));
            this.pnl_searchbar = new System.Windows.Forms.Panel();
            this.pbx_loading = new System.Windows.Forms.PictureBox();
            this.btn_goforit = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.tpnl_results = new System.Windows.Forms.TabControl();
            this.tpg_web = new System.Windows.Forms.TabPage();
            this.tpg_list = new System.Windows.Forms.TabPage();
            this.lvw_results = new System.Windows.Forms.ListView();
            this.col_source = new System.Windows.Forms.ColumnHeader();
            this.col_title = new System.Windows.Forms.ColumnHeader();
            this.col_url = new System.Windows.Forms.ColumnHeader();
            this.col_snippet = new System.Windows.Forms.ColumnHeader();
            this.col_cache = new System.Windows.Forms.ColumnHeader();
            this.col_stat = new System.Windows.Forms.ColumnHeader();
            this.pnl_srcopt = new System.Windows.Forms.Panel();
            this.tpnl_opt = new System.Windows.Forms.TableLayoutPanel();
            this.chk_google = new DotNetSkin.SkinControls.SkinCheckBox();
            this.chk_live = new DotNetSkin.SkinControls.SkinCheckBox();
            this.chk_yahoo = new DotNetSkin.SkinControls.SkinCheckBox();
            this.lbl_google = new System.Windows.Forms.Label();
            this.lbl_live = new System.Windows.Forms.Label();
            this.lbl_yahoo = new System.Windows.Forms.Label();
            this.lbl_rpq = new System.Windows.Forms.Label();
            this.nud_rpq = new System.Windows.Forms.NumericUpDown();
            this.tpnl_nap = new System.Windows.Forms.TableLayoutPanel();
            this.btn_next = new DotNetSkin.SkinControls.SkinButtonGreen();
            this.btn_prev = new DotNetSkin.SkinControls.SkinButtonRed();
            this.pnl_searchbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).BeginInit();
            this.tpnl_results.SuspendLayout();
            this.tpg_list.SuspendLayout();
            this.pnl_srcopt.SuspendLayout();
            this.tpnl_opt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rpq)).BeginInit();
            this.tpnl_nap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_searchbar
            // 
            this.pnl_searchbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_searchbar.Controls.Add(this.pbx_loading);
            this.pnl_searchbar.Controls.Add(this.btn_goforit);
            this.pnl_searchbar.Controls.Add(this.txt_search);
            this.pnl_searchbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_searchbar.MaximumSize = new System.Drawing.Size(65532, 24);
            this.pnl_searchbar.Name = "pnl_searchbar";
            this.pnl_searchbar.Size = new System.Drawing.Size(905, 24);
            this.pnl_searchbar.TabIndex = 0;
            // 
            // pbx_loading
            // 
            this.pbx_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_loading.BackgroundImage = global::com.sensepost.SPUD.res_images.waiting;
            this.pbx_loading.Image = global::com.sensepost.SPUD.res_images.waiting;
            this.pbx_loading.InitialImage = global::com.sensepost.SPUD.res_images.waiting;
            this.pbx_loading.Location = new System.Drawing.Point(882, 0);
            this.pbx_loading.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_loading.Name = "pbx_loading";
            this.pbx_loading.Size = new System.Drawing.Size(23, 23);
            this.pbx_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_loading.TabIndex = 2;
            this.pbx_loading.TabStop = false;
            // 
            // btn_goforit
            // 
            this.btn_goforit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_goforit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_goforit.Enabled = false;
            this.btn_goforit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goforit.Location = new System.Drawing.Point(774, 0);
            this.btn_goforit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_goforit.Name = "btn_goforit";
            this.btn_goforit.Size = new System.Drawing.Size(105, 23);
            this.btn_goforit.TabIndex = 1;
            this.btn_goforit.Text = "Go...";
            this.btn_goforit.UseVisualStyleBackColor = false;
            this.btn_goforit.Click += new System.EventHandler(this.btn_goforit_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Location = new System.Drawing.Point(0, 0);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(768, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // tpnl_results
            // 
            this.tpnl_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tpnl_results.Controls.Add(this.tpg_web);
            this.tpnl_results.Controls.Add(this.tpg_list);
            this.tpnl_results.Location = new System.Drawing.Point(0, 96);
            this.tpnl_results.Name = "tpnl_results";
            this.tpnl_results.SelectedIndex = 0;
            this.tpnl_results.Size = new System.Drawing.Size(905, 354);
            this.tpnl_results.TabIndex = 1;
            // 
            // tpg_web
            // 
            this.tpg_web.AutoScroll = true;
            this.tpg_web.BackColor = System.Drawing.Color.White;
            this.tpg_web.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpg_web.Location = new System.Drawing.Point(4, 22);
            this.tpg_web.Name = "tpg_web";
            this.tpg_web.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_web.Size = new System.Drawing.Size(897, 328);
            this.tpg_web.TabIndex = 0;
            this.tpg_web.Text = "Web View";
            // 
            // tpg_list
            // 
            this.tpg_list.Controls.Add(this.lvw_results);
            this.tpg_list.Location = new System.Drawing.Point(4, 22);
            this.tpg_list.Name = "tpg_list";
            this.tpg_list.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_list.Size = new System.Drawing.Size(897, 328);
            this.tpg_list.TabIndex = 1;
            this.tpg_list.Text = "List View";
            this.tpg_list.UseVisualStyleBackColor = true;
            // 
            // lvw_results
            // 
            this.lvw_results.AllowColumnReorder = true;
            this.lvw_results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvw_results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_source,
            this.col_title,
            this.col_url,
            this.col_snippet,
            this.col_cache,
            this.col_stat});
            this.lvw_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_results.FullRowSelect = true;
            this.lvw_results.GridLines = true;
            this.lvw_results.Location = new System.Drawing.Point(3, 3);
            this.lvw_results.MultiSelect = false;
            this.lvw_results.Name = "lvw_results";
            this.lvw_results.Size = new System.Drawing.Size(891, 322);
            this.lvw_results.TabIndex = 1;
            this.lvw_results.UseCompatibleStateImageBehavior = false;
            this.lvw_results.View = System.Windows.Forms.View.Details;
            this.lvw_results.DoubleClick += new System.EventHandler(this.lvw_results_DoubleClick);
            this.lvw_results.Resize += new System.EventHandler(this.lvw_results_Resize);
            this.lvw_results.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvw_results_ColumnClick);
            // 
            // col_source
            // 
            this.col_source.Text = "Source";
            this.col_source.Width = 50;
            // 
            // col_title
            // 
            this.col_title.Text = "Title";
            this.col_title.Width = 200;
            // 
            // col_url
            // 
            this.col_url.Text = "URL";
            this.col_url.Width = 200;
            // 
            // col_snippet
            // 
            this.col_snippet.Text = "Snippet";
            this.col_snippet.Width = 354;
            // 
            // col_cache
            // 
            this.col_cache.Text = "Cache Size";
            this.col_cache.Width = 85;
            // 
            // col_stat
            // 
            this.col_stat.Width = 0;
            // 
            // pnl_srcopt
            // 
            this.pnl_srcopt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_srcopt.Controls.Add(this.tpnl_opt);
            this.pnl_srcopt.Location = new System.Drawing.Point(0, 24);
            this.pnl_srcopt.MaximumSize = new System.Drawing.Size(65532, 72);
            this.pnl_srcopt.Name = "pnl_srcopt";
            this.pnl_srcopt.Size = new System.Drawing.Size(905, 72);
            this.pnl_srcopt.TabIndex = 2;
            // 
            // tpnl_opt
            // 
            this.tpnl_opt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tpnl_opt.ColumnCount = 3;
            this.tpnl_opt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tpnl_opt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tpnl_opt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tpnl_opt.Controls.Add(this.chk_google, 0, 0);
            this.tpnl_opt.Controls.Add(this.chk_live, 0, 1);
            this.tpnl_opt.Controls.Add(this.chk_yahoo, 0, 2);
            this.tpnl_opt.Controls.Add(this.lbl_google, 1, 0);
            this.tpnl_opt.Controls.Add(this.lbl_live, 1, 1);
            this.tpnl_opt.Controls.Add(this.lbl_yahoo, 1, 2);
            this.tpnl_opt.Controls.Add(this.lbl_rpq, 2, 0);
            this.tpnl_opt.Controls.Add(this.nud_rpq, 2, 1);
            this.tpnl_opt.Controls.Add(this.tpnl_nap, 2, 2);
            this.tpnl_opt.Location = new System.Drawing.Point(0, 0);
            this.tpnl_opt.Margin = new System.Windows.Forms.Padding(0);
            this.tpnl_opt.MaximumSize = new System.Drawing.Size(65532, 72);
            this.tpnl_opt.Name = "tpnl_opt";
            this.tpnl_opt.RowCount = 3;
            this.tpnl_opt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpnl_opt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpnl_opt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpnl_opt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnl_opt.Size = new System.Drawing.Size(905, 72);
            this.tpnl_opt.TabIndex = 0;
            // 
            // chk_google
            // 
            this.chk_google.AutoSize = true;
            this.chk_google.BackColor = System.Drawing.Color.Transparent;
            this.chk_google.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk_google.Location = new System.Drawing.Point(0, 0);
            this.chk_google.Margin = new System.Windows.Forms.Padding(0);
            this.chk_google.Name = "chk_google";
            this.chk_google.Size = new System.Drawing.Size(301, 24);
            this.chk_google.TabIndex = 0;
            this.chk_google.Text = "Show Google Results";
            this.chk_google.UseVisualStyleBackColor = true;
            this.chk_google.CheckedChanged += new System.EventHandler(this.ResultFilter);
            // 
            // chk_live
            // 
            this.chk_live.AutoSize = true;
            this.chk_live.BackColor = System.Drawing.Color.Transparent;
            this.chk_live.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk_live.Location = new System.Drawing.Point(0, 24);
            this.chk_live.Margin = new System.Windows.Forms.Padding(0);
            this.chk_live.Name = "chk_live";
            this.chk_live.Size = new System.Drawing.Size(301, 24);
            this.chk_live.TabIndex = 1;
            this.chk_live.Text = "Show MSN Live Results";
            this.chk_live.UseVisualStyleBackColor = true;
            this.chk_live.CheckedChanged += new System.EventHandler(this.ResultFilter);
            // 
            // chk_yahoo
            // 
            this.chk_yahoo.AutoSize = true;
            this.chk_yahoo.BackColor = System.Drawing.Color.Transparent;
            this.chk_yahoo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk_yahoo.Location = new System.Drawing.Point(0, 48);
            this.chk_yahoo.Margin = new System.Windows.Forms.Padding(0);
            this.chk_yahoo.Name = "chk_yahoo";
            this.chk_yahoo.Size = new System.Drawing.Size(301, 24);
            this.chk_yahoo.TabIndex = 2;
            this.chk_yahoo.Text = "Show! Yahoo! Results!";
            this.chk_yahoo.UseVisualStyleBackColor = true;
            this.chk_yahoo.CheckedChanged += new System.EventHandler(this.ResultFilter);
            // 
            // lbl_google
            // 
            this.lbl_google.AutoSize = true;
            this.lbl_google.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_google.Location = new System.Drawing.Point(301, 0);
            this.lbl_google.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_google.Name = "lbl_google";
            this.lbl_google.Size = new System.Drawing.Size(301, 24);
            this.lbl_google.TabIndex = 3;
            this.lbl_google.Text = "Total Google Results:";
            this.lbl_google.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_live
            // 
            this.lbl_live.AutoSize = true;
            this.lbl_live.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_live.Location = new System.Drawing.Point(301, 24);
            this.lbl_live.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_live.Name = "lbl_live";
            this.lbl_live.Size = new System.Drawing.Size(301, 24);
            this.lbl_live.TabIndex = 4;
            this.lbl_live.Text = "Total MSN Live Results:";
            this.lbl_live.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_yahoo
            // 
            this.lbl_yahoo.AutoSize = true;
            this.lbl_yahoo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_yahoo.Location = new System.Drawing.Point(301, 48);
            this.lbl_yahoo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_yahoo.Name = "lbl_yahoo";
            this.lbl_yahoo.Size = new System.Drawing.Size(301, 24);
            this.lbl_yahoo.TabIndex = 5;
            this.lbl_yahoo.Text = "Total! Yahoo! Results!:";
            this.lbl_yahoo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rpq
            // 
            this.lbl_rpq.AutoSize = true;
            this.lbl_rpq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rpq.Location = new System.Drawing.Point(602, 0);
            this.lbl_rpq.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_rpq.Name = "lbl_rpq";
            this.lbl_rpq.Size = new System.Drawing.Size(303, 24);
            this.lbl_rpq.TabIndex = 6;
            this.lbl_rpq.Text = "Results Per Query:";
            this.lbl_rpq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nud_rpq
            // 
            this.nud_rpq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_rpq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_rpq.Location = new System.Drawing.Point(602, 24);
            this.nud_rpq.Margin = new System.Windows.Forms.Padding(0);
            this.nud_rpq.Name = "nud_rpq";
            this.nud_rpq.Size = new System.Drawing.Size(303, 20);
            this.nud_rpq.TabIndex = 7;
            this.nud_rpq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_rpq.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_rpq.ValueChanged += new System.EventHandler(this.nud_rpq_ValueChanged);
            // 
            // tpnl_nap
            // 
            this.tpnl_nap.ColumnCount = 3;
            this.tpnl_nap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tpnl_nap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tpnl_nap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tpnl_nap.Controls.Add(this.btn_next, 2, 0);
            this.tpnl_nap.Controls.Add(this.btn_prev, 0, 0);
            this.tpnl_nap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnl_nap.Location = new System.Drawing.Point(602, 48);
            this.tpnl_nap.Margin = new System.Windows.Forms.Padding(0);
            this.tpnl_nap.Name = "tpnl_nap";
            this.tpnl_nap.RowCount = 1;
            this.tpnl_nap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnl_nap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnl_nap.Size = new System.Drawing.Size(303, 24);
            this.tpnl_nap.TabIndex = 8;
            // 
            // btn_next
            // 
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_next.Enabled = false;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_next.Location = new System.Drawing.Point(158, 0);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(145, 24);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Next Page >>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_prev.Enabled = false;
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.Color.Maroon;
            this.btn_prev.Location = new System.Drawing.Point(0, 0);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(143, 24);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "<< Previous Page";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // frm_advresbrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.pnl_srcopt);
            this.Controls.Add(this.tpnl_results);
            this.Controls.Add(this.pnl_searchbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_advresbrs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Spud Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_advresbrs_FormClosing);
            this.Load += new System.EventHandler(this.frm_advresbrs_Load);
            this.pnl_searchbar.ResumeLayout(false);
            this.pnl_searchbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).EndInit();
            this.tpnl_results.ResumeLayout(false);
            this.tpg_list.ResumeLayout(false);
            this.pnl_srcopt.ResumeLayout(false);
            this.tpnl_opt.ResumeLayout(false);
            this.tpnl_opt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rpq)).EndInit();
            this.tpnl_nap.ResumeLayout(false);
            this.ResumeLayout(false);

}

        #endregion

        private System.Windows.Forms.Panel pnl_searchbar;
        private System.Windows.Forms.TabControl tpnl_results;
        private System.Windows.Forms.TabPage tpg_web;
        private System.Windows.Forms.TabPage tpg_list;
        private System.Windows.Forms.Panel pnl_srcopt;
        private System.Windows.Forms.TableLayoutPanel tpnl_opt;
        private DotNetSkin.SkinControls.SkinCheckBox chk_google;
        private DotNetSkin.SkinControls.SkinCheckBox chk_live;
        private DotNetSkin.SkinControls.SkinCheckBox chk_yahoo;
        private System.Windows.Forms.Label lbl_google;
        private System.Windows.Forms.Label lbl_live;
        private System.Windows.Forms.Label lbl_yahoo;
        private System.Windows.Forms.Label lbl_rpq;
        private System.Windows.Forms.NumericUpDown nud_rpq;
        private System.Windows.Forms.TableLayoutPanel tpnl_nap;
        private DotNetSkin.SkinControls.SkinButtonGreen btn_next;
        private DotNetSkin.SkinControls.SkinButtonRed btn_prev;
        private System.Windows.Forms.Button btn_goforit;
        private System.Windows.Forms.ListView lvw_results;
        private System.Windows.Forms.ColumnHeader col_source;
        private System.Windows.Forms.ColumnHeader col_title;
        private System.Windows.Forms.ColumnHeader col_url;
        private System.Windows.Forms.ColumnHeader col_snippet;
        private System.Windows.Forms.ColumnHeader col_cache;
        private System.Windows.Forms.PictureBox pbx_loading;
        private System.Windows.Forms.ColumnHeader col_stat;
        public System.Windows.Forms.TextBox txt_search;
    }
}