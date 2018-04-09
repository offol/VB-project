Public Class Ajout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Utilisateur ajouté !")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Motdepasse As New ChangerMotDePasse() With {
          .MdiParent = Form1
      }
        Motdepasse.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("Es-tu sûr de vouloir supprimer ton compte?", "Utilisateur", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Close()
        ElseIf result = DialogResult.No Then
            Close()
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("Votre compte a été supprimé")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub
End Class