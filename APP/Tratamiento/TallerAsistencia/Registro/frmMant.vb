Imports System.ComponentModel
Imports Type
Namespace Tratamiento.TallerAsistencia

    Public Class frmMant

        Private Bss As Bussines.Tratamiento.TallerAsistencia.InternoTaller
        Private bssAsi As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
        Private objentACol As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
        Private objentCol As Entity.Tratamiento.TallerAsistencia.InternoTallerCol

#Region "Propiedades_Datos_Interno"
        Public Property _IDInterno As Integer = -1
        Private Property IDRegion() As Short = -1
        Private Property IDPenal() As Short = -1
        Private Property CodigoInterno() As String
            Get
                Return Me.txtCodigoInterno.Text()
            End Get
            Set(ByVal value As String)
                Me.txtCodigoInterno.Text = value
            End Set
        End Property
        Private Property PrimerApellido() As String
            Get
                Return Me.txtApellidoPat.Text()
            End Get
            Set(ByVal value As String)
                Me.txtApellidoPat.Text = value
            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtApellidoMat.Text
            End Get
            Set(ByVal value As String)
                Me.txtApellidoMat.Text = value
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
        Private ReadOnly Property getInternoApeNom As String
            Get

                Dim value As String = ""

                value = Me.PrimerApellido & " " & Me.SegundoApellido & ", " & Me.PreNombres

                Return value
            End Get
        End Property
        Private Property TipoDocumentoNumero() As String
            Get
                Return Me.txtTipoNumeroDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtTipoNumeroDoc.Text = value
            End Set
        End Property
        Private Property FechaNacimiento() As String
            Get
                Return Me.txtFechaNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaNacimiento.Text = value
            End Set
        End Property
        Private Property Edad() As String
            Get
                Return Me.txtEdad.Text
            End Get
            Set(ByVal value As String)
                Me.txtEdad.Text = value
            End Set
        End Property
        Private Property IDSexo() As Short
            Get
                Dim value As Short = -1

                If Me.rbtFemenino.Checked = True Then
                    value = 0
                End If

                If Me.rbtMasculino.Checked = True Then
                    value = 1
                End If

                Return value
            End Get
            Set(ByVal value As Short)

                Select Case value
                    Case 0
                        Me.rbtFemenino.Checked = True
                    Case 1
                        Me.rbtMasculino.Checked = True
                End Select

            End Set

        End Property
        Private Property EstadoCivil() As String
            Get
                Return Me.txtEstadoCivil.Text
            End Get
            Set(ByVal value As String)
                Me.txtEstadoCivil.Text = value
            End Set
        End Property
        Private Property ValidacionReniec() As Short
            Get
                Dim value As Short = -1

                If Me.rbtNoRNC.Checked = True Then
                    value = 0
                End If

                If Me.rbtSiRNC.Checked = True Then
                    value = 1
                End If

                Return value
            End Get
            Set(ByVal value As Short)

                If value > 0 Then
                    Me.rbtSiRNC.Checked = True
                End If

                If value < 1 Then
                    Me.rbtNoRNC.Checked = True
                End If

            End Set

        End Property
        Private Property Padre() As String
            Get
                Return Me.txtpadre.Text
            End Get
            Set(ByVal value As String)
                Me.txtpadre.Text = value
            End Set
        End Property
        Private Property Madre() As String
            Get
                Return Me.txtMadre.Text
            End Get
            Set(ByVal value As String)
                Me.txtMadre.Text = value
            End Set
        End Property
        Private Property NacionalidadNombre() As String
            Get
                Return Me.txtNacionalidadNombre.Text
            End Get
            Set(ByVal value As String)
                Me.txtNacionalidadNombre.Text = value
            End Set
        End Property
        Private Property PaisNacimiento() As String
            Get
                Return Me.txtPaisNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtPaisNacimiento.Text = value
            End Set
        End Property
        Private Property DepartamentoNacimiento() As String
            Get
                Return Me.txtDepartamentoNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtDepartamentoNacimiento.Text = value
            End Set
        End Property
        Private Property ProvinciaNacimiento() As String
            Get
                Return Me.txtProvinciaNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtProvinciaNacimiento.Text = value
            End Set
        End Property
        Private Property DistritoNacimiento() As String
            Get
                Return Me.txtDistritoNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtDistritoNacimiento.Text = value
            End Set
        End Property
        Private Property PenalNombre() As String
            Get
                Return Me.txtPenal.Text
            End Get
            Set(ByVal value As String)
                Me.txtPenal.Text = value
            End Set
        End Property
        Private Property Estado() As String
            Get
                Return Me.txtEstado.Text
            End Get
            Set(ByVal value As String)
                Me.txtEstado.Text = value
            End Set
        End Property
        Private Property FechaIngreso() As String
            Get
                Return Me.txtFechaIngresoPenal.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaIngresoPenal.Text = value
            End Set
        End Property
        Private Property CodigoMarcacion() As String
            Get
                Return Me.lblMarcacionID.Text
            End Get
            Set(ByVal value As String)
                Me.lblMarcacionID.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Asistencia"

        Private Property IDTaller() As Integer
            Get
                Dim value As Integer = -1
                Return Me.cbbTalleres.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTalleres.SelectedValue = value
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
        Private Property FechaInscripcion() As Long = 0
#End Region
#Region "Grilla"
        Private ReadOnly Property GrillaInternoTallerId() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With dgvListarActividades
                        value = .SelectedRows(0).Cells("col_cod").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaMotivoId() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With dgvListarActividades
                        value = .SelectedRows(0).Cells("col_mot_ret_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

#End Region

#Region "Combo"

        Private Sub ComboTaller()
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbTalleres
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = Combo_Talleres(True)
                .SelectedValue = -1
            End With
        End Sub
        Public Function Combo_Talleres(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable

            Bss = New Bussines.Tratamiento.TallerAsistencia.InternoTaller
            Dim objCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            objEnt.InternoID = _IDInterno
            objEnt.RegionID = Me.IDRegion
            objEnt.PenalID = Me._IDPenal
            objentCol = Bss.ListarTaller_v2(objEnt)

            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If

            For Each obj As Entity.Tratamiento.TallerAsistencia.InternoTaller In objentCol
                objDT.Rows.Add(New Object() {obj.CodigoTaller, (obj.NombreTaller).ToUpper})
            Next

            objDT.AcceptChanges()
            Return objDT

        End Function

#End Region
#Region "Listar"

        Private Sub Listar_DataInterno(intInternoID As Integer)

            Dim bss As New Bussines.Tratamiento.TallerAsistencia.InternoTaller
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.InternoTaller

            objEnt.InternoID = intInternoID
            objEnt.RegionID = Me.IDRegion
            objEnt.PenalID = Me._IDPenal
            objEnt = bss.Listar(objEnt)

            If objEnt.InternoID > 0 Then

                With objEnt
                    Me.IDRegion = .RegionID
                    Me.IDPenal = .PenalID
                    Me.CodigoMarcacion = "Codigo de Marcación: " & IIf(.CodigoMarcacionID > 0, .CodigoMarcacionID, "")
                    Me.CodigoInterno = .CodigoRP
                    Me.PrimerApellido = .ApellidoPaterno
                    Me.SegundoApellido = .ApellidoMaterno
                    Me.PreNombres = .Nombres
                    Me.TipoDocumentoNumero = .TipoDocumentoyNumeroDocumento
                    Me.FechaNacimiento = .FechaNacimientoString
                    Me.Edad = .Edad.ToString
                    Me.IDSexo = .SexoID
                    Me.EstadoCivil = .EstadoCivilNombre
                    Me.ValidacionReniec = .EstadoRncID
                    Me.Padre = .NombrePadre
                    Me.Madre = .NombreMadre
                    Me.NacionalidadNombre = .NacionalidadNombre
                    Me.PaisNacimiento = .NacimientoPaisNombre
                    Me.DepartamentoNacimiento = .NacimientoDepartamentoNombre
                    Me.ProvinciaNacimiento = .NacimientoProvinciaNombre
                    Me.DistritoNacimiento = .NacimientoDistritoNombre
                    Me.PenalNombre = .PenalNombre
                    Me.Estado = .EstadoNombre
                    Me.FechaIngreso = .FechaIngresoString
                    Me.FechaInscripcion = .FechaInscripcion
                    With UscFotografia_2v3
                        ._showFotoInternoPrincipal(intInternoID, APPControls.Foto.uscFotografia_2v.enmFotoPerfil.Frontal)
                    End With
                    ListarInternoTalleres(.InternoID)
                End With
            End If

        End Sub

        Private Sub ListarInternoTalleres(intInternoID As Integer)

            Dim bss As New Bussines.Tratamiento.TallerAsistencia.InternoTaller
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol

            objEnt.InternoID = intInternoID
            objEnt.RegionID = Me.IDRegion
            objEnt.PenalID = Me._IDPenal
            objEntCol = bss.ListarTaller_v2(objEnt)

            With dgvListarActividades
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With

        End Sub

        Private Sub BuscarAsistencia()

            bssAsi = New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim ent As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            objentACol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            With ent
                .InternoID = Me._IDInterno
                .CodigoTaller = Me.IDTaller
                .FechaInicioBusqueda = Me.FechaInicio
                .FechaFinBusqueda = Me.FechaFin
                .RegionID = Me.IDRegion
                .PenalID = Me._IDPenal
            End With

            objentACol = bssAsi.ListarAsistenciaInterno(ent)
            ListarFiltroGrilla()

        End Sub

        Private Sub ListarFiltroGrilla()
            Dim ObjCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol

            ObjCol = ListarFiltro(objentACol)
            With Me.dgwListar
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = ObjCol
                lblReg.Text = ObjCol.Count & " Reg. encontrados"
            End With

        End Sub

        Private Function ListarFiltro(objCol As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim objAsistenciaCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim Contador As Integer = 0
            Dim dia As Integer = 0
            Dim diaConse As Integer = 0
            Dim mes As Integer = 0
            Dim anho As Integer = 0

            For Each obj As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objCol
                Dim fec As Date = obj.FechaDate
                dia = CDate(obj.FechaDate).Day
                mes = CDate(obj.FechaDate).Month
                anho = CDate(obj.FechaDate).Year
                If Contador = 0 Then
                    diaConse = dia + 1
                    objAsistenciaCol.Add(obj)
                Else
                    While diaConse < dia
                        objAsistenciaCol.Add(obj)
                        diaConse = diaConse + 1
                    End While
                    objAsistenciaCol.Add(obj)
                    diaConse = diaConse + 1
                End If
                Contador += 1
            Next
            Contador = 0
            Dim objAsistenciaFinalCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            For Each obj As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objAsistenciaCol
                Contador += 1
                'Dim fec As Date = obj.FechaDate
                dia = CDate(obj.FechaDate).Day
                mes = CDate(obj.FechaDate).Month
                anho = CDate(obj.FechaDate).Year
                If Contador = 1 Or diaConse = dia Then
                    obj.Contador = Contador
                    Dim oob As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                    oob.Contador = Contador
                    oob.TallerNombre = obj.TallerNombre
                    oob.Fecha = obj.Fecha
                    oob.HoraEntrada = obj.HoraEntrada
                    oob.HoraSalida = obj.HoraSalida
                    objAsistenciaFinalCol.Add(oob)
                    diaConse = dia + 1
                Else
                    Dim strMes As String = mes
                    If Len(strMes) = 1 Then
                        strMes = "0" & mes
                    End If
                    Dim Fecha As Date = CDate(diaConse & "/" & strMes & "/" & anho)
                    Dim oob As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                    oob.Contador = Contador
                    oob.TallerNombre = obj.TallerNombre
                    oob.MotivoJustificacionID = -1
                    oob.EstadoJustificacion = -1
                    oob.Fecha = Legolas.Components.FechaHora.FechaLong(Fecha)
                    oob.HoraEntrada = "---"
                    oob.HoraSalida = "---"
                    objAsistenciaFinalCol.Add(oob)
                    diaConse = diaConse + 1
                End If
            Next
            Dim Value As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            If ckbSinsalida.Checked = False Then
                Return objAsistenciaFinalCol
            End If
            For Each obj As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objAsistenciaFinalCol
                'Filtra por codigo de interno            
                If (obj.HoraSalida.Trim = "00:00:00" Or obj.HoraSalida.Trim = "0" Or obj.HoraSalida.Length = 0) Then
                    Value.Add(obj)
                End If
            Next

            Return objAsistenciaCol

        End Function
#End Region

#Region "Otros"
      
        Private Sub ValoresDefault()

            UscFotografia_2v3._CheckImagen = True
            UscFotografia_2v3._PanelCheck = False

            Dim lngFecha As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong

            Me.FechaInicio = Legolas.Components.FechaHora.FechaPrimerDiaMes(lngFecha)
            Me.FechaFin = Legolas.Components.FechaHora.FechaUltimoDiaMes(lngFecha)

        End Sub

        Private Sub UsuarioPermisos()

            Me.pnlRetirar.Visible = Me._FormEscritura
            Me.pnlReporte.Visible = Me._FormReporte
            Me.pnlExportar.Visible = False
        End Sub
        Private Sub ALimpiar()

            Me.IDTaller = -1
            Me.FechaInicio = 0
            Me.FechaFin = 0
            Me.ckbSinsalida.Checked = False

        End Sub
#End Region

#Region "Formularios"
        Private Sub frm_Reporte()

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Interno")
                Exit Sub
            End If

            Dim frm As New Tratamiento.TallerAsistencia.Reporte.frmReportePopup
            With frm
                ._FechaIncripcion = Me.FechaInscripcion
                ._RegionId = Me.IDRegion
                ._PenalId = Me.IDPenal
                ._LoadParametros(Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_internoasistencia,
                     Me._IDInterno, getInternoApeNom)
                .ShowDialog()
            End With

        End Sub

        Private Sub frm_RetirarTaller()

            With dgvListarActividades
                If dgvListarActividades.Rows.Count > 0 Then
                    If .SelectedRows(0).Cells("col_est_id").Value = 1 Then

                        frm_Retiro()

                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno ya ha sido retirado del taller actual")
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningun taller disponible")
                End If
            End With

        End Sub
        Private Sub frm_MostrarRetiro()

            With dgvListarActividades
                If dgvListarActividades.Rows.Count > 0 Then
                    If .SelectedRows(0).Cells("col_est_id").Value = 0 Then

                        frm_Retiro()

                    Else
                        Legolas.Configuration.Aplication.MessageBox.Information("El interno se encuentra activo en esta Actividad laboral")
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningun taller disponible")
                End If
            End With

        End Sub

        Private Sub frm_Retiro()

            Dim frm As New Tratamiento.TallerAsistencia.frmRetiroTaller
            With frm
                ._IDInternoTaller = Me.GrillaInternoTallerId
                ._IDMotivoRetiro = Me.GrillaMotivoId
                ._IDInterno = Me._IDInterno
                ._IDRegion = Me.IDRegion
                ._IDPenal = Me._IDPenal
                'permisos
                ._FormEscritura = Me._FormEscritura
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarInternoTalleres(Me._IDInterno)
                End If

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

        Private Sub frmTallerAsistencia_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Listar_DataInterno(Me._IDInterno)
            UsuarioPermisos()

        End Sub

        Private Sub dgwListar_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwListar.CellFormatting
            'With Me.dgwListar
            '    Select Case e.ColumnIndex
            '        Case .Columns("col_fec_asi").Index
            '            If IsNumeric(e.Value) And e.Value > 1 Then
            '                e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
            '            Else
            '                e.Value = ""
            '            End If
            '    End Select
            'End With
        End Sub

        Private Sub tcInternos_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tcInternos.SelectedIndexChanged

            Select Case Me.tcInternos.SelectedTab.Name
                Case Me.tpDatosPersonales.Name
                    Listar_DataInterno(Me._IDInterno)
                    pnlRetirar.Visible = _FormEscritura
                    pnlExportar.Visible = False
                Case Me.tpControlAsistencia.Name
                    gbCabecera.Text = getInternoApeNom
                    ComboTaller()
                    BuscarAsistencia()
                    pnlRetirar.Visible = False
                    pnlExportar.Visible = _FormReporte
            End Select
        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            BuscarAsistencia()
        End Sub

        Private Sub btnRetirar_Click(sender As System.Object, e As System.EventArgs) Handles btnRetirar.Click
            frm_RetirarTaller()
        End Sub

        Private Sub ckbSinsalida_Click(sender As Object, e As System.EventArgs) Handles ckbSinsalida.Click

            ListarFiltroGrilla()

        End Sub

        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click

            ALimpiar()

        End Sub

        Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
            If Legolas.Configuration.Aplication.MessageBox.Question("Desea exportar el archivo a excel") = Windows.Forms.DialogResult.Yes Then
                Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwListar)
            End If
        End Sub


        Private Sub dgvListarActividades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarActividades.CellDoubleClick
            frm_MostrarRetiro()
        End Sub

        Private Sub Label4_Click(sender As Object, e As EventArgs)
        End Sub

        Private Sub dgvListarActividades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarActividades.CellContentClick

        End Sub

        Private Sub tcInternos_HandleDestroyed(sender As Object, e As EventArgs) Handles tcInternos.HandleDestroyed

        End Sub

        Private Sub dgwListar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwListar.CellContentClick

        End Sub
    End Class
End Namespace