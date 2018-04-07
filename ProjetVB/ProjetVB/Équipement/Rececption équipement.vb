Public Class Rececption_équipement
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub BtnValideréquip_Click(sender As Object, e As EventArgs) Handles BtnValideréquip.Click
        Dim ValidateÉquip As New Validation_équipement() With {
           .MdiParent = Form1
       }
        ValidateÉquip.Show()
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim ConfirmRecep As New Impression_Réception() With {
          .MdiParent = Form1
      }
        ConfirmRecep.Show()
        Me.Close()

    End Sub
End Class