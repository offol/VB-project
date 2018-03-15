Public Class Client
    Private myNumero As Integer
    Private myTypeClient As String
    Private myAdresse As String
    Private myTelephone As String
    Private myTelecopieur As String

    'Constructeur d'un client
    Public Sub New(NewNum As Integer, NewType As String, NewAdresse As String, NewTelephone As String, NewTelecopieur As String)
        Me.myNumero = NewNum
        Me.myTypeClient = NewType
        Me.myAdresse = NewAdresse
        Me.myTelephone = NewTelephone
        Me.myTelecopieur = NewTelecopieur
    End Sub

    Public Property Numéro() As Integer
        Get
            Return myNumero
        End Get
        Set(value As Integer)
            If myNumero <> value Then
                myNumero = value
            End If
        End Set
    End Property

    Public Property Type_Client() As String
        Get
            Return myTypeClient
        End Get
        Set(value As String)
            If myTypeClient IsNot value Then
                myTypeClient = value
            End If
        End Set
    End Property

    Public Property Adresse() As String
        Get
            Return myAdresse
        End Get
        Set(value As String)
            If myAdresse IsNot value Then
                myAdresse = value
            End If
        End Set
    End Property

    Public Property Téléphone() As String
        Get
            Return myTelephone
        End Get
        Set(value As String)
            If myTelephone IsNot value Then
                myTelephone = value
            End If
        End Set
    End Property

    Public Property Télécopieur() As String
        Get
            Return myTelecopieur
        End Get
        Set(value As String)
            If myTelecopieur IsNot value Then
                myTelecopieur = value
            End If
        End Set
    End Property

End Class
