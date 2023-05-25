Public Class GuessPattern
    Dim timeLeft As Integer = Module1.time
    Dim tryLeft As Integer = Module1.numberOfTry

    Private Sub TimerGuess_Tick(sender As Object, e As EventArgs) Handles TimerGuess.Tick
        timeLeft = timeLeft - 1
        LabelTimeLeft.Text = timeLeft & " sec"
    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles ButtonGuess.Click
        tryLeft = tryLeft - 1
        If verifySolution(PanelGuess) Then


        End If
    End Sub
    Private Function verifySolution(sender As Panel) As Boolean
        Dim nbError As Integer = 0
        For Each control As TextBox In sender.Controls
            control.Text = control.Text.Trim
            If Not control.Text.Length = 0 Then
                If Not Module1.patternToGuess.IndexOf(control.Text) = -1 Then
                    If Module1.patternToGuess.IndexOf(control.TabIndex) = control.Text Then
                        control.BackColor = Color.Green
                    Else
                        control.BackColor = Color.Blue
                        nbError = nbError + 1
                    End If
                Else
                    control.BackColor = SystemColors.Window
                    nbError = nbError + 1
                End If
            End If
            Return nbError = 0
        Next
    End Function
End Class