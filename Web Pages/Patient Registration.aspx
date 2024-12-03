<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient Registration.aspx.cs" Inherits="HospitalManagment.Web_Pages.Patient_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Patient Registration Form</title>

<link href="~/Css/Registration.css" rel="stylesheet" type="text/css" />



    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 178px;
        }
        .auto-style5 {
            width: 165px;
        }
        .auto-style6 {
            width: 164px;
        }
        .auto-style7 {
            width: 172px;
        }
        .auto-style8 {
            margin-left: 171px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Patient Registration Form</h2>

        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="rbtMale" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="rbtFemale" runat="server"  GroupName="Gender" Text="Female" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblContact" runat="server" Text="Contact"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblMedicalHistory" runat="server" Text="Medical History"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMedicalHistory" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnSubbmit" runat="server" CssClass="auto-style8" OnClick="txtButton_Click" Text="Submmit" />
        </p>

    </form>
</body>
</html>
