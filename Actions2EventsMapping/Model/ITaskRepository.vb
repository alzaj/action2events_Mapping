Public Interface ITaskRepository
#Region "Add"

#End Region 'Add

#Region "Delete"

#End Region 'Delete

#Region "Update"

#End Region 'Update

#Region "Select"

#End Region 'Select

    Sub CreateNewTask(ByVal taskToCreate As task)
    Sub DeleteTask(ByVal task_id As Integer)
    Function GetTaskById(ByVal id As Integer) As task
    Function GetAllTAsks() As IEnumerable(Of task)
    Function SaveChanges() As Integer
End Interface
