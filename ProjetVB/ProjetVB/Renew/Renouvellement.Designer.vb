<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Renouvellement
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
        Me.GroupBox1_ClientActuel = New System.Windows.Forms.GroupBox()
        Me.Btn_recherheClient = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Lb_tel = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Lb_rue = New System.Windows.Forms.Label()
        Me.Lb_NoCivique = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Lb_adresse = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox_Entreprise = New System.Windows.Forms.CheckBox()
        Me.CheckBox_pariculier = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Lb_prenom = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lb_NoClient = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxRechercheContrat = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Lb_NoContrat = New System.Windows.Forms.Label()
        Me.GroupBox1_ClientActuel.SuspendLayout()
        Me.GroupBoxRechercheContrat.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1_ClientActuel
        '
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Btn_recherheClient)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox7)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_tel)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox5)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_rue)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_NoCivique)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox4)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_adresse)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox3)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Label1)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.CheckBox_Entreprise)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.CheckBox_pariculier)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox2)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_prenom)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.TextBox1)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_NoClient)
        Me.GroupBox1_ClientActuel.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1_ClientActuel.Name = "GroupBox1_ClientActuel"
        Me.GroupBox1_ClientActuel.Size = New System.Drawing.Size(516, 144)
        Me.GroupBox1_ClientActuel.TabIndex = 13
        Me.GroupBox1_ClientActuel.TabStop = False
        '
        'Btn_recherheClient
        '
        Me.Btn_recherheClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_recherheClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_recherheClient.Location = New System.Drawing.Point(389, 100)
        Me.Btn_recherheClient.Name = "Btn_recherheClient"
        Me.Btn_recherheClient.Size = New System.Drawing.Size(110, 30)
        Me.Btn_recherheClient.TabIndex = 8
        Me.Btn_recherheClient.Text = "Recherche"
        Me.Btn_recherheClient.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(399, 52)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 5
        '
        'Lb_tel
        '
        Me.Lb_tel.AutoSize = True
        Me.Lb_tel.Location = New System.Drawing.Point(332, 55)
        Me.Lb_tel.Name = "Lb_tel"
        Me.Lb_tel.Size = New System.Drawing.Size(61, 13)
        Me.Lb_tel.TabIndex = 14
        Me.Lb_tel.Text = "Téléphone:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(237, 110)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(69, 20)
        Me.TextBox5.TabIndex = 7
        '
        'Lb_rue
        '
        Me.Lb_rue.AutoSize = True
        Me.Lb_rue.Location = New System.Drawing.Point(164, 113)
        Me.Lb_rue.Name = "Lb_rue"
        Me.Lb_rue.Size = New System.Drawing.Size(67, 13)
        Me.Lb_rue.TabIndex = 11
        Me.Lb_rue.Text = "Code Postal:"
        '
        'Lb_NoCivique
        '
        Me.Lb_NoCivique.AutoSize = True
        Me.Lb_NoCivique.Location = New System.Drawing.Point(11, 113)
        Me.Lb_NoCivique.Name = "Lb_NoCivique"
        Me.Lb_NoCivique.Size = New System.Drawing.Size(84, 13)
        Me.Lb_NoCivique.TabIndex = 10
        Me.Lb_NoCivique.Text = "Numéro civique:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(101, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(48, 20)
        Me.TextBox4.TabIndex = 6
        '
        'Lb_adresse
        '
        Me.Lb_adresse.AutoSize = True
        Me.Lb_adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_adresse.Location = New System.Drawing.Point(11, 86)
        Me.Lb_adresse.Name = "Lb_adresse"
        Me.Lb_adresse.Size = New System.Drawing.Size(56, 13)
        Me.Lb_adresse.TabIndex = 8
        Me.Lb_adresse.Text = "Adresse:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(49, 52)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom:"
        '
        'CheckBox_Entreprise
        '
        Me.CheckBox_Entreprise.AutoSize = True
        Me.CheckBox_Entreprise.Location = New System.Drawing.Point(335, 21)
        Me.CheckBox_Entreprise.Name = "CheckBox_Entreprise"
        Me.CheckBox_Entreprise.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox_Entreprise.TabIndex = 5
        Me.CheckBox_Entreprise.Text = "Entreprise"
        Me.CheckBox_Entreprise.UseVisualStyleBackColor = True
        '
        'CheckBox_pariculier
        '
        Me.CheckBox_pariculier.AutoSize = True
        Me.CheckBox_pariculier.Location = New System.Drawing.Point(244, 21)
        Me.CheckBox_pariculier.Name = "CheckBox_pariculier"
        Me.CheckBox_pariculier.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_pariculier.TabIndex = 4
        Me.CheckBox_pariculier.Text = "Particulier"
        Me.CheckBox_pariculier.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(216, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Lb_prenom
        '
        Me.Lb_prenom.AutoSize = True
        Me.Lb_prenom.Location = New System.Drawing.Point(164, 55)
        Me.Lb_prenom.Name = "Lb_prenom"
        Me.Lb_prenom.Size = New System.Drawing.Size(46, 13)
        Me.Lb_prenom.TabIndex = 2
        Me.Lb_prenom.Text = "Prenom:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Lb_NoClient
        '
        Me.Lb_NoClient.AutoSize = True
        Me.Lb_NoClient.Location = New System.Drawing.Point(9, 22)
        Me.Lb_NoClient.Name = "Lb_NoClient"
        Me.Lb_NoClient.Size = New System.Drawing.Size(76, 13)
        Me.Lb_NoClient.TabIndex = 0
        Me.Lb_NoClient.Text = "Numéro Client:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Recherche Client par:"
        '
        'GroupBoxRechercheContrat
        '
        Me.GroupBoxRechercheContrat.Controls.Add(Me.TextBox6)
        Me.GroupBoxRechercheContrat.Controls.Add(Me.Lb_NoContrat)
        Me.GroupBoxRechercheContrat.Location = New System.Drawing.Point(12, 28)
        Me.GroupBoxRechercheContrat.Name = "GroupBoxRechercheContrat"
        Me.GroupBoxRechercheContrat.Size = New System.Drawing.Size(516, 57)
        Me.GroupBoxRechercheContrat.TabIndex = 16
        Me.GroupBoxRechercheContrat.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(88, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(109, 20)
        Me.TextBox6.TabIndex = 1
        '
        'Lb_NoContrat
        '
        Me.Lb_NoContrat.AutoSize = True
        Me.Lb_NoContrat.Location = New System.Drawing.Point(6, 22)
        Me.Lb_NoContrat.Name = "Lb_NoContrat"
        Me.Lb_NoContrat.Size = New System.Drawing.Size(84, 13)
        Me.Lb_NoContrat.TabIndex = 19
        Me.Lb_NoContrat.Text = "Numero Contrat:"
        '
        'Renouvellement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 232)
        Me.Controls.Add(Me.GroupBoxRechercheContrat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1_ClientActuel)
        Me.Name = "Renouvellement"
        Me.Text = "Renew"
        Me.GroupBox1_ClientActuel.ResumeLayout(False)
        Me.GroupBox1_ClientActuel.PerformLayout()
        Me.GroupBoxRechercheContrat.ResumeLayout(False)
        Me.GroupBoxRechercheContrat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1_ClientActuel As GroupBox
    Friend WithEvents Btn_recherheClient As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Lb_tel As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Lb_rue As Label
    Friend WithEvents Lb_NoCivique As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Lb_adresse As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox_Entreprise As CheckBox
    Friend WithEvents CheckBox_pariculier As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Lb_prenom As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lb_NoClient As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBoxRechercheContrat As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Lb_NoContrat As Label
End Class
