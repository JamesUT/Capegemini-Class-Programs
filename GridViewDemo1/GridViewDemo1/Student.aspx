<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="GridViewDemo1.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvStudent" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Stud_Code" DataSourceID="SqlDataSource1" PageSize="7" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="Stud_Code" HeaderText="Stud_Code" ReadOnly="True" SortExpression="Stud_Code" />
                <asp:BoundField DataField="Stud_Name" HeaderText="Stud_Name" SortExpression="Stud_Name" />
                <asp:BoundField DataField="Dept_Code" HeaderText="Dept_Code" SortExpression="Dept_Code" />
                <asp:BoundField DataField="Stud_Dob" HeaderText="Stud_Dob" SortExpression="Stud_Dob" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Training %>" SelectCommand="SELECT * FROM [Student_master]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
