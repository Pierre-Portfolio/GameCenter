Public Class Morpion

    ''' <summary>
    ''' Configuration de la forme accueil
    ''' </summary>
    Private Sub Configuration()
        Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
        Me.Text = ("jeu du morpion")
        Me.BackColor = Color.Honeydew
        Me.Width = 660
        Me.Height = 462
    End Sub

    ''' <summary>
    ''' Création des images de titre
    ''' </summary>
    Dim ptbxI1 As New PictureBox
    Dim ptbxI2 As New PictureBox

    Private Sub Photosprincipale()
        Dim jeux As New PictureBox
        jeux.BackgroundImage = Image.FromFile("C:\Users\petil\OneDrive\Bureau\Projet VB\Morpion\Morpion\Resources\titre.png")
        jeux.BackgroundImageLayout = BackgroundImageLayout.Stretch
        jeux.Width = 524
        jeux.Height = 74
        jeux.Location = New Drawing.Point(57, 12)

        Me.Controls.Add(jeux)


        jeux.BackgroundImage = Image.FromFile("C:\Users\petil\OneDrive\Bureau\Projet VB\Morpion\Morpion\Resources\profils1.jpg")
        ptbxI1.BackgroundImageLayout = BackgroundImageLayout.Stretch
        ptbxI1.Width = 174
        ptbxI1.Location = New Drawing.Point(57, 92)
        ptbxI1.Height = 154
        Me.Controls.Add(ptbxI1)

        jeux.BackgroundImage = Image.FromFile("C:\Users\petil\OneDrive\Bureau\Projet VB\Morpion\Morpion\Resources\profils2.jpg")
        ptbxI2.BackgroundImageLayout = BackgroundImageLayout.Stretch
        ptbxI2.Size = ptbxI1.Size
        ptbxI2.Location = New Drawing.Point(407, 92)
        Me.Controls.Add(ptbxI2)
    End Sub

    ''' <summary>
    ''' Création des boutons d'images
    ''' </summary>

    Dim btn1 As New Button
    Dim btn2 As New Button
    Dim btn3 As New Button
    Dim btn4 As New Button
    Dim btn5 As New Button
    Dim btn6 As New Button

    Private Sub bouton()
        btn1.Height = 23
        btn1.Width = 53
        btn2.Size = btn1.Size
        btn3.Size = btn1.Size
        btn4.Size = btn1.Size
        btn5.Size = btn1.Size
        btn6.Size = btn1.Size

        btn1.Location = New Drawing.Point(57, 252)
        btn2.Location = New Drawing.Point(117, 252)
        btn3.Location = New Drawing.Point(177, 252)
        btn4.Location = New Drawing.Point(407, 252)
        btn5.Location = New Drawing.Point(467, 252)
        btn6.Location = New Drawing.Point(527, 252)

        btn1.Text = ("1")
        btn2.Text = ("2")
        btn3.Text = ("3")
        btn4.Text = ("1")
        btn5.Text = ("2")
        btn6.Text = ("3")

        Me.Controls.Add(btn1)
        Me.Controls.Add(btn2)
        Me.Controls.Add(btn3)
        Me.Controls.Add(btn4)
        Me.Controls.Add(btn5)
        Me.Controls.Add(btn6)

    End Sub

    ''' <summary>
    ''' Création dES labels demandant le nom des joueurs
    ''' </summary>
    Private Sub labelNom()
        Dim lblP1 As New Label With {
                .BackColor = Color.Honeydew,
                .Font = New Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold),
                .ForeColor = Color.Black,
                .Width = 250,
                .Height = 30,
                .Text = ("Nom joueur 1 : "),
                .Location = New Drawing.Point(57, 303)
            }
        Me.Controls.Add(lblP1)


        Dim lblP2 As New Label With {
                .BackColor = Color.Honeydew,
                .Font = New Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold),
                .ForeColor = Color.Black,
                .Width = 250,
                .Height = 30,
                .Text = ("Nom joueur 2 : "),
                .Location = New Drawing.Point(404, 303)
            }
        Me.Controls.Add(lblP2)
    End Sub

    ''' <summary>
    ''' Création des text ou les joueur mettrons leur pseudo
    ''' </summary>
    Dim txtbox As New TextBox
    Dim txtbox1 As New TextBox
    Private Sub textbox()

        txtbox.Width = 174
        txtbox.Height = 20
        txtbox.Location = New Drawing.Point(57, 335)
        Me.Controls.Add(txtbox)

        txtbox1.Width = 174
        txtbox1.Height = 20
        txtbox1.Location = New Drawing.Point(407, 335)
        Me.Controls.Add(txtbox1)
    End Sub

    ''' <summary>
    ''' Verifie si les parametre précédent sont conforme
    ''' </summary>
    Dim btnValider As New Button
    Private Sub Valider()
        btnValider.Height = 23
        btnValider.Width = 75
        btnValider.Location = New Drawing.Point(284, 393)
        btnValider.Text = ("Valider")
        Me.Controls.Add(btnValider)
    End Sub

    ''' <summary>
    ''' Coeur du programme qui va réalisé l'affichage de tout les composants
    ''' </summary>
    Private Sub Morpion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Configuration()
        Photosprincipale()
        bouton()
        labelNom()
        textbox()
        Valider()
    End Sub


End Class
