<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCreateTask = New System.Windows.Forms.TextBox()
        Me.tlpTaskList = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTask1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTask1 = New System.Windows.Forms.Label()
        Me.cbTask1 = New System.Windows.Forms.CheckBox()
        Me.ilCheck = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDeleteT1 = New System.Windows.Forms.Button()
        Me.ilDelete = New System.Windows.Forms.ImageList(Me.components)
        Me.tlpTask2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTask2 = New System.Windows.Forms.Label()
        Me.cbTask2 = New System.Windows.Forms.CheckBox()
        Me.btnDeleteT2 = New System.Windows.Forms.Button()
        Me.tlpTask3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTask3 = New System.Windows.Forms.Label()
        Me.cbTask3 = New System.Windows.Forms.CheckBox()
        Me.btnDeleteT3 = New System.Windows.Forms.Button()
        Me.tlpTask4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTask4 = New System.Windows.Forms.Label()
        Me.cbTask4 = New System.Windows.Forms.CheckBox()
        Me.btnDeleteT4 = New System.Windows.Forms.Button()
        Me.tlpTask5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTask5 = New System.Windows.Forms.Label()
        Me.cbTask5 = New System.Windows.Forms.CheckBox()
        Me.btnDeleteT5 = New System.Windows.Forms.Button()
        Me.tlpTask6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTask6 = New System.Windows.Forms.Label()
        Me.cbTask6 = New System.Windows.Forms.CheckBox()
        Me.btnDeleteT6 = New System.Windows.Forms.Button()
        Me.tlpTaskList.SuspendLayout()
        Me.tlpTask1.SuspendLayout()
        Me.tlpTask2.SuspendLayout()
        Me.tlpTask3.SuspendLayout()
        Me.tlpTask4.SuspendLayout()
        Me.tlpTask5.SuspendLayout()
        Me.tlpTask6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(98, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Simple ToDo"
        '
        'txtCreateTask
        '
        Me.txtCreateTask.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateTask.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCreateTask.Location = New System.Drawing.Point(19, 101)
        Me.txtCreateTask.Name = "txtCreateTask"
        Me.txtCreateTask.Size = New System.Drawing.Size(388, 39)
        Me.txtCreateTask.TabIndex = 0
        Me.txtCreateTask.TabStop = False
        Me.txtCreateTask.Text = "¿alguna tarea por hacer?"
        Me.txtCreateTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tlpTaskList
        '
        Me.tlpTaskList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpTaskList.ColumnCount = 1
        Me.tlpTaskList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTaskList.Controls.Add(Me.tlpTask1, 0, 0)
        Me.tlpTaskList.Controls.Add(Me.tlpTask2, 0, 1)
        Me.tlpTaskList.Controls.Add(Me.tlpTask3, 0, 2)
        Me.tlpTaskList.Controls.Add(Me.tlpTask4, 0, 3)
        Me.tlpTaskList.Controls.Add(Me.tlpTask5, 0, 4)
        Me.tlpTaskList.Controls.Add(Me.tlpTask6, 0, 5)
        Me.tlpTaskList.Location = New System.Drawing.Point(19, 162)
        Me.tlpTaskList.Name = "tlpTaskList"
        Me.tlpTaskList.RowCount = 6
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTaskList.Size = New System.Drawing.Size(388, 310)
        Me.tlpTaskList.TabIndex = 3
        '
        'tlpTask1
        '
        Me.tlpTask1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTask1.ColumnCount = 3
        Me.tlpTask1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpTask1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313.0!))
        Me.tlpTask1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTask1.Controls.Add(Me.lblTask1, 1, 0)
        Me.tlpTask1.Controls.Add(Me.cbTask1, 0, 0)
        Me.tlpTask1.Controls.Add(Me.btnDeleteT1, 2, 0)
        Me.tlpTask1.Location = New System.Drawing.Point(4, 4)
        Me.tlpTask1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tlpTask1.Name = "tlpTask1"
        Me.tlpTask1.RowCount = 1
        Me.tlpTask1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTask1.Size = New System.Drawing.Size(380, 43)
        Me.tlpTask1.TabIndex = 4
        Me.tlpTask1.Visible = False
        '
        'lblTask1
        '
        Me.lblTask1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask1.AutoSize = True
        Me.lblTask1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask1.Location = New System.Drawing.Point(37, 5)
        Me.lblTask1.Name = "lblTask1"
        Me.lblTask1.Size = New System.Drawing.Size(71, 32)
        Me.lblTask1.TabIndex = 0
        Me.lblTask1.Text = "Task 1"
        '
        'cbTask1
        '
        Me.cbTask1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTask1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbTask1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbTask1.FlatAppearance.BorderSize = 0
        Me.cbTask1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cbTask1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cbTask1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cbTask1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask1.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask1.ImageIndex = 1
        Me.cbTask1.ImageList = Me.ilCheck
        Me.cbTask1.Location = New System.Drawing.Point(1, 1)
        Me.cbTask1.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.cbTask1.Name = "cbTask1"
        Me.cbTask1.Size = New System.Drawing.Size(33, 41)
        Me.cbTask1.TabIndex = 1
        Me.cbTask1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cbTask1.UseVisualStyleBackColor = True
        '
        'ilCheck
        '
        Me.ilCheck.ImageStream = CType(resources.GetObject("ilCheck.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilCheck.TransparentColor = System.Drawing.Color.Transparent
        Me.ilCheck.Images.SetKeyName(0, "checked.png")
        Me.ilCheck.Images.SetKeyName(1, "unchecked.png")
        '
        'btnDeleteT1
        '
        Me.btnDeleteT1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteT1.FlatAppearance.BorderSize = 0
        Me.btnDeleteT1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteT1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteT1.ImageList = Me.ilDelete
        Me.btnDeleteT1.Location = New System.Drawing.Point(348, 1)
        Me.btnDeleteT1.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteT1.Name = "btnDeleteT1"
        Me.btnDeleteT1.Size = New System.Drawing.Size(31, 41)
        Me.btnDeleteT1.TabIndex = 2
        Me.btnDeleteT1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteT1.UseVisualStyleBackColor = True
        '
        'ilDelete
        '
        Me.ilDelete.ImageStream = CType(resources.GetObject("ilDelete.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilDelete.TransparentColor = System.Drawing.Color.Transparent
        Me.ilDelete.Images.SetKeyName(0, "delete.png")
        '
        'tlpTask2
        '
        Me.tlpTask2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTask2.ColumnCount = 3
        Me.tlpTask2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpTask2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313.0!))
        Me.tlpTask2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTask2.Controls.Add(Me.lblTask2, 1, 0)
        Me.tlpTask2.Controls.Add(Me.cbTask2, 0, 0)
        Me.tlpTask2.Controls.Add(Me.btnDeleteT2, 2, 0)
        Me.tlpTask2.Location = New System.Drawing.Point(4, 55)
        Me.tlpTask2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tlpTask2.Name = "tlpTask2"
        Me.tlpTask2.RowCount = 1
        Me.tlpTask2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTask2.Size = New System.Drawing.Size(380, 43)
        Me.tlpTask2.TabIndex = 5
        Me.tlpTask2.Visible = False
        '
        'lblTask2
        '
        Me.lblTask2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask2.AutoSize = True
        Me.lblTask2.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask2.Location = New System.Drawing.Point(37, 5)
        Me.lblTask2.Name = "lblTask2"
        Me.lblTask2.Size = New System.Drawing.Size(74, 32)
        Me.lblTask2.TabIndex = 0
        Me.lblTask2.Text = "Task 2"
        '
        'cbTask2
        '
        Me.cbTask2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTask2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbTask2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbTask2.FlatAppearance.BorderSize = 0
        Me.cbTask2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cbTask2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cbTask2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cbTask2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask2.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask2.ImageIndex = 1
        Me.cbTask2.ImageList = Me.ilCheck
        Me.cbTask2.Location = New System.Drawing.Point(1, 1)
        Me.cbTask2.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.cbTask2.Name = "cbTask2"
        Me.cbTask2.Size = New System.Drawing.Size(33, 41)
        Me.cbTask2.TabIndex = 1
        Me.cbTask2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cbTask2.UseVisualStyleBackColor = True
        '
        'btnDeleteT2
        '
        Me.btnDeleteT2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteT2.FlatAppearance.BorderSize = 0
        Me.btnDeleteT2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteT2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteT2.ImageList = Me.ilDelete
        Me.btnDeleteT2.Location = New System.Drawing.Point(348, 1)
        Me.btnDeleteT2.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteT2.Name = "btnDeleteT2"
        Me.btnDeleteT2.Size = New System.Drawing.Size(31, 41)
        Me.btnDeleteT2.TabIndex = 2
        Me.btnDeleteT2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteT2.UseVisualStyleBackColor = True
        '
        'tlpTask3
        '
        Me.tlpTask3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTask3.ColumnCount = 3
        Me.tlpTask3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpTask3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313.0!))
        Me.tlpTask3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTask3.Controls.Add(Me.lblTask3, 1, 0)
        Me.tlpTask3.Controls.Add(Me.cbTask3, 0, 0)
        Me.tlpTask3.Controls.Add(Me.btnDeleteT3, 2, 0)
        Me.tlpTask3.Location = New System.Drawing.Point(4, 106)
        Me.tlpTask3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tlpTask3.Name = "tlpTask3"
        Me.tlpTask3.RowCount = 1
        Me.tlpTask3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTask3.Size = New System.Drawing.Size(380, 43)
        Me.tlpTask3.TabIndex = 5
        Me.tlpTask3.Visible = False
        '
        'lblTask3
        '
        Me.lblTask3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask3.AutoSize = True
        Me.lblTask3.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask3.Location = New System.Drawing.Point(37, 5)
        Me.lblTask3.Name = "lblTask3"
        Me.lblTask3.Size = New System.Drawing.Size(74, 32)
        Me.lblTask3.TabIndex = 0
        Me.lblTask3.Text = "Task 3"
        '
        'cbTask3
        '
        Me.cbTask3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTask3.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbTask3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbTask3.FlatAppearance.BorderSize = 0
        Me.cbTask3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cbTask3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cbTask3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cbTask3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask3.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask3.ImageIndex = 1
        Me.cbTask3.ImageList = Me.ilCheck
        Me.cbTask3.Location = New System.Drawing.Point(1, 1)
        Me.cbTask3.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.cbTask3.Name = "cbTask3"
        Me.cbTask3.Size = New System.Drawing.Size(33, 41)
        Me.cbTask3.TabIndex = 1
        Me.cbTask3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cbTask3.UseVisualStyleBackColor = True
        '
        'btnDeleteT3
        '
        Me.btnDeleteT3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteT3.FlatAppearance.BorderSize = 0
        Me.btnDeleteT3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteT3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteT3.ImageList = Me.ilDelete
        Me.btnDeleteT3.Location = New System.Drawing.Point(348, 1)
        Me.btnDeleteT3.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteT3.Name = "btnDeleteT3"
        Me.btnDeleteT3.Size = New System.Drawing.Size(31, 41)
        Me.btnDeleteT3.TabIndex = 2
        Me.btnDeleteT3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteT3.UseVisualStyleBackColor = True
        '
        'tlpTask4
        '
        Me.tlpTask4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTask4.ColumnCount = 3
        Me.tlpTask4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpTask4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313.0!))
        Me.tlpTask4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTask4.Controls.Add(Me.lblTask4, 1, 0)
        Me.tlpTask4.Controls.Add(Me.cbTask4, 0, 0)
        Me.tlpTask4.Controls.Add(Me.btnDeleteT4, 2, 0)
        Me.tlpTask4.Location = New System.Drawing.Point(4, 157)
        Me.tlpTask4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tlpTask4.Name = "tlpTask4"
        Me.tlpTask4.RowCount = 1
        Me.tlpTask4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTask4.Size = New System.Drawing.Size(380, 43)
        Me.tlpTask4.TabIndex = 5
        Me.tlpTask4.Visible = False
        '
        'lblTask4
        '
        Me.lblTask4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask4.AutoSize = True
        Me.lblTask4.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask4.Location = New System.Drawing.Point(37, 5)
        Me.lblTask4.Name = "lblTask4"
        Me.lblTask4.Size = New System.Drawing.Size(75, 32)
        Me.lblTask4.TabIndex = 0
        Me.lblTask4.Text = "Task 4"
        '
        'cbTask4
        '
        Me.cbTask4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTask4.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbTask4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbTask4.FlatAppearance.BorderSize = 0
        Me.cbTask4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cbTask4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cbTask4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cbTask4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask4.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask4.ImageIndex = 1
        Me.cbTask4.ImageList = Me.ilCheck
        Me.cbTask4.Location = New System.Drawing.Point(1, 1)
        Me.cbTask4.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.cbTask4.Name = "cbTask4"
        Me.cbTask4.Size = New System.Drawing.Size(33, 41)
        Me.cbTask4.TabIndex = 1
        Me.cbTask4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cbTask4.UseVisualStyleBackColor = True
        '
        'btnDeleteT4
        '
        Me.btnDeleteT4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteT4.FlatAppearance.BorderSize = 0
        Me.btnDeleteT4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteT4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteT4.ImageList = Me.ilDelete
        Me.btnDeleteT4.Location = New System.Drawing.Point(348, 1)
        Me.btnDeleteT4.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteT4.Name = "btnDeleteT4"
        Me.btnDeleteT4.Size = New System.Drawing.Size(31, 41)
        Me.btnDeleteT4.TabIndex = 2
        Me.btnDeleteT4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteT4.UseVisualStyleBackColor = True
        '
        'tlpTask5
        '
        Me.tlpTask5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTask5.ColumnCount = 3
        Me.tlpTask5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpTask5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313.0!))
        Me.tlpTask5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTask5.Controls.Add(Me.lblTask5, 1, 0)
        Me.tlpTask5.Controls.Add(Me.cbTask5, 0, 0)
        Me.tlpTask5.Controls.Add(Me.btnDeleteT5, 2, 0)
        Me.tlpTask5.Location = New System.Drawing.Point(4, 208)
        Me.tlpTask5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tlpTask5.Name = "tlpTask5"
        Me.tlpTask5.RowCount = 1
        Me.tlpTask5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTask5.Size = New System.Drawing.Size(380, 43)
        Me.tlpTask5.TabIndex = 5
        Me.tlpTask5.Visible = False
        '
        'lblTask5
        '
        Me.lblTask5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask5.AutoSize = True
        Me.lblTask5.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask5.Location = New System.Drawing.Point(37, 5)
        Me.lblTask5.Name = "lblTask5"
        Me.lblTask5.Size = New System.Drawing.Size(74, 32)
        Me.lblTask5.TabIndex = 0
        Me.lblTask5.Text = "Task 5"
        '
        'cbTask5
        '
        Me.cbTask5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTask5.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbTask5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbTask5.FlatAppearance.BorderSize = 0
        Me.cbTask5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cbTask5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cbTask5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cbTask5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask5.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask5.ImageIndex = 1
        Me.cbTask5.ImageList = Me.ilCheck
        Me.cbTask5.Location = New System.Drawing.Point(1, 1)
        Me.cbTask5.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.cbTask5.Name = "cbTask5"
        Me.cbTask5.Size = New System.Drawing.Size(33, 41)
        Me.cbTask5.TabIndex = 1
        Me.cbTask5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cbTask5.UseVisualStyleBackColor = True
        '
        'btnDeleteT5
        '
        Me.btnDeleteT5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteT5.FlatAppearance.BorderSize = 0
        Me.btnDeleteT5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteT5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteT5.ImageList = Me.ilDelete
        Me.btnDeleteT5.Location = New System.Drawing.Point(348, 1)
        Me.btnDeleteT5.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteT5.Name = "btnDeleteT5"
        Me.btnDeleteT5.Size = New System.Drawing.Size(31, 41)
        Me.btnDeleteT5.TabIndex = 2
        Me.btnDeleteT5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteT5.UseVisualStyleBackColor = True
        '
        'tlpTask6
        '
        Me.tlpTask6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTask6.ColumnCount = 3
        Me.tlpTask6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpTask6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313.0!))
        Me.tlpTask6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTask6.Controls.Add(Me.lblTask6, 1, 0)
        Me.tlpTask6.Controls.Add(Me.cbTask6, 0, 0)
        Me.tlpTask6.Controls.Add(Me.btnDeleteT6, 2, 0)
        Me.tlpTask6.Location = New System.Drawing.Point(4, 261)
        Me.tlpTask6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tlpTask6.Name = "tlpTask6"
        Me.tlpTask6.RowCount = 1
        Me.tlpTask6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTask6.Size = New System.Drawing.Size(380, 43)
        Me.tlpTask6.TabIndex = 5
        Me.tlpTask6.Visible = False
        '
        'lblTask6
        '
        Me.lblTask6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask6.AutoSize = True
        Me.lblTask6.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask6.Location = New System.Drawing.Point(37, 5)
        Me.lblTask6.Name = "lblTask6"
        Me.lblTask6.Size = New System.Drawing.Size(74, 32)
        Me.lblTask6.TabIndex = 0
        Me.lblTask6.Text = "Task 6"
        '
        'cbTask6
        '
        Me.cbTask6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTask6.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbTask6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbTask6.FlatAppearance.BorderSize = 0
        Me.cbTask6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cbTask6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cbTask6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cbTask6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask6.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask6.ImageIndex = 1
        Me.cbTask6.ImageList = Me.ilCheck
        Me.cbTask6.Location = New System.Drawing.Point(1, 1)
        Me.cbTask6.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.cbTask6.Name = "cbTask6"
        Me.cbTask6.Size = New System.Drawing.Size(33, 41)
        Me.cbTask6.TabIndex = 1
        Me.cbTask6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cbTask6.UseVisualStyleBackColor = True
        '
        'btnDeleteT6
        '
        Me.btnDeleteT6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteT6.FlatAppearance.BorderSize = 0
        Me.btnDeleteT6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteT6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteT6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteT6.ImageList = Me.ilDelete
        Me.btnDeleteT6.Location = New System.Drawing.Point(348, 1)
        Me.btnDeleteT6.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteT6.Name = "btnDeleteT6"
        Me.btnDeleteT6.Size = New System.Drawing.Size(31, 41)
        Me.btnDeleteT6.TabIndex = 2
        Me.btnDeleteT6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteT6.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(423, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpTaskList)
        Me.Controls.Add(Me.txtCreateTask)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tlpTaskList.ResumeLayout(False)
        Me.tlpTask1.ResumeLayout(False)
        Me.tlpTask1.PerformLayout()
        Me.tlpTask2.ResumeLayout(False)
        Me.tlpTask2.PerformLayout()
        Me.tlpTask3.ResumeLayout(False)
        Me.tlpTask3.PerformLayout()
        Me.tlpTask4.ResumeLayout(False)
        Me.tlpTask4.PerformLayout()
        Me.tlpTask5.ResumeLayout(False)
        Me.tlpTask5.PerformLayout()
        Me.tlpTask6.ResumeLayout(False)
        Me.tlpTask6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCreateTask As TextBox
    Friend WithEvents tlpTaskList As TableLayoutPanel
    Friend WithEvents lblTask1 As Label
    Friend WithEvents tlpTask1 As TableLayoutPanel
    Friend WithEvents cbTask1 As CheckBox
    Friend WithEvents ilCheck As ImageList
    Friend WithEvents btnDeleteT1 As Button
    Friend WithEvents ilDelete As ImageList
    Friend WithEvents tlpTask2 As TableLayoutPanel
    Friend WithEvents lblTask2 As Label
    Friend WithEvents cbTask2 As CheckBox
    Friend WithEvents btnDeleteT2 As Button
    Friend WithEvents tlpTask3 As TableLayoutPanel
    Friend WithEvents lblTask3 As Label
    Friend WithEvents cbTask3 As CheckBox
    Friend WithEvents btnDeleteT3 As Button
    Friend WithEvents tlpTask4 As TableLayoutPanel
    Friend WithEvents lblTask4 As Label
    Friend WithEvents cbTask4 As CheckBox
    Friend WithEvents btnDeleteT4 As Button
    Friend WithEvents tlpTask5 As TableLayoutPanel
    Friend WithEvents lblTask5 As Label
    Friend WithEvents cbTask5 As CheckBox
    Friend WithEvents btnDeleteT5 As Button
    Friend WithEvents tlpTask6 As TableLayoutPanel
    Friend WithEvents lblTask6 As Label
    Friend WithEvents cbTask6 As CheckBox
    Friend WithEvents btnDeleteT6 As Button
End Class
