<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terminos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Terminos))
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkNoMostrar = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(226, 352)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(8, 42)
        Me.HScrollBar1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.HScrollBar1)
        Me.Panel1.Location = New System.Drawing.Point(42, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 413)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 654)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkNoMostrar
        '
        Me.chkNoMostrar.AutoSize = True
        Me.chkNoMostrar.Location = New System.Drawing.Point(42, 510)
        Me.chkNoMostrar.Name = "chkNoMostrar"
        Me.chkNoMostrar.Size = New System.Drawing.Size(118, 17)
        Me.chkNoMostrar.TabIndex = 5
        Me.chkNoMostrar.Text = "No volver a mostrar"
        Me.chkNoMostrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(294, 542)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 35)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(210, 542)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 35)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 92)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Términos y Condiciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Terminos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 589)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.chkNoMostrar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Terminos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents chkNoMostrar As CheckBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
End Class
