<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AutoPostBack.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b>Select City :</b>
        <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
        <div id="divCity" runat="server" visible="false">
            <b>If others,Please Specify :</b>
            <asp:TextBox id:"textCity" runat="server"></asp:TextBox>        
        </div>
    </div>
    </form>
</body>
</html>
