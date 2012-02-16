using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.sensepost.SPUD
{
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
            this.tmr_splash.Interval = 2000;
            this.tmr_splash.Enabled = true;
            this.tmr_splash.Start();
        }

        private void tmr_splash_Tick(object sender, EventArgs e)
        {
            this.tmr_splash.Stop();
            this.Hide();
        }

        private void frm_splash_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.tmr_splash.Stop();
            this.Hide();
        }
    }
}