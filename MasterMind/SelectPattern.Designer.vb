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
        Me.PanelPattern.Location = New System.Drawing.Point(31, 36)
        Me.PanelPattern.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelPattern.Name = "PanelPattern"
        Me.PanelPattern.Size = New System.Drawing.Size(169, 55)
        Me.PanelPattern.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(128, 19)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.MaxLength = 1
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(25, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(100, 19)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.MaxLength = 1
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(25, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(71, 19)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.MaxLength = 1
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(26, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(43, 19)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.MaxLength = 1
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(26, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 19)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonHide
        '
        Me.ButtonHide.Location = New System.Drawing.Point(233, 46)
        Me.ButtonHide.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHide.Name = "ButtonHide"
        Me.ButtonHide.Size = New System.Drawing.Size(81, 36)
        Me.ButtonHide.TabIndex = 1
        Me.ButtonHide.Text = "C'est parti !"
        Me.ButtonHide.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Caractère possible:"
        '
        'LabelCharacter
        '
        Me.LabelCharacter.AutoSize = True
        Me.LabelCharacter.Location = New System.Drawing.Point(258, 130)
        Me.LabelCharacter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCharacter.Name = "LabelCharacter"
        Me.LabelCharacter.Size = New System.Drawing.Size(28, 13)
        Me.LabelCharacter.TabIndex = 3
        Me.LabelCharacter.Text = "XXX"
        '
        'SelectPattern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 174)
        Me.Controls.Add(Me.LabelCharacter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonHide)
        Me.Controls.Add(Me.PanelPattern)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
