Imports System.Windows.Forms
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.TipoDocJudicial

Namespace Registro.Expediente.v5
    Public Class frmDelitoPopup4
        Private objBssDel As Bussines.Registro.Delito = Nothing
        Private objEntDel As Entity.Registro.Delito = Nothing
        Private objEnt As Entity.Registro.Agraviado = Nothing
        Private objBss As Bussines.Registro.InternoAgraviado = Nothing
        Public _objEntAgravCol_Ind As Entity.Registro.AgraviadoCol = Nothing
        Private blnSwitch As Boolean = False
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = 0
        Public Property _InternoID As Integer = 0
        'Public Property _NroIngresoInpeID As Integer = -1
        Public Property _IngresoID As Integer = 0
        Public Property _ExpedienteID As Integer = 0
        Public Property _ExpedienteIDAux As Integer = 0
        Public Property _DelitoID As Integer = 0
        Public Property _ExpedienteItem As Integer = 0
        Public Property _DelitoItem As Integer = 0
        Public Property _TemporalNuevo As Boolean = False
        Public Property _TipoDocumento As Integer = -1
        Public Property _GrabarEnablet As Boolean = False

        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
        Public Property _TipoDelito As Type.Enumeracion.enmTipoDelito = Type.Enumeracion.enmTipoDelito.Delitos
#Region "Propiedades"

        Private Property Switch As Integer = 1
        Public Property DelitoGenericoID() As Integer = -1
        Public Property DelitoGenericoNombre() As String
            Get
                Return Me.txtDelitogenerico.Text
            End Get
            Set(ByVal value As String)
                Me.txtDelitogenerico.Text = value
            End Set
        End Property
        Public Property DelitoEspecificoID() As Integer = -1
        Private Property Observacion() As String
            Get
                Return Me.txtObservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Otros"
        Public Property AgraviadoNombre As String = ""
        Public Property AgraviadoObservacion As String = ""
        Private blnVisibleGrabar As Boolean = False
        Private Property DelitoEstado() As Integer = -1
        Private _DelitoTipo As String
        Public Property DelitoTipo() As String
            Get
                Return _DelitoTipo
            End Get
            Set(ByVal value As String)
                _DelitoTipo = value
                Dim varia As String = ""
                If Me.DelitoTipo = 1 Then
                    varia = "ACTIVO"
                ElseIf Me.DelitoTipo = 2 Then
                    varia = "HISTORICO"
                Else
                    varia = ""
                End If
                '.Text = varia
            End Set
        End Property
        Private Property DelitoCapituloNro() As String
            Get
                Return Me.txtCapituloNro.Text
            End Get
            Set(ByVal value As String)
                Me.txtCapituloNro.Text = value
            End Set
        End Property
        Private Property DelitoCapituloNombre() As String
            Get
                Return Me.txtCapituloNombre.Text
            End Get
            Set(ByVal value As String)
                Me.txtCapituloNombre.Text = value
            End Set
        End Property
        Private Property DelitoSeccionNro() As String
            Get
                Return Me.txtSeccionNro.Text
            End Get
            Set(ByVal value As String)
                Me.txtSeccionNro.Text = value
            End Set
        End Property
        Private Property DelitoSeccionNombre() As String
            Get
                Return Me.txtSeccionNom.Text
            End Get
            Set(ByVal value As String)
                Me.txtSeccionNom.Text = value
            End Set
        End Property
        Private Property DelitoArticulo() As String
            Get
                Return Me.txtArticulo.Text
            End Get
            Set(ByVal value As String)
                Me.txtArticulo.Text = value
            End Set
        End Property
        Private Property DelitoTitulo() As String
            Get
                Return Me.txtTitulo.Text
            End Get
            Set(ByVal value As String)
                Me.txtTitulo.Text = value
            End Set
        End Property
        Public ReadOnly Property AgraviadoItem() As Integer
            Get
                Try
                    Return dgvAgraviados.SelectedRows(0).Cells("col_agr_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public Property AgraviadoItemCopia As Integer = -1


        Private _DelitoEspecificoNombre As String = ""
        Public ReadOnly Property DelitoEspecificoNombre() As String
            Get
                Return UscComboDelito1._DelitoEspecificoNombre
            End Get
            'Set(ByVal value As String)
            '    UscComboDelito1._DelitoEspecificoNombre = value
            'End Set
        End Property
#End Region

#End Region
#Region "Propiedades_Averiguar"

        Public Property _objEntDelito() As Entity.Registro.Delito
        Public Property _objEntDelitoCol() As Entity.Registro.DelitoCol
        Public Property _objEntAgraviado() As Entity.Registro.Agraviado
        Public Property _objEntAgraviadoCol() As Entity.Registro.AgraviadoCol
        Public Property _objEntAgraviadoCol_copi() As Entity.Registro.AgraviadoCol
        Public Property EliminarFila As Boolean = False
#End Region
#Region "Propiedades_Publicas"
        Public Property ResolucionNuevo As Boolean = False
        Public Property Delito() As Entity.Registro.Delito
            Get
                Return objEntDel
            End Get
            Set(value As Entity.Registro.Delito)
                objEntDel = value
            End Set
        End Property
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Resoluciones
#End Region
#Region "Listar"
        'djfgjfg
        Private Sub Listar() ''
            Dim delitem As Integer = Me._DelitoItem
            If _TemporalNuevo = True Then
                Me._DelitoItem = 0
            Else
                If _objEntDelito Is Nothing Then
                Else
                    With _objEntDelito
                        Me._Codigo = .Codigo
                        Me._InternoID = .InternoID
                        Me._IngresoID = .IngresoID
                        Me._InternoIngresoInpeId = .IngresoInpeId
                        Me._ExpedienteID = .ExpedienteID
                        Me.DelitoGenericoID = .DelitoGenerico
                        Me.DelitoGenericoNombre = .DelitoGenericoNombre 'cambiar
                        Me.DelitoEspecificoID = .DelitoEspecifico

                        'Dim DEL1 As Integer = .DelitoEspecifico
                        UscComboDelito1._DelitoGenericoID = .DelitoGenerico
                        UscComboDelito1._DelitoEspecifico_ID = .DelitoEspecifico
                        UscComboDelito1._Combo()
                        'cambiar

                        Me.Observacion = .Observacion
                        Me._DelitoItem = .DelitoItem
                        Me._ExpedienteItem = .ExpedienteItem
                        ListarDetalleDelito(.DelitoEspecificoNombre)
                        Me.Switch = 2
                    End With
                    Me.ResolucionNuevo = False
                    Me._DelitoItem = delitem
                    ValidarPadre()
                    If _objEntDelito.VisibleAuxiliar = True Then
                        btnOk.Enabled = False
                    End If
                End If
            End If
            With dgvAgraviados
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .DataSource = ""
                .DataSource = _objEntAgraviadoCol
                For i As Integer = 0 To .Rows.Count - 1
                    .Item(0, i).Value = i + 1
                Next
            End With
            Dim objBssPad As Bussines.Registro.InternoExpedientePadre
            objBssPad = New Bussines.Registro.InternoExpedientePadre
            Dim EntExp As New Entity.Registro.InternoExpedientePadre
            If Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                EntExp.Codigo = _objEntDelito.ExpedienteID
            Else
                EntExp.Codigo = Me._ExpedienteID
            End If

            EntExp.InternoID = Me._InternoID
            EntExp.IngresoID = -1 ' Me._IngresoID
            EntExp.IngresoInpeId = -1
            Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol

            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    EntColPad = objBssPad.ListarGrilla_LM(EntExp)
                Case Else
                    EntColPad = objBssPad.ListarGrilla(EntExp)
            End Select

            If Me._Codigo > 0 And Me._Codigo <> 999999 Then
                For Each EntCodi As Entity.Registro.InternoExpedientePadre In EntColPad
                    If EntExp.Codigo = EntCodi.InternoExpedienteRefPadreId Then
                        blnSwitch = True
                        Exit For
                    End If
                Next
            End If
            If blnSwitch = True Then
                InhabilitarControles()

            End If
        End Sub

        Private Sub ValidarPadre()
            If Me._ExpedienteID > 0 Then
                Dim objBssPad As Bussines.Registro.InternoExpedientePadre
                objBssPad = New Bussines.Registro.InternoExpedientePadre
                Dim EntExp As New Entity.Registro.InternoExpedientePadre
                EntExp.Codigo = IIf(Me._TipoDocumento = enumTipoDocumentoJudicial.Avocamiento, Me._ExpedienteIDAux, Me._ExpedienteID)
                EntExp.InternoID = Me._InternoID
                Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol

                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                        EntColPad = objBssPad.ListarGrilla_LM(EntExp)
                    Case Else
                        EntColPad = objBssPad.ListarGrilla(EntExp)
                End Select

                Dim blnSwitch As Boolean = False
                For Each EntCodi As Entity.Registro.InternoExpedientePadre In EntColPad
                    If EntExp.Codigo = EntCodi.InternoExpedienteRefPadreId Then
                        blnSwitch = True
                        Exit For
                    End If
                Next
            End If
        End Sub
        Private Sub ListarDetalleDelito(nombre As String)
            If nombre = "" Then Exit Sub

            Dim objBss As New Bussines.Mantenimiento.General.Delito
            Dim objEnt As New Entity.Mantenimiento.General.Delito

            objEnt = objBss.Listar_DelitoEspecifico_v2(Me._objEntDelito.DelitoEspecifico)

            If objEnt Is Nothing Then

            Else
                With objEnt
                    Me.DelitoTitulo = .DelitoTitulo
                    Me.DelitoTipo = .DelitoTipoID
                    Me.DelitoCapituloNro = .DelitoCapituloNro
                    Me.DelitoCapituloNombre = .DelitoCapituloNombre
                    Me.DelitoSeccionNro = .DelitoSeccionNumero
                    Me.DelitoSeccionNombre = .DelitoSeccionNombre
                    Me.DelitoArticulo = .DelitoArticulo
                End With
            End If

        End Sub
        Private Sub ListarAgraviados()

            With Me.dgvAgraviados
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = _objEntAgraviadoCol
                For i As Integer = 0 To .Rows.Count - 1
                    .Item(0, i).Value = i + 1
                Next
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub InhabilitarControles()
            UscComboDelito1.Enabled = False
            txtObservacion.ReadOnly = True
            btnAddAgraviado.Visible = False
            btnDelAgraviado.Visible = False
            btnOk.Enabled = False
        End Sub

        Private Function Validar() As Boolean
            Dim blnValue As Boolean = True

            If Me.DelitoGenericoID < 1 Then
                MessageBox.Show("Ingresar Delito Generico", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Return blnValue
            End If
            If UscComboDelito1._DelitoEspecificoID < 1 Then
                MessageBox.Show("Ingresar Delito Especifico", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Return blnValue
            End If

            If dgvAgraviados.Rows.Count = 0 Then
                MessageBox.Show("Debe ingresar por lo menos un agraviado", _
                     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Return blnValue
            End If
            Return blnValue
        End Function
        Private Sub AGrabar()
            Dim intValue As Integer = -1
            Dim intCon As Integer = 0

            If blnSwitch = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente ha sido referenciado, operacion cancelada")
                Exit Sub
            End If

            If Validar() = False Then Exit Sub
            If _objEntDelito Is Nothing Then _objEntDelito = New Entity.Registro.Delito


            If Me._Codigo < 1 Then
                If Me._TemporalNuevo = True Then
                    _objEntDelito.DelitoItem = 0
                    If _objEntDelitoCol Is Nothing Then
                    Else
                        For Each EntDel As Entity.Registro.Delito In _objEntDelitoCol
                            If Me.DelitoEspecificoID = EntDel.DelitoEspecifico Then
                                intCon = intCon + 1
                                Exit For
                            End If
                        Next
                    End If
                Else
                    If Me.DelitoEspecificoID = _objEntDelito.DelitoEspecifico Then
                    Else
                        If _objEntDelitoCol Is Nothing Then
                        Else
                            For Each EntDel As Entity.Registro.Delito In _objEntDelitoCol
                                If Me.DelitoEspecificoID = EntDel.DelitoEspecifico Then
                                    intCon = intCon + 1
                                    Exit For
                                End If
                            Next
                        End If
                    End If
                End If
            Else
                intValue = Me._Codigo

                If Me.DelitoEspecificoID = _objEntDelito.DelitoEspecifico Then
                Else
                    For Each EntDel As Entity.Registro.Delito In _objEntDelitoCol
                        If Me.DelitoEspecificoID = EntDel.DelitoEspecifico Then
                            intCon = intCon + 1
                            Exit For
                        End If
                    Next
                End If
            End If
            If intCon > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El delito [" & Me.DelitoEspecificoNombre & "] ya fue agregado")
                UscComboDelito1.Focus()
                Exit Sub
            End If
            intValue = 0
            With _objEntDelito
                .Codigo = Me._Codigo
                .InternoID = Me._InternoID
                .IngresoID = Me._IngresoID
                .IngresoInpeId = Me._InternoIngresoInpeId
                .ExpedienteID = Me._ExpedienteID
                .DelitoEspecificoEstado = Me.DelitoEstado
                .DelitoGenerico = Me.DelitoGenericoID
                .DelitoGenericoNombre = Me.txtDelitogenerico.Text
                .DelitoEspecifico = UscComboDelito1._DelitoEspecificoID
                .DelitoEspecificoNombre = UscComboDelito1._DelitoEspecificoNombre
                .Observacion = Me.Observacion
            End With

            If intValue > -1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub

        Private Sub AgrabarAgraviado()
            Me.ResolucionNuevo = True
            Dim intValue As Integer = -1

            objBss = New Bussines.Registro.InternoAgraviado
            If Me.ResolucionNuevo = True Then
                intValue = 0
            Else
                If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    objEnt.FlagTransferenciaSede = Me.FlagTransferSede
                    intValue = objBss.Grabar_LM(objEnt)
                Else
                    intValue = objBss.Grabar(objEnt)
                End If
                objEnt.Codigo = intValue 'para actualizar el Id
            End If

            If intValue > -1 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub
#End Region
#Region "Forms"
        Private Sub FRM_Mant_Agraviado()
            Dim frm As New Registro.Expediente.v5.frmAgraviadoPopup3
            With frm
                ._NuevoGrabar = False
                ._Codigo = dgvAgraviados.SelectedRows(0).Cells("col_agr_id").Value
                Me.posicion = Me.dgvAgraviados.SelectedRows(0).Index
                ._objEntAgraviado.InternoID = Me._InternoID
                ._objEntAgraviado.Codigo = Me.dgvAgraviados.SelectedRows(0).Cells("col_agr_id").Value
                ._objEntAgraviado.AgraviadoNombre = Me.dgvAgraviados.SelectedRows(0).Cells("col_agr_nom").Value
                ._objEntAgraviado.Observacion = Me.dgvAgraviados.SelectedRows(0).Cells("col_agr_obs").Value
                ._objEntAgraviado.ExpedienteID = Me._ExpedienteID
                ._TipoFormulario = Me._TipoFormulario
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                For Each obj As Entity.Registro.Agraviado In Me._objEntAgraviadoCol
                    If Me.dgvAgraviados.SelectedRows(0).Cells("col_agr_nom").Value = obj.AgraviadoNombre Then
                        'nada
                    Else
                        ._objEntAgraviadoCol.Add(obj)
                    End If
                Next
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    dgvAgraviados.Item("col_agr_nom", posicion).Value = ._objEntAgraviado.AgraviadoNombre
                    dgvAgraviados.Item("col_agr_obs", posicion).Value = ._objEntAgraviado.Observacion
                End If
            End With
        End Sub

        Private Sub FRM_Mant_Agraviado_Nuevo()
            Dim frm As New Registro.Expediente.v5.frmAgraviadoPopup3
            Me.ResolucionNuevo = True
            With frm
                'permisos
                ._NuevoGrabar = True
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                ._objEntAgraviadoCol = Me._objEntAgraviadoCol
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    _objEntAgraviado = New Entity.Registro.Agraviado
                    _objEntAgraviadoCol_copi = New Entity.Registro.AgraviadoCol
                    If Me.ResolucionNuevo = True Then
                        With _objEntAgraviado
                            _objEntAgraviado.Codigo = frm._Codigo
                            _objEntAgraviado.AgraviadoNombre = frm._AgraviadoNombre
                            _objEntAgraviado.Observacion = frm._Observacion
                            _objEntAgraviado.ExpedienteItem = Me._ExpedienteItem
                            _objEntAgraviado.DelitoItem = Me._DelitoItem
                            _objEntAgraviado.ExpedienteID = Me._ExpedienteID
                            _objEntAgraviado.DelitoID = Me._Codigo  'codigo principal del delito interno
                        End With
                        If dgvAgraviados.Rows.Count = 0 Then
                            _objEntAgraviadoCol = New Entity.Registro.AgraviadoCol
                            _objEntAgraviadoCol.Add(_objEntAgraviado)
                        Else
                            _objEntAgraviadoCol_copi = _objEntAgraviadoCol
                            _objEntAgraviadoCol_copi.Add(_objEntAgraviado)
                            _objEntAgraviadoCol = New Entity.Registro.AgraviadoCol
                            For Each Ent_Agr As Entity.Registro.Agraviado In _objEntAgraviadoCol_copi
                                _objEntAgraviadoCol.Add(Ent_Agr)
                            Next
                        End If

                        With dgvAgraviados
                            .AutoGenerateColumns = False
                            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                            .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                            .DataSource = ""
                            .DataSource = _objEntAgraviadoCol
                            For i As Integer = 0 To .Rows.Count - 1
                                .Item(0, i).Value = i + 1
                            Next
                        End With
                    Else
                        With _objEntAgraviado
                            With dgvAgraviados
                                .Item("col_agr_nom", posicion).Value = _objEntAgraviado.AgraviadoNombre
                                .Item("col_agr_obs", posicion).Value = _objEntAgraviado.Observacion
                            End With
                        End With
                    End If
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                        Exit Sub
                    Else
                        FRM_Mant_Agraviado_Nuevo()
                    End If

                End If

            End With

        End Sub
        Private Sub FRM_BuscarDelito()

            Dim frm As New Mantenimiento.Busqueda.frmDelitoPopup

            With frm
                ._TipoLicencia = Me._TipoLicencia
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    UscComboDelito1._DelitoGenericoID = frm.GrillaDelitoGenericoID
                    UscComboDelito1._DelitoEspecifico_ID = frm.GrillaDelitoEspecificoID
                    UscComboDelito1.ComboListar()
                End If
            End With

        End Sub
#End Region
#Region "Temporal"
        Private Sub Temporal_EliminarAgraviado()

            For i As Integer = 0 To _objEntAgraviadoCol.Count - 1
                If Me._Codigo > 0 Then
                    If Me.AgraviadoItem = _objEntAgraviadoCol.Item(i).AgraviadoItem Then
                        Dim EntAgr As New Entity.Registro.Agraviado
                        EntAgr.Codigo = _objEntAgraviadoCol.Item(i).Codigo
                        _objEntAgravCol_Ind.Add(EntAgr)
                        _objEntAgraviadoCol.Remove(i)
                        Exit For
                    End If
                Else
                    _objEntAgraviadoCol.Remove(Me.dgvAgraviados.CurrentCell.RowIndex)
                    Exit For
                End If
            Next
            ListarAgraviados()
        End Sub

        Private Sub Temporal_ListarAgraviados(objEntDelito As Entity.Registro.Delito)
            If objEntDelito Is Nothing Then
                'nada
            Else
                _objEntAgraviadoCol_copi = New Entity.Registro.AgraviadoCol


                For Each obj As Entity.Registro.Agraviado In _objEntAgraviadoCol
                    If objEntDelito.ExpedienteID = obj.ExpedienteID Then
                        If obj.ExpedienteID > 0 Then
                            If objEntDelito.DelitoItem = obj.DelitoItem Then
                                _objEntAgraviado = New Entity.Registro.Agraviado
                                Temporal_AgraviadoCopiarPropiedades(_objEntAgraviado, obj)
                                _objEntAgraviadoCol_copi.Add(_objEntAgraviado)
                            End If
                        Else
                            If objEntDelito.DelitoItem = obj.DelitoItem Then
                                _objEntAgraviado = New Entity.Registro.Agraviado
                                Temporal_AgraviadoCopiarPropiedades(_objEntAgraviado, obj)
                                _objEntAgraviadoCol_copi.Add(_objEntAgraviado)
                            End If
                        End If
                    End If
                Next
                With Me.dgvAgraviados
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = Nothing
                    .DataSource = _objEntAgraviadoCol_copi
                    For i As Integer = 0 To .Rows.Count - 1
                        .Item(0, i).Value = i + 1
                    Next
                End With
                _objEntAgraviadoCol = _objEntAgraviadoCol_copi
            End If
        End Sub

        Private Sub Temporal_AgraviadoCopiarPropiedades(objEntOrigen As Entity.Registro.Agraviado, ObjEntDestino As Entity.Registro.Agraviado)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoInpeId = ObjEntDestino.IngresoInpeId
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
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Dim blnSalir As Boolean = False
            Dim blnGrabar As Boolean = False
            Dim blnGrabarAgraviado As Boolean = False

            Select Case Me._TipoFormulario
                Case Type.Formulario.Registro.UserControl.ListadoExpediente
                    InhabilitarControles()
                    blnSalir = True
                Case Type.Formulario.Registro.UserControl.Resoluciones
                    blnGrabar = True
                    blnGrabarAgraviado = True
            End Select
            Me.pnlGrabarDatosAgraviado.Visible = blnGrabarAgraviado
            Me.pnlSalir.Visible = blnSalir
            Me.pnlGrabarDatos.Visible = blnGrabar
            Me.btnOk.Visible = Me._FormEscritura

        End Sub

        Private Sub ValoresxDefault()
            'Me.DelitoGenericoID = _objEntDelito.DelitoGenerico
            Me.DelitoEstado = -1
            UscComboDelito1.Focus()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoDelito)
        End Sub
#End Region

        Private Sub frmDelitoPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
        End Sub


        Private Sub frmDelitoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            Listar()
            'UscComboDelito1.Focus()
            _objEntAgravCol_Ind = New Entity.Registro.AgraviadoCol
            Usuario_Permiso()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoDelito)
            UscComboDelito1.Focus()
        End Sub


        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub txtDelitoEspecifico_TextChanged(sender As System.Object, e As System.EventArgs)
            Switch = 1
        End Sub

        Public Property posicion As Integer = 0

        Private Sub dgvAgraviados_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAgraviados.CellDoubleClick
            If dgvAgraviados.RowCount > 0 Then FRM_Mant_Agraviado()
        End Sub

        Private Sub btnElimina_Click(sender As System.Object, e As System.EventArgs)

            If dgvAgraviados.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar registro para eliminar.")
                Exit Sub
            End If

            If Me.dgvAgraviados.SelectedRows(0).Cells("col_agr_id").Value > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede eliminar Agraviado, pertenece a un expediente/delito registrado en Base de datos.")
                Exit Sub
            End If

            Dim dlgPregunta As DialogResult
            Dim strPregunta As String = "¿Esta Seguro de eliminar el Nombre del Agraviado?"
            Dim strTitulo As String = "INPE - SIP-POPE"
            dlgPregunta = MessageBox.Show(strPregunta, strTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dlgPregunta = DialogResult.Yes Then
                Me.EliminarFila = True
                Temporal_EliminarAgraviado()
            End If

        End Sub

        Private Sub btnDelDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnDelAgraviado.Click

            If dgvAgraviados.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar registro para eliminar.")
                Exit Sub
            End If

            Dim dlgPregunta As DialogResult
            Dim strPregunta As String = "¿Esta Seguro de eliminar al Agraviado?"
            Dim strTitulo As String = "INPE - SIP-POPE"
            dlgPregunta = MessageBox.Show(strPregunta, strTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dlgPregunta = DialogResult.Yes Then
                Temporal_EliminarAgraviado()
            End If

        End Sub

        Private Sub UscComboDelito1__Click_Eliminar() Handles UscComboDelito1._Click_Eliminar
            UscComboDelito1._CondicionElimina = True
        End Sub

        Private Sub UscComboDelito1__Click_Buscar() Handles UscComboDelito1._Click_Buscar
            If UscComboDelito1._DelitoEspecificoID < 1 Then
                Me.DelitoTitulo = ""
                Me.DelitoEstado = -1
                Me.DelitoGenericoID = -1
                Me.txtDelitogenerico.Text = ""
                Me.DelitoEspecificoID = -1
                Me.txtArticulo.Text = ""
                Me.txtCapituloNro.Text = ""
                Me.txtCapituloNombre.Text = ""
                Me.txtSeccionNro.Text = ""
                Me.txtSeccionNom.Text = ""
            Else
                Me.DelitoTitulo = UscComboDelito1._DelitoTitulo
                Me.DelitoGenericoID = UscComboDelito1._DelitoGenericoID
                Me.txtDelitogenerico.Text = UscComboDelito1._DelitoGenericoNombre
                Me.DelitoEspecificoID = UscComboDelito1._DelitoEspecificoID
                Me.txtArticulo.Text = UscComboDelito1._DelitoArticuloNombre
                Me.txtCapituloNro.Text = UscComboDelito1._DelitoCapituloNumero
                Me.txtCapituloNombre.Text = UscComboDelito1._DelitoCapituloNombre
                Me.DelitoEstado = UscComboDelito1._DelitoEstado
                Me.txtSeccionNro.Text = UscComboDelito1._DelitoSeccionNumero
                Me.txtSeccionNom.Text = UscComboDelito1._DelitoSeccionNombre
            End If
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnAddAgraviado_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAgraviado.Click
            FRM_Mant_Agraviado_Nuevo()
        End Sub

        Private Sub UscComboDelito1__Click_ObtenerDelito() Handles UscComboDelito1._Click_ObtenerDelito
            If UscComboDelito1._DelitoEspecificoID < 1 Then
                Me.DelitoTitulo = ""
                Me.DelitoGenericoID = -1
                Me.txtDelitogenerico.Text = ""
                Me.DelitoEspecificoID = -1
                Me.txtArticulo.Text = ""
                Me.txtCapituloNro.Text = ""
                Me.txtCapituloNombre.Text = ""
                Me.txtSeccionNro.Text = ""
                Me.txtSeccionNom.Text = ""
                Me.DelitoEstado = -1
            Else
                Me.DelitoTitulo = UscComboDelito1._DelitoTitulo
                Me.DelitoGenericoID = UscComboDelito1._DelitoGenericoID
                Me.txtDelitogenerico.Text = UscComboDelito1._DelitoGenericoNombre
                Me.DelitoEspecificoID = UscComboDelito1._DelitoEspecificoID
                'Me.DelitoEspecificoNombre = UscComboDelito1._DelitoEspecificoNombre
                Me.txtArticulo.Text = UscComboDelito1._DelitoArticuloNombre
                Me.txtCapituloNro.Text = UscComboDelito1._DelitoCapituloNumero
                Me.txtCapituloNombre.Text = UscComboDelito1._DelitoCapituloNombre
                Me.txtSeccionNro.Text = UscComboDelito1._DelitoSeccionNumero
                Me.txtSeccionNom.Text = UscComboDelito1._DelitoSeccionNombre
                Me.DelitoEstado = UscComboDelito1._DelitoEstado
            End If

        End Sub


        Private Sub UscComboDelito1__MostrarFormulario() Handles UscComboDelito1._MostrarFormulario

            Frm_BuscarDelito()

        End Sub
    End Class
End Namespace
