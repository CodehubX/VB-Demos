Public Class Form1
    'DayAction Enumerator
    Private Enum DayAction As Integer
        Asleep = 0
        GettingReadyForWork = 1
        TravellingToWork = 2
        AtWork = 3
        AtLunch = 4
        TravellingFromWork = 5
        RelaxingWithFriends = 6
        GettingReadyForBed = 7
    End Enum

    'Declare vairable
    Private CurrentState As DayAction

    'Hour property
    Private Property Hour() As Integer
        Get
            'Return the current hour displayed
            Return dtpHour.Value.Hour
        End Get
        Set(value As Integer)
            'Set the date using the hour passsed to this property
            dtpHour.Value =
                New Date(Now.Year, Now.Month, Now.Day, value, 0, 0)

            'Determine the state
            If value >= 6 And value < 7 Then
                CurrentState = DayAction.GettingReadyForWork
            ElseIf value >= 7 And value < 8 Then
                CurrentState = DayAction.TravellingToWork
            ElseIf value >= 8 And value < 9 Then
                CurrentState = DayAction.AtWork
            ElseIf value >= 9 And value < 10 Then
                CurrentState = DayAction.AtLunch
            ElseIf value >= 10 And value < 11 Then
                CurrentState = DayAction.AtWork
            ElseIf value >= 11 And value < 12 Then
                CurrentState = DayAction.TravellingFromWork
            ElseIf value >= 12 And value < 13 Then
                CurrentState = DayAction.GettingReadyForBed
            ElseIf value >= 13 And value < 14 Then
                CurrentState = DayAction.Asleep
            End If

            'Set the display text
            lblState.Text = "At" & value & ":00, Richard is " & CurrentState.ToString
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set the Hour property to the current hour
        Me.Hour = Now.Hour
    End Sub

    Private Sub dtpHour_ValueChanged(sender As Object, e As EventArgs) Handles dtpHour.ValueChanged
        'Update the Hour property
        Me.Hour = dtpHour.Value.Hour
    End Sub
End Class
