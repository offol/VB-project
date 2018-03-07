<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FournisseurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SécuritéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratToolStripMenuItem, Me.ÉToolStripMenuItem, Me.ServiceToolStripMenuItem, Me.FacturationToolStripMenuItem, Me.FournisseurToolStripMenuItem, Me.RapportsToolStripMenuItem, Me.SécuritéToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContratToolStripMenuItem
        '
        Me.ContratToolStripMenuItem.Name = "ContratToolStripMenuItem"
        Me.ContratToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ContratToolStripMenuItem.Text = "Contrat"
        '
        'ÉToolStripMenuItem
        '
        Me.ÉToolStripMenuItem.Name = "ÉToolStripMenuItem"
        Me.ÉToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ÉToolStripMenuItem.Text = "Équipement"
        '
        'ServiceToolStripMenuItem
        '
        Me.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        Me.ServiceToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ServiceToolStripMenuItem.Text = "Service"
        '
        'FacturationToolStripMenuItem
        '
        Me.FacturationToolStripMenuItem.Name = "FacturationToolStripMenuItem"
        Me.FacturationToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.FacturationToolStripMenuItem.Text = "Facturation"
        '
        'FournisseurToolStripMenuItem
        '
        Me.FournisseurToolStripMenuItem.Name = "FournisseurToolStripMenuItem"
        Me.FournisseurToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.FournisseurToolStripMenuItem.Text = "Fournisseur"
        '
        'RapportsToolStripMenuItem
        '
        Me.RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
        Me.RapportsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RapportsToolStripMenuItem.Text = "Rapports"
        '
        'SécuritéToolStripMenuItem
        '
        Me.SécuritéToolStripMenuItem.Name = "SécuritéToolStripMenuItem"
        Me.SécuritéToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SécuritéToolStripMenuItem.Text = "Sécurité"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 409)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContratToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÉToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FournisseurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SécuritéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
