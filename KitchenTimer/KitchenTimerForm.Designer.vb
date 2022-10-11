<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KitchenTimerForm
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
        Me.BackLeft_SingleTimer = New KitchenTimer.SingleTimer()
        Me.BackRight_SingleTimer = New KitchenTimer.SingleTimer()
        Me.FrontLeft_SingleTimer = New KitchenTimer.SingleTimer()
        Me.OneSecond = New System.Windows.Forms.Button()
        Me.ThreeSecond = New System.Windows.Forms.Button()
        Me.TenSecond = New System.Windows.Forms.Button()
        Me.OneMinute = New System.Windows.Forms.Button()
        Me.ThreeMinute = New System.Windows.Forms.Button()
        Me.TenMinute = New System.Windows.Forms.Button()
        Me.FrontRight_SingleTimer = New KitchenTimer.SingleTimer()
        Me.SuspendLayout()
        '
        'BackLeft_SingleTimer
        '
        Me.BackLeft_SingleTimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackLeft_SingleTimer.Beeps = 300
        Me.BackLeft_SingleTimer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BackLeft_SingleTimer.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.BackLeft_SingleTimer.Frequency = 440
        Me.BackLeft_SingleTimer.Location = New System.Drawing.Point(12, 11)
        Me.BackLeft_SingleTimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackLeft_SingleTimer.Name = "BackLeft_SingleTimer"
        Me.BackLeft_SingleTimer.Size = New System.Drawing.Size(241, 177)
        Me.BackLeft_SingleTimer.TabIndex = 0
        Me.BackLeft_SingleTimer.Title = "Back Left"
        '
        'BackRight_SingleTimer
        '
        Me.BackRight_SingleTimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackRight_SingleTimer.Beeps = 350
        Me.BackRight_SingleTimer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BackRight_SingleTimer.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.BackRight_SingleTimer.Frequency = 740
        Me.BackRight_SingleTimer.Location = New System.Drawing.Point(278, 11)
        Me.BackRight_SingleTimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackRight_SingleTimer.Name = "BackRight_SingleTimer"
        Me.BackRight_SingleTimer.Size = New System.Drawing.Size(241, 177)
        Me.BackRight_SingleTimer.TabIndex = 1
        Me.BackRight_SingleTimer.Title = "Back Right"
        '
        'FrontLeft_SingleTimer
        '
        Me.FrontLeft_SingleTimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FrontLeft_SingleTimer.Beeps = 100
        Me.FrontLeft_SingleTimer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FrontLeft_SingleTimer.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.FrontLeft_SingleTimer.Frequency = 1500
        Me.FrontLeft_SingleTimer.Location = New System.Drawing.Point(12, 220)
        Me.FrontLeft_SingleTimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FrontLeft_SingleTimer.Name = "FrontLeft_SingleTimer"
        Me.FrontLeft_SingleTimer.Size = New System.Drawing.Size(241, 177)
        Me.FrontLeft_SingleTimer.TabIndex = 2
        Me.FrontLeft_SingleTimer.Title = "Front Left"
        '
        'OneSecond
        '
        Me.OneSecond.BackColor = System.Drawing.SystemColors.Highlight
        Me.OneSecond.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OneSecond.ForeColor = System.Drawing.SystemColors.Control
        Me.OneSecond.Location = New System.Drawing.Point(15, 415)
        Me.OneSecond.Name = "OneSecond"
        Me.OneSecond.Size = New System.Drawing.Size(158, 64)
        Me.OneSecond.TabIndex = 4
        Me.OneSecond.Tag = 1
        Me.OneSecond.Text = "1 Second"
        Me.OneSecond.UseVisualStyleBackColor = False
        '
        'ThreeSecond
        '
        Me.ThreeSecond.BackColor = System.Drawing.SystemColors.Highlight
        Me.ThreeSecond.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ThreeSecond.ForeColor = System.Drawing.SystemColors.Control
        Me.ThreeSecond.Location = New System.Drawing.Point(189, 415)
        Me.ThreeSecond.Name = "ThreeSecond"
        Me.ThreeSecond.Size = New System.Drawing.Size(158, 64)
        Me.ThreeSecond.TabIndex = 10
        Me.ThreeSecond.Tag = 3
        Me.ThreeSecond.Text = "3 Seconds"
        Me.ThreeSecond.UseVisualStyleBackColor = False
        '
        'TenSecond
        '
        Me.TenSecond.BackColor = System.Drawing.SystemColors.Highlight
        Me.TenSecond.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TenSecond.ForeColor = System.Drawing.SystemColors.Control
        Me.TenSecond.Location = New System.Drawing.Point(361, 415)
        Me.TenSecond.Name = "TenSecond"
        Me.TenSecond.Size = New System.Drawing.Size(158, 64)
        Me.TenSecond.TabIndex = 11
        Me.TenSecond.Tag = 10
        Me.TenSecond.Text = "10 Seconds"
        Me.TenSecond.UseVisualStyleBackColor = False
        '
        'OneMinute
        '
        Me.OneMinute.BackColor = System.Drawing.SystemColors.Highlight
        Me.OneMinute.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OneMinute.ForeColor = System.Drawing.SystemColors.Control
        Me.OneMinute.Location = New System.Drawing.Point(15, 494)
        Me.OneMinute.Name = "OneMinute"
        Me.OneMinute.Size = New System.Drawing.Size(158, 64)
        Me.OneMinute.TabIndex = 12
        Me.OneMinute.Tag = 1
        Me.OneMinute.Text = "1 Minute"
        Me.OneMinute.UseVisualStyleBackColor = False
        '
        'ThreeMinute
        '
        Me.ThreeMinute.BackColor = System.Drawing.SystemColors.Highlight
        Me.ThreeMinute.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ThreeMinute.ForeColor = System.Drawing.SystemColors.Control
        Me.ThreeMinute.Location = New System.Drawing.Point(189, 494)
        Me.ThreeMinute.Name = "ThreeMinute"
        Me.ThreeMinute.Size = New System.Drawing.Size(158, 64)
        Me.ThreeMinute.TabIndex = 13
        Me.ThreeMinute.Tag = 3
        Me.ThreeMinute.Text = "3 Minutes"
        Me.ThreeMinute.UseVisualStyleBackColor = False
        '
        'TenMinute
        '
        Me.TenMinute.BackColor = System.Drawing.SystemColors.Highlight
        Me.TenMinute.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TenMinute.ForeColor = System.Drawing.SystemColors.Control
        Me.TenMinute.Location = New System.Drawing.Point(361, 494)
        Me.TenMinute.Name = "TenMinute"
        Me.TenMinute.Size = New System.Drawing.Size(158, 64)
        Me.TenMinute.TabIndex = 14
        Me.TenMinute.Tag = 10
        Me.TenMinute.Text = "10 Minutes"
        Me.TenMinute.UseVisualStyleBackColor = False
        '
        'FrontRight_SingleTimer
        '
        Me.FrontRight_SingleTimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FrontRight_SingleTimer.Beeps = 500
        Me.FrontRight_SingleTimer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FrontRight_SingleTimer.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.FrontRight_SingleTimer.Frequency = 200
        Me.FrontRight_SingleTimer.Location = New System.Drawing.Point(278, 220)
        Me.FrontRight_SingleTimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FrontRight_SingleTimer.Name = "FrontRight_SingleTimer"
        Me.FrontRight_SingleTimer.Size = New System.Drawing.Size(241, 177)
        Me.FrontRight_SingleTimer.TabIndex = 15
        Me.FrontRight_SingleTimer.Title = "Front Right"
        '
        'KitchenTimerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(531, 584)
        Me.Controls.Add(Me.FrontRight_SingleTimer)
        Me.Controls.Add(Me.TenMinute)
        Me.Controls.Add(Me.ThreeMinute)
        Me.Controls.Add(Me.OneMinute)
        Me.Controls.Add(Me.TenSecond)
        Me.Controls.Add(Me.ThreeSecond)
        Me.Controls.Add(Me.OneSecond)
        Me.Controls.Add(Me.FrontLeft_SingleTimer)
        Me.Controls.Add(Me.BackRight_SingleTimer)
        Me.Controls.Add(Me.BackLeft_SingleTimer)
        Me.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "KitchenTimerForm"
        Me.Text = "Alfred's Timer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackLeft_SingleTimer As SingleTimer
    Friend WithEvents BackRight_SingleTimer As SingleTimer
    Friend WithEvents FrontLeft_SingleTimer As SingleTimer
    Friend WithEvents OneSecond As Button
    Friend WithEvents ThreeSecond As Button
    Friend WithEvents TenSecond As Button
    Friend WithEvents OneMinute As Button
    Friend WithEvents ThreeMinute As Button
    Friend WithEvents TenMinute As Button
    Friend WithEvents FrontRight_SingleTimer As SingleTimer
End Class
