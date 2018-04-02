Public Class Modem
    Private Vitesse As Integer
    Private Prix As Integer
    Public Sub New(NewVit As String, NewPrix As Integer)
        Me.Vitesse = NewVit
        Me.Prix = NewPrix
    End Sub
    Public Property VitModem As String
        Get
            Return Vitesse
        End Get
        Set(value As String)
            If value <> Vitesse Then
                Vitesse = value
            End If
        End Set
    End Property
    Public Property PrixModem As String
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
