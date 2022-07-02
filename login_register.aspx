<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="login_register.aspx.cs" Inherits="BTL_News_Website.login_register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Đăng nhập Đăng ký</title>
</head>
<body>
    <form id="form1" method ="post">
        <table>
            <tr>
                <td>
                    <h1>Đăng nhập</h1>
                    <p>Nếu bạn đã có tài khoản thì hãy đăng nhập để đăng báo</p>
                    <label>Tài khoản: </label> 
                    <input type ="text" class ="taikhoan" name="inputTK" /><br />
                    <label>Mật khẩu: </label> 
                    <input type ="text" class ="matkhau" name="inputMK" /><br />
                    <button class="dangnhap" type ="button"> ĐĂNG NHẬP</button>
                </td>
                <td>
                    <h1>Đăng ký</h1>
                    <p>Nếu chưa có tài khoản, đăng ký ngay!</p>
                    <label>Tài khoản: </label> 
                    <input type ="text" class ="taikhoan1" name="inputTK1" /><br />
                    <label>Mật khẩu: </label> 
                    <input type ="text" class ="matkhau1" name="inputMK1" /><br />
                    <label>Nhập lại mật khẩu: </label> 
                    <input type ="text" class ="check" name="inputMK11" /><br />
                    <button class ="dangky" type ="button"> ĐĂNG KÝ</button>
                </td>
             </tr>
        </table>
    </form>
</body>
    <script>
        const tkDN = document.querySelector(".taikhoan");
        const mkDN = document.querySelector(".matkhau");
        const tkDK = document.querySelector(".taikhoan1");
        const mkDK = document.querySelector(".matkhau1");
        const checkDK = document.querySelector(".check");
        var btnDN = document.querySelector('button[class="dangnhap"]')
        var btnDK = document.querySelector('button[class="dangky"]')


        btnDN.addEventListener('click', function () {
            if (tkDN.value.trim() === "") {
                alert("Tài khoản không được trống");
            }
            if (mkDN.value.trim() === "") {
                alert("Mật khẩu không được trống");
            }
        })
        btnDK.addEventListener('click', function () {
            if (tkDK.value.trim() === "") {
                alert("Tài khoản không được trống");
            }
            if (checkDK.value.trim() != mkDK.value.trim()) {
                alert("Mật khẩu không trùng khớp");
            }
        })

    </script>
</html>

</asp:Content>
