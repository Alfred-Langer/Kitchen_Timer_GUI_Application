Public Class Center
    Public Shared busyFlag = False

    Private Sub Seconds_Click(sender As Object, e As EventArgs) Handles Sec1.Click, Sec3.Click, Sec10.Click

        'SingleTimer.SelectedTimer.SecondsCounter1.increaseBy(sender.Tag)
        'SingleTimer.SelectedTimer.StartButton.Enabled = True
        'SingleTimer.SelectedTimer.ClearButton.Enabled = True
        busyFlag = True
        SingleTimer.addSeconds(sender.Tag)
        busyFlag = False
    End Sub

    Private Sub Minutes_Click(sender As Object, e As EventArgs) Handles Min1.Click, Min3.Click, Min10.Click
        'SingleTimer.SelectedTimer.MinutesCounter1.increaseBy(sender.Tag)
        'SingleTimer.SelectedTimer.StartButton.Enabled = True
        'SingleTimer.SelectedTimer.ClearButton.Enabled = True
        busyFlag = True
        SingleTimer.addMinutes(sender.Tag)
        busyFlag = False
    End Sub



End Class
