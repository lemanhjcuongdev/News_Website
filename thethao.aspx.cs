using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_News_Website
{
    public partial class thethao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Thể thao - Báo điện tử CQT - CQT News";
            List<News> news = (List<News>)Application["newslist"];
            List<News> tt = new List<News>();

            foreach (News sp in news)
            {
                if (sp.Category.Equals("Thể thao"))
                {
                    tt.Add(sp);
                }
            }

            string html = "";
            foreach (News sp in tt)
            {
                html += "<section class='item'>" +
                    "<a href='trangconchitiet.aspx?id=" + sp.Id + "'>" +
                    "<img src='" + sp.Image + "' />" +
                    "<p class='title'>" + sp.Title + "</p>" +
                    "<section class='description'>" +
                    "<p class='time'>" + sp.Time + "  • </p>" +
                    "<p class='category'>" + sp.Category + "</p>" +
                    "</section>" +
                    "</a>" +
                    "</section>";
            }
            body.InnerHtml = html;
        }
    }
}