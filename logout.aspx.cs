using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_News_Website
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Request.Cookies["userCookie"].Value = null;
            Request.Cookies["userCookie"].Expires = DateTime.Now.AddMinutes(-1);
            HttpContext.Current.Response.Cookies.Add(Request.Cookies["userCookie"]);

            //int count = (int)Application["session_counter"];
            //if (count > 0)
            //    count--;
            //Application["session_counter"] = count;

            Response.Redirect("trangchu.aspx");
        }
    }
}