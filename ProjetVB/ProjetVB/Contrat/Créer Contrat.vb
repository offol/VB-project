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
        Dim ramdomnumber As System.Random = New System.Random()

        NumContrat.Text = ramdomnumber.Next()
    End Sub

    Private Sub Btn_cliParticulier_Click(sender As Object, e As EventArgs) Handles btn_cliParticulier.Click
        Dim Particulier As New Ajout_Client_Particulier() With {
                   .MdiParent = Form1
               }
        Particulier.Show()

    End Sub

    Private Sub Btn_cliCommercial_Click(sender As Object, e As EventArgs) Handles btn_cliCommercial.Click
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

    Private Sub btn_cliParticulier_Click_1(sender As Object, e As EventArgs) Handles btn_cliParticulier.Click

    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim Print As New Impression_Contrat() With {
            .MdiParent = Form1
        }
        Print.Show()
        Me.Close()
    End Sub

    Private Sub btn_cliCommercial_Click_1(sender As Object, e As EventArgs) Handles btn_cliCommercial.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub NumContrat_TextChanged(sender As Object, e As EventArgs) Handles NumContrat.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Livraison As New Mise_en_Service() With {
           .MdiParent = Form1
       }
        Livraison.Show()

    End Sub

    Public Sub DataGridView_LigneFacture_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_LignesEquipement.CellContentClick

    End Sub
End Class