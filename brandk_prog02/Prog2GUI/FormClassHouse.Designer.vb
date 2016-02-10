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
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lbType = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbRooms = New System.Windows.Forms.GroupBox()
        Me.rbRooms3 = New System.Windows.Forms.RadioButton()
        Me.rbRooms2 = New System.Windows.Forms.RadioButton()
        Me.rbRooms4 = New System.Windows.Forms.RadioButton()
        Me.gbGarages = New System.Windows.Forms.GroupBox()
        Me.rbGarages2 = New System.Windows.Forms.RadioButton()
        Me.rbGarages1 = New System.Windows.Forms.RadioButton()
        Me.rbGarages3 = New System.Windows.Forms.RadioButton()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.gbRooms.SuspendLayout()
        Me.gbGarages.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboType
        '
        Me.cboType.AutoCompleteCustomSource.AddRange(New String() {"Platteville", "Madison", "Chicago"})
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Chicago", "Madison", "Platteville"})
        Me.cboType.Location = New System.Drawing.Point(93, 128)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 0
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.Location = New System.Drawing.Point(138, 111)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(31, 13)
        Me.lbType.TabIndex = 3
        Me.lbType.Text = "Type"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(144, 183)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(18, 13)
        Me.lbID.TabIndex = 4
        Me.lbID.Text = "ID"
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Location = New System.Drawing.Point(138, 255)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(31, 13)
        Me.lbPrice.TabIndex = 5
        Me.lbPrice.Text = "Price"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(116, 335)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbRooms
        '
        Me.gbRooms.Controls.Add(Me.rbRooms3)
        Me.gbRooms.Controls.Add(Me.rbRooms2)
        Me.gbRooms.Controls.Add(Me.rbRooms4)
        Me.gbRooms.Enabled = False
        Me.gbRooms.Location = New System.Drawing.Point(310, 112)
        Me.gbRooms.Name = "gbRooms"
        Me.gbRooms.Size = New System.Drawing.Size(288, 100)
        Me.gbRooms.TabIndex = 7
        Me.gbRooms.TabStop = False
        Me.gbRooms.Text = "Rooms"
        '
        'rbRooms3
        '
        Me.rbRooms3.AutoSize = True
        Me.rbRooms3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbRooms3.Location = New System.Drawing.Point(127, 42)
        Me.rbRooms3.Name = "rbRooms3"
        Me.rbRooms3.Size = New System.Drawing.Size(17, 30)
        Me.rbRooms3.TabIndex = 1
        Me.rbRooms3.TabStop = True
        Me.rbRooms3.Text = "3"
        Me.rbRooms3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbRooms3.UseVisualStyleBackColor = True
        '
        'rbRooms2
        '
        Me.rbRooms2.AutoSize = True
        Me.rbRooms2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbRooms2.Location = New System.Drawing.Point(214, 42)
        Me.rbRooms2.Name = "rbRooms2"
        Me.rbRooms2.Size = New System.Drawing.Size(17, 30)
        Me.rbRooms2.TabIndex = 2
        Me.rbRooms2.TabStop = True
        Me.rbRooms2.Text = "2"
        Me.rbRooms2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbRooms2.UseVisualStyleBackColor = True
        '
        'rbRooms4
        '
        Me.rbRooms4.AutoSize = True
        Me.rbRooms4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbRooms4.Location = New System.Drawing.Point(40, 42)
        Me.rbRooms4.Name = "rbRooms4"
        Me.rbRooms4.Size = New System.Drawing.Size(17, 30)
        Me.rbRooms4.TabIndex = 0
        Me.rbRooms4.TabStop = True
        Me.rbRooms4.Text = "4"
        Me.rbRooms4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbRooms4.UseVisualStyleBackColor = True
        '
        'gbGarages
        '
        Me.gbGarages.Controls.Add(Me.rbGarages2)
        Me.gbGarages.Controls.Add(Me.rbGarages1)
        Me.gbGarages.Controls.Add(Me.rbGarages3)
        Me.gbGarages.Enabled = False
        Me.gbGarages.Location = New System.Drawing.Point(310, 241)
        Me.gbGarages.Name = "gbGarages"
        Me.gbGarages.Size = New System.Drawing.Size(288, 100)
        Me.gbGarages.TabIndex = 8
        Me.gbGarages.TabStop = False
        Me.gbGarages.Text = "Garages"
        '
        'rbGarages2
        '
        Me.rbGarages2.AutoSize = True
        Me.rbGarages2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbGarages2.Location = New System.Drawing.Point(127, 42)
        Me.rbGarages2.Name = "rbGarages2"
        Me.rbGarages2.Size = New System.Drawing.Size(17, 30)
        Me.rbGarages2.TabIndex = 1
        Me.rbGarages2.TabStop = True
        Me.rbGarages2.Text = "2"
        Me.rbGarages2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbGarages2.UseVisualStyleBackColor = True
        '
        'rbGarages1
        '
        Me.rbGarages1.AutoSize = True
        Me.rbGarages1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbGarages1.Location = New System.Drawing.Point(214, 42)
        Me.rbGarages1.Name = "rbGarages1"
        Me.rbGarages1.Size = New System.Drawing.Size(17, 30)
        Me.rbGarages1.TabIndex = 2
        Me.rbGarages1.TabStop = True
        Me.rbGarages1.Text = "1"
        Me.rbGarages1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbGarages1.UseVisualStyleBackColor = True
        '
        'rbGarages3
        '
        Me.rbGarages3.AutoSize = True
        Me.rbGarages3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbGarages3.Location = New System.Drawing.Point(40, 42)
        Me.rbGarages3.Name = "rbGarages3"
        Me.rbGarages3.Size = New System.Drawing.Size(17, 30)
        Me.rbGarages3.TabIndex = 0
        Me.rbGarages3.TabStop = True
        Me.rbGarages3.Text = "3"
        Me.rbGarages3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbGarages3.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(649, 197)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 5
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(649, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(407, 373)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 4
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(93, 199)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrice.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrice.Location = New System.Drawing.Point(93, 272)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.Tag = ""
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormClassHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 451)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.gbGarages)
        Me.Controls.Add(Me.gbRooms)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.cboType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormClassHouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Houses Kody Brand"
        Me.gbRooms.ResumeLayout(False)
        Me.gbRooms.PerformLayout()
        Me.gbGarages.ResumeLayout(False)
        Me.gbGarages.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents lbType As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents lbPrice As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbRooms As System.Windows.Forms.GroupBox
    Friend WithEvents rbRooms3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbRooms2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbRooms4 As System.Windows.Forms.RadioButton
    Friend WithEvents gbGarages As System.Windows.Forms.GroupBox
    Friend WithEvents rbGarages2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbGarages1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbGarages3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
End Class
