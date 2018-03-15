'Ce Module sert de base de données provisoir pour pouvoir tester
'Ajouter les données que vous voulez a l'intérieur de ce module
Public Module DataBase

    'Liste de services
    Public Services = New List(Of Service) From {
            New Service(1, "Service1", "blabla", 2.5),
            New Service(2, "Service2", "Bonjour", 3)
        }

    'Liste de factures
    Public Factures = New List(Of Facture) From {
            New Facture(1, 1, New System.DateTime(1993, 5, 31, 12, 14, 0), "Ouvert", 0, 0, 0, 0),
            New Facture(1, 2, New System.DateTime(2001, 6, 22, 10, 10, 0), "Fermer", 0, 0, 0, 0),
            New Facture(1, 3, DateTime.Now, "Ouvert", 0, 0, 0, 0)
        }

    'Liste de lignes de facture
    Public LignesFactures = New List(Of LigneFacture) From {
        New LigneFacture(1, 1, "Ordinateur", 3, 2.25, 0),
        New LigneFacture(1, 2, "Modem", 6, 24, 0),
        New LigneFacture(2, 1, "Service1", 2, 100, 0),
        New LigneFacture(2, 2, "Service3", 1, 7.6, 0),
        New LigneFacture(3, 1, "Portable", 1, 7.6, 0),
        New LigneFacture(3, 2, "Something", 1, 7.6, 0)
    }

End Module
