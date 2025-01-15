Public Class Form1
    Private Sub ISBN_Click(sender As Object, e As EventArgs) Handles ISBN.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click


        Dim isbn As String = txt_isbn.Text
        Dim titre As String = txt_titre.Text
        Dim auteur As String = txt_auteur.Text

        AjouterLivre(isbn, titre, auteur)

        MessageBox.Show("Livre ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txt_isbn.Clear()
        txt_titre.Clear()
        txt_auteur.Clear()
    End Sub


    Private Sub auteur_Click(sender As Object, e As EventArgs) Handles auteur.Click

    End Sub

    Private Sub txt_titre_TextChanged(sender As Object, e As EventArgs) Handles txt_titre.TextChanged

    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        Dim listeForm As New liste_livre
        listeForm.Show()
    End Sub

    Private Sub txt_auteur_TextChanged(sender As Object, e As EventArgs) Handles txt_auteur.TextChanged


    End Sub
End Class