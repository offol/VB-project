Public Class Équipement



    Private Sub ListBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox8.SelectedIndexChanged

    End Sub

    Public Sub Btn_servicesave_Click(sender As Object, e As EventArgs) Handles Btn_Equipsave.Click

        Dim EquipAdd As New Confication_Équip_Ajouté() With {
           .MdiParent = Form1
       }
        EquipAdd.Show()
        Me.Close()
    End Sub

    Private Sub Équipement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BDEquiplist As List(Of Equip) = DataBase.LignesEquip

        Dim Listecurrentequip As List(Of Equip) = New List(Of Equip)

        If CB_équip1M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(i) i.NumEquip = 1).First)
        ElseIf CB_équip1A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(r) r.Location = "Mensuelle"))
        End If

        Créer_Contrat.DataGridView_LignesEquipement.DataSource = Listecurrentequip

    End Sub

    Public Sub CB_équip1M_CheckedChanged(sender As Object, e As EventArgs) Handles CB_équip1M.CheckedChanged

    End Sub

    Public Sub CB_équip1A_CheckedChanged(sender As Object, e As EventArgs) Handles CB_équip1A.CheckedChanged

    End Sub

    Public Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Public Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Public Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Public Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Public Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Public Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Public Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged

    End Sub

    Public Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

    End Sub

    Public Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged

    End Sub

    Public Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged

    End Sub

    Public Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged

    End Sub

    Public Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged

    End Sub

    Public Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged

    End Sub

    Public Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged

    End Sub

    Public Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged

    End Sub

    Public Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged

    End Sub

    Public Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged

    End Sub

    Public Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged

    End Sub
End Class