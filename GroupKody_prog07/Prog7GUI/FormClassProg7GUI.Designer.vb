<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassProg7GUI
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
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnDB = New System.Windows.Forms.Button()
        Me.bntExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmployees
        '
        Me.btnEmployees.Location = New System.Drawing.Point(97, 77)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(75, 23)
        Me.btnEmployees.TabIndex = 0
        Me.btnEmployees.Text = "Employees "
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(192, 77)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(75, 23)
        Me.btnCustomers.TabIndex = 0
        Me.btnCustomers.Text = "Customers "
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(287, 77)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(75, 23)
        Me.btnProducts.TabIndex = 0
        Me.btnProducts.Text = "Products "
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Location = New System.Drawing.Point(382, 77)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(75, 23)
        Me.btnOrders.TabIndex = 0
        Me.btnOrders.Text = "Orders "
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnDB
        '
        Me.btnDB.Location = New System.Drawing.Point(192, 138)
        Me.btnDB.Name = "btnDB"
        Me.btnDB.Size = New System.Drawing.Size(75, 23)
        Me.btnDB.TabIndex = 0
        Me.btnDB.Text = "DB Location"
        Me.btnDB.UseVisualStyleBackColor = True
        '
        'bntExit
        '
        Me.bntExit.Location = New System.Drawing.Point(287, 138)
        Me.bntExit.Name = "bntExit"
        Me.bntExit.Size = New System.Drawing.Size(75, 23)
        Me.bntExit.TabIndex = 0
        Me.bntExit.Text = "Exit"
        Me.bntExit.UseVisualStyleBackColor = True
        '
        'FormClassProg7GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOrders)
        Me.Controls.Add(Me.bntExit)
        Me.Controls.Add(Me.btnDB)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnEmployees)
        Me.Name = "FormClassProg7GUI"
        Me.Text = "Prog 7 (GroupKody)"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnCustomers As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents btnOrders As System.Windows.Forms.Button
    Friend WithEvents btnDB As System.Windows.Forms.Button
    Friend WithEvents bntExit As System.Windows.Forms.Button
End Class
