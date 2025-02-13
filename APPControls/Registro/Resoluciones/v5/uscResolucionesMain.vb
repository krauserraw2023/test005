
Imports System.Globalization

Namespace Registro.Resoluciones
    Public Class uscResolucionesMain
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private BssPadin As New Bussines.Estadistica.PadinDelito

        Public Event _Click_BtnNuevoResolucion(IngresoID As Integer, ResIngRegistrado As Boolean, Opcion As Integer)
        Public Event _Click_BtnModificarResolucion(TipoDocumento As Integer, DocJudicialId As Integer, SubTipo As Integer, Version As String)
        Public Event _Click_BtnVerExpedientesPorResolucion(IdResolucion As Integer)
        Public Event _Click_BtnEliminarActualizarEstadoInterno()
        Public Event _ClickFocusCombo()

#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _NroIngresoID() As Integer = -1
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
        Private ReadOnly Property GrillaCount() As Integer
            Get
                Try
                    Return dgwGrilla.Rows.Count
                Catch ex As Exception
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaTipoDocumentoId() As Integer
            Get
                Try
                    Return dgwGrilla.SelectedRows(0).Cells("col_doc_tip").Value
                Catch ex As Exception
                End Try

            End Get
        End Property
        Private ReadOnly Property GrillaSubTipoDocumentoId() As Integer
            Get
                Try
                    Return dgwGrilla.SelectedRows(0).Cells("col_doc_sub_tip").Value
                Catch ex As Exception
                End Try

            End Get
        End Property
        Private ReadOnly Property GrillaResolucionId() As Integer
            Get
                Try
                    Return dgwGrilla.SelectedRows(0).Cells("col_codigo").Value
                Catch ex As Exception
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaEstado() As Integer
            Get
                Try
                    Return dgwGrilla.SelectedRows(0).Cells("col_estado").Value
                Catch ex As Exception
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoAnulacion() As Integer
            Get
                Try
                    Return dgwGrilla.SelectedRows(0).Cells("col_anu_id").Value
                Catch ex As Exception
                End Try
            End Get
        End Property
        Public Property _OpcionListar() As Integer = -1

        Private ReadOnly Property GrillaVersionLibertad() As Integer
            Get
                Dim valor As Integer = -1
                For Each obj As Entity.Registro.DocumentoJudicial In objEntCol
                    If Me.GrillaResolucionId = obj.Codigo Then
                        valor = obj.Proceso_Pendiente_Queda
                        Exit For
                    End If
                Next
                Try
                    Return valor
                Catch ex As Exception
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaVersion() As String
            Get
                Try
                    Return dgwGrilla.SelectedRows(0).Cells("col_doc_vers").Value
                Catch ex As Exception
                End Try
            End Get
        End Property
#End Region
#Region "Propiedades_USC"
        Private blnVisibleGrabar As Boolean = False
        Private blnVisibleEliminar As Boolean = False
        Public Property _VisibleGrabar As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(value As Boolean)
                blnVisibleGrabar = value
                VisibleControles()
            End Set
        End Property
        Public Property _VisibleEliminar As Boolean
            Get
                Return blnVisibleEliminar
            End Get
            Set(value As Boolean)
                blnVisibleEliminar = value
                VisibleControles()
            End Set
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

                Return value
            End Get
        End Property
        Private ReadOnly Property DocumentoTipo() As Short
            Get
                Dim value As Short = -1
                'ingreso
                If Me.rdbAclarados.Checked = True Then
                    value = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria

                Else
                    value = -1
                End If
                Return value
            End Get
        End Property
        Private Property DocumentoSubTipo() As Short = -1
#End Region
#Region "Listar"
        Public Sub _Listar()
            If Me._InternoID < 1 Then Exit Sub

            objEntCol = New Entity.Registro.DocumentoJudicialCol
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objEnt.InternoIngresoId = Me._NroIngresoID ' Me._Codigo
            objEnt.InternoId = Me._InternoID
            objEnt.DocumentoTipo = -1
            objEnt.DocumentoCategoria = Me.DocumentoCategoria
            objEntCol = objBss.ListarGrilla(objEnt)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                lblReg.Text = .Rows.Count & " Reg."
                .Refresh()
            End With
            Me._ChekedValor = False
        End Sub
        Public Sub _Listar2()
            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                lblReg.Text = .Rows.Count & " Reg."
                .Refresh()
            End With
        End Sub
#End Region
#Region "Accion"

        Private Sub EliminarResolucion()
            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If

            If GrillaCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If

            Dim strMensaje As String = "Confirma eliminar el registro seleccionado ?" + Chr(13) +
             "Esta accion eliminara los expedientes / delitos y agraviados " + Chr(13) +
             "del documento, tenga en cuenta que completada la operación" + Chr(13) +
             "no podrá recuperar el registro."
            If Me.GrillaTipoDocumentoId = 13 And Me.GrillaSubTipoDocumentoId = 2 Then strMensaje = "Confirma eliminar el registro seleccionado ?" + Chr(13) +
                                                                                                    "Esta accion eliminara el documento" + Chr(13) +
                                                                                                    "tenga en cuenta que completada la operación" + Chr(13) +
                                                                                                    "no podrá recuperar el registro."
            '**************Verificar si esta anulado****************************
            If objEntCol.DocumentoJudicial(dgwGrilla.SelectedRows(0).Index).IdDocumentoAntecedente >= Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede eliminar la resolucion, porque su estado es Anulado.")
                Exit Sub
            End If
            '***********verificar si la resolucion esta enlazada aun movimiento
            Dim bssMov As New Bussines.Registro.InternoMovimiento
            Dim objEntMovFec As New Entity.Registro.InternoMovimiento
            Dim objEntMov As New Entity.Registro.InternoMovimiento

            objEntMov.DocumJudicialID = Me.GrillaResolucionId
            objEntMov.InternoID = Me._InternoID
            objEntMov.IngresoID = Me._NroIngresoID

            objEntMovFec = bssMov.Listar(objEntMov)
            Dim datFechaDoc As Date = Legolas.Components.FechaHora.FechaDate(objEntMovFec.Fecha, True)

            objEntMov.Codigo = -1
            objEntMov = bssMov.Listar(objEntMov)
            Dim datFechaUltima As Date = Legolas.Components.FechaHora.FechaDate(objEntMov.Fecha, True)
            '*************Verificar si esta referenciado******************************
            Dim objEntExpCol As New Entity.Registro.ExpedienteCol
            Dim BssExp As New Bussines.Registro.Expediente

            objEntExpCol = BssExp.ListarExpedientexResolucion(Me.GrillaResolucionId)
            Dim entPad As New Entity.Registro.InternoExpedientePadre
            Dim BssPad As New Bussines.Registro.InternoExpedientePadre
            '--------'*******solo para avocamiento**************************************
            If Me.GrillaTipoDocumentoId = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                Dim objEntExpColcopi2 As New Entity.Registro.ExpedienteCol
                objEntExpColcopi2 = BssExp.ListarExpedientexResolucion(Me.GrillaResolucionId)
                Dim Mayor As Integer = 0

                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpColcopi2
                    If objEntExpediente.Codigo >= Mayor Then
                        Mayor = objEntExpediente.Codigo
                        objEntExpCol = New Entity.Registro.ExpedienteCol
                        objEntExpCol.Add(objEntExpediente)
                    End If
                Next
            End If
            '-------------'*******************************************************************
            Dim intConta As Integer = 0
            Dim strMsj As String = ""
            For Each entDocJudExp_ As Entity.Registro.Expediente In objEntExpCol
                entPad.InternoExpedienteId = entDocJudExp_.Codigo
                entPad._PenalId = Me._PenalID
                entPad.IngresoID = -1  ' entDocJudExp_.IngresoID
                Dim blnValor As Boolean = BssPad.ValidarExpediente(entPad)
                If blnValor = False Then
                    intConta = intConta + 1
                    Exit For
                End If
                Select Case entDocJudExp_.EstadoEjecucion
                    Case 2
                        strMsj = "Apto para el registro de egreso"
                        Exit For
                    Case 3
                        strMsj = "en estado Ejecutado"
                        Exit For
                End Select
            Next
            '******************************************************************
            Select Case Me.GrillaTipoDocumentoId
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    If objEntMovFec.DocumJudicialID > 0 And datFechaDoc < datFechaUltima Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Esta resolucion esta referenciado por un movimiento ó existe un movimiento de fecha superior, operacion suspendida")
                        Exit Sub
                    Else
                        If Me.GrillaSubTipoDocumentoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                            strMensaje = "Confirma eliminar el registro seleccionado ?" + Chr(13) +
                           "" + Chr(13) +
                            "Esta accion eliminara el documento de ingreso por traslado" + Chr(13) +
                            "y el Movimiento de traslado generado por este documento " + Chr(13) +
                            "tenga en cuenta que completada la operación no podrá recuperar el registro."
                        ElseIf objEntMovFec.DocumJudicialID > 0 Then
                            strMensaje = "Confirma eliminar el registro seleccionado ? " + Chr(13) +
                            "" + Chr(13) +
                             "Esta accion eliminara los expedientes / delitos y agraviados" + Chr(13) +
                             "y el movimiento generado por este documento " + Chr(13) +
                             "tenga en cuenta que completada la operación no podrá recuperar el registro."
                        End If
                    End If
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
                    objEnt = New Entity.Registro.DocumentoJudicial
                    objEnt.Codigo = Me.GrillaResolucionId
                    objEnt.InternoId = Me._InternoID
                    objEnt = (New Bussines.Registro.DocumentoJudicial).Listar_v2(objEnt)

                    If objEnt.MovimientoId > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El documento seleccionado no se puede eliminar porque" + Chr(13) +
                                                                                "tiene asociado un movimiento de egreso." + Chr(13) +
                                                                                "Si desea eliminarlo, primero debe eliminar el movimiento.")
                        Exit Sub
                    End If
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                    If objEntMovFec.DocumJudicialID > 0 Then
                        strMensaje = "Confirma eliminar el registro seleccionado ? " + Chr(13) +
                       "" + Chr(13) +
                        "Esta accion eliminara el documento " + Chr(13) +
                        "y el movimiento referenciado por este documento, tenga en cuenta" + Chr(13) +
                        "que completada la operación no podrá recuperar el registro."
                    Else
                        strMensaje = "Confirma eliminar el registro seleccionado ? " + Chr(13) +
                      "" + Chr(13) +
                       "Esta accion eliminara el documento, tenga en cuenta " + Chr(13) +
                       "que completada la operación no podrá recuperar el registro."
                    End If
            End Select
            '*****************************************************************
            If intConta > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible completar la operación solicitada, la Resolucion contiene un expediente que ha sido referenciado.")
                Exit Sub
            End If
            If strMsj.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible completar la operación solicitada, la Resolucion se encuentra " & strMsj)
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                objBss = New Bussines.Registro.DocumentoJudicial
                BssPadin.Eliminar(Me.GrillaResolucionId, Me._InternoID, Me._NroIngresoID)
                If objBss.Eliminar(Me.GrillaResolucionId, Me.GrillaTipoDocumentoId, Me.GrillaSubTipoDocumentoId, Me._InternoID, Me._NroIngresoID, strMensaje, Me.FlagTransferSede, objEntExpCol) > 0 Then
                    RaiseEvent _Click_BtnEliminarActualizarEstadoInterno()
                    _Listar()
                End If
                Me.Cursor = Cursors.Default
            End If
            '******************************************************************
        End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()

            Me.pnlGrabar.Visible = Me._VisibleGrabar
            Me.pnlEli.Visible = Me._VisibleEliminar
            Me.pnlAnular.Visible = False

        End Sub
        'verifica si existe registrado resolucion de ingreso
        Private Function ResolIngresoRegistrado() As Boolean
            For i As Integer = 0 To dgwGrilla.Rows.Count - 1
                If (dgwGrilla.Item("col_tip_doc_nom", i).Value = "INGRESO" Or dgwGrilla.Item("col_tip_doc_nom", i).Value = "DETENCION") _
                    And dgwGrilla.Item("col_estado", i).Value = "ACTIVO" Then
                    Return True
                End If
            Next
            Return False
        End Function
        Public Sub LoadUsc()
            _Listar()
        End Sub
#End Region

#Region "Eventos_Formulario"
        Public Sub MostrarBotonDetExp(Optional visible As Boolean = True)
            btnVerDetalleExp.Visible = visible
        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click

            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me._NroIngresoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                RaiseEvent _ClickFocusCombo()
                Exit Sub
            End If

            RaiseEvent _Click_BtnNuevoResolucion(Me._NroIngresoID, ResolIngresoRegistrado, Me._OpcionListar)

        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
            If dgwGrilla.SelectedRows.Count > 0 Then
                Dim valorId As Integer = IIf(Me.GrillaTipoDocumentoId = 6, Me.GrillaVersionLibertad, Me.GrillaSubTipoDocumentoId)
                'RaiseEvent _Click_BtnModificarResolucion(Me.GrillaTipoDocumentoId, Me.GrillaResolucionId, IIf(Me.GrillaTipoDocumentoId = 6, Me.GrillaVersionLibertad, Me.GrillaSubTipoDocumentoId))
                RaiseEvent _Click_BtnModificarResolucion(Me.GrillaTipoDocumentoId, Me.GrillaResolucionId, valorId, Me.GrillaVersion)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                Exit Sub
            End If
        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            With Me.dgwGrilla
                If e.RowIndex = -1 Then

                    Me.Cursor = Cursors.WaitCursor
                    objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    Me.Cursor = Cursors.Default
                    .Refresh()

                End If
            End With
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            If e.RowIndex > -1 Then
                btnModificar_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            EliminarResolucion()
        End Sub

        Private Sub btnInactivar_Click(sender As System.Object, e As System.EventArgs) Handles btnInactivar.Click
            If Me.dgwGrilla.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("No existe Ningun registro para anular")
                Exit Sub
            End If

        End Sub

        Private Sub btnVerDetalleExp_Click(sender As System.Object, e As System.EventArgs) Handles btnVerDetalleExp.Click
            RaiseEvent _Click_BtnVerExpedientesPorResolucion(Me._NroIngresoID)
        End Sub

        Private Sub dgwGrilla_RowPrePaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint
            dgwGrilla.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End Sub
#End Region


        Dim Contador_ As Integer = 0
        Private Sub rdbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _
            rdbTodos.CheckedChanged,
            rdbIngreso.Click,
            rdbEgreso.Click,
            rdbAclarados.Click,
            rdbSentencia.Click

            If Contador_ = 0 Then
                Contador_ = Contador_ + 1
                Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Todos
            Else
                If rdbIngreso.Checked = True Then
                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Ingreso
                ElseIf rdbEgreso.Checked = True Then
                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Egreso
                ElseIf rdbAclarados.Checked = True Then
                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Aclarados
                ElseIf rdbSentencia.Checked = True Then
                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Sentencia
                ElseIf rdbTodos.Checked = True Then
                    Me._OpcionListar = Type.Enumeracion.SubTipoDocJudicial.enumListar.Todos
                End If
                _Listar()
            End If

        End Sub


        Private Sub dgwGrilla_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete Then

                EliminarResolucion()

            End If

        End Sub

        Public _ChekedValor As Boolean = False
        Private Sub uscResolucionesMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            dgwGrilla.VisibleCampos = True
            gbRadioButon.Visible = False
            With Me.dgwGrilla
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True

        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_doc_recep").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

    End Class
End Namespace
