Public Interface ITaskRepository
#Region "Add"
    Sub AddNewTask(ByVal taskToAdd As task)

#End Region 'Add

#Region "Delete"

#End Region 'Delete

#Region "Update"

#End Region 'Update

#Region "Select"
    Function GetAllTasks() As IEnumerable(Of task)
#End Region 'Select

    Function SaveChanges() As Integer
End Interface
