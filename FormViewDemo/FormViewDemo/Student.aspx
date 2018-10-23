<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="FormViewDemo.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FormView ID="fvStudent" runat="server" AllowPaging="True" DataKeyNames="Stud_Code" DataSourceID="sdsStudent">
            <EditItemTemplate>
                Stud_Code:
                <asp:Label ID="Stud_CodeLabel1" runat="server" Text='<%# Eval("Stud_Code") %>' />
                <br />
                Stud_Name:
                <asp:TextBox ID="Stud_NameTextBox" runat="server" Text='<%# Bind("Stud_Name") %>' />
                <br />
                Dept_Code:
                <asp:TextBox ID="Dept_CodeTextBox" runat="server" Text='<%# Bind("Dept_Code") %>' />
                <br />
                Stud_Dob:
                <asp:TextBox ID="Stud_DobTextBox" runat="server" Text='<%# Bind("Stud_Dob") %>' />
                <br />
                Address:
                <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Stud_Code:
                <asp:TextBox ID="Stud_CodeTextBox" runat="server" Text='<%# Bind("Stud_Code") %>' />
                <br />
                Stud_Name:
                <asp:TextBox ID="Stud_NameTextBox" runat="server" Text='<%# Bind("Stud_Name") %>' />
                <br />
                Dept_Code:
                <asp:TextBox ID="Dept_CodeTextBox" runat="server" Text='<%# Bind("Dept_Code") %>' />
                <br />
                Stud_Dob:
                <asp:TextBox ID="Stud_DobTextBox" runat="server" Text='<%# Bind("Stud_Dob") %>' />
                <br />
                Address:
                <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Stud_Code:
                <asp:Label ID="Stud_CodeLabel" runat="server" Text='<%# Eval("Stud_Code") %>' />
                <br />
                Stud_Name:
                <asp:Label ID="Stud_NameLabel" runat="server" Text='<%# Bind("Stud_Name") %>' />
                <br />
                Dept_Code:
                <asp:Label ID="Dept_CodeLabel" runat="server" Text='<%# Bind("Dept_Code") %>' />
                <br />
                Stud_Dob:
                <asp:Label ID="Stud_DobLabel" runat="server" Text='<%# Bind("Stud_Dob") %>' />
                <br />
                Address:
                <asp:Label ID="AddressLabel" runat="server" Text='<%# Bind("Address") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
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
