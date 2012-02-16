using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Web;
using System.Text.RegularExpressions;

// The namespace.  'nuff said...
namespace com.sensepost.SPUDHelperClasses
{
    // The class.  'nuff said...
    public class Api_G
    {
        #region Public Class Structures
        public struct str_reshdr
        {
            public int n_total;
            public ArrayList res_itm;
        }
        public struct str_resitm
        {
            public String sz_url;
            public String sz_title;
            public String sz_snip;
            public String sz_cache;
        }
        #endregion

        #region Private Class Variables
        private String g_key;
        private String g_query;
        private int g_start;
        private int g_length;
        private bool g_aura;
        #endregion

        #region Class Instantiation
        // Class Instantiation
        public Api_G()
        {
            this.g_key      = "";
            this.g_query    = "";
            this.g_start    = 0;
            this.g_length   = 0;
            this.g_aura = false;
        }

        // Class Instantiation - Override 1
        public Api_G(String sz_k, String sz_q, int n_s, int n_l, bool b_a)
        {
            this.g_key      = sz_k;
            this.g_query    = sz_q;
            this.g_start    = n_s;
            this.g_length   = n_l;
            this.g_aura = b_a;
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
            StructuredEngineResult returnItem = new StructuredEngineResult();
            //System.Diagnostics.Debug.WriteLine("Houston, we're running with Aura enabled: " + this.g_aura.ToString());
            if (this.g_aura) returnItem = this.GoogleSearch();
            else returnItem = this.GoogleSoap();
            return returnItem;
        }
        #endregion

        #region Private Class Methods
        private StructuredEngineResult GoogleSoap()
        {
            //System.Diagnostics.Debug.WriteLine("Houston, We're running in the Google SOAP routine");
            StructuredEngineResult returnItem = new StructuredEngineResult();
            Collection<StructuredResultElement> returnResults = new Collection<StructuredResultElement>();
            com.google.api.GoogleSearchService the_service = new global::com.sensepost.SPUDHelperClasses.com.google.api.GoogleSearchService();
            com.google.api.GoogleSearchResult the_result = new global::com.sensepost.SPUDHelperClasses.com.google.api.GoogleSearchResult();
            com.google.api.ResultElement the_element = new global::com.sensepost.SPUDHelperClasses.com.google.api.ResultElement();
            try
            {
                the_result = the_service.doGoogleSearch(this.g_key, this.g_query, this.g_start, this.g_length, false, "", false, "", "latin1", "latin1");
            }
            catch (Exception ex)
            {
                StructuredResultElement str_res = new StructuredResultElement("Google", "", "", "", "", "", "ERROR:" + ex.Message.ToString());
                returnResults.Add(str_res);
                returnItem.ResultSource = "Google";
                returnItem.ResultTotal = 0;
                returnItem.ResultItems = returnResults;
                return returnItem;
            }
            returnItem.ResultSource = "Google";
            returnItem.ResultTotal = the_result.estimatedTotalResultsCount;
            for (int i = 0; i < the_result.resultElements.Length; i++)
            {
                the_element = the_result.resultElements[i];
                StructuredResultElement str_res = new StructuredResultElement("Google", the_element.URL.ToString(), the_element.cachedSize.ToString(), the_element.snippet.ToString(), the_element.summary.ToString(), the_element.title.ToString(), "SUCCESS");
                returnResults.Add(str_res);
            }
            returnItem.ResultItems = returnResults;
            return returnItem;
        }

        private StructuredEngineResult GoogleSearch()
        {
            //System.Diagnostics.Debug.WriteLine("Houston, We're running in the Google Search Routine");
            StructuredEngineResult return_item = new StructuredEngineResult();
            String GoogleHtml = this.GetGooglePage();
            if (GoogleHtml.StartsWith("ERROR:"))
            {
                StructuredResultElement sre = new StructuredResultElement("Google", "", "", "", "", "", GoogleHtml);
                return_item.ResultItems.Add(sre);
            }
            else
            {
                str_reshdr outres = GetGoogleItems(GoogleHtml);
                return_item.ResultSource = "Google";
                return_item.ResultTotal = outres.n_total;
                foreach (str_resitm the_itm in outres.res_itm)
                {
                    StructuredResultElement sre = new StructuredResultElement("Google", the_itm.sz_url, the_itm.sz_cache, the_itm.sz_snip, the_itm.sz_snip, the_itm.sz_title, "SUCCESS");
                    return_item.ResultItems.Add(sre);
                }
            }
            return return_item;
        }

        private String GetGooglePage()
        {
            String sz_Returner = "";
            WebResponse response = null;
            Stream stream = null;
            StreamReader reader = null;
            String theurl = HttpUtility.UrlEncode(this.g_query);
            theurl = "http://www.google.com/search?hl=en&q=" + theurl;
            theurl = theurl + "&num=" + this.g_length.ToString() + "&start=" + this.g_start.ToString();
            //System.Diagnostics.Debug.WriteLine("Houston, this is the URL we're querying... " + theurl);
            Uri m_uri = new Uri(theurl);
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(m_uri);
                response = request.GetResponse();
                stream = response.GetResponseStream();
                string line = "";
                reader = new StreamReader(stream);
                while ((line = reader.ReadLine()) != null)
                {
                    sz_Returner += line + "\r\n";
                }
                int body_start = sz_Returner.IndexOf("<body", StringComparison.OrdinalIgnoreCase);
                String body_text = sz_Returner.Substring(body_start, sz_Returner.Length - body_start);
                sz_Returner = body_text;
            }
            catch (Exception e)
            {
                sz_Returner = "ERROR:" + e.Message.ToString();
            }
            finally
            {
                if (reader != null) reader.Close();

                if (stream != null) stream.Close();

                if (response != null) response.Close();
            }
            return sz_Returner;
        }

        private str_reshdr GetGoogleItems(String sz_http)
        {
            str_reshdr returnthingy = new str_reshdr();
            // OK.  Here's what we do...
            // We get the index of the class="t bt" TABLE-TAG.
            // We then look for the end of the TABLE, and create a substring.
            // This contains the result header items (results x to y of z) etc.
            int n_reshdr = sz_http.IndexOf("<td align=right nowrap>", StringComparison.OrdinalIgnoreCase);
            if (n_reshdr > 0)
            {
                String sz_hdrresonly = sz_http.Substring(n_reshdr, sz_http.Length - n_reshdr);
                int n_hdrtab = sz_hdrresonly.IndexOf("</table>", StringComparison.OrdinalIgnoreCase);
                if (n_hdrtab > 0)
                {
                    String TheHeader = sz_hdrresonly.Substring(0, sz_hdrresonly.Length - n_hdrtab);
                    int n_Total = this.GoogleParseTotals(TheHeader);
                    returnthingy.n_total = n_Total;

                    // OK.  Now, we have the total.  We need the results...
                    // We look for the index of the first <div class=g item.  This is the first link result...
                    int n_detitm = sz_hdrresonly.IndexOf("<div class=g", StringComparison.OrdinalIgnoreCase);
                    if (n_detitm > 0)
                    {
                        String sz_resonly = sz_hdrresonly.Substring(n_detitm, sz_hdrresonly.Length - n_detitm);
                        sz_resonly = sz_resonly.Replace("\r", "");
                        sz_resonly = sz_resonly.Replace("\n", "");

                        ArrayList tmpres = GoogleParseItems(sz_resonly);
                        returnthingy.res_itm = tmpres;
                    }
                    else
                    {
                        returnthingy.n_total = 0;
                        returnthingy.res_itm = new ArrayList();
                    }
                }
                else
                {
                    returnthingy.n_total = 0;
                    returnthingy.res_itm = new ArrayList();
                }
            }
            else
            {
                returnthingy.n_total = 0;
                returnthingy.res_itm = new ArrayList();
            }
            return returnthingy;
        }

        private int GoogleParseTotals(String sz_HdrString)
        {
            int n_total = 0;
            try
            {
                String tmpString = sz_HdrString.Replace("\r", "");
                tmpString = sz_HdrString.Replace("\n", "");
                tmpString = sz_HdrString.Replace("<", "\n<");
                String[] arrString = tmpString.Split('\n');
                int n_count = 0;
                foreach (String wrkitm in arrString)
                {
                    if (wrkitm.StartsWith("<b>"))
                    {
                        if (n_count == 2)
                        {
                            String tmptotal = wrkitm.Replace("<b>", "");
                            tmptotal = tmptotal.Replace(",", "");
                            n_total = System.Convert.ToInt32(tmptotal);
                            break;
                        }
                        n_count++;
                    }
                }
            }
            catch { }
            return n_total;
        }

        private ArrayList GoogleParseItems(String sz_ResString)
        {
            ArrayList returnthingy = new ArrayList();
            String work_with_me = sz_ResString.Replace("<div class=g", "\n");
            String[] MyArray = work_with_me.Split('\n');
            // Now we have an array with length of n_length...
            foreach (String MyItm in MyArray)
            {
                if (MyItm != "")
                {
                    String sz_UrlString = "";
                    String sz_TitString = "";
                    String sz_SnpString = "";
                    String sz_CacString = "";
                    bool b_titl = false;
                    bool b_snip = false;
                    String tmpitm = MyItm.Replace("<", "\n<");
                    String[] tmparr = tmpitm.Split('\n');
                    foreach (String newitm in tmparr)
                    {
                        if (newitm.StartsWith("<a ") && sz_UrlString == "")
                        {
                            b_titl = true;
                            sz_UrlString = newitm;
                        }
                        else if (newitm.StartsWith("</a>"))
                        {
                            b_titl = false;
                        }
                        else if (newitm.StartsWith("<font size=-1>") && sz_SnpString == "")
                        {
                            b_snip = true;
                            sz_SnpString = newitm;
                        }
                        else if (newitm.StartsWith("<br>"))
                        {
                            b_snip = false;
                        }
                        else if (newitm.EndsWith(" - "))
                        {
                            sz_CacString = newitm;
                        }
                        else
                        {
                            if (b_snip) sz_SnpString += newitm;
                            if (b_titl) sz_TitString += newitm;
                        }
                    }
                    // We now have to clean and format the strings...
                    sz_UrlString = sz_UrlString.Replace("<a href=\"", "");
                    sz_UrlString = sz_UrlString.Replace("\" class=l onmousedown=\"return clk(this.href,'','','res','1','')\">", "");
                    int n_moo = sz_UrlString.IndexOf("\"");
                    if (n_moo > 0)
                    {
                        sz_UrlString = sz_UrlString.Substring(0, n_moo);
                    }
                    //System.Diagnostics.Debug.WriteLine("Houston, I found URL : " + sz_UrlString);
                    sz_SnpString = sz_SnpString.Replace("<font size=-1>", "");
                    int n_c = sz_CacString.IndexOf(" - ");
                    if (n_c > 0)
                    {
                        String s_c = sz_CacString.Substring(n_c + 3, sz_CacString.Length - n_c - 3);
                        n_c = s_c.IndexOf(" - ");
                        if (n_c > 0)
                        {
                            s_c = s_c.Substring(0, n_c);
                        }
                        else
                        {
                            s_c = "";
                        }
                        sz_CacString = s_c;
                    }
                    else
                    {
                        sz_CacString = "";
                    }
                    str_resitm tmp = new str_resitm();
                    tmp.sz_url = sz_UrlString;
                    tmp.sz_title = sz_TitString;
                    tmp.sz_snip = sz_SnpString;
                    tmp.sz_cache = sz_CacString;
                    returnthingy.Add(tmp);
                }
            }
            return returnthingy;
        }
        #endregion
    }
}
