<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="ReeaterDemo.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="repStudent" runat="server" DataSourceID="sdsStudent">
            <ItemTemplate>
                <asp:Label ID="lblStudCode" runat="server" Text='<%# Eval("Stud_Code") %>'></asp:Label>
                <asp:Label ID="lblStudName" runat="server" Text='<%# Eval("Stud_Name") %>'></asp:Label>
            </ItemTemplate>
            <SeparatorTemplate>
                <hr />
            </SeparatorTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="sdsStudent" runat="server" ConnectionString="<%$ ConnectionStrings:Training %>" DeleteCommand="DELETE FROM [Student_master] WHERE [Stud_Code] = @Stud_Code" InsertCommand="INSERT INTO [Student_master] ([Stud_Code], [Stud_Name], [Dept_Code], [Stud_Dob], [Address]) VALUES (@Stud_Code, @Stud_Name, @Dept_Code, @Stud_Dob, @Address)" SelectCommand="SELECT * FROM [Student_master]" UpdateCommand="UPDATE [Student_master] SET [Stud_Name] = @Stud_Name, [Dept_Code] = @Dept_Code, [Stud_Dob] = @Stud_Dob, [Address] = @Address WHERE [Stud_Code] = @Stud_Code">
            <DeleteParameters>
                <asp:Parameter Name="Stud_Code" Type="Decimal" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Stud_Code" Type="Decimal" />
                <asp:Parameter Name="Stud_Name" Type="String" />
                <asp:Parameter Name="Dept_Code" Type="Decimal" />
                <asp:Parameter Name="Stud_Dob" Type="DateTime" />
                <asp:Parameter Name="Address" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Stud_Name" Type="String" />
                <asp:Parameter Name="Dept_Code" Type="Decimal" />
                <asp:Parameter Name="Stud_Dob" Type="DateTime" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="Stud_Code" Type="Decimal" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
