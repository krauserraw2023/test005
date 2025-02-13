Imports Bussines
Imports Bussines.Mantenimiento.General
Imports Entity.Mantenimiento.General

Namespace Mantenimiento.Pabellon
    Public Class frmAmbientePopup
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmImpresion As Boolean = False
        Public _frmEliminar As Boolean = False

        Public Codigo As Integer = -1
        Public Pabellon As String = ""
        Public Piso As String = ""
        Public AleroId As Integer = -1
        Public Alero As String = ""
        Public RegionId As Integer = -1
        Public PenalId As Integer = -1

        Private AmbienteNombreSel As String = ""
        Private AmbienteIdSel As Integer = -1


        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

            Dim p As New Ambiente_BE


            If txtAmbiente.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre del piso.")
                Exit Sub
            End If

            If Me.Codigo > 0 Then
                p = (New Ambiente_BL).Listar(Codigo)
            Else
                p.IDPenal = Me.PenalId
                p.IDRegion = Me.RegionId
                p.AleroId = Me.AleroId
            End If

            p.AmbienteNombre = txtAmbiente.Text.Trim.ToUpper
            p.AmbienteHabilitado = IIf(chkActivo.Checked, True, False)

            Dim id As Integer = (New Ambiente_BL).Grabar(p)

            If id < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo grabar, por favor intentelo nuevamente.")
                Exit Sub
            End If

            Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub
        Private Sub PermisoUsuario()
            btnOK.Visible = Me._frmEscritura
        End Sub
        Private Sub frmAmbientePopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim p As New Ambiente_BE

            lblPabellon.Text = Me.Pabellon
            lblPiso.Text = Me.Piso
            lblAlero.Text = Me.Alero
            If Me.Codigo = -1 Then Exit Sub

            p = (New Ambiente_BL).Listar(Me.Codigo)

            txtAmbiente.Text = p.AmbienteNombre
            If p.AleroHabilitado Then
                chkActivo.Checked = True
            Else
                chkInactivo.Checked = True
            End If

            PermisoUsuario()
        End Sub
    End Class
End Namespace