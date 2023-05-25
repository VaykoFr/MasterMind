<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticPlayer
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
        Me.ComboBoxPlayer = New System.Windows.Forms.ComboBox()
        Me.LabelSelectPlayer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelBestTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelCumulTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelFirstPlayer = New System.Windows.Forms.Label()
        Me.LabelSecondPlayer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxPlayer
        '
        Me.ComboBoxPlayer.FormattingEnabled = True
        Me.ComboBoxPlayer.Location = New System.Drawing.Point(158, 73)
        Me.ComboBoxPlayer.Name = "ComboBoxPlayer"
        Me.ComboBoxPlayer.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxPlayer.TabIndex = 1
        '
        'LabelSelectPlayer
        '
        Me.LabelSelectPlayer.AutoSize = True
        Me.LabelSelectPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelectPlayer.Location = New System.Drawing.Point(109, 41)
        Me.LabelSelectPlayer.Name = "LabelSelectPlayer"
        Me.LabelSelectPlayer.Size = New System.Drawing.Size(256, 29)
        Me.LabelSelectPlayer.TabIndex = 2
        Me.LabelSelectPlayer.Text = "Choisissez un joueur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(57, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Score du joueur :"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScore.Location = New System.Drawing.Point(259, 140)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(86, 29)
        Me.LabelScore.TabIndex = 4
        Me.LabelScore.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(57, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Meilleur temps :"
        '
        'LabelBestTime
        '
        Me.LabelBestTime.AutoSize = True
        Me.LabelBestTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelBestTime.Location = New System.Drawing.Point(259, 183)
        Me.LabelBestTime.Name = "LabelBestTime"
        Me.LabelBestTime.Size = New System.Drawing.Size(86, 29)
        Me.LabelBestTime.TabIndex = 6
        Me.LabelBestTime.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(58, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Temps cumulé :"
        '
        'LabelCumulTime
        '
        Me.LabelCumulTime.AutoSize = True
        Me.LabelCumulTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelCumulTime.Location = New System.Drawing.Point(259, 228)
        Me.LabelCumulTime.Name = "LabelCumulTime"
        Me.LabelCumulTime.Size = New System.Drawing.Size(86, 29)
        Me.LabelCumulTime.TabIndex = 8
        Me.LabelCumulTime.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(325, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre de partie tant que:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(58, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Premier joueur :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(57, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Second joueur :"
        '
        'LabelFirstPlayer
        '
        Me.LabelFirstPlayer.AutoSize = True
        Me.LabelFirstPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelFirstPlayer.Location = New System.Drawing.Point(274, 324)
        Me.LabelFirstPlayer.Name = "LabelFirstPlayer"
        Me.LabelFirstPlayer.Size = New System.Drawing.Size(86, 29)
        Me.LabelFirstPlayer.TabIndex = 13
        Me.LabelFirstPlayer.Text = "Label8"
        '
        'LabelSecondPlayer
        '
        Me.LabelSecondPlayer.AutoSize = True
        Me.LabelSecondPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelSecondPlayer.Location = New System.Drawing.Point(274, 373)
        Me.LabelSecondPlayer.Name = "LabelSecondPlayer"
        Me.LabelSecondPlayer.Size = New System.Drawing.Size(86, 29)
        Me.LabelSecondPlayer.TabIndex = 14
        Me.LabelSecondPlayer.Text = "Label8"
        '
        'StatisticPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 446)
        Me.Controls.Add(Me.LabelSecondPlayer)
        Me.Controls.Add(Me.LabelFirstPlayer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelCumulTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelBestTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelSelectPlayer)
        Me.Controls.Add(Me.ComboBoxPlayer)
        Me.Name = "StatisticPlayer"
        Me.Text = "StatisticPlayer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxPlayer As ComboBox
    Friend WithEvents LabelSelectPlayer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelBestTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelCumulTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelFirstPlayer As Label
    Friend WithEvents LabelSecondPlayer As Label
End Class
