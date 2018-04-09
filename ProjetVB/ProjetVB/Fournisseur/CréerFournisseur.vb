Public Class CréerFournisseur

    Private DbFournisseur As List(Of Fournisseur)

    Private Sub CréerFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbFournisseur = DataBase.ListFournisseur
    End Sub

    Private Sub AnnulerFournisseur_Click_1(sender As Object, e As EventArgs) Handles AnnulerFournisseur.Click
        Me.Close()
    End Sub

    Private Sub Btn_enregistrerF_Click(sender As Object, e As EventArgs) Handles Btn_enregistrerF.Click
        DbFournisseur.Add(New Fournisseur(TextBox_numéro.Text, TextBox_Nom.Text, TextBoxNuméroCivique.Text + " " + TextBoxCodePostal.Text,
                                          TextBoxTelephone.Text, TextBoxtelecopieur.Text))
        MsgBox("Le fournisseur a été enregistré avec succès")

        Me.Close()
    End Sub
End Class