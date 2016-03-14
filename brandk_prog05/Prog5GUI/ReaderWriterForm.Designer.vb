<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReaderWriterForm
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
        Me.lstWorking = New System.Windows.Forms.ListBox()
        Me.lstWaiting = New System.Windows.Forms.ListBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnNewReader = New System.Windows.Forms.Button()
        Me.btnNewWriter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstWorking
        '
        Me.lstWorking.FormattingEnabled = True
        Me.lstWorking.Location = New System.Drawing.Point(38, 136)
        Me.lstWorking.Name = "lstWorking"
        Me.lstWorking.Size = New System.Drawing.Size(201, 186)
        Me.lstWorking.TabIndex = 0
        '
        'lstWaiting
        '
        Me.lstWaiting.FormattingEnabled = True
        Me.lstWaiting.Location = New System.Drawing.Point(592, 136)
        Me.lstWaiting.Name = "lstWaiting"
        Me.lstWaiting.Size = New System.Drawing.Size(201, 186)
        Me.lstWaiting.TabIndex = 1
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(273, 97)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(284, 225)
        Me.txtLog.TabIndex = 2
        '
        'btnNewReader
        '
        Me.btnNewReader.Location = New System.Drawing.Point(220, 342)
        Me.btnNewReader.Name = "btnNewReader"
        Me.btnNewReader.Size = New System.Drawing.Size(75, 23)
        Me.btnNewReader.TabIndex = 3
        Me.btnNewReader.Text = "New Reader"
        Me.btnNewReader.UseVisualStyleBackColor = True
        '
        'btnNewWriter
        '
        Me.btnNewWriter.Location = New System.Drawing.Point(378, 343)
        Me.btnNewWriter.Name = "btnNewWriter"
        Me.btnNewWriter.Size = New System.Drawing.Size(75, 23)
        Me.btnNewWriter.TabIndex = 4
        Me.btnNewWriter.Text = "New Writer"
        Me.btnNewWriter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(536, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Working"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(671, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Waiting"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(394, 58)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total : "
        '
        'ReaderWriterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewWriter)
        Me.Controls.Add(Me.btnNewReader)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lstWaiting)
        Me.Controls.Add(Me.lstWorking)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ReaderWriterForm"
        Me.Text = "Readers and Writers - FIFO ( Kody Brand )"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWorking As System.Windows.Forms.ListBox
    Friend WithEvents lstWaiting As System.Windows.Forms.ListBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents btnNewReader As System.Windows.Forms.Button
    Friend WithEvents btnNewWriter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
