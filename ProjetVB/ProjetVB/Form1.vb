﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New LogIn With {
         .MdiParent = Me
     }
        login.Show()
    End Sub

    Private Sub MenuItem_Service_Click(sender As Object, e As EventArgs) Handles MenuItem_Service.Click
        Dim serv As New MAJService With {
            .MdiParent = Me
        }
        serv.Show()
    End Sub

    Private Sub TaxeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaxeToolStripMenuItem.Click
        Dim tax As New Taxe With {
            .MdiParent = Me
        }
        tax.Show()
    End Sub

    Private Sub PaiementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaiementToolStripMenuItem.Click
        Dim paie As New Paiement With {
            .MdiParent = Me
        }
        paie.Show()
    End Sub

    Private Sub DaujourdhuiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaujourdhuiToolStripMenuItem.Click
        Dim fac As New FacturesScreen("Today") With {
            .MdiParent = Me
        }
        fac.Show()
    End Sub

    Private Sub AutresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutresToolStripMenuItem.Click
        Dim fac As New FacturesScreen("Others") With {
           .MdiParent = Me
       }
        fac.Show()
    End Sub

    Private Sub ContratToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratToolStripMenuItem.Click

    End Sub

    Private Sub CréerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerToolStripMenuItem.Click
        Dim contrat As New Créer_Contrat() With {
            .MdiParent = Me
        }
        contrat.Show()
    End Sub

    Private Sub RenouvelerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenouvelerToolStripMenuItem.Click
        Dim Renouveler As New Renew() With {
            .MdiParent = Me
        }
        Renouveler.Show()
    End Sub

    Private Sub FournisseurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FournisseurToolStripMenuItem.Click

    End Sub

    Private Sub consulterFournisseur_Click(sender As Object, e As EventArgs) Handles consulterFournisseur.Click
        Dim Cf As New ConsulterFournisseur() With {
        .MdiParent = Me
        }

        Cf.Show()
    End Sub

    Private Sub creerFournisseur_Click(sender As Object, e As EventArgs) Handles mnuCréerFournisseur.Click
        Dim Creerf As New CréerFournisseur() With {
        .MdiParent = Me
        }
        Creerf.Show()
    End Sub

    Private Sub modifierFournisseur_Click(sender As Object, e As EventArgs) Handles mnuModifierFournisseur.Click
        Dim modifierf As New ModifierFournisseur() With {
        .MdiParent = Me
        }
        modifierf.Show()
    End Sub

    Private Sub ChangerLeMotDePasseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangerLeMotDePasseToolStripMenuItem.Click
        Dim changerpassword As New ChangerMotDePasse() With {
        .MdiParent = Me
            }
        changerpassword.Show()
    End Sub

    Private Sub ListeDesUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesUtilisateursToolStripMenuItem.Click
        Dim listeUtilisateur As New ListeUtilisateur() With {
        .MdiParent = Me
        }
        listeUtilisateur.Show()
    End Sub
End Class
