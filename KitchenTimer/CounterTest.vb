Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography

Public MustInherit Class CounterTest
    Inherits Label

    Private maxvalue As Integer
    Private value As Integer





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
        Me.value = 0
    End Sub
    Public Sub setValue(newvalue As Integer)
        Me.value = newvalue

    End Sub


End Class
