<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnTester = New System.Windows.Forms.Button()
        Me.lblOrdre = New System.Windows.Forms.Label()
        Me.lblProposition1 = New System.Windows.Forms.Label()
        Me.lstproposition = New System.Windows.Forms.ListBox()
        Me.lsthistorique = New System.Windows.Forms.ListBox()
        Me.txtProposition = New System.Windows.Forms.TextBox()
        Me.lblProposition2 = New System.Windows.Forms.Label()
        Me.lblEssais = New System.Windows.Forms.Label()
        Me.lblRestant = New System.Windows.Forms.Label()
        Me.lblMotDesordre = New System.Windows.Forms.Label()
        Me.lblNbRestant = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnRejouer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelProp = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanelEssais = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanelProp2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelProp.SuspendLayout()
        Me.FlowLayoutPanelEssais.SuspendLayout()
        Me.FlowLayoutPanelProp2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTester
        '
        Me.btnTester.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnTester.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTester.Location = New System.Drawing.Point(124, 3)
        Me.btnTester.Name = "btnTester"
        Me.btnTester.Size = New System.Drawing.Size(87, 20)
        Me.btnTester.TabIndex = 1
        Me.btnTester.Text = "Tester"
        Me.btnTester.UseVisualStyleBackColor = True
        '
        'lblOrdre
        '
        Me.lblOrdre.AutoSize = True
        Me.lblOrdre.Location = New System.Drawing.Point(187, 9)
        Me.lblOrdre.Name = "lblOrdre"
        Me.lblOrdre.Size = New System.Drawing.Size(140, 13)
        Me.lblOrdre.TabIndex = 2
        Me.lblOrdre.Text = "Le mot à remettre en ordre : "
        '
        'lblProposition1
        '
        Me.lblProposition1.AutoSize = True
        Me.lblProposition1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProposition1.Location = New System.Drawing.Point(74, 52)
        Me.lblProposition1.Name = "lblProposition1"
        Me.lblProposition1.Size = New System.Drawing.Size(92, 13)
        Me.lblProposition1.TabIndex = 3
        Me.lblProposition1.Text = "PROPOSITION"
        '
        'lstproposition
        '
        Me.lstproposition.FormattingEnabled = True
        Me.lstproposition.Location = New System.Drawing.Point(3, 16)
        Me.lstproposition.Name = "lstproposition"
        Me.lstproposition.Size = New System.Drawing.Size(194, 186)
        Me.lstproposition.TabIndex = 4
        '
        'lsthistorique
        '
        Me.lsthistorique.AccessibleDescription = ""
        Me.lsthistorique.AccessibleName = ""
        Me.lsthistorique.FormattingEnabled = True
        Me.lsthistorique.Location = New System.Drawing.Point(265, 81)
        Me.lsthistorique.Name = "lsthistorique"
        Me.lsthistorique.Size = New System.Drawing.Size(200, 186)
        Me.lsthistorique.TabIndex = 5
        '
        'txtProposition
        '
        Me.txtProposition.Location = New System.Drawing.Point(3, 3)
        Me.txtProposition.Name = "txtProposition"
        Me.txtProposition.Size = New System.Drawing.Size(115, 20)
        Me.txtProposition.TabIndex = 6
        '
        'lblProposition2
        '
        Me.lblProposition2.AutoSize = True
        Me.lblProposition2.Location = New System.Drawing.Point(3, 0)
        Me.lblProposition2.Name = "lblProposition2"
        Me.lblProposition2.Size = New System.Drawing.Size(59, 13)
        Me.lblProposition2.TabIndex = 7
        Me.lblProposition2.Text = "Proposition"
        '
        'lblEssais
        '
        Me.lblEssais.AutoSize = True
        Me.lblEssais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEssais.Location = New System.Drawing.Point(95, 132)
        Me.lblEssais.Name = "lblEssais"
        Me.lblEssais.Size = New System.Drawing.Size(51, 13)
        Me.lblEssais.TabIndex = 8
        Me.lblEssais.Text = "ESSAIS"
        '
        'lblRestant
        '
        Me.lblRestant.AutoSize = True
        Me.lblRestant.Location = New System.Drawing.Point(3, 0)
        Me.lblRestant.Name = "lblRestant"
        Me.lblRestant.Size = New System.Drawing.Size(50, 13)
        Me.lblRestant.TabIndex = 9
        Me.lblRestant.Text = "Restant :"
        '
        'lblMotDesordre
        '
        Me.lblMotDesordre.AutoSize = True
        Me.lblMotDesordre.Enabled = False
        Me.lblMotDesordre.Location = New System.Drawing.Point(229, 31)
        Me.lblMotDesordre.Name = "lblMotDesordre"
        Me.lblMotDesordre.Size = New System.Drawing.Size(21, 13)
        Me.lblMotDesordre.TabIndex = 10
        Me.lblMotDesordre.Text = "XX"
        '
        'lblNbRestant
        '
        Me.lblNbRestant.AutoSize = True
        Me.lblNbRestant.Location = New System.Drawing.Point(59, 0)
        Me.lblNbRestant.Name = "lblNbRestant"
        Me.lblNbRestant.Size = New System.Drawing.Size(13, 13)
        Me.lblNbRestant.TabIndex = 11
        Me.lblNbRestant.Text = "5"
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(265, 286)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 12
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnRejouer
        '
        Me.btnRejouer.Location = New System.Drawing.Point(154, 286)
        Me.btnRejouer.Name = "btnRejouer"
        Me.btnRejouer.Size = New System.Drawing.Size(75, 23)
        Me.btnRejouer.TabIndex = 13
        Me.btnRejouer.Text = "Rejouer"
        Me.btnRejouer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "HISTORIQUE"
        '
        'FlowLayoutPanelProp
        '
        Me.FlowLayoutPanelProp.Controls.Add(Me.txtProposition)
        Me.FlowLayoutPanelProp.Controls.Add(Me.btnTester)
        Me.FlowLayoutPanelProp.Location = New System.Drawing.Point(12, 81)
        Me.FlowLayoutPanelProp.Name = "FlowLayoutPanelProp"
        Me.FlowLayoutPanelProp.Size = New System.Drawing.Size(217, 26)
        Me.FlowLayoutPanelProp.TabIndex = 15
        '
        'FlowLayoutPanelEssais
        '
        Me.FlowLayoutPanelEssais.Controls.Add(Me.lblRestant)
        Me.FlowLayoutPanelEssais.Controls.Add(Me.lblNbRestant)
        Me.FlowLayoutPanelEssais.Controls.Add(Me.FlowLayoutPanelProp2)
        Me.FlowLayoutPanelEssais.Location = New System.Drawing.Point(15, 148)
        Me.FlowLayoutPanelEssais.Name = "FlowLayoutPanelEssais"
        Me.FlowLayoutPanelEssais.Size = New System.Drawing.Size(214, 122)
        Me.FlowLayoutPanelEssais.TabIndex = 16
        '
        'FlowLayoutPanelProp2
        '
        Me.FlowLayoutPanelProp2.Controls.Add(Me.lblProposition2)
        Me.FlowLayoutPanelProp2.Controls.Add(Me.lstproposition)
        Me.FlowLayoutPanelProp2.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanelProp2.Name = "FlowLayoutPanelProp2"
        Me.FlowLayoutPanelProp2.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanelProp2.TabIndex = 17
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(211, 26)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 17
        Me.btnStart.Text = "Commencer"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(496, 326)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblEssais)
        Me.Controls.Add(Me.lsthistorique)
        Me.Controls.Add(Me.FlowLayoutPanelEssais)
        Me.Controls.Add(Me.lblProposition1)
        Me.Controls.Add(Me.FlowLayoutPanelProp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRejouer)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lblMotDesordre)
        Me.Controls.Add(Me.lblOrdre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Jeu de mots"
        Me.FlowLayoutPanelProp.ResumeLayout(False)
        Me.FlowLayoutPanelProp.PerformLayout()
        Me.FlowLayoutPanelEssais.ResumeLayout(False)
        Me.FlowLayoutPanelEssais.PerformLayout()
        Me.FlowLayoutPanelProp2.ResumeLayout(False)
        Me.FlowLayoutPanelProp2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTester As Button
    Friend WithEvents lblOrdre As Label
    Friend WithEvents lblProposition1 As Label
    Friend WithEvents lstproposition As ListBox
    Friend WithEvents lsthistorique As ListBox
    Friend WithEvents txtProposition As TextBox
    Friend WithEvents lblProposition2 As Label
    Friend WithEvents lblEssais As Label
    Friend WithEvents lblRestant As Label
    Friend WithEvents lblMotDesordre As Label
    Friend WithEvents lblNbRestant As Label
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnRejouer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanelProp As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelEssais As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelProp2 As FlowLayoutPanel
    Friend WithEvents btnStart As Button
End Class
