using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// The namespave.  'nuff said
namespace com.sensepost.SPUD
{
    // The class.  'nuff said
    public partial class frm_notify : Form
    {

        #region Private Class Variables
        private frm_main g_main;
        #endregion

        #region Class Instantiation
        public frm_notify(frm_main the_main)
        {
            InitializeComponent();
            this.g_main = the_main;
        }
        #endregion

        #region Widget Voids
        private void ocx_timer_Tick(object sender, EventArgs e)
        {
            this.ocx_timer.Stop();
            this.ocx_timer.Enabled = false;
            this.g_main.HideNsForm();
        }
        private void frm_notify_Shown(object sender, EventArgs e)
        {
            ocx_timer.Interval = 10000;
            ocx_timer.Enabled = true;
            ocx_timer.Start();
            lbl_quicksearch.Text = this.g_main.NotifyText;
        }
        #endregion
    }
}