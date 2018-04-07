Public Class Form1

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

    Private Sub CréerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerToolStripMenuItem.Click
        Dim contrat As New Créer_Contrat() With {
            .MdiParent = Me
        }
        contrat.Show()
    End Sub

    Private Sub RenouvelerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenouvelerToolStripMenuItem.Click
        Dim Renouveler As New Renouvellement() With {
            .MdiParent = Me
        }
        Renouveler.Show()
    End Sub


    Private Sub consulterFournisseur_Click(sender As Object, e As EventArgs) Handles consulterFournisseur.Click
        Dim Cf As New ConsulterFournisseur() With {
        .MdiParent = Me
        }

        Cf.Show()
    End Sub

    Private Sub RésilierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RésilierToolStripMenuItem.Click
        Dim Résil As New Résilier() With {
          .MdiParent = Me
      }
        Résil.Show()

    End Sub

    Private Sub RéceptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RéceptionToolStripMenuItem.Click
        Dim Recep As New Rececption_équipement() With {
           .MdiParent = Me
       }
        Recep.Show()
    End Sub

    Private Sub ConsulterToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LivraisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LivraisonToolStripMenuItem.Click

    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        Dim ModifLivraison As New Modifier_Livraison() With {
           .MdiParent = Me
       }
        ModifLivraison.Show()
    End Sub

    Private Sub AnnulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnulerToolStripMenuItem.Click
        Dim CancelLivraison As New Annuler_Livraison() With {
           .MdiParent = Me
       }
        CancelLivraison.Show()

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mnuCréerFournisseur_Click(sender As Object, e As EventArgs) Handles mnuCréerFournisseur.Click
        Dim CréerFournisseur As New CréerFournisseur() With {
         .MdiParent = Me
        }
        CréerFournisseur.Show()
    End Sub

    Private Sub mnuModifierFournisseur_Click(sender As Object, e As EventArgs) Handles mnuModifierFournisseur.Click

    End Sub


    Private Sub AchèvementDesContractsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AchèvementDesContractsToolStripMenuItem.Click
        Dim Achevement As New AchevementContrats() With {
            .MdiParent = Me
        }
        Achevement.Show()
    End Sub

    Private Sub EquipementRetour_Click(sender As Object, e As EventArgs) Handles ÉquipementsÀRetournerToolStripMenuItem.Click
        Dim EquipementRetour As New EquipementRetour() With {
            .MdiParent = Me
        }
        EquipementRetour.Show()
    End Sub

    Private Sub PaiementCarteCredit_Click(sender As Object, e As EventArgs) Handles PaiementParCarteCréditToolStripMenuItem.Click
        Dim PaiementCarte As New PaiementCarteCredit() With {
            .MdiParent = Me
        }
        PaiementCarte.Show()
    End Sub

    Private Sub PaiementRetraitDirect_Click(sender As Object, e As EventArgs) Handles PaiementParRetraitDirectToolStripMenuItem.Click
        Dim PaiementRetrait As New PaiementRetraitDirect() With {
            .MdiParent = Me
        }
        PaiementRetrait.Show()
    End Sub

    Private Sub ÉquipementÀCommanderToolStripMenuItem_Click(send As Object, e As EventArgs) Handles ÉquipementÀCommanderToolStripMenuItem.Click
        Dim EquipementCommander As New EquipementCommander() With {
            .MdiParent = Me
        }
        EquipementCommander.Show()
    End Sub

    Private Sub ContratsOuverts_Click(send As Object, e As EventArgs) Handles ContractsOuvertsToolStripMenuItem.Click
        Dim ContratsOuverts As New ContratsOuverts() With {
            .MdiParent = Me
        }
        ContratsOuverts.Show()
    End Sub

    Private Sub ContratsResiliers_Click(send As Object, e As EventArgs) Handles ContractsRésiliersToolStripMenuItem.Click
        Dim ContratsResiliers As New ContratsResiliers() With {
            .MdiParent = Me
        }
        ContratsResiliers.Show()
    End Sub

    Private Sub FournisseurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FournisseurToolStripMenuItem.Click

    End Sub

    Private Sub ChangerLeMotDePasseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangerLeMotDePasseToolStripMenuItem.Click
        Dim ChangerMotdepasse As New ChangerMotDePasse() With {
        .MdiParent = Me
        }
        ChangerMotdepasse.Show()
    End Sub

    Private Sub ListeDesUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesUtilisateursToolStripMenuItem.Click
        Dim ListeUtilisateur As New ListeUtilisateur() With {
            .MdiParent = Me
        }
        ListeUtilisateur.Show()
    End Sub
End Class
