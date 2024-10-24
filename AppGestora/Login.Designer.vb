<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AppGestora.My.Resources.Resources.UICSLP_logo__1_
        Me.PictureBox1.Location = New System.Drawing.Point(99, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(559, 205)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'correo
        '
        Me.correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.correo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correo.Location = New System.Drawing.Point(264, 300)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(274, 29)
        Me.correo.TabIndex = 1
        Me.correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'contraseña
        '
        Me.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.contraseña.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contraseña.Location = New System.Drawing.Point(264, 361)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña.Size = New System.Drawing.Size(274, 29)
        Me.contraseña.TabIndex = 2
        Me.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Correo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(349, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(801, 542)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.correo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents correo As TextBox
    Friend WithEvents contraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
