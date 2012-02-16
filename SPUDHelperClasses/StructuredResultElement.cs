using System;

// The NameSpace... 'Nuff said.
namespace com.sensepost.SPUDHelperClasses
{
    // The Class... 'Nuff said...
    public class StructuredResultElement
    {
        #region Private Class Variables
        private String g_source;
        private String g_url;
        private String g_cachesize;
        private String g_snippet;
        private String g_summary;
        private String g_title;
        private String g_error;
        #endregion

        #region Class Instantiation
        // Class Instantiation
        public StructuredResultElement()
        {
            this.g_source = "";
            this.g_url          = "";
            this.g_cachesize    = "";
            this.g_snippet      = "";
            this.g_summary      = "";
            this.g_title        = "";
            this.g_error        = "";
        }

        // Class Instantiation - Override 1
        public StructuredResultElement(String sz_o, String sz_u, String sz_c, String sz_s, String sz_m, String sz_t, String sz_e)
        {
            this.g_source       = sz_o;
            this.g_url          = sz_u;
            this.g_cachesize    = sz_c;
            this.g_snippet      = sz_s;
            this.g_summary      = sz_m;
            this.g_title        = sz_t;
            this.g_error        = sz_e;
        }
        #endregion

        #region Public Properties (Get:Set)
        public String ResultSource
        {
            get { return this.g_source; }
            set { this.g_source = value; }
        }

        public String ResultUrl
        {
            get { return this.g_url; }
            set { this.g_url = value; }
        }

        public String ResultCacheSize
        {
            get { return this.g_cachesize; }
            set { this.g_cachesize = value; }
        }

        public String ResultSnippet
        {
            get { return this.g_snippet; }
            set { this.g_snippet = value; }
        }

        public String ResultSummary
        {
            get { return this.g_summary; }
            set { this.g_summary = value; }
        }
        public String ResultTitle
        {
            get { return this.g_title; }
            set { this.g_title = value; }
        }

        public String ResultErrorCode
        {
            get { return this.g_error; }
            set { this.g_error = value; }
        }
        #endregion
    }
}
