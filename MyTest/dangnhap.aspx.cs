using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MyTest
{
    public partial class dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=M01;Initial Catalog=QLCanBo;Integrated Security=True";
            SqlConnection myconn=new SqlConnection(constring);
            myconn.Open();
            string str = "select * from NguoiDung where Tennguoidung='" + txtname.Text + "' and Matkhau='" + txtpass.Text + "'";
            SqlCommand mycmd=new SqlCommand(str,myconn);
            SqlDataReader data= mycmd.ExecuteReader();
            if (data.Read())
            {
               Panel1.Visible= false;
                Response.Write("Chúc mừng "+txtname.Text+ " đã đăng nhập thành công");
            }    
            else
            {
                Response.Write("Tên đăng nhập hoặc mật khẩu sai");
            }
            myconn.Close();
        }
    }
}