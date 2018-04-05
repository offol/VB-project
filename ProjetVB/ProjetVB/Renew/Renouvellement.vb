Public Class Renouvellement
    Private Sub Btn_recherheClient_Click(sender As Object, e As EventArgs) Handles Btn_recherheClient.Click
        Dim rechercheRenew As New Choix_Renouvellement() With {
           .MdiParent = Form1
       }
        rechercheRenew.Show()
        Me.Close()
    End Sub
End Class