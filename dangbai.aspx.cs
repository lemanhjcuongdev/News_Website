using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_News_Website
{
    public partial class dangbai : System.Web.UI.Page
    {
        private int inputID;
        private string inputTitle, inputContent, inputImage, inputCategory, inputTime, inputUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<News> dsBao = Application["newslist"] as List<News>;
            inputID = dsBao.Count +1 ;
            inputTitle = Request.Form["inputTitle"];
            inputContent = Request.Form["inputContent"];
            inputCategory = Request.Form["inputCategory"];
            if (inputCategory == "Khoa học & Công nghệ")
            {
                inputImage = "asset/images/Science_Technology.jpg";
            }
            else if (inputCategory == "Xã hội")
            {
                inputImage = "asset/images/society.jpg";
            }
            else if (inputCategory == "Thể thao")
            {
                inputImage = "asset/images/e_sport.jpg";
            }
            else inputImage = "";
        }
    }
}