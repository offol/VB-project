Public Class Modification_équipement_et_service
    Private Sub btnEquipement_Click(sender As Object, e As EventArgs) Handles btnEquipement.Click
        Dim Equip As New Équipement() With {
          .MdiParent = Form1
      }
        Equip.Show()
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Dim Serv As New Service() With {
         .MdiParent = Form1
     }
        Serv.Show()
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim Print As New Impression_Renouvellement() With {
           .MdiParent = Form1
       }
        Print.Show()
        Me.Close()
    End Sub

    Private Sub NumContrat_TextChanged(sender As Object, e As EventArgs) Handles NumContrat.TextChanged

    End Sub

    Private Sub Modification_équipement_et_service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ramdomnumber As System.Random = New System.Random()

        NumContrat.Text = ramdomnumber.Next()
    End Sub
End Class