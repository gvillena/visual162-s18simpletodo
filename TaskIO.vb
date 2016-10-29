Public Class TaskIO

    Private Shared _Instance As TaskIO = Nothing
    Private _TaskList As List(Of Task)

    Public Shared ReadOnly Property Instance() As TaskIO
        Get
            If _Instance Is Nothing Then _Instance = New TaskIO()
            Return _Instance
        End Get
    End Property

    Public Shared ReadOnly Property Count() As Integer
        Get
            Return Instance._TaskList.Count
        End Get
    End Property

    Sub New()
        _TaskList = New List(Of Task)
        '_TaskList.Add(New Task() With {.Id = 1, .Titulo = "Mi Tarea 1", .Completado = False})
        '_TaskList.Add(New Task() With {.Id = 2, .Titulo = "Mi Tarea 2", .Completado = False})
        '_TaskList.Add(New Task() With {.Id = 3, .Titulo = "Mi Tarea 3", .Completado = False})
    End Sub

    Public Shared Function NextId() As Integer

        Instance._TaskList.Sort(Function(x, y) x.Id.CompareTo(y.Id))

        If Instance._TaskList.Count > 0 Then
            Return Instance._TaskList.Last.Id + 1
        End If

        Return 1


    End Function

    Public Shared Sub AddTask(task As Task)

        ' Agregando newtask a la lista de tareas
        Instance._TaskList.Add(task)
    End Sub

    Public Shared Sub AddTask(titulo As String)

        ' Declarando e inicializando newtask 
        Dim newTask = New Task()
        newTask.Id = TaskIO.NextId()
        newTask.Titulo = titulo
        newTask.Completado = False

        ' Agregando newtask a la lista de tareas
        TaskIO.AddTask(newTask)

    End Sub

    Public Shared Sub DeleteTask(id As Integer)
        Instance._TaskList.Remove(GetTask(id))
    End Sub

    Public Shared Sub UpdateTask(task As Task)
        DeleteTask(task.Id)
        AddTask(task)
        Instance._TaskList.Sort(Function(x, y) x.Id.CompareTo(y.Id))
    End Sub

    Public Shared Function GetTasks() As List(Of Task)
        Return Instance._TaskList
    End Function

    Public Shared Function GetTask(id As Integer) As Task
        Return Instance._TaskList.Find(Function(x) x.Id = id)
    End Function

End Class
