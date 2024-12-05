using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTest
{
    public partial class layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["dangnhap"]!=null)
            {
                txt_xinchao.Text = "Xin chào" + Session["dangnhap"];
                hyperdangxuat.Visible= true;
                hyperdangxuat.NavigateUrl = "dangxuat.aspx";
            }
            else
            {
                txt_xinchao.Text = "";
                hyperdangxuat.Text="Đăng nhập";
                hyperdangxuat.NavigateUrl = "WebForm1.aspx";
            }
        }
    }
}