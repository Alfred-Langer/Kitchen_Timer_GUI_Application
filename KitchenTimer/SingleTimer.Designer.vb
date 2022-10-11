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
        Me.MinutesCounter1 = New KitchenTimer.MinutesCounter()
        Me.SecondsCounter1 = New KitchenTimer.SecondsCounter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MinutesCounter1
        '
        Me.MinutesCounter1.Font = New System.Drawing.Font("Segoe UI Semibold", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinutesCounter1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.MinutesCounter1.Location = New System.Drawing.Point(0, 45)
        Me.MinutesCounter1.Name = "MinutesCounter1"
        Me.MinutesCounter1.Size = New System.Drawing.Size(125, 70)
        Me.MinutesCounter1.TabIndex = 0
        Me.MinutesCounter1.Text = "00"
        Me.MinutesCounter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MinutesCounter1.UseCompatibleTextRendering = True
        '
        'SecondsCounter1
        '
        Me.SecondsCounter1.Font = New System.Drawing.Font("Segoe UI Semibold", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SecondsCounter1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.SecondsCounter1.Location = New System.Drawing.Point(119, 45)
        Me.SecondsCounter1.Name = "SecondsCounter1"
        Me.SecondsCounter1.Size = New System.Drawing.Size(125, 70)
        Me.SecondsCounter1.TabIndex = 1
        Me.SecondsCounter1.Text = "00"
        Me.SecondsCounter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SecondsCounter1.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(102, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton1.Location = New System.Drawing.Point(23, 0)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(194, 36)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.Text = "Back Left"
        Me.RadioButton1.UseCompatibleTextRendering = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.StartButton.Enabled = False
        Me.StartButton.FlatAppearance.BorderSize = 0
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StartButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StartButton.Location = New System.Drawing.Point(19, 118)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(62, 50)
        Me.StartButton.TabIndex = 4
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.StopButton.Enabled = False
        Me.StopButton.FlatAppearance.BorderSize = 0
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StopButton.Location = New System.Drawing.Point(87, 118)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(62, 50)
        Me.StopButton.TabIndex = 5
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClearButton.Enabled = False
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearButton.Location = New System.Drawing.Point(155, 118)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(62, 50)
        Me.ClearButton.TabIndex = 6
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
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SecondsCounter1)
        Me.Controls.Add(Me.MinutesCounter1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(241, 177)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MinutesCounter1 As MinutesCounter
    Friend WithEvents SecondsCounter1 As SecondsCounter
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Timer As Timer
End Class
