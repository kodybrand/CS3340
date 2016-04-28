<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderClass
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
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.rdoEmployee = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.btnUpdateDetails = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Location = New System.Drawing.Point(470, 69)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(70, 17)
        Me.rdoAll.TabIndex = 0
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "All Orders"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'rdoEmployee
        '
        Me.rdoEmployee.AutoSize = True
        Me.rdoEmployee.Location = New System.Drawing.Point(470, 103)
        Me.rdoEmployee.Name = "rdoEmployee"
        Me.rdoEmployee.Size = New System.Drawing.Size(120, 17)
        Me.rdoEmployee.TabIndex = 1
        Me.rdoEmployee.TabStop = True
        Me.rdoEmployee.Text = "Orders By Employee"
        Me.rdoEmployee.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(429, 211)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(510, 211)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(470, 249)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvDetails
        '
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Location = New System.Drawing.Point(30, 185)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.Size = New System.Drawing.Size(317, 127)
        Me.dgvDetails.TabIndex = 6
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Location = New System.Drawing.Point(30, 156)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(115, 23)
        Me.btnUpdateOrder.TabIndex = 7
        Me.btnUpdateOrder.Text = "Update Order"
        Me.btnUpdateOrder.UseVisualStyleBackColor = True
        '
        'btnUpdateDetails
        '
        Me.btnUpdateDetails.Location = New System.Drawing.Point(30, 316)
        Me.btnUpdateDetails.Name = "btnUpdateDetails"
        Me.btnUpdateDetails.Size = New System.Drawing.Size(115, 23)
        Me.btnUpdateDetails.TabIndex = 8
        Me.btnUpdateDetails.Text = "Update Details"
        Me.btnUpdateDetails.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(470, 145)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 20)
        Me.txtName.TabIndex = 9
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(470, 171)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(169, 20)
        Me.txtID.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(380, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Employee ID"
        '
        'dgvOrders
        '
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Location = New System.Drawing.Point(30, 23)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.Size = New System.Drawing.Size(317, 127)
        Me.dgvOrders.TabIndex = 13
        '
        'FormOrderClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnUpdateDetails)
        Me.Controls.Add(Me.btnUpdateOrder)
        Me.Controls.Add(Me.dgvDetails)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.rdoEmployee)
        Me.Controls.Add(Me.rdoAll)
        Me.Name = "FormOrderClass"
        Me.Text = "Orders"
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdateOrder As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDetails As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvOrders As System.Windows.Forms.DataGridView
End Class
