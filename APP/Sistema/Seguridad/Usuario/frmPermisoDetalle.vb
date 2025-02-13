Imports System.Linq

Namespace Sistema.Seguridad.Usuario
    Public Class frmPermisoDetalle
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _LicenciaID As Integer = -1
        Public Property _UsuarioDatos As String = ""
#End Region

#Region "Listar"
        Public Sub _Listar()
            If Me._Codigo < 1 Then
                Exit Sub
            End If
            Dim bssDoc As New Bussines.Seguridad.UsuarioNotificacion
            Dim objUsunot As New Entity.Sistema.Seguridad.UsuarioNotificacion
            Dim objCol As New Entity.Sistema.Seguridad.UsuarioNotificacionCol

            Dim objdocCol As New Entity.Sistema.Seguridad.UsuarioNotificacionCol
            With objUsunot
                .Codigo = Me._Codigo
                .CodUsuario = -1
            End With


            objdocCol = bssDoc.Listar(objUsunot)

            For Each obj As Entity.Sistema.Seguridad.UsuarioNotificacion In objdocCol
                With obj
                    txtAccion.Text = obj.Accion
                    txtMotivo.Text = obj.MotivoNombre
                    txtFechahabilitacion.Text = obj.FechaRegistrostr
                    txtFechadeshabilita.Text = obj.FechaInhabilitacionstr
                    txtUsuariohabilita.Text = .UsuarioAuditoriaNombres
                    txtUsuariodeshabilita.Text = .Audit_UsuarioModificacion
                End With
            Next


        End Sub
#End Region


#Region "Otros"


#End Region


        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmPermisoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _Listar()
        End Sub
    End Class
End Namespace
