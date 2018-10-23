<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="ValidationControlsDemo.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <b>Employee ID :</b>
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtID" Display="Dynamic" Text="[Please Provide Employee ID]" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Employee Name :</b>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                        ControlToValidate="txtName" Display="Dynamic" 
                        ErrorMessage="Employee Name Should be Provided" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revName" runat="server" ControlToValidate="txtName" ValidationExpression="[A-Z][a-z, ]+" Text="[Please provide Employee name and it should start with capital Letters]" ErrorMessage="Employteee name should start with capital letters and " ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Age :</b>
                </td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvAge" runat="server"  
                        ControlToValidate="txtAge"  Display="Dynamic"
                        ErrorMessage="Age Should be Provided" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvAge" runat="server"
                        ControlToValidate="txtAge" Type="Integer"
                        MinimumValue="18" MaximumValue="60"
                        Text="[Please Provide the age between 18 to 60]"
                        ErrorMessage="Age should be within 18 to 60" ForeColor="Red"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Gender :</b>
                </td>
                <td>
                    <asp:RadioButton ID="rdbMale" GroupName="Gender" runat="server" Text="Male" />
                    <asp:RadioButton ID="rdbFemale" GroupName="Gender" runat="server" Text="Female" />
                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <b>City :</b>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server">
                        <asp:ListItem Selected="True" Text="Select City" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Pune" Value="Pune"></asp:ListItem>
                        <asp:ListItem Text="Mumbai" Value="Mumbai"></asp:ListItem>
                        <asp:ListItem Text="Banglore" Value="Banglore"></asp:ListItem>
                        <asp:ListItem Text="Chennai" Value="Chennai"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Date of Joining :</b>
                </td>
                <td>
                    <asp:TextBox ID="txtDOJ" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvDoj" runat="server"
                        ControlToValidate="txtDoj" Text="[Please provid Date of Joining]"
                        ErrorMessage ="Date of Joining should be provided" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvDOJ" runat="server"
                        ControlToValidate="txtDOJ" Type="Date" Operator="DataTypeCheck"
                        Text="[Please provide proper Date]" ErrorMessage="Date should be in the format MM/DD/YY"
                        ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Salary :</b>
                </td>
                <td>
                    <asp:TextBox ID="txtSalary" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvSalary" runat="server"
                        ControlToValidate="txtSalary" Text="[Please provide Salary]"
                        ErrorMessage ="Salary should be provided" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvSalary" runat="server"
                        ControlToValidate ="txtSalary" Type="Integer" Operator="GreaterThan"
                        ValueToCompare="10000" Text="[Please Provide Salary > 10000]" 
                        ErrorMessage="Should be >10000" ForeColor="Red" Display="Dynamic"> </asp:CompareValidator>
                </td>
            </tr>
            <tr>
            <td>
                <b>Project Start Date : </b>
            </td>
            <td>
                <asp:TextBox ID="txtStart" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvStart" runat="server" 
                    ControlToValidate="txtStart" 
                    Text="[Please provide Project Start Date]" 
                    ErrorMessage="Project Start date should be provided" 
                    ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
            <tr>
            <td>
                <b>Project End Date : </b>
            </td>
            <td>
                <asp:TextBox ID="txtEnd" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvEnd" runat="server" 
                    ControlToValidate="txtEnd" 
                    Text="[Please provide Project End Date]" 
                    ErrorMessage="Project End date should be provided" 
                    ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvEnd" runat="server" ControlToCompare="txtStart" ControlToValidate="txtEnd"
                    Type="Date" Operator="GreaterThan"
                    Text="[Please provide End Date grater then Start Date]"
                    ErrorMessage ="End Date should be grater then start date"
                    ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
            </td>
        </tr>
            <tr>
            <td>
                <b>Phone Number : </b>
            </td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvPhone" runat="server" 
                    ControlToValidate="txtPhone" 
                    Text="[Please provide phone number]" 
                    ErrorMessage="Phone no should be provided" 
                    ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revPhone" runat="server" 
                    ControlToValidate="txtPhone"
                    ValidationExpression="[7-9][0-9]{9}"
                    Text="[Please provide phone no starting with 7 or 8 or 9 and it should have 10 digits]" 
                    ErrorMessage="Phone no should have 10 digits and must start with 7 or 8 or 9" 
                    ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Email ID : </b>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                    ControlToValidate="txtEmail" 
                    Text="[Please provide Email ID]" 
                    ErrorMessage="Email ID should be provided" 
                    ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                    ControlToValidate="txtEmail"
                    ValidationExpression="\w+([-+.']\w+)*@\w+"
                    Text="[Please provide proper Email ID]" 
                    ErrorMessage="Email ID should be proper" 
                    ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit Data" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                <asp:ValidationSummary runat="server" DisplayMode="BulletList" />
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
