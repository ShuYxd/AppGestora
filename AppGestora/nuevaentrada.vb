Imports MySql.Data.MySqlClient

Public Class nuevaentrada
    Private Sub alumnos_agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar opciones en el combobox de genero
        genero.Items.Add("Hombre")
        genero.Items.Add("Mujer")
        ' Cargar opciones en el combobox de carrera
        carrera.Items.Add("LD")
        carrera.Items.Add("LIA")
        ' Cargar opciones en el combobox de SEMESTRE
        semestre.Items.Add("1")
        semestre.Items.Add("2")
        semestre.Items.Add("3")
        semestre.Items.Add("4")
        semestre.Items.Add("5")
        semestre.Items.Add("6")
        semestre.Items.Add("7")

        ' Cargar opciones en el combobox de roles
        roles.Items.Add("Administrador")
        roles.Items.Add("Alumno")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Server=localhost;Database=bdapp;Uid=root;Pwd=;"

        ' Conexión a la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Verificar si la matrícula ya existe en la tabla de usuarios
                Dim checkQuery As String = "SELECT COUNT(*) FROM usuarios WHERE Matricula = @matricula"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@matricula", Matricula.Text)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If count = 0 Then
                        ' Si no existe, insertar en la tabla de usuarios
                        Dim queryUsuarios As String = "INSERT INTO usuarios (Matricula, Nombre, Correo, Contraseña, Rol) " &
                                                       "VALUES ( @matricula, @nombre, @correo, @contraseña, @rol)"

                        Using cmdUsuarios As New MySqlCommand(queryUsuarios, conn)
                            cmdUsuarios.Parameters.AddWithValue("@matricula", Matricula.Text)
                            cmdUsuarios.Parameters.AddWithValue("@nombre", nombrealumno.Text) ' Asumiendo que el nombre es el mismo
                            cmdUsuarios.Parameters.AddWithValue("@correo", correo.Text)
                            cmdUsuarios.Parameters.AddWithValue("@contraseña", contraseña.Text) ' Recuerda cifrar la contraseña
                            cmdUsuarios.Parameters.AddWithValue("@rol", roles.SelectedItem.ToString())
                            cmdUsuarios.ExecuteNonQuery()
                        End Using
                    Else
                        MessageBox.Show("La matrícula ya existe en usuarios.")
                        Return ' Salir si la matrícula ya existe
                    End If
                End Using

                ' Inserción en la tabla de ALUMNOS
                Dim query As String = "INSERT INTO alumnos (Matricula, ApellidoP, ApellidoM, Nombre, Nacionalidad, CURP, Telefono, Genero, Carrera, Semestre, Edad) " &
                                      "VALUES ( @matricula, @apellidopaterno, @apellidomaterno, @nombrealumno, @nacionalidad, @curp, @telefono, @genero, @carrera, @semestre), @edad"

                Using cmd As New MySqlCommand(query, conn)
                    ' Agregar parámetros con los valores de los controles
                    cmd.Parameters.AddWithValue("@matricula", Matricula.Text)
                    cmd.Parameters.AddWithValue("@apellidopaterno", apellidopaterno.Text)
                    cmd.Parameters.AddWithValue("@apellidomaterno", apellidomaterno.Text)
                    cmd.Parameters.AddWithValue("@nombrealumno", nombrealumno.Text)
                    cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad.Text)
                    cmd.Parameters.AddWithValue("@edad", edad.Text)
                    cmd.Parameters.AddWithValue("@curp", curp.Text)
                    cmd.Parameters.AddWithValue("@telefono", telefono.Text)
                    cmd.Parameters.AddWithValue("@genero", genero.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@carrera", carrera.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@semestre", semestre.SelectedItem.ToString())

                    ' Ejecutar el comando
                    cmd.ExecuteNonQuery()

                    ' Confirmar éxito
                    MessageBox.Show("Datos insertados correctamente")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al insertar los datos: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roles.SelectedIndexChanged

    End Sub
End Class
