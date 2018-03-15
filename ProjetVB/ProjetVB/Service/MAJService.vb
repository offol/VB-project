Public Class MAJService

    Private myList As List(Of Service)

    'Charge les services existant dans la listbox
    Private Sub MAJService_Load(sender As Object, e As EventArgs) Handles Me.Load
        myList = DataBase.Services
        SetDataSource()

    End Sub

    'Sauvegarde les modifications fait à un service
    Private Sub Button_Sauvegarder_Click(sender As Object, e As EventArgs) Handles Button_Sauvegarder.Click
        If ListBox_Service.SelectedItem IsNot Nothing Then

            ListBox_Service.SelectedItem.Description = TextBox_Description.Text
            ListBox_Service.SelectedItem.Prix = TextBox_Prix.Text
            ListBox_Service.SelectedItem.Nom = TextBox_Nom.Text
            SetDataSource()

        End If

    End Sub

    'Ouvre la fenêtre de création de service
    Private Sub Button_CréerService_Click(sender As Object, e As EventArgs) Handles Button_CréerService.Click
        myList.Add(New Service(myList.Last().Id + 1, TextBox_Nom.Text, TextBox_Description.Text, TextBox_Prix.Text))
        SetDataSource()
    End Sub

    'Met à jour les textbox pour voir les informations du service sélectionné
    Private Sub ListBox_Service_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox_Service.SelectedValueChanged

        If ListBox_Service.SelectedItem IsNot Nothing Then
            TextBox_Description.Text = ListBox_Service.SelectedItem.Description
            TextBox_Prix.Text = ListBox_Service.SelectedItem.Prix
            TextBox_Nom.Text = ListBox_Service.SelectedItem.Nom
        End If

    End Sub

    'Supprime un service
    Private Sub Button_Supprimer_Click(sender As Object, e As EventArgs) Handles Button_Supprimer.Click
        myList.Remove(ListBox_Service.SelectedItem)
        SetDataSource()
    End Sub

    'Initialize la datasource de la listBox
    Private Sub SetDataSource()
        ListBox_Service.DataSource = Nothing
        ListBox_Service.DataSource = myList
        ListBox_Service.DisplayMember = "Nom"
        ListBox_Service.ClearSelected()
        TextBox_Description.Text = ""
        TextBox_Prix.Text = ""
        TextBox_Nom.Text = ""
    End Sub
End Class