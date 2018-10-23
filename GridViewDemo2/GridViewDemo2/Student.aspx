<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="GridViewDemo2.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvStudent" runat="server" DataSourceID="sdsTraining" AutoGenerateColumns="False" DataKeyNames="Stud_Code">
            <Columns>
                <asp:BoundField DataField="Stud_Code" HeaderText="Stud_Code" ReadOnly="True" SortExpression="Stud_Code" />
                <asp:BoundField DataField="Stud_Name" HeaderText="Stud_Name" SortExpression="Stud_Name" />
                <asp:BoundField DataField="Dept_Code" HeaderText="Dept_Code" SortExpression="Dept_Code" />
                <asp:BoundField DataField="Stud_Dob" HeaderText="Stud_Dob" SortExpression="Stud_Dob" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        
        <asp:SqlDataSource ID="sdsTraining" runat="server" ConnectionString="<%$ ConnectionStrings:Training %>" SelectCommand="SELECT * FROM [Student_master]" DeleteCommand="DELETE FROM [Student_master] WHERE [Stud_Code] = @Stud_Code" InsertCommand="INSERT INTO [Student_master] ([Stud_Code], [Stud_Name], [Dept_Code], [Stud_Dob], [Address]) VALUES (@Stud_Code, @Stud_Name, @Dept_Code, @Stud_Dob, @Address)" UpdateCommand="UPDATE [Student_master] SET [Stud_Name] = @Stud_Name, [Dept_Code] = @Dept_Code, [Stud_Dob] = @Stud_Dob, [Address] = @Address WHERE [Stud_Code] = @Stud_Code">
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
