<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Vendor_Page.aspx.vb" Inherits="NEWS_PAPER_DISTRIBUTION.Vendor_UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 134px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" Orientation="Horizontal" runat="server">
                <Items>
                    <asp:MenuItem Text="My_Profile" Value="0" Selected="true"></asp:MenuItem>
                    <asp:MenuItem Text="My Customer" Value="1"></asp:MenuItem>
                    <asp:MenuItem Text="Contact" Value="2"></asp:MenuItem>
                </Items>
           </asp:Menu>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="My_Profile" runat="server">
                    <div>

                        Name&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp; Mobile Number&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        <br />
                        Vendor ID&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp; Pincode&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

                        <br />
                        <hr />
                        <br />
                        Update Your Information<br />
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style1">Fisrt Name</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" Height="32px" ReadOnly="True" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Last Name</td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" Height="32px" ReadOnly="True" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">UserName</td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server" Height="32px" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">E-Mail</td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" Height="32px" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Mobile</td>
                                <td>
                                    <asp:TextBox ID="TextBox8" runat="server" Height="32px" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Pincode</td>
                                <td>
                                    <asp:TextBox ID="TextBox9" runat="server" Height="32px" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Update Profile" />
                        <br />
                        <br />
                        <asp:Button ID="Button2" runat="server" Text="Log_Out" />
                        <br />
                    </div>
                </asp:View>
                <asp:View ID="My_Customer" runat="server">
                    <div>
                        My Customers
                        <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server">
                            <Columns>
                                <asp:BoundField DataField="C_Name" HeaderText="Customer Name" />
                                <asp:BoundField DataField="C_ID" HeaderText="Customer ID" />
                                <asp:BoundField DataField="Subscription" HeaderText="Subscription" />
                                <asp:BoundField DataField="Date_Of_Subscribe" HeaderText="Date Of Subscribe" />
                            </Columns>
                        </asp:GridView>
                        <br />
                        <br />
                        <asp:Button ID="Button3" runat="server" Text="Log_Out" />
                    </div>
                </asp:View>
                <asp:View ID="Contact" runat="server">
                    <div>
                        <asp:Table ID="Table2" runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px" ColumnSpan="6">Get-In Touch</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell>
                                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px" ColumnSpan="6" RowSpan="6">
                                    <asp:TextBox ID="TextBox3" Width="350" TextMode="MultiLine" runat="server"></asp:TextBox></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                            </asp:TableRow>
                        </asp:Table>
                        <br />
                        <br />
                        <asp:Button ID="Button4" runat="server" Text="Log_Out" />
                    </div>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
