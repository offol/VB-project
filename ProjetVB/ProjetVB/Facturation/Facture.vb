﻿Public Class Facture
    Private myNumClient As Integer
    Private myNumero As Integer
    Private myDateFacture As Date
    Private myEtat As String
    Private myMontantHT As Double
    Private myMontantTPS As Double
    Private myMontantTVQ As Double
    Private myMontantTotal As Double

    Public Sub New(NewNumClient As Integer, NewNumero As Integer, NewDate As Date, NewEtat As String, NewHT As Double, NewTPS As Double, NewTVQ As Double, NewTotal As Double)
        Me.myNumClient = NewNumClient
        Me.myNumero = NewNumero
        Me.myDateFacture = NewDate
        Me.myEtat = NewEtat
        Me.myMontantHT = NewHT
        Me.myMontantTPS = NewTPS
        Me.myMontantTVQ = NewTVQ
        Me.myMontantTotal = NewTotal
    End Sub

    Public Property Numéro() As Integer
        Get
            Return myNumero
        End Get
        Set(value As Integer)
            If myNumero <> value Then
                myNumero = value
            End If
        End Set
    End Property

    Public Property Date_Facture() As Date
        Get
            Return myDateFacture
        End Get
        Set(value As Date)
            If myDateFacture <> value Then
                myDateFacture = value
            End If
        End Set
    End Property

    Public Property État() As String
        Get
            Return myEtat
        End Get
        Set(value As String)
            If myEtat IsNot value Then
                myEtat = value
            End If
        End Set
    End Property

    Public Property Montant_Hors_Taxe() As Double
        Get
            Return myMontantHT
        End Get
        Set(value As Double)
            If myMontantHT <> value Then
                myMontantHT = value
            End If
        End Set
    End Property

    Public Property Montant_TPS() As Double
        Get
            Return myMontantTPS
        End Get
        Set(value As Double)
            If myMontantTPS <> value Then
                myMontantTPS = value
            End If
        End Set
    End Property

    Public Property Montant_TVQ() As Double
        Get
            Return myMontantTVQ
        End Get
        Set(value As Double)
            If myMontantTVQ <> value Then
                myMontantTVQ = value
            End If
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return myMontantTotal
        End Get
        Set(value As Double)
            If myMontantTotal <> value Then
                myMontantTotal = value
            End If
        End Set
    End Property

End Class
