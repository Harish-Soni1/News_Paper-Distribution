Imports MySql.Data.MySqlClient
Public Class Cust_Login
    Inherits System.Web.UI.Page
    Dim cn As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
    Dim RandNumber As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Open()
        Try
            Dim rnd As New Random
            RandNumber = (rnd.Next(10000000, 99999999)).ToString
            Dim insert As String = "insert into cust_login values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + RandNumber + "','" + TextBox4.Text + "','" + TextBox9.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')"
            Dim ci As New mysqlCommand(insert, cn)
            ci.ExecuteNonQuery()
            MsgBox("Customer Added")
        Catch ex As Exception

        End Try
    End Sub
End Class