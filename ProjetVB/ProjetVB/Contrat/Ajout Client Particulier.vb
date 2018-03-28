Public Class Ajout_Client_Particulier
    Private Sub Btn_CréerCltCom_Click(sender As Object, e As EventArgs) Handles Btn_CréerCltCom.Click
        Dim ConfirmeAdd As New Confirmation_Client_Ajouté() With {
          .MdiParent = Form1
      }
        ConfirmeAdd.Show()
        Me.Close()
    End Sub

    Private Sub NoClient_TextChanged(sender As Object, e As EventArgs) Handles NoClient.TextChanged
        'Dim MyRand As New Random(Convert.ToInt32(Now.Ticks And Integer.MaxValue))
        ' NoClient.Text = MyRand.Next(10000, 100000).ToString


    End Sub
End Class