Public Class Mise_en_Service
    Private Sub NoClient_TextChanged(sender As Object, e As EventArgs) Handles NoCommande.TextChanged

    End Sub

    Private Sub Mise_en_Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ramdomnumber As System.Random = New System.Random()

        NoCommande.Text = ramdomnumber.Next()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim Livraison As New Confirmation_Livraison() With {
            .MdiParent = Form1
        }
        Livraison.Show()
        Me.Close()
    End Sub
End Class