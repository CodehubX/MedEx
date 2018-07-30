Imports System.Data.OleDb
Public Class Form1


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim myconnection As OleDbConnection = New OleDbConnection
        myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\LoginDB.accdb"
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from LoginTable where Username = '" & TextBox1.Text & "' AND Password = '" & TextBox2.Text & "'", myconnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read = True) Then
            Me.Hide()

            MsgBox("Logged in Successfully")
        Else
            MsgBox("Username Or Password Incorrect")

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus

        TextBox1.Text = "username"
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus

        TextBox1.Text = ""
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        TextBox2.Text = "Password"

    End Sub


    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        TextBox2.Text = ""
        TextBox2.PasswordChar = "•"
    End Sub

    Private Sub Form1_GotFocus(sender As Object, e As EventArgs) Handles MyBase.GotFocus

    End Sub
End Class

