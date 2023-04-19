<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ComboPseudo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboPseudo
        '
        Me.ComboPseudo.FormattingEnabled = True
        Me.ComboPseudo.Location = New System.Drawing.Point(12, 12)
        Me.ComboPseudo.Name = "ComboPseudo"
        Me.ComboPseudo.Size = New System.Drawing.Size(174, 24)
        Me.ComboPseudo.TabIndex = 0
        Me.ComboPseudo.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 184)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "VALIDER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 320)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboPseudo)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Entrez votre pseudo"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboPseudo As ComboBox
    Friend WithEvents Button1 As Button
End Class
