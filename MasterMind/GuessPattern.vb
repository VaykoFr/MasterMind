Public Class GuessPattern
    Dim timeLeft As Integer = Module1.time
    Dim find As Boolean = False
    Private Sub GuessPattern_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCharacter.Text = Module1.possibleCharacter
        LabelTryLeft.Text = Module1.numberOfTry
        Me.Text = "Devine !"
    End Sub
    Private Sub TimerGuess_Tick(sender As Object, e As EventArgs) Handles TimerGuess.Tick
        timeLeft = timeLeft - 1
        LabelTimeLeft.Text = timeLeft & " sec"
        If timeLeft = 0 Then
            ButtonLeave.Visible = True
            LabelFind.Visible = True
            TimerGuess.Enabled = False
            ButtonGuess.Enabled = False
        End If
    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles ButtonGuess.Click
        LabelTryLeft.Text = LabelTryLeft.Text - 1
        If verifySolution(PanelGuess) Then
            ButtonLeave.Visible = True
            LabelFind.Visible = True
            TimerGuess.Enabled = False
            ButtonGuess.Enabled = False
            find = True
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

    Private Sub ButtonLeave_Click(sender As Object, e As EventArgs) Handles ButtonLeave.Click
        Module1.result(timeLeft, find)
        Module1.nextGame()
        Me.Close()
        Accueil.Show()
    End Sub


    Private Sub txtFinalCase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ButtonGuess.PerformClick()
            e.Handled = True
        End If
    End Sub

End Class