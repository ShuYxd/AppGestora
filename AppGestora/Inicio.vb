Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el nombre de usuario en un Label (asegúrate de tener un Label en tu formulario)
        lblBienvenido.Text = Session.Usernameglobal
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblBienvenido.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Alumnos.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        calificaciones.Show()
        Me.Hide()
    End Sub
End Class
