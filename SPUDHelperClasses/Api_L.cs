using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// The namespace.  'nuff said...
namespace com.sensepost.SPUDHelperClasses
{
    // The class.  'nuff said...
    public class Api_L
    {
        #region Private Class Variables
        private String g_key;
        private String g_query;
        private int g_start;
        private int g_length;
        #endregion

        #region Class Instantiation
        // Class Instantiation
        public Api_L()
        {
            this.g_key      = "";
            this.g_query    = "";
            this.g_start    = 0;
            this.g_length   = 0;
        }

        // Class instantiation - Override 1
        public Api_L(String sz_k, String sz_q, int n_s, int n_l)
        {
            this.g_key      = sz_k;
            this.g_query    = sz_q;
            this.g_start    = n_s;
            this.g_length   = n_l;
        }
        #endregion

        #region Public Class Properties (Get:Set)
        public String ApiKey
        {
            get { return this.g_key; }
            set { this.g_key = value; }
        }

        public String ApiQuery
        {
            get { return this.g_query; }
            set { this.g_query = value; }
        }

        public int ApiStart
        {
            get { return this.g_start; }
            set { this.g_start = value; }
        }

        public int ApiLength
        {
            get { return this.g_length; }
            set { this.g_length = value; }
        }
        #endregion

        #region Public Class Methods
        public StructuredEngineResult GetResults()
        //public ArrayList GetResults()
        {
            int Totals = 0;
            StructuredEngineResult returnItem = new StructuredEngineResult();
            Collection<StructuredResultElement> returnResults = new Collection<StructuredResultElement>();
            //ArrayList al_returner = new ArrayList();
            com.msn.search.soap.MSNSearchService the_service = new global::com.sensepost.SPUDHelperClasses.com.msn.search.soap.MSNSearchService();
            com.msn.search.soap.SourceRequest[] the_sourcerequest = new global::com.sensepost.SPUDHelperClasses.com.msn.search.soap.SourceRequest[1];
            com.msn.search.soap.SearchRequest the_searchrequest = new global::com.sensepost.SPUDHelperClasses.com.msn.search.soap.SearchRequest();
            com.msn.search.soap.SearchResponse the_response;

            the_sourcerequest[0] = new global::com.sensepost.SPUDHelperClasses.com.msn.search.soap.SourceRequest();
            the_sourcerequest[0].Source = com.msn.search.soap.SourceType.Web;
            the_sourcerequest[0].ResultFields = global::com.sensepost.SPUDHelperClasses.com.msn.search.soap.ResultFieldMask.All;

            the_searchrequest.AppID = this.g_key;
            the_searchrequest.Query = this.g_query;
            the_searchrequest.CultureInfo = "en-US";
            the_searchrequest.Requests = the_sourcerequest;

            try
            {
                the_response = the_service.Search(the_searchrequest);
                foreach (com.msn.search.soap.SourceResponse src_resp in the_response.Responses)
                {
                    com.msn.search.soap.Result[] the_result = src_resp.Results;
                    foreach (com.msn.search.soap.Result fin_res in the_result)
                    {
                        String res_url = "";
                        String res_sum = "";
                        String res_tit = "";

                        try
                        {
                            res_url = fin_res.Url.ToString();
                        }
                        catch
                        {
                            res_url = "";
                        }
                        try
                        {
                            res_sum = fin_res.Summary.ToString();
                        }
                        catch
                        {
                            res_sum = "";
                        }
                        try
                        {
                            res_tit = fin_res.Title.ToString();
                        }
                        catch 
                        {
                            res_tit = "";
                        }


                        StructuredResultElement str_res = new StructuredResultElement("Live", res_url, "Unknown Cache Size", res_sum, res_sum, res_tit, "SUCCESS");
                        returnResults.Add(str_res);
                        Totals = src_resp.Total;
                    }
                    returnItem.ResultSource = "Live";
                    returnItem.ResultTotal = Totals;
                    returnItem.ResultItems = returnResults;
                }
            }
            catch (Exception ex)
            {
                StructuredResultElement str_res = new StructuredResultElement("Live", "", "", "", "", "", "ERROR:" + ex.Message.ToString());
                returnResults.Add(str_res);
                returnItem.ResultSource = "Live";
                returnItem.ResultTotal = 0;
                returnItem.ResultItems = returnResults;
                return returnItem;
            }
            return returnItem;
        }
        #endregion
    }
}
