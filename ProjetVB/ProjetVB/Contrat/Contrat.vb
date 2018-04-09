Public Class Contrat
	Private NoContrat As Integer
	Private TypeContrat As String
	Private DateOuverture As Date
	Private DateResiliation As Date
	Private Equipements As List(Of Equip_Object)
	Private Services As List(Of ServiceObject)
	Private DateMiseEnVigueur As Date

	Public Sub New(NewNoContrat As Integer, NewTypeContrat As String, NewDateOuverture As Date, NewDateResiliation As Date, NewEquipements As List(Of Equip_Object), NewServices As List(Of ServiceObject), NewDateEnVigueur As Date)
		Me.NoContrat = NewNoContrat
		Me.TypeContrat = NewTypeContrat
		Me.DateOuverture = NewDateOuverture
		Me.DateResiliation = NewDateResiliation
		Me.Equipements = NewEquipements
		Me.Services = NewServices
		Me.DateMiseEnVigueur = NewDateEnVigueur
	End Sub
	Public ReadOnly Property Numero() As Integer
		Get
			Return NoContrat
		End Get
	End Property
	Public Property Type() As String
		Get
			Return TypeContrat
		End Get
		Set(value As String)
			If TypeContrat IsNot value Then
				TypeContrat = value
			End If
		End Set
	End Property
	Public ReadOnly Property Ouverture() As Date
		Get
			Return DateOuverture
		End Get
	End Property
	Public Property Resiliation() As Date
		Get
			Return DateResiliation
		End Get
		Set(value As Date)
			If value <> DateResiliation Then
				DateResiliation = value
			End If
		End Set
	End Property
	Public ReadOnly Property Equipement() As List(Of Equip_Object)
		Get
			Return Equipements
		End Get
	End Property
	Public ReadOnly Property Service() As List(Of ServiceObject)
		Get
			Return Services
		End Get
	End Property
	Public ReadOnly Property MiseEnVigueur() As Date
		Get
			Return DateMiseEnVigueur
		End Get
	End Property
End Class
