<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EquipementRetour
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
        Me.NumeroEquipement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEquipement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeEquipement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDeRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroEquipement, Me.NomEquipement, Me.TypeEquipement, Me.Quantite, Me.DateDeRetour})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'NumeroEquipement
        '
        Me.NumeroEquipement.HeaderText = "Numéro d'équipement"
        Me.NumeroEquipement.Name = "NumeroEquipement"
        '
        'NomEquipement
        '
        Me.NomEquipement.HeaderText = "Nom d'équipement"
        Me.NomEquipement.Name = "NomEquipement"
        '
        'TypeEquipement
        '
        Me.TypeEquipement.HeaderText = "Type d'équipement"
        Me.TypeEquipement.Name = "TypeEquipement"
        '
        'Quantite
        '
        Me.Quantite.HeaderText = "Quantité"
        Me.Quantite.Name = "Quantite"
        '
        'DateDeRetour
        '
        Me.DateDeRetour.HeaderText = "Date de Retour"
        Me.DateDeRetour.Name = "DateDeRetour"
        '
        'EquipementRetour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 255)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EquipementRetour"
        Me.Text = "EquipementRetour"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumeroEquipement As DataGridViewTextBoxColumn
    Friend WithEvents NomEquipement As DataGridViewTextBoxColumn
    Friend WithEvents TypeEquipement As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
    Friend WithEvents DateDeRetour As DataGridViewTextBoxColumn
End Class
