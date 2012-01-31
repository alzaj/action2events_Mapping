Public Class MainPresenter

    Public WithEvents _view As IMainView
    Public WithEvents _db As ITaskRepository

    Public Sub New(ByVal view As IMainView, ByVal db As ITaskRepository)
        Me._view = view
        Me._db = db
    End Sub

    Public Sub Hadle_MainView_ShowClick() Handles _view.ShowButtonPressed
        _view.debugLbl_Text = "Show Button clicked"
    End Sub

    Public Sub Hadle_MainView_ClearClick() Handles _view.ClearButtonPressed
        _view.debugLbl_Text = "Clear Button clicked"
    End Sub

End Class
