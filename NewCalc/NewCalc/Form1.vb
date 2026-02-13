Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sumar.Click
        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)
        Dim Resultado As Integer = Numero1 + Numero2
        Label5.Text = Resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Restar.Click
        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)
        Dim Resultado As Integer = Numero1 - Numero2
        Label5.Text = Resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)
        Dim Resultado As Integer = Numero1 * Numero2
        Label5.Text = Resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)
        Dim Resultado As Integer = Numero1 / Numero2
        Label5.Text = Resultado.ToString()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles boton0.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub boton9_Click(sender As Object, e As EventArgs) Handles boton9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub boton8_Click(sender As Object, e As EventArgs) Handles boton8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub boton7_Click(sender As Object, e As EventArgs) Handles boton7.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub boton6_Click(sender As Object, e As EventArgs) Handles boton6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Boton5_Click(sender As Object, e As EventArgs) Handles Boton5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub boton4_Click(sender As Object, e As EventArgs) Handles boton4.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles boton1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
