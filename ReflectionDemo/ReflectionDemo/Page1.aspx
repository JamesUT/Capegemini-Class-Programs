<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="ReflectionDemo.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Page 1 is Displayed</h1>
        <asp:Button ID="btnRedirect" runat="server" Text="Response.Redirect" OnClick="btnRedirect_Click" />
        <asp:Button ID="btnTransfer" runat="server" Text="Response.Transfer" OnClick="btnTransfer_Click" />
    </div>
    </form>
</body>
</html>
