Module gestion_livre
    Public listeISBN As New List(Of String)
    Public listeTitre As New List(Of String)
    Public listeAuteur As New List(Of String)

    Public Sub AjouterLivre(isbn As String, titre As String, auteur As String)
        listeISBN.Add(isbn)
        listeTitre.Add(titre)
        listeAuteur.Add(auteur)
    End Sub
End Module

