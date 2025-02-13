Imports Type.Enumeracion.TipoDocJudicial
Namespace Registro.Sentencias
    Public Class uscPeriodoCondena
        '/*bussiness*/
        Private objBssExpediente As Bussines.Registro.Expediente
        Private objBssPerCon As Bussines.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre
        '/*entitys*/
        Private objEntExpediente As Entity.Registro.Expediente = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntDelito As Entity.Registro.Delito = Nothing
        Private objEntAgraviado As Entity.Registro.Agraviado = Nothing
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
        '/*Entitys temporal*/
        Private objEntExpedienteIndCol As Entity.Registro.ExpedienteCol
        Private objEntExpedienteInd As Entity.Registro.Expediente

        Private objEntDelitoIndc As Entity.Registro.Delito
        Private objEntDelitoIndcCol As Entity.Registro.DelitoCol

        Private objEntAgraviadosIndc As Entity.Registro.Agraviado
        Private objEntAgraviadosIndcCol As Entity.Registro.AgraviadoCol
        Private objBssExp As Bussines.Registro.Expediente

#Region "Eventos"
        Public Event _Click_Expediente_Agregar()
        Public Event _Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)

        Public Event _Click_PeriodoCondena_Agregar()
        Public Event _Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)

        Public Event _Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol)
        Public Event _Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _click_VerSubtipoDocumentoJud()

#End Region
#Region "Variables"
        Private bolEdicionActivo As Boolean = False
        Private blnEliminarColection As Boolean = False
        Private blnEliminarDelitoColec As Boolean = False
        Private blnEliminarAgraviadoColec As Boolean = False
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
        Public Property _TipoDocumento As Integer = -1
        Public Property _SubTipoDocumento As Integer = -1

        '/* variables externas*/
        Public Property _TotalAnhos() As String
            Get
                Try
                    Return txtAnios.Text
                Catch ex As Exception
                    Return ""
                End Try
            End Get
            Set(ByVal value As String)
                txtAnios.Text = value
            End Set
        End Property
        Public Property _TotalMes() As String
            Get
                Try
                    Return txtMeses.Text
                Catch ex As Exception
                    Return ""
                End Try
            End Get
            Set(ByVal value As String)
                txtMeses.Text = value
            End Set
        End Property
        Public Property _TotalDias() As String
            Get
                Try
                    Return txtDias.Text
                Catch ex As Exception
                    Return ""
                End Try
            End Get
            Set(ByVal value As String)
                txtDias.Text = value
            End Set
        End Property
        Public ReadOnly Property GrillaNroRegistroPeriodocondena() As Integer
            Get
                Try
                    Return dgvPeriodoCondena.Rows.Count
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
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
        Public ReadOnly Property _RetornarLista_DocJudicialExpedientes() As Entity.Registro.ExpedienteCol
            Get
                Dim objEntColAux As New Entity.Registro.ExpedienteCol
                If Me._DocumentoJudicialID = -1 Then 'si es nuevo RESOLUCION 

                    Return objEntColAux
                Else 'si es editar resolucion
                    Return objEntExpedienteTempoCol
                End If
            End Get
        End Property

        '********************** HNRB
        Private ReadOnly Property GrillaPeriodoCondenaCodigo() As Integer
            Get
                Try
                    Return dgvPeriodoCondena.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaPeriodoCondenaItem() As Integer
            Get
                Try
                    Return dgvPeriodoCondena.SelectedRows(0).Cells("col_ped_cond_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteSelect() As Entity.Registro.Expediente
            Get
                objEntExpediente = New Entity.Registro.Expediente

                For Each objExp As Entity.Registro.Expediente In objEntExpedienteTempoCol

                Next

                Return objEntExpediente

            End Get
        End Property



#End Region
#Region "Propiedades_Grilla_Select"


        Private ReadOnly Property GrillaDelitoSelect() As Entity.Registro.Delito
            Get
                objEntDelito = New Entity.Registro.Delito


                Return objEntDelito

            End Get
        End Property


        Private _btnAgregarPerido As Boolean = True
        Public Property btnAgregarPerido() As Boolean
            Get
                Return _btnAgregarPerido
            End Get
            Set(ByVal value As Boolean)
                btnAddPerCond.Enabled = value
                btnEditPerCond.Enabled = value
                btnDelPerCond.Enabled = value
            End Set
        End Property
        Private _btnCajasPeriodo As Boolean = False
        Public Property btnCajasPeriodo() As Boolean
            Get
                Return _btnCajasPeriodo
            End Get
            Set(ByVal value As Boolean)
                txtAnios.ReadOnly = value
                txtMeses.ReadOnly = value
                txtDias.ReadOnly = value
            End Set
        End Property

        Public _blnCadenaPerpetua As Boolean = False
        Public Sub EliminarPeriodo()
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                obj.FlgEliminado = 1
            Next
            dgvPeriodoCondena.DataSource = Nothing
        End Sub
#End Region
#Region "Temporales"
        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol = Nothing
        Private objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing
        Public objEntPeriodoCondenaTempoCol As Entity.Registro.Documento.PeriodoCondenaSentenciaCol = Nothing


        Private entExpColAcum As New Entity.Registro.ExpedienteCol



        Public Sub _Temporal_GrabarPeriodoCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Temporal_GrabarPeriodoCondena(objEnt)
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
                    objEnt.DocJudicialId = objEnt.DocJudicialId
                    objEnt.RegionId = Me._RegionID
                    objEnt.PenalId = Me._PenalID
                    objEnt.PeriodoCondenaItem = TemporalPeriodoSentenciaItemMaximo() + 1
                    objEntPeriodoCondenaTempoCol.Add(objEnt)
                End If
            End If
            Listar_PeriodoCondena()
        End Sub
        Private Sub Temporal_GrabarListaExpediente(objEntTemCol As Entity.Registro.ExpedienteCol)
            If Not objEntTemCol Is Nothing Then
                For Each objEntExp As Entity.Registro.Expediente In objEntTemCol
                    objEntExp._RegionId = Me._RegionID
                    objEntExp._PenalId = Me._PenalID
                    objEntExp.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                    objEntExpedienteTempoCol.Add(objEntExp)
                Next

            End If
        End Sub

        Private Function TemporalPeriodoSentenciaItemMaximo() As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                If obj.PeriodoCondenaItem > intNumero Then intNumero = obj.PeriodoCondenaItem
            Next
            Return intNumero
        End Function





#Region "Eliminar"
        Private Sub Temporal_EliminarExpediente_Delito_Agraviado(SelectExpediente As Boolean, SelectDelito As Boolean, SelectAgraviado As Boolean)

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            bolEdicionActivo = False
            objEntAgraviadosIndcCol = New Entity.Registro.AgraviadoCol
            If Me._DocumentoJudicialID > 0 Then
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                objEntExpPadre = New Entity.Registro.InternoExpedientePadre
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

                    Temporal_EliminarExpedienteAgraviado()
                    'eliminar el delito

                End If
            End If
            If SelectDelito = True Then
                strMensaje = "Esta seguro de eliminar el delito, se eliminara sus agraviado !!!"
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then

                    'eliminar el agraviado
                    Temporal_EliminarDelitoAgraviado()
                    Temporal_EliminarDelito()

                End If
            End If
            If SelectAgraviado = True Then
            End If
        End Sub
        Private Sub Temporal_EliminarDelitoAgraviado()
            Dim intIndice As Integer = -1
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                intIndice = i

            Next

        End Sub
        Private Sub Temporal_EliminarDelito()
            Dim intConta As Integer = 0
            For Each objagr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol

            Next
            If intConta > 0 Then
                Exit Sub
            End If

        End Sub

        Private Sub Temporal_EliminarExpedienteAgraviado()
            objEntAgraviadosIndcCol = New Entity.Registro.AgraviadoCol
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1

            Next
        End Sub

        Dim intPadre As Integer = -1
        Private Function ValidarExpedientePadreBD() As Boolean
            Dim objBssPad As Bussines.Registro.InternoExpedientePadre
            objBssExpediente = New Bussines.Registro.Expediente
            Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol
            Dim ListaExpediente As New Entity.Registro.Expediente
            objBssPad = New Bussines.Registro.InternoExpedientePadre
            Dim EntExp As New Entity.Registro.InternoExpedientePadre

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
        Public Function Validar() As Boolean

            Dim blnValorTxt As Boolean = False
            Dim blnValorDgv As Boolean = False
                If (txtAnios.Text = "0" Or txtAnios.Text = "") And (txtMeses.Text = "0" Or txtMeses.Text = "") And (txtDias.Text = "0" Or txtDias.Text = "") Then
                    blnValorTxt = True
                End If

            Dim intValor As Integer = 0
            For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                If dgvPeriodoCondena.Item("col_eliminado", i).Value = False Then
                    intValor = intValor + 1
                End If
            Next
            If blnValorTxt = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar tiempo de condena")
                txtAnios.Focus()
                Return False
            End If
            'If intValor = 0 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Periodo de condena")
            '    dgvPeriodoCondena.Focus()
            '    Return False
            'End If

            Return True
        End Function
        Public entMov As Entity.Registro.InternoMovimiento
        Private blnValorLib As Boolean = False
        Private bssMov As Bussines.Registro.InternoMovimiento
        Private EntExpedienteAux As Entity.Registro.Expediente
        Private blnCondicionLib As Boolean = False
        Public Function ValidarRevocatoriaLibertadV2() As Boolean
            Select Case Me._TipoDocumento
                Case enumTipoDocumentoJudicial.Traslado, enumTipoDocumentoJudicial.Notas,
                     enumTipoDocumentoJudicial.Libertad, enumTipoDocumentoJudicial.Queda,
                     enumTipoDocumentoJudicial.Revocatoria_de_Libertad
                    Exit Function
            End Select
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                Exit Function
            End If
            blnValorLib = False
            entMov = New Entity.Registro.InternoMovimiento
            entMov.InternoID = Me._InternoId
            entMov.IngresoID = Me._InternoIngresoId
            entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
            bssMov = New Bussines.Registro.InternoMovimiento
            entMov = bssMov.Listar(entMov)
            If entMov Is Nothing Then
                Exit Function
            End If
            If entMov.Codigo < 1 Then
                Exit Function
            End If

            Dim intConta As Integer = 0
            Dim intContaLib As Integer = 0
            Dim strMensaje As String = ""
            Dim objEntExpedienteCol_rev As New Entity.Registro.ExpedienteCol
            Dim objExp As New Entity.Registro.Expediente
            objExp.InternoID = Me._InternoId
            objExp.IngresoID = Me._InternoIngresoId

            strMensaje = "Existe un 'movimiento de libertad', Si hace click en :" + Chr(13) +
                         " " + Chr(13) +
                         "[Aceptar] El movimiento de libertad se eliminara." + Chr(13) +
                         "[Cancelar] el proceso sera cancelado."

            Dim blnValor As Boolean = False
            objBssExp = New Bussines.Registro.Expediente
            If Me._DocumentoJudicialID > 0 Then
                For Each ent_ As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    EntExpedienteAux = New Entity.Registro.Expediente

                    Dim index As Integer = ent_.Codigo
                    While index > 0
                        objEntExpPadre.InternoExpedienteRefPadreId = index
                        Dim padre As New Entity.Registro.InternoExpedientePadre
                        padre = objBssExpedientePad.Listar(objEntExpPadre)
                        If padre.InternoExpedienteId > 0 Then
                            EntExpedienteAux.Codigo = padre.InternoExpedienteId
                        End If
                        index = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux.Codigo > 0 And ent_.Codigo < 1 Then
                        EntExpedienteAux = objBssExp.Listar(EntExpedienteAux).Expediente(0)
                        If EntExpedienteAux.LibertadTipoID < 1 Then
                            blnValor = True
                            Exit For
                        End If
                    ElseIf EntExpedienteAux.Codigo = -1 And ent_.LibertadTipoID < 1 Then
                        blnValor = True
                        Exit For
                    End If
                Next
                If entMov.Codigo > 0 And blnValor = True Then
                    If MessageBox.Show(strMensaje, "Inpe - SIP-POPE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        blnCondicionLib = True
                    Else
                        blnCondicionLib = False
                        blnValorLib = True
                    End If
                Else
                    blnCondicionLib = False
                End If
            Else

                For Each ent_ As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    EntExpedienteAux = New Entity.Registro.Expediente
                    Dim codigo As Integer = ent_.Codigo
                    While codigo > 0
                        objEntExpPadre.InternoExpedienteRefPadreId = codigo
                        Dim padre As New Entity.Registro.InternoExpedientePadre
                        padre = objBssExpedientePad.Listar(objEntExpPadre)
                        If padre.InternoExpedienteId > 0 Then
                            EntExpedienteAux.Codigo = padre.InternoExpedienteId
                        End If
                        codigo = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux Is Nothing Then
                        blnValor = True
                        Exit For
                    ElseIf EntExpedienteAux.Codigo > 0 Then
                        EntExpedienteAux = New Entity.Registro.Expediente
                        EntExpedienteAux = objBssExp.Listar(EntExpedienteAux).Expediente(0)
                        If EntExpedienteAux.LibertadTipoID < 1 Then
                            blnValor = True
                            Exit For
                        End If
                    ElseIf EntExpedienteAux.Codigo = -1 And ent_.LibertadTipoID < 1 Then
                        blnValor = True
                        Exit For
                    End If
                Next
                If entMov.Codigo > 0 And blnValor = True Then
                    If MessageBox.Show(strMensaje, "Inpe - SIP-POPE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        blnCondicionLib = True
                        blnValorLib = False
                    Else
                        blnCondicionLib = False
                        blnValorLib = True
                    End If
                Else
                    blnCondicionLib = False
                End If
            End If
            Return blnCondicionLib
        End Function

        Public Function ValidarPeriodoCondena() As String
            objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia
            Return objBssPerCon.Validar(txtAnios.Text, txtMeses.Text, txtDias.Text, objEntPeriodoCondenaTempoCol)
        End Function

        Public Sub EliminarExpedienteBD()
            If blnEliminarColection = True Then
                If ValidarEliminar(objEntExpedienteIndCol.Expediente(0).Codigo) = True Then
                    For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                        AEliminarAgraviadoBD(EntAgr.Codigo)
                    Next
                    For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol
                        AEliminarDelitoBD(EntDel.Codigo)
                    Next
                    For Each EntExp As Entity.Registro.Expediente In objEntExpedienteIndCol
                        AEliminarExpedienteBD(EntExp.Codigo)
                    Next
                End If
            End If
            If blnEliminarDelitoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
            End If
            If blnEliminarAgraviadoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
            End If
        End Sub
#End Region
#Region "Grabar"
#Region "Expediente"

        Private Sub Temporal_ExpedienteCopiarPropiedades(objEntOrigen As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)
            With objEntOrigen
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
                .Flagrancia = ObjEntDestino.Flagrancia
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

        Private Function TemporalDelitoItemMaximo(objEntCol As Entity.Registro.DelitoCol) As Integer
            Dim intNumero As Integer = 0

            For Each obj As Entity.Registro.Delito In objEntCol
                If obj.DelitoItem > intNumero Then intNumero = obj.DelitoItem
            Next
            Return intNumero
        End Function
        Private Sub Temporal_Delito_Modificar()




        End Sub
#End Region

#End Region
#End Region

#Region "Listar"

        Public Sub _ListarPeriodo(DocumentoJudicialID As Integer)
            If DocumentoJudicialID > 0 Then 'si es nuevo y se muestra los checkeds

                objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                objEntPerCon.DocJudicialId = DocumentoJudicialID
                objEntPerCon.RegionId = Me._RegionID
                objEntPerCon.PenalId = Me._PenalID
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    objEntPerCon.PenalId = -1
                End If
                objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar_V2(objEntPerCon)
                For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1 'indexar cada expediente
                    objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                    Me._TotalAnhos = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).Anio
                    Me._TotalMes = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).Mes
                    Me._TotalDias = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).Dia
                Next

            End If
            Listar_PeriodoCondena()
            bolEdicionActivo = True

        End Sub
        Private Sub Listar_PeriodoCondena()
            If objEntPeriodoCondenaTempoCol Is Nothing Then
                objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            End If
            With dgvPeriodoCondena
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = IIf(objEntPeriodoCondenaTempoCol.Count < 1, Nothing, objEntPeriodoCondenaTempoCol)
            End With
            For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                Me.dgvPeriodoCondena.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                If dgvPeriodoCondena.Item("col_eliminado", i).Value = True Then Me.dgvPeriodoCondena.Rows(i).Visible = False
            Next
        End Sub
#End Region
#Region "Validar"
        Private Function ValidarTipoResolucion(Valor As Integer) As Boolean
            Dim ListaTipo = {Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia}
            For Each Codigo As Integer In ListaTipo
                If Valor = Codigo Then
                    Return False
                    Exit For
                    Exit Function
                End If
            Next
            Return True
        End Function
        Public Function ValidarExpedienteReferenciado(Condicion As String) As Boolean
            If Me._DocumentoJudicialID > 0 Then
                Dim strMensaje As String = ""
                Dim intValorpadre As Integer = 0
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                Select Case Condicion
                    Case 1
                        strMensaje = "no se puede agregar expedientes"
                    Case 2
                        strMensaje = "no se puede agregar delitos"
                    Case 3
                        strMensaje = "no se puede agregar agraviados"
                    Case 4
                        strMensaje = "no se puede agregar [Tiempo de condena] o [Periodo de condena]"
                    Case 5
                        strMensaje = "no se puede eliminar [Tiempo de condena] o [Periodo de condena]"
                    Case 6
                        strMensaje = "VAL"
                    Case 7
                        strMensaje = "[Operación cancelada]"
                End Select

                Dim intValor As Integer = 0
                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    If objEntExpediente.Codigo > 0 Then
                        objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                        objEntExpPadre.InternoID = objEntExpediente.InternoID
                        If objBssExpedientePad.ExisteExpedienteHijo(objEntExpPadre) > 0 Then
                            intValor = intValor + 1
                        End If
                    End If
                Next
                If intValor > 0 Then
                    If strMensaje <> "VAL" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)
                    End If
                    Return False
                End If
            End If
            Return True
        End Function
#End Region
#Region "Accion"

        Public Sub _Grabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDoc As Entity.Registro.DocumentoJudicial)
            ' EliminarExpedienteBD()
            AGrabar(DocumentoJudicialID, Nuevo, EntDoc)
        End Sub
        Private Sub AGrabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDoc As Entity.Registro.DocumentoJudicial)

            objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia
            For Each entPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                With entPerCond
                    .DocJudicialId = DocumentoJudicialID
                    .InternoId = Me._InternoId
                    .IngresoId = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .Anio = Me.txtAnios.Text
                    .Mes = IIf(Me.txtMeses.Text.Length = 0, 0, Me.txtMeses.Text)
                    .Dia = IIf(Me.txtDias.Text.Length = 0, 0, Me.txtDias.Text)
                End With
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    If entPerCond.FlgEliminado = True Then
                        If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                    Else
                        objBssPerCon.Grabar_LM_V2(entPerCond)
                    End If
                Else
                    If entPerCond.FlgEliminado = True Then
                        If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                    Else
                        objBssPerCon.Grabar_LM_V2(entPerCond)
                    End If
                End If
            Next

        End Sub

        Private Function AEliminarAgraviadoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then
                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                value = objBssAgraviado.Eliminar(Codigo, Me.FlagTransferSede)
            End If
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
                value = objBssExpediente.Eliminar2(Codigo, Me.FlagTransferSede)
                If value > 0 Then
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    objBssExpedientePad.Eliminar(intPadre, Me.FlagTransferSede)
                    objBssExpediente.GrabarEstadoVisibilidad(intPadre, True, Me.FlagTransferSede)
                End If
            End If
            Return value

        End Function
        Private Function ValidarEliminar(Codigo As Integer) As Boolean
            For Each EntVal As Entity.Registro.Expediente In objEntExpedienteTempoCol
                If Codigo = EntVal.Codigo Then
                    Return False
                    Exit For
                End If
            Next
            Return True
        End Function
#End Region

#Region "Otros"

        Private Sub ValoresxDefault()
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            objEntDelitoTempoCol = New Entity.Registro.DelitoCol
            objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol
            objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
        End Sub
        Private Sub ElimanarPeriodoCondena()
            If dgvPeriodoCondena.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un periodo de condena para eliminar")
                Exit Sub
            End If
            If dgvPeriodoCondena.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                Exit Sub
            End If
            If Me._DocumentoJudicialID > 0 Then
                Dim intConta As Integer = 0
                For Each EntExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If EntExp.ExpedienteReferido = True Then
                        intConta = intConta + 1
                    End If
                Next
                If intConta > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede eliminar el periodo de condena, porque el expediente ya ha sido referenciado")
                    Exit Sub
                End If
            End If
            If Legolas.Configuration.Aplication.MessageBox.Question("¿Esta Seguro de eliminar el periodo de condena seleccionado?") = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1
                    If Me.GrillaPeriodoCondenaItem = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                        objEntPeriodoCondenaTempoCol.Remove(i)
                        Listar_PeriodoCondena()
                        Exit For
                    End If
                Next
            End If
        End Sub

#End Region



        Private Sub dgvPeriodoCondena_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPeriodoCondena.CellDoubleClick
            If dgvPeriodoCondena.Rows.Count < 1 Then Exit Sub
            btnEditPerCond_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEditPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnEditPerCond.Click

            If dgvPeriodoCondena.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para modificar")
                Exit Sub
            End If
            If dgvPeriodoCondena.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para modificar")
                Exit Sub
            End If
            Dim intConta As Integer = 0

            For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1
                If Me.GrillaPeriodoCondenaItem = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                    If intConta > 0 Then
                        objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).ValorRef = True
                    End If
                    RaiseEvent _Click_PeriodoCondena_Editar(objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i))
                    Exit For
                End If
            Next
        End Sub

        Private Sub btnDelPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnDelPerCond.Click
            If dgvPeriodoCondena.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un periodo de condena para eliminar")
                Exit Sub
            End If
            If Me._DocumentoJudicialID > 0 Then
                If ValidarExpedienteReferenciado(5) = False Then
                    Exit Sub
                End If
            End If
            If dgvPeriodoCondena.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.Question("¿Esta Seguro de eliminar el periodo de condena seleccionado?") = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1
                    If Me.GrillaPeriodoCondenaItem = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                        objEntPeriodoCondenaTempoCol.Remove(i)
                        Listar_PeriodoCondena()
                        Exit For
                    End If
                Next
            End If
        End Sub

        Private Sub btnAddPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPerCond.Click
            If Me._DocumentoJudicialID > 0 Then
                If ValidarExpedienteReferenciado(4) = False Then
                    Exit Sub
                End If
            End If
            RaiseEvent _Click_PeriodoCondena_Agregar()
        End Sub

        Private Sub dgwExpediente_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            btnEditExpe_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEditExpe_Click(sender As System.Object, e As System.EventArgs)
        End Sub

        Private Sub btnEliminarExp_Click(sender As System.Object, e As System.EventArgs)

            Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)

        End Sub



        Private Sub btnAddDelito_Click(sender As System.Object, e As System.EventArgs)
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(2) = False Then
                    Exit Sub
                End If
            End If

            bolEdicionActivo = False
            If objEntDelitoTempoColGrilla Is Nothing Then
                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
            End If

            bolEdicionActivo = True
        End Sub



        Public Sub New()
            InitializeComponent()
            ValoresxDefault()
        End Sub

        Private Sub dgwDelito_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            If e.ColumnIndex = -1 Or e.RowIndex = -1 Or bolEdicionActivo = False Then Exit Sub


        End Sub

        Private Sub uscDetallRegistroSentencia_Load(sender As Object, e As System.EventArgs) Handles Me.Load



        End Sub

        Private Sub dgwExpediente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)

            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)

            End If


        End Sub

        Private Sub dgwDelito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Delete Then
                e.Handled = True

            End If

        End Sub


        Private Sub dgvPeriodoCondena_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvPeriodoCondena.KeyDown
            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                ElimanarPeriodoCondena()

            End If

        End Sub

        Private Sub dgwExpediente_RowStateChanged(sender As Object, e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)

        End Sub

        Private Sub txtAnios_Click(sender As Object, e As System.EventArgs) Handles txtAnios.Click
            txtAnios.Focus()
        End Sub

        Private Sub txtAnios_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnios.KeyPress
            If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
                e.Handled = True
            End If
        End Sub


    End Class
End Namespace