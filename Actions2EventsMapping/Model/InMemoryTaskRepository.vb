Public Class InMemoryTaskRepository
    Implements ITaskRepository

    Private _tasks As New List(Of task)
    Private _mappings As New List(Of task2event)
    Private _events As New List(Of [event])

    Public Sub New()

    End Sub

    'Public Sub New(ByVal tasksCount As Integer)
    'tasks without parent task with childeren tasks, not assigned to an event, not attended to an event
    'tasks without parent task with childeren tasks, not assigned to an event, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks without parent task with childeren tasks, assigned to 3 an event with parent event with children events, not attended to an event
    'tasks without parent task with childeren tasks, assigned to 3 an event with parent event with children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks without parent task with childeren tasks, assigned to 5 an event with parent event without children events, not attended to an event
    'tasks without parent task with childeren tasks, assigned to 5 an event with parent event without children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks without parent task with childeren tasks, assigned to 2 an event without parent event with children events, not attended to an event
    'tasks without parent task with childeren tasks, assigned to 2 an event without parent event with children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks without parent task with childeren tasks, assigned to 1 an event without parent event without children events, not attended to an event
    'tasks without parent task with childeren tasks, assigned to 1 an event without parent event without children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events

    'tasks without parent task without childeren tasks, not assigned to an event, not attended to an event
    'tasks without parent task without childeren tasks, not assigned to an event, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks without parent task without childeren tasks, assigned to an event with parent event with children events, not attended to an event
    'tasks without parent task without childeren tasks, assigned to an event with parent event with children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks without parent task without childeren tasks, assigned to an event with parent event without children events, not attended to an event
    'tasks without parent task without childeren tasks, assigned to an event with parent event without children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks without parent task without childeren tasks, assigned to an event without parent event with children events, not attended to an event
    'tasks without parent task without childeren tasks, assigned to an event without parent event with children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks without parent task without childeren tasks, assigned to an event without parent event without children events, not attended to an event
    'tasks without parent task without childeren tasks, assigned to an event without parent event without children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events

    'tasks with parent task with childeren tasks, not assigned to an event, not attended to an event
    'tasks with parent task with childeren tasks, not assigned to an event, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks with parent task with childeren tasks, assigned to an event with parent event with children events, not attended to an event
    'tasks with parent task with childeren tasks, assigned to an event with parent event with children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks with parent task with childeren tasks, assigned to an event with parent event without children events, not attended to an event
    'tasks with parent task with childeren tasks, assigned to an event with parent event without children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks with parent task with childeren tasks, assigned to an event without parent event with children events, not attended to an event
    'tasks with parent task with childeren tasks, assigned to an event without parent event with children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks with parent task with childeren tasks, assigned to an event without parent event without children events, not attended to an event
    'tasks with parent task with childeren tasks, assigned to an event without parent event without children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events

    'tasks with parent task without childeren tasks, not assigned to an event, not attended to an event
    'tasks with parent task without childeren tasks, not assigned to an event, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks with parent task without childeren tasks, assigned to an event with parent event with children events, not attended to an event
    'tasks with parent task without childeren tasks, assigned to an event with parent event with children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks with parent task without childeren tasks, assigned to an event with parent event without children events, not attended to an event
    'tasks with parent task without childeren tasks, assigned to an event with parent event without children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks with parent task without childeren tasks, assigned to an event without parent event with children events, not attended to an event
    'tasks with parent task without childeren tasks, assigned to an event without parent event with children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'tasks with parent task without childeren tasks, assigned to an event without parent event without children events, not attended to an event
    'tasks with parent task without childeren tasks, assigned to an event without parent event without children events, attended to an event with parent event with children events
    '                                                                                                                                    with parent event without children events
    '                                                                                                                                    without parent event with children events
    '                                                                                                                                    without parent event without children events
    'End Sub

#Region "Add"
    Public Sub AddNewTask(ByVal taskToAdd As task) Implements ITaskRepository.AddNewTask
        taskToAdd.task_id = Me.FindMaxTasksId + 1
        Me._tasks.Add(taskToAdd)
    End Sub
#End Region 'Add

#Region "Delete"

#End Region 'Delete

#Region "Update"

#End Region 'Update

#Region "Select"
    Public Function GetAllTAsks() As System.Collections.Generic.IEnumerable(Of task) Implements ITaskRepository.GetAllTAsks
        Return Me._tasks
    End Function
#End Region 'Select

    Public Function SaveChanges() As Integer Implements ITaskRepository.SaveChanges
        Throw New NotImplementedException
    End Function

#Region "Helper Functions"
    Public Function FindMaxTasksId() As Integer
        Dim maxId As Integer = 0
        For Each t As task In Me._tasks
            If t.task_id > maxId Then maxId = t.task_id
        Next
        Return maxId
    End Function
#End Region 'Helper Functions
End Class
