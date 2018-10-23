<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FileUploadDemo.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:FileUpload ID="ful1" runat="server" AllowMultiple="true" />
    <asp:Button ID="btnUpload" runat="server" Text="Upload" />
    </div>
    </form>
</body>
</html>
