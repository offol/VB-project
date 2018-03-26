<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturesScreen
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
        Me.DataGridView_Facture = New System.Windows.Forms.DataGridView()
        Me.Numéro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_facture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Paiement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.État = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant_Hors_Taxe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant_TVQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant_TPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant_Restant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_New_Facture = New System.Windows.Forms.Button()
        Me._Sauvegarder = New System.Windows.Forms.Button()
        Me.Button_Supprimer = New System.Windows.Forms.Button()
        Me.Button_Imprimer = New System.Windows.Forms.Button()
        Me.Button_calcFac_ht = New System.Windows.Forms.Button()
        Me.Button_calc_tvq = New System.Windows.Forms.Button()
        Me._calc_tps = New System.Windows.Forms.Button()
        Me.Button_calc_total = New System.Windows.Forms.Button()
        Me.GroupBox_option = New System.Windows.Forms.GroupBox()
        Me.Button_SuppLigne = New System.Windows.Forms.Button()
        Me.Button_NewLigneFac = New System.Windows.Forms.Button()
        Me.GrouBox_calcul = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_LigneFacture = New System.Windows.Forms.DataGridView()
        Me.Numéro_Facture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numéro_Ligne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix_Unitaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix_Hors_Taxe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_CalcLigneHT = New System.Windows.Forms.Button()
        CType(Me.DataGridView_Facture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_option.SuspendLayout()
        Me.GrouBox_calcul.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_LigneFacture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_Facture
        '
        Me.DataGridView_Facture.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView_Facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Facture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numéro, Me.Date_facture, Me.Date_Paiement, Me.État, Me.Montant_Hors_Taxe, Me.Montant_TVQ, Me.Montant_TPS, Me.Total, Me.Montant_Restant})
        Me.DataGridView_Facture.Location = New System.Drawing.Point(6, 18)
        Me.DataGridView_Facture.MultiSelect = False
        Me.DataGridView_Facture.Name = "DataGridView_Facture"
        Me.DataGridView_Facture.RowHeadersVisible = False
        Me.DataGridView_Facture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Facture.Size = New System.Drawing.Size(805, 187)
        Me.DataGridView_Facture.TabIndex = 1
        '
        'Numéro
        '
        Me.Numéro.DataPropertyName = "Numéro"
        Me.Numéro.HeaderText = "Numéro"
        Me.Numéro.Name = "Numéro"
        Me.Numéro.ReadOnly = True
        '
        'Date_facture
        '
        Me.Date_facture.DataPropertyName = "Date_Facture"
        Me.Date_facture.HeaderText = "Date_Facture"
        Me.Date_facture.Name = "Date_facture"
        Me.Date_facture.ReadOnly = True
        '
        'Date_Paiement
        '
        Me.Date_Paiement.DataPropertyName = "Date_Paiement"
        Me.Date_Paiement.HeaderText = "Date_Paiement"
        Me.Date_Paiement.Name = "Date_Paiement"
        '
        'État
        '
        Me.État.DataPropertyName = "État"
        Me.État.HeaderText = "État"
        Me.État.Name = "État"
        Me.État.ReadOnly = True
        '
        'Montant_Hors_Taxe
        '
        Me.Montant_Hors_Taxe.DataPropertyName = "Montant_Hors_Taxe"
        Me.Montant_Hors_Taxe.HeaderText = "Montant_Hors_Taxe"
        Me.Montant_Hors_Taxe.Name = "Montant_Hors_Taxe"
        '
        'Montant_TVQ
        '
        Me.Montant_TVQ.DataPropertyName = "Montant_TVQ"
        Me.Montant_TVQ.HeaderText = "Montant_TVQ"
        Me.Montant_TVQ.Name = "Montant_TVQ"
        Me.Montant_TVQ.ReadOnly = True
        '
        'Montant_TPS
        '
        Me.Montant_TPS.DataPropertyName = "Montant_TPS"
        Me.Montant_TPS.HeaderText = "Montant_TPS"
        Me.Montant_TPS.Name = "Montant_TPS"
        Me.Montant_TPS.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Montant_Restant
        '
        Me.Montant_Restant.DataPropertyName = "Montant_Restant"
        Me.Montant_Restant.HeaderText = "Montant_Restant"
        Me.Montant_Restant.Name = "Montant_Restant"
        '
        'Button_New_Facture
        '
        Me.Button_New_Facture.Location = New System.Drawing.Point(6, 19)
        Me.Button_New_Facture.Name = "Button_New_Facture"
        Me.Button_New_Facture.Size = New System.Drawing.Size(118, 23)
        Me.Button_New_Facture.TabIndex = 2
        Me.Button_New_Facture.Text = "Nouvelle Facture"
        Me.Button_New_Facture.UseVisualStyleBackColor = True
        '
        '_Sauvegarder
        '
        Me._Sauvegarder.Location = New System.Drawing.Point(130, 103)
        Me._Sauvegarder.Name = "_Sauvegarder"
        Me._Sauvegarder.Size = New System.Drawing.Size(110, 23)
        Me._Sauvegarder.TabIndex = 3
        Me._Sauvegarder.Text = "Sauvegarder"
        Me._Sauvegarder.UseVisualStyleBackColor = True
        '
        'Button_Supprimer
        '
        Me.Button_Supprimer.Location = New System.Drawing.Point(6, 61)
        Me.Button_Supprimer.Name = "Button_Supprimer"
        Me.Button_Supprimer.Size = New System.Drawing.Size(118, 23)
        Me.Button_Supprimer.TabIndex = 4
        Me.Button_Supprimer.Text = "Supprimer Facture"
        Me.Button_Supprimer.UseVisualStyleBackColor = True
        '
        'Button_Imprimer
        '
        Me.Button_Imprimer.Location = New System.Drawing.Point(6, 103)
        Me.Button_Imprimer.Name = "Button_Imprimer"
        Me.Button_Imprimer.Size = New System.Drawing.Size(118, 23)
        Me.Button_Imprimer.TabIndex = 5
        Me.Button_Imprimer.Text = "Imprimer"
        Me.Button_Imprimer.UseVisualStyleBackColor = True
        '
        'Button_calcFac_ht
        '
        Me.Button_calcFac_ht.Location = New System.Drawing.Point(6, 17)
        Me.Button_calcFac_ht.Name = "Button_calcFac_ht"
        Me.Button_calcFac_ht.Size = New System.Drawing.Size(153, 23)
        Me.Button_calcFac_ht.TabIndex = 6
        Me.Button_calcFac_ht.Text = "Calculer montant ht Facture"
        Me.Button_calcFac_ht.UseVisualStyleBackColor = True
        '
        'Button_calc_tvq
        '
        Me.Button_calc_tvq.Location = New System.Drawing.Point(6, 60)
        Me.Button_calc_tvq.Name = "Button_calc_tvq"
        Me.Button_calc_tvq.Size = New System.Drawing.Size(75, 23)
        Me.Button_calc_tvq.TabIndex = 7
        Me.Button_calc_tvq.Text = "Calculer tvq"
        Me.Button_calc_tvq.UseVisualStyleBackColor = True
        '
        '_calc_tps
        '
        Me._calc_tps.Location = New System.Drawing.Point(87, 60)
        Me._calc_tps.Name = "_calc_tps"
        Me._calc_tps.Size = New System.Drawing.Size(75, 23)
        Me._calc_tps.TabIndex = 8
        Me._calc_tps.Text = "Calculer tps"
        Me._calc_tps.UseVisualStyleBackColor = True
        '
        'Button_calc_total
        '
        Me.Button_calc_total.Location = New System.Drawing.Point(6, 102)
        Me.Button_calc_total.Name = "Button_calc_total"
        Me.Button_calc_total.Size = New System.Drawing.Size(153, 23)
        Me.Button_calc_total.TabIndex = 9
        Me.Button_calc_total.Text = "Calculer montant total"
        Me.Button_calc_total.UseVisualStyleBackColor = True
        '
        'GroupBox_option
        '
        Me.GroupBox_option.Controls.Add(Me.Button_SuppLigne)
        Me.GroupBox_option.Controls.Add(Me.Button_NewLigneFac)
        Me.GroupBox_option.Controls.Add(Me._Sauvegarder)
        Me.GroupBox_option.Controls.Add(Me.Button_New_Facture)
        Me.GroupBox_option.Controls.Add(Me.Button_Supprimer)
        Me.GroupBox_option.Controls.Add(Me.Button_Imprimer)
        Me.GroupBox_option.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_option.Name = "GroupBox_option"
        Me.GroupBox_option.Size = New System.Drawing.Size(247, 132)
        Me.GroupBox_option.TabIndex = 10
        Me.GroupBox_option.TabStop = False
        Me.GroupBox_option.Text = "Option"
        '
        'Button_SuppLigne
        '
        Me.Button_SuppLigne.Location = New System.Drawing.Point(131, 61)
        Me.Button_SuppLigne.Name = "Button_SuppLigne"
        Me.Button_SuppLigne.Size = New System.Drawing.Size(109, 23)
        Me.Button_SuppLigne.TabIndex = 7
        Me.Button_SuppLigne.Text = "Supprimer Ligne"
        Me.Button_SuppLigne.UseVisualStyleBackColor = True
        '
        'Button_NewLigneFac
        '
        Me.Button_NewLigneFac.Location = New System.Drawing.Point(131, 18)
        Me.Button_NewLigneFac.Name = "Button_NewLigneFac"
        Me.Button_NewLigneFac.Size = New System.Drawing.Size(110, 23)
        Me.Button_NewLigneFac.TabIndex = 6
        Me.Button_NewLigneFac.Text = "Nouvelle Ligne"
        Me.Button_NewLigneFac.UseVisualStyleBackColor = True
        '
        'GrouBox_calcul
        '
        Me.GrouBox_calcul.Controls.Add(Me.Button_calc_total)
        Me.GrouBox_calcul.Controls.Add(Me.Button_calcFac_ht)
        Me.GrouBox_calcul.Controls.Add(Me._calc_tps)
        Me.GrouBox_calcul.Controls.Add(Me.Button_calc_tvq)
        Me.GrouBox_calcul.Location = New System.Drawing.Point(265, 13)
        Me.GrouBox_calcul.Name = "GrouBox_calcul"
        Me.GrouBox_calcul.Size = New System.Drawing.Size(172, 132)
        Me.GrouBox_calcul.TabIndex = 11
        Me.GrouBox_calcul.TabStop = False
        Me.GrouBox_calcul.Text = "Calcule Facture"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView_Facture)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 211)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facture"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView_LigneFacture)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 204)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Détail de la facture"
        '
        'DataGridView_LigneFacture
        '
        Me.DataGridView_LigneFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LigneFacture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numéro_Facture, Me.Numéro_Ligne, Me.Description, Me.Quantité, Me.Prix_Unitaire, Me.Prix_Hors_Taxe})
        Me.DataGridView_LigneFacture.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView_LigneFacture.MultiSelect = False
        Me.DataGridView_LigneFacture.Name = "DataGridView_LigneFacture"
        Me.DataGridView_LigneFacture.RowHeadersVisible = False
        Me.DataGridView_LigneFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_LigneFacture.Size = New System.Drawing.Size(659, 178)
        Me.DataGridView_LigneFacture.TabIndex = 0
        '
        'Numéro_Facture
        '
        Me.Numéro_Facture.DataPropertyName = "Numéro_Facture"
        Me.Numéro_Facture.HeaderText = "Numéro_Facture"
        Me.Numéro_Facture.Name = "Numéro_Facture"
        Me.Numéro_Facture.ReadOnly = True
        '
        'Numéro_Ligne
        '
        Me.Numéro_Ligne.DataPropertyName = "Numéro_Ligne"
        Me.Numéro_Ligne.HeaderText = "Numéro_Ligne"
        Me.Numéro_Ligne.Name = "Numéro_Ligne"
        Me.Numéro_Ligne.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Quantité
        '
        Me.Quantité.DataPropertyName = "Quantité"
        Me.Quantité.HeaderText = "Quantité"
        Me.Quantité.Name = "Quantité"
        '
        'Prix_Unitaire
        '
        Me.Prix_Unitaire.DataPropertyName = "Prix_Unitaire"
        Me.Prix_Unitaire.HeaderText = "Prix_Unitaire"
        Me.Prix_Unitaire.Name = "Prix_Unitaire"
        Me.Prix_Unitaire.ReadOnly = True
        '
        'Prix_Hors_Taxe
        '
        Me.Prix_Hors_Taxe.DataPropertyName = "Prix_Hors_Taxe"
        Me.Prix_Hors_Taxe.HeaderText = "Prix_Hors_Taxe"
        Me.Prix_Hors_Taxe.Name = "Prix_Hors_Taxe"
        Me.Prix_Hors_Taxe.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_CalcLigneHT)
        Me.GroupBox3.Location = New System.Drawing.Point(444, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calcule Ligne"
        '
        'Button_CalcLigneHT
        '
        Me.Button_CalcLigneHT.Location = New System.Drawing.Point(6, 17)
        Me.Button_CalcLigneHT.Name = "Button_CalcLigneHT"
        Me.Button_CalcLigneHT.Size = New System.Drawing.Size(121, 23)
        Me.Button_CalcLigneHT.TabIndex = 0
        Me.Button_CalcLigneHT.Text = "Calculer prix hors-taxe"
        Me.Button_CalcLigneHT.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_CalcLigneHT.UseVisualStyleBackColor = True
        '
        'FacturesScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 619)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrouBox_calcul)
        Me.Controls.Add(Me.GroupBox_option)
        Me.Name = "FacturesScreen"
        Me.Text = "Factures"
        CType(Me.DataGridView_Facture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_option.ResumeLayout(False)
        Me.GrouBox_calcul.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_LigneFacture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_New_Facture As Button
    Friend WithEvents _Sauvegarder As Button
    Friend WithEvents Button_Supprimer As Button
    Friend WithEvents Button_Imprimer As Button
    Friend WithEvents Button_calcFac_ht As Button
    Friend WithEvents Button_calc_tvq As Button
    Friend WithEvents _calc_tps As Button
    Friend WithEvents Button_calc_total As Button
    Friend WithEvents GroupBox_option As GroupBox
    Friend WithEvents GrouBox_calcul As GroupBox
    Friend WithEvents DataGridView_Facture As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView_LigneFacture As DataGridView
    Friend WithEvents Button_NewLigneFac As Button
    Friend WithEvents Button_SuppLigne As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button_CalcLigneHT As Button
    Friend WithEvents Numéro_Facture As DataGridViewTextBoxColumn
    Friend WithEvents Numéro_Ligne As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Prix_Unitaire As DataGridViewTextBoxColumn
    Friend WithEvents Prix_Hors_Taxe As DataGridViewTextBoxColumn
    Friend WithEvents Numéro As DataGridViewTextBoxColumn
    Friend WithEvents Date_facture As DataGridViewTextBoxColumn
    Friend WithEvents Date_Paiement As DataGridViewTextBoxColumn
    Friend WithEvents État As DataGridViewTextBoxColumn
    Friend WithEvents Montant_Hors_Taxe As DataGridViewTextBoxColumn
    Friend WithEvents Montant_TVQ As DataGridViewTextBoxColumn
    Friend WithEvents Montant_TPS As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Montant_Restant As DataGridViewTextBoxColumn
End Class
