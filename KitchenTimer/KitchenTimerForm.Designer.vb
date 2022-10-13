<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Center
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SingleTimer1 = New KitchenTimer.SingleTimer()
        Me.SingleTimer2 = New KitchenTimer.SingleTimer()
        Me.SingleTimer3 = New KitchenTimer.SingleTimer()
        Me.Sec1 = New System.Windows.Forms.Button()
        Me.Sec3 = New System.Windows.Forms.Button()
        Me.Sec10 = New System.Windows.Forms.Button()
        Me.Min1 = New System.Windows.Forms.Button()
        Me.Min3 = New System.Windows.Forms.Button()
        Me.Min10 = New System.Windows.Forms.Button()
        Me.SingleTimer4 = New KitchenTimer.SingleTimer()
        Me.SuspendLayout()
        '
        'SingleTimer1
        '
        Me.SingleTimer1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.SingleTimer1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SingleTimer1.Alarm_Beeps = 1
        Me.SingleTimer1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SingleTimer1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.SingleTimer1.Alarm_Frequency = 500
        Me.SingleTimer1.Location = New System.Drawing.Point(12, 11)
        Me.SingleTimer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SingleTimer1.Name = "SingleTimer1"
        Me.SingleTimer1.Size = New System.Drawing.Size(241, 177)
        Me.SingleTimer1.TabIndex = 0
        Me.SingleTimer1.Title = "Back Left"
        '
        'SingleTimer2
        '
        Me.SingleTimer2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.SingleTimer2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SingleTimer2.Alarm_Beeps = 2
        Me.SingleTimer2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SingleTimer2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.SingleTimer2.Alarm_Frequency = 1000
        Me.SingleTimer2.Location = New System.Drawing.Point(278, 11)
        Me.SingleTimer2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SingleTimer2.Name = "SingleTimer2"
        Me.SingleTimer2.Size = New System.Drawing.Size(241, 177)
        Me.SingleTimer2.TabIndex = 1
        Me.SingleTimer2.Title = "Back Right"
        '
        'SingleTimer3
        '
        Me.SingleTimer3.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.SingleTimer3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SingleTimer3.Alarm_Beeps = 3
        Me.SingleTimer3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SingleTimer3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.SingleTimer3.Alarm_Frequency = 1500
        Me.SingleTimer3.Location = New System.Drawing.Point(12, 220)
        Me.SingleTimer3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SingleTimer3.Name = "SingleTimer3"
        Me.SingleTimer3.Size = New System.Drawing.Size(241, 177)
        Me.SingleTimer3.TabIndex = 2
        Me.SingleTimer3.Title = "Front Left"
        '
        'Sec1
        '
        Me.Sec1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Sec1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec1.ForeColor = System.Drawing.SystemColors.Control
        Me.Sec1.Location = New System.Drawing.Point(15, 415)
        Me.Sec1.Name = "Sec1"
        Me.Sec1.Size = New System.Drawing.Size(158, 64)
        Me.Sec1.TabIndex = 4
        Me.Sec1.Tag = 1
        Me.Sec1.Text = "1 Second"
        Me.Sec1.UseVisualStyleBackColor = False
        '
        'Sec3
        '
        Me.Sec3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Sec3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec3.ForeColor = System.Drawing.SystemColors.Control
        Me.Sec3.Location = New System.Drawing.Point(189, 415)
        Me.Sec3.Name = "Sec3"
        Me.Sec3.Size = New System.Drawing.Size(158, 64)
        Me.Sec3.TabIndex = 10
        Me.Sec3.Tag = 3
        Me.Sec3.Text = "3 Seconds"
        Me.Sec3.UseVisualStyleBackColor = False
        '
        'Sec10
        '
        Me.Sec10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Sec10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec10.ForeColor = System.Drawing.SystemColors.Control
        Me.Sec10.Location = New System.Drawing.Point(361, 415)
        Me.Sec10.Name = "Sec10"
        Me.Sec10.Size = New System.Drawing.Size(158, 64)
        Me.Sec10.TabIndex = 11
        Me.Sec10.Tag = 10
        Me.Sec10.Text = "10 Seconds"
        Me.Sec10.UseVisualStyleBackColor = False
        '
        'Min1
        '
        Me.Min1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Min1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min1.ForeColor = System.Drawing.SystemColors.Control
        Me.Min1.Location = New System.Drawing.Point(15, 494)
        Me.Min1.Name = "Min1"
        Me.Min1.Size = New System.Drawing.Size(158, 64)
        Me.Min1.TabIndex = 12
        Me.Min1.Tag = 1
        Me.Min1.Text = "1 Minute"
        Me.Min1.UseVisualStyleBackColor = False
        '
        'Min3
        '
        Me.Min3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Min3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min3.ForeColor = System.Drawing.SystemColors.Control
        Me.Min3.Location = New System.Drawing.Point(189, 494)
        Me.Min3.Name = "Min3"
        Me.Min3.Size = New System.Drawing.Size(158, 64)
        Me.Min3.TabIndex = 13
        Me.Min3.Tag = 3
        Me.Min3.Text = "3 Minutes"
        Me.Min3.UseVisualStyleBackColor = False
        '
        'Min10
        '
        Me.Min10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Min10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min10.ForeColor = System.Drawing.SystemColors.Control
        Me.Min10.Location = New System.Drawing.Point(361, 494)
        Me.Min10.Name = "Min10"
        Me.Min10.Size = New System.Drawing.Size(158, 64)
        Me.Min10.TabIndex = 14
        Me.Min10.Tag = 10
        Me.Min10.Text = "10 Minutes"
        Me.Min10.UseVisualStyleBackColor = False
        '
        'SingleTimer4
        '
        Me.SingleTimer4.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.SingleTimer4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SingleTimer4.Alarm_Beeps = 4
        Me.SingleTimer4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SingleTimer4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.SingleTimer4.Alarm_Frequency = 1750
        Me.SingleTimer4.Location = New System.Drawing.Point(278, 220)
        Me.SingleTimer4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SingleTimer4.Name = "SingleTimer4"
        Me.SingleTimer4.Size = New System.Drawing.Size(241, 177)
        Me.SingleTimer4.TabIndex = 15
        Me.SingleTimer4.TabStop = False
        Me.SingleTimer4.Title = "Front Right"
        '
        'Center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(531, 584)
        Me.Controls.Add(Me.SingleTimer4)
        Me.Controls.Add(Me.Min10)
        Me.Controls.Add(Me.Min3)
        Me.Controls.Add(Me.Min1)
        Me.Controls.Add(Me.Sec10)
        Me.Controls.Add(Me.Sec3)
        Me.Controls.Add(Me.Sec1)
        Me.Controls.Add(Me.SingleTimer3)
        Me.Controls.Add(Me.SingleTimer2)
        Me.Controls.Add(Me.SingleTimer1)
        Me.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Center"
        Me.Text = "Alfred's Timer V1.0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SingleTimer1 As SingleTimer
    Friend WithEvents SingleTimer2 As SingleTimer
    Friend WithEvents SingleTimer3 As SingleTimer
    Friend WithEvents Sec1 As Button
    Friend WithEvents Sec3 As Button
    Friend WithEvents Sec10 As Button
    Friend WithEvents Min1 As Button
    Friend WithEvents Min3 As Button
    Friend WithEvents Min10 As Button
    Friend WithEvents SingleTimer4 As SingleTimer
End Class
