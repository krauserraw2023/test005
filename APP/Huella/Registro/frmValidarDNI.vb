
Imports System.Windows.Forms
Imports Type.Enumeracion.Licencia
Imports APPWebService

Namespace Huella.Registro
    Public Class frmValidarDNI
        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Private objEntCol As Entity.Registro.NombreAsociadoCol = Nothing
#Region "Propiedades"
        Public Property _InternoID As Integer = -1
        Public Property _TipoDocumento As Integer = -1
        Public Property _NumeroDocumento() As String
            Get
                Return Me.txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumDocumento.Text = value
            End Set
        End Property
        Public Property _NumeroDocumentoUsuario() As String = ""
        Private ObjetoReniec As New APPWebService.ws_reniec_sede.NumeroDocumento
        Private Estado As Integer = -1
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1

        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region

#Region "Accion"
        Private Sub Aceptar()
            If Validar() = True Then
                Dim frm As New Huella.Registro.frmValidarHuella
                frm._NumeroDocumentoUsuario = Me._NumeroDocumentoUsuario
                frm._InternoID = Me._InternoID
                frm._RegionID = Me._RegionID
                frm._PenalID = Me._PenalID
                frm.ObjetoReniec = Me.ObjetoReniec
                frm._Estado = Me.Estado
                If frm.ShowDialog() = DialogResult.OK Then
                End If
                Me.Close()
            End If
        End Sub


        Private Function Validar() As Boolean
            Me.Cursor = Cursors.WaitCursor

            Dim intVal As Integer = BuscarInterno()
            If Me._NumeroDocumento.Length <> 8 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar N° de Documento de 8 digitos")
                txtNumDocumento.Focus()
                Return False
            End If
            If BuscarInternoReniec(Me._NumeroDocumento, intVal) Is Nothing Then
                txtNumDocumento.Focus()
                Return False
            End If
            Me.Cursor = Cursors.Default

            Return True
        End Function
        Private Function BuscarInterno() As Integer
            Dim bss As New Bussines.Registro.Interno_Grilla
            Dim obj As New Entity.Registro.Interno_Grilla
            Dim objCol As New Entity.Registro.InternoCol
            Me._InternoID = -1
            obj.InternoNumeroDocumento = Me._NumeroDocumento
            obj.IDTipoDocIdentidad = 10 'DNI
            obj.IDPenal = Me._PenalID
            objCol = bss.ListarInternoBusqueda(obj)
            If objCol.Count > 0 Then
                Me._InternoID = objCol.Item(0).Codigo
            End If
            Return Me._InternoID
        End Function
        Public Function BuscarInternoReniec(DNI As String, intVal As Integer) As APPWebService.ws_reniec_sede.NumeroDocumento
            Dim bss As New Bussines.Globall.Reniec
            Dim rpt As APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
            Dim mensaje As String =""
            rpt = bss.WS_ReniecxDNI_Resultado(DNI)
            If rpt.Error_Cod < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Codigo error: " & rpt.Error_Cod & ", Mensaje: " & rpt.Error_Mensaje)
                Return Nothing
            End If
            If rpt.Error_Cod = 5114 Then
                If intVal < 1 Then
                    mensaje = "El DNI ingresado no existe en el penal ni en RENIEC"
                Else
                    mensaje = rpt.Error_Mensaje & " o no existe."
                End If
                Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje)
                Return Nothing
            End If
            If rpt.Error_Cod = 5111 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(rpt.Error_Mensaje)
                Return Nothing
            End If
            If rpt.Error_Cod = 0 Then
                If intVal > 0 Then
                    Me.Estado = 1
                ElseIf intVal < 1 Then
                    Me.Estado = 2
                Else
                    Me.Estado = 3
                End If
                Me.ObjetoReniec = rpt.Resultado
            End If
            Return Me.ObjetoReniec
        End Function
#End Region


        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            Aceptar()
        End Sub

        Private Sub frmValidarDNI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim objBss As New Bussines.Seguridad.Usuario
            Dim objEnt As New Entity.Sistema.Seguridad.Usuario

            objEnt = objBss.Listar(Legolas.Configuration.Usuario.Codigo)
            Me._NumeroDocumentoUsuario = objEnt.NumeroDocumento

        End Sub
    End Class

End Namespace