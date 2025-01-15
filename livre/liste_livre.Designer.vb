<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liste_livre
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
        Me.btn_afficher = New System.Windows.Forms.Button()
        Me.lst_isbn = New System.Windows.Forms.ListBox()
        Me.lst_titre = New System.Windows.Forms.ListBox()
        Me.lst_auteur = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_afficher
        '
        Me.btn_afficher.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_afficher.Location = New System.Drawing.Point(336, 359)
        Me.btn_afficher.Name = "btn_afficher"
        Me.btn_afficher.Size = New System.Drawing.Size(116, 47)
        Me.btn_afficher.TabIndex = 3
        Me.btn_afficher.Text = "afficher"
        Me.btn_afficher.UseVisualStyleBackColor = False
        '
        'lst_isbn
        '
        Me.lst_isbn.FormattingEnabled = True
        Me.lst_isbn.ItemHeight = 16
        Me.lst_isbn.Location = New System.Drawing.Point(49, 93)
        Me.lst_isbn.Name = "lst_isbn"
        Me.lst_isbn.Size = New System.Drawing.Size(149, 164)
        Me.lst_isbn.TabIndex = 4
        '
        'lst_titre
        '
        Me.lst_titre.FormattingEnabled = True
        Me.lst_titre.ItemHeight = 16
        Me.lst_titre.Location = New System.Drawing.Point(320, 93)
        Me.lst_titre.Name = "lst_titre"
        Me.lst_titre.Size = New System.Drawing.Size(149, 164)
        Me.lst_titre.TabIndex = 5
        '
        'lst_auteur
        '
        Me.lst_auteur.FormattingEnabled = True
        Me.lst_auteur.ItemHeight = 16
        Me.lst_auteur.Location = New System.Drawing.Point(603, 93)
        Me.lst_auteur.Name = "lst_auteur"
        Me.lst_auteur.Size = New System.Drawing.Size(149, 164)
        Me.lst_auteur.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(103, 54)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 16)
        Me.label1.TabIndex = 7
        Me.label1.Text = "ISBN"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(373, 54)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(28, 16)
        Me.label2.TabIndex = 8
        Me.label2.Text = "titre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(656, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "auteur"
        '
        'liste_livre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lst_auteur)
        Me.Controls.Add(Me.lst_titre)
        Me.Controls.Add(Me.lst_isbn)
        Me.Controls.Add(Me.btn_afficher)
        Me.Name = "liste_livre"
        Me.Text = "liste_livre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_afficher As Button
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
End Class
