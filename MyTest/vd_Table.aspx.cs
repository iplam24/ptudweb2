using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTest
{
    public partial class vd_Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i, j;
            for(i=0;i<3;i++)
            {
                TableRow r= new TableRow();
                for(j=0;j<4;j++) { 
                    TableCell c= new TableCell();
                    c.Text = "Dòng" + i + " Cột" + j;
                    r.Cells.Add(c);
                }
                tbl_vd.Rows.Add(r);
            }    
        }
    }
}