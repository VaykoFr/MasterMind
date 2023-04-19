Imports System.IO
Imports System.Text.Json
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            MsgBox("Pseudo " & pseudo & " ajouté")

            ' Écrire la liste des pseudos dans un fichier JSON
            Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(ComboPseudo.Items)
            My.Computer.FileSystem.WriteAllText("pseudos.json", json, False)
        End If
    End Sub




End Class
