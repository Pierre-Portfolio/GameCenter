<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpNouvelleTache = New System.Windows.Forms.GroupBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lblCategorie = New System.Windows.Forms.Label()
        Me.cboCategorie = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.grpListe = New System.Windows.Forms.GroupBox()
        Me.btnPurger = New System.Windows.Forms.Button()
        Me.pnlListe1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpTache = New System.Windows.Forms.GroupBox()
        Me.PanelVue = New System.Windows.Forms.Panel()
        Me.grpNouvelleTache.SuspendLayout()
        Me.grpListe.SuspendLayout()
        Me.grpTache.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNouvelleTache
        '
        Me.grpNouvelleTache.Controls.Add(Me.chkDate)
        Me.grpNouvelleTache.Controls.Add(Me.DateTimePicker1)
        Me.grpNouvelleTache.Controls.Add(Me.btnAjouter)
        Me.grpNouvelleTache.Controls.Add(Me.lblCategorie)
        Me.grpNouvelleTache.Controls.Add(Me.cboCategorie)
        Me.grpNouvelleTache.Controls.Add(Me.txtDescription)
        Me.grpNouvelleTache.Controls.Add(Me.lblDescription)
        Me.grpNouvelleTache.Controls.Add(Me.txtTitre)
        Me.grpNouvelleTache.Controls.Add(Me.lblTitre)
        Me.grpNouvelleTache.Location = New System.Drawing.Point(16, 17)
        Me.grpNouvelleTache.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grpNouvelleTache.Name = "grpNouvelleTache"
        Me.grpNouvelleTache.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grpNouvelleTache.Size = New System.Drawing.Size(1288, 401)
        Me.grpNouvelleTache.TabIndex = 0
        Me.grpNouvelleTache.TabStop = False
        Me.grpNouvelleTache.Text = "Nouvelle Tache"
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(203, 343)
        Me.chkDate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(187, 36)
        Me.chkDate.TabIndex = 7
        Me.chkDate.Text = "Date limite"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(400, 343)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 38)
        Me.DateTimePicker1.TabIndex = 1
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(1069, 331)
        Me.btnAjouter.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(211, 62)
        Me.btnAjouter.TabIndex = 6
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'lblCategorie
        '
        Me.lblCategorie.AutoSize = True
        Me.lblCategorie.Location = New System.Drawing.Point(8, 150)
        Me.lblCategorie.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCategorie.Name = "lblCategorie"
        Me.lblCategorie.Size = New System.Drawing.Size(138, 32)
        Me.lblCategorie.TabIndex = 5
        Me.lblCategorie.Text = "Categorie"
        '
        'cboCategorie
        '
        Me.cboCategorie.FormattingEnabled = True
        Me.cboCategorie.Location = New System.Drawing.Point(16, 198)
        Me.cboCategorie.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cboCategorie.Name = "cboCategorie"
        Me.cboCategorie.Size = New System.Drawing.Size(159, 39)
        Me.cboCategorie.TabIndex = 4
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(203, 103)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(1076, 221)
        Me.txtDescription.TabIndex = 3
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(8, 105)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(157, 32)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Descritpion"
        '
        'txtTitre
        '
        Me.txtTitre.Location = New System.Drawing.Point(101, 43)
        Me.txtTitre.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(1177, 38)
        Me.txtTitre.TabIndex = 1
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Location = New System.Drawing.Point(8, 50)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(71, 32)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Titre"
        '
        'grpListe
        '
        Me.grpListe.Controls.Add(Me.btnPurger)
        Me.grpListe.Controls.Add(Me.pnlListe1)
        Me.grpListe.Location = New System.Drawing.Point(16, 427)
        Me.grpListe.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grpListe.Name = "grpListe"
        Me.grpListe.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grpListe.Size = New System.Drawing.Size(613, 596)
        Me.grpListe.TabIndex = 1
        Me.grpListe.TabStop = False
        Me.grpListe.Text = "Liste des taches"
        '
        'btnPurger
        '
        Me.btnPurger.Location = New System.Drawing.Point(421, 653)
        Me.btnPurger.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnPurger.Name = "btnPurger"
        Me.btnPurger.Size = New System.Drawing.Size(181, 64)
        Me.btnPurger.TabIndex = 1
        Me.btnPurger.Text = "Purger"
        Me.btnPurger.UseVisualStyleBackColor = True
        '
        'pnlListe1
        '
        Me.pnlListe1.AutoScroll = True
        Me.pnlListe1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlListe1.Location = New System.Drawing.Point(21, 38)
        Me.pnlListe1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pnlListe1.Name = "pnlListe1"
        Me.pnlListe1.Size = New System.Drawing.Size(571, 539)
        Me.pnlListe1.TabIndex = 0
        Me.pnlListe1.WrapContents = False
        '
        'grpTache
        '
        Me.grpTache.Controls.Add(Me.PanelVue)
        Me.grpTache.Location = New System.Drawing.Point(637, 427)
        Me.grpTache.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grpTache.Name = "grpTache"
        Me.grpTache.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grpTache.Size = New System.Drawing.Size(667, 749)
        Me.grpTache.TabIndex = 2
        Me.grpTache.TabStop = False
        Me.grpTache.Text = "Tache"
        '
        'PanelVue
        '
        Me.PanelVue.Location = New System.Drawing.Point(16, 236)
        Me.PanelVue.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.PanelVue.Name = "PanelVue"
        Me.PanelVue.Size = New System.Drawing.Size(651, 537)
        Me.PanelVue.TabIndex = 0
        '
        'frmPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1323, 1030)
        Me.Controls.Add(Me.grpTache)
        Me.Controls.Add(Me.grpListe)
        Me.Controls.Add(Me.grpNouvelleTache)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmPrincipale"
        Me.Text = "Todo list"
        Me.grpNouvelleTache.ResumeLayout(False)
        Me.grpNouvelleTache.PerformLayout()
        Me.grpListe.ResumeLayout(False)
        Me.grpTache.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpNouvelleTache As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents lblCategorie As System.Windows.Forms.Label
    Friend WithEvents cboCategorie As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents grpListe As System.Windows.Forms.GroupBox
    Friend WithEvents pnlListe1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnPurger As System.Windows.Forms.Button
    Friend WithEvents grpTache As System.Windows.Forms.GroupBox
    Friend WithEvents PanelVue As Panel
End Class
