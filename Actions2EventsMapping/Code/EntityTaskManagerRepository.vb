Public Class EntityTaskManagerRepository
    Implements ITaskRepository

    Private _dbContext As New action2eventsEntities

    Public Function GetTaskById(id As Integer) As task Implements ITaskRepository.GetTaskById
        Return _dbContext.tasks.FirstOrDefault(Function(d) d.task_id = id)
    End Function

    Public Function GetAllTAsks() As System.Collections.Generic.IEnumerable(Of task) Implements ITaskRepository.GetAllTAsks
        Return _dbContext.tasks.ToList
    End Function

    Public Sub CreateNewTask(taskToCreate As task) Implements ITaskRepository.CreateNewTask
        _dbContext.AddTotasks(taskToCreate)
        _dbContext.SaveChanges()
    End Sub

    Public Function SaveChanges() As Integer Implements ITaskRepository.SaveChanges
        Return _dbContext.SaveChanges
    End Function

    Public Sub DeleteTask(task_id As Integer) Implements ITaskRepository.DeleteTask
        Dim taskToDel = GetTaskById(task_id)
        _dbContext.tasks.DeleteObject(taskToDel)
        _dbContext.SaveChanges()
    End Sub
End Class
