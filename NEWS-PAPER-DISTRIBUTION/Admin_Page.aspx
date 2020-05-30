<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Admin_Page.aspx.vb" Inherits="NEWS_PAPER_DISTRIBUTION.Admin_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" Orientation="Horizontal" runat="server">
                <Items>
                    <asp:MenuItem Text="Customers" Value="0" Selected="true"></asp:MenuItem>
                    <asp:MenuItem Text="Vendors" Value="1"></asp:MenuItem>
                </Items>
            </asp:Menu>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="My_Customers" runat="server">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="f_name" HeaderText="Fisrt Name" />
                            <asp:BoundField DataField="l_name" HeaderText="Last Name" />
                            <asp:BoundField DataField="u_name" HeaderText="User Name" />
                            <asp:BoundField DataField="u_id" HeaderText="Customer ID" />
                            <asp:BoundField DataField="email" HeaderText="E-Mail" />
                            <asp:BoundField DataField="mobile" HeaderText="Mobile" />
                            <asp:BoundField DataField="address" HeaderText="Address" />
                            <asp:BoundField DataField="pincode" HeaderText="PinCode" />
                        </Columns>
                    </asp:GridView>
                </asp:View>
                <asp:View ID="My_Vendors" runat="server">
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="f_name" HeaderText="Fisrt Name" />
                            <asp:BoundField DataField="l_name" HeaderText="Last Name" />
                            <asp:BoundField DataField="v_name" HeaderText="User Name" />
                            <asp:BoundField DataField="v_id" HeaderText="Vendor ID" />
                            <asp:BoundField DataField="v_e_mail" HeaderText="E-Mail" />
                            <asp:BoundField DataField="mobile" HeaderText="Mobile" />
                            <asp:BoundField DataField="pincode" HeaderText="PinCode" />
                        </Columns>
                    </asp:GridView>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
