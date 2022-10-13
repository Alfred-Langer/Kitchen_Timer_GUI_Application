Public Class SecondsCounter



    Private minutes As MinutesCounter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.maxvalue = 59
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

    Public Sub decrement()
        If (Me.getValue() = 0 And minutes.getValue() = 0) Then
            'MAKE ALARM GO BURRR'
        ElseIf (Me.getValue = 0) Then
            minutes.decrement()
            Me.setValue(59)
        Else
            Me.setValue(Me.getValue() - 1)
        End If
    End Sub

    Public Sub increaseBy(increment As Integer)

        If (minutes.isMax() And ((Me.getValue() + increment) >= Me.maxvalue)) Then
            Me.setToMax()
        ElseIf ((Me.getValue() + increment) > Me.maxvalue) Then
            minutes.setValue(minutes.getValue() + 1)
            Me.setValue(Me.getValue() + increment - Me.maxvalue - 1)
        Else
            Me.setValue(Me.getValue() + increment)

        End If
    End Sub

    Public Sub setMinutesCounter(newcounter As MinutesCounter)
        Me.minutes = newcounter
    End Sub


End Class
