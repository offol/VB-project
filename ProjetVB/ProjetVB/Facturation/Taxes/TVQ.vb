Public Module TVQ
    Private myTauxTVQ As Double = 0.09975

    Public Property TauxTVQ As Double
        Get
            Return myTauxTVQ
        End Get
        Set(value As Double)
            If myTauxTVQ <> value Then
                myTauxTVQ = value
            End If
        End Set
    End Property
End Module
