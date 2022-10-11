Public MustInherit Class Counter

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Me.AutoSize = False
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.Font = CounterFont
        Me.UseCompatibleTextRendering = True

    End Sub



    Protected maxvalue As Integer
    Private value As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function isMax() As Boolean
        If Me.value = Me.maxvalue Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function isZero() As Boolean
        If Me.value = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub reset()
        Me.value = 0
    End Sub
    Public Sub setToMax()
        Me.setValue(maxvalue)
    End Sub
    Public Function getValue() As Integer
        Return Me.value

    End Function
    Public Sub setValue(newvalue As Integer)
        Me.value = newvalue
        Me.Text = Me.value.ToString("00")
    End Sub
End Class
