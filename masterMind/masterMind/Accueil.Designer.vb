<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.ComboBoxPlayer1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPlayer2 = New System.Windows.Forms.ComboBox()
        Me.ButtonScore = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.LabelApp = New System.Windows.Forms.Label()
        Me.LabelJ1 = New System.Windows.Forms.Label()
        Me.LabelJ2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxPlayer1
        '
        Me.ComboBoxPlayer1.FormattingEnabled = True
        Me.ComboBoxPlayer1.Location = New System.Drawing.Point(87, 55)
        Me.ComboBoxPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxPlayer1.Name = "ComboBoxPlayer1"
        Me.ComboBoxPlayer1.Size = New System.Drawing.Size(107, 21)
        Me.ComboBoxPlayer1.TabIndex = 0
        '
        'ComboBoxPlayer2
        '
        Me.ComboBoxPlayer2.FormattingEnabled = True
        Me.ComboBoxPlayer2.Location = New System.Drawing.Point(87, 114)
        Me.ComboBoxPlayer2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxPlayer2.Name = "ComboBoxPlayer2"
        Me.ComboBoxPlayer2.Size = New System.Drawing.Size(107, 21)
        Me.ComboBoxPlayer2.TabIndex = 1
        '
        'ButtonScore
        '
        Me.ButtonScore.Location = New System.Drawing.Point(291, 55)
        Me.ButtonScore.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(84, 47)
        Me.ButtonScore.TabIndex = 2
        Me.ButtonScore.Text = "Scoreboard"
        Me.ButtonScore.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(87, 167)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(84, 47)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "Quitter"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(291, 167)
        Me.ButtonStart.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(84, 47)
        Me.ButtonStart.TabIndex = 4
        Me.ButtonStart.Text = "Commercer"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'LabelApp
        '
        Me.LabelApp.AutoSize = True
        Me.LabelApp.Location = New System.Drawing.Point(182, 6)
        Me.LabelApp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelApp.Name = "LabelApp"
        Me.LabelApp.Size = New System.Drawing.Size(83, 13)
        Me.LabelApp.TabIndex = 5
        Me.LabelApp.Text = "MASTER MIND"
        '
        'LabelJ1
        '
        Me.LabelJ1.AutoSize = True
        Me.LabelJ1.Location = New System.Drawing.Point(84, 40)
        Me.LabelJ1.Name = "LabelJ1"
        Me.LabelJ1.Size = New System.Drawing.Size(87, 13)
        Me.LabelJ1.TabIndex = 6
        Me.LabelJ1.Text = "Pseudo Joueur 1"
        '
        'LabelJ2
        '
        Me.LabelJ2.AutoSize = True
        Me.LabelJ2.Location = New System.Drawing.Point(84, 99)
        Me.LabelJ2.Name = "LabelJ2"
        Me.LabelJ2.Size = New System.Drawing.Size(87, 13)
        Me.LabelJ2.TabIndex = 7
        Me.LabelJ2.Text = "Pseudo Joueur 2"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 227)
        Me.Controls.Add(Me.LabelJ2)
        Me.Controls.Add(Me.LabelJ1)
        Me.Controls.Add(Me.LabelApp)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.ComboBoxPlayer2)
        Me.Controls.Add(Me.ComboBoxPlayer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxPlayer1 As ComboBox
    Friend WithEvents ComboBoxPlayer2 As ComboBox
    Friend WithEvents ButtonScore As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents LabelApp As Label
    Friend WithEvents LabelJ1 As Label
    Friend WithEvents LabelJ2 As Label
End Class
