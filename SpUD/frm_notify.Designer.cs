namespace com.sensepost.SPUD
{
    partial class frm_notify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_notify));
            this.lbl_quicksearch = new System.Windows.Forms.Label();
            this.ocx_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_quicksearch
            // 
            this.lbl_quicksearch.Location = new System.Drawing.Point(12, 9);
            this.lbl_quicksearch.Name = "lbl_quicksearch";
            this.lbl_quicksearch.Size = new System.Drawing.Size(306, 17);
            this.lbl_quicksearch.TabIndex = 0;
            // 
            // ocx_timer
            // 
            this.ocx_timer.Interval = 10000;
            this.ocx_timer.Tick += new System.EventHandler(this.ocx_timer_Tick);
            // 
            // frm_notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(330, 35);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_quicksearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_notify";
            this.Opacity = 0.75;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.StyleChanged += new System.EventHandler(this.frm_notify_Shown);
            this.SizeChanged += new System.EventHandler(this.frm_notify_Shown);
            this.Resize += new System.EventHandler(this.frm_notify_Shown);
            this.Shown += new System.EventHandler(this.frm_notify_Shown);
            this.Enter += new System.EventHandler(this.frm_notify_Shown);
            this.Activated += new System.EventHandler(this.frm_notify_Shown);
            this.VisibleChanged += new System.EventHandler(this.frm_notify_Shown);
            this.Move += new System.EventHandler(this.frm_notify_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_quicksearch;
        private System.Windows.Forms.Timer ocx_timer;

    }
}