Public Class Créer_Contrat

    Private WithEvents Equip As New Équipement() With {
          .MdiParent = Form1
      }

    Private Sub btnEquipement_Click(sender As Object, e As EventArgs) Handles btnEquipement.Click

        Equip.Show()

    End Sub

    Private Sub Equip_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Equip.FormClosed
        DataGridView_LignesEquipement.DataSource = Equip.Listecurrentequip

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

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Dim Serv As New Service() With {
          .MdiParent = Form1
      }
        Serv.Show()
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim Print As New Impression_Contrat() With {
            .MdiParent = Form1
        }
        Print.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Livraison As New Mise_en_Service() With {
           .MdiParent = Form1
       }
        Livraison.Show()

    End Sub

End Class