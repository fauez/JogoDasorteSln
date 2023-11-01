Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub BtbPlayer_Click(sender As Object, e As EventArgs) Handles BtbPlayer.Click
        Dim local As String
        'Aqui abaixo variavel local onde vai direcionar onde esta a imagem
        local = "C:\JogoDasorteSln\"
        ImageResult.Visible = False
        Randomize()
        Num1.Text = CStr(Int(Rnd() * 8))
        Num2.Text = CStr(Int(Rnd() * 8))
        Num3.Text = CStr(Int(Rnd() * 8))



        If (Num1.Text = "7") And (Num2.Text = "7") And (Num3.Text = "7") Then
            ImageResult.Image = Image.FromFile(local + "imagem7result.jpg")
            ImageResult.Visible = True
            Beep()
        ElseIf (Num1.Text = "7") Or (Num2.Text = "7") Or (Num3.Text = "7") Then
            ImageResult.Image = Image.FromFile(local + "jogar.jpg")
            ImageResult.Visible = True
            Beep()
        Else
            ImageResult.Image = Image.FromFile(local + "gameover.png")
            ImageResult.Visible = True

        End If


    End Sub
End Class
