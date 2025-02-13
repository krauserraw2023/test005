Imports System.Globalization
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.SubTipoDocJudicial
Imports Type.Enumeracion.TipoDocJudicial

Namespace Registro.Resoluciones
    Public Class uscResolucionesMain_LM
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
        Private objEntFiltroDocJud As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing

        Dim Contador_ As Integer = 0
        Public _ChekedValor As Boolean = False
        Public Property _ExcluirMandatoDeCarceleta As Boolean = False
#Region "Eventos"
        Public Event _Click_BtnNuevoResolucion(IngresoID As Integer, ResIngRegistrado As Boolean, Opcion As Integer)
        Public Event _Click_BtnModificarResolucion(TipoDocumento As Integer, DocJudicialId As Integer, SubTipo As Integer, _penId As Integer, Version As String)
        Public Event _Click_BtnVerExpedientesPorResolucion(IdResolucion As Integer)
        Public Event _Click_BtnEliminarActualizarEstadoInterno()
        Public Event _ClickFocusCombo()
#End Region
        '--
#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _NroIngresoID() As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    v = 1
                End If
                Return v
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCount() As Integer
            Get
                Return dgwGrilla.Rows.Count
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
        Private ReadOnly Property GrillaPenalId() As Integer
            Get
                Try
                    Return dgwGrilla.SelectedRows(0).Cells("col_pen_id").Value
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
                If Me.rdbIngreso.Checked = True Then value = 1 'ingreso
                If Me.rdbEgreso.Checked = True Then value = 3 'egreso
                If Me.rdbSentencia.Checked = True Then value = 2 'sentencias
                If Me.rdbAclarados.Checked = True Then value = 1

                Return value
            End Get
        End Property

        Private ReadOnly Property DocumentoTipo() As Short
            Get
                Dim value As Short = -1
                'ingreso
                If Me.rdbAclarados.Checked = True Then
                    value = enumTipoDocumentoJudicial.Aclaratoria
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
            objEntFiltroDocJud = New Entity.Registro.DocumentoJudicial

            objEntFiltroDocJud.InternoId = Me._InternoID
            objEntFiltroDocJud.DocumentoCategoria = Me.DocumentoCategoria

            Select Case _TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                     Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana

                    objEntFiltroDocJud.InternoIngresoId = -1
                    objEntFiltroDocJud.IngresoInpeId = Me._IngresoInpeID
                    objEntCol = objBss.ListarGrilla_LM(objEntFiltroDocJud, Me._TipoLicencia)

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta

                    objEntFiltroDocJud._PenalID = Me._PenalID
                    objEntFiltroDocJud.IngresoInpeId = Me._IngresoInpeID
                    objEntFiltroDocJud.InternoIngresoId = -1
                    objEntCol = objBss.ListarGrillaDocCarceleta_LM(objEntFiltroDocJud, Me._TipoLicencia, _ExcluirMandatoDeCarceleta)
            End Select

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

            'validar cantidad de registros
            If GrillaCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If

            If Me._VisibleEliminar = False Then

                Select Case Me.GrillaTipoDocumentoId
                    Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital,
                         Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.RetornoTrasladoHospital,
                         Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital_Nota
                    Case Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario no tiene permiso para realizar esta operación")
                        Exit Sub
                End Select

            End If

            Dim strMensaje As String = "Confirma eliminar el registro seleccionado ?" + Chr(13) +
             " " + Chr(13) + "Esta acción eliminara los expedientes / delitos y agraviados " + Chr(13) +
             "del documento, tenga en cuenta que completada la operación, no podrá recuperar el registro."

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = Windows.Forms.DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                objBss = New Bussines.Registro.DocumentoJudicial
                '*************Verificar si esta referenciado******************************
                Dim objEntExpCol As New Entity.Registro.ExpedienteCol
                Dim BssExp As New Bussines.Registro.Expediente
                objEntExpCol = BssExp.ListarExpedientexResolucion_LM(Me.GrillaResolucionId)
                Dim entPad As New Entity.Registro.InternoExpedientePadre
                Dim BssPad As New Bussines.Registro.InternoExpedientePadre

                '--------'*******solo para avocamiento*******************************
                If Me.GrillaTipoDocumentoId = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                    Dim objEntExpColcopi2 As New Entity.Registro.ExpedienteCol
                    objEntExpColcopi2 = BssExp.ListarExpedientexResolucion_LM(Me.GrillaResolucionId)
                    Dim Mayor As Integer = 0
                    For Each objEntExpediente As Entity.Registro.Expediente In objEntExpColcopi2
                        If objEntExpediente.Codigo >= Mayor Then
                            Mayor = objEntExpediente.Codigo
                            objEntExpCol = New Entity.Registro.ExpedienteCol
                            objEntExpCol.Add(objEntExpediente)
                        End If
                    Next
                End If

                '*******************************************************************
                Dim codigoPadre As Integer = -1
                For Each entExp_ As Entity.Registro.Expediente In objEntExpCol
                    entPad.InternoExpedienteId = entExp_.Codigo
                    entPad._PenalId = -1
                    entPad.IngresoInpeId = Me._IngresoInpeID
                    If Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                        entPad.DocJudicialID = -1
                    Else
                        entPad.DocJudicialID = Me.GrillaResolucionId
                    End If
                    codigoPadre = BssPad.ValidarExpediente_LM(entPad)
                    If codigoPadre > 0 Then
                        Exit For
                    End If
                Next

                If codigoPadre > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible completar la operación solicitada, la Resolución contiene un expediente que ha sido referenciado.")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                '*****************************************************************
                If objBss.Eliminar_LM(Me.GrillaResolucionId, Me.GrillaTipoDocumentoId, Me.GrillaSubTipoDocumentoId, Me._InternoID, Me._IngresoInpeID,
                                      strMensaje, Me.FlagTransferSede) > 0 Then
                    RaiseEvent _Click_BtnEliminarActualizarEstadoInterno()
                    _Listar()
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                End If

                Me.Cursor = Cursors.Default
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()
            Me.pnlGrabar.Visible = True ' Me._VisibleGrabar
            Me.pnlEli.Visible = Me._VisibleEliminar
            Me.pnlAnular.Visible = False
            col_ing_inp_nro.Visible = True

            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta
                    col_doc_lib.Visible = False
                    col_doc_fol.Visible = False
                    col_pen_nom.Visible = False
                Case enmTipoLicencia.PenalLimaMetropolitana
                    col_doc_lib.Visible = False
                    col_doc_fol.Visible = False
                    col_pen_nom.Visible = False
                Case enmTipoLicencia.RegionLimaMetropolitana
                    col_doc_lib.Visible = True
                    col_doc_fol.Visible = True
                    col_pen_nom.Visible = True
            End Select
        End Sub

        'verifica si existe registrado resolucion de ingreso
        Private Function ResolIngresoRegistrado() As Boolean
            For i As Integer = 0 To dgwGrilla.Rows.Count - 1
                If (dgwGrilla.Item("col_tip_doc_nom", i).Value = "INGRESO" _
                    Or dgwGrilla.Item("col_tip_doc_nom", i).Value = "DETENCION") _
                    And dgwGrilla.Item("col_estado", i).Value = "ACTIVO" Then
                    Return True
                End If
            Next
            Return False
        End Function

        Public Sub LoadUsc()
            _Listar()
            col_ing_inp_nro.Visible = True

            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta
                    'col_ing_inp_nro.Visible = True
                    'col_ing_pen_nro.Visible = False
                Case enmTipoLicencia.RegionLimaMetropolitana
                    'col_ing_inp_nro.Visible = True
                    'col_ing_pen_nro.Visible = False
                    col_pen_nom.Visible = False
                Case enmTipoLicencia.PenalLimaMetropolitana
                    'col_ing_pen_nro.Visible = True
                    'col_ing_inp_nro.Visible = False
                    col_pen_nom.Visible = False
            End Select
        End Sub
#End Region

#Region "Eventos_Formulario"
        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe grabar los datos básicos del interno y registrar el número de ingreso correspondiente.")
                Exit Sub
            End If

            If Me._IngresoInpeID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                RaiseEvent _ClickFocusCombo()
                Exit Sub
            End If

            RaiseEvent _Click_BtnNuevoResolucion(Me._IngresoInpeID, ResolIngresoRegistrado, Me._OpcionListar)
        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
            If dgwGrilla.SelectedRows.Count > 0 Then
                RaiseEvent _Click_BtnModificarResolucion(Me.GrillaTipoDocumentoId, Me.GrillaResolucionId, IIf(Me.GrillaTipoDocumentoId = 6, Me.GrillaVersionLibertad, Me.GrillaSubTipoDocumentoId), Me.GrillaPenalId, Me.GrillaVersion)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                Exit Sub
            End If
        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            With Me.dgwGrilla
                If e.RowIndex = -1 Then
                    Me.Cursor = Cursors.WaitCursor
                    'objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    .CurrentCell = Nothing
                    Me.Cursor = Cursors.Default
                    .Refresh()
                End If
            End With
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            If e.RowIndex > -1 Then btnModificar_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            EliminarResolucion()
        End Sub

        Private Sub btnInactivar_Click(sender As System.Object, e As System.EventArgs) Handles btnInactivar.Click
            If Me.dgwGrilla.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("No existe Ningún registro para anular")
                Exit Sub
            End If
        End Sub

        Private Sub btnVerDetalleExp_Click(sender As System.Object, e As System.EventArgs) Handles btnVerDetalleExp.Click
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta
                    RaiseEvent _Click_BtnVerExpedientesPorResolucion(Me._IngresoInpeID)
                Case enmTipoLicencia.PenalLimaMetropolitana
                    RaiseEvent _Click_BtnVerExpedientesPorResolucion(Me._NroIngresoID)
                Case enmTipoLicencia.RegionLimaMetropolitana
                    RaiseEvent _Click_BtnVerExpedientesPorResolucion(Me._IngresoInpeID)
            End Select
        End Sub

        Private Sub dgwGrilla_RowPrePaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint
            dgwGrilla.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End Sub
#End Region
        Public Sub MostrarBotonOcultaDetExp(Optional visible As Boolean = True)
            btnVerDetalleExp.Visible = visible
        End Sub
        Private Sub rdbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _
            rdbTodos.CheckedChanged, _
            rdbIngreso.Click, _
            rdbEgreso.Click, _
            rdbAclarados.Click, _
            rdbSentencia.Click

            If Contador_ = 0 Then
                Contador_ = Contador_ + 1
                Me._OpcionListar = enumListar.Todos
            Else
                If rdbIngreso.Checked = True Then
                    Me._OpcionListar = enumListar.Ingreso
                ElseIf rdbEgreso.Checked = True Then
                    Me._OpcionListar = enumListar.Egreso
                ElseIf rdbAclarados.Checked = True Then
                    Me._OpcionListar = enumListar.Aclarados
                ElseIf rdbSentencia.Checked = True Then
                    Me._OpcionListar = enumListar.Sentencia
                ElseIf rdbTodos.Checked = True Then
                    Me._OpcionListar = enumListar.Todos
                End If
                _Listar()
            End If
        End Sub

        Private Sub dgwGrilla_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown
            If e.KeyCode = Keys.Delete Then EliminarResolucion()
        End Sub

        Private Sub uscResolucionesMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            dgwGrilla.VisibleCampos = True
            gbRadioButon.Visible = False
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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

    End Class
End Namespace
