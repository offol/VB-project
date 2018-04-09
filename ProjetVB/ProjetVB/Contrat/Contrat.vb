Public Class Contrat
	Private NoContrat As Integer
	Private NoClient As Integer
	Private TypeContrat As String
	Private DateOuverture As Date
	Private DateResiliation As Date
	Private Equipements As List(Of Equip_Object)
	Private Services As List(Of ServiceObject)
	Private DateMiseEnVigueur As Date

	Public Sub New(NewNoContrat As Integer, NewNoClient As Integer, NewTypeContrat As String, NewDateOuverture As Date, NewDateResiliation As Date, NewEquipements As List(Of Equip_Object), NewServices As List(Of ServiceObject), NewDateEnVigueur As Date)
		Me.NoContrat = NewNoContrat
		Me.NoClient = NewNoClient
		Me.TypeContrat = NewTypeContrat
		Me.DateOuverture = NewDateOuverture
		Me.DateResiliation = NewDateResiliation
		Me.Equipements = NewEquipements
		Me.Services = NewServices
		Me.DateMiseEnVigueur = NewDateEnVigueur
	End Sub
End Class
