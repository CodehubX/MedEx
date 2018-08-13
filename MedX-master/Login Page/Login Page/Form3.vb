Imports System.Data.OleDb
Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\AlphaPhiKappa\Downloads\MedX-master\Login Page\Login Page\bin\Debug\LoginDB.accdb"
        connection.Open()
        Dim updatequery As New OleDbCommand("INSERT INTO LoginTable WHERE MAX(PID) (Username,Password,Answer) VALUES(@username,@password,@answer)", connection)
        updatequery.Parameters.Add("@Username", OleDbType.VarChar).Value = TextBox1.Text
        updatequery.Parameters.Add("@name2", OleDbType.VarChar).Value = TextBox3.Text
        updatequery.Parameters.Add("@num", OleDbType.Numeric).Value = TextBox4.Text
        MsgBox("Profile Created")
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub
End Class