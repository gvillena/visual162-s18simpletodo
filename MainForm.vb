Public Class MainForm

    Private TaskItems As New Dictionary(Of String, Integer)
    Private UpdatingList As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Tarea de Prueba
        Dim testTask = New Task() With {.Id = TaskIO.NextId(), .Titulo = "Tarea de prueba", .Completado = False}

        TaskIO.AddTask(testTask)

        ' Tasks Table Layout Panels
        tlpTask1.Visible = False
        tlpTask2.Visible = False
        tlpTask3.Visible = False
        tlpTask4.Visible = False
        tlpTask5.Visible = False
        tlpTask6.Visible = False

        ' Actualizar lista de tareas
        UpdateTaskList()

    End Sub

    Private Sub txtCreateTask_Enter(sender As Object, e As EventArgs) Handles txtCreateTask.Enter
        txtCreateTask.Text = ""
        txtCreateTask.ForeColor = Color.Black
    End Sub

    Private Sub txtCreateTask_Leave(sender As Object, e As EventArgs) Handles txtCreateTask.Leave
        txtCreateTask.Text = "¿alguna tarea por hacer?"
        txtCreateTask.ForeColor = Color.DarkGray
    End Sub

    Private Sub txtCreateTask_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreateTask.KeyPress

        ' Verificando tecla presionada
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            If TaskIO.Count = 6 Then
                MsgBox("No puede agregar mas de 6 tareas.")
            Else
                Dim tituloTarea = txtCreateTask.Text
                TaskIO.AddTask(tituloTarea)
                UpdateTaskList()
            End If

            tlpTaskList.Focus()
            e.Handled = True

        End If

    End Sub

    Private Sub UpdateTaskList()

        UpdatingList = True

        tlpTask1.Visible = False
        tlpTask2.Visible = False
        tlpTask3.Visible = False
        tlpTask4.Visible = False
        tlpTask5.Visible = False
        tlpTask6.Visible = False

        TaskItems.Clear()

        For Each t As Task In TaskIO.GetTasks

            Select Case False

                Case tlpTask1.Visible
                    cbTask1.Checked = t.Completado
                    lblTask1.Text = t.Titulo
                    tlpTask1.Visible = True
                    TaskItems.Add("TaskItem1", t.Id)

                Case tlpTask2.Visible
                    cbTask2.Checked = t.Completado
                    lblTask2.Text = t.Titulo
                    tlpTask2.Visible = True
                    TaskItems.Add("TaskItem2", t.Id)

                Case tlpTask3.Visible
                    cbTask3.Checked = t.Completado
                    lblTask3.Text = t.Titulo
                    tlpTask3.Visible = True
                    TaskItems.Add("TaskItem3", t.Id)

                Case tlpTask4.Visible
                    cbTask4.Checked = t.Completado
                    lblTask4.Text = t.Titulo
                    tlpTask4.Visible = True
                    TaskItems.Add("TaskItem4", t.Id)

                Case tlpTask5.Visible
                    cbTask5.Checked = t.Completado
                    lblTask5.Text = t.Titulo
                    tlpTask5.Visible = True
                    TaskItems.Add("TaskItem5", t.Id)

                Case tlpTask6.Visible
                    cbTask6.Checked = t.Completado
                    lblTask6.Text = t.Titulo
                    tlpTask6.Visible = True
                    TaskItems.Add("TaskItem6", t.Id)

            End Select

        Next

        UpdatingList = False

    End Sub

    Private Sub cbTask1_CheckedChanged(sender As Object, e As EventArgs) Handles cbTask1.CheckedChanged

        ' Salir en caso se este actualizando la lista
        If cbTask1.Checked Then
            cbTask1.ImageIndex = 0
            lblTask1.ForeColor = Color.LightGray
        Else
            cbTask1.ImageIndex = 1
            lblTask1.ForeColor = Color.Black
        End If

        ' Salir en caso se este actualizando la lista
        If UpdatingList Then Exit Sub

        Dim task = TaskIO.GetTask(TaskItems("TaskItem1"))
        task.Completado = cbTask1.Checked
        TaskIO.UpdateTask(task)
        UpdateTaskList()

    End Sub

    Private Sub cbTask2_CheckedChanged(sender As Object, e As EventArgs) Handles cbTask2.CheckedChanged

        ' Salir en caso se este actualizando la lista
        If cbTask2.Checked Then
            cbTask2.ImageIndex = 0
            lblTask2.ForeColor = Color.LightGray
        Else
            cbTask2.ImageIndex = 1
            lblTask2.ForeColor = Color.Black
        End If

        ' Salir en caso se este actualizando la lista
        If UpdatingList Then Exit Sub

        Dim task = TaskIO.GetTask(TaskItems("TaskItem2"))
        task.Completado = cbTask2.Checked
        TaskIO.UpdateTask(task)
        UpdateTaskList()

    End Sub

    Private Sub cbTask3_CheckedChanged(sender As Object, e As EventArgs) Handles cbTask3.CheckedChanged

        ' Salir en caso se este actualizando la lista
        If cbTask3.Checked Then
            cbTask3.ImageIndex = 0
            lblTask3.ForeColor = Color.LightGray
        Else
            cbTask3.ImageIndex = 1
            lblTask3.ForeColor = Color.Black
        End If

        ' Salir en caso se este actualizando la lista
        If UpdatingList Then Exit Sub

        Dim task = TaskIO.GetTask(TaskItems("TaskItem3"))
        task.Completado = cbTask3.Checked
        TaskIO.UpdateTask(task)
        UpdateTaskList()

    End Sub

    Private Sub cbTask4_CheckedChanged(sender As Object, e As EventArgs) Handles cbTask4.CheckedChanged

        ' Salir en caso se este actualizando la lista
        If cbTask4.Checked Then
            cbTask4.ImageIndex = 0
            lblTask4.ForeColor = Color.LightGray
        Else
            cbTask4.ImageIndex = 1
            lblTask4.ForeColor = Color.Black
        End If

        ' Salir en caso se este actualizando la lista
        If UpdatingList Then Exit Sub

        Dim task = TaskIO.GetTask(TaskItems("TaskItem4"))
        task.Completado = cbTask4.Checked
        TaskIO.UpdateTask(task)
        UpdateTaskList()

    End Sub

    Private Sub cbTask5_CheckedChanged(sender As Object, e As EventArgs) Handles cbTask5.CheckedChanged

        ' Salir en caso se este actualizando la lista
        If cbTask5.Checked Then
            cbTask5.ImageIndex = 0
            lblTask5.ForeColor = Color.LightGray
        Else
            cbTask5.ImageIndex = 1
            lblTask5.ForeColor = Color.Black
        End If

        ' Salir en caso se este actualizando la lista
        If UpdatingList Then Exit Sub

        Dim task = TaskIO.GetTask(TaskItems("TaskItem5"))
        task.Completado = cbTask5.Checked
        TaskIO.UpdateTask(task)
        UpdateTaskList()

    End Sub

    Private Sub cbTask6_CheckedChanged(sender As Object, e As EventArgs) Handles cbTask6.CheckedChanged

        ' Salir en caso se este actualizando la lista
        If cbTask6.Checked Then
            cbTask6.ImageIndex = 0
            lblTask6.ForeColor = Color.LightGray
        Else
            cbTask6.ImageIndex = 1
            lblTask6.ForeColor = Color.Black
        End If

        ' Salir en caso se este actualizando la lista
        If UpdatingList Then Exit Sub

        Dim task = TaskIO.GetTask(TaskItems("TaskItem6"))
        task.Completado = cbTask6.Checked
        TaskIO.UpdateTask(task)
        UpdateTaskList()

    End Sub

    Private Sub btnDeleteT1_Click(sender As Object, e As EventArgs) Handles btnDeleteT1.Click
        TaskIO.DeleteTask(TaskItems("TaskItem1"))
        UpdateTaskList()
    End Sub

    Private Sub btnDeleteT2_Click(sender As Object, e As EventArgs) Handles btnDeleteT2.Click
        TaskIO.DeleteTask(TaskItems("TaskItem2"))
        UpdateTaskList()
    End Sub

    Private Sub btnDeleteT3_Click(sender As Object, e As EventArgs) Handles btnDeleteT3.Click
        TaskIO.DeleteTask(TaskItems("TaskItem3"))
        UpdateTaskList()
    End Sub

    Private Sub btnDeleteT4_Click(sender As Object, e As EventArgs) Handles btnDeleteT4.Click
        TaskIO.DeleteTask(TaskItems("TaskItem4"))
        UpdateTaskList()
    End Sub

    Private Sub btnDeleteT5_Click(sender As Object, e As EventArgs) Handles btnDeleteT5.Click
        TaskIO.DeleteTask(TaskItems("TaskItem5"))
        UpdateTaskList()
    End Sub

    Private Sub btnDeleteT6_Click(sender As Object, e As EventArgs) Handles btnDeleteT6.Click
        TaskIO.DeleteTask(TaskItems("TaskItem6"))
        UpdateTaskList()
    End Sub

    Private Sub tlpTask1_MouseEnter(sender As Object, e As EventArgs) Handles tlpTask1.MouseEnter, cbTask1.MouseEnter, lblTask1.MouseEnter, btnDeleteT1.MouseEnter
        btnDeleteT1.ImageIndex = 0
    End Sub

    Private Sub tlpTask1_MouseLeave(sender As Object, e As EventArgs) Handles tlpTask1.MouseLeave, cbTask1.MouseLeave, lblTask1.MouseLeave, btnDeleteT1.MouseLeave
        btnDeleteT1.ImageIndex = -1
    End Sub

    Private Sub tlpTask2_MouseEnter(sender As Object, e As EventArgs) Handles tlpTask2.MouseEnter, cbTask2.MouseEnter, lblTask2.MouseEnter, btnDeleteT2.MouseEnter
        btnDeleteT2.ImageIndex = 0
    End Sub

    Private Sub tlpTask2_MouseLeave(sender As Object, e As EventArgs) Handles tlpTask2.MouseLeave, cbTask2.MouseLeave, lblTask2.MouseLeave, btnDeleteT2.MouseLeave
        btnDeleteT2.ImageIndex = -1
    End Sub

    Private Sub tlpTask3_MouseEnter(sender As Object, e As EventArgs) Handles tlpTask3.MouseEnter, cbTask3.MouseEnter, lblTask3.MouseEnter, btnDeleteT3.MouseEnter
        btnDeleteT3.ImageIndex = 0
    End Sub

    Private Sub tlpTask3_MouseLeave(sender As Object, e As EventArgs) Handles tlpTask3.MouseLeave, cbTask3.MouseLeave, lblTask3.MouseLeave, btnDeleteT3.MouseLeave
        btnDeleteT3.ImageIndex = -1
    End Sub

    Private Sub tlpTask4_MouseEnter(sender As Object, e As EventArgs) Handles tlpTask4.MouseEnter, cbTask4.MouseEnter, lblTask4.MouseEnter, btnDeleteT4.MouseEnter
        btnDeleteT4.ImageIndex = 0
    End Sub

    Private Sub tlpTask4_MouseLeave(sender As Object, e As EventArgs) Handles tlpTask4.MouseLeave, cbTask4.MouseLeave, lblTask4.MouseLeave, btnDeleteT4.MouseLeave
        btnDeleteT4.ImageIndex = -1
    End Sub

    Private Sub tlpTask5_MouseEnter(sender As Object, e As EventArgs) Handles tlpTask5.MouseEnter, cbTask5.MouseEnter, lblTask5.MouseEnter, btnDeleteT5.MouseEnter
        btnDeleteT5.ImageIndex = 0
    End Sub

    Private Sub tlpTask5_MouseLeave(sender As Object, e As EventArgs) Handles tlpTask5.MouseLeave, cbTask5.MouseLeave, lblTask5.MouseLeave, btnDeleteT5.MouseLeave
        btnDeleteT5.ImageIndex = -1
    End Sub

    Private Sub tlpTask6_MouseEnter(sender As Object, e As EventArgs) Handles tlpTask6.MouseEnter, cbTask6.MouseEnter, lblTask6.MouseEnter, btnDeleteT6.MouseEnter
        btnDeleteT6.ImageIndex = 0
    End Sub

    Private Sub tlpTask6_MouseLeave(sender As Object, e As EventArgs) Handles tlpTask6.MouseLeave, cbTask6.MouseLeave, lblTask6.MouseLeave, btnDeleteT6.MouseLeave
        btnDeleteT6.ImageIndex = -1
    End Sub

End Class