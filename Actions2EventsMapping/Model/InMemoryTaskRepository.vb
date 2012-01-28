Public Class InMemoryTaskRepository
    Implements ITaskRepository

    Private _tasks As New List(Of task)
    Private _mappings As New List(Of task2event)
    Private _events As New List(Of [event])

    Public Sub New()

    End Sub

    ''' <summary>
    ''' For debugging purposes. Repository is initialized with number of tasks, events and mappings
    ''' </summary>
    ''' <remarks>
    '''</remarks>
    Public Sub New(ByVal tasksCount As Integer)
        'tasks without parent task, not assigned to an event, not attended to an event
        'tasks without parent task, not assigned to an event, attended to an event
        'tasks without parent task, assigned to an event, not attended to an event
        'tasks without parent task, assigned to an event, attended to an event
        'tasks with parent task, not assigned to an event, not attended to an event
        'tasks with parent task, not assigned to an event, attended to an event
        'tasks with parent task, assigned to an event, not attended to an event
        'tasks with parent task, assigned to an event, attended to an event

        Throw New NotImplementedException
    End Sub

#Region "Add"
    Public Sub CreateNewTask(ByVal taskToCreate As task) Implements ITaskRepository.CreateNewTask
        Throw New NotImplementedException
    End Sub
#End Region 'Add

#Region "Delete"
    Public Sub DeleteTask(ByVal task_id As Integer) Implements ITaskRepository.DeleteTask
        Throw New NotImplementedException
    End Sub
#End Region 'Delete

#Region "Update"

#End Region 'Update

#Region "Select"
    Public Function GetAllTAsks() As System.Collections.Generic.IEnumerable(Of task) Implements ITaskRepository.GetAllTAsks
        Throw New NotImplementedException
    End Function

    Public Function GetTaskById(ByVal id As Integer) As task Implements ITaskRepository.GetTaskById
        Throw New NotImplementedException
    End Function
#End Region 'Select

    Public Function SaveChanges() As Integer Implements ITaskRepository.SaveChanges
        Throw New NotImplementedException
    End Function
End Class
