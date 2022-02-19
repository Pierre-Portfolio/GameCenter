Public Class Form1

    Dim nbtour As New Label
    Dim lstbx As New TextBox
    Dim btnLeave As New Button
    Dim pseudo1 As New Label
    Dim pseudo2 As New Label
    Dim btnValider As New Button
    Dim txtbox As New TextBox
    Dim txtbox1 As New TextBox
    Dim lblP1 As New Label
    Dim lblP2 As New Label

    Dim btn1 As New Button
    Dim btn2 As New Button
    Dim btn3 As New Button
    Dim btn4 As New Button
    Dim btn5 As New Button
    Dim btn6 As New Button

    Dim jeux As New PictureBox
    Dim ptbxI1 As New PictureBox
    Dim ptbxI2 As New PictureBox
    ''' <summary>
    ''' Configuration de la forme accueil
    ''' </summary>
    Private Sub Configuration()
        Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
        Me.Text = ("Morpion")
        Me.BackColor = Color.Honeydew
        Me.Width = 660
        Me.Height = 462
        Me.MinimumSize = New Size(660, 462)
    End Sub


    ''' <summary>
    ''' Création des images de titre
    ''' </summary>


    Private Sub Photosprincipale()

        jeux.BackgroundImage = My.Resources.Resources.titre
        jeux.BackgroundImageLayout = BackgroundImageLayout.Stretch
        jeux.Width = 0.785 * Me.Width
        jeux.Height = 74
        jeux.Top = 3
        jeux.Left = 57
        jeux.Anchor = AnchorStyles.Right And AnchorStyles.Left
        jeux.SizeMode = PictureBoxSizeMode.AutoSize
        Me.Controls.Add(jeux)

        ptbxI1.BackgroundImage = My.Resources.Resources.profils1
        ptbxI1.BackgroundImageLayout = BackgroundImageLayout.Stretch
        ptbxI1.Width = 174
        ptbxI1.Location = New Drawing.Point(57, 92)
        ptbxI1.Height = 154
        jeux.SizeMode = PictureBoxSizeMode.AutoSize
        Me.Controls.Add(ptbxI1)

        ptbxI2.BackgroundImage = My.Resources.Resources.profils1
        ptbxI2.BackgroundImageLayout = BackgroundImageLayout.Stretch
        ptbxI2.Size = ptbxI1.Size
        ptbxI2.Location = New Drawing.Point(Me.Width - 253, 92)
        ptbxI2.SizeMode = AnchorStyles.Right And AnchorStyles.Left
        Me.Controls.Add(ptbxI2)
    End Sub

    ''' <summary>
    ''' Création des boutons d'images
    ''' </summary>
    Private Sub Bouton()
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

        AddHandler btn1.Click, AddressOf ChangerImage1
        AddHandler btn2.Click, AddressOf ChangerImage2
        AddHandler btn3.Click, AddressOf ChangerImage3
        AddHandler btn4.Click, AddressOf ChangerImage4
        AddHandler btn5.Click, AddressOf ChangerImage5
        AddHandler btn6.Click, AddressOf ChangerImage6

    End Sub

    ''' <summary>
    ''' Création dES labels demandant le nom des joueurs
    ''' </summary>


    Private Sub LabelNom()

        lblP1.BackColor = Color.Honeydew
        lblP1.Font = New Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold)
        lblP1.ForeColor = Color.Black
        lblP1.Width = 250
        lblP1.Height = 30
        lblP1.Text = ("Nom joueur 1 : ")
        lblP1.Location = New Drawing.Point(57, 303)
        Me.Controls.Add(lblP1)

        lblP2.BackColor = Color.Honeydew
        lblP2.Font = New Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold)
        lblP2.ForeColor = Color.Black
        lblP2.Width = 250
        lblP2.Height = 30
        lblP2.Text = ("Nom joueur 2 : ")
        lblP2.Location = New Drawing.Point(404, 303)
        Me.Controls.Add(lblP2)
    End Sub

    ''' <summary>
    ''' Création des text ou les joueur mettrons leur pseudo
    ''' </summary>
    Private Sub Textbox()

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

    Private Sub Valider()
        btnValider.Height = 23
        btnValider.Width = 75
        btnValider.Location = New Drawing.Point(284, 393)
        btnValider.Text = ("Valider")
        Me.Controls.Add(btnValider)
        AddHandler btnValider.Click, AddressOf validation
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
        ListBox()
    End Sub

    Private Sub ChangerImage1(sender As Object, e As EventArgs)
        ptbxI1.BackgroundImage = My.Resources.Resources.profils1
    End Sub

    Private Sub ChangerImage2(sender As Object, e As EventArgs)
        ptbxI1.BackgroundImage = My.Resources.Resources.profils2
    End Sub

    Private Sub ChangerImage3(sender As Object, e As EventArgs)
        ptbxI1.BackgroundImage = My.Resources.Resources.profils3
    End Sub

    Private Sub ChangerImage4(sender As Object, e As EventArgs)
        ptbxI2.BackgroundImage = My.Resources.Resources.profils1
    End Sub

    Private Sub ChangerImage5(sender As Object, e As EventArgs)
        ptbxI2.BackgroundImage = My.Resources.Resources.profils2
    End Sub

    Private Sub ChangerImage6(sender As Object, e As EventArgs)
        ptbxI2.BackgroundImage = My.Resources.Resources.profils3
    End Sub

    Private Sub Validation()
        If txtbox.Text = ("") Then
            MessageBox.Show("Le joueur 1 n'a pas de pseudo.", "Important Message")
        ElseIf txtbox1.Text = ("") Then
            MessageBox.Show("Le joueur 2 n'a pas de pseudo.", "Important Message")
        ElseIf txtbox1.Text = txtbox.Text Then
            MessageBox.Show("Le deux joueur de peuvent pas avoir le même pseudo", "Important Message")
        Else
            Nettoyage()
            Demarrage()
        End If
    End Sub




    Private Sub Nettoyage()
        pseudo1.Text = txtbox.Text
        pseudo2.Text = txtbox1.Text
        txtbox.Visible = False
        txtbox1.Visible = False
        txtbox.Enabled = False
        txtbox1.Enabled = False

        btn1.Visible = False
        btn1.Enabled = False
        btn2.Visible = False
        btn2.Enabled = False
        btn3.Visible = False
        btn3.Enabled = False
        btn4.Visible = False
        btn4.Enabled = False
        btn5.Visible = False
        btn5.Enabled = False
        btn6.Visible = False
        btn6.Enabled = False

        lblP1.Visible = False
        lblP2.Visible = False
        btnValider.Visible = False

    End Sub


    Private Sub Demarrage()
        pseudo1.ForeColor = Color.Black
        pseudo1.Height = 30
        pseudo1.Width = 100
        pseudo1.Location = New Drawing.Point(57, (ptbxI1.Bottom) + (8 / 462) * Me.Height)
        pseudo1.Font = New Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold)
        Me.Controls.Add(pseudo1)

        pseudo2.ForeColor = Color.Black
        pseudo2.Height = 30
        pseudo2.Width = 100
        pseudo2.Location = New Drawing.Point(ptbxI2.Left, (ptbxI1.Bottom) + (8 / 462) * Me.Height)
        pseudo2.Font = New Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold)
        Me.Controls.Add(pseudo2)

        btnLeave.ForeColor = Color.Honeydew
        btnLeave.Size = btnValider.Size
        btnLeave.Location = New Drawing.Point(Me.Width / 2 - 38, Me.Height - 80)
        btnLeave.Text = ("Quitter")
        btnLeave.ForeColor = Color.Black

        AddHandler btnLeave.Click, AddressOf Quitter

        Me.Controls.Add(btnLeave)

        Affichertour()

        lstbx.Visible = True
        nbtour.Visible = True
        tlpbouton.Visible = True

        btnLeave.Visible = True
    End Sub

    Private Sub Form1_AutoSizeChanged(sender As Object, e As EventArgs) Handles Me.Resize
        jeux.Top = 3
        jeux.Left = ((1 - 0.785) / 2) * Me.Width - 10
        jeux.Width = 0.785 * Me.Width
        jeux.Height = 0.2 * Me.Height

        ptbxI1.Top = (jeux.Bottom) + (18 / 660) * Me.Height

        ptbxI2.Top = (jeux.Bottom) + (18 / 660) * Me.Height
        ptbxI2.Left = Me.Width - 253

        btn1.Top = (ptbxI1.Bottom) + (8 / 462) * Me.Height
        btn2.Top = (ptbxI1.Bottom) + (8 / 462) * Me.Height
        btn3.Top = (ptbxI1.Bottom) + (8 / 462) * Me.Height
        btn4.Top = (ptbxI1.Bottom) + (8 / 462) * Me.Height
        btn5.Top = (ptbxI1.Bottom) + (8 / 462) * Me.Height
        btn6.Top = (ptbxI1.Bottom) + (8 / 462) * Me.Height

        lblP1.Top = (btn1.Bottom) + (28 / 462) * Me.Height
        lblP2.Top = (btn1.Bottom) + (28 / 462) * Me.Height

        txtbox.Top = (lblP1.Bottom) + (5 / 462) * Me.Height
        txtbox1.Top = (lblP1.Bottom) + (5 / 462) * Me.Height

        btnValider.Top = Me.Height - 80
        btnValider.Left = Me.Width / 2 - 38

        btnLeave.Top = Me.Height - 80
        btnLeave.Left = Me.Width / 2 - 38

        btn4.Left = ptbxI2.Left
        btn5.Left = btn4.Left + 60
        btn6.Left = btn5.Left + 60
        lblP2.Left = ptbxI2.Left
        txtbox1.Left = ptbxI2.Left

        pseudo1.Top = (ptbxI1.Bottom) + (8 / 462) * Me.Height
        pseudo2.Top = (ptbxI1.Bottom) + (8 / 462) * Me.Height
        pseudo2.Left = ptbxI2.Left

        tlpbouton.Left = btnValider.Left - 45
        tlpbouton.Top = ptbxI2.Top
        nbtour.Location = New Drawing.Point(btnValider.Left - 38, tlpbouton.Bottom + 5)

        lstbx.Left = pseudo2.Left
        lstbx.Top = (pseudo2.Bottom) + (20 / 660) * Me.Height
    End Sub


    Private Sub ListBox()
        tlpbouton.Left = btnValider.Left - 38
        tlpbouton.Top = (jeux.Bottom) + (18 / 660) * Me.Height

        lstbx.Height = 100
        lstbx.Visible = False
        lstbx.Width = 174
        lstbx.Multiline = True
        lstbx.Location = New Drawing.Point(pseudo2.Left, pseudo2.Bottom + 100)
        lstbx.ScrollBars = ScrollBars.Vertical
        lstbx.Text = ("Historique des partie:
")
        Me.Controls.Add(lstbx)
    End Sub


    Private Sub Affichertour()
        nbtour.BackColor = Color.Honeydew
        nbtour.Font = New Font(FontFamily.GenericSansSerif, 9.0F, FontStyle.Bold)
        nbtour.ForeColor = Color.Black
        nbtour.Width = 200
        nbtour.Height = 30
        nbtour.Text = txtbox.Text + " à toi de jouer"
        nbtour.Location = New Drawing.Point(btnValider.Left - 38, tlpbouton.Bottom + 5)
        nbtour.Visible = False
        Me.Controls.Add(nbtour)
    End Sub



    Private Sub Verifwinner()

        If bt1.Text = "X" And bt2.Text = "X" And bt3.Text = "X" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo1.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt4.Text = "X" And bt5.Text = "X" And bt6.Text = "X" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo1.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt7.Text = "X" And bt8.Text = "X" And bt9.Text = "X" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo1.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If


        If bt1.Text = "X" And bt5.Text = "X" And bt9.Text = "X" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo1.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt7.Text = "X" And bt5.Text = "X" And bt3.Text = "X" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo1.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If


        If bt1.Text = "X" And bt4.Text = "X" And bt7.Text = "X" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo1.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt2.Text = "X" And bt5.Text = "X" And bt8.Text = "X" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo1.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt3.Text = "X" And bt6.Text = "X" And bt9.Text = "X" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo1.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        'Verif joueur2

        If bt1.Text = "O" And bt2.Text = "O" And bt3.Text = "O" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo2.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt4.Text = "O" And bt5.Text = "O" And bt6.Text = "O" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo2.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt7.Text = "O" And bt8.Text = "O" And bt9.Text = "O" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo2.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If


        If bt1.Text = "O" And bt5.Text = "O" And bt9.Text = "O" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo2.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt7.Text = "O" And bt5.Text = "O" And bt3.Text = "O" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo2.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If


        If bt1.Text = "O" And bt4.Text = "O" And bt7.Text = "O" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo2.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt2.Text = "O" And bt5.Text = "O" And bt8.Text = "O" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo2.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If

        If bt3.Text = "O" And bt6.Text = "O" And bt9.Text = "O" Then
            lstbx.Text = lstbx.Text + ("Le joueur " + pseudo2.Text + " à gagné la partie.
")
            bloquerautrecoup()
            restart()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt1.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt1.Text = "O"
        End If
        bt1.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt2.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt2.Text = "O"
        End If
        bt2.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt3.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt3.Text = "O"
        End If
        bt3.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt4.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt4.Text = "O"
        End If
        bt4.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt5.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt5.Text = "O"
        End If
        bt5.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt6.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt6.Text = "O"
        End If
        bt6.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt7.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt7.Text = "O"
        End If
        bt7.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt8.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt8.Text = "O"
        End If
        bt8.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        If nbtour.Text = txtbox.Text + " à toi de jouer" Then
            bt9.Text = "X"
            nbtour.Text = txtbox1.Text + " à toi de jouer"
        Else
            nbtour.Text = txtbox.Text + " à toi de jouer"
            bt9.Text = "O"
        End If
        bt9.Enabled = False
        verifwinner()
        Egaliter()
    End Sub

    Private Sub restart()
        If MessageBox.Show("Voullez vous rejouer ? ? ", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
        DialogResult.Yes Then
            bt1.Enabled = True
            bt1.Text = ""

            bt2.Enabled = True
            bt2.Text = ""

            bt3.Enabled = True
            bt3.Text = ""

            bt4.Enabled = True
            bt4.Text = ""

            bt5.Enabled = True
            bt5.Text = ""

            bt5.Enabled = True
            bt5.Text = ""

            bt6.Enabled = True
            bt6.Text = ""

            bt7.Enabled = True
            bt7.Text = ""

            bt8.Enabled = True
            bt8.Text = ""

            bt9.Enabled = True
            bt9.Text = ""
        Else
            Me.Dispose()
        End If


    End Sub

    Private Sub Bloquerautrecoup()
        bt1.Enabled = False
        bt2.Enabled = False
        bt3.Enabled = False
        bt4.Enabled = False
        bt5.Enabled = False
        bt6.Enabled = False
        bt7.Enabled = False
        bt8.Enabled = False
        bt9.Enabled = False
    End Sub

    Private Sub Quitter()
        If MessageBox.Show("Voullez vous revenir au menu principal ? ", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
        DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Egaliter()
        If bt1.Enabled = False And bt2.Enabled = False And bt3.Enabled = False And bt4.Enabled = False And bt5.Enabled = False And bt6.Enabled = False And bt7.Enabled = False And bt8.Enabled = False And bt9.Enabled = False Then
            MsgBox("Egaliter !")
            lstbx.Text = lstbx.Text + ("Egaliter !
")
            restart()
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(292, 212)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
