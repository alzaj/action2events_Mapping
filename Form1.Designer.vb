<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.closeForm = New System.Windows.Forms.Button()
        Me.saveChanges = New System.Windows.Forms.Button()
        Me.tasksGridView = New System.Windows.Forms.DataGridView()
        CType(Me.tasksGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeForm
        '
        Me.closeForm.Location = New System.Drawing.Point(197, 227)
        Me.closeForm.Name = "closeForm"
        Me.closeForm.Size = New System.Drawing.Size(75, 23)
        Me.closeForm.TabIndex = 0
        Me.closeForm.Text = "Close"
        Me.closeForm.UseVisualStyleBackColor = True
        '
        'saveChanges
        '
        Me.saveChanges.Location = New System.Drawing.Point(116, 226)
        Me.saveChanges.Name = "saveChanges"
        Me.saveChanges.Size = New System.Drawing.Size(75, 23)
        Me.saveChanges.TabIndex = 1
        Me.saveChanges.Text = "Save"
        Me.saveChanges.UseVisualStyleBackColor = True
        '
        'tasksGridView
        '
        Me.tasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tasksGridView.Location = New System.Drawing.Point(13, 13)
        Me.tasksGridView.Name = "tasksGridView"
        Me.tasksGridView.Size = New System.Drawing.Size(512, 192)
        Me.tasksGridView.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 262)
        Me.Controls.Add(Me.tasksGridView)
        Me.Controls.Add(Me.saveChanges)
        Me.Controls.Add(Me.closeForm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tasksGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents closeForm As System.Windows.Forms.Button
    Friend WithEvents saveChanges As System.Windows.Forms.Button
    Friend WithEvents tasksGridView As System.Windows.Forms.DataGridView

End Class
