<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service
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
        Me.GroupBox_ordi = New System.Windows.Forms.GroupBox()
        Me.lblPrixService2 = New System.Windows.Forms.Label()
        Me.lblPrixService1 = New System.Windows.Forms.Label()
        Me.CheckBox_Serv2 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBox_Serv1 = New System.Windows.Forms.CheckBox()
        Me.Btn_servicesave = New System.Windows.Forms.Button()
        Me.CheckBox_Serv5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Serv6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPrixService6 = New System.Windows.Forms.Label()
        Me.lblPrixService5 = New System.Windows.Forms.Label()
        Me.CheckBox_Serv4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Serv3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrixService4 = New System.Windows.Forms.Label()
        Me.lblPrixService3 = New System.Windows.Forms.Label()
        Me.GroupBox_ordi.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_ordi
        '
        Me.GroupBox_ordi.Controls.Add(Me.lblPrixService2)
        Me.GroupBox_ordi.Controls.Add(Me.lblPrixService1)
        Me.GroupBox_ordi.Controls.Add(Me.CheckBox_Serv2)
        Me.GroupBox_ordi.Controls.Add(Me.Label9)
        Me.GroupBox_ordi.Controls.Add(Me.CheckBox_Serv1)
        Me.GroupBox_ordi.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_ordi.Name = "GroupBox_ordi"
        Me.GroupBox_ordi.Size = New System.Drawing.Size(395, 88)
        Me.GroupBox_ordi.TabIndex = 1
        Me.GroupBox_ordi.TabStop = False
        Me.GroupBox_ordi.Text = "Base"
        Me.GroupBox_ordi.UseWaitCursor = True
        '
        'lblPrixService2
        '
        Me.lblPrixService2.AutoSize = True
        Me.lblPrixService2.Location = New System.Drawing.Point(332, 51)
        Me.lblPrixService2.Name = "lblPrixService2"
        Me.lblPrixService2.Size = New System.Drawing.Size(31, 13)
        Me.lblPrixService2.TabIndex = 45
        Me.lblPrixService2.Text = "125$"
        Me.lblPrixService2.UseWaitCursor = True
        '
        'lblPrixService1
        '
        Me.lblPrixService1.AutoSize = True
        Me.lblPrixService1.Location = New System.Drawing.Point(338, 28)
        Me.lblPrixService1.Name = "lblPrixService1"
        Me.lblPrixService1.Size = New System.Drawing.Size(25, 13)
        Me.lblPrixService1.TabIndex = 44
        Me.lblPrixService1.Text = "50$"
        Me.lblPrixService1.UseWaitCursor = True
        '
        'CheckBox_Serv2
        '
        Me.CheckBox_Serv2.AutoSize = True
        Me.CheckBox_Serv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Serv2.Location = New System.Drawing.Point(9, 51)
        Me.CheckBox_Serv2.Name = "CheckBox_Serv2"
        Me.CheckBox_Serv2.Size = New System.Drawing.Size(218, 19)
        Me.CheckBox_Serv2.TabIndex = 43
        Me.CheckBox_Serv2.Text = "#002 Assistance téléphonique"
        Me.CheckBox_Serv2.UseVisualStyleBackColor = True
        Me.CheckBox_Serv2.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 351)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.UseWaitCursor = True
        '
        'CheckBox_Serv1
        '
        Me.CheckBox_Serv1.AutoSize = True
        Me.CheckBox_Serv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Serv1.Location = New System.Drawing.Point(9, 28)
        Me.CheckBox_Serv1.Name = "CheckBox_Serv1"
        Me.CheckBox_Serv1.Size = New System.Drawing.Size(220, 17)
        Me.CheckBox_Serv1.TabIndex = 1
        Me.CheckBox_Serv1.Text = "#001 Installation des équipements"
        Me.CheckBox_Serv1.UseVisualStyleBackColor = True
        Me.CheckBox_Serv1.UseWaitCursor = True
        '
        'Btn_servicesave
        '
        Me.Btn_servicesave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_servicesave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_servicesave.Location = New System.Drawing.Point(318, 278)
        Me.Btn_servicesave.Name = "Btn_servicesave"
        Me.Btn_servicesave.Size = New System.Drawing.Size(89, 30)
        Me.Btn_servicesave.TabIndex = 54
        Me.Btn_servicesave.Text = "Ajouter"
        Me.Btn_servicesave.UseVisualStyleBackColor = True
        '
        'CheckBox_Serv5
        '
        Me.CheckBox_Serv5.AutoSize = True
        Me.CheckBox_Serv5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Serv5.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox_Serv5.Name = "CheckBox_Serv5"
        Me.CheckBox_Serv5.Size = New System.Drawing.Size(247, 19)
        Me.CheckBox_Serv5.TabIndex = 65
        Me.CheckBox_Serv5.Text = "#005 Réparation des équipements"
        Me.CheckBox_Serv5.UseVisualStyleBackColor = True
        Me.CheckBox_Serv5.UseWaitCursor = True
        '
        'CheckBox_Serv6
        '
        Me.CheckBox_Serv6.AutoSize = True
        Me.CheckBox_Serv6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Serv6.Location = New System.Drawing.Point(6, 54)
        Me.CheckBox_Serv6.Name = "CheckBox_Serv6"
        Me.CheckBox_Serv6.Size = New System.Drawing.Size(263, 19)
        Me.CheckBox_Serv6.TabIndex = 64
        Me.CheckBox_Serv6.Text = "#006 Programmation des pages Web"
        Me.CheckBox_Serv6.UseVisualStyleBackColor = True
        Me.CheckBox_Serv6.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPrixService6)
        Me.GroupBox2.Controls.Add(Me.lblPrixService5)
        Me.GroupBox2.Controls.Add(Me.CheckBox_Serv6)
        Me.GroupBox2.Controls.Add(Me.CheckBox_Serv5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 79)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Premium"
        '
        'lblPrixService6
        '
        Me.lblPrixService6.AutoSize = True
        Me.lblPrixService6.Location = New System.Drawing.Point(332, 57)
        Me.lblPrixService6.Name = "lblPrixService6"
        Me.lblPrixService6.Size = New System.Drawing.Size(31, 13)
        Me.lblPrixService6.TabIndex = 67
        Me.lblPrixService6.Text = "600$"
        '
        'lblPrixService5
        '
        Me.lblPrixService5.AutoSize = True
        Me.lblPrixService5.Location = New System.Drawing.Point(332, 32)
        Me.lblPrixService5.Name = "lblPrixService5"
        Me.lblPrixService5.Size = New System.Drawing.Size(31, 13)
        Me.lblPrixService5.TabIndex = 66
        Me.lblPrixService5.Text = "425$"
        '
        'CheckBox_Serv4
        '
        Me.CheckBox_Serv4.AutoSize = True
        Me.CheckBox_Serv4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Serv4.Location = New System.Drawing.Point(9, 53)
        Me.CheckBox_Serv4.Name = "CheckBox_Serv4"
        Me.CheckBox_Serv4.Size = New System.Drawing.Size(310, 19)
        Me.CheckBox_Serv4.TabIndex = 66
        Me.CheckBox_Serv4.Text = "#004 Impression des rapports et statistiques"
        Me.CheckBox_Serv4.UseVisualStyleBackColor = True
        Me.CheckBox_Serv4.UseWaitCursor = True
        '
        'CheckBox_Serv3
        '
        Me.CheckBox_Serv3.AutoSize = True
        Me.CheckBox_Serv3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Serv3.Location = New System.Drawing.Point(9, 28)
        Me.CheckBox_Serv3.Name = "CheckBox_Serv3"
        Me.CheckBox_Serv3.Size = New System.Drawing.Size(215, 19)
        Me.CheckBox_Serv3.TabIndex = 63
        Me.CheckBox_Serv3.Text = "#003 Formation du personnel"
        Me.CheckBox_Serv3.UseVisualStyleBackColor = True
        Me.CheckBox_Serv3.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrixService4)
        Me.GroupBox1.Controls.Add(Me.lblPrixService3)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Serv3)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Serv4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 81)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plus"
        '
        'lblPrixService4
        '
        Me.lblPrixService4.AutoSize = True
        Me.lblPrixService4.Location = New System.Drawing.Point(332, 56)
        Me.lblPrixService4.Name = "lblPrixService4"
        Me.lblPrixService4.Size = New System.Drawing.Size(31, 13)
        Me.lblPrixService4.TabIndex = 67
        Me.lblPrixService4.Text = "300$"
        '
        'lblPrixService3
        '
        Me.lblPrixService3.AutoSize = True
        Me.lblPrixService3.Location = New System.Drawing.Point(332, 31)
        Me.lblPrixService3.Name = "lblPrixService3"
        Me.lblPrixService3.Size = New System.Drawing.Size(31, 13)
        Me.lblPrixService3.TabIndex = 46
        Me.lblPrixService3.Text = "325$"
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 321)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_servicesave)
        Me.Controls.Add(Me.GroupBox_ordi)
        Me.Name = "Service"
        Me.Text = "Service"
        Me.GroupBox_ordi.ResumeLayout(False)
        Me.GroupBox_ordi.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_ordi As GroupBox
    Friend WithEvents CheckBox_Serv2 As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CheckBox_Serv1 As CheckBox
    Friend WithEvents Btn_servicesave As Button
    Friend WithEvents CheckBox_Serv5 As CheckBox
    Friend WithEvents CheckBox_Serv6 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPrixService2 As Label
    Friend WithEvents lblPrixService1 As Label
    Friend WithEvents lblPrixService6 As Label
    Friend WithEvents lblPrixService5 As Label
    Friend WithEvents CheckBox_Serv4 As CheckBox
    Friend WithEvents CheckBox_Serv3 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPrixService4 As Label
    Friend WithEvents lblPrixService3 As Label
End Class
