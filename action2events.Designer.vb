﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("9055fc79-6b74-48df-842b-ad9151f76c66")>
#Region "EDM Relationship Metadata"
<Assembly: EdmRelationshipAttribute("action2eventsModel", "FK_task2event_events", "events", System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType([event]), "task2event", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(task2event), True)>
<Assembly: EdmRelationshipAttribute("action2eventsModel", "FK_task2event_tasks", "tasks", System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(task), "task2event", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(task2event), True)>
<Assembly: EdmRelationshipAttribute("action2eventsModel", "FK_tasks_tasks", "tasks", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(task), "tasks1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(task), True)>

#End Region

#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class action2eventsEntities
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new action2eventsEntities object using the connection string found in the 'action2eventsEntities' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=action2eventsEntities", "action2eventsEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new action2eventsEntities object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "action2eventsEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new action2eventsEntities object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "action2eventsEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property events() As ObjectSet(Of [event])
        Get
            If (_events Is Nothing) Then
                _events = MyBase.CreateObjectSet(Of [event])("events")
            End If
            Return _events
        End Get
    End Property

    Private _events As ObjectSet(Of [event])

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property task2event() As ObjectSet(Of task2event)
        Get
            If (_task2event Is Nothing) Then
                _task2event = MyBase.CreateObjectSet(Of task2event)("task2event")
            End If
            Return _task2event
        End Get
    End Property

    Private _task2event As ObjectSet(Of task2event)

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property tasks() As ObjectSet(Of task)
        Get
            If (_tasks Is Nothing) Then
                _tasks = MyBase.CreateObjectSet(Of task)("tasks")
            End If
            Return _tasks
        End Get
    End Property

    Private _tasks As ObjectSet(Of task)

    #End Region
    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the events EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToevents(ByVal [event] As [event])
        MyBase.AddObject("events", [event])
    End Sub

    ''' <summary>
    ''' Deprecated Method for adding a new object to the task2event EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddTotask2event(ByVal task2event As task2event)
        MyBase.AddObject("task2event", task2event)
    End Sub

    ''' <summary>
    ''' Deprecated Method for adding a new object to the tasks EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddTotasks(ByVal task As task)
        MyBase.AddObject("tasks", task)
    End Sub

    #End Region
End Class

#End Region
#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="action2eventsModel", Name:="event")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class [event]
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new event object.
    ''' </summary>
    ''' <param name="event_id">Initial value of the event_id property.</param>
    ''' <param name="title">Initial value of the title property.</param>
    Public Shared Function Createevent(event_id As Global.System.Int32, title As Global.System.String) As [event]
        Dim [event] as [event] = New [event]
        [event].event_id = event_id
        [event].title = title
        Return [event]
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property event_id() As Global.System.Int32
        Get
            Return _event_id
        End Get
        Set
            If (_event_id <> Value) Then
                Onevent_idChanging(value)
                ReportPropertyChanging("event_id")
                _event_id = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("event_id")
                Onevent_idChanged()
            End If
        End Set
    End Property

    Private _event_id As Global.System.Int32
    Private Partial Sub Onevent_idChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub Onevent_idChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property title() As Global.System.String
        Get
            Return _title
        End Get
        Set
            OntitleChanging(value)
            ReportPropertyChanging("title")
            _title = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("title")
            OntitleChanged()
        End Set
    End Property

    Private _title As Global.System.String
    Private Partial Sub OntitleChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OntitleChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property attendedtask_id() As Nullable(Of Global.System.Int32)
        Get
            Return _attendedtask_id
        End Get
        Set
            Onattendedtask_idChanging(value)
            ReportPropertyChanging("attendedtask_id")
            _attendedtask_id = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("attendedtask_id")
            Onattendedtask_idChanged()
        End Set
    End Property

    Private _attendedtask_id As Nullable(Of Global.System.Int32)
    Private Partial Sub Onattendedtask_idChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub Onattendedtask_idChanged()
    End Sub

    #End Region
    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("action2eventsModel", "FK_task2event_events", "task2event")>
     Public Property assignedTasks() As EntityCollection(Of task2event)
        Get
            Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of task2event)("action2eventsModel.FK_task2event_events", "task2event")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of task2event)("action2eventsModel.FK_task2event_events", "task2event", value)
            End If
        End Set
    End Property

    #End Region
End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="action2eventsModel", Name:="task")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class task
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new task object.
    ''' </summary>
    ''' <param name="task_id">Initial value of the task_id property.</param>
    ''' <param name="title">Initial value of the title property.</param>
    Public Shared Function Createtask(task_id As Global.System.Int32, title As Global.System.String) As task
        Dim task as task = New task
        task.task_id = task_id
        task.title = title
        Return task
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property task_id() As Global.System.Int32
        Get
            Return _task_id
        End Get
        Set
            If (_task_id <> Value) Then
                Ontask_idChanging(value)
                ReportPropertyChanging("task_id")
                _task_id = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("task_id")
                Ontask_idChanged()
            End If
        End Set
    End Property

    Private _task_id As Global.System.Int32
    Private Partial Sub Ontask_idChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub Ontask_idChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property title() As Global.System.String
        Get
            Return _title
        End Get
        Set
            OntitleChanging(value)
            ReportPropertyChanging("title")
            _title = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("title")
            OntitleChanged()
        End Set
    End Property

    Private _title As Global.System.String
    Private Partial Sub OntitleChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OntitleChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property parenttask_id() As Nullable(Of Global.System.Int32)
        Get
            Return _parenttask_id
        End Get
        Set
            Onparenttask_idChanging(value)
            ReportPropertyChanging("parenttask_id")
            _parenttask_id = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("parenttask_id")
            Onparenttask_idChanged()
        End Set
    End Property

    Private _parenttask_id As Nullable(Of Global.System.Int32)
    Private Partial Sub Onparenttask_idChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub Onparenttask_idChanged()
    End Sub

    #End Region
    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("action2eventsModel", "FK_task2event_tasks", "task2event")>
     Public Property assignedEvents() As EntityCollection(Of task2event)
        Get
            Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of task2event)("action2eventsModel.FK_task2event_tasks", "task2event")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of task2event)("action2eventsModel.FK_task2event_tasks", "task2event", value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("action2eventsModel", "FK_tasks_tasks", "tasks1")>
     Public Property childrenTasks() As EntityCollection(Of task)
        Get
            Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of task)("action2eventsModel.FK_tasks_tasks", "tasks1")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of task)("action2eventsModel.FK_tasks_tasks", "tasks1", value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("action2eventsModel", "FK_tasks_tasks", "tasks")>
    Public Property parentTask() As task
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of task)("action2eventsModel.FK_tasks_tasks", "tasks").Value
        End Get
        Set
            CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of task)("action2eventsModel.FK_tasks_tasks", "tasks").Value = value
        End Set
    End Property
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <BrowsableAttribute(False)>
    <DataMemberAttribute()>
    Public Property parentTaskReference() As EntityReference(Of task)
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of task)("action2eventsModel.FK_tasks_tasks", "tasks")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of task)("action2eventsModel.FK_tasks_tasks", "tasks", value)
            End If
        End Set
    End Property

    #End Region
End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="action2eventsModel", Name:="task2event")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class task2event
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new task2event object.
    ''' </summary>
    ''' <param name="id">Initial value of the id property.</param>
    ''' <param name="task_id">Initial value of the task_id property.</param>
    ''' <param name="event_id">Initial value of the event_id property.</param>
    Public Shared Function Createtask2event(id As Global.System.Int32, task_id As Global.System.Int32, event_id As Global.System.Int32) As task2event
        Dim task2event as task2event = New task2event
        task2event.id = id
        task2event.task_id = task_id
        task2event.event_id = event_id
        Return task2event
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property id() As Global.System.Int32
        Get
            Return _id
        End Get
        Set
            If (_id <> Value) Then
                OnidChanging(value)
                ReportPropertyChanging("id")
                _id = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("id")
                OnidChanged()
            End If
        End Set
    End Property

    Private _id As Global.System.Int32
    Private Partial Sub OnidChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnidChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property task_id() As Global.System.Int32
        Get
            Return _task_id
        End Get
        Set
            Ontask_idChanging(value)
            ReportPropertyChanging("task_id")
            _task_id = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("task_id")
            Ontask_idChanged()
        End Set
    End Property

    Private _task_id As Global.System.Int32
    Private Partial Sub Ontask_idChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub Ontask_idChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property event_id() As Global.System.Int32
        Get
            Return _event_id
        End Get
        Set
            Onevent_idChanging(value)
            ReportPropertyChanging("event_id")
            _event_id = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("event_id")
            Onevent_idChanged()
        End Set
    End Property

    Private _event_id As Global.System.Int32
    Private Partial Sub Onevent_idChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub Onevent_idChanged()
    End Sub

    #End Region
    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("action2eventsModel", "FK_task2event_events", "events")>
    Public Property [event]() As [event]
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of [event])("action2eventsModel.FK_task2event_events", "events").Value
        End Get
        Set
            CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of [event])("action2eventsModel.FK_task2event_events", "events").Value = value
        End Set
    End Property
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <BrowsableAttribute(False)>
    <DataMemberAttribute()>
    Public Property eventReference() As EntityReference(Of [event])
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of [event])("action2eventsModel.FK_task2event_events", "events")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of [event])("action2eventsModel.FK_task2event_events", "events", value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("action2eventsModel", "FK_task2event_tasks", "tasks")>
    Public Property task() As task
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of task)("action2eventsModel.FK_task2event_tasks", "tasks").Value
        End Get
        Set
            CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of task)("action2eventsModel.FK_task2event_tasks", "tasks").Value = value
        End Set
    End Property
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <BrowsableAttribute(False)>
    <DataMemberAttribute()>
    Public Property taskReference() As EntityReference(Of task)
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of task)("action2eventsModel.FK_task2event_tasks", "tasks")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of task)("action2eventsModel.FK_task2event_tasks", "tasks", value)
            End If
        End Set
    End Property

    #End Region
End Class

#End Region

