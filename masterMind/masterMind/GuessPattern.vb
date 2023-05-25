Public Class GuessPattern
    Dim timeLeft As Integer = Module1.time
    Private Sub GuessPattern_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCharacter.Text = Module1.possibleCharacter
        LabelTryLeft.Text = Module1.numberOfTry
    End Sub
    Private Sub TimerGuess_Tick(sender As Object, e As EventArgs) Handles TimerGuess.Tick
        timeLeft = timeLeft - 1
        LabelTimeLeft.Text = timeLeft & " sec"
    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles ButtonGuess.Click
        LabelTryLeft.Text = LabelTryLeft.Text - 1
        If verifySolution(PanelGuess) Then
            ButtonLeave.Visible = True
            LabelFind.Visible = True
            TimerGuess.Enabled = False
            ButtonGuess.Enabled = False
        End If
    End Sub
    Private Function verifySolution(sender As Panel) As Boolean
        Dim nbError As Integer = 0
        For Each control As TextBox In sender.Controls
            control.Text = control.Text.Trim
            If Not control.Text.Length = 0 Then
                If Module1.patternToGuess.Contains(control.Text) Then
                    If Module1.patternToGuess(control.TabIndex) = control.Text Then
                        control.BackColor = Color.Green
                    Else
                        control.BackColor = Color.Blue
                        nbError = nbError + 1
                    End If
                Else
                    control.BackColor = SystemColors.Window
                    nbError = nbError + 1
                End If
            Else
                control.BackColor = SystemColors.Window
                nbError = nbError + 1
            End If
        Next
        Return nbError = 0
    End Function
End Class