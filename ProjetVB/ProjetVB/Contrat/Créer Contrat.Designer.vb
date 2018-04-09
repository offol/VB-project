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
        Me.Btn_SuppService = New System.Windows.Forms.Button()
        Me.Btn_supprimer = New System.Windows.Forms.Button()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.DataGrid_Service = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.DataGrid_Service, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1_ClientActuel.Location = New System.Drawing.Point(0, 49)
        Me.GroupBox1_ClientActuel.Name = "GroupBox1_ClientActuel"
        Me.GroupBox1_ClientActuel.Size = New System.Drawing.Size(576, 165)
        Me.GroupBox1_ClientActuel.TabIndex = 12
        Me.GroupBox1_ClientActuel.TabStop = False
        '
        'btnConsulte
        '
        Me.btnConsulte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsulte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulte.Location = New System.Drawing.Point(451, 127)
        Me.btnConsulte.Name = "btnConsulte"
        Me.btnConsulte.Size = New System.Drawing.Size(110, 30)
        Me.btnConsulte.TabIndex = 16
        Me.btnConsulte.Text = "Consulter"
        Me.btnConsulte.UseVisualStyleBackColor = True
        '
        'Btn_recherheClient
        '
        Me.Btn_recherheClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_recherheClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_recherheClient.Location = New System.Drawing.Point(335, 127)
        Me.Btn_recherheClient.Name = "Btn_recherheClient"
        Me.Btn_recherheClient.Size = New System.Drawing.Size(110, 30)
        Me.Btn_recherheClient.TabIndex = 13
        Me.Btn_recherheClient.Text = "Recherche"
        Me.Btn_recherheClient.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Client Existant"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(399, 79)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 15
        '
        'Lb_tel
        '
        Me.Lb_tel.AutoSize = True
        Me.Lb_tel.Location = New System.Drawing.Point(332, 82)
        Me.Lb_tel.Name = "Lb_tel"
        Me.Lb_tel.Size = New System.Drawing.Size(61, 13)
        Me.Lb_tel.TabIndex = 14
        Me.Lb_tel.Text = "Téléphone:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(237, 137)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(69, 20)
        Me.TextBox5.TabIndex = 12
        '
        'Lb_rue
        '
        Me.Lb_rue.AutoSize = True
        Me.Lb_rue.Location = New System.Drawing.Point(164, 140)
        Me.Lb_rue.Name = "Lb_rue"
        Me.Lb_rue.Size = New System.Drawing.Size(67, 13)
        Me.Lb_rue.TabIndex = 11
        Me.Lb_rue.Text = "Code Postal:"
        '
        'Lb_NoCivique
        '
        Me.Lb_NoCivique.AutoSize = True
        Me.Lb_NoCivique.Location = New System.Drawing.Point(11, 140)
        Me.Lb_NoCivique.Name = "Lb_NoCivique"
        Me.Lb_NoCivique.Size = New System.Drawing.Size(84, 13)
        Me.Lb_NoCivique.TabIndex = 10
        Me.Lb_NoCivique.Text = "Numéro civique:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(101, 137)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(48, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Lb_adresse
        '
        Me.Lb_adresse.AutoSize = True
        Me.Lb_adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_adresse.Location = New System.Drawing.Point(11, 113)
        Me.Lb_adresse.Name = "Lb_adresse"
        Me.Lb_adresse.Size = New System.Drawing.Size(56, 13)
        Me.Lb_adresse.TabIndex = 8
        Me.Lb_adresse.Text = "Adresse:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(49, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom:"
        '
        'CheckBox_Entreprise
        '
        Me.CheckBox_Entreprise.AutoSize = True
        Me.CheckBox_Entreprise.Location = New System.Drawing.Point(335, 45)
        Me.CheckBox_Entreprise.Name = "CheckBox_Entreprise"
        Me.CheckBox_Entreprise.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox_Entreprise.TabIndex = 5
        Me.CheckBox_Entreprise.Text = "Entreprise"
        Me.CheckBox_Entreprise.UseVisualStyleBackColor = True
        '
        'CheckBox_pariculier
        '
        Me.CheckBox_pariculier.AutoSize = True
        Me.CheckBox_pariculier.Location = New System.Drawing.Point(244, 48)
        Me.CheckBox_pariculier.Name = "CheckBox_pariculier"
        Me.CheckBox_pariculier.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_pariculier.TabIndex = 4
        Me.CheckBox_pariculier.Text = "Particulier"
        Me.CheckBox_pariculier.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(216, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Lb_prenom
        '
        Me.Lb_prenom.AutoSize = True
        Me.Lb_prenom.Location = New System.Drawing.Point(164, 82)
        Me.Lb_prenom.Name = "Lb_prenom"
        Me.Lb_prenom.Size = New System.Drawing.Size(46, 13)
        Me.Lb_prenom.TabIndex = 2
        Me.Lb_prenom.Text = "Prenom:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Lb_NoClient
        '
        Me.Lb_NoClient.AutoSize = True
        Me.Lb_NoClient.Location = New System.Drawing.Point(9, 49)
        Me.Lb_NoClient.Name = "Lb_NoClient"
        Me.Lb_NoClient.Size = New System.Drawing.Size(76, 13)
        Me.Lb_NoClient.TabIndex = 0
        Me.Lb_NoClient.Text = "Numéro Client:"
        '
        'GroupBox1_Contrat
        '
        Me.GroupBox1_Contrat.Controls.Add(Me.Button2)
        Me.GroupBox1_Contrat.Controls.Add(Me.Btn_SuppService)
        Me.GroupBox1_Contrat.Controls.Add(Me.Btn_supprimer)
        Me.GroupBox1_Contrat.Controls.Add(Me.btnComplete)
        Me.GroupBox1_Contrat.Controls.Add(Me.DataGrid_Service)
        Me.GroupBox1_Contrat.Controls.Add(Me.DataGridView_LignesEquipement)
        Me.GroupBox1_Contrat.Controls.Add(Me.btnService)
        Me.GroupBox1_Contrat.Controls.Add(Me.btnEquipement)
        Me.GroupBox1_Contrat.Controls.Add(Me.NumContrat)
        Me.GroupBox1_Contrat.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1_Contrat.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1_Contrat.Controls.Add(Me.Lb_DateResi)
        Me.GroupBox1_Contrat.Controls.Add(Me.Lb_DateOuv)
        Me.GroupBox1_Contrat.Controls.Add(Me.Lb_NoContrat)
        Me.GroupBox1_Contrat.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox1_Contrat.Name = "GroupBox1_Contrat"
        Me.GroupBox1_Contrat.Size = New System.Drawing.Size(576, 568)
        Me.GroupBox1_Contrat.TabIndex = 13
        Me.GroupBox1_Contrat.TabStop = False
        Me.GroupBox1_Contrat.Text = "Contrat"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(9, 523)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 30)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Mise en service"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn_SuppService
        '
        Me.Btn_SuppService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SuppService.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SuppService.Location = New System.Drawing.Point(414, 469)
        Me.Btn_SuppService.Name = "Btn_SuppService"
        Me.Btn_SuppService.Size = New System.Drawing.Size(59, 22)
        Me.Btn_SuppService.TabIndex = 26
        Me.Btn_SuppService.Text = "Supprimer"
        Me.Btn_SuppService.UseVisualStyleBackColor = True
        '
        'Btn_supprimer
        '
        Me.Btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_supprimer.Location = New System.Drawing.Point(505, 244)
        Me.Btn_supprimer.Name = "Btn_supprimer"
        Me.Btn_supprimer.Size = New System.Drawing.Size(59, 22)
        Me.Btn_supprimer.TabIndex = 25
        Me.Btn_supprimer.Text = "Supprimer"
        Me.Btn_supprimer.UseVisualStyleBackColor = True
        '
        'btnComplete
        '
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.Location = New System.Drawing.Point(454, 523)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(110, 30)
        Me.btnComplete.TabIndex = 17
        Me.btnComplete.Text = "Compléter"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'DataGrid_Service
        '
        Me.DataGrid_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Service.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5})
        Me.DataGrid_Service.Location = New System.Drawing.Point(9, 314)
        Me.DataGrid_Service.MultiSelect = False
        Me.DataGrid_Service.Name = "DataGrid_Service"
        Me.DataGrid_Service.RowHeadersVisible = False
        Me.DataGrid_Service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_Service.Size = New System.Drawing.Size(399, 177)
        Me.DataGrid_Service.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Numéro de service"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Prix"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Prix Unitaire"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridView_LignesEquipement
        '
        Me.DataGridView_LignesEquipement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LignesEquipement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numéro_Équiement, Me.Location, Me.Type, Me.Quantité, Me.Prix_Unitaire})
        Me.DataGridView_LignesEquipement.Location = New System.Drawing.Point(9, 89)
        Me.DataGridView_LignesEquipement.MultiSelect = False
        Me.DataGridView_LignesEquipement.Name = "DataGridView_LignesEquipement"
        Me.DataGridView_LignesEquipement.RowHeadersVisible = False
        Me.DataGridView_LignesEquipement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_LignesEquipement.Size = New System.Drawing.Size(490, 177)
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
        Me.btnService.Location = New System.Drawing.Point(9, 285)
        Me.btnService.Name = "btnService"
        Me.btnService.Size = New System.Drawing.Size(75, 23)
        Me.btnService.TabIndex = 20
        Me.btnService.Text = "Services"
        Me.btnService.UseVisualStyleBackColor = True
        '
        'btnEquipement
        '
        Me.btnEquipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipement.Location = New System.Drawing.Point(9, 60)
        Me.btnEquipement.Name = "btnEquipement"
        Me.btnEquipement.Size = New System.Drawing.Size(75, 23)
        Me.btnEquipement.TabIndex = 13
        Me.btnEquipement.Text = "Équipement"
        Me.btnEquipement.UseVisualStyleBackColor = True
        '
        'NumContrat
        '
        Me.NumContrat.Location = New System.Drawing.Point(88, 22)
        Me.NumContrat.Name = "NumContrat"
        Me.NumContrat.Size = New System.Drawing.Size(109, 20)
        Me.NumContrat.TabIndex = 18
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(447, 48)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker2.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(447, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(114, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Lb_DateResi
        '
        Me.Lb_DateResi.AutoSize = True
        Me.Lb_DateResi.Location = New System.Drawing.Point(332, 54)
        Me.Lb_DateResi.Name = "Lb_DateResi"
        Me.Lb_DateResi.Size = New System.Drawing.Size(99, 13)
        Me.Lb_DateResi.TabIndex = 16
        Me.Lb_DateResi.Text = "Date de Résiliation:"
        '
        'Lb_DateOuv
        '
        Me.Lb_DateOuv.AutoSize = True
        Me.Lb_DateOuv.Location = New System.Drawing.Point(332, 25)
        Me.Lb_DateOuv.Name = "Lb_DateOuv"
        Me.Lb_DateOuv.Size = New System.Drawing.Size(89, 13)
        Me.Lb_DateOuv.TabIndex = 15
        Me.Lb_DateOuv.Text = "Date d'ouverture:"
        '
        'Lb_NoContrat
        '
        Me.Lb_NoContrat.AutoSize = True
        Me.Lb_NoContrat.Location = New System.Drawing.Point(6, 25)
        Me.Lb_NoContrat.Name = "Lb_NoContrat"
        Me.Lb_NoContrat.Size = New System.Drawing.Size(84, 13)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 214)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client"
        '
        'btn_cliCommercial
        '
        Me.btn_cliCommercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cliCommercial.Location = New System.Drawing.Point(237, 20)
        Me.btn_cliCommercial.Name = "btn_cliCommercial"
        Me.btn_cliCommercial.Size = New System.Drawing.Size(75, 23)
        Me.btn_cliCommercial.TabIndex = 4
        Me.btn_cliCommercial.Text = "Commercial"
        Me.btn_cliCommercial.UseVisualStyleBackColor = True
        '
        'btn_cliParticulier
        '
        Me.btn_cliParticulier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cliParticulier.Location = New System.Drawing.Point(141, 20)
        Me.btn_cliParticulier.Name = "btn_cliParticulier"
        Me.btn_cliParticulier.Size = New System.Drawing.Size(75, 23)
        Me.btn_cliParticulier.TabIndex = 3
        Me.btn_cliParticulier.Text = "Particulier"
        Me.btn_cliParticulier.UseVisualStyleBackColor = True
        '
        'Lb_ajoutClient
        '
        Me.Lb_ajoutClient.AutoSize = True
        Me.Lb_ajoutClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_ajoutClient.Location = New System.Drawing.Point(9, 23)
        Me.Lb_ajoutClient.Name = "Lb_ajoutClient"
        Me.Lb_ajoutClient.Size = New System.Drawing.Size(100, 16)
        Me.Lb_ajoutClient.TabIndex = 2
        Me.Lb_ajoutClient.Text = "Ajouter Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 805)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox1_Contrat)
        Me.Name = "Créer_Contrat"
        Me.Text = "Créer_Contrat"
        Me.GroupBox1_ClientActuel.ResumeLayout(False)
        Me.GroupBox1_ClientActuel.PerformLayout()
        Me.GroupBox1_Contrat.ResumeLayout(False)
        Me.GroupBox1_Contrat.PerformLayout()
        CType(Me.DataGrid_Service, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGrid_Service As DataGridView
    Friend WithEvents btnComplete As Button
    Friend WithEvents Btn_supprimer As Button
    Friend WithEvents Btn_SuppService As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Numéro_Équiement As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Prix_Unitaire As DataGridViewTextBoxColumn
    Friend WithEvents ValidationéquipementBindingSource As BindingSource
    Friend WithEvents EquipBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
