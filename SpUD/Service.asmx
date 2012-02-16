<%@ WebService Language="C#" Class="Service" %>

using System;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using com.sensepost.SPUDHelperClasses;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {
    }

    [WebMethod]
    public StructuredResult GetStructResult(String sz_q, int n_s, int n_l, bool b_g)
    {
        StructuredQuery c_query = new StructuredQuery(sz_q, n_s, n_l, b_g);
        Api_Combined the_api = new Api_Combined(c_query);
        StructuredResult the_moo = the_api.GetTheResults();
        return the_moo;
    }
    
}
