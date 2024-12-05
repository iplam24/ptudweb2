using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MyTest
{
    public partial class xoacb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string constring = ConfigurationManager.ConnectionStrings["vxlam"].ConnectionString;
            SqlConnection mycon = new SqlConnection(constring);
            mycon.Open();
            SqlCommand mycmd = new SqlCommand("sp_xoacb",mycon);
            mycmd.CommandType = System.Data.CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@macb", Request.QueryString["macb"]);
            mycmd.ExecuteNonQuery();
            Response.Redirect("HienCB1.aspx");
            mycon.Close();

        }
    }
}