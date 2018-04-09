Public Class Modification_équipement_et_service

    Private ListEquip As List(Of Equip_Object)

    Private ListService As List(Of ServiceObject)

    Private WithEvents Equip As New Équipement() With {
          .MdiParent = Form1
      }

    Private WithEvents Serv As New Service() With {
          .MdiParent = Form1}

    Private Sub Service_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Serv.FormClosed
        DataGrid_Service.DataSource = Serv.ListecurrentService

    End Sub

    Private Sub Equip_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Equip.FormClosed
        DataGridView_LignesEquipement.DataSource = Equip.Listecurrentequip

    End Sub
    Private Sub btnEquipement_Click(sender As Object, e As EventArgs) Handles btnEquipement.Click
        Equip = New Équipement() With {
          .MdiParent = Form1
      }
        Equip.Show()
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Serv = New Service() With {
         .MdiParent = Form1
     }
        Serv.Show()


    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim Print As New Impression_Renouvellement() With {
           .MdiParent = Form1
       }
        Print.Show()
        Me.Close()
    End Sub

    Private Sub NumContrat_TextChanged(sender As Object, e As EventArgs) Handles NumContrat.TextChanged

    End Sub

    Private Sub Modification_équipement_et_service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ramdomnumber As System.Random = New System.Random()

        ListEquip = DataBase.LignesEquip
        ListService = DataBase.Services

        NumContrat.Text = ramdomnumber.Next()
    End Sub

    'Met à jour la liste des équipement dans la gridview
    Private Sub UpdateDataSource()
        DataGridView_LignesEquipement.DataSource = Nothing
        DataGridView_LignesEquipement.DataSource = Equip.Listecurrentequip
    End Sub
    'Trouve équipement qui est sélectionné
    Private Function FindSelectedEquip()
        Dim SelectedEquip As Integer = DataGridView_LignesEquipement.SelectedRows.Item(0).Cells().Item(0).Value

        Return ListEquip.Where(Function(z) z.NumEquip = SelectedEquip).First
    End Function
    Private Sub Btn_supprimer_Click(sender As Object, e As EventArgs) Handles Btn_supprimer.Click
        If DataGridView_LignesEquipement.SelectedRows.Count() <> 0 Then

            Equip.Listecurrentequip.Remove(FindSelectedEquip())

            UpdateDataSource()

        End If
    End Sub

    'Met à jour la liste des Service dans la gridview
    Private Sub UpdateDataSourceService()
        DataGrid_Service.DataSource = Nothing
        DataGrid_Service.DataSource = Serv.ListecurrentService
    End Sub
    'Trouve équipement qui est sélectionné
    Private Function FindSelectedService()
        Dim SelectedService As Integer = DataGrid_Service.SelectedRows.Item(0).Cells().Item(0).Value

        Return ListService.Where(Function(z) z.Id = SelectedService).First
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGrid_Service.SelectedRows.Count() <> 0 Then

            Serv.ListecurrentService.Remove(FindSelectedService())

            UpdateDataSourceService()

        End If
    End Sub
End Class