Public Class ChoixCalculatrice

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonCommercial.Click
        CCommercial.Show()
        Me.Hide()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cscientifique.Show()
        Me.Hide()
    End Sub
End Class