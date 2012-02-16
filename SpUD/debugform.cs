using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.sensepost.SPUDHelperClasses;

namespace com.sensepost.SPUD
{
    public partial class debugform : Form
    {
        public debugform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StructuredQuery the_q = new StructuredQuery(textBox1.Text, 0, 10, false);
            Api_Combined the_api = new Api_Combined(the_q);
            StructuredResult the_r = the_api.GetTheResults();
        }
    }
}