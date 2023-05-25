<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuessPattern
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelGuess = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonGuess = New System.Windows.Forms.Button()
        Me.TimerGuess = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Label()
        Me.LabelTimeLeft = New System.Windows.Forms.Label()
        Me.ButtonLeave = New System.Windows.Forms.Button()
        Me.LabelCodeCouleur = New System.Windows.Forms.Label()
        Me.LabelMiss = New System.Windows.Forms.Label()
        Me.LabelPresent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTry = New System.Windows.Forms.Label()
        Me.LabelTryLeft = New System.Windows.Forms.Label()
        Me.LabelPossibleCharacter = New System.Windows.Forms.Label()
        Me.LabelCharacter = New System.Windows.Forms.Label()
        Me.PanelGuess.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelGuess
        '
        Me.PanelGuess.Controls.Add(Me.TextBox5)
        Me.PanelGuess.Controls.Add(Me.TextBox4)
        Me.PanelGuess.Controls.Add(Me.TextBox3)
        Me.PanelGuess.Controls.Add(Me.TextBox2)
        Me.PanelGuess.Controls.Add(Me.TextBox1)
        Me.PanelGuess.Location = New System.Drawing.Point(64, 43)
        Me.PanelGuess.Name = "PanelGuess"
        Me.PanelGuess.Size = New System.Drawing.Size(267, 112)
        Me.PanelGuess.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(197, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(35, 26)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(156, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(35, 26)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(36, 26)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(71, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(37, 26)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(28, 48)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(37, 26)
        Me.TextBox1.TabIndex = 0
        '
        'ButtonGuess
        '
        Me.ButtonGuess.Location = New System.Drawing.Point(404, 71)
        Me.ButtonGuess.Name = "ButtonGuess"
        Me.ButtonGuess.Size = New System.Drawing.Size(119, 66)
        Me.ButtonGuess.TabIndex = 1
        Me.ButtonGuess.Text = "Guess"
        Me.ButtonGuess.UseVisualStyleBackColor = True
        '
        'TimerGuess
        '
        Me.TimerGuess.Enabled = True
        Me.TimerGuess.Interval = 1000
        '
        'LabelTimer
        '
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Location = New System.Drawing.Point(398, 502)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(119, 20)
        Me.LabelTimer.TabIndex = 2
        Me.LabelTimer.Text = "Temps restant :"
        '
        'Timer
        '
        Me.Timer.AutoSize = True
        Me.Timer.Location = New System.Drawing.Point(524, 502)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(0, 20)
        Me.Timer.TabIndex = 3
        '
        'LabelTimeLeft
        '
        Me.LabelTimeLeft.AutoSize = True
        Me.LabelTimeLeft.Location = New System.Drawing.Point(523, 502)
        Me.LabelTimeLeft.Name = "LabelTimeLeft"
        Me.LabelTimeLeft.Size = New System.Drawing.Size(48, 20)
        Me.LabelTimeLeft.TabIndex = 4
        Me.LabelTimeLeft.Text = "Label"
        '
        'ButtonLeave
        '
        Me.ButtonLeave.Enabled = False
        Me.ButtonLeave.Location = New System.Drawing.Point(440, 677)
        Me.ButtonLeave.Name = "ButtonLeave"
        Me.ButtonLeave.Size = New System.Drawing.Size(165, 91)
        Me.ButtonLeave.TabIndex = 5
        Me.ButtonLeave.Text = "Bye"
        Me.ButtonLeave.UseVisualStyleBackColor = True
        '
        'LabelCodeCouleur
        '
        Me.LabelCodeCouleur.AutoSize = True
        Me.LabelCodeCouleur.Location = New System.Drawing.Point(436, 169)
        Me.LabelCodeCouleur.Name = "LabelCodeCouleur"
        Me.LabelCodeCouleur.Size = New System.Drawing.Size(114, 20)
        Me.LabelCodeCouleur.TabIndex = 6
        Me.LabelCodeCouleur.Text = "Code Couleur :"
        '
        'LabelMiss
        '
        Me.LabelMiss.AutoSize = True
        Me.LabelMiss.Location = New System.Drawing.Point(459, 202)
        Me.LabelMiss.Name = "LabelMiss"
        Me.LabelMiss.Size = New System.Drawing.Size(60, 20)
        Me.LabelMiss.TabIndex = 7
        Me.LabelMiss.Text = "Absent"
        '
        'LabelPresent
        '
        Me.LabelPresent.AutoSize = True
        Me.LabelPresent.ForeColor = System.Drawing.Color.Blue
        Me.LabelPresent.Location = New System.Drawing.Point(459, 232)
        Me.LabelPresent.Name = "LabelPresent"
        Me.LabelPresent.Size = New System.Drawing.Size(64, 20)
        Me.LabelPresent.TabIndex = 8
        Me.LabelPresent.Text = "Présent"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(412, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Présent et bien placé"
        '
        'LabelTry
        '
        Me.LabelTry.AutoSize = True
        Me.LabelTry.Location = New System.Drawing.Point(414, 420)
        Me.LabelTry.Name = "LabelTry"
        Me.LabelTry.Size = New System.Drawing.Size(109, 20)
        Me.LabelTry.TabIndex = 10
        Me.LabelTry.Text = "Coup restant :"
        '
        'LabelTryLeft
        '
        Me.LabelTryLeft.AutoSize = True
        Me.LabelTryLeft.Location = New System.Drawing.Point(530, 420)
        Me.LabelTryLeft.Name = "LabelTryLeft"
        Me.LabelTryLeft.Size = New System.Drawing.Size(48, 20)
        Me.LabelTryLeft.TabIndex = 11
        Me.LabelTryLeft.Text = "Label"
        '
        'LabelPossibleCharacter
        '
        Me.LabelPossibleCharacter.AutoSize = True
        Me.LabelPossibleCharacter.Location = New System.Drawing.Point(414, 317)
        Me.LabelPossibleCharacter.Name = "LabelPossibleCharacter"
        Me.LabelPossibleCharacter.Size = New System.Drawing.Size(143, 20)
        Me.LabelPossibleCharacter.TabIndex = 12
        Me.LabelPossibleCharacter.Text = "Possible character:"
        '
        'LabelCharacter
        '
        Me.LabelCharacter.AutoSize = True
        Me.LabelCharacter.Location = New System.Drawing.Point(463, 341)
        Me.LabelCharacter.Name = "LabelCharacter"
        Me.LabelCharacter.Size = New System.Drawing.Size(48, 20)
        Me.LabelCharacter.TabIndex = 13
        Me.LabelCharacter.Text = "Label"
        '
        'GuessPattern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 806)
        Me.Controls.Add(Me.LabelCharacter)
        Me.Controls.Add(Me.LabelPossibleCharacter)
        Me.Controls.Add(Me.LabelTryLeft)
        Me.Controls.Add(Me.LabelTry)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPresent)
        Me.Controls.Add(Me.LabelMiss)
        Me.Controls.Add(Me.LabelCodeCouleur)
        Me.Controls.Add(Me.ButtonLeave)
        Me.Controls.Add(Me.LabelTimeLeft)
        Me.Controls.Add(Me.Timer)
        Me.Controls.Add(Me.LabelTimer)
        Me.Controls.Add(Me.ButtonGuess)
        Me.Controls.Add(Me.PanelGuess)
        Me.Name = "GuessPattern"
        Me.Text = "GuessPattern"
        Me.PanelGuess.ResumeLayout(False)
        Me.PanelGuess.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelGuess As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonGuess As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TimerGuess As Timer
    Friend WithEvents LabelTimer As Label
    Friend WithEvents Timer As Label
    Friend WithEvents LabelTimeLeft As Label
    Friend WithEvents ButtonLeave As Button
    Friend WithEvents LabelCodeCouleur As Label
    Friend WithEvents LabelMiss As Label
    Friend WithEvents LabelPresent As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTry As Label
    Friend WithEvents LabelTryLeft As Label
    Friend WithEvents LabelPossibleCharacter As Label
    Friend WithEvents LabelCharacter As Label
End Class
