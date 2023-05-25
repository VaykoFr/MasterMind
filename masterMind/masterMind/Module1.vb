Module Module1
    Public possibleCharacter As String = "#$£%@"
    Public players(1) As String
    Public numberOfTry As Integer = 15
    Public time As Integer = 90
    Public patternToGuess As String
    Public gameNumber As Integer = 0
    Public listOfPlayer As Dictionary(Of String, List(Of Integer))
    Public Sub main()

    End Sub

    Public Sub saveData()

    End Sub

    Public Sub registerPattern(sender As Panel)
        Dim pattern As String
        For Each controls As TextBox In sender.Controls
            pattern = pattern & controls.Text
        Next
        patternToGuess = pattern
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

End Module
