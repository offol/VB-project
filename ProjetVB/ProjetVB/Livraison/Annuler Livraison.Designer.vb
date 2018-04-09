<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Annuler_Livraison
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
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.NoCommandeAnnuler = New System.Windows.Forms.TextBox()
        Me.Lb_NoClient = New System.Windows.Forms.Label()
        Me.LbLivreur = New System.Windows.Forms.Label()
        Me.ComboBox_AjoutcltCom_prov = New System.Windows.Forms.ComboBox()
        Me.BtnValideréquip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnComplete
        '
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.Location = New System.Drawing.Point(318, 56)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(110, 30)
        Me.btnComplete.TabIndex = 40
        Me.btnComplete.Text = "Annuler"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'NoCommandeAnnuler
        '
        Me.NoCommandeAnnuler.Location = New System.Drawing.Point(199, 18)
        Me.NoCommandeAnnuler.Name = "NoCommandeAnnuler"
        Me.NoCommandeAnnuler.Size = New System.Drawing.Size(127, 20)
        Me.NoCommandeAnnuler.TabIndex = 39
        '
        'Lb_NoClient
        '
        Me.Lb_NoClient.AutoSize = True
        Me.Lb_NoClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NoClient.Location = New System.Drawing.Point(12, 19)
        Me.Lb_NoClient.Name = "Lb_NoClient"
        Me.Lb_NoClient.Size = New System.Drawing.Size(181, 16)
        Me.Lb_NoClient.TabIndex = 38
        Me.Lb_NoClient.Text = "Numéro bon de livraison:"
        '
        'LbLivreur
        '
        Me.LbLivreur.AutoSize = True
        Me.LbLivreur.Location = New System.Drawing.Point(13, 65)
        Me.LbLivreur.Name = "LbLivreur"
        Me.LbLivreur.Size = New System.Drawing.Size(114, 13)
        Me.LbLivreur.TabIndex = 42
        Me.LbLivreur.Text = "Raison de l'annulation:"
        '
        'ComboBox_AjoutcltCom_prov
        '
        Me.ComboBox_AjoutcltCom_prov.FormattingEnabled = True
        Me.ComboBox_AjoutcltCom_prov.Items.AddRange(New Object() {"Non disponibilité", "Non paiement", "Modification du contrat", "Résiliation du contrat"})
        Me.ComboBox_AjoutcltCom_prov.Location = New System.Drawing.Point(130, 62)
        Me.ComboBox_AjoutcltCom_prov.Name = "ComboBox_AjoutcltCom_prov"
        Me.ComboBox_AjoutcltCom_prov.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox_AjoutcltCom_prov.TabIndex = 41
        '
        'BtnValideréquip
        '
        Me.BtnValideréquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValideréquip.Location = New System.Drawing.Point(353, 16)
        Me.BtnValideréquip.Name = "BtnValideréquip"
        Me.BtnValideréquip.Size = New System.Drawing.Size(75, 23)
        Me.BtnValideréquip.TabIndex = 43
        Me.BtnValideréquip.Text = "Valider"
        Me.BtnValideréquip.UseVisualStyleBackColor = True
        '
        'Annuler_Livraison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 98)
        Me.Controls.Add(Me.BtnValideréquip)
        Me.Controls.Add(Me.LbLivreur)
        Me.Controls.Add(Me.ComboBox_AjoutcltCom_prov)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.NoCommandeAnnuler)
        Me.Controls.Add(Me.Lb_NoClient)
        Me.Name = "Annuler_Livraison"
        Me.Text = "Annuler_Livraison"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComplete As Button
    Friend WithEvents NoCommandeAnnuler As TextBox
    Friend WithEvents Lb_NoClient As Label
    Friend WithEvents LbLivreur As Label
    Friend WithEvents ComboBox_AjoutcltCom_prov As ComboBox
    Friend WithEvents BtnValideréquip As Button
End Class
