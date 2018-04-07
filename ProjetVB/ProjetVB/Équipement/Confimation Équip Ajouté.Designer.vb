<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confication_Équip_Ajouté
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confication_Équip_Ajouté))
        Me.PictureBox_ClientAjouté = New System.Windows.Forms.PictureBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lbl_equipajouté = New System.Windows.Forms.Label()
        CType(Me.PictureBox_ClientAjouté, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_ClientAjouté
        '
        Me.PictureBox_ClientAjouté.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox_ClientAjouté.Image = CType(resources.GetObject("PictureBox_ClientAjouté.Image"), System.Drawing.Image)
        Me.PictureBox_ClientAjouté.Location = New System.Drawing.Point(50, 9)
        Me.PictureBox_ClientAjouté.Name = "PictureBox_ClientAjouté"
        Me.PictureBox_ClientAjouté.Size = New System.Drawing.Size(141, 140)
        Me.PictureBox_ClientAjouté.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_ClientAjouté.TabIndex = 7
        Me.PictureBox_ClientAjouté.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Location = New System.Drawing.Point(86, 189)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lbl_equipajouté
        '
        Me.lbl_equipajouté.AutoSize = True
        Me.lbl_equipajouté.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_equipajouté.Location = New System.Drawing.Point(30, 162)
        Me.lbl_equipajouté.Name = "lbl_equipajouté"
        Me.lbl_equipajouté.Size = New System.Drawing.Size(180, 15)
        Me.lbl_equipajouté.TabIndex = 5
        Me.lbl_equipajouté.Text = "Équipement ajouté avec succès"
        '
        'Confication_Équip_Ajouté
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(249, 221)
        Me.Controls.Add(Me.PictureBox_ClientAjouté)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lbl_equipajouté)
        Me.Name = "Confication_Équip_Ajouté"
        Me.Text = "Confication_Équip_Ajouté"
        CType(Me.PictureBox_ClientAjouté, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_ClientAjouté As PictureBox
    Friend WithEvents btnOK As Button
    Friend WithEvents lbl_equipajouté As Label
End Class
