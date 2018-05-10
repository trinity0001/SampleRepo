using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SampleRepo
{
    public partial class Default : System.Web.UI.MasterPage
    {
        public static string conn_string = "Server=localhost;Database=samplerepo;Uid=samplerepo_user;Pwd=pass;";
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<!-- page load here -->");
            using (MySqlConnection conn = new MySqlConnection(conn_string))
            {
                conn.Open();
                 MySqlCommand cmd =conn.CreateCommand();
                cmd.CommandText = "select * from users";
                MySqlDataReader reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    Response.Write(reader["email"].ToString());
                }
                conn.Close();
            }
        }
        
    }
}