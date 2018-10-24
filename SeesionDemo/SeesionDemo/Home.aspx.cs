using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeesionDemo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Session["counter"] = 0;
                lblSessionID.Text = Session.SessionID;
                lblSessionCounter.Text = Session["counter"].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int cnt = (int)Session["counter"];
            cnt = cnt + 1;
            Session["counter"] = cnt;
            lblSessionCounter.Text = Session["counter"].ToString();
        }
    }
}