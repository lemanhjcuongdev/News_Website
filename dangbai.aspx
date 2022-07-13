<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="dangbai.aspx.cs" Inherits="BTL_News_Website.dangbai" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
      <meta charset="UTF-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="asset/css/dangbai_style.css" />
      <title>Document</title>
    </head>
    <body>
      <form class="dangbai" action="dangbai.aspx" method="post" enctype="multipart/form-data">
        <label>Nhập tiêu đề bài báo</label>
          <br />
        <textarea name="inputTitle" id="inputTitle" cols="180" rows="4" required="required"></textarea>
          <br />
        <label>Nhập nội dung bài báo</label>
          <br />
        <textarea name="inputContent" id="inputContent" cols="180" rows="18" required="required"></textarea>
          <br />
        <label>Chọn ảnh cho bài báo: </label>
        <input type="file" name="inputImage" id="inputImage" accept="image/*" required="required"/>
        <br />
        <label>Chọn thể loại: </label>
        <select name="inputCategory" class="category">
            <option value="Khoa học & Công nghệ">Khoa học & Công nghệ</option>
            <option value="Xã hội">Xã hội</option>
            <option value="E-sport">Thể thao</option>
        </select>
        <br />
        <%--<input id="submit" type="submit" value="ĐĂNG BÀI"/>--%>
          <button id="submit" type="submit">ĐĂNG BÀI</button>
      </form>
    </body>
        <script>
            const cate_Select = document.querySelector(".category");
            const inputTitle = document.querySelector("#inputTitle");
            const inputContent = document.querySelector("#inputContent");
            const btnSubmit = document.querySelector("#submit");
            const formDangBai = document.querySelector(".dangbai")
            //btnSubmit.addEventListener("click", function (e) {
            //    e.preventDefault();
            //    let noti = "";
            //    if (inputTitle.value.trim() == "") {
            //        noti += "Tiêu đề không được trống. ";
            //    }
            //    if (inputContent.value.trim() == "") {
            //        noti += "Nội dung không được trống. ";
            //    }
            //    if (noti != "") {
            //        /*                    e.preventDefault();*/
            //        alert(noti);
            //    } else {
            //        console.log("Alo123");
            //        formDangBai.submit();
            //    }
            //})
        </script>
    </html>
</asp:Content>
