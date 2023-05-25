<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPattern
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
        Me.PanelPattern = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonHide = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCharacter = New System.Windows.Forms.Label()
        Me.PanelPattern.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPattern
        '
        Me.PanelPattern.Controls.Add(Me.TextBox5)
        Me.PanelPattern.Controls.Add(Me.TextBox4)
        Me.PanelPattern.Controls.Add(Me.TextBox3)
        Me.PanelPattern.Controls.Add(Me.TextBox2)
        Me.PanelPattern.Controls.Add(Me.TextBox1)
        Me.PanelPattern.Location = New System.Drawing.Point(46, 56)
        Me.PanelPattern.Name = "PanelPattern"
        Me.PanelPattern.Size = New System.Drawing.Size(254, 84)
        Me.PanelPattern.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(192, 29)
        Me.TextBox5.MaxLength = 1
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(35, 26)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(150, 29)
        Me.TextBox4.MaxLength = 1
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 26)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(107, 29)
        Me.TextBox3.MaxLength = 1
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(37, 26)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(64, 29)
        Me.TextBox2.MaxLength = 1
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(37, 26)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 29)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(37, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonHide
        '
        Me.ButtonHide.Location = New System.Drawing.Point(350, 71)
        Me.ButtonHide.Name = "ButtonHide"
        Me.ButtonHide.Size = New System.Drawing.Size(122, 55)
        Me.ButtonHide.TabIndex = 1
        Me.ButtonHide.Text = "Hide"
        Me.ButtonHide.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "possible character :"
        '
        'LabelCharacter
        '
        Me.LabelCharacter.AutoSize = True
        Me.LabelCharacter.Location = New System.Drawing.Point(387, 200)
        Me.LabelCharacter.Name = "LabelCharacter"
        Me.LabelCharacter.Size = New System.Drawing.Size(57, 20)
        Me.LabelCharacter.TabIndex = 3
        Me.LabelCharacter.Text = "Label2"
        '
        'SelectPattern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 268)
        Me.Controls.Add(Me.LabelCharacter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonHide)
        Me.Controls.Add(Me.PanelPattern)
        Me.Name = "SelectPattern"
        Me.Text = "SelectPattern"
        Me.PanelPattern.ResumeLayout(False)
        Me.PanelPattern.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelPattern As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonHide As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelCharacter As Label
End Class
