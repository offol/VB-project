Public Class Chèque
    Private myNumClient As Integer
    Private myNumCheque As String
    Private myDateCheque As DateTime

    Public Sub New(NewClient As Integer, NewNumCheque As String, NewDate As DateTime)
        Me.myNumClient = NewClient
        Me.myNumCheque = NewNumCheque
        Me.myDateCheque = NewDate
    End Sub

    Public ReadOnly Property Numéro_Client() As Integer
        Get
            Return myNumClient
        End Get
    End Property

    Public Property Numéro_Chèque() As String
        Get
            Return myNumCheque
        End Get
        Set(value As String)
            If myNumCheque IsNot value Then
                myNumCheque = value
            End If
        End Set
    End Property

    Public Property Date_Chèque As DateTime
        Get
            Return myDateCheque
        End Get
        Set(value As DateTime)
            If myDateCheque <> value Then
                myDateCheque = value
            End If
        End Set
    End Property
End Class
