using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseConnectivityDemo
{
    public partial class InsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into ramya.student (studid,studname,emaiid) values (@studid,@studname,@emaiid)",con);
            cmd.Parameters.AddWithValue("@studid", txtCode.Text);
            cmd.Parameters.AddWithValue("@studname", txtName.Text);
            cmd.Parameters.AddWithValue("@emaiid", txtAddress.Text);
            con.Open();

            int recAff = cmd.ExecuteNonQuery();
            con.Close();
            if (recAff > 0)
            {
                Response.Write("<SCRIPT type='text/javascript'>alert('Record Updated');</SCRIPT>");
            }
            else
            {
                Response.Write("<SCRIPT type='text/javascript'>alert('Record not updated');</SCRIPT>");
            }
        }
    }
}