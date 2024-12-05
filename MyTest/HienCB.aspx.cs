using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MyTest
{
    public partial class HienCB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string constring= "Data Source=M01;Initial Catalog=QLCanBo;Integrated Security=True";
            SqlConnection myconn=new SqlConnection(constring);
            myconn.Open();
            string str = "select * from canbo";
            SqlCommand mycmd=new SqlCommand(str,myconn);
            SqlDataReader data= mycmd.ExecuteReader();
            int j = 1;
            while(data.Read())
            {
                TableRow r= new TableRow();
                TableCell c= new TableCell(); 
                c.Text=j.ToString();
                r.Cells.Add(c);
                for(int i=0;i<6;i++)
                {
                    TableCell cell= new TableCell();
                    cell.Text = data[i].ToString();
                    r.Cells.Add (cell);
                }
                TableCell c1 = new TableCell();
                c1.Text = "<a href='suacb.aspx?macb=" + data[0].ToString() + "'>Sửa</a>";
                c1.Text+= " <a href='xoacb.aspx?macb=" + data[0].ToString() + "'>Xóa</a>";
                r.Cells.Add(c1);
                Table1.Rows.Add(r);
                j++;
            }
        }
    }
}