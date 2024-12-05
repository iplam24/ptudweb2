using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTest
{
    public partial class testCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie ck = Request.Cookies["username"];
            if (ck == null)
            {
                lbltest.Text = "cookies của bạn chưa được tạo";
            }
            else
            {
                lbltest.Text = "Đã lưu cookies user! <br>";
                lbltest.Text += "Cookies " + ck.Value;
            }
        }

        protected void btn_dangNhap_Click(object sender, EventArgs e)
        {
            HttpCookie ck = Request.Cookies["username"];
            if (ck == null)
            {
                ck = new HttpCookie("username");
            }
                ck.Value = txtUserName.Text.Trim();
                ck.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(ck);


                lbltest.Text = "Bạn đã lưu cookies thành công! <br>";
                lbltest.Text += "Xin chào "+ck.Value;
             
        }
    }
}