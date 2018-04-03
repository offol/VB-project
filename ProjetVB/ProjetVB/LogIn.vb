Public Class LogIn
    Private Sub Button_connect_Click(sender As Object, e As EventArgs) Handles Button_connect.Click
        Form1.ToolStripStatusLabel1.Text = TextBox_nom.Text

        Me.Close()
    End Sub
End Class