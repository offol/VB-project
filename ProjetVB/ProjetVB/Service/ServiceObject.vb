Public Class ServiceObject

    Private myId As Integer
    Private myNom As String
    Private myDescription As String
    Private myPrix As Integer

    Public Sub New(NewId As Integer, NewNom As String, NewDescription As String, NewPrix As Integer)
        Me.myId = NewId
        Me.myNom = NewNom
        Me.myDescription = NewDescription
        Me.myPrix = NewPrix
    End Sub

    Public ReadOnly Property Id() As Integer
        Get
            Return myId
        End Get
    End Property

    Public Property Nom() As String
        Get
            Return Me.myNom
        End Get
        Set(value As String)
            If myNom IsNot value Then
                Me.myNom = value
            End If
        End Set
    End Property

    Public Property Description As String
        Get
            Return myDescription
        End Get
        Set(value As String)
            If myDescription IsNot value Then
                myDescription = value
            End If
        End Set
    End Property

    Public Property Prix As Integer
        Get
            Return myPrix
        End Get
        Set(value As Integer)
            If myPrix <> value Then
                myPrix = value
            End If
        End Set
    End Property



End Class
