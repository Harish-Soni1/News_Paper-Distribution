Imports MySql.Data.MySqlClient
Public Class Vendor_Login
    Inherits System.Web.UI.Page
    Dim cn As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
    Dim RandNumber As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub create_table()
        Try
            Dim contar As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
            contar.Open()
            Dim name As String = TextBox3.Text + "_" + "subscribers"
            Dim create_v_table As String = "create table if not exists " + name + "
        (C_Name varchar(10) not null,
        C_ID varchar(8) not null,
        Subscription varchar(15) not null,
        Date_Of_Subscribe date,
        foreign key(C_ID) references cust_login(u_id))"
            Dim cmd As New MySqlCommand(create_v_table, contar)
            cmd.ExecuteNonQuery()
        Catch

        End Try
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Open()
        Try
            Dim rnd As New Random
            RandNumber = (rnd.Next(1000000, 99999999)).ToString
            Dim insert As String = "insert into vendor_login values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + RandNumber + "','" + TextBox8.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')"
            Dim ci As New mysqlCommand(insert, cn)
            ci.ExecuteNonQuery()
            MsgBox("Vendor Added")
            create_table()
        Catch ex As Exception

        End Try
    End Sub
End Class