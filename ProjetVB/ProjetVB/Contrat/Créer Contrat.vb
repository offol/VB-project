Public Class Créer_Contrat
    Private Sub Button_NewLigneFac_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_pariculier.CheckedChanged

    End Sub

    Private Sub DaujourdhuiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AutresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaiementToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TaxeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnEquipement_Click(sender As Object, e As EventArgs) Handles btnEquipement.Click
        Dim Equip As New Équipement() With {
          .MdiParent = Form1
      }
        Equip.Show()
    End Sub

    Private Sub Créer_Contrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_cliParticulier_Click(sender As Object, e As EventArgs) Handles Btn_cliParticulier.Click
        Dim Particulier As New Ajout_Client_Particulier() With {
                   .MdiParent = Form1
               }
        Particulier.Show()

    End Sub

    Private Sub Btn_cliCommercial_Click(sender As Object, e As EventArgs) Handles Btn_cliCommercial.Click
        Dim Commercial As New Ajout_Client_Commercial() With {
                .MdiParent = Form1
            }
        Commercial.Show()
    End Sub

    Private Sub Btn_supprimer_Click(sender As Object, e As EventArgs) Handles Btn_supprimer.Click

    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Dim Serv As New Service() With {
          .MdiParent = Form1
      }
        Serv.Show()
    End Sub
End Class