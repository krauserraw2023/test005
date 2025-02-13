Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.TipoDocJudicial

Namespace Registro.AlertaSentencias
    Public Class frmReporteAlerta
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

#Region "Enum"
        Public Enum enmListarReportes As Short
            Ninguno = 0
            Todos = 1
            Interno = 2
        End Enum
#End Region
#Region "Propiedades_Parametricas"
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _InternoApeNom As String = ""
        Public Property _TipoReporte As enmListarReportes = enmListarReportes.Todos
        Public Property _EnabledTipoInterno() As Boolean = False
        Private Property RestriccionCol() As Entity.Reporte.CertificadoLibertad.RestriccionCol
        Private blnCargoShow As Boolean = False
#End Region



#Region "Propiedades"
        Private Property FechaISPString() As String = ""
        Private Property NumeroDocTrasladoStr As String = ""
        Private Property PenalNomOrigenTraslado As String = ""
        Private Property PenalNomDestinoTraslado As String = ""
        Private Property FechaIngresoString() As String = ""

        Private Property RegionID() As Short
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.cbbRegion.Text
            End Get
        End Property
        Private Property PenalID() As Short
            Get
                Dim v As Short = -1
                If Me.cbbPenal.SelectedValue <= 0 Then
                    v = -1
                Else
                    Return Me.cbbPenal.SelectedValue
                End If
                Return v
            End Get
            Set(value As Short)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.cbbPenal.Text
            End Get
        End Property

        Private Property FechaInicio() As Long
            Get

                Return Me.dtpFechaIni.ValueLong

            End Get
            Set(value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFin() As Long
            Get

                Return Me.dtpFechaFin.ValueLong

            End Get
            Set(value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property
#End Region
#Region "Propiedades_Certificado_Reclusion"
        Private Property DocumentoNumero As String = ""
        Private Property FechaEmision As String = ""
        Private Property Observacion As String = ""
#End Region
        Private Property ProcedenciaPenal As String = ""
        Private Property Nota As String = ""
#Region "Combo"
        Private Sub ComboRegion()

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboPenal()

            With Me.cbbPenal
                ._Todos = True
                '._TodosMensaje = "[Seleccionar penal]"
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.RegionID
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarReporte()

            Dim strReporte As String = 89

            Dim objEntFiltro As New Legolas.LEntity.Globall.Reporte
            Dim objEntCol As New Legolas.LEntity.Globall.ReporteCol

            Dim objBss As New Legolas.LBusiness.Globall.Reporte

            With objEntFiltro
                .CodigoMultiple = strReporte
            End With

            objEntCol = objBss.Listar(objEntFiltro)
            If ValidarPenalLicencia() > -1 Then
                For i As Integer = objEntCol.Count - 1 To 0 Step -1
                    If objEntCol.Reporte(i).Codigo = 25 Then 'Or objEntCol.Reporte(i).Codigo = 36 Then'constancia de reclusion
                        objEntCol.RemoveAt(i)
                    End If
                Next
            End If
            For i As Integer = objEntCol.Count - 1 To 0 Step -1
                If objEntCol.Reporte(i).Codigo = 48 And Me._TipoLicencia = enmTipoLicencia.Carceleta Then 'Or objEntCol.Reporte(i).Codigo = 36 Then'constancia de reclusion
                    objEntCol.Reporte(i).Nombre = "Ficha de identificación carceleta"
                End If
            Next


        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            'por region
            If Me.RegionID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Region")
                        Me.cbbRegion.Focus()
                        Return value
                    End If

            'por penal
            'If Me.PenalID < 1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Penal")
            '    Me.cbbPenal.Focus()
            '    Return value
            'End If

            'por fechas inicio
            If Me.FechaInicio < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha")
                Me.dtpFechaIni.Focus()
                Return value
            End If

            'la fecha mayor no puede ser menor a la fecha ini
            'If Me.FechaFin < Me.FechaInicio Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser mayor a la fecha de inicio")
            '   Me.dtpFechaIni.Focus()
            '  Return value
            'End If

            value = True
            Return value

        End Function

        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            FRM_ReporteAlertaSentencia()

        End Sub

#End Region
#Region "Form"
        Private Sub FRM_ReporteAlertaSentencia()
            Dim bss As New Bussines.Registro.DocumentoJudicial
            Dim obj As New Entity.Registro.DocumentoJudicial

            If bss.Listar_DocumentosJudiciales(obj).Count = 0 Then
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con documentos judiciales")
                'Exit Sub
            End If

            Dim opcion As String = ""
            Select Case Me._TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                    Select Case Legolas.Configuration.Usuario.NivelUsuario
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                            opcion = "lst_aler_sent_orl"

                        Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                            'region lima
                            If Me.RegionID = 3 Then
                                If Me.PenalID > 0 Then

                                    Select Case Me.PenalID
                                        Case 26, 30, 46, 49, 53, 54
                                            opcion = "lst_aler_sent_prov"
                                        Case Else
                                            opcion = "lst_aler_sent_lm"
                                    End Select
                                Else
                                    opcion = "lst_aler_sent_orl"
                                End If
                            Else
                                'otras sedes regionales
                                If Me.PenalID > 0 Then
                                    opcion = "lst_aler_sent_prov"
                                Else
                                    opcion = "lst_aler_sent_sedes_regionales"
                                End If
                            End If

                    End Select

                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    opcion = "lst_aler_sent_lm"
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                    opcion = "lst_aler_sent_prov"
                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    opcion = "lst_aler_sent_sedes_regionales"
            End Select

            Dim frm As New APPReporte.Registro.ReporteCrystal_v2
            With frm
                ._ReporteId = Type.Reporte.Registro.rptListaAlertaSentencia
                ._Filtro.Text = Me.Text
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                Me.dtpFechaIni.Value = Now()
                ._Filtro.FechaInicio = dtpFechaIni.ValueLong
                ._Filtro.FechaFinOri = dtpFechaFin.ValueLong
                ._Filtro.Nacionalidad = IIf(rdbPeruanos.Checked = True, 1, IIf(rdbExtranjeros.Checked = True, 2, -1))
                ._LicenciaId = Me._TipoLicencia
                .ReporteOpcion = opcion
                .ShowDialog()
            End With
        End Sub



#End Region
#Region "Otros"

        Private Sub ValoresxDefault()
            ComboRegion()
            ComboPenal()

            'If Me._RegionID > 0 Then
            '    Me.RegionID = Me._RegionID
            'End If
            'If Me._PenalID > 0 Then
            '    Me.PenalID = Me._PenalID
            'End If
            'If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionProvincia Then
            '    cbbRegion.Enabled = False
            '    cbbPenal.SelectedValue = -1
            'End If
            'If Me._TipoLicencia = enmTipoLicencia.PenalProvincia Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
            '    cbbRegion.Enabled = False
            '    cbbPenal.Enabled = False
            'End If

            Dim blnRegionhabilitar As Boolean = False
            Dim blnPenalHabilitar As Boolean = False
            Select Case Me._TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                    Select Case Legolas.Configuration.Usuario.NivelUsuario
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                            Me.RegionID = 3
                            blnPenalHabilitar = True
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede
                            blnRegionhabilitar = True
                            blnPenalHabilitar = True
                    End Select

                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    Me.RegionID = 3
                    Me.PenalID = Me._PenalID
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia

                    Me.RegionID = Me._RegionID
                    Me.PenalID = Me._PenalID

                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    Me.RegionID = Me._RegionID
                    blnPenalHabilitar = True
            End Select

            cbbRegion.Enabled = blnRegionhabilitar
            cbbPenal.Enabled = blnPenalHabilitar

            Me.dtpFechaIni.Value = Now()
            Me.dtpFechaFin.Value = Now()
        End Sub
        Private Function ValidarPenalLicencia() As Integer
            Dim PenalLic As Integer = -1
            PenalLic = Legolas.LBusiness.Globall.WinApp.LicenciaApp
            Select Case PenalLic
                Case 66, 67, 68, 69, 70, 71
                    PenalLic = PenalLic
                Case Else
                    PenalLic = -1
            End Select
            Return PenalLic
        End Function
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AOK()
        End Sub

        Private Sub frmReporteHistorialPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmReportePopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            'ListarReporte()
            Me.RegionID = Me.RegionID
            blnCargoShow = True
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            ComboPenal()

        End Sub


    End Class
End Namespace