using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_News_Website
{
    public partial class login_register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> users = (List<User>)Application["Users"];
            string tkdk = Request.Form["inputTKDK"];
            string mkdk = Request.Form["inputMKDK"];
            string mkdkcheck = Request.Form["inputMKCheckDK"];
            string tkdn = Request.Form["inputTK"];
            string mkdn = Request.Form["inputMK"];

            if (tkdn != null && mkdn != null)
            {
                int checkdn = 0;
                int index = 0;
                for (int i = 0; i < users.Count; i++)
                {
                    if (String.Compare(users[i].Taikhoan, tkdn.ToString(), false) == 0 && String.Compare(users[i].Matkhau, mkdn.ToString(), false) == 0)
                    {
                        index = i;
                        checkdn++;
                        //Response.Redirect("trangchu");
                    }
                }
                if (checkdn > 0)
                {
                    HttpCookie mycookieDN = new HttpCookie("userCookie");
                    mycookieDN.Value = "" + tkdn;
                    mycookieDN.Expires = DateTime.Now.AddMinutes(10);
                    HttpContext.Current.Response.Cookies.Add(mycookieDN);
                    Response.Redirect("trangchu.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Sai tài khoản hoặc mật khẩu')</script>");
                }
            }

            else if (tkdk != null && mkdk != null && mkdkcheck != null)
            {
                int check = 0;
                for (int i = 0; i < users.Count; i++)
                {
                    if (String.Compare(users[i].Taikhoan, tkdk.ToString(), false) == 0)
                    {
                        check++;
                    }
                }
                if (check == 0)
                {
                    users.Add(new User(users.Count + 1, tkdk, mkdk, "user"));
                    HttpCookie mycookie = new HttpCookie("userCookie");
                    mycookie.Value = "" + tkdk;
                    mycookie.Expires = DateTime.Now.AddMinutes(10);
                    HttpContext.Current.Response.Cookies.Add(mycookie);
                    Response.Write("<script>alert('Đăng kí thành công')</script>");
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    Response.Write("<script>alert('Tài khoản đã tồn tại, vui lòng nhập tài khoản khác!')</script>");
                }
            }
        }
    }
}
