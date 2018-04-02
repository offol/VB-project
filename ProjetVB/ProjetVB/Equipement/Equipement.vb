Public Class Equipement
    Private NumEquipement As Integer
    Private NomEquipement As String
    Private Marque As String
    Private Description As String
    Private Prix As Integer
    Public Sub New(NewNum As Integer, NewNom As String, NewMarque As String, NewDesc As String, NewPrix As Integer)
        Me.NumEquipement = NewNum
        Me.NomEquipement = NewNom
        Me.Marque = NewMarque
        Me.Description = NewDesc
        Me.Prix = NewPrix
    End Sub
    Public Property NoEquipement() As Integer
        Get
            Return NumEquipement
        End Get
        Set(value As Integer)
            If value <> NumEquipement Then
                NumEquipement = value
            End If
        End Set
    End Property
    Public Property NomEqu() As Integer
        Get
            Return NomEquipement
        End Get
        Set(value As Integer)
            If value <> NomEquipement Then
                NomEquipement = value
            End If
        End Set
    End Property
    Public Property MarqueEquipement() As Integer
        Get
            Return Marque
        End Get
        Set(value As Integer)
            If value <> Marque Then
                Marque = value
            End If
        End Set
    End Property
    Public Property DescEquipement() As Integer
        Get
            Return Description
        End Get
        Set(value As Integer)
            If value <> Description Then
                Description = value
            End If
        End Set
    End Property
End Class
