Public Class Accueil
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Module1.saveData()
        Close()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If verifyPlayer(ComboBoxPlayer1.Text, ComboBoxPlayer2.Text) Then
            Module1.registerPlayers(ComboBoxPlayer1.Text, ComboBoxPlayer2.Text)
            SelectPattern.Show()
            Me.Hide()
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

    Private Sub ButtonScore_Click(sender As Object, e As EventArgs) Handles ButtonScore.Click
        Me.Hide()
        StatisticPlayer.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each key As String In listOfPlayer.Keys()
            If Not ComboBoxPlayer1.Items.Contains(key) Then
                ComboBoxPlayer1.Items.Add(key)
            End If
            If Not ComboBoxPlayer2.Items.Contains(key) Then
                ComboBoxPlayer2.Items.Add(key)
            End If
        Next
    End Sub
End Class
