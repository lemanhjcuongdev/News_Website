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
        private string inputTitle, inputContent, inputImage, inputCategory, inputUrl;
        private DateTime inputTime;
        string fileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            inputTitle = Server.HtmlEncode(Request.Form["inputTitle"]);
            inputContent = Server.HtmlEncode(Request.Form["inputContent"]);
            inputTime = DateTime.Now;
            inputCategory = Request.Form["inputCategory"];

            if (inputTitle != null)
            {
                List<News> dsBao = Application["newslist"] as List<News>;
                inputID = dsBao.Count + 1;

                saveFile(Request.Files["inputImage"], Request.MapPath("~/asset/images/"));
                inputImage = "/asset/images/" + fileName;
                Response.Write(inputImage);
                inputUrl = "#";

                dsBao.Add(new News(inputID, inputTitle, inputContent, inputTime, inputCategory, inputImage, inputUrl));
                Application["newslist"] = dsBao;
                Response.Redirect("trangchu.aspx");
            }

        }
        public void saveFile(HttpPostedFile file, string path)
        {
            fileName = file.FileName;
            string filePath = path + fileName;
            file.SaveAs(filePath);
        }
    }
}