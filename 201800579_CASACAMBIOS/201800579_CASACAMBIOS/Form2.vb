Public Class Form2

    'con este boton regresaremos a nuestro menu principal
    Private Sub BTregresar_Click(sender As Object, e As EventArgs) Handles BTregresar.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class