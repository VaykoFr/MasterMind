Imports System.IO
Imports System.Text.Json
Imports Newtonsoft.Json

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charge les pseudos à partir du fichier JSON
        If File.Exists("PlayerStats.json") Then
            Dim json As String = File.ReadAllText("PlayerStats.json")
            Dim playerStats As List(Of Dictionary(Of String, String)) = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)

            ' Ajoute les pseudos à la ComboBox
            For Each player In playerStats
                Dim pseudo As String = player("pseudo")
                If Not ComboPseudo.Items.Contains(pseudo) Then
                    ComboPseudo.Items.Add(pseudo)
                End If
            Next
        End If
    End Sub

    Private Sub ComboPseudo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboPseudo.Validating
        Dim pseudo As String = ComboPseudo.Text

        If ComboPseudo.Items.Contains(pseudo) Then
            MsgBox("Ce pseudo est déjà utilisé")
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pseudo As String = ComboPseudo.Text

        If ComboPseudo.Items.Contains(pseudo) Then
            MsgBox("Ce pseudo est déjà utilisé")
        Else
            ComboPseudo.Items.Add(pseudo)

            ' Ajoute le pseudo au fichier JSON
            Dim playerStats As New List(Of Dictionary(Of String, String))()
            If File.Exists("PlayerStats.json") Then
                Dim json As String = File.ReadAllText("PlayerStats.json")
                playerStats = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)
            End If
            Dim player As New Dictionary(Of String, String)()
            player.Add("pseudo", pseudo)
            playerStats.Add(player)
            Dim jsonOutput As String = JsonConvert.SerializeObject(playerStats)
            File.WriteAllText("PlayerStats.json", jsonOutput)

            MsgBox("Pseudo " & pseudo & " ajouté et sauvegardé dans le fichier PlayerStats.JSON")
        End If
    End Sub







End Class
