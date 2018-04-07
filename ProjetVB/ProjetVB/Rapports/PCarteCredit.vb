Public Class PCarteCredit

    Private numCarte As String
    Private dateExpiration As DateTime
    Private typeCarte As String
    Private MontantPaye As Double

    Public Sub New(NewNum As String, Newdate As DateTime, Newtype As String, Newmontant As Double)
        Me.numCarte = NewNum
        Me.dateExpiration = Newdate
        Me.typeCarte = Newtype
        Me.MontantPaye = Newmontant
    End Sub

    Public ReadOnly Property Numéro_Carte() As String
        Get
            Return numCarte
        End Get
    End Property

    Public ReadOnly Property Date_Expiration() As DateTime
        Get
            Return dateExpiration
        End Get
    End Property

    Public ReadOnly Property Type_Carte() As String
        Get
            Return typeCarte
        End Get
    End Property

    Public ReadOnly Property Montant_Payé As Double
        Get
            Return MontantPaye
        End Get
    End Property

End Class
