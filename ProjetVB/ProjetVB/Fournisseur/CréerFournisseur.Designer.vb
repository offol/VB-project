<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CréerFournisseur
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
        Me.lbnomFournisseur = New System.Windows.Forms.Label()
        Me.lbnumeroFournisseur = New System.Windows.Forms.Label()
        Me.lbtelephoneFournisseur = New System.Windows.Forms.Label()
        Me.lbtelecopieurFournisseur = New System.Windows.Forms.Label()
        Me.Enregistrer_lbl = New System.Windows.Forms.Label()
        Me.TextBox_Nom = New System.Windows.Forms.TextBox()
        Me.TextBoxtelecopieur = New System.Windows.Forms.TextBox()
        Me.TextBoxTelephone = New System.Windows.Forms.TextBox()
        Me.TextBox_numéro = New System.Windows.Forms.TextBox()
        Me.Lb_adresseFournisseur = New System.Windows.Forms.Label()
        Me.Lb_NoCiviqueFournisseur = New System.Windows.Forms.Label()
        Me.Lb_rueFournisseur = New System.Windows.Forms.Label()
        Me.TextBoxNuméroCivique = New System.Windows.Forms.TextBox()
        Me.TextBoxCodePostal = New System.Windows.Forms.TextBox()
        Me.Btn_enregistrerF = New System.Windows.Forms.Button()
        Me.AnnulerFournisseur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbnomFournisseur
        '
        Me.lbnomFournisseur.AutoSize = True
        Me.lbnomFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lbnomFournisseur.Location = New System.Drawing.Point(13, 54)
        Me.lbnomFournisseur.Name = "lbnomFournisseur"
        Me.lbnomFournisseur.Size = New System.Drawing.Size(45, 17)
        Me.lbnomFournisseur.TabIndex = 0
        Me.lbnomFournisseur.Text = "Nom :"
        '
        'lbnumeroFournisseur
        '
        Me.lbnumeroFournisseur.AutoSize = True
        Me.lbnumeroFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lbnumeroFournisseur.Location = New System.Drawing.Point(13, 83)
        Me.lbnumeroFournisseur.Name = "lbnumeroFournisseur"
        Me.lbnumeroFournisseur.Size = New System.Drawing.Size(66, 17)
        Me.lbnumeroFournisseur.TabIndex = 1
        Me.lbnumeroFournisseur.Text = "Numéro :"
        '
        'lbtelephoneFournisseur
        '
        Me.lbtelephoneFournisseur.AutoSize = True
        Me.lbtelephoneFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lbtelephoneFournisseur.Location = New System.Drawing.Point(13, 115)
        Me.lbtelephoneFournisseur.Name = "lbtelephoneFournisseur"
        Me.lbtelephoneFournisseur.Size = New System.Drawing.Size(84, 17)
        Me.lbtelephoneFournisseur.TabIndex = 2
        Me.lbtelephoneFournisseur.Text = "Téléphone :"
        '
        'lbtelecopieurFournisseur
        '
        Me.lbtelecopieurFournisseur.AutoSize = True
        Me.lbtelecopieurFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lbtelecopieurFournisseur.Location = New System.Drawing.Point(13, 146)
        Me.lbtelecopieurFournisseur.Name = "lbtelecopieurFournisseur"
        Me.lbtelecopieurFournisseur.Size = New System.Drawing.Size(91, 17)
        Me.lbtelecopieurFournisseur.TabIndex = 3
        Me.lbtelecopieurFournisseur.Text = "Télécopieur :"
        '
        'Enregistrer_lbl
        '
        Me.Enregistrer_lbl.AutoSize = True
        Me.Enregistrer_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Enregistrer_lbl.Location = New System.Drawing.Point(12, 18)
        Me.Enregistrer_lbl.Name = "Enregistrer_lbl"
        Me.Enregistrer_lbl.Size = New System.Drawing.Size(217, 22)
        Me.Enregistrer_lbl.TabIndex = 6
        Me.Enregistrer_lbl.Text = "Enregistrer un fournisseur"
        '
        'TextBox_Nom
        '
        Me.TextBox_Nom.Location = New System.Drawing.Point(116, 54)
        Me.TextBox_Nom.Name = "TextBox_Nom"
        Me.TextBox_Nom.Size = New System.Drawing.Size(155, 20)
        Me.TextBox_Nom.TabIndex = 7
        '
        'TextBoxtelecopieur
        '
        Me.TextBoxtelecopieur.Location = New System.Drawing.Point(116, 143)
        Me.TextBoxtelecopieur.Name = "TextBoxtelecopieur"
        Me.TextBoxtelecopieur.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxtelecopieur.TabIndex = 8
        '
        'TextBoxTelephone
        '
        Me.TextBoxTelephone.Location = New System.Drawing.Point(116, 112)
        Me.TextBoxTelephone.Name = "TextBoxTelephone"
        Me.TextBoxTelephone.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxTelephone.TabIndex = 9
        '
        'TextBox_numéro
        '
        Me.TextBox_numéro.Location = New System.Drawing.Point(116, 83)
        Me.TextBox_numéro.Name = "TextBox_numéro"
        Me.TextBox_numéro.Size = New System.Drawing.Size(155, 20)
        Me.TextBox_numéro.TabIndex = 10
        '
        'Lb_adresseFournisseur
        '
        Me.Lb_adresseFournisseur.AutoSize = True
        Me.Lb_adresseFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_adresseFournisseur.Location = New System.Drawing.Point(13, 189)
        Me.Lb_adresseFournisseur.Name = "Lb_adresseFournisseur"
        Me.Lb_adresseFournisseur.Size = New System.Drawing.Size(56, 13)
        Me.Lb_adresseFournisseur.TabIndex = 11
        Me.Lb_adresseFournisseur.Text = "Adresse:"
        '
        'Lb_NoCiviqueFournisseur
        '
        Me.Lb_NoCiviqueFournisseur.AutoSize = True
        Me.Lb_NoCiviqueFournisseur.Location = New System.Drawing.Point(13, 217)
        Me.Lb_NoCiviqueFournisseur.Name = "Lb_NoCiviqueFournisseur"
        Me.Lb_NoCiviqueFournisseur.Size = New System.Drawing.Size(87, 13)
        Me.Lb_NoCiviqueFournisseur.TabIndex = 12
        Me.Lb_NoCiviqueFournisseur.Text = "Numéro civique :"
        '
        'Lb_rueFournisseur
        '
        Me.Lb_rueFournisseur.AutoSize = True
        Me.Lb_rueFournisseur.Location = New System.Drawing.Point(13, 247)
        Me.Lb_rueFournisseur.Name = "Lb_rueFournisseur"
        Me.Lb_rueFournisseur.Size = New System.Drawing.Size(67, 13)
        Me.Lb_rueFournisseur.TabIndex = 13
        Me.Lb_rueFournisseur.Text = "Code Postal:"
        '
        'TextBoxNuméroCivique
        '
        Me.TextBoxNuméroCivique.Location = New System.Drawing.Point(99, 210)
        Me.TextBoxNuméroCivique.Name = "TextBoxNuméroCivique"
        Me.TextBoxNuméroCivique.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxNuméroCivique.TabIndex = 14
        '
        'TextBoxCodePostal
        '
        Me.TextBoxCodePostal.Location = New System.Drawing.Point(99, 244)
        Me.TextBoxCodePostal.Name = "TextBoxCodePostal"
        Me.TextBoxCodePostal.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxCodePostal.TabIndex = 15
        '
        'Btn_enregistrerF
        '
        Me.Btn_enregistrerF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_enregistrerF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_enregistrerF.Location = New System.Drawing.Point(28, 310)
        Me.Btn_enregistrerF.Name = "Btn_enregistrerF"
        Me.Btn_enregistrerF.Size = New System.Drawing.Size(110, 30)
        Me.Btn_enregistrerF.TabIndex = 16
        Me.Btn_enregistrerF.Text = "Enregistrer"
        Me.Btn_enregistrerF.UseVisualStyleBackColor = True
        '
        'AnnulerFournisseur
        '
        Me.AnnulerFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AnnulerFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnulerFournisseur.Location = New System.Drawing.Point(208, 310)
        Me.AnnulerFournisseur.Name = "AnnulerFournisseur"
        Me.AnnulerFournisseur.Size = New System.Drawing.Size(110, 30)
        Me.AnnulerFournisseur.TabIndex = 17
        Me.AnnulerFournisseur.Text = "Annuler"
        Me.AnnulerFournisseur.UseVisualStyleBackColor = True
        '
        'CréerFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 373)
        Me.Controls.Add(Me.AnnulerFournisseur)
        Me.Controls.Add(Me.Btn_enregistrerF)
        Me.Controls.Add(Me.TextBoxCodePostal)
        Me.Controls.Add(Me.TextBoxNuméroCivique)
        Me.Controls.Add(Me.Lb_rueFournisseur)
        Me.Controls.Add(Me.Lb_NoCiviqueFournisseur)
        Me.Controls.Add(Me.Lb_adresseFournisseur)
        Me.Controls.Add(Me.TextBox_numéro)
        Me.Controls.Add(Me.TextBoxTelephone)
        Me.Controls.Add(Me.TextBoxtelecopieur)
        Me.Controls.Add(Me.TextBox_Nom)
        Me.Controls.Add(Me.Enregistrer_lbl)
        Me.Controls.Add(Me.lbtelecopieurFournisseur)
        Me.Controls.Add(Me.lbtelephoneFournisseur)
        Me.Controls.Add(Me.lbnumeroFournisseur)
        Me.Controls.Add(Me.lbnomFournisseur)
        Me.Name = "CréerFournisseur"
        Me.Text = "Créer Fournisseur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbnomFournisseur As Label
    Friend WithEvents lbnumeroFournisseur As Label
    Friend WithEvents lbtelephoneFournisseur As Label
    Friend WithEvents lbtelecopieurFournisseur As Label
    Friend WithEvents Enregistrer_lbl As Label
    Friend WithEvents TextBox_Nom As TextBox
    Friend WithEvents TextBoxtelecopieur As TextBox
    Friend WithEvents TextBoxTelephone As TextBox
    Friend WithEvents TextBox_numéro As TextBox
    Friend WithEvents Lb_adresseFournisseur As Label
    Friend WithEvents Lb_NoCiviqueFournisseur As Label
    Friend WithEvents Lb_rueFournisseur As Label
    Friend WithEvents TextBoxNuméroCivique As TextBox
    Friend WithEvents TextBoxCodePostal As TextBox
    Friend WithEvents Btn_enregistrerF As Button
    Friend WithEvents AnnulerFournisseur As Button
End Class
