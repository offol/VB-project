<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAJService
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
        Me.ListBox_Service = New System.Windows.Forms.ListBox()
        Me.Label_Description = New System.Windows.Forms.Label()
        Me.Label_Prix = New System.Windows.Forms.Label()
        Me.Button_CréerService = New System.Windows.Forms.Button()
        Me.Button_Sauvegarder = New System.Windows.Forms.Button()
        Me.TextBox_Description = New System.Windows.Forms.TextBox()
        Me.TextBox_Prix = New System.Windows.Forms.MaskedTextBox()
        Me.Button_Supprimer = New System.Windows.Forms.Button()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.TextBox_Nom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox_Service
        '
        Me.ListBox_Service.FormattingEnabled = True
        Me.ListBox_Service.Location = New System.Drawing.Point(12, 11)
        Me.ListBox_Service.Name = "ListBox_Service"
        Me.ListBox_Service.Size = New System.Drawing.Size(236, 173)
        Me.ListBox_Service.TabIndex = 0
        '
        'Label_Description
        '
        Me.Label_Description.AutoSize = True
        Me.Label_Description.Location = New System.Drawing.Point(12, 245)
        Me.Label_Description.Name = "Label_Description"
        Me.Label_Description.Size = New System.Drawing.Size(66, 13)
        Me.Label_Description.TabIndex = 1
        Me.Label_Description.Text = "Description :"
        '
        'Label_Prix
        '
        Me.Label_Prix.AutoSize = True
        Me.Label_Prix.Location = New System.Drawing.Point(12, 220)
        Me.Label_Prix.Name = "Label_Prix"
        Me.Label_Prix.Size = New System.Drawing.Size(30, 13)
        Me.Label_Prix.TabIndex = 2
        Me.Label_Prix.Text = "Prix :"
        '
        'Button_CréerService
        '
        Me.Button_CréerService.Location = New System.Drawing.Point(202, 328)
        Me.Button_CréerService.Name = "Button_CréerService"
        Me.Button_CréerService.Size = New System.Drawing.Size(106, 23)
        Me.Button_CréerService.TabIndex = 3
        Me.Button_CréerService.Text = "Créer un service"
        Me.Button_CréerService.UseVisualStyleBackColor = True
        '
        'Button_Sauvegarder
        '
        Me.Button_Sauvegarder.Location = New System.Drawing.Point(11, 328)
        Me.Button_Sauvegarder.Name = "Button_Sauvegarder"
        Me.Button_Sauvegarder.Size = New System.Drawing.Size(85, 23)
        Me.Button_Sauvegarder.TabIndex = 4
        Me.Button_Sauvegarder.Text = "Sauvegarder"
        Me.Button_Sauvegarder.UseVisualStyleBackColor = True
        '
        'TextBox_Description
        '
        Me.TextBox_Description.Location = New System.Drawing.Point(84, 245)
        Me.TextBox_Description.Multiline = True
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.Size = New System.Drawing.Size(224, 77)
        Me.TextBox_Description.TabIndex = 5
        '
        'TextBox_Prix
        '
        Me.TextBox_Prix.Location = New System.Drawing.Point(84, 217)
        Me.TextBox_Prix.Name = "TextBox_Prix"
        Me.TextBox_Prix.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Prix.TabIndex = 7
        '
        'Button_Supprimer
        '
        Me.Button_Supprimer.Location = New System.Drawing.Point(102, 328)
        Me.Button_Supprimer.Name = "Button_Supprimer"
        Me.Button_Supprimer.Size = New System.Drawing.Size(94, 23)
        Me.Button_Supprimer.TabIndex = 8
        Me.Button_Supprimer.Text = "Supprimer"
        Me.Button_Supprimer.UseVisualStyleBackColor = True
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.Location = New System.Drawing.Point(12, 194)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(35, 13)
        Me.Label_Nom.TabIndex = 9
        Me.Label_Nom.Text = "Nom :"
        '
        'TextBox_Nom
        '
        Me.TextBox_Nom.Location = New System.Drawing.Point(84, 191)
        Me.TextBox_Nom.Name = "TextBox_Nom"
        Me.TextBox_Nom.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Nom.TabIndex = 10
        '
        'MAJService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 358)
        Me.Controls.Add(Me.TextBox_Nom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.Button_Supprimer)
        Me.Controls.Add(Me.TextBox_Prix)
        Me.Controls.Add(Me.TextBox_Description)
        Me.Controls.Add(Me.Button_Sauvegarder)
        Me.Controls.Add(Me.Button_CréerService)
        Me.Controls.Add(Me.Label_Prix)
        Me.Controls.Add(Me.Label_Description)
        Me.Controls.Add(Me.ListBox_Service)
        Me.Name = "MAJService"
        Me.Text = "MAJService"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_Service As ListBox
    Friend WithEvents Label_Description As Label
    Friend WithEvents Label_Prix As Label
    Friend WithEvents Button_CréerService As Button
    Friend WithEvents Button_Sauvegarder As Button
    Friend WithEvents TextBox_Description As TextBox
    Friend WithEvents TextBox_Prix As MaskedTextBox
    Friend WithEvents Button_Supprimer As Button
    Friend WithEvents Label_Nom As Label
    Friend WithEvents TextBox_Nom As TextBox
End Class
