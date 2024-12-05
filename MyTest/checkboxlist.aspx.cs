using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTest
{
    public partial class checkboxlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ckb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_TB.Text = "Những Items mà bạn đã chọn là: <br>";
            int i;
            for(i=0;i<ckb_items.Items.Count;i++) {
                if (ckb_items.Items[i].Selected)
                    lbl_TB.Text += ckb_items.Items[i].Text + "<br>";
            }
        }
    }
}