<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Vendor_Registration.aspx.vb" Inherits="NEWS_PAPER_DISTRIBUTION.Vendor_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 222px;
        }
        .auto-style2 {
            width: 279px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            NDS Vendor Registration<table style="width:100%;">
                <tr>
                    <td class="auto-style1">First Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="241px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Last Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Height="32px" Width="241px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">User Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" Height="32px" Width="241px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">E-Mail</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox8" runat="server" Height="32px" Width="241px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Mobile number</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server" Height="32px" Width="241px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Pincode</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox5" runat="server" Height="32px" Width="241px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox6" runat="server" Height="32px" Width="241px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Confirm Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox7" runat="server" Height="32px" Width="241px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
