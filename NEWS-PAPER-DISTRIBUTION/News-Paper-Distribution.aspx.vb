Imports MySql.Data.MySqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim cn As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox5.Text = " " And TextBox6.Text = " " Then
            MsgBox("Please Enter UserName and Password")
        End If
        If DropDownList1.Text = "Admin" Then
            Dim u As String = TextBox5.Text
            Dim p As String = TextBox6.Text
            Dim s As String = "select * from admin where user_name='" + u + "' and password='" + p + "'"
            Dim cms As New MySqlCommand(s, cn)
            Dim adp As New MySqlDataAdapter(cms)
            Dim dt As New DataTable()
            adp.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("Invalid Username and Password")
            Else
                MsgBox("Welcome Mr. " + u)
                Response.Redirect("Admin_Page.aspx")
            End If
        End If
        If DropDownList1.Text = "Customer" Then
            Dim u As String = TextBox5.Text
            Dim p As String = TextBox6.Text
            Dim s As String = "select f_name,password from cust_login where u_name='" + u + "' and password='" + p + "'"
            Dim ci As New MySqlCommand(s, cn)
            Session("customer_name") = u
            Session("password") = p
            Dim adapt As New MySqlDataAdapter(ci)
            Dim table As New DataTable()
            adapt.Fill(table)
            If table.Rows.Count = 0 Then
                MsgBox("Invalid Username and Password")
            Else
                MsgBox("Welcome Mr. " + u)
                Response.Redirect("Customer_Page.aspx")
            End If
        End If
        If DropDownList1.Text = "Vendor" Then
            Dim u As String = TextBox5.Text
            Dim p As String = TextBox6.Text
            Dim s As String = "select f_name,password from vendor_login where v_name='" + u + "' and password='" + p + "'"
            Dim ci As New MySqlCommand(s, cn)
            Session("vendor_name") = u
            Session("password") = p
            Dim adapt As New MySqlDataAdapter(ci)
            Dim table As New DataTable()
            adapt.Fill(table)
            If table.Rows.Count = 0 Then
                MsgBox("Invalid Username and Password")
            Else
                MsgBox("Welcome Mr. " + u)
                Response.Redirect("Vendor_Page.aspx")
            End If
        End If
    End Sub
End Class