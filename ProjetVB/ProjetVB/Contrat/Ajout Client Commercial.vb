Public Class Ajout_Client_Commercial
    Private Sub Btn_CréerCltCom_Click(sender As Object, e As EventArgs) Handles Btn_CréerCltCom.Click
        Dim ConfirmeAdd As New Confirmation_Client_Ajouté() With {
          .MdiParent = Form1
      }
        ConfirmeAdd.Show()
        Me.Close()

    End Sub

    Private Sub Ajout_Client_Commercial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NoClient_TextChanged(sender As Object, e As EventArgs) Handles NoClient.TextChanged

    End Sub
End Class