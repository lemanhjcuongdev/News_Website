﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="trangchu.aspx.cs" Inherits="BTL_News_Website.trangchu" ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="asset/css/trangchu_style.css" />
        <title>CQT News</title>
    </head>
    <body>
        <section class="content">

        </section>
        <script>
            const renderNewsList = document.querySelector(".content");

            renderNewsList.innerHTML = "<%= Session["renderNewsList"] %>";
        </script>
    </body>
    </html>
</asp:Content>

