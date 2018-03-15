Public Module TPS
    Private myTauxTPS As Double = 0.05

    Public Property TauxTPS As Double
        Get
            Return myTauxTPS
        End Get
        Set(value As Double)
            If myTauxTPS <> value Then
                myTauxTPS = value
            End If
        End Set
    End Property

End Module
