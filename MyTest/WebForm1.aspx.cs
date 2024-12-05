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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["vxlam"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(conn);
            sqlcon.Open();
            string sql = "select * from nguoidung where Tennguoidung='" + txtusername.Text.Trim() + "' and Matkhau='" + txtpassword.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql,sqlcon);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                Session["dangnhap"] = data[0].ToString();
                Response.Redirect("HienCB1.aspx");
            }
            else
            {
                txtusername.Text = "onclick=\"return confirm ('Bạn có chắc chắn muốn xóa không?')";
            }
        }
    }
}