Public Class Service
    Private Sub Btn_équipementsave_Click(sender As Object, e As EventArgs) Handles Btn_servicesave.Click
        Dim ServiceAdd As New Confirmation_Service_Ajouté() With {
            .MdiParent = Form1
        }
        ServiceAdd.Show()
        Me.Close()

    End Sub
End Class