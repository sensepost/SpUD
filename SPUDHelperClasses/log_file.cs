using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;

// The namespace. 'nuff said...
namespace com.sensepost.SPUDHelperClasses
{
    // the class.  'nuff said...
    public class log_file
    {
        #region Private Class Variables
        private ArrayList ar_AllLogs;
        private String sz_LogFile;
        private StreamWriter sw_LogFile;
        private bool b_HaveIOpened;
        #endregion

        #region Class Instantiation
        public log_file(String sz_f, bool b_ap)
        {
            // When the class is instantiated, we set the filename...
            this.sz_LogFile = sz_f;
            this.Instantiate(b_ap);
        }
        #endregion

        #region Private Class Methods
        private ArrayList GetAllLogdata()
        {
            ArrayList ReturnThingy = new ArrayList();
            try
            {
                String data_line = "";
                StreamReader sr_logfile = new StreamReader(this.sz_LogFile);
                data_line = sr_logfile.ReadLine();
                if (data_line != "") ReturnThingy.Add(data_line);
                while (data_line != null)
                {
                    data_line = sr_logfile.ReadLine();
                    if (data_line != "") ReturnThingy.Add(data_line);
                }
                sr_logfile.Close();
            }
            catch
            {
                ReturnThingy = new ArrayList();
            }
            return ReturnThingy;
        }

        private String GetTheTime()
        {
            DateTime the_time = System.DateTime.Now;
            String dt = the_time.ToShortDateString().ToString();
            String tm = the_time.ToShortTimeString().ToString().Replace("A", "").Replace("P", "").Replace("a", "").Replace("p", "").Replace("M", "").Replace("m", "").Replace(" ", "");
            tm += "." + the_time.Millisecond.ToString();
            return dt + " " + tm;
        }

        private void Instantiate(bool b_ap)
        {
            this.b_HaveIOpened = false;
            // Now, we get all the logs...
            if (b_ap) this.ar_AllLogs = this.GetAllLogdata();
            else this.ar_AllLogs = new ArrayList();
            // And now, we open the file for writing...
            try
            {
                this.sw_LogFile = new StreamWriter(sz_LogFile, b_ap);
                this.b_HaveIOpened = true;
            }
            catch
            {
                this.b_HaveIOpened = false;
            }
        }
        #endregion

        #region Public Class Properties
        public bool IsLogging
        {
            get { return this.b_HaveIOpened; }
        }
        public ArrayList GetLogs
        {
            get { return this.ar_AllLogs; }
        }
        #endregion

        #region Public Class Methods
        public void LogEvent(String sz_src, String sz_lev, String sz_det)
        {
            String the_dat = this.GetTheTime();
            String the_src = sz_src;
            String the_lev = sz_lev;
            String the_det = sz_det;
            if (b_HaveIOpened)
            {
                this.sw_LogFile.WriteLine(the_dat + "\t" + the_src + "\t" + the_lev + "\t" + the_det);
                this.sw_LogFile.Flush();
                this.ar_AllLogs.Add(the_dat + "\t" + the_src + "\t" + the_lev + "\t" + the_det);
            }
        }

        public void ClrEvent()
        {
            if (b_HaveIOpened)
            {
                this.sw_LogFile.Close();
                this.Instantiate(false);
            }
        }

        public void StopLogging()
        {
            this.sw_LogFile.Flush();
            this.sw_LogFile.Close();
        }
        #endregion
    }
}
