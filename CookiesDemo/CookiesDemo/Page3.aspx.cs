using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesDemo
{
    public partial class Page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie ck = Request.Cookies["Data"];
            if (ck != null)
            {
                Label1.Text = ck["name"];
                Label2.Text = ck["company"];
            }
        }
    }
}