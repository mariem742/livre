Public Class liste_livre
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click

    End Sub

    Private Sub lst_titre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_titre.SelectedIndexChanged

    End Sub

    Private Sub lst_isbn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_isbn.SelectedIndexChanged

    End Sub

    Private Sub liste_livre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_isbn.Items.Clear()
        lst_titre.Items.Clear()
        lst_auteur.Items.Clear()

        ' Charger les données des listes dans les ListBox
        For i As Integer = 0 To listeISBN.Count - 1
            lst_isbn.Items.Add(listeISBN(i))
            lst_titre.Items.Add(listeTitre(i))
            lst_auteur.Items.Add(listeAuteur(i))
        Next
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class