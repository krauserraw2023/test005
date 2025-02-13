Imports Type.Enumeracion.Licencia
Namespace Registro.Expediente.v5
    Public Class frmListaDocumentosPopup
        Private objBss As Bussines.Registro.Expediente = Nothing
        Private objBssPad As Bussines.Registro.InternoExpedientePadre = Nothing
        Private objEnt As Entity.Registro.Expediente = Nothing
        Private objEntExpediente As Entity.Registro.Documento.DocumentoJudicialExpediente
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntPeriodoCondenaTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
        Private objEntDelitoCol As Entity.Registro.DelitoCol
        Private objEntAgraviadoCol As Entity.Registro.AgraviadoCol

        Public objEntDelitoTempoCol2 As New Entity.Registro.DelitoCol
        Public objEntAgraviadoTempoCol2 As New Entity.Registro.AgraviadoCol
        Public objDocumJudicialCol As Entity.Registro.DocumentoJudicialCol
        Private objDocumJudicial As Entity.Registro.DocumentoJudicial


#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _IngresoID As Integer = -1
        Public Property _IngresoInpeID As Integer = -1
        Public Property _TemporalNuevo As Boolean = False
        Public Property _NuevoExpediente As Boolean = False
        Public Property _SituacionJuridicaExpe As Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
        Public Property _TipoResolucion As Integer = -1
        Public Property _TipoLicencia As Integer = -1

        Public ReadOnly Property _GrillaExpedienteIdSeleccionado() As Integer
            Get

                Return Me.GrillaExpedienteId

            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteId() As Integer
            Get
                Try
                    Return dgwExpediente2.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
#End Region
#Region "Variables_Temporales"
        Public objEntExpedienteTempoCol As Entity.Registro.Documento.DocumentoJudicialExpedienteCol = Nothing
        Public objEntExpedienteTempoColCopi As Entity.Registro.ExpedienteCol = Nothing
        Public objEntExpedienteTempoColCopi2 As New Entity.Registro.ExpedienteCol
        Public objEntDocumentoCol As New Entity.Registro.DocumentoJudicialCol
#End Region
#Region "Propiedades_Publicas"
        Private blnVisibleGrabar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
                ShowControl()
            End Set
        End Property
        Public Property _GrillaSeleccionMultiple As Boolean = True
        Public Event _Click_EnviarColection(EntExpCol As Entity.Registro.ExpedienteCol)
#End Region
#Region "Propiedades_Expediente"
        Public Property _TipoAutJudicial() As Integer = -1
        Public Property DocJudicialID As Integer = -1
#End Region

#Region "Listar"

        Public Sub _ListarExpediente(__DocJudicialId As Integer, Optional ByVal CargarMandDetencionHistorico As Boolean = True, Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)
            Dim objReg As New Entity.Registro.DocumentoJudicial
            Dim objRegCol As New Entity.Registro.DocumentoJudicialCol
            objDocumJudicialCol = New Entity.Registro.DocumentoJudicialCol
            objReg.InternoId = Me._InternoID
            objReg.InternoIngresoId = Me._IngresoID
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then

                objRegCol = (New Bussines.Registro.DocumentoJudicial).ListarDocJud_v2_LM(objReg)
            Else

                objRegCol = (New Bussines.Registro.DocumentoJudicial).Listar_DocumentosJudiciales(objReg)
            End If
            For Each obj As Entity.Registro.DocumentoJudicial In objRegCol
                Select Case obj.DocumentoTipo
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                        If obj.IdDocumentoAntecedente < Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total Then
                            obj.DocumentoTipoNombre = obj.DocumentoTipoNombre & "/" & obj.MovimientoMotivoNom
                            objDocumJudicialCol.Add(obj)
                        End If
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado
                        If obj.IdDocumentoAntecedente < Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total Then
                            objDocumJudicialCol.Add(obj)
                        End If
                End Select
            Next
            With Me.dgwExpediente2
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objDocumJudicialCol
                .Refresh()
                lblNroExpedientes.Text = "Documentos " & .Rows.Count & " Reg."
            End With
        End Sub
        Private Sub Temporal_ListarExpediente()
            With Me.dgwExpediente2
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntExpedienteTempoCol
                .Refresh()
                lblNroExpedientes.Text = "Documentos " & .Rows.Count & " Reg."
            End With
        End Sub
        Private Sub TemporalCopiarPropiedades(obj As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)
            With obj
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
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
                .Observacion = ObjEntDestino.Observacion
                .LibertadTipoID = ObjEntDestino.LibertadTipoID
            End With
        End Sub

        Private Sub ListarTemporal()
            _ListarExpediente(Me._Codigo, True, False)
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnNuevo.Visible = Me._FormEscritura
            Me.btnOk.Visible = Me._FormEscritura
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                dgwExpediente2.Columns("col_nro_ing").Visible = True
                btnNuevo.Visible = False
            End If
        End Sub
#End Region
#Region "Accion"

        Private Sub AGrabar()
            If Validar(-1) = False Then
                Exit Sub
            End If
            'ListarDelitos_Inicio()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Dim ValorInt As Integer = 0
        Dim objDocumJudicial_copia As New Entity.Registro.DocumentoJudicialCol
        Public Function Validar(IdExpe) As Boolean
            Dim blnValor As Boolean = False
            Dim blnValorcon As Boolean = False
            Dim strMensaje As String = ""
            If dgwExpediente2.Columns("colu_eleg").Visible = False And dgwExpediente2.Rows.Count > 0 Then
                dgwExpediente2.Item("colu_eleg", dgwExpediente2.SelectedRows(0).Index).Value = True
            End If
            If Me._InternoID = -1 Then
                MsgBox("No se ha enviado el parametro DocJudicialId al objeto", MsgBoxStyle.Critical)
                blnValor = False
            ElseIf dgwExpediente2.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Lista de documentos vacia, operación cancelada")
                dgwExpediente2.Focus()
                blnValor = False
            ElseIf dgwExpediente2.Rows.Count > 0 Then
                objDocumJudicial = New Entity.Registro.DocumentoJudicial
                Dim intConta As Integer = 0
                For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
                    If dgwExpediente2.Item("colu_eleg", i).Value = False Then
                        intConta = intConta + 1
                    Else
                        If Not (objEntDocumentoCol Is Nothing) Then
                            For Each ent As Entity.Registro.DocumentoJudicial In objEntDocumentoCol
                                If ent.DocumentoNumero = objDocumJudicialCol.DocumentoJudicial(i).DocumentoNumero Then
                                    strMensaje = ent.DocumentoNumero
                                    blnValorcon = True
                                    Exit For
                                End If
                            Next
                        End If
                        objDocumJudicial = objDocumJudicialCol.DocumentoJudicial(i)
                        objDocumJudicial_copia.Add(objDocumJudicial)
                    End If
                Next
                If dgwExpediente2.Rows.Count = intConta Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione al menos un documento")
                    dgwExpediente2.Focus()
                    blnValor = False
                Else
                    objDocumJudicialCol = New Entity.Registro.DocumentoJudicialCol
                    objDocumJudicialCol = objDocumJudicial_copia
                    blnValor = True
                End If
                If blnValorcon = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El documento Nº : " & strMensaje & " , ya se encuentra en la lista")
                    dgwExpediente2.Focus()
                    blnValor = False
                End If
            End If


            Return blnValor
        End Function
        Private Function ResolucionNombre(intResID As Integer) As String
            Dim strNombre As String = ""
            Select Case intResID
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                    strNombre = "Aclaratoria"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                    strNombre = "Ampliacion_Autoapertorio"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                    strNombre = "Avocamiento"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion
                    strNombre = "Prolongacion de Detencion"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia
                    strNombre = "Sentencia"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria
                    strNombre = "Sentencia de Aclaratoria"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
                    strNombre = "Sent_Sustitucion_Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Adecuacion_Pena
                    strNombre = "Sent_Adecuacion_Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
                    strNombre = "Sent_Sustitucion_Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior
                    strNombre = "Ejecutoria_Superior"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema
                    strNombre = "Ejecutoria_Suprema"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia
                    strNombre = "Integracion de Sentencia"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia
                    strNombre = "Refundicion de Sentencia"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                    strNombre = "Sumatoria de Sentencia"
            End Select
            Return strNombre
        End Function
        Public Function CargarExpedienteSeleccionado() As Boolean

            objEntExpedienteTempoColCopi = New Entity.Registro.ExpedienteCol
            Dim intValue As Integer = 0
            Dim blnCondicion As Boolean = False
            Dim strNumeroExpediente As String = ""

            For Each EntCopi As Entity.Registro.Expediente In objEntExpedienteTempoColCopi
                For Each EntCopi2 As Entity.Registro.Expediente In objEntExpedienteTempoColCopi2
                    If EntCopi.ExpedienteNumero = EntCopi2.ExpedienteNumero Then
                        blnCondicion = True
                        strNumeroExpediente = EntCopi.ExpedienteNumero
                        Exit For
                        Exit For
                    End If
                Next
            Next
            If Me._GrillaSeleccionMultiple = False Then
                If objEntExpedienteTempoColCopi2.Count > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista ya posee un expediente")
                    Exit Function
                    Return False
                End If
            End If
            If blnCondicion = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente : " & strNumeroExpediente & "  ya se encuentra en la lista")
                Exit Function
                Return False
            End If
            Return True
        End Function
        Public Function CargarExpedienteSeleccionadoCheket() As Boolean

            objEntExpedienteTempoColCopi = New Entity.Registro.ExpedienteCol
            Dim intValue As Integer = 0
            Dim blnCondicion As Boolean = False
            Dim strNumeroExpediente As String = ""

            For Each EntCopi As Entity.Registro.Expediente In objEntExpedienteTempoColCopi
                For Each EntCopi2 As Entity.Registro.Expediente In objEntExpedienteTempoColCopi2
                    If EntCopi.ExpedienteNumero = EntCopi2.ExpedienteNumero Then
                        blnCondicion = True
                        strNumeroExpediente = EntCopi.ExpedienteNumero
                        Exit For
                        Exit For
                    End If
                Next
            Next
            If Me._GrillaSeleccionMultiple = False Then
                If objEntExpedienteTempoColCopi2.Count > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista ya posee un expediente")
                    Exit Function
                    Return False
                End If
            End If
            If blnCondicion = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente : " & strNumeroExpediente & "  ya se encuentra en la lista")
                Exit Function
                Return False
            End If
            Return True
        End Function
#End Region
#Region "Permisos"
        Private Sub ShowControl()
            Me.btnOk.Visible = Me._VisibleGrabar
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            With dgwExpediente2
                .Columns("colu_eleg").HeaderText = ""
                .Columns("colu_num_exp").ReadOnly = True
                .Columns("colu_sit_jur").ReadOnly = True
                .Columns("colu_aut_jud").ReadOnly = True
                .Columns("colu_sal_jud_nom").ReadOnly = True
                .Columns("colu_secre").ReadOnly = True
                .VisibleCampos = False
            End With
        End Sub
#End Region

        Private Sub frmExpedientePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmExpedientePopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            ListarTemporal()
            Usuario_Permiso()
        End Sub


        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub UscListaExpeDeResolucion1__Click_Expediente_Agregar()
            FRM_MantenimientoExpediente(True, Nothing)
        End Sub
        Public blnCondicion As Boolean = True
        Private Sub FRM_MantenimientoExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3()
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    '._InternoID = Me._InternoID
                    '._IngresoID = Me._IngresoID
                    ._TemporalNuevo = True 'temporal nuevo
                Else
                    ._Codigo = objEnt.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                End If
                ._objEntExpediente = objEnt
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    'Me.UscListaExpeDeResolucion1._Temporal_GrabarExpediente(._objEntExpediente)
                    'Me.UscExpeDeResolucion1._Temporal_GrabarExpediente(._objEntExpediente)

                    blnCondicion = True
                    Me.Close()
                End If

            End With
        End Sub
        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            Me._NuevoExpediente = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End Sub
        Private Sub dgwExpediente2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            If Me._GrillaSeleccionMultiple = False Then
                If dgwExpediente2.Columns("colu_sele").Visible = True And dgwExpediente2.Columns("colu_sele").Index = e.ColumnIndex Then
                    For i As Integer = 0 To dgwExpediente2.Rows.Count - 1 'obligar a marcar check a un solo registro (emular radio button)
                        If i <> dgwExpediente2.CurrentCell.RowIndex Then
                            dgwExpediente2.Item("colu_sele", i).Value = False
                        End If
                    Next
                End If
            End If
        End Sub

        Private Sub ckbSeleccionar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbSeleccionar.CheckedChanged
            With dgwExpediente2
                If ckbSeleccionar.Checked = True Then
                    If .Rows.Count > 0 Then
                        For i As Integer = 0 To .Rows.Count - 1
                            .Item("colu_eleg", i).Value = True
                        Next
                    End If
                Else
                    If .Rows.Count > 0 Then
                        For i As Integer = 0 To .Rows.Count - 1
                            .Item("colu_eleg", i).Value = False
                        Next
                    End If

                End If
            End With
        End Sub
        Private Sub dgwExpediente2_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente2.CellDoubleClick
            btnOk.PerformClick()
        End Sub
    End Class
End Namespace
