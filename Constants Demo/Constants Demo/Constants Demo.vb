Public Class Form1
    'File name constant
    Private Const strFileName As String = "D:\Hello.txt"

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        'Using a constant
        MessageBox.Show("1: " & strFileName, "Constants Demo")
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        'Using the constant again
        MessageBox.Show("2: " & strFileName, "Constants Demo")
    End Sub
End Class
