<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGridClass
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGridClass))
        Me.TheBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.btnFirst = New System.Windows.Forms.ToolStripButton()
        Me.btnPrev = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNext = New System.Windows.Forms.ToolStripButton()
        Me.btnLast = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripLabel()
        Me.btnReload = New System.Windows.Forms.ToolStripLabel()
        Me.btnBack = New System.Windows.Forms.ToolStripLabel()
        Me.TheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TheDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.TheBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TheBindingNavigator.SuspendLayout()
        CType(Me.TheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TheDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TheBindingNavigator
        '
        Me.TheBindingNavigator.AddNewItem = Me.BindingNavigatorCountItem
        Me.TheBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TheBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TheBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFirst, Me.btnPrev, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.btnNext, Me.btnLast, Me.BindingNavigatorSeparator2, Me.btnNew, Me.BindingNavigatorDeleteItem, Me.btnSave, Me.btnReload, Me.btnBack})
        Me.TheBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TheBindingNavigator.MoveFirstItem = Me.btnFirst
        Me.TheBindingNavigator.MoveLastItem = Me.btnLast
        Me.TheBindingNavigator.MoveNextItem = Me.btnNext
        Me.TheBindingNavigator.MovePreviousItem = Me.btnPrev
        Me.TheBindingNavigator.Name = "TheBindingNavigator"
        Me.TheBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TheBindingNavigator.Size = New System.Drawing.Size(653, 25)
        Me.TheBindingNavigator.TabIndex = 0
        Me.TheBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'btnFirst
        '
        Me.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFirst.Image = CType(resources.GetObject("btnFirst.Image"), System.Drawing.Image)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.RightToLeftAutoMirrorImage = True
        Me.btnFirst.Size = New System.Drawing.Size(23, 22)
        Me.btnFirst.Text = "Move first"
        '
        'btnPrev
        '
        Me.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrev.Image = CType(resources.GetObject("btnPrev.Image"), System.Drawing.Image)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.RightToLeftAutoMirrorImage = True
        Me.btnPrev.Size = New System.Drawing.Size(23, 22)
        Me.btnPrev.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNext
        '
        Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.RightToLeftAutoMirrorImage = True
        Me.btnNext.Size = New System.Drawing.Size(23, 22)
        Me.btnNext.Text = "Move next"
        '
        'btnLast
        '
        Me.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), System.Drawing.Image)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.RightToLeftAutoMirrorImage = True
        Me.btnLast.Size = New System.Drawing.Size(23, 22)
        Me.btnLast.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.RightToLeftAutoMirrorImage = True
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "Add new"
        '
        'btnSave
        '
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(31, 22)
        Me.btnSave.Text = "Save"
        '
        'btnReload
        '
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(43, 22)
        Me.btnReload.Text = "Reload"
        '
        'btnBack
        '
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 22)
        Me.btnBack.Text = "Back"
        '
        'TheDataGridView
        '
        Me.TheDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TheDataGridView.Location = New System.Drawing.Point(22, 42)
        Me.TheDataGridView.Name = "TheDataGridView"
        Me.TheDataGridView.Size = New System.Drawing.Size(619, 322)
        Me.TheDataGridView.TabIndex = 1
        '
        'FormGridClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.TheDataGridView)
        Me.Controls.Add(Me.TheBindingNavigator)
        Me.Name = "FormGridClass"
        Me.Text = "FormGridClass"
        CType(Me.TheBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TheBindingNavigator.ResumeLayout(False)
        Me.TheBindingNavigator.PerformLayout()
        CType(Me.TheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TheDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnReload As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnBack As System.Windows.Forms.ToolStripLabel
    Public WithEvents TheDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TheBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents TheBindingSource As System.Windows.Forms.BindingSource
End Class
