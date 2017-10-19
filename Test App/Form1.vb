Public Class TestForm
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TMRSlider.Value = 1000
        Timer1.Interval = TMRSlider.Value
        TBButton.Text = 0
        TBTimer.Text = 0
        LBLInterval.Text = Timer1.Interval
        Timer1.Start()
    End Sub

    Private Sub BTNAddSub_Click(sender As Object, e As EventArgs) Handles BTNAddSub.Click
        If CBButtonSubtract.Checked = True Then
            TBButton.Text -= 1
        Else
            TBButton.Text += 1
        End If
    End Sub

    Private Sub CBButtonSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles CBButtonSubtract.CheckedChanged
        If CBButtonSubtract.Checked = True Then
            BTNAddSub.Text = "Subtract"
        Else
            BTNAddSub.Text = "Add"
        End If
    End Sub

    Private Sub BTNReset_Click(sender As Object, e As EventArgs) Handles BTNReset.Click
        TBButton.Text = 0
    End Sub

    Private Sub TMRSlider_Scroll(sender As Object, e As EventArgs) Handles TMRSlider.Scroll
        Timer1.Interval = TMRSlider.Value
        LBLInterval.Text = Timer1.Interval & "ms"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CBTimerAdd.Checked = False And CBTimerSubtract.Checked = False Then
            CBTimerAdd.Checked = True
        End If

        If CBTimerAdd.Checked = True Then
            TBTimer.Text += 1
        ElseIf CBTimerSubtract.Checked = True Then
            TBTimer.Text -= 1
        End If
    End Sub

    Private Sub CBTimerAdd_CheckedChanged(sender As Object, e As EventArgs) Handles CBTimerAdd.CheckedChanged
        If CBTimerAdd.Checked = True Then
            CBTimerSubtract.Checked = False
        End If
    End Sub

    Private Sub CBTimerSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles CBTimerSubtract.CheckedChanged
        If CBTimerSubtract.Checked = True Then
            CBTimerAdd.Checked = False
        End If
    End Sub

    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        Timer1.Start()
    End Sub

    Private Sub BTNStop_Click(sender As Object, e As EventArgs) Handles BTNStop.Click
        Timer1.Stop()
    End Sub
End Class
