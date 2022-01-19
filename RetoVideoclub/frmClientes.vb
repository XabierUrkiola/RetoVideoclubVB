Imports System.Configuration
Imports System.Data.OleDb

Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView_Clientes.DataSource = rellenarGrid()

    End Sub

    Private Function rellenarGrid() As DataTable

        Dim dtClientes As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New OleDbConnection(connString)

            Using cmd As New OleDbCommand("Select CLIENTEID, NOMBRE, APELLIDO1, APELLIDO2, ESBAJA From CLIENTES", conn)
                conn.Open()

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                dtClientes.Load(reader)

            End Using

        End Using

        Return dtClientes

    End Function


End Class