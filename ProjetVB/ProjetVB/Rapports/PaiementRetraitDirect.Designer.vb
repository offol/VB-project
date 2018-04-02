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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumeroCompte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDeCompte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantPaye = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroCompte, Me.TypeDeCompte, Me.MontantPaye})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(367, 166)
        Me.DataGridView1.TabIndex = 0
        '
        'NumeroCompte
        '
        Me.NumeroCompte.HeaderText = "Numéro de Compte"
        Me.NumeroCompte.Name = "NumeroCompte"
        '
        'TypeDeCompte
        '
        Me.TypeDeCompte.HeaderText = "Type de Compte"
        Me.TypeDeCompte.Name = "TypeDeCompte"
        '
        'MontantPaye
        '
        Me.MontantPaye.HeaderText = "Montant Payé"
        Me.MontantPaye.Name = "MontantPaye"
        '
        'PaiementRetraitDirect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 246)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PaiementRetraitDirect"
        Me.Text = "PaiementRetraitDirect"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumeroCompte As DataGridViewTextBoxColumn
    Friend WithEvents TypeDeCompte As DataGridViewTextBoxColumn
    Friend WithEvents MontantPaye As DataGridViewTextBoxColumn
End Class
