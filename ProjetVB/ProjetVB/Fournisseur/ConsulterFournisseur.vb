﻿Public Class ConsulterFournisseur
    Private Sub Annuler_consulterFournisseur_Click(sender As Object, e As EventArgs) Handles Annuler_consulterFournisseur.Click
        Close()
    End Sub

    Private Sub Consulter_Region_Click(sender As Object, e As EventArgs) Handles Consulter_Region.Click
        MsgBox("Recherche en cours...")
        Dim Statut As New StatutFournisseur() With {
            .MdiParent = Form1
        }
        Statut.Show()
    End Sub
End Class