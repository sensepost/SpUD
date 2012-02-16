using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;

// The namespace.  'nuff said...
namespace com.sensepost.SPUDHelperClasses
{
    // the class.  'nuff said...
    public class Api_Y
    {
        #region Private Class Variables
        private String g_key;
        private String g_query;
        private int g_start;
        private int g_length;
        #endregion

        #region Class Instantiation
        // Class Instantiation
        public Api_Y()
        {
            this.g_key      = "";
            this.g_query    = "";
            this.g_start    = 0;
            this.g_length   = 0;
        }

        // Class instantiation - Override 1
        public Api_Y(String sz_k, String sz_q, int n_s, int n_l)
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
        {

            int TotalResults = 0;
            StructuredEngineResult returnItem = new StructuredEngineResult();
            Collection<StructuredResultElement> returnResults = new Collection<StructuredResultElement>();
            int i = this.g_start + 1;

            Uri the_address = new Uri("http://search.yahooapis.com/WebSearchService/V1/webSearch");
            HttpWebRequest the_request = WebRequest.Create(the_address) as HttpWebRequest;
            the_request.Method = "POST";
            the_request.ContentType = "application/x-www-form-urlencoded";
            // We mangle the query somewhat here so that Google Hack queries return less false-positives...
            this.g_query = this.g_query.ToLower();
            this.g_query = this.g_query.Replace("filetype:", "inurl:.");
            this.g_query = this.g_query.Replace("intext:", "SENSEPOSTINTEXTPLACEHOLDER:");
            this.g_query = this.g_query.Replace("ext:", "inurl:.");
            this.g_query = this.g_query.Replace("SENSEPOSTINTEXTPLACEHOLDER:", "intext:");
            this.g_query = this.g_query.Replace("|", " OR ");
            this.g_query = this.g_query.Replace("intitle:index.of.", "intitle:\"index of \"");
            this.g_query = this.g_query.Replace("intitle:index.of", "intitle:\"index of\"");
            this.g_query = this.g_query.Replace("intitle:\"index.of.", "intitle:\"index of ");
            this.g_query = this.g_query.Replace("intitle:\"index.of", "intitle:\"index of");
            StringBuilder the_querydata = new StringBuilder();
            the_querydata.Append("appid=" + HttpUtility.UrlEncode(this.g_key));
            the_querydata.Append("&start=" + HttpUtility.UrlEncode(i.ToString()));
            the_querydata.Append("&query=" + HttpUtility.UrlEncode(this.g_query));
            the_querydata.Append("&results=" + HttpUtility.UrlEncode(this.g_length.ToString()));
            byte[] the_datatosend = UTF8Encoding.UTF8.GetBytes(the_querydata.ToString());
            the_request.ContentLength = the_datatosend.Length;
            using (Stream strm_post = the_request.GetRequestStream())
            {
                strm_post.Write(the_datatosend, 0, the_datatosend.Length);
            }
            String the_xmlstring = "";
            try
            {
                using (HttpWebResponse the_response = the_request.GetResponse() as HttpWebResponse)
                {
                    StreamReader strm_response = new StreamReader(the_response.GetResponseStream());
                    the_xmlstring = strm_response.ReadToEnd().ToString();
                }
                XmlDocument the_xmldoc = new XmlDocument();
                the_xmldoc.LoadXml(the_xmlstring);
                XmlNodeList the_masterlist = the_xmldoc.DocumentElement.ChildNodes;

                String sz_resultstr = "";
                String sz_resultend = "";
                String sz_resulttot = "";

                sz_resultstr = the_xmldoc.DocumentElement.GetAttribute("firstResultPosition").ToString();
                sz_resultend = the_xmldoc.DocumentElement.GetAttribute("totalResultsReturned").ToString();
                sz_resulttot = the_xmldoc.DocumentElement.GetAttribute("totalResultsAvailable").ToString();
                TotalResults = System.Convert.ToInt32(sz_resulttot);
                
                foreach (XmlNode master_node in the_masterlist)
                {
                    String res_title = "";
                    String res_summary = "";
                    String res_url = "";
                    String res_cache = "";
                    foreach (XmlNode child1_node in master_node.ChildNodes)
                    {
                        if (child1_node.Name.ToString().ToLower() == "title") res_title = child1_node.InnerText.ToString();
                        if (child1_node.Name.ToString().ToLower() == "summary") res_summary = child1_node.InnerText.ToString();
                        if (child1_node.Name.ToString().ToLower() == "url") res_url = child1_node.InnerText.ToString();
                        if (child1_node.Name.ToString().ToLower() == "cache")
                        {
                            foreach (XmlNode child2_node in child1_node.ChildNodes)
                            {
                                if (child2_node.Name.ToString().ToLower() == "size")
                                {
                                    res_cache = child2_node.InnerText.ToString();
                                    break;
                                }
                            }
                        }
                    }
                    if (res_title.Length > 0 || res_summary.Length > 0 || res_url.Length > 0)
                    {
                        StructuredResultElement the_resultelement = new StructuredResultElement("Yahoo", res_url, res_cache, res_summary, res_summary, res_title, "SUCCESS");
                        returnResults.Add(the_resultelement);
                    }
                }
                returnItem.ResultSource = "Yahoo";
                returnItem.ResultTotal = TotalResults;
                returnItem.ResultItems = returnResults;
            }
            catch (Exception ex)
            {
                StructuredResultElement the_resultelement = new StructuredResultElement("Yahoo", "", "", "", "", "", "ERROR:" + ex.Message.ToString());
                returnResults.Add(the_resultelement);
                returnItem.ResultSource = "Yahoo";
                returnItem.ResultTotal = 0;
                returnItem.ResultItems = returnResults;
            }
            return returnItem;
        }
        #endregion
    }
}
