<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="dangbai.aspx.cs" Inherits="BTL_News_Website.dangbai" %>
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
      <form class="dangbai" action="dangbai.aspx" method="post">
        <label>Nhập tiêu đề bài báo</label>
          <br />
        <textarea name="inputTitle" id="inputTitle" cols="180" rows="4"></textarea>
          <br />
        <label>Nhập nội dung bài báo</label>
          <br />
        <textarea name="inputContent" id="inputContent" cols="180" rows="18"></textarea>
          <br />
        <label>Chọn ảnh cho bài báo: </label>
        <input type="file" name="inputImage" id="inputImage" accept="image/*"/>
          <br />
          <label>Chọn thể loại: </label>
          <select name="inputCategory" class="category">
              <option value="Khoa học & Công nghệ">Khoa học & Công nghệ</option>
          </select>
          <br />
          <input type="submit" value="ĐĂNG BÀI">
      </form>
        <script>
            const cate_Select = document.querySelector(".category");

            cate_Select.innerHTML = <%= Session["cate_list"] %>;
        </script>
    </body>
    </html>
</asp:Content>
