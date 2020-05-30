<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Forgot_Password.aspx.vb" Inherits="NEWS_PAPER_DISTRIBUTION.Forgot_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 165px;
        }
        .auto-style2 {
            width: 1197px;
        }
        .auto-style3 {
            width: 165px;
            height: 140px;
        }
        .auto-style4 {
            width: 1197px;
            height: 140px;
        }
        .auto-style5 {
            height: 140px;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            height: 73px;
        }
        .auto-style8 {
            height: 73px;
            width: 275px;
        }
        .auto-style9 {
            height: 73px;
            width: 289px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">Forgot Password</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">User Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Customer</asp:ListItem>
                            <asp:ListItem>Vendor</asp:ListItem>
                        </asp:DropDownList></td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style8">UserName</td>
                                <td class="auto-style9">
                                    <asp:TextBox ID="TextBox3" runat="server" Height="40px" Width="250px"></asp:TextBox>
                                </td>
                                <td class="auto-style7">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Email</td>
                                <td class="auto-style9">
                                    <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="250px"></asp:TextBox>
                                </td>
                                <td class="auto-style7">
                                    <asp:Button ID="Button1" runat="server" Height="51px" Text="Send OTP" Width="144px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">OTP</td>
                                <td class="auto-style9">
                                    <asp:TextBox ID="TextBox2" runat="server" Height="40px" Width="250px"></asp:TextBox>
                                </td>
                                <td class="auto-style7">
                                    <asp:Button ID="Button2" runat="server" Height="51px" Text="Verify" Width="144px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8"></td>
                                <td class="auto-style9">
                                    <asp:Button ID="Button3" runat="server" Height="51px" Text="Send Password " Width="159px" />
                                </td>
                                <td class="auto-style7"></td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
