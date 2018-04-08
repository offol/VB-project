﻿'Ce Module sert de base de données provisoir pour pouvoir tester
'Ajouter les données que vous voulez a l'intérieur de ce module
Public Module DataBase

    Public PaiementCredit = New List(Of PCarteCredit) From {
        New PCarteCredit("123456789", New System.DateTime(1993, 5, 31, 12, 14, 0), "Visa", 230.99)
    }

    Public PaiementRetrait = New List(Of PRetraitDirect) From {
        New PRetraitDirect("567546", "Desjardin", 543.82)
    }

    'Liste de clients
    Public Clients = New List(Of Client) From {
        New Client(1, "Entreprise", "blabla road", "819-456-3456", "819-436-7654")
    }


    'Liste de services
    Public Services = New List(Of ServiceObject) From {
            New ServiceObject(1, "Service1", "blabla", 2.5),
            New ServiceObject(2, "Service2", "Bonjour", 3)
        }

    'Liste de factures
    Public Factures = New List(Of Facture) From {
            New Facture(1, 1, New System.DateTime(1993, 5, 31, 12, 14, 0), "Ouvert", 0, 0, 0, 0, Nothing, 0),
            New Facture(1, 2, New System.DateTime(2001, 6, 22, 10, 10, 0), "Fermer", 0, 0, 0, 0, Nothing, 0),
            New Facture(1, 3, DateTime.Now, "Ouvert", 0, 0, 0, 0, Nothing, 0)
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

    'Ajouter des cartes de crédit relier a des clients
    Public CartesDeCredits = New List(Of CarteDeCrédit) From {
        New CarteDeCrédit(1, "1245678986544", New Date(2020, 6, 22, 0, 0, 0), "Visa")
    }

    'Liste de chèques relié a des clients
    Public Cheques = New List(Of Chèque) From {
        New Chèque(1, "1245", DateTime.Today)
    }

    'Liste de retraits direct
    Public RetraitDirects = New List(Of RetraitDirect) From {
        New RetraitDirect(1, "1166367", "Desjardin")
    }

    'Liste lignes Équipement
    Public LignesEquip = New List(Of Equip) From {
        New Equip(1, "Mensuelle", "Bureautique", 1, 45),
        New Equip(1, "Annuelle", "Bureautique", 1, 500),
        New Equip(2, "Mensuelle", "Bureautique", 1, 60),
        New Equip(2, "Annuelle", "Bureautique", 1, 650),
        New Equip(3, "Mensuelle", "Bureautique", 1, 52),
        New Equip(3, "Annuelle", "Bureautique", 1, 600),
        New Equip(4, "Mensuelle", "Bureautique", 1, 60),
        New Equip(4, "Annuelle", "Bureautique", 1, 650),
        New Equip(5, "Mensuelle", "Bureautique", 1, 60),
        New Equip(5, "Annuelle", "Bureautique", 1, 650),
        New Equip(6, "Mensuelle", "Multimédia", 1, 65),
        New Equip(6, "Annuelle", "Multimédia", 1, 700),
        New Equip(7, "Mensuelle", "Multimédia", 1, 60),
        New Equip(7, "Annuelle", "Multimédia", 1, 650),
        New Equip(8, "Mensuelle", "Multimédia", 1, 70),
        New Equip(8, "Annuelle", "Multimédia", 1, 780),
        New Equip(9, "Mensuelle", "Multimédia", 1, 80),
        New Equip(9, "Annuelle", "Multimédia", 1, 820),
        New Equip(10, "Mensuelle", "Multimédia", 1, 70),
        New Equip(10, "Annuelle", "Multimédia", 1, 780)
    }

End Module
