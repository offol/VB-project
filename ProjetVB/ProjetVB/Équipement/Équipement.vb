Public Class Équipement
    Private Sub ListBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox8.SelectedIndexChanged

    End Sub

    Private Sub Btn_servicesave_Click(sender As Object, e As EventArgs) Handles Btn_servicesave.Click
        Dim EquipAdd As New Confication_Équip_Ajouté() With {
           .MdiParent = Form1
       }
        EquipAdd.Show()
        Me.Close()
    End Sub
End Class