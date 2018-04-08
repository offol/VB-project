Public Class Équipement

    Public Listecurrentequip As List(Of Equip_Object)
    Private BDEquiplist As List(Of Equip_Object)

    Private Sub ListBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox8.SelectedIndexChanged

    End Sub

    Public Sub Btn_servicesave_Click(sender As Object, e As EventArgs) Handles Btn_Equipsave.Click

        Listecurrentequip = New List(Of Equip_Object)

        If CB_équip1M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(i) i.NumEquip = 1 AndAlso i.Location = "Annuelle").First)
        ElseIf CB_équip1A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(r) r.NumEquip = 1 AndAlso r.Location = "Mensuelle").First)
        End If

        Dim EquipAdd As New Confication_Équip_Ajouté() With {
           .MdiParent = Form1
       }
        EquipAdd.Show()
        Me.Close()
    End Sub

    Private Sub Équipement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BDEquiplist = DataBase.LignesEquip
    End Sub
End Class