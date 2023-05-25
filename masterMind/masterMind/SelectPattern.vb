Public Class SelectPattern
    Private Sub SelectPattern_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCharacter.Text = Module1.possibleCharacter
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        If verifyCorrectCombinaison() Then
            Module1.registerPattern(PanelPattern)
            Me.Hide()
            GuessPattern.Show()
        Else
            MsgBox("incorrect Character")
        End If
    End Sub

    Private Function verifyCorrectCombinaison() As Boolean
        For Each sender As TextBox In PanelPattern.Controls
            If sender.Text.Trim.Length = 0 Then
                Return False
            ElseIf Module1.possibleCharacter.IndexOf(sender.Text) = -1 Then
                Return False
            End If
        Next
        Return True
    End Function
End Class