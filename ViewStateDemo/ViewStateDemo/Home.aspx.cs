using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["Counter"] = 0;
                lblCounter.Text = ViewState["Counter"].ToString();
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            int cnt = (int) ViewState["Counter"];
            cnt++;
            ViewState["Counter"] = cnt;
            lblCounter.Text = ViewState["Counter"].ToString();
        }
    }
}