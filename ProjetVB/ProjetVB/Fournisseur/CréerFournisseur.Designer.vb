<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CréerFournisseur
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
        Me.lbnomFournisseur = New System.Windows.Forms.Label()
        Me.lbnumeroFournisseur = New System.Windows.Forms.Label()
        Me.lbtelephoneFournisseur = New System.Windows.Forms.Label()
        Me.lbtelecopieurFournisseur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbnomFournisseur
        '
        Me.lbnomFournisseur.AutoSize = True
        Me.lbnomFournisseur.Location = New System.Drawing.Point(51, 63)
        Me.lbnomFournisseur.Name = "lbnomFournisseur"
        Me.lbnomFournisseur.Size = New System.Drawing.Size(29, 13)
        Me.lbnomFournisseur.TabIndex = 0
        Me.lbnomFournisseur.Text = "Nom"
        '
        'lbnumeroFournisseur
        '
        Me.lbnumeroFournisseur.AutoSize = True
        Me.lbnumeroFournisseur.Location = New System.Drawing.Point(51, 90)
        Me.lbnumeroFournisseur.Name = "lbnumeroFournisseur"
        Me.lbnumeroFournisseur.Size = New System.Drawing.Size(44, 13)
        Me.lbnumeroFournisseur.TabIndex = 1
        Me.lbnumeroFournisseur.Text = "Numéro"
        '
        'lbtelephoneFournisseur
        '
        Me.lbtelephoneFournisseur.AutoSize = True
        Me.lbtelephoneFournisseur.Location = New System.Drawing.Point(51, 134)
        Me.lbtelephoneFournisseur.Name = "lbtelephoneFournisseur"
        Me.lbtelephoneFournisseur.Size = New System.Drawing.Size(58, 13)
        Me.lbtelephoneFournisseur.TabIndex = 2
        Me.lbtelephoneFournisseur.Text = "Téléphone"
        '
        'lbtelecopieurFournisseur
        '
        Me.lbtelecopieurFournisseur.AutoSize = True
        Me.lbtelecopieurFournisseur.Location = New System.Drawing.Point(51, 193)
        Me.lbtelecopieurFournisseur.Name = "lbtelecopieurFournisseur"
        Me.lbtelecopieurFournisseur.Size = New System.Drawing.Size(63, 13)
        Me.lbtelecopieurFournisseur.TabIndex = 3
        Me.lbtelecopieurFournisseur.Text = "Télécopieur"
        '
        'CréerFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbtelecopieurFournisseur)
        Me.Controls.Add(Me.lbtelephoneFournisseur)
        Me.Controls.Add(Me.lbnumeroFournisseur)
        Me.Controls.Add(Me.lbnomFournisseur)
        Me.Name = "CréerFournisseur"
        Me.Text = "Créer Fournisseur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbnomFournisseur As Label
    Friend WithEvents lbnumeroFournisseur As Label
    Friend WithEvents lbtelephoneFournisseur As Label
    Friend WithEvents lbtelecopieurFournisseur As Label
End Class
