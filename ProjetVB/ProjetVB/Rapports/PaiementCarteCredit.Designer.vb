<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaiementCarteCredit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView_PCarte = New System.Windows.Forms.DataGridView()
        Me.NumeroCarte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateExpiration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDeCarte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView_PCarte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_PCarte
        '
        Me.DataGridView_PCarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_PCarte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroCarte, Me.DateExpiration, Me.TypeDeCarte, Me.Montant})
        Me.DataGridView_PCarte.Location = New System.Drawing.Point(12, 31)
        Me.DataGridView_PCarte.Name = "DataGridView_PCarte"
        Me.DataGridView_PCarte.Size = New System.Drawing.Size(448, 150)
        Me.DataGridView_PCarte.TabIndex = 0
        '
        'NumeroCarte
        '
        Me.NumeroCarte.DataPropertyName = "Numéro_Carte"
        Me.NumeroCarte.HeaderText = "Numero Carte"
        Me.NumeroCarte.Name = "NumeroCarte"
        '
        'DateExpiration
        '
        Me.DateExpiration.DataPropertyName = "Date_Expiration"
        Me.DateExpiration.HeaderText = "Date d'expiration"
        Me.DateExpiration.Name = "DateExpiration"
        '
        'TypeDeCarte
        '
        Me.TypeDeCarte.DataPropertyName = "Type_Carte"
        Me.TypeDeCarte.HeaderText = "Type de Carte"
        Me.TypeDeCarte.Name = "TypeDeCarte"
        '
        'Montant
        '
        Me.Montant.DataPropertyName = "Montant_Payé"
        Me.Montant.HeaderText = "Montant Payé"
        Me.Montant.Name = "Montant"
        '
        'PaiementCarteCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 244)
        Me.Controls.Add(Me.DataGridView_PCarte)
        Me.Name = "PaiementCarteCredit"
        Me.Text = "PaiementCarteCredit"
        CType(Me.DataGridView_PCarte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_PCarte As DataGridView
    Friend WithEvents NumeroCarte As DataGridViewTextBoxColumn
    Friend WithEvents DateExpiration As DataGridViewTextBoxColumn
    Friend WithEvents TypeDeCarte As DataGridViewTextBoxColumn
    Friend WithEvents Montant As DataGridViewTextBoxColumn
End Class
