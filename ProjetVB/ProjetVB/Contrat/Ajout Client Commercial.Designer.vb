<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Client_Commercial
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
        Me.GroupBox_AjoutcltCom_com = New System.Windows.Forms.GroupBox()
        Me.lbl_adressefact = New System.Windows.Forms.Label()
        Me.ComboBox_Adressefact_Prov = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Adressefact_rue = New System.Windows.Forms.TextBox()
        Me.Lbl_AdressefactRue = New System.Windows.Forms.Label()
        Me.Adressefact_codepostale = New System.Windows.Forms.TextBox()
        Me.Lbl_AdressefactCodepostale = New System.Windows.Forms.Label()
        Me.lbl_adressefact_No = New System.Windows.Forms.Label()
        Me.Adressefact_no = New System.Windows.Forms.TextBox()
        Me.CheckBox_courriel = New System.Windows.Forms.CheckBox()
        Me.CheckBox_poste = New System.Windows.Forms.CheckBox()
        Me.Lbl_fact = New System.Windows.Forms.Label()
        Me.Lbl_langue = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Lbl_Adressefact_courriel = New System.Windows.Forms.Label()
        Me.CheckBox_Anglais = New System.Windows.Forms.CheckBox()
        Me.CheckBox_francais = New System.Windows.Forms.CheckBox()
        Me.Lbl_NEQ = New System.Windows.Forms.Label()
        Me.NEQ = New System.Windows.Forms.TextBox()
        Me.AjoutcltCom_telecop = New System.Windows.Forms.TextBox()
        Me.lbl_AjoutcltCom_telecop = New System.Windows.Forms.Label()
        Me.AjoutcltCom_Web = New System.Windows.Forms.TextBox()
        Me.lb_AjoutcltCom_Web = New System.Windows.Forms.Label()
        Me.AjoutcltCom_Domaine = New System.Windows.Forms.TextBox()
        Me.Lbl_AjoutcltCom_Domaine = New System.Windows.Forms.Label()
        Me.AjoutcltCom_Société = New System.Windows.Forms.TextBox()
        Me.Lbl_AjoutcltCom_Société = New System.Windows.Forms.Label()
        Me.ComboBox_AjoutcltCom_prov = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rue = New System.Windows.Forms.TextBox()
        Me.Lbl_rue = New System.Windows.Forms.Label()
        Me.NoClient = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_AjoutcltCom_Birth = New System.Windows.Forms.Label()
        Me.AjoutcltCom_tel = New System.Windows.Forms.TextBox()
        Me.Lb_tel = New System.Windows.Forms.Label()
        Me.CodePostale = New System.Windows.Forms.TextBox()
        Me.Lb_CodePostale = New System.Windows.Forms.Label()
        Me.Lb_NoCivique = New System.Windows.Forms.Label()
        Me.NoCivique = New System.Windows.Forms.TextBox()
        Me.Lb_adresse = New System.Windows.Forms.Label()
        Me.AjoutcltCom_nom = New System.Windows.Forms.TextBox()
        Me.Lbl_AjoutcltCom_nom = New System.Windows.Forms.Label()
        Me.AjoutcltCom_prenom = New System.Windows.Forms.TextBox()
        Me.Lb_prenom = New System.Windows.Forms.Label()
        Me.Lb_NoClient = New System.Windows.Forms.Label()
        Me.Btn_CréerCltCom = New System.Windows.Forms.Button()
        Me.GroupBox_mandataireCom = New System.Windows.Forms.GroupBox()
        Me.mandajeunefille = New System.Windows.Forms.TextBox()
        Me.lbl_mandajeunefille = New System.Windows.Forms.Label()
        Me.DateTimePicker_mandaBirth = New System.Windows.Forms.DateTimePicker()
        Me.lbl_mandaBirth = New System.Windows.Forms.Label()
        Me.mandaTel = New System.Windows.Forms.TextBox()
        Me.lbl_mandaTel = New System.Windows.Forms.Label()
        Me.mandaNom = New System.Windows.Forms.TextBox()
        Me.lbl_mandaNom = New System.Windows.Forms.Label()
        Me.mandaprenom = New System.Windows.Forms.TextBox()
        Me.Lbl_mandaprenom = New System.Windows.Forms.Label()
        Me.GroupBox1_ClientActuel.SuspendLayout()
        Me.GroupBox_AjoutcltCom_com.SuspendLayout()
        Me.GroupBox_mandataireCom.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1_ClientActuel
        '
        Me.GroupBox1_ClientActuel.Controls.Add(Me.GroupBox_AjoutcltCom_com)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lbl_NEQ)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.NEQ)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.AjoutcltCom_telecop)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.lbl_AjoutcltCom_telecop)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.AjoutcltCom_Web)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.lb_AjoutcltCom_Web)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.AjoutcltCom_Domaine)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lbl_AjoutcltCom_Domaine)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.AjoutcltCom_Société)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lbl_AjoutcltCom_Société)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.ComboBox_AjoutcltCom_prov)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Label5)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.rue)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lbl_rue)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.NoClient)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lbl_AjoutcltCom_Birth)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.AjoutcltCom_tel)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_tel)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.CodePostale)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_CodePostale)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_NoCivique)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.NoCivique)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_adresse)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.AjoutcltCom_nom)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lbl_AjoutcltCom_nom)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.AjoutcltCom_prenom)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_prenom)
        Me.GroupBox1_ClientActuel.Controls.Add(Me.Lb_NoClient)
        Me.GroupBox1_ClientActuel.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1_ClientActuel.Name = "GroupBox1_ClientActuel"
        Me.GroupBox1_ClientActuel.Size = New System.Drawing.Size(520, 535)
        Me.GroupBox1_ClientActuel.TabIndex = 15
        Me.GroupBox1_ClientActuel.TabStop = False
        '
        'GroupBox_AjoutcltCom_com
        '
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.lbl_adressefact)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.ComboBox_Adressefact_Prov)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Label20)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Adressefact_rue)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Lbl_AdressefactRue)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Adressefact_codepostale)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Lbl_AdressefactCodepostale)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.lbl_adressefact_No)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Adressefact_no)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.CheckBox_courriel)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.CheckBox_poste)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Lbl_fact)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Lbl_langue)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.TextBox13)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.Lbl_Adressefact_courriel)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.CheckBox_Anglais)
        Me.GroupBox_AjoutcltCom_com.Controls.Add(Me.CheckBox_francais)
        Me.GroupBox_AjoutcltCom_com.Location = New System.Drawing.Point(0, 223)
        Me.GroupBox_AjoutcltCom_com.Name = "GroupBox_AjoutcltCom_com"
        Me.GroupBox_AjoutcltCom_com.Size = New System.Drawing.Size(520, 223)
        Me.GroupBox_AjoutcltCom_com.TabIndex = 39
        Me.GroupBox_AjoutcltCom_com.TabStop = False
        Me.GroupBox_AjoutcltCom_com.Text = "Communication"
        '
        'lbl_adressefact
        '
        Me.lbl_adressefact.AutoSize = True
        Me.lbl_adressefact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adressefact.Location = New System.Drawing.Point(11, 115)
        Me.lbl_adressefact.Name = "lbl_adressefact"
        Me.lbl_adressefact.Size = New System.Drawing.Size(160, 13)
        Me.lbl_adressefact.TabIndex = 55
        Me.lbl_adressefact.Text = "Adresse de facturation différente"
        '
        'ComboBox_Adressefact_Prov
        '
        Me.ComboBox_Adressefact_Prov.FormattingEnabled = True
        Me.ComboBox_Adressefact_Prov.Items.AddRange(New Object() {"L'Alberta", "La Colombie-Britannique", "L'Île-du-Prince-Édouard", "Le Manitoba", "Le Nouveau-Brunswick", "La Nouvelle-Écosse", "L'Ontario", "Le Québec", "La Saskatchewan", "Terre-Neuve et Labrador", "Les Territoires du Nord-Ouest", "Le Nunavut", "Le Yukon"})
        Me.ComboBox_Adressefact_Prov.Location = New System.Drawing.Point(301, 152)
        Me.ComboBox_Adressefact_Prov.Name = "ComboBox_Adressefact_Prov"
        Me.ComboBox_Adressefact_Prov.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox_Adressefact_Prov.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(246, 156)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Province"
        '
        'Adressefact_rue
        '
        Me.Adressefact_rue.Location = New System.Drawing.Point(47, 153)
        Me.Adressefact_rue.Name = "Adressefact_rue"
        Me.Adressefact_rue.Size = New System.Drawing.Size(184, 20)
        Me.Adressefact_rue.TabIndex = 21
        '
        'Lbl_AdressefactRue
        '
        Me.Lbl_AdressefactRue.AutoSize = True
        Me.Lbl_AdressefactRue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AdressefactRue.Location = New System.Drawing.Point(12, 156)
        Me.Lbl_AdressefactRue.Name = "Lbl_AdressefactRue"
        Me.Lbl_AdressefactRue.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_AdressefactRue.TabIndex = 51
        Me.Lbl_AdressefactRue.Text = "Rue:"
        '
        'Adressefact_codepostale
        '
        Me.Adressefact_codepostale.Location = New System.Drawing.Point(237, 131)
        Me.Adressefact_codepostale.Name = "Adressefact_codepostale"
        Me.Adressefact_codepostale.Size = New System.Drawing.Size(69, 20)
        Me.Adressefact_codepostale.TabIndex = 20
        '
        'Lbl_AdressefactCodepostale
        '
        Me.Lbl_AdressefactCodepostale.AutoSize = True
        Me.Lbl_AdressefactCodepostale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AdressefactCodepostale.Location = New System.Drawing.Point(164, 134)
        Me.Lbl_AdressefactCodepostale.Name = "Lbl_AdressefactCodepostale"
        Me.Lbl_AdressefactCodepostale.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_AdressefactCodepostale.TabIndex = 49
        Me.Lbl_AdressefactCodepostale.Text = "Code Postal:"
        '
        'lbl_adressefact_No
        '
        Me.lbl_adressefact_No.AutoSize = True
        Me.lbl_adressefact_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adressefact_No.Location = New System.Drawing.Point(11, 134)
        Me.lbl_adressefact_No.Name = "lbl_adressefact_No"
        Me.lbl_adressefact_No.Size = New System.Drawing.Size(84, 13)
        Me.lbl_adressefact_No.TabIndex = 48
        Me.lbl_adressefact_No.Text = "Numéro civique:"
        '
        'Adressefact_no
        '
        Me.Adressefact_no.Location = New System.Drawing.Point(101, 131)
        Me.Adressefact_no.Name = "Adressefact_no"
        Me.Adressefact_no.Size = New System.Drawing.Size(48, 20)
        Me.Adressefact_no.TabIndex = 19
        '
        'CheckBox_courriel
        '
        Me.CheckBox_courriel.AutoSize = True
        Me.CheckBox_courriel.Location = New System.Drawing.Point(87, 87)
        Me.CheckBox_courriel.Name = "CheckBox_courriel"
        Me.CheckBox_courriel.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox_courriel.TabIndex = 18
        Me.CheckBox_courriel.Text = "Courriel"
        Me.CheckBox_courriel.UseVisualStyleBackColor = True
        '
        'CheckBox_poste
        '
        Me.CheckBox_poste.AutoSize = True
        Me.CheckBox_poste.Location = New System.Drawing.Point(15, 87)
        Me.CheckBox_poste.Name = "CheckBox_poste"
        Me.CheckBox_poste.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox_poste.TabIndex = 17
        Me.CheckBox_poste.Text = "Poste"
        Me.CheckBox_poste.UseVisualStyleBackColor = True
        '
        'Lbl_fact
        '
        Me.Lbl_fact.AutoSize = True
        Me.Lbl_fact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_fact.Location = New System.Drawing.Point(10, 71)
        Me.Lbl_fact.Name = "Lbl_fact"
        Me.Lbl_fact.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_fact.TabIndex = 11
        Me.Lbl_fact.Text = "Facturation"
        '
        'Lbl_langue
        '
        Me.Lbl_langue.AutoSize = True
        Me.Lbl_langue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_langue.Location = New System.Drawing.Point(12, 26)
        Me.Lbl_langue.Name = "Lbl_langue"
        Me.Lbl_langue.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_langue.TabIndex = 10
        Me.Lbl_langue.Text = "Langue"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(63, 186)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(221, 20)
        Me.TextBox13.TabIndex = 23
        '
        'Lbl_Adressefact_courriel
        '
        Me.Lbl_Adressefact_courriel.AutoSize = True
        Me.Lbl_Adressefact_courriel.Location = New System.Drawing.Point(12, 189)
        Me.Lbl_Adressefact_courriel.Name = "Lbl_Adressefact_courriel"
        Me.Lbl_Adressefact_courriel.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_Adressefact_courriel.TabIndex = 8
        Me.Lbl_Adressefact_courriel.Text = "Courriel:"
        '
        'CheckBox_Anglais
        '
        Me.CheckBox_Anglais.AutoSize = True
        Me.CheckBox_Anglais.Location = New System.Drawing.Point(87, 42)
        Me.CheckBox_Anglais.Name = "CheckBox_Anglais"
        Me.CheckBox_Anglais.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox_Anglais.TabIndex = 16
        Me.CheckBox_Anglais.Text = "Anglais"
        Me.CheckBox_Anglais.UseVisualStyleBackColor = True
        '
        'CheckBox_francais
        '
        Me.CheckBox_francais.AutoSize = True
        Me.CheckBox_francais.Location = New System.Drawing.Point(15, 42)
        Me.CheckBox_francais.Name = "CheckBox_francais"
        Me.CheckBox_francais.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox_francais.TabIndex = 15
        Me.CheckBox_francais.Text = "Français"
        Me.CheckBox_francais.UseVisualStyleBackColor = True
        '
        'Lbl_NEQ
        '
        Me.Lbl_NEQ.AutoSize = True
        Me.Lbl_NEQ.Location = New System.Drawing.Point(301, 18)
        Me.Lbl_NEQ.Name = "Lbl_NEQ"
        Me.Lbl_NEQ.Size = New System.Drawing.Size(136, 13)
        Me.Lbl_NEQ.TabIndex = 38
        Me.Lbl_NEQ.Text = "Numéro d'entreprise (NEQ):"
        '
        'NEQ
        '
        Me.NEQ.Location = New System.Drawing.Point(443, 15)
        Me.NEQ.Name = "NEQ"
        Me.NEQ.Size = New System.Drawing.Size(64, 20)
        Me.NEQ.TabIndex = 2
        '
        'AjoutcltCom_telecop
        '
        Me.AjoutcltCom_telecop.Location = New System.Drawing.Point(321, 126)
        Me.AjoutcltCom_telecop.Name = "AjoutcltCom_telecop"
        Me.AjoutcltCom_telecop.Size = New System.Drawing.Size(186, 20)
        Me.AjoutcltCom_telecop.TabIndex = 10
        '
        'lbl_AjoutcltCom_telecop
        '
        Me.lbl_AjoutcltCom_telecop.AutoSize = True
        Me.lbl_AjoutcltCom_telecop.Location = New System.Drawing.Point(254, 129)
        Me.lbl_AjoutcltCom_telecop.Name = "lbl_AjoutcltCom_telecop"
        Me.lbl_AjoutcltCom_telecop.Size = New System.Drawing.Size(66, 13)
        Me.lbl_AjoutcltCom_telecop.TabIndex = 35
        Me.lbl_AjoutcltCom_telecop.Text = "Télécopieur:"
        '
        'AjoutcltCom_Web
        '
        Me.AjoutcltCom_Web.Location = New System.Drawing.Point(312, 102)
        Me.AjoutcltCom_Web.Name = "AjoutcltCom_Web"
        Me.AjoutcltCom_Web.Size = New System.Drawing.Size(195, 20)
        Me.AjoutcltCom_Web.TabIndex = 9
        '
        'lb_AjoutcltCom_Web
        '
        Me.lb_AjoutcltCom_Web.AutoSize = True
        Me.lb_AjoutcltCom_Web.Location = New System.Drawing.Point(254, 105)
        Me.lb_AjoutcltCom_Web.Name = "lb_AjoutcltCom_Web"
        Me.lb_AjoutcltCom_Web.Size = New System.Drawing.Size(54, 13)
        Me.lb_AjoutcltCom_Web.TabIndex = 33
        Me.lb_AjoutcltCom_Web.Text = "Site Web:"
        '
        'AjoutcltCom_Domaine
        '
        Me.AjoutcltCom_Domaine.Location = New System.Drawing.Point(312, 77)
        Me.AjoutcltCom_Domaine.Name = "AjoutcltCom_Domaine"
        Me.AjoutcltCom_Domaine.Size = New System.Drawing.Size(195, 20)
        Me.AjoutcltCom_Domaine.TabIndex = 8
        '
        'Lbl_AjoutcltCom_Domaine
        '
        Me.Lbl_AjoutcltCom_Domaine.AutoSize = True
        Me.Lbl_AjoutcltCom_Domaine.Location = New System.Drawing.Point(254, 80)
        Me.Lbl_AjoutcltCom_Domaine.Name = "Lbl_AjoutcltCom_Domaine"
        Me.Lbl_AjoutcltCom_Domaine.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_AjoutcltCom_Domaine.TabIndex = 31
        Me.Lbl_AjoutcltCom_Domaine.Text = "Domaine:"
        '
        'AjoutcltCom_Société
        '
        Me.AjoutcltCom_Société.Location = New System.Drawing.Point(357, 54)
        Me.AjoutcltCom_Société.Name = "AjoutcltCom_Société"
        Me.AjoutcltCom_Société.Size = New System.Drawing.Size(150, 20)
        Me.AjoutcltCom_Société.TabIndex = 7
        '
        'Lbl_AjoutcltCom_Société
        '
        Me.Lbl_AjoutcltCom_Société.AutoSize = True
        Me.Lbl_AjoutcltCom_Société.Location = New System.Drawing.Point(254, 57)
        Me.Lbl_AjoutcltCom_Société.Name = "Lbl_AjoutcltCom_Société"
        Me.Lbl_AjoutcltCom_Société.Size = New System.Drawing.Size(97, 13)
        Me.Lbl_AjoutcltCom_Société.TabIndex = 29
        Me.Lbl_AjoutcltCom_Société.Text = "Nom de la Société:"
        '
        'ComboBox_AjoutcltCom_prov
        '
        Me.ComboBox_AjoutcltCom_prov.FormattingEnabled = True
        Me.ComboBox_AjoutcltCom_prov.Items.AddRange(New Object() {"L'Alberta", "La Colombie-Britannique", "L'Île-du-Prince-Édouard", "Le Manitoba", "Le Nouveau-Brunswick", "La Nouvelle-Écosse", "L'Ontario", "Le Québec", "La Saskatchewan", "Terre-Neuve et Labrador", "Les Territoires du Nord-Ouest", "Le Nunavut", "Le Yukon"})
        Me.ComboBox_AjoutcltCom_prov.Location = New System.Drawing.Point(300, 196)
        Me.ComboBox_AjoutcltCom_prov.Name = "ComboBox_AjoutcltCom_prov"
        Me.ComboBox_AjoutcltCom_prov.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox_AjoutcltCom_prov.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Province"
        '
        'rue
        '
        Me.rue.Location = New System.Drawing.Point(46, 197)
        Me.rue.Name = "rue"
        Me.rue.Size = New System.Drawing.Size(184, 20)
        Me.rue.TabIndex = 13
        '
        'Lbl_rue
        '
        Me.Lbl_rue.AutoSize = True
        Me.Lbl_rue.Location = New System.Drawing.Point(11, 200)
        Me.Lbl_rue.Name = "Lbl_rue"
        Me.Lbl_rue.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_rue.TabIndex = 23
        Me.Lbl_rue.Text = "Rue:"
        '
        'NoClient
        '
        Me.NoClient.Location = New System.Drawing.Point(130, 15)
        Me.NoClient.Name = "NoClient"
        Me.NoClient.Size = New System.Drawing.Size(127, 20)
        Me.NoClient.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(114, 99)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Lbl_AjoutcltCom_Birth
        '
        Me.Lbl_AjoutcltCom_Birth.AutoSize = True
        Me.Lbl_AjoutcltCom_Birth.Location = New System.Drawing.Point(10, 102)
        Me.Lbl_AjoutcltCom_Birth.Name = "Lbl_AjoutcltCom_Birth"
        Me.Lbl_AjoutcltCom_Birth.Size = New System.Drawing.Size(96, 13)
        Me.Lbl_AjoutcltCom_Birth.TabIndex = 16
        Me.Lbl_AjoutcltCom_Birth.Text = "Date de naissance"
        '
        'AjoutcltCom_tel
        '
        Me.AjoutcltCom_tel.Location = New System.Drawing.Point(78, 122)
        Me.AjoutcltCom_tel.Name = "AjoutcltCom_tel"
        Me.AjoutcltCom_tel.Size = New System.Drawing.Size(140, 20)
        Me.AjoutcltCom_tel.TabIndex = 6
        '
        'Lb_tel
        '
        Me.Lb_tel.AutoSize = True
        Me.Lb_tel.Location = New System.Drawing.Point(10, 125)
        Me.Lb_tel.Name = "Lb_tel"
        Me.Lb_tel.Size = New System.Drawing.Size(61, 13)
        Me.Lb_tel.TabIndex = 14
        Me.Lb_tel.Text = "Téléphone:"
        '
        'CodePostale
        '
        Me.CodePostale.Location = New System.Drawing.Point(236, 172)
        Me.CodePostale.Name = "CodePostale"
        Me.CodePostale.Size = New System.Drawing.Size(69, 20)
        Me.CodePostale.TabIndex = 12
        '
        'Lb_CodePostale
        '
        Me.Lb_CodePostale.AutoSize = True
        Me.Lb_CodePostale.Location = New System.Drawing.Point(163, 175)
        Me.Lb_CodePostale.Name = "Lb_CodePostale"
        Me.Lb_CodePostale.Size = New System.Drawing.Size(67, 13)
        Me.Lb_CodePostale.TabIndex = 11
        Me.Lb_CodePostale.Text = "Code Postal:"
        '
        'Lb_NoCivique
        '
        Me.Lb_NoCivique.AutoSize = True
        Me.Lb_NoCivique.Location = New System.Drawing.Point(10, 175)
        Me.Lb_NoCivique.Name = "Lb_NoCivique"
        Me.Lb_NoCivique.Size = New System.Drawing.Size(84, 13)
        Me.Lb_NoCivique.TabIndex = 10
        Me.Lb_NoCivique.Text = "Numéro civique:"
        '
        'NoCivique
        '
        Me.NoCivique.Location = New System.Drawing.Point(100, 172)
        Me.NoCivique.Name = "NoCivique"
        Me.NoCivique.Size = New System.Drawing.Size(48, 20)
        Me.NoCivique.TabIndex = 11
        '
        'Lb_adresse
        '
        Me.Lb_adresse.AutoSize = True
        Me.Lb_adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_adresse.Location = New System.Drawing.Point(11, 151)
        Me.Lb_adresse.Name = "Lb_adresse"
        Me.Lb_adresse.Size = New System.Drawing.Size(56, 13)
        Me.Lb_adresse.TabIndex = 8
        Me.Lb_adresse.Text = "Adresse:"
        '
        'AjoutcltCom_nom
        '
        Me.AjoutcltCom_nom.Location = New System.Drawing.Point(49, 54)
        Me.AjoutcltCom_nom.Name = "AjoutcltCom_nom"
        Me.AjoutcltCom_nom.Size = New System.Drawing.Size(169, 20)
        Me.AjoutcltCom_nom.TabIndex = 3
        '
        'Lbl_AjoutcltCom_nom
        '
        Me.Lbl_AjoutcltCom_nom.AutoSize = True
        Me.Lbl_AjoutcltCom_nom.Location = New System.Drawing.Point(10, 57)
        Me.Lbl_AjoutcltCom_nom.Name = "Lbl_AjoutcltCom_nom"
        Me.Lbl_AjoutcltCom_nom.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_AjoutcltCom_nom.TabIndex = 6
        Me.Lbl_AjoutcltCom_nom.Text = "Nom:"
        '
        'AjoutcltCom_prenom
        '
        Me.AjoutcltCom_prenom.Location = New System.Drawing.Point(62, 77)
        Me.AjoutcltCom_prenom.Name = "AjoutcltCom_prenom"
        Me.AjoutcltCom_prenom.Size = New System.Drawing.Size(156, 20)
        Me.AjoutcltCom_prenom.TabIndex = 4
        '
        'Lb_prenom
        '
        Me.Lb_prenom.AutoSize = True
        Me.Lb_prenom.Location = New System.Drawing.Point(10, 80)
        Me.Lb_prenom.Name = "Lb_prenom"
        Me.Lb_prenom.Size = New System.Drawing.Size(46, 13)
        Me.Lb_prenom.TabIndex = 2
        Me.Lb_prenom.Text = "Prenom:"
        '
        'Lb_NoClient
        '
        Me.Lb_NoClient.AutoSize = True
        Me.Lb_NoClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NoClient.Location = New System.Drawing.Point(11, 16)
        Me.Lb_NoClient.Name = "Lb_NoClient"
        Me.Lb_NoClient.Size = New System.Drawing.Size(113, 16)
        Me.Lb_NoClient.TabIndex = 0
        Me.Lb_NoClient.Text = "Numéro Client: "
        '
        'Btn_CréerCltCom
        '
        Me.Btn_CréerCltCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_CréerCltCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CréerCltCom.Location = New System.Drawing.Point(422, 559)
        Me.Btn_CréerCltCom.Name = "Btn_CréerCltCom"
        Me.Btn_CréerCltCom.Size = New System.Drawing.Size(110, 30)
        Me.Btn_CréerCltCom.TabIndex = 32
        Me.Btn_CréerCltCom.Text = "Créer"
        Me.Btn_CréerCltCom.UseVisualStyleBackColor = True
        '
        'GroupBox_mandataireCom
        '
        Me.GroupBox_mandataireCom.Controls.Add(Me.mandajeunefille)
        Me.GroupBox_mandataireCom.Controls.Add(Me.lbl_mandajeunefille)
        Me.GroupBox_mandataireCom.Controls.Add(Me.DateTimePicker_mandaBirth)
        Me.GroupBox_mandataireCom.Controls.Add(Me.lbl_mandaBirth)
        Me.GroupBox_mandataireCom.Controls.Add(Me.mandaTel)
        Me.GroupBox_mandataireCom.Controls.Add(Me.lbl_mandaTel)
        Me.GroupBox_mandataireCom.Controls.Add(Me.mandaNom)
        Me.GroupBox_mandataireCom.Controls.Add(Me.lbl_mandaNom)
        Me.GroupBox_mandataireCom.Controls.Add(Me.mandaprenom)
        Me.GroupBox_mandataireCom.Controls.Add(Me.Lbl_mandaprenom)
        Me.GroupBox_mandataireCom.Location = New System.Drawing.Point(12, 447)
        Me.GroupBox_mandataireCom.Name = "GroupBox_mandataireCom"
        Me.GroupBox_mandataireCom.Size = New System.Drawing.Size(520, 106)
        Me.GroupBox_mandataireCom.TabIndex = 33
        Me.GroupBox_mandataireCom.TabStop = False
        Me.GroupBox_mandataireCom.Text = "Mandataire"
        '
        'mandajeunefille
        '
        Me.mandajeunefille.Location = New System.Drawing.Point(387, 59)
        Me.mandajeunefille.Name = "mandajeunefille"
        Me.mandajeunefille.Size = New System.Drawing.Size(117, 20)
        Me.mandajeunefille.TabIndex = 28
        '
        'lbl_mandajeunefille
        '
        Me.lbl_mandajeunefille.AutoSize = True
        Me.lbl_mandajeunefille.Location = New System.Drawing.Point(235, 65)
        Me.lbl_mandajeunefille.Name = "lbl_mandajeunefille"
        Me.lbl_mandajeunefille.Size = New System.Drawing.Size(146, 13)
        Me.lbl_mandajeunefille.TabIndex = 30
        Me.lbl_mandajeunefille.Text = "Nom de jeune fille de la mère:"
        '
        'DateTimePicker_mandaBirth
        '
        Me.DateTimePicker_mandaBirth.Location = New System.Drawing.Point(114, 59)
        Me.DateTimePicker_mandaBirth.Name = "DateTimePicker_mandaBirth"
        Me.DateTimePicker_mandaBirth.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker_mandaBirth.TabIndex = 27
        '
        'lbl_mandaBirth
        '
        Me.lbl_mandaBirth.AutoSize = True
        Me.lbl_mandaBirth.Location = New System.Drawing.Point(12, 65)
        Me.lbl_mandaBirth.Name = "lbl_mandaBirth"
        Me.lbl_mandaBirth.Size = New System.Drawing.Size(99, 13)
        Me.lbl_mandaBirth.TabIndex = 28
        Me.lbl_mandaBirth.Text = "Date de naissance:"
        '
        'mandaTel
        '
        Me.mandaTel.Location = New System.Drawing.Point(404, 31)
        Me.mandaTel.Name = "mandaTel"
        Me.mandaTel.Size = New System.Drawing.Size(100, 20)
        Me.mandaTel.TabIndex = 26
        '
        'lbl_mandaTel
        '
        Me.lbl_mandaTel.AutoSize = True
        Me.lbl_mandaTel.Location = New System.Drawing.Point(337, 34)
        Me.lbl_mandaTel.Name = "lbl_mandaTel"
        Me.lbl_mandaTel.Size = New System.Drawing.Size(61, 13)
        Me.lbl_mandaTel.TabIndex = 26
        Me.lbl_mandaTel.Text = "Téléphone:"
        '
        'mandaNom
        '
        Me.mandaNom.Location = New System.Drawing.Point(50, 31)
        Me.mandaNom.Name = "mandaNom"
        Me.mandaNom.Size = New System.Drawing.Size(100, 20)
        Me.mandaNom.TabIndex = 24
        '
        'lbl_mandaNom
        '
        Me.lbl_mandaNom.AutoSize = True
        Me.lbl_mandaNom.Location = New System.Drawing.Point(12, 34)
        Me.lbl_mandaNom.Name = "lbl_mandaNom"
        Me.lbl_mandaNom.Size = New System.Drawing.Size(32, 13)
        Me.lbl_mandaNom.TabIndex = 24
        Me.lbl_mandaNom.Text = "Nom:"
        '
        'mandaprenom
        '
        Me.mandaprenom.Location = New System.Drawing.Point(217, 31)
        Me.mandaprenom.Name = "mandaprenom"
        Me.mandaprenom.Size = New System.Drawing.Size(100, 20)
        Me.mandaprenom.TabIndex = 25
        '
        'Lbl_mandaprenom
        '
        Me.Lbl_mandaprenom.AutoSize = True
        Me.Lbl_mandaprenom.Location = New System.Drawing.Point(165, 34)
        Me.Lbl_mandaprenom.Name = "Lbl_mandaprenom"
        Me.Lbl_mandaprenom.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_mandaprenom.TabIndex = 22
        Me.Lbl_mandaprenom.Text = "Prenom:"
        '
        'Ajout_Client_Commercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 597)
        Me.Controls.Add(Me.GroupBox_mandataireCom)
        Me.Controls.Add(Me.Btn_CréerCltCom)
        Me.Controls.Add(Me.GroupBox1_ClientActuel)
        Me.Name = "Ajout_Client_Commercial"
        Me.Text = "Ajout_Client_Commercial"
        Me.GroupBox1_ClientActuel.ResumeLayout(False)
        Me.GroupBox1_ClientActuel.PerformLayout()
        Me.GroupBox_AjoutcltCom_com.ResumeLayout(False)
        Me.GroupBox_AjoutcltCom_com.PerformLayout()
        Me.GroupBox_mandataireCom.ResumeLayout(False)
        Me.GroupBox_mandataireCom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1_ClientActuel As GroupBox
    Friend WithEvents ComboBox_AjoutcltCom_prov As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rue As TextBox
    Friend WithEvents Lbl_rue As Label
    Friend WithEvents NoClient As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Lbl_AjoutcltCom_Birth As Label
    Friend WithEvents AjoutcltCom_tel As TextBox
    Friend WithEvents Lb_tel As Label
    Friend WithEvents CodePostale As TextBox
    Friend WithEvents Lb_CodePostale As Label
    Friend WithEvents Lb_NoCivique As Label
    Friend WithEvents NoCivique As TextBox
    Friend WithEvents Lb_adresse As Label
    Friend WithEvents AjoutcltCom_nom As TextBox
    Friend WithEvents Lbl_AjoutcltCom_nom As Label
    Friend WithEvents AjoutcltCom_prenom As TextBox
    Friend WithEvents Lb_prenom As Label
    Friend WithEvents Lb_NoClient As Label
    Friend WithEvents AjoutcltCom_Web As TextBox
    Friend WithEvents lb_AjoutcltCom_Web As Label
    Friend WithEvents AjoutcltCom_Domaine As TextBox
    Friend WithEvents Lbl_AjoutcltCom_Domaine As Label
    Friend WithEvents AjoutcltCom_Société As TextBox
    Friend WithEvents Lbl_AjoutcltCom_Société As Label
    Friend WithEvents Lbl_NEQ As Label
    Friend WithEvents NEQ As TextBox
    Friend WithEvents AjoutcltCom_telecop As TextBox
    Friend WithEvents lbl_AjoutcltCom_telecop As Label
    Friend WithEvents Btn_CréerCltCom As Button
    Friend WithEvents GroupBox_AjoutcltCom_com As GroupBox
    Friend WithEvents lbl_adressefact As Label
    Friend WithEvents ComboBox_Adressefact_Prov As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Adressefact_rue As TextBox
    Friend WithEvents Lbl_AdressefactRue As Label
    Friend WithEvents Adressefact_codepostale As TextBox
    Friend WithEvents Lbl_AdressefactCodepostale As Label
    Friend WithEvents lbl_adressefact_No As Label
    Friend WithEvents Adressefact_no As TextBox
    Friend WithEvents CheckBox_courriel As CheckBox
    Friend WithEvents CheckBox_poste As CheckBox
    Friend WithEvents Lbl_fact As Label
    Friend WithEvents Lbl_langue As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Lbl_Adressefact_courriel As Label
    Friend WithEvents CheckBox_Anglais As CheckBox
    Friend WithEvents CheckBox_francais As CheckBox
    Friend WithEvents GroupBox_mandataireCom As GroupBox
    Friend WithEvents mandajeunefille As TextBox
    Friend WithEvents lbl_mandajeunefille As Label
    Friend WithEvents DateTimePicker_mandaBirth As DateTimePicker
    Friend WithEvents lbl_mandaBirth As Label
    Friend WithEvents mandaTel As TextBox
    Friend WithEvents lbl_mandaTel As Label
    Friend WithEvents mandaNom As TextBox
    Friend WithEvents lbl_mandaNom As Label
    Friend WithEvents mandaprenom As TextBox
    Friend WithEvents Lbl_mandaprenom As Label
End Class
