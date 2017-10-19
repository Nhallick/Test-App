<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestForm))
        Me.BTNAddSub = New System.Windows.Forms.Button()
        Me.CBButtonSubtract = New System.Windows.Forms.CheckBox()
        Me.TBButton = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TBTimer = New System.Windows.Forms.TextBox()
        Me.TMRSlider = New System.Windows.Forms.TrackBar()
        Me.CBTimerAdd = New System.Windows.Forms.CheckBox()
        Me.CBTimerSubtract = New System.Windows.Forms.CheckBox()
        Me.BTNReset = New System.Windows.Forms.Button()
        Me.BTNStart = New System.Windows.Forms.Button()
        Me.BTNStop = New System.Windows.Forms.Button()
        Me.LBLInterval = New System.Windows.Forms.Label()
        CType(Me.TMRSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNAddSub
        '
        Me.BTNAddSub.Location = New System.Drawing.Point(12, 12)
        Me.BTNAddSub.Name = "BTNAddSub"
        Me.BTNAddSub.Size = New System.Drawing.Size(75, 23)
        Me.BTNAddSub.TabIndex = 0
        Me.BTNAddSub.Text = "Add"
        Me.BTNAddSub.UseVisualStyleBackColor = True
        '
        'CBButtonSubtract
        '
        Me.CBButtonSubtract.AutoSize = True
        Me.CBButtonSubtract.Location = New System.Drawing.Point(12, 41)
        Me.CBButtonSubtract.Name = "CBButtonSubtract"
        Me.CBButtonSubtract.Size = New System.Drawing.Size(66, 17)
        Me.CBButtonSubtract.TabIndex = 1
        Me.CBButtonSubtract.Text = "Subtract"
        Me.CBButtonSubtract.UseVisualStyleBackColor = True
        '
        'TBButton
        '
        Me.TBButton.Location = New System.Drawing.Point(12, 64)
        Me.TBButton.Name = "TBButton"
        Me.TBButton.Size = New System.Drawing.Size(100, 20)
        Me.TBButton.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TBTimer
        '
        Me.TBTimer.Location = New System.Drawing.Point(142, 109)
        Me.TBTimer.Name = "TBTimer"
        Me.TBTimer.Size = New System.Drawing.Size(100, 20)
        Me.TBTimer.TabIndex = 3
        '
        'TMRSlider
        '
        Me.TMRSlider.Location = New System.Drawing.Point(142, 13)
        Me.TMRSlider.Maximum = 1000
        Me.TMRSlider.Name = "TMRSlider"
        Me.TMRSlider.Size = New System.Drawing.Size(100, 45)
        Me.TMRSlider.TabIndex = 4
        '
        'CBTimerAdd
        '
        Me.CBTimerAdd.AutoSize = True
        Me.CBTimerAdd.Location = New System.Drawing.Point(142, 63)
        Me.CBTimerAdd.Name = "CBTimerAdd"
        Me.CBTimerAdd.Size = New System.Drawing.Size(45, 17)
        Me.CBTimerAdd.TabIndex = 5
        Me.CBTimerAdd.Text = "Add"
        Me.CBTimerAdd.UseVisualStyleBackColor = True
        '
        'CBTimerSubtract
        '
        Me.CBTimerSubtract.AutoSize = True
        Me.CBTimerSubtract.Location = New System.Drawing.Point(142, 86)
        Me.CBTimerSubtract.Name = "CBTimerSubtract"
        Me.CBTimerSubtract.Size = New System.Drawing.Size(66, 17)
        Me.CBTimerSubtract.TabIndex = 6
        Me.CBTimerSubtract.Text = "Subtract"
        Me.CBTimerSubtract.UseVisualStyleBackColor = True
        '
        'BTNReset
        '
        Me.BTNReset.Location = New System.Drawing.Point(12, 94)
        Me.BTNReset.Name = "BTNReset"
        Me.BTNReset.Size = New System.Drawing.Size(14, 11)
        Me.BTNReset.TabIndex = 7
        Me.BTNReset.UseVisualStyleBackColor = True
        '
        'BTNStart
        '
        Me.BTNStart.Location = New System.Drawing.Point(142, 138)
        Me.BTNStart.Name = "BTNStart"
        Me.BTNStart.Size = New System.Drawing.Size(48, 21)
        Me.BTNStart.TabIndex = 8
        Me.BTNStart.Text = "Start"
        Me.BTNStart.UseVisualStyleBackColor = True
        '
        'BTNStop
        '
        Me.BTNStop.Location = New System.Drawing.Point(196, 139)
        Me.BTNStop.Name = "BTNStop"
        Me.BTNStop.Size = New System.Drawing.Size(46, 21)
        Me.BTNStop.TabIndex = 9
        Me.BTNStop.Text = "Stop"
        Me.BTNStop.UseVisualStyleBackColor = True
        '
        'LBLInterval
        '
        Me.LBLInterval.AutoSize = True
        Me.LBLInterval.Location = New System.Drawing.Point(177, 45)
        Me.LBLInterval.Name = "LBLInterval"
        Me.LBLInterval.Size = New System.Drawing.Size(31, 13)
        Me.LBLInterval.TabIndex = 10
        Me.LBLInterval.Text = "1000"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 171)
        Me.Controls.Add(Me.LBLInterval)
        Me.Controls.Add(Me.BTNStop)
        Me.Controls.Add(Me.BTNStart)
        Me.Controls.Add(Me.BTNReset)
        Me.Controls.Add(Me.CBTimerSubtract)
        Me.Controls.Add(Me.CBTimerAdd)
        Me.Controls.Add(Me.TMRSlider)
        Me.Controls.Add(Me.TBTimer)
        Me.Controls.Add(Me.TBButton)
        Me.Controls.Add(Me.CBButtonSubtract)
        Me.Controls.Add(Me.BTNAddSub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TestForm"
        Me.Text = "Test Form"
        CType(Me.TMRSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNAddSub As Button
    Friend WithEvents CBButtonSubtract As CheckBox
    Friend WithEvents TBButton As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TBTimer As TextBox
    Friend WithEvents TMRSlider As TrackBar
    Friend WithEvents CBTimerAdd As CheckBox
    Friend WithEvents CBTimerSubtract As CheckBox
    Friend WithEvents BTNReset As Button
    Friend WithEvents BTNStart As Button
    Friend WithEvents BTNStop As Button
    Friend WithEvents LBLInterval As Label
End Class
