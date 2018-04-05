<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choix_Renouvellement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choix_Renouvellement))
        Me.PictureBox_ClientAjouté = New System.Windows.Forms.PictureBox()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.lbl_clientajouté = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox_ClientAjouté, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_ClientAjouté
        '
        Me.PictureBox_ClientAjouté.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox_ClientAjouté.Image = CType(resources.GetObject("PictureBox_ClientAjouté.Image"), System.Drawing.Image)
        Me.PictureBox_ClientAjouté.Location = New System.Drawing.Point(85, 22)
        Me.PictureBox_ClientAjouté.Name = "PictureBox_ClientAjouté"
        Me.PictureBox_ClientAjouté.Size = New System.Drawing.Size(141, 140)
        Me.PictureBox_ClientAjouté.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_ClientAjouté.TabIndex = 7
        Me.PictureBox_ClientAjouté.TabStop = False
        '
        'btnRenew
        '
        Me.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRenew.Location = New System.Drawing.Point(23, 206)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(120, 48)
        Me.btnRenew.TabIndex = 6
        Me.btnRenew.Text = "Conserver équipement et service"
        Me.btnRenew.UseVisualStyleBackColor = True
        '
        'lbl_clientajouté
        '
        Me.lbl_clientajouté.AutoSize = True
        Me.lbl_clientajouté.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientajouté.Location = New System.Drawing.Point(114, 175)
        Me.lbl_clientajouté.Name = "lbl_clientajouté"
        Me.lbl_clientajouté.Size = New System.Drawing.Size(82, 15)
        Me.lbl_clientajouté.TabIndex = 5
        Me.lbl_clientajouté.Text = "Contrat trouvé"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(171, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 48)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Modification équipement et service"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Choix_Renouvellement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(323, 268)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox_ClientAjouté)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.lbl_clientajouté)
        Me.Name = "Choix_Renouvellement"
        Me.Text = "Choix_Renouvellement"
        CType(Me.PictureBox_ClientAjouté, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_ClientAjouté As PictureBox
    Friend WithEvents btnRenew As Button
    Friend WithEvents lbl_clientajouté As Label
    Friend WithEvents Button1 As Button
End Class
