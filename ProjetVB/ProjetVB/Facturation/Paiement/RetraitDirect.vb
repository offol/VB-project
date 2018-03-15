Public Class RetraitDirect
    Private myNumClient As Integer
    Private myNumCompte As String
    Private myTypeCompte As String

    Public Sub New(NewClient As Integer, NewNumCompte As String, NewType As String)
        Me.myNumClient = NewClient
        Me.myNumCompte = NewNumCompte
        Me.myTypeCompte = NewType
    End Sub

    Public ReadOnly Property Numéro_Client() As Integer
        Get
            Return myNumClient
        End Get
    End Property

    Public Property Numéro_Compte() As String
        Get
            Return myNumCompte
        End Get
        Set(value As String)
            If myNumCompte IsNot value Then
                myNumCompte = value
            End If
        End Set
    End Property

    Public Property Type_Compte() As String
        Get
            Return myTypeCompte
        End Get
        Set(value As String)
            If myTypeCompte IsNot value Then
                myTypeCompte = value
            End If
        End Set
    End Property
End Class
