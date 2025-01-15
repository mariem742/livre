<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form4
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
        Me.dgv_livre = New System.Windows.Forms.DataGridView()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.auteur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_livre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_livre
        '
        Me.dgv_livre.BackgroundColor = System.Drawing.Color.Thistle
        Me.dgv_livre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_livre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBN, Me.titre, Me.auteur})
        Me.dgv_livre.Location = New System.Drawing.Point(-1, -1)
        Me.dgv_livre.Name = "dgv_livre"
        Me.dgv_livre.RowHeadersWidth = 51
        Me.dgv_livre.RowTemplate.Height = 24
        Me.dgv_livre.Size = New System.Drawing.Size(802, 439)
        Me.dgv_livre.TabIndex = 0
        '
        'ISBN
        '
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.MinimumWidth = 6
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Width = 125
        '
        'titre
        '
        Me.titre.HeaderText = "titre"
        Me.titre.MinimumWidth = 6
        Me.titre.Name = "titre"
        Me.titre.Width = 125
        '
        'auteur
        '
        Me.auteur.HeaderText = "auteur"
        Me.auteur.MinimumWidth = 6
        Me.auteur.Name = "auteur"
        Me.auteur.Width = 125
        '
        'form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgv_livre)
        Me.Name = "form4"
        Me.Text = "form4"
        CType(Me.dgv_livre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_livre As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents titre As DataGridViewTextBoxColumn
    Friend WithEvents auteur As DataGridViewTextBoxColumn
End Class
