Public Class Form3

    Dim down = False
    Dim mybrush = Brushes.Black
    Dim a As Integer = 12
    Dim b As Integer = 12
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        down = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If down = True Then
            PictureBox1.CreateGraphics.FillEllipse(mybrush, e.X, e.Y, a, b)
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        down = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mybrush = Brushes.Black
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        mybrush = Brushes.Blue
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mybrush = Brushes.Red
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mybrush = Brushes.Green
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mybrush = Brushes.Yellow
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mybrush = Brushes.Gray
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        mybrush = Brushes.HotPink
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        mybrush = Brushes.Orange
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mybrush = Brushes.BlueViolet


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mybrush = Brushes.White

    End Sub



    Private Sub Button14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        PictureBox1.BackColor = Color.AntiqueWhite
        PictureBox1.BackColor = Color.White


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        PictureBox1.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        PictureBox1.BackColor = Color.Red
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        a = 4
        b = 7
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        a = 7
        b = 7
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        a = 10
        b = 10
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        a = 13
        b = 13
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        a = 16
        b = 16
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        a = 19
        b = 19
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        a = 22
        b = 22
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        a = 25
        b = 25
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        a = 28
        b = 28
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PictureBox1.BackColor = Color.Green
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        PictureBox1.BackColor = Color.Black
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        PictureBox1.BackColor = Color.OrangeRed
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        PictureBox1.BackColor = Color.Gold
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        End
    End Sub
End Class
