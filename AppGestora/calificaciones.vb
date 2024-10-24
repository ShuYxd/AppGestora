Imports MySql.Data.MySqlClient

Public Class calificaciones
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los combobox al iniciar
        CargarComboboxes()
        ' Cargar los datos iniciales
        CargarDatos()
    End Sub

    ' Método para cargar datos en el DataGridView
    Private Sub CargarDatos()
        Dim connectionString As String = "Server=localhost;Database=bdapp;Uid=root;Pwd=;"
        Dim query As String = "SELECT Matricula, Nombre, Carrera, Semestre FROM alumnos WHERE 1=1"

        ' Filtrar por semestre
        If Not String.IsNullOrEmpty(ComboBoxSemestre.Text) Then
            query += " AND Semestre = @semestre"
        End If

        ' Filtrar por carrera
        If Not String.IsNullOrEmpty(ComboBoxCarrera.Text) Then
            query += " AND Carrera = @carrera"
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Agregar parámetros solo si son seleccionados
                    If Not String.IsNullOrEmpty(ComboBoxSemestre.Text) Then
                        cmd.Parameters.AddWithValue("@semestre", ComboBoxSemestre.Text)
                    End If
                    If Not String.IsNullOrEmpty(ComboBoxCarrera.Text) Then
                        cmd.Parameters.AddWithValue("@carrera", ComboBoxCarrera.Text)
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table) ' Rellena el DataTable con los datos filtrados
                        DataGridView1.DataSource = table ' Asigna el DataTable al DataGridView
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message) ' Manejo de errores
        End Try
    End Sub

    ' Método para cargar los valores de los ComboBox
    Private Sub CargarComboboxes()
        ' Aquí puedes agregar los valores que deseas para cada ComboBox
        ' Para ComboBoxSemestre
        ComboBoxSemestre.Items.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8"})
        ' Para ComboBoxCarrera
        ComboBoxCarrera.Items.AddRange(New String() {"LIA", "LD"})
        ' Para ComboBoxPeriodo, agrega los periodos disponibles
        periodo.Items.AddRange(New String() {"1", "2", "3"}) ' Ajusta según tus necesidades
    End Sub

    ' Evento que se ejecuta al cambiar el texto en los ComboBoxes
    Private Sub ComboBoxSemestre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSemestre.SelectedIndexChanged, ComboBoxCarrera.SelectedIndexChanged
        CargarDatos() ' Recarga los datos al cambiar un filtro
    End Sub

    ' Método que se ejecuta al hacer clic en una celda del DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then ' Verifica que se haya seleccionado una fila válida
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Label7.Text = selectedRow.Cells("Matricula").Value.ToString() ' Muestra la matrícula en el Label
            Label9.Text = selectedRow.Cells("Nombre").Value.ToString() ' Muestra el nombre en Label9
        End If
    End Sub

    ' Evento que se ejecuta al hacer clic en el botón "Ver Calificaciones"
    Private Sub btnVerCalificaciones_Click(sender As Object, e As EventArgs) Handles vercali.Click
        VerCalificaciones() ' Llama al método para ver las calificaciones
    End Sub

    ' Método para ver calificaciones de un alumno
    Private Sub VerCalificaciones()
        Dim connectionString As String = "Server=localhost;Database=bdapp;Uid=root;Pwd=;"
        Dim query As String = "SELECT MateriaClave, Calificacion FROM calificaciones WHERE Matricula = @Matricula AND Periodo = @Periodo"

        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Asegúrate de que Label7 y ComboBoxPeriodo no estén vacíos antes de usar sus valores
                    If Not String.IsNullOrEmpty(Label7.Text) AndAlso Not String.IsNullOrEmpty(periodo.Text) Then
                        cmd.Parameters.AddWithValue("@Matricula", Label7.Text)
                        cmd.Parameters.AddWithValue("@Periodo", periodo.Text)

                        conn.Open() ' Abre la conexión
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        ' Limpiar los TextBoxes antes de mostrar nuevos resultados
                        LIA71_2020.Clear()
                        LIA72_2020.Clear()
                        LIA73_2020.Clear()
                        LIA74_2020.Clear()
                        OP71_2020.Clear()
                        OP72_2020.Clear()
                        SC05_2020.Clear()
                        VC03_2020.Clear()

                        ' Leer los resultados y asignar las calificaciones a los TextBoxes correspondientes
                        While reader.Read()
                            Dim materia As String = reader("MateriaClave").ToString()
                            Dim calificacion As String = reader("Calificacion").ToString()

                            Select Case materia
                                Case "LIA71-2020"
                                    LIA71_2020.Text = calificacion
                                Case "LIA72-2020"
                                    LIA72_2020.Text = calificacion
                                Case "LIA73-2020"
                                    LIA73_2020.Text = calificacion
                                Case "LIA74-2020"
                                    LIA74_2020.Text = calificacion
                                Case "OP71-2020"
                                    OP71_2020.Text = calificacion
                                Case "OP72-2020"
                                    OP72_2020.Text = calificacion
                                Case "SC05-2020"
                                    SC05_2020.Text = calificacion
                                Case "VC03-2020"
                                    VC03_2020.Text = calificacion
                            End Select
                        End While

                        ' Si no se encontró ninguna calificación
                        If reader.HasRows = False Then
                            MessageBox.Show("No se encontraron calificaciones para esta matrícula y periodo.")
                        End If

                        reader.Close() ' Cierra el lector
                    Else
                        MessageBox.Show("Por favor, selecciona un estudiante y un período.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar calificaciones: " & ex.Message) ' Manejo de errores
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Server=localhost;Database=bdapp;Uid=root;Pwd=;"

        ' Lista de TextBoxes con sus respectivas MateriaClave
        Dim calificaciones As New Dictionary(Of String, String) From {
            {"LIA71-2020", LIA71_2020.Text},
            {"LIA72-2020", LIA72_2020.Text},
            {"LIA73-2020", LIA73_2020.Text},
            {"LIA74-2020", LIA74_2020.Text},
            {"OP71-2020", OP71_2020.Text},
            {"OP72-2020", OP72_2020.Text},
            {"SC05-2020", SC05_2020.Text},
            {"VC03-2020", VC03_2020.Text}
        }

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open() ' Abre la conexión

                For Each kvp As KeyValuePair(Of String, String) In calificaciones
                    Dim materiaClave As String = kvp.Key
                    Dim calificacion As String = kvp.Value

                    ' Verificar si ya existe la calificación
                    Dim checkQuery As String = "SELECT COUNT(*) FROM calificaciones WHERE Matricula = @Matricula AND MateriaClave = @MateriaClave AND Periodo = @Periodo"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@Matricula", Label7.Text) ' Asegúrate de que Label7 contenga la matrícula
                        checkCmd.Parameters.AddWithValue("@MateriaClave", materiaClave)
                        checkCmd.Parameters.AddWithValue("@Periodo", periodo.Text) ' Asegúrate de que ComboBoxPeriodo tenga el periodo seleccionado

                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                        If count > 0 Then
                            ' Si existe, actualiza
                            Dim updateQuery As String = "UPDATE calificaciones SET Calificacion = @Calificacion WHERE Matricula = @Matricula AND MateriaClave = @MateriaClave AND Periodo = @Periodo"
                            Using updateCmd As New MySqlCommand(updateQuery, conn)
                                updateCmd.Parameters.AddWithValue("@Calificacion", calificacion)
                                updateCmd.Parameters.AddWithValue("@Matricula", Label7.Text)
                                updateCmd.Parameters.AddWithValue("@MateriaClave", materiaClave)
                                updateCmd.Parameters.AddWithValue("@Periodo", periodo.Text)

                                updateCmd.ExecuteNonQuery() ' Ejecuta la actualización
                            End Using
                        Else
                            ' Si no existe, inserta
                            Dim insertQuery As String = "INSERT INTO calificaciones (Matricula, MateriaClave, Calificacion, Periodo) VALUES (@Matricula, @MateriaClave, @Calificacion, @Periodo)"
                            Using insertCmd As New MySqlCommand(insertQuery, conn)
                                insertCmd.Parameters.AddWithValue("@Matricula", Label7.Text)
                                insertCmd.Parameters.AddWithValue("@MateriaClave", materiaClave)
                                insertCmd.Parameters.AddWithValue("@Calificacion", calificacion)
                                insertCmd.Parameters.AddWithValue("@Periodo", periodo.Text)

                                insertCmd.ExecuteNonQuery() ' Ejecuta la inserción
                            End Using
                        End If
                    End Using
                Next
            End Using

            MessageBox.Show("Calificaciones guardadas correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al guardar calificaciones: " & ex.Message) ' Manejo de errores
        End Try
    End Sub
End Class
