Public Class comenzar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verifica el valor de My.Settings.NoMostrarTerminos
        If My.Settings.NoMostrarTerminos Then
            ' Si es True, abre el formulario de Login
            Dim Login As New Login() ' Asegúrate de que el nombre del formulario de login es correcto
            Login.Show()
            Me.Hide()
        Else
            ' Si es False, abre el formulario de Términos
            Dim Terminos As New Terminos() ' Asegúrate de que el nombre del formulario de términos es correcto
            Terminos.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub comenzar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class