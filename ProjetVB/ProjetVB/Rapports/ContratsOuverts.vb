Public Class ContratsOuverts
	Private Sub ContratsOuverts_Load(sender As Object, e As EventArgs) Handles Me.Load
		DataGridView1.DataSource = DataBase.ContratsActifs
	End Sub
End Class