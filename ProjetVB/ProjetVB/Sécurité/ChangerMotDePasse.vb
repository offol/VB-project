Public Class ChangerMotDePasse
    Private DBUser As List(Of Utilisateur)

    Private Sub ChangerMotDePasse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBUser = DataBase.ListUser
    End Sub

    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        Close()
    End Sub

    Private Sub Changer_Click(sender As Object, e As EventArgs) Handles Changer.Click

        Dim User As Utilisateur

        If DBUser.Where(Function(i) i.Username = TextBoxNomUtilisateur.Text AndAlso i.PassWord = TextBoxMotdePasse.Text).Count > 0 Then
            User = DBUser.Where(Function(i) i.Username = TextBoxNomUtilisateur.Text AndAlso i.PassWord = TextBoxMotdePasse.Text).First

            If TextBoxNouveauMotdePasse.Text = TextBoxConfirmerMotdePasse.Text Then

                User.PassWord = TextBoxNouveauMotdePasse.Text

                MsgBox("Votre mot de passe a été changé avec succès")

            Else
                MsgBox("Nouveau mot de passe et confirmation ne sont pas identique")
            End If
        Else
            MsgBox("Le nom d'utilisateur ou le mot de passe est incorrect")
        End If
    End Sub
End Class