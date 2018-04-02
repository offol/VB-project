<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EquipementCommander
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
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroEquipement, Me.NomEquipement, Me.Type, Me.Quantité, Me.Prix})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 215)
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
        'Type
        '
        Me.Type.HeaderText = "Type d'équipement"
        Me.Type.Name = "Type"
        '
        'Quantité
        '
        Me.Quantité.HeaderText = "Quantité"
        Me.Quantité.Name = "Quantité"
        '
        'Prix
        '
        Me.Prix.HeaderText = "Prix"
        Me.Prix.Name = "Prix"
        '
        'EquipementCommander
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 308)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EquipementCommander"
        Me.Text = "Equipement à Commander"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumeroEquipement As DataGridViewTextBoxColumn
    Friend WithEvents NomEquipement As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
End Class
