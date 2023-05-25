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
            Return False
        End If
        Return Not player1 = player2
    End Function
End Class
