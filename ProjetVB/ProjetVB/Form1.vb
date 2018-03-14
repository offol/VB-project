Public Class Form1
    Private Sub MenuItem_Service_Click(sender As Object, e As EventArgs) Handles MenuItem_Service.Click
        Dim serv As New MAJService With {
            .MdiParent = Me
        }
        serv.Show()
    End Sub
End Class
