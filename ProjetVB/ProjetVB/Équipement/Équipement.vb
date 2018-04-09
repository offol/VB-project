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

        If CB_équip2M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(a) a.NumEquip = 2 AndAlso a.Location = "Annuelle").First)
        ElseIf CB_équip2A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(b) b.NumEquip = 2 AndAlso b.Location = "Mensuelle").First)
        End If

        If CB_équip3M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(c) c.NumEquip = 3 AndAlso c.Location = "Annuelle").First)
        ElseIf CB_équip3A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(d) d.NumEquip = 3 AndAlso d.Location = "Mensuelle").First)
        End If

        If CB_équip4M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(g) g.NumEquip = 4 AndAlso g.Location = "Annuelle").First)
        ElseIf CB_équip4A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(f) f.NumEquip = 4 AndAlso f.Location = "Mensuelle").First)
        End If

        If CB_équip5M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(h) h.NumEquip = 5 AndAlso h.Location = "Annuelle").First)
        ElseIf CB_équip5A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(j) j.NumEquip = 5 AndAlso j.Location = "Mensuelle").First)
        End If

        If CB_équip6M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(k) k.NumEquip = 6 AndAlso k.Location = "Annuelle").First)
        ElseIf CB_équip6A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(l) l.NumEquip = 6 AndAlso l.Location = "Mensuelle").First)
        End If

        If CB_équip7M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(m) m.NumEquip = 7 AndAlso m.Location = "Annuelle").First)
        ElseIf CB_équip7A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(n) n.NumEquip = 7 AndAlso n.Location = "Mensuelle").First)
        End If

        If CB_équip8M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(o) o.NumEquip = 8 AndAlso o.Location = "Annuelle").First)
        ElseIf CB_équip8A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(p) p.NumEquip = 8 AndAlso p.Location = "Mensuelle").First)
        End If

        If CB_équip9M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(q) q.NumEquip = 9 AndAlso q.Location = "Annuelle").First)
        ElseIf CB_équip9A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(s) s.NumEquip = 9 AndAlso s.Location = "Mensuelle").First)
        End If

        If CB_équip10M.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(t) t.NumEquip = 10 AndAlso t.Location = "Annuelle").First)
        ElseIf CB_équip10A.Checked = True Then
            Listecurrentequip.Add(BDEquiplist.Where(Function(u) u.NumEquip = 10 AndAlso u.Location = "Mensuelle").First)
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