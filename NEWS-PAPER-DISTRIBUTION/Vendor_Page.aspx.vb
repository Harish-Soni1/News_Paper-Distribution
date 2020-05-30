Imports MySql.Data.MySqlClient
Public Class Vendor_UI
    Inherits System.Web.UI.Page
    Dim cn As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
    Dim v_name, mobile, v_id, pincode, t_name, pin1, l_name, email, u_name As String

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Session.Clear()
        Response.Redirect("News-Paper-Distribution.aspx")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Session.Clear()
        Response.Redirect("News-Paper-Distribution.aspx")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Session.Clear()
        Response.Redirect("News-Paper-Distribution.aspx")
    End Sub

    Dim dt As New DataTable()
    Dim dr1 As MySqlDataReader

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con5 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con5.Open()
            Dim update_query As String = "update vendor_login set v_name='" + TextBox6.Text + "',mobile='" + TextBox8.Text + "',v_e_mail='" + TextBox7.Text + "',pincode='" + TextBox9.Text + "' where f_name='" + v_name + "'"
            Dim cmd As New MySqlCommand(update_query, con5)
            cmd.ExecuteNonQuery()
            MsgBox("Profile Updated")
        Catch

        End Try
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cn.Open()
        Dim s As String = "select * from vendor_login where v_name = '" + Session("vendor_name") + "'"
        Dim cmd As New MySqlCommand(s, cn)
        dr1 = cmd.ExecuteReader()
        While dr1.Read
            v_name = dr1.GetString("f_name")
            l_name = dr1.GetString("l_name")
            u_name = dr1.GetString("v_name")
            v_id = dr1.GetString("v_id")
            email = dr1.GetString("v_e_mail")
            mobile = dr1.GetString("mobile")
            pincode = dr1.GetString("pincode")
        End While
        Label1.Text = v_name
        Label2.Text = mobile
        Label3.Text = v_id
        Label4.Text = pincode
        TextBox4.Text = v_name
        TextBox5.Text = l_name
        TextBox6.Text = u_name
        TextBox7.Text = email
        TextBox8.Text = mobile
        TextBox9.Text = pincode

        getdata()
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
    Private Function getdata() As DataTable
        Try
            select_table()
            Dim constr As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            Dim name As String = t_name + "_" + "subscribers"
            Dim s As String = "select * from " + name + ""
            Dim cmd As New MySqlCommand(s, constr)
            Dim sda As New MySqlDataAdapter
            sda.SelectCommand = cmd
            sda.Fill(dt)
            Return dt
        Catch

        End Try
    End Function
    Public Sub select_pincode()
        Try
            Dim con1 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con1.Open()
            Dim select_pincode As String = "select pincode from vendor_login where f_name='" + v_name + "'"
            Dim cmd As New MySqlCommand(select_pincode, con1)
            dr1 = cmd.ExecuteReader()
            While dr1.Read
                pin1 = dr1.GetString("pincode")
            End While
        Catch

        End Try
    End Sub
    Public Sub select_table()
        select_pincode()
        Try
            Dim con3 As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            con3.Open()
            Dim select_table_name As String = "select v_name from vendor_login where pincode= " + pin1 + ""
            Dim cmd As New MySqlCommand(select_table_name, con3)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read
                t_name = dr.GetString("v_name")
            End While
        Catch

        End Try
    End Sub
    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        Dim index As Int32 = Int32.Parse(e.Item.Value)
        MultiView1.ActiveViewIndex = index
    End Sub
End Class