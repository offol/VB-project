<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaiementRetraitDirect
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
        Me.DataGridView_PRD = New System.Windows.Forms.DataGridView()
        Me.NumeroCompte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDeCompte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantPaye = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView_PRD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_PRD
        '
        Me.DataGridView_PRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_PRD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroCompte, Me.TypeDeCompte, Me.MontantPaye})
        Me.DataGridView_PRD.Location = New System.Drawing.Point(31, 25)
        Me.DataGridView_PRD.Name = "DataGridView_PRD"
        Me.DataGridView_PRD.Size = New System.Drawing.Size(367, 166)
        Me.DataGridView_PRD.TabIndex = 0
        '
        'NumeroCompte
        '
        Me.NumeroCompte.DataPropertyName = "Numero_Compte"
        Me.NumeroCompte.HeaderText = "Numéro de Compte"
        Me.NumeroCompte.Name = "NumeroCompte"
        '
        'TypeDeCompte
        '
        Me.TypeDeCompte.DataPropertyName = "Type_Compte"
        Me.TypeDeCompte.HeaderText = "Type de Compte"
        Me.TypeDeCompte.Name = "TypeDeCompte"
        '
        'MontantPaye
        '
        Me.MontantPaye.DataPropertyName = "Montant_Paye"
        Me.MontantPaye.HeaderText = "Montant Payé"
        Me.MontantPaye.Name = "MontantPaye"
        '
        'PaiementRetraitDirect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 246)
        Me.Controls.Add(Me.DataGridView_PRD)
        Me.Name = "PaiementRetraitDirect"
        Me.Text = "PaiementRetraitDirect"
        CType(Me.DataGridView_PRD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_PRD As DataGridView
    Friend WithEvents NumeroCompte As DataGridViewTextBoxColumn
    Friend WithEvents TypeDeCompte As DataGridViewTextBoxColumn
    Friend WithEvents MontantPaye As DataGridViewTextBoxColumn
End Class
