Public Class Form1
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

    Private Sub CréerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuCréerFournisseur.Click
        CréerFournisseur.Show()

    End Sub

    Private Sub ModifierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuModifierFournisseur.Click
        ModifierFournisseur.Show()

    End Sub

    Private Sub RenouvelerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenouvelerToolStripMenuItem.Click

    End Sub

    Private Sub FournisseurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FournisseurToolStripMenuItem.Click

    End Sub
End Class
