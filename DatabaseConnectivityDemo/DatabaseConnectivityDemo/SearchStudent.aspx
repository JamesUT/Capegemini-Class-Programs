<%@ Page Title="" Language="C#" MasterPageFile="~/CompanyMaster.Master" AutoEventWireup="true" CodeBehind="SearchStudent.aspx.cs" Inherits="DatabaseConnectivityDemo.SearchStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <table style="width:100%">
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblCode" runat="server" Text="StudentCode"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtCode" runat="server" TextMode="Number" ></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Search" runat="server" Text="Search" OnClick="Search_Click" />
            <td>
            <td style="width:60%">
                <asp:RequiredFieldValidator ID="rfvCode" runat="server"  
                        ControlToValidate="txtCode"  Display="Dynamic"
                        ErrorMessage="Code should be provided" ForeColor="Red" ValidationGroup="Search"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvCode" runat="server"
                        ControlToValidate="txtCode" Type="Integer"
                        MinimumValue="1000" MaximumValue="10000"
                        Text="[Code should be between 1000 and 10000]"
                        ErrorMessage="Code should be between 1000 and 10000" ForeColor="Red" ValidationGroup="Search"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblName" runat="server" Text="StudentName"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtName" runat="server" Enabled="false"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                        ControlToValidate="txtName" Display="Dynamic" 
                        ErrorMessage="Student Name Should be Provided" ForeColor="Red" ValidationGroup="Update"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revName" runat="server" ValidationGroup="Update" ControlToValidate="txtName" ValidationExpression="[A-Z][a-z, ]+" Text="[Please provide Student name and it should start with capital Letters]" ErrorMessage="Employteee name should start with capital letters and must contain only alphabets" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblDCode" runat="server" Text="DepartmentCode"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtDCode" runat="server" TextMode="Number" Enabled="false"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rvfDCode" runat="server"  
                        ControlToValidate="txtDCode"  Display="Dynamic"
                        ErrorMessage="Code should be provided" ForeColor="Red" ValidationGroup="Update"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvDCode" runat="server"
                        ControlToValidate="txtDCode" Type="Integer"
                        MinimumValue="1000" MaximumValue="10000"
                        Text="[Code should be between 1000 and 10000]"
                        ErrorMessage="Code should be between 1000 and 10000" ForeColor="Red" ValidationGroup="Update"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblDOB" runat="server" Text="DateofBirth"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtDOB" runat="server" Enabled="false"></asp:TextBox>
            </td>
            <asp:RequiredFieldValidator ID="rfvBOB" runat="server"
                        ControlToValidate="txtDOB" Text="[Please provid Date of Birth]"
                        ErrorMessage ="Date of Birth should be provided" ForeColor="Red" ValidationGroup="Update" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvDOB" runat="server"
                        ControlToValidate="txtDOB" Type="Date" Operator="DataTypeCheck"
                        Text="[Please provide proper Date]" ValidationGroup="Update" ErrorMessage="Date should be in the format MM/DD/YY"
                        ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width:20%">
                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            </td>
            <td style="width:20%">
                <asp:TextBox ID="txtAddress" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Enabled="false" ValidationGroup="Update" OnClick="btnUpdate_Click" />
            </td>
            <td>
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Enabled="false" />
            </td>
            <td></td>
        </tr>
    </table>
</asp:Content>
