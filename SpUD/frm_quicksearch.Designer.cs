namespace com.sensepost.SPUD
{
    partial class frm_quicksearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_quicksearch));
            this.lbl_query = new System.Windows.Forms.Label();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.btn_go = new DotNetSkin.SkinControls.SkinButtonGreen();
            this.btn_cancel = new DotNetSkin.SkinControls.SkinButtonRed();
            this.ocx_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_query
            // 
            this.lbl_query.AutoSize = true;
            this.lbl_query.Location = new System.Drawing.Point(2, 9);
            this.lbl_query.Name = "lbl_query";
            this.lbl_query.Size = new System.Drawing.Size(38, 13);
            this.lbl_query.TabIndex = 0;
            this.lbl_query.Text = "Query:";
            // 
            // txt_query
            // 
            this.txt_query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_query.Location = new System.Drawing.Point(46, 6);
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(279, 20);
            this.txt_query.TabIndex = 1;
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_go.Location = new System.Drawing.Point(169, 32);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 23);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "OK";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Maroon;
            this.btn_cancel.Location = new System.Drawing.Point(250, 32);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ocx_timer
            // 
            this.ocx_timer.Tick += new System.EventHandler(this.ocx_timer_Tick);
            // 
            // frm_quicksearch
            // 
            this.AcceptButton = this.btn_go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(330, 56);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_query);
            this.Controls.Add(this.lbl_query);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_quicksearch";
            this.Opacity = 0.75;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_quicksearch";
            this.TopMost = true;
            this.StyleChanged += new System.EventHandler(this.frm_quicksearch_Shown);
            this.SizeChanged += new System.EventHandler(this.frm_quicksearch_Shown);
            this.Resize += new System.EventHandler(this.frm_quicksearch_Shown);
            this.Shown += new System.EventHandler(this.frm_quicksearch_Shown);
            this.Enter += new System.EventHandler(this.frm_quicksearch_Shown);
            this.Activated += new System.EventHandler(this.frm_quicksearch_Shown);
            this.VisibleChanged += new System.EventHandler(this.frm_quicksearch_Shown);
            this.Move += new System.EventHandler(this.frm_quicksearch_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_query;
        private System.Windows.Forms.TextBox txt_query;
        private DotNetSkin.SkinControls.SkinButtonGreen btn_go;
        private DotNetSkin.SkinControls.SkinButtonRed btn_cancel;
        private System.Windows.Forms.Timer ocx_timer;
    }
}