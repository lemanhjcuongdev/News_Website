<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="dangbai.aspx.cs" Inherits="BTL_News_Website.dangbai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html lang="vi">
    <head>
      <meta charset="UTF-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <title>Document</title>
    </head>
    <body>
      <form action="dangbai.aspx" method="post">
        <label>Tiêu đề</label>
        <textarea name="inputTitle" id="inputTitle" cols="180" rows="10"></textarea>
        <label>Nội dung bài báo</label>
        <textarea name="inputContent" id="inputContent" cols="180" rows="26"></textarea>
        <input type="submit" value="Đăng bài">
        <input type="file" name="inputImage" id="inputImage" accept="image/png, image/jpeg, image/gif"/>
      </form>
    </body>
    </html>
</asp:Content>
