Imports Bussines
Imports Bussines.Mantenimiento.General
Imports Entity.Mantenimiento.General

Namespace Mantenimiento.Pabellon
    Public Class frmMantAleroPopup
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmImpresion As Boolean = False
        Public _frmEliminar As Boolean = False

        Public Codigo As Integer = -1
        Public NomPiso As String = ""
        Public NomPabellon As String = ""
        Public PisoId As Integer = -1
        Public RegionId As Integer = -1
        Public PenalId As Integer = -1

        Private RegistroActualizado As Boolean = False


        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
            If txtNombreAlero.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre del piso.")
                Exit Sub
            End If

            Dim p As New Alero_BE

            If Me.Codigo > 0 Then
                p = (New Alero_BL).Listar(Codigo)
            Else
                p.IDPenal = Me.PenalId
                p.IDRegion = Me.RegionId
                p.PisoId = Me.PisoId
            End If

            p.Nombre = txtNombreAlero.Text.Trim.ToUpper
            p.AleroHabilitado = IIf(chkActivo.Checked, True, False)

            Dim id As Integer = (New Alero_BL).Grabar(p)

            If id < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo grabar, por favor intentelo nuevamente.")
                Exit Sub
            End If

            Me.RegistroActualizado = True

            Me.Codigo = id
            Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

            Me.DialogResult = DialogResult.OK

        End Sub
        Private Sub PermisoUsuario()
            btnOK.Visible = Me._frmEscritura

        End Sub
        Private Sub frmMantAleroPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim p As New Alero_BE

            If Me.Codigo = -1 Then Exit Sub

            p = (New Alero_BL).Listar(Me.Codigo)

            txtNombreAlero.Text = p.Nombre

            If p.AleroHabilitado Then
                chkActivo.Checked = True
            Else
                chkInactivo.Checked = True
            End If
            PermisoUsuario()
        End Sub



        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click


            Me.Close()

        End Sub
    End Class
End Namespace