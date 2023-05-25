Public Class Accueil
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Module1.saveData()
        Close()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If verifyPlayer(ComboBoxPlayer1.Text, ComboBoxPlayer2.Text) Then
            Module1.registerPlayers(ComboBoxPlayer1.Text, ComboBoxPlayer2.Text)
            Me.Hide()
            SelectPattern.Show()
        End If
    End Sub

    Private Function verifyPlayer(player1 As String, player2 As String) As Boolean
        player1 = player1.Trim.ToLower
        player2 = player2.Trim.ToLower
        If player1.Length = 0 Or player2.Length = 0 Then
            MsgBox("Le pseudo du joueur ne peut pas être vide.")
            Return False
        End If
        If player1 = player2 Then
            MsgBox("Les pseudos doivent être différents.")
            Return False
        End If
        Return Not player1 = player2
    End Function


    Private Sub J1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxPlayer1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If Not ComboBoxPlayer1.Text.Length = 0 Then
                SendKeys.Send("{TAB}")
            End If
            e.Handled = True
            End If
    End Sub
    Private Sub J2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxPlayer2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If Not ComboBoxPlayer2.Text.Length = 0 Then
                ButtonStart.PerformClick()
            End If
            e.Handled = True
            End If
    End Sub

End Class
