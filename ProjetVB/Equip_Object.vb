Imports Microsoft.VisualBasic

Public Class Equip_Object
    Private myNumEquip As Integer
    Private myLocation As String
    Private myType As String
    Private myQuantity As Double
    Private myPrice As Double

    Public Sub New(NewNumEquip As Integer, NewLocation As String, NewType As String, NewQuantity As Double, NewPrice As Double)
        Me.myNumEquip = NewNumEquip
        Me.myLocation = NewLocation
        Me.myType = NewType
        Me.myQuantity = NewQuantity
        Me.myPrice = NewPrice

    End Sub

    Public Property NumEquip() As Integer
        Get
            Return myNumEquip
        End Get
        Set(value As Integer)
            If myNumEquip <> value Then
                myNumEquip = value
            End If
        End Set
    End Property

    Public Property Location() As Integer
        Get
            Return myLocation
        End Get
        Set(value As String)
            If myLocation <> value Then
                myLocation = value
            End If
        End Set
    End Property
    Public Property Type() As Integer
        Get
            Return myType
        End Get
        Set(value As String)
            If myType <> value Then
                myType = value
            End If
        End Set
    End Property

    Public Property Quantity() As Integer
        Get
            Return myQuantity
        End Get
        Set(value As Double)
            If myQuantity <> value Then
                myQuantity = value
            End If
        End Set
    End Property

    Public Property Price() As Integer
        Get
            Return myPrice
        End Get
        Set(value As Double)
            If myPrice <> value Then
                myPrice = value
            End If
        End Set
    End Property
End Class