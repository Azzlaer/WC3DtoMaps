<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescargas = New System.Windows.Forms.TextBox()
        Me.btnwarcraft = New System.Windows.Forms.Button()
        Me.txtwarcraft = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btndescargas = New System.Windows.Forms.Button()
        Me.btnmover = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.check1w3m = New System.Windows.Forms.CheckBox()
        Me.check2w3x = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carpeta de descargas"
        '
        'txtdescargas
        '
        Me.txtdescargas.Location = New System.Drawing.Point(15, 314)
        Me.txtdescargas.Name = "txtdescargas"
        Me.txtdescargas.Size = New System.Drawing.Size(330, 22)
        Me.txtdescargas.TabIndex = 1
        Me.txtdescargas.Text = "C:\Users\Azzlaer\Downloads"
        '
        'btnwarcraft
        '
        Me.btnwarcraft.Location = New System.Drawing.Point(351, 371)
        Me.btnwarcraft.Name = "btnwarcraft"
        Me.btnwarcraft.Size = New System.Drawing.Size(98, 38)
        Me.btnwarcraft.TabIndex = 2
        Me.btnwarcraft.Text = "Buscar"
        Me.btnwarcraft.UseVisualStyleBackColor = True
        '
        'txtwarcraft
        '
        Me.txtwarcraft.Location = New System.Drawing.Point(15, 387)
        Me.txtwarcraft.Name = "txtwarcraft"
        Me.txtwarcraft.Size = New System.Drawing.Size(330, 22)
        Me.txtwarcraft.TabIndex = 4
        Me.txtwarcraft.Text = "D:\Juegos\Warcraft III\Maps\Download"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Carpeta de Warcraft 3/Maps/Download"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(436, 45)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Para hacer mas facil la busqueda de mapas que hayas bajado a tu computadora y mov" & _
            "er los maps a tu carpeta de Warcraft 3"
        '
        'btndescargas
        '
        Me.btndescargas.Location = New System.Drawing.Point(351, 298)
        Me.btndescargas.Name = "btndescargas"
        Me.btndescargas.Size = New System.Drawing.Size(98, 38)
        Me.btndescargas.TabIndex = 6
        Me.btndescargas.Text = "Buscar"
        Me.btndescargas.UseVisualStyleBackColor = True
        '
        'btnmover
        '
        Me.btnmover.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnmover.Location = New System.Drawing.Point(0, 634)
        Me.btnmover.Name = "btnmover"
        Me.btnmover.Size = New System.Drawing.Size(467, 42)
        Me.btnmover.TabIndex = 7
        Me.btnmover.Text = "Empezar"
        Me.btnmover.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(257, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 173)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'check1w3m
        '
        Me.check1w3m.AutoSize = True
        Me.check1w3m.Checked = True
        Me.check1w3m.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check1w3m.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check1w3m.Location = New System.Drawing.Point(12, 191)
        Me.check1w3m.Name = "check1w3m"
        Me.check1w3m.Size = New System.Drawing.Size(125, 24)
        Me.check1w3m.TabIndex = 10
        Me.check1w3m.Text = "Mapas .w3m"
        Me.check1w3m.UseVisualStyleBackColor = True
        '
        'check2w3x
        '
        Me.check2w3x.AutoSize = True
        Me.check2w3x.Checked = True
        Me.check2w3x.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check2w3x.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check2w3x.Location = New System.Drawing.Point(329, 191)
        Me.check2w3x.Name = "check2w3x"
        Me.check2w3x.Size = New System.Drawing.Size(119, 24)
        Me.check2w3x.TabIndex = 11
        Me.check2w3x.Text = "Mapas .w3x"
        Me.check2w3x.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(15, 451)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(433, 164)
        Me.ListBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Registro"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 676)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.check2w3x)
        Me.Controls.Add(Me.check1w3m)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnmover)
        Me.Controls.Add(Me.btndescargas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtwarcraft)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnwarcraft)
        Me.Controls.Add(Me.txtdescargas)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LatinBattle.com - WC3DtoMaps "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdescargas As System.Windows.Forms.TextBox
    Friend WithEvents btnwarcraft As System.Windows.Forms.Button
    Friend WithEvents txtwarcraft As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btndescargas As System.Windows.Forms.Button
    Friend WithEvents btnmover As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents check1w3m As System.Windows.Forms.CheckBox
    Friend WithEvents check2w3x As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
