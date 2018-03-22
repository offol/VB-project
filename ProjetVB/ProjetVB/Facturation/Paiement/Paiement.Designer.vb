<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Paiement
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
        Me.Button_payer = New System.Windows.Forms.Button()
        Me.ComboBox_modePaiement = New System.Windows.Forms.ComboBox()
        Me.Label_modePaiement = New System.Windows.Forms.Label()
        Me.GroupBox_carteCrédit = New System.Windows.Forms.GroupBox()
        Me.GroupBox_retraitDirect = New System.Windows.Forms.GroupBox()
        Me.GroupBox_chèque = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_montantPayer = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_NoCarte = New System.Windows.Forms.TextBox()
        Me.TextBox_DateExpiration = New System.Windows.Forms.TextBox()
        Me.TextBox_TypeCarte = New System.Windows.Forms.TextBox()
        Me.TextBox_NoCompte = New System.Windows.Forms.TextBox()
        Me.TextBox_TypeRD = New System.Windows.Forms.TextBox()
        Me.TextBox_NoCheque = New System.Windows.Forms.TextBox()
        Me.TextBox_institution = New System.Windows.Forms.TextBox()
        Me.TextBox_dateCheque = New System.Windows.Forms.TextBox()
        Me.DataGridView_Facture = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant_Restant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox_carteCrédit.SuspendLayout()
        Me.GroupBox_retraitDirect.SuspendLayout()
        Me.GroupBox_chèque.SuspendLayout()
        CType(Me.DataGridView_Facture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_payer
        '
        Me.Button_payer.Location = New System.Drawing.Point(495, 217)
        Me.Button_payer.Name = "Button_payer"
        Me.Button_payer.Size = New System.Drawing.Size(105, 23)
        Me.Button_payer.TabIndex = 3
        Me.Button_payer.Text = "Payer"
        Me.Button_payer.UseVisualStyleBackColor = True
        '
        'ComboBox_modePaiement
        '
        Me.ComboBox_modePaiement.FormattingEnabled = True
        Me.ComboBox_modePaiement.Location = New System.Drawing.Point(120, 217)
        Me.ComboBox_modePaiement.Name = "ComboBox_modePaiement"
        Me.ComboBox_modePaiement.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_modePaiement.TabIndex = 5
        '
        'Label_modePaiement
        '
        Me.Label_modePaiement.AutoSize = True
        Me.Label_modePaiement.Location = New System.Drawing.Point(13, 225)
        Me.Label_modePaiement.Name = "Label_modePaiement"
        Me.Label_modePaiement.Size = New System.Drawing.Size(101, 13)
        Me.Label_modePaiement.TabIndex = 6
        Me.Label_modePaiement.Text = "Mode de paiement :"
        '
        'GroupBox_carteCrédit
        '
        Me.GroupBox_carteCrédit.Controls.Add(Me.TextBox_TypeCarte)
        Me.GroupBox_carteCrédit.Controls.Add(Me.TextBox_DateExpiration)
        Me.GroupBox_carteCrédit.Controls.Add(Me.TextBox_NoCarte)
        Me.GroupBox_carteCrédit.Controls.Add(Me.Label3)
        Me.GroupBox_carteCrédit.Controls.Add(Me.Label2)
        Me.GroupBox_carteCrédit.Controls.Add(Me.Label1)
        Me.GroupBox_carteCrédit.Location = New System.Drawing.Point(16, 264)
        Me.GroupBox_carteCrédit.Name = "GroupBox_carteCrédit"
        Me.GroupBox_carteCrédit.Size = New System.Drawing.Size(247, 153)
        Me.GroupBox_carteCrédit.TabIndex = 7
        Me.GroupBox_carteCrédit.TabStop = False
        Me.GroupBox_carteCrédit.Text = "Information Carte de crédit"
        Me.GroupBox_carteCrédit.Visible = False
        '
        'GroupBox_retraitDirect
        '
        Me.GroupBox_retraitDirect.Controls.Add(Me.TextBox_TypeRD)
        Me.GroupBox_retraitDirect.Controls.Add(Me.TextBox_NoCompte)
        Me.GroupBox_retraitDirect.Controls.Add(Me.Label9)
        Me.GroupBox_retraitDirect.Controls.Add(Me.Label8)
        Me.GroupBox_retraitDirect.Location = New System.Drawing.Point(298, 264)
        Me.GroupBox_retraitDirect.Name = "GroupBox_retraitDirect"
        Me.GroupBox_retraitDirect.Size = New System.Drawing.Size(271, 153)
        Me.GroupBox_retraitDirect.TabIndex = 8
        Me.GroupBox_retraitDirect.TabStop = False
        Me.GroupBox_retraitDirect.Text = "Information Retrait direct"
        Me.GroupBox_retraitDirect.Visible = False
        '
        'GroupBox_chèque
        '
        Me.GroupBox_chèque.Controls.Add(Me.TextBox_dateCheque)
        Me.GroupBox_chèque.Controls.Add(Me.TextBox_institution)
        Me.GroupBox_chèque.Controls.Add(Me.TextBox_NoCheque)
        Me.GroupBox_chèque.Controls.Add(Me.Label6)
        Me.GroupBox_chèque.Controls.Add(Me.Label4)
        Me.GroupBox_chèque.Controls.Add(Me.Label5)
        Me.GroupBox_chèque.Location = New System.Drawing.Point(601, 264)
        Me.GroupBox_chèque.Name = "GroupBox_chèque"
        Me.GroupBox_chèque.Size = New System.Drawing.Size(218, 153)
        Me.GroupBox_chèque.TabIndex = 9
        Me.GroupBox_chèque.TabStop = False
        Me.GroupBox_chèque.Text = "Information Chèque"
        Me.GroupBox_chèque.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Carte :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date expiration :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type de carte :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No. Chèque :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Institution :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Date :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Montant payer :"
        '
        'TextBox_montantPayer
        '
        Me.TextBox_montantPayer.Location = New System.Drawing.Point(352, 218)
        Me.TextBox_montantPayer.Name = "TextBox_montantPayer"
        Me.TextBox_montantPayer.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_montantPayer.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "No. Compte :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Type :"
        '
        'TextBox_NoCarte
        '
        Me.TextBox_NoCarte.Location = New System.Drawing.Point(98, 19)
        Me.TextBox_NoCarte.Name = "TextBox_NoCarte"
        Me.TextBox_NoCarte.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_NoCarte.TabIndex = 3
        '
        'TextBox_DateExpiration
        '
        Me.TextBox_DateExpiration.Location = New System.Drawing.Point(98, 47)
        Me.TextBox_DateExpiration.Name = "TextBox_DateExpiration"
        Me.TextBox_DateExpiration.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_DateExpiration.TabIndex = 4
        '
        'TextBox_TypeCarte
        '
        Me.TextBox_TypeCarte.Location = New System.Drawing.Point(98, 79)
        Me.TextBox_TypeCarte.Name = "TextBox_TypeCarte"
        Me.TextBox_TypeCarte.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_TypeCarte.TabIndex = 5
        '
        'TextBox_NoCompte
        '
        Me.TextBox_NoCompte.Location = New System.Drawing.Point(83, 20)
        Me.TextBox_NoCompte.Name = "TextBox_NoCompte"
        Me.TextBox_NoCompte.Size = New System.Drawing.Size(182, 20)
        Me.TextBox_NoCompte.TabIndex = 2
        '
        'TextBox_TypeRD
        '
        Me.TextBox_TypeRD.Location = New System.Drawing.Point(83, 47)
        Me.TextBox_TypeRD.Name = "TextBox_TypeRD"
        Me.TextBox_TypeRD.Size = New System.Drawing.Size(182, 20)
        Me.TextBox_TypeRD.TabIndex = 3
        '
        'TextBox_NoCheque
        '
        Me.TextBox_NoCheque.Location = New System.Drawing.Point(83, 20)
        Me.TextBox_NoCheque.Name = "TextBox_NoCheque"
        Me.TextBox_NoCheque.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_NoCheque.TabIndex = 3
        '
        'TextBox_institution
        '
        Me.TextBox_institution.Location = New System.Drawing.Point(83, 50)
        Me.TextBox_institution.Name = "TextBox_institution"
        Me.TextBox_institution.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_institution.TabIndex = 4
        '
        'TextBox_dateCheque
        '
        Me.TextBox_dateCheque.Location = New System.Drawing.Point(83, 79)
        Me.TextBox_dateCheque.Name = "TextBox_dateCheque"
        Me.TextBox_dateCheque.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_dateCheque.TabIndex = 5
        '
        'DataGridView_Facture
        '
        Me.DataGridView_Facture.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView_Facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Facture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.Montant_Restant})
        Me.DataGridView_Facture.Location = New System.Drawing.Point(16, 12)
        Me.DataGridView_Facture.MultiSelect = False
        Me.DataGridView_Facture.Name = "DataGridView_Facture"
        Me.DataGridView_Facture.RowHeadersVisible = False
        Me.DataGridView_Facture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Facture.Size = New System.Drawing.Size(912, 187)
        Me.DataGridView_Facture.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Numéro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Numéro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date_Facture"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date_Facture"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date_Paiement"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date_Paiement"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "État"
        Me.DataGridViewTextBoxColumn4.HeaderText = "État"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Montant_Hors_Taxe"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Montant_Hors_Taxe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Montant_TVQ"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Montant_TVQ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Montant_TPS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Montant_TPS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Montant_Restant
        '
        Me.Montant_Restant.DataPropertyName = "Montant_Restant"
        Me.Montant_Restant.HeaderText = "Montant_Restant"
        Me.Montant_Restant.Name = "Montant_Restant"
        '
        'Paiement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 425)
        Me.Controls.Add(Me.DataGridView_Facture)
        Me.Controls.Add(Me.TextBox_montantPayer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox_chèque)
        Me.Controls.Add(Me.GroupBox_retraitDirect)
        Me.Controls.Add(Me.GroupBox_carteCrédit)
        Me.Controls.Add(Me.Label_modePaiement)
        Me.Controls.Add(Me.ComboBox_modePaiement)
        Me.Controls.Add(Me.Button_payer)
        Me.Name = "Paiement"
        Me.Text = "Paiement"
        Me.GroupBox_carteCrédit.ResumeLayout(False)
        Me.GroupBox_carteCrédit.PerformLayout()
        Me.GroupBox_retraitDirect.ResumeLayout(False)
        Me.GroupBox_retraitDirect.PerformLayout()
        Me.GroupBox_chèque.ResumeLayout(False)
        Me.GroupBox_chèque.PerformLayout()
        CType(Me.DataGridView_Facture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_payer As Button
    Friend WithEvents ComboBox_modePaiement As ComboBox
    Friend WithEvents Label_modePaiement As Label
    Friend WithEvents GroupBox_carteCrédit As GroupBox
    Friend WithEvents GroupBox_retraitDirect As GroupBox
    Friend WithEvents GroupBox_chèque As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_montantPayer As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_TypeCarte As TextBox
    Friend WithEvents TextBox_DateExpiration As TextBox
    Friend WithEvents TextBox_NoCarte As TextBox
    Friend WithEvents TextBox_TypeRD As TextBox
    Friend WithEvents TextBox_NoCompte As TextBox
    Friend WithEvents TextBox_dateCheque As TextBox
    Friend WithEvents TextBox_institution As TextBox
    Friend WithEvents TextBox_NoCheque As TextBox
    Friend WithEvents DataGridView_Facture As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Montant_Restant As DataGridViewTextBoxColumn
End Class
