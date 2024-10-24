Imports MySql.Data.MySqlClient

Public Class Login
    ' Conexión a la base de datos MySQL
    Dim connectionString As String = "Server=localhost;Database=bdapp;Uid=root;Pwd=;"  ' Ajusta si es necesario

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtener datos de los TextBox
        Dim username As String = correo.Text
        Dim password As String = contraseña.Text

        Try
            ' Usar Using para manejar la conexión de forma segura
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Consulta SQL para validar usuario y obtener el nombre y rol
                Dim query As String = "SELECT Nombre, Rol FROM Usuarios WHERE Correo = @username AND Contraseña = @password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()  ' Leer los datos del usuario
                            Dim nombre As String = reader("Nombre").ToString()
                            Dim rol As String = reader("Rol").ToString()

                            ' Si los datos son correctos, guardar el nombre en la sesión
                            Session.Usernameglobal = nombre  ' Guardar el nombre del usuario en la sesión

                            ' Verificar si el usuario es alumno o administrador
                            If rol = "Alumno" Then
                                ' Abrir formulario del alumno

                                MessageBox.Show("Eres alumno")
                            ElseIf rol = "Administrador" Then
                                ' Abrir formulario del administrador
                                Me.Hide()
                                Dim adminForm As New Inicio() ' Cambia el nombre según tu formulario de administrador
                                adminForm.Show()
                            End If
                        Else
                            ' Si los datos son incorrectos, mostrar mensaje
                            MessageBox.Show("Usuario o contraseña incorrectos.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Código para inicializar el formulario, si es necesario
        Terminos.Hide()
    End Sub
End Class
