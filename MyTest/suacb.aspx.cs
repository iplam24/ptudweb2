using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace MyTest
{
    public partial class suacb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string macb = Request.QueryString["macb"];
                if ( macb != null )
                {
                    string constring = WebConfigurationManager.ConnectionStrings["dtnham"].ConnectionString;
                    SqlConnection mycon= new SqlConnection( constring );
                    mycon.Open();
                    string sql = "select * from canbo where MaCB='" + macb + "'";
                    SqlCommand mycmd=new SqlCommand(sql,mycon);
                    SqlDataReader data= mycmd.ExecuteReader();
                    if(data.Read())
                    {
                        txtmacb.Text = data[0].ToString();
                        txttencb.Text = data[1].ToString();
                        txtnsinh.Text = data[2].ToString();
                        txtgioitinh.Text= data[3].ToString();
                        txtque.Text = data[4].ToString();
                        txtchucvu.Text = data[5].ToString();
                    }
                    mycon.Close();
                }
            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            string constring = WebConfigurationManager.ConnectionStrings["dtnham"].ConnectionString;
            SqlConnection mycon = new SqlConnection(constring);
            mycon.Open();
            SqlCommand cmd=new SqlCommand("sp_Suacb",mycon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@macb",txtmacb.Text);
            cmd.Parameters.AddWithValue("@tencb",txttencb.Text);
            cmd.Parameters.AddWithValue("@ns", txtnsinh.Text);
            cmd.Parameters.AddWithValue("@gt", txtgioitinh.Text);
            cmd.Parameters.AddWithValue("@que", txtque.Text);
            cmd.Parameters.AddWithValue("@chucvu", txtchucvu.Text);
            cmd.ExecuteNonQuery();
            Response.Redirect("HienCB.aspx");
            mycon.Close();

        }
    }
}