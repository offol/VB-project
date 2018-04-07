Public Class Paiement

    Private ListFactures As List(Of Facture)
    Private ListMode As List(Of String)

    Private Sub Paiement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListFactures = DataBase.Factures

        ListFactures = ListFactures.Where(Function(f) f.État Is "Ouvert").ToList()

        ListMode = New List(Of String) From {
            "Carte de crédit",
            "Chèque",
            "Retrait direct"
        }

        ComboBox_modePaiement.DataSource = ListMode

        UpdateDataSource()
    End Sub

    'Met à jour la liste des factures dans la gridview
    Private Sub UpdateDataSource()
        DataGridView_Facture.DataSource = Nothing
        DataGridView_Facture.DataSource = ListFactures
    End Sub

    'Trouve la facture qui est sélectionné
    Private Function FindSelectedFacture()
        Dim SelectedNum As Integer = DataGridView_Facture.SelectedRows.Item(0).Cells().Item(0).Value

        Return ListFactures.Where(Function(i) i.Numéro = SelectedNum).First
    End Function

    'Action lorsque le boutton payer est activer
    Private Sub Button_payer_Click(sender As Object, e As EventArgs) Handles Button_payer.Click
        Dim SelectedFacture As Facture = FindSelectedFacture()

        SelectedFacture.Date_Paiement = DateTime.Today
        SelectedFacture.Montant_Restant = SelectedFacture.Total - Val(TextBox_montantPayer.Text)

        If SelectedFacture.Montant_Restant = 0 Then
            SelectedFacture.État = "Fermer"
        End If

        'TODO sauvegarder les informations de paiement du client
        If ComboBox_modePaiement.SelectedItem Is "Carte de crédit" Then

            Dim DbPaiement As List(Of PCarteCredit) = DataBase.PaiementCredit

            DbPaiement.Add(New PCarteCredit(TextBox_NoCarte.Text, DateTime.Now, TextBox_TypeCarte.Text, TextBox_montantPayer.Text))

        ElseIf ComboBox_modePaiement.SelectedItem Is "Retrait direct" Then
            Dim DbPaiement As List(Of PRetraitDirect) = DataBase.PaiementRetrait

            DbPaiement.Add(New PRetraitDirect(TextBox_NoCompte.Text, TextBox_TypeRD.Text, TextBox_montantPayer.Text))

        End If

        UpdateDataSource()
    End Sub

    'Change la visibilité des groupbox selon le mode de paiement choisit
    Private Sub ComboBox_modePaiement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_modePaiement.SelectedIndexChanged

        'Charger les informations de paiement du client si elle existe
        If ComboBox_modePaiement.SelectedItem Is "Carte de crédit" Then
            GroupBox_carteCrédit.Visible = True
            GroupBox_chèque.Visible = False
            GroupBox_retraitDirect.Visible = False
        ElseIf ComboBox_modePaiement.SelectedItem Is "Chèque" Then
            GroupBox_carteCrédit.Visible = False
            GroupBox_chèque.Visible = True
            GroupBox_retraitDirect.Visible = False
        ElseIf ComboBox_modePaiement.SelectedItem Is "Retrait direct" Then
            GroupBox_carteCrédit.Visible = False
            GroupBox_chèque.Visible = False
            GroupBox_retraitDirect.Visible = True
        End If

    End Sub
End Class