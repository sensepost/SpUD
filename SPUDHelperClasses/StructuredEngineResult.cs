using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Name space... 'nuff said...
namespace com.sensepost.SPUDHelperClasses
{
    // The Class... 'nuff said...
    public class StructuredEngineResult
    {
        #region Private Class Variables
        private String g_source;
        private int g_total;
        private Collection<StructuredResultElement> g_results;
        #endregion

        #region Class Instantiation
        // Class Instantiation
        public StructuredEngineResult()
        {
            this.g_source = "";
            this.g_total = 0;
            this.g_results = new Collection<StructuredResultElement>();
        }

        //Class instantiation - Override 1
        public StructuredEngineResult(String sz_s, int n_t, Collection<StructuredResultElement> c_r)
        {
            this.g_source = sz_s;
            this.g_total = n_t;
            this.g_results = c_r;
        }
        #endregion

        #region Public Properties (Get:Set)
        public String ResultSource
        {
            get { return this.g_source; }
            set { this.g_source = value; }
        }

        public int ResultTotal
        {
            get { return this.g_total; }
            set { this.g_total = value; }
        }

        public Collection<StructuredResultElement> ResultItems
        {
            get { return this.g_results; }
            set { this.g_results = value; }
        }
        #endregion
    }
}
