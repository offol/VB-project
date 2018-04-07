Public Class Choix_Résiliation
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CancelContract As New Impression_Résiliation() With {
          .MdiParent = Form1
      }
        CancelContract.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class