Public Class LigneFacture
    Private myNumeroFacture As Integer
    Private myNumeroLigne As Integer
    Private myDescription As String
    Private myQuantity As Integer
    Private myPrixUnitaire As Double
    Private myPrixHT As Double

    Public Sub New(NewNumFacture As Integer, NewNumLigne As Integer, NewDescription As String, NewQuantity As Integer, NewPrixUnitaire As Double, NewPrixHT As Double)
        Me.myNumeroFacture = NewNumFacture
        Me.myNumeroLigne = NewNumLigne
        Me.myDescription = NewDescription
        Me.myQuantity = NewQuantity
        Me.myPrixUnitaire = NewPrixUnitaire
        Me.myPrixHT = NewPrixHT
    End Sub

    Public Property Numéro_Facture() As Integer
        Get
            Return myNumeroFacture
        End Get
        Set(value As Integer)
            If myNumeroFacture <> value Then
                myNumeroFacture = value
            End If
        End Set
    End Property

    Public Property Numéro_Ligne() As Integer
        Get
            Return myNumeroLigne
        End Get
        Set(value As Integer)
            If myNumeroLigne <> value Then
                myNumeroLigne = value
            End If
        End Set
    End Property

    Public Property Description() As String
        Get
            Return myDescription
        End Get
        Set(value As String)
            If myDescription IsNot value Then
                myDescription = value
            End If
        End Set
    End Property

    Public Property Quantité() As Integer
        Get
            Return myQuantity
        End Get
        Set(value As Integer)
            If myQuantity <> value Then
                myQuantity = value
            End If
        End Set
    End Property

    Public Property Prix_Unitaire() As Double
        Get
            Return myPrixUnitaire
        End Get
        Set(value As Double)
            If myPrixUnitaire <> value Then
                myPrixUnitaire = value
            End If
        End Set
    End Property

    Public Property Prix_Hors_Taxe As Double
        Get
            Return myPrixHT
        End Get
        Set(value As Double)
            If myPrixHT <> value Then
                myPrixHT = value
            End If
        End Set
    End Property

End Class
