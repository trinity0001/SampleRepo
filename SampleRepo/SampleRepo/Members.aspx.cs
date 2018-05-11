using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleRepo
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id)) return;
            var result = DB.GetUserById(id);
            if (result == null) lblResult.Text = "bulunamadı";
            else lblResult.Text = String.Join(",", result);
        }
    }
}