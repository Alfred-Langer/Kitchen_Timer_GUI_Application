Imports System.ComponentModel

Public Class SingleTimer

    'Defining the three properties of the Single Timer Class. (I needed to add the Editor Browsable, Browsable, and Description attributes
    'in order to see them in the properties window)

    <System.ComponentModel.EditorBrowsable(True)>
    <System.ComponentModel.Browsable(True)>
    <System.ComponentModel.Description("This is the title")>
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal NewValue As String)
            _title = NewValue
            Me.TitleLabel.Text = NewValue
        End Set
    End Property

    <System.ComponentModel.EditorBrowsable(True)>
    <System.ComponentModel.Browsable(True)>
    <System.ComponentModel.Description("This is the Frequency of the Single Timer Alarm")>
    Public Property Alarm_Frequency() As Integer
        Get
            Return frequency
        End Get
        Set(ByVal NewValue As Integer)
            frequency = NewValue
        End Set
    End Property

    <System.ComponentModel.EditorBrowsable(True)>
    <System.ComponentModel.Browsable(True)>
    <System.ComponentModel.Description("This is the Duration of the Single Timer Alarm")>
    Public Property Alarm_Beeps() As Integer
        Get
            Return beeps
        End Get
        Set(ByVal NewValue As Integer)
            beeps = NewValue
        End Set
    End Property
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        'This is where I give the SecondsCounter and MinutesCounter references to each other
        Me.Seconds.setMinutesCounter(Me.Minutes)
        Me.Minutes.setSecondsCounter(Me.Seconds)

    End Sub


    Public Shared Sub addMinutes(extraMins As Integer)
        If SingleTimer.SelectedTimer.countdown = False And SingleTimer.SelectedTimer.beeping = False Then
            SingleTimer.SelectedTimer.AddMinutesToSelected(extraMins)
            SingleTimer.SelectedTimer.StartButton.Enabled = True
            SingleTimer.SelectedTimer.ClearButton.Enabled = True
        End If

    End Sub

    Private Sub AddMinutesToSelected(extraMins As Integer)
        Me.Minutes.increaseBy(extraMins)
    End Sub

    Public Shared Sub addSeconds(extraSeconds As Integer)
        If SingleTimer.SelectedTimer.countdown = False And SingleTimer.SelectedTimer.beeping = False Then
            SingleTimer.SelectedTimer.AddSecondsToSelected(extraSeconds)
            SingleTimer.SelectedTimer.StartButton.Enabled = True
            SingleTimer.SelectedTimer.ClearButton.Enabled = True
        End If

    End Sub

    Private Sub AddSecondsToSelected(extraSeconds As Integer)
        Me.Seconds.increaseBy(extraSeconds)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetLook()
        If ClearButton.Enabled = True Then
            Me.Timer.Enabled = False
            Me.countdown = False
            Center.ActiveControl = Nothing
            StopButton.Enabled = False
            Me.Minutes.setValue(0)
            Me.Seconds.setValue(0)
            Me.Timer.Interval = 1000
            DisableAllButtons()
        End If

    End Sub

    Private Sub ClearButton_EnabledChanged(sender As Object, e As EventArgs) Handles ClearButton.EnabledChanged
        If ClearButton.Enabled = True Then
            ClearButton.ForeColor = System.Drawing.Color.Black
            ClearButton.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub deselectMe()
        If Me.beeping = True Then
            alarmColours()
        Else
            Me.newForeColor(System.Drawing.Color.RoyalBlue)
        End If
        Me.newBackColor(System.Drawing.SystemColors.ActiveCaption)
        Me.TitleLabel.Checked = False
        Me.ColonLabel.Visible = True

    End Sub

    Private Sub DisableAllButtons()
        ClearButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        ClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        StopButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        StopButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        StartButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        StartButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Center.ActiveControl = Nothing
        Me.StopButton.Enabled = False
        Me.StartButton.Enabled = False
        Me.ClearButton.Enabled = False
    End Sub

    Private Sub newBackColor(newColor As Color)
        Me.BackColor = newColor
    End Sub

    Private Sub newForeColor(newColor As Color)
        Me.TitleLabel.ForeColor = newColor
        Me.Seconds.ForeColor = newColor
        Me.Minutes.ForeColor = newColor
        Me.ColonLabel.ForeColor = newColor
    End Sub

    Private Sub selectMe()

        If Me.beeping = True Then
            alarmColours()
        Else
            Me.newForeColor(SystemColors.Control)
        End If
        Me.newBackColor(System.Drawing.SystemColors.Highlight)
        Me.TitleLabel.Checked = True
        Me.ColonLabel.Visible = True
        SingleTimer.SelectedTimer = Me

    End Sub

    Private Sub SingleTimer_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        If SingleTimer.SelectedTimer Is Me Then
            Me.newBackColor(System.Drawing.SystemColors.Highlight)
            Me.newForeColor(SystemColors.Control)
            Me.TitleLabel.Checked = True
        End If
    End Sub

    Private Sub SetLook()
        If Center.SingleTimer1 Is Me Then
            Me.selectMe()
            Center.SingleTimer2.deselectMe()
            Center.SingleTimer3.deselectMe()
            Center.SingleTimer4.deselectMe()
        ElseIf Center.SingleTimer2 Is Me Then
            Me.selectMe()
            Center.SingleTimer1.deselectMe()
            Center.SingleTimer3.deselectMe()
            Center.SingleTimer4.deselectMe()
        ElseIf Center.SingleTimer3 Is Me Then
            Me.selectMe()
            Center.SingleTimer2.deselectMe()
            Center.SingleTimer1.deselectMe()
            Center.SingleTimer4.deselectMe()
        ElseIf Center.SingleTimer4 Is Me Then
            Me.selectMe()
            Center.SingleTimer2.deselectMe()
            Center.SingleTimer3.deselectMe()
            Center.SingleTimer1.deselectMe()
        End If
    End Sub

    Private Sub SingleTimer_Click(sender As Object, e As EventArgs) Handles Me.Click, TitleLabel.Click, Seconds.Click, Minutes.Click, ColonLabel.Click
        SetLook()
    End Sub

    Private Sub soundAlarm()
        For i = 1 To Me.Alarm_Beeps
            Console.Beep(Me.Alarm_Frequency, (200 / Me.Alarm_Beeps))
        Next i
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If StartButton.Enabled = True Then
            Me.countdown = True
            Me.Timer.Enabled = True
            StartButton.ForeColor = System.Drawing.SystemColors.WindowFrame
            StartButton.BackColor = System.Drawing.SystemColors.ButtonShadow
            Center.ActiveControl = Nothing
            StartButton.Enabled = False
            StopButton.Enabled = True
        End If
        SetLook()
    End Sub

    Private Sub StartButton_EnabledChanged(sender As Object, e As EventArgs) Handles StartButton.EnabledChanged
        If StartButton.Enabled = True Then
            StartButton.ForeColor = System.Drawing.Color.SpringGreen
            StartButton.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If StopButton.Enabled = True Then
            Me.countdown = False
            StopButton.ForeColor = System.Drawing.SystemColors.WindowFrame
            StopButton.BackColor = System.Drawing.SystemColors.ButtonShadow
            stopTiming()
            Center.ActiveControl = Nothing
            StopButton.Enabled = False
        End If
        SetLook()
    End Sub

    Private Sub StopButton_EnabledChanged(sender As Object, e As EventArgs) Handles StopButton.EnabledChanged
        If StopButton.Enabled = True Then
            StopButton.ForeColor = System.Drawing.Color.Red
            StopButton.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub stopTiming()

        Me.Timer.Enabled = False

        If Me.beeping = True Then
            Me.Timer.Interval = 1000
            Me.beeping = False
            DisableAllButtons()
        Else
            StartButton.Enabled = True
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.Timer.Enabled = False
        If Me.countdown Then
            Me.Seconds.decrement()
            If Me.Minutes.isZero() And Me.Seconds.isZero() Then
                Me.countdown = False
                Me.beeping = True
                Me.alarmColours()
                Me.Timer.Interval = 1
            End If
        Else
            ClearButton.ForeColor = System.Drawing.SystemColors.WindowFrame
            ClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow
            Me.ClearButton.Enabled = False
            Me.countdown = False
            Me.Timer.Interval = 600
            If Me.ColonLabel.Visible = True Then
                Me.ColonLabel.Visible = False
            Else
                Me.ColonLabel.Visible = True
            End If
            soundAlarm() 'This Is When the singleTimer has reached zero And the alarm should be sounding
        End If
        Me.Timer.Enabled = True
    End Sub



    'These are my custom sub routines just to simplify my code
    Private Sub alarmColours()
        Me.TitleLabel.ForeColor = System.Drawing.Color.Red
        Me.Minutes.ForeColor = System.Drawing.Color.Red
        Me.Seconds.ForeColor = System.Drawing.Color.Red
        Me.ColonLabel.ForeColor = System.Drawing.Color.Red
    End Sub



End Class
