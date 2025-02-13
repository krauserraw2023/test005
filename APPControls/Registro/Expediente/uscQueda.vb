Option Explicit On
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.SubTipoDocJudicial
Imports Type.Enumeracion
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.Movimiento
Imports System.Data
Imports System.Windows.Media
Imports Microsoft.Office.Interop.Word
Imports System.Windows.Controls
Imports APPControls.Registro.Expediente
Imports Microsoft.ReportingServices.Diagnostics.Internal

Public Class uscQueda
    Public Event _Click_chkQueda()


    Private i As Integer = 1
    Private MensajeError As String
    Private Temp_obs As String


    Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre = Nothing
    '/*entitys*/
    Private objBssExpediente As Bussines.Registro.Expediente = Nothing
    Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
    Private objEntDelito As Entity.Registro.Delito = Nothing
    Private objEntAgraviado As Entity.Registro.Agraviado = Nothing
    Private objBssExp As Bussines.Registro.Expediente
    Private objBssDoc As Bussines.Registro.DocumentoJudicial
    Private bssMov As Bussines.Registro.InternoMovimiento


    Private objBss As Bussines.Registro.Expediente = Nothing
    Private objBssPad As Bussines.Registro.InternoExpedientePadre = Nothing
    Private objEnt As Entity.Registro.Expediente = Nothing
    Private objEntExpediente As Entity.Registro.Expediente
    Private objBssDelito As Bussines.Registro.Delito = Nothing
    Public objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
    Public objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
    Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
    Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
    Private objEntPeriodoCondenaTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
    Private objEntDelitoCol As Entity.Registro.DelitoCol
    Private objEntAgraviadoCol As Entity.Registro.AgraviadoCol
    Private entExpColAcum As Entity.Registro.ExpedienteCol

    Private objEntDelito_copy As Entity.Registro.Delito

    Private objEnt_Q As New Entity.Registro.DocumentoJudicial
    Private objBss_Q As New Bussines.Registro.DocumentoJudicial
    Private blnCondicionLib As Boolean = False
    Private blnValorDel As Boolean = False
    Private blnValorExp As Boolean = False
    Private fechaejecucionMov As String

    Dim ExpedienteTemporalCol As New Entity.Registro.ExpedienteCol
    Dim objEntExpedienteCol2 As New Entity.Registro.ExpedienteCol

    Public EntMovimiento As New Entity.Registro.InternoMovimiento
    Public entMov As Entity.Registro.InternoMovimiento
    Public _EstablecimientomentalId As Integer = -1
    Public Property _SubTipo As Integer = -1

    Public Property _fechaejecucionMov() As String
        Get
            Return fechaejecucionMov
        End Get
        Set(value As String)
            fechaejecucionMov = value
            If fechaejecucionMov = Nothing Then
                grp01.Enabled = True
            Else
                If fechaejecucionMov.Trim.Length > 0 Then
                    grp01.Enabled = False
                Else
                    grp01.Enabled = True
                End If
            End If
        End Set
    End Property



#Region "Propiedades_Parametricas"
    Public Property _Codigo As Integer = -1
    Public Property TipoAutoridadJudicial As Integer = -1
    Public Property _DocumentoTipo As Integer = -1
    Public Property SalaJuzgado As Integer = -1
    Public Property _DocumentoJudicialID As Integer = -1
    Public Property _DocumentoJudicialExpedienteID As Integer = -1
    Public Property _RegionID() As Integer = -1
    Public Property _PenalID() As Integer = -1
    Public Property _InternoIngresoInpeId() As Integer = -1
    Public Property _IngresoID As Integer = -1
    Public Property _InternoID As Integer = -1
    Public Property _Documentos_sin_mov As Boolean = False
    Public Property _TemporalNuevo As Boolean = False
    Public Property _NuevoExpediente As Boolean = False
    Public Property _SituacionJuridicaExpe As Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
    Public Property _TipoResolucion As Integer = -1
    Public Property _FechaRecep As Long = 0
    Public Property _FechaMovimiento As Long = 0

    Private Property blnEliminarColection As Boolean = False
    Private Property blnEliminarDelitoColec As Boolean = False
    Private Property blnEliminarAgraviadoColec As Boolean = False
    Private Property intCodigoExpediente As Integer = -1
    Private Property intCodigoDelito As Integer = -1
    Private Property Nuevo As Boolean = False
    Private Property blnAccionEditar As Boolean = False
    Private Property blnAccionEliminar As Boolean = False
    Public Property _VisibleControlExpediente As Boolean = False

    Public Property _Cantidad_queda As Integer = 0

    Private AgraviadosIndcCol As New Entity.Registro.AgraviadoCol
    Private AgraviadosIndcCol2 As New Entity.Registro.AgraviadoCol
    Private AgraviadosIndcCol3 As New Entity.Registro.AgraviadoCol
    Private AgraviadosIndc As New Entity.Registro.Agraviado
    Private DelitoIndcCol As New Entity.Registro.DelitoCol
    Private DelitoIndcCol2 As New Entity.Registro.DelitoCol
    Private DelitoIndc As New Entity.Registro.Delito
    Private ExpedienteIndc As New Entity.Registro.ExpedienteCol
    Private objEntExpediente_copi As Entity.Registro.Expediente

    Dim intPadre As Integer = -1


    Public ReadOnly Property _EntExpediente() As Entity.Registro.Expediente
        Get
            Dim tmp As Entity.Registro.Expediente
            Try
                tmp = objEntExpedienteTempoCol_Queda.Item(dgwExpediente_queda.CurrentCell.RowIndex)
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
            End Try
            Return tmp
        End Get
    End Property
    Public ReadOnly Property _chkqueda_si() As Boolean
        Get
            Return Me.chk_queda_si.Checked
        End Get
    End Property
    Public ReadOnly Property _chkqueda_no() As Boolean
        Get
            Return Me.chk_queda_no.Checked
        End Get
    End Property
    Public ReadOnly Property _GrillaExpedienteIdSeleccionado() As Integer
        Get

            Return Me.GrillaExpedienteID

        End Get
    End Property
    Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
    Private ReadOnly Property FlagTransferSede As Integer
        Get
            Dim v As Integer = 0
            If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                v = 1
            End If
            Return v
        End Get
    End Property



#End Region
#Region "Propiedades_Grilla"
    Public ReadOnly Property _GrillaExpedienteID() As Integer
        Get
            Return Me.GrillaExpedienteID
        End Get
    End Property
    Public ReadOnly Property _GrillaDelitoID() As Integer
        Get
            Return Me.GrillaDelitoID
        End Get
    End Property
    Public ReadOnly Property _GrillaAgraviadoID() As Integer
        Get

            Return Me.GrillaAgraviadoID

        End Get
    End Property

    Private ReadOnly Property GrillaExpedienteID() As Integer
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("codigo").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Private ReadOnly Property GrillaDocJudicialID() As Integer
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_doc_jdu_id").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property

    Public ReadOnly Property GrillaReferenciado() As Boolean
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_exp_ref_val").Value
            Catch ex As Exception
                Return False
            End Try
        End Get
    End Property
    Private ReadOnly Property GrillaDelitoID() As Integer
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwDelito_queda
                    intValue = .SelectedRows(0).Cells("col_int_del_id").Value

                    If intValue = -1 Then intValue = 0
                End With
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
            End Try
            Return intValue
        End Get
    End Property
    Private ReadOnly Property GrillaDelitoDodJudID() As Integer
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwDelito_queda
                    intValue = .SelectedRows(0).Cells("col_doc_jud_id").Value

                    If intValue = -1 Then intValue = 0
                End With
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
            End Try
            Return intValue
        End Get
    End Property
    Private ReadOnly Property GrillaAgraviadoID() As Integer
        Get
            Dim value As Integer = -1
            Try
                With Me.dgwAgraviados_queda
                    value = .SelectedRows(0).Cells("col_agr_id").Value
                End With
            Catch ex As Exception
                Return -1
            End Try
            Return value
        End Get
    End Property

    Public ReadOnly Property _GrillaItemExpediente() As Integer
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_item").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _GrillaItemDelito() As Integer
        Get
            Try
                Return dgwDelito_queda.SelectedRows(0).Cells("col_del_item").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _GrillaItemAgraviado() As Integer
        Get
            Try
                Return dgwAgraviados_queda.SelectedRows(0).Cells("col_agr_item").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _Grilla_NroRegistroExpediente As Integer
        Get
            Try
                Return dgwExpediente_queda.Rows.Count
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _Grilla_NroRegistroDelito As Integer
        Get
            Try
                Return dgwDelito_queda.Rows.Count
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _Grilla_NroRegistroAgraviado As Integer
        Get
            Try
                Return dgwAgraviados_queda.Rows.Count
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _GrillaSalaJudicialID() As Integer
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_sal_jud_id").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _GrillaDelitoEspecificoID() As Integer
        Get
            Try
                Return dgwDelito_queda.SelectedRows(0).Cells("col_del_esp_id").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _GrillaLibertadTipoID() As Integer
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_tip_lib_id").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public ReadOnly Property _GrillaMotivoQuedaID() As Integer
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_mot_que_id").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Private ReadOnly Property grillaIdCentroSalud As Short
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_est_men_id").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Private ReadOnly Property grillaIdTipoInimputable As Short
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_tip_exp_inim").Value
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Private ReadOnly Property grillaCentroSaludMentalNombre As String
        Get
            Try
                Return dgwExpediente_queda.SelectedRows(0).Cells("col_est_men_des").Value
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property
    Private ReadOnly Property GrillaDelitoSelect() As Entity.Registro.Delito
        Get
            objEntDelito = New Entity.Registro.Delito

            For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                If Me._GrillaItemDelito = objDel.DelitoItem Then
                    objEntDelito = objDel
                    Exit For
                End If
            Next

            Return objEntDelito

        End Get
    End Property
    Private ReadOnly Property GrillaExpedienteSelect() As Entity.Registro.Expediente
        Get
            objEntExpediente = New Entity.Registro.Expediente

            For Each objExp As Entity.Registro.Expediente In objEntExpedienteTempoCol_Queda
                If Me._GrillaItemExpediente = objExp.ExpedienteItem Then
                    objEntExpediente = objExp '
                    Exit For
                End If
            Next

            Return objEntExpediente

        End Get
    End Property
    Private ReadOnly Property GrillaDelitoIndex() As Integer
        Get
            Dim value As Integer = -1

            For i As Integer = 0 To objEntDelitoTempoCol.Count - 1
                If Me.GrillaExpedienteID = objEntDelitoTempoCol.Delito(i).ExpedienteID Then
                    If Me._GrillaItemDelito = objEntDelitoTempoCol.Delito(i).DelitoItem Then
                        value = i
                        Exit For
                    End If
                End If
            Next
            Return value
        End Get
    End Property

#End Region

    Public grabarMovimientoLibertad As Boolean = False

#Region "Variables_Temporales"
    Public objEntExpedienteTempoCol_Queda As Entity.Registro.ExpedienteCol = Nothing
    Public objEntExpedienteTempoCol_QuedaCopi As Entity.Registro.ExpedienteCol = Nothing
    Public objEntExpedienteTempoCol_QuedaCopi2 As New Entity.Registro.ExpedienteCol
    Private objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol = Nothing
    Public objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing
    Private objEntExpedienteCol As Entity.Registro.ExpedienteCol = Nothing

#End Region
#Region "Propiedades_Publicas"
    Private blnVisibleGrabar As Boolean = False
    Public Property _VisibleGrabar() As Boolean
        Get
            Return blnVisibleGrabar
        End Get
        Set(ByVal value As Boolean)
            blnVisibleGrabar = value
            '   |ShowControl()
        End Set
    End Property
    Public Property _GrillaSeleccionMultiple As Boolean = True
    Public Event _Click_EnviarColection(EntExpCol As Entity.Registro.ExpedienteCol)
#End Region
#Region "Propiedades_Expediente"
    Public Property _TipoAutJudicial() As Integer = -1
    Public Property DocJudicialID As Integer = -1
#End Region


    Public Sub _LoadUsc()
        If _Codigo = -1 Then

        End If
        ValoresxDefault()
    End Sub
    Private Sub ValoresxDefault()
        Me.lbOtrosProcesos.Items.Clear()
        dgwExpediente_queda.ReadOnly = True
        Select Case Me._DocumentoTipo
            Case 26

        End Select
        Listar()
    End Sub
    'Private Sub Listar()
    '    If Me._Codigo < 1 Then
    '        Exit Sub
    '    End If
    '    objEnt_Q = New Entity.Registro.DocumentoJudicial
    '    objBss_Q = New Bussines.Registro.DocumentoJudicial
    '    objEnt_Q.Codigo = Me._Codigo
    '    objEnt_Q = objBss_Q.Listar_v2(objEnt_Q)
    '    With objEnt_Q
    '        Me._Codigo = .Codigo
    '        Me._DocumentoTipo = .DocumentoTipo
    '        Me.TipoAutoridadJudicial = .TipoAutoridadJudicial

    '        If (.Observacion_Queda).Length > 0 Then
    '            Dim cadena() As String = (.Observacion_Queda).Split("$")
    '            For Each var As String In cadena
    '                lbOtrosProcesos.Items.Add(var)
    '            Next
    '        End If

    '        If .Proceso_Pendiente_Queda = -1 Then
    '            Me.chk_queda_si.Checked = False
    '            Me.chk_queda_no.Checked = False
    '            Me.chk_queda_si.Enabled = False
    '            Me.chk_queda_no.Enabled = False
    '        Else
    '            If .Proceso_Pendiente_Queda = 1 Then
    '                Me.chk_queda_si.Checked = True
    '                Me.chk_queda_no.Checked = False
    '                'Me.txtobs_queda.Text = .Observacion_Queda
    '            Else
    '                Me.chk_queda_si.Checked = False
    '                Me.chk_queda_no.Checked = True
    '            End If
    '        End If
    '    End With
    'End Sub
    Public Sub InhabilitarRadioButon(EstadoMov As Integer)
        chk_queda_si.Enabled = IIf(EstadoMov = Type.Enumeracion.Movimiento.enmEstadoMovimiento.Terminado, False, True)
    End Sub
    Private Sub fn_OcultarColumnas()
        If Me._SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
            dgwExpediente_queda.Columns("col_num").Visible = False
        Else
            dgwExpediente_queda.Columns("col_num").ReadOnly = True
        End If
        If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
            With dgwExpediente_queda
                .Columns("col_tip_lib").Visible = True
                .Columns("col_exp_btn").Visible = True
            End With
        ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda Then
            With dgwExpediente_queda
                .Columns("col_mot_que").Visible = True
                .Columns("col_exp_btn").Visible = True
            End With
        End If
    End Sub
    Public Sub _ListarExpediente_Queda(DocumentoJudicialID As Integer, Optional ByVal CargarMandDetencionHistorico As Boolean = True,
                                     Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)
        Try
            If DocumentoJudicialID = -1 Then Exit Sub
            objEntExpedienteTempoCol_Queda = (New Bussines.Registro.Expediente).ListarGrillaPopup_Queda_Modif(DocumentoJudicialID, Me._InternoID, Me._IngresoID, Me._InternoIngresoInpeId)
            If IsNothing(objEntExpedienteTempoCol_Queda) = False Then
                If IsNothing(objEntExpedienteTempoCol_Queda.Item(0)) = False Then
                    _Cantidad_queda = objEntExpedienteTempoCol_Queda.Count()
                Else
                    _Cantidad_queda = 0
                End If
            Else
                _Cantidad_queda = 0
            End If

            dgwExpediente_queda.Columns("colu_eleg").Visible = False
            With dgwExpediente_queda
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntExpedienteTempoCol_Queda
            End With
        Catch ex As Exception
            MensajeError = "No determinado."
            MensajeError = ("Error #" & i.ToString() & vbCrLf _
                        & "Mensaje: " & ex.Message & ControlChars.NewLine _
                        & "Fuente: " & ex.Source & ControlChars.NewLine _
                        & "Recomendación: Volver a ejecutar el Proceso.")
            ' MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")
        Finally

        End Try
    End Sub

    Public Function Validar_Queda() As Boolean
        Dim blnValue As Boolean = False
        If Me.chk_queda_si.Checked = False And Me.chk_queda_no.Checked = False Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("Por favor, seleccionar una opción del Queda.")
            ' Me.chk_queda_si.Focus()
            'Me.chk_queda_si.Select()
            Return blnValue
        End If
        If Me.chk_queda_si.Checked = True Then
            If dgwExpediente_queda.Rows.Count = 0 And lbOtrosProcesos.Items.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar el proceso vigente")
                btnAgregar.Focus()
                Return False
            End If
            'If Me.txtobs_queda.Text.Trim.Length < 1 Then
            'Legolas.Configuration.Aplication.MessageBox.Exclamation("Es obligatorio ingresar observación.")
            'Me.txtobs_queda.Focus()
            'Me.txtobs_queda.Select()
            'MsgBox("Por favor, requiere ingresar observación.", 64, "Sistema Internos Penitenciario")
            'Return False
            'End If
        Else
            blnValue = True
            Return blnValue
        End If
        Return True
    End Function

    Public Function GrabarQueda(Exp_Jud_id As Integer)
        Try
            Dim eopcion As Integer
            Dim objEntQ As Entity.Registro.DocumentoJudicial
            Dim objBssQ As Bussines.Registro.DocumentoJudicial


            objBssQ = New Bussines.Registro.DocumentoJudicial
            objEntQ = New Entity.Registro.DocumentoJudicial
            objEntExpediente = New Entity.Registro.Expediente
            If chk_queda_si.Checked = True Then
                eopcion = 1
            Else
                eopcion = 0
            End If
            With objEntQ
                .Codigo = Me._Codigo
                .InternoId = Me._InternoID
                .IngresoNro = Me._IngresoID
                .InternoIngresoId = Me._InternoIngresoInpeId
                .DocumentoTipo = 26
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .Proceso_Pendiente_Queda = eopcion
                Dim pos As Integer = 0
                For Each var As String In lbOtrosProcesos.Items()
                    pos += 1
                    If pos = 1 Then
                        .Observacion_Queda = var
                    Else
                        .Observacion_Queda = .Observacion_Queda & "$" & var
                    End If
                Next
                ' .Observacion_Queda = Me.txtobs_queda.Text
            End With
            objBssQ.GrabarQuedaJud(objEntQ)
            objBss = New Bussines.Registro.Expediente
            'objBss.EliminarQuedaExp(Exp_Jud_id)
            objBss.GrabarQuedaExp(Me.objEntExpedienteTempoCol_Queda, Exp_Jud_id)

        Catch ex As Exception
            MensajeError = "No determinado."
            MensajeError = ("Error #" & i.ToString() & vbCrLf _
                        & "Mensaje: " & ex.Message & ControlChars.NewLine _
                        & "Fuente: " & ex.Source & ControlChars.NewLine _
                        & "Recomendación: Volver a ejecutar el Proceso.")
            'MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")
        Finally

        End Try
    End Function

    '__DocJudicialId As Integer, Optional ByVal CargarMandDetencionHistorico As Boolean = True, Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False
    Public Sub _ListarExpediente_Queda(objEnt_Exp_Lib_sel As Entity.Registro.ExpedienteCol)
        Try
            Select Case Me._TipoResolucion

                Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia, enumTipoDocumentoJudicial.Sumatoria_de_Sentencia,
                 enumTipoDocumentoJudicial.AcumulacionExpedientes, enumTipoDocumentoJudicial.Revocatoria_de_Libertad,
                  enumTipoDocumentoJudicial.Queda,
                 enumTipoDocumentoJudicial.Anulacion_Antecedentes
                    dgwExpediente_queda.Columns("colu_eleg").HeaderText = ""
                Case Else
                    dgwExpediente_queda.Columns("colu_eleg").Visible = False
            End Select
            Select Case Me._TipoResolucion
                Case enumTipoDocumentoJudicial.Libertad, enumTipoDocumentoJudicial.Revocatoria_de_Libertad, enumTipoDocumentoJudicial.Queda,
                  enumTipoDocumentoJudicial.Anulacion_Antecedentes, enumTipoDocumentoJudicial.Notas,
                  enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                  enumTipoDocumentoJudicial.Retorno_de_HospitalMental
                    Me._SituacionJuridicaExpe = -1
            End Select
            objEntExpedienteTempoCol_Queda = New Entity.Registro.ExpedienteCol
            objEntExpediente = New Entity.Registro.Expediente
            With objEntExpediente
                .IngresoInpeId = Me._InternoIngresoInpeId
                .IngresoID = Me._IngresoID
                .InternoID = Me._InternoID
                .SituacionJuridicaID = Me._SituacionJuridicaExpe
                '---Listar todos los expedientes
                If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad Or Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then
                    .Anulacion = enmEstadoAnulado.Anulado_parcial
                    .DocumentoTipoID = enumTipoDocumentoJudicial.Libertad
                    Select Case Me._TipoLicencia

                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana

                            objEntExpedienteTempoCol_Queda = (New Bussines.Registro.Expediente).ListarGrillaPopup_LM_Queda(objEntExpediente, objEnt_Exp_Lib_sel)
                            If IsNothing(objEntExpedienteTempoCol_Queda) = False Then
                                If IsNothing(objEntExpedienteTempoCol_Queda.Item(0)) = False Then
                                    _Cantidad_queda = objEntExpedienteTempoCol_Queda.Count()
                                Else
                                    _Cantidad_queda = 0
                                End If
                            Else
                                _Cantidad_queda = 0
                            End If

                        Case Else
                            objEntExpedienteTempoCol_Queda = (New Bussines.Registro.Expediente).ListarGrillaPopup_Queda(objEntExpediente, objEnt_Exp_Lib_sel)
                            If IsNothing(objEntExpedienteTempoCol_Queda) = False Then
                                If IsNothing(objEntExpedienteTempoCol_Queda.Item(0)) = False Then
                                    _Cantidad_queda = objEntExpedienteTempoCol_Queda.Count()
                                Else
                                    _Cantidad_queda = 0
                                End If
                            Else
                                _Cantidad_queda = 0
                            End If

                    End Select
                    If _Cantidad_queda > 0 Then
                        RaiseEvent _Click_chkQueda()
                    End If
                End If
            End With
            If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad Or
           Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then
                Dim objEntExpedienteTempoCol_Queda_Cop As New Entity.Registro.ExpedienteCol
                For Each EntLib As Entity.Registro.Expediente In objEntExpedienteTempoCol_Queda
                    If EntLib.LibertadTipoID > 0 Then
                        If EntLib.FechaLibertad > 0 Then
                        Else
                            objEntExpedienteTempoCol_Queda_Cop.Add(EntLib)
                        End If
                    Else
                        objEntExpedienteTempoCol_Queda_Cop.Add(EntLib)
                    End If
                Next
                objEntExpedienteTempoCol_Queda = New Entity.Registro.ExpedienteCol
                objEntExpedienteTempoCol_Queda = objEntExpedienteTempoCol_Queda_Cop
            End If

            If objEntExpedienteTempoCol_Queda Is Nothing Or objEntExpedienteTempoCol_Queda.Count = 0 Then
                Me._NuevoExpediente = True
                lblNroExpedientes.Text = "# Expedientes 0 Reg."
            Else
                With dgwExpediente_queda
                    .DataSource = Nothing
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = objEntExpedienteTempoCol_Queda
                End With
            End If

        Catch ex As Exception
            MensajeError = "No determinado."
            MensajeError = ("Error #" & i.ToString() & vbCrLf _
                        & "Mensaje: " & ex.Message & ControlChars.NewLine _
                        & "Fuente: " & ex.Source & ControlChars.NewLine _
                        & "Recomendación: Volver a ejecutar el Proceso.")
            MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")
        Finally

        End Try
    End Sub

    Private Sub Listar()
        If Me._Codigo < 1 Then
            Exit Sub
        End If
        objEnt_Q = New Entity.Registro.DocumentoJudicial
        objBss_Q = New Bussines.Registro.DocumentoJudicial
        objEnt_Q.Codigo = Me._Codigo
        objEnt_Q = objBss_Q.Listar_v2(objEnt_Q)
        With objEnt_Q
            Me._Codigo = .Codigo
            Me._DocumentoTipo = .DocumentoTipo
            Me.TipoAutoridadJudicial = .TipoAutoridadJudicial

            If (.Observacion_Queda).Length > 0 Then
                Dim cadena() As String = (.Observacion_Queda).Split("$")
                For Each var As String In cadena
                    lbOtrosProcesos.Items.Add(var)
                Next
            End If

            If .Proceso_Pendiente_Queda = -1 Then
                Me.chk_queda_si.Checked = False
                Me.chk_queda_no.Checked = False
                Me.chk_queda_si.Enabled = False
                Me.chk_queda_no.Enabled = False
            Else
                If .Proceso_Pendiente_Queda = 1 Then
                    Me.chk_queda_si.Checked = True
                    Me.chk_queda_no.Checked = False
                    'Me.txtobs_queda.Text = .Observacion_Queda
                Else
                    Me.chk_queda_si.Checked = False
                    Me.chk_queda_no.Checked = True
                End If
            End If
        End With
    End Sub

    Private Sub Temporal_ListarExpediente()
        Try
            With Me.dgwExpediente_queda
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = IIf(objEntExpedienteTempoCol_Queda Is Nothing, Nothing, objEntExpedienteTempoCol_Queda)
                .Refresh()
                lblNroExpedientes.Text = "# Expedientes " & .Rows.Count & " Reg."
            End With

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Temporal_ListarDelitos_Queda()
        Try
            With Me.dgwDelito_queda
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = IIf(objEntDelitoTempoCol Is Nothing, Nothing, objEntDelitoTempoCol)
                ' lblNrodelitos.Text = "Delito(s) " & .Rows.Count & " Reg."
            End With
        Catch ex As Exception
            MensajeError = "No determinado."
            MensajeError = ("Error #" & i.ToString() & vbCrLf _
                        & "Mensaje: " & ex.Message & ControlChars.NewLine _
                        & "Fuente: " & ex.Source & ControlChars.NewLine _
                        & "Recomendación: Volver a ejecutar el Proceso.")
            MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")

        Finally

        End Try
    End Sub
    Private Sub Temporal_ListarAgraviados_Queda()
        Try
            With Me.dgwAgraviados_queda
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = IIf(objEntAgraviadoTempoCol Is Nothing, Nothing, objEntAgraviadoTempoCol)
                'Me.lblNroAgraviados.Text = "Agraviado(s) " & .Rows.Count & " Reg."
                .Refresh()
            End With
        Catch ex As Exception
            MensajeError = "No determinado."
            MensajeError = ("Error #" & i.ToString() & vbCrLf _
                        & "Mensaje: " & ex.Message & ControlChars.NewLine _
                        & "Fuente: " & ex.Source & ControlChars.NewLine _
                        & "Recomendación: Volver a ejecutar el Proceso.")
            MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")
        Finally

        End Try
    End Sub
    Public Sub Temporal_EliminarExpediente_Delito_Agraviado()
        Try
            If IsNothing(objEntExpedienteTempoCol_Queda) = False Then
                If IsNothing(objEntExpedienteTempoCol_Queda.Item(0)) = False Then
                    For i As Integer = objEntExpedienteTempoCol_Queda.Count - 1 To 0 Step -1
                        If Me._GrillaItemExpediente = objEntExpedienteTempoCol_Queda.Item(i).ExpedienteItem Then
                            objEntExpedienteTempoCol_Queda.Remove(i)
                        End If
                    Next
                Else
                    objEntExpedienteTempoCol_Queda = Nothing
                End If
                'objEntExpedienteTempoCol_Queda = (New Bussines.Registro.Expediente).ListarGrillaPopup_Queda(objEntExpediente, objEntExpedienteTempoCol_Queda)
            Else
                objEntExpedienteTempoCol_Queda = Nothing
            End If

            If IsNothing(objEntDelitoTempoCol) = False Then
                If IsNothing(objEntDelitoTempoCol.Item(0)) = False Then
                    For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                        If Me._GrillaItemDelito = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                            objEntDelitoTempoCol.Remove(i)
                        End If
                    Next
                Else
                    objEntDelitoTempoCol = Nothing
                End If
            Else
                objEntDelitoTempoCol = Nothing
            End If

            If IsNothing(objEntAgraviadoTempoCol) = False Then
                If IsNothing(objEntAgraviadoTempoCol.Item(0)) = False Then
                    For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                        If Me._GrillaItemAgraviado = objEntAgraviadoTempoCol.Item(i).ExpedienteItem Then
                            objEntAgraviadoTempoCol.Remove(i)
                        End If
                    Next
                Else
                    objEntAgraviadoTempoCol = Nothing
                End If
            Else
                objEntAgraviadoTempoCol = Nothing
            End If
            Temporal_ListarExpediente()
            Temporal_ListarDelitos_Queda()
            Temporal_ListarAgraviados_Queda()
            'objEntDelito = (New Bussines.Registro.Delito).Listar_Delito_Queda(-1500, -1500, -1500)
            'objEntDelitoTempoCol = (New Bussines.Registro.Delito).Listar_Delito_Queda_Col(-1500, -1500, -1500)
            'objEntDelitoTempoColGrilla = objEntDelitoTempoCol

            'objEntAgraviado = (New Bussines.Registro.InternoAgraviado).Listar_Agraviado_Queda(-1500, -1500, -1500, -1500)
            'objEntAgraviadoTempoCol = (New Bussines.Registro.InternoAgraviado).Listar2(objEntExpediente)  'Listar_ant(objEntAgraviado)
            'Me.objEntAgraviadoTempoColGrilla = objEntAgraviadoTempoCol

        Catch ex As Exception
            MensajeError = "No determinado."
            MensajeError = ("Error #" & i.ToString() & vbCrLf _
                        & "Mensaje: " & ex.Message & ControlChars.NewLine _
                        & "Fuente: " & ex.Source & ControlChars.NewLine _
                        & "Recomendación: Volver a ejecutar el Proceso.")
            MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")
        Finally

        End Try
    End Sub
    Public Sub MostrarControlesButton()
        chk_queda_si.Checked = False
        chk_queda_no.Checked = False
    End Sub
    Public Function OtrosProcesos() As Integer
        Return lbOtrosProcesos.Items.Count()
    End Function

    Public Function AGrabar(objDoc As Entity.Registro.DocumentoJudicial) As Integer
        Dim Value As Integer = -1
        objEnt_Q = New Entity.Registro.DocumentoJudicial
        objBss_Q = New Bussines.Registro.DocumentoJudicial
        Try
            With objEnt_Q

                .Codigo = Me._Codigo
                .DocumentoTipo = Me._DocumentoTipo
                .DocumentoNumero = ""          'Me.DocumentoNumero
                .DocumentoFechaRecepcion = 0   'Me.DocumentoFechaRecepcion
                .DocumentoFecha = 0            'Me.DocumentoFecha
                .TipoAutoridadJudicial = Me.TipoAutoridadJudicial

                If Me.TipoAutoridadJudicial = 0 Then 'EnumTipoAutoridad.AutoridadJudicial Then
                    .DistritoJudicial = 1      'Me.DistritoJudicial
                    If Me.SalaJuzgado > 0 Then
                        .SalaJuzgado = -1      'Me.SalaJuzgado
                    Else
                        .SalaJuzgado = -1
                    End If
                    .JuezNombre = ""           'Me.JuezNombre
                    .SecretarioNombre = ""     'Me.SecretarioNombre
                    .AutoridadOtroNombre = ""
                    .AutoridadOtroCargo = ""
                Else
                    .DistritoJudicial = -1
                    .SalaJuzgado = -1
                    .JuezNombre = ""
                    .SecretarioNombre = ""
                    .AutoridadOtroNombre = ""  'Me.AutoridadOtroNombre
                    .AutoridadOtroCargo = ""   'Me.AutoridadOtroCargo
                End If
                If Me.chk_queda_si.Checked = True Then
                    .NumFolio = 1              'Si Queda  Me.NumFolio
                Else
                    .NumFolio = 0              'No Queda
                End If
                .NumLibro = ""                 'Me.NumLibro
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._IngresoID                     'Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .SituacionJuridicaId = Me._SituacionJuridicaExpe     'Me.SituacionJuridicaId
                .Observacion = Me.txtobs_queda.Text
                .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                Select Case Me._DocumentoTipo
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion,
                           Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Prision_Preventiva,
                           Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Adecuacion_Prision_Preventiva
                        .ProlonDetencionFechFin = objDoc.ProlonDetencionFechFin
                        .ProlonDetencionFechIni = objDoc.ProlonDetencionFechIni
                        .ProlonDetencionTipoUnidad = objDoc.ProlonDetencionTipoUnidad
                        .ProlonDetencionValor = objDoc.ProlonDetencionValor
                        'Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                        '    .FechaMovimiento = Me.FechaMovimiento
                        'Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                        '      Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental
                        '    .FechaInscipcion = Me.FechaMovimiento
                End Select
                .FechaMovimiento = 0       'Me.FechaMovimiento
                .FechaInscripcion = 0      'Me.FechaInscripcion
                .DocumentoSubTipoId = -1   'Me._DocSubTipoID
                .FlagTransferenciaSede = 0 'Me.FlagTransferSede
                .MovimientoMotivoId = -1   'objDoc.MovimientoMotivoId
                ' .EstadoEjecucionId = Me.idEstadoTraslado
                .SentenciaTotalAnios = 0   'objDoc.SentenciaTotalAnios
                .SentenciaTotalMeses = 0   'objDoc.SentenciaTotalMeses
                .SentenciaTotalDias = 0    'objDoc.SentenciaTotalDias
                .SentenciaCadenaPerpetua = objDoc.SentenciaCadenaPerpetua
                .PenalDestinoOtroNom = ""  'objDoc.PenalDestinoOtroNom
                .PenalOtroOrigenNom = ""   'objDoc.PenalOtroOrigenNom
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
            End With

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                Value = objBss_Q.Grabar_LM(objEnt_Q)
            Else
                Value = objBss_Q.Grabar2(objEnt_Q)
            End If
        Catch ex As Exception
            MensajeError = "No determinado."
            MensajeError = ("Error #" & i.ToString() & vbCrLf _
                        & "Mensaje: " & ex.Message & ControlChars.NewLine _
                        & "Fuente: " & ex.Source & ControlChars.NewLine _
                        & "Recomendación: Volver a ejecutar el Proceso.")
            MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")
        Finally

        End Try
        Return Value
    End Function
    Public Sub _Grabar(DocumentoJudicialID As Integer, Nuevo As Boolean, Optional TipoLibertadID As Short = -1, Optional TipoDocumento As Short = -1)
        EliminarExpedienteBD()
        Select Case Me._TipoLicencia
            Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                AGrabar_LM(DocumentoJudicialID, Nuevo, TipoLibertadID, TipoDocumento)
            Case Else
                AGrabar(DocumentoJudicialID, Nuevo, TipoLibertadID, TipoDocumento)
        End Select
    End Sub

    Public Sub EliminarExpedienteBD()
        If blnEliminarColection = True Then
            If ValidarEliminar(ExpedienteIndc.Expediente(0).Codigo) = True Then
                For Each EntAgr As Entity.Registro.Agraviado In AgraviadosIndcCol
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In DelitoIndcCol
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
                For Each EntExp As Entity.Registro.Expediente In ExpedienteIndc
                    AEliminarExpedienteBD(EntExp.Codigo)
                Next
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                objEntExpedienteCol2 = New Entity.Registro.ExpedienteCol
            End If
        End If
        If blnEliminarDelitoColec = True Then
            For Each EntAgr As Entity.Registro.Agraviado In AgraviadosIndcCol2
                AEliminarAgraviadoBD(EntAgr.Codigo)
            Next
            For Each EntDel As Entity.Registro.Delito In DelitoIndcCol2
                AEliminarDelitoBD(EntDel.Codigo)
            Next
        End If
        If blnEliminarAgraviadoColec = True Then
            For Each EntAgr As Entity.Registro.Agraviado In AgraviadosIndcCol3
                AEliminarAgraviadoBD(EntAgr.Codigo)
            Next
        End If
    End Sub
    Private Function ValidarEliminar(Codigo As Integer) As Boolean
        For Each EntVal As Entity.Registro.Expediente In objEntExpedienteTempoCol_Queda
            If Codigo = EntVal.Codigo Then
                Return False
                Exit For
            End If
        Next
        Return True
    End Function
    Private Function AEliminarAgraviadoBD(Codigo As Integer) As Integer

        Dim value As Integer = -1
        If Codigo > 0 Then
            objBssAgraviado = New Bussines.Registro.InternoAgraviado
            value = objBssAgraviado.Eliminar(Codigo, Me.FlagTransferSede)
        End If
        Return value

    End Function
    Private Function AEliminarAgraviadoBD2(Codigo As Integer) As Integer

        Dim value As Integer = -1
        If Codigo > 0 Then
            objBssAgraviado = New Bussines.Registro.InternoAgraviado
            value = objBssAgraviado.Eliminar(Codigo, Me.FlagTransferSede)
        End If
        Return value

    End Function

    Private Function AEliminarDelitoBD(Codigo As Integer) As Integer
        Dim value As Integer = -1
        If Codigo > 0 Then
            objBssDelito = New Bussines.Registro.Delito
            value = objBssDelito.Eliminar2(Codigo, Me.FlagTransferSede)
        End If
        Return value
    End Function
    Private Function AEliminarExpedienteBD(Codigo As Integer) As Integer

        Dim value As Integer = -1
        If Codigo > 0 Then
            Dim CodExpedienteHij As Integer = -1
            Dim entPad As New Entity.Registro.InternoExpedientePadre
            objBssExpediente = New Bussines.Registro.Expediente

            If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad Or Me._TipoResolucion = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
                      Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then
                'objBssExpediente.GrabarEstadoVisibilidad(Codigo, False, Me.FlagTransferSede)
                entPad.InternoID = Me._InternoID
                entPad.InternoExpedienteId = Codigo
                CodExpedienteHij = objBssExpedientePad.Listar(entPad).InternoExpedienteRefPadreId
            ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                entPad.InternoID = Me._InternoID
                entPad.InternoExpedienteId = Codigo
                CodExpedienteHij = objBssExpedientePad.Listar(entPad).InternoExpedienteRefPadreId
            End If
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    value = objBssExpediente.Eliminar_LM(Codigo, Me.FlagTransferSede)
                Case Else
                    value = objBssExpediente.Eliminar2(Codigo, Me.FlagTransferSede)
            End Select
            If value > 0 Then
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad Or Me._TipoResolucion = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
                      Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then

                    Dim ObjPad As New Entity.Registro.InternoExpedientePadre
                    ObjPad.InternoExpedienteId = Codigo
                    ObjPad.InternoID = Me._InternoID
                    ObjPad.IngresoInpeId = Me._InternoIngresoInpeId
                    intPadre = objBssExpedientePad.Listar_LM(ObjPad).Codigo
                    objBssExpedientePad.Eliminar(intPadre, Me.FlagTransferSede)

                    objBssExpediente.GrabarEstadoVisibilidad_LM(CodExpedienteHij, 1, Me.FlagTransferSede)
                    '------------------------------------------------------------
                    Dim objExpPadre As New Entity.Registro.InternoExpedientePadre
                    Dim objExpPadreCol As New Entity.Registro.InternoExpedientePadreCol
                    objExpPadre.InternoExpedienteId = value
                    If objExpPadre.InternoID > 0 Then
                        Select Case Me._TipoLicencia
                            Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                objExpPadreCol = objBssExpedientePad.ListarGrilla_LM(objExpPadre)
                            Case Else
                                objExpPadreCol = objBssExpedientePad.ListarGrilla(objExpPadre)
                        End Select
                        For Each obj As Entity.Registro.InternoExpedientePadre In objExpPadreCol
                            objBssExpediente.GrabarEstadoVisibilidad(obj.InternoExpedienteRefPadreId, True, Me.FlagTransferSede)
                        Next
                    End If
                ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                    value = objBssExpediente.Eliminar2(CodExpedienteHij, Me.FlagTransferSede)
                    Dim bssDel As New Bussines.Registro.Delito
                    Dim bssAgr As New Bussines.Registro.InternoAgraviado
                    Dim entDelCol As New Entity.Registro.DelitoCol
                    Dim entDel As New Entity.Registro.Delito

                    entDel.InternoID = Me._InternoID
                    entDel.ExpedienteID = CodExpedienteHij
                    entDelCol = bssDel.Listar2(entDel)
                    For Each objD As Entity.Registro.Delito In entDelCol
                        bssDel.Eliminar2(objD.Codigo, Me.FlagTransferSede)

                        Dim entAgrCol As New Entity.Registro.AgraviadoCol
                        Dim entAgr As New Entity.Registro.Agraviado

                        entAgr.InternoID = Me._InternoID
                        entAgr.DelitoID = objD.Codigo
                        entAgrCol = bssAgr.Listar(entAgr)
                        For Each objA As Entity.Registro.Agraviado In entAgrCol
                            bssAgr.Eliminar(objA.Codigo, Me.FlagTransferSede)
                        Next
                    Next
                Else
                    objBssExpedientePad.Eliminar(intPadre, Me.FlagTransferSede)
                    objBssExpediente.GrabarEstadoVisibilidad(intPadre, False, Me.FlagTransferSede)
                End If
            End If
        End If
        Return value

    End Function

    Private Sub AGrabar_LM(DocumentoJudicialID As Integer, Nuevo As Boolean, Optional TipoLibertadID As Short = -1, Optional TipoDocumento As Short = -1)

        objBssDoc = New Bussines.Registro.DocumentoJudicial
        objBssExp = New Bussines.Registro.Expediente
        objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
        objBssDelito = New Bussines.Registro.Delito
        objBssAgraviado = New Bussines.Registro.InternoAgraviado
        bssMov = New Bussines.Registro.InternoMovimiento

        'Recorrer expedientes y grabar
        If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
            ' GrabarAvocamiento_LM(DocumentoJudicialID, Nuevo)
        Else

            grabarBDPeriodoCondena(DocumentoJudicialID, objEntPeriodoCondenaTempoCol)

            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol_Queda
                Dim ExpedienteOrigId As Integer = objExpediente.Codigo
                Dim DocumentoOrigId As Integer = objExpediente.CreaDocJudicialId
                Dim intIdExpe As Integer = -1
                With objExpediente
                    If Nuevo = True Then
                        With objExpediente
                            If objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                Dim entExpCol As New Entity.Registro.ExpedienteCol
                                entExpCol = objBssExp.ListarExpedientexResolucion_LM(objExpediente.CreaDocJudicialId)
                                For Each objExp As Entity.Registro.Expediente In entExpCol
                                    objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, Me.FlagTransferSede)
                                Next
                            Else
                                If .Codigo > 0 Then objBssExp.GrabarEstadoVisibilidad(.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                            End If
                            .Codigo = -1
                            .ExpedienteVisible = 1
                        End With
                    Else
                        If ExpedienteOrigId > 0 And DocumentoOrigId <> DocumentoJudicialID Then
                            If objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                                objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                                objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                Dim entExpCol As New Entity.Registro.ExpedienteCol
                                entExpCol = objBssExp.ListarExpedientexResolucion_LM(objExpediente.CreaDocJudicialId)
                                For Each objExp As Entity.Registro.Expediente In entExpCol
                                    objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, FlagTransferSede)
                                Next
                                .Codigo = -1
                            Else
                                objBssExp.GrabarEstadoVisibilidad(.Codigo, False, FlagTransferSede)
                                .Codigo = -1
                            End If
                            objExpediente.ExpedienteVisible = 1
                        Else
                            If objExpediente.Codigo < 1 Then
                                objExpediente.ExpedienteVisible = 1
                            End If
                        End If
                    End If
                    If TipoDocumento = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Then
                        objExpediente.LibertadTipoID = -1
                    End If
                    .InternoID = Me._InternoID
                    .IngresoID = Me._IngresoID  'reseteamos el numero ingreso del nuevo objeto expe al num ing actual
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .CreaDocJudicialId = DocumentoJudicialID
                    objExpediente.FlagTransferenciaSede = Me.FlagTransferSede
                End With
                intIdExpe = objBssExp.Grabar_LM(objExpediente)
                '----------------------Padre------------------------------------
                If intIdExpe > 0 Then
                    Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                    With objIntExpPad
                        .InternoID = Me._InternoID
                        .IngresoID = -1 'Me._InternoIngresoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .DocJudicialID = DocumentoJudicialID
                        .InternoExpedienteId = intIdExpe
                        .InternoExpedienteRefPadreId = ExpedienteOrigId
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        ._RegionId = Me._RegionID
                        ._PenalId = Me._PenalID
                    End With
                    '---------------ExpedientePadre------------------------------
                    If Nuevo = True Then
                        If objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                           objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                           objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                            Dim entExpColPad As New Entity.Registro.ExpedienteCol
                            entExpColPad = objBssExp.ListarExpedientexResolucion_LM(ExpedienteOrigId)
                            For Each objExp As Entity.Registro.Expediente In entExpColPad
                                For Each obj As Entity.Registro.Expediente In entExpColAcum
                                    If objExp.Codigo = obj.Codigo Then
                                        objBssExp.GrabarEstadoVisibilidad(obj.Codigo, False, Me.FlagTransferSede)
                                        objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                                        objBssExpedientePad.Grabar_LM(objIntExpPad)
                                    End If

                                Next
                            Next
                        Else
                            If ExpedienteOrigId > 0 Then
                                objBssExpedientePad.Grabar_LM(objIntExpPad) 'guardar en BD
                            End If
                        End If
                    Else
                        If ExpedienteOrigId < 1 Or (ExpedienteOrigId > 0 And DocumentoOrigId <> DocumentoJudicialID) Then
                            If objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                Dim entExpColPad As New Entity.Registro.ExpedienteCol
                                entExpColPad = objBssExp.ListarExpedientexResolucion_LM(ExpedienteOrigId)
                                For Each objExp As Entity.Registro.Expediente In entExpColPad
                                    objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, Me.FlagTransferSede)
                                    objIntExpPad.InternoExpedienteRefPadreId = objExp.Codigo
                                    objBssExpedientePad.Grabar_LM(objIntExpPad)
                                Next
                            Else
                                objIntExpPad.InternoExpedienteId = intIdExpe
                                objIntExpPad.InternoExpedienteRefPadreId = ExpedienteOrigId
                                objBssExpedientePad.Grabar_LM(objIntExpPad)
                            End If
                        End If
                    End If
                End If

                Dim intIdDel As Integer = -1
                Dim intIdAgrav As Integer = -1
                '----------------------Registrar delitos-------------------------

                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    Dim codigoDelitoOri As Integer = objDel.Codigo
                    Dim creaDelitoOri As Integer = objDel.CreaDocJudicialId
                    If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                        If Nuevo = True Then
                            objDel.Codigo = -1
                        Else
                            If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then
                                objDel.Codigo = -1
                            End If
                        End If
                        objDel.ExpedienteID = intIdExpe  'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocumentoJudicialID
                        objDel.InternoID = Me._InternoID
                        objDel.IngresoID = -1 'Me._InternoIngresoID
                        objDel.IngresoInpeId = Me._InternoIngresoInpeId
                        objDel.FlagTransferenciaSede = Me.FlagTransferSede
                        objDel.RegionID = Me._RegionID
                        objDel.PenalID = Me._PenalID

                        If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then objDel.CodigodelitoPad = codigoDelitoOri

                        intIdDel = objBssDelito.Grabar_LM(objDel)

                        For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                            Dim codigoAgraviadoOri As Integer = obj.Codigo
                            Dim creaAgraviadoOri As Integer = obj.CreaDocJudicialId

                            If objDel.DelitoItem = obj.DelitoItem Then
                                If Nuevo = True Then
                                    obj.Codigo = -1
                                Else
                                    If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                        obj.Codigo = -1
                                    End If
                                End If
                                obj.DelitoID = intIdDel
                                obj.CreaDocJudicialId = DocumentoJudicialID
                                obj.ExpedienteID = intIdExpe
                                obj.InternoID = Me._InternoID
                                obj.IngresoID = -1 'Me._InternoIngresoID
                                obj.IngresoInpeId = Me._InternoIngresoInpeId
                                obj.FlagTransferenciaSede = Me.FlagTransferSede
                                obj.RegionID = Me._RegionID
                                obj.PenalID = Me._PenalID

                                If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then obj.CodigoagraviadoPad = codigoAgraviadoOri

                                intIdAgrav = objBssAgraviado.Grabar_LM(obj)
                            End If
                        Next
                    End If
                Next
                objExpediente.Codigo = intIdExpe
            Next
        End If
        If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad And Me._Documentos_sin_mov = False Then
            If Me.grabarMovimientoLibertad = True Then
                Dim EntMov As New Entity.Registro.InternoMovimiento
                With EntMovimiento
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .InternoID = Me._InternoID
                    .IngresoID = Me._IngresoID
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso
                    .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    .EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                    EntMov = bssMov.Listar_LM(EntMovimiento)
                    If EntMov.Codigo > 0 Then
                        .Fecha = EntMov.Fecha
                        .MovimientoMotivoID = EntMov.MovimientoMotivoID
                        .Observacion = EntMov.Observacion
                        EntMovimiento.Codigo = EntMov.Codigo
                    End If
                    .DocumJudicialID = DocumentoJudicialID
                    '------------------
                    Dim entDocJud As New Entity.Registro.DocumentoJudicial
                    entDocJud.Codigo = DocumentoJudicialID
                    entDocJud = objBssDoc.Listar_v2(entDocJud)
                    .DocumJudicialNum = entDocJud.DocumentoNumero
                    .DocumJudicialFecha = entDocJud.DocumentoFecha
                    .DocumJudicialFecharecepcion = entDocJud.DocumentoFechaRecepcion
                    .TipoAutoridadJudicialID = entDocJud.TipoAutoridadJudicial
                    .AutoridadJudicialID = entDocJud.DistritoJudicial
                    .SalaJudicialID = entDocJud.SalaJuzgado
                    .DocJudJuez = entDocJud.JuezNombre
                    .DocJudSecretario = entDocJud.SecretarioNombre
                    .RegionOrigenID = Me._RegionID
                    .PenalOrigenID = Me._PenalID
                    .RegionDestinoID = entDocJud.RegionDestinoId
                    .PenalDestinoID = entDocJud.PenalDestinoid
                End With
                bssMov.Grabar_LM(EntMovimiento)
            End If
        ElseIf Me._TipoResolucion = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
           Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then
            If blnCondicionLib = True Then
                entMov = New Entity.Registro.InternoMovimiento
                entMov.InternoID = Me._InternoID
                entMov.IngresoID = Me._IngresoID
                entMov.IngresoInpeId = Me._InternoIngresoInpeId
                entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                entMov = bssMov.Listar(entMov)
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("pendienteh") 'pendientehnrb analizar
                bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
            End If
        Else
            If blnCondicionLib = True Then
                entMov = New Entity.Registro.InternoMovimiento
                With entMov
                    .InternoID = Me._InternoID
                    .IngresoID = Me._IngresoID
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                End With
                entMov = bssMov.Listar(entMov)
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("pendienteh") 'pendientehnrb analizar
                bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
            End If
        End If
    End Sub
    Private Sub grabarBDPeriodoCondena(idDocumentoJudicial As Integer, objListaPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentenciaCol)

        If objEntPeriodoCondenaTempoCol Is Nothing Then
            Exit Sub
        End If

        Dim objBssPerCon As New Bussines.Registro.Documento.PeriodoCondenaSentencia
        For Each entPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
            With entPerCond
                .DocJudicialId = idDocumentoJudicial
                .InternoId = Me._InternoID
                .IngresoId = Me._IngresoID
                .IngresoInpeId = Me._InternoIngresoInpeId
                .FlagTransferenciaSede = Me.FlagTransferSede
            End With

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then

                If entPerCond.FlgEliminado = True Then
                    If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                Else
                    objBssPerCon.Grabar_LM(entPerCond)
                End If

            Else
                If entPerCond.FlgEliminado = True Then
                    If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                Else
                    objBssPerCon.Grabar(entPerCond)
                End If
            End If
        Next

    End Sub





    Private Sub AGrabar(DocumentoJudicialID As Integer, Nuevo As Boolean, Optional TipoLibertadID As Short = -1, Optional TipoDocumento As Short = -1)
        objBssExp = New Bussines.Registro.Expediente
        objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
        Dim intIdExped As Integer = -1
        'Recorrer expedientes y grabar
        If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
            'GrabarAvocamiento(DocumentoJudicialID, Nuevo)
        Else

            grabarBDPeriodoCondena(DocumentoJudicialID, objEntPeriodoCondenaTempoCol)

            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol_Queda
                Dim CodExpedienteOrig As Integer = objExpediente.Codigo
                Dim CodDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                Dim CodDocumentoTipoOrig As Integer = objExpediente.DocumentoTipoID
                intIdExped = -1
                With objExpediente
                    If Nuevo = True Then
                        If .DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                           .DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                           .DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then

                            Dim entExpCol As New Entity.Registro.ExpedienteCol
                            entExpCol = objBssExp.ListarExpedientexResolucion(objExpediente.CreaDocJudicialId)
                            For Each objExp As Entity.Registro.Expediente In entExpCol
                                objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, Me.FlagTransferSede)
                            Next
                        Else
                            If objExpediente.Codigo > 0 Then objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                        End If
                        .Codigo = -1
                    Else
                        If CodExpedienteOrig > 0 And CodDocumentoOrig <> DocumentoJudicialID Then
                            If .DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                                                                       .DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                                  .DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                Dim entExpCol As New Entity.Registro.ExpedienteCol
                                entExpCol = objBssExp.ListarExpedientexResolucion(objExpediente.CreaDocJudicialId)
                                For Each objExp As Entity.Registro.Expediente In entExpCol
                                    objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, FlagTransferSede)
                                Next
                            Else
                                objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, FlagTransferSede)
                            End If
                            .Codigo = -1
                        End If
                    End If
                    '-----Datos del Expediente
                    .ExpedienteVisible = 1
                    .IngresoID = Me._IngresoID  'reseteamos el numero ingreso del nuevo objeto expe al num ing actual
                    .CreaDocJudicialId = DocumentoJudicialID
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    If TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
                       TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                        .LibertadTipoID = -1
                    End If
                End With
                intIdExped = objBssExp.Grabar(objExpediente)

                '----------------------Padre------------------------------------
                If intIdExped > 0 Then
                    Dim objExpedientePad As New Entity.Registro.InternoExpedientePadre
                    With objExpedientePad
                        .InternoID = Me._InternoID
                        .IngresoID = Me._IngresoID
                        .DocJudicialID = DocumentoJudicialID
                        .InternoExpedienteId = intIdExped
                        .InternoExpedienteRefPadreId = CodExpedienteOrig
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        ._RegionId = Me._RegionID
                        ._PenalId = Me._PenalID
                    End With
                    '<---------------ExpedientePadre------------------------------
                    With objExpediente
                        If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                           .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                           .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                           CodDocumentoTipoOrig = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                           CodDocumentoTipoOrig = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                           CodDocumentoTipoOrig = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then

                            If (Nuevo = True And CodExpedienteOrig > 0) Or
                                (Nuevo = False And (CodExpedienteOrig < 1 Or (CodExpedienteOrig > 0 And CodDocumentoOrig <> DocumentoJudicialID))) Then
                                Dim entExpCol As New Entity.Registro.ExpedienteCol
                                entExpCol = objBssExp.ListarExpedientexResolucion(CodDocumentoOrig)
                                For Each objExp As Entity.Registro.Expediente In entExpCol
                                    objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, FlagTransferSede)
                                    objExpedientePad.InternoExpedienteRefPadreId = objExp.Codigo
                                    objBssExpedientePad.Grabar(objExpedientePad)
                                Next
                            End If
                        Else
                            If (Nuevo = True And CodExpedienteOrig > 0) Or
                               (Nuevo = False And (CodExpedienteOrig < 1 Or (CodExpedienteOrig > 0 And CodDocumentoOrig <> DocumentoJudicialID))) Then
                                objBssExpedientePad.Grabar(objExpedientePad) 'guardar en BD
                            End If
                        End If
                    End With
                End If

                Dim intIdDel As Integer = -1
                Dim intIdAgrav As Integer = -1
                '----------------------Registrar delitos-------------------------
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                        objBssDelito = New Bussines.Registro.Delito
                        Dim codigoDelitoOri As Integer = objDel.Codigo
                        Dim creaDelitoOri As Integer = objDel.CreaDocJudicialId
                        If Nuevo = True Then
                            objDel.Codigo = -1
                        Else
                            If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then
                                objDel.Codigo = -1
                            End If
                        End If
                        objDel.ExpedienteID = intIdExped  'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocumentoJudicialID
                        objDel.InternoID = Me._InternoID
                        objDel.IngresoID = Me._IngresoID
                        objDel.FlagTransferenciaSede = Me.FlagTransferSede
                        objDel.RegionID = Me._RegionID
                        objDel.PenalID = Me._PenalID
                        If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then
                            objDel.CodigodelitoPad = codigoDelitoOri
                        End If
                        intIdDel = objBssDelito.Grabar_v2(objDel)

                        For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                            If objDel.DelitoItem = obj.DelitoItem Then
                                Dim codigoAgraviadoOri As Integer = obj.Codigo
                                Dim creaAgraviadoOri As Integer = obj.CreaDocJudicialId
                                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                                If Nuevo = True Then
                                    obj.Codigo = -1
                                Else
                                    If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                        obj.Codigo = -1
                                    End If
                                End If
                                obj.DelitoID = intIdDel
                                obj.CreaDocJudicialId = DocumentoJudicialID
                                obj.ExpedienteID = intIdExped
                                obj.InternoID = Me._InternoID
                                obj.IngresoID = Me._IngresoID
                                obj.FlagTransferenciaSede = Me.FlagTransferSede
                                obj.RegionID = Me._RegionID
                                obj.PenalID = Me._PenalID
                                If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                    obj.CodigoagraviadoPad = codigoAgraviadoOri
                                End If
                                intIdAgrav = objBssAgraviado.Grabar(obj)
                            End If
                        Next
                    End If
                Next
                objExpediente.Codigo = intIdExped
            Next
        End If
        If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad And Me._Documentos_sin_mov = False Then
            If Me.grabarMovimientoLibertad = True Then
                Dim bssMovimiento As New Bussines.Registro.InternoMovimiento
                Dim EntMov As New Entity.Registro.InternoMovimiento
                With EntMovimiento
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .InternoID = Me._InternoID
                    .IngresoID = Me._IngresoID
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso
                    .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    .EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                    EntMov = bssMovimiento.Listar(EntMovimiento)
                    ' If EntMov.Codigo > 0 Then
                    .Fecha = Me._FechaMovimiento
                    .MovimientoMotivoID = objEntExpedienteTempoCol_Queda.Item(0).LibertadTipoID ' EntMov.MovimientoMotivoID
                    .Observacion = EntMov.Observacion
                    EntMovimiento.Codigo = EntMov.Codigo
                    'End If
                    .DocumJudicialID = DocumentoJudicialID
                    '------------------
                    objBssDoc = New Bussines.Registro.DocumentoJudicial
                    Dim entDocJud As New Entity.Registro.DocumentoJudicial
                    entDocJud.Codigo = DocumentoJudicialID
                    entDocJud = objBssDoc.Listar_v2(entDocJud)
                    .DocumJudicialNum = entDocJud.DocumentoNumero
                    .DocumJudicialFecha = entDocJud.DocumentoFecha
                    .DocumJudicialFecharecepcion = entDocJud.DocumentoFechaRecepcion
                    .TipoAutoridadJudicialID = entDocJud.TipoAutoridadJudicial
                    .AutoridadJudicialID = entDocJud.DistritoJudicial
                    .SalaJudicialID = entDocJud.SalaJuzgado
                    .DocJudJuez = entDocJud.JuezNombre
                    .DocJudSecretario = entDocJud.SecretarioNombre
                    .RegionOrigenID = Me._RegionID
                    .PenalOrigenID = Me._PenalID
                    .RegionDestinoID = entDocJud.RegionDestinoId
                    .PenalDestinoID = entDocJud.PenalDestinoid
                End With
                bssMovimiento.Grabar(EntMovimiento)
            Else
                Dim objExp As New Entity.Registro.Expediente
                objExp.Codigo = intIdExped
                objBssExp.UpdateDmpSmp(objExp)
            End If
        ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
           Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda Then
            If blnCondicionLib = True Then
                bssMov = New Bussines.Registro.InternoMovimiento
                entMov = New Entity.Registro.InternoMovimiento
                entMov.InternoID = Me._InternoID
                entMov.IngresoID = Me._IngresoID
                entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                entMov = bssMov.Listar(entMov)
                bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
            End If
        Else
            If blnCondicionLib = True Then
                bssMov = New Bussines.Registro.InternoMovimiento
                entMov = New Entity.Registro.InternoMovimiento
                entMov.InternoID = Me._InternoID
                entMov.IngresoID = Me._IngresoID
                entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                entMov = bssMov.Listar(entMov)
                bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
            End If
        End If
    End Sub


    '**********************AGRAVIADOS Y DELITOS*************************************************

    Public Sub _Temporal_Grabar_Expediente_Delito_Agraviado(objEnt As Entity.Registro.ExpedienteCol, objEntDel As Entity.Registro.DelitoCol, objEntAgr As Entity.Registro.AgraviadoCol)
        Dim strMensaje As String = ""
        If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria Or
           Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio Or
           Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Or
           Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion Then
            Select Case Me._TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                    strMensaje = "Aclaratoria"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                    strMensaje = "Ampliacion_Autoapertorio"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                    'ExpAvocamientoAux = objEnt.Expediente(0)
                    strMensaje = "Avocamiento"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion
                    strMensaje = "Prolongacion_Detencion"
            End Select
            'If dgwExpediente.Rows.Count = 0 Then
            '    If objEnt.Count = 1 Then
            '        'Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)
            '    Else
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & ", solo puede cargar un expediente.")
            '        objEnt = Nothing
            '        objEntDel = Nothing
            '        objEntAgr = Nothing
            '        Exit Sub
            '    End If
            'Else
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & ", ya posee un expediente.")
            '    objEnt = Nothing
            '    objEntDel = Nothing
            '    objEntAgr = Nothing
            '    Exit Sub
            'End If
        Else
            Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)
            blnAccionEditar = True
        End If

        If Me._DocumentoJudicialID > 0 Then
            objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
            objEntPerCon.DocJudicialId = Me._DocumentoJudicialID
            objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)

            For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1 'indexar cada expediente
                objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
            Next

        End If

    End Sub

    Private Sub Temporal_Grabar_Expediente_Delito_Agraviado(objEntExpedienteCol As Entity.Registro.ExpedienteCol, objEntDelitoCol As Entity.Registro.DelitoCol,
                                                        objEntAgraviadoCol As Entity.Registro.AgraviadoCol)
        entExpColAcum = New Entity.Registro.ExpedienteCol


        For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
            Dim ItemExpediente As Integer = 0
            objEntExpediente._RegionId = Me._RegionID
            objEntExpediente._PenalId = Me._PenalID
            Dim entDelitoCol_cop As New Entity.Registro.DelitoCol
            'grabar expedientes
            If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                                 objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then
                objEntExpediente.Codigo = objEntExpediente.CreaDocJudicialId
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                If Nuevo = True Then
                    objEntExpediente.LibertadTipoID = -1
                End If
            End If
            ItemExpediente = Temporal_GrabarExpediente(objEntExpediente)
            If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
               objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                                  objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then
                Dim objEntExpedienteCol2 As New Entity.Registro.ExpedienteCol
                objBssExp = New Bussines.Registro.Expediente
                objEntExpedienteCol2 = objBssExp.ListarExpedientexResolucion(objEntExpediente.CreaDocJudicialId)
                For Each objEnt2 As Entity.Registro.Expediente In objEntExpedienteCol2
                    entExpColAcum.Add(objEnt2)
                    For Each objDelito As Entity.Registro.Delito In objEntDelitoCol
                        Dim ItemDelito As Integer = -1
                        If objEnt2.Codigo = objDelito.ExpedienteID And objDelito.CreaDocJudicialId = objEntExpediente.Codigo Then
                            objDelito.ExpedienteItem = ItemExpediente
                            objDelito.ExpedienteID = objEntExpediente.CreaDocJudicialId
                            objDelito.CreaDocJudicialId = objEntExpediente.CreaDocJudicialId

                            ItemDelito = Temporal_GrabarDelito_Int(objEnt2, objDelito, Nothing)
                            For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol

                                If objDelito.Codigo = objAgraviado.DelitoID And objAgraviado.AgraviadoItem < 1 Then
                                    objAgraviado.ExpedienteID = objEntExpediente.CreaDocJudicialId
                                    objAgraviado.ExpedienteItem = ItemExpediente  ' objDelito.ExpedienteItem  'Me._GrillaItemExpediente  'objEntExpediente.ExpedienteItem
                                    objAgraviado.DelitoItem = ItemDelito
                                    'grabar agraviados
                                    objAgraviado.CreaDocJudicialId = objEntExpediente.CreaDocJudicialId
                                    Temporal_GrabarAgraviado_Int(objDelito, objAgraviado)
                                End If
                            Next
                        End If
                    Next
                Next
            Else
                For Each objDelito As Entity.Registro.Delito In objEntDelitoCol
                    If objEntExpediente.Codigo = objDelito.ExpedienteID Then

                        objDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
                        'grabar delitos
                        Temporal_GrabarDelito(objEntExpediente, objDelito, Nothing)
                        For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            If objDelito.Codigo = objAgraviado.DelitoID Then
                                objAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                                objAgraviado.DelitoItem = objDelito.DelitoItem
                                'grabar agraviados de forma Temporal
                                Temporal_GrabarAgraviado(objDelito, objAgraviado)

                            End If
                        Next
                    End If
                Next
            End If
        Next

        Temporal_ListarExpediente()
        Temporal_ListarDelitos(Nothing)
        Temporal_ListarAgraviados()

    End Sub


    Private Function Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente) As Integer
        If objEnt.LibertadTipoID = 0 Then objEnt.LibertadTipoID = -1

        mostrarDatosInimputables(objEnt.MotivoIngresoID)

        If objEnt.Codigo > 0 Then
            'si es un registro de base de datos
            If objEnt.ExpedienteItem > 0 Then
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol_Queda
                    If obj.Codigo = objEnt.Codigo Then
                        Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                objEntExpediente = New Entity.Registro.Expediente
                objEnt._RegionId = Me._RegionID
                objEnt._PenalId = Me._PenalID
                objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol_Queda) + 1
                objEntExpedienteTempoCol_Queda.Add(objEnt)
            End If
        Else
            'si el temporal ya existe 
            If objEnt.ExpedienteItem > 0 Then
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol_Queda
                    If obj.ExpedienteItem = objEnt.ExpedienteItem Then
                        Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'si el temporal es nuevo
                objEntExpediente = New Entity.Registro.Expediente
                objEnt._RegionId = Me._RegionID
                objEnt._PenalId = Me._PenalID
                objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol_Queda) + 1
                objEntExpedienteTempoCol_Queda.Add(objEnt)
            End If
        End If

        Temporal_ListarExpediente()
        Return objEnt.ExpedienteItem
    End Function
    Private Sub Temporal_GrabarExpediente2(objEnt As Entity.Registro.Expediente)
        If objEnt.Codigo > 0 Then
            'si es un registro de base de datos
            If objEnt.ExpedienteItem > 0 Then
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol_Queda
                    If obj.Codigo = objEnt.Codigo Then
                        Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                objEntExpediente = New Entity.Registro.Expediente
                objEnt._RegionId = Me._RegionID
                objEnt._PenalId = Me._PenalID
                objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol_Queda) + 1
                objEntExpedienteTempoCol_Queda.Add(objEnt)
            End If
        Else
            'si el temporal ya existe 
            If objEnt.ExpedienteItem > 0 Then
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol_Queda
                    If obj.ExpedienteItem = objEnt.ExpedienteItem Then
                        Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'si el temporal es nuevo
                objEntExpediente = New Entity.Registro.Expediente
                objEnt._RegionId = Me._RegionID
                objEnt._PenalId = Me._PenalID
                objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol_Queda) + 1
                objEntExpedienteTempoCol_Queda.Add(objEnt)
            End If
        End If
        Temporal_ListarExpediente2()
    End Sub

    Private Function Temporal_GrabarDelito_Int(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito,
                                   objEntAgraviadoCol As Entity.Registro.AgraviadoCol) As Integer

        If objEntDelito.Codigo > 0 Then
            'si el delito viene de la bd 
            If objEntDelito.DelitoItem > 0 Then
                'actualiza agraviados
                '
                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                    If obj.Codigo = objEntDelito.Codigo Then
                        Temporal_DelitoCopiarPropiedades(obj, objEntDelito)
                        Exit For
                    End If
                Next
            Else

                objEntDelito.ExpedienteItem = objEntDelito.ExpedienteItem
                objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                objEntDelitoTempoCol.Add(objEntDelito)
            End If
        Else
            'si el temporal ya existe 
            If objEntDelito.DelitoItem > 0 Then
                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                    If obj.DelitoItem = objEntDelito.DelitoItem Then
                        Temporal_DelitoCopiarPropiedades(obj, objEntDelito)
                        Exit For
                    End If
                Next

            Else
                'si el temporal es nuevo
                ' objEntDelito = New Entity.Registro.Delito
                objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                objEntDelitoTempoCol.Add(objEntDelito)

            End If
        End If

        dgwExpediente_queda_CellClick(Nothing, Nothing)

        Return objEntDelito.DelitoItem

    End Function

    Private Sub Temporal_GrabarAgraviado_Int(objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)

        If objEnt.Codigo > 0 Then
            'si el registro esta en la base de datos
            If objEnt.AgraviadoItem > 0 Then
                'For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                '    If obj.Codigo = objEnt.Codigo Then
                '        Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                '        Exit For
                '    End If
                'Next
            Else
                objEnt.DelitoItem = objEnt.DelitoItem
                objEnt.ExpedienteItem = objEnt.ExpedienteItem ' Me._GrillaItemExpediente '  objEntDelito.ExpedienteItem
                objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                objEntAgraviadoTempoCol.Add(objEnt)
            End If
        Else
            'si el temporal ya existe ''''''''''''''''''''''EL ULTIMO ELIMINA REVISAR
            If objEnt.AgraviadoItem > 0 Then
                For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If obj.AgraviadoItem = objEnt.AgraviadoItem Then
                        Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'si el temporal es nuevo
                'objEntAgraviado = New Entity.Registro.Agraviado

                objEnt.DelitoItem = objEntDelito.DelitoItem
                objEnt.ExpedienteItem = Me._GrillaItemExpediente
                objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                objEntAgraviadoTempoCol.Add(objEnt)

            End If

        End If


    End Sub

    Public Sub _Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntAgraviadoCol As Entity.Registro.AgraviadoCol, objAgr_Ind As Entity.Registro.AgraviadoCol)
        EliminarAgraviado_desde_Delito(objAgr_Ind)
        Temporal_GrabarDelito(objEntExpediente, objEntDelito, objEntAgraviadoCol)
    End Sub
    Private Sub Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito,
                                   objEntAgraviadoCol As Entity.Registro.AgraviadoCol)
        'objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
        'objEntDelitoTempoCol = New Entity.Registro.DelitoCol

        If objEntDelito.Codigo > 0 Then
            'si el delito viene de la bd 
            If objEntDelito.DelitoItem > 0 Then
                'actualiza agraviados
                For Each obj As Entity.Registro.Delito In objEntDelitoTempoColGrilla
                    If obj.Codigo = objEntDelito.Codigo Then
                        Temporal_DelitoCopiarPropiedades(obj, objEntDelito)
                        Exit For
                    End If
                Next
            Else
                objEntDelito.ExpedienteItem = objEntExpediente.ExpedienteItem ' objEntDelito.ExpedienteItem
                objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                objEntDelitoTempoCol.Add(objEntDelito)
            End If
            If objEntAgraviadoCol Is Nothing Then
                'nada
            Else
                For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                    Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                Next
            End If
        Else
            'si el temporal ya existe 
            If objEntDelito.DelitoItem > 0 Then

                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                    If obj.DelitoItem = objEntDelito.DelitoItem Then
                        Temporal_DelitoCopiarPropiedades(obj, objEntDelito)
                        Exit For
                    End If
                Next

                'actualiza agraviados
                For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                    Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                Next

            Else
                'si el temporal es nuevo
                objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                objEntDelitoTempoCol.Add(objEntDelito)
                'actualiza agraviados
                If objEntAgraviadoCol Is Nothing = False Then
                    For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                        Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                    Next
                End If
            End If
        End If
        If Me._TipoResolucion = enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Or
           (Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionReferenciado And Me._VisibleControlExpediente = False) Then
            Temporal_ListarDelitos2()
        Else
            If Me._TipoResolucion = enumTipoDocumentoJudicial.Avocamiento Then
                Temporal_ListarDelitos(objEntExpediente)
            Else
                'objEntExpediente_copi = New Entity.Registro.Expediente
                'objEntExpediente_copi = objEntExpediente
                dgwExpediente_queda_CellClick(Nothing, Nothing)
            End If
        End If
    End Sub

    Public Sub _Temporal_GrabarAgraviado(objEnt As Entity.Registro.Agraviado)

        Temporal_GrabarAgraviado(objEntDelitoTempoCol.Delito(Me.GrillaDelitoIndex), objEnt)

    End Sub
    Private Sub Temporal_GrabarAgraviado(objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)
        'objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol

        If objEnt.Codigo > 0 Then
            'si el registro esta en la base de datos
            If objEnt.AgraviadoItem > 0 Then
                For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If obj.Codigo = objEnt.Codigo Then
                        Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'objEntAgraviado = New Entity.Registro.Agraviado
                objEnt.DelitoItem = objEntDelito.DelitoItem
                objEnt.ExpedienteItem = objEntDelito.ExpedienteItem ' Me._GrillaItemExpediente '  objEntDelito.ExpedienteItem
                objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                objEntAgraviadoTempoCol.Add(objEnt)
            End If
        Else
            'si el temporal ya existe ''''''''''''''''''''''EL ULTIMO ELIMINA REVISAR
            If objEnt.AgraviadoItem > 0 Then
                For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If obj.AgraviadoItem = objEnt.AgraviadoItem Then
                        Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'si el temporal es nuevo
                'objEntAgraviado = New Entity.Registro.Agraviado
                Dim strNombre As String = ""
                Dim blnValor As Boolean = False
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If EntAgr.DelitoItem = objEnt.DelitoItem Then
                        If EntAgr.AgraviadoNombre = objEnt.AgraviadoNombre Then
                            strNombre = objEnt.AgraviadoNombre
                            blnValor = True
                        End If
                    End If
                Next
                If blnValor = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado : " & strNombre & ", ya se encuentra la lista ")
                    Exit Sub
                Else
                    objEnt.DelitoItem = objEntDelito.DelitoItem
                    objEnt.ExpedienteItem = Me._GrillaItemExpediente
                    objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                    objEntAgraviadoTempoCol.Add(objEnt)
                End If
            End If

        End If

        If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
            'dgwDelitos_CellClick(Nothing, Nothing)
        Else
            objEntDelito_copy = New Entity.Registro.Delito
            objEntDelito_copy = objEntDelito
            'dgwDelitos_CellClick(Nothing, Nothing)
        End If
    End Sub
    Private objEntAgraviadoTempoCol_Avocat As New Entity.Registro.AgraviadoCol
    Private Sub Temporal_GrabarAgraviado2(objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)
        If objEnt.Codigo > 0 Then
            'si el registro esta en la base de datos
            If objEnt.AgraviadoItem > 0 Then
                For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If obj.Codigo = objEnt.Codigo Then
                        Temporal_AgraviadoCopiarPropiedades2(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'objEntAgraviado = New Entity.Registro.Agraviado
                objEnt.DelitoItem = objEntDelito.DelitoItem
                objEnt.ExpedienteItem = objEntDelito.ExpedienteItem
                objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol_Avocat) + 1
                objEntAgraviadoTempoCol_Avocat.Add(objEnt)
            End If
        Else
            'si el temporal ya existe ''''''''''''''''''''''EL ULTIMO ELIMINA REVISAR
            If objEnt.AgraviadoItem > 0 Then
                For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If obj.AgraviadoItem = objEnt.AgraviadoItem Then
                        Temporal_AgraviadoCopiarPropiedades2(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'si el temporal es nuevo
                'objEntAgraviado = New Entity.Registro.Agraviado
                objEnt.DelitoItem = objEntDelito.DelitoItem
                objEnt.ExpedienteItem = 1
                objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol_Avocat) + 1
                objEntAgraviadoTempoCol_Avocat.Add(objEnt)
            End If
        End If
    End Sub
    Private Sub Temporal_AgraviadoCopiarPropiedades2(objEntOrigen As Entity.Registro.Agraviado, ObjEntDestino As Entity.Registro.Agraviado)
        With objEntOrigen
            .Codigo = ObjEntDestino.Codigo
            .InternoID = ObjEntDestino.InternoID
            .IngresoID = ObjEntDestino.IngresoID
            .ExpedienteID = ObjEntDestino.ExpedienteID
            .DelitoID = ObjEntDestino.DelitoID
            .AgraviadoItem = ObjEntDestino.AgraviadoItem
            .DelitoItem = ObjEntDestino.DelitoItem
            .ExpedienteItem = ObjEntDestino.ExpedienteItem
            '/*campos*/
            .AgraviadoNombre = ObjEntDestino.AgraviadoNombre
            .Observacion = ObjEntDestino.Observacion
            .Estado = ObjEntDestino.Estado
        End With
    End Sub
    Private Sub Temporal_AgraviadoCopiarPropiedades(objEntOrigen As Entity.Registro.Agraviado, ObjEntDestino As Entity.Registro.Agraviado)
        With objEntOrigen
            .Codigo = ObjEntDestino.Codigo
            .InternoID = ObjEntDestino.InternoID
            .IngresoID = ObjEntDestino.IngresoID
            .ExpedienteID = ObjEntDestino.ExpedienteID
            .DelitoID = ObjEntDestino.DelitoID
            .AgraviadoItem = ObjEntDestino.AgraviadoItem
            .DelitoItem = ObjEntDestino.DelitoItem
            .ExpedienteItem = ObjEntDestino.ExpedienteItem
            '/*campos*/
            .AgraviadoNombre = ObjEntDestino.AgraviadoNombre
            .Observacion = ObjEntDestino.Observacion
            .Estado = ObjEntDestino.Estado
            .CreaDocJudicialId = ObjEntDestino.CreaDocJudicialId
        End With
    End Sub
    Private Function TemporalAgraviadoItemMaximo(objEntCol As Entity.Registro.AgraviadoCol) As Integer

        Dim value As Integer = 0
        Dim intNumero As Integer = 0

        For Each obj As Entity.Registro.Agraviado In objEntCol

            If obj.AgraviadoItem > intNumero Then
                intNumero = obj.AgraviadoItem
                value = intNumero
            End If

        Next
        Return value
    End Function
    Private Sub Temporal_Modificar_Agraviado()

        'If dgwAgraviados_queda.Rows.Count = 0 Then
        '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un agraviado para modificar.")
        '    Exit Sub
        'End If
        'blnVaorAgr = False
        'RaiseEvent _Click_Agraviado_Editar(Me.GrillaDelitoSelect, Me.GrilllaAgraviadoSelect)

    End Sub
    Private Sub Temporal_ListarDelitos(objEntExpediente As Entity.Registro.Expediente)
        Try
            If objEntExpediente Is Nothing Then
                If dgwDelito_queda.Rows.Count > 0 Then
                    'dgwDelitos_CellClick(Nothing, Nothing)
                End If
            Else
                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol

                    If obj.ExpedienteID = objEntExpediente.Codigo Then
                        If obj.ExpedienteID > 0 Then

                            objEntDelito = New Entity.Registro.Delito
                            Temporal_DelitoCopiarPropiedades(objEntDelito, obj)

                            If objEntExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                           objEntExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                            objEntExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then

                                objEntDelito.ExpedienteItem = obj.ExpedienteItem
                            End If

                            objEntDelitoTempoColGrilla.Add(objEntDelito)

                        Else
                            If objEntExpediente.ExpedienteItem = obj.ExpedienteItem Then
                                objEntDelito = New Entity.Registro.Delito
                                Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                                objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                                objEntDelitoTempoColGrilla.Add(objEntDelito)
                            End If
                        End If
                    ElseIf Me._TipoResolucion = enumTipoDocumentoJudicial.Avocamiento Then
                        objEntDelito = New Entity.Registro.Delito
                        Temporal_DelitoCopiarPropiedades(objEntDelito, obj)

                        objEntDelito.ExpedienteItem = IIf(Me._SubTipo = enumSubTipo.IngresoTraslado, objEntExpediente.ExpedienteItem, Me._GrillaItemExpediente)

                        objEntDelitoTempoColGrilla.Add(objEntDelito)
                    End If
                Next

                With Me.dgwDelito_queda
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = Nothing
                    .DataSource = objEntDelitoTempoColGrilla
                    ' lblNrodelitos.Text = "Delito(s) " & .Rows.Count & " Reg."
                End With
                'dgwDelitos_CellClick(Nothing, Nothing)
            End If

        Catch ex As Exception
        Finally

        End Try
    End Sub

    Private Sub Temporal_ListarDelitos2()
        objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol

        For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
            'If obj.ExpedienteID = objEntExpediente.Codigo Then
            If obj.Codigo > 0 Then

                objEntDelito = New Entity.Registro.Delito
                Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                'objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                objEntDelitoTempoColGrilla.Add(objEntDelito)

            Else
                'If objEntExpediente. = obj.ExpedienteItem Then
                objEntDelito = New Entity.Registro.Delito
                Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                'objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                objEntDelitoTempoColGrilla.Add(objEntDelito)
                'End If
            End If
            'End If
        Next

        With Me.dgwDelito_queda
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            .DataSource = Nothing
            .DataSource = objEntDelitoTempoColGrilla
            'lblNrodelitos.Text = "Delito(s) " & .Rows.Count & " Reg."
        End With
        'dgwDelitos_CellClick(Nothing, Nothing)

    End Sub
    Private Sub mostrarDatosInimputables(idTipoInimputable As Short)

        Dim verBotonImimputable As Boolean = False

        Select Case Me._TipoResolucion

            Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad

                If idTipoInimputable = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable Or
                    idTipoInimputable = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable Then
                    verCamposInimputables(True, idTipoInimputable)
                Else
                    verCamposInimputables(False, idTipoInimputable)
                End If

                verBotonImimputable = True

            Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital,
                 Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.RetornoTrasladoHospital
                verCamposInimputables(True, idTipoInimputable)
                verBotonImimputable = True

        End Select

        'Me.btnInimputable.Visible = verBotonImimputable

    End Sub
    Private Sub Temporal_ListarAgraviados()

        If objEntDelito Is Nothing Then
            'nada
        Else

            objEntAgraviadoTempoColGrilla = New Entity.Registro.AgraviadoCol

            For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol

                If obj.Codigo > 0 Then
                    Dim abc As Integer = objEntDelitoTempoCol.Count

                    If Me._GrillaDelitoID = obj.DelitoID Then
                        objEntAgraviado = New Entity.Registro.Agraviado
                        Temporal_AgraviadoCopiarPropiedades(objEntAgraviado, obj)
                        If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                          objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                          objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then
                            objEntAgraviado.ExpedienteItem = objEntDelito.ExpedienteItem
                        Else
                            objEntAgraviado.ExpedienteItem = Me._GrillaItemExpediente
                        End If

                        objEntAgraviadoTempoColGrilla.Add(objEntAgraviado)
                    End If
                Else
                    If obj.DelitoItem = Me._GrillaItemDelito Then
                        objEntAgraviado = New Entity.Registro.Agraviado
                        Temporal_AgraviadoCopiarPropiedades(objEntAgraviado, obj)
                        objEntAgraviadoTempoColGrilla.Add(objEntAgraviado)
                    End If
                End If

            Next

            With Me.dgwAgraviados_queda
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = objEntAgraviadoTempoColGrilla
                'Me.lblNroAgraviados.Text = "Agraviado(s) " & .Rows.Count & " Reg."
                .Refresh()
            End With
        End If
    End Sub

    Private Sub Temporal_ExpedienteCopiarPropiedades(objEntOrigen As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)

        With objEntOrigen
            .Codigo = ObjEntDestino.Codigo
            .InternoID = ObjEntDestino.InternoID
            .IngresoID = ObjEntDestino.IngresoID
            'campos
            .AutoridadJudicialID = ObjEntDestino.AutoridadJudicialID
            .AutoridadJudicialNombre = ObjEntDestino.AutoridadJudicialNombre
            .SalaJudicialID = ObjEntDestino.SalaJudicialID
            .SalaJudicialNombre = ObjEntDestino.SalaJudicialNombre
            .ExpedienteJuez = ObjEntDestino.ExpedienteJuez
            .ExpedienteSecretario = ObjEntDestino.ExpedienteSecretario
            .ExpedienteNumero = ObjEntDestino.ExpedienteNumero
            .ExpedienteFechaDocRecepcion = ObjEntDestino.ExpedienteFechaDocRecepcion
            .ExpedienteFecha = ObjEntDestino.ExpedienteFecha
            .SituacionJuridicaNombre = ObjEntDestino.SituacionJuridicaNombre
            .SituacionJuridicaID = ObjEntDestino.SituacionJuridicaID
            .Flagrancia = ObjEntDestino.Flagrancia
            .Observacion = ObjEntDestino.Observacion
            .LibertadTipoID = ObjEntDestino.LibertadTipoID
            .LibertadTipoNom = ObjEntDestino.LibertadTipoNom
            .MotivoIngresoID = ObjEntDestino.MotivoIngresoID
            .EstablecimientomentalId = ObjEntDestino.EstablecimientomentalId
            Me._EstablecimientomentalId = ObjEntDestino.EstablecimientomentalId
            .NuevoMotivoInimputableId = ObjEntDestino.NuevoMotivoInimputableId
            .NuevoEstablecimientomentalId = ObjEntDestino.NuevoEstablecimientomentalId
        End With

    End Sub
    Private Function TemporalExpedienteItemMaximo(objEntCol As Entity.Registro.ExpedienteCol) As Integer
        Dim value As Integer = 0
        Dim intNumero As Integer = 0

        For Each obj As Entity.Registro.Expediente In objEntCol
            If obj.ExpedienteItem > intNumero Then
                intNumero = obj.ExpedienteItem
                value = intNumero
            End If
        Next

        Return value
    End Function
    Private Sub Temporal_DelitoCopiarPropiedades(objEntOrigen As Entity.Registro.Delito, ObjEntDestino As Entity.Registro.Delito)
        With objEntOrigen
            .Codigo = ObjEntDestino.Codigo
            .InternoID = ObjEntDestino.InternoID
            .IngresoID = ObjEntDestino.IngresoID
            .ExpedienteID = ObjEntDestino.ExpedienteID
            .ExpedienteItem = ObjEntDestino.ExpedienteItem
            .DelitoItem = ObjEntDestino.DelitoItem
            '/*campos*/
            .DelitoGenerico = ObjEntDestino.DelitoGenerico
            .DelitoGenericoNombre = ObjEntDestino.DelitoGenericoNombre
            .DelitoEspecifico = ObjEntDestino.DelitoEspecifico
            .DelitoEspecificoNombre = ObjEntDestino.DelitoEspecificoNombre
            .Estado = ObjEntDestino.Estado
            .Observacion = ObjEntDestino.Observacion
            .CreaDocJudicialId = ObjEntDestino.CreaDocJudicialId
        End With
    End Sub
    Private Function TemporalDelitoItemMaximo(objEntCol As Entity.Registro.DelitoCol) As Integer

        Dim value As Integer = 0
        Dim intNumero As Integer = 0

        For Each obj As Entity.Registro.Delito In objEntCol
            'intNumero = obj.DelitoItem
            If obj.DelitoItem > intNumero Then
                intNumero = obj.DelitoItem
                value = intNumero
            End If
        Next

        Return value
    End Function
    Private Sub Temporal_Delito_Modificar()

        If dgwDelito_queda.Rows.Count = 0 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un delito para modificar.")
            Exit Sub
        End If

        Me.GrillaDelitoSelect.DelitoItem = Me._GrillaItemDelito
        Me.GrillaDelitoSelect.ExpedienteItem = Me._GrillaItemExpediente
        For i As Integer = 0 To objEntDelitoTempoColGrilla.Count - 1
            objEntDelitoTempoColGrilla.internoDelito(i).Auxiliar = False
            If objEntDelitoTempoColGrilla.internoDelito(i).DelitoEspecifico = Me._GrillaDelitoEspecificoID Then
                objEntDelitoTempoColGrilla.internoDelito(i).Auxiliar = True
            End If
        Next
        Dim usr As New APPControls.Busqueda.UscComboDelito
        'usr._DelitoGenericoID = Me.GrillaDelitoSelect.DelitoGenerico
        If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Then
            'RaiseEvent _Click_Delito_Editar(Nothing, Me.GrillaDelitoSelect, Me.Grilla_Agraviados_Delito_Select, objEntDelitoTempoColGrilla)
        Else
            Dim abc As Integer = objEntDelitoTempoCol.Count
            'RaiseEvent _Click_Delito_Editar(Me.objEntExpedienteTempoCol_Queda.Item(Me.GrillaExpedienteIndex), Me.GrillaDelitoSelect, Me.Grilla_Agraviados_Delito_Select, objEntDelitoTempoColGrilla)
        End If

    End Sub
    Private Sub Temporal_ListarExpediente2()
        With Me.dgwExpediente_queda
            .DataSource = Nothing
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            .DataSource = objEntExpedienteTempoCol_Queda
            .Refresh()
            lblNroExpedientes.Text = "Expedientes " & .Rows.Count & " Reg."
            For i As Integer = 0 To .Rows.Count - 1
                .Item("col_num", i).Value = i + 1
            Next
        End With

    End Sub
    Private Sub dgwExpediente_queda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwExpediente_queda.CellClick

        If dgwExpediente_queda.Rows.Count > 0 Then
            If blnValorExp = False Then
                If Me._SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                    Temporal_ListarDelitos(IIf((Me.GrillaExpedienteSelect).ExpedienteItem < 1, objEntExpediente_copi, Me.GrillaExpedienteSelect)) ' )
                Else
                    '  Temporal_ListarDelitos(Me.GrillaExpedienteSelect)
                End If
            Else
                Temporal_ListarDelitos(objEntExpedienteTempoCol_Queda.Expediente(0))
                blnValorExp = False
            End If

        End If
    End Sub
    Public Sub EliminarAgraviado_desde_Delito(EntAgrCol_Ind As Entity.Registro.AgraviadoCol)
        If Me.dgwAgraviados_queda.RowCount > 0 Then
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                For Each EntAgr_Ind As Entity.Registro.Agraviado In EntAgrCol_Ind ' AgraviadosIndcCol3
                    If objEntAgraviadoTempoCol.Item(i).Codigo = EntAgr_Ind.Codigo Then
                        AgraviadosIndcCol3.Add(EntAgr_Ind)
                        objEntAgraviadoTempoCol.Remove(i)
                        blnEliminarAgraviadoColec = True
                    End If
                Next
            Next
        End If
        ' 'dgwDelitos_CellClick(Nothing, Nothing)
    End Sub
    Private Sub verCamposInimputables(vf As Boolean, idTipoInimputable As Short)

        'Me.col_est_men_des.Visible = vf
        'Me.col_exp_inmp.Visible = vf
        'Me.col_exp_inmp.Width = 190

        'If vf = True Then
        '    Select Case idTipoInimputable
        '        Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable

        '            Me.pnlDuracionCondena.Visible = vf
        '            Me.gbDuracioncondena.Text = "Duración de la medida de seguridad"
        '            Me.gbComputo.Text = "Cómputo de la medida de seguridad"

        '        Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable

        '            Me.pnlDuracionCondena.Visible = False
        '    End Select
        'Else
        '    Me.pnlDuracionCondena.Visible = vf
        'End If

    End Sub

    Private Sub dgwExpediente_queda_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgwExpediente_queda.DataError
        'MessageBox.Show("Error happened " & e.Context.ToString())
        'If (e.Context = DataGridViewDataErrorContexts.Commit) _
        '    Then
        '    MessageBox.Show("Commit error")
        'End If
        'If (e.Context = DataGridViewDataErrorContexts.CurrentCellChange) Then
        '    MessageBox.Show("Cell change")
        'End If
        'If (e.Context = DataGridViewDataErrorContexts.Parsing) Then
        '    MessageBox.Show("parsing error")
        'End If
        'If (e.Context = DataGridViewDataErrorContexts.LeaveControl) Then
        '    MessageBox.Show("leave control error")
        'End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"
            e.ThrowException = False
        End If
    End Sub

    Private Sub dgwDelito_queda_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgwDelito_queda.DataError
        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"
            e.ThrowException = False
        End If

    End Sub
    Private Sub dgwAgraviados_queda_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgwAgraviados_queda.DataError
        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"
            e.ThrowException = False
        End If
    End Sub
    Private Sub chk_queda_si_CheckedChanged(sender As Object, e As EventArgs) Handles chk_queda_si.CheckedChanged
        If chk_queda_si.Checked = True Then
            Me.txtobs_queda.Text = Temp_obs
            Me.txtobs_queda.Enabled = True
            Me.grp02.Enabled = True
            RaiseEvent _Click_chkQueda()
        End If
    End Sub
    Private Sub chk_queda_no_CheckedChanged(sender As Object, e As EventArgs) Handles chk_queda_no.CheckedChanged
        If chk_queda_no.Checked = True Then
            Temp_obs = Me.txtobs_queda.Text
            Me.txtobs_queda.Text = ""
            Me.txtobs_queda.Enabled = False
            Me.grp02.Enabled = False
            RaiseEvent _Click_chkQueda()
        End If
    End Sub

    Public Sub eliminar_movimiento_libertad(strAccion As String, strOpcion As String, Codigo As Integer, InternoId As Integer, IngresoId As Integer)
        Dim intValue As Integer = -1
        objBssDoc = New Bussines.Registro.DocumentoJudicial

        If Me.chk_queda_si.Checked = True Then
            intValue = objBssDoc.Eliminar_x_Queda(strAccion, strOpcion, Codigo, InternoId, IngresoId, Me.FlagTransferSede)
        End If
    End Sub
    Dim sw As Boolean = False
    Dim num As Integer = 0
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New frmCargarProceso
        If frm.ShowDialog = DialogResult.OK Then
            If sw = False Then num = dgwExpediente_queda.Rows.Count + lbOtrosProcesos.Items.Count
            num = num + 1
            lbOtrosProcesos.Items.Add("(" & num & ") Nº EXP: " & frm._NumeroExpediente & " | " & frm._SalaJudicial)
            sw = True
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If lbOtrosProcesos.Items.Count = 0 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar proceso pendiente a eliminar.")
            lbOtrosProcesos.Focus()
        Else
            If lbOtrosProcesos.SelectedIndex = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar proceso pendiente a eliminar.")
                lbOtrosProcesos.Focus()
            Else
                If Legolas.Configuration.Aplication.MessageBox.Question("Desea quitar el proceso vigente seleccionado") = DialogResult.Yes Then
                    lbOtrosProcesos.Items.RemoveAt(lbOtrosProcesos.SelectedIndex)
                End If
            End If
        End If
    End Sub

    Private Sub dgwExpediente_queda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwExpediente_queda.CellContentClick

    End Sub
End Class
