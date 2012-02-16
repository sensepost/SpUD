using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace com.sensepost.SPUD
{
    static class Program
    {
        public static KeyboardHook kh;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TestForm());
            using (kh = new KeyboardHook( ))
            {
                frm_splash the_splash = new frm_splash();
                the_splash.Show();
                Application.Run(new frm_main());
                //Application.Run(new debugform());
            }
        }
    }
}