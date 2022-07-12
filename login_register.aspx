<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="login_register.aspx.cs" Inherits="BTL_News_Website.login_register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>
    <%-- Đẩy r đấy --%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Đăng nhập Đăng ký</title>
</head>
<body style="display:block">
        <table>
            <tr>
                <td>
                    <h1>Đăng nhập</h1>
                    <%--<p>Nếu bạn đã có tài khoản thì hãy đăng nhập để đăng báo</p>--%>
                    <form id="formdn" method ="post" action="#">
                        <label>Tài khoản: </label> 
                        <input type ="text" class ="taikhoan" name="inputTK" /><br />
                        <label>Mật khẩu: </label> 
                        <input type ="text" class ="matkhau" name="inputMK" /><br />
                        <button type="submit" id="btnDangNhap">ĐĂNG NHẬP</button>
                    </form>
                </td>

                <td>
                    <h1>Đăng ký</h1>
<%--                    <p>Nếu chưa có tài khoản, đăng ký ngay!</p>--%>
                    <form id="form2" method ="post" action="#">
                        <label>Tài khoản: </label> 
                        <input type ="text" class ="taikhoan1" name="inputTKDK" /><br />
                        <label>Mật khẩu: </label> 
                        <input type ="text" class ="matkhau1" name="inputMKDK" /><br />
                        <label>Nhập lại mật khẩu: </label> 
                        <input type ="text" class ="check" name="inputMKCheckDK" /><br />
                        <button class ="dangky" type ="submit"> ĐĂNG KÝ</button>
                    </form>
                </td>
             </tr>
        </table>
</body>
    <script>
        const tkDN = document.querySelector(".taikhoan");
        const mkDN = document.querySelector(".matkhau");
        const tkDK = document.querySelector(".taikhoan1");
        const mkDK = document.querySelector(".matkhau1");
        const checkDK = document.querySelector(".check");
        var btnDN = document.querySelector('#btnDangNhap')
        var btnDK = document.querySelector('button[class="dangky"]')
        const formDK = document.querySelector('#form2')
        const formDN = document.querySelector('#formdn')

        btnDN.addEventListener('click', function (e) {
            e.preventDefault();
            if (tkDN.value.trim() === "") {
                alert("Tài khoản không được trống");
            }
            else if (mkDN.value.trim() === "") {
                alert("Mật khẩu không được trống");
            } else {
                formDN.submit();
            }
        })

        btnDK.addEventListener('click', function (e) {
            e.preventDefault();
            if (tkDK.value.trim() === "") {
                alert("Tài khoản không được trống");
            }
            else if (mkDK.value.trim() === "") {
                alert("Mật khẩu không được trống");
            }
            else if (checkDK.value.trim() != mkDK.value.trim()) {
                alert("Mật khẩu không trùng khớp");
                checkDK.focus();
            } else {
                formDK.submit();
            }
        })

    </script>
</html>

</asp:Content>
