<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassHouse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbRooms = New System.Windows.Forms.GroupBox()
        Me.rbR3 = New System.Windows.Forms.RadioButton()
        Me.rbR2 = New System.Windows.Forms.RadioButton()
        Me.rbR4 = New System.Windows.Forms.RadioButton()
        Me.gbGarages = New System.Windows.Forms.GroupBox()
        Me.rbG2 = New System.Windows.Forms.RadioButton()
        Me.rbG1 = New System.Windows.Forms.RadioButton()
        Me.rbG3 = New System.Windows.Forms.RadioButton()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbRooms.SuspendLayout()
        Me.gbGarages.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(49, 180)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrice.Location = New System.Drawing.Point(49, 241)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Chicago", "Madison", "Platteville"})
        Me.cboType.Location = New System.Drawing.Point(49, 118)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(72, 295)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbRooms
        '
        Me.gbRooms.Controls.Add(Me.rbR3)
        Me.gbRooms.Controls.Add(Me.rbR2)
        Me.gbRooms.Controls.Add(Me.rbR4)
        Me.gbRooms.Enabled = False
        Me.gbRooms.Location = New System.Drawing.Point(270, 103)
        Me.gbRooms.Name = "gbRooms"
        Me.gbRooms.Size = New System.Drawing.Size(254, 84)
        Me.gbRooms.TabIndex = 7
        Me.gbRooms.TabStop = False
        Me.gbRooms.Text = "Rooms"
        '
        'rbR3
        '
        Me.rbR3.AutoSize = True
        Me.rbR3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbR3.Location = New System.Drawing.Point(116, 32)
        Me.rbR3.Name = "rbR3"
        Me.rbR3.Size = New System.Drawing.Size(17, 30)
        Me.rbR3.TabIndex = 2
        Me.rbR3.TabStop = True
        Me.rbR3.Text = "3"
        Me.rbR3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbR3.UseVisualStyleBackColor = True
        '
        'rbR2
        '
        Me.rbR2.AutoSize = True
        Me.rbR2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbR2.Location = New System.Drawing.Point(195, 32)
        Me.rbR2.Name = "rbR2"
        Me.rbR2.Size = New System.Drawing.Size(17, 30)
        Me.rbR2.TabIndex = 1
        Me.rbR2.TabStop = True
        Me.rbR2.Text = "2"
        Me.rbR2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbR2.UseVisualStyleBackColor = True
        '
        'rbR4
        '
        Me.rbR4.AutoSize = True
        Me.rbR4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbR4.Location = New System.Drawing.Point(37, 32)
        Me.rbR4.Name = "rbR4"
        Me.rbR4.Size = New System.Drawing.Size(17, 30)
        Me.rbR4.TabIndex = 0
        Me.rbR4.TabStop = True
        Me.rbR4.Text = "4"
        Me.rbR4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbR4.UseVisualStyleBackColor = True
        '
        'gbGarages
        '
        Me.gbGarages.Controls.Add(Me.rbG2)
        Me.gbGarages.Controls.Add(Me.rbG1)
        Me.gbGarages.Controls.Add(Me.rbG3)
        Me.gbGarages.Enabled = False
        Me.gbGarages.Location = New System.Drawing.Point(270, 225)
        Me.gbGarages.Name = "gbGarages"
        Me.gbGarages.Size = New System.Drawing.Size(254, 84)
        Me.gbGarages.TabIndex = 8
        Me.gbGarages.TabStop = False
        Me.gbGarages.Text = "Garages"
        '
        'rbG2
        '
        Me.rbG2.AutoSize = True
        Me.rbG2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbG2.Location = New System.Drawing.Point(116, 38)
        Me.rbG2.Name = "rbG2"
        Me.rbG2.Size = New System.Drawing.Size(17, 30)
        Me.rbG2.TabIndex = 5
        Me.rbG2.TabStop = True
        Me.rbG2.Text = "2"
        Me.rbG2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbG2.UseVisualStyleBackColor = True
        '
        'rbG1
        '
        Me.rbG1.AutoSize = True
        Me.rbG1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbG1.Location = New System.Drawing.Point(195, 38)
        Me.rbG1.Name = "rbG1"
        Me.rbG1.Size = New System.Drawing.Size(17, 30)
        Me.rbG1.TabIndex = 4
        Me.rbG1.TabStop = True
        Me.rbG1.Text = "1"
        Me.rbG1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbG1.UseVisualStyleBackColor = True
        '
        'rbG3
        '
        Me.rbG3.AutoSize = True
        Me.rbG3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbG3.Location = New System.Drawing.Point(37, 38)
        Me.rbG3.Name = "rbG3"
        Me.rbG3.Size = New System.Drawing.Size(17, 30)
        Me.rbG3.TabIndex = 3
        Me.rbG3.TabStop = True
        Me.rbG3.Text = "3"
        Me.rbG3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbG3.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(360, 354)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 4
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(581, 163)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 5
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(581, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FormClassHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 451)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.gbGarages)
        Me.Controls.Add(Me.gbRooms)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormClassHouse"
        Me.Text = "Program 2 (Kody Brand)"
        Me.gbRooms.ResumeLayout(False)
        Me.gbRooms.PerformLayout()
        Me.gbGarages.ResumeLayout(False)
        Me.gbGarages.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbRooms As System.Windows.Forms.GroupBox
    Friend WithEvents rbR3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbR2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbR4 As System.Windows.Forms.RadioButton
    Friend WithEvents gbGarages As System.Windows.Forms.GroupBox
    Friend WithEvents rbG2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbG1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbG3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
