using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoPostBack
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ddlCity.Items.Add("Pune");
                ddlCity.Items.Add("Mumbai");
                ddlCity.Items.Add("Hyderabad");
                ddlCity.Items.Add("Chennai");
                ddlCity.Items.Add("Others");
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlCity.SelectedItem.Text == "Others")
            {
                divCity.Visible = true;
            }
            else
            {
                divCity.Visible = false;
            }
        }
    }
}