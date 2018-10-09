Public Class Form1
    Private Sub btnForNextLoop_Click(sender As Object, e As EventArgs) Handles btnForNextLoop.Click
        'Declare variable
        Dim intCount As Integer

        'Clear the ,list
        Clearlist()

        'Perform a loop
        For intCount = 1 To 5
            'add the item to the list
            lstData.Items.Add("I'm item " & intCount.ToString & " in the list")
        Next
    End Sub

    Private Sub Clearlist()
        'Clear the list
        lstData.Items.Clear()
    End Sub

    Private Sub btnForNextLoopWithStep_Click(sender As Object, e As EventArgs) Handles btnForNextLoopWithStep.Click
        'Clear the ,list
        Clearlist()

        'Perform a loop
        For intCount As Integer = 4 To 62 Step 7
            'add the item to the list
            lstData.Items.Add(intCount.ToString)
        Next
    End Sub

    Private Sub btnBackwardsForNextLoop_Click(sender As Object, e As EventArgs) Handles btnBackwardsForNextLoop.Click
        'Clear the ,list
        Clearlist()

        'Perform a loop
        For intCount As Integer = 10 To 1 Step -1
            'add the item to the list
            lstData.Items.Add(intCount.ToString)
        Next
    End Sub

    Private Sub btnForEachLoop_Click(sender As Object, e As EventArgs) Handles btnForEachLoop.Click
        'Clear the ,list
        Clearlist()

        'List each folder at the root of the C Drive
        For Each strFolder As String In
            My.Computer.FileSystem.GetDirectories("C:\")

            'Add the item to the list
            lstData.Items.Add(strFolder)
        Next
    End Sub

    Private Sub btnDoLoopUntil_Click(sender As Object, e As EventArgs) Handles btnDoLoopUntil.Click
        'Declare Vairables
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0

        'Clear the ,list
        Clearlist()

        'Process the loop until intRandomNumber = 10
        Do Until intRandomNumber = 10
            'Get a random number between 0 and 24
            intRandomNumber = objRandom.Next(25)
            'Add the number to the list
            lstData.Items.Add(intRandomNumber.ToString)
        Loop
    End Sub

    Private Sub btnDoWhileLoop_Click(sender As Object, e As EventArgs) Handles btnDoWhileLoop.Click
        'Declare variables
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0

        'Clear the ,list
        Clearlist()

        'Process the loop while intRandomNumber < 15
        Do While intRandomNumber < 15
            'Get a random number between 0 and 24
            intRandomNumber = objRandom.Next(25)
            'Add the numer to the list
            lstData.Items.Add(intRandomNumber.ToString)
        Loop
    End Sub

    Private Sub btnNestedLoops_Click(sender As Object, e As EventArgs) Handles btnNestedLoops.Click
        'Clear the ,list
        Clearlist()

        'Process an outer loop
        For intOuterLoop As Integer = 1 To 2
            'Process a nested (inner) loop
            For intInnerLoop As Integer = 1 To 3
                lstData.Items.Add(intOuterLoop.ToString & ", " & intInnerLoop.ToString)
            Next
        Next
    End Sub

    Private Sub btnQuittingAForLoop_Click(sender As Object, e As EventArgs) Handles btnQuittingAForLoop.Click
        'Clear the ,list
        Clearlist()

        'List each folder at the root of your C drive
        For Each strFolder As String In
                My.Computer.FileSystem.GetDirectories("C:\")

            'Add the item to the list
            lstData.Items.Add(strFolder)

            'Do you have a folfer C:\Program Files?
            If String.Compare(strFolder, "c:\program files", True) = 0 Then

                'Tell the user
                MessageBox.Show("Found it, exiting the loop now.", "Loops")

                'Quit the loop early
                Exit For
            End If
        Next
    End Sub

    Private Sub btnQuittingADoLoop_Click(sender As Object, e As EventArgs) Handles btnQuittingADoLoop.Click
        'Declare variable
        Dim intCount As Integer = 0

        'Clear the ,list
        Clearlist()

        'Porcess the Loop
        Do While intCount < 10
            'Add the item to the list
            lstData.Items.Add(intCount.ToString)

            'Increment the count by 1
            intCount += 1

            'Should you quit the Loop
            If intCount = 3 Then

                Exit Do
            End If

        Loop
    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        'Declare a variable
        Dim total As Integer = 0
        Dim numInput As Integer

        numInput = txtNumInput.Text.ToString

        'Loop and add numbers
        For count = 1 To numInput
            lstData.Items.Add(count)
            total = total + count
        Next

        lstData.Items.Add(total)
    End Sub

    Private Sub txtNumInput_Click(sender As Object, e As EventArgs) Handles txtNumInput.Click
        'Clear default message on click
        txtNumInput.Clear()
    End Sub

    Private Sub btnDoWhileClass_Click(sender As Object, e As EventArgs) Handles btnDoWhileClass.Click
        Dim n As Integer
        n = 1

        Do Until n > 10
            lstData.Items.Add(n)
            n = n + 1
        Loop
    End Sub

    Private Sub btnCountdown_Click(sender As Object, e As EventArgs) Handles btnCountdown.Click
        'Clear the ,list
        Clearlist()

        'loop backwards
        For sec As Integer = 60 To 0 Step -1
            lstData.Items.Add(sec)
        Next

        MsgBox("Countdown to 0 complete")

    End Sub
End Class
