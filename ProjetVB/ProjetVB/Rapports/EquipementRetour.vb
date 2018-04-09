Public Class EquipementRetour
	Private Sub EquipementRetour_Load(Sender As Object, e As EventArgs) Handles Me.Load
		DataGridView1.DataSource = DataBase.LignesEquip
	End Sub

End Class