using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forms_m7_autocomplete.autocomplete_07.before
{
    public partial class QueryHandler1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var teams = new List<string>()
            {
                "Giants",
                "Jets"
            };

            var q = Request.QueryString["q"];
            var result = teams.Where(t => t.ToUpper().StartsWith(q.ToUpper()));

            var jss = new JavaScriptSerializer();
            var output = jss.Serialize(result);
            Response.Write(output);
        }
    }
}