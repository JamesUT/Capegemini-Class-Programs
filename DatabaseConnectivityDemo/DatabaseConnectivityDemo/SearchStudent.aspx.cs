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
    
    public partial class SearchStudent : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString);
        SqlCommand cmd = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from ramya.student where studid = @SCode ", con);
            cmd.Parameters.AddWithValue("@SCode", txtCode.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                txtCode.Text = dr["studid"].ToString();
                txtName.Text = dr["studname"].ToString();
                txtAddress.Text = dr["emaiid"].ToString();
                txtDOB.Text = "01\012014";
                txtDCode.Text = "abcd";

                txtAddress.Enabled = true;
                txtCode.Enabled = true;
                txtDCode.Enabled = true;
                txtDOB.Enabled = true;
                txtName.Enabled = true;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                Response.Write("<SCRIPT type='text/javascript'>alert('Record not found for student code " + txtCode.Text + "');</SCRIPT>");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update ramya.student set studname = @studname,emaiid=@emaiid where studid=@studid", con);
            cmd.Parameters.AddWithValue("@studname", txtName.Text);
            cmd.Parameters.AddWithValue("@emaiid", txtAddress.Text);
            cmd.Parameters.AddWithValue("@studid", txtCode.Text);

            con.Open();
            int recaff = cmd.ExecuteNonQuery();
            con.Close();

            if(recaff > 0)
            {
                Response.Write("<SCRIPT type='text/javascript'>alert('Record update for student code " + txtCode.Text + "');</SCRIPT>");
                txtAddress.Enabled = false;
                //txtCode.Enabled = false;
                txtDCode.Enabled = false;
                txtDOB.Enabled = false;
                txtName.Enabled = false;

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                Response.Write("<SCRIPT type='text/javascript'>alert('Record not update for student code " + txtCode.Text + "');</SCRIPT>");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from ramya.student where studid = @studid", con);
            cmd.Parameters.AddWithValue("@studid" , txtCode.Text);
            con.Open();

            int rev = cmd.ExecuteNonQuery();
            con.Close();

            if(rev > 0 )
            {
                Response.Write("<SCRIPT type='text/javascript'>alert('Record deleted for student code " + txtCode.Text + "');</SCRIPT>");
            }
            else
            {
                Response.Write("<SCRIPT type='text/javascript'>alert('Record not deleted for student code " + txtCode.Text + "');</SCRIPT>");
            }
        }
    }
}