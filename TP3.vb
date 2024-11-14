Public Class TP3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim taille = lst_taille.SelectedItem.ToString()
        Dim ingrd As String = ""
        If rd_1.Checked Then
            ingrd = "Croute fine"
        ElseIf rd_2.Checked Then
            ingrd = "Croute classique"
        ElseIf rd_3.Checked Then
            ingrd = "Croute epaise"
        End If
        Dim ingrsupp As String = ""
        If chk_1.Checked Then
            ingrsupp = ingrsupp + "champignion"
        ElseIf chk_2.Checked Then
            ingrsupp = ingrsupp + "olive"
        ElseIf chk_3.Checked Then
            ingrsupp = ingrsupp + "poivrins"
        ElseIf chk_4.Checked Then
            ingrsupp = ingrsupp + "formage supplémentaires"
        End If
        Dim msg As String = "Taille:  " + taille + "  Type de croute:  " + ingrd + "  ingrediant supplémentaire:  " + ingrsupp
        MessageBox.Show(msg)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TP3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
