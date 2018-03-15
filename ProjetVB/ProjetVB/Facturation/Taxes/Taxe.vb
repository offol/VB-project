Public Class Taxe
    Private Sub Taxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_TPS.Text = TPS.TauxTPS
        TextBox_TVQ.Text = TVQ.TauxTVQ
    End Sub

    Private Sub Button_Sauvegarder_Click(sender As Object, e As EventArgs) Handles Button_Sauvegarder.Click
        TPS.TauxTPS = TextBox_TPS.Text
        TVQ.TauxTVQ = TextBox_TVQ.Text
    End Sub
End Class