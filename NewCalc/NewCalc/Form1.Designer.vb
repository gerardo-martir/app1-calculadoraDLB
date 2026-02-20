<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Sumar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Restar = New System.Windows.Forms.Button()
        Me.Multiplicar = New System.Windows.Forms.Button()
        Me.Dividir = New System.Windows.Forms.Button()
        Me.boton0 = New System.Windows.Forms.Button()
        Me.boton9 = New System.Windows.Forms.Button()
        Me.boton8 = New System.Windows.Forms.Button()
        Me.boton7 = New System.Windows.Forms.Button()
        Me.boton4 = New System.Windows.Forms.Button()
        Me.Boton5 = New System.Windows.Forms.Button()
        Me.boton6 = New System.Windows.Forms.Button()
        Me.boton1 = New System.Windows.Forms.Button()
        Me.Boton2 = New System.Windows.Forms.Button()
        Me.Boton3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora real"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero 2"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(103, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 28)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(235, 28)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "0"
        '
        'Sumar
        '
        Me.Sumar.BackColor = System.Drawing.Color.LavenderBlush
        Me.Sumar.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sumar.Location = New System.Drawing.Point(500, 137)
        Me.Sumar.Name = "Sumar"
        Me.Sumar.Size = New System.Drawing.Size(90, 66)
        Me.Sumar.TabIndex = 5
        Me.Sumar.Text = "+"
        Me.Sumar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RESULTADO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(357, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 79)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "0"
        '
        'Restar
        '
        Me.Restar.BackColor = System.Drawing.Color.LavenderBlush
        Me.Restar.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restar.Location = New System.Drawing.Point(500, 209)
        Me.Restar.Name = "Restar"
        Me.Restar.Size = New System.Drawing.Size(90, 66)
        Me.Restar.TabIndex = 8
        Me.Restar.Text = "-"
        Me.Restar.UseVisualStyleBackColor = False
        '
        'Multiplicar
        '
        Me.Multiplicar.BackColor = System.Drawing.Color.LavenderBlush
        Me.Multiplicar.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicar.Location = New System.Drawing.Point(500, 281)
        Me.Multiplicar.Name = "Multiplicar"
        Me.Multiplicar.Size = New System.Drawing.Size(90, 66)
        Me.Multiplicar.TabIndex = 9
        Me.Multiplicar.Text = "X"
        Me.Multiplicar.UseVisualStyleBackColor = False
        '
        'Dividir
        '
        Me.Dividir.BackColor = System.Drawing.Color.LavenderBlush
        Me.Dividir.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dividir.Location = New System.Drawing.Point(500, 353)
        Me.Dividir.Name = "Dividir"
        Me.Dividir.Size = New System.Drawing.Size(90, 66)
        Me.Dividir.TabIndex = 10
        Me.Dividir.Text = "÷"
        Me.Dividir.UseVisualStyleBackColor = False
        '
        'boton0
        '
        Me.boton0.BackColor = System.Drawing.Color.LavenderBlush
        Me.boton0.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton0.Location = New System.Drawing.Point(308, 353)
        Me.boton0.Name = "boton0"
        Me.boton0.Size = New System.Drawing.Size(90, 66)
        Me.boton0.TabIndex = 11
        Me.boton0.Text = "0"
        Me.boton0.UseVisualStyleBackColor = False
        '
        'boton9
        '
        Me.boton9.BackColor = System.Drawing.Color.LavenderBlush
        Me.boton9.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton9.Location = New System.Drawing.Point(404, 281)
        Me.boton9.Name = "boton9"
        Me.boton9.Size = New System.Drawing.Size(90, 66)
        Me.boton9.TabIndex = 12
        Me.boton9.Text = "9"
        Me.boton9.UseVisualStyleBackColor = False
        '
        'boton8
        '
        Me.boton8.BackColor = System.Drawing.Color.LavenderBlush
        Me.boton8.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton8.Location = New System.Drawing.Point(308, 281)
        Me.boton8.Name = "boton8"
        Me.boton8.Size = New System.Drawing.Size(90, 66)
        Me.boton8.TabIndex = 13
        Me.boton8.Text = "8"
        Me.boton8.UseVisualStyleBackColor = False
        '
        'boton7
        '
        Me.boton7.BackColor = System.Drawing.Color.LavenderBlush
        Me.boton7.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton7.Location = New System.Drawing.Point(212, 281)
        Me.boton7.Name = "boton7"
        Me.boton7.Size = New System.Drawing.Size(90, 66)
        Me.boton7.TabIndex = 14
        Me.boton7.Text = "7"
        Me.boton7.UseVisualStyleBackColor = False
        '
        'boton4
        '
        Me.boton4.BackColor = System.Drawing.Color.LavenderBlush
        Me.boton4.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton4.Location = New System.Drawing.Point(212, 209)
        Me.boton4.Name = "boton4"
        Me.boton4.Size = New System.Drawing.Size(90, 66)
        Me.boton4.TabIndex = 17
        Me.boton4.Text = "4"
        Me.boton4.UseVisualStyleBackColor = False
        '
        'Boton5
        '
        Me.Boton5.BackColor = System.Drawing.Color.LavenderBlush
        Me.Boton5.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton5.Location = New System.Drawing.Point(308, 209)
        Me.Boton5.Name = "Boton5"
        Me.Boton5.Size = New System.Drawing.Size(90, 66)
        Me.Boton5.TabIndex = 16
        Me.Boton5.Text = "5"
        Me.Boton5.UseVisualStyleBackColor = False
        '
        'boton6
        '
        Me.boton6.BackColor = System.Drawing.Color.LavenderBlush
        Me.boton6.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton6.Location = New System.Drawing.Point(404, 209)
        Me.boton6.Name = "boton6"
        Me.boton6.Size = New System.Drawing.Size(90, 66)
        Me.boton6.TabIndex = 15
        Me.boton6.Text = "6"
        Me.boton6.UseVisualStyleBackColor = False
        '
        'boton1
        '
        Me.boton1.BackColor = System.Drawing.Color.LavenderBlush
        Me.boton1.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton1.Location = New System.Drawing.Point(212, 137)
        Me.boton1.Name = "boton1"
        Me.boton1.Size = New System.Drawing.Size(90, 66)
        Me.boton1.TabIndex = 20
        Me.boton1.Text = "1"
        Me.boton1.UseVisualStyleBackColor = False
        '
        'Boton2
        '
        Me.Boton2.BackColor = System.Drawing.Color.LavenderBlush
        Me.Boton2.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton2.Location = New System.Drawing.Point(308, 137)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(90, 66)
        Me.Boton2.TabIndex = 19
        Me.Boton2.Text = "2"
        Me.Boton2.UseVisualStyleBackColor = False
        '
        'Boton3
        '
        Me.Boton3.BackColor = System.Drawing.Color.LavenderBlush
        Me.Boton3.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton3.Location = New System.Drawing.Point(404, 137)
        Me.Boton3.Name = "Boton3"
        Me.Boton3.Size = New System.Drawing.Size(90, 66)
        Me.Boton3.TabIndex = 18
        Me.Boton3.Text = "3"
        Me.Boton3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LavenderBlush
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(404, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 66)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "C"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NewCalc.My.Resources.Resources.workingonaweekendunusual
        Me.PictureBox1.Location = New System.Drawing.Point(8, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LavenderBlush
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(212, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 66)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 70)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 24
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Seleccionado"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 114)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 25
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Seleccionado"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(599, 450)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.boton1)
        Me.Controls.Add(Me.Boton2)
        Me.Controls.Add(Me.Boton3)
        Me.Controls.Add(Me.boton4)
        Me.Controls.Add(Me.Boton5)
        Me.Controls.Add(Me.boton6)
        Me.Controls.Add(Me.boton7)
        Me.Controls.Add(Me.boton8)
        Me.Controls.Add(Me.boton9)
        Me.Controls.Add(Me.boton0)
        Me.Controls.Add(Me.Dividir)
        Me.Controls.Add(Me.Multiplicar)
        Me.Controls.Add(Me.Restar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Sumar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Sumar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Restar As Button
    Friend WithEvents Multiplicar As Button
    Friend WithEvents Dividir As Button
    Friend WithEvents boton0 As Button
    Friend WithEvents boton9 As Button
    Friend WithEvents boton8 As Button
    Friend WithEvents boton7 As Button
    Friend WithEvents boton4 As Button
    Friend WithEvents Boton5 As Button
    Friend WithEvents boton6 As Button
    Friend WithEvents boton1 As Button
    Friend WithEvents Boton2 As Button
    Friend WithEvents Boton3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
