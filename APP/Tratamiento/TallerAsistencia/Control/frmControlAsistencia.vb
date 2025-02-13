Imports System.ComponentModel
Imports Type
Namespace Tratamiento.TallerAsistencia

    Public Class frmControlAsistencia

        Private bssAsi As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
        Private bssTal As New Bussines.Tratamiento.TallerAsistencia.InternoTaller
        Private objentACol As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
        Private ObjCol As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
#Region "Propiedades_Grilla"

        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With dgwListar
                        intValue = .SelectedRows(0).Cells("col_con_cod").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property        

        Private ReadOnly Property Grilla_InternoID As Integer
            Get
                Dim str As Integer = -1
                str = dgwListar.SelectedRows(0).Cells("col_con_int_id").Value
                Return str
            End Get
        End Property
        Private ReadOnly Property GrillaInternoApeNom As String
            Get
                Dim strValue As String = ""
                Try
                    With dgwListar
                        strValue = .SelectedRows(0).Cells("col_con_ape_pat").Value & " " & .SelectedRows(0).Cells("col_con_ape_mat").Value & " " & .SelectedRows(0).Cells("col_con_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property Grilla_CodigoAsistencia As Integer
            Get
                Dim str As Integer = -1
                str = dgwListar.SelectedRows(0).Cells("col_con_cod").Value
                Return str
            End Get
        End Property
        Private ReadOnly Property Grilla_JustificacionID As Integer
            Get
                Dim str As Integer = -1
                str = dgwListar.SelectedRows(0).Cells("col_jus_id").Value
                Return str
            End Get
        End Property
#End Region

#Region "Propiedades_Busqueda_Internos"
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
        Private Property Apellidos() As String
            Get
                Return Me.txtApellidos.Text()
            End Get
            Set(ByVal value As String)
                Me.txtApellidos.Text = value
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
        Private Property PreNombres() As String
            Get
                Return Me.txtNombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtNombres.Text = value
            End Set
        End Property
        Private Property FechaInicio() As Long
            Get
                Return dtpFechaIni.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFin() As Long
            Get
                Return Me.dtpFechaFin.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property
#End Region
#Region "Combos"
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
        Private Sub ComboTalleres()
            With Me.cbbTalleres
                ._Todos = True
                .CodigoPadre = Me.IDPenal
                ._LoadUsc(Type.Combo.Tratamiento.Trabajo.TallerAsistencia.Talleres, True)
            End With
            blnCombo = False
        End Sub

#End Region
#Region "Listar"

        Private Function ValidarFecha() As Boolean
            If (Me.FechaInicio = 0 And Me.FechaFin > 0) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar fecha correcta")
                Me.dtpFechaIni.Focus()
                Return False
            End If
            If (Me.FechaInicio > 0 And Me.FechaFin = 0) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar fecha correcta")
                Me.dtpFechaFin.Focus()
                Return False
            End If
            If Me.FechaInicio > Me.FechaFin Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de inicio busqueda no puede ser mayor que la fecha fin")
                dtpFechaIni.Focus()
                Return False
            End If
            Return True
        End Function

        Private Sub BuscarAsistencia()

            If ValidarFecha() = False Then
                Exit Sub
            End If

            objentACol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            bssAsi = New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            bssTal = New Bussines.Tratamiento.TallerAsistencia.InternoTaller

            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim objTal As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            Dim objColTall As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol

            objEnt.CodigoTaller = Me.IDTaller
            objEnt.FechaInicioBusqueda = Me.FechaInicio
            objEnt.FechaFinBusqueda = Me.FechaFin
            objEnt.ApellidosNombres = Me.Apellidos
            objEnt.Nombres = Me.PreNombres
            objEnt.PenalID = Me.IDPenal

            objTal.CodigoTaller = Me.IDTaller
            objTal.FechaInicioBusqueda = Me.FechaInicio
            objTal.FechaFinBusqueda = Me.FechaFin
            objTal.ApellidosNombres = Me.Apellidos
            objTal.Nombres = Me.PreNombres
            objTal.EstadoLaboralID = 1
            objTal.PenalID = Me.IDPenal

            objentACol = bssAsi.ListarAsistencia_v2(objEnt)
            objColTall = bssTal.ListarCol_v2(objTal)

            ObjCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            ObjCol = ListarFiltro(objentACol, objColTall, Me.FechaInicio, Me.FechaFin)

            With Me.dgwListar
                .ReadOnly = True
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = ObjCol
                If ObjCol.Count > 0 Then
                    .Rows(0).Selected = False
                End If
                lblReg.Text = ObjCol.Count & " Reg. encontrados"
            End With

        End Sub
        Private Function ListarFiltro(objCol As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol, objTallCol As Entity.Tratamiento.TallerAsistencia.InternoTallerCol, FechaIni As Long, FechaFin As Long) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim objAsistenciaCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim objAsisCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim Contador As Integer = 0
            Dim dia As Integer = 0
            Dim mes As Integer = 0
            Dim anho As Integer = 0

            Dim PrimerDiaAsis As Integer = 0
            Dim TallerId As Integer = -1
            Dim swich As Boolean = True
            Dim blnswicht As Boolean = False

            If objCol.Count > 0 Then
                PrimerDiaAsis = CDate(objCol.Item(0).FechaDate).Day
                TallerId = objCol.Item(0).CodigoTaller
                blnswicht = True
            End If

            For Each obj As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objCol
                Contador += 1
                dia = CDate(obj.FechaDate).Day
                mes = CDate(obj.FechaDate).Month
                anho = CDate(obj.FechaDate).Year
                If PrimerDiaAsis = dia Then
                    If TallerId = obj.CodigoTaller Then
                        objAsisCol.Add(obj)
                        objAsistenciaCol.Add(obj)
                        blnswicht = True
                    Else
                        For Each obj2 As Entity.Tratamiento.TallerAsistencia.InternoTaller In objTallCol
                            swich = True
                            If TallerId = obj2.CodigoTaller Then
                                For Each ob As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objAsisCol
                                    If obj2.InternoID = ob.InternoID Then
                                        If obj2.CodigoTaller = ob.CodigoTaller Then
                                            swich = False
                                            Exit For
                                        End If
                                    End If
                                Next
                                If swich = True Then
                                    Dim fecha As Date = CDate(dia & "/" & mes & "/" & anho)
                                    Dim objeto As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                                    objeto.InternoID = obj2.InternoID
                                    objeto.CodigoRP = obj2.CodigoRP
                                    objeto.ApellidoPaterno = obj2.ApellidoPaterno
                                    objeto.ApellidoMaterno = obj2.ApellidoMaterno
                                    objeto.Nombres = obj2.Nombres
                                    objeto.TipoDocumentoID = obj2.TipoDocumentoID
                                    objeto.TipoDocumentoNombre = obj2.TipoDocumentoNombre
                                    objeto.NumeroDocumento = obj2.NumeroDocumento
                                    objeto.NacionalidadNombre = obj2.NacionalidadNombre
                                    objeto.TallerNombre = obj2.NombreTaller
                                    objeto.Fecha = Legolas.Components.FechaHora.FechaLong(fecha)
                                    objeto.HoraEntrada = "---"
                                    objeto.HoraSalida = "---"
                                    objeto.MotivoJustificacionID = -1
                                    objeto.EstadoJustificacion = -1
                                    objAsisCol.Add(objeto)
                                    objAsistenciaCol.Add(objeto)
                                End If
                            End If
                        Next
                        TallerId = obj.CodigoTaller
                        objAsisCol.Add(obj)
                        objAsistenciaCol.Add(obj)

                    End If
                Else
                    blnswicht = False
                    For Each obj2 As Entity.Tratamiento.TallerAsistencia.InternoTaller In objTallCol
                        If obj2.CodigoTaller = objAsisCol.Item(objAsisCol.Count - 1).CodigoTaller Then
                            swich = True
                            For Each ob As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objAsisCol
                                If obj2.InternoID = ob.InternoID Then
                                    swich = False
                                    Exit For
                                End If
                            Next
                            If swich = True Then
                                Dim diaaux As Integer = dia + 1
                                Dim fecha As Date = CDate(diaaux & "/" & mes & "/" & anho)
                                Dim objeto As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                                objeto.InternoID = obj2.InternoID
                                objeto.CodigoRP = obj2.CodigoRP
                                objeto.ApellidoPaterno = obj2.ApellidoPaterno
                                objeto.ApellidoMaterno = obj2.ApellidoMaterno
                                objeto.Nombres = obj2.Nombres
                                objeto.TipoDocumentoID = obj2.TipoDocumentoID
                                objeto.TipoDocumentoNombre = obj2.TipoDocumentoNombre
                                objeto.NumeroDocumento = obj2.NumeroDocumento
                                objeto.NacionalidadNombre = obj2.NacionalidadNombre
                                objeto.TallerNombre = obj2.NombreTaller
                                objeto.Fecha = Legolas.Components.FechaHora.FechaLong(fecha)
                                objeto.HoraEntrada = "---"
                                objeto.HoraSalida = "---"
                                objeto.MotivoJustificacionID = -1
                                objeto.EstadoJustificacion = -1
                                objAsisCol.Add(objeto)
                                objAsistenciaCol.Add(objeto)
                            End If
                        End If
                    Next
                    Dim oobj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia

                    objAsisCol.Add(obj)
                    objAsistenciaCol.Add(obj)
                    PrimerDiaAsis = PrimerDiaAsis - 1
                    TallerId = obj.CodigoTaller
                End If
            Next
            If blnswicht = True Then
                For Each obj As Entity.Tratamiento.TallerAsistencia.InternoTaller In objTallCol
                    swich = True
                    For Each ob As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objAsisCol
                        If obj.InternoID = ob.InternoID Then
                            swich = False
                            Exit For
                        End If
                    Next
                    If swich = True Then
                        Dim fecha As Date = CDate(dia & "/" & mes & "/" & anho)
                        Dim objeto As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                        objeto.InternoID = obj.InternoID
                        objeto.CodigoRP = obj.CodigoRP
                        objeto.ApellidoPaterno = obj.ApellidoPaterno
                        objeto.ApellidoMaterno = obj.ApellidoMaterno
                        objeto.Nombres = obj.Nombres
                        objeto.TipoDocumentoID = obj.TipoDocumentoID
                        objeto.TipoDocumentoNombre = obj.TipoDocumentoNombre
                        objeto.NumeroDocumento = obj.NumeroDocumento
                        objeto.NacionalidadNombre = obj.NacionalidadNombre
                        objeto.TallerNombre = obj.NombreTaller
                        objeto.Fecha = Legolas.Components.FechaHora.FechaLong(fecha)
                        objeto.HoraEntrada = "---"
                        objeto.HoraSalida = "---"
                        objeto.MotivoJustificacionID = -1
                        objeto.EstadoJustificacion = -1
                        objAsisCol.Add(objeto)
                        objAsistenciaCol.Add(objeto)
                    End If
                Next
            End If
            Dim con As Integer = 0
            If ckbSinsalida.Checked = False And ckbInasistencia.Checked = False Then
                For Each ob As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objAsistenciaCol
                    con += 1
                    ob.Contador = con
                Next
                Return objAsistenciaCol
            End If
            Dim Value As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            For Each obj As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objAsistenciaCol
                If ckbSinsalida.Checked = True Then
                    If (obj.HoraSalida.Trim = "00:00:00" Or obj.HoraSalida.Trim = "0" Or obj.HoraSalida.Length = 0) Then
                        con += 1
                        obj.Contador = con
                        Value.Add(obj)
                    End If
                ElseIf ckbInasistencia.Checked = True Then
                    If (obj.HoraEntrada.Trim = "---" And obj.HoraSalida.Trim = "---" And obj.MotivoJustificacionID = -1) Then
                        con += 1
                        obj.Contador = con
                        Value.Add(obj)
                    End If
                End If
            Next
            Return Value
        End Function
        Private Sub ListarFiltroGrilla()
            Dim ObjCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol

            'ObjCol = ListarFiltro(objentACol)

            With Me.dgwListar
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = ObjCol
                lblReg.Text = ObjCol.Count & " Reg. encontrados"
                For i As Integer = 0 To ObjCol.Count - 1
                    .Item("col_num", i).Value = i + 1
                Next
            End With
        End Sub

#End Region
#Region "Otros"
        Private Sub ValoresDefault()

            ComboRegion()
            ComboPenal()
            ComboTalleres()


            Dim lngFecha As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong
            Me.FechaInicio = Now().ToFileTime
            Me.FechaFin = Now().ToFileTime

            Me.col_fec_nac.Tag = "fecha"
            Me.col_fec_asi.Tag = "fecha"
            pnlEliminar.Visible = False
            pnlReporte.Visible = False
        End Sub

        Private Sub ALimpiar()

            Me.Apellidos = ""
            Me.PreNombres = ""
            Me.IDTaller = -1
            Me.FechaInicio = 0
            Me.FechaFin = 0
            Me.ckbSinsalida.Checked = False

        End Sub

#End Region
#Region "Formularios"
        Private Sub frm_AgregarAsistencia()

            Dim f As New Tratamiento.TallerAsistencia.frmRegularizarAsistencia
            f._PenalID = Me.IDPenal
            f._RegionID = Me.IDRegion
            'permisos

            f._FormEscritura = Me._FormEscritura
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                BuscarAsistencia()
            End If

        End Sub
        Private Sub frm_RegularizarAsistencia(e As Integer)
            If Me._FormEscritura = True Then
                If Me.IDPenal < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar establecimiento penal")
                    Exit Sub
                End If
                Dim intIndiceFilaSel As Integer = -1
                Dim conEntrada As Integer = Len(dgwListar.SelectedRows(0).Cells("col_con_hor_ent").Value)
                Dim conSalida As Integer = Len(dgwListar.SelectedRows(0).Cells("col_con_hor_sal").Value)
                Dim IdJustifi As Integer = dgwListar.SelectedRows(0).Cells("col_jus_id").Value

                If Me.Grilla_JustificacionID < 1 Then 'Sin justificacion
                    If conEntrada > 0 And conSalida = 0 Then
                        Dim f As New Tratamiento.TallerAsistencia.frmRegularizar
                        f._Codigo = Me.Grilla_CodigoAsistencia
                        f._FormEscritura = _FormEscritura
                        f._Habilitar = False
                        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                            intIndiceFilaSel = dgwListar.CurrentRow.Index
                            BuscarAsistencia()
                            Try
                                dgwListar.Rows(intIndiceFilaSel).Selected = True 'vuelve a seleccionar la misma fila la cual se esta actualizando
                                dgwListar.CurrentCell = dgwListar.Item(1, intIndiceFilaSel)
                            Catch ex As Exception
                            End Try
                        End If
                    ElseIf conEntrada = 0 And conSalida = 0 Then
                        Dim f As New Tratamiento.TallerAsistencia.Control.frmRegistrarFaltas
                        f._Codigo = Me.Grilla_CodigoAsistencia
                        f._FormEscritura = _FormEscritura
                        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                            BuscarAsistencia()
                        End If
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Information("El registro posee [Hora de entrada] y [ Hora de salida]")
                    End If
                ElseIf Me.Grilla_JustificacionID = 1 Then 'Omision
                    Dim f As New Tratamiento.TallerAsistencia.frmRegularizar
                    f._Codigo = Me.Grilla_CodigoAsistencia
                    f._FormEscritura = _FormEscritura
                    f._Habilitar = False
                    If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                        intIndiceFilaSel = dgwListar.CurrentRow.Index
                        BuscarAsistencia()
                        Try
                            dgwListar.Rows(intIndiceFilaSel).Selected = True 'vuelve a seleccionar la misma fila la cual se esta actualizando
                            dgwListar.CurrentCell = dgwListar.Item(1, intIndiceFilaSel)
                        Catch ex As Exception
                        End Try
                    End If
                ElseIf Me.Grilla_JustificacionID > 1 Then 'Todas Justificaciones
                    Dim f As New Tratamiento.TallerAsistencia.Control.frmRegistrarFaltas
                    f._Codigo = Me.Grilla_CodigoAsistencia
                    f.MotivoFaltaId = Me.Grilla_JustificacionID
                    f._RegionID = Me.IDRegion
                    f._PenalID = Me.IDPenal
                    f._FormEscritura = _FormEscritura
                    If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                        BuscarAsistencia()
                    End If
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Esta acción no esta permitida para este usuario.")
            End If
        End Sub
        Private Sub frm_FaltaDisciplinaria()
            If Me.IDPenal < 1 Or Me.IDRegion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar Establecimiento Penal")
                Exit Sub
                cbbRegion.Focus()
            End If
            Dim f As New Tratamiento.TallerAsistencia.Control.frmRegistrarFaltas
            f._RegionID = Me.IDRegion
            f._PenalID = Me.IDPenal
            'permisos
            f._FormEscritura = Me._FormEscritura
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                BuscarAsistencia()
            End If

        End Sub
        Private Sub frm_Reporte()
            Dim frm As New Tratamiento.TallerAsistencia.Reporte.frmReportePopup
            With frm
                ._LoadParametros(Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_internoasistencia,
                                  Me.Grilla_InternoID, Me.GrillaInternoApeNom)
                .ShowDialog()
            End With
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

        Private Sub UsuarioPermisos()

            Me.pnlImporAsistencia.Visible = Me._FormEscritura
            Me.pnlRegularizar.Visible = Me._FormEscritura
            Me.pnlExportar.Visible = Me._FormEscritura
            'Me.pnlEliminar.Visible = Me._FormEliminar
        End Sub

        Private Sub frmTallerAsistencia_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Me.WindowState = FormWindowState.Maximized
            UsuarioPermisos()
        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            BuscarAsistencia()
        End Sub

        Private Sub dgwListar_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwListar.CellDoubleClick
            If e.RowIndex = -1 Then
                Exit Sub
            End If
            frm_RegularizarAsistencia(e.ColumnIndex)
        End Sub

        Private Sub dgwListar_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwListar.CellFormatting
            With Me.dgwListar
                Select Case e.ColumnIndex
                    Case .Columns("col_fec_nac").Index, .Columns("col_fec_asi").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            'e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                            e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
            ALimpiar()
        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            If dgwListar.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pueder exportar a excel porque no hay registros.")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea exportar el archivo a excel?") = Windows.Forms.DialogResult.Yes Then
                Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwListar)
            End If

        End Sub
        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            If dgwListar.Rows.Count = 0 Or Me.GrillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione registro")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Confirma eliminar el registro seleccionado?") = Windows.Forms.DialogResult.Yes Then

                Dim objBss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
                Dim Value As Integer = -1

                Value = objBss.Eliminar(Me.GrillaCodigo)

                If Value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria.")
                    BuscarAsistencia()
                End If

            End If

        End Sub

        Private Sub ckbSinsalida_Click(sender As Object, e As System.EventArgs)

            ListarFiltroGrilla()

        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            ComboPenal()

        End Sub

        Private Sub btnRegularizarAsistencia_Click(sender As System.Object, e As System.EventArgs)

            If Me.IDPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione penal")
                Exit Sub
            End If

            frm_AgregarAsistencia()

        End Sub

        Private Sub btnImportarAsis_Click(sender As System.Object, e As System.EventArgs) Handles btnImportarAsis.Click

            If Me.IDPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione penal")
                Exit Sub
            End If

            Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            intTipoLicencia = (New Bussines.Sistema.Instalacion).ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            If intTipoLicencia = 3 Or intTipoLicencia = 2 Then '3=sede,2=region
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Opción válida solo para penales.")
                Exit Sub
            End If

            Dim bss As New Bussines.Tratamiento.TallerAsistencia.MarcacionAsistenciaEquipo
            Dim outSms As String = ""

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Confirma importar las marcaciones del biométrico?") = Windows.Forms.DialogResult.Yes Then
                If bss.ImportMarcacionDesdeBdBiometricoATmp(outSms) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outSms)
                End If

                outSms = ""
                If bss.ImportarMarcacionDesdeTmp(Me.IDRegion, Me.IDPenal, outSms) = True Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Error: " & outSms)
                End If
            End If

        End Sub

        Private Sub cbbPenal__SelectedIndexChanged() Handles cbbPenal._SelectedIndexChanged
            If Me.IDPenal > 0 Then ComboTalleres()
        End Sub

        Private Sub dgwListar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwListar.CellClick
            If dgwListar.Rows.Count = 0 Then Exit Sub

            If e.RowIndex = -1 Then
                Me.Cursor = Cursors.WaitCursor
                ObjCol.Sort(dgwListar.Columns(e.ColumnIndex).DataPropertyName)
                dgwListar.CurrentCell = Nothing
                Me.Cursor = Cursors.Default
                dgwListar.Refresh()
            End If
        End Sub

        Private Sub btnSuspender_Click(sender As Object, e As EventArgs) Handles btnSuspender.Click
            frm_FaltaDisciplinaria()
        End Sub

        Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
            txtApellidos.KeyPress,
            txtNombres.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                BuscarAsistencia()
            End If
        End Sub

        Private Sub btnImportABdTmp_Click(sender As Object, e As EventArgs)
            If Me.IDPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione penal")
                Exit Sub
            End If

            Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            intTipoLicencia = (New Bussines.Sistema.Instalacion).ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            If intTipoLicencia = 3 Or intTipoLicencia = 2 Then '3=sede,2=region
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Opción válida solo para penales.")
                Exit Sub
            End If

            Dim bss As New Bussines.Tratamiento.TallerAsistencia.MarcacionAsistenciaEquipo
            Dim outSms As String = ""

            If bss.ImportMarcacionDesdeBdBiometricoATmp(outSms) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSms)
            End If
        End Sub

        Private Sub ckbSinsalida_CheckedChanged(sender As Object, e As EventArgs) Handles ckbSinsalida.CheckedChanged
            If ckbSinsalida.Checked = True Then
                ckbInasistencia.Checked = False
            End If
        End Sub

        Private Sub ckbInasistencia_CheckedChanged(sender As Object, e As EventArgs) Handles ckbInasistencia.CheckedChanged
            If ckbInasistencia.Checked = True Then
                ckbSinsalida.Checked = False
            End If
        End Sub
    End Class
End Namespace