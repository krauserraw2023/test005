Namespace Registro.Documento
    Public Class uscMandatoDetencion_LM
        'Public Event _CellDoubleClick_GrillaExpediente(IngresoCodigo As Integer, ExpedienteCodigo As Integer)
        Public Event _CellDoubleClick_GrillaExpediente(ExpedienteCodigo As Integer)
        Public Event _CellDoubleClick_GrillaDelito(IngresoInpeId As Integer, ExpedienteCodigo As Integer, DelitoCodigo As Integer)
        Public Event _CellDoubleClick_GrillaAgraviado(IngresoCodigo As Integer, ExpedienteCodigo As Integer, DelitoCodigo As Integer, AgraviadoCodigo As Integer)

#Region "Propiedades"
        Public Property _IDIngresoINPE() As Integer = -1
        ' Public Property _IngresoID() As Integer = -1lkjsdklnfdsklnj
        Public Property _InternoID() As Integer = -1
        Public Property _InternoEstado() As Integer = -1 '1 activo --0 inactivo
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property _objEntCol As Entity.Registro.ExpedienteCol = Nothing
        Public Property _ObjEntExp As Entity.Registro.Expediente = Nothing
        Public Property _ObjEntDel As Entity.Registro.Delito = Nothing
        Public Property _ObjEntAgr As Entity.Registro.Agraviado = Nothing
        Public Property _ObjEntAgrCol As Entity.Registro.AgraviadoCol = Nothing

        Private objEntCol1 As New Entity.Registro.AgraviadoCol
        Private objEntCol2 As New Entity.Registro.DelitoCol
        Dim objBssExp As Bussines.Registro.Expediente
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objBssPadre As Bussines.Registro.InternoExpedientePadre
        Private objBssPadin As New Bussines.Estadistica.PadinDelito
#End Region

#Region "Propiedades Publicas"

        Private blnVisibleAnulacion As Boolean = False
        Public Property _VisibleAnulacion() As Boolean
            Get
                Return blnVisibleAnulacion
            End Get
            Set(ByVal value As Boolean)
                blnVisibleAnulacion = value
                VisibleControles()
            End Set
        End Property
        Private blnVisiblePadin As Boolean = False
        Public Property _VisiblePadin() As Boolean
            Get
                Return blnVisiblePadin
            End Get
            Set(ByVal value As Boolean)
                blnVisiblePadin = value
                VisibleControles()
            End Set
        End Property
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    v = 1
                End If
                Return v
            End Get
        End Property
        Public Property _Grabar As Boolean = False
#End Region
#Region "Propieades_Grilla"
        Private ReadOnly Property GrillaTipoDocumento() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwExpediente
                        intValue = .SelectedRows(0).Cells("col_tip_doc").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaDocumentoJudicialID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwExpediente
                        intValue = .SelectedRows(0).Cells("col_doc_jud_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwExpediente
                        intValue = .SelectedRows(0).Cells("col_exp_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoExpedienteCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDelito
                        intValue = .SelectedRows(0).Cells("col_expediente_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteNumero() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwExpediente
                        strValue = .SelectedRows(0).Cells("col_exp_num").Value
                    End With
                Catch ex As Exception

                End Try

                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDelito
                        intValue = .SelectedRows(0).Cells("col_del_id").Value
                    End With
                Catch ex As Exception
                    intValue = -1
                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoEspecificoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDelito
                        intValue = .SelectedRows(0).Cells("col_del_esp_id").Value
                    End With
                Catch ex As Exception
                    intValue = -1
                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoGenericoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDelito
                        intValue = .SelectedRows(0).Cells("col_del_gen_id").Value
                    End With
                Catch ex As Exception
                    intValue = -1
                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoEspecificoNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwDelito
                        strValue = .SelectedRows(0).Cells("col_del_esp_nom").Value
                    End With
                Catch ex As Exception
                    strValue = -1
                End Try

                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoGenericoNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwDelito
                        strValue = .SelectedRows(0).Cells("col_del_gen_nom").Value
                    End With
                Catch ex As Exception
                    strValue = -1
                End Try

                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaAgraviadoCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwAgraviado
                        intValue = .SelectedRows(0).Cells("col_agr_id").Value
                    End With
                Catch ex As Exception
                    intValue = -1
                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIngresoCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwExpediente
                        intValue = .SelectedRows(0).Cells("col_int_ing").Value
                    End With
                Catch ex As Exception
                    intValue = -1
                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaCondicion() As Boolean
            Get
                Dim intValue As Boolean = -1
                Try
                    With Me.dgwExpediente
                        intValue = .SelectedRows(0).Cells("col_condicion").Value
                    End With
                Catch ex As Exception
                    intValue = False
                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaTipoLibertadId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwExpediente
                        intValue = .SelectedRows(0).Cells("col_tip_lib_id").Value
                    End With
                Catch ex As Exception
                    intValue = False
                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaAnulacionEstadoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwExpediente
                        intValue = .SelectedRows(0).Cells("col_anu_est_id").Value
                    End With
                Catch ex As Exception
                    intValue = False
                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaAnulacionDelitoEstadoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDelito
                        intValue = .SelectedRows(0).Cells("col_anu_del_est_id").Value
                    End With
                Catch ex As Exception
                    intValue = False
                End Try

                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_GrillaCount"
        Private intGrillaCountIngreso As Integer = 0
        Private intGrillaCountExp As Integer = 0
        Private intGrillaCountDel As Integer = 0
        Private intGrillaCountAgra As Integer = 0

        Private Property GrillaCountExp() As Integer
            Get
                Return intGrillaCountExp
            End Get
            Set(ByVal value As Integer)
                intGrillaCountExp = value
                Me.lblRegExp.Text = intGrillaCountExp.ToString & " Reg."
            End Set
        End Property
        Private Property GrillaCountDel() As Integer
            Get
                Return intGrillaCountDel
            End Get
            Set(ByVal value As Integer)
                intGrillaCountDel = value
                Me.lblRegDelito.Text = intGrillaCountDel.ToString & " Reg."
            End Set
        End Property
        Private Property GrillaCountAgra() As Integer
            Get
                Return intGrillaCountAgra
            End Get
            Set(ByVal value As Integer)
                intGrillaCountAgra = value
                Me.lblRegAgra.Text = intGrillaCountAgra.ToString & " Reg."
            End Set
        End Property
#End Region
#Region "Listar"
        Public Sub _ListarExpediente()
            ListarExpediente()
        End Sub
        Private Sub ListarExpediente()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            _objEntCol = New Entity.Registro.ExpedienteCol
            Dim objTmp As New Entity.Registro.Expediente
            Dim objBss As New Bussines.Registro.Expediente
            objTmp.IngresoInpeId = Me._IDIngresoINPE
            objTmp.InternoID = Me._InternoID
            objTmp.ExpedienteVisible = 1
            objTmp.Anulacion = -1
            _objEntCol = objBss.Listar_LM_v2(objTmp)

            With Me.dgwExpediente
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = _objEntCol
                Me.GrillaCountExp = .RowCount
            End With

            If Me.dgwExpediente.RowCount > 0 Then
                ListarDelito()
            Else
                Me.dgwDelito.DataSource = ""
                Me.dgwAgraviado.DataSource = ""
            End If
        End Sub

        Private Sub ListarExpedienteSeleccionado()

            If Me._InternoID < 1 Then Exit Sub
            Dim NumeroDeFilaSeleccionada As Integer = dgwExpediente.SelectedRows.Item(0).Index  '  dgwExpediente.CurrentRow.Index

            _objEntCol = New Entity.Registro.ExpedienteCol
            Dim objTmp As New Entity.Registro.Expediente
            Dim objBss As New Bussines.Registro.Expediente
            objTmp.IngresoID = -1 ' Me.IngresoID
            objTmp.IngresoInpeId = Me._IDIngresoINPE
            objTmp.InternoID = Me._InternoID
            objTmp.ExpedienteVisible = 1
            objTmp.Anulacion = -1
            _objEntCol = objBss.Listar_LM(objTmp)

            With Me.dgwExpediente
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = _objEntCol
                Me.GrillaCountExp = .RowCount
            End With
            dgwExpediente.Rows(NumeroDeFilaSeleccionada).Selected = True
            ListarDelito()
        End Sub

        Dim objEntDelitoCol As Entity.Registro.DelitoCol
        Dim objEntAgraviadoTempoCol As New Entity.Registro.AgraviadoCol
        Private Sub ListarDelito()

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                If Me._InternoID < 1 Or Me._IDIngresoINPE < 1 Or Me.GrillaExpedienteCodigo < 1 Then
                    Exit Sub
                End If
            Else
                If Me._InternoID < 1 Or Me._IDIngresoINPE < 1 Or Me.GrillaExpedienteCodigo < 1 Then
                    Exit Sub
                End If
            End If


            Dim objBss As New Bussines.Registro.Delito
            Dim objEntDelitoTempoCol As New Entity.Registro.DelitoCol
            Dim objEntAgraviadoCol As New Entity.Registro.AgraviadoCol
            Dim objBssAgraviado As New Bussines.Registro.InternoAgraviado
            Dim objDelito As Entity.Registro.Delito
            If Me.GrillaTipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
               Me.GrillaTipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
               Me.GrillaTipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                Dim objEntExpedienteTempoCol2 As New Entity.Registro.ExpedienteCol

                objBssExp = New Bussines.Registro.Expediente
                objEntExpedienteTempoCol2 = objBssExp.ListarExpedientexResolucion(Me.GrillaDocumentoJudicialID)
                Dim intConta As Integer = -1
                Dim objEntDelitoCol_copi As New Entity.Registro.DelitoCol
                For Each obj_ As Entity.Registro.Expediente In objEntExpedienteTempoCol2

                    objEntDelitoCol = New Entity.Registro.DelitoCol
                    objDelito = New Entity.Registro.Delito
                    objDelito.Codigo = -1
                    objDelito.IngresoID = obj_.IngresoID
                    objDelito.InternoID = obj_.InternoID
                    objDelito.ExpedienteID = obj_.Codigo
                    objEntDelitoCol = objBss.Listar2(objDelito)
                    Dim objEntDelito_copi As New Entity.Registro.Delito
                    For Each objDel As Entity.Registro.Delito In objEntDelitoCol
                        Dim Valor As Integer = 0
                        Dim intInd As Integer = -1
                        For Each objEntDel As Entity.Registro.Delito In objEntDelitoCol_copi
                            intInd = intInd + 1
                            If objDel.DelitoEspecifico = objEntDel.DelitoEspecifico Then
                                objEntDelito_copi = objEntDel
                                Valor = 1
                                Exit For
                            End If
                        Next
                        Dim codExpHis As Integer = -1
                        If Valor = 0 Then
                            objEntDelitoCol_copi.Add(objDel)
                            objEntDelitoTempoCol.Add(objDel)
                        Else
                            codExpHis = objEntDelito_copi.ExpedienteID
                        End If
                        objDel.DelitoAuxiliar = False

                    Next
                Next
                objEntCol2 = objEntDelitoTempoCol
            Else
                objDelito = New Entity.Registro.Delito
                ' objDelito.IngresoID = Me._IngresoID
                objDelito.InternoID = Me._InternoID
                objDelito.ExpedienteID = Me.dgwExpediente.SelectedRows(0).Cells("col_exp_id").Value ' Me.GrillaExpedienteCodigo
                objDelito.Anulacion = 0
                objEntCol2 = objBss.Listar2(objDelito)
            End If
            With Me.dgwDelito
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol2
                Me.GrillaCountDel = .RowCount
            End With

            If Me.dgwDelito.RowCount > 0 Then
                ListarAgraviado()
            Else
                Me.dgwAgraviado.DataSource = ""
            End If
        End Sub
        Public Sub _ListarDelito()
            ListarDelito()
        End Sub
        Private Sub ListarAgraviado()
            'listar 4-2

            'If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
            If Me._InternoID < 1 Or Me._IDIngresoINPE < 1 Or Me.GrillaExpedienteCodigo < 1 Or Me.GrillaDelitoCodigo < 1 Then
                Exit Sub
            End If

            objBssDelito = New Bussines.Registro.Delito
            Dim objBss As New Bussines.Registro.InternoAgraviado

            If Me.GrillaTipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
               Me.GrillaTipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
               Me.GrillaTipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                Dim entDel As New Entity.Registro.Delito
                entDel.CreaDocJudicialId = Me.GrillaDocumentoJudicialID
                entDel.DelitoEspecifico = Me.GrillaDelitoEspecificoID
                'entDel.IngresoID = Me._IngresoID
                entDel.InternoID = Me._InternoID

                Dim entExp As New Entity.Registro.Expediente
                entExp.InternoID = Me._InternoID
                'entExp.IngresoID = Me._IngresoID
                entExp.DelitoEspecificoID = Me.GrillaDelitoEspecificoID
                entExp.CreaDocJudicialId = Me.GrillaDocumentoJudicialID

                objEntCol1 = objBss.Listar2(entExp)
                Dim objEntCol1_copi As New Entity.Registro.AgraviadoCol
                Dim AgraviadoCon As Integer = 0
                For Each obj As Entity.Registro.Agraviado In objEntCol1
                    AgraviadoCon = 0
                    For Each obj2 As Entity.Registro.Agraviado In objEntCol1_copi
                        Dim ent1 As New Entity.Registro.Delito
                        Dim ent2 As New Entity.Registro.Delito
                        ent1 = objBssDelito.Listar(obj.DelitoID)
                        ent2 = objBssDelito.Listar(obj2.DelitoID)
                        If obj.AgraviadoNombre = obj2.AgraviadoNombre And
                             ent1.DelitoEspecifico = ent2.DelitoEspecifico Then
                            AgraviadoCon = AgraviadoCon + 1
                            Exit For
                        End If
                    Next
                    If AgraviadoCon = 0 Then
                        objEntCol1_copi.Add(obj)
                    End If
                Next
                objEntCol1 = objEntCol1_copi
            Else
                'objEntCol1 = objBss.Listar(-1, Me.GrillaDelitoCodigo, Me.InternoID, _
                '                  Me.IngresoID, Me.GrillaExpedienteCodigo, -1, "")
                Dim objEnt As New Entity.Registro.Agraviado
                With objEnt
                    .Codigo = -1
                    .DelitoID = Me.GrillaDelitoCodigo
                    .InternoID = Me._InternoID
                    '.IngresoID = Me._IngresoID
                    .ExpedienteID = Me.GrillaExpedienteCodigo
                    .TipoSentenciaId = -1
                    .AgraviadoNombre = ""
                End With
                objEnt.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                objEntCol1 = objBss.Listar(objEnt)

            End If
            With Me.dgwAgraviado
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol1
                Me.GrillaCountAgra = .RowCount
            End With
            Me._ObjEntAgrCol = objEntCol1
        End Sub
        Public Sub _ListarAgraviado()
            ListarAgraviado()
        End Sub
#End Region

#Region "Otros"
        Public Sub _LoadUsc()

            ValoresxDefault()
            ListarExpediente()

        End Sub

        Private Sub ValoresxDefault()
            With Me.dgwExpediente
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            btnEliminar.Visible = Me._VisibleAnulacion
        End Sub
        Private Sub VisibleControles()

            Me.col_exp_anulacion.Visible = Me._VisibleAnulacion
            Me.col_del_anulacion.Visible = Me._VisibleAnulacion
            Me.col_agr_anulacion.Visible = Me._VisibleAnulacion

            Me.col_dmp.Visible = Me._VisiblePadin
            Me.col_smp.Visible = Me._VisiblePadin
            Me.col_n1.Visible = Me._VisiblePadin
            Me.col_n2.Visible = Me._VisiblePadin

        End Sub
        'J.E.U Actualizar Padindelitos 23/04/2021
        Private Sub GrabarDelitoPadin(objEntDel As Entity.Registro.Delito, TipoSituacionJuridica As Integer, Optional blnSW As Boolean = False)
            Dim obj As New Entity.Estadistica.PadinDelito

            With objEntDel
                obj.TipoSituacionJuridica = TipoSituacionJuridica
                obj.ExpedienteId = Me.GrillaExpedienteCodigo
                obj.ExpedienteNumero = Me.GrillaExpedienteNumero
                obj.DocumentoJudicialId = Me.GrillaDocumentoJudicialID
                obj.DelitoEspecificoId = Me.GrillaDelitoEspecificoID
                obj.DelitoEspecificoNombre = Me.GrillaDelitoEspecificoNombre
                obj.DelitoGenericoId = Me.GrillaDelitoGenericoID
                obj.DelitoGenericoNombre = Me.GrillaDelitoGenericoNombre

                obj.InternoId = Me._InternoID
                obj.IngresoId = -1
                obj.IngresoInpeId = Me._IDIngresoINPE
                obj.InternoDelitoId = objEntDel.Codigo
                obj.DelitoMayorPena = objEntDel.DelitoMayorPena
                obj.DelitoSentenciaMayorPena = objEntDel.DelitoSentenciaMayorPena
                obj.RegionID = Me.RegionID
                obj.PenalID = Me.PenalID
            End With

            objBssPadin.Grabar(obj, blnSW)
        End Sub
#End Region
#Region "Eventos"
        Private Sub dgwExpediente_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellDoubleClick
            If Me.dgwExpediente.RowCount > 0 Then
                Select Case e.ColumnIndex
                    Case Me.dgwExpediente.Columns("col_dmp").Index, Me.dgwExpediente.Columns("col_smp").Index
                    Case Else
                        _ObjEntExp = _objEntCol.Item(dgwExpediente.SelectedRows(0).Index)
                        RaiseEvent _CellDoubleClick_GrillaExpediente(Me.GrillaExpedienteCodigo)
                End Select
            End If
        End Sub
        Private Sub dgwDelito_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellDoubleClick
            If Me.dgwDelito.RowCount > 0 Then
                Select Case e.ColumnIndex
                    Case Me.dgwDelito.Columns("col_n1").Index, Me.dgwDelito.Columns("col_n2").Index
                    Case Else
                        For Each EntDel As Entity.Registro.Delito In objEntCol2
                            If Val(dgwDelito.SelectedRows(0).Cells("col_del_id").Value) = EntDel.Codigo Then
                                EntDel.VisibleAuxiliar = True
                                Me._ObjEntDel = EntDel
                                Exit For
                            End If
                        Next
                        RaiseEvent _CellDoubleClick_GrillaDelito(Me._IDIngresoINPE, Me.GrillaExpedienteCodigo, Me.GrillaDelitoCodigo)
                End Select
            End If

        End Sub

        Private Sub dgwAgraviado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwAgraviado.CellDoubleClick

            If Me.dgwAgraviado.RowCount > 0 Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntCol1
                    If Val(dgwAgraviado.SelectedRows(0).Cells("col_agr_id").Value) = EntAgr.Codigo Then
                        Me._ObjEntAgr = EntAgr
                        Exit For
                    End If
                Next
                RaiseEvent _CellDoubleClick_GrillaAgraviado(Me._IDIngresoINPE, Me.GrillaExpedienteCodigo, Me.GrillaDelitoCodigo, Me.GrillaAgraviadoCodigo)
            End If
        End Sub

        Private Sub dgwExpediente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellClick

            If e.RowIndex >= 0 Then

                ListarDelito()

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then Exit Sub

                Select Case e.ColumnIndex

                    Case Me.dgwExpediente.Columns("col_dmp").Index

                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Este check funciona Seleccionando y/o Desmarcando el Delito n(1)!!!")
                        Exit Sub

                    Case Me.dgwExpediente.Columns("col_smp").Index

                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                       "Este check funciona Seleccionando y/o Desmarcando el Delito n(2)!!!")
                        Exit Sub
                End Select
            End If

        End Sub
        Private Sub dgwDelito_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellClick

            If e.RowIndex >= 0 Then
                ListarAgraviado()
                Dim objBssExp As New Bussines.Registro.Expediente
                Dim objBss As New Bussines.Registro.Delito
                Dim strPregunta As String
                Dim intContadorLib As Integer = 0

                If Me._IDIngresoINPE < 1 Then
                    MessageBox.Show("Seleccione el numero de ingreso", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then Exit Sub

                Dim Quitar As Boolean = False
                Select Case e.ColumnIndex
                    Case Me.dgwDelito.Columns("col_n1").Index
                        If Me.GrillaAnulacionEstadoId = 2 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar este delito, porque pertenece a un proceso Anulado", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                            Exit Sub
                        End If
                        If Me.GrillaAnulacionDelitoEstadoId = 2 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar este delito, porque se encuentra en estado Anulado", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                            Exit Sub
                        End If
                        For Each obj As Entity.Registro.Expediente In _objEntCol
                            If obj.LibertadTipoID > 0 Then
                                intContadorLib += 1
                            End If
                        Next
                        If _objEntCol.Count = intContadorLib Then
                            For Each obj As Entity.Registro.Expediente In _objEntCol
                                If obj.Principal = True Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar este delito, porque pertenece a un proceso en Libertad", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                                    Exit Sub
                                End If
                            Next
                        Else
                            If Me.GrillaTipoLibertadId > 0 Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar este delito, porque pertenece a un proceso en Libertad", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                                Exit Sub
                            End If
                        End If
                        'If blnSMP Then  'TIENE SENTENCIA DE MAYOR PENA
                        If dgwDelito.SelectedRows(0).Cells("col_n1").Value().ToString = "True" Then
                            strPregunta = "Desea excluir(quitar) el delito de mayor pena, como parte del expediente actual ?, esta informacion sera procesada en el Reporte Padin."
                            Quitar = True
                        Else
                            strPregunta = "Desea confirmar que el Delito actual sea el de Mayor Pena, esta informacion sera procesada en el Reporte Padin."
                            Quitar = False
                        End If
                        Dim blnRespuesta As Windows.Forms.DialogResult
                        blnRespuesta = MessageBox.Show(strPregunta, "Seleccione Opcion...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                        Dim objEntDel As New Entity.Registro.Delito
                        objEntDel.FlagTransferenciaSede = 0 'Me.FlagTransferSede
                        objEntDel.InternoID = Me._InternoID
                        objEntDel.IngresoInpeId = Me._IDIngresoINPE
                        objEntDel.Codigo = Me.GrillaDelitoCodigo
                        Select Case Me.GrillaTipoDocumento
                            Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes,
                                Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                                Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                                objEntDel.ExpedienteID = Me.GrillaDelitoExpedienteCodigo
                            Case Else
                                objEntDel.ExpedienteID = Me.GrillaExpedienteCodigo
                        End Select
                        Dim blnSW As Boolean = False
                        If blnRespuesta = DialogResult.Yes Then
                            If Quitar = False Then
                                objEntDel.DelitoMayorPena = True
                            Else
                                objEntDel.DelitoMayorPena = False
                                blnSW = True
                            End If
                            objBss.ActualizarDelitoMayorPena_LM(objEntDel)
                            GrabarDelitoPadin(objEntDel, Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado, blnSW)
                            ListarExpedienteSeleccionado()
                            Legolas.Configuration.Aplication.MessageBox.Information("Operación realizada satisfactoriamente")
                        ElseIf blnRespuesta = DialogResult.No Then
                            If Quitar = False Then
                                objEntDel.DelitoMayorPena = False
                            Else
                                objEntDel.DelitoMayorPena = True
                            End If
                            objBss.ActualizarDelitoMayorPena_LM(objEntDel)
                            ListarExpedienteSeleccionado()
                        End If
                    Case Me.dgwDelito.Columns("col_n2").Index 'Cuando trabajamos con SMP
                        If Me.GrillaAnulacionEstadoId = 2 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar este delito, porque pertenece a un proceso Anulado", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                            Exit Sub
                        End If
                        If Me.GrillaAnulacionDelitoEstadoId = 2 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar este delito, porque se encuentra en estado Anulado", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                            Exit Sub
                        End If

                        Dim blnSW As Boolean = False
                        If dgwExpediente.SelectedRows(0).Cells("sentencia").Value <> "" Then
                            For Each obj As Entity.Registro.Expediente In _objEntCol
                                If obj.LibertadTipoID > 0 Then
                                    intContadorLib += 1
                                End If
                            Next
                            If _objEntCol.Count = intContadorLib Then
                                For Each obj As Entity.Registro.Expediente In _objEntCol
                                    If obj.SentenciaPrincipal = True Then
                                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar este delito, porque pertenece a un proceso en Libertad", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                                        Exit Sub
                                    End If
                                Next
                            Else
                                If Me.GrillaTipoLibertadId > 0 Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar este delito, porque pertenece a un proceso en Libertad", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                                    Exit Sub
                                End If
                            End If
                            If dgwDelito.SelectedRows(0).Cells("col_n2").Value().ToString = "True" Then
                                strPregunta = "Desea excluir(quitar) el delito seleccionado, como parte de la sentencia de mayor pena?, esta informacion sera procesada en el Reporte Padin."
                                Quitar = True
                            Else
                                strPregunta = "Desea considerar el delito seleccionado, su expediente actual como parte de la sentencia de mayor pena?," + Chr(13) +
                                                  "esta informacion sera procesada en el Reporte Padin."
                                Quitar = False
                            End If
                            Dim blnRespuesta As Windows.Forms.DialogResult
                            blnRespuesta = MessageBox.Show(strPregunta, "Seleccione Opcion...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                            Dim objEntDel As New Entity.Registro.Delito
                            objEntDel.FlagTransferenciaSede = 0
                            objEntDel.InternoID = Me._InternoID
                            objEntDel.IngresoInpeId = Me._IDIngresoINPE
                            objEntDel.Codigo = Me.GrillaDelitoCodigo
                            Select Case Me.GrillaTipoDocumento
                                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes,
                                    Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                                    Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                                    objEntDel.ExpedienteID = Me.GrillaDelitoExpedienteCodigo
                                Case Else
                                    objEntDel.ExpedienteID = Me.GrillaExpedienteCodigo
                            End Select
                            If blnRespuesta = DialogResult.Yes Then
                                objBssExp = New Bussines.Registro.Expediente
                                Dim entExp As New Entity.Registro.Expediente
                                entExp.FlagTransferenciaSede = 0
                                entExp.InternoID = Me._InternoID
                                entExp.IngresoInpeId = Me._IDIngresoINPE

                                Dim objEntDel2 As New Entity.Registro.Delito
                                If Quitar = False Then
                                    entExp.int_sen_pad = True
                                    '    objBssExp.ActualizarSentenciaMayorPena_LM(entExp)

                                    objEntDel.DelitoMayorPena = True
                                    objEntDel.DelitoSentenciaMayorPena = True

                                    objBss.ActualizarSentenciaMayorPena_LM(objEntDel)
                                    objEntDel2.DelitoMayorPena = 1
                                    objEntDel2.InternoID = Me._InternoID
                                    objEntDel2.IngresoInpeId = Me._IDIngresoINPE
                                    If objBss.Listar2_LM(objEntDel2).Count = 0 Then
                                        objBss.ActualizarDelitoMayorPena_LM(objEntDel)
                                    End If
                                    Dim entInt As New Bussines.Registro.Interno
                                    If objEntDel.DelitoSentenciaMayorPena = True Then
                                        entInt.ActualizarInternoSMP(Me._InternoID, Me._IDIngresoINPE)
                                    End If
                                Else
                                    blnSW = True
                                    entExp.int_sen_pad = False
                                    'objBssExp.ActualizarSentenciaMayorPena_LM(entExp)
                                    objEntDel2.DelitoMayorPena = 0
                                    objEntDel2.InternoID = Me._InternoID
                                    objEntDel2.IngresoInpeId = Me._IDIngresoINPE
                                    objEntDel2.Codigo = Me.GrillaDelitoCodigo
                                    objBss.ActualizarSentenciaMayorPena_LM(objEntDel)
                                End If
                                GrabarDelitoPadin(objEntDel, Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado, blnSW)
                                ListarExpedienteSeleccionado()
                                Legolas.Configuration.Aplication.MessageBox.Information("Operación realizada satisfactoriamente")
                            ElseIf blnRespuesta = DialogResult.No Then
                                If Quitar = False Then
                                    Dim blnSMP As Boolean = False
                                    Dim objDelitoCol As New Entity.Registro.DelitoCol
                                    Dim objDelito As New Entity.Registro.Delito
                                    objDelito.InternoID = Me._InternoID
                                    objDelito.IngresoInpeId = Me._IDIngresoINPE
                                    objDelitoCol = objBssDelito.Listar2_LM(objDelito)
                                    For Each objExpSMP As Entity.Registro.Delito In objDelitoCol
                                        If objExpSMP.DelitoSentenciaMayorPena = "True" Then
                                            blnSMP = True
                                            Exit For
                                        End If
                                    Next
                                    If blnSMP = False Then
                                        objBssExp = New Bussines.Registro.Expediente
                                        Dim entExp As New Entity.Registro.Expediente
                                        entExp.FlagTransferenciaSede = 0
                                        entExp.InternoID = Me._InternoID
                                        entExp.IngresoInpeId = Me._IDIngresoINPE
                                        entExp.Codigo = Me.GrillaExpedienteCodigo

                                        entExp.int_sen_pad = False
                                        objBssExp.ActualizarSentenciaMayorPena_LM(entExp)
                                    Else
                                        objBssExp = New Bussines.Registro.Expediente
                                        Dim entExp As New Entity.Registro.Expediente
                                        entExp.FlagTransferenciaSede = 0
                                        entExp.InternoID = Me._InternoID
                                        entExp.IngresoInpeId = Me._IDIngresoINPE
                                        entExp.Codigo = Me.GrillaExpedienteCodigo

                                        entExp.int_sen_pad = True
                                        objBssExp.ActualizarSentenciaMayorPena_LM(entExp)
                                    End If
                                End If
                                ListarExpedienteSeleccionado()
                            End If
                        Else
                            If dgwDelito.SelectedRows(0).Cells("col_n2").Value().ToString = "True" Then
                                strPregunta = "Desea excluir(quitar) el delito seleccionado." + Chr(13) +
                                                  "ya que pertenece a un expediente que no registra sentencia."
                                If MessageBox.Show(strPregunta, "Seleccione Opcion...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    Dim objEntDel As New Entity.Registro.Delito
                                    objEntDel.InternoID = Me._InternoID
                                    objEntDel.IngresoID = Me._IDIngresoINPE
                                    objEntDel.Codigo = Me.GrillaDelitoCodigo
                                    Dim objEntDel2 As New Entity.Registro.Delito
                                    objBssExp = New Bussines.Registro.Expediente
                                    Dim entExp As New Entity.Registro.Expediente
                                    entExp.InternoID = Me._InternoID
                                    entExp.IngresoInpeId = Me._IDIngresoINPE
                                    entExp.int_sen_pad = False
                                    objBssExp.ActualizarSentenciaMayorPena(entExp)
                                    objEntDel2.DelitoMayorPena = 0
                                    objEntDel2.InternoID = Me._InternoID
                                    objEntDel2.IngresoInpeId = Me._IDIngresoINPE
                                    objEntDel2.Codigo = Me.GrillaDelitoCodigo
                                    objBss.ActualizarSentenciaMayorPena_v5(objEntDel)
                                    blnSW = True
                                    GrabarDelitoPadin(objEntDel, Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado, blnSW)
                                    ListarExpedienteSeleccionado()
                                    Legolas.Configuration.Aplication.MessageBox.Information("Operación realizada satisfactoriamente")
                                End If
                            Else
                                Legolas.Configuration.Aplication.MessageBox.Information("El delito seleccionado pertenece a un expediente" + Chr(13) +
                                                                               "que no registra sentencia.")
                            End If
                        End If
                End Select
            End If

        End Sub
#End Region

        Private Sub dgwExpediente_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyUp
            ListarDelito()
        End Sub

        Private Sub dgwDelito_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDelito.KeyUp
            ListarAgraviado()
        End Sub

        Private Sub dgwExpediente_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellContentClick

        End Sub

        Private Sub dgwDelito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDelito.CellContentClick

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            Dim bss As New Bussines.Registro.Expediente
            Dim objCol As New Entity.Registro.ExpedienteCol
            Dim blnSw As Boolean = False
            Dim strMensaje As String = ""
            objCol = bss.ListarExpedientexResolucion_LM(Me.GrillaDocumentoJudicialID)
            Dim obj As New Entity.Registro.Expediente
            For Each obj In objCol
                If obj.DocumentoTipoID = 35 Then
                    blnSw = True
                    Exit For
                End If
            Next
            If blnSw = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("El proceso " & GrillaExpedienteNumero & " tiene los siguientes datos :" + Chr(13) +
                                                                              "Fecha de recepción: " & obj.ExpedienteFechaDocRecepcionDate + Chr(13) +
                                                                              "Fecha de documento: " & obj.ExpedienteFechaDate + Chr(13) +
                                                                              "Procesos duplicados: " & "0" + Chr(13) +
                                                                              "" + Chr(13) +
                                                                              "Desea eliminar de todas maneras el documento.") = DialogResult.Yes Then
                    bss.Eliminar_LM(Me.GrillaExpedienteCodigo)
                    ListarExpediente()
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede eliminar el expediente : " & GrillaExpedienteNumero + Chr(13) +
                                                                        "Porque esta referenciado por un documentos judicial.")
            End If
        End Sub
    End Class

End Namespace
