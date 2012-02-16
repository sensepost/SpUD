using System;

// The name space... 'nuff said.
namespace com.sensepost.SPUDHelperClasses
{
    // The class... 'nuff said
    public class StructuredQuery
    {
        #region Private Class Variables
        private String g_query;
        private int g_start;
        private int g_length;
        private bool g_gh;
        #endregion

        #region Class Instantiation
        // Class Instantiation
        public StructuredQuery()
        {
            this.g_query    = "";
            this.g_start    = 0;
            this.g_length   = 0;
            this.g_gh       = false;
        }

        // Class instantiation Override 1
        public StructuredQuery(String sz_q, int n_s, int n_l, bool b_g)
        {
            this.g_query    = sz_q;
            this.g_start    = n_s;
            this.g_length   = n_l;
            this.g_gh       = b_g;
        }
        #endregion

        #region Publicly Exposed Properties (Get:Set)
        public String QueryString
        {
            get { return this.g_query; }
            set { this.g_query = value; }
        }

        public int QueryStart
        {
            get { return this.g_start; }
            set { this.g_start = value; }
        }

        public int QueryLength
        {
            get { return this.g_length; }
            set { this.g_length = value; }
        }

        public bool QueryGoogleHack
        {
            get { return this.g_gh; }
            set { this.g_gh = value; }
        }
        #endregion
    }
}
