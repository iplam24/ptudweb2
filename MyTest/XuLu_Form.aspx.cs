using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTest
{
    public partial class XuLu_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["txtname"];
            string pass = Request.QueryString["txtpass"];
            string age = Request.QueryString["txtage"];
            string mail= Request.QueryString["txtmail"];
            string sdt = Request.QueryString["txtsdt"];
            Response.Write("Tên đăng nhập: " + name + "<br>");
            Response.Write("Mật khẩu: " + pass + "<br>");
            Response.Write("Độ tuổi: " + age + "<br>");
            Response.Write("Email: " + mail + "<br>");
            Response.Write("Số điện thoại: " + sdt + "<br>");
        }
    }
}