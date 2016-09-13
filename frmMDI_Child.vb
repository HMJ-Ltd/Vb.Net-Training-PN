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

    Private Sub frmMDI_Child_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOutput.Text = "The quick brown fox jumped over the lazy dog"
        cboOperator.SelectedIndex = 0
    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        If LCase(txtOutput.Text).Contains(LCase(txtFind.Text)) Then
            MsgBox("Found It")
        End If
    End Sub

    Private Sub cmdReplace_Click(sender As Object, e As EventArgs) Handles cmdReplace.Click
        Try
            txtOutput.Text = txtOutput.Text.Replace(txtFind.Text, txtReplace.Text)
        Catch
            'DO Nothing
        End Try
    End Sub

    Private Sub cmdSplit_Click(sender As Object, e As EventArgs) Handles cmdSplit.Click
        Dim s As String
        Dim liCount As Integer = 0
        Dim lsArray() As String

        s = txtOutput.Text
        txtOutput.Clear()
        For Each lsWord In Split(s, " ")
            txtOutput.Text = txtOutput.Text & lsWord & vbCrLf
        Next
        lsArray = Split(s, " ")
        'Add 1 as base zero
        MsgBox("No of elements (words) = " & UBound(lsArray) + 1)

        'Character account 
        For Each lsChar As Char In s
            liCount += 1
        Next

        MsgBox("No of characters = " & liCount)

    End Sub

    Private Sub cmdGetDate_Click(sender As Object, e As EventArgs) Handles cmdGetDate.Click
        txtOutput.Text = txtOutput.Text & vbCrLf & fnctGetDate
    End Sub

    Private Sub cmdAddDate2_Click(sender As Object, e As EventArgs) Handles cmdAddDate2.Click
        Dim s As String = txtOutput.Text.ToLower

        If s.Contains("date") AndAlso s.Contains("here") Then
            txtOutput.Text = String.Format("Today is {0}.", fnctGetDate)
        Else
            txtOutput.Text = "No Action - Missing the words date and here"
        End If
    End Sub

    'Calculator

    Private Function fncGetOperator() As EnuOperation
        Select cboOperator.Text
            Case "+" : Return enuOperation.Add
            Case "-" : Return enuOperation.Subtract
            Case "*" : Return enuOperation.Multiply
            Case "/" : Return enuOperation.Divide
            Case "%Co1:" : Return enuOperation.Percent
            Case Else : Return enuOperation.Add
        End Select
    End Function

    Private Function fncCalculate(A As Double, B As Double, Op As enuOperation) As Double
        If Op = enuOperation.Add Then Return A + B
        If Op = enuOperation.Subtract Then Return A - B
        If Op = enuOperation.Multiply Then Return A * B
        If Op = enuOperation.Divide Then Return A / B
        If Op = enuOperation.Percent Then Return (A / B) * 100
        'Must always return a value
        Return 0
    End Function

    Private Sub SubCalculate()
        Try
            txtResult.Text = fncCalculate(txtNum1.Text, txtNum2.Text, fncGetOperator)
        Catch ex As Exception
            txtResult.Text = "Error"
        End Try
    End Sub

    Private Enum enuOperation
        Add
        Subtract
        Multiply
        Divide
        Percent
    End Enum

    Private Sub txtResult_GotFocus(sender As Object, e As EventArgs) Handles txtResult.GotFocus
        SubCalculate()
    End Sub

    Private Sub cboOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperator.SelectedIndexChanged
        SubCalculate()
    End Sub
End Class