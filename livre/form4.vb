Public Class form4
    Private Sub dgv_livre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_livre.CellContentClick

    End Sub

    Private Sub form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgv_livre.Columns.Clear()
        dgv_livre.Columns.Add("ISBN", "ISBN")
        dgv_livre.Columns.Add("Titre", "Titre")
        dgv_livre.Columns.Add("Auteur", "Auteur")

        ' Ajouter les données dans le DataGridView
        For i As Integer = 0 To listeISBN.Count - 1
            dgv_livre.Rows.Add(listeISBN(i), listeTitre(i), listeAuteur(i))
        Next
    End Sub
End Class