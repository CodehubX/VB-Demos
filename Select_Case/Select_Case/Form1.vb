Public Class Form1
    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged
        'Declare variables
        Dim strName As String
        Dim strFavoriteColor As String

        'Get the selected name
        strName = lstData.Items(lstData.SelectedIndex).ToString

        'Use a select Case Statement to get the favourite colour of
        'of the selected name

        Select Case strName
            Case "Bryan"
                strFavoriteColor = "Sea Blue"

            Case "Kevin"
                strFavoriteColor = "Morning Mist"

            Case "Tim"
                strFavoriteColor = "Passionate Purple"

            Case "Jay"
                strFavoriteColor = "Red"
        End Select

        'Display the favourite colour of the selected name
        MessageBox.Show(strName & "'s favourite color is " & strFavoriteColor, "Select Demo")

        'Use Select Case statement to display a person's gender
        Select Case strName.ToLower
            Case "bryan", "jay", "tim"
                MessageBox.Show("This person's gender is male.", "Select Demo")
            Case "kevin"
                MessageBox.Show("This person's gender is unknown.", "Select Demo")
        End Select
    End Sub
End Class
