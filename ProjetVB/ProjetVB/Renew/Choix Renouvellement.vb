Public Class Choix_Renouvellement
    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Modifrenew As New Modification_équipement_et_service() With {
           .MdiParent = Form1
       }
        Modifrenew.Show()
        Me.Close()
    End Sub

    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click
        Dim SameRenew As New Impression_Renouvellement() With {
           .MdiParent = Form1
       }
        SameRenew.Show()
        Me.Close()
    End Sub
End Class