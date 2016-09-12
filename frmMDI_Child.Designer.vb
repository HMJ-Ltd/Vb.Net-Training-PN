<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDI_Child
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
        Me.cmdAddForm = New System.Windows.Forms.Button()
        Me.cmdAlighLeft = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAddForm
        '
        Me.cmdAddForm.Location = New System.Drawing.Point(21, 19)
        Me.cmdAddForm.Name = "cmdAddForm"
        Me.cmdAddForm.Size = New System.Drawing.Size(114, 35)
        Me.cmdAddForm.TabIndex = 0
        Me.cmdAddForm.Text = "Add Form"
        Me.cmdAddForm.UseVisualStyleBackColor = True
        '
        'cmdAlighLeft
        '
        Me.cmdAlighLeft.Location = New System.Drawing.Point(207, 19)
        Me.cmdAlighLeft.Name = "cmdAlighLeft"
        Me.cmdAlighLeft.Size = New System.Drawing.Size(65, 35)
        Me.cmdAlighLeft.TabIndex = 1
        Me.cmdAlighLeft.Text = "- - >"
        Me.cmdAlighLeft.UseVisualStyleBackColor = True
        '
        'frmMDI_Child
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdAlighLeft)
        Me.Controls.Add(Me.cmdAddForm)
        Me.Name = "frmMDI_Child"
        Me.Text = "MDI_Child_A"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAddForm As System.Windows.Forms.Button
    Friend WithEvents cmdAlighLeft As System.Windows.Forms.Button
End Class
