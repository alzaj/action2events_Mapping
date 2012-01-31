<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.debugLbl = New System.Windows.Forms.Label()
        Me.showBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'debugLbl
        '
        Me.debugLbl.AutoSize = True
        Me.debugLbl.Location = New System.Drawing.Point(13, 13)
        Me.debugLbl.Name = "debugLbl"
        Me.debugLbl.Size = New System.Drawing.Size(68, 13)
        Me.debugLbl.TabIndex = 2
        Me.debugLbl.Text = "Debug Label"
        '
        'showBtn
        '
        Me.showBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.showBtn.Location = New System.Drawing.Point(13, 230)
        Me.showBtn.Name = "showBtn"
        Me.showBtn.Size = New System.Drawing.Size(75, 23)
        Me.showBtn.TabIndex = 3
        Me.showBtn.Text = "Show"
        Me.showBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.clearBtn.Location = New System.Drawing.Point(95, 230)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 4
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(13, 30)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(263, 194)
        Me.TreeView1.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 262)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.showBtn)
        Me.Controls.Add(Me.debugLbl)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents debugLbl As System.Windows.Forms.Label
    Friend WithEvents showBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
