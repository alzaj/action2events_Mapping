Public Class TestDB
    Inherits InMemoryTaskRepository
End Class

<TestClass()> _
Public Class DataManipulationTests

    <TestMethod()> _
    Public Sub AddNewTask()
        Dim _db As ITaskRepository = New TestDB
        Dim t As New task
        t.title = "task"
        _db.AddNewTask(t)
        Assert.IsTrue(_db.GetAllTasks.Count = 1)
    End Sub

End Class
