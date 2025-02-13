Namespace Registro.Siscrico
    Public Class frmBuscaIntegBand
        Private objBssBanda As Bussines.Registro.Banda = Nothing
        Private objEntColBanda As Entity.Registro.BandaCol = Nothing
        Private objBssIntBanda As Bussines.Registro.InternoOrgCriminal = Nothing
        Private objEntColIntBand As Entity.Registro.InternoOrgCriminalCol = Nothing

#Region "Propiedades"
        Private Property _PenalID() As Integer
            Get
                Return cbbPenal.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenal.SelectedValue = value
            End Set
        End Property
        Private Property _RegionID() As Integer
            Get
                Return cbbRegion.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property _BandaTipoID() As Integer
            Get
                Return Me.cbbBandaTipo.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbBandaTipo.SelectedValue = value
            End Set
        End Property
        Private Property _BandaNombre() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                txtNom.Text = value
            End Set
        End Property
        Dim intIdBandaSel As Integer 'mantiene el valor id de la banda al presionar sobre el boton ver integrantes
        Private Property _BandaIdSelect() As Integer
            Get
                Return intIdBandaSel
            End Get
            Set(value As Integer)
                intIdBandaSel = value
            End Set
        End Property
        Dim strBandaNombreSel As String 'mantiene nombre banda al presionar sobre el boton ver integrantes
        Private Property _BandaNombreSelect() As String
            Get
                Return strBandaNombreSel
            End Get
            Set(value As String)
                strBandaNombreSel = value
            End Set
        End Property
        Dim strBandaTipoNombreSelect As String 'mantiene tipo de banda al presionar sobre el boton ver integrantes
        Private Property _BandaTipoNombreSelect() As String
            Get
                Return strBandaTipoNombreSelect
            End Get
            Set(value As String)
                strBandaTipoNombreSelect = value
            End Set
        End Property
        Dim intBandaTipoIdSel As Integer
        Private Property _BandaTipoIdSel() As Integer
            Get
                Return intBandaTipoIdSel
            End Get
            Set(value As Integer)
                intBandaTipoIdSel = value
            End Set
        End Property
#End Region
#Region "PropiedadesGrilla"

        Private ReadOnly Property _GrillaInternoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIntegrantesBanda
                        intValue = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property _GrillaIngresoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIntegrantesBanda
                        intValue = .SelectedRows(0).Cells("col_ing_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        '
        Private ReadOnly Property _GrillaRegionId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIntegrantesBanda
                        intValue = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property _GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIntegrantesBanda
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property _GrillaIntBandaId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIntegrantesBanda
                        intValue = .SelectedRows(0).Cells("int_ban_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property _GrillaIntBandaEstado() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwIntegrantesBanda
                        strValue = .SelectedRows(0).Cells("col_estado").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property _GrillaIntBanda_TipoOrgCrimNom() As String
            Get
                Dim strValue As String = ""
                Try
                    strValue = dgwIntegrantesBanda.SelectedRows(0).Cells("col_org_crim_tip_nom").Value
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property _GrillaIntBanda_CrimOrgNom() As String
            Get
                Dim strValue As String = ""
                Try
                    strValue = dgwIntegrantesBanda.SelectedRows(0).Cells("col_ban_nom").Value
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property _GrillaIntBanda_CrimOrgId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = dgwIntegrantesBanda.SelectedRows(0).Cells("col_band_id").Value
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

#End Region
#Region "Combo"
        Private Sub CargarComboTipoBanda()
            With Me.cbbBandaTipo
                ._Todos = True
                .ComboTipo = Type.Combo.ComboTipo.BandaTipo
                .LoadUsc()                
            End With
            Me._BandaTipoID = 2 'organizaciones criminales
        End Sub
        Private Sub CargarComboRegion()
            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select

            With Me.cbbRegion
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.RegionUsuario
                .Parametro1 = Legolas.Configuration.Usuario.Codigo
                .Parametro2 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With
        End Sub
        Private Sub CargarComboPenal()
            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select

            With Me.cbbPenal
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.PenalUsuario
                .CodigoPadre = Me._RegionID
                .Parametro1 = Legolas.Configuration.Usuario.Codigo
                .Parametro2 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With
        End Sub
        Private Sub CargarComboTipoIntegranteBanda()
            With Me.cbbTipoIntegranteBan
                .ComboTipo = Type.Combo.ComboTipo.BandaMiembroTipo
                .Parametro1 = Legolas.Configuration.Usuario.Codigo
                .Parametro2 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()
            objBssBanda = New Bussines.Registro.Banda
            objEntColBanda = New Entity.Registro.BandaCol
            Dim entBand As New Entity.Registro.Banda
            entBand.BandaTipoID = Me._BandaTipoID
            entBand.BandaNombre = Me._BandaNombre
            objEntColBanda = objBssBanda.Listar(entBand)
            With Me.dgwGrillaBandas
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntColBanda

                lblReg.Text = " Reg. " & .RowCount.ToString
            End With
        End Sub
        Private Sub ListarIntegrantesBanda(BandaID As Integer, idEstadoIntBand As Integer, BandaMiembroTipoID As Integer, CodInterno As String, apePatInt As String, apeMatInt As String, nomInt As String, regId As Integer, penId As Integer)
            Try
                If regId = -1 Then
                    dgwIntegrantesBanda.Columns("col_reg_nom").Visible = True
                Else
                    dgwIntegrantesBanda.Columns("col_reg_nom").Visible = False
                End If
                If penId = -1 Then
                    dgwIntegrantesBanda.Columns("col_pen_nom").Visible = True
                Else
                    dgwIntegrantesBanda.Columns("col_pen_nom").Visible = False
                End If
            Catch ex As Exception

            End Try

            Dim objIntBand As New Entity.Registro.InternoOrgCriminal

            objIntBand.BandaID = BandaID
            objIntBand.Estado = idEstadoIntBand
            objIntBand.BandaMiembroTipoID = BandaMiembroTipoID
            'CodInterno As String,apePatInt As String, apeMatInt As String ,nomInt As Integer 
            objIntBand.CodigoInterno = Trim(CodInterno)
            objIntBand.ApePatInterno = Trim(apePatInt)
            objIntBand.ApeMatInterno = Trim(apeMatInt)
            objIntBand.NombresInterno = Trim(nomInt)
            objIntBand.PenalID = penId
            objIntBand.RegioID = regId
            objBssIntBanda = New Bussines.Registro.InternoOrgCriminal
            objEntColIntBand = New Entity.Registro.InternoOrgCriminalCol()

            objEntColIntBand = objBssIntBanda.ListarIntegrantesBanda2(objIntBand)
            With Me.dgwIntegrantesBanda
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntColIntBand
                If BandaID <> -1 Then 'significa que la busqueda es general por datos del interno
                    lblNomBanda.Text = dgwGrillaBandas.Item("colNombre", dgwGrillaBandas.CurrentCell.RowIndex).Value & " (" & .RowCount.ToString & " - INTEGRANTES)"
                End If
                Me._BandaIdSelect = BandaID
                'lblCantRegIntband.Text = " Reg. " & .RowCount.ToString
            End With
        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminarIntBanda()
            If dgwIntegrantesBanda.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Seleccione el registro que desea eliminar")
                Exit Sub
            End If
            If MsgBox("Está seguro de eliminar el registro seleccionado?, una vez eliminada el registro no podrá recuperarla.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim objBss As New Bussines.Registro.InternoBanda
                Dim intValue As Integer = -1

                objBss.Eliminar(Me._GrillaIntBandaId)
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Dim intIdEstadoBand As Integer = -1
                If rdbTodos.Checked = True Then intIdEstadoBand = -1
                If rdbVigente.Checked = True Then intIdEstadoBand = 1
                If rdbBaja.Checked = True Then intIdEstadoBand = 0

                If rbFiltXOrgCrim.Checked = True Then 'si la lista se muestra poor org crim
                    ListarIntegrantesBanda(Me._BandaIdSelect, intIdEstadoBand, cbbTipoIntegranteBan.SelectedValue, _
                                      "", "", "", "", Me._RegionID, Me._PenalID) 'listar por IdOrgCrim
                Else
                    ListarIntegrantesBanda(-1, -1, -1, _
                                      txtCodInterno.Text, txtApePat.Text, txtApeMat.Text, txtNomInt.Text, Me._RegionID, Me._PenalID)
                End If
                Legolas.Configuration.Aplication.MessageBox.Information( _
                       "Operación completada satisfactoriamente")
            End If
        End Sub
        Public Sub ABajaIntBanda()
            If dgwIntegrantesBanda.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Seleccione el registro para cambiar el estado")
                Exit Sub
            End If
            If UCase(Me._GrillaIntBandaEstado) = "ANULADO" Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
          "No es posible completar la operación, registro ya se encuentra ANULADO")
                Exit Sub
            End If
            If MsgBox("Está seguro de cambiar el estado del registro seleccionado a ANULADO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim objBss As New Bussines.Registro.InternoBanda
                Dim value As Integer = -1
                'Dim intInterno As Integer = -1
                'Dim intEstado As Integer = -1
                objBss = New Bussines.Registro.InternoBanda


                Dim intIdDocJudAnula As Integer
                intIdDocJudAnula = CreaDocJudNulidad()
                If intIdDocJudAnula = -1 Then
                    Exit Sub
                End If
                value = objBss.GrabarEstado(Me._GrillaIntBandaId, 0, intIdDocJudAnula)

                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Dim intIdEstadoBand As Integer = -1
                If rdbTodos.Checked = True Then intIdEstadoBand = -1
                If rdbVigente.Checked = True Then intIdEstadoBand = 1
                If rdbBaja.Checked = True Then intIdEstadoBand = 0
                If rbFiltXOrgCrim.Checked = True Then 'si la lista se muestra poor org crim
                    ListarIntegrantesBanda(Me._BandaIdSelect, intIdEstadoBand, cbbTipoIntegranteBan.SelectedValue, _
                                      "", "", "", "", Me._RegionID, Me._PenalID)
                Else
                    ListarIntegrantesBanda(-1, -1, -1, _
                                      txtCodInterno.Text, txtApePat.Text, txtApeMat.Text, txtNomInt.Text, Me._RegionID, Me._PenalID)
                End If
            End If
        End Sub
        Private Sub AMantenimiento(Nuevo As Boolean)
            '
            Dim frm As New frmInternoBandaPopup2
            Dim p As New Entity.Registro.Banda
            With frm

                ._FormEscritura = Me._FormEscritura
                ._FormLectura = Me._FormLectura

                If Nuevo = True Then

                    If dgwGrillaBandas.Rows.Count < 1 And rbFiltXOrgCrim.Checked = True Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                        "En la lista superior busque el registro de organización ciminal")
                        Exit Sub
                    End If
                    If Trim(lblNomBanda.Text) = "" And rbFiltXOrgCrim.Checked = True Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                        "En la lista superior ubique el registro de organización ciminal")
                        Exit Sub
                    End If
                    If rbFiltXOrgCrim.Checked = True Then
                        p = (New Bussines.Registro.Banda).Listar(Me._BandaIdSelect)
                        ._BandaId = p.Codigo
                        ._BandaNombre = Me._BandaNombreSelect
                        ._BandaTipoId = p.BandaTipoID
                        ._BandaTipoNombre = Me._BandaTipoNombreSelect
                    Else
                        ._BandaId = -1
                        ._BandaNombre = ""
                        ._BandaTipoId = -1
                        ._BandaTipoNombre = ""
                    End If
                    ._InternoBandId = -1
                    ._EstadoIntegrante = "ACTIVO"

                Else
                    If dgwIntegrantesBanda.Rows.Count < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                        "Seleccione el registro de interno para su edición")
                        Exit Sub
                    End If
                    If Me._GrillaIntBandaEstado = "ANULADO" Then
                        Legolas.Configuration.Aplication.MessageBox.Information( _
                       "Tenga en cuenta que el registro se encuentra anulado")
                    End If
                    If rbFiltXOrgCrim.Checked = True Then
                        p = (New Bussines.Registro.Banda).Listar(Me._BandaIdSelect)
                        ._BandaId = p.Codigo
                        ._BandaNombre = Me._BandaNombreSelect
                        ._BandaTipoId = p.BandaTipoID
                        ._BandaTipoNombre = Me._BandaTipoNombreSelect
                    Else
                        p = (New Bussines.Registro.Banda).Listar(Val(Me._GrillaIntBanda_CrimOrgId))
                        ._BandaId = p.Codigo
                        ._BandaNombre = Me._GrillaIntBanda_CrimOrgNom
                        ._BandaTipoId = p.BandaTipoID
                        ._BandaTipoNombre = Me._GrillaIntBanda_TipoOrgCrimNom
                    End If

                    ._EstadoIntegrante = dgwIntegrantesBanda.Item("col_estado", dgwIntegrantesBanda.CurrentCell.RowIndex).Value
                    ._InternoBandId = dgwIntegrantesBanda.Item("int_ban_id", dgwIntegrantesBanda.CurrentCell.RowIndex).Value
                End If
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim intIdEstadoBand As Integer = -1
                    If rdbTodos.Checked = True Then intIdEstadoBand = -1
                    If rdbVigente.Checked = True Then intIdEstadoBand = 1
                    If rdbBaja.Checked = True Then intIdEstadoBand = 0
                    'Legolas.Configuration.Aplication.MessageBox.Information( _
                    '   "La operación se completó satisfactoriamente")
                    If rbFiltXOrgCrim.Checked = True Then 'si la lista se muestra poor org crim
                        ListarIntegrantesBanda(Me._BandaIdSelect, intIdEstadoBand, cbbTipoIntegranteBan.SelectedValue, _
                                          "", "", "", "", Me._RegionID, Me._PenalID)
                    Else
                        ListarIntegrantesBanda(-1, -1, -1, _
                                          txtCodInterno.Text, txtApePat.Text, txtApeMat.Text, txtNomInt.Text, Me._RegionID, Me._PenalID)
                    End If
                End If
            End With
        End Sub
        Private Sub ExportIntegrantes()
            If dgwIntegrantesBanda.Rows.Count < 1 Then Exit Sub
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwIntegrantesBanda)
        End Sub
        Private Sub FiltrarIntegrantes()
            Dim intIdEstadoBand As Integer = -1
            If Me._BandaIdSelect = -1 And rbFiltXOrgCrim.Checked = True Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione un registro de organizacion criminal")
                Exit Sub
            End If
            If rbFiltXOrgCrim.Checked = True Then
                If rdbTodos.Checked = True Then intIdEstadoBand = -1
                If rdbVigente.Checked = True Then intIdEstadoBand = 1
                If rdbBaja.Checked = True Then intIdEstadoBand = 0

                ListarIntegrantesBanda(Me._BandaIdSelect, intIdEstadoBand, cbbTipoIntegranteBan.SelectedValue, _
                                      "", "", "", "", Me._RegionID, Me._PenalID)
            Else
                Me._BandaIdSelect = -1
                intIdEstadoBand = -1
                ListarIntegrantesBanda(-1, -1, -1, _
                                       txtCodInterno.Text, txtApePat.Text, txtApeMat.Text, txtNomInt.Text, Me._RegionID, Me._PenalID)
            End If
        End Sub
#End Region
#Region "Otros"

        Private Sub VerInfoInterno()

            Me.Cursor = Cursors.WaitCursor

            If dgwIntegrantesBanda.CurrentCell.RowIndex <> -1 Then
                Dim frm As New Registro.Penal.Busqueda.frmMant
                frm.MdiParent = Me.MdiParent
                With frm

                    If Me._GrillaInternoId < 1 Then
                        Exit Sub
                    End If
                    .InternoID = Me._GrillaInternoId

                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                    .Show()
                End With
            End If

            Me.Cursor = Cursors.Default
        End Sub
        Private Sub ValoresxDefault()
            Me._BandaIdSelect = -1
            CargarComboTipoBanda()
            CargarComboRegion()
            CargarComboPenal()
            CargarComboTipoIntegranteBanda()


        End Sub
        Private Function CreaDocJudNulidad() As Integer
            Dim frm As New Registro.Documento.frmDocJudicial
            With frm
                ._DocumentoJudicialID = -1
                ._RegionID = Me._GrillaRegionId
                ._PenalID = Me._GrillaPenalId
                ._FormEscritura = Me._FormEscritura
                ._FormLectura = Me._FormLectura
                ._InternoID = Me._GrillaInternoId
                ._IngresoID = Me._GrillaIngresoId
                ._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
                If .ShowDialog() = DialogResult.OK Then
                    Return ._DocumentoJudicialID
                Else
                    Legolas.Configuration.Aplication.MessageBox.Information("Operación cancelada")
                    Return -1
                End If
            End With
        End Function
        Private Sub FiltrarIntBanda()
            Dim intIdEstadoBand As Integer = -1
            If Me._BandaIdSelect = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Information( _
                        "Seleccione un registro de banda")
                Exit Sub
            End If
            If rdbTodos.Checked = True Then intIdEstadoBand = -1
            If rdbVigente.Checked = True Then intIdEstadoBand = 1
            If rdbBaja.Checked = True Then intIdEstadoBand = 0
            ListarIntegrantesBanda(Me._BandaIdSelect, intIdEstadoBand, cbbTipoIntegranteBan.SelectedValue, _
                                       txtCodInterno.Text, txtApePat.Text, txtApeMat.Text, txtNomInt.Text, Me._RegionID, Me._PenalID)
        End Sub
        Private Sub UsuarioPermisos()
            'Me.pnlEditar.Visible = Me._FormEscritura
            Me.pnlReporte.Visible = Me._FormReporte
            'Me.pnlEliminar.Visible = Me._FormEliminar
            'Me.pnlAnular.Visible = Me._FormEscritura
        End Sub
#End Region
#Region "Eventos_Otros"

        Private Sub frmBuscaIntegBand_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
            UsuarioPermisos()
        End Sub

        Private Sub frmBuscaIntegrantesBanda_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            Me.WindowState = FormWindowState.Maximized
            cbbBandaTipo.Enabled = False

        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            lblNomBanda.Text = ""
            Me._BandaIdSelect = -1
            Me._BandaNombreSelect = ""
            Me._BandaTipoNombreSelect = ""
            dgwIntegrantesBanda.DataSource = Nothing
            Listar()
        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaBandas.CellClick
            If dgwGrillaBandas.Rows.Count = 0 Then Exit Sub
            Me._BandaIdSelect = Val(Me.dgwGrillaBandas.Item("col_id", dgwGrillaBandas.CurrentCell.RowIndex).Value)
            Me._BandaNombreSelect = Me.dgwGrillaBandas.Item("colNombre", dgwGrillaBandas.CurrentCell.RowIndex).Value
            Me._BandaTipoNombreSelect = Me.dgwGrillaBandas.Item("colTipo", dgwGrillaBandas.CurrentCell.RowIndex).Value
            ListarIntegrantesBanda(Me._BandaIdSelect, -1, -1, "", "", "", "", Me._RegionID, Me._PenalID)
            cbbTipoIntegranteBan.SelectedIndex = 0
            rdbTodos.Checked = True
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            AMantenimiento(True)
        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
            AMantenimiento(False)
        End Sub

        Private Sub dgwIntegrantesBanda_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIntegrantesBanda.CellDoubleClick
            If Me.dgwIntegrantesBanda.RowCount > 0 Then
                VerInfoInterno() 'AMantenimiento(False)
            End If
        End Sub

        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
            ABajaIntBanda()
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            AEliminarIntBanda()
        End Sub

        Private Sub dgwIntegrantesBanda_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIntegrantesBanda.CellMouseEnter
            If dgwIntegrantesBanda.Columns(e.ColumnIndex).Name = "verDoc" And e.RowIndex >= 0 Then
                dgwIntegrantesBanda.Cursor = Cursors.Hand
            End If
        End Sub

        Private Sub dgwIntegrantesBanda_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIntegrantesBanda.CellMouseLeave
            If dgwIntegrantesBanda.Columns(e.ColumnIndex).Name = "verDoc" And e.RowIndex >= 0 Then
                dgwIntegrantesBanda.Cursor = Cursors.Default
            End If
        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click
            ExportIntegrantes()
        End Sub

        Private Sub txtNom_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNom.KeyDown
            If e.KeyCode = Keys.Enter Then
                tsbBuscar_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub cmdFiltrar_Click(sender As System.Object, e As System.EventArgs)
            Call FiltrarIntegrantes()
        End Sub

        Private Sub dgwIntegrantesBanda_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwIntegrantesBanda.KeyDown
            If e.KeyCode = Keys.Delete And Me._FormEliminar Then
                btnEliminar_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click
            Dim f As New Registro.Reporte.frmReporteSiscrico
            With f
                ._FormImpresion = Me._FormImpresion
                .ShowDialog()
            End With

        End Sub

        Private Sub dgwGrilla_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGrillaBandas.KeyDown
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                dgwGrilla_CellClick(Nothing, Nothing)
            End If
        End Sub

        Private Sub txtCodInterno_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodInterno.KeyDown
            If e.KeyCode = Keys.Enter Then
                cmdFiltrar_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub txtApePat_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtApePat.KeyDown
            If e.KeyCode = Keys.Enter Then
                cmdFiltrar_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub txtApeMat_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtApeMat.KeyDown
            If e.KeyCode = Keys.Enter Then
                cmdFiltrar_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub txtNomInt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNomInt.KeyDown
            If e.KeyCode = Keys.Enter Then
                cmdFiltrar_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub rbFiltXOrgCrim_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFiltXOrgCrim.CheckedChanged
            If rbFiltXOrgCrim.Checked = True Then
                txtCodInterno.Text = ""
                txtApePat.Text = ""
                txtApeMat.Text = ""
                Panel6.Visible = True
                pnlBusXBand.Visible = True
                dgwGrillaBandas.Visible = True
                lblNomBanda.Visible = True
                Try
                    dgwIntegrantesBanda.Columns("col_reg_nom").Visible = False
                    dgwIntegrantesBanda.Columns("col_pen_nom").Visible = False
                    dgwIntegrantesBanda.Columns("col_org_crim_tip_nom").Visible = False
                    dgwIntegrantesBanda.Columns("col_ban_nom").Visible = False
                Catch ex As Exception
                End Try

                dgwGrillaBandas.DataSource = Nothing
                dgwIntegrantesBanda.DataSource = Nothing
                Try
                    cbbPenal.SelectedIndex = 0
                    cbbRegion.SelectedIndex = 0
                Catch ex As Exception
                End Try

            End If
        End Sub

        Private Sub rbFiltXInterno_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFiltXInterno.CheckedChanged
            If rbFiltXInterno.Checked = True Then
                txtCodInterno.Text = ""
                txtApePat.Text = ""
                txtApeMat.Text = ""

                Panel6.Visible = False
                pnlBusXBand.Visible = False
                dgwGrillaBandas.Visible = False
                lblNomBanda.Visible = False
                Try
                    dgwIntegrantesBanda.Columns("col_reg_nom").Visible = True
                    dgwIntegrantesBanda.Columns("col_pen_nom").Visible = True

                    dgwIntegrantesBanda.Columns("col_org_crim_tip_nom").Visible = True
                    dgwIntegrantesBanda.Columns("col_ban_nom").Visible = True
                Catch ex As Exception
                End Try

                dgwGrillaBandas.DataSource = Nothing
                dgwIntegrantesBanda.DataSource = Nothing

                Try
                    cbbPenal.SelectedIndex = 0
                    cbbRegion.SelectedIndex = 0
                Catch ex As Exception
                End Try

                Me._BandaIdSelect = -1
                Me._BandaNombreSelect = ""
                Me._BandaTipoNombreSelect = ""
            End If
        End Sub

#End Region

        Private Sub cbbBandaTipo__SelectedIndexChanged() Handles cbbBandaTipo._SelectedIndexChanged
            tsbBuscar_Click(Nothing, Nothing)
        End Sub

        Private Sub cbbPenal__SelectedIndexChanged() Handles cbbPenal._SelectedIndexChanged
            If dgwGrillaBandas.Rows.Count < 1 Then Exit Sub
            ListarIntegrantesBanda(Me._BandaIdSelect, -1, -1, "", "", "", "", Me._RegionID, Me._PenalID)
            cbbTipoIntegranteBan.SelectedIndex = 0
        End Sub

        Private Sub cbbuscRegion__ValueChanged() Handles cbbRegion._SelectedIndexChanged
            CargarComboPenal()
            If dgwGrillaBandas.Rows.Count < 1 Then Exit Sub
            ListarIntegrantesBanda(Me._BandaIdSelect, -1, -1, "", "", "", "", Me._RegionID, Me._PenalID)
            cbbTipoIntegranteBan.SelectedIndex = 0
        End Sub

        Private Sub cbbTipoIntegranteBan__SelectedIndexChanged() Handles cbbTipoIntegranteBan._SelectedIndexChanged
            Try
                Call FiltrarIntegrantes()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub rdbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbTodos.CheckedChanged
            Try
                If rdbTodos.Checked = True Then
                    Call FiltrarIntegrantes()
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub rdbVigente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbVigente.CheckedChanged
            Try
                If rdbVigente.Checked = True Then
                    Call FiltrarIntegrantes()
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub rdbBaja_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbBaja.CheckedChanged
            Try
                If rdbBaja.Checked = True Then
                    Call FiltrarIntegrantes()
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub dgwGrillaBandas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaBandas.CellContentClick

        End Sub

        Private Sub dgwIntegrantesBanda_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIntegrantesBanda.CellContentClick

        End Sub
    End Class
End Namespace