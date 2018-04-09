<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatutFournisseur
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
        Me.Numero_contrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Paiement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.État = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView_Facture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Facture
        '
        Me.DataGridView_Facture.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView_Facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Facture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numéro, Me.Numero_contrat, Me.Date_Paiement, Me.État})
        Me.DataGridView_Facture.Location = New System.Drawing.Point(-2, 0)
        Me.DataGridView_Facture.MultiSelect = False
        Me.DataGridView_Facture.Name = "DataGridView_Facture"
        Me.DataGridView_Facture.RowHeadersVisible = False
        Me.DataGridView_Facture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Facture.Size = New System.Drawing.Size(404, 152)
        Me.DataGridView_Facture.TabIndex = 2
        '
        'Numéro
        '
        Me.Numéro.DataPropertyName = "Numéro"
        Me.Numéro.HeaderText = "Fournisseur"
        Me.Numéro.Name = "Numéro"
        Me.Numéro.ReadOnly = True
        '
        'Numero_contrat
        '
        Me.Numero_contrat.DataPropertyName = "Date_Facture"
        Me.Numero_contrat.HeaderText = "Numéro Contrat"
        Me.Numero_contrat.Name = "Numero_contrat"
        Me.Numero_contrat.ReadOnly = True
        '
        'Date_Paiement
        '
        Me.Date_Paiement.DataPropertyName = "Date_Paiement"
        Me.Date_Paiement.HeaderText = "Adresse"
        Me.Date_Paiement.Name = "Date_Paiement"
        '
        'État
        '
        Me.État.DataPropertyName = "État"
        Me.État.HeaderText = "Statut"
        Me.État.Name = "État"
        Me.État.ReadOnly = True
        '
        'StatutFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 152)
        Me.Controls.Add(Me.DataGridView_Facture)
        Me.Name = "StatutFournisseur"
        Me.Text = "Statut Fournisseur"
        CType(Me.DataGridView_Facture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_Facture As DataGridView
    Friend WithEvents Numéro As DataGridViewTextBoxColumn
    Friend WithEvents Numero_contrat As DataGridViewTextBoxColumn
    Friend WithEvents Date_Paiement As DataGridViewTextBoxColumn
    Friend WithEvents État As DataGridViewTextBoxColumn
End Class
