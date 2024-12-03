<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Billings.aspx.cs" Inherits="HospitalManagment.Web_Pages.Billings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Billing</title>

    <link href="~/Css/Bill.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 194px;
        }
        .auto-style3 {
            margin-left: 197px;
            margin-bottom: 0px;
        }
    </style>
  
</head>
<body>
    <form id="form1" runat="server">
       <div>
        <h2>Billings</h2>
       
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPatientID" runat="server" Text="PatientID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtPatientID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAmount" runat="server" Text="Amount"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPaymentStatus" runat="server" Text="Payment Status"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPaymentStatus" runat="server">
                          <asp:ListItem Text="Paid" Value="Paid"></asp:ListItem>
            <asp:ListItem Text="Pending" Value="Pending"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPaymentDate" runat="server" Text="Payment Date"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Generate Bill" CssClass="auto-style3" OnClick="btnSubmit_Click" />
        </p>
    </form>
</body>
</html>
