using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using WebGrease;

namespace MyTest
{
    public partial class HienCB1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["dangnhap"]!=null)
            {
                string constring = WebConfigurationManager.ConnectionStrings["vxlam"].ConnectionString;
                SqlConnection mycon = new SqlConnection(constring);
                mycon.Open();
                string sql = "select * from canbo";
                SqlCommand mycmd = new SqlCommand(sql, mycon);
                SqlDataReader data = mycmd.ExecuteReader();
                int j = 1;
                while (data.Read())
                {
                    TableRow r = new TableRow();
                    TableCell cell = new TableCell();
                    cell.Text = j.ToString();
                    r.Cells.Add(cell);
                    for (int i = 0; i < 7; i++)
                    {
                        TableCell c = new TableCell();
                        if (i == 6)
                        {
                            c.Text = "<img src='" + data[i].ToString() + "' width='100px'>";
                        }
                        else
                        {
                            c.Text = data[i].ToString();
                        }
                        r.Cells.Add(c);
                    }
                    TableCell cell1 = new TableCell();
                    cell1.Text = "<a href='suacb1.aspx?macb=" + data[0].ToString() + "'> Sửa </a>";

                    cell1.Text += "<a href='xoacb.aspx?macb=" + data[0].ToString() + "' onclick=\"return confirm ('Bạn có chắc chắn muốn xóa không?')\"> Xóa </a>";

                    r.Cells.Add(cell1);
                    tblhiencb.Rows.Add(r);
                    j++;
                }
                mycon.Close();
            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }
        }
    }
}