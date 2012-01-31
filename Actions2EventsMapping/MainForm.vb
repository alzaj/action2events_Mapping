Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class MainForm
    Implements IMainView

    Public Event ShowButtonPressed() Implements IMainView.ShowButtonPressed
    Public Event ClearButtonPressed() Implements IMainView.ClearButtonPressed
    Private _presenter As MainPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._presenter = New MainPresenter(Me, New InMemoryTaskRepository)

    End Sub

    Public Property debugLbl_Text As String Implements IMainView.debugLbl_Text
        Get
            Return Me.debugLbl.Text
        End Get
        Set(ByVal value As String)
            Me.debugLbl.Text = value
        End Set
    End Property

    Private Sub showBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showBtn.Click
        RaiseEvent ShowButtonPressed()
    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        RaiseEvent ClearButtonPressed()
    End Sub
End Class
