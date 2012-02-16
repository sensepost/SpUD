namespace com.sensepost.SPUD
{
    partial class frm_logview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_logview));
            this.pnl_bot = new System.Windows.Forms.Panel();
            this.btn_truncate = new DotNetSkin.SkinControls.SkinButtonRed();
            this.btn_close = new DotNetSkin.SkinControls.SkinButtonGreen();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lvw_log = new System.Windows.Forms.ListView();
            this.col_date = new System.Windows.Forms.ColumnHeader();
            this.col_source = new System.Windows.Forms.ColumnHeader();
            this.col_level = new System.Windows.Forms.ColumnHeader();
            this.col_detail = new System.Windows.Forms.ColumnHeader();
            this.pnl_bot.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_bot
            // 
            this.pnl_bot.Controls.Add(this.btn_truncate);
            this.pnl_bot.Controls.Add(this.btn_close);
            this.pnl_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bot.Location = new System.Drawing.Point(0, 240);
            this.pnl_bot.Name = "pnl_bot";
            this.pnl_bot.Size = new System.Drawing.Size(740, 33);
            this.pnl_bot.TabIndex = 0;
            // 
            // btn_truncate
            // 
            this.btn_truncate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_truncate.ForeColor = System.Drawing.Color.Maroon;
            this.btn_truncate.Location = new System.Drawing.Point(581, 6);
            this.btn_truncate.Name = "btn_truncate";
            this.btn_truncate.Size = new System.Drawing.Size(75, 23);
            this.btn_truncate.TabIndex = 1;
            this.btn_truncate.Text = "Clear Log";
            this.btn_truncate.UseVisualStyleBackColor = true;
            this.btn_truncate.Click += new System.EventHandler(this.btn_truncate_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_close.Location = new System.Drawing.Point(662, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.lvw_log);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(740, 240);
            this.pnl_top.TabIndex = 1;
            // 
            // lvw_log
            // 
            this.lvw_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_date,
            this.col_source,
            this.col_level,
            this.col_detail});
            this.lvw_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_log.Location = new System.Drawing.Point(0, 0);
            this.lvw_log.Name = "lvw_log";
            this.lvw_log.Size = new System.Drawing.Size(740, 240);
            this.lvw_log.TabIndex = 0;
            this.lvw_log.UseCompatibleStateImageBehavior = false;
            this.lvw_log.View = System.Windows.Forms.View.Details;
            // 
            // col_date
            // 
            this.col_date.Text = "Date / Time";
            this.col_date.Width = 100;
            // 
            // col_source
            // 
            this.col_source.Text = "Source";
            this.col_source.Width = 100;
            // 
            // col_level
            // 
            this.col_level.Text = "Level";
            this.col_level.Width = 100;
            // 
            // col_detail
            // 
            this.col_detail.Text = "Detail";
            this.col_detail.Width = 435;
            // 
            // frm_logview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 273);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_bot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_logview";
            this.Text = "SPUD - View Logs";
            this.Activated += new System.EventHandler(this.frm_logview_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_logview_FormClosing);
            this.pnl_bot.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_bot;
        private DotNetSkin.SkinControls.SkinButtonRed btn_truncate;
        private DotNetSkin.SkinControls.SkinButtonGreen btn_close;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.ListView lvw_log;
        private System.Windows.Forms.ColumnHeader col_date;
        private System.Windows.Forms.ColumnHeader col_source;
        private System.Windows.Forms.ColumnHeader col_level;
        private System.Windows.Forms.ColumnHeader col_detail;
    }
}