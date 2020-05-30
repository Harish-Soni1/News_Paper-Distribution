<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="News-Paper-Distribution.aspx.vb" Inherits="NEWS_PAPER_DISTRIBUTION.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>   
        Body {  
          font-family: Calibri, Helvetica, sans-serif;  
          background-color: pink;  
        }  
        .Button {   
               background-color: #4CAF50;   
               width: 100%;  
                color: orange;   
                padding: 15px;   
                margin: 10px 0px;   
                border: none;   
                cursor: pointer;   
                 }   
         form {   
                border: 3px solid #f1f1f1;   
            }   
         input[type=text], input[type=password] {   
                width: 100%;   
                margin: 8px 0;  
                padding: 12px 20px;   
                display: inline-block;   
                border: 2px solid green;   
                box-sizing: border-box;   
            }
        .DropDownList {
            width: 100%;
            margin: 8px 0;
            padding: 12px 20px;
            border: 2px solid green;
            box-sizing: border-box;
        }
        Button:hover {
            opacity: 0.7;
        }

        .cancelbtn {
            width: auto;
            padding: 10px 18px;
            margin: 10px 5px;
        }
         .container {   
                padding: 25px;   
                background-color: lightblue;  
            }   
        </style>
</head>
<body>
    <h1> Login Here </h1>  
    <form id="form1" runat="server">
        <div>
            <label>
            <br />
             Log-In Type: </label><br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="174px" Font-Size="Large" Height="24px">
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Customer</asp:ListItem>
                <asp:ListItem>Vendor</asp:ListItem>
            </asp:DropDownList>
            <br />

            <label>
            <br />
            Username : </label>   
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<label>Password : </label>   
            <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" CssClass="Button" Text="Login" />   
            Forgot <asp:HyperLink ID="HyperLink3" runat="server"><a href="Forgot_Password.aspx">password?</a></asp:HyperLink>   
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server"><a href="Customer_Registeration.aspx">Create Customer Account</a></asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server"><a href="Vendor_Registration.aspx">Create Vendor Account</a></asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
