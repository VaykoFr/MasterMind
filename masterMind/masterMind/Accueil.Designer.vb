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
        Me.SuspendLayout()
        '
        'ComboBoxPlayer1
        '
        Me.ComboBoxPlayer1.FormattingEnabled = True
        Me.ComboBoxPlayer1.Location = New System.Drawing.Point(131, 84)
        Me.ComboBoxPlayer1.Name = "ComboBoxPlayer1"
        Me.ComboBoxPlayer1.Size = New System.Drawing.Size(159, 28)
        Me.ComboBoxPlayer1.TabIndex = 0
        '
        'ComboBoxPlayer2
        '
        Me.ComboBoxPlayer2.FormattingEnabled = True
        Me.ComboBoxPlayer2.Location = New System.Drawing.Point(131, 176)
        Me.ComboBoxPlayer2.Name = "ComboBoxPlayer2"
        Me.ComboBoxPlayer2.Size = New System.Drawing.Size(159, 28)
        Me.ComboBoxPlayer2.TabIndex = 1
        '
        'ButtonScore
        '
        Me.ButtonScore.Location = New System.Drawing.Point(437, 114)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(126, 72)
        Me.ButtonScore.TabIndex = 2
        Me.ButtonScore.Text = "Scoreboard"
        Me.ButtonScore.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(149, 257)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(126, 72)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(437, 257)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(126, 72)
        Me.ButtonStart.TabIndex = 4
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'LabelApp
        '
        Me.LabelApp.AutoSize = True
        Me.LabelApp.Location = New System.Drawing.Point(273, 9)
        Me.LabelApp.Name = "LabelApp"
        Me.LabelApp.Size = New System.Drawing.Size(121, 20)
        Me.LabelApp.TabIndex = 5
        Me.LabelApp.Text = "MASTER MIND"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 350)
        Me.Controls.Add(Me.LabelApp)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.ComboBoxPlayer2)
        Me.Controls.Add(Me.ComboBoxPlayer1)
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
End Class
