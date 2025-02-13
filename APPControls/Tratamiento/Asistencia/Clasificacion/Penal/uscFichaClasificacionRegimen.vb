Option Explicit On

Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Mantenimiento.Tratamiento.Clasificacion
Imports Entity.Registro.Carceleta.Clasificacion
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Imports Type.Enumeracion.Clasificacion
Imports Type.Enumeracion.Usuario

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class uscFichaClasificacionRegimen

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

        Public Function IsRegimenEnEstadoEdicion() As Boolean
            Dim v As Boolean = False
            If Me._uscFichaTab = EnmFichaTab.enmRegimen Then
                If Me.btnNuevo.Tag.ToString.ToUpper = "GRABAR" Then
                    Return True
                End If
            End If

            Return v
        End Function
        Public Function IsEtapaEnEstadoEdicion() As Boolean
            Dim v As Boolean = False
            If Me._uscFichaTab = EnmFichaTab.enmEtapa Then
                If Me.btnNuevo.Tag.ToString.ToUpper = "GRABAR" Then
                    Return True
                End If
            End If

            Return v
        End Function

#End Region

#Region "Propiedades_Privadas"
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
        Private ReadOnly Property FechaHoraClasificacion As Long
            Get
                Dim value As Long = 0

                If FechaClasificacionRegimen > 0 Then
                    Dim dteFecha As Date = Me.dtpFechaRegimen.Value & " " & dtpHoraETAPA.Value.ToString("HH:mm") & ":00"
                    value = dteFecha.ToFileTime
                Else
                    dtpHoraETAPA.Value = DateTime.Today
                End If

                Return value
            End Get
        End Property
        Private ReadOnly Property FechaHoraClasificacionCadena As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaHoraClasificacion, True)
            End Get
        End Property
        Private Property IDSitucionJuridica() As Short
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
                    With Me.dgwGrillaFicha
                        intValue = .SelectedRows(0).Cells("col_codigo").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDFicha() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaFicha
                        Return .SelectedRows(0).Cells("col_fic_id2").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaFichaNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrillaFicha
                        value = .SelectedRows(0).Cells("col_nom_fic").Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property


        Private ReadOnly Property GrillaIDFichaTipo() As enmTipoFicha
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaFicha
                        Return .SelectedRows(0).Cells("tip_fic_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFichaEstado() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaFicha
                        intValue = .SelectedRows(0).Cells("col_estado_id").Value
                    End With
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFichaEstadoNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrillaFicha
                        intValue = .SelectedRows(0).Cells("col_estado").Value
                    End With
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFichaNumClasificacion() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaFicha
                        intValue = .SelectedRows(0).Cells("col_num_clasif").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
#End Region

#Region "Propiedades_GrillaVariable"
        Private ReadOnly Property GrillaVariableNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgvFichaVariables
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
            Me.IDSitucionJuridica = 0
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

            CargarCombo()
            ListarInternoPabellon()
            MostrarControlesFicha()

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

            With objEntFiltroInternoPab
                .IDInterno = Me._IDInterno
                .IDIngreso = Me._IDIngreso
                .IDIngresoInpe = Me._IDIngresoInpe
                .Estado = 1 'activo
                .TipoProcesoClasificacion = "PC"
            End With

            Dim objEntInternoPab As InternoPabellon_BE = (New InternoPabellon_BL).ListarClasificacionPendiente(objEntFiltroInternoPab)

            If objEntInternoPab IsNot Nothing Then

                With objEntInternoPab
                    Me.IDInternoPabellon = .Codigo
                    Me.NumeroClasificacion = .NumeroClasificacionRegimen
                    Me.FechaClasificacionRegimen = .FechaClasificacionRegimen
                    dtpHoraETAPA.Value = Legolas.Components.FechaHora.FechaDate(.FechaClasificacionRegimen, True)
                    Me.IDSitucionJuridica = .IDSituacionJuridica
                    Me.IDRegimen = .IDRegimen
                    Me.Estado = .Estado
                End With
                btnNuevo.BackgroundImage = APPControls.My.Resources.Resources._1277961326_folder_edit
                Me.btnNuevo.Tag = "Editar"
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
                    Me.FichaNumeroClasificacion = .NumeroClasificacion
                    Me.FichaFechaClasificacion = .FechaClasificacionString
                    Me.FichaPuntaje = .Puntaje
                    Me.FichaObservacion = .Observacion
                    Me.FichaResultadoID = .InternoIDRegimen
                    Me.FichaResultadoValor = .InternoRegimenNombre
                End With

            Else
                Me.FichaSituacionJuridica = Me.SituacionJuridica
                Me.FichaNumeroClasificacion = Me.NumeroClasificacion
                Me.FichaFechaClasificacion = Me.FechaHoraClasificacionCadena
                Me.FichaPuntaje = 0
                Me.FichaObservacion = ""
                Me.FichaResultadoValor = ""
            End If

            'permisos de las fichas 
            Dim blnVerBotonAccionFicha As Boolean = False
            Select Case Me.GrillaIDFichaTipo
                Case enmTipoFicha.Legal
                    If Me.VerFichaLegal = True And Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then blnVerBotonAccionFicha = True

                Case enmTipoFicha.Psicologica
                    If Me.VerFichaPsicologica = True And Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then blnVerBotonAccionFicha = True

                Case enmTipoFicha.Social
                    If Me.VerFichaSocial = True And Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then blnVerBotonAccionFicha = True

                Case enmTipoFicha.Final
                    If Me.VerFichaFinal = True And Me.GrillaFichaEstado <> EnmFichaEstado.Finalizado Then
                        blnVerBotonAccionFicha = True
                    End If

            End Select

            Me.pnlBotonGrabarFicha.Visible = blnVerBotonAccionFicha
            Me.gbDatosFicha.Text = "DATOS DE LA FICHA: " & Me.GrillaFichaNombre

            txtobservacion.Enabled = blnVerBotonAccionFicha
            btnBuscarPabellon.Enabled = blnVerBotonAccionFicha

        End Sub

        Private Function ListarGrillaFichaRegimen() As List(Of InternoFicha_BE)
            Dim objEntFiltro As New InternoFicha_BE With {
                .IDInterno = Me._IDInterno,
                .IDInternoIngreso = Me._IDIngreso,
                .IDInternoIngresoInpe = Me._IDIngresoInpe,
                .IDRegion = Me._IDRegion,
                .IDPenal = Me._IDPenal,
                .FichaGrupo = Me.FichaGrupo
            }

            'consultar si el interno, tiene fichas registradas en la bd     
            Dim objEntColBD As List(Of InternoFicha_BE) = (New InternoFicha_BL).ListarGrilla(objEntFiltro) 'fichas del interno

            'listar las fichas de las plantillas en funcion a la cantidad de clasificaciones del interno ------------>.
            Dim objEntFiltroFicha As New MaestroFicha_BE With {
                .AmbitoClasificacionId = intAmbitoClasificacion,
                .GrupoSecuencial = Me.FichaGrupo
            }

            If objEntColBD.Count = 0 Then objEntFiltroFicha.EstadoId = 1 'si es nuevo listar solo el activo

            'fichas plantilla original
            Dim objEntColFichaMaestras As MaestroFichaCol_BE = (New Bussines.Clasificacion.MaestroFicha).Listar(objEntFiltroFicha)
            Dim intCantClasficacion As Integer = 0

            If objEntColBD.Count = 0 Then
                intCantClasficacion = 1
            Else
                If Me.NumeroClasificacion = 0 Then
                    intCantClasficacion = objEntColBD.Item(objEntColBD.Count - 1).NumeroClasificacion
                Else
                    intCantClasficacion = Me.NumeroClasificacion
                End If
            End If

            Dim objEntFichaMaestrasTemporalCol As New MaestroFichaCol_BE 'agrupa todas las fichas plantillas
            For i As Integer = 1 To intCantClasficacion '
                For Each objFila As MaestroFicha_BE In objEntColFichaMaestras
                    Dim objEnt As New MaestroFicha_BE With {
                            .NumeroClasificacion = i,
                            .Codigo = objFila.Codigo,
                            .Nombre = objFila.Nombre,
                            .TipoFichaId = objFila.TipoFichaId
                        }

                    objEntFichaMaestrasTemporalCol.Add(objEnt)
                Next
            Next

            '<-----------------------------------------------------------------------------------------------------------------

            Dim objEntCol As New List(Of InternoFicha_BE)

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

            Return objEntCol

        End Function

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

                Dim objEntColBD As List(Of InternoFicha_BE) = (New InternoFicha_BL()).ListarGrilla(New InternoFicha_BE() With {
                                                                  .IDInterno = Me._IDInterno,
                                                                  .IDInternoIngreso = Me._IDIngreso,
                                                                  .IDInternoIngresoInpe = Me._IDIngresoInpe,
                                                                  .IDRegion = Me._IDRegion,
                                                                  .IDPenal = Me._IDPenal,
                                                                  .FichaGrupo = Me.FichaGrupo
                                                                })

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

            objEntCol = ListarGrillaFichaRegimen()

            Me.bListadoIniciado = True 'artificio para controlar que se llame dgwGrillaFicha.CellEnter
            With Me.dgwGrillaFicha
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

            For Each f As DataGridViewRow In dgwGrillaFicha.Rows

                f.DefaultCellStyle.BackColor = objColorDeshabilitado

                Select Case f.Cells("tip_fic_id").Value
                    Case enmTipoFicha.Legal
                        If Me.VerFichaLegal = True And f.Cells("col_estado_id").Value <> EnmFichaEstado.Finalizado Then f.DefaultCellStyle.BackColor = objColorHabilitado

                    Case enmTipoFicha.Psicologica
                        If Me.VerFichaPsicologica = True And f.Cells("col_estado_id").Value <> EnmFichaEstado.Finalizado Then f.DefaultCellStyle.BackColor = objColorHabilitado

                    Case enmTipoFicha.Social
                        If Me.VerFichaSocial = True And f.Cells("col_estado_id").Value <> EnmFichaEstado.Finalizado Then f.DefaultCellStyle.BackColor = objColorHabilitado

                    Case enmTipoFicha.Final
                        If Me.VerFichaFinal = True And f.Cells("col_estado_id").Value <> EnmFichaEstado.Finalizado Then f.DefaultCellStyle.BackColor = objColorHabilitado

                        f.DefaultCellStyle.Font = New Font(Me.dgwGrillaFicha.DefaultCellStyle.Font, FontStyle.Bold)
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

            If Me.dgwGrillaFicha.Rows.Count > 0 Then Me.dgwGrillaFicha.Rows(0).Selected = True

        End Sub

        Private Sub ListarGrillaVariable()

            If Me.GrillaIDFicha < 1 Then Exit Sub

            Dim objEntFichaInternoDet As New InternoFichaDetalle_BE
            Dim objEnListaFichaInternoDet As New List(Of InternoFichaDetalle_BE)


            '******************************** cargar detalles  *****************************
            If Me.GrillaIDFichaTipo = enmTipoFicha.Final Then

                Me.dgvFichaVariables.Visible = False
                Me.pnlSubDetalle.Dock = DockStyle.Fill
                Me.pnlResultadoFicha.Visible = True
                Me.pnlDatosFicha.Dock = DockStyle.Top

            Else
                Me.pnlSubDetalle.Dock = DockStyle.Bottom
                Me.dgvFichaVariables.Visible = True
                Me.pnlResultadoFicha.Visible = False
                Me.pnlDatosFicha.Dock = DockStyle.Fill

                objEntFichaInternoDet.IDInternoFicha = Me.GrillaFichaCodigo

                If Me.GrillaFichaCodigo > 0 Then objEnListaFichaInternoDet = (New InternoFichaDetalle_BL()).Listar(objEntFichaInternoDet)

                ''******************************** cargar plantilla ficha **************************
                Dim objEntMaeVariable As New MaestroVariable_BE With {
                    .FichaID = Me.GrillaIDFicha
                }

                ''------- pintar sobre la grilla de la plantilla -------
                Dim entValTmp As MaestroIndicador_BE
                With dgvFichaVariables
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = (New Bussines.Clasificacion.MaestroVariable()).Listar(objEntMaeVariable)
                End With

                For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                    For Each objDetFin As InternoFichaDetalle_BE In objEnListaFichaInternoDet
                        With dgvFichaVariables
                            If .Item("col_mae_var_id", i).Value = objDetFin.IDVariable Then
                                .Item("col_ptje2", i).Value = objDetFin.Ponderacion
                                .Item("col_ptje_noprev", i).Value = objDetFin.PonderacionNoPrevista
                                .Item("col_fic_det_id", i).Value = objDetFin.Codigo

                                entValTmp = (New Bussines.Clasificacion.MaestroIndicador).Listar2(objDetFin.IDIndicador, objDetFin.IDVariable, Me.GrillaIDFicha)
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

            For Each f As DataGridViewRow In dgvFichaVariables.Rows
                f.Cells("col_valor").Style.Font = New Font(dgvFichaVariables.Font, FontStyle.Bold)
            Next

            Me.dgvFichaVariables.AllowUserToResizeRows = False
            Me.dgvFichaVariables.AutoGenerateColumns = False
        End Sub

        Public Sub _ListarFilaVariable(intPuntaje As Short, strNombre As String, intValorIdSeleccionado As Short, intValorNoPrevisto As Short)
            With dgvFichaVariables
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
        Private Function ValidarNuevaApertura() As Boolean

            If ValidarDatosInterno() = False Then Return False

            If Me.IDInternoPabellon > 0 And (New InternoPabellon_BL).fn_ObtenerEstado(Me.IDInternoPabellon) = 1 Then 'validar el estado del registro de interno pabellon
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro de clasificación aperturado no ha sido finalizado, por ello no se puede crear un nuevo proceso de clasificación")
                Return False
            End If

            ''''validar si existe ficha pendiente de finalizar caso contrario no permitir continuar
            Dim objEntInternoPab As New InternoPabellon_BE With {
                .IDInterno = Me._IDInterno,
                .IDIngreso = IIf(Me._IDIngresoInpe > 0, -1, Me._IDIngreso),
                .IDIngresoInpe = Me._IDIngresoInpe,
                .Estado = 1
                }

            objEntInternoPab = (New InternoPabellon_BL).ListarClasificacionPendiente(objEntInternoPab)
            If Not objEntInternoPab Is Nothing Then
                If objEntInternoPab.IDEtapa = -1 And objEntInternoPab.IDFichaRegimen = -1 And objEntInternoPab.IDRegimen > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun existe ficha de clasificación aun pendientes de finalizar, verifique")
                    Return False
                End If

                If objEntInternoPab.IDEtapa > 0 And objEntInternoPab.IDFichaRegimen = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun existe ficha de clasificación aun pendientes de finalizarpor parte de O.T.T.")
                    Return False
                End If

            End If

            Return True
        End Function

        Private Function ValidarAperturaClasificacion() As Boolean

            If Me.IDInternoPabellon < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Jefe de la Junta de Clasificación, no ha aperturado el registro de clasificación")
                Return False
            End If

            If Me.GrillaFichaEstado = enmEstadoRegistroFicha.Finalizado Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha ha sido finalizada, no se puede modificar los datos")
                Return False
            End If

            Return True
        End Function

        Private Function ValidarFicha() As Boolean

            If ValidarAperturaClasificacion() = False Then Return False

            'validar
            If Me.GrillaIDFichaTipo = enmTipoFicha.Final Then
                'validar el estado finalizado de las fichas
                For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                    If dgwGrillaFicha.Item("tip_fic_id", i).Value <> enmTipoFicha.Final Then
                        If dgwGrillaFicha.Item("col_estado_id", i).Value <> enmEstadoRegistroFicha.Finalizado Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de generar la ficha final, todas las demás fichas deben estar en estado finalizado.")
                            Return False
                        End If
                    End If
                Next

            Else
                'validar los indicadores de cada variable
                For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1

                    Dim strVariable As String = dgvFichaVariables.Item("col_val_nom", i).Value.ToUpper
                    Dim strNombreIndicador As String = CType(dgvFichaVariables.Item("col_valor", i).Value, String)

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
                For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                    Dim strNombreIndicador As String = CType(dgvFichaVariables.Item("col_valor", i).Value, String)

                    If Not strNombreIndicador Is Nothing = True Then
                        value = True
                        Exit For
                    End If
                Next
            End If

            Return value
        End Function

        Private Function ValidarNuevaEtapa()

            If ValidarDatosInterno() = False Then Return False

            If (New InternoPabellon_BL).fn_ObtenerIDFichaRegimen(Me.IDInternoPabellon) < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha finalizado la clasificación del régimen del interno, verifique")
                Return False
            End If

            If Me.IDRegimen > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro de la clasificación de etapa del interno, ya se encuentra activo")
                Return False
            End If

            Return True

        End Function
#End Region
#Region "Accion"
        Function isFichaFinalFinalizado() As Boolean
            Dim bFicFinalFinalizado As Boolean = False
            For Each f As DataGridViewRow In dgwGrillaFicha.Rows
                If f.Cells("tip_fic_id").Value = enmTipoFicha.Final And f.Cells("col_estado").Value = "FINALIZADO" Then
                    bFicFinalFinalizado = True
                Else
                    bFicFinalFinalizado = False
                End If
            Next
            Return bFicFinalFinalizado
        End Function
        Function existeFichaFinalizado() As Boolean
            For Each f As DataGridViewRow In dgwGrillaFicha.Rows
                If f.Cells("col_estado").Value = "FINALIZADO" Or f.Cells("col_estado").Value = "BLOQUEADO" Then
                    Return True
                End If
            Next
            Return False
        End Function
        Private Sub ANuevoGrabar()

            Dim strMensaje As String = ""


            Select Case Me.btnNuevo.Tag.ToString.ToUpper
                Case "Editar".ToUpper
                    If isFichaFinalFinalizado() = False Then
                        Dim str As String = "Confirma modificar los datos principales de clasificación a régimen?"
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
                        SplitContainer1.Enabled = False
                        btnCancelar.Visible = True
                        btnCancelar.Enabled = True
                    End If
                Case "Nuevo".ToUpper

                    If ValidarNuevaApertura() = False Then Exit Sub

                    strMensaje = "Desea aperturar un nuevo registro de clasificación del interno: " & Me._InternoApeNom.ToUpper

                    If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then

                        Me.NumeroClasificacion = 0
                        Me.FechaClasificacionRegimen = 0
                        Me.IDSitucionJuridica = -1
                        Me.pnlDatosApertura.Enabled = True
                        Me.btnCancelar.Enabled = True
                        SplitContainer1.Enabled = False

                        Me.btnNuevo.BackgroundImage = My.Resources.Diskette_32x32
                        Me.btnNuevo.Tag = "Grabar"

                        Me.dtpFechaRegimen.Focus()

                    End If
                Case "Grabar".ToUpper

                    If AGrabarInternoPabellon() = True Then
                        btnNuevo.BackgroundImage = APPControls.My.Resources.Resources._1277961326_folder_edit
                        Me.btnNuevo.Tag = "Editar"

                        Me.btnCancelar.Enabled = False
                        Me.pnlDatosApertura.Enabled = False
                        SplitContainer1.Enabled = True
                        If Me.IDInternoPabellon > 0 Then ListarInternoPabellon()
                    End If

            End Select



        End Sub
        Private Function AGrabarInternoPabellon() As Boolean

            Dim value As Boolean = False

            If Me.FechaClasificacionRegimen < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la fecha de clasificación")
                Me.dtpFechaRegimen.Focus()
                Return value
            End If

            If Me.IDSitucionJuridica < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione situación jurídidca")
                Me.cbbSitJuridica.Focus()
                Return value
            End If

            Dim strMensaje As String = "Desea grabar el registro de clasificación del interno (los datos ingresados se aplicarán a todas las fichas)"
            Dim strMensajeOut As String = ""

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then
                Dim objEnt As New InternoPabellon_BE With {
                    .Codigo = Me.IDInternoPabellon,
                    .IDInterno = Me._IDInterno,
                    .IDIngreso = Me._IDIngreso,
                    .IDIngresoInpe = Me._IDIngresoInpe,
                    .FechaClasificacionRegimen = Me.FechaHoraClasificacion,
                    .IDSituacionJuridica = Me.IDSitucionJuridica,
                    .NumeroClasificacionRegimen = Val(txtNumClasif.Text),
                    .IDRegion = Me._IDRegion,
                    .IDPenal = Me._IDPenal,
                    .Estado = 1,
                    .TipoProcesoClasificacion = "PC"'proceso de clasificacion completa
                }

                If Me.IDInternoPabellon > 0 Then
                    Me.IDInternoPabellon = (New InternoPabellon_BL).ActualizarRegimen(objEnt, strMensajeOut)
                Else
                    Me.IDInternoPabellon = (New InternoPabellon_BL).Grabar(objEnt, strMensajeOut)
                End If

                If Me.IDInternoPabellon > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    value = True
                    ListarInternoPabellon()
                    ListarGrillaFicha()
                End If

            End If

            Return value
        End Function


        Private Sub ABuscarFichas()

            Dim filaActual As Integer = 0
            If dgwGrillaFicha.CurrentRow IsNot Nothing Then filaActual = dgwGrillaFicha.CurrentRow.Index

            ListarGrillaFicha()

            Try
                dgwGrillaFicha.Rows(filaActual).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(filaActual).Cells("col_nom_fic")
                ListarGrillaVariable()
            Catch ex As Exception

            End Try

        End Sub

        Private Sub ABuscarVariables()

            If Me.GrillaIDFichaTipo = enmTipoFicha.Final Then Exit Sub

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

            Dim indRegSel As Integer = If(dgwGrillaFicha.CurrentRow Is Nothing, 0, dgwGrillaFicha.CurrentRow.Index)

            ListarGrillaFicha()

            Try
                dgwGrillaFicha.Rows(indRegSel).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(indRegSel).Cells("col_nom_fic")
            Catch ex As Exception

            End Try

            ListarGrillaVariable()

        End Sub

        Function isFichaFinalBloqueado() As Boolean
            Dim bFicFinalFinalizado As Boolean = False


            For Each f As DataGridViewRow In dgwGrillaFicha.Rows
                If f.Cells("tip_fic_id").Value = enmTipoFicha.Final And f.Cells("col_estado").Value = "FINALIZADO" Then
                    bFicFinalFinalizado = True
                Else
                    bFicFinalFinalizado = False
                End If
            Next

            Return bFicFinalFinalizado
        End Function

        Private Sub AFinalizarFicha()
            If Me.GrillaIDFichaTipo = enmTipoFicha.Final AndAlso Me._uscFichaTab = EnmFichaTab.enmEtapa And lblResultado.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de finalizar ficha, debe guardar la ficha final.")
                Exit Sub
            End If

            If Me.GrillaIDFichaTipo = enmTipoFicha.Final AndAlso Me._uscFichaTab = EnmFichaTab.enmEtapa And lblPabellon.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el pabellón")
                Exit Sub
            End If
            If Me.GrillaFichaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha actual, no ha sido registrada por ello no se puede finalizar")
                Exit Sub
            End If


            If Me.GrillaIDFichaTipo = enmTipoFicha.Final Then
                AFinalizarFichaFinal()
            Else
                AFinalizarFichaOtros()
            End If



        End Sub


        Private Sub AFinalizarFichaFinal()

            'validar el estado de la ficha
            If Me.GrillaFichaEstado = enmEstadoRegistroFicha.Finalizado Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha actual, ya se encuentra en el estado finalizado")
                Exit Sub
            End If

            Dim strMensaje As String = "Confirma finalizar el registro seleccionado?, luego de finalizar ya no podrá modificar."

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then

                Dim strMensajeOut As String = ""

                Dim value As Integer = (New InternoFicha_BL()).GrabarEstado(Me.GrillaFichaCodigo, enmEstadoRegistroFicha.Finalizado, strMensajeOut)

                If Me.GrillaIDFichaTipo = enmTipoFicha.Final Then
                    value = (New InternoPabellon_BL).GrabarFichaClasificacionRegimen(Me.IDInternoPabellon, Me.GrillaFichaCodigo, strMensajeOut)
                End If

                If value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    ListarGrillaFicha()
                End If

                Try
                    dgwGrillaFicha.Rows(dgwGrillaFicha.CurrentRow.Index).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                    dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(dgwGrillaFicha.CurrentRow.Index).Cells("col_nom_fic")
                Catch ex As Exception

                End Try

            End If

        End Sub

        Private Sub AFinalizarFichaOtros()
            Dim cad As String = ""
            Dim intEstado As enmEstadoRegistroFicha = enmEstadoRegistroFicha.Finalizado

            If Me.GrillaFichaEstado = enmEstadoRegistroFicha.Finalizado And (Me._uscPerfilUsuario = EnumDependencia.Social Or
                                     _uscPerfilUsuario = EnumDependencia.Legal Or
                                     _uscPerfilUsuario = EnumDependencia.Psicologo) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha actual se encuentra en el estado finalizado, para desbloquear coordinar con el jefe de la junta de clasificación.")
                Exit Sub
            End If

            'validar el estado de la ficha
            If Me.GrillaFichaEstado = enmEstadoRegistroFicha.Finalizado Then
                If isFichaFinalBloqueado() Then
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

            If Legolas.Configuration.Aplication.MessageBox.Question(cad) = DialogResult.Yes Then

                Dim strMensajeOut As String = ""

                If (New InternoFicha_BL()).GrabarEstado(Me.GrillaFichaCodigo, intEstado, strMensajeOut) > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    ListarGrillaFicha()
                End If
                Try
                    dgwGrillaFicha.Rows(dgwGrillaFicha.CurrentRow.Index).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                    dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(dgwGrillaFicha.CurrentRow.Index).Cells("col_nom_fic")
                Catch ex As Exception

                End Try

            End If

        End Sub

        Private Sub ACalcularPuntajeFicha()

            Dim intSumaPuntaje As Integer = 0
            For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                If Val(dgvFichaVariables.Item("col_ptje_noprev", i).Value) = 0 Then
                    intSumaPuntaje += Val(dgvFichaVariables.Item("col_ptje2", i).Value)
                Else
                    intSumaPuntaje += Val(dgvFichaVariables.Item("col_ptje_noprev", i).Value)
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

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("col_num_clasif", i).Value = intNumClas Then

                    Select Case dgwGrillaFicha.Item("tip_fic_id", i).Value
                        Case enmTipoFicha.Legal
                            nPjtFicLegal = dgwGrillaFicha.Item("col_ptje", i).Value

                        Case enmTipoFicha.Psicologica
                            nPjtFicPsicologica = dgwGrillaFicha.Item("col_ptje", i).Value

                        Case enmTipoFicha.Social
                            nPjtFicSocial = dgwGrillaFicha.Item("col_ptje", i).Value
                    End Select
                End If
            Next

            nTotal = nPjtFicLegal + nPjtFicSocial + nPjtFicPsicologica

            Dim strNombreResultado As String = ""

            'la ficha de resultado debe ser valida
            If Me.FichaResultado > 1 Then
                Dim objEntFiltroResulDet As New ResultadoDet_BE With {
                                    .IDFichaResultado = Me.FichaResultado
                                }
                Dim objEntListaResulDet As Entity.EntityCol(Of ResultadoDet_BE) = (New Bussines.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet).Listar(objEntFiltroResulDet)

                For Each objFila As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In objEntListaResulDet
                    If objFila.SituacionJuridicaId = Me.IDSitucionJuridica AndAlso nTotal >= objFila.PuntajeInicial And nTotal <= objFila.PuntajeFinal Then
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

            If Me.GrillaIDFichaTipo = enmTipoFicha.Final Then
                intIDRegimen = AResultadoFichaFinal()
                If intIDRegimen < 1 Then Return value
            End If

            Dim objEnt As InternoFicha_BE = New InternoFicha_BE With {
                .Codigo = Me.GrillaFichaCodigo,
                .CodigoPadre = -1,
                .IDInterno = Me._IDInterno,
                .IDInternoIngreso = Me._IDIngreso,
                .IDInternoIngresoInpe = Me._IDIngresoInpe,
                .IDFicha = Me.GrillaIDFicha,
                .NumeroClasificacion = Me.NumeroClasificacion,
                .FechaClasificacion = Me.FechaHoraClasificacion,
                .Observacion = Me.FichaObservacion,
                .Puntaje = Me.FichaPuntaje,
                .Estado = If(GrillaFichaCodigo = -1, 0, Me.GrillaFichaEstado),
                .IDFichaTipo = Me.GrillaIDFichaTipo,
                .FichaGrupo = Me.FichaGrupo,
                .InternoIDSituacionJuridica = Me.IDSitucionJuridica,
                .InternoIDRegimen = intIDRegimen,
                .InternoIDEtapa = intIDEtapa,
                .MotivoCambio = "",
                .IDRegion = Me._IDRegion,
                .IDPenal = Me._IDPenal
            }

            Dim strMensajeOut As String = ""

            Dim intValue As Integer = (New InternoFicha_BL()).Grabar(objEnt, strMensajeOut)

            If intValue = -1 Then
                If strMensajeOut.Length > 0 Then Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeOut)
                Return value
            End If

            If Me.GrillaIDFichaTipo = enmTipoFicha.Final Then

                intValue = (New InternoFicha_BL()).GrabarCodigoPadre(Me._IDInterno, Me._IDIngreso, Me._IDIngresoInpe, Me.NumeroClasificacion, Me.FichaGrupo, intValue, strMensajeOut)

                If intValue > 0 Then value = True

            Else
                '----------------------- guardar detalles -------------------------
                strMensajeOut = ""

                For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                    Dim objEntDetalle As New InternoFichaDetalle_BE With {
                        .Codigo = If(dgvFichaVariables.Item("col_fic_det_id", i).Value Is Nothing, -1, dgvFichaVariables.Item("col_fic_det_id", i).Value),
                        .IDInternoFicha = intValue,
                        .IDVariable = dgvFichaVariables.Item("col_mae_var_id", i).Value,
                        .IDIndicador = If(dgvFichaVariables.Item("col_val_id_sel", i).Value = Nothing, -1, dgvFichaVariables.Item("col_val_id_sel", i).Value),
                        .Ponderacion = If(dgvFichaVariables.Item("col_ptje_noprev", i).Value > 0, 0, dgvFichaVariables.Item("col_ptje2", i).Value),
                        .PonderacionNoPrevista = If(Val(dgvFichaVariables.Item("col_ptje_noprev", i).Value) <= 0, 0, dgvFichaVariables.Item("col_ptje_noprev", i).Value),
                        .Estado = 1, 'activo,
                        .IDegion = Me._IDRegion,
                        .IDPenal = Me._IDPenal
                    }

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

            Me.FichaClasificar = EnmFichaClasificar.enmRegimen
            strNombre = "REGIMEN: "
            lblPabellon.Visible = False
            Label4.Visible = False
            btnBuscarPabellon.Visible = False
            Me.pnlRegimen.Visible = False

            If Me._uscEscritura = True Then
                Select Case Me._uscPerfilUsuario
                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                        Me.VerFichaLegal = True
                        Me.VerFichaSocial = True
                        Me.VerFichaPsicologica = True
                        Me.VerFichaFinal = True

                        btnNuevo.Enabled = False
                        btnGrabarFicha.Enabled = False
                        btnBloquear.Enabled = False
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

                    btnNuevo.Enabled = False
                    btnGrabarFicha.Enabled = False
                    btnBloquear.Enabled = False
                End If
            End If

            Me.pnlCabecera.Visible = Me.VerFichaFinal
            Me.col_ptje_noprev.Visible = Me._uscVisibleVariableNoPrevista

            Me.pnlDatosApertura.Enabled = False
            Me.btnCancelar.Enabled = False
            Me.FichaResultadoNombre = strNombre

            'si no tiene permiso a ninguna ficha, no debe salir el panel de botones
            If Me.VerFichaLegal = False And Me.VerFichaPsicologica = False And Me.VerFichaSocial = False Then
                Me.pnlBotonesGrilla.Visible = Me.VerFichaSocial
                Me.pnlBotonGrabarFicha.Visible = Me.VerFichaSocial
                If Me._uscPerfilUsuario = EnumDependencia.SecretariaJuntaClasificacion Then
                    pnlBotonesGrilla.Visible = True
                    btnBloquear.Visible = False
                End If
            End If

        End Sub

#End Region
        Private Sub dgwGrillaFicha_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaFicha.CellClick
            If dgwGrillaFicha.Rows.Count = 0 Then Exit Sub

            blnClickGrillaFicha = True

            If bListadoIniciado = False Then
                ListarFicha()
                ListarGrillaVariable()
                dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.SelectionForeColor = dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.ForeColor

                If Me._uscFichaTab = EnmFichaTab.enmEtapa AndAlso Me.GrillaIDFichaTipo = enmTipoFicha.Final Then
                    If Me.dgwGrillaFicha.SelectedRows(0).Cells("col_fec_cla").Value <> "" Then 'solo debe ver si la ficha es final y ya tiene datos grabados pero pendientes de finalizar
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

            blnClickGrillaFicha = False

        End Sub

        Private Sub dgwGrillaFicha_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaFicha.CellEnter
            If dgwGrillaFicha.Rows.Count = 0 Then Exit Sub

            If blnClickGrillaFicha = True Then Exit Sub

            If bListadoIniciado = False Then
                ListarFicha()
                ListarGrillaVariable()
                dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.SelectionForeColor = dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.ForeColor

                If Me._uscFichaTab = EnmFichaTab.enmEtapa AndAlso Me.GrillaIDFichaTipo = enmTipoFicha.Final Then
                    If Me.dgwGrillaFicha.SelectedRows(0).Cells("col_fec_cla").Value <> "" Then 'solo debe ver si la ficha es final y ya tiene datos grabados pero pendientes de finalizar
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

        Private Sub dgwGrillaFicha_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaFicha.CellLeave
            dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.ForeColor = dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.ForeColor
        End Sub

        Private Sub dgwGrillaFicha_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgwGrillaFicha.CellPainting

            If dgwGrillaFicha.Rows.Count = 0 Then Exit Sub

            If dgwGrillaFicha.Columns(e.ColumnIndex).Name = "col_num_clasif" AndAlso e.RowIndex <> -1 Then

                Dim tmp As Integer = 0
                For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                    If dgwGrillaFicha.Rows(i).Visible = True Then tmp += 1
                Next

                If tmp = 1 Then Exit Sub 'en caso sea un solo registro visible no debe hacer nada
                Using gridBrush As Brush = New SolidBrush(Me.dgwGrillaFicha.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                    Using gridLinePen As Pen = New Pen(gridBrush)

                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                        If e.RowIndex = dgwGrillaFicha.Rows.Count - 1 OrElse dgwGrillaFicha.Item(e.ColumnIndex, e.RowIndex + 1).Value.ToString() <> e.Value.ToString() Then
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                        End If

                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                        If e.Value IsNot Nothing Then
                            Dim previos As Integer = 0
                            Dim siguientes As Integer = 0
                            For i As Integer = e.RowIndex - 1 To 0 Step -1
                                If dgwGrillaFicha.Item(e.ColumnIndex, i).Value <> e.Value Or i = 0 Or dgwGrillaFicha.Item(e.ColumnIndex, i).Displayed = False Then
                                    previos = e.RowIndex - i - 1
                                    Exit For
                                End If
                            Next
                            For i As Integer = e.RowIndex + 1 To dgwGrillaFicha.Rows.Count - 1
                                If dgwGrillaFicha.Item(e.ColumnIndex, i).Value <> e.Value Or dgwGrillaFicha.Rows.Count - 1 = i Or dgwGrillaFicha.Item(e.ColumnIndex, i).Displayed = False Then
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

        Private Sub dgwGrillaFicha_KeyDown(sender As Object, e As KeyEventArgs) Handles dgwGrillaFicha.KeyDown

            Select Case e.KeyData
                Case Keys.Delete
            End Select

        End Sub

        Private Sub dgwGrillaFicha_Scroll(sender As Object, e As ScrollEventArgs) Handles dgwGrillaFicha.Scroll

            If e.Type = ScrollEventType.SmallDecrement Or e.Type = ScrollEventType.SmallIncrement Then
                If Not (dgwGrillaFicha.FirstDisplayedCell.RowIndex + dgwGrillaFicha.DisplayedRowCount(True) = dgwGrillaFicha.Rows.Count) Then dgwGrillaFicha.Refresh()
            End If

        End Sub

        Private Sub dgvFichaVariables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFichaVariables.CellClick

            If e.RowIndex = -1 Then Exit Sub

            If dgvFichaVariables.Columns(e.ColumnIndex).Name = "col_buton" Then

                If Me.IDInternoPabellon < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Jefe de la Junta de Clasificación, no ha aperturado el registro de clasificación")
                    Exit Sub
                End If

                Dim EntFichaDet As New DatosFicha
                With EntFichaDet
                    .IDIndicador = dgvFichaVariables.Item("col_val_id_sel", e.RowIndex).Value
                    .MaeIDVariable = dgvFichaVariables.SelectedRows(0).Cells("col_mae_var_id").Value
                    .MaeIDFicha = Me.GrillaIDFicha
                    .VariableNombre = Me.GrillaVariableNombre
                    .ValorPuntaje = dgvFichaVariables.Item("col_ptje2", e.RowIndex).Value
                    .ValorNoPrevisto = dgvFichaVariables.Item("col_ptje_noprev", e.RowIndex).Value
                    .IDInternoFichaDetalle = dgvFichaVariables.Item("col_fic_det_id", e.RowIndex).Value
                    .InternoIDSituacionJuridica = Me.IDSitucionJuridica
                    .IDGrupoFicha = Me.FichaGrupo
                End With

                RaiseEvent GrillaFichaVariable_CellClick(EntFichaDet)
            End If

        End Sub

        Private Sub dgvFichaVariables_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFichaVariables.CellEnter
            dgvFichaVariables.CurrentRow.Cells("col_valor").Style.SelectionForeColor = dgvFichaVariables.CurrentRow.Cells("col_valor").Style.ForeColor
        End Sub

        Private Sub dgvFichaVariables_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFichaVariables.CellLeave
            dgvFichaVariables.CurrentRow.Cells("col_valor").Style.ForeColor = dgvFichaVariables.CurrentRow.Cells("col_valor").Style.ForeColor
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
            ABuscarFichas()
        End Sub

        Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles btnListarVariables.Click
            ABuscarVariables()
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnGrabarFicha.Click
            AGrabarFicha()
        End Sub

        Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
            ANuevoGrabar()
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            Me.btnCancelar.Enabled = False
            Me.pnlDatosApertura.Enabled = False
            SplitContainer1.Enabled = True
            If Me.IDInternoPabellon > 0 Then
                btnNuevo.BackgroundImage = APPControls.My.Resources.Resources._1277961326_folder_edit
                Me.btnNuevo.Tag = "Editar"
                ListarInternoPabellon()
            Else
                Me.btnNuevo.BackgroundImage = My.Resources.add_32
                Me.btnNuevo.Tag = "Nuevo"
            End If
        End Sub



        Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

            If Me.GrillaFichaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Registre el proceso de clasificación del interno")
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim intEstado As Short = -1

            If Me.GrillaIDFichaTipo = enmTipoFicha.Final Then
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

        Private Sub btnBloquear_Click(sender As Object, e As EventArgs) Handles btnBloquear.Click
            AFinalizarFicha()
        End Sub

    End Class

End Namespace