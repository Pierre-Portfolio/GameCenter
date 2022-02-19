' TP5, création de controles dynamiques
' TO-DO liste

Public Class frmPrincipale

#Region "Classes et types utiles"

    ''' <summary>
    ''' Classe representant une tache de la 'Todo list'
    ''' </summary>
    ''' <remarks></remarks>
    Class Tache
        'titre de la tache, ne peut pas etre vide
        Public titre As String
        'description de la tache, peut etre vide
        Public description As String
        'categorie de la tache, peut etre vide (=-1)
        Public categorie As Categorie = -1
        'date de fin de la tache, peut etre vide (= Nothing)
        Public dateFin As Date = Nothing
        'est-ce que la tache est termine
        Public termine As Boolean = False
        'tableau des controles pour l'affichage de la tache dans la liste (panel, label, bouton voir, bouton modifier)
        Public controles As Control()


        ''' <summary>
        ''' Creer un nouvel objet tache
        ''' </summary>
        ''' <param name="titre">le titre de la tache</param>
        ''' <param name="description">la description de la tache</param>
        ''' <param name="controles">le tableau des controles pour l'affichage de la tache dans la liste (panel, label, bouton voir, bouton modifier)</param>
        ''' <remarks></remarks>
        Sub New(titre As String, description As String, controles As Control())
            Me.titre = titre
            Me.description = description
            Me.controles = controles
        End Sub

        ''' <summary>
        ''' Determine si un controle est lie a l'affichage de cette tache dans la liste des taches
        ''' </summary>
        ''' <param name="ctrl">le controle a tester</param>
        ''' <returns>retourne vrai si ce controle est l'un de ceux utilises pour afficher cette tache dans la liste</returns>
        ''' <remarks></remarks>
        Public Function lieeAuControle(ctrl As Control) As Boolean
            For Each c In controles
                If ctrl.Equals(c) Then
                    Return True
                End If
            Next
            Return False
        End Function

    End Class

    ''' <summary>
    ''' Enumeration des categories possibles pour une tache
    ''' </summary>
    ''' <remarks></remarks>
    Enum Categorie
        travail
        loisir
        famille
        maison
    End Enum

#End Region

#Region "Variables Globales"

    'liste de toutes les taches
    Private taches As New List(Of Tache)
    'tache dont les details sont actuellement affiches
    Dim tacheAffichee As Tache = Nothing
    'references vers les controles qui seront utilises pour la modification d'une tache
    Dim txtModifTitre As New TextBox
    Dim txtModifDescr As New TextBox
    Dim cboModifCat As New ComboBox
    Dim chkModifDate As New CheckBox
    Dim dateModif As New DateTimePicker

#End Region

#Region "Procedures Evenementielles Statiques"

    ''' <summary>
    ''' Procedure evenementielle declenchee au chargement de la form.
    ''' Remplissage des valeur de la liste de categorie et initialisation des controles de saisie.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cats As Array
        cats = System.Enum.GetValues(GetType(Categorie))
        For Each cat In cats
            cboCategorie.Items.Add(cat)
        Next
        initialiserSaisie()
    End Sub

    ''' <summary>
    ''' Procedure evenementielle declenchee lors d'un click sur le bouton ajouter.
    ''' Cree les controles pour afficher la nouvelle tache dans la liste, et cree la tache.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If txtTitre.Text = "" Then
            MsgBox("Vous devez donner au moins un titre !!!")
            Return
        End If

        'creation des controles pour cette tache dans la liste des taches
        'COMPLETER ICI LE CODE DE CETTE PROCEDURE EVENEMENTIELLE
        'VOUS DEVEZ CREER LES 4 CONTROLES pnlTache, chkTache, btnVoirTache et btnModifierTache
        'QUI PERMETTRONT D"AFFICHER LA TACHE DANS LA LISTE
        'VOUS DEVEZ AUSSI ATTACHER LES PROCEDURES EVENEMENTIELLES CORRESPONDANTES A CES CONTROLES

        Dim pnlTache As New Panel
        pnlTache.AutoSize = True
        Dim chkTache As New CheckBox
        chkTache.Text = txtTitre.Text
        pnlTache.Controls.Add(chkTache)
        AddHandler chkTache.CheckedChanged, AddressOf cocherTache
        Dim btnVoirTache As New Button
        btnVoirTache.Text = "voir"
        btnVoirTache.AutoSize = True
        btnVoirTache.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        btnVoirTache.Location = New Point(chkTache.Size.Width + 1, 0)
        pnlTache.Controls.Add(btnVoirTache)
        AddHandler btnVoirTache.Click, AddressOf ClickVoirOuModifierTache
        Dim btnModifierTache As New Button
        btnModifierTache.Text = "mod."
        btnModifierTache.AutoSize = True
        btnModifierTache.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        btnModifierTache.Location = New Point(chkTache.Size.Width + 1 + btnVoirTache.Size.Width + 1, 0)
        pnlTache.Controls.Add(btnModifierTache)
        AddHandler btnModifierTache.Click, AddressOf ClickVoirOuModifierTache
        pnlListe1.Controls.Add(pnlTache)
        Dim btnModifierModifier As New Button
        Dim controles As Control() = {pnlTache, chkTache, btnVoirTache, btnModifierTache, btnModifierModifier}



        'creation d'une nouvelle tache
        Dim tache As New Tache(txtTitre.Text, txtDescription.Text, controles)
        If cboCategorie.SelectedIndex <> -1 Then
            tache.categorie = cboCategorie.SelectedIndex
        End If
        If chkDate.Checked Then
            tache.dateFin = DateTimePicker1.Value
        End If

        'ajout de la tache a la liste
        taches.Add(tache)

        initialiserSaisie()
    End Sub

    'ECRIRE ICI LA PROCEDURE EVENEMENTIELLE POUR LE BOUTON "PURGER"

#End Region

#Region "Procedures Evenementielles Dynamiques"

    ''' <summary>
    ''' Procedure evenementielle declenchee lorsqu'une case a cocher est activee/desactivee dans la liste des taches. 
    ''' La tache correspondante sera marquee comme terminee. Une tache marquee comme terminee ne pourra plus etre modifiee.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cocherTache(sender As Object, e As EventArgs)
        'retrouver la tache a afficher a partir du controle
        Dim tache As Tache = retrouverTache(sender)
        'si la tache a ete trouvee, la marquer comme terminee ou pas
        'si la tache est terminee, desactiver le bouton modifier
        If Not tache Is Nothing Then
            tache.termine = CType(sender, CheckBox).Checked
            tache.controles(3).Enabled = Not tache.termine
        End If
    End Sub

    ''' <summary>
    ''' Procedure evenementielle declenchee lors d'un click sur le bouton pour voir ou modifier une tache.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClickVoirOuModifierTache(sender As Object, e As EventArgs)
        'si il y a une tache deja affichee, enlever la bordure dans la liste
        If Not tacheAffichee Is Nothing Then
            CType(tacheAffichee.controles(0), Panel).BorderStyle = BorderStyle.None
        End If
        'retrouver la tache a afficher a partir du controle
        tacheAffichee = retrouverTache(sender)
        'si la tache a ete trouvee, lancer la creation des controles d'affichage ou de modification
        'selon le bouton qui a ete actionne
        If Not tacheAffichee Is Nothing Then
            afficherTache(tacheAffichee, CType(sender, Button).Text = "mod.")
        End If
    End Sub

    'ECRIRE ICI LES PROCEDURES EVENEMENTIELLES POUR LES BOUTONS DE VALIDATION ET D'ANNULATION DE LA MODIFICATION D'UNE TACHE

#End Region

#Region "Procedures et fonctions utiles"

    ''' <summary>
    ''' Initialise les champs de saisie d'une nouvelle tache
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initialiserSaisie()
        txtTitre.Text = ""
        txtDescription.Text = ""
        cboCategorie.SelectedIndex = -1
        chkDate.Checked = False
    End Sub

    Private Sub afficherListe()

    End Sub

    ''' <summary>
    ''' Retrouve la tache de la liste liee a un controle particulier de la liste des taches
    ''' </summary>
    ''' <param name="ctrl">le controle</param>
    ''' <returns>la tache a laquelle ce controle est lie</returns>
    ''' <remarks></remarks>
    Private Function retrouverTache(ctrl As Control) As Tache
        For Each tache In taches
            If tache.lieeAuControle(ctrl) Then
                Return tache
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Creation des controles pour l'affichage complet d'une tache.
    ''' La tache sera affichee dans un panel dans le controle GroupBox 'grpTache', avec des controles permettant
    ''' son affichage ou sa modification, selon la valeur du parametre modifiable.
    ''' Si la tache peut etre modifiee, des bouton "valider" et "annuler" permettront d'appliquer ou non les changements.
    ''' La tache concernee dans la liste sera mise en evidence.
    ''' </summary>
    ''' <param name="tache">la tache a afficher</param>
    ''' <remarks></remarks>
    Private Sub afficherTache(tache As Tache, modifiable As Boolean)
        'ajoute une bordure a la tache affichee dans la liste
        CType(tache.controles(0), Panel).BorderStyle = BorderStyle.FixedSingle
        'enleve les controles deja present dans la zone d'affichage
        grpTache.Controls.Clear()
        'index permettant de calculer la position verticale des controle
        Dim indexY = 0
        'creation d'un Panel pour ajouter les controles
        Dim pnlTache As New Panel
        pnlTache.AutoSize = True
        pnlTache.Anchor = AnchorStyles.Left & AnchorStyles.Bottom & AnchorStyles.Right & AnchorStyles.Top


        If Not modifiable Then

            Dim LabelTitre As New Label
            LabelTitre.Text = "Titre"
            LabelTitre.AutoSize = True
            LabelTitre.Location = New Point(0, indexY)
            pnlTache.Controls.Add(LabelTitre)
            indexY += LabelTitre.Size.Height + 10

            txtModifTitre.ReadOnly = True
            txtModifTitre.AutoSize = True
            txtModifTitre.Location = New Point(0, indexY)
            txtModifTitre.Text = tache.titre
            pnlTache.Controls.Add(txtModifTitre)
            indexY += txtModifTitre.Size.Height + 20

            Dim LabelDesc As New Label
            LabelDesc.Text = "Description"
            LabelDesc.AutoSize = True
            LabelDesc.Location = New Point(0, indexY)
            pnlTache.Controls.Add(LabelDesc)
            indexY += LabelDesc.Size.Height + 10

            txtModifDescr.ReadOnly = True
            txtModifDescr.AutoSize = True
            txtModifDescr.Location = New Point(0, indexY)
            txtModifDescr.Text = tache.description
            pnlTache.Controls.Add(txtModifDescr)
            indexY += txtModifDescr.Size.Height + 20

        Else

            txtModifTitre.ReadOnly = False
            txtModifDescr.AutoSize = True
            txtModifTitre.Location = New Point(0, indexY)
            txtModifTitre.Text = tache.titre
            pnlTache.Controls.Add(txtModifTitre)
            indexY += txtModifTitre.Size.Height + 20

            txtModifDescr.ReadOnly = False
            txtModifDescr.AutoSize = False
            txtModifTitre.Size = New Size(100, 200)
            txtModifDescr.Location = New Point(0, indexY)
            txtModifDescr.Text = tache.description
            pnlTache.Controls.Add(txtModifDescr)
            indexY += txtModifDescr.Size.Height + 20


            Dim cats As Array
            cats = System.Enum.GetValues(GetType(Categorie))
            For Each cat In cats
                cboModifCat.Items.Add(cat)
            Next
            cboModifCat.AutoSize = True
            cboModifCat.Location = New Point(0, indexY)
            cboModifCat.SelectedIndex = tache.categorie
            pnlTache.Controls.Add(cboModifCat)
            indexY += cboModifCat.Size.Height + 20


            chkModifDate.AutoSize = True
            chkModifDate.Location = New Point(0, indexY)
            chkModifDate.Text = "Date Limite"
            chkModifDate.Checked = (Not tache.dateFin = Nothing)
            pnlTache.Controls.Add(chkModifDate)
            indexY += chkModifDate.Size.Height + 20

            dateModif.AutoSize = True
            dateModif.Location = New Point(0, indexY)
            If Not tache.dateFin = Nothing Then
                dateModif.Value = tache.dateFin
            End If
            pnlTache.Controls.Add(dateModif)
            indexY += dateModif.Size.Height + 20








            'mettre les autres boutons et callback




            tache.controles(4) = New Button
            tache.controles(4).AutoSize = True
            tache.controles(4).Location = New Point(0, indexY)
            tache.controles(4).Text = "Valider"
            pnlTache.Controls.Add(tache.controles(4))
            AddHandler tache.controles(4).Click, AddressOf ModifierMod
            Dim BtnAnnuler As New Button
            BtnAnnuler.AutoSize = True
            BtnAnnuler.Location = New Point(100, indexY)
            BtnAnnuler.Text = "Annuler"
            pnlTache.Controls.Add(BtnAnnuler)
            AddHandler BtnAnnuler.Click, AddressOf AnnulerMod


            'ROLES POUR MODIFIER UNE TACHE
            '=> TEXTBOX, COMBOBOX, CHECKBOX ET DATETIMEPICKER
            '=> BOUTONS VALIDER ET ANNULER
        End If

        'ajout du panel avec les controles dans la zone d'affichage
        pnlTache.Location = New Point(5, 20)
        grpTache.Controls.Add(pnlTache)
    End Sub


    Private Sub AnnulerMod(sender As Object, e As EventArgs)
        grpTache.Controls.Clear()
    End Sub

    Private Sub ModifierMod(sender As Object, e As EventArgs)
        Dim Tache As Tache = retrouverTache(sender)
        Tache.titre = txtModifTitre.Text
        Tache.controles(0).Controls(0).Text = txtModifTitre.Text
        Tache.description = txtModifDescr.Text
        If cboModifCat.SelectedIndex <> -1 Then
            Tache.categorie = cboModifCat.SelectedIndex
        Else
            Tache.categorie = -1
        End If
        If chkModifDate.Checked Then
            Tache.dateFin = dateModif.Value
        Else
            Tache.dateFin = Nothing
        End If
        grpTache.Controls.Clear()
    End Sub

#End Region

End Class