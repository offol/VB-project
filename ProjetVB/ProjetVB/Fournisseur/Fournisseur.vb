Public Class Fournisseur
    Private numeroFournisseur As Integer
    Private nomFournisseur As String
    Private adresseFournisseur As String
    Private telephoneFournisseur As String
    Private telecopieurFournisseur As String

    'Constructeur d'un fournisseur
    Public Sub New(NewNum As Integer, NewFournisseur As String, NewAdresse As String, NewTelephone As String, NewTelecopieur As String)
        Me.numeroFournisseur = NewNum
        Me.nomFournisseur = NewFournisseur
        Me.adresseFournisseur = NewAdresse
        Me.telephoneFournisseur = NewTelephone
        Me.telecopieurFournisseur = NewTelecopieur
    End Sub

    Public Property Numéro() As Integer
        Get
            Return numeroFournisseur
        End Get
        Set(value As Integer)
            If numeroFournisseur <> value Then
                numeroFournisseur = value
            End If
        End Set
    End Property

    Public Property Nom_Fournisseur() As String
        Get
            Return nomFournisseur
        End Get
        Set(value As String)
            If nomFournisseur IsNot value Then
                nomFournisseur = value
            End If
        End Set
    End Property

    Public Property Adresse() As String
        Get
            Return adresseFournisseur
        End Get
        Set(value As String)
            If adresseFournisseur IsNot value Then
                adresseFournisseur = value
            End If
        End Set
    End Property

    Public Property Téléphone() As String
        Get
            Return telephoneFournisseur
        End Get
        Set(value As String)
            If telephoneFournisseur IsNot value Then
                telephoneFournisseur = value
            End If
        End Set
    End Property

    Public Property Télécopieur() As String
        Get
            Return telecopieurFournisseur
        End Get
        Set(value As String)
            If telecopieurFournisseur IsNot value Then
                telecopieurFournisseur = value
            End If
        End Set
    End Property


End Class
