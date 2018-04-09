<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutClient
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ComboBox_TypeClient = New System.Windows.Forms.ComboBox()
		Me.AdresseLabel = New System.Windows.Forms.Label()
		Me.TextBox_Adresse = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox_Telephone = New System.Windows.Forms.TextBox()
		Me.TextBox_Telecopieur = New System.Windows.Forms.TextBox()
		Me.Button_CreerClient = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(60, 60)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(101, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Type de client:"
		'
		'ComboBox_TypeClient
		'
		Me.ComboBox_TypeClient.FormattingEnabled = True
		Me.ComboBox_TypeClient.Location = New System.Drawing.Point(183, 57)
		Me.ComboBox_TypeClient.Name = "ComboBox_TypeClient"
		Me.ComboBox_TypeClient.Size = New System.Drawing.Size(180, 24)
		Me.ComboBox_TypeClient.TabIndex = 1
		'
		'AdresseLabel
		'
		Me.AdresseLabel.AutoSize = True
		Me.AdresseLabel.Location = New System.Drawing.Point(97, 116)
		Me.AdresseLabel.Name = "AdresseLabel"
		Me.AdresseLabel.Size = New System.Drawing.Size(64, 17)
		Me.AdresseLabel.TabIndex = 2
		Me.AdresseLabel.Text = "Adresse:"
		'
		'TextBox_Adresse
		'
		Me.TextBox_Adresse.Location = New System.Drawing.Point(183, 111)
		Me.TextBox_Adresse.Name = "TextBox_Adresse"
		Me.TextBox_Adresse.Size = New System.Drawing.Size(180, 22)
		Me.TextBox_Adresse.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(81, 168)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 17)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Téléphone:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(74, 220)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(87, 17)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Télécopieur:"
		'
		'TextBox_Telephone
		'
		Me.TextBox_Telephone.Location = New System.Drawing.Point(183, 168)
		Me.TextBox_Telephone.Name = "TextBox_Telephone"
		Me.TextBox_Telephone.Size = New System.Drawing.Size(180, 22)
		Me.TextBox_Telephone.TabIndex = 6
		'
		'TextBox_Telecopieur
		'
		Me.TextBox_Telecopieur.Location = New System.Drawing.Point(183, 220)
		Me.TextBox_Telecopieur.Name = "TextBox_Telecopieur"
		Me.TextBox_Telecopieur.Size = New System.Drawing.Size(180, 22)
		Me.TextBox_Telecopieur.TabIndex = 7
		'
		'Button_CreerClient
		'
		Me.Button_CreerClient.Location = New System.Drawing.Point(342, 302)
		Me.Button_CreerClient.Name = "Button_CreerClient"
		Me.Button_CreerClient.Size = New System.Drawing.Size(109, 52)
		Me.Button_CreerClient.TabIndex = 8
		Me.Button_CreerClient.Text = "Créer Client"
		Me.Button_CreerClient.UseVisualStyleBackColor = True
		'
		'AjoutClient
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(579, 418)
		Me.Controls.Add(Me.Button_CreerClient)
		Me.Controls.Add(Me.TextBox_Telecopieur)
		Me.Controls.Add(Me.TextBox_Telephone)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox_Adresse)
		Me.Controls.Add(Me.AdresseLabel)
		Me.Controls.Add(Me.ComboBox_TypeClient)
		Me.Controls.Add(Me.Label1)
		Me.Name = "AjoutClient"
		Me.Text = "AjoutClient"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox_TypeClient As ComboBox
	Friend WithEvents AdresseLabel As Label
	Friend WithEvents TextBox_Adresse As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox_Telephone As TextBox
	Friend WithEvents TextBox_Telecopieur As TextBox
	Friend WithEvents Button_CreerClient As Button
End Class
