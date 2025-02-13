Imports System.Linq

Namespace Registro.AlertaSentencias
    Public Class frmAlertasSentenciasCabecera
#Region "Propiedades_Parametricas"
        Public _MdiParenAux As MDIParent1
        Public Property _Codigo As Integer = -1
        Public Property _LicenciaID As Integer = -1
        Public Property _TipoLicenciaID As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property _FechaInicio As Long = -1
        Public Property _FechaFin As Long = -1
        Public Property _Variabletiempo As Integer = 30
        Public Property _item As Integer = -1
        Public Property _Fecha() As String
            Get
                Return txtFechaconsulta.Text
            End Get
            Set(ByVal value As String)
                txtFechaconsulta.Text = value
            End Set
        End Property

        Public Property _PenalID As Integer = -1
        Public Property _RegionID As Integer = -1

        Public Hora As String
        Private HoraLocal As String
#End Region

#Region "Listar"
        Public Sub _ListarSentenciasCabecera()
            Dim bss As New Bussines.Registro.AlertaSentenciaCabecera
            Dim obj As New Entity.Registro.AlertaSentenciaCabecera
            Dim objCol As New Entity.Registro.AlertaSentenciaCabeceraCol

            Dim opcion As String = ""
            With obj
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                If Me._TipoLicenciaID = 3 Then
                    ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                End If
                If Me._TipoLicenciaID = 1 Then
                    ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                End If
            End With


            objCol = bss.Listar(obj)

            If objCol.Count > 0 Then
                With objCol.AlertaSentenciaCabecera(0)
                    Me._Codigo = .Codigo
                    txtTitulo.Text = .Titulo
                    txtNumero.Text = .Numero
                    Me._item = .Item
                    txtSenpendientes.Text = .SentenciasPendientes
                    txtSenvencidas.Text = .SentenciasVencidas
                    txtFechaconsulta.Text = .FechaConsulta
                    txtFechafinal.Text = .FechaFinal.ToShortDateString
                    Me._RegionID = ._RegionID
                    Me._PenalID = ._PenalID
                End With
            End If

        End Sub

#End Region


#Region "Otros"
        Private Sub ValoresxDefault()
            'Timer1.Enabled = True
            _ListarSentenciasCabecera()
        End Sub

#End Region

        Private Sub frmExpedientePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            ''Timer1.Enabled = False
            FRM_ModuloAlerta(_Codigo, _RegionID, _PenalID, _Fecha, _item)
        End Sub

        Private Sub FRM_ModuloAlerta(intCodigo As Integer, RegionId As Integer, PenalId As Integer, Fecha As String, Item As Integer)

            '/*abrir el formulario de notificacion*/

            Dim blnLectura As Boolean = True
            Dim blnEscritura As Boolean = True
            Dim blnReporte As Boolean = True
            Dim blnEliminar As Boolean = True

            Dim frm As New Registro.AlertaSentencias.frmAlertaSentenciaDetalle

            With frm
                ._Codigo = intCodigo
                ._TipoLicenciaID = IIf(Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.Sede, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Me._TipoLicenciaID)
                ._LicenciaID = Me._LicenciaID
                ._Fecha = Fecha
                ._Item = Item
                ._RegionId = RegionId
                If ._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana _
                   Or ._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia Then
                    ._PenalID = -1
                Else
                    ._PenalID = PenalId
                End If
                ._FormLectura = blnLectura
                ._FormEscritura = blnEscritura
                ._FormReporte = blnReporte
                ._FormEliminar = blnEliminar
                .MdiParent = Me._MdiParenAux
                Me.Close()
                .Show()
            End With

        End Sub
    End Class

End Namespace
