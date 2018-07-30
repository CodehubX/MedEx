Imports System.Data.OleDb

Public Class Form2


    Private Sub LoginTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LoginTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginDBDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDBDataSet.LoginTable' table. You can move, or remove it, as needed.
        Me.LoginTableTableAdapter.Fill(Me.LoginDBDataSet.LoginTable)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim connection As OleDbConnection = New OleDbConnection

        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\AlphaPhiKappa\Documents\GitHub\MedX\Login Page\Login Page\LoginDB.accdb"

        connection.Open()
        Dim updatequery As OleDbCommand = New OleDbCommand("INSERT INTO LoginTable (Name1,Name2,[Number],Age,Sex) VALUES(@name1,@name2,@num,@age,@sex)", connection)
        updatequery.Parameters.AddWithValue("@name1", TextBox1.Text)
        updatequery.Parameters.AddWithValue("@name2", TextBox2.Text)
        updatequery.Parameters.AddWithValue("@num", TextBox3.Text)
        updatequery.Parameters.AddWithValue("@age", DateTimePicker1.Value)
        updatequery.Parameters.AddWithValue("@sex", ComboBox1.SelectedItem)
        updatequery.ExecuteNonQuery()
        Me.Hide()
        Form3.Show()

    End Sub


End Class