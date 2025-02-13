Imports System.ComponentModel
Imports Type
Namespace Tratamiento.TallerAsistencia
    Public Class frmBuscar
        Dim ws As APPWebService.ws_pope_ep_trat_asist_tall.ApiBiostarClient
        Private bssIntTaller As New Bussines.Tratamiento.TallerAsistencia.InternoTaller
#Region "Propiedades Parametricas"
        Private objEntCol As Entity.Tratamiento.TallerAsistencia.InternoTallerCol
#End Region

#Region "Busqueda Internos"
        Private Property IDRegion() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property IDPenal() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private Property CodigoInterno() As String
            Get
                Return Me.txtCodInterno.Text()
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property PrimerPaterno() As String
            Get
                Return Me.txtApePat.Text()
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtApeMat.Text
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property PreNombres() As String
            Get
                Return Me.txtNom.Text
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property IDSexo() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbHom.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbMuj.Checked = True Then
                    intValue = 2
                End If

                If Me.rdbSexoTodos.Checked = True Then
                    intValue = -1
                End If

                Return intValue
            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbHom.Checked = True
                    Case 2
                        rdbMuj.Checked = True
                    Case Else
                        rdbSexoTodos.Checked = True
                End Select

            End Set

        End Property
        Private Property IDTipoDocumento() As Integer
            Get
                Dim value As Integer = -1
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property IDNacionalidadPais() As Integer
            Get
                Dim value As Integer = -1
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property BuscaNumeroDocumento() As String
            Get
                Return Me.txtBuscaNumeroDocumento.Text
            End Get
            Set(ByVal value As String)
                Me.txtBuscaNumeroDocumento.Text = value
            End Set
        End Property
        Private Property IDEstadoLaboral() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbActivo.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbInactivo.Checked = True Then
                    intValue = 0
                End If

                If Me.rdbEstadoTodos.Checked = True Then
                    intValue = -1
                End If

                Return intValue
            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbActivo.Checked = True
                    Case 0
                        rdbInactivo.Checked = True
                    Case Else
                        rdbEstadoTodos.Checked = True
                End Select

            End Set

        End Property
        Private Property IDEstado() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rbtEstadoActivo.Checked = True Then
                    intValue = 1
                End If

                If Me.rbtEstadoInactivo.Checked = True Then
                    intValue = 0
                End If

                If Me.rbtTodos.Checked = True Then
                    intValue = -1
                End If

                Return intValue
            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rbtEstadoActivo.Checked = True
                    Case 0
                        Me.rbtEstadoInactivo.Checked = True
                    Case Else
                        Me.rbtTodos.Checked = True
                End Select

            End Set

        End Property

        Private Property IDActividad() As Integer
            Get
                Dim value As Integer = -1
                Return -1
            End Get
            Set(ByVal value As Integer)
                'Me.cbbActividades.SelectedValue = value
            End Set
        End Property
        Private Property IDTaller() As Integer
            Get
                Dim value As Integer = -1
                Return Me.cbbTalleres.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTalleres.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_codigo").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaCodigoRP() As String
            Get
                Dim intValue As String = ""
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_cod_rp").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDInterno() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pri_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaApeyNom() As String
            Get
                Dim value As String = ""
                Try
                    With dgwGrilla
                        value = .SelectedRows(0).Cells("col_int_ape").Value & ", " & .SelectedRows(0).Cells("col_int_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaIDRegion() As Short
            Get
                Dim value As Integer = -1
                Try
                    With dgwGrilla
                        value = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaIDPenal() As Short
            Get
                Dim intValue As Integer = -1
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFechaInscripcion() As Long
            Get
                Dim intValue As Long = -1
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pri_fec_asi").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

#End Region

#Region "Combo"
        Private blnCombo As Boolean = False
        Private Sub ComboRegion()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
            End If

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Configuracion.Licencia.Codigo
                ._Todos = blnTodos
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboPenal()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
            End If

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.IDRegion
                .Parametro1 = Configuracion.Licencia.Codigo
                ._Todos = blnTodos
                .LoadUsc()
            End With

            If Me.IDRegion < 1 Then
                Me.cbbPenal.Enabled = False
                ComboTalleres()
            Else
                Me.cbbPenal.Enabled = True
            End If

        End Sub

        Private Sub Combo()

            With Me.cbbNacionalidad
                ._Todos = True
                .LoadUsc()
            End With

            With Me.cbbTipoDoc
                ._Todos = True
                .LoadUsc()
            End With

            blnCombo = False
            ComboActividades()
            ComboTalleres()
        End Sub

        Private Sub ComboActividades()
            'With Me.cbbActividades
            '    ._Todos = True
            '    ._LoadUsc(Type.Combo.Tratamiento.Trabajo.TallerAsistencia.TallerActividad, True)
            'End With
            blnCombo = False
        End Sub

        Private Sub ComboTalleres()
            With Me.cbbTalleres
                ._Todos = True
                .CodigoPadre = Me.IDPenal
                ._LoadUsc(Type.Combo.Tratamiento.Trabajo.TallerAsistencia.Talleres, True)
            End With
            blnCombo = False
        End Sub

#End Region
#Region "Validar"

        Private Function ValidarBusqueda() As Boolean
            Dim value As Boolean = False
            'validar que el tener la opcion todos ingrese un dato

            value = True

            Return value
        End Function

#End Region

#Region "Listar"
        Private Sub Buscar()

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim objBss As New Bussines.Tratamiento.TallerAsistencia.InternoTaller
            Dim objEntFiltro As New Entity.Tratamiento.TallerAsistencia.InternoTaller

            With objEntFiltro
                '/*interno*/
                .CodigoRP = Me.CodigoInterno
                .ApellidoPaterno = Me.PrimerPaterno
                .ApellidoMaterno = Me.SegundoApellido
                .Nombres = Me.PreNombres
                .SexoID = Me.IDSexo
                .TipoDocumentoID = Me.IDTipoDocumento
                .NumeroDocumento = Me.BuscaNumeroDocumento
                .NacionalidadID = Me.IDNacionalidadPais
                .EstadoLaboralID = Me.IDEstadoLaboral
                .EstadoID = Me.IDEstado
                .RegionID = Me.IDRegion
                .PenalID = Me.IDPenal
                .CodigoTaller = Me.IDTaller
                '.CodigoTipoActividad = Me.TipoActividad
                .CodigoActividad = Me.IDActividad
            End With
            objEntCol = objBss.ListarCol_v2(objEntFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                lblRegPrin.Text = objEntCol.Count & " Reg."
            End With

        End Sub
        Private Sub ShowFotografia()

            If Me.UscFotografia_2v2._CheckImagen = False Or Me.GrillaIDInterno < 1 Then
                Me.UscFotografia_2v2._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v2._showFotoInternoPrincipal(Me.GrillaIDInterno, APPControls.Foto.uscFotografia_2v.enmFotoPerfil.Frontal)

            If UscFotografia_2v2._HasImagen = False Then
                Me.UscFotografia_2v2._Limpiar()
            End If

        End Sub
#End Region


#Region "Formularios"
        Private Sub FRM_Mantenimiento(blnNuevo As Boolean)

            Dim intIDInterno As Integer = -1
            Dim intIDPenal As Short = -1

            If blnNuevo = True Then
                intIDInterno = -1
                intIDPenal = Me.IDPenal
            Else
                If Me.GrillaIDInterno < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Interno")
                    Exit Sub
                End If
                intIDInterno = Me.GrillaIDInterno
                intIDPenal = Me.GrillaIDPenal
            End If

            Dim frm As New Tratamiento.TallerAsistencia.frmMant
            frm.MdiParent = Me.MdiParent

            With frm
                ._IDInterno = intIDInterno
                'permisos
                ._FormLectura = Me._FormLectura
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormImpresion = Me._FormImpresion
                ._FormEliminar = Me._FormEliminar
                .Show()
            End With
        End Sub
        Private Sub frm_Reporte()

            If Me.GrillaIDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione Interno")
                Exit Sub
            End If

            Dim frm As New Tratamiento.TallerAsistencia.Reporte.frmReportePopup
            With frm
                ._FechaIncripcion = Me.GrillaFechaInscripcion
                ._LoadParametros(Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_internoasistencia,
                    Me.GrillaIDInterno, Me.GrillaApeyNom)
                .ShowDialog()
            End With

        End Sub
        Private Sub frm_InscripcionTaller()

            If Me.IDPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Penal")
                Me.cbbPenal.Focus()
                Exit Sub
            End If

            Dim frm As New Tratamiento.TallerAsistencia.frmInscripcionTaller
            With frm
                ._RegionID = Me.IDRegion
                ._PenalID = Me.IDPenal
                .ShowDialog()
            End With

        End Sub

#End Region
#Region "Otros"
        Private Sub ALimpiar()
            Me.CodigoInterno = ""
            Me.PrimerPaterno = ""
            Me.SegundoApellido = ""
            Me.PreNombres = ""
            Me.BuscaNumeroDocumento = ""
            Me.IDTipoDocumento = -1
            Me.IDNacionalidadPais = -1
            Me.IDSexo = -1 'todos
            Me.IDEstado = -1
            'Me.TipoActividad = -1
            Me.IDActividad = -1
            Me.IDTaller = -1
            Me.txtApePat.Focus()
        End Sub
        Private Sub ValoresDefault()

            ComboRegion()
            ComboPenal()
            Combo()
            dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            UscFotografia_2v2._CheckImagen = True
            UscFotografia_2v2._PanelCheck = False

        End Sub

        Private Sub UsuarioPermisos()

            Me.btnNuevo.Visible = Me._FormEscritura
            Me.pnlReporte.Visible = Me._FormReporte

        End Sub

#End Region

        Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click
            frm_Reporte()
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub frmTallerAsistencia_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresDefault()
        End Sub

        Private Sub frmTallerAsistencia_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Me.WindowState = FormWindowState.Maximized
            UsuarioPermisos()
        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea exportar el archivo a excel") = Windows.Forms.DialogResult.Yes Then
                Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
            End If

        End Sub

        Private Sub tsbBuscarInterno_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscarInterno.Click
            Buscar()
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            Me.Cursor = Cursors.WaitCursor

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_Mantenimiento(False)
            End If

            Me.Cursor = Cursors.Default
        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter
            ShowFotografia()

            If dgwGrilla.CurrentRow.Index < 0 Then Exit Sub

            If dgwGrilla.Item("col_reg_vinc_bio", e.RowIndex).Value = True And
                dgwGrilla.Item("col_est_nom", e.RowIndex).Value = "INACTIVO" Then
                btnViculaBiometrico.Text = "Quitar vínculo biométrico"
            Else
                btnViculaBiometrico.Text = "Vincular con biométrico"
            End If
        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_int_fec_nac").Index, .Columns("col_pri_fec_asi").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
            Dim c As Color
            If dgwGrilla.Item("col_reg_vinc_bio", e.RowIndex).Value = False Then
                c = Color.FromArgb(242, 242, 242)
            Else
                c = Color.FromArgb(2, 229, 25)
            End If
            If dgwGrilla.Columns(e.ColumnIndex).Name = "col_reg_vinc_bio" Then
                e.CellStyle.BackColor = c
                e.CellStyle.SelectionBackColor = c
            End If
        End Sub

        Private Sub tsbLimpiarGrilla_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiarGrilla.Click
            ALimpiar()
        End Sub

        Private Sub cbbActividades_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
            ComboTalleres()
        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            frm_InscripcionTaller()
        End Sub

        'Private Sub rbtTipoTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _

        '    rbtActSoporte.CheckedChanged,
        '    rbtServAd.CheckedChanged

        '    ComboActividades()
        '    ComboTalleres()

        'End Sub

        Private Sub txtCodInterno_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _
                           txtCodInterno.KeyPress,
                           txtApePat.KeyPress,
                           txtApeMat.KeyPress,
                           txtNom.KeyPress,
                           txtBuscaNumeroDocumento.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            ComboPenal()

        End Sub

        Private Sub cbbPenal__SelectedIndexChanged() Handles cbbPenal._SelectedIndexChanged

            If Me.IDPenal > 0 Then
                ComboTalleres()
            End If

        End Sub

        Private Sub btnViculaBiometrico_Click(sender As Object, e As EventArgs) Handles btnViculaBiometrico.Click
            If dgwGrilla.Rows.Count = 0 Then Exit Sub

            If IniciarSesionBiometrico() = False Then Exit Sub

            Try
                ws.test()
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Servicio web para intearctuar con el biométrico no se encuentra disponible, comuníquese con el administrador del sistema.")
                Exit Sub
            End Try

            If dgwGrilla.Item("col_reg_vinc_bio", dgwGrilla.CurrentRow.Index).Value = True And
                dgwGrilla.Item("col_est_nom", dgwGrilla.CurrentRow.Index).Value = "INACTIVO" Then

                Dim obj2 As New Entity.Tratamiento.TallerAsistencia.InternoTaller
                obj2.Codigo = Me.GrillaCodigo

                obj2 = bssIntTaller.Listar(obj2)

                obj2.CodigoMarcacionID = bssIntTaller.Listar(obj2.Codigo).CodigoMarcacionID

                BarBajaUsuarioBiometrico(obj2.CodigoMarcacionID, Me.GrillaCodigo)
                Exit Sub
            End If

            If dgwGrilla.Item("col_est_int", dgwGrilla.CurrentRow.Index).Value <> "ACTIVO" Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno se encuentra inactivo.")
                Exit Sub
            End If

            If dgwGrilla.Item("col_est_nom", dgwGrilla.CurrentRow.Index).Value <> "ACTIVO" Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno se encuentra inactivo en el taller.")
                Exit Sub
            End If

            If dgwGrilla.Item("col_reg_vinc_bio", dgwGrilla.CurrentRow.Index).Value = True Then
                Legolas.Configuration.Aplication.MessageBox.Information("Ya se encuentra vinculado al biométrico.")
                Exit Sub
            End If


            '--------------------------- vincular con el biometrico ----------------------
            Dim v As Boolean = True
            Dim Nombre As String = ""
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            obj.Codigo = Me.GrillaCodigo

            obj = bssIntTaller.Listar(obj)

            If obj Is Nothing Then Exit Sub
            If String.IsNullOrEmpty(obj.GrupoAcceso) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Grupo de acceso no válido, verifique.")
                Exit Sub
            End If

            If String.IsNullOrEmpty(obj.GrupoUsuario) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Grupo de usuario no válido, verifique.")
                Exit Sub
            End If

            If MsgBox("Se va a vincular al interno al equipo biométrico al grupo de actividad " & obj.GrupoUsuario.ToUpper & ", desea continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If

            obj.CodigoMarcacionID = bssIntTaller.Listar(obj.Codigo).CodigoMarcacionID
            Nombre = obj.ApellidoPaterno & " " & obj.ApellidoMaterno & " " & obj.Nombres

            Dim out_Eror As String = ""

            Try
                ws.CargaUsuarioSupremaV2(out_Eror, obj.CodigoMarcacionID, Nombre, obj.GrupoAcceso, obj.GrupoUsuario, obj.Email)
                If out_Eror.ToUpper = "Duplicate User".ToUpper Then
                    If MsgBox("El usuario ya se encuentra vinculado al biométrico en un grupo de actividad distinta, desea vincular al biométrico en el grupo de actividad " & obj.GrupoUsuario & "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim valor As Boolean = False
                        valor = EliminarUsuarioDeBiometrico(obj.CodigoMarcacionID)
                        If valor = False Then
                            out_Eror = "No se pudo eliminar el usuario del biométrico para vincular nuevamente a otro grupo."
                            v = False
                        Else
                            ws.CargaUsuarioSupremaV2(out_Eror, obj.CodigoMarcacionID, Nombre, obj.GrupoAcceso, obj.GrupoUsuario, obj.Email)
                            If out_Eror.Length > 0 Then v = False
                        End If
                    Else
                        out_Eror = "Usuario duplicado en el biométrico."
                        v = False
                    End If
                Else
                    If out_Eror.Length > 0 Then

                        ws.CargaUsuarioSupremaV2(out_Eror, obj.CodigoMarcacionID, Nombre, obj.GrupoAcceso, obj.GrupoUsuario, obj.Email) 'segundo intento

                        If out_Eror.Length > 0 Then v = False

                    End If
                End If
            Catch ex As Exception
                out_Eror = ex.Message
                v = False
            End Try

            If v = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("No se pudo vincular al interno a la actividad " & obj.GrupoUsuario & ", " & out_Eror)
            Else 'confirmar vinculacion con biometrico
                bssIntTaller.GrabarEstadoRegVinculacion(obj.Codigo, True)

                Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria.")
            End If
        End Sub

        Private Function EliminarUsuarioDeBiometrico(IdUsuario As String)
            Dim v As Boolean = True
            Dim out_Eror As String = ""
            ws.EliminarUsuario(out_Eror, IdUsuario)

            If out_Eror.Length > 0 Then
                v = False
            End If

            Return v
        End Function

        Private Function BarBajaUsuarioBiometrico(IdUsuario As String, idInternoTaller As Integer)
            Dim out_Eror As String = ""
            Dim v As Boolean = True

            Try
                ws.DesHabUsuarioSupremaV2(out_Eror, IdUsuario, 0)

                If out_Eror.Length > 0 Then
                    v = False
                Else
                    bssIntTaller.GrabarEstadoRegVinculacion(idInternoTaller, False)
                End If

            Catch ex As Exception
                out_Eror = ex.Message
                v = False
            End Try

            If v = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo desvincular del equipo biométrico, " & out_Eror)
            End If

            Return v
        End Function

        Private Function IniciarSesionBiometrico() As Boolean
            Dim out_Error As String = ""
            Dim v As Boolean = False
            bssIntTaller = New Bussines.Tratamiento.TallerAsistencia.InternoTaller

            ws = New APPWebService.ws_pope_ep_trat_asist_tall.ApiBiostarClient
            ws.Endpoint.Address = New System.ServiceModel.EndpointAddress(APPWebService.PathURL.ws_trat_taller_asist)

            Try
                ws.test()
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Servicio web para vinculación no se encuentra disponible, comuníquese con el administrador del sistema.")
                Return False
            End Try

            Try
                v = bssIntTaller.WS_IniciarLoggin(ws, out_Error)

                If out_Error.Length > 0 Then v = False
            Catch ex As Exception
                out_Error = ex.ToString
                v = False
            End Try

            If v = False Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo iniciar sessión con el biométrico por lo tanto no se podrá vincular el registro con el equipo biométrico; " & out_Error)
            End If

            Return v
        End Function
    End Class
End Namespace