Imports MySql.Data.MySqlClient
Public Class Admin_Page
    Inherits System.Web.UI.Page
    Dim dt As New DataTable()
    Dim dt1 As New DataTable()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        for_customer()
        for_vendor()
    End Sub
    Public Sub for_customer()
        getdata_c()
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
    Public Sub for_vendor()
        getdata_v()
        GridView2.DataSource = dt1
        GridView2.DataBind()
    End Sub
    Private Function getdata_c() As DataTable
        Dim constr As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
        Using cmd As New MySqlCommand("select * from cust_login")
            Using sda As New MySqlDataAdapter
                cmd.Connection = constr
                sda.SelectCommand = cmd
                sda.Fill(dt)
                Return dt
            End Using
        End Using
    End Function
    Private Function getdata_v() As DataTable
        Dim constr As New MySqlConnection("server=localhost;user id=   ;password=   ;database=npd")
        Using cmd As New mysqlCommand("select * from vendor_login")
            Using sda As New mysqlDataAdapter
                cmd.Connection = constr
                sda.SelectCommand = cmd
                sda.Fill(dt1)
                Return dt1
            End Using
        End Using
    End Function

    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        Dim index As Int32 = Int32.Parse(e.Item.Value)
        MultiView1.ActiveViewIndex = index
    End Sub
End Class