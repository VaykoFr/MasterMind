Public Class SelectPattern
    Private Sub SelectPattern_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCharacter.Text = Module1.possibleCharacter
        Me.Text = "Fait deviner !"
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        If verifyCorrectCombinaison() Then
            Module1.registerPattern(PanelPattern)
            Me.Hide()
            GuessPattern.Show()
        Else
            MsgBox("Incorrect Character")
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

    Private Sub txtFinalCase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ButtonHide.PerformClick()
            e.Handled = True
        End If
    End Sub

End Class