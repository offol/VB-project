<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AchevementContrats
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NoContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroEquipement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinDeContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoContrat, Me.NumeroEquipement, Me.Type, Me.FinDeContrat})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(454, 148)
        Me.DataGridView1.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'NoContrat
        '
        Me.NoContrat.HeaderText = "Numéro de Contrat"
        Me.NoContrat.Name = "NoContrat"
        '
        'NumeroEquipement
        '
        Me.NumeroEquipement.HeaderText = "Numéro d'Équipement"
        Me.NumeroEquipement.Name = "NumeroEquipement"
        '
        'Type
        '
        Me.Type.HeaderText = "Type d'équipement"
        Me.Type.Name = "Type"
        '
        'FinDeContrat
        '
        Me.FinDeContrat.HeaderText = "Fin de Contrat"
        Me.FinDeContrat.Name = "FinDeContrat"
        '
        'AchevementContrats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 305)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AchevementContrats"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents NoContrat As DataGridViewTextBoxColumn
    Friend WithEvents NumeroEquipement As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents FinDeContrat As DataGridViewTextBoxColumn
End Class
