Public Class Ordinateur
    Private Type As String
    Private Prix As Integer
    Public Sub New(NewType As String, NewPrix As Integer)
        Me.Type = NewType
        Me.Prix = NewPrix
    End Sub
    Public Property TypeOrdi As String
        Get
            Return Type
        End Get
        Set(value As String)
            If value <> Type Then
                Type = value
            End If
        End Set
    End Property
    Public Property PrixOrdi As String
        Get
            Return Prix
        End Get
        Set(value As String)
            If value <> Prix Then
                Prix = value
            End If
        End Set
    End Property
End Class
