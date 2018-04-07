<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rececption_équipement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnValideréquip = New System.Windows.Forms.Button()
        Me.Gbaccesoires = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.Gbaccesoires.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numéro de série:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 20)
        Me.TextBox1.TabIndex = 1
        '
        'BtnValideréquip
        '
        Me.BtnValideréquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValideréquip.Location = New System.Drawing.Point(325, 17)
        Me.BtnValideréquip.Name = "BtnValideréquip"
        Me.BtnValideréquip.Size = New System.Drawing.Size(75, 23)
        Me.BtnValideréquip.TabIndex = 14
        Me.BtnValideréquip.Text = "Valider"
        Me.BtnValideréquip.UseVisualStyleBackColor = True
        '
        'Gbaccesoires
        '
        Me.Gbaccesoires.Controls.Add(Me.CheckBox4)
        Me.Gbaccesoires.Controls.Add(Me.CheckBox3)
        Me.Gbaccesoires.Controls.Add(Me.CheckBox2)
        Me.Gbaccesoires.Controls.Add(Me.CheckBox1)
        Me.Gbaccesoires.Location = New System.Drawing.Point(15, 128)
        Me.Gbaccesoires.Name = "Gbaccesoires"
        Me.Gbaccesoires.Size = New System.Drawing.Size(385, 62)
        Me.Gbaccesoires.TabIndex = 15
        Me.Gbaccesoires.TabStop = False
        Me.Gbaccesoires.Text = "Accessoires manquants"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(233, 28)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Souris"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(163, 28)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Clavier"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(80, 28)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Moniteur"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Cables"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 62)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "État de l'équipement"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(83, 28)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox5.TabIndex = 3
        Me.CheckBox5.Text = "Endommagé"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(6, 28)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox8.TabIndex = 0
        Me.CheckBox8.Text = "Bon"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'btnComplete
        '
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.Location = New System.Drawing.Point(290, 196)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(110, 30)
        Me.btnComplete.TabIndex = 18
        Me.btnComplete.Text = "Réceptionner"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'Rececption_équipement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 237)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gbaccesoires)
        Me.Controls.Add(Me.BtnValideréquip)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rececption_équipement"
        Me.Text = "Rececption_équipement"
        Me.Gbaccesoires.ResumeLayout(False)
        Me.Gbaccesoires.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnValideréquip As Button
    Friend WithEvents Gbaccesoires As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents btnComplete As Button
End Class
