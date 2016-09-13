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
        Me.cmdAlighLeft = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdReplace = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.cmdSplit = New System.Windows.Forms.Button()
        Me.cmdAddForm = New System.Windows.Forms.Button()
        Me.cmdGetDate = New System.Windows.Forms.Button()
        Me.cmdAddDate2 = New System.Windows.Forms.Button()
        Me.fraCalculator = New System.Windows.Forms.GroupBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.cboOperator = New System.Windows.Forms.ComboBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.fraCalculator.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAlighLeft
        '
        Me.cmdAlighLeft.Location = New System.Drawing.Point(513, 12)
        Me.cmdAlighLeft.Name = "cmdAlighLeft"
        Me.cmdAlighLeft.Size = New System.Drawing.Size(65, 35)
        Me.cmdAlighLeft.TabIndex = 1
        Me.cmdAlighLeft.Text = "- - >"
        Me.cmdAlighLeft.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(324, 103)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(254, 328)
        Me.txtOutput.TabIndex = 2
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(181, 103)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(114, 35)
        Me.cmdFind.TabIndex = 3
        Me.cmdFind.Text = "Find String"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'cmdReplace
        '
        Me.cmdReplace.Location = New System.Drawing.Point(181, 154)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(114, 35)
        Me.cmdReplace.TabIndex = 4
        Me.cmdReplace.Text = "Replace"
        Me.cmdReplace.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(7, 107)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(147, 22)
        Me.txtFind.TabIndex = 5
        '
        'txtReplace
        '
        Me.txtReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReplace.Location = New System.Drawing.Point(7, 160)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(147, 22)
        Me.txtReplace.TabIndex = 6
        '
        'cmdSplit
        '
        Me.cmdSplit.Location = New System.Drawing.Point(181, 205)
        Me.cmdSplit.Name = "cmdSplit"
        Me.cmdSplit.Size = New System.Drawing.Size(114, 35)
        Me.cmdSplit.TabIndex = 7
        Me.cmdSplit.Text = "Split"
        Me.cmdSplit.UseVisualStyleBackColor = True
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
        'cmdGetDate
        '
        Me.cmdGetDate.Location = New System.Drawing.Point(155, 19)
        Me.cmdGetDate.Name = "cmdGetDate"
        Me.cmdGetDate.Size = New System.Drawing.Size(114, 35)
        Me.cmdGetDate.TabIndex = 8
        Me.cmdGetDate.Text = "Add Date"
        Me.cmdGetDate.UseVisualStyleBackColor = True
        '
        'cmdAddDate2
        '
        Me.cmdAddDate2.Location = New System.Drawing.Point(291, 19)
        Me.cmdAddDate2.Name = "cmdAddDate2"
        Me.cmdAddDate2.Size = New System.Drawing.Size(114, 35)
        Me.cmdAddDate2.TabIndex = 9
        Me.cmdAddDate2.Text = "Add Date with{}"
        Me.cmdAddDate2.UseVisualStyleBackColor = True
        '
        'fraCalculator
        '
        Me.fraCalculator.Controls.Add(Me.txtResult)
        Me.fraCalculator.Controls.Add(Me.txtNum2)
        Me.fraCalculator.Controls.Add(Me.cboOperator)
        Me.fraCalculator.Controls.Add(Me.txtNum1)
        Me.fraCalculator.Location = New System.Drawing.Point(20, 273)
        Me.fraCalculator.Name = "fraCalculator"
        Me.fraCalculator.Size = New System.Drawing.Size(274, 184)
        Me.fraCalculator.TabIndex = 10
        Me.fraCalculator.TabStop = False
        Me.fraCalculator.Text = "Calculator using Operation"
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(8, 147)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(147, 22)
        Me.txtResult.TabIndex = 9
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(8, 70)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(147, 22)
        Me.txtNum2.TabIndex = 8
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboOperator
        '
        Me.cboOperator.FormattingEnabled = True
        Me.cboOperator.Items.AddRange(New Object() {"+", "-", "/", "*", "%"})
        Me.cboOperator.Location = New System.Drawing.Point(8, 110)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.Size = New System.Drawing.Size(52, 21)
        Me.cboOperator.TabIndex = 7
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(6, 31)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(147, 22)
        Me.txtNum1.TabIndex = 6
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmMDI_Child
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 527)
        Me.Controls.Add(Me.fraCalculator)
        Me.Controls.Add(Me.cmdAddDate2)
        Me.Controls.Add(Me.cmdGetDate)
        Me.Controls.Add(Me.cmdSplit)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.cmdReplace)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.cmdAlighLeft)
        Me.Controls.Add(Me.cmdAddForm)
        Me.Name = "frmMDI_Child"
        Me.Text = "MDI_Child_A"
        Me.fraCalculator.ResumeLayout(False)
        Me.fraCalculator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAlighLeft As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdReplace As System.Windows.Forms.Button
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents cmdSplit As System.Windows.Forms.Button
    Friend WithEvents cmdAddForm As System.Windows.Forms.Button
    Friend WithEvents cmdGetDate As System.Windows.Forms.Button
    Friend WithEvents cmdAddDate2 As System.Windows.Forms.Button
    Friend WithEvents fraCalculator As System.Windows.Forms.GroupBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents cboOperator As System.Windows.Forms.ComboBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
End Class
