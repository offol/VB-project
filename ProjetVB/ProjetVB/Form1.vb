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
        Dim modFournisseur As New ModifierFournisseur() With {
           .MdiParent = Me
       }
        modFournisseur.Show()
    End Sub


	Private Sub AchèvementDesContractsToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim Achevement As New AchevementContrats() With {
			.MdiParent = Me
		}
		Achevement.Show()
	End Sub

	Private Sub EquipementRetour_Click(sender As Object, e As EventArgs)
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
		Dim Equipementret As New EquipementRetour() With {
			.MdiParent = Me
		}
		Equipementret.Show()
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

    Private Sub Aide_Click(sender As Object, e As EventArgs) Handles AideSurToolStripMenuItem.Click
        Dim AideScreen As New Aide() With {
            .MdiParent = Me
        }
        Aide.Show()
    End Sub

    Private Sub APropos_Click(sender As Object, e As EventArgs) Handles ÀProposSGARIToolStripMenuItem.Click
        Dim Apropos As New APropos() With {
            .MdiParent = Me
        }
        Apropos.Show()
    End Sub

    Private Sub SupportTechnique_Click(sender As Object, e As EventArgs) Handles SupportTechniqueToolStripMenuItem.Click
        Dim SupportTechnique As New SupportTechnique() With {
            .MdiParent = Me
        }
        SupportTechnique.Show()
    End Sub

    Private Sub AjoutModificationDestructionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutModificationDestructionToolStripMenuItem.Click
        Dim AjouterModificationDestruction As New Ajout() With {
            .MdiParent = Me
        }
        AjouterModificationDestruction.Show()
    End Sub

    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click
        If ToolStripStatusLabel1.Text = "" Then
            Dim login As New LogIn With {
                .MdiParent = Me
            }
            login.Show()
        Else
            MsgBox("Vous devez être déconnecté pour vous connecter à un autre compte")
        End If
    End Sub

    Private Sub DéconnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnectionToolStripMenuItem.Click
        ToolStripStatusLabel1.Text = ""
        MsgBox("Utilisateur Déconnecté")
    End Sub

    Private Sub FormationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormationToolStripMenuItem.Click
        Dim FormationAide As New Formation With {
            .MdiParent = Me
        }
        FormationAide.Show()
    End Sub
End Class
