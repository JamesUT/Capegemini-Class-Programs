<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="DetailsViewDemo.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DetailsView ID="dvStudent" runat="server" AllowPaging="True" DataSourceID="sdsStudent">
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
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
