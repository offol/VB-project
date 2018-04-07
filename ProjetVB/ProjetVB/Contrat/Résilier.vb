Public Class Résilier
    Private Sub Btn_recherheClient_Click(sender As Object, e As EventArgs) Handles Btn_recherheClient.Click
        Dim CancelContract As New Choix_Résiliation() With {
          .MdiParent = Form1
      }
        CancelContract.Show()
        Me.Close()
    End Sub
End Class