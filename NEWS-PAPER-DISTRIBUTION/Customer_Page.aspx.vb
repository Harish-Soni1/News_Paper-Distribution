Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Net.Mail
Public Class Cust_UI
    Inherits System.Web.UI.Page
    Dim cn As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
    Dim f_name, l_name, pincode, mobile, u_id, u_name, address, RandNumber As String
    Dim subscribe, pin1, v_name, v_id, f_name1, email, email1 As String
    Dim price(), s_price As String
    Dim dt As New DataTable()
    Dim subscribe_date As DateTime
    Dim dr1 As MySqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cn.Open()
        Try
            select1()
            Label1.Text = f_name
            Label2.Text = mobile
            Label3.Text = u_id
            Label4.Text = address
            TextBox4.Text = f_name
            TextBox5.Text = l_name
            TextBox6.Text = u_name
            TextBox7.Text = mobile
            TextBox8.Text = address
            TextBox9.Text = pincode
            TextBox10.Text = email1
        Catch ex As Exception

        End Try
        Table1.BorderStyle = BorderStyle.Solid
        Table1.CellPadding = 1
        Table1.BorderWidth = 1

        getdata()
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
    Private Function getdata() As DataTable
        Dim constr As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
        Using cmd As New MySqlCommand("select * from my_order")
            Using sda As New MySqlDataAdapter
                cmd.Connection = constr
                sda.SelectCommand = cmd
                sda.Fill(dt)
            End Using
        End Using
    End Function
    Public Sub select_pincode()
        Try
            Dim con1 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con1.Open()
            Dim select_pincode As String = "select pincode from cust_login where u_name='" + u_name + "'"
            Dim cmd As New MySqlCommand(select_pincode, con1)
            dr1 = cmd.ExecuteReader()
            While dr1.Read
                pin1 = dr1.GetString("pincode")
            End While
        Catch

        End Try
    End Sub
    Public Sub select_table()
        Try
            select_pincode()
            Dim con3 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con3.Open()
            Dim select_table_name As String = "select v_name from vendor_login where pincode=" + pin1 + ""
            Dim cmd As New MySqlCommand(select_table_name, con3)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read
                v_name = dr.GetString("v_name")
            End While
        Catch

        End Try
    End Sub

    Function delete_cust()
        Try
            select_table()
            Dim con7 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con7.Open()
            Dim name As String = v_name + "_" + "subscribers"
            Dim delete_query As String = "delete from " + name + " where C_Name='" + f_name + "'"
            Dim cmd As New MySqlCommand(delete_query, con7)
            cmd.ExecuteNonQuery()
            Response.Redirect(Request.RawUrl)
            con7.Close()
        Catch

        End Try
    End Function

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Session.Clear()
        Response.Redirect("News-Paper-Distribution.aspx")
    End Sub

    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Session.Clear()
        Response.Redirect("News-Paper-Distribution.aspx")
    End Sub

    Protected Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Session.Clear()
        Response.Redirect("News-Paper-Distribution.aspx")
    End Sub

    Protected Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Session.Clear()
        Response.Redirect("News-Paper-Distribution.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim con5 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con5.Open()
            Dim update_query As String = "update cust_login set u_name='" + TextBox6.Text + "','" + TextBox10.Text + "',mobile='" + TextBox7.Text + "',address='" + TextBox8.Text + "',pincode='" + TextBox9.Text + "' where f_name='" + f_name + "'"
            Dim cmd As New MySqlCommand(update_query, con5)
            cmd.ExecuteNonQuery()
            MsgBox("Profile Updated")
        Catch

        End Try
    End Sub

    Protected Sub linkUnsub_Click(sender As Object, e As EventArgs)
        Try
            Dim con6 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con6.Open()
            Dim delete_query As String = "delete from my_order where C_Name='" + f_name + "'"
            Dim cmd As New MySqlCommand(delete_query, con6)
            cmd.ExecuteNonQuery()
            delete_cust()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub vendor_info()
        Try
            Dim con4 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con4.Open()
            Dim s As String = "select * from vendor_login where v_name = '" + v_name + "'"
            Dim cmd As New MySqlCommand(s, con4)
            dr1 = cmd.ExecuteReader()
            While dr1.Read
                f_name1 = dr1.GetString("f_name")
                mobile = dr1.GetString("mobile")
                v_id = dr1.GetString("v_id")
                email = dr1.GetString("v_e_mail")
            End While
            MsgBox("Your Vendor Name: " + f_name1 + " His Mobile Number: " + mobile + " And ID: " + v_id)
        Catch

        End Try
    End Sub
    Public Sub insert1()
        select_pincode()
        select_table()
        Try
            Dim cont As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            cont.Open()
            Dim name As String = v_name + "_" + "subscribers"
            Dim insert As String = "insert into " + name + " values('" + f_name + "','" + u_id + "','" + subscribe + "',str_to_date('" + subscribe_date.ToString("dd-MM-yyyy") + "','%d-%m-%Y'))"
            Dim cmd As New MySqlCommand(insert, cont)
            cmd.ExecuteNonQuery()
            cont.Close()
        Catch

        End Try
    End Sub
    Public Sub select1()
        Try
            Dim contan As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            contan.Open()
            Dim cust_select As String = "select * from cust_login where u_name='" + Session("customer_name") + "'"
            Dim cmd1 As New MySqlCommand(cust_select, contan)
            dr1 = cmd1.ExecuteReader()
            While dr1.Read
                f_name = dr1.GetString("f_name")
                l_name = dr1.GetString("l_name")
                mobile = dr1.GetString("mobile")
                u_name = dr1.GetString("u_name")
                u_id = dr1.GetString("u_id")
                email1 = dr1.GetString("email")
                address = dr1.GetString("address")
                pincode = dr1.GetString("pincode")
            End While
        Catch ex As Exception

        End Try
    End Sub
    Public Sub select_date()
        Try
            Dim cont1 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            cont1.Open()
            Dim cust_select As String = "select date from my_order where c_name='" + Session("customer_name") + "'"
            Dim cmd1 As New MySqlCommand(cust_select, cont1)
            dr1 = cmd1.ExecuteReader()
            While dr1.Read
                subscribe_date = dr1.GetString("date")
            End While
            Dim s_date() As String = subscribe_date.ToString.Split(" ")
            Dim a As String = s_date(0)
            Dim b As String = s_date(1)
            Dim c As String = s_date(2)
            subscribe_date = a
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        Dim index As Int32 = Int32.Parse(e.Item.Value)
        MultiView1.ActiveViewIndex = index
    End Sub
    Function is_subscribe()
        Try
            Dim con2 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con2.Open()
            Dim s As String = "select * from my_order where subcription='" + subscribe + "'"
            Dim cmd As New MySqlCommand(s, con2)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch

        End Try
    End Function
    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        select1()
        subscribe = Table1.Rows(1).Cells(0).Text
        If is_subscribe() Then
            MsgBox("Already Subscribed")
        Else
            Try
                price = Table1.Rows(1).Cells(1).Text.Split(" ")
                s_price = price(0)
                Dim rnd As New Random
                RandNumber = (rnd.Next(1000000, 99999999)).ToString
                Dim insert As String = "insert into my_order values('" + RandNumber + "','" + f_name + "','" + u_id + "','" + subscribe + "',now(),'" + s_price + "')"
                Dim cmd As New MySqlCommand(insert, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Subscribe Succesfully")
                select_date()
                insert1()
                vendor_info()
                valid_email()
                send_info()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Protected Sub Button2_Click1(sender As Object, e As EventArgs) Handles Button2.Click
        select1()
        If is_subscribe() Then
            MsgBox("Already Subscribed")
        Else
            Try
                subscribe = Table1.Rows(4).Cells(0).Text
                price = Table1.Rows(4).Cells(1).Text.Split(" ")
                s_price = price(0)
                Dim rnd As New Random
                RandNumber = (rnd.Next(1000000, 99999999)).ToString
                Dim insert As String = "insert into my_order values('" + RandNumber + "','" + f_name + "','" + u_id + "','" + subscribe + "',now(),'" + s_price + "')"
                Dim cmd As New MySqlCommand(insert, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Subscribe Succesfully")
                select_date()
                insert1()
                vendor_info()
                valid_email()
                send_info()
            Catch

            End Try
        End If
    End Sub

    Protected Sub Button3_Click1(sender As Object, e As EventArgs) Handles Button3.Click
        select1()
        If is_subscribe() Then
            MsgBox("Already Subscribed")
        Else
            Try
                subscribe = Table1.Rows(5).Cells(0).Text
                price = Table1.Rows(5).Cells(1).Text.Split(" ")
                s_price = price(0)
                Dim rnd As New Random
                RandNumber = (rnd.Next(1000000, 99999999)).ToString
                Dim insert As String = "insert into my_order values('" + RandNumber + "','" + f_name + "','" + u_id + "','" + subscribe + "',now(),'" + s_price + "')"
                Dim cmd As New MySqlCommand(insert, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Subscribe Succesfully")
                select_date()
                insert1()
                vendor_info()
                valid_email()
                send_info()
            Catch

            End Try
        End If
    End Sub
    Protected Sub Button4_Click1(sender As Object, e As EventArgs) Handles Button4.Click
        select1()
        If is_subscribe() Then
            MsgBox("Already Subscribed")
        Else
            Try
                subscribe = Table1.Rows(6).Cells(0).Text
                price = Table1.Rows(6).Cells(1).Text.Split(" ")
                s_price = price(0)
                Dim rnd As New Random
                RandNumber = (rnd.Next(1000000, 99999999)).ToString
                Dim insert As String = "insert into my_order values('" + RandNumber + "','" + f_name + "','" + u_id + "','" + subscribe + "',now(),'" + s_price + "')"
                Dim cmd As New MySqlCommand(insert, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Subscribe Succesfully")
                select_date()
                insert1()
                vendor_info()
                valid_email()
                send_info()
            Catch

            End Try
        End If
    End Sub
    Protected Sub Button5_Click1(sender As Object, e As EventArgs) Handles Button5.Click
        select1()
        If is_subscribe() Then
            MsgBox("Already Subscribed")
        Else
            Try
                subscribe = Table1.Rows(7).Cells(0).Text
                price = Table1.Rows(7).Cells(1).Text.Split(" ")
                s_price = price(0)
                Dim rnd As New Random
                RandNumber = (rnd.Next(1000000, 99999999)).ToString
                Dim insert As String = "insert into my_order values('" + RandNumber + "','" + f_name + "','" + u_id + "','" + subscribe + "',now(),'" + s_price + "')"
                Dim cmd As New MySqlCommand(insert, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Subscribe Succesfully")
                select_date()
                insert1()
                vendor_info()
                valid_email()
                send_info()
            Catch

            End Try
        End If
    End Sub
    Protected Sub Button6_Click1(sender As Object, e As EventArgs) Handles Button6.Click
        select1()
        If is_subscribe() Then
            MsgBox("Alredy Subscribed")
        Else
            Try
                subscribe = Table1.Rows(8).Cells(0).Text
                price = Table1.Rows(8).Cells(1).Text.Split(" ")
                s_price = price(0)
                Dim rnd As New Random
                RandNumber = (rnd.Next(1000000, 99999999)).ToString
                Dim insert As String = "insert into my_order values('" + RandNumber + "','" + f_name + "','" + u_id + "','" + subscribe + "',now(),'" + s_price + "')"
                Dim cmd As New MySqlCommand(insert, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Subscribe Succesfully")
                select_date()
                insert1()
                vendor_info()
                valid_email()
                send_info()
            Catch

            End Try
        End If
    End Sub
    Function valid_email()
        Dim login_str As String = "SELECT v_e_mail FROM vendor_login WHERE v_name='" + v_name + "' and v_e_mail='" + email + "'"
        Dim cmd As New MySqlCommand(login_str, cn)
        Dim adapt As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapt.Fill(table)
        Try
            If table.Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Sub send_info()
        Try
            Dim smtp_server As New SmtpClient
            Dim mail As New MailMessage
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("stony1575@gmail.com", "Tony#123@")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            mail.From = New MailAddress("stony1575@gmail.com")
            mail.To.Add(email)
            mail.Subject = "One Time Password for Verification"
            mail.IsBodyHtml = False
            Dim rnd As New Random
            RandNumber = (rnd.Next(100000, 999999)).ToString
            mail.Body = "Hello Mr." + f_name1 + ". You have a new Customer" +
                "Details of Customer is" +
                "Name: " + f_name +
                "Mobile Number: " + mobile +
                "Subscription of: " + subscribe +
                "Price of: " + s_price
            smtp_server.Send(mail)
        Catch ex As Exception
            MsgBox("Unable to Send Your Mail")
        End Try
    End Sub
End Class