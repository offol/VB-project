<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContratsOuverts
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
        Me.NoContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOuverture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateResiliation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Services = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiseEnVigueur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoContrat, Me.TypeContrat, Me.DateOuverture, Me.DateResiliation, Me.Equipement, Me.Services, Me.MiseEnVigueur})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'NoContrat
        '
        Me.NoContrat.HeaderText = "Numéro de Contrat"
        Me.NoContrat.Name = "NoContrat"
        '
        'TypeContrat
        '
        Me.TypeContrat.HeaderText = "Type de Contrat"
        Me.TypeContrat.Name = "TypeContrat"
        '
        'DateOuverture
        '
        Me.DateOuverture.HeaderText = "Date d'Ouverture"
        Me.DateOuverture.Name = "DateOuverture"
        '
        'DateResiliation
        '
        Me.DateResiliation.HeaderText = "Date de résiliation"
        Me.DateResiliation.Name = "DateResiliation"
        '
        'Equipement
        '
        Me.Equipement.HeaderText = "Équipememt"
        Me.Equipement.Name = "Equipement"
        '
        'Services
        '
        Me.Services.HeaderText = "Services"
        Me.Services.Name = "Services"
        '
        'MiseEnVigueur
        '
        Me.MiseEnVigueur.HeaderText = "Mise en Vigueur"
        Me.MiseEnVigueur.Name = "MiseEnVigueur"
        '
        'ContratsOuverts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 323)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ContratsOuverts"
        Me.Text = "ContratsOuverts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NoContrat As DataGridViewTextBoxColumn
    Friend WithEvents TypeContrat As DataGridViewTextBoxColumn
    Friend WithEvents DateOuverture As DataGridViewTextBoxColumn
    Friend WithEvents DateResiliation As DataGridViewTextBoxColumn
    Friend WithEvents Equipement As DataGridViewTextBoxColumn
    Friend WithEvents Services As DataGridViewTextBoxColumn
    Friend WithEvents MiseEnVigueur As DataGridViewTextBoxColumn
End Class
