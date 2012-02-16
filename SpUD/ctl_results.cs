using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// The namespace. 'nuff said...
namespace com.sensepost.SPUD
{
    // The class.  'nuff said...
    public partial class ctl_results : UserControl
    {
        #region Class Instantiation
        // Class instantiation
        public ctl_results()
        {
            InitializeComponent();
            //this.MaximumSize = new Size(this.Parent.Width, this.Parent.Height);
            this.Refresh();
        }
        // Class instantiation : Override 1
        public ctl_results(Image im_s, String sz_t, String sz_l, String sz_s, String sz_a)
        {
            InitializeComponent();
            this.pic_source.Image = im_s;
            if (sz_a.ToLower() != "success")
            {
                this.BackColor = System.Drawing.Color.Red;
                this.lbl_title.Text = "API Error";
                this.lbl_link.Visible = false;
                this.lbl_link.Enabled = false;
                this.lbl_snip.Text = sz_s;
            }
            else
            {
                this.lbl_title.Text = sz_t;
                this.lbl_link.Text = sz_l;
                this.lbl_link.Links.Add(0, lbl_link.Text.Length, lbl_link.Text);
                this.lbl_snip.Text = sz_s;
            }
        }
        #endregion

        private void lbl_snip_Click(object sender, EventArgs e)
        {
            return;
        }

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
            return;
        }

        private void pic_source_Click(object sender, EventArgs e)
        {
            return;
        }

        private void ctl_results_Click(object sender, EventArgs e)
        {
            return;
        }

        private void ctl_results_DoubleClick(object sender, EventArgs e)
        {
            return;
        }
    }
}
