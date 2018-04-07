Public Class Annuler_Livraison
    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim CancelLivraisonconfirm As New Confirmation_annulation_livraison() With {
          .MdiParent = Form1
      }
        CancelLivraisonconfirm.Show()
        Me.Close()
    End Sub

    Private Sub BtnValideréquip_Click(sender As Object, e As EventArgs) Handles BtnValideréquip.Click
        Dim CancelValide As New Validation_Annulation_livraison() With {
         .MdiParent = Form1
     }
       CancelValide.Show()

    End Sub
End Class