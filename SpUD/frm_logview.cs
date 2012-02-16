using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// The namespace.  'nuff said...
namespace com.sensepost.SPUD
{

    // The class. 'nuff said
    public partial class frm_logview : Form
    {
        #region Private Class Variables
        private ArrayList g_logs;
        private frm_main g_main;
        #endregion

        #region Class Instantiation
        public frm_logview(frm_main the_main)
        {
            this.g_main = the_main;
            InitializeComponent();
            g_logs = g_main.log_main.GetLogs;
            this.LoadTheLogs();
        }
        #endregion

        #region Widget Target Voids
        private void frm_logview_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.g_main.HideLfForm();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.g_main.HideLfForm();
        }

        private void btn_truncate_Click(object sender, EventArgs e)
        {
            lvw_log.Items.Clear();
            this.g_main.log_main.ClrEvent();
        }
        #endregion

        #region Private Class Methods
        private void LoadTheLogs()
        {
            foreach (String logitm in this.g_logs)
            {
                try
                {
                    String[] logthingy = logitm.Split('\t');
                    ListViewItem lvi = new ListViewItem(logthingy);
                    lvw_log.Items.Add(lvi);
                }
                catch { }
            }
        }
        #endregion

        private void frm_logview_Activated(object sender, EventArgs e)
        {
            g_logs = g_main.log_main.GetLogs;
            this.LoadTheLogs();
        }
    }
}