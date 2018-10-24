<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ViewStateDemo.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <b>Counter value :</b> <asp:Label ID="lblCounter" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
    </div>
    </form>
</body>
</html>
