<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formation
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
        Me.Ordi1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Ordi1
        '
        Me.Ordi1.BackColor = System.Drawing.Color.Gainsboro
        Me.Ordi1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ordi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ordi1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Ordi1.FormattingEnabled = True
        Me.Ordi1.ItemHeight = 12
        Me.Ordi1.Items.AddRange(New Object() {"Contrat :", "-Prise de commande", "-Créer date de début et date de fin du contrat", "-Recherche client existant", "-Création nouveau client", "-Ajout et retrait de service", "-Ajout et retrait d’équipement", "-Sélectionner équipement et type de location", "-Mise en service", "-Planifier livraison", "-Compléter et imprimer le contrat", "-Renouveler un contrat", "-Modifier service et équipement lors du renouvellement", "-Résilier un contrat", "", "Équipement :", "-Réception d’équipement en location", "-Validation d’équipement retourné", "-Annulation et modification livraison", "", "Mise à jour des Services :", "-Créer nouveau service", "-Modifier service", "-Supprimer Service", "", "Facturation:", "-Consulter facturation d’aujourd’hui et autre", "-Créer ou supprimer de facture", "-Calculer prix avec et sans taxe", "-Détails de la facture", "-Procéder au paiement de facture", "-Voir paiement effectué", "-Choisir mode de paiement", "-Montant à payer", "-Calculer Taxe", "", "Fournisseur :", "-Créer fournisseur", "-Modifier fournisseur", "-Consulter fournisseur", "", " Rapports :", "-Achèvement de contrat", "-Équipement à commander et retourner", "-Contrat ouvert", "-Type de paiement", "-Client continentaux", "", "Sécurité:", "-Ajout, modification et destruction d’utilisateur", "-Changer mot de passe", "-Consulter la liste des utilisateurs", "-Connection et déconnection de l’interface"})
        Me.Ordi1.Location = New System.Drawing.Point(14, 27)
        Me.Ordi1.Margin = New System.Windows.Forms.Padding(5)
        Me.Ordi1.Name = "Ordi1"
        Me.Ordi1.Size = New System.Drawing.Size(358, 636)
        Me.Ordi1.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Formation sur différentes pages de l'interface"
        '
        'Formation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 673)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ordi1)
        Me.Name = "Formation"
        Me.Text = "Formation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ordi1 As ListBox
    Friend WithEvents Label1 As Label
End Class
