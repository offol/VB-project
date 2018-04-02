<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifierFournisseur
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
        Me.Btm_VeriferLeStatut = New System.Windows.Forms.Button()
        Me.Btn_ModifierFournisseur = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.GroupBox_Fournisseur = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CanadaComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NvidiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TekInformatiqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SamsungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdresseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox_Fournisseur.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btm_VeriferLeStatut
        '
        Me.Btm_VeriferLeStatut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Btm_VeriferLeStatut.Location = New System.Drawing.Point(12, 339)
        Me.Btm_VeriferLeStatut.Name = "Btm_VeriferLeStatut"
        Me.Btm_VeriferLeStatut.Size = New System.Drawing.Size(179, 29)
        Me.Btm_VeriferLeStatut.TabIndex = 0
        Me.Btm_VeriferLeStatut.Text = "Vérifier le Statut"
        Me.Btm_VeriferLeStatut.UseVisualStyleBackColor = True
        '
        'Btn_ModifierFournisseur
        '
        Me.Btn_ModifierFournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Btn_ModifierFournisseur.Location = New System.Drawing.Point(227, 339)
        Me.Btn_ModifierFournisseur.Name = "Btn_ModifierFournisseur"
        Me.Btn_ModifierFournisseur.Size = New System.Drawing.Size(179, 29)
        Me.Btn_ModifierFournisseur.TabIndex = 1
        Me.Btn_ModifierFournisseur.Text = "Modifier"
        Me.Btn_ModifierFournisseur.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.ButtonAnnuler.Location = New System.Drawing.Point(432, 339)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(179, 29)
        Me.ButtonAnnuler.TabIndex = 2
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'GroupBox_Fournisseur
        '
        Me.GroupBox_Fournisseur.Controls.Add(Me.MenuStrip1)
        Me.GroupBox_Fournisseur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GroupBox_Fournisseur.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox_Fournisseur.Name = "GroupBox_Fournisseur"
        Me.GroupBox_Fournisseur.Size = New System.Drawing.Size(595, 272)
        Me.GroupBox_Fournisseur.TabIndex = 3
        Me.GroupBox_Fournisseur.TabStop = False
        Me.GroupBox_Fournisseur.Text = "Fournisseur"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CanadaComputerToolStripMenuItem, Me.NvidiaToolStripMenuItem, Me.TekInformatiqueToolStripMenuItem, Me.IntelToolStripMenuItem, Me.AsusToolStripMenuItem, Me.SamsungToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 19)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(589, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CanadaComputerToolStripMenuItem
        '
        Me.CanadaComputerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdresseToolStripMenuItem})
        Me.CanadaComputerToolStripMenuItem.Name = "CanadaComputerToolStripMenuItem"
        Me.CanadaComputerToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.CanadaComputerToolStripMenuItem.Text = "Canada Computer"
        '
        'NvidiaToolStripMenuItem
        '
        Me.NvidiaToolStripMenuItem.Name = "NvidiaToolStripMenuItem"
        Me.NvidiaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.NvidiaToolStripMenuItem.Text = "Nvidia"
        '
        'TekInformatiqueToolStripMenuItem
        '
        Me.TekInformatiqueToolStripMenuItem.Name = "TekInformatiqueToolStripMenuItem"
        Me.TekInformatiqueToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.TekInformatiqueToolStripMenuItem.Text = "Tek Informatique"
        '
        'IntelToolStripMenuItem
        '
        Me.IntelToolStripMenuItem.Name = "IntelToolStripMenuItem"
        Me.IntelToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.IntelToolStripMenuItem.Text = "Intel"
        '
        'AsusToolStripMenuItem
        '
        Me.AsusToolStripMenuItem.Name = "AsusToolStripMenuItem"
        Me.AsusToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AsusToolStripMenuItem.Text = "Asus"
        '
        'SamsungToolStripMenuItem
        '
        Me.SamsungToolStripMenuItem.Name = "SamsungToolStripMenuItem"
        Me.SamsungToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.SamsungToolStripMenuItem.Text = "Samsung"
        '
        'AdresseToolStripMenuItem
        '
        Me.AdresseToolStripMenuItem.Name = "AdresseToolStripMenuItem"
        Me.AdresseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdresseToolStripMenuItem.Text = "Adresse"
        '
        'ModifierFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 375)
        Me.Controls.Add(Me.GroupBox_Fournisseur)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.Btn_ModifierFournisseur)
        Me.Controls.Add(Me.Btm_VeriferLeStatut)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ModifierFournisseur"
        Me.Text = "Modifier"
        Me.GroupBox_Fournisseur.ResumeLayout(False)
        Me.GroupBox_Fournisseur.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btm_VeriferLeStatut As Button
    Friend WithEvents Btn_ModifierFournisseur As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents GroupBox_Fournisseur As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CanadaComputerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdresseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NvidiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TekInformatiqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SamsungToolStripMenuItem As ToolStripMenuItem
End Class
