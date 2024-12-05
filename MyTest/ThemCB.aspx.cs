using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTest
{
    public partial class ThemCB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btlLuu_Click(object sender, EventArgs e)
        {
            string constring = WebConfigurationManager.ConnectionStrings["vxlam"].ConnectionString;
            SqlConnection myconn = new SqlConnection(constring);
            myconn.Open();
            string filename = "";
            if (FileUpload1.HasFiles)
            {
                filename = "Images/" + FileUpload1.FileName;
                string filepath = MapPath(filename);
                FileUpload1.SaveAs(filepath);
            }
            SqlCommand mycmd = new SqlCommand("sp_themcb", myconn);
            mycmd.CommandType=System.Data.CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@macb",txtmacb.Text);
            mycmd.Parameters.AddWithValue("@ht", txtten.Text);
            mycmd.Parameters.AddWithValue("@ns", txtngaysinh.Text);
            mycmd.Parameters.AddWithValue("@gt", txtgioitinh.Text);
            mycmd.Parameters.AddWithValue("@que", txtque.Text);
            mycmd.Parameters.AddWithValue("@cv", txtchucvu.Text);
            mycmd.Parameters.AddWithValue("@anh",filename );

            mycmd.ExecuteNonQuery();
            Response.Redirect("HienCB1.aspx");
        }
    }
}