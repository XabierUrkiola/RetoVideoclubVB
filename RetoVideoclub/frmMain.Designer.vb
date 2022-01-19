<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel_MenuLateral = New System.Windows.Forms.Panel()
        Me.btn_MenuProveedor = New System.Windows.Forms.Button()
        Me.Panel_SubPeliculas = New System.Windows.Forms.Panel()
        Me.btn_RegistrarPeliculas = New System.Windows.Forms.Button()
        Me.btn_VisualizarPeliculas = New System.Windows.Forms.Button()
        Me.btn_PeliculasMenu = New System.Windows.Forms.Button()
        Me.Panel_SubCliente = New System.Windows.Forms.Panel()
        Me.btn_RegistrarClientes = New System.Windows.Forms.Button()
        Me.btn_VisualizarClientes = New System.Windows.Forms.Button()
        Me.Btn_ClientesMenu = New System.Windows.Forms.Button()
        Me.Panel_Logo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_ContenedorFormularios = New System.Windows.Forms.Panel()
        Me.Panel_MenuLateral.SuspendLayout()
        Me.Panel_SubPeliculas.SuspendLayout()
        Me.Panel_SubCliente.SuspendLayout()
        Me.Panel_Logo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_MenuLateral
        '
        Me.Panel_MenuLateral.AutoScroll = True
        Me.Panel_MenuLateral.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel_MenuLateral.Controls.Add(Me.btn_MenuProveedor)
        Me.Panel_MenuLateral.Controls.Add(Me.Panel_SubPeliculas)
        Me.Panel_MenuLateral.Controls.Add(Me.btn_PeliculasMenu)
        Me.Panel_MenuLateral.Controls.Add(Me.Panel_SubCliente)
        Me.Panel_MenuLateral.Controls.Add(Me.Btn_ClientesMenu)
        Me.Panel_MenuLateral.Controls.Add(Me.Panel_Logo)
        Me.Panel_MenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_MenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.Panel_MenuLateral.Name = "Panel_MenuLateral"
        Me.Panel_MenuLateral.Size = New System.Drawing.Size(200, 561)
        Me.Panel_MenuLateral.TabIndex = 0
        '
        'btn_MenuProveedor
        '
        Me.btn_MenuProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_MenuProveedor.FlatAppearance.BorderSize = 0
        Me.btn_MenuProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MenuProveedor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MenuProveedor.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_MenuProveedor.Location = New System.Drawing.Point(0, 326)
        Me.btn_MenuProveedor.Name = "btn_MenuProveedor"
        Me.btn_MenuProveedor.Size = New System.Drawing.Size(200, 45)
        Me.btn_MenuProveedor.TabIndex = 5
        Me.btn_MenuProveedor.Text = "Proveedores"
        Me.btn_MenuProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_MenuProveedor.UseVisualStyleBackColor = True
        '
        'Panel_SubPeliculas
        '
        Me.Panel_SubPeliculas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel_SubPeliculas.Controls.Add(Me.btn_RegistrarPeliculas)
        Me.Panel_SubPeliculas.Controls.Add(Me.btn_VisualizarPeliculas)
        Me.Panel_SubPeliculas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_SubPeliculas.Location = New System.Drawing.Point(0, 255)
        Me.Panel_SubPeliculas.Name = "Panel_SubPeliculas"
        Me.Panel_SubPeliculas.Size = New System.Drawing.Size(200, 71)
        Me.Panel_SubPeliculas.TabIndex = 4
        '
        'btn_RegistrarPeliculas
        '
        Me.btn_RegistrarPeliculas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_RegistrarPeliculas.FlatAppearance.BorderSize = 0
        Me.btn_RegistrarPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RegistrarPeliculas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RegistrarPeliculas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_RegistrarPeliculas.Location = New System.Drawing.Point(0, 35)
        Me.btn_RegistrarPeliculas.Name = "btn_RegistrarPeliculas"
        Me.btn_RegistrarPeliculas.Size = New System.Drawing.Size(200, 35)
        Me.btn_RegistrarPeliculas.TabIndex = 1
        Me.btn_RegistrarPeliculas.Text = "Registrar peliculas"
        Me.btn_RegistrarPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_RegistrarPeliculas.UseVisualStyleBackColor = True
        '
        'btn_VisualizarPeliculas
        '
        Me.btn_VisualizarPeliculas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_VisualizarPeliculas.FlatAppearance.BorderSize = 0
        Me.btn_VisualizarPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VisualizarPeliculas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VisualizarPeliculas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_VisualizarPeliculas.Location = New System.Drawing.Point(0, 0)
        Me.btn_VisualizarPeliculas.Name = "btn_VisualizarPeliculas"
        Me.btn_VisualizarPeliculas.Size = New System.Drawing.Size(200, 35)
        Me.btn_VisualizarPeliculas.TabIndex = 0
        Me.btn_VisualizarPeliculas.Text = "Visualizar peliculas"
        Me.btn_VisualizarPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_VisualizarPeliculas.UseVisualStyleBackColor = True
        '
        'btn_PeliculasMenu
        '
        Me.btn_PeliculasMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_PeliculasMenu.FlatAppearance.BorderSize = 0
        Me.btn_PeliculasMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PeliculasMenu.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PeliculasMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_PeliculasMenu.Location = New System.Drawing.Point(0, 210)
        Me.btn_PeliculasMenu.Name = "btn_PeliculasMenu"
        Me.btn_PeliculasMenu.Size = New System.Drawing.Size(200, 45)
        Me.btn_PeliculasMenu.TabIndex = 3
        Me.btn_PeliculasMenu.Text = "Peliculas"
        Me.btn_PeliculasMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PeliculasMenu.UseVisualStyleBackColor = True
        '
        'Panel_SubCliente
        '
        Me.Panel_SubCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel_SubCliente.Controls.Add(Me.btn_RegistrarClientes)
        Me.Panel_SubCliente.Controls.Add(Me.btn_VisualizarClientes)
        Me.Panel_SubCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_SubCliente.Location = New System.Drawing.Point(0, 135)
        Me.Panel_SubCliente.Name = "Panel_SubCliente"
        Me.Panel_SubCliente.Size = New System.Drawing.Size(200, 75)
        Me.Panel_SubCliente.TabIndex = 2
        '
        'btn_RegistrarClientes
        '
        Me.btn_RegistrarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_RegistrarClientes.FlatAppearance.BorderSize = 0
        Me.btn_RegistrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RegistrarClientes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RegistrarClientes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_RegistrarClientes.Location = New System.Drawing.Point(0, 35)
        Me.btn_RegistrarClientes.Name = "btn_RegistrarClientes"
        Me.btn_RegistrarClientes.Size = New System.Drawing.Size(200, 35)
        Me.btn_RegistrarClientes.TabIndex = 1
        Me.btn_RegistrarClientes.Text = "Registrar clientes"
        Me.btn_RegistrarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_RegistrarClientes.UseVisualStyleBackColor = True
        '
        'btn_VisualizarClientes
        '
        Me.btn_VisualizarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_VisualizarClientes.FlatAppearance.BorderSize = 0
        Me.btn_VisualizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VisualizarClientes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VisualizarClientes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_VisualizarClientes.Location = New System.Drawing.Point(0, 0)
        Me.btn_VisualizarClientes.Name = "btn_VisualizarClientes"
        Me.btn_VisualizarClientes.Size = New System.Drawing.Size(200, 35)
        Me.btn_VisualizarClientes.TabIndex = 0
        Me.btn_VisualizarClientes.Text = "Visualizar clientes"
        Me.btn_VisualizarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_VisualizarClientes.UseVisualStyleBackColor = True
        '
        'Btn_ClientesMenu
        '
        Me.Btn_ClientesMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_ClientesMenu.FlatAppearance.BorderSize = 0
        Me.Btn_ClientesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ClientesMenu.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ClientesMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_ClientesMenu.Location = New System.Drawing.Point(0, 90)
        Me.Btn_ClientesMenu.Name = "Btn_ClientesMenu"
        Me.Btn_ClientesMenu.Size = New System.Drawing.Size(200, 45)
        Me.Btn_ClientesMenu.TabIndex = 1
        Me.Btn_ClientesMenu.Text = "Cliente"
        Me.Btn_ClientesMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ClientesMenu.UseVisualStyleBackColor = True
        '
        'Panel_Logo
        '
        Me.Panel_Logo.Controls.Add(Me.PictureBox1)
        Me.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Logo.Name = "Panel_Logo"
        Me.Panel_Logo.Size = New System.Drawing.Size(200, 90)
        Me.Panel_Logo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel_ContenedorFormularios
        '
        Me.Panel_ContenedorFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel_ContenedorFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ContenedorFormularios.Location = New System.Drawing.Point(200, 0)
        Me.Panel_ContenedorFormularios.Name = "Panel_ContenedorFormularios"
        Me.Panel_ContenedorFormularios.Size = New System.Drawing.Size(723, 561)
        Me.Panel_ContenedorFormularios.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 561)
        Me.Controls.Add(Me.Panel_ContenedorFormularios)
        Me.Controls.Add(Me.Panel_MenuLateral)
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_MenuLateral.ResumeLayout(False)
        Me.Panel_SubPeliculas.ResumeLayout(False)
        Me.Panel_SubCliente.ResumeLayout(False)
        Me.Panel_Logo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_MenuLateral As Panel
    Friend WithEvents Panel_SubCliente As Panel
    Friend WithEvents btn_RegistrarClientes As Button
    Friend WithEvents btn_VisualizarClientes As Button
    Friend WithEvents Btn_ClientesMenu As Button
    Friend WithEvents Panel_Logo As Panel
    Friend WithEvents Panel_SubPeliculas As Panel
    Friend WithEvents btn_RegistrarPeliculas As Button
    Friend WithEvents btn_VisualizarPeliculas As Button
    Friend WithEvents btn_PeliculasMenu As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_MenuProveedor As Button
    Friend WithEvents Panel_ContenedorFormularios As Panel
End Class
