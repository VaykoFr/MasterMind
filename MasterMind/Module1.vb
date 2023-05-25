Module Module1
    Public possibleCharacter As String = "#$£%@"
    Public players(1) As String
    Public numberOfTry As Integer = 15
    Public time As Integer = 90
    Public patternToGuess(4) As Char
    Public gameNumber As Integer = 0
    Public listOfPlayer As Dictionary(Of String, Integer()) = New Dictionary(Of String, Integer())

    Public Sub loadData()

    End Sub

    Public Sub saveData()

    End Sub

    Public Sub registerPattern(sender As Panel)
        For Each controls As TextBox In sender.Controls
            patternToGuess(controls.TabIndex) = controls.Text
        Next
    End Sub

    Public Sub registerPlayers(p1 As String, p2 As String)
        players(0) = p1
        players(1) = p2
    End Sub

    Public Sub nextGame()
        gameNumber = (gameNumber + 1) Mod 2
        If gameNumber = 1 Then
            Accueil.ComboBoxPlayer1.Text = players(1)
            Accueil.ComboBoxPlayer2.Text = players(0)
        Else
            Accueil.ComboBoxPlayer1.Text = ""
            Accueil.ComboBoxPlayer2.Text = ""
        End If
    End Sub

    Public Sub result(timeLeft As Integer, found As Boolean)
        If Not listOfPlayer.ContainsKey(players(0)) Then
            listOfPlayer.Add(players(0), New Integer() {0, 0, 0, 0, 0})
        End If

        Dim player1Data As Integer() = listOfPlayer(players(0))
        player1Data(4) = player1Data(4) + (time - timeLeft)
        player1Data(2) = player1Data(2) + 1
        If found Then
            player1Data(0) = player1Data(0) + 1
            If player1Data(1) > (time - timeLeft) Then
                player1Data(1) = time - timeLeft
            End If
        End If
        listOfPlayer(players(0)) = player1Data
        If Not listOfPlayer.ContainsKey(players(1)) Then
            listOfPlayer.Add(players(1), New Integer() {0, 0, 0, 0, 0})
        End If
        Dim player2Data As Integer() = listOfPlayer(players(1))
        player2Data(3) = player2Data(3) + 1
    End Sub

End Module
