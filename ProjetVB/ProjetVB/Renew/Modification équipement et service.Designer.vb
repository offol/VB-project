<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modification_équipement_et_service
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
        Me.GroupBox1_Contrat = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_supprimer = New System.Windows.Forms.Button()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_LigneFacture = New System.Windows.Forms.DataGridView()
        Me.Numéro_Équiement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix_Unitaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnService = New System.Windows.Forms.Button()
        Me.btnEquipement = New System.Windows.Forms.Button()
        Me.NumContrat = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lb_DateResi = New System.Windows.Forms.Label()
        Me.Lb_DateOuv = New System.Windows.Forms.Label()
        Me.Lb_NoContrat = New System.Windows.Forms.Label()
        Me.GroupBox1_Contrat.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_LigneFacture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1_Contrat
        '
        Me.GroupBox1_Contrat.Controls.Add(Me.Button1)
        Me.GroupBox1_Contrat.Controls.Add(Me.Btn_supprimer)
        Me.GroupBox1_Contrat.Controls.Add(Me.btnComplete)
        Me.GroupBox1_Contrat.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1_Contrat.Controls.Add(Me.DataGridView1)
        Me.GroupBox1_Contrat.Controls.Add(Me.DataGridView_LigneFacture)
        Me.GroupBox1_Contrat.Controls.Add(Me.Label4)
        Me.GroupBox1_Contrat.Controls.Add(Me.btnService)
        Me.GroupBox1_Contrat.Controls.Add(Me.btnEquipement)
        Me.GroupBox1_Contrat.Controls.Add(Me.NumContrat)
        Me.GroupBox1_Contrat.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1_Contrat.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1_Contrat.Controls.Add(Me.Lb_DateResi)
        Me.GroupBox1_Contrat.Controls.Add(Me.Lb_DateOuv)
        Me.GroupBox1_Contrat.Controls.Add(Me.Lb_NoContrat)
        Me.GroupBox1_Contrat.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1_Contrat.Name = "GroupBox1_Contrat"
        Me.GroupBox1_Contrat.Size = New System.Drawing.Size(656, 539)
        Me.GroupBox1_Contrat.TabIndex = 14
        Me.GroupBox1_Contrat.TabStop = False
        Me.GroupBox1_Contrat.Text = "Renouvellement contrat"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(440, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 22)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Supprimer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_supprimer
        '
        Me.Btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_supprimer.Location = New System.Drawing.Point(440, 262)
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
        Me.btnComplete.Location = New System.Drawing.Point(540, 503)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(110, 30)
        Me.btnComplete.TabIndex = 17
        Me.btnComplete.Text = "Compléter"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(139, 507)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker3.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 312)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(490, 177)
        Me.DataGridView1.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Numéro Équipement"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Numéro d'équipement"
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
        'DataGridView_LigneFacture
        '
        Me.DataGridView_LigneFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LigneFacture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numéro_Équiement, Me.Type, Me.Description, Me.Quantité, Me.Prix_Unitaire})
        Me.DataGridView_LigneFacture.Location = New System.Drawing.Point(9, 83)
        Me.DataGridView_LigneFacture.MultiSelect = False
        Me.DataGridView_LigneFacture.Name = "DataGridView_LigneFacture"
        Me.DataGridView_LigneFacture.RowHeadersVisible = False
        Me.DataGridView_LigneFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_LigneFacture.Size = New System.Drawing.Size(490, 177)
        Me.DataGridView_LigneFacture.TabIndex = 23
        '
        'Numéro_Équiement
        '
        Me.Numéro_Équiement.DataPropertyName = "Numéro Équipement"
        Me.Numéro_Équiement.HeaderText = "Numéro d'équipement"
        Me.Numéro_Équiement.Name = "Numéro_Équiement"
        Me.Numéro_Équiement.ReadOnly = True
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
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
        Me.Prix_Unitaire.DataPropertyName = "Prix Unitaire"
        Me.Prix_Unitaire.HeaderText = "Prix Unitaire"
        Me.Prix_Unitaire.Name = "Prix_Unitaire"
        Me.Prix_Unitaire.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 513)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Date de Mise en Service:"
        '
        'btnService
        '
        Me.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnService.Location = New System.Drawing.Point(9, 283)
        Me.btnService.Name = "btnService"
        Me.btnService.Size = New System.Drawing.Size(75, 23)
        Me.btnService.TabIndex = 20
        Me.btnService.Text = "Services"
        Me.btnService.UseVisualStyleBackColor = True
        '
        'btnEquipement
        '
        Me.btnEquipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipement.Location = New System.Drawing.Point(9, 54)
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
        Me.DateTimePicker2.Location = New System.Drawing.Point(534, 48)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker2.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(534, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(114, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Lb_DateResi
        '
        Me.Lb_DateResi.AutoSize = True
        Me.Lb_DateResi.Location = New System.Drawing.Point(419, 54)
        Me.Lb_DateResi.Name = "Lb_DateResi"
        Me.Lb_DateResi.Size = New System.Drawing.Size(99, 13)
        Me.Lb_DateResi.TabIndex = 16
        Me.Lb_DateResi.Text = "Date de Résiliation:"
        '
        'Lb_DateOuv
        '
        Me.Lb_DateOuv.AutoSize = True
        Me.Lb_DateOuv.Location = New System.Drawing.Point(419, 25)
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
        'Modification_équipement_et_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 559)
        Me.Controls.Add(Me.GroupBox1_Contrat)
        Me.Name = "Modification_équipement_et_service"
        Me.Text = "Modification_équipement_et_service"
        Me.GroupBox1_Contrat.ResumeLayout(False)
        Me.GroupBox1_Contrat.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_LigneFacture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1_Contrat As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_supprimer As Button
    Friend WithEvents btnComplete As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView_LigneFacture As DataGridView
    Friend WithEvents Numéro_Équiement As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Prix_Unitaire As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents btnService As Button
    Friend WithEvents btnEquipement As Button
    Friend WithEvents NumContrat As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Lb_DateResi As Label
    Friend WithEvents Lb_DateOuv As Label
    Friend WithEvents Lb_NoContrat As Label
End Class
