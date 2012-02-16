namespace com.sensepost.SPUD
{
    partial class frm_splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_splash));
            this.pbx_splash = new System.Windows.Forms.PictureBox();
            this.tmr_splash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_splash
            // 
            this.pbx_splash.Image = global::com.sensepost.SPUD.res_images.SpuddySplash;
            this.pbx_splash.InitialImage = global::com.sensepost.SPUD.res_images.SpuddySplash;
            this.pbx_splash.Location = new System.Drawing.Point(12, 12);
            this.pbx_splash.Name = "pbx_splash";
            this.pbx_splash.Size = new System.Drawing.Size(307, 468);
            this.pbx_splash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_splash.TabIndex = 0;
            this.pbx_splash.TabStop = false;
            // 
            // tmr_splash
            // 
            this.tmr_splash.Tick += new System.EventHandler(this.tmr_splash_Tick);
            // 
            // frm_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(331, 491);
            this.Controls.Add(this.pbx_splash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_splash";
            this.Opacity = 0.9;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SensePost SPUD";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_splash_KeyPress);
            this.Load += new System.EventHandler(this.frm_splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_splash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_splash;
        private System.Windows.Forms.Timer tmr_splash;
    }
}