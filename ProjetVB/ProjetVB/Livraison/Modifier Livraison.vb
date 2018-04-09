Public Class Modifier_Livraison
    Private Sub btnComplete_Click(sender As Object, e As EventArgs)
        Dim Livraison As New Confirmation_Livraison() With {
           .MdiParent = Form1
       }
        Livraison.Show()
        Me.Close()
    End Sub

    Private Sub BtnValideréquip_Click(sender As Object, e As EventArgs) Handles BtnValideréquip.Click
        Dim ValidLivraison As New Validation_bon_de_livraison() With {
           .MdiParent = Form1
       }
        ValidLivraison.Show()

        NoCommande.ReadOnly = True

    End Sub

    Private Sub btnComplete_Click_1(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim ModifLivraison As New Confirmation_Mofidication_Livraison() With {
          .MdiParent = Form1
      }
        ModifLivraison.Show()
        Me.Close()
    End Sub
End Class