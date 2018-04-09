Public Class PaiementRetraitDirect
	Private Sub PaiementRetraitDirect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DataGridView_PRD.DataSource = DataBase.PaiementRetrait
	End Sub
End Class