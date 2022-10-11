Public Class MinutesCounter

    Private seconds As SecondsCounter
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.maxvalue = 99
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

    Public Sub decrement()

        Me.setValue(Me.getValue - 1)
    End Sub

    Public Sub increaseBy(increment As Integer)

        If ((Me.getValue() + increment) > Me.maxvalue) Then
            Me.setToMax()
            seconds.setToMax()
        Else
            Me.setValue(Me.getValue + increment)
        End If
    End Sub

    Public Sub setSecondsCounter(newcounter As SecondsCounter)
        Me.seconds = newcounter
    End Sub

End Class
