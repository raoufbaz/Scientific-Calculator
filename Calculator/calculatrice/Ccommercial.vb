﻿Public Class CCommercial
    Dim var1, var2, resultat As Double
    Dim sign As Char


    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub ButtonDot_Click(sender As Object, e As EventArgs) Handles ButtonDot.Click
        TextBox1.Text = TextBox1.Text + "."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")
        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        Else

            var1 = CDbl(TextBox1.Text)

        sign = "-"
        TextBox1.Clear()
        End If
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")
        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        Else

            var1 = CDbl(TextBox1.Text)

        sign = "*"
        TextBox1.Clear()
        End If
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")
        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        Else

            var1 = CDbl(TextBox1.Text)

        sign = "/"
        TextBox1.Clear()
        End If
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        If (sign = "+") Then

            resultat = var1 + CDbl(TextBox1.Text)

        ElseIf (sign = "-") Then
            resultat = var1 - CDbl(TextBox1.Text)

        ElseIf (sign = "*") Then
            resultat = var1 * CDbl(TextBox1.Text)

        ElseIf (sign = "/") Then
            resultat = var1 / CDbl(TextBox1.Text)
        ElseIf (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")
        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        End If
        TextBox1.Text = resultat
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ChoixCalculatrice.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        TextBox1.Text = ""

    End Sub

    Public Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")
        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        Else


            var1 = CDbl(TextBox1.Text)

        sign = "+"
        TextBox1.Clear()

        End If
    End Sub
End Class
