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
    public partial class suacb1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!Page.IsPostBack)
            {
                string constring = WebConfigurationManager.ConnectionStrings["vxlam"].ConnectionString;
                SqlConnection mycon = new SqlConnection(constring);
                mycon.Open();
                string sql = "select * from canbo where MaCB='" + Request.QueryString["macb"].ToString() + "'";
                SqlCommand mycmd = new SqlCommand(sql, mycon);
                SqlDataReader data = mycmd.ExecuteReader();
                if (data.Read())
                {
                    txtmacb.Text = data[0].ToString();
                    txtten.Text = data[1].ToString();
                    txtngaysinh.Text = data[2].ToString();
                    txtgioitinh.Text = data[3].ToString();
                    txtque.Text = data[4].ToString();
                    txtchucvu.Text = data[5].ToString();
                    label_anh.Text = "<img src='" + data[6].ToString() + "' width='100px'>";
                }
                mycon.Close();
            }
           
        }

        protected void btlLuu_Click(object sender, EventArgs e)
        {
            string constring = WebConfigurationManager.ConnectionStrings["vxlam"].ConnectionString;
            SqlConnection mycon = new SqlConnection(constring);
            mycon.Open();
            
            
           
            string filename = "";
            if (FileUpload1.HasFiles)
            {
                filename = "Images/" + FileUpload1.FileName;
                string filepath = MapPath(filename);
                FileUpload1.SaveAs(filepath);
                SqlCommand mycmd = new SqlCommand("sp_suacb", mycon);
                mycmd.CommandType = System.Data.CommandType.StoredProcedure;
                mycmd.Parameters.AddWithValue("@macb", txtmacb.Text);
                mycmd.Parameters.AddWithValue("@tencb", txtten.Text);
                mycmd.Parameters.AddWithValue("@ns", txtngaysinh.Text);
                mycmd.Parameters.AddWithValue("@gt", txtgioitinh.Text);
                mycmd.Parameters.AddWithValue("@que", txtque.Text);
                mycmd.Parameters.AddWithValue("@chucvu", txtchucvu.Text);
                mycmd.Parameters.AddWithValue("@anh", filename);
                mycmd.ExecuteNonQuery();
                mycon.Close();
                Response.Redirect("HienCB1.aspx");
            }
            else
            {
                SqlCommand mycmd = new SqlCommand("capnhat_cb", mycon);
                mycmd.CommandType = System.Data.CommandType.StoredProcedure;
                mycmd.Parameters.AddWithValue("@macb", txtmacb.Text);
                mycmd.Parameters.AddWithValue("@tencb", txtten.Text);
                mycmd.Parameters.AddWithValue("@ns", txtngaysinh.Text);
                mycmd.Parameters.AddWithValue("@gt", txtgioitinh.Text);
                mycmd.Parameters.AddWithValue("@que", txtque.Text);
                mycmd.Parameters.AddWithValue("@chucvu", txtchucvu.Text);
               
                mycmd.ExecuteNonQuery();
                mycon.Close();
                Response.Redirect("HienCB1.aspx");
            }
        }
    }
}