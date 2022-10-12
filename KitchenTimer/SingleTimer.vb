Imports System.ComponentModel

Public Class SingleTimer

    Public Shared SelectedTimer As SingleTimer = KitchenTimerForm.BackLeft_SingleTimer

    Private beeping As Boolean = False
    Private countdown As Boolean = False
    Private _title As String = "Back Left"
    <System.ComponentModel.EditorBrowsable(True)>
    <System.ComponentModel.Browsable(True)>
    <System.ComponentModel.Description("This is the title")>
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal NewValue As String)
            _title = NewValue
            Me.RadioButton1.Text = NewValue

        End Set
    End Property

    Private _frequency As Integer = 440
    <System.ComponentModel.EditorBrowsable(True)>
    <System.ComponentModel.Browsable(True)>
    <System.ComponentModel.Description("This is the Frequency of the Single Timer Alarm")>
    Public Property Frequency() As Integer
        Get
            Return _frequency
        End Get
        Set(ByVal NewValue As Integer)
            _frequency = NewValue

        End Set
    End Property

    Private _beeps As Integer = 250
    <System.ComponentModel.EditorBrowsable(True)>
    <System.ComponentModel.Browsable(True)>
    <System.ComponentModel.Description("This is the Duration of the Single Timer Alarm")>
    Public Property Beeps() As Integer
        Get
            Return _beeps
        End Get
        Set(ByVal NewValue As Integer)
            _beeps = NewValue

        End Set
    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.SecondsCounter1.setMinutesCounter(Me.MinutesCounter1)
        Me.MinutesCounter1.setSecondsCounter(Me.SecondsCounter1)

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Friend Shared Sub addMinutes(extraMins As Integer)
        SingleTimer.SelectedTimer.AddMinutesToSelected(extraMins)
        SingleTimer.SelectedTimer.StartButton.Enabled = True
        SingleTimer.SelectedTimer.ClearButton.Enabled = True
    End Sub

    Private Sub AddMinutesToSelected(extraMins As Integer)
        Me.MinutesCounter1.increaseBy(extraMins)
    End Sub

    Friend Shared Sub addSeconds(extraSeconds As Integer)
        SingleTimer.SelectedTimer.AddSecondsToSelected(extraSeconds)
        SingleTimer.SelectedTimer.StartButton.Enabled = True
        SingleTimer.SelectedTimer.ClearButton.Enabled = True
    End Sub

    Private Sub AddSecondsToSelected(extraSeconds As Integer)
        Me.SecondsCounter1.increaseBy(extraSeconds)
    End Sub

    Private Sub newBackColor(newColor As Color)
        Me.BackColor = newColor
    End Sub

    Private Sub newForeColor(newColor As Color)
        Me.RadioButton1.ForeColor = newColor
        Me.SecondsCounter1.ForeColor = newColor
        Me.MinutesCounter1.ForeColor = newColor
        Me.Label1.ForeColor = newColor
    End Sub


    Private Sub SingleTimer_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        If SingleTimer.SelectedTimer Is Me Then
            Me.newBackColor(System.Drawing.SystemColors.Highlight)
            Me.newForeColor(SystemColors.Control)
            Me.RadioButton1.Checked = True
        End If
    End Sub

    Private Sub deselectMe()
        If Me.beeping = True Then
            alarmColours()
        Else
            Me.newForeColor(System.Drawing.Color.RoyalBlue)
        End If
        Me.newBackColor(System.Drawing.SystemColors.ActiveCaption)
        Me.RadioButton1.Checked = False
        Me.Label1.Visible = True

    End Sub

    Private Sub selectMe()

        If Me.beeping = True Then
            alarmColours()
        Else
            Me.newForeColor(SystemColors.Control)
        End If
        Me.newBackColor(System.Drawing.SystemColors.Highlight)
        Me.RadioButton1.Checked = True
        Me.Label1.Visible = True
        SingleTimer.SelectedTimer = Me

    End Sub

    Private Sub alarmColours()
        Me.RadioButton1.ForeColor = System.Drawing.Color.Red
        Me.MinutesCounter1.ForeColor = System.Drawing.Color.Red
        Me.SecondsCounter1.ForeColor = System.Drawing.Color.Red
        Me.Label1.ForeColor = System.Drawing.Color.Red
    End Sub

    Private Sub SetLook()
        If KitchenTimerForm.BackLeft_SingleTimer Is Me Then
            Me.selectMe()
            KitchenTimerForm.BackRight_SingleTimer.deselectMe()
            KitchenTimerForm.FrontLeft_SingleTimer.deselectMe()
            KitchenTimerForm.FrontRight_SingleTimer.deselectMe()
        ElseIf KitchenTimerForm.BackRight_SingleTimer Is Me Then
            Me.selectMe()
            KitchenTimerForm.BackLeft_SingleTimer.deselectMe()
            KitchenTimerForm.FrontLeft_SingleTimer.deselectMe()
            KitchenTimerForm.FrontRight_SingleTimer.deselectMe()
        ElseIf KitchenTimerForm.FrontLeft_SingleTimer Is Me Then
            Me.selectMe()
            KitchenTimerForm.BackRight_SingleTimer.deselectMe()
            KitchenTimerForm.BackLeft_SingleTimer.deselectMe()
            KitchenTimerForm.FrontRight_SingleTimer.deselectMe()
        ElseIf KitchenTimerForm.FrontRight_SingleTimer Is Me Then
            Me.selectMe()
            KitchenTimerForm.BackRight_SingleTimer.deselectMe()
            KitchenTimerForm.FrontLeft_SingleTimer.deselectMe()
            KitchenTimerForm.BackLeft_SingleTimer.deselectMe()
        End If
    End Sub

    Private Sub SingleTimer_Click(sender As Object, e As EventArgs) Handles Me.Click, RadioButton1.Click, SecondsCounter1.Click, MinutesCounter1.Click, Label1.Click
        SetLook()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        SetLook()
        If StartButton.Enabled = True Then
            Me.countdown = True
            Me.Timer.Enabled = True
            StartButton.Enabled = False
            StartButton.ForeColor = System.Drawing.SystemColors.WindowFrame
            StartButton.BackColor = System.Drawing.SystemColors.ButtonShadow
            StopButton.Enabled = True
        End If


    End Sub

    Private Sub StartButton_EnabledChanged(sender As Object, e As EventArgs) Handles StartButton.EnabledChanged
        If StartButton.Enabled = True Then
            StartButton.ForeColor = System.Drawing.Color.SpringGreen
            StartButton.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If StopButton.Enabled = True Then
            stopTiming()
            StopButton.ForeColor = System.Drawing.SystemColors.WindowFrame
            StopButton.BackColor = System.Drawing.SystemColors.ButtonShadow
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

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetLook()

        If ClearButton.Enabled = True Then
            Me.Timer.Enabled = False
            StopButton.Enabled = False
            Me.MinutesCounter1.setValue(0)
            Me.SecondsCounter1.setValue(0)
            Me.Timer.Interval = 1000
            ClearButton.ForeColor = System.Drawing.SystemColors.WindowFrame
            ClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow
            DisableAllButtons()
        End If
    End Sub

    Private Sub ClearButton_EnabledChanged(sender As Object, e As EventArgs) Handles ClearButton.EnabledChanged
        If ClearButton.Enabled = True Then
            ClearButton.ForeColor = System.Drawing.Color.Black
            ClearButton.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub DisableAllButtons()
        Me.StopButton.Enabled = False
        Me.StartButton.Enabled = False
        Me.ClearButton.Enabled = False
    End Sub

    Private Sub soundAlarm()
        Console.Beep(Me.Frequency, Me.Beeps)
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
        If Me.beeping = True Then
            ClearButton.ForeColor = System.Drawing.SystemColors.WindowFrame
            ClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow
            Me.ClearButton.Enabled = False
            Me.countdown = False
            Me.Timer.Interval = Me.Beeps
            If Me.Label1.Visible = True Then
                Me.Label1.Visible = False
            Else
                Me.Label1.Visible = True
            End If
            soundAlarm() 'This Is When the singleTimer has reached zero And the alarm should be sounding
        ElseIf Me.countdown = True Then
            Me.SecondsCounter1.decrement() 'This is when the singletimer should be decrementing by one second every one second
            If Me.MinutesCounter1.isZero() And Me.SecondsCounter1.isZero() Then
                Me.beeping = True
                Me.alarmColours()
                Me.Timer.Interval = 1
            End If
        End If
    End Sub
End Class
