using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTest
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_TB.Text = "Xin chào mọi người!";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void chk_copy_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_copy.Checked)
                txt_work.Text = txt_home.Text;
            else
                txt_work.Text = "";
        }
    }
}