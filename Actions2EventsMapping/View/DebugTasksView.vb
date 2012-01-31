Public Class DebugTasksView
    Implements IMainView

    Public Event ClearButtonPressed() Implements IMainView.ClearButtonPressed
    Public Event ShowButtonPressed() Implements IMainView.ShowButtonPressed

    Private _debugLbl_Text As String = ""
    Public Property debugLbl_Text As String Implements IMainView.debugLbl_Text
        Get
            Return Me._debugLbl_Text
        End Get
        Set(ByVal value As String)
            Me._debugLbl_Text = value
        End Set
    End Property

End Class
