Public Class Form1

    ' On déclare le chemin du répertoire de sauvegarde du jeu
    Private repertoire262060 As String = My.Computer.FileSystem.ReadAllText("DD Saves location.txt")

    ' On déclare un URL à partir duquel on peut lancer le jeu
    Private DDurl As String = My.Computer.FileSystem.ReadAllText("DD url.txt")

    ' On déclare les chemins des répertoires dans lesquels seront hébergés les copies
    Private Const cheminDD1 As String = "save 1\"
    Private Const cheminDD2 As String = "save 2\"
    Private Const cheminDD3 As String = "save 3\"
    Private Const cheminDD4 As String = "save 4\"

    Private Const chemin_texte_DD1 As String = "DD Saver comment1.txt"
    Private Const chemin_texte_DD2 As String = "DD Saver comment2.txt"
    Private Const chemin_texte_DD3 As String = "DD Saver comment3.txt"
    Private Const chemin_texte_DD4 As String = "DD Saver comment4.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Si le commentaire de la Sauvegarde 1 est vide, alors on met le message par défaut, sinon, on le laisse tel quel
        Dim file_content1 As String = My.Computer.FileSystem.ReadAllText(chemin_texte_DD1)
        If file_content1 = Nothing Then
            Me.Commentaire1.Text = "Commentaire sur la Sauvegarde 1..."
        Else
            Me.Commentaire1.Text = file_content1
        End If

        ' Si le commentaire de la Sauvegarde 2 est vide, alors on met le message par défaut, sinon, on le laisse tel quel
        Dim file_content2 As String = My.Computer.FileSystem.ReadAllText(chemin_texte_DD2)
        If file_content2 = Nothing Then
            Me.Commentaire2.Text = "Commentaire sur la Sauvegarde 2..."
        Else
            Me.Commentaire2.Text = file_content2
        End If

        ' Si le commentaire de la Sauvegarde 3 est vide, alors on met le message par défaut, sinon, on le laisse tel quel
        Dim file_content3 As String = My.Computer.FileSystem.ReadAllText(chemin_texte_DD3)
        If file_content3 = Nothing Then
            Me.Commentaire3.Text = "Commentaire sur la Sauvegarde 3..."
        Else
            Me.Commentaire3.Text = file_content3
        End If

        ' Si le commentaire de la Sauvegarde 4 est vide, alors on met le message par défaut, sinon, on le laisse tel quel
        Dim file_content4 As String = My.Computer.FileSystem.ReadAllText(chemin_texte_DD4)
        If file_content4 = Nothing Then
            Me.Commentaire4.Text = "Commentaire sur la Sauvegarde 4..."
        Else
            Me.Commentaire4.Text = file_content4
        End If
    End Sub

    ' On copie le contenu du répertoire de sauvegarde du jeu vers l'emplacement de copie n°1 (en écrasant les fichiers si nécessaire)
    Private Sub Copier1_Button_Click(sender As Object, e As EventArgs) Handles Copier1_Button.Click
        My.Computer.FileSystem.CopyDirectory(repertoire262060, cheminDD1, True)
    End Sub

    ' On copie le contenu du répertoire de sauvegarde du jeu vers l'emplacement de copie n°2 (en écrasant les fichiers si nécessaire)
    Private Sub Copier2_Button_Click(sender As Object, e As EventArgs) Handles Copier2_Button.Click
        My.Computer.FileSystem.CopyDirectory(repertoire262060, cheminDD2, True)
    End Sub

    ' On copie le contenu du répertoire de sauvegarde du jeu vers l'emplacement de copie n°3 (en écrasant les fichiers si nécessaire)
    Private Sub Copier3_Button_Click(sender As Object, e As EventArgs) Handles Copier3_Button.Click
        My.Computer.FileSystem.CopyDirectory(repertoire262060, cheminDD3, True)
    End Sub

    ' On copie le contenu du répertoire de sauvegarde du jeu vers l'emplacement de copie n°4 (en écrasant les fichiers si nécessaire)
    Private Sub Copier4_Button_Click(sender As Object, e As EventArgs) Handles Copier4_Button.Click
        My.Computer.FileSystem.CopyDirectory(repertoire262060, cheminDD4, True)
    End Sub

    ' On remplace le contenu du répertoire de copie n°1 vers l'emplacement de sauvegarde du jeu (en écrasant les fichiers si nécessaire)
    Private Sub Remplacer1_Button_Click(sender As Object, e As EventArgs) Handles Remplacer1_Button.Click
        My.Computer.FileSystem.CopyDirectory(cheminDD1, repertoire262060, True)
    End Sub

    ' On remplace le contenu du répertoire de copie n°2 vers l'emplacement de sauvegarde du jeu (en écrasant les fichiers si nécessaire)
    Private Sub Remplacer2_Button_Click(sender As Object, e As EventArgs) Handles Remplacer2_Button.Click
        My.Computer.FileSystem.CopyDirectory(cheminDD2, repertoire262060, True)
    End Sub

    ' On remplace le contenu du répertoire de copie n°3 vers l'emplacement de sauvegarde du jeu (en écrasant les fichiers si nécessaire)
    Private Sub Remplacer3_Button_Click(sender As Object, e As EventArgs) Handles Remplacer3_Button.Click
        My.Computer.FileSystem.CopyDirectory(cheminDD3, repertoire262060, True)
    End Sub

    ' On remplace le contenu du répertoire de copie n°4 vers l'emplacement de sauvegarde du jeu (en écrasant les fichiers si nécessaire)
    Private Sub Remplacer4_Button_Click(sender As Object, e As EventArgs) Handles Remplacer4_Button.Click
        My.Computer.FileSystem.CopyDirectory(cheminDD4, repertoire262060, True)
    End Sub

    ' On lance le jeu à partir de l'URL Steam (car l'ordinateur ne nous accorde pas le droit de lancer l'application elle-même)
    Private Sub LancerDD_Button_Click(sender As Object, e As EventArgs) Handles LancerDD_Button.Click
        Process.Start(DDurl)
    End Sub

    'On arrête le programme ('End' fonctionne aussi mais est plus brutal)
    Private Sub Quitter_Button_Click(sender As Object, e As EventArgs) Handles Quitter_Button.Click
        Me.Close()
    End Sub

    ' Si Commentaire 1 est cliqué, on sélectionne tout le texte de celui-ci
    Private Sub Commentaire1_Click(sender As Object, e As EventArgs) Handles Commentaire1.Click
        ' Lorsque la boîte de commentaire est cliquée, on sélectionne tout le texte
        Commentaire1.SelectionStart = 0
        Commentaire1.SelectionLength = Commentaire1.Text.Length
    End Sub

    ' Si Commentaire 2 est cliqué, on sélectionne tout le texte de celui-ci
    Private Sub Commentaire2_Click(sender As Object, e As EventArgs) Handles Commentaire2.Click
        ' Lorsque la boîte de commentaire est cliquée, on sélectionne tout le texte
        Commentaire2.SelectionStart = 0
        Commentaire2.SelectionLength = Commentaire2.Text.Length
    End Sub

    ' Si Commentaire 3 est cliqué, on sélectionne tout le texte de celui-ci
    Private Sub Commentaire3_Click(sender As Object, e As EventArgs) Handles Commentaire3.Click
        ' Lorsque la boîte de commentaire est cliquée, on sélectionne tout le texte
        Commentaire3.SelectionStart = 0
        Commentaire3.SelectionLength = Commentaire3.Text.Length
    End Sub

    ' Si Commentaire 4 est cliqué, on sélectionne tout le texte de celui-ci
    Private Sub Commentaire4_Click(sender As Object, e As EventArgs) Handles Commentaire4.Click
        ' Lorsque la boîte de commentaire est cliquée, on sélectionne tout le texte
        Commentaire4.SelectionStart = 0
        Commentaire4.SelectionLength = Commentaire4.Text.Length
    End Sub

    ' Si le texte du Commentaire 1 change, on le copie dans le fichier DD Saver comment1.txt
    Private Sub Commentaire1_TextChanged(sender As Object, e As EventArgs) Handles Commentaire1.TextChanged
        My.Computer.FileSystem.WriteAllText(chemin_texte_DD1, Commentaire1.Text, False)
    End Sub

    ' Si le texte du Commentaire 2 change, on le copie dans le fichier DD Saver comment2.txt
    Private Sub Commentaire2_TextChanged(sender As Object, e As EventArgs) Handles Commentaire2.TextChanged
        My.Computer.FileSystem.WriteAllText(chemin_texte_DD2, Commentaire2.Text, False)
    End Sub

    ' Si le texte du Commentaire 3 change, on le copie dans le fichier DD Saver comment3.txt
    Private Sub Commentaire3_TextChanged(sender As Object, e As EventArgs) Handles Commentaire3.TextChanged
        My.Computer.FileSystem.WriteAllText(chemin_texte_DD3, Commentaire3.Text, False)
    End Sub

    ' Si le texte du Commentaire 4 change, on le copie dans le fichier DD Saver comment4.txt
    Private Sub Commentaire4_TextChanged(sender As Object, e As EventArgs) Handles Commentaire4.TextChanged
        My.Computer.FileSystem.WriteAllText(chemin_texte_DD4, Commentaire4.Text, False)
    End Sub
End Class