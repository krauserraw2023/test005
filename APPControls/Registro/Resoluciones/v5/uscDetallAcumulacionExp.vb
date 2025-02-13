Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones

    Public Class uscDetallAcumulacionExp

        '/*bussiness*/
        Private objBssExpediente As Bussines.Registro.Expediente
        Private objBssPerCon As Bussines.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre
        '/*entitys*/
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
        Private objEntExpediente As Entity.Registro.Expediente = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntDelito As Entity.Registro.Delito = Nothing
        Private objEntAgraviado As Entity.Registro.Agraviado = Nothing
        Private objEntAgraviadoAux As Entity.Registro.AgraviadoCol = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Public _blnCadenaPerpetua As Boolean = False
        Public Event _Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito)
        Public Event _Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado)
        'jmr
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
#Region "Eventos"
        Public Event _Click_Expediente_Agregar()
        Public Event _Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)

        Public Event _Click_PeriodoCondena_Agregar()
        Public Event _Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)

        Public Event _Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)

#End Region
#Region "Propiedades"
        Dim bolEdicionActivo As Boolean = False
        Private _btnAgregarPerido As Boolean = True

        Private _btnCajasPeriodo As Boolean = False
#End Region
#Region "Propiedades_Parametricas"
        Public Property _DocumentoJudicialID As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId As Integer = -1
        Public Property _InternoIngresoId As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        '/*revisar*/
        Public Property _PermisoEliminar() As Boolean = False
        Public Property _TipoResolucion As Integer = -1
        Private Property blnEliminarColection As Boolean = False
        Private Property blnEliminarDelitoColec As Boolean = False
        Private Property blnEliminarAgraviadoColec As Boolean = False
        Private Property intCodigoExpediente As Integer = -1
        Public ReadOnly Property _GrillaDelito_ExpItem() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_exp_item").Value
                Catch ex As Exception
                    Return 0
                End Try
            End Get
        End Property
        Public Property _Documentos_sin_mov As Boolean = False
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property _RetornarLista_DocJudicialExpedientes() As Entity.Registro.ExpedienteCol
            Get
                Dim objEntColAux As New Entity.Registro.ExpedienteCol
                If Me._DocumentoJudicialID = -1 Then 'si es nuevo RESOLUCION 
                    For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                        objEntColAux.Add(objEntExpedienteTempoCol.Expediente(i))
                    Next
                    Return objEntColAux
                Else 'si es editar resolucion
                    Return objEntExpedienteTempoCol
                End If
            End Get
        End Property

        '********************** HNRB



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
        Private ReadOnly Property GrillaExpedienteSelect() As Entity.Registro.Expediente
            Get
                objEntExpediente = New Entity.Registro.Expediente

                For Each objExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If Me._GrillaItemExpediente = objExp.ExpedienteItem Then
                        objEntExpediente = objExp
                        Exit For
                    End If
                Next

                Return objEntExpediente

            End Get
        End Property

        Private ReadOnly Property GrillaDocumentoJudID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDelito
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
        Private ReadOnly Property GrillaAgraviadoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwAgraviados
                        intValue = .SelectedRows(0).Cells("col_agr_id").Value

                        If intValue = -1 Then intValue = 0
                    End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property

        Public ReadOnly Property _GrillaItemExpediente() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaItemDelito() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_del_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaItemAgraviado() As Integer
            Get
                Try
                    Return dgwAgraviados.SelectedRows(0).Cells("col_agrav_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property

        Private ReadOnly Property GrilllaAgraviadoSelect() As Entity.Registro.Agraviado
            Get

                objEntAgraviado = New Entity.Registro.Agraviado

                For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If Me._GrillaItemAgraviado = objAgraviado.AgraviadoItem Then
                        objEntAgraviado = objAgraviado
                        Exit For
                    End If
                Next
                Return objEntAgraviado

            End Get
        End Property

#End Region
#Region "Propiedades_Grilla_Select"
        Private ReadOnly Property GrillaExpedienteIndex() As Integer
            Get
                Return Me.dgwExpediente.SelectedRows(0).Index
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
        Private ReadOnly Property GrillaAgraviadoIndex() As Integer
            Get
                Dim value As Integer = -1

                For i As Integer = 0 To objEntAgraviadoTempoCol.Count - 1
                    If Me.GrillaExpedienteID = objEntAgraviadoTempoCol.Item(i).ExpedienteID Then
                        If Me._GrillaItemAgraviado = objEntAgraviadoTempoCol.Item(i).AgraviadoItem Then
                            value = i
                            Exit For
                        End If
                    End If
                Next
                Return value
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
        Private ReadOnly Property Grilla_Agraviados_Delito_Select() As Entity.Registro.AgraviadoCol
            Get

                Dim value As New Entity.Registro.AgraviadoCol

                If dgwDelito.Rows.Count > 0 Then

                    For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If Me._GrillaItemDelito = objAgraviado.DelitoItem Then
                            value.Add(objAgraviado)
                        End If
                    Next
                End If
                Return value
            End Get
        End Property
#End Region
#Region "Temporales"

        Public objEntPeriodoCondenaTempoCol As Entity.Registro.Documento.PeriodoCondenaSentenciaCol = Nothing
        Public objEntExpedienteTempoCol_Prin As Entity.Registro.ExpedienteCol = Nothing
        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Private objEntExpedienteIndc As New Entity.Registro.ExpedienteCol

        Private objEntDelitoIndc As New Entity.Registro.Delito
        Private objEntDelitoIndcCol As New Entity.Registro.DelitoCol
        Private objEntDelitoIndcCol2 As New Entity.Registro.DelitoCol
        Private objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing

        Public objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing
        Private objEntAgraviadosIndcCol As New Entity.Registro.AgraviadoCol
        Private objEntAgraviadosIndcCol2 As New Entity.Registro.AgraviadoCol
        Private objEntAgraviadosIndcCol3 As New Entity.Registro.AgraviadoCol
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing

#Region "Eliminar"
        Private Sub Temporal_EliminarExpediente_Delito_Agraviado(SelectExpediente As Boolean, SelectDelito As Boolean, SelectAgraviado As Boolean)
            Dim objExpCol As New Entity.Registro.ExpedienteCol
            objBssExpediente = New Bussines.Registro.Expediente

            intCodigoExpediente = Me.GrillaExpedienteID
            If Me._DocumentoJudicialID > 0 And intCodigoExpediente > 0 Then
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                objEntExpPadre.InternoExpedienteId = intCodigoExpediente
                Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                If blnValor = False Then
                    If SelectExpediente = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente seleccionado no se puede eliminar, ya ha sido referenciado")
                    ElseIf SelectDelito = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El delito seleccionado no se puede eliminar, ya ha sido referenciado")
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado seleccionado no se puede eliminar, ya ha sido referenciado")
                    End If
                    Exit Sub
                End If
            End If
            Dim strMensaje As String = ""
            If SelectExpediente = True Then
                strMensaje = "Esta seguro de eliminar el expediente, delitos y agraviado, una vez eliminado no se podra recuperar la información"
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then
                    blnEliminarColection = True
                    'eliminar el agraviado
                    Temporal_EliminarExpedienteAgraviado()
                    'eliminar el delito
                    Temporal_EliminarExpedienteDelito()
                    'eliminar el expediente
                    Temporal_EliminarExpediente()
                End If
            End If
            If SelectDelito = True Then
                strMensaje = "Esta seguro de eliminar el delito, se eliminara sus agraviado !!!"
                Dim intCodigoDelito As Integer = Me.GrillaDelitoID
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then
                    blnEliminarDelitoColec = True
                    'eliminar el agraviado
                    Temporal_EliminarDelitoAgraviado()
                    Temporal_EliminarDelito()

                End If
            End If
            If SelectAgraviado = True Then
                strMensaje = "Esta seguro de eliminar el agraviado !!!"
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then
                    If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                        blnEliminarAgraviadoColec = True
                    End If
                    'eliminar el agraviado
                    Temporal_EliminarAgraviado()
                End If
            End If
        End Sub

        Private Sub Temporal_EliminarDelitoAgraviado()
            Dim EntAgr As New Entity.Registro.Agraviado
            Dim intIndice As Integer = -1
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemAgraviado = objEntAgraviadoTempoCol.Item(i).AgraviadoItem Then
                    intIndice = i
                    Dim intCodigo As Integer = objEntAgraviadoTempoCol.Item(i).Codigo

                    If objEntAgraviadoTempoCol.Item(i).Codigo > 0 Then
                        If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                            EntAgr.Codigo = intCodigo
                            'blnEliminarDelitoColec = True
                            objEntAgraviadosIndcCol2.Add(EntAgr)
                        End If
                    End If
                    objEntAgraviadoTempoCol.Remove(intIndice)
                End If
            Next
        End Sub

        Private Sub Temporal_EliminarDelito()
            Dim intCodigo As Integer = Me.GrillaDelitoID
            Dim EntDel As New Entity.Registro.Delito

            If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                If intCodigo > 0 Then
                    'blnEliminarAgraviadoColec = True
                    EntDel.Codigo = intCodigo
                    objEntDelitoIndcCol2.Add(EntDel)
                End If
            End If
            objEntDelitoTempoCol.Remove(Me.GrillaDelitoIndex)

        End Sub
        Private Sub Temporal_EliminarAgraviado()
            Dim intCodigo As Integer = Me.GrillaAgraviadoID
            Dim EntAgr As New Entity.Registro.Agraviado

            If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                If intCodigo > 0 Then
                    blnEliminarAgraviadoColec = True
                    EntAgr.Codigo = intCodigo
                    objEntAgraviadosIndcCol2.Add(EntAgr)
                End If
            End If
            Dim abc As Integer = Me.GrillaAgraviadoIndex
            objEntAgraviadoTempoCol.Remove(Me.GrillaAgraviadoIndex)

        End Sub

        Private Sub Temporal_EliminarExpedienteAgraviado()
            Dim AgraviadosIndc As New Entity.Registro.Agraviado
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemExpediente = objEntAgraviadoTempoCol.Item(i).ExpedienteItem Then
                    If Me._GrillaExpedienteID > 0 And (Me._DocumentoJudicialID = Me.GrillaDocumentoJudID) Then
                        If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                            blnEliminarColection = True
                            AgraviadosIndc.Codigo = objEntAgraviadoTempoCol.Item(i).Codigo
                            objEntAgraviadosIndcCol.Add(AgraviadosIndc)
                        End If
                    End If
                    objEntAgraviadoTempoCol.Remove(i)
                End If
            Next
            'dgwDelito_CellContentClick(Nothing, Nothing)
        End Sub

        Private Sub Temporal_EliminarExpedienteDelito()

            If Me._GrillaExpedienteID > 0 And (Me._DocumentoJudicialID = Me.GrillaDocumentoJudID) Then
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                        objEntDelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndcCol.Add(objEntDelitoIndc)
                        objEntDelitoTempoCol.Delete(i)
                    End If
                Next
            Else
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                        'Dim intCodigo As Integer = objEntDelitoTempoCol.Item(i).Codigo
                        'objEntDelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        'objEntDelitoIndcCol.Add(objEntDelitoIndc)
                        objEntDelitoTempoCol.Delete(i)
                    End If
                Next
            End If
            dgwExpediente_CellClick(Nothing, Nothing)
            dgwDelito.Refresh()

        End Sub

        Private Sub Temporal_EliminarExpediente()

            If Me.dgwExpediente.RowCount > 0 Then
                Dim intCodigo As Integer = Me.GrillaExpedienteID
                If Me.GrillaExpedienteID > 0 And (Me._DocumentoJudicialID = Me.GrillaDocumentoJudID) Then
                    Dim Exp_ent As New Entity.Registro.Expediente
                    Exp_ent.Codigo = intCodigo
                    objEntExpedienteIndc.Add(Exp_ent)
                End If
                objEntExpedienteTempoCol.Remove(Me.GrillaExpedienteIndex)
                Temporal_ListarExpediente()
                Temporal_ListarDelitos(Nothing)
                dgwExpediente_CellClick(Nothing, Nothing)
            End If

        End Sub
        Dim intPadre As Integer = -1
        Private Function ValidarExpedientePadreBD() As Boolean
            Dim objBssPad As Bussines.Registro.InternoExpedientePadre
            Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol
            Dim ListaExpediente As New Entity.Registro.Expediente
            objBssPad = New Bussines.Registro.InternoExpedientePadre
            Dim EntExp As New Entity.Registro.InternoExpedientePadre
            EntExp.Codigo = Me._GrillaExpedienteID
            EntExp.InternoID = Me._InternoId
            EntColPad = objBssPad.ListarGrilla(EntExp)
            Dim blnSwitch As Boolean = False
            For Each EntCodi As Entity.Registro.InternoExpedientePadre In EntColPad
                If EntExp.Codigo = EntCodi.InternoExpedienteRefPadreId Then
                    intPadre = EntCodi.InternoExpedienteRefPadreId
                    blnSwitch = True
                    Exit For
                End If
            Next
            If blnSwitch = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente no puede ser elimando, ha sido referenciado.")
                blnSwitch = False
            End If
            Return blnSwitch
        End Function
#End Region
#Region "Grabar"
        Private Sub Temporal_Grabar_Expediente_Delito_Agraviado2(objEntExpedienteCol As Entity.Registro.ExpedienteCol, objEntDelitoCol As Entity.Registro.DelitoCol, _
                                                                objEntAgraviadoCol As Entity.Registro.AgraviadoCol)
            objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
            objEntAgraviadoTempoColGrilla = New Entity.Registro.AgraviadoCol
            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                objEntExpediente._RegionId = Me._RegionID
                objEntExpediente._PenalId = Me._PenalID
                Temporal_GrabarExpediente(objEntExpediente)
            Next
            Dim i As Integer = -1
            Dim j As Integer = -1
            For Each EntDel As Entity.Registro.Delito In objEntDelitoCol
                i = i + 1
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadoCol
                    j = j + 1

                Next
            Next
            Dim objEntPeriodoAuxTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia

            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                objEntPerCon.DocJudicialId = objEntExpediente.CreaDocJudicialId
                objEntPeriodoAuxTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)
                If objEntPeriodoCondenaTempoCol.Count = 0 Then
                    For Each EntPer As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoAuxTempoCol
                        objEntPeriodoCondenaTempoCol.Add(EntPer)
                    Next
                Else
                    For Each EntPer As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoAuxTempoCol 'indexar cada expediente
                        objEntPeriodoCondenaTempoCol.Add(EntPer)
                    Next
                End If
            Next


            Temporal_ListarExpediente()
            With dgwDelito
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntDelitoTempoColGrilla
            End With
        End Sub
        Public Sub _Temporal_Grabar_Expediente_Delito_Agraviado(objEnt As Entity.Registro.ExpedienteCol, objEntDel As Entity.Registro.DelitoCol, objEntAgr As Entity.Registro.AgraviadoCol)
            Dim strMensaje As String = ""
            If Me._TipoResolucion = enumTipoDocumentoJudicial.Aclaratoria Or
               Me._TipoResolucion = enumTipoDocumentoJudicial.Ampliacion_Autoapertorio Or
               Me._TipoResolucion = enumTipoDocumentoJudicial.Avocamiento Or
               Me._TipoResolucion = enumTipoDocumentoJudicial.Prolongacion_Detencion Then
                Select Case Me._TipoResolucion
                    Case enumTipoDocumentoJudicial.Aclaratoria
                        strMensaje = "Aclaratoria"
                    Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                        strMensaje = "Ampliacion_Autoapertorio"
                    Case enumTipoDocumentoJudicial.Avocamiento
                        strMensaje = "Avocamiento"
                    Case enumTipoDocumentoJudicial.Prolongacion_Detencion
                        strMensaje = "Prolongacion_Detencion"
                End Select
                If dgwExpediente.Rows.Count = 0 Then
                    If objEnt.Count = 1 Then
                        Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & ", solo puede cargar un expediente.")
                        objEnt = Nothing
                        objEntDel = Nothing
                        objEntAgr = Nothing
                        Exit Sub
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & ", ya posee un expediente.")
                    objEnt = Nothing
                    objEntDel = Nothing
                    objEntAgr = Nothing
                    Exit Sub
                End If
            Else
                Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)
            End If
        End Sub

        Private Sub Temporal_Grabar_Expediente_Delito_Agraviado(objEntExpedienteCol As Entity.Registro.ExpedienteCol, objEntDelitoCol As Entity.Registro.DelitoCol,
                                                                objEntAgraviadoCol As Entity.Registro.AgraviadoCol)

            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                objEntExpediente._RegionId = Me._RegionID
                objEntExpediente._PenalId = Me._PenalID
                'grabar expedientes
                If objEntExpediente.DocumentoTipoID = 28 Then
                    objEntExpediente.Codigo = 999999
                End If
                Temporal_GrabarExpediente(objEntExpediente)
                If objEntExpediente.DocumentoTipoID = 28 Then

                    'Next
                Else
                    For Each objDelito As Entity.Registro.Delito In objEntDelitoCol
                        If objEntExpediente.Codigo = objDelito.ExpedienteID Then

                            objDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
                            'grabar delitos
                            Temporal_GrabarDelito(objEntExpediente, objDelito, Nothing)

                        End If
                        For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            If objDelito.Codigo = objAgraviado.DelitoID Then

                                objAgraviado.ExpedienteItem = objDelito.ExpedienteItem
                                objAgraviado.DelitoItem = objDelito.DelitoItem
                                'grabar agraviados
                                Temporal_GrabarAgraviado(objDelito, objAgraviado)

                            End If
                        Next
                    Next
                End If
            Next

            Temporal_ListarExpediente()
            Temporal_ListarDelitos(Nothing)
            Temporal_ListarAgraviados(Nothing)

        End Sub

        Public Sub _Temporal_GrabarPeriodoCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Temporal_GrabarPeriodoCondena(objEnt)
        End Sub
        Public Sub _Temporal_GrabarPeriodoNuevaCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Temporal_GrabarPeriodoCondenaNuevo(objEnt)
        End Sub
        Private Sub Temporal_GrabarPeriodoCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            If objEnt.Codigo > 0 Then
                'nada
            Else
                If objEnt.PeriodoCondenaItem > 0 Then
                    For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In Me.objEntPeriodoCondenaTempoCol
                        If obj.PeriodoCondenaItem = objEnt.PeriodoCondenaItem Then
                            objEnt = obj.Copiar_PeriodoCondenaSentencia()
                            Exit For
                        End If
                    Next
                Else
                    'si el temporal es nuevo
                    Me.objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                    objEnt.RegionId = Me._RegionID
                    objEnt.PenalId = Me._PenalID
                    objEnt.PeriodoCondenaItem = TemporalPeriodoSentenciaItemMaximo() + 1
                    objEntPeriodoCondenaTempoCol.Add(objEnt)
                End If
            End If
            'listar_PeriodoCondenaNuevo()
        End Sub
        Dim objEntPeriodoCondenaNuevaTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
        Private Sub Temporal_GrabarPeriodoCondenaNuevo(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            If objEnt.Codigo > 0 Then
                'nada
            Else
                If objEnt.PeriodoCondenaItem > 0 Then
                    For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In Me.objEntPeriodoCondenaTempoCol
                        If obj.PeriodoCondenaItem = objEnt.PeriodoCondenaItem Then
                            objEnt = obj.Copiar_PeriodoCondenaSentencia()
                            Exit For
                        End If
                    Next
                Else
                    'si el temporal es nuevo
                    Me.objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                    objEnt.RegionId = Me._RegionID
                    objEnt.PenalId = Me._PenalID
                    objEnt.PeriodoCondenaItem = TemporalPeriodoSentenciaItemMaximo() + 1
                    objEntPeriodoCondenaNuevaTempoCol.Add(objEnt)
                End If
            End If
            'listar_PeriodoCondenaNuevo()
        End Sub
        Private Sub Temporal_GrabarListaExpediente(objEntTemCol As Entity.Registro.ExpedienteCol)
            If Not objEntTemCol Is Nothing Then
                For Each objEntExp As Entity.Registro.Expediente In objEntTemCol
                    objEntExp._RegionId = Me._RegionID
                    objEntExp._PenalId = Me._PenalID
                    objEntExp.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                    objEntExpedienteTempoCol.Add(objEntExp)
                Next
                Temporal_ListarExpediente()
            End If
        End Sub
        Private Function TemporalPeriodoSentenciaItemMaximo() As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaNuevaTempoCol
                If obj.PeriodoCondenaItem > intNumero Then intNumero = obj.PeriodoCondenaItem
            Next
            Return intNumero
        End Function
#Region "Expediente"
        Public Sub _Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente)


            If objEnt.Nuevo = False Then
                If ValidarTipoResolucion(Me._TipoResolucion) = True Then
                    If dgwExpediente.Rows.Count = 0 Then
                        Temporal_GrabarExpediente(objEnt)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion solo puede tener un expediente.")
                        Exit Sub
                    End If
                End If
            End If
            Temporal_GrabarExpediente(objEnt)
            dgwExpediente_CellClick(Nothing, Nothing)
        End Sub
        Private Function Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente) As Integer

            'si el temporal ya existe 
            If objEnt.ExpedienteItem > 0 Then
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If obj.ExpedienteItem = objEnt.ExpedienteItem Then
                        Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'si el temporal es nuevo
                objEnt._RegionId = Me._RegionID
                objEnt._PenalId = Me._PenalID
                objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                objEntExpedienteTempoCol.Add(objEnt)
            End If
            Temporal_ListarExpediente()
            Return objEnt.ExpedienteItem
            'Temporal_ListarExpediente()
        End Function
        Private Sub Temporal_ExpedienteCopiarPropiedades(objEntOrigen As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .TipoAutoridadJudicialID = .TipoAutoridadJudicialID
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

            End With

        End Sub
        Private Function TemporalExpedienteItemMaximo(objEntCol As Entity.Registro.ExpedienteCol) As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Expediente In objEntCol
                If obj.ExpedienteItem > intNumero Then intNumero = obj.ExpedienteItem
            Next
            Return intNumero
        End Function
#End Region
#Region "Delito"
        Public Sub _Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntAgraviadoCol As Entity.Registro.AgraviadoCol, objAgr_Ind As Entity.Registro.AgraviadoCol)
            Temporal_GrabarDelito(objEntExpediente, objEntDelito, objEntAgraviadoCol)
            Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
        End Sub
        Private objEntDelitoFiltraCol As New Entity.Registro.DelitoCol
        Private Function Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito,
                                                  objEntAgraviadoCol As Entity.Registro.AgraviadoCol) As Integer
            'validar si el delito ya esta seleccionado, cambiar por id
            For i As Integer = 0 To dgwDelito.Rows.Count - 1
                If objEntDelito.Codigo < -1 Then 'PENDIENTEHNB verificar condicion 
                    If objEntDelito.DelitoEspecificoNombre = dgwDelito.Item("col_del_esp_nom", i).Value Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El delito ya existe en la lista, no podra ser agregado.")
                        Exit Function
                    End If
                End If
            Next
            If objEntDelito.Codigo > 0 Then
                'si el delito viene de la bd 
                If objEntDelito.DelitoItem > 0 Then
                    'actualiza agraviados
                    For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                        If obj.Codigo = objEntDelito.Codigo Then
                            Temporal_DelitoCopiarPropiedades(obj, objEntDelito)
                            Exit For
                        End If
                    Next
                Else

                    objEntDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
                    objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                    objEntDelitoTempoCol.Add(objEntDelito)

                End If
                If Not objEntAgraviadoCol Is Nothing Then
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
                    If Not objEntAgraviadoCol Is Nothing Then

                        For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                        Next

                    End If

                End If

            End If
            dgwExpediente_CellClick(Nothing, Nothing)
            Return objEntDelito.DelitoItem
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
            End With
        End Sub
        Private Function TemporalDelitoItemMaximo(objEntCol As Entity.Registro.DelitoCol) As Integer
            Dim intNumero As Integer = 0

            For Each obj As Entity.Registro.Delito In objEntCol
                If obj.DelitoItem > intNumero Then intNumero = obj.DelitoItem
            Next
            Return intNumero
        End Function
        Private Sub Temporal_Delito_Modificar()
            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe registro seleccionado para modificar.")
                Exit Sub
            End If

            Me.GrillaDelitoSelect.DelitoItem = Me._GrillaItemDelito
            Me.GrillaDelitoSelect.ExpedienteItem = Me._GrillaItemExpediente

            RaiseEvent _Click_Delito_Editar(Me.objEntExpedienteTempoCol.Item(Me.GrillaExpedienteIndex), Me.GrillaDelitoSelect, Me.Grilla_Agraviados_Delito_Select, objEntDelitoTempoColGrilla)

        End Sub

#End Region
#Region "Agraviado"
        Public Sub _Temporal_GrabarAgraviado(objEnt As Entity.Registro.Agraviado)
            Temporal_GrabarAgraviado(objEntDelitoTempoCol.Delito(Me.GrillaDelitoIndex), objEnt)
        End Sub
        Private Sub Temporal_GrabarAgraviado(objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)

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
                    objEnt.ExpedienteItem = objEntDelito.ExpedienteItem
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
            dgwDelito_CellClick(Nothing, Nothing)
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
                .TipoSentenciaId = ObjEntDestino.TipoSentenciaId
                '/*campos*/
                .AgraviadoNombre = ObjEntDestino.AgraviadoNombre
                .Observacion = ObjEntDestino.Observacion
                .Estado = ObjEntDestino.Estado
                .FlgEliminado = ObjEntDestino.FlgEliminado
            End With
        End Sub
        Private Function TemporalAgraviadoItemMaximo(objEntCol As Entity.Registro.AgraviadoCol) As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Agraviado In objEntCol
                If obj.AgraviadoItem > intNumero Then intNumero = obj.AgraviadoItem
            Next
            Return intNumero
        End Function
#End Region
#End Region
#End Region
#Region "Listar"
        Private DocumentoJudPrincipal As Integer = -1
        Private ExpedientePrincipal As Integer = -1
        Public Sub _ListarExpediente(DocumentoJudicialID As Integer,
                                     Optional ByVal CargarMandDetencionHistorico As Boolean = True,
                                     Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)

            If Me._DocumentoJudicialID < 1 Then 'si es nuevo y se muestra los checkeds
                'nada
                dgwExpediente.Columns("col_exp_ref").Visible = False
            Else


                Dim objEntExpedienteColTmp As New Entity.Registro.ExpedienteCol
                Dim objEntDelitoColTmp As New Entity.Registro.DelitoCol
                Dim objEntAgraviadoCol As New Entity.Registro.AgraviadoCol
                objBssDelito = New Bussines.Registro.Delito
                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                '--------
                objEntExpedienteColTmp = (New Bussines.Registro.Expediente).ListarExpedientexResolucion(DocumentoJudicialID)
                '------
                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteColTmp

                    objEntExpediente.ExpedienteItem = Temporal_GrabarExpediente(objEntExpediente)
                    Dim objdel As New Entity.Registro.Delito
                    objdel.InternoID = Me._InternoId
                    objdel.IngresoID = Me._InternoIngresoId
                    objdel.ExpedienteID = objEntExpediente.Codigo
                    If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                        objdel.IngresoInpeId = Me._InternoIngresoInpeId
                        objEntDelitoColTmp = objBssDelito.Listar2_LM(objdel)
                    Else
                        objEntDelitoColTmp = objBssDelito.Listar2(objdel)
                    End If
                    For Each objEntDelito As Entity.Registro.Delito In objEntDelitoColTmp
                        Dim DelitoItem As Integer = Temporal_GrabarDelito(objEntExpediente, objEntDelito, Nothing)
                        objEntAgraviadoCol = New Entity.Registro.AgraviadoCol
                        Dim objEnt As New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = -1
                            .DelitoID = objEntDelito.Codigo
                            .InternoID = Me._InternoId
                            .IngresoID = Me._InternoIngresoId
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            .ExpedienteID = objEntExpediente.Codigo
                            .TipoSentenciaId = -1
                            .AgraviadoNombre = ""
                        End With
                        If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                            objEntAgraviadoCol = objBssAgraviado.Listar_LM(objEnt)
                        Else
                            objEntAgraviadoCol = objBssAgraviado.Listar(objEnt)
                        End If

                        For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            objEntAgraviado.DelitoItem = DelitoItem
                            Temporal_GrabarAgraviado(objEntDelito, objEntAgraviado)
                        Next
                    Next
                Next

                objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                objEntPerCon.DocJudicialId = DocumentoJudicialID
                objEntPerCon.RegionId = Me._RegionID
                objEntPerCon.PenalId = Me._PenalID
                objEntPeriodoCondenaNuevaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)
                For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1 'indexar cada expediente
                    objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                Next

                'listar_PeriodoCondenaNuevo()
                If Me._DocumentoJudicialID < 1 Then
                    'listar_PeriodoCondena()
                Else
                    'listar_PeriodoCondena_Mod()
                End If
                Temporal_ListarExpediente()
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Then
                    If objEntExpedienteColTmp.Count > 0 Then
                        Temporal_ListarDelitos(objEntExpedienteColTmp.Expediente(dgwExpediente.SelectedRows(0).Index))
                    End If
                Else

                    Temporal_ListarDelitos(objEntExpedienteTempoCol.Expediente(dgwExpediente.SelectedRows(0).Index))
                End If
            End If

            bolEdicionActivo = True
        End Sub
        Private Sub ACopiarPropiedades(nuevo As Boolean, DocJudicial As Entity.Registro.DocumentoJudicial)

            Dim f As DataGridViewRow
            dgwDelito.Rows.Clear()
            bolEdicionActivo = False 'levantar
            For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                Temporal_ListarAgraviados(objDel)
                For Each objAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoColGrilla
                    f = dgwDelito.Rows(dgwDelito.Rows.Add())
                    f.Cells("col_int_del_id").Value = objDel.Codigo
                    f.Cells("col_exp_id").Value = objDel.ExpedienteID
                    f.Cells("col_exp_item").Value = objDel.ExpedienteItem
                    f.Cells("col_del_item").Value = objDel.DelitoItem
                    f.Cells("col_del_esp_id").Value = objDel.DelitoEspecifico
                    f.Cells("col_del_esp_nom").Value = objDel.DelitoEspecificoNombre
                    f.Cells("col_del_gen_id").Value = objDel.DelitoGenerico
                    f.Cells("col_nom_del_gen").Value = objDel.DelitoGenericoNombre
                    f.Cells("col_del_obs").Value = objDel.Observacion

                    f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId

                    f.Cells("col_agrav_cod").Value = objAgr.Codigo
                    f.Cells("col_agrav_item").Value = objAgr.AgraviadoItem
                    f.Cells("col_agr_delito_item").Value = objAgr.DelitoItem
                    f.Cells("col_agr_exp_item").Value = objAgr.ExpedienteItem
                    f.Cells("col_agrav").Value = objAgr.AgraviadoNombre
                    f.Cells("col_agr_obs").Value = objAgr.Observacion
                    f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId
                Next
            Next
            'Next
            Dim objExpediente As New Entity.Registro.Expediente
            Dim EntGrillaDelito As New Entity.Registro.DelitoCol
            Dim EntGrillaAgraviado As New Entity.Registro.AgraviadoCol
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            With objExpediente
                .Codigo = -1
                .ExpedienteVisible = 1
                .InternoID = Me._InternoId
                .IngresoID = Me._InternoIngresoId  'reseteamos el numero ingreso del nuevo objeto expe al num ing actual
                .IngresoInpeId = Me._InternoIngresoInpeId
                .CreaDocJudicialId = DocJudicial.Codigo
                .ExpedienteNumero = DocJudicial.DocumentoNumero
                .AutoridadJudicialID = DocJudicial.DistritoJudicial
                .SalaJudicialID = DocJudicial.SalaJuzgado
                .ExpedienteJuez = DocJudicial.JuezNombre
                .ExpedienteSecretario = DocJudicial.SecretarioNombre
                .ExpedienteFechaDocRecepcion = DocJudicial.DocumentoFechaRecepcion
                .ExpedienteFecha = DocJudicial.DocumentoFecha
                .SituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                .Observacion = DocJudicial.Observacion
                .ExpedienteItem = 1
            End With
            objEntExpedienteTempoCol.Add(objExpediente)
            For i As Integer = 0 To dgwDelito.Rows.Count - 1
                If EntGrillaDelito.Count = 0 Then
                    Dim EntDel_ As New Entity.Registro.Delito
                    Dim EntAgr_ As New Entity.Registro.Agraviado
                    With EntDel_
                        .Codigo = -1 'dgwDelito.Item("col_int_del_id", i).Value
                        .InternoID = Me._InternoId
                        .IngresoID = Me._InternoIngresoId
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .DelitoEspecifico = dgwDelito.Item("col_del_esp_id", i).Value
                        .DelitoEspecificoNombre = dgwDelito.Item("col_del_esp_nom", i).Value
                        .DelitoGenerico = dgwDelito.Item("col_del_gen_id", i).Value
                        .Observacion = dgwDelito.Item("col_del_obs", i).Value
                        .AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value
                        .DelitoItem = i + 1
                        .ExpedienteItem = 1
                    End With
                    EntGrillaDelito.Add(EntDel_)
                    With EntAgr_
                        .Codigo = -1 'dgwDelito.Item("col_agrav_cod", i).Value
                        .AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value
                        .Observacion = dgwDelito.Item("col_agr_obs", i).Value
                        .TipoSentenciaId = dgwDelito.Item("col_tip_sent", i).Value
                        .DelitoItem = i + 1
                        .AgraviadoItem = i + 1
                        .ExpedienteItem = 1
                    End With
                    EntGrillaAgraviado.Add(EntAgr_)
                Else
                    Dim intValor As Integer = 0
                    For Each EntCom As Entity.Registro.Delito In EntGrillaDelito
                        If EntCom.DelitoEspecifico = dgwDelito.Item("col_del_esp_id", i).Value And
                           EntCom.AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value Then
                            intValor = intValor + 1
                            Exit For
                        End If
                    Next
                    If intValor = 0 Then
                        Dim EntDel_ As New Entity.Registro.Delito
                        Dim EntAgr_ As New Entity.Registro.Agraviado
                        With EntDel_
                            .Codigo = -1 'dgwDelito.Item("col_int_del_id", i).Value
                            .InternoID = Me._InternoId
                            .IngresoID = Me._InternoIngresoId
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            .DelitoEspecifico = dgwDelito.Item("col_del_esp_id", i).Value
                            .DelitoEspecificoNombre = dgwDelito.Item("col_del_esp_nom", i).Value
                            .DelitoGenerico = dgwDelito.Item("col_del_gen_id", i).Value
                            .Observacion = dgwDelito.Item("col_del_obs", i).Value
                            .AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value
                            .DelitoItem = i + 1
                            .ExpedienteItem = 1
                        End With
                        EntGrillaDelito.Add(EntDel_)
                        With EntAgr_
                            .Codigo = -1 'dgwDelito.Item("col_agrav_cod", i).Value
                            .AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value
                            .Observacion = dgwDelito.Item("col_agr_obs", i).Value
                            .TipoSentenciaId = dgwDelito.Item("col_tip_sent", i).Value
                            .DelitoItem = i + 1
                            .AgraviadoItem = i + 1
                            .ExpedienteItem = 1
                        End With
                        EntGrillaAgraviado.Add(EntAgr_)
                    End If
                End If
            Next
            objEntDelitoTempoCol = EntGrillaDelito
            objEntAgraviadoTempoCol = EntGrillaAgraviado
            blnJuntaExp = True
            AGrabar(True, DocJudicial)
        End Sub

        Private Sub Temporal_ListarExpediente()
            With Me.dgwExpediente
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = IIf(objEntExpedienteTempoCol.Expediente(0) Is Nothing, Nothing, objEntExpedienteTempoCol)
                .Refresh()
                lblNroExpedientes.Text = "Expedientes " & .Rows.Count & " Reg."
                For i As Integer = 0 To .Rows.Count - 1
                    .Item("col_num", i).Value = i + 1
                Next
            End With
        End Sub

        Private Sub Temporal_ListarDelitos(objEntExpediente As Entity.Registro.Expediente)

            If objEntExpediente Is Nothing Then
                'nada
            Else

                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol

                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol

                    If obj.ExpedienteID = objEntExpediente.Codigo Then
                        If obj.ExpedienteID > 0 Then

                            objEntDelito = New Entity.Registro.Delito
                            Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                            objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                            objEntDelitoTempoColGrilla.Add(objEntDelito)

                        Else
                            If objEntExpediente.ExpedienteItem = obj.ExpedienteItem Then
                                objEntDelito = New Entity.Registro.Delito
                                Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                                objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                                objEntDelitoTempoColGrilla.Add(objEntDelito)
                            End If
                        End If
                    End If
                Next

                With Me.dgwDelito
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = Nothing
                    .DataSource = objEntDelitoTempoColGrilla
                    lblNrodelitos.Text = "Delito(s) " & .Rows.Count & " Reg."
                End With
                dgwDelito_CellClick(Nothing, Nothing)
            End If
        End Sub


        Private Sub Temporal_ListarAgraviados(objEntDelito As Entity.Registro.Delito)
            'If objEntDelito Is Nothing Then Exit Sub

            'objEntAgraviadoTempoColGrilla = New Entity.Registro.AgraviadoCol
            'For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol

            '    If obj.DelitoItem = objEntDelito.DelitoItem Then
            '        objEntAgraviado = New Entity.Registro.Agraviado
            '        Temporal_AgraviadoCopiarPropiedades(objEntAgraviado, obj)
            '        objEntAgraviadoTempoColGrilla.Add(obj)
            '    End If
            'Next
            If objEntDelito Is Nothing Then
                'nada
            Else
                objEntDelito.ExpedienteID = Me._GrillaExpedienteID
                objEntDelito.Codigo = Me._GrillaDelitoID
                objEntDelito.DelitoItem = Me._GrillaItemDelito
                objEntAgraviadoTempoColGrilla = New Entity.Registro.AgraviadoCol

                For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol

                    If obj.Codigo > 0 Then

                        If objEntDelito.Codigo = obj.DelitoID Then
                            objEntAgraviado = New Entity.Registro.Agraviado
                            Temporal_AgraviadoCopiarPropiedades(objEntAgraviado, obj)
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
                With Me.dgwAgraviados
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = Nothing
                    .DataSource = objEntAgraviadoTempoColGrilla
                    Me.lblNroAgraviados.Text = "Agraviado(s) " & .Rows.Count & " Reg."
                    .Refresh()
                End With
            End If
        End Sub
#End Region
#Region "Accion"
        Public Sub _Grabar(Nuevo As Boolean, DocumentoJudicial As Entity.Registro.DocumentoJudicial)
            EliminarExpedienteBD()
            AGrabar(Nuevo, DocumentoJudicial)
        End Sub
        Dim blnJuntaExp As Boolean = False
        Dim EntExpPad_Col As New Entity.Registro.ExpedienteCol

        Private Sub AGrabar(Nuevo As Boolean, DocJudicial As Entity.Registro.DocumentoJudicial)

            objBssExpediente = New Bussines.Registro.Expediente
            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
            Dim objEntDelitoCol_copi As New Entity.Registro.DelitoCol


            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol
                Dim ExpedienteOrigId As Integer = objExpediente.Codigo
                Dim DocumentoOrigId As Integer = objExpediente.CreaDocJudicialId
                Dim intExpNuevoCodigo As Integer = -1

                With objExpediente
                    If Nuevo = True Then
                        If objExpediente.Codigo > 0 Then objBssExpediente.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                        .Codigo = -1 'recetear
                    Else
                        If objExpediente.Codigo > 0 And DocumentoOrigId <> DocJudicial.Codigo Then
                            objBssExpediente.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede)
                            .Codigo = -1
                        End If
                    End If
                    .InternoID = Me._InternoId
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .CreaDocJudicialId = DocJudicial.Codigo
                    .SituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
                    .ExpedienteVisible = 1
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                End With
                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    intExpNuevoCodigo = objBssExpediente.Grabar_LM(objExpediente)
                Else
                    intExpNuevoCodigo = objBssExpediente.Grabar(objExpediente)
                End If

                Dim Ent As New Entity.Registro.Expediente
                Ent.Codigo = intExpNuevoCodigo
                EntExpPad_Col.Add(Ent)
                '---------------ExpedientePadre------------------------------
                Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                With objIntExpPad
                    .InternoExpedienteId = intExpNuevoCodigo
                    .InternoExpedienteRefPadreId = ExpedienteOrigId    'intIdExpePadId
                    .InternoID = Me._InternoId
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .DocJudicialID = DocJudicial.Codigo
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                End With
                If Nuevo = True Then
                    If ExpedienteOrigId > 0 Then
                        If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                            objBssExpedientePad.Grabar_LM(objIntExpPad) 'guardar en BD
                        Else
                            objBssExpedientePad.Grabar(objIntExpPad) 'guardar en BD
                        End If
                    End If
                Else
                    If ExpedienteOrigId > 0 And DocumentoOrigId <> DocJudicial.Codigo Then
                        If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                            objBssExpedientePad.Grabar_LM(objIntExpPad) 'guardar en BD
                        Else
                            objBssExpedientePad.Grabar(objIntExpPad) 'guardar en BD
                        End If
                    End If
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
                            If codigoDelitoOri > 0 And creaDelitoOri <> DocJudicial.Codigo Then
                                objDel.Codigo = -1
                            End If
                        End If
                        objDel.ExpedienteID = intExpNuevoCodigo   'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocJudicial.Codigo
                        objDel.InternoID = Me._InternoId
                        objDel.IngresoID = Me._InternoIngresoId
                        objDel.IngresoInpeId = Me._InternoIngresoInpeId
                        objDel.FlagTransferenciaSede = Me.FlagTransferSede
                        objDel.RegionID = Me._RegionID
                        objDel.PenalID = Me._PenalID
                        If codigoDelitoOri > 0 And creaDelitoOri <> DocJudicial.Codigo Then
                            objDel.CodigodelitoPad = codigoDelitoOri
                        End If
                        If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                            intIdDel = objBssDelito.Grabar_LM(objDel)
                        Else
                            intIdDel = objBssDelito.Grabar_v2(objDel)
                        End If

                        For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol

                            If objDel.DelitoItem = obj.DelitoItem Then

                                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                                Dim codigoAgraviadoOri As Integer = obj.Codigo
                                Dim creaAgraviadoOri As Integer = obj.CreaDocJudicialId

                                If Nuevo = True Then
                                    obj.Codigo = -1
                                Else
                                    If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocJudicial.Codigo Then
                                        obj.Codigo = -1
                                    End If
                                End If
                                obj.DelitoID = intIdDel
                                obj.CreaDocJudicialId = DocJudicial.Codigo
                                obj.ExpedienteID = intExpNuevoCodigo
                                obj.InternoID = Me._InternoId
                                obj.IngresoID = Me._InternoIngresoId
                                obj.IngresoInpeId = Me._InternoIngresoInpeId
                                obj.FlagTransferenciaSede = Me.FlagTransferSede
                                obj.RegionID = Me._RegionID
                                obj.PenalID = Me._PenalID
                                If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocJudicial.Codigo Then
                                    obj.CodigoagraviadoPad = codigoAgraviadoOri
                                End If
                                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                                    Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                                    intIdAgrav = objBssAgraviado.Grabar_LM(obj)
                                Else
                                    intIdAgrav = objBssAgraviado.Grabar(obj)
                                End If
                            End If
                        Next
                    End If
                Next
            Next
        End Sub

        Public Function Validar(var As Integer) As Boolean
            If Me.dgwExpediente.Rows.Count < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion debe tener por lo menos 2 expedientes")
                Return False
            End If

            Dim ExpNumero As String = ""
            Dim DelitoEspecifico As String = ""
            Dim FilaExp_ As Integer = 0
            Dim FilaDel_ As Integer = 0
            'Validar expediente delito
            For j As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                FilaExp_ = 0
                ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                For k As Integer = 0 To objEntDelitoTempoCol.Count - 1
                    ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                    If objEntDelitoTempoCol.Item(k).ExpedienteItem = objEntExpedienteTempoCol.Expediente(j).ExpedienteItem Then
                        FilaExp_ = FilaExp_ + 1
                    End If
                Next
                If FilaExp_ = 0 Then
                    btnAddDelito.Focus()
                    Exit For
                End If
            Next
            If FilaExp_ = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente: [" & ExpNumero & "] debe tener por lo menos un delito")
                Return False
            End If
            '-------------------------
            For j As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                For k As Integer = 0 To objEntDelitoTempoCol.Count - 1
                    FilaExp_ = 0
                    ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                    For l As Integer = 0 To objEntAgraviadoTempoCol.Count - 1
                        DelitoEspecifico = objEntDelitoTempoCol.Delito(k).DelitoEspecificoNombre
                        If objEntAgraviadoTempoCol.Item(l).DelitoItem = objEntDelitoTempoCol.Delito(k).DelitoItem Then
                            FilaExp_ = FilaExp_ + 1
                        End If
                    Next
                    If FilaExp_ = 0 Then
                        btnAddAgrav.Focus()
                        Exit For
                        Exit For
                    End If
                Next
            Next
            If FilaExp_ = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente: [" & ExpNumero & "]" + Chr(13) +
                                                                        "El delito : [" & DelitoEspecifico & "]" + Chr(13) +
                                                                        "debe tener por lo menos un agraviado")
                Return False
            End If
            '--------------------
            Return True
        End Function

        Private Function ValidarTipoResolucion(Valor As Integer) As Boolean
            Dim ListaTipo = {enumTipoDocumentoJudicial.Sentencia, _
                             enumTipoDocumentoJudicial.Sentencia_Aclaratoria, _
                             enumTipoDocumentoJudicial.Integracion_Sentencia}
            For Each Codigo As Integer In ListaTipo
                If Valor = Codigo Then
                    If Valor = enumTipoDocumentoJudicial.Integracion_Sentencia And Me._DocumentoJudicialID < 1 Then
                        Return False
                        Exit For
                        Exit Function
                    End If
                    If Valor = enumTipoDocumentoJudicial.Integracion_Sentencia And Me._DocumentoJudicialID > 0 Then
                        Return True
                        Exit For
                        Exit Function
                    End If
                    Return True
                    Exit For
                    Exit Function
                End If
            Next
            Return False
        End Function

        Public Sub EliminarExpedienteBD()
            If blnEliminarColection = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
                For Each EntExp As Entity.Registro.Expediente In objEntExpedienteIndc
                    AEliminarExpedienteBD(EntExp.Codigo)
                Next
            End If
            If blnEliminarDelitoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol2
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol2
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
            End If
            If blnEliminarAgraviadoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol2
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
            End If
        End Sub

        Private Function AEliminarAgraviadoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then value = (New Bussines.Registro.InternoAgraviado).Eliminar(Codigo, Me.FlagTransferSede)
            Return value
        End Function

        Private Function AEliminarDelitoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then value = (New Bussines.Registro.Delito).Eliminar2(Codigo, Me.FlagTransferSede)
            Return value
        End Function

        Private Function AEliminarExpedienteBD(Codigo As Integer) As Integer
            'falta referenciar al padre
            Dim value As Integer = -1
            If Codigo > 0 Then
                objBssExpediente = New Bussines.Registro.Expediente
                value = objBssExpediente.Eliminar2(Codigo)
                If value > 0 Then
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    objBssExpedientePad.Eliminar(intPadre, Me.FlagTransferSede)
                    objBssExpediente.GrabarEstadoVisibilidad(intPadre, True, Me.FlagTransferSede)
                End If
            End If
            Return value

        End Function
#End Region
#Region "Otros"

        Private Sub ValoresxDefault()
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            objEntDelitoTempoCol = New Entity.Registro.DelitoCol
            objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol
            objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            dgwExpediente.Columns("col_exp_ref").ReadOnly = True
        End Sub

        Private Function ValidarExpedienteReferenciado(Condicion As String) As Boolean
            If Me._DocumentoJudicialID > 0 Then
                Dim strMensaje As String = ""
                Dim intValorpadre As Integer = 0
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre

                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    If objEntExpediente.Codigo > 0 Then
                        objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                        Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                        If blnValor = False Then
                            intValorpadre = intValorpadre + 1
                        End If
                    End If
                Next
                If intValorpadre > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)
                    Return False
                End If
            End If
            Return True
        End Function
#End Region

        Private Sub dgwExpediente_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellClick
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
            End If
        End Sub

        Private Sub btnAddPerCond_Click(sender As System.Object, e As System.EventArgs)
            RaiseEvent _Click_PeriodoCondena_Agregar()
        End Sub

        Private Sub dgwExpediente_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellDoubleClick
            btnEditExpe_Click(Nothing, Nothing)
        End Sub
        Private Sub btnEditExpe_Click(sender As System.Object, e As System.EventArgs) Handles btnEditExpe.Click
            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir al menos un expediente para modificar.")
                Exit Sub
            End If
            RaiseEvent _Click_Expediente_Editar(Me.objEntExpedienteTempoCol.Expediente(Me.dgwExpediente.SelectedRows(0).Index))
        End Sub
        Private Sub btnEliminarExp_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarExp.Click
            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                Exit Sub
            End If
            Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)
        End Sub
        Private Sub btnAddExp_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExp.Click
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(1) = False Then
                    Exit Sub
                End If
            End If
            RaiseEvent _Click_Expediente_Agregar()
        End Sub

        Public Sub New()
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            ValoresxDefault()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        End Sub
        Private Sub dgwDelito_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            If e.ColumnIndex = -1 Or e.RowIndex = -1 Or bolEdicionActivo = False Then Exit Sub
            If dgwDelito.Columns(e.ColumnIndex).Name = "col_tip_sent" Then
                For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If entAgrav.AgraviadoItem = dgwDelito.Item("col_agrav_item", e.RowIndex).Value Then entAgrav.TipoSentenciaId = dgwDelito.Item("col_tip_sent", e.RowIndex).Value
                Next
            End If
        End Sub

        Private Sub uscDetallResolucionIntegracionSent_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            dgwExpediente.VisibleCampos = False
        End Sub

        Private Sub dgwExpediente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyDown
            If e.KeyCode = Keys.Delete Then
                e.Handled = True
                Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)
            End If
        End Sub

        Private Sub dgwDelito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                If dgwDelito.Rows.Count = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                    Exit Sub
                End If
                bolEdicionActivo = False
                Temporal_EliminarExpediente_Delito_Agraviado(False, True, False)
                dgwExpediente_CellClick(Nothing, Nothing)
                bolEdicionActivo = True
            End If
        End Sub

        Private Sub dgwDelito_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellClick
            If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Then
                If dgwDelito.Rows.Count < 1 Then
                    dgwAgraviados.DataSource = Nothing
                    Exit Sub
                End If
            End If
            If dgwDelito.Rows.Count > 0 Then
                Temporal_ListarAgraviados(Me.GrillaDelitoSelect)
            End If
        End Sub

        Private Sub btnAddDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnAddDelito.Click
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(2) = False Then
                    Exit Sub
                End If
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Then
                RaiseEvent _Click_Delito_Agregar(Nothing, objEntDelitoTempoColGrilla)
            Else
                If dgwExpediente.Rows.Count < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir al menos un expediente para ingresar un delito.")
                    Exit Sub
                End If
                If objEntDelitoTempoColGrilla Is Nothing Then
                    objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
                End If
                RaiseEvent _Click_Delito_Agregar(objEntExpedienteTempoCol.Item(Me.dgwExpediente.SelectedRows(0).Index), objEntDelitoTempoColGrilla)
            End If
            dgwDelito_CellClick(Nothing, Nothing)
        End Sub


        Private Sub btnDelDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnDelDelito.Click
            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un delito para eliminar.")
                Exit Sub
            Else
                Temporal_EliminarExpediente_Delito_Agraviado(False, True, False)
                dgwExpediente_CellClick(Nothing, Nothing)
            End If
        End Sub


        Private Sub btnEditDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnEditDelito.Click
            Temporal_Delito_Modificar()
            dgwDelito_CellClick(Nothing, Nothing)
        End Sub

        Private Sub btnAddAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAgrav.Click
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(3) = False Then
                    Exit Sub
                End If
            End If
            If dgwDelito.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir al menos un delito registrado para ingresar un agraviado.")
                Exit Sub
            End If

            RaiseEvent _Click_Agraviado_Agregar(Me.GrillaDelitoSelect)
        End Sub

        Private Sub btnEditAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnEditAgrav.Click
            Temporal_Modificar_Agraviado()
        End Sub
        Private Sub Temporal_Modificar_Agraviado()

            If dgwAgraviados.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un agraviado para modificar.")
                Exit Sub
            End If

            RaiseEvent _Click_Agraviado_Editar(Me.GrillaDelitoSelect, Me.GrilllaAgraviadoSelect)

        End Sub

        Private Sub dgwDelito_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellDoubleClick
            btnEditDelito.PerformClick()
        End Sub

        Private Sub btnDelAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnDelAgrav.Click
            If dgwAgraviados.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                Exit Sub
            End If
            bolEdicionActivo = False
            Temporal_EliminarExpediente_Delito_Agraviado(False, False, True)
            dgwExpediente_CellClick(Nothing, Nothing)
            bolEdicionActivo = True
        End Sub

        Private Sub dgwAgraviados_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwAgraviados.CellDoubleClick
            If e.ColumnIndex = -1 Or e.RowIndex = -1 Then Exit Sub
            Me.btnEditAgrav.PerformClick()
        End Sub

        Private Sub dgwExpediente_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyUp
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.GrillaExpedienteSelect)
            End If
        End Sub

        Private Sub dgwDelito_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDelito.KeyUp
            If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Then
                If dgwDelito.Rows.Count < 1 Then
                    dgwAgraviados.DataSource = Nothing
                    Exit Sub
                End If
            End If
            If dgwDelito.Rows.Count > 0 Then
                Temporal_ListarAgraviados(Me.GrillaDelitoSelect)
            End If
        End Sub
    End Class
End Namespace