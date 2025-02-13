Option Explicit On

Imports APPControls.Tratamiento.Asistencia.Clasificacion.Penal
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Registro.Carceleta.Clasificacion
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Imports Type.Enumeracion.Clasificacion
Imports Type.Enumeracion.Usuario

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class uscFichaClasificacionEtapaProv_v2
        Private Property TIPO_PROCESO_CLASIF As String = "" 'PC=Proceso completo (regimen y etapa)

        Private objBssInternoPabellon As InternoPabellon_BL = Nothing

        Private intAmbitoClasificacion As Short = 2 'Establecimiento Penitenciario
        Private blnClickGrillaFicha As Boolean = False
        Private bListadoIniciado As Boolean = False 'artificio para controlar lo anterior

#Region "Eventos"
        Public Event GrillaFicha_CellEnter(intCodigo As Integer, TipoTablaAudit As Type.Enumeracion.Auditoria.EnumTipTabla)
        Public Event GrillaFichaVariable_CellClick(objEnt As DatosFicha)
        Public Event Reporte_Click(intIDInternoFichaFinal As Integer, objFichaTab As EnmFichaTab)
#End Region

#Region "Enum"
        Public Enum EnmFichaTab As Short
            enmNinguno = -1
            enmRegimen = 1
            enmEtapa = 2
        End Enum

        Public Enum EnmFichaClasificar As Short
            enmRegimen = 5
            enmEtapaOrdinario = 6
            enmEtapaEspecial = 7
        End Enum
        Private Enum EnmFichaResultado As Short
            enmRegimen = 12
            enmEtapaOrdinario = 13
            enmEtapaEspecial = 14
        End Enum
        Private Enum EnmTipoRegimen As Short
            Ordinario = 1
            Especial = 2
        End Enum
        Private Enum EnmFichaEstado As Short
            Pendiente = 0
            Finalizado = 1
        End Enum
        Private Enum EnmInternoPabellonEstado As Short
            Pendiente = 1
            Finalizado = 2
        End Enum
#End Region

#Region "Propiedades_Publicas"
        Public Property _IDInterno As Integer = -1
        Public Property _InternoApeNom As String = ""
        Public Property _IDIngresoInpe As Integer = -1
        Public Property _IDIngreso As Integer = -1
        Public Property _InternoEstado As Short = -1
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
#End Region

#Region "Propiedades_Privadas"
        Private ReadOnly Property FechaHoraClasificacionRegimen As Long
            Get
                Dim value As Long = 0
                If dtpFechaRegimen.ValueLong > 0 Then
                    Dim dteFecha As Date = Me.dtpFechaRegimen.Value & " " & dtpHoraETAPA.Value.ToString("HH:mm") & ":00"
                    value = dteFecha.ToFileTime
                Else
                    dtpHoraETAPA.Value = DateTime.Today
                End If

                Return value
            End Get
        End Property
        Public Property IDPabellon As Integer = -1
        Private Property FichaClasificar As EnmFichaClasificar = EnmFichaClasificar.enmRegimen
        Private Property IDInternoPabellon As Integer = -1
        Private Property NumeroClasificacion() As Integer
            Get
                Return Integer.Parse(Me.txtNumClasif.Text)
            End Get
            Set(value As Integer)
                Me.txtNumClasif.Text = value.ToString
            End Set
        End Property
        Private Property FechaClasificacionRegimen() As Long
            Get
                Return dtpFechaRegimen.ValueLong
            End Get
            Set(value As Long)
                dtpFechaRegimen.ValueLong = value
            End Set
        End Property

        Private ReadOnly Property FechaHoraClasificacionCadena As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaHoraClasificacionRegimen, True)
            End Get
        End Property
        Private Property IDSituacionJuridica() As Short
            Get
                Return Me.cbbSitJuridica.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbSitJuridica.SelectedIndex = value
            End Set
        End Property
        Private ReadOnly Property SituacionJuridica As String
            Get
                Return Me.cbbSitJuridica.Text.ToUpper
            End Get
        End Property
        Private Property IDRegimen() As Short
            Get
                Return Me.cbbRegimen.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbRegimen.SelectedIndex = value
            End Set
        End Property
        Private Property Estado As Short = -1
        Private Property VerFichaLegal As Boolean = False
        Private Property VerFichaPsicologica As Boolean = False
        Private Property VerFichaSocial As Boolean = False
        Private Property VerFichaFinal As Boolean = False
#Region "Ficha"
        Private ReadOnly Property FichaGrupo As Short
            Get
                Return Me.FichaClasificar
            End Get
        End Property
        Private ReadOnly Property FichaResultado As EnmFichaResultado
            Get
                Dim value As EnmFichaResultado = -1

                Select Case Me.FichaClasificar
                    Case EnmFichaClasificar.enmRegimen
                        value = EnmFichaResultado.enmRegimen

                    Case EnmFichaClasificar.enmEtapaOrdinario
                        value = EnmFichaResultado.enmEtapaOrdinario

                    Case EnmFichaClasificar.enmEtapaEspecial
                        value = EnmFichaResultado.enmEtapaEspecial
                End Select

                Return value
            End Get

        End Property
        Private Property FichaNumeroClasificacion() As String
            Get
                Return Me.txtFichaNumClasifi.Text
            End Get
            Set(value As String)
                Me.txtFichaNumClasifi.Text = value
            End Set
        End Property

        Private Property FichaSituacionJuridica As String
            Get
                Return Me.lblSituacionJuridica.Text
            End Get
            Set(value As String)
                Me.lblSituacionJuridica.Text = value
            End Set
        End Property
        Private Property FichaFechaClasificacion As String
            Get
                Return Me.lblFichaFechaClasi.Text
            End Get
            Set(value As String)
                Me.lblFichaFechaClasi.Text = value
            End Set
        End Property
        Private Property FichaPuntaje() As String
            Get
                Return txtPuntTotal.Text
            End Get
            Set(value As String)
                txtPuntTotal.Text = value
            End Set
        End Property
        Private Property FichaObservacion() As String
            Get
                Return txtobservacion.Text
            End Get
            Set(value As String)
                txtobservacion.Text = value
            End Set
        End Property
        Private Property FichaResultadoNombre As String
            Get
                Return Me.lblEtiquetaResul.Text.ToUpper
            End Get
            Set(value As String)
                Me.lblEtiquetaResul.Text = value.ToUpper
            End Set
        End Property
        Private Property FichaResultadoID As Short = -1
        Private Property FichaResultadoValor As String
            Get
                Return Me.lblResultado.Text.ToUpper
            End Get
            Set(value As String)
                Me.lblResultado.Text = value.ToUpper
            End Set
        End Property
#End Region
#End Region

#Region "Propieades_GrillaFicha"

        Private ReadOnly Property GrillaFichaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = dgwFic.SelectedRows(0).Cells("col_codigo").Value
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDFicha() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    Return dgwFic.SelectedRows(0).Cells("col_fic_id2").Value
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaFichaNombre() As String
            Get
                Dim value As String = ""
                Try
                    value = dgwFic.SelectedRows(0).Cells("col_nom_fic").Value
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property


        Private ReadOnly Property GrillaIDFichaTipo() As Type.Enumeracion.Clasificacion.enmTipoFicha
            Get
                Dim intValue As Integer = -1
                Try
                    Return dgwFic.SelectedRows(0).Cells("tip_fic_id").Value
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFichaEstado() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = dgwFic.SelectedRows(0).Cells("col_estado_id").Value
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFichaEstadoNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    intValue = dgwFic.SelectedRows(0).Cells("col_estado").Value
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFichaNumClasificacion() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = dgwFic.SelectedRows(0).Cells("col_num_clasif").Value
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFechaClasificacion() As String
            Get
                Dim c As String = ""
                Try
                    c = dgwFic.SelectedRows(0).Cells("col_fec_cla").Value
                Catch ex As Exception

                End Try

                Return c
            End Get
        End Property

#End Region

#Region "Propiedades_GrillaVariable"
        Private ReadOnly Property GrillaVariableNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgvVar
                        intValue = .SelectedRows(0).Cells("col_val_nom").Value
                    End With
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
#End Region

#Region "Propiedades_UserControl"
        Public Property _uscFichaTab As EnmFichaTab = EnmFichaTab.enmRegimen
        Public Property _uscPerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia
        Public Property _uscVisibleVariableNoPrevista As Boolean = False
        Public Property _uscEscritura As Boolean = False
        Public Property _uscEliminar() As Boolean = False
        Public Property _uscReporte() As Boolean = False

#End Region

#Region "Combo"

        Private Sub ComboSituacionJuridica()

            With Me.cbbSitJuridica
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Procesado")
                .Items.Add("Sentenciado")
            End With
            Me.IDSituacionJuridica = 0
        End Sub
        Private Sub ComboRegimen()
            With Me.cbbRegimen
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Regimen Cerrado Ordinario - R.C.O.")
                .Items.Add("Regimen Cerrado Especial - R.C.E.")
            End With

        End Sub

        Private Sub CargarCombo()
            ComboSituacionJuridica()
            ComboRegimen()
        End Sub
#End Region

#Region "Listar"

        Public Sub _ListarUsc()
            Me._IDIngresoInpe = -1
            CargarCombo()
            ListarInternoPabellon()
            MostrarControlesFicha()

            'validar los datos del interno 
            If ValidarDatosInterno() = False Then
                Me.pnlBotonesGrilla.Enabled = False
                Me.pnlBotonGrabarFicha.Enabled = False
                Exit Sub
            End If

            ListarGrillaFicha()
            ListarFicha()
            ListarGrillaVariable()

        End Sub
        Private Sub ListarInternoPabellon()

            Dim objEntFiltroInternoPab As New InternoPabellon_BE
            Dim objEntInternoPab As New InternoPabellon_BE

            With objEntFiltroInternoPab
                .IDInterno = Me._IDInterno
                .IDIngreso = Me._IDIngreso
                .IDIngresoInpe = -1 ' Me._IDIngresoInpe
                .Estado = 1 'activo
            End With

            objEntInternoPab = (New InternoPabellon_BL).ListarClasificacionPendiente(objEntFiltroInternoPab)

            If objEntInternoPab IsNot Nothing Then

                Dim dteFecha As Date = Now

                If objEntInternoPab.IDRegimen < 0 Then Exit Sub 'para que obligue agregar etapa mediante el popup

                With objEntInternoPab
                    Me.IDInternoPabellon = .Codigo
                    Me.TIPO_PROCESO_CLASIF = .TipoProcesoClasificacion
                    Me.Estado = .Estado
                    Me.IDSituacionJuridica = .IDSituacionJuridica
                    Me.IDRegimen = .IDRegimen

                    Me.NumeroClasificacion = .NumeroClasificacionEtapa
                    Me.FechaClasificacionRegimen = .FechaClasificacionEtapa
                    dteFecha = Legolas.Components.FechaHora.FechaDate(.FechaClasificacionEtapa, True)

                    If Me.TIPO_PROCESO_CLASIF = "PC" Then

                    Else

                        If Me.TIPO_PROCESO_CLASIF <> "PC" And .Estado <> 2 Then
                            btnNuevo.BackgroundImage = APPControls.My.Resources.Resources._1277961326_folder_edit
                            Me.btnNuevo.Tag = "Editar"
                            ToolTip1.SetToolTip(btnNuevo, "Editar")
                            btnCancelEdit.Visible = False
                            Me.pnlDatosApertura.Enabled = False
                            pnlSituacionJur.Enabled = False
                            pnlRegimen.Enabled = False
                            SplitContainer1.Enabled = True
                        End If
                    End If

                    dtpHoraETAPA.Value = dteFecha
                End With
            Else
                Me.IDInternoPabellon = -1
                Me.NumeroClasificacion = 0
                Me.FechaClasificacionRegimen = 0
                Me.IDSituacionJuridica = -1
                Me.IDRegimen = -1
                Me.Estado = 1
            End If

        End Sub
        Private Sub ListarFicha()
            Me.IDPabellon = -1
            lblPabellon.Text = ""

            If Me.GrillaFichaCodigo > 0 Then

                Dim objEntFiltro As New InternoFicha_BE() With {.Codigo = Me.GrillaFichaCodigo}

                Dim objEnt As InternoFicha_BE = (New InternoFicha_BL).Listar(objEntFiltro).Item(0)

                With objEnt
                    Me.FichaSituacionJuridica = .InternoSituacionJuridicaNombre
                    lblRegimen.Text = .InternoRegimenNombre
                    Me.FichaNumeroClasificacion = .NumeroClasificacion
                    Me.FichaFechaClasificacion = DateTime.FromFileTime(.FechaClasificacion).ToString("dd/MM/yyyy hh:mm tt")
                    Me.FichaPuntaje = .Puntaje
                    Me.FichaObservacion = .Observacion

                    rdbOrgCrimSI.Checked = If(.PerteneceOrgCriminal = "S", True, False)
                    rdbOrgCrimNO.Checked = If(.PerteneceOrgCriminal = "N", True, False)

                    'ver el resultado, dependiendo del tab
                    Me.FichaResultadoID = .InternoIDEtapa
                    Me.FichaResultadoValor = .InternoEtapaNombre
                    If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                        Dim entAux As New InternoPabellon_BE With {
                        .IDFichaEtapa = Me.GrillaFichaCodigo
                        }
                        Dim ls As List(Of InternoPabellon_BE) = (New InternoPabellon_BL).ListarGrilla(entAux)
                        If ls.Count > 0 Then
                            Me.IDPabellon = ls.Item(0).IDPabellon
                            lblPabellon.Text = ls.Item(0).PabellonNombre
                        End If
                    End If
                End With
            Else
                Me.FichaSituacionJuridica = Me.SituacionJuridica
                lblRegimen.Text = cbbRegimen.Text.ToUpper
                Me.FichaNumeroClasificacion = Me.NumeroClasificacion
                Me.FichaFechaClasificacion = DateTime.FromFileTime(Me.FechaHoraClasificacionRegimen).ToString("dd/MM/yyyy hh:mm tt")
                Me.FichaPuntaje = 0
                Me.FichaObservacion = ""
                Me.FichaResultadoValor = ""
                lblPabellon.Text = ""
                Me.IDPabellon = -1
            End If

            'permisos de las fichas 
            Dim blnVerBotonAccionFicha As Boolean = False
            Select Case Me.GrillaIDFichaTipo
                Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                    If Me.VerFichaLegal = True And Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then blnVerBotonAccionFicha = True

                Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                    If Me.VerFichaPsicologica = True And Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then blnVerBotonAccionFicha = True

                Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                    If Me.VerFichaSocial = True And Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then blnVerBotonAccionFicha = True

                Case Type.Enumeracion.Clasificacion.enmTipoFicha.Final
                    If Me.VerFichaFinal = True And Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then
                        blnVerBotonAccionFicha = True
                    End If

            End Select

            If Me._uscPerfilUsuario = EnumDependencia.SistemasInformacion Then
                blnVerBotonAccionFicha = True
            End If

            Me.pnlBotonGrabarFicha.Visible = blnVerBotonAccionFicha
            'Me.pnlSubDetalle.Enabled = blnVerBotonAccionFicha
            Me.gbDatosFicha.Text = "DATOS DE LA FICHA: " & Me.GrillaFichaNombre

            txtobservacion.Enabled = blnVerBotonAccionFicha
            btnBuscarPabellon.Enabled = blnVerBotonAccionFicha


        End Sub

        Private Function ListarGrillaFichaEtapa() As List(Of InternoFicha_BE)

            Dim objEntCol As New List(Of InternoFicha_BE)

            'consultar si el interno, tiene fichas registradas en la bd            
            Dim objEntColBDFinalizado As List(Of InternoFicha_BE) = (New InternoFicha_BL()).ListarGrillaEtapa(New InternoFicha_BE() With {
                                                             .IDInterno = Me._IDInterno,
                                                             .IDInternoIngreso = Me._IDIngreso,
                                                             .IDInternoIngresoInpe = Me._IDIngresoInpe,
                                                             .IDRegion = Me._IDRegion,
                                                             .IDPenal = Me._IDPenal
                                                             }) 'fichas del interno

            If Me.IDRegimen > 0 And Estado = EnmInternoPabellonEstado.Pendiente Then

                Select Case Me.IDRegimen
                    Case EnmTipoRegimen.Ordinario
                        Me.FichaClasificar = EnmFichaClasificar.enmEtapaOrdinario

                    Case EnmTipoRegimen.Especial
                        Me.FichaClasificar = EnmFichaClasificar.enmEtapaEspecial
                End Select

                'listar los registros con el regimen del combo

                Dim objEntColBD As List(Of InternoFicha_BE) = (New InternoFicha_BL()).ListarGrilla(New InternoFicha_BE() With {
                                                                  .IDInterno = Me._IDInterno,
                                                                  .IDInternoIngreso = Me._IDIngreso,
                                                                  .IDInternoIngresoInpe = Me._IDIngresoInpe,
                                                                  .IDRegion = Me._IDRegion,
                                                                  .IDPenal = Me._IDPenal,
                                                                  .FichaGrupo = Me.FichaGrupo
                                                                }) 'fichas del interno

                'listar las fichas de las plantillas en funcion a la cantidad de clasificaciones del interno ------------>.
                Dim objEntFiltroFicha As New MaestroFicha_BE

                objEntFiltroFicha.AmbitoClasificacionId = intAmbitoClasificacion
                objEntFiltroFicha.GrupoSecuencial = Me.FichaGrupo
                If objEntColBD.Count = 0 Then 'si es nuevo listar solo el activo
                    objEntFiltroFicha.EstadoId = 1
                End If

                'fichas plantilla original
                Dim objEntColFichaMaestras As MaestroFichaCol_BE = (New Bussines.Clasificacion.MaestroFicha).Listar(objEntFiltroFicha)

                Dim objEntFichaMaestrasTemporalCol As New MaestroFichaCol_BE 'agrupa todas las fichas plantillas

                For Each objFila As MaestroFicha_BE In objEntColFichaMaestras
                    objEntFichaMaestrasTemporalCol.Add(New MaestroFicha_BE() With {
                                                       .NumeroClasificacion = Me.NumeroClasificacion,
                                                       .Codigo = objFila.Codigo,
                                                       .Nombre = objFila.Nombre,
                                                       .TipoFichaId = objFila.TipoFichaId
                                                       })
                Next

                'cargar las fichas, del numero actual de clasificacion                
                For Each objFilaFicha As MaestroFicha_BE In objEntFichaMaestrasTemporalCol

                    Dim objEnt As New InternoFicha_BE With {
                        .IDFicha = objFilaFicha.Codigo,
                        .NumeroClasificacion = objFilaFicha.NumeroClasificacion,
                        .FichaNombre = objFilaFicha.Nombre, 'TipoFichaNombre
                        .IDFichaTipo = objFilaFicha.TipoFichaId
                    }

                    For Each objFilaBD As InternoFicha_BE In objEntColBD
                        If objFilaFicha.Codigo = objFilaBD.IDFicha = True And objFilaFicha.NumeroClasificacion = objFilaBD.NumeroClasificacion Then
                            objEnt.Codigo = objFilaBD.Codigo
                            objEnt.NumeroClasificacion = objFilaBD.NumeroClasificacion
                            objEnt.FechaClasificacion = objFilaBD.FechaClasificacion
                            objEnt.Puntaje = objFilaBD.Puntaje
                            objEnt.Estado = objFilaBD.Estado
                            objEnt.Observacion = objFilaBD.Observacion
                            objEnt.InternoIDSituacionJuridica = objFilaBD.InternoIDSituacionJuridica
                            Exit For
                        End If
                    Next
                    objEntCol.Add(objEnt)
                Next

            End If

            Dim objLista As New List(Of InternoFicha_BE)

            For Each objFila As InternoFicha_BE In objEntColBDFinalizado
                objLista.Add(objFila)
            Next

            For Each objFila As InternoFicha_BE In objEntCol
                objLista.Add(objFila)
            Next

            Return objLista
        End Function
        Private Sub ListarGrillaFicha()

            If Me._IDInterno < 1 Then Exit Sub

            Dim objEntCol As New List(Of InternoFicha_BE)

            objEntCol = ListarGrillaFichaEtapa()

            Me.bListadoIniciado = True 'artificio para controlar que se llame dgwGrillaFicha.CellEnter
            With Me.dgwFic
                .RowCount = objEntCol.Count
                For f As Integer = 0 To objEntCol.Count - 1
                    .Item("col_codigo", f).Value = objEntCol.Item(f).Codigo
                    .Item("tip_fic_id", f).Value = objEntCol.Item(f).IDFichaTipo
                    .Item("col_fic_id2", f).Value = objEntCol.Item(f).IDFicha
                    .Item("col_nom_fic", f).Value = objEntCol.Item(f).FichaNombre
                    .Item("col_fec_cla", f).Value = objEntCol.Item(f).FechaClasificacionString
                    .Item("col_num_clasif", f).Value = objEntCol.Item(f).NumeroClasificacion
                    .Item("col_ptje", f).Value = objEntCol.Item(f).Puntaje
                    .Item("col_estado_id", f).Value = objEntCol.Item(f).Estado
                    .Item("col_estado", f).Value = objEntCol.Item(f).EstadoNombre
                Next
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AutoGenerateColumns = False
            End With

            Me.bListadoIniciado = False

            Dim objColorHabilitado As Color = Color.White
            Dim objColorDeshabilitado As Color = Color.Gainsboro

            For Each f As DataGridViewRow In dgwFic.Rows

                f.DefaultCellStyle.BackColor = objColorDeshabilitado

                Select Case f.Cells("tip_fic_id").Value
                    Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                        If Me.VerFichaLegal = True And f.Cells("col_estado_id").Value <> EnmFichaEstado.Finalizado Then f.DefaultCellStyle.BackColor = objColorHabilitado

                    Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                        If Me.VerFichaPsicologica = True And f.Cells("col_estado_id").Value <> EnmFichaEstado.Finalizado Then f.DefaultCellStyle.BackColor = objColorHabilitado

                    Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                        If Me.VerFichaSocial = True And f.Cells("col_estado_id").Value <> EnmFichaEstado.Finalizado Then f.DefaultCellStyle.BackColor = objColorHabilitado

                    Case Type.Enumeracion.Clasificacion.enmTipoFicha.Final
                        If Me.VerFichaFinal = True And f.Cells("col_estado_id").Value <> EnmFichaEstado.Finalizado Then f.DefaultCellStyle.BackColor = objColorHabilitado

                        f.DefaultCellStyle.Font = New Font(Me.dgwFic.DefaultCellStyle.Font, FontStyle.Bold)
                End Select

                Select Case f.Cells("col_estado").Value
                    Case "PENDIENTE"
                        f.Cells("col_estado").Style.ForeColor = Color.Brown
                    Case "FINALIZADO"
                        f.Cells("col_estado").Style.ForeColor = Color.Black
                    Case Else
                        f.Cells("col_estado").Style.ForeColor = Color.Black
                End Select
            Next

            If Me.dgwFic.Rows.Count > 0 Then Me.dgwFic.Rows(0).Selected = True

        End Sub

        Private Sub ListarGrillaVariable()

            If Me.GrillaIDFicha < 1 Then Exit Sub

            Dim objEntFichaInternoDet As New InternoFichaDetalle_BE
            Dim objEnListaFichaInternoDet As New List(Of InternoFichaDetalle_BE)

            Dim objEntListaMaeVariable As New MaestroVariableCol_BE
            Dim objBssMaeIndicador As New Bussines.Clasificacion.MaestroIndicador

            '******************************** cargar detalles  *****************************
            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then

                Me.dgvVar.Visible = False
                Me.pnlSubDetalle.Dock = DockStyle.Fill
                Me.pnlResultadoFicha.Visible = True
                Me.pnlDatosFicha.Dock = DockStyle.Top
                'Me.dgvFichaVariables.Columns("col_buton").Visible = False

            Else
                Me.pnlSubDetalle.Dock = DockStyle.Bottom
                Me.dgvVar.Visible = True
                Me.pnlResultadoFicha.Visible = False
                Me.pnlDatosFicha.Dock = DockStyle.Fill

                objEntFichaInternoDet.IDInternoFicha = Me.GrillaFichaCodigo

                If Me.GrillaFichaCodigo > 0 Then objEnListaFichaInternoDet = (New InternoFichaDetalle_BL()).Listar(objEntFichaInternoDet)

                ''******************************** cargar plantilla ficha **************************
                Dim objEntMaeVariable As New MaestroVariable_BE With {
                    .FichaID = Me.GrillaIDFicha
                }
                objEntListaMaeVariable = (New Bussines.Clasificacion.MaestroVariable()).Listar(objEntMaeVariable)

                ''------- pintar sobre la grilla de la plantilla -------
                Dim entValTmp As MaestroIndicador_BE
                With dgvVar
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = objEntListaMaeVariable
                End With

                For i As Integer = 0 To dgvVar.Rows.Count - 1
                    For Each objDetFin As InternoFichaDetalle_BE In objEnListaFichaInternoDet
                        With dgvVar
                            If .Item("col_mae_var_id", i).Value = objDetFin.IDVariable Then
                                .Item("col_ptje2", i).Value = objDetFin.Ponderacion
                                .Item("col_ptje_noprev", i).Value = objDetFin.PonderacionNoPrevista
                                .Item("col_fic_det_id", i).Value = objDetFin.Codigo
                                entValTmp = New MaestroIndicador_BE
                                entValTmp = objBssMaeIndicador.Listar2(objDetFin.IDIndicador, objDetFin.IDVariable, Me.GrillaIDFicha)
                                If entValTmp IsNot Nothing Then
                                    .Item("col_val_id_sel", i).Value = objDetFin.IDIndicador
                                    .Item("col_valor", i).Value = entValTmp.Descripcion
                                Else
                                    .Item("col_val_id_sel", i).Value = -1
                                End If
                            End If
                        End With
                    Next
                Next
            End If

            For Each f As DataGridViewRow In dgvVar.Rows
                'f.Cells("col_valor").Style.ForeColor = Color.Black '.Green
                f.Cells("col_valor").Style.Font = New Font(dgvVar.Font, FontStyle.Bold)
            Next

            Me.dgvVar.AllowUserToResizeRows = False
            Me.dgvVar.AutoGenerateColumns = False
        End Sub

        Public Sub _ListarFilaVariable(intPuntaje As Short, strNombre As String, intValorIdSeleccionado As Short, intValorNoPrevisto As Short)
            With dgvVar
                .Item("col_val_id_sel", .CurrentRow.Index).Value = intValorIdSeleccionado
                .Item("col_valor", .CurrentRow.Index).Value = strNombre  ' f.ValorNombreSeleccionado
                .Item("col_ptje_noprev", .CurrentRow.Index).Value = intValorNoPrevisto
                .Item("col_ptje2", .CurrentRow.Index).Value = intPuntaje ' f.ValorPuntaje
            End With
            ACalcularPuntajeFicha()
        End Sub

#End Region
#Region "Validar"
        Private Function ValidarDatosInterno() As Boolean

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para completar la acción, guardar los datos básicos del interno.")
                Return False
            End If

            If Me._IDIngreso < 1 And Me._IDIngresoInpe < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningún Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar.")
                Return False
            End If


            If Me._InternoEstado = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del interno se encuentra inactivo.")
                Return False
            End If

            Return True
        End Function

        Private Function ValidarAperturaClasificacion() As Boolean

            If Me.IDInternoPabellon < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Jefe de la Junta de Clasificación, no ha aperturado el registro de clasificación")
                Return False
            End If

            If Me.GrillaFichaEstado = Type.Enumeracion.Clasificacion.enmEstadoRegistroFicha.Finalizado Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha ha sido finalizada, no se puede modificar los datos")
                Return False
            End If

            Return True
        End Function

        Private Function ValidarFicha() As Boolean

            If ValidarAperturaClasificacion() = False Then Return False

            'validar
            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then

                'validar el estado finalizado de las fichas
                For i As Integer = 0 To dgwFic.Rows.Count - 1
                    If dgwFic.Item("tip_fic_id", i).Value <> Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                        If dgwFic.Item("col_estado_id", i).Value <> Type.Enumeracion.Clasificacion.enmEstadoRegistroFicha.Finalizado Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de generar la ficha final, todas las demás fichas deben estar en estado finalizado.")
                            Return False
                        End If
                    End If
                Next
                If rdbOrgCrimSI.Checked = False And rdbOrgCrimNO.Checked = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe indicar si pertenece o no a una organización criminal")
                    Return False
                End If
            Else
                'validar los indicadores de cada variable
                For i As Integer = 0 To dgvVar.Rows.Count - 1

                    Dim strVariable As String = dgvVar.Item("col_val_nom", i).Value.ToUpper
                    Dim strNombreIndicador As String = CType(dgvVar.Item("col_valor", i).Value, String)

                    If strNombreIndicador Is Nothing = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar el indicador correspondiente a la variable " & strVariable)
                        Return False
                    End If
                Next

                'validar puntaje
                If Me.FichaPuntaje < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha seleccionado todos los indicadores de las variables mostradas, verifique los indicadores.")
                    Return False
                End If

            End If

            Return True
        End Function

        Private Function ValidarVariablesSeModifico(intIDFichaCodigo As Integer) As Boolean

            Dim value As Boolean = False

            If intIDFichaCodigo < 1 Then
                For i As Integer = 0 To dgvVar.Rows.Count - 1
                    Dim strVariable As String = dgvVar.Item("col_val_nom", i).Value.ToUpper
                    Dim strNombreIndicador As String = CType(dgvVar.Item("col_valor", i).Value, String)

                    If Not strNombreIndicador Is Nothing = True Then
                        value = True
                        Exit For
                    End If
                Next
            End If

            Return value
        End Function

#End Region
#Region "Accion"
        Private Sub ANuevoGrabar()

            Dim strMensaje As String = ""
            Select Case Me.btnNuevo.Tag.ToString.ToUpper
                Case "Editar".ToUpper
                    If Me.TIPO_PROCESO_CLASIF <> "PC" And isFichaFinalFinalizado() = False Then
                        Dim str As String = "Confirma modificar los datos principales de clasificación a etapa?"
                        If Legolas.Configuration.Aplication.MessageBox.Question(str) <> DialogResult.Yes Then
                            Exit Sub
                        End If

                        ABuscarFichas()

                        If existeFichaFinalizado() = True Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible modificar dado que existen fichas en estado finalizado.")
                            Exit Sub
                        End If

                        btnNuevo.BackgroundImage = APPControls.My.Resources.Resources.Diskette_32x32
                        Me.btnNuevo.Tag = "Grabar"
                        ToolTip1.SetToolTip(btnNuevo, "Grabar")
                        Me.pnlDatosApertura.Enabled = True
                        pnlSituacionJur.Enabled = True
                        pnlRegimen.Enabled = True
                        SplitContainer1.Enabled = False
                        btnCancelEdit.Visible = True
                    End If
                Case "Grabar".ToUpper
                    If Me.TIPO_PROCESO_CLASIF <> "PC" And isFichaFinalFinalizado() = False Then
                        If Me.IDInternoPabellon = -1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno, por favor cierre la ventana y vuelva a cargar nuevamente.")
                            Exit Sub
                        End If
                        'GRABAR debe actualizar todas las fichas relacionadas a la ficha final

                        btnNuevo.BackgroundImage = APPControls.My.Resources.Resources._1277961326_folder_edit
                        Me.btnNuevo.Tag = "Editar"
                        ToolTip1.SetToolTip(btnNuevo, "Editar")
                        Me.pnlDatosApertura.Enabled = False
                        pnlSituacionJur.Enabled = False
                        pnlRegimen.Enabled = False
                        SplitContainer1.Enabled = True

                        Dim objEnt As New InternoPabellon_BE With {
                            .Codigo = Me.IDInternoPabellon,
                            .FechaClasificacionEtapa = Me.FechaHoraClasificacionRegimen,
                            .IDSituacionJuridica = Me.IDSituacionJuridica,
                            .IDRegimen = Me.IDRegimen,
                            .NumeroClasificacionEtapa = txtNumClasif.Text
                        }

                        Dim strMensajeOut As String = ""
                        Dim idTmp As Integer = (New InternoPabellon_BL).ActualizarEtapa(objEnt, strMensajeOut)
                        If idTmp = -1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo actualizar " & strMensajeOut)
                            Exit Sub
                        End If
                        btnCancelEdit.Visible = False

                        lblSituacionJuridica.Text = IIf(Me.IDSituacionJuridica = 1, "PROCESADO", "SENTENCIADO")
                        lblRegimen.Text = cbbRegimen.Text.ToUpper()
                        Me.FichaFechaClasificacion = DateTime.FromFileTime(Me.FechaHoraClasificacionRegimen).ToString("dd/MM/yyyy hh:mm tt")

                        Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria, recomendar a los integrantes de la junta que deben actualizar sus fichas presionando en el botón [Refrescar] para ver los cambios.")
                    End If
                Case "Nuevo".ToUpper
                    'validar si existe ficha pendiente de finalizar caso contrario no permitir continuar
                    Dim objEntInternoPab As New InternoPabellon_BE

                    With objEntInternoPab
                        .IDInterno = Me._IDInterno
                        .IDIngreso = Me._IDIngreso
                        .Estado = 1 'activo
                    End With

                    objEntInternoPab = (New InternoPabellon_BL).ListarClasificacionPendiente(objEntInternoPab)
                    If Not objEntInternoPab Is Nothing Then
                        If objEntInternoPab.IDEtapa = -1 And objEntInternoPab.IDFichaRegimen = -1 And objEntInternoPab.IDRegimen > 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun existe ficha de clasificación pendientes de finalizar, verifique")
                            Exit Sub
                        End If

                        If objEntInternoPab.IDEtapa > 0 And objEntInternoPab.IDFichaRegimen = -1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun existe ficha de clasificación pendientes de finalizar por parte de O.T.T.")
                            Exit Sub
                        End If

                        If objEntInternoPab.IDEtapa = -1 And objEntInternoPab.IDFichaRegimen = -1 Then 'And objEntInternoPab.TipoProcesoClasificacion <> "PC"
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun existe ficha de clasificación pendientes de finalizar, verifique.")
                            Exit Sub
                        End If

                        If objEntInternoPab.IDEtapa = -1 And objEntInternoPab.TipoProcesoClasificacion = "PC" And objEntInternoPab.NumeroClasificacionEtapa > 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun existe ficha de clasificación pendientes de finalizar, verifique.")
                            Exit Sub
                        End If

                        If objEntInternoPab.IDEtapa > 0 And objEntInternoPab.IDFichaRegimen = -1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun existe ficha de clasificación pendientes de finalizar por parte de O.T.T.")
                            Exit Sub
                        End If

                        If objEntInternoPab.IDEtapa > 0 And objEntInternoPab.IDFichaRegimen > -1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun existe ficha de clasificación pendientes de finalizar por parte de O.T.T.")
                            Exit Sub
                        End If

                    End If
                    strMensaje = "Desea habilitar la clasificación de etapa del interno: " & Me._InternoApeNom.ToUpper

                    If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then

                        Dim f As New frmAddClasifEtapaPopupProv
                        f._IDInterno = Me._IDInterno
                        f._IDIngreso = Me._IDIngreso
                        f._IDIngresoInpe = Me._IDIngresoInpe
                        f._IDRegion = Me._IDRegion
                        f._IDPenal = Me._IDPenal
                        If f.ShowDialog = DialogResult.OK Then
                            Me._ListarUsc()

                            'Me.IDInternoPabellon = f.IDInternoPabellon
                            'Me.TIPO_PROCESO_CLASIF = f.TIPO_PROCESO_CLASIF
                            'Me.Estado = f.Estado
                            'Me.IDSitucionJuridica = f.IDSituacionJuridica
                            'Me.IDRegimen = f.IDRegimen

                            'Me.NumeroClasificacion = f.NumeroClasificacion
                            'Me.FechaClasificacionRegimen = f.FechaClasificacionRegimen
                            'Dim dteFecha As Date = Legolas.Components.FechaHora.FechaDate(f.FechaClasificacionRegimen, True)


                            'Me.HoraClasificacion = Format(dteFecha, "HH")
                            'Me.MinutoClasificacion = Format(dteFecha, "mm")

                            ''ListarInternoPabellon()

                            'Select Case Me.IDRegimen
                            '    Case EnmTipoRegimen.Ordinario
                            '        Me.FichaClasificar = EnmFichaClasificar.enmEtapaOrdinario

                            '    Case EnmTipoRegimen.Especial
                            '        Me.FichaClasificar = EnmFichaClasificar.enmEtapaEspecial
                            'End Select

                            'ListarGrillaFicha()
                            'ListarFicha()
                            'ListarGrillaVariable()
                        End If
                    End If

            End Select

        End Sub

        Private Sub ABuscarFichas()

            Dim filaActual As Integer = 0
            If dgwFic.CurrentRow IsNot Nothing Then filaActual = dgwFic.CurrentRow.Index

            ListarGrillaFicha()

            Try
                dgwFic.Rows(filaActual).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                dgwFic.CurrentCell = dgwFic.Rows(filaActual).Cells("col_nom_fic")
                ListarGrillaVariable()
            Catch ex As Exception

            End Try

        End Sub

        Private Sub ABuscarVariables()

            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then Exit Sub

            If ValidarVariablesSeModifico(Me.GrillaFichaCodigo) = True Then
                If Legolas.Configuration.Aplication.MessageBox.Question("Hay indicadores que no han sido grabados, desea grabar las variables?") = DialogResult.Yes Then
                    Exit Sub
                Else
                    ListarGrillaVariable()
                End If
            Else
                ListarGrillaVariable()
            End If

        End Sub

        Private Sub AGrabarFicha()

            If ValidarFicha() = False Then Exit Sub

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar <> DialogResult.Yes Then Exit Sub

            btnGrabarFicha.Enabled = False

            If AGrabar() = False Then
                btnGrabarFicha.Enabled = True
                Exit Sub
            End If

            btnGrabarFicha.Enabled = True
            Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

            Dim indRegSel As Integer = If(dgwFic.CurrentRow Is Nothing, 0, dgwFic.CurrentRow.Index)

            ListarGrillaFicha()

            Try
                dgwFic.Rows(indRegSel).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                dgwFic.CurrentCell = dgwFic.Rows(indRegSel).Cells("col_nom_fic")
            Catch ex As Exception

            End Try

            ListarGrillaVariable()
            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                Label4.Visible = True
                lblPabellon.Visible = True
                btnBuscarPabellon.Visible = True
            End If
        End Sub

        Private Sub AFinalizarFicha()
            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final AndAlso Me._uscFichaTab = EnmFichaTab.enmEtapa And lblResultado.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de finalizar ficha, debe guardar la ficha final.")
                Exit Sub
            End If

            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final AndAlso Me._uscFichaTab = EnmFichaTab.enmEtapa And lblPabellon.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el pabellón")
                Exit Sub
            End If
            If Me.GrillaFichaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha actual, no ha sido registrada por ello no se puede finalizar")
                Exit Sub
            End If

            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                AFinalizarFichaFinal()
            Else
                AFinalizarFichaOtros()
            End If
        End Sub

        Private Sub AFinalizarFichaFinal()
            'validar el estado de la ficha
            If Me.GrillaFichaEstado = Type.Enumeracion.Clasificacion.enmEstadoRegistroFicha.Finalizado Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha actual, ya se encuentra en el estado finalizado")
                Exit Sub
            End If

            Dim strMensaje As String = "Confirma finalizar el registro seleccionado?, luego de finalizar ya no podrá modificar."

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then

                Dim strMensajeOut As String = ""
                Dim value As Integer = (New InternoFicha_BL()).GrabarEstado(Me.GrillaFichaCodigo, Type.Enumeracion.Clasificacion.enmEstadoRegistroFicha.Finalizado, strMensajeOut)

                If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                    value = (New InternoPabellon_BL).GrabarFichaClasificacionEtapa(Me.IDInternoPabellon, Me.GrillaFichaCodigo, Me.IDPabellon, strMensajeOut)
                End If

                If value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then btnUbicacion.Visible = True
                    ListarGrillaFicha()
                End If

                Try
                    dgwFic.Rows(dgwFic.CurrentRow.Index).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                    dgwFic.CurrentCell = dgwFic.Rows(dgwFic.CurrentRow.Index).Cells("col_nom_fic")
                Catch ex As Exception

                End Try

            End If
        End Sub

        Function existeFichaFinalizado() As Boolean
            For Each f As DataGridViewRow In dgwFic.Rows
                If f.Cells("col_estado").Value = "FINALIZADO" Or f.Cells("col_estado").Value = "BLOQUEADO" Then
                    Return True
                End If
            Next
            Return False
        End Function

        Function isFichaFinalFinalizado() As Boolean
            Dim bFicFinalFinalizado As Boolean = False
            For Each f As DataGridViewRow In dgwFic.Rows
                If f.Cells("tip_fic_id").Value = Type.Enumeracion.Clasificacion.enmTipoFicha.Final And f.Cells("col_estado").Value = "FINALIZADO" Then
                    bFicFinalFinalizado = True
                Else
                    bFicFinalFinalizado = False
                End If
            Next
            Return bFicFinalFinalizado
        End Function

        Private Sub AFinalizarFichaOtros()
            Dim cad As String = ""
            Dim intEstado As Type.Enumeracion.Clasificacion.enmEstadoRegistroFicha = Type.Enumeracion.Clasificacion.enmEstadoRegistroFicha.Finalizado

            If Me.GrillaFichaEstado = enmEstadoRegistroFicha.Finalizado And (Me._uscPerfilUsuario = EnumDependencia.Social Or
                                     _uscPerfilUsuario = EnumDependencia.Legal Or
                                    _uscPerfilUsuario = EnumDependencia.Psicologo) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha actual se encuentra en estado finalizado, para desbloquear coordinar con el jefe de la junta de clasificación.")
                Exit Sub
            End If

            'validar el estado de la ficha
            If Me.GrillaFichaEstado = enmEstadoRegistroFicha.Finalizado Then
                If isFichaFinalFinalizado() Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible completar la operación, ficha final se encuentra finalizado")
                    Return
                Else
                    cad = "Confirma desbloquear el registro seleccionado?"
                    intEstado = enmEstadoRegistroFicha.Pendiente
                End If
            Else 'finalizar ficha
                If (Me.GrillaIDFichaTipo = enmTipoFicha.Social And (Me._uscPerfilUsuario <> EnumDependencia.Social And Me._uscPerfilUsuario <> EnumDependencia.JefeJTCyLegalPsicologoSocial And
                    Me._uscPerfilUsuario <> EnumDependencia.JefeJTCySocial)) Or
                    (Me.GrillaIDFichaTipo = enmTipoFicha.Legal And (Me._uscPerfilUsuario <> EnumDependencia.Legal And Me._uscPerfilUsuario <> EnumDependencia.JefeJTCyLegal And
                    Me._uscPerfilUsuario <> EnumDependencia.JefeJTCyLegalPsicologoSocial)) Or
                    (Me.GrillaIDFichaTipo = enmTipoFicha.Psicologica And (Me._uscPerfilUsuario <> EnumDependencia.Psicologo And Me._uscPerfilUsuario <> EnumDependencia.JefeJTCyLegalPsicologoSocial And
                    Me._uscPerfilUsuario <> EnumDependencia.JefeJTCyPsicologo)) Then

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Accion no autorizada.")
                    Return
                End If

                cad = "Confirma finalizar el registro seleccionado?, luego de finalizar ya no podrá modificar."
                intEstado = enmEstadoRegistroFicha.Finalizado
            End If

            Dim dteFecha As Date = Me.GrillaFechaClasificacion & ""

            If Me.FechaHoraClasificacionRegimen <> dteFecha.ToFileTime Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Grabe la ficha por favor para actualizar la fecha y hora.")
                Return
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question(cad) = DialogResult.Yes Then

                Dim strMensajeOut As String = ""
                Dim value As Integer = (New InternoFicha_BL()).GrabarEstado(Me.GrillaFichaCodigo, intEstado, strMensajeOut)

                If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                    value = (New InternoPabellon_BL).GrabarFichaClasificacionEtapa(Me.IDInternoPabellon, Me.GrillaFichaCodigo, Me.IDPabellon, strMensajeOut)
                End If

                If value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then btnUbicacion.Visible = True
                    ListarGrillaFicha()
                End If

                Try
                    dgwFic.Rows(dgwFic.CurrentRow.Index).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                    dgwFic.CurrentCell = dgwFic.Rows(dgwFic.CurrentRow.Index).Cells("col_nom_fic")
                Catch ex As Exception

                End Try

            End If

        End Sub

        Private Sub ACalcularPuntajeFicha()

            Dim intSumaPuntaje As Integer = 0
            For i As Integer = 0 To dgvVar.Rows.Count - 1
                If Val(dgvVar.Item("col_ptje_noprev", i).Value) = 0 Then
                    intSumaPuntaje += Val(dgvVar.Item("col_ptje2", i).Value)
                Else
                    intSumaPuntaje += Val(dgvVar.Item("col_ptje_noprev", i).Value)
                End If
            Next

            Me.FichaPuntaje = Integer.Parse(intSumaPuntaje)

        End Sub

        Private Function AResultadoFichaFinal() As Short

            Dim value As Short = -1

            Dim intNumClas As Short = Me.NumeroClasificacion
            Dim nPjtFicLegal As Short = 0
            Dim nPjtFicSocial As Short = 0
            Dim nPjtFicPsicologica As Short = 0
            Dim nTotal As Short = 0

            For i As Integer = 0 To dgwFic.Rows.Count - 1
                If dgwFic.Item("col_num_clasif", i).Value = intNumClas Then

                    Select Case dgwFic.Item("tip_fic_id", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                            nPjtFicLegal = dgwFic.Item("col_ptje", i).Value

                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                            nPjtFicPsicologica = dgwFic.Item("col_ptje", i).Value

                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                            nPjtFicSocial = dgwFic.Item("col_ptje", i).Value
                    End Select
                End If
            Next

            nTotal = nPjtFicLegal + nPjtFicSocial + nPjtFicPsicologica

            Dim strNombreResultado As String = ""

            'la ficha de resultado debe ser valida
            If Me.FichaResultado > 1 Then
                Dim objEntFiltroResulDet As New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
                Dim objEntListaResulDet As Entity.EntityCol(Of Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE)

                objEntFiltroResulDet.IDFichaResultado = Me.FichaResultado

                objEntListaResulDet = (New Bussines.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet).Listar(objEntFiltroResulDet)

                For Each objFila As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In objEntListaResulDet
                    If objFila.SituacionJuridicaId = Me.IDSituacionJuridica AndAlso nTotal >= objFila.PuntajeInicial And nTotal <= objFila.PuntajeFinal Then
                        value = objFila.IDTabla
                        strNombreResultado = objFila.Descripcion
                        Exit For
                    End If
                Next

                If value < 1 Or strNombreResultado.Trim.Length < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("La ficha actual no está configurado para devolver el resultado final")
                    Return value
                End If

            End If
            Me.FichaResultadoID = value
            Me.FichaPuntaje = nTotal.ToString
            Me.FichaResultadoValor = strNombreResultado

            Return value
        End Function

        Private Function AGrabar() As Boolean

            Dim value As Boolean = False
            Dim intIDRegimen As Short = -1
            Dim intIDEtapa As Short = -1

            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                intIDEtapa = AResultadoFichaFinal()
                If intIDEtapa < 1 Then Return value
            End If

            Dim objEnt As InternoFicha_BE = New InternoFicha_BE
            Dim pertOC As String = ""
            If rdbOrgCrimSI.Checked Or rdbOrgCrimNO.Checked Then
                pertOC = If(rdbOrgCrimSI.Checked, "S", "N")
            End If

            With objEnt
                .Codigo = Me.GrillaFichaCodigo
                .CodigoPadre = -1
                .IDInterno = Me._IDInterno
                .IDInternoIngreso = Me._IDIngreso
                .IDInternoIngresoInpe = Me._IDIngresoInpe
                .IDFicha = Me.GrillaIDFicha
                .NumeroClasificacion = Me.NumeroClasificacion
                .FechaClasificacion = Me.FechaHoraClasificacionRegimen
                .Observacion = Me.FichaObservacion
                .Puntaje = Me.FichaPuntaje
                .Estado = If(GrillaFichaCodigo = -1, 0, Me.GrillaFichaEstado)
                .IDFichaTipo = Me.GrillaIDFichaTipo
                .FichaGrupo = Me.FichaGrupo
                .InternoIDSituacionJuridica = Me.IDSituacionJuridica
                .InternoIDRegimen = Me.IDRegimen
                .InternoIDEtapa = intIDEtapa
                .MotivoCambio = "" 'Me.FichaMotivoCambio
                .IDRegion = Me._IDRegion
                .IDPenal = Me._IDPenal
                .PerteneceOrgCriminal = pertOC
            End With


            Dim strMensajeOut As String = ""

            Dim intValue As Integer = (New InternoFicha_BL()).Grabar(objEnt, strMensajeOut)

            If intValue = -1 Then
                If strMensajeOut.Length > 0 Then Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeOut)
                Return value
            End If

            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then

                intValue = (New InternoFicha_BL()).GrabarCodigoPadre(Me._IDInterno, Me._IDIngreso, Me._IDIngresoInpe, Me.NumeroClasificacion, Me.FichaGrupo, intValue, strMensajeOut)

                If intValue > 0 Then value = True

            Else
                '----------------------- guardar detalles -------------------------
                strMensajeOut = ""

                For i As Integer = 0 To dgvVar.Rows.Count - 1
                    Dim objEntDetalle As New InternoFichaDetalle_BE

                    With objEntDetalle
                        .Codigo = If(dgvVar.Item("col_fic_det_id", i).Value Is Nothing, -1, dgvVar.Item("col_fic_det_id", i).Value)
                        .IDInternoFicha = intValue
                        .IDVariable = dgvVar.Item("col_mae_var_id", i).Value
                        .IDIndicador = If(dgvVar.Item("col_val_id_sel", i).Value = Nothing, -1, dgvVar.Item("col_val_id_sel", i).Value)
                        .Ponderacion = If(dgvVar.Item("col_ptje_noprev", i).Value > 0, 0, dgvVar.Item("col_ptje2", i).Value)
                        .PonderacionNoPrevista = If(Val(dgvVar.Item("col_ptje_noprev", i).Value) <= 0, 0, dgvVar.Item("col_ptje_noprev", i).Value)
                        .Estado = 1 'activo
                        .IDegion = Me._IDRegion
                        .IDPenal = Me._IDPenal
                    End With

                    If (New InternoFichaDetalle_BL).Grabar(objEntDetalle, strMensajeOut) = -1 Then
                        If strMensajeOut.Length > 0 Then Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeOut)
                        Return value
                    End If
                Next

            End If

            Return True
        End Function

#End Region
#Region "Otros"
        Private Sub MostrarControlesFicha()
            Dim strNombre As String = ""

            lblPabellon.Visible = True
            Label4.Visible = True
            btnBuscarPabellon.Visible = True
            btnUbicacion.Visible = True
            Me.pnlRegimen.Visible = True
            strNombre = "ETAPA: "
            'Me.btnNuevo.Image = My.Resources.accept_32

            If Me._uscEscritura = True Then
                Select Case Me._uscPerfilUsuario
                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                        Me.VerFichaLegal = True
                        Me.VerFichaSocial = True
                        Me.VerFichaPsicologica = True
                        Me.VerFichaFinal = True

                        btnNuevo.Enabled = True
                        btnGrabarFicha.Enabled = True
                        btnBloquear.Enabled = True
                    Case Type.Enumeracion.Usuario.EnumDependencia.Legal
                        Me.VerFichaLegal = True

                    Case Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal
                        Me.VerFichaLegal = True
                        Me.VerFichaFinal = True

                    Case Type.Enumeracion.Usuario.EnumDependencia.Social
                        Me.VerFichaSocial = True

                    Case Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial
                        Me.VerFichaSocial = True
                        Me.VerFichaFinal = True

                    Case Type.Enumeracion.Usuario.EnumDependencia.Psicologo
                        Me.VerFichaPsicologica = True

                    Case Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo

                        Me.VerFichaPsicologica = True
                        Me.VerFichaFinal = True

                    Case Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial
                        Me.VerFichaLegal = True
                        Me.VerFichaSocial = True
                        Me.VerFichaPsicologica = True
                        Me.VerFichaFinal = True
                    Case Else
                        Me.VerFichaLegal = False
                        Me.VerFichaSocial = False
                        Me.VerFichaPsicologica = False
                        Me.VerFichaFinal = False
                End Select
            Else
                If Me._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                    Me.VerFichaLegal = True
                    Me.VerFichaSocial = True
                    Me.VerFichaPsicologica = True
                    Me.VerFichaFinal = True

                    btnNuevo.Enabled = True
                    btnGrabarFicha.Enabled = True
                    btnBloquear.Enabled = True
                End If
            End If

            Me.pnlCabecera.Visible = Me.VerFichaFinal
            Me.col_ptje_noprev.Visible = Me._uscVisibleVariableNoPrevista

            Me.pnlDatosApertura.Enabled = False
            Me.pnlSituacionJur.Enabled = False
            Me.pnlRegimen.Enabled = False
            Me.FichaResultadoNombre = strNombre

            'si no tiene permiso a ninguna ficha, no debe salir el panel de botones
            If Me.VerFichaLegal = False And Me.VerFichaPsicologica = False And Me.VerFichaSocial = False Then
                Me.pnlBotonesGrilla.Visible = False 'Me.VerFichaSocial
                Me.pnlBotonGrabarFicha.Visible = False 'Me.VerFichaSocial
                If Me._uscPerfilUsuario = EnumDependencia.JefeTratamientoPenitenciario Or Me._uscPerfilUsuario = EnumDependencia.SecretariaJuntaClasificacion Then
                    pnlBotonesGrilla.Visible = True
                    btnBloquear.Visible = False
                End If
            End If

        End Sub

#End Region
        Private Sub dgwGrillaFicha_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwFic.CellClick
            If dgwFic.Rows.Count = 0 Then Exit Sub

            blnClickGrillaFicha = True

            If bListadoIniciado = False Then
                ListarFicha()
                ListarGrillaVariable()
                dgwFic.CurrentRow.Cells("col_estado").Style.SelectionForeColor = dgwFic.CurrentRow.Cells("col_estado").Style.ForeColor

                If Me._uscFichaTab = EnmFichaTab.enmEtapa AndAlso Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                    pnlOrgCrim.Visible = True
                    If Me.GrillaFichaEstado = EnmFichaEstado.Finalizado Then
                        btnUbicacion.Visible = True
                    Else
                        btnUbicacion.Visible = False
                    End If
                    If Me.dgwFic.SelectedRows(0).Cells("col_fec_cla").Value <> "" Then 'solo debe ver si la ficha es final y ya tiene datos grabados pero pendientes de finalizar
                        Label4.Visible = True
                        lblPabellon.Visible = True
                        btnBuscarPabellon.Visible = True
                    Else
                        Label4.Visible = False
                        lblPabellon.Visible = False
                        btnBuscarPabellon.Visible = False
                    End If
                Else
                    pnlOrgCrim.Visible = False
                End If
            End If

            blnClickGrillaFicha = False

        End Sub

        Private Sub dgwGrillaFicha_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgwFic.CellEnter
            If dgwFic.Rows.Count = 0 Then Exit Sub

            If blnClickGrillaFicha = True Then Exit Sub

            If bListadoIniciado = False Then
                ListarFicha()
                ListarGrillaVariable()
                dgwFic.CurrentRow.Cells("col_estado").Style.SelectionForeColor = dgwFic.CurrentRow.Cells("col_estado").Style.ForeColor

                If Me._uscFichaTab = EnmFichaTab.enmEtapa AndAlso Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                    If Me.GrillaFichaEstado = EnmFichaEstado.Finalizado Then
                        btnUbicacion.Visible = True
                    Else
                        btnUbicacion.Visible = False
                    End If
                    If Me.dgwFic.SelectedRows(0).Cells("col_fec_cla").Value <> "" Then 'solo debe ver si la ficha es final y ya tiene datos grabados pero pendientes de finalizar
                        Label4.Visible = True
                        lblPabellon.Visible = True
                        btnBuscarPabellon.Visible = True
                    Else
                        Label4.Visible = False
                        lblPabellon.Visible = False
                        btnBuscarPabellon.Visible = False
                    End If

                End If

            End If

            RaiseEvent GrillaFicha_CellEnter(Me.GrillaFichaCodigo, Type.Enumeracion.Auditoria.EnumTipTabla.tra_asi_mov_interno_penal_ficha)

        End Sub

        Private Sub dgwGrillaFicha_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgwFic.CellLeave
            dgwFic.CurrentRow.Cells("col_estado").Style.ForeColor = dgwFic.CurrentRow.Cells("col_estado").Style.ForeColor
        End Sub

        Private Sub dgwGrillaFicha_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgwFic.CellPainting

            If dgwFic.Rows.Count = 0 Then Exit Sub

            If dgwFic.Columns(e.ColumnIndex).Name = "col_num_clasif" AndAlso e.RowIndex <> -1 Then

                Dim tmp As Integer = 0
                For i As Integer = 0 To dgwFic.Rows.Count - 1
                    If dgwFic.Rows(i).Visible = True Then tmp += 1
                Next

                If tmp = 1 Then Exit Sub 'en caso sea un solo registro visible no debe hacer nada
                Using gridBrush As Brush = New SolidBrush(Me.dgwFic.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                    Using gridLinePen As Pen = New Pen(gridBrush)
                        ' Clear cell   
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                        If e.RowIndex = dgwFic.Rows.Count - 1 OrElse dgwFic.Item(e.ColumnIndex, e.RowIndex + 1).Value.ToString() <> e.Value.ToString() Then
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                        End If
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                        If e.Value IsNot Nothing Then
                            Dim previos As Integer = 0
                            Dim siguientes As Integer = 0
                            For i As Integer = e.RowIndex - 1 To 0 Step -1
                                If dgwFic.Item(e.ColumnIndex, i).Value <> e.Value Or i = 0 Or dgwFic.Item(e.ColumnIndex, i).Displayed = False Then
                                    previos = e.RowIndex - i - 1
                                    Exit For
                                End If
                            Next
                            For i As Integer = e.RowIndex + 1 To dgwFic.Rows.Count - 1
                                If dgwFic.Item(e.ColumnIndex, i).Value <> e.Value Or dgwFic.Rows.Count - 1 = i Or dgwFic.Item(e.ColumnIndex, i).Displayed = False Then
                                    siguientes = i - e.RowIndex - 1
                                    Exit For
                                End If
                            Next

                            If siguientes = previos Or siguientes - 1 = previos Then
                                e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X, e.CellBounds.Y, StringFormat.GenericDefault)
                            End If
                        End If

                        e.Handled = True
                    End Using
                End Using
            End If

        End Sub

        Private Sub dgwGrillaFicha_KeyDown(sender As Object, e As KeyEventArgs) Handles dgwFic.KeyDown

            Select Case e.KeyData
                Case Keys.Delete
            End Select

        End Sub

        Private Sub dgwGrillaFicha_Scroll(sender As Object, e As ScrollEventArgs) Handles dgwFic.Scroll

            If e.Type = ScrollEventType.SmallDecrement Or e.Type = ScrollEventType.SmallIncrement Then
                If Not (dgwFic.FirstDisplayedCell.RowIndex + dgwFic.DisplayedRowCount(True) = dgwFic.Rows.Count) Then dgwFic.Refresh()
            End If

        End Sub

        Private Sub dgvFichaVariables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVar.CellClick

            If e.RowIndex = -1 Then Exit Sub

            If dgvVar.Columns(e.ColumnIndex).Name = "col_buton" Then

                If Me.IDInternoPabellon < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Jefe de la Junta de Clasificación, no ha aperturado el registro de clasificación")
                    Exit Sub
                End If

                Dim EntFichaDet As New DatosFicha
                With EntFichaDet
                    .IDIndicador = dgvVar.Item("col_val_id_sel", e.RowIndex).Value
                    .MaeIDVariable = dgvVar.SelectedRows(0).Cells("col_mae_var_id").Value
                    .MaeIDFicha = Me.GrillaIDFicha
                    .VariableNombre = Me.GrillaVariableNombre
                    .ValorPuntaje = dgvVar.Item("col_ptje2", e.RowIndex).Value
                    .ValorNoPrevisto = dgvVar.Item("col_ptje_noprev", e.RowIndex).Value
                    .IDInternoFichaDetalle = dgvVar.Item("col_fic_det_id", e.RowIndex).Value
                    .InternoIDSituacionJuridica = Me.IDSituacionJuridica
                    .IDGrupoFicha = Me.FichaGrupo
                End With

                RaiseEvent GrillaFichaVariable_CellClick(EntFichaDet)
            End If

        End Sub

        Private Sub dgvFichaVariables_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVar.CellEnter
            dgvVar.CurrentRow.Cells("col_valor").Style.SelectionForeColor = dgvVar.CurrentRow.Cells("col_valor").Style.ForeColor
        End Sub

        Private Sub dgvFichaVariables_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVar.CellLeave
            dgvVar.CurrentRow.Cells("col_valor").Style.ForeColor = dgvVar.CurrentRow.Cells("col_valor").Style.ForeColor
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
            'ABuscarFichas()
            Me._ListarUsc()
        End Sub

        Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles btnListarVariables.Click
            ABuscarVariables()
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnGrabarFicha.Click
            AGrabarFicha()
        End Sub

        Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

            If Me.GrillaFichaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Registre el proceso de clasificación del interno")
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim intEstado As Short = -1

            If Me.GrillaIDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                intValue = Me.GrillaFichaCodigo
                intEstado = Me.GrillaFichaEstado
            Else

                intValue = (New InternoFicha_BL()).fnObtenerIDPadre(Me.GrillaFichaCodigo)

                If intValue < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha final aun no ha sido generada")
                    Exit Sub
                End If

                intEstado = (New InternoFicha_BL()).fnObtenerEstado(intValue)
            End If

            If intEstado <> 1 Then 'finalizado
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para ver el reporte, la ficha final debe estar en estado finalizado")
                Exit Sub
            End If

            RaiseEvent Reporte_Click(intValue, _uscFichaTab)

        End Sub

        Private Sub btnBuscarPabellon_Click(sender As Object, e As EventArgs) Handles btnBuscarPabellon.Click
            Dim frm As New Tratamiento.Asistencia.Clasificacion.Penal.frmGrillaPabellonPopup
            With frm
                ._IDEtapa = Me.FichaResultadoID
                ._IDRegion = Me._IDRegion
                ._IDPenal = Me._IDPenal
                If .ShowDialog = DialogResult.OK Then
                    Me.IDPabellon = ._getIDPabellon
                    lblPabellon.Text = ._getPabellonNomre
                End If

            End With
        End Sub

        Private Sub btnUbicacion_Click(sender As Object, e As EventArgs) Handles btnUbicacion.Click
            If Me._IDInterno < 1 Then Exit Sub

            If Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha final debe estar en estado finalizado")
                Exit Sub
            End If
            If _uscPerfilUsuario <> EnumDependencia.TratamientoPenitenciario And
                    _uscPerfilUsuario <> EnumDependencia.JefeTratamientoPenitenciario And
                    _uscPerfilUsuario <> EnumDependencia.SistemasInformacion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Acción pemitida solo para el Jefe de O.T.T.")
                Exit Sub
            End If

            Dim f As New frmUbi_ClasifEtapa
            f.InternoPenalFichaId = Me.GrillaFichaCodigo
            f._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
            If f.ShowDialog = DialogResult.OK Then

            End If
        End Sub
        Private Sub btnBloquear_Click(sender As Object, e As EventArgs) Handles btnBloquear.Click
            AFinalizarFicha()
        End Sub

        Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
            btnNuevo.BackgroundImage = APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnNuevo.Tag = "Editar"
            ToolTip1.SetToolTip(btnNuevo, "Editar")
            Me.pnlDatosApertura.Enabled = False
            pnlSituacionJur.Enabled = False
            pnlRegimen.Enabled = False
            SplitContainer1.Enabled = True
            btnCancelEdit.Visible = False
            Me._ListarUsc()
        End Sub
        Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
            ANuevoGrabar()
        End Sub
    End Class

End Namespace