<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicHtml.aspx.cs" Inherits="HtmlToImage.DynamicHtml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height:250px;width:300px;border-radius:3px;">
        <p>This is dynamic html, Image will be generated for this html</p>
        <p>This image is created by <%=dynamicText %></p>
        <p>Current DateTime is <%=currentDate %></p>
    </div>
    </form>
</body>
</html>
