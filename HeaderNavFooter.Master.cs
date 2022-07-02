using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_News_Website
{
    public partial class HeaderNavFooter : System.Web.UI.MasterPage
    {
        private string inputSearch;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Form["inputSearch"] != null)
            {
                inputSearch = Request.Form["inputSearch"];
                List<News> dsBao = Application["newslist"] as List<News>;

                int count = 0;
                string sHTML = "";
                for (int i = 0; i < dsBao.Count; i++)
                {
                    if(dsBao[i].Title.ToLower().Contains(inputSearch.ToLower()) == true)
                    {
                        count++;
                        sHTML += "<section class='item'>" +
                        "<a href='#'>" +
                        "<img src='" + dsBao[i].Image + "' />" +
                        "<p class='title'>" + dsBao[i].Title + "</p>" +
                        "<section class='description'>" +
                        "<p class='time'>" + dsBao[i].Time + " ngày trước • </p>" +
                        "<p class='category'>" + dsBao[i].Category + "</p>" +
                        "</section>" +
                        "</a>" +
                        "</section>";
                    }
                }
                if(count == 0)
                {
                    //Response.Redirect("trangchu.aspx");
                    Response.Write("<script>alert('Không tìm thấy bài báo nào với từ khóa: " + inputSearch + "')</script>");
                } else
                {
                    Response.Write("<script>alert('Có tổng cộng " + count + " bài báo')</script>");
                }
                Session["renderNewsList"] = sHTML;
            }
        }
    }
}