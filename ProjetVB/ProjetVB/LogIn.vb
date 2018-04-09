Public Class LogIn

    Private DBUtilisateur As List(Of Utilisateur)

    Private Sub Button_connect_Click(sender As Object, e As EventArgs) Handles Button_connect.Click

        Dim LogInUser As Utilisateur

        If DBUtilisateur.Where(Function(i) i.Username = TextBox_nom.Text AndAlso i.PassWord = TextBox_motdepasse.Text).Count > 0 Then
            LogInUser = DBUtilisateur.Where(Function(i) i.Username = TextBox_nom.Text AndAlso i.PassWord = TextBox_motdepasse.Text).First

            If LogInUser IsNot Nothing Then

                Form1.ToolStripStatusLabel1.Text = TextBox_nom.Text

                Me.Close()
            Else
                MsgBox("Mot de passe ou nom d'utilisateur incorrect")
            End If
        Else
            MsgBox("Mot de passe ou nom d'utilisateur incorrect")
        End If

    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBUtilisateur = DataBase.ListUser
    End Sub
End Class