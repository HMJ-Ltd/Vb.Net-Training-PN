Public Class frmMDI_Child

    Private Sub cmdAddForm_Click(sender As Object, e As EventArgs) Handles cmdAddForm.Click
        'Reference public routine on parent form
        frmMDIParent.AddForm("Blue Form", "blue")
    End Sub

    Private Sub cmdAlighLeft_Click(sender As Object, e As EventArgs) Handles cmdAlighLeft.Click
        frmMDIParent.SnapFormRight(Me.Name)
        'Example of changing properties of a control on another form
        frmMDIParent.Controls("MenuStrip1").BackColor = Color.Beige
    End Sub

    Private Sub frmMDI_Child_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Example of changing properties of a control on another form / closing form event
        frmMDIParent.Controls("MenuStrip1").BackColor = Color.BlueViolet
    End Sub


End Class