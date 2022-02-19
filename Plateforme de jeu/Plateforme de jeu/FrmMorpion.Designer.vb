<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bt1 = New System.Windows.Forms.Button()
        Me.tlpbouton = New System.Windows.Forms.TableLayoutPanel()
        Me.bt9 = New System.Windows.Forms.Button()
        Me.bt8 = New System.Windows.Forms.Button()
        Me.bt7 = New System.Windows.Forms.Button()
        Me.bt5 = New System.Windows.Forms.Button()
        Me.bt4 = New System.Windows.Forms.Button()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.bt6 = New System.Windows.Forms.Button()
        Me.tlpbouton.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt1
        '
        Me.bt1.Location = New System.Drawing.Point(3, 3)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(42, 42)
        Me.bt1.TabIndex = 0
        Me.bt1.UseVisualStyleBackColor = True
        '
        'tlpbouton
        '
        Me.tlpbouton.ColumnCount = 3
        Me.tlpbouton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpbouton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpbouton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpbouton.Controls.Add(Me.bt9, 2, 2)
        Me.tlpbouton.Controls.Add(Me.bt8, 1, 2)
        Me.tlpbouton.Controls.Add(Me.bt7, 0, 2)
        Me.tlpbouton.Controls.Add(Me.bt6, 2, 1)
        Me.tlpbouton.Controls.Add(Me.bt5, 1, 1)
        Me.tlpbouton.Controls.Add(Me.bt4, 0, 1)
        Me.tlpbouton.Controls.Add(Me.bt3, 2, 0)
        Me.tlpbouton.Controls.Add(Me.bt2, 1, 0)
        Me.tlpbouton.Controls.Add(Me.bt1, 0, 0)
        Me.tlpbouton.Location = New System.Drawing.Point(62, 49)
        Me.tlpbouton.Name = "tlpbouton"
        Me.tlpbouton.RowCount = 3
        Me.tlpbouton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpbouton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpbouton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpbouton.Size = New System.Drawing.Size(146, 145)
        Me.tlpbouton.TabIndex = 1
        Me.tlpbouton.Visible = False
        '
        'bt9
        '
        Me.bt9.Location = New System.Drawing.Point(99, 99)
        Me.bt9.Name = "bt9"
        Me.bt9.Size = New System.Drawing.Size(42, 42)
        Me.bt9.TabIndex = 8
        Me.bt9.UseVisualStyleBackColor = True
        '
        'bt8
        '
        Me.bt8.Location = New System.Drawing.Point(51, 99)
        Me.bt8.Name = "bt8"
        Me.bt8.Size = New System.Drawing.Size(42, 42)
        Me.bt8.TabIndex = 7
        Me.bt8.UseVisualStyleBackColor = True
        '
        'bt7
        '
        Me.bt7.Location = New System.Drawing.Point(3, 99)
        Me.bt7.Name = "bt7"
        Me.bt7.Size = New System.Drawing.Size(42, 42)
        Me.bt7.TabIndex = 6
        Me.bt7.UseVisualStyleBackColor = True
        '
        'bt5
        '
        Me.bt5.Location = New System.Drawing.Point(51, 51)
        Me.bt5.Name = "bt5"
        Me.bt5.Size = New System.Drawing.Size(42, 42)
        Me.bt5.TabIndex = 4
        Me.bt5.UseVisualStyleBackColor = True
        '
        'bt4
        '
        Me.bt4.Location = New System.Drawing.Point(3, 51)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(42, 42)
        Me.bt4.TabIndex = 3
        Me.bt4.UseVisualStyleBackColor = True
        '
        'bt3
        '
        Me.bt3.Location = New System.Drawing.Point(99, 3)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(42, 42)
        Me.bt3.TabIndex = 2
        Me.bt3.UseVisualStyleBackColor = True
        '
        'bt2
        '
        Me.bt2.Location = New System.Drawing.Point(51, 3)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(42, 42)
        Me.bt2.TabIndex = 1
        Me.bt2.UseVisualStyleBackColor = True
        '
        'bt6
        '
        Me.bt6.Location = New System.Drawing.Point(99, 51)
        Me.bt6.Name = "bt6"
        Me.bt6.Size = New System.Drawing.Size(42, 42)
        Me.bt6.TabIndex = 5
        Me.bt6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.tlpbouton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tlpbouton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bt1 As Button
    Friend WithEvents tlpbouton As TableLayoutPanel
    Friend WithEvents bt9 As Button
    Friend WithEvents bt8 As Button
    Friend WithEvents bt7 As Button
    Friend WithEvents bt6 As Button
    Friend WithEvents bt5 As Button
    Friend WithEvents bt4 As Button
    Friend WithEvents bt3 As Button
    Friend WithEvents bt2 As Button
End Class
