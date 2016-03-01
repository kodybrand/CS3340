<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassThread
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnWait = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnTerminate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstAllUsers = New System.Windows.Forms.ListBox()
        Me.txtTotalTransacions = New System.Windows.Forms.TextBox()
        Me.txtTotalBalance = New System.Windows.Forms.TextBox()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(313, 79)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnWait
        '
        Me.btnWait.Location = New System.Drawing.Point(313, 123)
        Me.btnWait.Name = "btnWait"
        Me.btnWait.Size = New System.Drawing.Size(75, 23)
        Me.btnWait.TabIndex = 1
        Me.btnWait.Text = "Wait"
        Me.btnWait.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(313, 167)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnTerminate
        '
        Me.btnTerminate.Location = New System.Drawing.Point(313, 211)
        Me.btnTerminate.Name = "btnTerminate"
        Me.btnTerminate.Size = New System.Drawing.Size(75, 23)
        Me.btnTerminate.TabIndex = 3
        Me.btnTerminate.Text = "Terminate"
        Me.btnTerminate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(313, 255)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstAllUsers
        '
        Me.lstAllUsers.FormattingEnabled = True
        Me.lstAllUsers.Location = New System.Drawing.Point(420, 79)
        Me.lstAllUsers.Name = "lstAllUsers"
        Me.lstAllUsers.Size = New System.Drawing.Size(233, 199)
        Me.lstAllUsers.TabIndex = 6
        '
        'txtTotalTransacions
        '
        Me.txtTotalTransacions.Location = New System.Drawing.Point(180, 35)
        Me.txtTotalTransacions.Name = "txtTotalTransacions"
        Me.txtTotalTransacions.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTransacions.TabIndex = 7
        '
        'txtTotalBalance
        '
        Me.txtTotalBalance.Location = New System.Drawing.Point(420, 34)
        Me.txtTotalBalance.Name = "txtTotalBalance"
        Me.txtTotalBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalBalance.TabIndex = 8
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Location = New System.Drawing.Point(177, 17)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(95, 13)
        Me.lblTransactions.TabIndex = 9
        Me.lblTransactions.Text = "Total Transactions"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(417, 17)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(73, 13)
        Me.lblBalance.TabIndex = 9
        Me.lblBalance.Text = "Total Balance"
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(47, 79)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(233, 199)
        Me.txtLog.TabIndex = 10
        '
        'FormClassThread
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblTransactions)
        Me.Controls.Add(Me.txtTotalBalance)
        Me.Controls.Add(Me.txtTotalTransacions)
        Me.Controls.Add(Me.lstAllUsers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTerminate)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnWait)
        Me.Controls.Add(Me.btnNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormClassThread"
        Me.Text = "FormClassThread"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnWait As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnTerminate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstAllUsers As System.Windows.Forms.ListBox
    Friend WithEvents txtTotalTransacions As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalBalance As System.Windows.Forms.TextBox
    Friend WithEvents lblTransactions As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
End Class
