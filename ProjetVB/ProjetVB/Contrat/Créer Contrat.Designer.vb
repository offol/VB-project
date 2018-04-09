<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Créer_Contrat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.GroupBox1_ClientActuel = New System.Windows.Forms.GroupBox()
		Me.btnConsulte = New System.Windows.Forms.Button()
		Me.Btn_recherheClient = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox7 = New System.Windows.Forms.TextBox()
		Me.Lb_tel = New System.Windows.Forms.Label()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Lb_rue = New System.Windows.Forms.Label()
		Me.Lb_NoCivique = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Lb_adresse = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.CheckBox_Entreprise = New System.Windows.Forms.CheckBox()
		Me.CheckBox_pariculier = New System.Windows.Forms.CheckBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Lb_prenom = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Lb_NoClient = New System.Windows.Forms.Label()
		Me.GroupBox1_Contrat = New System.Windows.Forms.GroupBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Btn_supprimer = New System.Windows.Forms.Button()
		Me.btnComplete = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridView_LignesEquipement = New System.Windows.Forms.DataGridView()
		Me.Numéro_Équiement = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Prix_Unitaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnService = New System.Windows.Forms.Button()
		Me.btnEquipement = New System.Windows.Forms.Button()
		Me.NumContrat = New System.Windows.Forms.TextBox()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Lb_DateResi = New System.Windows.Forms.Label()
		Me.Lb_DateOuv = New System.Windows.Forms.Label()
		Me.Lb_NoContrat = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btn_cliCommercial = New System.Windows.Forms.Button()
		Me.btn_cliParticulier = New System.Windows.Forms.Button()
		Me.Lb_ajoutClient = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.EquipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ValidationéquipementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.GroupBox1_ClientActuel.SuspendLayout()
		Me.GroupBox1_Contrat.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView_LignesEquipement, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.EquipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ValidationéquipementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1_ClientActuel
		'
		Me.GroupBox1_ClientActuel.Controls.Add(Me.btnConsulte)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Btn_recherheClient)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Label3)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox7)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_tel)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox5)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_rue)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_NoCivique)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox4)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_adresse)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox3)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Label1)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.CheckBox_Entreprise)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.CheckBox_pariculier)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox2)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_prenom)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox1)
		Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_NoClient)
		Me.GroupBox1_ClientActuel.Location = New System.Drawing.Point(0, 60)
		Me.GroupBox1_ClientActuel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1_ClientActuel.Name = "GroupBox1_ClientActuel"
		Me.GroupBox1_ClientActuel.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1_ClientActuel.Size = New System.Drawing.Size(768, 203)
		Me.GroupBox1_ClientActuel.TabIndex = 12
		Me.GroupBox1_ClientActuel.TabStop = False
		'
		'btnConsulte
		'
		Me.btnConsulte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnConsulte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnConsulte.Location = New System.Drawing.Point(601, 156)
		Me.btnConsulte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnConsulte.Name = "btnConsulte"
		Me.btnConsulte.Size = New System.Drawing.Size(147, 37)
		Me.btnConsulte.TabIndex = 16
		Me.btnConsulte.Text = "Consulter"
		Me.btnConsulte.UseVisualStyleBackColor = True
		'
		'Btn_recherheClient
		'
		Me.Btn_recherheClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.Btn_recherheClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Btn_recherheClient.Location = New System.Drawing.Point(447, 156)
		Me.Btn_recherheClient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Btn_recherheClient.Name = "Btn_recherheClient"
		Me.Btn_recherheClient.Size = New System.Drawing.Size(147, 37)
		Me.Btn_recherheClient.TabIndex = 13
		Me.Btn_recherheClient.Text = "Recherche"
		Me.Btn_recherheClient.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(8, 20)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(132, 20)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Client Existant"
		'
		'TextBox7
		'
		Me.TextBox7.Location = New System.Drawing.Point(532, 97)
		Me.TextBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox7.Name = "TextBox7"
		Me.TextBox7.Size = New System.Drawing.Size(132, 22)
		Me.TextBox7.TabIndex = 15
		'
		'Lb_tel
		'
		Me.Lb_tel.AutoSize = True
		Me.Lb_tel.Location = New System.Drawing.Point(443, 101)
		Me.Lb_tel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_tel.Name = "Lb_tel"
		Me.Lb_tel.Size = New System.Drawing.Size(80, 17)
		Me.Lb_tel.TabIndex = 14
		Me.Lb_tel.Text = "Téléphone:"
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(316, 169)
		Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(91, 22)
		Me.TextBox5.TabIndex = 12
		'
		'Lb_rue
		'
		Me.Lb_rue.AutoSize = True
		Me.Lb_rue.Location = New System.Drawing.Point(219, 172)
		Me.Lb_rue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_rue.Name = "Lb_rue"
		Me.Lb_rue.Size = New System.Drawing.Size(88, 17)
		Me.Lb_rue.TabIndex = 11
		Me.Lb_rue.Text = "Code Postal:"
		'
		'Lb_NoCivique
		'
		Me.Lb_NoCivique.AutoSize = True
		Me.Lb_NoCivique.Location = New System.Drawing.Point(15, 172)
		Me.Lb_NoCivique.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_NoCivique.Name = "Lb_NoCivique"
		Me.Lb_NoCivique.Size = New System.Drawing.Size(110, 17)
		Me.Lb_NoCivique.TabIndex = 10
		Me.Lb_NoCivique.Text = "Numéro civique:"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(135, 169)
		Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(63, 22)
		Me.TextBox4.TabIndex = 9
		'
		'Lb_adresse
		'
		Me.Lb_adresse.AutoSize = True
		Me.Lb_adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lb_adresse.Location = New System.Drawing.Point(15, 139)
		Me.Lb_adresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_adresse.Name = "Lb_adresse"
		Me.Lb_adresse.Size = New System.Drawing.Size(72, 17)
		Me.Lb_adresse.TabIndex = 8
		Me.Lb_adresse.Text = "Adresse:"
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(65, 97)
		Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(132, 22)
		Me.TextBox3.TabIndex = 7
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(15, 101)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Nom:"
		'
		'CheckBox_Entreprise
		'
		Me.CheckBox_Entreprise.AutoSize = True
		Me.CheckBox_Entreprise.Location = New System.Drawing.Point(447, 55)
		Me.CheckBox_Entreprise.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CheckBox_Entreprise.Name = "CheckBox_Entreprise"
		Me.CheckBox_Entreprise.Size = New System.Drawing.Size(95, 21)
		Me.CheckBox_Entreprise.TabIndex = 5
		Me.CheckBox_Entreprise.Text = "Entreprise"
		Me.CheckBox_Entreprise.UseVisualStyleBackColor = True
		'
		'CheckBox_pariculier
		'
		Me.CheckBox_pariculier.AutoSize = True
		Me.CheckBox_pariculier.Location = New System.Drawing.Point(325, 59)
		Me.CheckBox_pariculier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CheckBox_pariculier.Name = "CheckBox_pariculier"
		Me.CheckBox_pariculier.Size = New System.Drawing.Size(93, 21)
		Me.CheckBox_pariculier.TabIndex = 4
		Me.CheckBox_pariculier.Text = "Particulier"
		Me.CheckBox_pariculier.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(288, 97)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(132, 22)
		Me.TextBox2.TabIndex = 3
		'
		'Lb_prenom
		'
		Me.Lb_prenom.AutoSize = True
		Me.Lb_prenom.Location = New System.Drawing.Point(219, 101)
		Me.Lb_prenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_prenom.Name = "Lb_prenom"
		Me.Lb_prenom.Size = New System.Drawing.Size(61, 17)
		Me.Lb_prenom.TabIndex = 2
		Me.Lb_prenom.Text = "Prenom:"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(117, 57)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(132, 22)
		Me.TextBox1.TabIndex = 1
		'
		'Lb_NoClient
		'
		Me.Lb_NoClient.AutoSize = True
		Me.Lb_NoClient.Location = New System.Drawing.Point(12, 60)
		Me.Lb_NoClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_NoClient.Name = "Lb_NoClient"
		Me.Lb_NoClient.Size = New System.Drawing.Size(101, 17)
		Me.Lb_NoClient.TabIndex = 0
		Me.Lb_NoClient.Text = "Numéro Client:"
		'
		'GroupBox1_Contrat
		'
		Me.GroupBox1_Contrat.Controls.Add(Me.Button2)
		Me.GroupBox1_Contrat.Controls.Add(Me.Button1)
		Me.GroupBox1_Contrat.Controls.Add(Me.Btn_supprimer)
		Me.GroupBox1_Contrat.Controls.Add(Me.btnComplete)
		Me.GroupBox1_Contrat.Controls.Add(Me.DataGridView1)
		Me.GroupBox1_Contrat.Controls.Add(Me.DataGridView_LignesEquipement)
		Me.GroupBox1_Contrat.Controls.Add(Me.btnService)
		Me.GroupBox1_Contrat.Controls.Add(Me.btnEquipement)
		Me.GroupBox1_Contrat.Controls.Add(Me.NumContrat)
		Me.GroupBox1_Contrat.Controls.Add(Me.DateTimePicker2)
		Me.GroupBox1_Contrat.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox1_Contrat.Controls.Add(Me.Lb_DateResi)
		Me.GroupBox1_Contrat.Controls.Add(Me.Lb_DateOuv)
		Me.GroupBox1_Contrat.Controls.Add(Me.Lb_NoContrat)
		Me.GroupBox1_Contrat.Location = New System.Drawing.Point(16, 277)
		Me.GroupBox1_Contrat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1_Contrat.Name = "GroupBox1_Contrat"
		Me.GroupBox1_Contrat.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1_Contrat.Size = New System.Drawing.Size(768, 699)
		Me.GroupBox1_Contrat.TabIndex = 13
		Me.GroupBox1_Contrat.TabStop = False
		Me.GroupBox1_Contrat.Text = "Contrat"
		'
		'Button2
		'
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(12, 644)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(172, 37)
		Me.Button2.TabIndex = 27
		Me.Button2.Text = "Mise en service"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(673, 577)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(79, 27)
		Me.Button1.TabIndex = 26
		Me.Button1.Text = "Supprimer"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Btn_supprimer
		'
		Me.Btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Btn_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Btn_supprimer.Location = New System.Drawing.Point(673, 300)
		Me.Btn_supprimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Btn_supprimer.Name = "Btn_supprimer"
		Me.Btn_supprimer.Size = New System.Drawing.Size(79, 27)
		Me.Btn_supprimer.TabIndex = 25
		Me.Btn_supprimer.Text = "Supprimer"
		Me.Btn_supprimer.UseVisualStyleBackColor = True
		'
		'btnComplete
		'
		Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnComplete.Location = New System.Drawing.Point(605, 644)
		Me.btnComplete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnComplete.Name = "btnComplete"
		Me.btnComplete.Size = New System.Drawing.Size(147, 37)
		Me.btnComplete.TabIndex = 17
		Me.btnComplete.Text = "Compléter"
		Me.btnComplete.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
		Me.DataGridView1.Location = New System.Drawing.Point(12, 386)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(653, 218)
		Me.DataGridView1.TabIndex = 24
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "Numéro de service"
		Me.DataGridViewTextBoxColumn1.HeaderText = "Numéro de service"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "Type"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
		Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantité"
		Me.DataGridViewTextBoxColumn4.HeaderText = "Quantité"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "Prix_Unitaire"
		Me.DataGridViewTextBoxColumn5.HeaderText = "Prix Unitaire"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		Me.DataGridViewTextBoxColumn5.ReadOnly = True
		'
		'DataGridView_LignesEquipement
		'
		Me.DataGridView_LignesEquipement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView_LignesEquipement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numéro_Équiement, Me.Location, Me.Type, Me.Quantité, Me.Prix_Unitaire})
		Me.DataGridView_LignesEquipement.Location = New System.Drawing.Point(12, 110)
		Me.DataGridView_LignesEquipement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.DataGridView_LignesEquipement.MultiSelect = False
		Me.DataGridView_LignesEquipement.Name = "DataGridView_LignesEquipement"
		Me.DataGridView_LignesEquipement.RowHeadersVisible = False
		Me.DataGridView_LignesEquipement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView_LignesEquipement.Size = New System.Drawing.Size(653, 218)
		Me.DataGridView_LignesEquipement.TabIndex = 23
		'
		'Numéro_Équiement
		'
		Me.Numéro_Équiement.DataPropertyName = "NumEquip"
		Me.Numéro_Équiement.HeaderText = "Numéro d'équipement"
		Me.Numéro_Équiement.Name = "Numéro_Équiement"
		Me.Numéro_Équiement.ReadOnly = True
		'
		'Location
		'
		Me.Location.DataPropertyName = "Location"
		Me.Location.HeaderText = "Location"
		Me.Location.Name = "Location"
		'
		'Type
		'
		Me.Type.DataPropertyName = "Type"
		Me.Type.HeaderText = "Type"
		Me.Type.Name = "Type"
		Me.Type.ReadOnly = True
		'
		'Quantité
		'
		Me.Quantité.DataPropertyName = "Quantity"
		Me.Quantité.HeaderText = "Quantité"
		Me.Quantité.Name = "Quantité"
		'
		'Prix_Unitaire
		'
		Me.Prix_Unitaire.DataPropertyName = "Price"
		Me.Prix_Unitaire.HeaderText = "Prix Unitaire"
		Me.Prix_Unitaire.Name = "Prix_Unitaire"
		Me.Prix_Unitaire.ReadOnly = True
		'
		'btnService
		'
		Me.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnService.Location = New System.Drawing.Point(12, 351)
		Me.btnService.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnService.Name = "btnService"
		Me.btnService.Size = New System.Drawing.Size(100, 28)
		Me.btnService.TabIndex = 20
		Me.btnService.Text = "Services"
		Me.btnService.UseVisualStyleBackColor = True
		'
		'btnEquipement
		'
		Me.btnEquipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEquipement.Location = New System.Drawing.Point(12, 74)
		Me.btnEquipement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnEquipement.Name = "btnEquipement"
		Me.btnEquipement.Size = New System.Drawing.Size(100, 28)
		Me.btnEquipement.TabIndex = 13
		Me.btnEquipement.Text = "Équipement"
		Me.btnEquipement.UseVisualStyleBackColor = True
		'
		'NumContrat
		'
		Me.NumContrat.Location = New System.Drawing.Point(117, 27)
		Me.NumContrat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.NumContrat.Name = "NumContrat"
		Me.NumContrat.Size = New System.Drawing.Size(144, 22)
		Me.NumContrat.TabIndex = 18
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Location = New System.Drawing.Point(596, 59)
		Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(137, 22)
		Me.DateTimePicker2.TabIndex = 18
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(596, 27)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(151, 22)
		Me.DateTimePicker1.TabIndex = 17
		'
		'Lb_DateResi
		'
		Me.Lb_DateResi.AutoSize = True
		Me.Lb_DateResi.Location = New System.Drawing.Point(443, 66)
		Me.Lb_DateResi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_DateResi.Name = "Lb_DateResi"
		Me.Lb_DateResi.Size = New System.Drawing.Size(131, 17)
		Me.Lb_DateResi.TabIndex = 16
		Me.Lb_DateResi.Text = "Date de Résiliation:"
		'
		'Lb_DateOuv
		'
		Me.Lb_DateOuv.AutoSize = True
		Me.Lb_DateOuv.Location = New System.Drawing.Point(443, 31)
		Me.Lb_DateOuv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_DateOuv.Name = "Lb_DateOuv"
		Me.Lb_DateOuv.Size = New System.Drawing.Size(118, 17)
		Me.Lb_DateOuv.TabIndex = 15
		Me.Lb_DateOuv.Text = "Date d'ouverture:"
		'
		'Lb_NoContrat
		'
		Me.Lb_NoContrat.AutoSize = True
		Me.Lb_NoContrat.Location = New System.Drawing.Point(8, 31)
		Me.Lb_NoContrat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_NoContrat.Name = "Lb_NoContrat"
		Me.Lb_NoContrat.Size = New System.Drawing.Size(112, 17)
		Me.Lb_NoContrat.TabIndex = 14
		Me.Lb_NoContrat.Text = "Numero Contrat:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btn_cliCommercial)
		Me.GroupBox1.Controls.Add(Me.btn_cliParticulier)
		Me.GroupBox1.Controls.Add(Me.GroupBox1_ClientActuel)
		Me.GroupBox1.Controls.Add(Me.Lb_ajoutClient)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Location = New System.Drawing.Point(16, 6)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(768, 263)
		Me.GroupBox1.TabIndex = 14
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Client"
		'
		'btn_cliCommercial
		'
		Me.btn_cliCommercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btn_cliCommercial.Location = New System.Drawing.Point(316, 25)
		Me.btn_cliCommercial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btn_cliCommercial.Name = "btn_cliCommercial"
		Me.btn_cliCommercial.Size = New System.Drawing.Size(100, 28)
		Me.btn_cliCommercial.TabIndex = 4
		Me.btn_cliCommercial.Text = "Commercial"
		Me.btn_cliCommercial.UseVisualStyleBackColor = True
		'
		'btn_cliParticulier
		'
		Me.btn_cliParticulier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btn_cliParticulier.Location = New System.Drawing.Point(188, 25)
		Me.btn_cliParticulier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btn_cliParticulier.Name = "btn_cliParticulier"
		Me.btn_cliParticulier.Size = New System.Drawing.Size(100, 28)
		Me.btn_cliParticulier.TabIndex = 3
		Me.btn_cliParticulier.Text = "Particulier"
		Me.btn_cliParticulier.UseVisualStyleBackColor = True
		'
		'Lb_ajoutClient
		'
		Me.Lb_ajoutClient.AutoSize = True
		Me.Lb_ajoutClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lb_ajoutClient.Location = New System.Drawing.Point(12, 28)
		Me.Lb_ajoutClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Lb_ajoutClient.Name = "Lb_ajoutClient"
		Me.Lb_ajoutClient.Size = New System.Drawing.Size(124, 20)
		Me.Lb_ajoutClient.TabIndex = 2
		Me.Lb_ajoutClient.Text = "Ajouter Client"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(15, 31)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(0, 17)
		Me.Label2.TabIndex = 1
		'
		'EquipBindingSource
		'
		Me.EquipBindingSource.DataSource = GetType(ProjetVB.Equip_Object)
		'
		'ValidationéquipementBindingSource
		'
		Me.ValidationéquipementBindingSource.DataSource = GetType(ProjetVB.Validation_équipement)
		'
		'Créer_Contrat
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(801, 991)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.GroupBox1_Contrat)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Créer_Contrat"
		Me.Text = "Créer_Contrat"
		Me.GroupBox1_ClientActuel.ResumeLayout(False)
		Me.GroupBox1_ClientActuel.PerformLayout()
		Me.GroupBox1_Contrat.ResumeLayout(False)
		Me.GroupBox1_Contrat.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView_LignesEquipement, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.EquipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ValidationéquipementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox1_ClientActuel As GroupBox
    Friend WithEvents CheckBox_Entreprise As CheckBox
    Friend WithEvents CheckBox_pariculier As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Lb_prenom As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lb_NoClient As Label
    Friend WithEvents Lb_adresse As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Lb_rue As Label
    Friend WithEvents Lb_NoCivique As Label
    Friend WithEvents GroupBox1_Contrat As GroupBox
    Friend WithEvents Lb_DateResi As Label
    Friend WithEvents Lb_DateOuv As Label
    Friend WithEvents Lb_NoContrat As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Lb_tel As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_recherheClient As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NumContrat As TextBox
    Friend WithEvents btn_cliCommercial As Button
    Friend WithEvents btn_cliParticulier As Button
    Friend WithEvents Lb_ajoutClient As Label
    Friend WithEvents btnService As Button
    Friend WithEvents btnEquipement As Button
    Friend WithEvents btnConsulte As Button
    Friend WithEvents DataGridView_LignesEquipement As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnComplete As Button
    Friend WithEvents Btn_supprimer As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Numéro_Équiement As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Prix_Unitaire As DataGridViewTextBoxColumn
    Friend WithEvents ValidationéquipementBindingSource As BindingSource
    Friend WithEvents EquipBindingSource As BindingSource
End Class
