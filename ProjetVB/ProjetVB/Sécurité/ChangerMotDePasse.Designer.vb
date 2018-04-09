<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangerMotDePasse
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
        Me.Changer = New System.Windows.Forms.Button()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.Lbl_nomUtilisateur = New System.Windows.Forms.Label()
        Me.lbl_motdePasse = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNomUtilisateur = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmerMotdePasse = New System.Windows.Forms.TextBox()
        Me.TextBoxNouveauMotdePasse = New System.Windows.Forms.TextBox()
        Me.TextBoxMotdePasse = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Changer
        '
        Me.Changer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.35!)
        Me.Changer.Location = New System.Drawing.Point(12, 118)
        Me.Changer.Name = "Changer"
        Me.Changer.Size = New System.Drawing.Size(118, 23)
        Me.Changer.TabIndex = 0
        Me.Changer.Text = "Changer"
        Me.Changer.UseVisualStyleBackColor = True
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.35!)
        Me.btn_Annuler.Location = New System.Drawing.Point(228, 118)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(118, 23)
        Me.btn_Annuler.TabIndex = 1
        Me.btn_Annuler.Text = "Annuler"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'Lbl_nomUtilisateur
        '
        Me.Lbl_nomUtilisateur.AutoSize = True
        Me.Lbl_nomUtilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.35!)
        Me.Lbl_nomUtilisateur.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_nomUtilisateur.Name = "Lbl_nomUtilisateur"
        Me.Lbl_nomUtilisateur.Size = New System.Drawing.Size(113, 16)
        Me.Lbl_nomUtilisateur.TabIndex = 2
        Me.Lbl_nomUtilisateur.Text = "Nom d'utilisateur :"
        '
        'lbl_motdePasse
        '
        Me.lbl_motdePasse.AutoSize = True
        Me.lbl_motdePasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.35!)
        Me.lbl_motdePasse.Location = New System.Drawing.Point(3, 28)
        Me.lbl_motdePasse.Name = "lbl_motdePasse"
        Me.lbl_motdePasse.Size = New System.Drawing.Size(96, 16)
        Me.lbl_motdePasse.TabIndex = 3
        Me.lbl_motdePasse.Text = "Mot de passe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.35!)
        Me.Label3.Location = New System.Drawing.Point(3, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nouveau mot de passe :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.35!)
        Me.Label4.Location = New System.Drawing.Point(3, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Confirmer le mot de passe :"
        '
        'TextBoxNomUtilisateur
        '
        Me.TextBoxNomUtilisateur.Location = New System.Drawing.Point(122, 5)
        Me.TextBoxNomUtilisateur.Name = "TextBoxNomUtilisateur"
        Me.TextBoxNomUtilisateur.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxNomUtilisateur.TabIndex = 6
        '
        'TextBoxConfirmerMotdePasse
        '
        Me.TextBoxConfirmerMotdePasse.Location = New System.Drawing.Point(172, 74)
        Me.TextBoxConfirmerMotdePasse.Name = "TextBoxConfirmerMotdePasse"
        Me.TextBoxConfirmerMotdePasse.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxConfirmerMotdePasse.TabIndex = 7
        '
        'TextBoxNouveauMotdePasse
        '
        Me.TextBoxNouveauMotdePasse.Location = New System.Drawing.Point(163, 51)
        Me.TextBoxNouveauMotdePasse.Name = "TextBoxNouveauMotdePasse"
        Me.TextBoxNouveauMotdePasse.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxNouveauMotdePasse.TabIndex = 8
        '
        'TextBoxMotdePasse
        '
        Me.TextBoxMotdePasse.Location = New System.Drawing.Point(105, 28)
        Me.TextBoxMotdePasse.Name = "TextBoxMotdePasse"
        Me.TextBoxMotdePasse.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxMotdePasse.TabIndex = 9
        '
        'ChangerMotDePasse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(352, 148)
        Me.Controls.Add(Me.TextBoxMotdePasse)
        Me.Controls.Add(Me.TextBoxNouveauMotdePasse)
        Me.Controls.Add(Me.TextBoxConfirmerMotdePasse)
        Me.Controls.Add(Me.TextBoxNomUtilisateur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_motdePasse)
        Me.Controls.Add(Me.Lbl_nomUtilisateur)
        Me.Controls.Add(Me.btn_Annuler)
        Me.Controls.Add(Me.Changer)
        Me.Name = "ChangerMotDePasse"
        Me.Text = "Changer le mot de passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Changer As Button
    Friend WithEvents btn_Annuler As Button
    Friend WithEvents Lbl_nomUtilisateur As Label
    Friend WithEvents lbl_motdePasse As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNomUtilisateur As TextBox
    Friend WithEvents TextBoxConfirmerMotdePasse As TextBox
    Friend WithEvents TextBoxNouveauMotdePasse As TextBox
    Friend WithEvents TextBoxMotdePasse As TextBox
End Class
