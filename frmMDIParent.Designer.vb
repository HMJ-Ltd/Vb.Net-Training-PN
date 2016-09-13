<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDIParent
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddRedFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowConrolPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphicsFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRedFormToolStripMenuItem, Me.CloseFormsToolStripMenuItem, Me.ShowConrolPanelToolStripMenuItem, Me.GraphicsFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(875, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddRedFormToolStripMenuItem
        '
        Me.AddRedFormToolStripMenuItem.Name = "AddRedFormToolStripMenuItem"
        Me.AddRedFormToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.AddRedFormToolStripMenuItem.Text = "Add Red Form"
        '
        'CloseFormsToolStripMenuItem
        '
        Me.CloseFormsToolStripMenuItem.Name = "CloseFormsToolStripMenuItem"
        Me.CloseFormsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CloseFormsToolStripMenuItem.Text = "Close Forms"
        '
        'ShowConrolPanelToolStripMenuItem
        '
        Me.ShowConrolPanelToolStripMenuItem.Name = "ShowConrolPanelToolStripMenuItem"
        Me.ShowConrolPanelToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ShowConrolPanelToolStripMenuItem.Text = "Show Conrol Panel"
        '
        'GraphicsFormToolStripMenuItem
        '
        Me.GraphicsFormToolStripMenuItem.Name = "GraphicsFormToolStripMenuItem"
        Me.GraphicsFormToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.GraphicsFormToolStripMenuItem.Text = "Graphics Form"
        '
        'frmMDIParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 514)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMDIParent"
        Me.Text = "MDI Project Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddRedFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseFormsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowConrolPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraphicsFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
