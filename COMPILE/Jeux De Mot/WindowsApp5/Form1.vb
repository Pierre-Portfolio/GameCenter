Public Class Form1
    Private rand As New Random()
    Dim nbEssais As Integer = 5
    Dim Clean As Integer = 0
    Dim nbrTrouve As Integer = 0
    Dim nbrParties As Integer = 0
    Dim Indice As Integer = 0
    Dim RatioVictoire As Double = 0
    Dim TableauMots() As String = {"CHAISE", "TABLE", "ORDINATEUR", "CHEMIN", "VOITURE", "TAPIS", "EXTENSIONS"}
    Dim rnd As New Random

    Private Sub Propositions()
        If (txtProposition.Text = "") Then
            lstproposition.Items.Add("Erreur le champ est vide !")
            afficherNBrestant()
        ElseIf (txtProposition.Text = TableauMots(Indice)) Then
            lstproposition.Text = "Gagner"
            Gagner()
            nbrTrouve = nbrTrouve + 1
        Else
            lstproposition.Items.Add(txtProposition.Text)
            nbEssais = nbEssais - &B1
            afficherNBrestant()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTester.Click
        If (VerifStarts()) Then
            VerifStart()
        Else
            If (nbEssais > 0) Then
                Cleanlst()
                Propositions()
            Else
                motIncorrect()
            End If
        End If
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim result As Integer = MessageBox.Show("Voulez-vous vraiment quitter ?", "Alerte", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.No Then
            Exit Sub
        Else result = DialogResult.Yes
            Quitter()
            Dispose()
        End If
    End Sub

    Private Function melanger(ByVal chaine As String) As String
        Dim newChaine As String = ""
        Dim pos As Integer
        For Each letter As Char In chaine
            pos = rand.Next(0, newChaine.Length + 1)
            newChaine = newChaine.Insert(rand.Next(0, newChaine.Length + 1), letter)
        Next
        lblMotDesordre.Text = newChaine
    End Function

    Private Sub Quitter()
        RatioVictoire = nbrTrouve * 100 / nbrParties
        If (RatioVictoire >= 70) Then
            MessageBox.Show(RatioVictoire & "% de victoire, félicitation! cela représente " & nbrTrouve & " mot(s) trouvé(s) sur " & nbrParties & " parties. Au Revoir!")
        ElseIf (RatioVictoire = 50) Then
            MessageBox.Show(RatioVictoire & "% de victoire, tu fera mieu la prochaine fois! cela représente " & nbrTrouve & " mot(s) trouvé(s) sur " & nbrParties & " parties. Au Revoir!")
        Else
            MessageBox.Show(RatioVictoire & "% de victoire, pas mal! cela représente " & nbrTrouve & " mot(s) trouvé(s) sur " & nbrParties & " parties. Au Revoir!")
        End If
    End Sub

    Private Sub nouvellePartie()
        nbrParties = nbrParties + 1
        lstproposition.Items.Clear()
        txtProposition.Clear()
        nbEssais = 5
        afficherNBrestant()
        Indice = rnd.Next(4)
        melanger(TableauMots(Indice))
        btnStart.Visible = False
        lblMotDesordre.Visible = True
    End Sub

    Private Sub motIncorrect()
        If nbEssais = 0 Then
            lsthistorique.Items.Add("Partie " & nbrParties & " : perdu")
            If MessageBox.Show("Perdu. Le mot était : " & TableauMots(Indice) & ". Veux tu rejouer ?") Then
                nouvellePartie()
            Else
                Quitter()
            End If
        End If
    End Sub

    Private Sub Gagner()
        lsthistorique.Items.Add("Partie " & nbrParties & " : gagner")
        If MessageBox.Show("Gagner. Le mot était : " & TableauMots(Indice) & ". Veux tu rejouer ?") Then
            nouvellePartie()
        Else
            Quitter()
        End If
    End Sub

    Private Sub btnRejouer_Click(sender As Object, e As EventArgs) Handles btnRejouer.Click
        Dim result As Integer = MessageBox.Show("Voulez-vous vraiment rejouer ?", "Alerte", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.No Then
            Exit Sub
        Else result = DialogResult.Yes
            lsthistorique.Items.Add("Partie " & nbrParties & " : Abandon")
            nouvellePartie()
        End If
    End Sub

    Private Sub afficherNBrestant()
        lblNbRestant.Text = nbEssais
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        nouvellePartie()
    End Sub

    Private Function VerifStarts() As Boolean
        If (btnStart.Visible = True) Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub VerifStart()
        Cleanlst()
        lstproposition.Items.Add("La partie n'a pas commencée ! ")
    End Sub

    Private Sub Cleanlst()
        Clean = Clean + 1
        If (Clean = &B101) Then
            lstproposition.Items.Clear()
            Clean = 0
        End If
    End Sub

End Class
