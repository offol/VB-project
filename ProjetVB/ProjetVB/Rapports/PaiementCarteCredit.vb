Public Class PaiementCarteCredit

    Private Sub PaiementCarteCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_PCarte.DataSource = DataBase.PaiementCredit
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_PCarte.CellContentClick

    End Sub

End Class