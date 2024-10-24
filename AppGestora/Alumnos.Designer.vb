<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCarrera = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxCarrera = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCarrera = New System.Windows.Forms.TextBox()
        Me.txtSemestre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(617, 533)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(756, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(664, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Semestre:"
        '
        'ComboBoxCarrera
        '
        Me.ComboBoxCarrera.FormattingEnabled = True
        Me.ComboBoxCarrera.Location = New System.Drawing.Point(756, 75)
        Me.ComboBoxCarrera.Name = "ComboBoxCarrera"
        Me.ComboBoxCarrera.Size = New System.Drawing.Size(97, 21)
        Me.ComboBoxCarrera.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(679, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Carrera:"
        '
        'CheckBoxCarrera
        '
        Me.CheckBoxCarrera.AutoSize = True
        Me.CheckBoxCarrera.Location = New System.Drawing.Point(920, 12)
        Me.CheckBoxCarrera.Name = "CheckBoxCarrera"
        Me.CheckBoxCarrera.Size = New System.Drawing.Size(121, 17)
        Me.CheckBoxCarrera.TabIndex = 5
        Me.CheckBoxCarrera.Text = "Activar Filtro Carrera"
        Me.CheckBoxCarrera.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(698, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Informacion de Alumno"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(791, 182)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(189, 20)
        Me.txtMatricula.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(791, 219)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(189, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(791, 255)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(189, 20)
        Me.txtApellidoPaterno.TabIndex = 9
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(791, 293)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(189, 20)
        Me.txtApellidoMaterno.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(706, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Matricula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(715, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(660, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Apellido Paterno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(652, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Apellido Materno"
        '
        'txtCarrera
        '
        Me.txtCarrera.Location = New System.Drawing.Point(767, 343)
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.Size = New System.Drawing.Size(60, 20)
        Me.txtCarrera.TabIndex = 15
        '
        'txtSemestre
        '
        Me.txtSemestre.Location = New System.Drawing.Point(920, 343)
        Me.txtSemestre.Name = "txtSemestre"
        Me.txtSemestre.Size = New System.Drawing.Size(60, 20)
        Me.txtSemestre.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(833, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Semestre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(695, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Carrera"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(699, 409)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(124, 48)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(856, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 48)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Nueva Entrada"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 583)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSemestre)
        Me.Controls.Add(Me.txtCarrera)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBoxCarrera)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxCarrera)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Alumnos"
        Me.Text = "Alumnos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCarrera As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBoxCarrera As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCarrera As TextBox
    Friend WithEvents txtSemestre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Button1 As Button
End Class
