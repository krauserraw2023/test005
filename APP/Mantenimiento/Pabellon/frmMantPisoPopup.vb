Imports Bussines
Imports Entity.Mantenimiento.General

Namespace Mantenimiento.Pabellon
    Public Class frmMantPisoPopup
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmImpresion As Boolean = False
        Public _frmEliminar As Boolean = False

        Public Codigo As Integer = -1
        Public PabellonId As Integer = -1
        Public NomPabellon As String = ""

        Public RegionId As Integer = -1
        Public PenalId As Integer = -1

        Private Sub frmMantPisoPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtPabellon.Text = Me.NomPabellon
            If Me.Codigo = -1 Then Exit Sub

            Dim p As Piso_BE = (New Piso_BL).Listar(Me.Codigo)

            txtNombrePiso.Text = p.Nombre
            chkActivo.Checked = IIf(p.PisoHabilitado, True, False)
            btnOK.Visible = Me._frmEscritura

        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
            Dim p As New Piso_BE
            Dim id As Integer = -1

            If txtNombrePiso.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre del piso.")
                Exit Sub
            End If

            If Me.Codigo > 0 Then
                p = (New Piso_BL).Listar(Codigo)
            Else
                p.IDPenal = Me.PenalId
                p.IDRegion = Me.RegionId
                p.PabellonId = Me.PabellonId
            End If

            p.Nombre = txtNombrePiso.Text.Trim.ToUpper
            p.PisoHabilitado = IIf(chkActivo.Checked, True, False)

            id = (New Piso_BL).Grabar(p)

            If id < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo grabar, por favor intentelo nuevamente.")
                Exit Sub
            End If

            Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            Me.DialogResult = DialogResult.OK
            Me.Close()

        End Sub

    End Class
End Namespace