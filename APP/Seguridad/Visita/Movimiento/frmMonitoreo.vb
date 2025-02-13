Namespace Visita.Movimiento
    Public Class frmMonitoreo
        Private objBss As Bussines.Visita.Movimiento = Nothing
        Private objEntCol As Entity.Visita.MovimientoCol = Nothing
#Region "Propiedades_Buscar"
        Private ReadOnly Property RegionID() As Integer
            Get

                Return Me.UsrRegionPenal1._RegionID
            End Get

        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.UsrRegionPenal1._RegionNombre
            End Get
        End Property
        Private ReadOnly Property PenalID() As Integer
            Get

                Return Me.UsrRegionPenal1._PenalID
            End Get

        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.UsrRegionPenal1._PenalNombre
            End Get
        End Property
        Private ReadOnly Property TipoFechaUnica() As Boolean
            Get
                Dim blnValue As Boolean = False

                If Me.rdbFechaUni.Checked = True Then
                    blnValue = True
                End If
                Return blnValue
            End Get
        End Property
        Private Property FechaInicio() As Long
            Get
                Dim lngValue As Long = 0

                If Me.TipoFechaUnica = True Then
                    lngValue = Me.dtpFecha.ValueLong
                Else
                    lngValue = Me.dtpFechaIni.ValueLong
                End If

                Return lngValue
            End Get
            Set(ByVal value As Long)

                If Me.TipoFechaUnica = True Then
                    Me.dtpFecha.ValueLong = value
                Else
                    Me.dtpFechaIni.ValueLong = value
                End If
            End Set

        End Property
        Private Property FechaFin() As Long
            Get
                Dim lngValue As Long = 0

                If Me.TipoFechaUnica = True Then
                    lngValue = Me.dtpFecha.ValueLong
                Else
                    lngValue = Me.dtpFechaFin.ValueLong
                End If

                Return lngValue

            End Get
            Set(ByVal value As Long)

                If Me.TipoFechaUnica = True Then
                    Me.dtpFecha.ValueLong = value
                Else
                    Me.dtpFechaFin.ValueLong = value
                End If

            End Set
        End Property
        Private Property EstadoMovimiento() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbSinSal.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbConSal.Checked = True Then
                    intValue = 2
                End If

                If Me.rdbTodos.Checked = True Then
                    intValue = -1
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case -1
                        Me.rdbTodos.Checked = True
                    Case 1
                        Me.rdbSinSal.Checked = True
                    Case 2
                        Me.rdbConSal.Checked = True
                End Select
            End Set
        End Property
        Private Property MenoresTipo() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rb_menor_adulto.Checked = True Then
                    intValue = 1
                End If

                If Me.rb_menor_menor.Checked = True Then
                    intValue = 2
                End If

                If Me.rb_menor_todos.Checked = True Then
                    intValue = -1
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case -1
                        Me.rb_menor_todos.Checked = True
                    Case 1
                        Me.rb_menor_adulto.Checked = True
                    Case 2
                        Me.rb_menor_menor.Checked = True
                End Select
            End Set
        End Property

        Private Property VisitanteTipoDocumentoID() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property VisitaNumeroDoc() As String
            Get
                Return Me.txtVisNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVisNumDoc.Text = value
            End Set
        End Property
        Private Property VisitaApeNom() As String
            Get
                Return Me.txtVisApeNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVisApeNom.Text = value
            End Set
        End Property

        Private Property PaseNumero() As String
            Get
                Return Me.txtpasenumero.Text
            End Get
            Set(ByVal value As String)
                Me.txtpasenumero.Text = value
            End Set
        End Property
        Private ReadOnly Property MenoresCantidad() As Integer
            Get
                Dim intValue As Integer = 0

                If Me.chk_visitante_menor.Checked Then
                    intValue = 1
                End If
                Return intValue
            End Get

        End Property

        Private Property InternoNumeroDoc() As String
            Get
                Return Me.txtIntNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntNumDoc.Text = value
            End Set
        End Property
        Private Property InternoApeNom() As String
            Get
                Return Me.txtIntApeNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntApeNom.Text = value
            End Set
        End Property

        Private Property TipoParentesco As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbParentesco.Checked = True Then
                    value = 1
                End If

                If Me.rdbTipoVisita.Checked = True Then
                    value = 2
                End If
                Return value
            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbParentesco.Checked = True
                    Case 2
                        Me.rdbTipoVisita.Checked = True
                    Case Else
                        Me.rdbParentescoTodos.Checked = False
                End Select

            End Set
        End Property
        Private Property Parentesco() As Integer
            Get
                Return Me.cbbParentesco.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbParentesco.SelectedValue = value
            End Set
        End Property
        Private Property RegimenVisiatID() As Short
            Get
                Return Me.cbbTipoRegimen.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbTipoRegimen.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaMovimientoID() As Long
            Get
                Dim value As Long = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_mov_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaMovimientoIDPadre() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_mov_id_pdr").Value '
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaIDPenal() As Integer
            Get
                Dim value As Long = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaIDRegion() As Integer
            Get
                Dim value As Long = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaTipoInterno() As Short
            Get
                Dim value As Short = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_tip_int").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaInternoID() As Long
            Get
                Dim value As Long = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaIDInternoPJ() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_int_id_pj").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaInternoApeNom() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_int_ape_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaVisitanteID() As Long
            Get
                Dim value As Long = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_vis_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaVisitanteApeNom() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_vis_ape_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaFotoVisitante() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwMovi
                        strValue = .SelectedRows(0).Cells("col_fot_vis").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaMenorTipo() As Integer
            Get
                Dim value As String = ""
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_men_tip").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private Sub GrillaCount(ByVal RowCount As Integer)

            Dim strValue As String = ""
            Dim intValue As Integer = 0

            intValue = RowCount
            Me.lblReg.Text = intValue & " Reg."

        End Sub

#End Region
#Region "Combo"
        Private Sub ComboRegionPenal()

            With Me.UsrRegionPenal1                
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._LoadUsc()
            End With

        End Sub
        Private Sub ComboTipoDoc()

            With Me.cbbTipoDoc
                .ComboTipo = Type.Combo.ComboTipo.TipoDoc
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboParentesco()

            With Me.cbbParentesco
                If Me.TipoParentesco = -1 Then
                    ._Todos = True
                Else
                    ._Todos = False
                End If
                .ComboTipo = Type.Combo.ComboTipo.Parentesco
                .CodigoPadre = Me.TipoParentesco
                .LoadUsc()
            End With
        End Sub

        Private Sub ComboRegimenVisita()

            Dim objBss As New Bussines.General.Parametrica
            Dim objEntCol As New Entity.General.ParametricaCol
            Dim objEntColCombo As New Entity.General.ParametricaCol

            Dim blnRegimenEspe As Boolean = False
            Dim blnAddEnt As Boolean = False

            Listar_Config_Visita()

            If Me.Config_RegimenVisitaID = 2 Or Me.Config_RegimenVisitaID = 3 Then
                blnRegimenEspe = True
            End If

            objEntCol = objBss.Listar(Type.Combo.ComboTipo.VIS_RegimenVisita, -1, -1, -1, True, "[Todos]")

            For Each obj As Entity.General.Parametrica In objEntCol
                Select Case obj.Codigo
                    Case -1, 1, 4
                        blnAddEnt = True

                    Case Type.Enumeracion.Visita.RegimenVisita.PoderJudicial

                        If Me.Config_HabilitarInternoPJ = True Then
                            blnAddEnt = True
                        End If

                    Case 2, 3
                        If blnRegimenEspe = True Then
                            blnAddEnt = True
                        End If
                End Select

                If obj.Codigo <> 3 Then
                    If blnAddEnt = True Then
                        objEntColCombo.Add(obj)
                        blnAddEnt = False
                    End If
                End If

            Next

            With Me.cbbTipoRegimen
                .DataSource = objEntColCombo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub
#End Region
#Region "Listar"
        Private Function ValidarBusqueda() As Boolean

            Dim value As Boolean = False

            If Me.TipoFechaUnica = False Then

                '/*validar fecha inicio
                If Me.FechaInicio = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese fecha inicio")
                    Me.dtpFechaIni.Focus()
                    Return value
                End If

                '/*validar fecha fin*/
                If Me.FechaFin = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese fecha fin")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If

                '/*'fecha fin, no puede ser menor a la fecha de inicio*/
                If Me.FechaFin < Me.FechaInicio Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "La fecha final es menor a la fecha inicio, cambie las fechas")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If

            End If

            value = True

            Return value
        End Function
        Private Function Listar() As Boolean

            Dim blnValue As Boolean = False

            objBss = New Bussines.Visita.Movimiento
            objEntCol = New Entity.Visita.MovimientoCol

            Dim objEntFiltro As New Entity.Visita.Movimiento

            With objEntFiltro
                '/*visita*/             
                .VisitanteTipoDocumento = Me.VisitanteTipoDocumentoID
                .VisitanteNumeroDocumento = Me.VisitaNumeroDoc
                .VisitanteApellidosyNombres = Me.VisitaApeNom
                '/*interno*/                
                .InternoNumeroDocumento = Me.InternoNumeroDoc
                .InternoApellidosyNombres = Me.InternoApeNom
                ''/*movimiento
                .FechaInicio = Me.FechaInicio
                .FechaFin = Me.FechaFin
                .MenoresCantidad = Me.MenoresCantidad
                .MenoresTipo = Me.MenoresTipo
                .EstadoID = Me.EstadoMovimiento
                .ParentescoID = Me.Parentesco
                .PaseNumero = Me.PaseNumero
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .RegimenVisitaID = Me.RegimenVisiatID
            End With

            objEntCol = objBss.ListarGrillaMonitoreo(objEntFiltro)

            With Me.dgwMovi
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol

                GrillaCount(.RowCount)

                If .RowCount > 0 Then
                    .SelectedRows(0).Selected = False
                End If
            End With

            blnValue = True

        End Function
        Private Sub Buscar()

            Me.col_fec_ing.Tag = "fecha"
            Me.col_fec_sal.Tag = "fecha"
            Me.col_fec_cre.Tag = "fecha"
            Me.col_ico_nin_men.Tag = "image"

            Select Case Me.EstadoMovimiento
                Case 1
                    Me.col_hor_sal.Visible = False
                    Me.col_fec_sal.Visible = False
                    Me.col_min_per.Visible = False
                Case Else
                    Me.col_hor_sal.Visible = True
                    Me.col_fec_sal.Visible = True
                    Me.col_min_per.Visible = True
            End Select

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            Listar()

        End Sub
#End Region
#Region "Accion"
        Public Sub AExportar()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwMovi)
            'Legolas.Components.ExportarGrillaExcel.Exportar_Excel(Me.dgwMovi)
        End Sub
#End Region
#Region "Form"
        Private intCountfrmDetalle As Integer = 0
        Private Sub FRM_VerMovimiento()

            If Me.GrillaMovimientoID < 1 Then
                MessageBox.Show("Seleccione registro a ver el detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lngMovimientoID As Long = -1
            Dim lngMovimientoIDPadre As Long = -1
            Dim lngVisitanteID As Integer = -1

            Dim intTipoInterno As Short = -1
            Dim lngInternoID As Long = -1
            Dim intIDInternoPJ As Integer = -1

            'movimiento id
            If Me.GrillaMovimientoIDPadre > 0 And Me.GrillaMenorTipo = 2 Then 'menores de edad

                lngMovimientoID = Me.GrillaMovimientoIDPadre
                objBss = New Bussines.Visita.Movimiento
                Dim objEnt As New Entity.Visita.Movimiento

                objEnt = objBss.Listar(lngMovimientoID)

                lngVisitanteID = objEnt.VisitaID

                intTipoInterno = objEnt.TipoInterno
                lngInternoID = objEnt.InternoID
                intIDInternoPJ = objEnt.IDInternoPJ

            Else
                lngMovimientoID = Me.GrillaMovimientoID
                lngVisitanteID = Me.GrillaVisitanteID

                intTipoInterno = Me.GrillaTipoInterno
                lngInternoID = Me.GrillaInternoID
                intIDInternoPJ = Me.GrillaIDInternoPJ

            End If

            'movimiento padre
            Select Case Me.GrillaMenorTipo
                Case 1 'adulto
                    If Me.GrillaMovimientoIDPadre > 0 Then
                        lngMovimientoIDPadre = Me.GrillaMovimientoIDPadre
                    Else
                        lngMovimientoIDPadre = Me.GrillaMovimientoID
                    End If
                Case 2 'menor
                    If Me.GrillaMovimientoIDPadre > 0 Then
                        lngMovimientoIDPadre = Me.GrillaMovimientoIDPadre
                    End If
            End Select

            'validar
            If lngMovimientoID < 1 And lngVisitanteID < 1 Then
                Exit Sub
            End If

            Dim frm As New Visita.Movimiento.frmDetalle
            With frm
                ._MovimientoID = lngMovimientoID
                ._MovimientoPadreID = lngMovimientoIDPadre
                ._VisitanteID = lngVisitanteID

                ._TipoInterno = intTipoInterno
                ._InternoID = lngInternoID
                ._IDInternoPJ = intIDInternoPJ

                ._RegionID = Me.GrillaIDRegion
                ._PenalID = Me.GrillaIDPenal
                'Config.AbrirFormulario(frm, MDIParent1)
                .MdiParent = Me.MdiParent
                intCountfrmDetalle += 1
                .Text = .Text & " " & intCountfrmDetalle
                .Show()
            End With

        End Sub
        Private Sub FRM_Pendientes()

            'verificar si hay movimientos de visitas sin salida
            Dim frm As New Visita.frmVisitaSinSalidaPopup
            With frm
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._BuscarAuto = True
                ._Mensaje = True
                ._FormEscritura = Me._FormEscritura
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Reporte"
        Private Sub AReporte()

            If Me.PenalID < 1 Then
                MessageBox.Show("Seleccione Penal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim frm As New Visita.Movimiento.frmReportePopup_v2
            With frm
                ._IDRegion = Me.RegionID
                ._IDPenal = Me.PenalID
                ._FechaInicio = Me.FechaInicio
                ._FechaFin = Me.FechaFin
                ._IDInternoSelect = Me.GrillaInternoID
                ._InternoApeNombres = Me.GrillaInternoApeNom
                ._IDVisitanteSelect = Me.GrillaVisitanteID
                ._VisitanteApeNombres = Me.GrillaVisitanteApeNom
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Permisos/Accesos"
        Private Property Config_RegimenVisitaID As Short = -1
        Private Property Config_HabilitarInternoPJ As Boolean = False

        Private Sub Listar_Config_Visita()

            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As New Entity.Visita.Config

            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .Estado = 1 'alta
            End With

            objEnt = objBss.ListarConfigActual(objEntFiltro)

            If Not objEnt Is Nothing Then
                With objEnt
                    Me.Config_RegimenVisitaID = .RegimenTipoID
                    Me.Config_HabilitarInternoPJ = .HabilitarInternosPJ
                End With
            Else
                Me.Config_RegimenVisitaID = -1
                'Me.RegimenTipoNombre = "Regimen Ordinario"                
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permisos()

            Dim blnEscritura As Boolean = False

            Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                Case 1 'sede central
                    If Legolas.Configuration.Usuario.NivelUsuario = Type.Enumeracion.Usuario.EnumTipoUsuario.Nacional Then
                        If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                            blnEscritura = Me._FormEscritura
                        End If
                    End If
                Case Else 'otras licencias
                    blnEscritura = Me._FormEscritura
            End Select

            Me._FormEscritura = blnEscritura
            Me.pnlPendientes.Visible = Me._FormEscritura
            Me.pnlExportar.Visible = Me._FormReporte
            Me.pnlReporte.Visible = Me._FormReporte

        End Sub
        Private Sub ValoresxDefault()

            Usuario_Permisos()
            Me.WindowState = FormWindowState.Maximized

            HabilitarFecha()
            ComboRegionPenal()
            ComboTipoDoc()
            ComboParentesco()
            ComboRegimenVisita()

            Me.FechaInicio = Legolas.Configuration.Aplication.FechayHora.FechaLong
            Me.Focus()

        End Sub
        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String)

            With Me.UscFoto1
                '._TipoImagen = APPControls.Foto.uscFotografia.DirectotioTipo.Visitante
                .SizeMode = PictureBoxSizeMode.Zoom
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub
        Private Sub HabilitarParentesco()

            Me.ComboParentesco()


        End Sub
        Private Sub HabilitarFecha()

            Me.dtpFecha.Enabled = False
            Me.dtpFechaIni.Enabled = False
            Me.dtpFechaFin.Enabled = False

            If Me.rdbFechaUni.Checked = True Then
                Me.dtpFecha.Enabled = True
            Else
                Me.dtpFechaIni.Enabled = True
                Me.dtpFechaFin.Enabled = True
            End If

        End Sub
        Private Sub ListarPermisoPerfil()

            'perfil jefe de grupo
            If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.JefeGrupoSeguridad Then

                Me.rdbFechaUni.Checked = True
                Me.rdbFechaRango.Enabled = False
                HabilitarFecha()

            End If

        End Sub
#End Region

        Private Sub frmMonitoreo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            'Me.WindowState = FormWindowState.Maximized
            ValoresxDefault()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            AExportar()
        End Sub

        Private Sub btnSalirBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirBusqueda.Click

            Me.Close()

        End Sub

        Private Sub dgwMovi_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellClick

            Try
                With Me.dgwMovi
                    If e.RowIndex = -1 And e.ColumnIndex <> .Columns("col_ico_nin_men").Index Then
                        .Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If

                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwMovi_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellDoubleClick

            If Me.dgwMovi.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_VerMovimiento()
            End If

        End Sub

        Private Sub dgwMovi_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellEnter

            If Me.dgwMovi.RowCount > 0 Then
                ImagenFotoVisitante(Me.GrillaFotoVisitante)
            End If

        End Sub

        Private Sub dgwMovi_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwMovi.CellFormatting

            With Me.dgwMovi
                Select Case e.ColumnIndex
                    Case .Columns("col_fec_ing").Index, .Columns("col_fec_sal").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If

                    Case .Columns("col_fec_cre").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If

                    Case .Columns("col_edad").Index

                        If .Rows(e.RowIndex).Cells("col_fec_nac_vis").Value > 0 Then
                            e.Value = e.Value
                        Else
                            e.Value = ""
                        End If

                End Select

            End With

        End Sub
        Private Sub txtVisNumDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
      txtVisNumDoc.KeyPress, _
      txtVisApeNom.KeyPress, _
      txtIntNumDoc.KeyPress, _
      txtIntApeNom.KeyPress, _
      txtpasenumero.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub
        Private Sub rdbFechaUni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbFechaUni.Click, _
     rdbFechaRango.Click

            HabilitarFecha()

        End Sub
        Private Sub rdbSinSal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
     rdbSinSal.Click, _
     rdbConSal.Click, _
     rdbTodos.Click

            Buscar()

        End Sub
        Private Sub UscFoto1__CheckClick() Handles UscFoto1._CheckClick

            ImagenFotoVisitante(Me.GrillaFotoVisitante)

        End Sub
        Private Sub rdbParentesco_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
           Handles rdbParentesco.Click, _
            rdbTipoVisita.Click, _
             rdbParentescoTodos.Click

            HabilitarParentesco()

        End Sub

        Private Sub btnPendientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPendientes.Click

            FRM_Pendientes()

        End Sub

        Private Sub btnVerMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerMov.Click

            FRM_VerMovimiento()

        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click

            AReporte()

        End Sub

        Private Sub frmMonitoreo_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarPermisoPerfil()

        End Sub

        Private Sub rdbFechaUni_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbFechaUni.CheckedChanged

        End Sub

        Private Sub pbLeyenda_Click(sender As System.Object, e As System.EventArgs) Handles pbLeyenda.Click

            Dim frm As New Visita.Movimiento.frmLeyendaMovimientoPopup
            frm.ShowDialog()

        End Sub

        Private Sub UsrRegionPenal1__PenalSelectedIndexChanged() Handles UsrRegionPenal1._PenalSelectedIndexChanged

            ComboRegimenVisita()

        End Sub

        Private Sub UsrRegionPenal1_Load(sender As System.Object, e As System.EventArgs) Handles UsrRegionPenal1.Load

        End Sub
    End Class
End Namespace