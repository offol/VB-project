Public Class ContratsResiliers
	Private Sub ContratsResiliers_Load(sender As Object, e As EventArgs) Handles Me.Load
		DataGridView1.DataSource = DataBase.ContratsResiliers
	End Sub
End Class