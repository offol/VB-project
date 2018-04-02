<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContratsResiliers
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
        Me.NumeroContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDeContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDOuverture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDeResiliation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Services = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiseEnVigueur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroContrat, Me.TypeDeContrat, Me.DateDOuverture, Me.DateDeResiliation, Me.Equipement, Me.Services, Me.MiseEnVigueur})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 220)
        Me.DataGridView1.TabIndex = 0
        '
        'NumeroContrat
        '
        Me.NumeroContrat.HeaderText = "Numéro de Contrat"
        Me.NumeroContrat.Name = "NumeroContrat"
        '
        'TypeDeContrat
        '
        Me.TypeDeContrat.HeaderText = "Type de Contrat"
        Me.TypeDeContrat.Name = "TypeDeContrat"
        '
        'DateDOuverture
        '
        Me.DateDOuverture.HeaderText = "Date d'Ouverture"
        Me.DateDOuverture.Name = "DateDOuverture"
        '
        'DateDeResiliation
        '
        Me.DateDeResiliation.HeaderText = "Date de Résiliation"
        Me.DateDeResiliation.Name = "DateDeResiliation"
        '
        'Equipement
        '
        Me.Equipement.HeaderText = "Équipement"
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
        'ContratsResiliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 306)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ContratsResiliers"
        Me.Text = "ContratsResiliers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumeroContrat As DataGridViewTextBoxColumn
    Friend WithEvents TypeDeContrat As DataGridViewTextBoxColumn
    Friend WithEvents DateDOuverture As DataGridViewTextBoxColumn
    Friend WithEvents DateDeResiliation As DataGridViewTextBoxColumn
    Friend WithEvents Equipement As DataGridViewTextBoxColumn
    Friend WithEvents Services As DataGridViewTextBoxColumn
    Friend WithEvents MiseEnVigueur As DataGridViewTextBoxColumn
End Class
