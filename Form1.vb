Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class Form1

    Private _dbContext As New action2eventsEntities

    Private Sub closeForm_Click(sender As System.Object, e As System.EventArgs) Handles closeForm.Click
        _dbContext.Dispose()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tasksGridView.DataSource = _dbContext.tasks
    End Sub


    Private Sub saveChanges_Click(sender As System.Object, e As System.EventArgs) Handles saveChanges.Click
        Try
            _dbContext.SaveChanges()
            MessageBox.Show("Changes saved to the database.")
            Me.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
