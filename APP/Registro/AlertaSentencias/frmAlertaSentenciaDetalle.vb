Option Explicit On


Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Type.Enumeracion.Licencia
Imports System.Linq

Namespace Registro.AlertaSentencias
    Public Class frmAlertaSentenciaDetalle


#Region "Propiedades"
        Private objCol As Entity.Registro.AlertaSentenciaDetalleCol = Nothing
        Private ReadOnly Property IDLicencia As Short
            Get
                Return Configuracion.Licencia.Codigo
            End Get
        End Property
        Private ReadOnly Property LicenciaTipo As Short
            Get
                Dim value As Short = -1
                Dim objBss As New Bussines.Sistema.Instalacion
                value = objBss.ListarTipo(Me.IDLicencia)
                Return value
            End Get
        End Property
        Private ReadOnly Property UsuarioPerfil As Short
            Get
                Return Legolas.Configuration.Usuario.OficinaID
            End Get
        End Property

#End Region

#Region "Propiedades_Detalle"


        Public Property _Codigo As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property _RegionId As Integer = -1
        Public Property _TipoLicenciaID As Integer = -1
        Public Property _LicenciaID As Integer = -1
        Public Property _Item As Integer = -1
        Public Property _Fecha As DateTime
        Private intEstado As Integer = -1

        Public ReadOnly Property EstadoId() As Integer
            Get
                Dim intVal As Integer = -1
                If Me.rdbPendiente.Checked = True Then
                    intVal = 1
                End If
                If Me.rdbVencido.Checked = True Then
                    intVal = 2
                End If
                If Me.rdbTodos.Checked = True Then
                    intVal = -1
                End If
                Return intVal
            End Get
        End Property
#End Region

#Region "Propiedades_Grilla"

        Private ReadOnly Property GrillaInternoId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwAlertasentencia
                    intValue = .SelectedRows(0).Cells("col_int_id").Value
                End With
                Return intValue
            End Get
        End Property

        Private Property NumeroCorrelativo() As Integer
            Get
                Return cbbCorrelativo.SelectedValue
            End Get
            Set(value As Integer)
                cbbCorrelativo.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_Otros"

        Private ReadOnly Property IDLicencia2 As Integer
            Get
                Return Legolas.LBusiness.Globall.WinApp.LicenciaApp
            End Get
        End Property
#End Region
#Region "Propiedades_Cabecera"

#End Region

#Region "Combo"
        Private Sub ComboRegion()
            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.Region
                ._Todos = False
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboPenal()

            With Me.cbbPenal
                ._Todos = False
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.cbbRegion.SelectedValue
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
        Private Sub Combonumero()
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbCorrelativo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_Numero
                Dim indice As Integer = -1
                If Now().ToShortTimeString < "12:30:00" Then
                    indice = 1
                ElseIf Now().ToShortTimeString < "16:30:00" Then
                    indice = 2
                Else
                    indice = 3
                End If
                .SelectedValue = indice
            End With
        End Sub
#End Region

#Region "Listar"

        Public Sub _ListarSentenciasporCumplir()

            Dim bssDoc As New Bussines.Registro.AlertaSentenciaDetalle
            Dim objDet As New Entity.Registro.AlertaSentenciaDetalle
            objCol = New Entity.Registro.AlertaSentenciaDetalleCol

            If Me._Codigo < 1 Then Exit Sub
            If Me._PenalID = 0 Then
                Me._PenalID = -1
                Me.cbbPenal.SelectedValue = -1
            End If
            With objDet
                .Codigo = Me._Codigo
                ._RegionID = Me._RegionId
                ._PenalID = Me._PenalID
                ._TipoLicencia = Me._TipoLicenciaID
                .EstadoId = Me.EstadoId
                dtpFecha.Value = Me._Fecha
                cbbCorrelativo.Text = Me._Item
                lblechavencimiento.Text = CDate(Me.dtpFecha.Value).Date.AddDays(30)
            End With

            objCol = bssDoc.Listar(objDet)

            If objCol.Count > 0 Then
                lblTitulosentencia.Text = objCol.AlertaSentenciaDetalle(0).Titulo
                lblEstado.Text = objCol.AlertaSentenciaDetalle(0).EstadoCabecera
                If objCol.AlertaSentenciaDetalle(0).Codigo < 1 Then
                    lblReg.Text = 0 & " Reg."
                    dgwAlertasentencia.DataSource = Nothing
                    Exit Sub
                End If
            Else
                lblTitulosentencia.Text = "No existe registros en este periodo de vencimiento de condena"
                lblEstado.Text = ""
            End If

            With Me.dgwAlertasentencia
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objCol
                .Refresh()
                lblReg.Text = objCol.Count & " Reg."

            End With
        End Sub
        Private Sub Buscar()

            Dim bssDoc As New Bussines.Registro.AlertaSentenciaDetalle
            Dim objDet As New Entity.Registro.AlertaSentenciaDetalle
            objCol = New Entity.Registro.AlertaSentenciaDetalleCol

            With objDet
                .Codigo = -1
                ._RegionID = Me._RegionId
                ._PenalID = Me.cbbPenal.SelectedValue
                ._TipoLicencia = IIf(Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.Sede, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Me._TipoLicenciaID)
                .FechaConsulta = Me.dtpFecha.Value
                lblechavencimiento.Text = CDate(Me.dtpFecha.Value).Date.AddDays(30)
                .Item = Me.NumeroCorrelativo
                .EstadoId = Me.EstadoId
            End With

            objCol = bssDoc.Listar_bus(objDet)

            If objCol.Count > 0 Then
                If objCol.AlertaSentenciaDetalle(0).Codigo < 1 Then
                    lblTitulosentencia.Text = ""
                    lblEstado.Text = ""
                    lblechavencimiento.Text = ""
                    lblReg.Text = 0 & " Reg."
                    dgwAlertasentencia.DataSource = Nothing
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe registros en la fecha y hora consultada")
                    Exit Sub
                Else
                    lblTitulosentencia.Text = objCol.AlertaSentenciaDetalle(0).Titulo
                    lblEstado.Text = objCol.AlertaSentenciaDetalle(0).EstadoCabecera
                End If
            Else
                lblTitulosentencia.Text = ""
                lblEstado.Text = ""
                lblechavencimiento.Text = ""
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe registros en la fecha y hora consultada")
            End If

            With Me.dgwAlertasentencia
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objCol
                .Refresh()
                lblReg.Text = objCol.Count & " Reg."

            End With
        End Sub

#End Region

#Region "Permisos_Usuario"
        Private Function ValidarSedeLicencia(IDPenal As Integer) As Integer

            Dim value As Integer = -1

            Dim intLicenciaID As Integer = Me.IDLicencia
            Dim bssInstall As New Bussines.Sistema.Instalacion

            Select Case bssInstall.Listar(intLicenciaID).Tipo

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                    value = Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia

                    Dim objBssInDet As New Bussines.Sistema.InstalacionDetalle
                    Dim intLicEscritura As Integer

                    intLicEscritura = objBssInDet.VerificarPermisoEscritura(-1, intLicenciaID, IDPenal)
                    If intLicEscritura > 0 Then
                        value = -1
                    Else
                        value = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    End If
                Case Else
                    value = -1
            End Select

            Return value

        End Function
        Private Sub Usuario_Permisos()

            Dim intLicenciaID As Integer = Me.IDLicencia
            Dim blnBuscarLicenciaPenalEscritura As Boolean = False
            Dim intTipoLicencia As Short = -1

            Dim objBss As New Bussines.Sistema.Instalacion

            Select Case intLicenciaID
                Case 1 'sede central
                    blnBuscarLicenciaPenalEscritura = True
                Case Else 'provincias

                    intTipoLicencia = objBss.ListarTipo(intLicenciaID)

                    Select Case intTipoLicencia
                        Case 2 'regiones
                            blnBuscarLicenciaPenalEscritura = True
                    End Select

            End Select

            If blnBuscarLicenciaPenalEscritura = True Then

                Dim objBssInDet As New Bussines.Sistema.InstalacionDetalle
                Dim intLicEscritura As Integer

                intLicEscritura = objBssInDet.VerificarPermisoEscritura(-1, intLicenciaID, Me._PenalID)

                If intLicEscritura < 1 Then
                    Me._FormEscritura = False
                    Me._FormEliminar = False
                End If

            End If

            If Me._FormEscritura = True Then

                Select Case Configuracion.Licencia.Codigo
                    Case 1 'sede central
                        Select Case Legolas.Configuration.Usuario.OficinaID

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario

                            Case Else
                                Me._FormEscritura = False
                        End Select

                    Case Else 'provincias

                        Select Case Legolas.Configuration.Usuario.OficinaID

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario

                            Case Else
                                Me._FormEscritura = False
                        End Select
                End Select
            End If

            If Me._FormEliminar = True Then

                Select Case Configuracion.Licencia.Codigo
                    Case 1 'sede central

                        Select Case Legolas.Configuration.Usuario.OficinaID

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario

                            Case Else
                                Me._FormEliminar = False
                        End Select

                    Case Else 'provincias

                        Select Case Legolas.Configuration.Usuario.OficinaID

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario

                            Case Else
                                Me._FormEliminar = False
                        End Select
                End Select
            End If

            'controles
            '  Me.pnlGrabarDatos.Visible = Me._FormEscritura
            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlReporte.Visible = Me._FormReporte
            Me.pnlVerLibro.Visible = Me._FormReporte
            '/*datos complementarios*/



        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()

            ComboRegion()
            Me.dtpFecha.Value = Now()
            Combonumero()
            'ComboPenal()
            ConfigurarCombo()
            ConfigurarGrilla()
            _ListarSentenciasporCumplir()
            ' Me.Refresh()
            Me.WindowState = FormWindowState.Maximized
        End Sub
        Private Sub Limpiar()
            dtpFecha.Value = Now()
            rdbTodos.Checked = True

            Dim indice As Integer = -1
            If Now().ToShortTimeString < "12:30:00" Then
                indice = 1
            ElseIf Now().ToShortTimeString < "16:30:00" Then
                indice = 2
            Else
                indice = 3
            End If
            cbbCorrelativo.Text = indice
            lblTitulosentencia.Text = ""
            lblechavencimiento.Text = ""
            lblEstado.Text = ""
        End Sub
        Private Sub ConfigurarGrilla()

            With dgwAlertasentencia
                For i As Integer = 0 To dgwAlertasentencia.Columns.Count - 1
                    Select Case i
                        Case 14
                            .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                            .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        Case 11, 12, 13
                            .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                            .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Case Else
                            .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End Select
                Next

                .Columns("col_not_sen_dias_res").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("col_not_sen_dias_res").DefaultCellStyle.Format = "#,#"

            End With

        End Sub
#End Region


        Private Sub frmAlertaSentenciaDetalle_Load(sender As Object, e As EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub ConfigurarCombo()
            If Me._TipoLicenciaID = -1 Then
                Me._TipoLicenciaID = Me.LicenciaTipo
                Me._LicenciaID = Me.IDLicencia

                Dim bss As New Bussines.Registro.AlertaSentenciaCabecera
                Dim obj As New Entity.Registro.AlertaSentenciaCabecera
                Dim objCol As New Entity.Registro.AlertaSentenciaCabeceraCol

                With obj
                    If Me._TipoLicenciaID = 3 Then
                        Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.Sede
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Sede
                    End If
                    If Me._TipoLicenciaID = 2 Then
                        Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    End If
                    If Me._TipoLicenciaID = 1 Then
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                    End If
                End With
                objCol = bss.Listar(obj)
                If objCol.Count > 0 Then
                    If objCol.AlertaSentenciaCabecera(0)._RegionID = 0 Then
                        objCol.AlertaSentenciaCabecera(0)._RegionID = 3
                    End If
                    Me._RegionId = objCol.AlertaSentenciaCabecera(0)._RegionID
                    If objCol.AlertaSentenciaCabecera(0)._PenalID = 0 Then
                        objCol.AlertaSentenciaCabecera(0)._PenalID = -1
                    End If
                    Me._PenalID = objCol.AlertaSentenciaCabecera(0)._PenalID
                End If
            End If
            Me.cbbRegion.SelectedValue = Me._RegionId
            ComboPenal()
            If Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                Me.cbbRegion.Enabled = False

            ElseIf Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia Then
                Me.cbbRegion.Enabled = False
                Me.cbbPenal.Enabled = False
                Me.lblPenal.Visible = Visible
                Me.cbbPenal.Visible = Visible
                Me.cbbPenal.SelectedValue = Me._PenalID
            ElseIf Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia Then
                Me.cbbRegion.Enabled = False
                Me.cbbPenal.Enabled = True
                Me.lblPenal.Visible = Visible
                Me.cbbPenal.Visible = Visible
                Me.cbbPenal.SelectedValue = Me._PenalID
            ElseIf Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                Me.cbbRegion.Enabled = False
                Me.cbbPenal.Enabled = False
                Me.lblPenal.Visible = Visible
                Me.cbbPenal.Visible = Visible
                Me.cbbPenal.SelectedValue = Me._PenalID
            ElseIf Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.Sede Then
                Me.cbbRegion.Enabled = False

            End If
        End Sub

        Private Sub tsbBuscar_Click(sender As Object, e As EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub btnDetalleInterno_Click(sender As Object, e As EventArgs) Handles btnDetalleInterno.Click
            FRM_InternoDetalle(Me.GrillaInternoId)
        End Sub

        Private Sub FRM_InternoDetalle(IDInterno As Long)

            '/*abrir el los permisos del usuario*/

            Dim objEntUsuarioModuloCol As New Legolas.LEntity.Seguridad.UsuarioModuloCol
            Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioModulo

            objEntUsuarioModuloCol = objBss.Listar(Legolas.Configuration.Usuario.Codigo, -1, 31) 'registro penal

            Dim blnLectura As Boolean = False
            Dim blnEscritura As Boolean = False
            Dim blnReporte As Boolean = False
            Dim blnEliminar As Boolean = False

            If objEntUsuarioModuloCol IsNot Nothing Then
                If objEntUsuarioModuloCol.Count = 1 Then
                    blnLectura = objEntUsuarioModuloCol.Item(0).Lectura
                    blnEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                    blnReporte = objEntUsuarioModuloCol.Item(0).Reporte
                    blnEliminar = objEntUsuarioModuloCol.Item(0).Eliminar
                End If
            End If

            Dim blnVersion5 As Boolean = Bussines.General.Penal.Version5(Me._PenalID)
            '/*abrir el formulario de internos*/
            If Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.Sede Then
                Dim frm As New Registro.Main.Region.frmMantenimiento
                frm.MdiParent = Me.MdiParent
                With frm
                    ._IDInterno = IDInterno
                    ._FormLectura = blnLectura
                    ._FormEscritura = blnEscritura
                    ._FormReporte = blnReporte
                    ._FormEliminar = blnEliminar
                    .Show()
                End With
            ElseIf Me._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia Then
                Dim frm As New Registro.PenalLM.Busqueda.frmMantenimiento
                frm.MdiParent = Me.MdiParent
                With frm
                    ._IDInterno = IDInterno
                    ._FormLectura = blnLectura
                    ._FormEscritura = blnEscritura
                    ._FormReporte = blnReporte
                    ._FormEliminar = blnEliminar
                    .Show()
                End With
            Else
                    Dim frm As New Registro.Penal.Busqueda.frmMant
                frm.MdiParent = Me.MdiParent
                With frm
                    .InternoID = IDInterno
                    ._FormLectura = blnLectura
                    ._FormEscritura = blnEscritura
                    ._FormReporte = blnReporte
                    ._FormEliminar = blnEliminar
                    .Show()
                End With
            End If

        End Sub

        Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwAlertasentencia)

        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnFicha_Click(sender As Object, e As EventArgs) Handles btnFicha.Click
            FRM_VerReportes()
        End Sub

        Private Sub FRM_VerReportes()

            Dim frm2 As New Registro.AlertaSentencias.frmReporteAlerta
            With frm2
                ._RegionID = Me._RegionId
                ._PenalID = Me._PenalID
                ._TipoReporte = Type.Reporte.Registro.rptListaAlertaSentencia
                ._TipoLicencia = Me._TipoLicenciaID
                .ShowDialog()
            End With
        End Sub

        Private Sub dgwAlertasentencia_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgwAlertasentencia.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            If dgwAlertasentencia.Columns(e.ColumnIndex).Name = "col_not_sen_dias_res" Then
                If dgwAlertasentencia.Item("col_not_sen_est_id", e.RowIndex).Value = 2 Then
                    e.CellStyle.BackColor = Color.OrangeRed
                End If
            End If
        End Sub


        Private Sub dgwAlertasentencia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwAlertasentencia.CellClick
            If e.RowIndex = -1 Then
                With Me.dgwAlertasentencia
                    Me.Cursor = Cursors.WaitCursor
                    objCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    .CurrentCell = Nothing
                    Me.Cursor = Cursors.Default
                    .Refresh()
                End With
            End If
        End Sub

        Private Sub tsbLimpiar_Click(sender As Object, e As EventArgs) Handles tsbLimpiar.Click
            Limpiar()
        End Sub

        Private Sub frmAlertaSentenciaDetalle_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        End Sub
    End Class
End Namespace
