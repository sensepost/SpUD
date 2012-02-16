namespace com.sensepost.SPUD
{
    partial class ctl_results
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_source = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_link = new System.Windows.Forms.LinkLabel();
            this.lbl_snip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_source)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_source
            // 
            this.pic_source.Location = new System.Drawing.Point(0, 0);
            this.pic_source.MaximumSize = new System.Drawing.Size(49, 49);
            this.pic_source.Name = "pic_source";
            this.pic_source.Size = new System.Drawing.Size(49, 49);
            this.pic_source.TabIndex = 0;
            this.pic_source.TabStop = false;
            this.pic_source.Click += new System.EventHandler(this.pic_source_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(55, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(67, 20);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "lbl_title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_link
            // 
            this.lbl_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_link.AutoSize = true;
            this.lbl_link.Location = new System.Drawing.Point(56, 20);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(39, 13);
            this.lbl_link.TabIndex = 2;
            this.lbl_link.TabStop = true;
            this.lbl_link.Text = "lbl_link";
            this.lbl_link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_link_LinkClicked);
            // 
            // lbl_snip
            // 
            this.lbl_snip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_snip.AutoSize = true;
            this.lbl_snip.Location = new System.Drawing.Point(56, 36);
            this.lbl_snip.Name = "lbl_snip";
            this.lbl_snip.Size = new System.Drawing.Size(42, 13);
            this.lbl_snip.TabIndex = 3;
            this.lbl_snip.Text = "lbl_snip";
            this.lbl_snip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_snip.Click += new System.EventHandler(this.lbl_snip_Click);
            // 
            // ctl_results
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_snip);
            this.Controls.Add(this.lbl_link);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pic_source);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctl_results";
            this.Size = new System.Drawing.Size(125, 52);
            this.DoubleClick += new System.EventHandler(this.ctl_results_DoubleClick);
            this.Click += new System.EventHandler(this.ctl_results_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pic_source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_source;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.LinkLabel lbl_link;
        private System.Windows.Forms.Label lbl_snip;
    }
}
