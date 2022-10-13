Public Class Center

    Private Sub Seconds_Click(sender As Object, e As EventArgs) Handles Sec1.Click, Sec3.Click, Sec10.Click
        SingleTimer.addSeconds(sender.Tag)
    End Sub

    Private Sub Minutes_Click(sender As Object, e As EventArgs) Handles Min1.Click, Min3.Click, Min10.Click
        SingleTimer.addMinutes(sender.Tag)
    End Sub



End Class
