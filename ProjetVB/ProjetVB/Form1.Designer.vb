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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.ContratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CréerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RenouvelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RésilierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ÉToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RéceptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LivraisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AnnulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.ServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuItem_Service = New System.Windows.Forms.ToolStripMenuItem()
		Me.FacturationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FacturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DaujourdhuiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AutresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PaiementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.TaxeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FournisseurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCréerFournisseur = New System.Windows.Forms.ToolStripMenuItem()
		Me.consulterFournisseur = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuModifierFournisseur = New System.Windows.Forms.ToolStripMenuItem()
		Me.RapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ÉquipementÀCommanderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.ContractsOuvertsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContractsRésiliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
		Me.PaiementParCarteCréditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PaiementParRetraitDirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SécuritéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AjoutModificationDestructionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ChangerLeMotDePasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
		Me.ListeDesUtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DéconnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SommaireDeLaideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AideSurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SupportTechniqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
		Me.FormationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
		Me.ÀProposSGARIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.MenuStrip1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratToolStripMenuItem, Me.ÉToolStripMenuItem, Me.ServiceToolStripMenuItem, Me.FacturationToolStripMenuItem, Me.FournisseurToolStripMenuItem, Me.RapportsToolStripMenuItem, Me.SécuritéToolStripMenuItem, Me.ToolStripMenuItem1})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
		Me.MenuStrip1.Size = New System.Drawing.Size(1899, 28)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'ContratToolStripMenuItem
		'
		Me.ContratToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréerToolStripMenuItem, Me.RenouvelerToolStripMenuItem, Me.RésilierToolStripMenuItem, Me.ToolStripSeparator3, Me.QuitterToolStripMenuItem})
		Me.ContratToolStripMenuItem.Name = "ContratToolStripMenuItem"
		Me.ContratToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
		Me.ContratToolStripMenuItem.Text = "Contrat"
		'
		'CréerToolStripMenuItem
		'
		Me.CréerToolStripMenuItem.Name = "CréerToolStripMenuItem"
		Me.CréerToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
		Me.CréerToolStripMenuItem.Text = "Créer"
		'
		'RenouvelerToolStripMenuItem
		'
		Me.RenouvelerToolStripMenuItem.Name = "RenouvelerToolStripMenuItem"
		Me.RenouvelerToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
		Me.RenouvelerToolStripMenuItem.Text = "Renouveler"
		'
		'RésilierToolStripMenuItem
		'
		Me.RésilierToolStripMenuItem.Name = "RésilierToolStripMenuItem"
		Me.RésilierToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
		Me.RésilierToolStripMenuItem.Text = "Résilier"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(155, 6)
		'
		'QuitterToolStripMenuItem
		'
		Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
		Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
		Me.QuitterToolStripMenuItem.Text = "Quitter"
		'
		'ÉToolStripMenuItem
		'
		Me.ÉToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RéceptionToolStripMenuItem, Me.LivraisonToolStripMenuItem, Me.ToolStripSeparator4})
		Me.ÉToolStripMenuItem.Name = "ÉToolStripMenuItem"
		Me.ÉToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
		Me.ÉToolStripMenuItem.Text = "Équipement"
		'
		'RéceptionToolStripMenuItem
		'
		Me.RéceptionToolStripMenuItem.Name = "RéceptionToolStripMenuItem"
		Me.RéceptionToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
		Me.RéceptionToolStripMenuItem.Text = "Réception"
		'
		'LivraisonToolStripMenuItem
		'
		Me.LivraisonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem, Me.AnnulerToolStripMenuItem})
		Me.LivraisonToolStripMenuItem.Name = "LivraisonToolStripMenuItem"
		Me.LivraisonToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
		Me.LivraisonToolStripMenuItem.Text = "Livraison"
		'
		'ModifierToolStripMenuItem
		'
		Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
		Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
		Me.ModifierToolStripMenuItem.Text = "Modifier"
		'
		'AnnulerToolStripMenuItem
		'
		Me.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem"
		Me.AnnulerToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
		Me.AnnulerToolStripMenuItem.Text = "Annuler"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(148, 6)
		'
		'ServiceToolStripMenuItem
		'
		Me.ServiceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_Service})
		Me.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
		Me.ServiceToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
		Me.ServiceToolStripMenuItem.Text = "Service"
		'
		'MenuItem_Service
		'
		Me.MenuItem_Service.Name = "MenuItem_Service"
		Me.MenuItem_Service.Size = New System.Drawing.Size(168, 26)
		Me.MenuItem_Service.Text = "MÀJ services"
		'
		'FacturationToolStripMenuItem
		'
		Me.FacturationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturesToolStripMenuItem, Me.PaiementToolStripMenuItem, Me.ToolStripSeparator1, Me.TaxeToolStripMenuItem})
		Me.FacturationToolStripMenuItem.Name = "FacturationToolStripMenuItem"
		Me.FacturationToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
		Me.FacturationToolStripMenuItem.Text = "Facturation"
		'
		'FacturesToolStripMenuItem
		'
		Me.FacturesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaujourdhuiToolStripMenuItem, Me.AutresToolStripMenuItem})
		Me.FacturesToolStripMenuItem.Name = "FacturesToolStripMenuItem"
		Me.FacturesToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
		Me.FacturesToolStripMenuItem.Text = "Factures"
		'
		'DaujourdhuiToolStripMenuItem
		'
		Me.DaujourdhuiToolStripMenuItem.Name = "DaujourdhuiToolStripMenuItem"
		Me.DaujourdhuiToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
		Me.DaujourdhuiToolStripMenuItem.Text = "d'aujourd'hui"
		'
		'AutresToolStripMenuItem
		'
		Me.AutresToolStripMenuItem.Name = "AutresToolStripMenuItem"
		Me.AutresToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
		Me.AutresToolStripMenuItem.Text = "Autres"
		'
		'PaiementToolStripMenuItem
		'
		Me.PaiementToolStripMenuItem.Name = "PaiementToolStripMenuItem"
		Me.PaiementToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
		Me.PaiementToolStripMenuItem.Text = "Paiement"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
		'
		'TaxeToolStripMenuItem
		'
		Me.TaxeToolStripMenuItem.Name = "TaxeToolStripMenuItem"
		Me.TaxeToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
		Me.TaxeToolStripMenuItem.Text = "Taxe"
		'
		'FournisseurToolStripMenuItem
		'
		Me.FournisseurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCréerFournisseur, Me.consulterFournisseur, Me.mnuModifierFournisseur})
		Me.FournisseurToolStripMenuItem.Name = "FournisseurToolStripMenuItem"
		Me.FournisseurToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
		Me.FournisseurToolStripMenuItem.Text = "Fournisseur"
		'
		'mnuCréerFournisseur
		'
		Me.mnuCréerFournisseur.Name = "mnuCréerFournisseur"
		Me.mnuCréerFournisseur.Size = New System.Drawing.Size(146, 26)
		Me.mnuCréerFournisseur.Text = "Créer"
		'
		'consulterFournisseur
		'
		Me.consulterFournisseur.Name = "consulterFournisseur"
		Me.consulterFournisseur.Size = New System.Drawing.Size(146, 26)
		Me.consulterFournisseur.Text = "Consulter"
		'
		'mnuModifierFournisseur
		'
		Me.mnuModifierFournisseur.Name = "mnuModifierFournisseur"
		Me.mnuModifierFournisseur.Size = New System.Drawing.Size(146, 26)
		Me.mnuModifierFournisseur.Text = "Modifier"
		'
		'RapportsToolStripMenuItem
		'
		Me.RapportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÉquipementÀCommanderToolStripMenuItem, Me.ToolStripSeparator6, Me.ContractsOuvertsToolStripMenuItem, Me.ContractsRésiliersToolStripMenuItem, Me.ToolStripSeparator8, Me.PaiementParCarteCréditToolStripMenuItem, Me.PaiementParRetraitDirectToolStripMenuItem})
		Me.RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
		Me.RapportsToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
		Me.RapportsToolStripMenuItem.Text = "Rapports"
		'
		'ÉquipementÀCommanderToolStripMenuItem
		'
		Me.ÉquipementÀCommanderToolStripMenuItem.Name = "ÉquipementÀCommanderToolStripMenuItem"
		Me.ÉquipementÀCommanderToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
		Me.ÉquipementÀCommanderToolStripMenuItem.Text = "Équipement"
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(254, 6)
		'
		'ContractsOuvertsToolStripMenuItem
		'
		Me.ContractsOuvertsToolStripMenuItem.Name = "ContractsOuvertsToolStripMenuItem"
		Me.ContractsOuvertsToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
		Me.ContractsOuvertsToolStripMenuItem.Text = "Contracts ouverts"
		'
		'ContractsRésiliersToolStripMenuItem
		'
		Me.ContractsRésiliersToolStripMenuItem.Name = "ContractsRésiliersToolStripMenuItem"
		Me.ContractsRésiliersToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
		Me.ContractsRésiliersToolStripMenuItem.Text = "Contracts résiliers"
		'
		'ToolStripSeparator8
		'
		Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
		Me.ToolStripSeparator8.Size = New System.Drawing.Size(254, 6)
		'
		'PaiementParCarteCréditToolStripMenuItem
		'
		Me.PaiementParCarteCréditToolStripMenuItem.Name = "PaiementParCarteCréditToolStripMenuItem"
		Me.PaiementParCarteCréditToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
		Me.PaiementParCarteCréditToolStripMenuItem.Text = "Paiement par carte crédit"
		'
		'PaiementParRetraitDirectToolStripMenuItem
		'
		Me.PaiementParRetraitDirectToolStripMenuItem.Name = "PaiementParRetraitDirectToolStripMenuItem"
		Me.PaiementParRetraitDirectToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
		Me.PaiementParRetraitDirectToolStripMenuItem.Text = "Paiement par retrait direct"
		'
		'SécuritéToolStripMenuItem
		'
		Me.SécuritéToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutModificationDestructionToolStripMenuItem, Me.ChangerLeMotDePasseToolStripMenuItem, Me.ToolStripSeparator10, Me.ListeDesUtilisateursToolStripMenuItem, Me.ToolStripSeparator2, Me.ConnectionToolStripMenuItem, Me.DéconnectionToolStripMenuItem})
		Me.SécuritéToolStripMenuItem.Name = "SécuritéToolStripMenuItem"
		Me.SécuritéToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
		Me.SécuritéToolStripMenuItem.Text = "Sécurité"
		'
		'AjoutModificationDestructionToolStripMenuItem
		'
		Me.AjoutModificationDestructionToolStripMenuItem.Name = "AjoutModificationDestructionToolStripMenuItem"
		Me.AjoutModificationDestructionToolStripMenuItem.Size = New System.Drawing.Size(309, 26)
		Me.AjoutModificationDestructionToolStripMenuItem.Text = "Ajout / Modification / Destruction"
		'
		'ChangerLeMotDePasseToolStripMenuItem
		'
		Me.ChangerLeMotDePasseToolStripMenuItem.Name = "ChangerLeMotDePasseToolStripMenuItem"
		Me.ChangerLeMotDePasseToolStripMenuItem.Size = New System.Drawing.Size(309, 26)
		Me.ChangerLeMotDePasseToolStripMenuItem.Text = "Changer le mot de passe"
		'
		'ToolStripSeparator10
		'
		Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
		Me.ToolStripSeparator10.Size = New System.Drawing.Size(306, 6)
		'
		'ListeDesUtilisateursToolStripMenuItem
		'
		Me.ListeDesUtilisateursToolStripMenuItem.Name = "ListeDesUtilisateursToolStripMenuItem"
		Me.ListeDesUtilisateursToolStripMenuItem.Size = New System.Drawing.Size(309, 26)
		Me.ListeDesUtilisateursToolStripMenuItem.Text = "Liste des utilisateurs"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(306, 6)
		'
		'ConnectionToolStripMenuItem
		'
		Me.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
		Me.ConnectionToolStripMenuItem.Size = New System.Drawing.Size(309, 26)
		Me.ConnectionToolStripMenuItem.Text = "Connection"
		'
		'DéconnectionToolStripMenuItem
		'
		Me.DéconnectionToolStripMenuItem.Name = "DéconnectionToolStripMenuItem"
		Me.DéconnectionToolStripMenuItem.Size = New System.Drawing.Size(309, 26)
		Me.DéconnectionToolStripMenuItem.Text = "Déconnection"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SommaireDeLaideToolStripMenuItem, Me.AideSurToolStripMenuItem, Me.SupportTechniqueToolStripMenuItem, Me.ToolStripSeparator11, Me.FormationToolStripMenuItem, Me.ToolStripSeparator12, Me.ÀProposSGARIToolStripMenuItem})
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 24)
		Me.ToolStripMenuItem1.Text = "?"
		'
		'SommaireDeLaideToolStripMenuItem
		'
		Me.SommaireDeLaideToolStripMenuItem.Name = "SommaireDeLaideToolStripMenuItem"
		Me.SommaireDeLaideToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
		Me.SommaireDeLaideToolStripMenuItem.Text = "Sommaire de l'aide"
		'
		'AideSurToolStripMenuItem
		'
		Me.AideSurToolStripMenuItem.Name = "AideSurToolStripMenuItem"
		Me.AideSurToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
		Me.AideSurToolStripMenuItem.Text = "Aide sur"
		'
		'SupportTechniqueToolStripMenuItem
		'
		Me.SupportTechniqueToolStripMenuItem.Name = "SupportTechniqueToolStripMenuItem"
		Me.SupportTechniqueToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
		Me.SupportTechniqueToolStripMenuItem.Text = "Support technique"
		'
		'ToolStripSeparator11
		'
		Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
		Me.ToolStripSeparator11.Size = New System.Drawing.Size(210, 6)
		'
		'FormationToolStripMenuItem
		'
		Me.FormationToolStripMenuItem.Name = "FormationToolStripMenuItem"
		Me.FormationToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
		Me.FormationToolStripMenuItem.Text = "Formation"
		'
		'ToolStripSeparator12
		'
		Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
		Me.ToolStripSeparator12.Size = New System.Drawing.Size(210, 6)
		'
		'ÀProposSGARIToolStripMenuItem
		'
		Me.ÀProposSGARIToolStripMenuItem.Name = "ÀProposSGARIToolStripMenuItem"
		Me.ÀProposSGARIToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
		Me.ÀProposSGARIToolStripMenuItem.Text = "À propos SGARI"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 807)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
		Me.StatusStrip1.Size = New System.Drawing.Size(1899, 25)
		Me.StatusStrip1.TabIndex = 3
		Me.StatusStrip1.Text = "TEst"
		'
		'ToolStripStatusLabel2
		'
		Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
		Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(147, 20)
		Me.ToolStripStatusLabel2.Text = "Utilisateur connecté :"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 20)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1899, 832)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.Text = "SGARI : ABONNET"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContratToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÉToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FournisseurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SécuritéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuItem_Service As ToolStripMenuItem
    Friend WithEvents FacturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaujourdhuiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaiementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaxeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CréerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenouvelerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RésilierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RéceptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnuCréerFournisseur As ToolStripMenuItem
    Friend WithEvents consulterFournisseur As ToolStripMenuItem
    Friend WithEvents mnuModifierFournisseur As ToolStripMenuItem
	Friend WithEvents ÉquipementÀCommanderToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
	Friend WithEvents ContractsOuvertsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ContractsRésiliersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
	Friend WithEvents PaiementParCarteCréditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PaiementParRetraitDirectToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AjoutModificationDestructionToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ChangerLeMotDePasseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ListeDesUtilisateursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SommaireDeLaideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideSurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupportTechniqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents FormationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ÀProposSGARIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents LivraisonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnnulerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DéconnectionToolStripMenuItem As ToolStripMenuItem
End Class
