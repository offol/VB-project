Public Class AjoutClient
	Private ListeTypeClient As New List(Of String)
	Private MyClients As New List(Of Client)
	Private Sub AjoutClient_Load(Sender As Object, e As EventArgs) Handles Me.Load
		ListeTypeClient = New List(Of String) From {
			"Particulier",
			"Entreprise",
			"Employé"
		}
		ComboBox_TypeClient.DataSource = ListeTypeClient
		MyClients = DataBase.Clients

	End Sub

	Private Sub Button_CreerClient_Click(sender As Object, e As EventArgs) Handles Button_CreerClient.Click
		MyClients.Add(New Client(MyClients.Last.Numéro + 1, ComboBox_TypeClient.Text, TextBox_Adresse.Text, TextBox_Telephone.Text, TextBox_Telecopieur.Text))
		Me.Close()
	End Sub
End Class