Public Class FacturesScreen

    Private ListFactures As List(Of Facture)
    Private ListLignesFacture As List(Of LigneFacture)
    Private myOption As String

    'Constructeur
    Public Sub New(NewOption As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        Me.myOption = NewOption
    End Sub

    'Charge les factures
    Private Sub FacturesScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListFactures = DataBase.Factures

        If myOption Is "Today" Then
            ListFactures = ListFactures.Where(Function(f) f.Date_Facture.Year = DateTime.Now.Year AndAlso f.Date_Facture.Day = DateTime.Now.Day).ToList()

        Else
            ListFactures = ListFactures.Where(Function(f) f.Date_Facture.Year <> DateTime.Now.Year AndAlso f.Date_Facture.Day <> DateTime.Now.Day).ToList()
        End If

        UpdateDataSource()
    End Sub

    'ajoute une nouvelle facture
    Private Sub Button_New_Facture_Click(sender As Object, e As EventArgs) Handles Button_New_Facture.Click
        Dim maxNum As Integer = 0

        For Each fac As Facture In ListFactures
            If fac.Numéro > maxNum Then
                maxNum = fac.Numéro
            End If
        Next
        maxNum += 1

        ListFactures.Add(New Facture(1, maxNum, System.DateTime.Now.ToString(), "Ouvert", 0, 0, 0, 0))

        UpdateDataSource()

    End Sub

    'Met à jour la liste des factures dans la gridview
    Private Sub UpdateDataSource()
        DataGridView_Facture.DataSource = Nothing
        DataGridView_Facture.DataSource = ListFactures
    End Sub

    Private Sub UpdateLigneDataSource()
        DataGridView_LigneFacture.DataSource = Nothing
        DataGridView_LigneFacture.DataSource = ListLignesFacture
    End Sub

    'Trouve la facture qui est sélectionné
    Private Function FindSelectedFacture()
        Dim SelectedNum As Integer = DataGridView_Facture.SelectedRows.Item(0).Cells().Item(0).Value

        Return ListFactures.Where(Function(i) i.Numéro = SelectedNum).First
    End Function

    'Trouve la ligne de facture qui est sélectionné
    Private Function FindSelectedLigne()
        Dim SelectedNum As Integer = DataGridView_LigneFacture.SelectedRows.Item(0).Cells().Item(1).Value
        Return ListLignesFacture.Where(Function(i) i.Numéro_Ligne = SelectedNum).First
    End Function

    'Supprime la facture sélectionné
    Private Sub Button_Supprimer_Click(sender As Object, e As EventArgs) Handles Button_Supprimer.Click
        If DataGridView_Facture.SelectedRows.Count() <> 0 Then

            ListFactures.Remove(FindSelectedFacture())

            UpdateDataSource()

        End If
    End Sub

    'Calcule la tvq pour la facture sélectionné
    Private Sub Button_calc_tvq_Click(sender As Object, e As EventArgs) Handles Button_calc_tvq.Click
        If DataGridView_Facture.SelectedRows.Count() <> 0 Then
            Dim SelectedFacture As Facture = FindSelectedFacture()

            SelectedFacture.Montant_TVQ = SelectedFacture.Montant_Hors_Taxe * TVQ.TauxTVQ

            UpdateDataSource()
        End If
    End Sub

    'calcule la tps pour la facture sélectionné
    Private Sub _calc_tps_Click(sender As Object, e As EventArgs) Handles _calc_tps.Click
        If DataGridView_Facture.SelectedRows.Count() <> 0 Then
            Dim SelectedFacture As Facture = FindSelectedFacture()

            SelectedFacture.Montant_TPS = SelectedFacture.Montant_Hors_Taxe * TPS.TauxTPS

            UpdateDataSource()
        End If
    End Sub

    'Calcule le montant total pour la facture sélectionné
    Private Sub Button_calc_total_Click(sender As Object, e As EventArgs) Handles Button_calc_total.Click
        If DataGridView_Facture.SelectedRows.Count() <> 0 Then
            Dim SelectedFacture As Facture = FindSelectedFacture()

            SelectedFacture.Total = SelectedFacture.Montant_Hors_Taxe + SelectedFacture.Montant_TPS + SelectedFacture.Montant_TVQ

            UpdateDataSource()
        End If
    End Sub

    'Lorsqu'un facture est sélectionner cette fonction va chercher les lignes de facture associer avec la facture
    Private Sub DataGridView_Facture_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView_Facture.SelectionChanged
        If DataGridView_Facture.SelectedRows.Count() <> 0 Then
            Dim SelectedFacture As Facture = FindSelectedFacture()
            ListLignesFacture = DataBase.LignesFactures
            ListLignesFacture = ListLignesFacture.Where(Function(l) l.Numéro_Facture = SelectedFacture.Numéro).ToList()

            DataGridView_LigneFacture.DataSource = ListLignesFacture
        End If
    End Sub

    'Ajoute une nouvelle ligne de facture
    Private Sub Button_NewLigneFac_Click(sender As Object, e As EventArgs) Handles Button_NewLigneFac.Click
        If DataGridView_Facture.SelectedRows.Count() <> 0 Then
            Dim SelectedFacture As Facture = FindSelectedFacture()

            Dim maxNum As Integer = 0
            If ListLignesFacture.Count() > 0 Then
                For Each fac As LigneFacture In ListLignesFacture
                    If fac.Numéro_Ligne > maxNum Then
                        maxNum = fac.Numéro_Ligne
                    End If
                Next
            End If
            maxNum += 1


            ListLignesFacture.Add(New LigneFacture(SelectedFacture.Numéro, maxNum, " ", 0, 0, 0))

            UpdateLigneDataSource()
        End If
    End Sub

    'Supprime une ligne de la facture
    Private Sub Button_SuppLigne_Click(sender As Object, e As EventArgs) Handles Button_SuppLigne.Click
        If DataGridView_LigneFacture.SelectedRows.Count() <> 0 Then
            Dim SelectedLigne As LigneFacture = FindSelectedLigne()

            ListLignesFacture.Remove(SelectedLigne)

            UpdateLigneDataSource()
        End If
    End Sub

    'Calcule le prix hors-taxe d'une ligne de facture
    Private Sub Button_CalcLigneHT_Click(sender As Object, e As EventArgs) Handles Button_CalcLigneHT.Click
        If DataGridView_LigneFacture.SelectedRows.Count() <> 0 Then
            Dim SelectedLigne As LigneFacture = FindSelectedLigne()

            SelectedLigne.Prix_Hors_Taxe = SelectedLigne.Quantité * SelectedLigne.Prix_Unitaire

            UpdateLigneDataSource()
        End If
    End Sub

    'Calcule le prix hors-Taxe d'une facture
    Private Sub Button_calcFac_ht_Click(sender As Object, e As EventArgs) Handles Button_calcFac_ht.Click
        If DataGridView_Facture.SelectedRows.Count() <> 0 Then
            Dim SelectedFacture As Facture = FindSelectedFacture()

            Dim montant As Double = 0

            For Each ligne As LigneFacture In ListLignesFacture
                montant += ligne.Prix_Hors_Taxe
            Next

            SelectedFacture.Montant_Hors_Taxe = montant

            UpdateDataSource()
        End If
    End Sub
End Class