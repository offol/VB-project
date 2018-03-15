Public Class CarteDeCrédit
    Private myNumClient As Integer
    Private myNumCarte As String
    Private myDateExpiration As DateTime
    Private myTypeCarte As String

    Public Sub New(NewClient As Integer, NewNum As String, NewDate As DateTime, NewType As String)
        Me.myNumClient = NewClient
        Me.myNumCarte = NewNum
        Me.myDateExpiration = NewDate
        Me.myTypeCarte = NewType
    End Sub

    Public ReadOnly Property Numéro_Client() As Integer
        Get
            Return myNumClient
        End Get
    End Property

    Public Property Numéro_Carte() As String
        Get
            Return myNumCarte
        End Get
        Set(value As String)
            If myNumCarte IsNot value Then
                myNumCarte = value
            End If
        End Set
    End Property

    Public Property Date_Expiration() As DateTime
        Get
            Return myDateExpiration
        End Get
        Set(value As DateTime)
            If myDateExpiration <> value Then
                myDateExpiration = value
            End If
        End Set
    End Property

    Public Property Type_Carte() As String
        Get
            Return myTypeCarte
        End Get
        Set(value As String)
            If myTypeCarte IsNot value Then
                myTypeCarte = value
            End If
        End Set
    End Property

End Class
