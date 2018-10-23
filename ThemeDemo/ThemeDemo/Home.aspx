<%@ Page Language="C#" AutoEventWireup="true" Theme="Summer" CodeBehind="Home.aspx.cs" Inherits="ThemeDemo.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblHeader" SkinID="header" runat="server" Text="Registration Form :"></asp:Label>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblID"  runat="server" Text="Employee ID :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtID" SkinID="textbox" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblName" runat="server" Text="Employee Name :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" SkinID="textbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblAddress" runat="server" Text="Employee Address :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress" SkinID="textbox" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnReset" SkinID="button" runat="server" Text="Reset" />
                </td>
                <td>
                    <asp:Button ID="btnSubmit" SkinID="button" runat="server" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblFooter" SkinID="message" runat="server" Text="Message :"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
