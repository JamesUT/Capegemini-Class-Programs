using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesDemo
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Label5_Click(object sender, EventArgs e)
        {
            HttpCookie ck = new HttpCookie("Data");
            ck.Values.Add("name", Label3.Text);
            ck.Values.Add("company", Label4.Text);
            ck.Expires = DateTime.Now.AddMinutes(2);
            Response.Cookies.Add(ck);
            Response.Write("Cookie Created");
        }
    }
}