Imports System.Security.Cryptography
Imports System.Windows.Forms.Design

Public Class SingleTimerTest
    Inherits Control

    Private beeping As Boolean
    Private beeps As Integer
    Private countdown As Boolean
    Private frequency As Integer
    Private StartButton As Button
    Private StopButton As Button
    Private ClearButton As Button
    Private TitleLabel As RadioButton
    Property Title() As String
        Get
            Return Me.TitleLabel.Text

        End Get
        Set(ByVal Value As String)
            Me.TitleLabel.Text = Value
        End Set
    End Property

    Private ColonLabel As Label
    Private Timer As Timer


    Public Function IsMax() As Boolean
        Dim bReturn As Boolean

        ' bReturn = TimerMinutesCounter.isMax And TimerSecondsCounter.isMax

        IsMax = bReturn

    End Function



End Class
