Public Interface ITaskRepository
    Sub CreateNewTask(taskToCreate As task)
    Sub DeleteTask(task_id As Integer)
    Function GetTaskById(id As Integer) As task
    Function GetAllTAsks() As IEnumerable(Of task)
    Function SaveChanges() As Integer
End Interface
