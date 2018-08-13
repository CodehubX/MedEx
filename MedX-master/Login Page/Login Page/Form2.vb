Imports System.Data.OleDb

Public Class Form2


    Private Sub LoginTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LoginTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginDBDataSet)

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim connection As OleDbConnection = New OleDbConnection

        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\AlphaPhiKappa\Downloads\MedX-master\Login Page\Login Page\bin\Debug\LoginDB.accdb"

        connection.Open()
        Dim updatequery As OleDbCommand = New OleDbCommand("INSERT INTO LoginTable (Name1,Name2,[Number],Age,Sex) VALUES(@name1,@name2,@num,@age,@sex)", connection)
        ComboBox1.Text = ""
        updatequery.Parameters.Add("@name1", OleDbType.VarChar).Value = TextBox1.Text
        updatequery.Parameters.Add("@name2", OleDbType.VarChar).Value = TextBox2.Text
        updatequery.Parameters.Add("@num", OleDbType.Numeric).Value = TextBox3.Text
        updatequery.Parameters.Add("@age", OleDbType.Numeric).Value = TextBox4.Text
        updatequery.Parameters.Add("@sex", OleDbType.VarChar).Value = ComboBox1.Text
        updatequery.ExecuteNonQuery()
        ComboBox1.Text = ""
        Me.Hide()
        Form3.Show()
        connection.Close()


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub
End Class