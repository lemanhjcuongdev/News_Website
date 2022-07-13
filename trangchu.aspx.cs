using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_News_Website
{
    public partial class trangchu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["renderNewsList"] = renderNewsList();
        }
        private string renderNewsList()
        {
            string sHTML = "";
            List<News> dsBao = Application["newslist"] as List<News>;
            for(int i = 0; i < dsBao.Count; i++)
            {
                sHTML += "<section class='item'>" +
                    "<a href='trangconchitiet.aspx?id=" + dsBao[i].Id + "'>" +
                    "<img src='"+dsBao[i].Image+"' />" +
                    "<p class='title'>"+ Server.HtmlDecode(dsBao[i].Title)+"</p>" +
                    "<section class='description'>" +
                    "<p class='time'>"+dsBao[i].Time+ "  • </p>" +
                    "<p class='category'>"+dsBao[i].Category+"</p>" +
                    "</section>" +
                    "</a>" +
                    "</section>";
            }

            return sHTML;
        }
    }
}