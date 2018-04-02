<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsulterFournisseur
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Consulter_Region = New System.Windows.Forms.Button()
        Me.TextBoxRegion = New System.Windows.Forms.TextBox()
        Me.Region_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNom_fournisseur = New System.Windows.Forms.Label()
        Me.TextBoxNuméroContrat = New System.Windows.Forms.TextBox()
        Me.TextBoxRechercheNomFournisseur = New System.Windows.Forms.TextBox()
        Me.Annuler_consulterFournisseur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Recherche fournisseur par :"
        '
        'Consulter_Region
        '
        Me.Consulter_Region.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Consulter_Region.Location = New System.Drawing.Point(12, 161)
        Me.Consulter_Region.Name = "Consulter_Region"
        Me.Consulter_Region.Size = New System.Drawing.Size(91, 29)
        Me.Consulter_Region.TabIndex = 17
        Me.Consulter_Region.Text = "Consulter"
        Me.Consulter_Region.UseVisualStyleBackColor = True
        '
        'TextBoxRegion
        '
        Me.TextBoxRegion.Location = New System.Drawing.Point(152, 93)
        Me.TextBoxRegion.Name = "TextBoxRegion"
        Me.TextBoxRegion.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRegion.TabIndex = 18
        '
        'Region_lbl
        '
        Me.Region_lbl.AutoSize = True
        Me.Region_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Region_lbl.Location = New System.Drawing.Point(12, 93)
        Me.Region_lbl.Name = "Region_lbl"
        Me.Region_lbl.Size = New System.Drawing.Size(61, 17)
        Me.Region_lbl.TabIndex = 19
        Me.Region_lbl.Text = "Region :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Numéro de contrat :"
        '
        'LabelNom_fournisseur
        '
        Me.LabelNom_fournisseur.AutoSize = True
        Me.LabelNom_fournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.LabelNom_fournisseur.Location = New System.Drawing.Point(12, 126)
        Me.LabelNom_fournisseur.Name = "LabelNom_fournisseur"
        Me.LabelNom_fournisseur.Size = New System.Drawing.Size(45, 17)
        Me.LabelNom_fournisseur.TabIndex = 21
        Me.LabelNom_fournisseur.Text = "Nom :"
        '
        'TextBoxNuméroContrat
        '
        Me.TextBoxNuméroContrat.Location = New System.Drawing.Point(152, 58)
        Me.TextBoxNuméroContrat.Name = "TextBoxNuméroContrat"
        Me.TextBoxNuméroContrat.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuméroContrat.TabIndex = 22
        '
        'TextBoxRechercheNomFournisseur
        '
        Me.TextBoxRechercheNomFournisseur.Location = New System.Drawing.Point(152, 126)
        Me.TextBoxRechercheNomFournisseur.Name = "TextBoxRechercheNomFournisseur"
        Me.TextBoxRechercheNomFournisseur.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRechercheNomFournisseur.TabIndex = 23
        '
        'Annuler_consulterFournisseur
        '
        Me.Annuler_consulterFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Annuler_consulterFournisseur.Location = New System.Drawing.Point(160, 161)
        Me.Annuler_consulterFournisseur.Name = "Annuler_consulterFournisseur"
        Me.Annuler_consulterFournisseur.Size = New System.Drawing.Size(92, 29)
        Me.Annuler_consulterFournisseur.TabIndex = 24
        Me.Annuler_consulterFournisseur.Text = "Annuler"
        Me.Annuler_consulterFournisseur.UseVisualStyleBackColor = True
        '
        'ConsulterFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 221)
        Me.Controls.Add(Me.Annuler_consulterFournisseur)
        Me.Controls.Add(Me.TextBoxRechercheNomFournisseur)
        Me.Controls.Add(Me.TextBoxNuméroContrat)
        Me.Controls.Add(Me.LabelNom_fournisseur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Region_lbl)
        Me.Controls.Add(Me.TextBoxRegion)
        Me.Controls.Add(Me.Consulter_Region)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ConsulterFournisseur"
        Me.Text = "Consulter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Consulter_Region As Button
    Friend WithEvents TextBoxRegion As TextBox
    Friend WithEvents Region_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNom_fournisseur As Label
    Friend WithEvents TextBoxNuméroContrat As TextBox
    Friend WithEvents TextBoxRechercheNomFournisseur As TextBox
    Friend WithEvents Annuler_consulterFournisseur As Button
End Class
