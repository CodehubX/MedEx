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

        Me.Hide()
        Form3.Show()

    End Sub
End Class