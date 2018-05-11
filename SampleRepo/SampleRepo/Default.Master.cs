using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SampleRepo
{
    public partial class Default : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            Response.Write("<!-- page load begins here -->");
            List<List<object>> rows = DBHelper.Select("users");
            if (rows == null) return;
            foreach (List<object> row in rows)
            {
                Response.Write(String.Join(",", row));
            }
            Response.Write("<!-- page load ends here -->");
            */
        }

    }
}