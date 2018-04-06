Public Class ChangerMotDePasse
    Private Sub ChangerMotDePasse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        Close()
    End Sub

    Private Sub Changer_Click(sender As Object, e As EventArgs) Handles Changer.Click
        MsgBox("Votre mot de passe à été changé avec succès")
    End Sub
End Class