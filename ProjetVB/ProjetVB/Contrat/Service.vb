Public Class Service

    Public ListecurrentService As List(Of ServiceObject)
    Private BDServicelist As List(Of ServiceObject)
    Private Sub Btn_équipementsave_Click(sender As Object, e As EventArgs) Handles Btn_servicesave.Click
        ListecurrentService = New List(Of ServiceObject)

        If CheckBox_Serv1.Checked = True Then
            ListecurrentService.Add(BDServicelist.Where(Function(i) i.Id = 1).First)
        End If

        If CheckBox_Serv2.Checked = True Then
            ListecurrentService.Add(BDServicelist.Where(Function(a) a.Id = 2).First)
        End If

        If CheckBox_Serv3.Checked = True Then
            ListecurrentService.Add(BDServicelist.Where(Function(b) b.Id = 3).First)
        End If

        If CheckBox_Serv4.Checked = True Then
            ListecurrentService.Add(BDServicelist.Where(Function(c) c.Id = 4).First)
        End If
        If CheckBox_Serv5.Checked = True Then
            ListecurrentService.Add(BDServicelist.Where(Function(d) d.Id = 5).First)
        End If

        If CheckBox_Serv6.Checked = True Then
            ListecurrentService.Add(BDServicelist.Where(Function(f) f.Id = 6).First)
        End If


        Dim ServiceAdd As New Confirmation_Service_Ajouté() With {
            .MdiParent = Form1
        }
        ServiceAdd.Show()
        Me.Close()

    End Sub

    Private Sub Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BDServicelist = DataBase.Services
    End Sub
End Class