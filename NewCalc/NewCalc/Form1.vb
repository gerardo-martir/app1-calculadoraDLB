Public Class Form1
    Dim Activo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sumar.Click
        Dim Numero1 As Double = Double.Parse(TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)
        Dim Resultado As Double = Numero1 + Numero2
        Label5.Text = Resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Restar.Click
        Dim Numero1 As Double = Double.Parse(TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)
        Dim Resultado As Double = Numero1 - Numero2
        Label5.Text = Resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        Dim Numero1 As Double = Double.Parse(TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)
        Dim Resultado As Double = Numero1 * Numero2
        Label5.Text = Resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        Dim Numero1 As Double = Double.Parse(TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)
        Dim Resultado As Double = Numero1 / Numero2
        Label5.Text = Resultado.ToString()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles boton0.Click
        Activo.Text = Activo.Text & "0"
    End Sub

    Private Sub boton9_Click(sender As Object, e As EventArgs) Handles boton9.Click
        Activo.Text = Activo.Text & "9"
    End Sub

    Private Sub boton8_Click(sender As Object, e As EventArgs) Handles boton8.Click
        Activo.Text = Activo.Text & "8"
    End Sub

    Private Sub boton7_Click(sender As Object, e As EventArgs) Handles boton7.Click
        Activo.Text = Activo.Text & "7"
    End Sub

    Private Sub boton6_Click(sender As Object, e As EventArgs) Handles boton6.Click
        Activo.Text = Activo.Text & "6"
    End Sub

    Private Sub Boton5_Click(sender As Object, e As EventArgs) Handles Boton5.Click
        Activo.Text = Activo.Text & "5"
    End Sub

    Private Sub boton4_Click(sender As Object, e As EventArgs) Handles boton4.Click
        Activo.Text = Activo.Text & "4"
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        Activo.Text = Activo.Text & "3"
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        Activo.Text = Activo.Text & "2"
    End Sub

    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles boton1.Click
        Activo.Text = Activo.Text & "1"
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Activo.Text = "0"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Activo.Text = Activo.Text & "."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Activo = TextBox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Activo = TextBox2
    End Sub
End Class
