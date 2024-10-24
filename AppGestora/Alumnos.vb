Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Alumnos
    Private connString As String = "Server=localhost;Database=bdapp;Uid=root;Pwd=;"

    Private Sub alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con opciones numéricas para semestre
        ComboBox1.Items.Add("Todos")
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ComboBox1.Items.Add("6")
        ComboBox1.Items.Add("7")
        ComboBox1.Items.Add("8")
        ComboBox1.SelectedIndex = 0 ' Seleccionar la primera opción por defecto
        LoadData("Todos", "") ' Cargar datos por defecto

        ' Llenar ComboBoxCarrera con opciones de carrera
        LoadCarreras()
    End Sub

    Private Sub LoadCarreras()
        Dim query As String = "SELECT DISTINCT carrera FROM alumnos"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ComboBoxCarrera.Items.Add(reader("carrera").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadData(semestreFilter As String, carreraFilter As String)
        Dim query As String = "SELECT Matricula, Nombre, ApellidoP, ApellidoM, Edad, Semestre, Carrera FROM alumnos WHERE 1=1" ' El 1=1 es útil para concatenar condiciones

        If semestreFilter <> "Todos" Then
            query += " AND Semestre = @semestreFilter"
        End If

        If Not String.IsNullOrEmpty(carreraFilter) Then
            query += " AND Carrera = @carreraFilter"
        End If

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                ' Añadir parámetros si hay un filtro
                If semestreFilter <> "Todos" Then
                    cmd.Parameters.AddWithValue("@semestreFilter", Convert.ToInt32(semestreFilter))
                End If

                If Not String.IsNullOrEmpty(carreraFilter) Then
                    cmd.Parameters.AddWithValue("@carreraFilter", carreraFilter)
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedSemestre As String = ComboBox1.SelectedItem.ToString()
        Dim selectedCarrera As String = If(CheckBoxCarrera.Checked, ComboBoxCarrera.SelectedItem?.ToString(), "")

        LoadData(selectedSemestre, selectedCarrera)
    End Sub

    Private Sub CheckBoxCarrera_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCarrera.CheckedChanged
        Dim selectedSemestre As String = ComboBox1.SelectedItem.ToString()
        Dim selectedCarrera As String = If(CheckBoxCarrera.Checked, ComboBoxCarrera.SelectedItem?.ToString(), "")

        LoadData(selectedSemestre, selectedCarrera)
    End Sub

    Private Sub ComboBoxCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarrera.SelectedIndexChanged
        Dim selectedSemestre As String = ComboBox1.SelectedItem.ToString()
        Dim selectedCarrera As String = If(CheckBoxCarrera.Checked, ComboBoxCarrera.SelectedItem?.ToString(), "")

        LoadData(selectedSemestre, selectedCarrera)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Aquí puedes agregar código adicional si necesitas manejar clics en el DataGridView
        ' Verificar si se ha seleccionado una fila en el DataGridView
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Rellenar los TextBox con los valores de la fila seleccionada
            txtMatricula.Text = selectedRow.Cells("Matricula").Value.ToString()
            txtNombre.Text = selectedRow.Cells("Nombre").Value.ToString()
            txtApellidoPaterno.Text = selectedRow.Cells("ApellidoP").Value.ToString()
            txtApellidoMaterno.Text = selectedRow.Cells("ApellidoM").Value.ToString()
            txtCarrera.Text = selectedRow.Cells("Carrera").Value.ToString()
            txtSemestre.Text = selectedRow.Cells("Semestre").Value.ToString()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Verificar que se haya seleccionado una fila antes de guardar
        If String.IsNullOrEmpty(txtMatricula.Text) Then
            MessageBox.Show("Por favor, selecciona un alumno para editar.")
            Return
        End If

        ' Ventana emergente de confirmación
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas guardar los cambios?", "Confirmar Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Actualizar el alumno en la base de datos
            ActualizarAlumno()
            ' Volver a cargar los datos en el DataGridView
            LoadData(ComboBox1.SelectedItem.ToString(), If(CheckBoxCarrera.Checked, ComboBoxCarrera.SelectedItem?.ToString(), ""))
            ' Limpiar los TextBox
            LimpiarTextBoxes()
        End If
    End Sub

    Private Sub ActualizarAlumno()
        Dim query As String = "UPDATE alumnos SET Nombre = @nombre, ApellidoP = @apellidopaterno, ApellidoM = @apellidomaterno, Carrera = @carrera, Semestre = @semestre WHERE Matricula = @matricula"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text)
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@apellidopaterno", txtApellidoPaterno.Text)
                cmd.Parameters.AddWithValue("@apellidomaterno", txtApellidoMaterno.Text)
                cmd.Parameters.AddWithValue("@carrera", txtCarrera.Text)
                cmd.Parameters.AddWithValue("@semestre", txtSemestre.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub LimpiarTextBoxes()
        txtMatricula.Clear()
        txtNombre.Clear()
        txtApellidoPaterno.Clear()
        txtApellidoMaterno.Clear()
        txtCarrera.Clear()
        txtSemestre.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nuevaentrada.Show()
    End Sub
End Class