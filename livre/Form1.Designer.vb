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
        Me.txt_isbn = New System.Windows.Forms.TextBox()
        Me.txt_titre = New System.Windows.Forms.TextBox()
        Me.txt_auteur = New System.Windows.Forms.TextBox()
        Me.ISBN = New System.Windows.Forms.Label()
        Me.titre = New System.Windows.Forms.Label()
        Me.auteur = New System.Windows.Forms.Label()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_afficher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_isbn
        '
        Me.txt_isbn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_isbn.Location = New System.Drawing.Point(204, 62)
        Me.txt_isbn.Name = "txt_isbn"
        Me.txt_isbn.Size = New System.Drawing.Size(182, 22)
        Me.txt_isbn.TabIndex = 0
        '
        'txt_titre
        '
        Me.txt_titre.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_titre.Location = New System.Drawing.Point(204, 121)
        Me.txt_titre.Name = "txt_titre"
        Me.txt_titre.Size = New System.Drawing.Size(182, 22)
        Me.txt_titre.TabIndex = 1
        '
        'txt_auteur
        '
        Me.txt_auteur.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_auteur.Location = New System.Drawing.Point(204, 189)
        Me.txt_auteur.Name = "txt_auteur"
        Me.txt_auteur.Size = New System.Drawing.Size(182, 22)
        Me.txt_auteur.TabIndex = 2
        '
        'ISBN
        '
        Me.ISBN.AutoSize = True
        Me.ISBN.Location = New System.Drawing.Point(67, 62)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(38, 16)
        Me.ISBN.TabIndex = 3
        Me.ISBN.Text = "ISBN"
        '
        'titre
        '
        Me.titre.AutoSize = True
        Me.titre.Location = New System.Drawing.Point(77, 127)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(28, 16)
        Me.titre.TabIndex = 4
        Me.titre.Text = "titre"
        '
        'auteur
        '
        Me.auteur.AutoSize = True
        Me.auteur.Location = New System.Drawing.Point(67, 195)
        Me.auteur.Name = "auteur"
        Me.auteur.Size = New System.Drawing.Size(44, 16)
        Me.auteur.TabIndex = 5
        Me.auteur.Text = "auteur"
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.LightGray
        Me.btn_ajouter.Location = New System.Drawing.Point(153, 299)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(103, 42)
        Me.btn_ajouter.TabIndex = 6
        Me.btn_ajouter.Text = "ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'btn_afficher
        '
        Me.btn_afficher.BackColor = System.Drawing.Color.LightGray
        Me.btn_afficher.Location = New System.Drawing.Point(414, 299)
        Me.btn_afficher.Name = "btn_afficher"
        Me.btn_afficher.Size = New System.Drawing.Size(103, 42)
        Me.btn_afficher.TabIndex = 7
        Me.btn_afficher.Text = "afficher"
        Me.btn_afficher.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(938, 411)
        Me.Controls.Add(Me.btn_afficher)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.auteur)
        Me.Controls.Add(Me.titre)
        Me.Controls.Add(Me.ISBN)
        Me.Controls.Add(Me.txt_auteur)
        Me.Controls.Add(Me.txt_titre)
        Me.Controls.Add(Me.txt_isbn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents ISBN As Label
    Friend WithEvents titre As Label
    Friend WithEvents auteur As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button
End Class
