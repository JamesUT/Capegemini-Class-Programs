<%@ Page Title="" Language="C#" MasterPageFile="~/CompanyMaster.Master" AutoEventWireup="true" CodeBehind="InsertStudent.aspx.cs" Inherits="DatabaseConnectivityDemo.InsertStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <table style="width:100%">
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblCode" runat="server" Text="StudentCode"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtCode" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td style="width:60%">
                <asp:RequiredFieldValidator ID="rfvCode" runat="server"  
                        ControlToValidate="txtCode"  Display="Dynamic"
                        ErrorMessage="Code should be provided" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvCode" runat="server"
                        ControlToValidate="txtCode" Type="Integer"
                        MinimumValue="1000" MaximumValue="10000"
                        Text="[Code should be between 1000 and 10000]"
                        ErrorMessage="Code should be between 1000 and 10000" ForeColor="Red"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblName" runat="server" Text="StudentName"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                        ControlToValidate="txtName" Display="Dynamic" 
                        ErrorMessage="Student Name Should be Provided" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revName" runat="server" ControlToValidate="txtName" ValidationExpression="[A-Z][a-z, ]+" Text="[Please provide Student name and it should start with capital Letters]" ErrorMessage="Employteee name should start with capital letters and must contain only alphabets" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblDCode" runat="server" Text="DepartmentCode"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtDCode" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rvfDCode" runat="server"  
                        ControlToValidate="txtDCode"  Display="Dynamic"
                        ErrorMessage="Code should be provided" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvDCode" runat="server"
                        ControlToValidate="txtDCode" Type="Integer"
                        MinimumValue="1000" MaximumValue="10000"
                        Text="[Code should be between 1000 and 10000]"
                        ErrorMessage="Code should be between 1000 and 10000" ForeColor="Red"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblDOB" runat="server" Text="DateofBirth"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="rfvBOB" runat="server"
                        ControlToValidate="txtDOB" Text="[Please provid Date of Birth]"
                        ErrorMessage ="Date of Birth should be provided" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvDOB" runat="server"
                        ControlToValidate="txtDOB" Type="Date" Operator="DataTypeCheck"
                        Text="[Please provide proper Date]" ErrorMessage="Date should be in the format MM/DD/YY"
                        ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            </td>
            <td></td>
        </tr>
    </table>
</asp:Content>
