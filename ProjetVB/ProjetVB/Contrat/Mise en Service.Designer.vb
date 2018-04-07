<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mise_en_Service
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
        Me.lb_Datemiseenservice = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_AjoutcltCom_prov = New System.Windows.Forms.ComboBox()
        Me.LbLivreur = New System.Windows.Forms.Label()
        Me.NoCommande = New System.Windows.Forms.TextBox()
        Me.Lb_NoClient = New System.Windows.Forms.Label()
        Me.DataGridView_LigneFacture = New System.Windows.Forms.DataGridView()
        Me.Numéro_Équiement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix_Unitaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Lb_tel = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Lb_prenom = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Lb_hour = New System.Windows.Forms.Label()
        Me.btnComplete = New System.Windows.Forms.Button()
        CType(Me.DataGridView_LigneFacture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_Datemiseenservice
        '
        Me.lb_Datemiseenservice.AutoSize = True
        Me.lb_Datemiseenservice.Location = New System.Drawing.Point(18, 44)
        Me.lb_Datemiseenservice.Name = "lb_Datemiseenservice"
        Me.lb_Datemiseenservice.Size = New System.Drawing.Size(100, 13)
        Me.lb_Datemiseenservice.TabIndex = 0
        Me.lb_Datemiseenservice.Text = "Date mise en serive"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'ComboBox_AjoutcltCom_prov
        '
        Me.ComboBox_AjoutcltCom_prov.FormattingEnabled = True
        Me.ComboBox_AjoutcltCom_prov.Items.AddRange(New Object() {"Livreur #1", "Livreur #2", "Livreur #3", "Livreur #4", "Livreur #5"})
        Me.ComboBox_AjoutcltCom_prov.Location = New System.Drawing.Point(405, 157)
        Me.ComboBox_AjoutcltCom_prov.Name = "ComboBox_AjoutcltCom_prov"
        Me.ComboBox_AjoutcltCom_prov.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox_AjoutcltCom_prov.TabIndex = 11
        '
        'LbLivreur
        '
        Me.LbLivreur.AutoSize = True
        Me.LbLivreur.Location = New System.Drawing.Point(362, 160)
        Me.LbLivreur.Name = "LbLivreur"
        Me.LbLivreur.Size = New System.Drawing.Size(42, 13)
        Me.LbLivreur.TabIndex = 12
        Me.LbLivreur.Text = "Livreur:"
        '
        'NoCommande
        '
        Me.NoCommande.Location = New System.Drawing.Point(204, 12)
        Me.NoCommande.Name = "NoCommande"
        Me.NoCommande.Size = New System.Drawing.Size(127, 20)
        Me.NoCommande.TabIndex = 14
        '
        'Lb_NoClient
        '
        Me.Lb_NoClient.AutoSize = True
        Me.Lb_NoClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NoClient.Location = New System.Drawing.Point(17, 13)
        Me.Lb_NoClient.Name = "Lb_NoClient"
        Me.Lb_NoClient.Size = New System.Drawing.Size(181, 16)
        Me.Lb_NoClient.TabIndex = 13
        Me.Lb_NoClient.Text = "Numéro bon de livraison:"
        '
        'DataGridView_LigneFacture
        '
        Me.DataGridView_LigneFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LigneFacture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numéro_Équiement, Me.Type, Me.Description, Me.Quantité, Me.Prix_Unitaire})
        Me.DataGridView_LigneFacture.Location = New System.Drawing.Point(12, 190)
        Me.DataGridView_LigneFacture.MultiSelect = False
        Me.DataGridView_LigneFacture.Name = "DataGridView_LigneFacture"
        Me.DataGridView_LigneFacture.RowHeadersVisible = False
        Me.DataGridView_LigneFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_LigneFacture.Size = New System.Drawing.Size(490, 177)
        Me.DataGridView_LigneFacture.TabIndex = 24
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Lb_tel)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Lb_prenom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 70)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(380, 29)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 21
        '
        'Lb_tel
        '
        Me.Lb_tel.AutoSize = True
        Me.Lb_tel.Location = New System.Drawing.Point(319, 32)
        Me.Lb_tel.Name = "Lb_tel"
        Me.Lb_tel.Size = New System.Drawing.Size(61, 13)
        Me.Lb_tel.TabIndex = 20
        Me.Lb_tel.Text = "Téléphone:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(41, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nom:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(202, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        '
        'Lb_prenom
        '
        Me.Lb_prenom.AutoSize = True
        Me.Lb_prenom.Location = New System.Drawing.Point(153, 32)
        Me.Lb_prenom.Name = "Lb_prenom"
        Me.Lb_prenom.Size = New System.Drawing.Size(46, 13)
        Me.Lb_prenom.TabIndex = 16
        Me.Lb_prenom.Text = "Prenom:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"})
        Me.ComboBox1.Location = New System.Drawing.Point(59, 157)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'Lb_hour
        '
        Me.Lb_hour.AutoSize = True
        Me.Lb_hour.Location = New System.Drawing.Point(14, 160)
        Me.Lb_hour.Name = "Lb_hour"
        Me.Lb_hour.Size = New System.Drawing.Size(39, 13)
        Me.Lb_hour.TabIndex = 27
        Me.Lb_hour.Text = "Heure:"
        '
        'btnComplete
        '
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.Location = New System.Drawing.Point(392, 376)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(110, 30)
        Me.btnComplete.TabIndex = 28
        Me.btnComplete.Text = "Confirmer"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'Mise_en_Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 418)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.Lb_hour)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView_LigneFacture)
        Me.Controls.Add(Me.NoCommande)
        Me.Controls.Add(Me.Lb_NoClient)
        Me.Controls.Add(Me.LbLivreur)
        Me.Controls.Add(Me.ComboBox_AjoutcltCom_prov)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lb_Datemiseenservice)
        Me.Name = "Mise_en_Service"
        Me.Text = "Mise_en_Service"
        CType(Me.DataGridView_LigneFacture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_Datemiseenservice As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox_AjoutcltCom_prov As ComboBox
    Friend WithEvents LbLivreur As Label
    Friend WithEvents NoCommande As TextBox
    Friend WithEvents Lb_NoClient As Label
    Friend WithEvents DataGridView_LigneFacture As DataGridView
    Friend WithEvents Numéro_Équiement As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Prix_Unitaire As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Lb_tel As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Lb_prenom As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Lb_hour As Label
    Friend WithEvents btnComplete As Button
End Class
