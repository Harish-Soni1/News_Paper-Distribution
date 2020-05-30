Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Net.Mail
Public Class Forgot_Password
    Inherits System.Web.UI.Page
    Dim cn As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
    Dim RandNumber As String
    Dim em As String
    Dim dr1 As MySqlDataReader
    Dim valid_mail As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Function valid_email_customer()
        Dim login_str As String = "SELECT email FROM cust_login WHERE u_name='" + TextBox3.Text + "' and email='" + TextBox1.Text + "'"
        Dim cmd As New MySqlCommand(login_str, cn)
        Dim adapt As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapt.Fill(table)
        Try
            If table.Rows.Count = 1 Then
                MsgBox("OTP Send")
                Return True
            Else
                MsgBox("Sorry OTP is not Send")
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Sub customer_password()
        cn.Close()
        Try
            Dim cnh2 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            cnh2.Open()
            Dim q As String = "select password from cust_login where u_name='" + TextBox3.Text + "'"
            Dim cmd1 As New MySqlCommand(q, cnh2)
            cmd1.Parameters.AddWithValue("u_name", TextBox3.Text)
            Dim dr1 As MySqlDataReader
            dr1 = cmd1.ExecuteReader()
            Dim pass As String
            While dr1.Read
                pass = dr1.GetString("password")
                MsgBox("Your password is " + pass)
            End While
            cnh2.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub send_otp()
        Try
            Dim smtp_server As New SmtpClient
            Dim mail As New MailMessage
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("stony1575@gmail.com", "Tony#123@")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            mail.From = New MailAddress("stony1575@gmail.com")
            mail.To.Add(TextBox1.Text)
            mail.Subject = "One Time Password for Verification"
            mail.IsBodyHtml = False
            Dim rnd As New Random
            RandNumber = (rnd.Next(100000, 999999)).ToString
            mail.Body = "Your One Time Password for Fetch Credentials is:" + RandNumber
            smtp_server.Send(mail)
        Catch ex As Exception
            MsgBox("Unable to Send your OTP")
        End Try
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DropDownList1.Text = "Customer" Then
            valid_email_customer()
            send_otp()
        End If
        If DropDownList1.Text = "Vendor" Then
            valid_email_vendor()
            send_otp()
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = RandNumber Then
            MsgBox("OTP matched")
            Button3.Enabled = True
        Else
            MsgBox("Invalid OTP")
        End If
    End Sub
    Function valid_email_vendor()
        Dim login_str As String = "SELECT v_e_mail FROM vendor_login WHERE v_name='" + TextBox3.Text + "' and v_e_mail='" + TextBox2.Text + "'"
        Dim cmd As New MySqlCommand(login_str, cn)
        Dim adapt As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapt.Fill(table)
        Try
            If table.Rows.Count = 1 Then
                MsgBox("OTP Send")
                Return True
            Else
                MsgBox("Sorry OTP is not Send")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Public Sub vendor_password()
        cn.Close()
        Try
            Dim cnh2 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            cnh2.Open()
            Dim q As String = "select password from vendor_login where v_name='" + TextBox3.Text + "'"
            Dim cmd1 As New mysqlCommand(q, cnh2)
            cmd1.Parameters.AddWithValue("v_name", TextBox3.Text)
            Dim dr1 As mysqlDataReader
            dr1 = cmd1.ExecuteReader()
            Dim pass As String
            While dr1.Read
                pass = dr1.GetString("password")
                MsgBox("Your password is " + pass)
            End While
            cnh2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

End Class