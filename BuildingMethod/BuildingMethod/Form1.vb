Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare Variables
        Dim dblArea As Double

        'Calculate the area  of a circle with a radius of 100
        dblArea = CalculateAreaFromRadius(100)

        'displa results
        MessageBox.Show(dblArea.ToString, "Area of 100")
    End Sub

    Private Sub SayHello()
        'Display Welcome message
        MessageBox.Show("Hello World", "Three Buttons")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SayHello()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SayHello()
    End Sub

    'Calculate the area of a circle given the radius
    Private Function CalculateAreaFromRadius(ByVal radius As Double) As Double
        'declare variables
        Dim dblRadiusSquared As Double
        Dim dblResult As Double

        'Square the radius
        dblRadiusSquared = radius * radius

        'multiply by pi
        dblResult = dblRadiusSquared * Math.PI

        'return result
        Return dblResult
    End Function
End Class
