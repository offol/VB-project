<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.Button_connect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_nom = New System.Windows.Forms.TextBox()
        Me.TextBox_motdepasse = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_connect
        '
        Me.Button_connect.Location = New System.Drawing.Point(125, 98)
        Me.Button_connect.Name = "Button_connect"
        Me.Button_connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_connect.TabIndex = 0
        Me.Button_connect.Text = "Connection"
        Me.Button_connect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom d'utilisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mot de passe :"
        '
        'TextBox_nom
        '
        Me.TextBox_nom.Location = New System.Drawing.Point(109, 21)
        Me.TextBox_nom.Name = "TextBox_nom"
        Me.TextBox_nom.Size = New System.Drawing.Size(219, 20)
        Me.TextBox_nom.TabIndex = 3
        '
        'TextBox_motdepasse
        '
        Me.TextBox_motdepasse.Location = New System.Drawing.Point(109, 61)
        Me.TextBox_motdepasse.Name = "TextBox_motdepasse"
        Me.TextBox_motdepasse.Size = New System.Drawing.Size(219, 20)
        Me.TextBox_motdepasse.TabIndex = 4
        Me.TextBox_motdepasse.UseSystemPasswordChar = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 133)
        Me.Controls.Add(Me.TextBox_motdepasse)
        Me.Controls.Add(Me.TextBox_nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_connect)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_connect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_nom As TextBox
    Friend WithEvents TextBox_motdepasse As TextBox
End Class
