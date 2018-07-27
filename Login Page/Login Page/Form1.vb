Imports System.Data.OleDb
Public Class Form1

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim myconnection As OleDbConnection = New OleDbConnection
        myconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath+ "\LoginDB.accdb"
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from LoginTable where Username = '" & TextBox1.Text & "' AND Password = '" & TextBox2.Text & "'", myconnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read = True) Then

            MsgBox("Logged in Successfully")
        Else
            MsgBox("Username Or Password Incorrect")

        End If
    End Sub
End Class

