Imports System.Math
Public Class Cscientifique
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

    Private Sub exposant_Click(sender As Object, e As EventArgs) Handles exposant.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")

        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        Else
            TextBox1.Text = CDbl(TextBox1.Text * TextBox1.Text)
        End If



    End Sub

    Private Sub SquareRoot_Click(sender As Object, e As EventArgs) Handles SquareRoot.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")
        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        Else

            TextBox1.Text = CDbl(Sqrt(CDbl(TextBox1.Text)))
        End If
    End Sub

    Private Sub Pi_Click(sender As Object, e As EventArgs) Handles Pi.Click
        TextBox1.Text = System.Math.PI

    End Sub

    Private Sub CosButton_Click(sender As Object, e As EventArgs) Handles CosButton.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")

        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        ElseIf (TextBox1.Text = 90
        ) Then
            TextBox1.Text = 0

        ElseIf (TextBox1.Text = 60
            ) Then
            TextBox1.Text = Sqrt(1) / 2

        ElseIf (TextBox1.Text = 45
            ) Then
            TextBox1.Text = Sqrt(2) / 2

        ElseIf (TextBox1.Text = 30
            ) Then
            TextBox1.Text = Sqrt(3) / 2

        ElseIf (TextBox1.Text = 0
            ) Then
            TextBox1.Text = 1
        Else
            MessageBox.Show("Valeurs prise en charge : 0, 30, 45, 60, 90")
            TextBox1.Clear()

        End If
    End Sub

    Private Sub Sinus_Click(sender As Object, e As EventArgs) Handles Sinus.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")

        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        ElseIf (TextBox1.Text = 0
        ) Then
            TextBox1.Text = 0

        ElseIf (TextBox1.Text = 30
            ) Then
            TextBox1.Text = Sqrt(1) / 2

        ElseIf (TextBox1.Text = 45
            ) Then
            TextBox1.Text = Sqrt(2) / 2

        ElseIf (TextBox1.Text = 60
            ) Then
            TextBox1.Text = Sqrt(3) / 2

        ElseIf (TextBox1.Text = 90
            ) Then
            TextBox1.Text = 1

        Else
            MessageBox.Show("Valeurs prise en charge : 0, 30, 45, 60, 90")
            TextBox1.Clear()

        End If
    End Sub

    Private Sub Tangeante_Click(sender As Object, e As EventArgs) Handles Tangeante.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("aucune valeur entree")

        ElseIf (TextBox1.Text = ".") Then
            MessageBox.Show("aucune valeur entree")
            TextBox1.Clear()

        ElseIf (TextBox1.Text = 90
        ) Then
            MessageBox.Show("Valeur Non Defini")

        ElseIf (TextBox1.Text = 60
            ) Then
            TextBox1.Text = Sqrt(3)

        ElseIf (TextBox1.Text = 45
            ) Then
            TextBox1.Text = 1

        ElseIf (TextBox1.Text = 30
            ) Then
            TextBox1.Text = 1 / Sqrt(3)

        ElseIf (TextBox1.Text = 0
            ) Then
            TextBox1.Text = 0
        Else
            MessageBox.Show("Valeurs prise en charge : 0, 30, 45, 60, 90")
            TextBox1.Clear()

        End If
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