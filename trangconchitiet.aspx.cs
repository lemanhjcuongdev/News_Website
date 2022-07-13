using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_News_Website
{
    public partial class trangconchitiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ID = Request.QueryString["id"];
            if (ID != null)
            {
                //Response.Write(ID);
                List<News> dsBao = Application["newslist"] as List<News>;
                string sHTML = "";
                for(int i = 0; i<dsBao.Count; i++)
                {
                    //Response.Write(dsBao[i].Id);
                    if (dsBao[i].Id == int.Parse(ID))
                    {
                        //Response.Write(dsBao[i].Id);
                        sHTML += "<div class='head'>" +
                        "<p> Tin tức </p>" + "<h1>" + Server.HtmlDecode(dsBao[i].Title) + "</h1>" +
                        "</div>" + "<div class='description'>" + "<img src='" + dsBao[i].Image + "'/>" +
                        "<p class='title'>" + Server.HtmlDecode(dsBao[i].Content) + "</p>" + "</div>";

                    }
                }
                Session["renderTrangconchitiet"] = sHTML;
            }
        }
    }
}