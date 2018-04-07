Public Class PRetraitDirect
    Private NumCompte As String
    Private TypeCompte As String
    Private MontantPaye As Double

    Public Sub New(NewNum As String, NewType As String, NewMontant As Double)
        Me.NumCompte = NewNum
        Me.TypeCompte = NewType
        Me.MontantPaye = NewMontant
    End Sub

    Public ReadOnly Property Numero_Compte() As String
        Get
            Return NumCompte
        End Get
    End Property

    Public ReadOnly Property Type_Compte() As String
        Get
            Return TypeCompte
        End Get
    End Property

    Public ReadOnly Property Montant_Paye() As Double
        Get
            Return MontantPaye
        End Get
    End Property

End Class
