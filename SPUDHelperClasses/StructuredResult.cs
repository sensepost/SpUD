using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Name space... 'nuff said...
namespace com.sensepost.SPUDHelperClasses
{
    // The Class... 'nuff said...
    public class StructuredResult
    {
        #region Private Class Variables
        private int g_start;
        private int g_end;
        private int g_total;
        private int g_google;
        private int g_live;
        private int g_yahoo;
        private String g_querystring;
        private Collection<StructuredResultElement> g_results;
        #endregion

        #region Class Instantiation
        // Class Instantiation
        public StructuredResult()
        {
            this.g_start        = 0;
            this.g_end          = 0;
            this.g_total        = 0;
            this.g_google       = 0;
            this.g_live         = 0;
            this.g_yahoo        = 0;
            this.g_querystring  = "";
            this.g_results      = new Collection<StructuredResultElement>();
        }

        //Class instantiation - Override 1
        public StructuredResult(int n_s, int n_e, int n_t, int n_g, int n_l, int n_y, String sz_q, Collection<StructuredResultElement> c_r)
        {
            this.g_start        = n_s;
            this.g_end          = n_e;
            this.g_total        = n_t;
            this.g_google       = n_g;
            this.g_live         = n_l;
            this.g_yahoo        = n_y;
            this.g_querystring  = sz_q;
            this.g_results      = c_r;
        }
        #endregion

        #region Public Properties (Get:Set)
        public int ResultStart
        {
            get { return this.g_start; }
            set { this.g_start = value; }
        }

        public int ResultEnd
        {
            get { return this.g_end; }
            set { this.g_end = value; }
        }

        public int ResultTotal
        {
            get { return this.g_total; }
            set { this.g_total = value; }
        }

        public int ResultGoogleTotal
        {
            get { return this.g_google; }
            set { this.g_google = value; }
        }

        public int ResultLiveTotal
        {
            get { return this.g_live; }
            set { this.g_live = value; }
        }

        public int ResultYahooTotal
        {
            get { return this.g_yahoo; }
            set { this.g_yahoo = value; }
        }

        public String ResultQueryString
        {
            get { return this.g_querystring; }
            set { this.g_querystring = value; }
        }

        public Collection<StructuredResultElement> ResultItems
        {
            get { return this.g_results; }
            set { this.g_results = value; }
        }
        #endregion
    }
}
