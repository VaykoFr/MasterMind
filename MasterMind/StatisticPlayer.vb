﻿Public Class StatisticPlayer
    Private Sub StatisticPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each key As String In Module1.listOfPlayer.Keys

        Next
        Me.Text = "Tableau des scorese"
    End Sub
End Class