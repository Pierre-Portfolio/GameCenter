Public Class Plateforme

    ''' <summary>
    ''' Configuration de la forme accueil
    ''' </summary>
    Private Sub Accueil()
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Text = ("Plateforme de jeu video")
        Me.BackgroundImage = My.Resources.Resources.background
        Me.Width = 368
        Me.Height = 275
    End Sub


    ''' <summary>
    ''' configuration des boutons de l'interface
    ''' </summary>
    Private Sub Bouton_accueil()
        Dim btn1 As New Button
        AddHandler btn1.Click, AddressOf LanceMorpion
        Dim btn2 As New Button
        AddHandler btn2.Click, AddressOf LanceBiblio
        Dim btn3 As New Button
        AddHandler btn3.Click, AddressOf Recherche
        Dim btnQuitter As New Button
        AddHandler btnQuitter.Click, AddressOf Quitter

        btn1.BackgroundImage = My.Resources.Resources.notre_select
        btn1.BackgroundImageLayout = BackgroundImageLayout.Stretch

        btn2.BackgroundImage = My.Resources.Resources.biblioteque
        btn2.BackgroundImageLayout = BackgroundImageLayout.Stretch

        btn3.BackgroundImage = My.Resources.Resources.rechercher
        btn3.BackgroundImageLayout = BackgroundImageLayout.Stretch

        btnQuitter.BackgroundImage = My.Resources.Resources.quitter
        btnQuitter.BackgroundImageLayout = BackgroundImageLayout.Stretch

        btn1.Location = New Drawing.Point(44, 121)
        btn1.Width = 114
        btn1.Height = 52

        btn2.Location = New Drawing.Point(190, 121)
        btn2.Size = btn1.Size

        btn3.Location = New Drawing.Point(84, 194)
        btn1.Width = 114
        btn1.Height = 52

        btnQuitter.Location = New Drawing.Point(190, 194)
        btnQuitter.Size = btn3.Size

        Me.Controls.Add(btn1)
        Me.Controls.Add(btn2)
        Me.Controls.Add(btn3)
        Me.Controls.Add(btnQuitter)
    End Sub

    ''' <summary>
    ''' Configuration des images de titre
    ''' </summary>
    Private Sub photos()
        Dim titre As New PictureBox
        Dim titre2 As New PictureBox


        titre.BackgroundImage = My.Resources.Resources.plateforme
        titre.BackgroundImageLayout = BackgroundImageLayout.Stretch
        titre.Width = 351
        titre.Location = New Drawing.Point(1, 1)
        titre.Height = 50

        titre2.BackgroundImage = My.Resources.Resources.de_jeux
        titre2.BackgroundImageLayout = BackgroundImageLayout.Stretch
        titre2.Location = New Drawing.Point(90, 50)
        titre2.Width = 175
        titre2.Height = 50

        Me.Controls.Add(titre)
        Me.Controls.Add(titre2)
    End Sub


    ''' <summary>
    ''' Appelle toute les fonction citée précédemment
    ''' </summary>
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accueil()
        bouton_accueil()
        photos()
    End Sub


    ''' <summary>
    ''' Evenement du bouton quitter qui permet de quitter l'application après une confirmation
    ''' </summary>
    Private Sub Quitter(sender As Object, e As EventArgs)
        If MessageBox.Show("Voulez vous vraiment quitter la plateforme ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) =
            DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Lance la forme recherche pour rechercher un jeu
    ''' </summary>
    Private Sub Recherche(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        'rechercher.Show()
    End Sub

    ''' <summary>
    ''' Lance la forme biblioteque ou tout les jeux sont répertorié
    ''' </summary>
    Private Sub LanceBiblio(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        'biblio.Show()
    End Sub

    ''' <summary>
    ''' Lance la forme morpion qui permet de jouer au morpion
    ''' </summary>
    Private Sub LanceMorpion()
        Dim news As New Form1
        news.Show()
    End Sub
End Class
