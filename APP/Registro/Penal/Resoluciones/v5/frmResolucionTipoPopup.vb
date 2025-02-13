Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.SubTipoDocJudicial
Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class frmResolucionTipoPopup
        Dim objBss As Bussines.Registro.Documento.DocumentoJudicialTipo = Nothing
        Dim objEntCol As Entity.Registro.Documento.DocumentoJudicialTipoCol = Nothing

        Dim objSubBss As Bussines.Registro.Documento.DocumentoJudicialSubTipo = Nothing
        Dim objSubEntCol As Entity.Registro.Documento.DocumentoJudicialSubTipoCol = Nothing

#Region "Propiedades Parametricas"
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _RegionID() As Short = -1
        Public Property _PenalID() As Short = -1
        Public Property _CodigoInterno() As String = ""
        Public Property _NombresInterno() As String = ""
        Public Property _ResolucionIngRegistrado As Boolean = False
        'Public Property _PenalLM As Boolean = False
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _OpcionListar As Integer = -1
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property _Documento_sin_mov As Boolean = False
        Public Property _Historico As Boolean = False
        Public Property _HistoricoFecha As Long = 0
#End Region

#Region "Propiedades"
        Private Property SubTipoDocumento As Integer = -1
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaSubTipoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaSubtipo
                        intValue = .SelectedRows(0).Cells("col_sub_tip").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_Filtro"
        Private ReadOnly Property DocumentoCategoria() As Short
            Get
                Dim value As Short = -1

                'ingreso
                If Me.rdbIngreso.Checked = True Then
                    value = 1
                End If

                'egreso
                If Me.rdbEgreso.Checked = True Then
                    value = 3
                End If

                'sentencias
                If Me.rdbSentencia.Checked = True Then
                    value = 2
                End If

                If Me.rdbAclarados.Checked = True Then
                    value = 1
                End If
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                    value = -1
                End If

                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Retorno"
        Public ReadOnly Property _Codigo() As Integer
            Get
                Return Me.GrillaCodigo
            End Get
        End Property
#End Region
#Region "Propiedades_Config"
        Private ReadOnly Property PerfilUsuario As Short
            Get
                Return Legolas.Configuration.Usuario.OficinaID
            End Get
        End Property

#End Region
#Region "Listar"
        Private Sub Buscar()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.Documento.DocumentoJudicialTipo
            objEntCol = New Entity.Registro.Documento.DocumentoJudicialTipoCol

            objEntCol = objBss.Listar(Me._TipoLicencia, Type.Enumeracion.Licencia.enmTipoDocumento.Documentos, Me.PerfilUsuario, Me.DocumentoCategoria)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With
            If Me.dgwGrilla.RowCount > 0 Then
                Me.dgwGrilla.Rows(0).Selected = True
            End If
            ListarSubtipo()
            Usuario_Permiso()
        End Sub
#End Region
#Region "Form"
#Region "Resoluciones"
        Private Sub FRM_Mant_Notas(ByVal SubTipoID As Integer)
            Select Case SubTipoID
                Case enumSubTipo.ProyeccionVencimientoCondena

                    FRM_Mant_Resol_ProyeccionVencimientoPena()

                Case enumSubTipo.Nota_de_Sentencia, enumSubTipo.Adelanto_de_Fallo
                    Dim frm As New Registro.Resoluciones.frmNotaPeriodo
                    With frm
                        ._Codigo = -1
                        ._InternoId = Me._InternoID
                        ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                        ._InternoIngresoId = Me._IngresoID
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                        ._CodigoInterno = Me._CodigoInterno
                        ._NombresInterno = Me._NombresInterno
                        ._blnNuevoRegistro = True
                        ._Subtipo = SubTipoID
                        ._TipoLicencia = Me._TipoLicencia
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    End With
                Case Else
                    Dim frm As New Registro.Resoluciones.frmNota
                    With frm
                        ._Codigo = -1
                        ._InternoId = Me._InternoID
                        ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                        ._InternoIngresoId = Me._IngresoID
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                        ._CodigoInterno = Me._CodigoInterno
                        ._NombresInterno = Me._NombresInterno
                        ._blnNuevoRegistro = True
                        ._Subtipo = SubTipoID
                        ._TipoLicencia = Me._TipoLicencia
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    End With
            End Select
        End Sub
        Private Sub FRM_Mant_AcumExpedientes()

            Dim frm As New Registro.Resoluciones.frmResolAcumExpedientes
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoId = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                ''.UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_RevocatoriaLibertad()

            Dim frm As New Registro.Resoluciones.frmResolRevocatoriaLibertad
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoId = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoId = Me._InternoID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                .UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                ._TipoResolucion = Me.dgwGrilla.SelectedRows(0).Cells("col_id").Value
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Queda()

            If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                Dim frm As New Registro.RegionLima.Resoluciones.frmQueda
                With frm
                    ._Codigo = -1
                    ._InternoId = Me._InternoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._InternoIngresoId = Me._IngresoID
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._InternoId = Me._InternoID
                    ._CodigoInterno = Me._CodigoInterno
                    ._NombresInterno = Me._NombresInterno
                    .UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
                    ._TipoLicencia = Me._TipoLicencia
                    ._TipoResolucion = Me.dgwGrilla.SelectedRows(0).Cells("col_id").Value
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            Else
                Dim frm As New Registro.Resoluciones.frmQueda
                With frm
                    ._Codigo = -1
                    ._InternoId = Me._InternoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._InternoIngresoId = Me._IngresoID
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._InternoId = Me._InternoID
                    ._CodigoInterno = Me._CodigoInterno
                    ._NombresInterno = Me._NombresInterno
                    .UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
                    ._TipoLicencia = Me._TipoLicencia
                    ._TipoResolucion = Me.dgwGrilla.SelectedRows(0).Cells("col_id").Value
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            End If

        End Sub
        Private Sub FRM_Mant_Resol_Aclaratoria(ByVal SubTipoID As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAclaratoriaExpe

            With frm
                ._Codigo = -1
                ._InternoIngresoId = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoId = Me._InternoID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._NuevoRegistro = True
                ._Subtipo = SubTipoID
                .UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub
        Private Sub FRM_Mant_Resol_Libertad()
            Dim frm As New Registro.Resoluciones.frmResolLibertad_v2
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoId = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._Documento_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                ._TipoResolucion = Me.dgwGrilla.SelectedRows(0).Cells("col_id").Value
                ._Historico = Me._Historico
                ._HistoricoFecha = Me._HistoricoFecha
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Ordentraslado()
            Dim frm As New Registro.Resoluciones.frmOrdenTrasladoHospital
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoId = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._Documento_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                ._TipoResolucion = Me.dgwGrilla.SelectedRows(0).Cells("col_id").Value
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Ordentraslado_Nota()
            Dim frm As New Registro.Resoluciones.frmOrdenTrasladoHospital_Nota
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoId = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._Documento_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                ._TipoResolucion = Me.dgwGrilla.SelectedRows(0).Cells("col_id").Value
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub

        Private Sub FRM_Mant_Resol_ProlongDetencion()
            Dim frm As New Registro.Resoluciones.frmResolProlongDetencion
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._DocumentoTipo = Me.GrillaCodigo
                .UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Resol_AnulacionAntecedentes()
            Dim frm As New Registro.Sentencias.frmResolAnulacion
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Resol_Traslado()
            Dim frm As New Registro.Resoluciones.frmResolTraslado
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub
        Private Sub FRM_Mant_Resol_Avocamiento()
            Dim frm As New Registro.Resoluciones.frmResolAvocamiento
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                .UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub

        Private Sub FRM_Mant_Detencion_Carceleta()
            Dim frm As New Registro.Resoluciones.frmResolDetencion
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                '._InternoIngresoId = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoId = Me._InternoID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionCarceleta
                .UscExpeDeResolucion1._Documentos_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub

        Private Sub FRM_Mant_Resol_Detencion()
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                Dim frm As New Registro.Resoluciones.frmResolDetencion
                With frm
                    ._Codigo = -1
                    ._InternoId = Me._InternoID
                    '._InternoIngresoId = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._InternoId = Me._InternoID
                    ._CodigoInterno = Me._CodigoInterno
                    ._NombresInterno = Me._NombresInterno
                    ._blnNuevoRegistro = True
                    ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion
                    .UscExpeDeResolucion1._Documentos_sin_mov = Me._Documento_sin_mov
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            Else
                Dim frm As New Registro.Resoluciones.frmResolDetencion
                With frm
                    ._Codigo = -1
                    ._InternoId = Me._InternoID
                    ._InternoIngresoId = Me._IngresoID
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._InternoId = Me._InternoID
                    ._CodigoInterno = Me._CodigoInterno
                    ._NombresInterno = Me._NombresInterno
                    ._blnNuevoRegistro = True
                    ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion
                    .UscExpeDeResolucion1._Documentos_sin_mov = Me._Documento_sin_mov
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            End If
        End Sub

        Private Sub FRM_Mant_Detencion_Referenciado()
            Dim frm As New Registro.Resoluciones.frmResolDetencionReferenciado
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoId = Me._InternoID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado
                .UscExpeDeResolucion1._Documentos_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub
        Private Sub FRM_Mant_Resol_PrisionPreventiva()
            Dim frm As New Registro.Resoluciones.frmResolPrisionPreventiva

            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoId = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoId = Me._InternoID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._Documento_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_ResolIngreso(ByVal SubTipo As Integer)
            Dim frm As New Registro.Resoluciones.frmResolIngreso

            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoID = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._DocumentoSubtipo = Me.GrillaSubTipoId
                ._Documento_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_ResolIngresoTraslado()
            Dim frm As New Registro.Resoluciones.frmResolIngresoTraslado

            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoID = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._Documento_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_ResolIngreso_RL(ByVal SubTipo As Integer)
            Dim frm As New Registro.RegionLima.Resoluciones.frmResolIngreso
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoID = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._DocumentoSubtipo = Me.GrillaSubTipoId
                ._Documento_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Resol_AmpliacionAuto()
            Dim frm As New Registro.Resoluciones.frmResolAmpliaAutoapert
            With frm
                ._Codigo = -1
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                .UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    Me.DialogResult = Windows.Forms.DialogResult.OK

                End If

            End With
        End Sub
        Private Sub FRM_Mant_Resol_OtroProceso()
            Dim frm As New Registro.Resoluciones.frmOtrosprocesos
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._TipoFormulario = Me.GrillaCodigo
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub

#End Region
#Region "Sentencias"

        Private Sub FRM_Mant_Resolucion()
            Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub
        Private Sub FRM_Mant_ResolucionSuperior()
            Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion_Superior
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub
        Private Sub FRM_Mant_Sent()
            Dim frm As New Registro.Sentencias.frmResolSentenciaV2
            'Dim frm As New Registro.Sentencias.frmResolSentencia
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Sent_Conmutacion()
            Dim frm As New Registro.Sentencias.frmResolSentenciaConmutacion
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._TipoResolucion = Me.GrillaCodigo
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Sent_Multiple()
            If Me.GrillaCodigo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionDeclaraConsentida Then
                Dim frm As New Registro.Sentencias.frmResolSentenciaNueva
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._InternoIngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._CodigoInterno = Me._CodigoInterno
                    ._NombresInterno = Me._NombresInterno
                    ._TipoResolucion = Me.GrillaCodigo
                    ._blnNuevoRegistro = True
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

                End With
            Else
                Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._InternoIngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._CodigoInterno = Me._CodigoInterno
                    ._NombresInterno = Me._NombresInterno
                    ._TipoResolucion = Me.GrillaCodigo
                    ._blnNuevoRegistro = True
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

                End With
            End If
        End Sub
        Private Sub FRM_Mant_Resol_Sent_PLD()
            Dim frm As New Registro.RegionLima.Resoluciones.frmResolSentenciaMultiple
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._TipoResolucion = Me.GrillaCodigo
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Resol_Revocatoria()
            Dim frm As New Registro.RegionLima.Resoluciones.frmResolRevocatoria
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._TipoResolucion = Me.GrillaCodigo
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub

        Private Sub FRM_Mant_Sent_Integracion()
            If Me.GrillaCodigo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Then
                Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._InternoIngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._CodigoInterno = Me._CodigoInterno
                    ._NombresInterno = Me._NombresInterno
                    ._blnNuevoRegistro = True
                    ._TipoResolucion = Me.GrillaCodigo
                    ._TipoLicencia = Me._TipoLicencia
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            Else
                Dim frm As New Registro.Sentencias.frmResolIntegracionSent
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._InternoIngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._CodigoInterno = Me._CodigoInterno
                    ._NombresInterno = Me._NombresInterno
                    ._blnNuevoRegistro = True
                    ._TipoResolucion = Me.GrillaCodigo
                    ._TipoLicencia = Me._TipoLicencia
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            End If
        End Sub
        Private Sub FRM_Mant_Resol_ProyeccionVencimientoPena()
            Dim frm As New Registro.Resoluciones.frmProyeccionVencimientoCondena
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._CodigoInterno = Me._CodigoInterno
                ._NombresInterno = Me._NombresInterno
                ._TipoResolucion = Me.GrillaCodigo
                ._Subtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.ProyeccionVencimientoCondena
                ._blnNuevoRegistro = True
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
#End Region
#End Region

#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.btnOk.Visible = Me._FormEscritura

        End Sub
        Private Sub MostrarCabecera()


            Dim blnVisible As Boolean = False

            Select Case Me._TipoLicencia

                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    blnVisible = True

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta, Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    Me.Size = New Size(Me.Width, 150)
                    blnVisible = False

            End Select

            Me.grbCabecera.Visible = blnVisible

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            If Me._InternoID < 1 Then
                MessageBox.Show("No ha enviado el valor de IdInterno", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim MovimientoID As Integer = -1
            Dim strmensaje As String = "El interno no cuenta con una Resolución de ingreso, " + Chr(13) +
                                       "por favor registre el documento."
            Dim bssReg As New Bussines.Registro.DocumentoJudicial
            Dim EntReg As New Entity.Registro.DocumentoJudicial

            EntReg.Codigo = -1
            EntReg.InternoId = Me._InternoID
            EntReg.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso

            Dim EntRegDoc As New Entity.Registro.DocumentoJudicial
            Dim EntRegDocCol As New Entity.Registro.DocumentoJudicialCol

            Select Case Me._TipoLicencia
                Case enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.Carceleta
                    EntReg.IngresoInpeId = Me._InternoIngresoInpeId
                    EntReg.InternoIngresoId = -1
                    EntRegDocCol = bssReg.ListarDocJud_v2_LM(EntReg)

                    If EntRegDocCol.Count > 0 Then EntReg = EntRegDocCol.DocumentoJudicial(0)

                    Dim bss As New Bussines.Registro.IngresoInpe
                    MovimientoID = bss.Listar(Me._InternoIngresoInpeId).IDTipoMovimiento
                Case Else
                    EntReg.InternoIngresoId = Me._IngresoID
                    EntReg.IngresoInpeId = -1
                    EntRegDoc = bssReg.Listar_v2(EntReg)
            End Select

            Select Case Me.GrillaCodigo

                Case enumTipoDocumentoJudicial.Ingreso

                    If Not EntRegDoc Is Nothing AndAlso EntRegDoc.DocumentoTipo = enumTipoDocumentoJudicial.Ingreso Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno ya cuenta con un registro de ingreso activo")
                        Exit Sub
                    End If

                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        FRM_Mant_ResolIngreso_RL(Me.GrillaSubTipoId)
                    Else

                        Select Case Me.GrillaSubTipoId
                            Case enumSubTipo.IngresoPrisionPreventiva
                                FRM_Mant_Resol_PrisionPreventiva()

                            Case enumSubTipo.IngresoTraslado
                                FRM_Mant_ResolIngresoTraslado()

                            Case Else
                                FRM_Mant_ResolIngreso(Me.GrillaSubTipoId)

                        End Select

                    End If

                Case enumTipoDocumentoJudicial.Libertad

                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then

                        Select Case MovimientoID
                            Case Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD, Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                                'pasa
                            Case Else
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                        End Select

                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If

                    FRM_Mant_Resol_Libertad()
                Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                     enumTipoDocumentoJudicial.Retorno_de_HospitalMental
                    If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                        Dim obj As New Entity.Registro.DocumentoJudicial
                        obj.InternoId = Me._InternoID
                        obj.IngresoInpeId = Me._InternoIngresoInpeId
                        If bssReg.Listar_DocumentosJudiciales_LM(obj).Count = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con ningun documento registrado de ingreso o traslado.")
                            Exit Sub
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            'Exit Sub
                        End If
                    End If

                    FRM_Mant_Ordentraslado()
                Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota
                    If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                        Dim obj As New Entity.Registro.DocumentoJudicial
                        obj.InternoId = Me._InternoID
                        obj.IngresoInpeId = Me._InternoIngresoInpeId
                        If bssReg.Listar_DocumentosJudiciales_LM(obj).Count = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con ningun documento registrado de ingreso o traslado.")
                            Exit Sub
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            'Exit Sub
                        End If
                    End If

                    FRM_Mant_Ordentraslado_Nota()
                Case enumTipoDocumentoJudicial.Traslado

                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD And EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            'If MessageBox.Show("Recuerde que el interno no cuenta con una Resolución de ingreso, desea continuar registrando el traslado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                            '    'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            '    Exit Sub
                            'End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_Resol_Traslado()

                'Case enumTipoDocumentoJudicial.Detencion
                '    FRM_Mant_Resol_Detencion()

                Case enumTipoDocumentoJudicial.DetencionCarceleta
                    FRM_Mant_Detencion_Carceleta()

                Case enumTipoDocumentoJudicial.DetencionReferenciado, enumTipoDocumentoJudicial.Detencion
                    FRM_Mant_Detencion_Referenciado()

                Case enumTipoDocumentoJudicial.Aclaratoria

                    Me.SubTipoDocumento = EntRegDoc.DocumentoTipo
                    If Me.GrillaSubTipoId = enumSubTipo.Aclaratoria_de_Expediente Or _
                       Me.GrillaSubTipoId = enumSubTipo.Aclaratoria_de_ExpedienteNombres Then
                        If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                                If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                    'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                    'Exit Sub
                                End If
                            End If
                        Else
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                Exit Sub
                            End If
                        End If
                    End If

                    FRM_Mant_Resol_Aclaratoria(Me.GrillaSubTipoId)

                Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio

                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                            End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If

                    FRM_Mant_Resol_AmpliacionAuto()

                Case enumTipoDocumentoJudicial.Avocamiento
                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                            End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_Resol_Avocamiento()

                Case enumTipoDocumentoJudicial.Prolongacion_Detencion,
                     enumTipoDocumentoJudicial.Adecuacion_Prision_Preventiva,
                     enumTipoDocumentoJudicial.Prolongacion_Prision_Preventiva
                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                            End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_Resol_ProlongDetencion()

                Case enumTipoDocumentoJudicial.Anulacion_Antecedentes
                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                            End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If


                    FRM_Mant_Resol_AnulacionAntecedentes()

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                    FRM_Mant_Notas(Me.GrillaSubTipoId)

                Case enumTipoDocumentoJudicial.AcumulacionExpedientes
                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                            End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_AcumExpedientes()

                Case enumTipoDocumentoJudicial.Revocatoria_de_Libertad

                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                            End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_RevocatoriaLibertad()

                Case enumTipoDocumentoJudicial.Queda

                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                            End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If

                    Dim EstadoID As Integer = -1
                    If Not (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or _
                       Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or _
                       Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                        EstadoID = (New Bussines.Registro.Interno).Listar_v5(Me._InternoID).EstadoID
                        If EstadoID = Type.Enumeracion.Interno.EnmEstado.Inactivo Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede registrar el documento QUEDA," + Chr(13) +
                                                                                    "cuando el interno se encuentra en estado ACTIVO.")
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_Queda()

                Case enumTipoDocumentoJudicial.Notas
                    If Me._ResolucionIngRegistrado = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con registro de ingreso o Mandato de detencion")
                        Exit Sub
                    End If
                    FRM_Mant_Notas(Me.GrillaSubTipoId)
                    '******************************************************* Sentencias ****************

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia

                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        If MovimientoID <> Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD Then
                            If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                                'Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                                'Exit Sub
                            End If
                        End If
                    Else
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_Sent()

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                    Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia

                    If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_Sent_Integracion()

                Case enumTipoDocumentoJudicial.Sent_Conmutacion_Pena

                    If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_Sent_Conmutacion()

                Case enumTipoDocumentoJudicial.Sent_Sustitucion_Pena, enumTipoDocumentoJudicial.Resolucion,
                     enumTipoDocumentoJudicial.Resolucion_Superior, enumTipoDocumentoJudicial.ResolucionConsentida,
                     enumTipoDocumentoJudicial.Sent_Adecuacion_Pena, enumTipoDocumentoJudicial.ResolucionDeclaraConsentida,
                     enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Integracion_Sentencia,
                     enumTipoDocumentoJudicial.Ejecutoria_Superior, enumTipoDocumentoJudicial.Ejecutoria_Suprema

                    If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                        If EntRegDoc.DocumentoTipo <> enumTipoDocumentoJudicial.Ingreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje)
                            Exit Sub
                        End If
                    End If
                    FRM_Mant_Sent_Multiple()

                Case enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                    enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD,
                     enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida

                    FRM_Mant_Resol_Sent_PLD()

                Case enumTipoDocumentoJudicial.Revocatoria

                    FRM_Mant_Resol_Revocatoria()

                Case enumTipoDocumentoJudicial.OtroProceso

                    FRM_Mant_Resol_OtroProceso()

            End Select

        End Sub

        Private Sub frmResolucionTipoPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            MostrarCabecera()

        End Sub

        Private Sub frmMovimientoTipoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Buscar()

        End Sub

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            ListarSubtipo()
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            btnOk_Click(Nothing, Nothing)
        End Sub

        Private Sub rdbIngreso_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
            rdbIngreso.Click, _
            rdbEgreso.Click, _
            rdbSentencia.Click, _
            rdbAclarados.Click, _
            rdbTodos.Click

            Select Case Me._OpcionListar
                Case Type.Enumeracion.SubTipoDocJudicial.enumListar.Ingreso

                    rdbIngreso.Checked = True
                Case Type.Enumeracion.SubTipoDocJudicial.enumListar.Egreso

                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Egreso
                    rdbEgreso.Checked = True
                Case Type.Enumeracion.SubTipoDocJudicial.enumListar.Aclarados

                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Aclarados
                    rdbAclarados.Checked = True
                Case Type.Enumeracion.SubTipoDocJudicial.enumListar.Sentencia

                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Sentencia
                    rdbSentencia.Checked = True
                Case Type.Enumeracion.SubTipoDocJudicial.enumListar.Todos

                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Todos
                    rdbTodos.Checked = True
            End Select

            Buscar()

        End Sub
        Private Sub ListarSubtipo()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            objSubBss = New Bussines.Registro.Documento.DocumentoJudicialSubTipo
            objSubEntCol = New Entity.Registro.Documento.DocumentoJudicialSubTipoCol
            Select Case Me.GrillaCodigo
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana And Me.GrillaCodigo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                        objSubEntCol = Nothing
                        dgwGrilla.Size = New Size(445, 246)
                        dgwGrillaSubtipo.Visible = False
                    Else
                        objSubEntCol = objSubBss.Listar(Me.GrillaCodigo, Me.DocumentoCategoria)
                        dgwGrilla.Size = New Size(207, 246)
                        dgwGrillaSubtipo.Visible = True
                    End If
                Case Else
                    objSubEntCol = Nothing
                    dgwGrilla.Size = New Size(445, 246)
                    dgwGrillaSubtipo.Visible = False
            End Select
            With Me.dgwGrillaSubtipo
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objSubEntCol
            End With
        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick
            dgwGrilla_CellClick(Nothing, Nothing)
        End Sub
        Private Sub dgwGrilla_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyUp
            dgwGrilla_CellClick(Nothing, Nothing)
        End Sub

        Private Sub rdbEgreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbEgreso.CheckedChanged
            Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Egreso
        End Sub

        Private Sub rdbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTodos.CheckedChanged
            Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Todos
        End Sub

        Private Sub rdbIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbIngreso.CheckedChanged
            Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Ingreso
        End Sub

        Private Sub rdbSentencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSentencia.CheckedChanged
            Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Sentencia
        End Sub

        Private Sub rdbAclarados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAclarados.CheckedChanged
            Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Aclarados
        End Sub

        Private Sub dgwGrilla_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgwGrilla.Validated
            dgwGrilla_CellClick(Nothing, Nothing)
        End Sub

        Private Sub dgwGrillaSubtipo_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaSubtipo.CellDoubleClick
            btnOk_Click(Nothing, Nothing)
        End Sub
    End Class
End Namespace


