<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Taxe
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
        Me.Button_Sauvegarder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_TPS = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_TVQ = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Button_Sauvegarder
        '
        Me.Button_Sauvegarder.Location = New System.Drawing.Point(12, 151)
        Me.Button_Sauvegarder.Name = "Button_Sauvegarder"
        Me.Button_Sauvegarder.Size = New System.Drawing.Size(91, 27)
        Me.Button_Sauvegarder.TabIndex = 0
        Me.Button_Sauvegarder.Text = "Sauvegarder"
        Me.Button_Sauvegarder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Information TPS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Information TVQ"
        '
        'TextBox_TPS
        '
        Me.TextBox_TPS.Location = New System.Drawing.Point(16, 43)
        Me.TextBox_TPS.Name = "TextBox_TPS"
        Me.TextBox_TPS.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_TPS.TabIndex = 3
        '
        'TextBox_TVQ
        '
        Me.TextBox_TVQ.Location = New System.Drawing.Point(16, 106)
        Me.TextBox_TVQ.Name = "TextBox_TVQ"
        Me.TextBox_TVQ.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_TVQ.TabIndex = 4
        '
        'Taxe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 189)
        Me.Controls.Add(Me.TextBox_TVQ)
        Me.Controls.Add(Me.TextBox_TPS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Sauvegarder)
        Me.Name = "Taxe"
        Me.Text = "Taxe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Sauvegarder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_TPS As MaskedTextBox
    Friend WithEvents TextBox_TVQ As MaskedTextBox
End Class
