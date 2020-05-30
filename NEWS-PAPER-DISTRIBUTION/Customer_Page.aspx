<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Customer_Page.aspx.vb" Inherits="NEWS_PAPER_DISTRIBUTION.Cust_UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 166px;
        }
        .auto-style3 {
            width: 166px;
            height: 42px;
        }
        .auto-style4 {
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:Menu ID="Menu1" Orientation="Horizontal" runat="server">
                    <Items>
                        <asp:MenuItem Text="My_Profile" Value="0" Selected="true"></asp:MenuItem>
                        <asp:MenuItem Text="Subcription" Value="1"></asp:MenuItem>
                        <asp:MenuItem Text="My Orders" Value="2"></asp:MenuItem>
                        <asp:MenuItem Text="Contact" Value="3"></asp:MenuItem>
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
                        Customer ID&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp; Address&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

                        <br />
                        <hr />
                        <br />
                        Update Your Information<br />
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style2">First Name</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" Height="32px" ReadOnly="True" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Last Name</td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" Height="32px" ReadOnly="True" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">User Name</td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server" Height="32px" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">E-Mail</td>
                                <td>
                                    <asp:TextBox ID="TextBox10" runat="server" Height="32px" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style3">Mobile Number</td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="TextBox7" runat="server" Height="32px" Width="241px"></asp:TextBox>
                                </td>
                                <td class="auto-style4"></td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Address</td>
                                <td>
                                    <asp:TextBox ID="TextBox8" runat="server" Height="32px" TextMode="MultiLine" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Pincode</td>
                                <td>
                                    <asp:TextBox ID="TextBox9" runat="server" Height="32px" Width="241px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        <br />
                        <asp:Button ID="Button7" runat="server" Text="Update Profile" />
                        <br />
                        <br />
                        <asp:Button ID="Button8" runat="server" Text="Log_Out" />
                    </div>
                </asp:View>
                <asp:View ID="Subscription" runat="server">
                    <div>
                        Subscription<br />
                        <br />
                        <asp:Table ID="Table1" runat="server">
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="9">DAILY NEWSPAPER</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="6">NEWS-PAPER</asp:TableCell>
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="2">90 Rs/Month</asp:TableCell>
                                <asp:TableCell runat="server">
                                    <asp:Button ID="Button1" runat="server" Text="SUBSCRIBE" /></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="9">ADD ON:</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="9">ARTICLES</asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="6">FOR KIDS</asp:TableCell>
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="2">120 Rs/Month</asp:TableCell>
                                <asp:TableCell runat="server"><asp:Button ID="Button2" runat="server" Text="SUBSCRIBE" /></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="6">FOR ADULTS</asp:TableCell>
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="2">150 Rs/Month</asp:TableCell>
                                <asp:TableCell runat="server"><asp:Button ID="Button3" runat="server" Text="SUBSCRIBE" /></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="6">FOR WOMEN</asp:TableCell>
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="2">120 Rs/Month</asp:TableCell>
                                <asp:TableCell runat="server"><asp:Button ID="Button4" runat="server" Text="SUBSCRIBE" /></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="6">TECHNOLOGY</asp:TableCell>
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="2">160 Rs/Month</asp:TableCell>
                                <asp:TableCell runat="server"><asp:Button ID="Button5" runat="server" Text="SUBSCRIBE" /></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" BorderStyle="Solid">
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="6">SPORTS</asp:TableCell>
                                <asp:TableCell runat="server" BorderStyle="Solid" ColumnSpan="2">
                                    160 Rs/Month</asp:TableCell>
                                <asp:TableCell runat="server"><asp:Button ID="Button6" runat="server" Text="SUBSCRIBE" /></asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <br />
                        <br />
                        <asp:Button ID="Button9" runat="server" Text="Log_Out" />
                    </div>
                </asp:View>
                <asp:View ID="My_Orders" runat="server">
                    <div>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="subscription_id" HeaderText="Subscription ID"/>
                                <asp:BoundField DataField="c_name" HeaderText="Customer Name"/>
                                <asp:BoundField DataField="c_id" HeaderText="Customer ID"/>
                                <asp:BoundField DataField="subcription" HeaderText="Subscription"/>
                                <asp:BoundField DataField="date" HeaderText="Date"/>
                                <asp:BoundField DataField="price" HeaderText="Price"/>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="linkUnsub" Text="UnSubscribe" runat="server" OnClick="linkUnsub_Click"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        
                        <br />
                        <br />
                        <asp:Button ID="Button10" runat="server" Text="Log_Out" />
                        
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
                        <asp:Button ID="Button11" runat="server" Text="Log_Out" />
                        <br />
                    </div>
                </asp:View>
            </asp:MultiView>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
