Public Class frmMDIParent

    Private Sub frmMDIParent_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim frmChildA As New frmMDI_Child

        frmChildA.MdiParent = Me
        frmChildA.Show()

    End Sub
    Public Sub AddForm(Name As String, frmColor As String)
        Dim frmNew As New Form

        frmNew.MdiParent = Me
        frmNew.Name = Name
        frmNew.Text = Name
        frmNew.BackColor = Color.FromName(frmColor)
        frmNew.Show()

    End Sub

    Private Sub AddRedFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRedFormToolStripMenuItem.Click
        AddForm("Red Form", "Red")
    End Sub

    Private Sub CloseFormsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseFormsToolStripMenuItem.Click
        Me.MdiChildren.ToList.ForEach(Sub(f) If Not f.Name = "ControlPanel" Then f.Close())
    End Sub

    Private Sub ShowConrolPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowConrolPanelToolStripMenuItem.Click
        Dim lbSkip As Boolean

        'Single-line lambdas must include exactly one statement, use switches / flags 
        Me.MdiChildren.ToList.ForEach(Sub(f) If f.Name = "ControlPanel" Then lbSkip = True)

        If Not lbSkip Then
            Dim frmCPanel As New Form

            frmCPanel.MdiParent = Me
            frmCPanel.Name = "ControlPanel"
            frmCPanel.Text = "Control Panel"
            frmCPanel.Show()

            'Positioning has to be set after form has been loaded
            frmCPanel.Left = Me.Width - frmCPanel.Width - 20
        End If

    End Sub

    Public Sub SnapFormRight(Name As String)
        Me.MdiChildren.ToList.ForEach(Sub(f) If f.Name = Name Then f.Left = Me.Width - f.Width - 20)

    End Sub
End Class
