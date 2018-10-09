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

    Private Sub btnArraysAsParameters_Click(sender As Object, e As EventArgs) Handles btnArraysAsParameters.Click
        'Clear List
        ClearList()

        'List your friends
        AddItemsToList(strFriends)
    End Sub

    Private Sub AddItemsToLIst(ByRef arrayList As String())
        'Enumerate the array
        For Each strName As String In arrayList
            'Add the array item to the lsit
            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnMoreArrayParameters_Click(sender As Object, e As EventArgs) Handles btnMoreArrayParameters.Click
        'Clear List
        ClearList()

        'Declare an array
        Dim strMoreFriends(1) As String

        'populate the array
        strMoreFriends(0) = "Teyvon"
        strMoreFriends(1) = "Jenna"

        'List your friends
        AddItemsToLIst(strFriends)
        AddItemsToLIst(strMoreFriends)
    End Sub

    Private Sub btnSortingArrays_Click(sender As Object, e As EventArgs) Handles btnSortingArrays.Click
        'Clear List
        ClearList()

        'sort Arrays
        Array.Sort(strFriends)

        'List your friends
        AddItemsToLIst(strFriends)
    End Sub

    Private Sub btnReversingAnArray_Click(sender As Object, e As EventArgs) Handles btnReversingAnArray.Click
        'Clear List
        ClearList()

        'Reverse the order-elements
        Array.Reverse(strFriends)

        'List your friends
        AddItemsToLIst(strFriends)

    End Sub

    Private Sub btnInitialisingArraysWithValues_Click(sender As Object, e As EventArgs) Handles btnInitialisingArraysWithValues.Click
        'Clear List
        ClearList()

        'Declare and populate an array
        Dim strMyFriends() As String = {"Tevon", "Fred", "Debra", "Gingerana", "Hilda"}

        'List your friends
        AddItemsToLIst(strMyFriends)
    End Sub
End Class
