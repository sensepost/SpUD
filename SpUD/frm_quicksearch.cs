using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//The namespace. 'nuff said...
namespace com.sensepost.SPUD
{
    // the class.  'nuff said
    public partial class frm_quicksearch : Form
    {
        #region Private Class Variables
        private frm_main g_main;
        //private frm_advresbrs g_search;
        #endregion

        #region Class instantiation
        public frm_quicksearch(frm_main the_main)
        {
            InitializeComponent();
            this.g_main = the_main;
        }
        #endregion

        #region Widget Target Voids
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.g_main.HideQsForm();
        }
        #endregion

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (txt_query.Text.Length == 0) return;
            this.g_main.StartQsSearch(txt_query.Text);
        }

        private void frm_quicksearch_Shown(object sender, EventArgs e)
        {
            this.ocx_timer.Interval = 15000;
            this.ocx_timer.Enabled = true;
            this.ocx_timer.Start();
        }

        private void ocx_timer_Tick(object sender, EventArgs e)
        {
            this.ocx_timer.Stop();
            this.ocx_timer.Enabled = false;
            this.g_main.HideQsForm();
        }
    }
}