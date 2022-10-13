Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl




    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Minutes = New KitchenTimer.MinutesCounter()
        Me.Seconds = New KitchenTimer.SecondsCounter()
        Me.ColonLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.RadioButton()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Minutes
        '
        Me.Minutes.Font = New System.Drawing.Font("Segoe UI Semibold", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Minutes.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Minutes.Location = New System.Drawing.Point(0, 45)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(125, 70)
        Me.Minutes.TabIndex = 0
        Me.Minutes.Text = "00"
        Me.Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Minutes.UseCompatibleTextRendering = True
        '
        'Seconds
        '
        Me.Seconds.Font = New System.Drawing.Font("Segoe UI Semibold", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Seconds.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Seconds.Location = New System.Drawing.Point(119, 45)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(125, 70)
        Me.Seconds.TabIndex = 1
        Me.Seconds.Text = "00"
        Me.Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Seconds.UseCompatibleTextRendering = True
        '
        'ColonLabel
        '
        Me.ColonLabel.Font = New System.Drawing.Font("Segoe UI Historic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ColonLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ColonLabel.Location = New System.Drawing.Point(102, 53)
        Me.ColonLabel.Name = "ColonLabel"
        Me.ColonLabel.Size = New System.Drawing.Size(39, 52)
        Me.ColonLabel.TabIndex = 2
        Me.ColonLabel.Text = ":"
        Me.ColonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ColonLabel.UseCompatibleTextRendering = True
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.FlatAppearance.BorderSize = 0
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TitleLabel.Location = New System.Drawing.Point(23, 0)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(194, 36)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "Back Left"
        Me.TitleLabel.UseCompatibleTextRendering = True
        Me.TitleLabel.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.StartButton.Enabled = False
        Me.StartButton.FlatAppearance.BorderSize = 0
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StartButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StartButton.Location = New System.Drawing.Point(19, 118)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(62, 50)
        Me.StartButton.TabIndex = 4
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.StopButton.Enabled = False
        Me.StopButton.FlatAppearance.BorderSize = 0
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StopButton.Location = New System.Drawing.Point(87, 118)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(62, 50)
        Me.StopButton.TabIndex = 5
        Me.StopButton.TabStop = False
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClearButton.Enabled = False
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearButton.Location = New System.Drawing.Point(155, 118)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(62, 50)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.TabStop = False
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.ColonLabel)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Minutes)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(241, 177)
        Me.ResumeLayout(False)

    End Sub


    Private beeping As Boolean = False
    Private beeps As Integer = 250
    Friend WithEvents ClearButton As Button
    Friend WithEvents ColonLabel As Label
    Private countdown As Boolean = False
    Private frequency As Integer = 440
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents Timer As Timer
    Private _title As String = "Back Left"
    Friend WithEvents TitleLabel As RadioButton

    Friend WithEvents Minutes As MinutesCounter
    Friend WithEvents Seconds As SecondsCounter

    Private Shared SelectedTimer As SingleTimer = Center.SingleTimer1




End Class
