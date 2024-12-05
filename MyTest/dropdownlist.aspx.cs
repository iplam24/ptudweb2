using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTest
{
    public partial class dropdownlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddl_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_city.SelectedItem.Selected)
                lbl_TB.Text = "Tỉnh/ Thành phố mà bạn vừa chọn là: " + ddl_city.SelectedItem.Text;
        }
    }
}