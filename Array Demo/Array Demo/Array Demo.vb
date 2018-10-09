Public Class Form1
    'Declare an array
    Dim strFriends(4) As String

    Private Sub btnArrayElement_Click(sender As Object, e As EventArgs) Handles btnArrayElement.Click
        'Clear List
        ClearList()

        'Declare an array
        Dim strFriends(4) As String

        'Populate the array
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Mitchelle"
        strFriends(4) = "Kezzie"

        'Add the first array item to the list
        lstFriends.Items.Add(strFriends(0))
    End Sub

    Private Sub ClearList()
        'Clear the list
        lstFriends.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the array
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Mitchelle"
        strFriends(4) = "Kezzie"
    End Sub

    Private Sub btnEnumerateArray_Click(sender As Object, e As EventArgs) Handles btnEnumerateArray.Click
        'Clear List
        ClearList()

        'Enumerate Array
        For Each strName As String In strFriends
            'Add the array item to the list
            lstFriends.Items.Add(strName)
        Next
    End Sub
End Class
