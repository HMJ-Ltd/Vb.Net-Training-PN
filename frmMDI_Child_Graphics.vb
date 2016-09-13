Public Class frmMDI_Child_Graphics

    ' Need to set a public handle to reference the graphics object (which is a component within System.Drawing loaded via IMPORTS on the primary form)
    Dim objGRAPHICS As Graphics

    ' Initialise random number generator
    Dim liRndInteger As New Random

    Private Sub frmMDI_Child_Graphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objGRAPHICS = Me.CreateGraphics

    End Sub

    Private Sub cmdMakeGrid_Click(sender As Object, e As EventArgs) Handles cmdMakeGrid.Click
        Dim x As Integer
        Dim y As Integer

        'Creating an array of "type" / class 
        Dim MyAnimal(4) As classAnimal

        'Creating a list, which is a one dimensional array
        Dim listOfHorses As New List(Of classAnimal)

        MyAnimal(0) = New classAnimal With {.AnimalType = "Horse", .Color = "Brown", .Quantity = "2"}

        MsgBox("What Animal" & vbCrLf & MyAnimal(0).AnimalType)


        'Clear graphics area (this form) and set background color to that used for Controls
        objGRAPHICS.Clear(Color.FromName("Control"))

        For x = 0 To 5
            For y = 0 To 4
                objGRAPHICS.DrawRectangle(Pens.Blue, New Rectangle(x * 32, y * 32, 32, 32))
                objGRAPHICS.DrawString(liRndInteger.Next(0, 100), Me.Font, Brushes.Green, New Point(x * 32, y * 32))
            Next
        Next


    End Sub
End Class