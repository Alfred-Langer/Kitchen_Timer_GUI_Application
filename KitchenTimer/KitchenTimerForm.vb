Public Class KitchenTimerForm

    Private Sub OneSecond_Click(sender As Object, e As EventArgs) Handles OneSecond.Click, ThreeSecond.Click, TenSecond.Click

        SingleTimer.SelectedTimer.SecondsCounter1.increaseBy(sender.Tag)
        SingleTimer.SelectedTimer.StartButton.Enabled = True
        SingleTimer.SelectedTimer.ClearButton.Enabled = True
    End Sub

    Private Sub OneMinute_Click(sender As Object, e As EventArgs) Handles OneMinute.Click, ThreeMinute.Click, TenMinute.Click
        SingleTimer.SelectedTimer.MinutesCounter1.increaseBy(sender.Tag)
        SingleTimer.SelectedTimer.StartButton.Enabled = True
        SingleTimer.SelectedTimer.ClearButton.Enabled = True
    End Sub

End Class
