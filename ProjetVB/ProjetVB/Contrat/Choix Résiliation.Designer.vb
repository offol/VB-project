<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choix_Résiliation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choix_Résiliation))
        Me.PictureBox_ClientAjouté = New System.Windows.Forms.PictureBox()
        Me.lbl_clientajouté = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox_ClientAjouté, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_ClientAjouté
        '
        Me.PictureBox_ClientAjouté.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox_ClientAjouté.Image = CType(resources.GetObject("PictureBox_ClientAjouté.Image"), System.Drawing.Image)
        Me.PictureBox_ClientAjouté.Location = New System.Drawing.Point(84, 23)
        Me.PictureBox_ClientAjouté.Name = "PictureBox_ClientAjouté"
        Me.PictureBox_ClientAjouté.Size = New System.Drawing.Size(141, 140)
        Me.PictureBox_ClientAjouté.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_ClientAjouté.TabIndex = 11
        Me.PictureBox_ClientAjouté.TabStop = False
        '
        'lbl_clientajouté
        '
        Me.lbl_clientajouté.AutoSize = True
        Me.lbl_clientajouté.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientajouté.Location = New System.Drawing.Point(113, 176)
        Me.lbl_clientajouté.Name = "lbl_clientajouté"
        Me.lbl_clientajouté.Size = New System.Drawing.Size(82, 15)
        Me.lbl_clientajouté.TabIndex = 9
        Me.lbl_clientajouté.Text = "Contrat trouvé"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Êtes-vous sûr vouloir résilier ce contrat?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(36, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Annuler"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(171, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 30)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Résilier le contrat"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Choix_Résiliation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(315, 292)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox_ClientAjouté)
        Me.Controls.Add(Me.lbl_clientajouté)
        Me.Name = "Choix_Résiliation"
        Me.Text = "Choix_Résiliation"
        CType(Me.PictureBox_ClientAjouté, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_ClientAjouté As PictureBox
    Friend WithEvents lbl_clientajouté As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
