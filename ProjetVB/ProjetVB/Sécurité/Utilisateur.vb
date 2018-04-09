Public Class Utilisateur
    Private myUsername As String
    Private myNom As String
    Private myCellulaire As String
    Private myPassword As String

    Public Sub New(NewUsername As String, NewNom As String, NumCell As String, NewPassWord As String)
        Me.myUsername = NewUsername
        Me.myNom = NewNom
        Me.myCellulaire = NumCell
        Me.myPassword = NewPassWord
    End Sub

    Public ReadOnly Property Username() As String
        Get
            Return myUsername
        End Get
    End Property

    Public Property Nom() As String
        Get
            Return myNom
        End Get
        Set(value As String)
            If myNom IsNot value Then
                myNom = value
            End If
        End Set
    End Property

    Public Property Numero_Cellulaire() As String
        Get
            Return myCellulaire
        End Get
        Set(value As String)
            If myCellulaire IsNot value Then
                myCellulaire = value
            End If
        End Set
    End Property

    Public Property PassWord() As String
        Get
            Return myPassword
        End Get
        Set(value As String)
            If myPassword IsNot value Then
                myPassword = value
            End If
        End Set
    End Property

End Class
