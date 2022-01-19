Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarSubMenus()
    End Sub

    Private Sub ocultarSubMenus()
        Panel_SubCliente.Visible = False
        Panel_SubPeliculas.Visible = False
    End Sub

    Private Sub mostrarSubmenu(subMenu As Panel)
        If subMenu.Visible = False Then
            ocultarSubMenus()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub Btn_ClientesMenu_Click(sender As Object, e As EventArgs) Handles Btn_ClientesMenu.Click
        mostrarSubmenu(Panel_SubCliente)

    End Sub

    Private Sub btn_PeliculasMenu_Click(sender As Object, e As EventArgs) Handles btn_PeliculasMenu.Click
        mostrarSubmenu(Panel_SubPeliculas)

    End Sub

    Private Sub abrirFormularioEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form

        Formulario = Panel_ContenedorFormularios.Controls.OfType(Of Miform)().FirstOrDefault()

        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            Panel_ContenedorFormularios.Controls.Add(Formulario)
            Panel_ContenedorFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

    Private Sub btn_VisualizarClientes_Click(sender As Object, e As EventArgs) Handles btn_VisualizarClientes.Click
        abrirFormularioEnPanel(Of frmClientes)()
    End Sub



End Class
