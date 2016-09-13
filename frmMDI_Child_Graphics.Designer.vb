<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDI_Child_Graphics
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
        Me.cmdMakeGrid = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdMakeGrid
        '
        Me.cmdMakeGrid.Location = New System.Drawing.Point(23, 213)
        Me.cmdMakeGrid.Name = "cmdMakeGrid"
        Me.cmdMakeGrid.Size = New System.Drawing.Size(75, 23)
        Me.cmdMakeGrid.TabIndex = 0
        Me.cmdMakeGrid.Text = "Show Grid"
        Me.cmdMakeGrid.UseVisualStyleBackColor = True
        '
        'frmMDI_Child_Graphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdMakeGrid)
        Me.Name = "frmMDI_Child_Graphics"
        Me.Text = "frmMDI_Child_Graphics"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdMakeGrid As System.Windows.Forms.Button
End Class
