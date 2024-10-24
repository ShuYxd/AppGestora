Imports System.Windows.Forms ' Asegúrate de que esta importación sea correcta

Public Class Terminos

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MessageBox.Show("Debes aceptar los términos y condiciones para continuar.")
        End
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Verifica si el CheckBox está marcado
        If chkNoMostrar.Checked Then
            ' Si está marcado, establece My.Settings.NoMostrarTerminos en True
            My.Settings.NoMostrarTerminos = True
            My.Settings.Save() ' Guarda los cambios en la configuración
        End If

        ' Abre el formulario de Login
        Dim loginForm As New Login() ' Asegúrate de que el nombre del formulario de login es correcto
        loginForm.Show()

        ' Cierra el formulario de Términos
        Me.Hide() ' o Me.Close() dependiendo de tu lógica
    End Sub

    Private Sub Terminos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
