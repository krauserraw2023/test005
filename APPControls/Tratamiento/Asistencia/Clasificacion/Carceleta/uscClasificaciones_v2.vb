Imports Type.Enumeracion.Clasificacion
Imports Type.Enumeracion.Usuario
Imports System.Data.Linq
Imports System.Linq
Imports Entity.Registro.Carceleta.Clasificacion

'Namespace Registro.Carceleta.Clasificacion
Namespace Clasificacion
    Public Class uscClasificaciones_v2
        Public Event _Click_FichaDetalle(EntFichaDet As Entity.Clasificacion.Documento.DatosFicha)
        Public Event _Click_PrintFicha(Codigo As Integer, grupoFichaId As Integer, TipoFichaId As Type.Enumeracion.Clasificacion.enmTipoFicha)
        Public Event _Click_PrintFormato06(IdFicha As Integer, grupoFichaId As Integer)
        Public Event _Show_AuditFicha(IdFicha As Integer, TipoTablaAudit As Type.Enumeracion.TipoTabla.EnumTipTabla)

        Public Event _Click_btn_Formato06(FichaId As Integer, variableIndicador As String, escritura As Boolean)


        Dim indiceFilaAnterior As Integer = -1

        Dim flagValidarDatos As Boolean = True
        Dim strDatosActual As String = "" 'concatenar valores para detectar si hubo cambios en los cavloresvalores.
        Dim bEditManualPenDest As Boolean = False

        'bug de la grilla, al hacer grilla.rowCount internamente se llama al evento dgwGrillaFicha.CellEnter provocando efecto no deseado
        Private bListadoIniciado As Boolean = False 'artificio para controlar lo anterior

#Region "Propiedades publicas"
        Public Property _IngresoInpeId() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _FichaId() As Integer = -1
        Public Property _EtapaFichaId As Integer = -1
        'Public Property _RegimenFichaId As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _Apellidos() As String = ""
        Public Property _Nombres() As String = ""
        Public Property _Sexo As String = ""
        Public Property _GrupoFichaId As Integer = -1 '
        Public Property _Nacionalidad As String = ""
        Public Property _TipoDocIdentStr As String = ""
        Public Property _NumDocIdentStr As String = ""
        Private ReadOnly Property ApellidosyNombres() As String
            Get
                Return Me._Apellidos & ", " & Me._Nombres
            End Get
        End Property
        Public Property _EstadoInterno As Integer = -1
#End Region

#Region "Propiedades"
        Private Property PerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia
        Private Property NivelUsuario As Integer 'en futura version cambiar por un enum

        Private Property CategoriaFichaNombre() As String
            Get
                Return txtCategoria.Text
            End Get
            Set(value As String)
                txtCategoria.Text = value
            End Set
        End Property

        Private Property Observacion() As String
            Get
                Return txtobservacion.Text
            End Get
            Set(value As String)
                txtobservacion.Text = value
            End Set
        End Property

        Private Property FechaClasificacion() As Long
            Get
                Return dtpFecha.ValueLong
            End Get
            Set(value As Long)
                dtpFecha.ValueLong = value
            End Set
        End Property

        Private Property Puntaje() As String
            Get
                Return txtPuntTotal.Text
            End Get
            Set(value As String)
                txtPuntTotal.Text = value
            End Set
        End Property

        Private Property RegionDestinoId() As Integer
            Get
                Return cbbRegionDestino.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegionDestino.SelectedValue = value
            End Set
        End Property

        Private Property RegimenPenalId() As Integer
            Get
                Return cbbRegimenPenal.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegimenPenal.SelectedValue = value
            End Set
        End Property

        Private Property PenalDestinoId() As Integer
            Get
                Return cbbPenalDestino.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenalDestino.SelectedValue = value
            End Set
        End Property

#End Region

#Region "COMBO"
        Private Sub ComboRegion()
            With Me.cbbRegionDestino
                ._Todos = False
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With
        End Sub

        Private Sub ComboPenal()
            With Me.cbbPenalDestino
                ._Todos = False
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.RegionDestinoId
                .Parametro1 = -1
                .LoadUsc()
            End With
        End Sub

        Private Sub ComboRegimenPenitenciario()
            'If Me.PenalDestinoId <= 0 Then Exit Sub
            'Dim pen As Entity.General.Penal
            Dim entCol As New Entity.Mantenimiento.General.RegimenPenitenciarioCol
            Try
                'pen = (New Bussines.General.Penal).Listar(Me.PenalDestinoId)
                entCol = (New Bussines.General.Penal).ListarRegimen(3)

                cbbRegimenPenal.DataSource = entCol
                cbbRegimenPenal.DisplayMember = "Regimen"
                cbbRegimenPenal.ValueMember = "Codigo"
            Catch ex As Exception
                Dim s As String = ""
                s = s
            End Try

            If entCol.Count > 1 Then Me.RegimenPenalId = -1

        End Sub

        Private Sub CargarCombo()
            ComboRegion()
            ComboRegimenPenitenciario()
        End Sub
#End Region

#Region "Propieades_Grilla"
        Private intGrillaCountAgra As Integer = 0

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

        Private ReadOnly Property GrillaFichaNumClasificacion() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = Me.dgwGrillaFicha.SelectedRows(0).Cells("col_num_clasif").Value
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaFicha() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    Return Me.dgwGrillaFicha.SelectedRows(0).Cells("col_fic_id2").Value
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaTipoFicha() As Type.Enumeracion.Clasificacion.enmTipoFicha
            Get
                Dim intValue As Integer = -1
                Try
                    Return Me.dgwGrillaFicha.SelectedRows(0).Cells("tip_fic_id").Value
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property

        Public ReadOnly Property GrillaFichaDetalle() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    Return dgvFichaVariables.SelectedRows(0).Cells("col_mae_var_id").Value
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaEstadoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = Me.dgwGrillaFicha.SelectedRows(0).Cells("col_estado_id").Value
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaEstadoNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    intValue = Me.dgwGrillaFicha.SelectedRows(0).Cells("col_estado").Value
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property

        Private Property GrillaCount() As Integer
            Get
                Return intGrillaCountAgra
            End Get
            Set(ByVal value As Integer)
                intGrillaCountAgra = value
            End Set
        End Property

        Private Property NumeroClasificacion() As Integer
            Get
                Return Me.txtNumClasificacion.Text
            End Get
            Set(value As Integer)
                Me.txtNumClasificacion.Text = value
            End Set
        End Property
        Private Property SitucionJuridicaId() As Integer
            Get
                Dim id As Integer = -1
                Select Case cboSitJuridica.Text
                    Case "PROCESADO"
                        id = 1
                    Case "SENTENCIADO"
                        id = 2
                    Case Else
                        id = -1
                End Select
                Return id
            End Get
            Set(value As Integer)
                Select Case value
                    Case 1
                        cboSitJuridica.Text = "PROCESADO"
                    Case 2
                        cboSitJuridica.Text = "SENTENCIADO"
                    Case Else
                        cboSitJuridica.Text = "[--SELECCIONE--]"
                End Select
            End Set
        End Property
#End Region

#Region "Grilla_variable"
        Private ReadOnly Property GrillaVariableNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    intValue = Me.dgvFichaVariables.SelectedRows(0).Cells("col_val_nom").Value
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
#End Region

#Region "Propiedades_UserControl"
        Private blnVisibleGrabar As Boolean = False
        Private blnVisibleEliminar As Boolean = False
        Private blnVisibleImprimir As Boolean = False
        Private ReadOnly Property FechaRegistroMovimiento As Long
            Get
                Dim value As Long = 0
                If dtpFecha.ValueLong > 0 Then
                    Dim dteFecha As Date = Me.dtpFecha.Value & " " & dtpHoraETAPA.Value.ToString("HH:mm") & ":00"
                    value = dteFecha.ToFileTime
                Else
                    dtpHoraETAPA.Value = DateTime.Today
                End If

                Return value
            End Get
        End Property

        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(value As Boolean)
                blnVisibleGrabar = value
                ShowControl()
            End Set
        End Property
        Public Property _VisibleEliminar() As Boolean
            Get
                Return blnVisibleEliminar
            End Get
            Set(value As Boolean)
                blnVisibleEliminar = value
                ShowControl()
            End Set
        End Property
        Public Property _VisibleImprimir() As Boolean
            Get
                Return blnVisibleImprimir
            End Get
            Set(value As Boolean)
                blnVisibleImprimir = value
                ShowControl()
            End Set
        End Property
#End Region

#Region "Listar"

        Private Sub Listar()
            If Me._InternoID < 1 Then Exit Sub

            Dim objEntCol As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim ent As New Entity.Clasificacion.InternoClasificacion.InternoFicha

            With ent
                .InternoId = Me._InternoID
                .IngresoInpeId = Me._IngresoInpeId
                .RegionId = Me._RegionID
                .PenalId = Me._PenalID
            End With

            Dim objEntColBD As Entity.Clasificacion.InternoClasificacion.InternoFichaCol = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).ListarGrilla(ent) 'fichas del interno

            '--------------- carga las fichas de las plantillas en funcion a la cantidad de clasificaciones del interno ------------>.
            Dim entFicCol_ As New MaestroFichaCol_BE 'fichas plantilla original
            Dim entFic As New MaestroFicha_BE
            Dim entFicTmplCol As New MaestroFichaCol_BE 'agrupa todas las fichas plantillas

            entFic.AmbitoClasificacionId = enmAmbitoClasificacion.Carceleta
            If objEntColBD.Count = 0 Then 'si es nuevo listar solo el activo
                entFic.EstadoId = 1
            Else
                Dim str_codGrupSecuencial As String = ""
                For Each f As Entity.Clasificacion.InternoClasificacion.InternoFicha In objEntColBD
                    str_codGrupSecuencial = str_codGrupSecuencial & "," & f.GrupoFichaId
                Next
                str_codGrupSecuencial = str_codGrupSecuencial.Substring(1)
                entFic.GrupoSecuencialStr = str_codGrupSecuencial
            End If

            entFicCol_ = (New Bussines.Clasificacion.MaestroFicha).Listar(entFic)
            Me._GrupoFichaId = entFicCol_.Ficha(0).GrupoSecuencial
            Select Case Me._GrupoFichaId
                Case 1, 2
                    Label5.Visible = True
                    txtCategoria.Visible = True
                    col_cat_nom.Visible = True
                Case 3
                    col_cat_nom.Visible = False
                    Label5.Visible = False
                    txtCategoria.Visible = False
                Case 4, 10 '10 directiva RESOL. Nº 198-2023-INPE/P
                    col_cat_nom.Visible = False
                    Label5.Visible = False
                    txtCategoria.Visible = False
                    Label9.Visible = True
                    cboSitJuridica.Visible = True
            End Select

            Dim intCantClasficacion As Integer = 0

            If objEntColBD.Count = 0 Then
                intCantClasficacion = 1
            Else
                intCantClasficacion = Int(objEntColBD.Count / entFicCol_.Count) + If((objEntColBD.Count Mod entFicCol_.Count) > 0, 1, 0)
            End If

            For i As Integer = 1 To intCantClasficacion '
                For Each enti As MaestroFicha_BE In entFicCol_
                    entFicTmplCol.Add(enti)
                Next
            Next
            '<-----------------------------------------------------------------------------------------------------------------

            For Each entfic_ As MaestroFicha_BE In entFicTmplCol

                Dim entobj As New Entity.Clasificacion.InternoClasificacion.InternoFicha

                entobj.FichaId = entfic_.Codigo
                entobj.NumeroClasificacion = 0
                entobj.FichaNombres = entfic_.TipoFichaNombre
                entobj.TipoFichaId = entfic_.TipoFichaId
                For Each entficBD As Entity.Clasificacion.InternoClasificacion.InternoFicha In objEntColBD
                    If entfic_.Codigo = entficBD.FichaId And entficBD.blnValor = False Then
                        entobj.Codigo = entficBD.Codigo
                        entobj.NumeroClasificacion = entficBD.NumeroClasificacion
                        entobj.FechaClasificacion = entficBD.FechaClasificacion
                        entobj.Puntaje = entficBD.Puntaje
                        entobj.CategoriaFichaId = entficBD.CategoriaFichaId
                        entobj.CategoriaFichaNombre = entficBD.CategoriaFichaNombre
                        entobj.Estado = entficBD.Estado
                        entobj.Observacion = entficBD.Observacion
                        entobj.InternoSituacionJuridicaId = entficBD.InternoSituacionJuridicaId
                        entobj.RegimenPenalId = entficBD.RegimenPenalId
                        entficBD.blnValor = True
                        Exit For
                    End If
                Next
                objEntCol.Add(entobj)
            Next

            Me.bListadoIniciado = True 'artificio para controlar que se llame dgwGrillaFicha.CellEnter
            With Me.dgwGrillaFicha
                .RowCount = objEntCol.Count
                Me.GrillaCount = .RowCount
                For f As Integer = 0 To objEntCol.Count - 1
                    .Item("col_codigo", f).Value = objEntCol.InternoClasificacion(f).Codigo
                    .Item("tip_fic_id", f).Value = objEntCol.InternoClasificacion(f).TipoFichaId
                    .Item("col_fic_id2", f).Value = objEntCol.InternoClasificacion(f).FichaId
                    .Item("col_nom_fic", f).Value = objEntCol.InternoClasificacion(f).FichaNombres
                    .Item("col_fec_cla", f).Value = objEntCol.InternoClasificacion(f).FechaClasificacionDate
                    .Item("col_num_clasif", f).Value = objEntCol.InternoClasificacion(f).NumeroClasificacion
                    .Item("col_ptje", f).Value = objEntCol.InternoClasificacion(f).Puntaje
                    .Item("col_id_cat", f).Value = objEntCol.InternoClasificacion(f).CategoriaFichaId
                    .Item("col_cat_nom", f).Value = objEntCol.InternoClasificacion(f).CategoriaFichaNombre
                    .Item("col_estado", f).Value = objEntCol.InternoClasificacion(f).EstadoNombre
                    .Item("col_estado_id", f).Value = objEntCol.InternoClasificacion(f).EstadoId
                    .Item("col_obs", f).Value = objEntCol.InternoClasificacion(f).Observacion
                    .Item("col_sit_jur", f).Value = objEntCol.InternoClasificacion(f).InternoSituacionJuridicaId
                    .Item("col_regimen_id", f).Value = objEntCol.InternoClasificacion(f).RegimenPenalId
                Next
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AutoGenerateColumns = False
            End With
            Me.bListadoIniciado = False

            For Each f As DataGridViewRow In dgwGrillaFicha.Rows
                If f.Cells("tip_fic_id").Value = enmTipoFicha.Final Then
                    f.DefaultCellStyle.Font = New Font(Me.dgwGrillaFicha.DefaultCellStyle.Font, FontStyle.Bold)
                End If

                Select Case f.Cells("col_estado").Value
                    Case "PENDIENTE"
                        f.Cells("col_estado").Style.ForeColor = Color.Brown
                    Case "FINALIZADO"
                        f.Cells("col_estado").Style.ForeColor = Color.Black
                    Case Else
                        f.Cells("col_estado").Style.ForeColor = Color.Black
                End Select
            Next

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                dgwGrillaFicha.Rows(i).Visible = True
                dgwGrillaFicha.Rows(0).Selected = True
            Next

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1

                Try
                    If dgwGrillaFicha.Rows(i).Visible = True Then
                        Try
                            Me.dgwGrillaFicha.CurrentCell = Nothing
                        Catch ex As Exception

                        End Try
                        dgwGrillaFicha.Rows(i).Selected = True
                        Me.dgwGrillaFicha.CurrentCell = Me.dgwGrillaFicha(3, i)

                        Exit For
                    End If
                Catch ex As Exception

                End Try

            Next
        End Sub

        Private Sub ActualizarGrillaFicha()
            Dim objEntCol As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim objEntColBD As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol


            Dim filaActual As Integer = 0
            If Not dgwGrillaFicha.CurrentRow Is Nothing Then
                filaActual = dgwGrillaFicha.CurrentRow.Index
            End If

            Dim ent As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                .InternoId = Me._InternoID,
                .IngresoInpeId = Me._IngresoInpeId,
                .RegionId = Me._RegionID,
                .PenalId = Me._PenalID
            }

            objEntColBD = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).ListarGrilla(ent) 'fichas del interno

            '--------------- carga las fichas de las plantillas en funcion a la cantidad de clasificaciones del interno ------------>.
            Dim entFicCol_ As New MaestroFichaCol_BE 'fichas plantilla original
            Dim entFic As New MaestroFicha_BE
            Dim entFicTmplCol As New MaestroFichaCol_BE 'agrupa todas las fichas plantillas

            entFic.AmbitoClasificacionId = enmAmbitoClasificacion.Carceleta
            If objEntColBD.Count = 0 Then 'si es nuevo listar solo el activo
                entFic.EstadoId = 1
            Else
                Dim str_codGrupSecuencial As String = ""
                For Each f As Entity.Clasificacion.InternoClasificacion.InternoFicha In objEntColBD
                    str_codGrupSecuencial = str_codGrupSecuencial & "," & f.GrupoFichaId
                Next
                str_codGrupSecuencial = str_codGrupSecuencial.Substring(1)
                entFic.GrupoSecuencialStr = str_codGrupSecuencial
            End If

            entFicCol_ = (New Bussines.Clasificacion.MaestroFicha).Listar(entFic)
            Dim intCantClasficacion As Integer = 0

            If objEntColBD.Count = 0 Then
                intCantClasficacion = 1
            Else
                intCantClasficacion = Int(objEntColBD.Count / entFicCol_.Count) + If((objEntColBD.Count Mod entFicCol_.Count) > 0, 1, 0)
            End If

            For i As Integer = 1 To intCantClasficacion '
                For Each enti As MaestroFicha_BE In entFicCol_
                    entFicTmplCol.Add(enti)
                Next
            Next
            '<-----------------------------------------------------------------------------------------------------------------

            For Each entfic_ As MaestroFicha_BE In entFicTmplCol

                Dim entobj As New Entity.Clasificacion.InternoClasificacion.InternoFicha

                entobj.FichaId = entfic_.Codigo
                entobj.NumeroClasificacion = 0
                entobj.FichaNombres = entfic_.TipoFichaNombre
                entobj.TipoFichaId = entfic_.TipoFichaId
                For Each entficBD As Entity.Clasificacion.InternoClasificacion.InternoFicha In objEntColBD
                    If entfic_.Codigo = entficBD.FichaId And entficBD.blnValor = False Then
                        entobj.Codigo = entficBD.Codigo
                        entobj.NumeroClasificacion = entficBD.NumeroClasificacion
                        entobj.FechaClasificacion = entficBD.FechaClasificacion
                        entobj.Puntaje = entficBD.Puntaje
                        entobj.CategoriaFichaId = entficBD.CategoriaFichaId
                        entobj.CategoriaFichaNombre = entficBD.CategoriaFichaNombre
                        entobj.Estado = entficBD.Estado
                        entobj.Observacion = entficBD.Observacion
                        entobj.InternoSituacionJuridicaId = entficBD.InternoSituacionJuridicaId
                        entficBD.blnValor = True
                        Exit For
                    End If
                Next
                objEntCol.Add(entobj)
            Next

            With Me.dgwGrillaFicha
                .RowCount = objEntCol.Count
                Me.GrillaCount = .RowCount
                For f As Integer = 0 To objEntCol.Count - 1
                    .Item("col_codigo", f).Value = objEntCol.InternoClasificacion(f).Codigo
                    .Item("tip_fic_id", f).Value = objEntCol.InternoClasificacion(f).TipoFichaId
                    .Item("col_fic_id2", f).Value = objEntCol.InternoClasificacion(f).FichaId
                    .Item("col_nom_fic", f).Value = objEntCol.InternoClasificacion(f).FichaNombres
                    .Item("col_fec_cla", f).Value = objEntCol.InternoClasificacion(f).FechaClasificacionDate
                    .Item("col_num_clasif", f).Value = objEntCol.InternoClasificacion(f).NumeroClasificacion
                    .Item("col_ptje", f).Value = objEntCol.InternoClasificacion(f).Puntaje
                    .Item("col_id_cat", f).Value = objEntCol.InternoClasificacion(f).CategoriaFichaId
                    .Item("col_cat_nom", f).Value = objEntCol.InternoClasificacion(f).CategoriaFichaNombre
                    .Item("col_estado", f).Value = objEntCol.InternoClasificacion(f).EstadoNombre
                    .Item("col_estado_id", f).Value = objEntCol.InternoClasificacion(f).EstadoId
                    .Item("col_obs", f).Value = objEntCol.InternoClasificacion(f).Observacion
                    .Item("col_sit_jur", f).Value = objEntCol.InternoClasificacion(f).InternoSituacionJuridicaId
                Next
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AutoGenerateColumns = False
            End With

            For Each f As DataGridViewRow In dgwGrillaFicha.Rows
                If f.Cells("tip_fic_id").Value = enmTipoFicha.Final Then
                    f.DefaultCellStyle.Font = New Font(Me.dgwGrillaFicha.DefaultCellStyle.Font, FontStyle.Bold)
                End If

                Select Case f.Cells("col_estado").Value
                    Case "PENDIENTE"
                        f.Cells("col_estado").Style.ForeColor = Color.Brown
                    Case "FINALIZADO"
                        f.Cells("col_estado").Style.ForeColor = Color.Black
                    Case Else
                        f.Cells("col_estado").Style.ForeColor = Color.Black
                End Select
            Next

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                dgwGrillaFicha.Rows(i).Visible = True
                dgwGrillaFicha.Rows(0).Selected = True
            Next

            Try
                dgwGrillaFicha.Rows(filaActual).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(filaActual).Cells("col_nom_fic")
            Catch ex As Exception

            End Try

        End Sub

        Private Sub ListarValores()
            'Me.UscAuditUser1.LoadAudit(Me.GrillaFichaCodigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoFichaClasificacion)

            Dim entDetFic As New Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle
            Dim entDetFicCol As New Entity.Clasificacion.InternoClasificacion.InternoFichaDetalleCol
            Dim bssDetFic As New Bussines.Clasificacion.InternoClasificacion.InternoFichaDetalle_BL

            Dim bssval As New Bussines.Clasificacion.MaestroIndicador
            Dim bssFich As New Bussines.Clasificacion.MaestroVariable
            Dim entVar As New MaestroVariable_BE
            Dim entVarCol As New MaestroVariableCol_BE

            Dim entIntFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha
            Dim bssIntFic As New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL

            '    '******************************** cargar InternoFicha *****************************
            If Me.GrillaFichaCodigo < 1 Then
                With entIntFic
                    Me._FichaId = Me.GrillaFicha
                    Me.FechaClasificacion = Now.ToFileTime
                    Me.NumeroClasificacion = 0
                    Me._EtapaFichaId = -1
                    Me.CategoriaFichaNombre = ""
                    Me.Observacion = ""
                    Me.Puntaje = 0
                    Me.RegionDestinoId = -1
                    Me.PenalDestinoId = -1
                    Me.RegimenPenalId = -1
                    Me._RegionID = Me._RegionID
                    Me._PenalID = Me._PenalID
                    dtpHoraETAPA.Value = DateTime.Today
                    Me.SitucionJuridicaId = -1
                End With
                If Me.GrillaTipoFicha = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                    Dim v As Integer = dgwGrillaFicha.Item("col_num_clasif", 0).Value
                    For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                        If dgwGrillaFicha.Item("col_num_clasif", 0).Value > v Then
                            v = dgwGrillaFicha.Item("col_num_clasif", 0).Value
                        End If
                    Next
                    Me.NumeroClasificacion = v + 1
                End If

                'cargar situacion juridica de la ficha lagal
                For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                    If dgwGrillaFicha.Item("tip_fic_id", i).Value = 1 Then
                        Me.SitucionJuridicaId = dgwGrillaFicha.Item("col_sit_jur", i).Value
                    End If
                Next
                cboSitJuridica.Enabled = False
                If Me.SitucionJuridicaId = -1 And Me.GrillaTipoFicha = enmTipoFicha.Legal Then
                    cboSitJuridica.Enabled = True
                End If
            Else
                Dim entFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha
                entFic.Codigo = Me.GrillaFichaCodigo
                If Me._GrupoFichaId > 2 Then
                    entIntFic = bssIntFic.Listar_v2(entFic).InternoClasificacion(0)
                Else 'version antigua
                    entIntFic = bssIntFic.Listar(entFic).InternoClasificacion(0)
                End If
                With entIntFic
                    Me.Observacion = .Observacion
                    Me.FechaClasificacion = .FechaClasificacion
                    Dim f As Date = Legolas.Components.FechaHora.FechaDate(.FechaClasificacion, True)
                    dtpHoraETAPA.Value = f
                    'Me.HoraClasif = Format(f, "HH")
                    'Me.MinutoClasif = Format(f, "mm")
                    Me._FichaId = Me.GrillaFicha
                    Me.NumeroClasificacion = .NumeroClasificacion
                    Me._EtapaFichaId = .CategoriaFichaId

                    Me.RegionDestinoId = .RegionDestinoId
                    Me.PenalDestinoId = .PenalDestinoId
                    Me.RegimenPenalId = .RegimenPenalId
                    Me.Puntaje = .Puntaje
                    Me.SitucionJuridicaId = .InternoSituacionJuridicaId
                    Me.lblModificadoPor.Text = .MotivoModifPenalDet
                    If Me._GrupoFichaId = 4 Or Me._GrupoFichaId = 10 Then
                        cboSitJuridica.Enabled = False
                        If entIntFic.TipoFicha = enmTipoFicha.Legal Then
                            cboSitJuridica.Enabled = If(Me.SitucionJuridicaId > 0, False, True)
                        End If
                    End If

                    Select Case Me._GrupoFichaId
                        Case 1 'version inicial
                            Me.CategoriaFichaNombre = dgwGrillaFicha.Item("col_cat_nom", dgwGrillaFicha.CurrentCell.RowIndex).Value
                        Case 2
                            Me.CategoriaFichaNombre = .CategoriaFichaNombre
                        Case > 2 'nueva version 2018-01
                            If .MotivoModifPenalDet.Length > 0 Then
                                btnEdiPenal.Enabled = True
                                btnCancelPenal.Enabled = True
                                cbbRegionDestino.Enabled = True
                                cbbPenalDestino.Enabled = True
                                cbbRegimenPenal.Enabled = True
                            Else
                                btnEdiPenal.Enabled = True
                                btnCancelPenal.Enabled = False
                                cbbRegionDestino.Enabled = False
                                cbbPenalDestino.Enabled = False
                                cbbRegimenPenal.Enabled = False
                            End If
                    End Select
                End With
            End If

            Select Case Me.GrillaEstadoId
                Case enmEstadoRegistroFicha.Pendiente
                    btnBloqDesbloq.Tag = "LOCK"
                    btnBloqDesbloq.BackgroundImage = My.Resources.Desbloquear
                    ToolTip1.SetToolTip(btnBloqDesbloq, "Finalizar registro")
                    gbUbicacion.Enabled = True
                Case enmEstadoRegistroFicha.Finalizado
                    btnBloqDesbloq.Tag = "UNLOCK"
                    btnBloqDesbloq.BackgroundImage = My.Resources.Bloquear
                    ToolTip1.SetToolTip(btnBloqDesbloq, "Desbloquear registro")
                Case enmEstadoRegistroFicha.Bloqueado
                    btnBloqDesbloq.Tag = ""
                    btnBloqDesbloq.BackgroundImage = My.Resources.Cerrado
            End Select

            '******************************** cargar detalles  *****************************

            btnFormato06_legal.Visible = False
            btnFormato06_social.Visible = False
            btnFormato06_psicologica.Visible = False


            If Me.GrillaTipoFicha = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                dgvFichaVariables.Visible = False
                If Me.PerfilUsuario = EnumDependencia.Legal Or (Me.PerfilUsuario = EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3) Then
                    gbUbicacion.Visible = True
                    Panel3.Dock = DockStyle.Fill
                    txtNumClasificacion.ReadOnly = False
                    If Me._GrupoFichaId = 1 Then

                    ElseIf Me._GrupoFichaId = 2 Then
                        EvaluarCategoriaFinal_Grupo02()
                    ElseIf Me._GrupoFichaId = 3 Then
                        If lblModificadoPor.Text.Length = 0 Then 'recalcular solo si no es manual (si es manual debe existir motivo modif).
                            EvaluarCategoriaFinal_Grupo03()
                        End If
                    ElseIf Me._GrupoFichaId = 4 Then 'grupo4
                        If lblModificadoPor.Text.Length = 0 Then 'recalcular solo si no es manual (si es manual debe existir motivo modif).
                            EvaluarCategoriaFinal_Grupo04()
                        End If
                    Else 'grupo 10
                        If lblModificadoPor.Text.Length = 0 Then 'recalcular solo si no es manual (si es manual debe existir motivo modif).
                            EvaluarCategoriaFinal_Grupo10()
                        End If
                    End If

                    cmdCancel.Visible = Me._VisibleGrabar
                    btnAceptar.Visible = Me._VisibleGrabar
                Else
                    gbUbicacion.Visible = True
                    Panel3.Dock = DockStyle.Fill
                    txtNumClasificacion.ReadOnly = False
                    If Me._GrupoFichaId <= 2 Then
                        EvaluarCategoriaFinal_Grupo02()
                    ElseIf Me._GrupoFichaId = 3 Then
                        If lblModificadoPor.Text.Length = 0 Then 'recalcular solo si no es manual (si es manual debe existir motivo modif).
                            EvaluarCategoriaFinal_Grupo03()
                        End If
                    ElseIf Me._GrupoFichaId = 4 Then 'grupo 4
                        If lblModificadoPor.Text.Length = 0 Then 'recalcular solo si no es manual (si es manual debe existir motivo modif).
                            EvaluarCategoriaFinal_Grupo04()
                        End If
                    Else 'grupo 10
                        If lblModificadoPor.Text.Length = 0 Then 'recalcular solo si no es manual (si es manual debe existir motivo modif).
                            EvaluarCategoriaFinal_Grupo10()
                        End If
                    End If
                    cmdCancel.Visible = True
                    btnAceptar.Visible = False
                    Exit Sub
                End If

            Else
                gbDetalle.Visible = True
                Panel3.Dock = DockStyle.Bottom
                txtNumClasificacion.ReadOnly = True
                lblPuntaje.Visible = True
                txtPuntTotal.Visible = True
                dgvFichaVariables.Visible = True
                dgvFichaVariables.Dock = DockStyle.Fill
                gbUbicacion.Visible = False
                'gbDetalle.Dock = DockStyle.Bottom

                cmdCancel.Visible = Me._VisibleGrabar
                btnAceptar.Visible = Me._VisibleGrabar

                entDetFic.InternoFichaId = Me.GrillaFichaCodigo
                If Me.GrillaFichaCodigo > 0 Then
                    entDetFicCol = bssDetFic.Listar(entDetFic)
                End If
                ''******************************** cargar plantilla ficha **************************
                entVar.FichaID = Me.GrillaFicha
                entVarCol = bssFich.Listar(entVar)
                ''------- pintar sobre la grilla de la plantilla -------
                Dim entValTmp As MaestroIndicador_BE
                With dgvFichaVariables
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = entVarCol
                End With
                For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                    For Each objDetFin As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle In entDetFicCol
                        With dgvFichaVariables
                            If .Item("col_mae_var_id", i).Value = objDetFin.VariableId Then
                                .Item("col_ptje2", i).Value = objDetFin.Ponderacion
                                .Item("col_ptje_noprev", i).Value = objDetFin.PonderacionNoPrevista
                                .Item("col_fic_det_id", i).Value = objDetFin.Codigo
                                entValTmp = New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE
                                entValTmp = bssval.Listar2(objDetFin.IndicadorId, objDetFin.VariableId, Me.GrillaFicha)
                                If Not entValTmp Is Nothing Then
                                    .Item("col_val_id_sel", i).Value = objDetFin.IndicadorId
                                    .Item("col_valor", i).Value = entValTmp.Descripcion
                                Else
                                    .Item("col_val_id_sel", i).Value = -1
                                End If
                            End If
                        End With
                    Next
                Next

                'ocultar columna de grilla en funcion al perfil de usuario
                Select Case Me.PerfilUsuario
                    Case EnumDependencia.SistemasInformacion
                        dgvFichaVariables.Columns("col_buton").Visible = True
                    Case EnumDependencia.Legal
                        dgvFichaVariables.Columns("col_buton").Visible = If(Me.GrillaTipoFicha = enmTipoFicha.Legal, True, False)
                    Case EnumDependencia.Social
                        dgvFichaVariables.Columns("col_buton").Visible = If(Me.GrillaTipoFicha = enmTipoFicha.Social, True, False)
                    Case EnumDependencia.Psicologo
                        dgvFichaVariables.Columns("col_buton").Visible = If(Me.GrillaTipoFicha = enmTipoFicha.Psicologica, True, False)
                    Case Else
                        dgvFichaVariables.Columns("col_buton").Visible = False
                End Select
            End If
            '--------------------
            For Each f As DataGridViewRow In dgvFichaVariables.Rows
                'f.Cells("col_valor").Style.ForeColor = Color.Black '.Green
                f.Cells("col_valor").Style.Font = New Font(dgvFichaVariables.Font, FontStyle.Bold)
            Next

            dgvFichaVariables.AllowUserToResizeRows = False
            dgvFichaVariables.AutoGenerateColumns = False

            btnImprimirF06.Visible = False

            If Me.GrillaEstadoId = enmEstadoRegistroFicha.Finalizado Or Me.GrillaEstadoId = enmEstadoRegistroFicha.Bloqueado Then ' Or (Me.GrillaNumClasificacion > 0 And GrillaTipoFicha <> enmTipoFicha.Final) Then
                btnAceptar.Enabled = False
                cmdCancel.Enabled = False
                btnAceptar.BackgroundImage = My.Resources.Diskette_32x32_gris
                cmdCancel.BackgroundImage = My.Resources.anular2_gris
                gbUbicacion.Enabled = False

                btnFormato06_legal.Visible = False
                btnFormato06_social.Visible = False
                btnFormato06_psicologica.Visible = False


                If (Me._GrupoFichaId = 4 Or Me._GrupoFichaId = 10) And (Me.GrillaEstadoId = enmEstadoRegistroFicha.Bloqueado Or Me.GrillaEstadoId = enmEstadoRegistroFicha.Finalizado) AndAlso Me.cboSitJuridica.Text = "PROCESADO" Then
                    If Me.GrillaTipoFicha = enmTipoFicha.Legal And (Me.PerfilUsuario = EnumDependencia.Legal Or (EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3)) Then
                        btnFormato06_legal.Visible = True
                    End If
                    If Me.GrillaTipoFicha = enmTipoFicha.Social And (Me.PerfilUsuario = EnumDependencia.Social Or (EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3)) Then
                        btnFormato06_social.Visible = True
                    End If
                    If Me.GrillaTipoFicha = enmTipoFicha.Psicologica And (Me.PerfilUsuario = EnumDependencia.Psicologo Or (EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3)) Then
                        btnFormato06_psicologica.Visible = True
                    End If
                    If Me.GrillaTipoFicha = enmTipoFicha.Final And (Me.PerfilUsuario = EnumDependencia.Legal And Me.RegimenPenalId = 2 Or (EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3)) Then
                        btnImprimirF06.Visible = True
                    End If
                End If

                Exit Sub
            End If

            Select Case Me.PerfilUsuario
                Case EnumDependencia.Social
                    btnAceptar.Enabled = True
                    cmdCancel.Enabled = True
                    btnAceptar.BackgroundImage = My.Resources.Diskette_32x32
                    cmdCancel.BackgroundImage = My.Resources.anular2
                Case EnumDependencia.Psicologo
                    btnAceptar.Enabled = True
                    cmdCancel.Enabled = True
                    btnAceptar.BackgroundImage = My.Resources.Diskette_32x32
                    cmdCancel.BackgroundImage = My.Resources.anular2
                Case EnumDependencia.Legal
                    If Me.GrillaTipoFicha = enmTipoFicha.Psicologica Or Me.GrillaTipoFicha = enmTipoFicha.Social Then
                        If Me.GrillaEstadoId <> enmEstadoRegistroFicha.Bloqueado Then
                            btnAceptar.Enabled = True
                            cmdCancel.Enabled = True
                            btnAceptar.BackgroundImage = My.Resources.Diskette_32x32
                            cmdCancel.BackgroundImage = My.Resources.anular2
                        Else
                            btnAceptar.Enabled = False
                            cmdCancel.Enabled = False
                            btnAceptar.BackgroundImage = My.Resources.accept_32_gris
                            cmdCancel.BackgroundImage = My.Resources.anular2_gris
                        End If
                    Else
                        btnAceptar.Enabled = True
                        cmdCancel.Enabled = True
                        btnAceptar.BackgroundImage = My.Resources.Diskette_32x32
                        cmdCancel.BackgroundImage = My.Resources.anular2
                    End If
                Case EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3 '3= nivel sede central
                    btnAceptar.Enabled = True
                    cmdCancel.Enabled = True
                    btnAceptar.BackgroundImage = My.Resources.Diskette_32x32
                    cmdCancel.BackgroundImage = My.Resources.anular2
                Case Else
                    btnAceptar.Enabled = False
                    cmdCancel.Enabled = False
                    btnAceptar.BackgroundImage = My.Resources.accept_32_gris
                    cmdCancel.BackgroundImage = My.Resources.anular2_gris
            End Select

            If btnAceptar.Enabled = True Then
                gbUbicacion.Enabled = True
            End If
            strDatosActual = ConcatenarValores()



        End Sub

        'jescobar
        Public Sub Listar2(puntaje As Integer, Nombre As String, ValorIdSeleccionado As Integer, ValorNoPrevisto As Integer)
            With dgvFichaVariables
                .Item("col_val_id_sel", .CurrentRow.Index).Value = ValorIdSeleccionado
                .Item("col_valor", .CurrentRow.Index).Value = Nombre  ' f.ValorNombreSeleccionado
                .Item("col_ptje_noprev", .CurrentRow.Index).Value = ValorNoPrevisto
                .Item("col_ptje2", .CurrentRow.Index).Value = puntaje ' f.ValorPuntaje
            End With
            CalcularPuntajeTotal_v2()
        End Sub

#End Region

#Region "Accion"

        Private Function Validar() As Boolean
            If (Me.CategoriaFichaNombre = "" And Me._GrupoFichaId = 2) Or (Me.GrillaTipoFicha = enmTipoFicha.Final) Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Datos incompletos, no se ha podido determinar la categoria.")
                Return False
            End If
            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("tip_fic_id", i).Value = enmTipoFicha.Final _
                    And dgwGrillaFicha.Item("col_estado_id", i).Value = enmEstadoRegistroFicha.Pendiente _
                    And dgwGrillaFicha.Item("col_cat_nom", i).Value <> "" Then '

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Los resultados de la ficha final depende de la ficha que está modificando, para modificar se sugiere eliminar la ficha final")
                    Return False

                End If

                If Me.GrillaFichaCodigo > 0 Then
                    Dim intFic As Entity.Clasificacion.InternoClasificacion.InternoFicha
                    intFic = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).Listar_V2(Me.GrillaFichaCodigo)

                    If intFic.FichaFinalId > 0 Then 'si la ficha actual ya fue referenciada por la ficha final
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Los resultados de la ficha final depende de la ficha que está modificando, para modificar " &
                                                                                "y no alterar el resultado el resultado fichal se sugiere eliminar la ficha final.")
                        Return False
                    End If
                End If
            Next

            For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1

                If (Me._GrupoFichaId = 4 Or Me._GrupoFichaId = 10) And Me.GrillaFichaCodigo <= 0 And dgwGrillaFicha.Item("tip_fic_id", dgwGrillaFicha.CurrentRow.Index).Value = enmTipoFicha.Legal Then Continue For

                If dgvFichaVariables.Item("col_valor", i).Value <> Nothing AndAlso dgvFichaVariables.Item("col_valor", i).Value.ToString = String.Empty Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Debe seleccionar el valor correspondiente a la variable " & dgvFichaVariables.Item("col_val_nom", i).Value.ToUpper)
                    Return False
                End If

            Next

            If Me.FechaClasificacion = 0 Or Me.FechaClasificacion > Now.ToFileTime Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Fecha de clasificación incorrecta.")
                dtpFecha.Focus()
                Return False
            End If

            Return True
        End Function

        Private Function UsuarioAutorizado() As Boolean
            Select Case Me.PerfilUsuario
                Case EnumDependencia.Social
                    If Me.GrillaTipoFicha <> enmTipoFicha.Social Then Return False

                Case EnumDependencia.Psicologo
                    If Me.GrillaTipoFicha <> enmTipoFicha.Psicologica Then Return False

                Case EnumDependencia.Legal
                    If Me.GrillaTipoFicha = enmTipoFicha.Psicologica Or Me.GrillaTipoFicha = enmTipoFicha.Social Then Return False

                Case EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3
                    Return True

                Case Else
                    Return False
            End Select
            Return True
        End Function

        Private Sub AELiminarFicha()
            Dim Bss As New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL
            Dim intFic As Entity.Clasificacion.InternoClasificacion.InternoFicha
            Dim outSms As String = ""

            If Me._InternoID <= 0 Or Me._IngresoInpeId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione un registro a eliminar.")
                Exit Sub
            End If
            If Me.GrillaEstadoId = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ficha sin datos.")
                Exit Sub
            End If
            If Me.GrillaEstadoId = enmEstadoRegistroFicha.Finalizado Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ficha en estado finalizado, para poder eliminar el registro debe desbloquear el registro.")
                Exit Sub
            End If

            If UsuarioAutorizado() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No está autorizado para eliminar el registro, el único autorizado es quien generó la ficha")
                Exit Sub
            End If

            'no se debe permitir eliminar la ficha legal en caso los demas ya hayan clasificado, dado que el legal determina la situacion juridica.
            If Me.GrillaTipoFicha = enmTipoFicha.Legal And Me.GrillaEstadoId <> enmEstadoRegistroFicha.Bloqueado Then RefrescarGrillas()

            Select Case Me.GrillaEstadoId
                Case enmEstadoRegistroFicha.Pendiente
                    If GrillaTipoFicha <> enmTipoFicha.Final Then
                        For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                            If dgwGrillaFicha.Item("tip_fic_id", i).Value = enmTipoFicha.Final And dgwGrillaFicha.Item("col_estado_id", i).Value <> enmEstadoRegistroFicha.Pendiente And dgwGrillaFicha.Item("col_estado_id", i).Value <> enmEstadoRegistroFicha.Ninguno Then '
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha final depende de la ficha que está eliminando, se sugiere eliminar primero la ficha final")
                                Exit Sub
                            End If
                        Next
                    End If
                    intFic = Bss.Listar_V2(Me.GrillaFichaCodigo)
                    If intFic.FichaFinalId > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede cambiar el estado de la ficha seleccionada porque la ficha final ya fue generada, para completar la operación debe eliminar la ficha final.")
                        Exit Sub
                    End If
                Case enmEstadoRegistroFicha.Bloqueado
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible eliminar el registro seleccionado, estado de ficha bloqueado")
                    Exit Sub
            End Select

            If Me.GrillaFichaCodigo < 0 Then Exit Sub

            'si es ficha legal no debe existir ninguna otra ficha
            If Me._GrupoFichaId = 4 Or Me._GrupoFichaId = 10 Then 'tanto el grupo 4 y 10 son similares, solo cambia puntajes
                If Me.GrillaTipoFicha = enmTipoFicha.Legal Then
                    Dim catFicDepen As Integer = 0
                    For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                        If dgwGrillaFicha.Item("tip_fic_id", i).Value <> 1 And dgwGrillaFicha.Item("col_ptje", i).Value > 0 Then 'diferente de ficha legal
                            catFicDepen = catFicDepen + 1
                        End If
                    Next
                    If catFicDepen > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("Primero elimine todas las demas fichas.")
                        Exit Sub
                    End If
                End If
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                If Bss.Eliminar(Me.GrillaFichaCodigo, outSms) = -1 Then 'se envia el tipo de ficha solo si es fic final para seretear el num de clasif de otrs fichas dependientes a 0.
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(outSms)
                    Exit Sub
                End If

                Dim filaActual As Integer = 0
                If Not dgwGrillaFicha.CurrentRow Is Nothing Then
                    filaActual = dgwGrillaFicha.CurrentRow.Index
                End If
                Listar()
                Try
                    dgwGrillaFicha.Rows(filaActual).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                    dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(filaActual).Cells("col_nom_fic")
                Catch ex As Exception
                End Try
                ListarValores()
                strDatosActual = ""
            End If
        End Sub

        Private Sub AgregarPlantillaFichas()
            If Me._IngresoInpeId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningún Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar.")
                Exit Sub
            End If

            Dim blnValor As Boolean = False
            If Me._EstadoInterno = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Interno inactivo, no es posible completar la operación.")
                Exit Sub
            End If

            btnRefresh.PerformClick()

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("col_estado_id", i).Value = enmEstadoRegistroFicha.Pendiente And dgwGrillaFicha.Rows(i).Visible = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede agregar una reclasificación mientras existan fichas en estado pendiente, debe finalizar dichos registros.")
                    Exit Sub
                End If
                If dgwGrillaFicha.Item("col_estado_id", i).Value <> enmEstadoRegistroFicha.Bloqueado And dgwGrillaFicha.Rows(i).Visible = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede agregar una reclasificación mientras no se hayan consolidado la ficha final en un oficio.")
                    Exit Sub
                End If
            Next
            'verificar por BD
            If Me.PerfilUsuario <> EnumDependencia.Legal And Me.PerfilUsuario <> EnumDependencia.SistemasInformacion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El único usuario que puede agregar una nueva reclasificación es el usuario con el perfil legal.")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.Question("Está seguro de agregar nuevas fichas de clasificación") = DialogResult.Yes Then

                'verificar que se haya finalizado la ficha final.

                blnValor = True
            Else
                Exit Sub
            End If

            If blnValor = True Then
                With dgwGrillaFicha
                    Dim posicion As Integer = dgwGrillaFicha.Rows.Count
                    Dim bssFic As New Bussines.Clasificacion.MaestroFicha
                    Dim entFicCol_ As New MaestroFichaCol_BE
                    Dim entFic As New MaestroFicha_BE

                    entFic.AmbitoClasificacionId = 1
                    entFic.EstadoId = 1 'solo activo
                    entFicCol_ = bssFic.Listar(entFic)
                    For i As Integer = 0 To entFicCol_.Count - 1
                        .Rows.Add()
                        .Rows(posicion + i).Cells("col_codigo").Value = -1
                        .Rows(posicion + i).Cells("col_fic_id2").Value = entFicCol_.Ficha(i).Codigo
                        .Rows(posicion + i).Cells("tip_fic_id").Value = entFicCol_.Ficha(i).TipoFicha
                        .Rows(posicion + i).Cells("col_nom_fic").Value = entFicCol_.Ficha(i).TipoFichaNombre
                        .Rows(posicion + i).Cells("col_num_clasif").Value = 0
                        .Rows(posicion + i).Cells("col_ptje").Value = 0
                        .Rows(posicion + i).Cells("col_estado_id").Value = 0
                        .Rows(posicion + i).Cells("col_estado").Value = "PENDIENTE"
                    Next

                    For Each f As DataGridViewRow In dgwGrillaFicha.Rows
                        If f.Cells("tip_fic_id").Value = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then f.DefaultCellStyle.Font = New Font(Me.dgwGrillaFicha.DefaultCellStyle.Font, FontStyle.Bold)

                        Select Case f.Cells("col_estado").Value
                            Case "FINALIZADO", "PENDIENTE"
                                f.Cells("col_estado").Style.ForeColor = Color.Brown
                            Case Else
                                f.Cells("col_estado").Style.ForeColor = Color.Black
                        End Select
                    Next
                End With

                'ocultar registros de acuerdo al perfil del usuario
                Select Case Me.PerfilUsuario
                    Case EnumDependencia.Psicologo
                        For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                            If dgwGrillaFicha.Item("tip_fic_id", i).Value = Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica Then
                                dgwGrillaFicha.Rows(i).Visible = True
                                dgwGrillaFicha.Rows(i).Selected = True
                                dgwGrilla_CellClick(Nothing, Nothing)
                            Else
                                dgwGrillaFicha.Rows(i).Visible = False
                            End If
                        Next
                    Case EnumDependencia.Social
                        For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                            If dgwGrillaFicha.Item("tip_fic_id", i).Value = Type.Enumeracion.Clasificacion.enmTipoFicha.Social Then
                                dgwGrillaFicha.Rows(i).Visible = True
                                dgwGrillaFicha.Rows(i).Selected = True
                                dgwGrilla_CellClick(Nothing, Nothing)
                            Else
                                dgwGrillaFicha.Rows(i).Visible = False
                            End If
                        Next
                    Case Else
                        For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                            dgwGrillaFicha.Rows(i).Visible = True
                            dgwGrillaFicha.Rows(0).Selected = True
                            dgwGrilla_CellClick(Nothing, Nothing)
                        Next
                End Select
            End If
        End Sub

        Private Function AGrabar() As Boolean

            If Validar() = False Then Return False

            Dim outErrSms As String = ""
            Dim intValue As Integer = -1
            Dim objBssDet As New Bussines.Clasificacion.InternoClasificacion.InternoFichaDetalle_BL
            Dim objBss As New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL
            Dim ent As New Entity.Clasificacion.InternoClasificacion.InternoFicha
            With ent
                .Codigo = Me.GrillaFichaCodigo
                .InternoId = Me._InternoID
                .IngresoInpeId = Me._IngresoInpeId
                .FichaId = Me.GrillaFicha
                .CategoriaFichaId = Me._EtapaFichaId
                .FichaFinalId = -1
                .RegionDestinoId = -1
                .PenalDestinoId = -1
                .NumeroClasificacion = Me.NumeroClasificacion
                .FechaClasificacion = Me.FechaRegistroMovimiento ' dtpFecha.ValueLong
                .Observacion = Me.txtobservacion.Text
                .Puntaje = Double.Parse(txtPuntTotal.Text)
                .Estado = If(GrillaFichaCodigo = -1, 0, Me.GrillaEstadoId)
                .RegionId = Me._RegionID
                .PenalId = Me._PenalID
                If Me._GrupoFichaId <> 3 Then
                    .CategoriaFichaNombre = Me.CategoriaFichaNombre
                End If
                .TipoFichaId = Me.GrillaTipoFicha
                .GrupoFichaId = Me._GrupoFichaId
                .InternoSituacionJuridicaId = Me.SitucionJuridicaId
            End With

            intValue = objBss.Grabar(ent, outErrSms)
            If intValue = -1 Then
                If outErrSms.Length > 0 Then Legolas.Configuration.Aplication.MessageBox.MensajeError(outErrSms)
                Return False
            Else
                cboSitJuridica.Enabled = False
            End If

            '----------------------- guardar detalles -------------------------
            outErrSms = ""
            Dim IdDetFic As Integer = -1

            For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                Dim entDet As New Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle

                With entDet
                    .Codigo = If(dgvFichaVariables.Item("col_fic_det_id", i).Value Is Nothing, -1, dgvFichaVariables.Item("col_fic_det_id", i).Value)
                    .InternoFichaId = intValue
                    .VariableId = dgvFichaVariables.Item("col_mae_var_id", i).Value
                    .IndicadorId = If(dgvFichaVariables.Item("col_val_id_sel", i).Value = Nothing, -1, dgvFichaVariables.Item("col_val_id_sel", i).Value)
                    .Ponderacion = If(dgvFichaVariables.Item("col_ptje_noprev", i).Value > 0, 0, dgvFichaVariables.Item("col_ptje2", i).Value)
                    .PonderacionNoPrevista = If(Val(dgvFichaVariables.Item("col_ptje_noprev", i).Value) <= 0, 0, dgvFichaVariables.Item("col_ptje_noprev", i).Value)
                    .Estado = 1 'activo
                    .RegionId = Me._RegionID
                    .PenalId = Me._PenalID
                End With

                IdDetFic = objBssDet.Grabar(entDet, outErrSms)

                If IdDetFic = -1 Then
                    If outErrSms.Length > 0 Then Legolas.Configuration.Aplication.MessageBox.MensajeError(outErrSms)
                    Return False
                End If
            Next
            Return True
        End Function

        Private Function AGrabarFF() As Boolean
            Select Case Me._GrupoFichaId
                Case 1, 2
                    If ValidaGrabarFF_Grupo2() = False Then Return False
                Case 3, 4, 10
                    If ValidaGrabarFF_Grupo3() = False Then Return False 'validacion para la nueva ficha 2018
            End Select


            Dim ent As New Entity.Clasificacion.InternoClasificacion.InternoFicha

            Dim NumClasTMP As Integer = 0

            If Me.GrillaFichaCodigo > 0 Then
                Dim entTMP As Entity.Clasificacion.InternoClasificacion.InternoFicha = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).Listar_V2(Me.GrillaFichaCodigo)
                NumClasTMP = entTMP.NumeroClasificacion
            End If

            With ent
                .Codigo = Me.GrillaFichaCodigo
                .NumeroClasificacion = Me.NumeroClasificacion
                .InternoId = Me._InternoID
                .IngresoInpeId = Me._IngresoInpeId
                .FichaId = Me._FichaId
                .CategoriaFichaId = Me._EtapaFichaId
                .RegionDestinoId = Me.RegionDestinoId
                .PenalDestinoId = Me.PenalDestinoId
                .RegimenPenalId = Me.RegimenPenalId
                .FechaClasificacion = Me.FechaRegistroMovimiento
                .Observacion = Me.Observacion
                .Estado = If(GrillaFichaCodigo = -1, 0, Me.GrillaEstadoId)
                .PenalId = Me._PenalID
                .RegionId = Me._RegionID
                .TipoFichaId = Me.GrillaTipoFicha
                .Puntaje = Val(txtPuntTotal.Text)
                .MotivoModifPenalDet = lblModificadoPor.Text
                .InternoSituacionJuridicaId = Me.SitucionJuridicaId
                .GrupoFichaId = Me._GrupoFichaId
            End With

            Dim outSms As String = ""

            Dim _id As Integer = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).Grabar(ent, outSms)
            If _id = -1 Then
                If outSms.Length > 0 Then Legolas.Configuration.Aplication.MessageBox.Exclamation(outSms)
                Return False
            End If

            'actualizar estado y num classificacion de fichas relacionadas al maestro
            Dim bssFic As New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL
            Dim entidadFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha


            entidadFic.InternoId = Me._InternoID
            entidadFic.IngresoInpeId = Me._IngresoInpeId
            entidadFic.NumeroClasificacion = NumClasTMP ' If(Nuevo = True, 0, Me.NumeroClasificacion)

            Dim entFicCol As Entity.Clasificacion.InternoClasificacion.InternoFichaCol = New Entity.Clasificacion.InternoClasificacion.InternoFichaCol

            Select Case Me._GrupoFichaId
                Case 1, 2
                    entFicCol = bssFic.Listar(entidadFic)
                Case 3, 4, 10
                    entFicCol = bssFic.Listar_v2(entidadFic)
            End Select


            For Each obj As Entity.Clasificacion.InternoClasificacion.InternoFicha In entFicCol
                obj.NumeroClasificacion = Me.NumeroClasificacion
                obj.FichaFinalId = _id
                Dim idTmp = bssFic.Grabar(obj, outSms)
            Next
            Return True
        End Function

        Private Function ValidaGrabarFF_Grupo2() As Boolean
            Dim intNumClas As Integer = Me.GrillaFichaNumClasificacion

            Dim strCatFicLegal As String = ""
            Dim strCatFicPsicologica As String = ""
            Dim strCatFicSocial As String = ""

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("col_num_clasif", i).Value = intNumClas Then
                    Select Case dgwGrillaFicha.Item("tip_fic_id", i).Value
                        Case enmTipoFicha.Legal
                            strCatFicLegal = dgwGrillaFicha.Item("col_cat_nom", i).Value
                        Case enmTipoFicha.Psicologica
                            strCatFicPsicologica = dgwGrillaFicha.Item("col_cat_nom", i).Value
                        Case enmTipoFicha.Social
                            strCatFicSocial = dgwGrillaFicha.Item("col_cat_nom", i).Value
                    End Select

                    If dgwGrillaFicha.Item("col_estado_id", i).Value = enmEstadoRegistroFicha.Pendiente And dgwGrillaFicha.Item("tip_fic_id", i).Value <> enmTipoFicha.Final Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de generar la ficha final, todas las demás fichas deben estar en estado finalizado.")
                        Cancelar()
                        Return False
                    End If
                End If
            Next

            If strCatFicLegal = "" Or strCatFicSocial = "" Or strCatFicPsicologica = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de generar la ficha final debe completar las demas fichas.")
                Cancelar()
                Return False
            End If
            If Len(strCatFicLegal) > 0 And Len(strCatFicSocial) > 0 And Len(strCatFicPsicologica) > 0 And Me.CategoriaFichaNombre = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo determinar la CATEGORIA de la ficha final, revise que la categorización de las demas fichas estén correctas.")
                Cancelar()
                Return False
            End If
            'verificar que todas las demas fichas esten finalizadas

            If Val(Me.NumeroClasificacion) = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el número de clasificación para este interno.")
                txtNumClasificacion.Focus()
                Return False
            End If
            If Me.FechaClasificacion = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Fecha de clasificación incorrecta.")
                dtpFecha.Focus()
                Return False
            End If
            If Me.PenalDestinoId <= 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la región y penal de ubicación.")
                Return False
            End If

            '------------ validar duplicados ----------------------->
            Dim entIntFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha

            entIntFic.NumeroClasificacion = Me.NumeroClasificacion
            entIntFic.InternoId = Me._InternoID
            entIntFic.IngresoInpeId = Me._IngresoInpeId
            entIntFic.TipoFichaId = Me.GrillaTipoFicha

            Dim listIntFic As Entity.Clasificacion.InternoClasificacion.InternoFichaCol = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).Listar_v2(entIntFic)

            If listIntFic.Count > 0 Then
                If Me.GrillaFichaCodigo < 0 Or listIntFic.InternoClasificacion(0).Codigo <> Me.GrillaFichaCodigo Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Número de clasificación ya existe.")
                    Return False
                End If
            End If
            '<---------------------------------------------------------
            Return True
        End Function

        Private Function ValidaGrabarFF_Grupo3() As Boolean
            Dim bss As New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL
            Dim intNumClas As Integer = Me.GrillaFichaNumClasificacion

            Dim totFicLegal As Integer = 0
            Dim totFicPsicologica As Integer = 0
            Dim totCatFicSocial As Integer = 0

            Dim nFicSocialId As Integer = -1
            Dim nFicLegalId As Integer = -1
            Dim nFicPsicoId As Integer = -1
            ActualizarGrillaFicha()
            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("col_num_clasif", i).Value = intNumClas Then
                    Select Case dgwGrillaFicha.Item("tip_fic_id", i).Value
                        Case enmTipoFicha.Legal
                            nFicLegalId = dgwGrillaFicha.Item("col_codigo", i).Value
                            totFicLegal = dgwGrillaFicha.Item("col_ptje", i).Value
                        Case enmTipoFicha.Psicologica
                            nFicPsicoId = dgwGrillaFicha.Item("col_codigo", i).Value
                            totFicPsicologica = dgwGrillaFicha.Item("col_ptje", i).Value
                        Case enmTipoFicha.Social
                            nFicSocialId = dgwGrillaFicha.Item("col_codigo", i).Value
                            totCatFicSocial = dgwGrillaFicha.Item("col_ptje", i).Value
                    End Select

                    If dgwGrillaFicha.Item("col_estado_id", i).Value = enmEstadoRegistroFicha.Pendiente And dgwGrillaFicha.Item("tip_fic_id", i).Value <> enmTipoFicha.Final Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de generar la ficha final, todas las demás fichas deben estar en estado finalizado.")
                        Cancelar()
                        Return False
                    End If
                End If
            Next

            If totFicLegal = 0 Or totFicPsicologica = 0 Or totCatFicSocial = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de generar la ficha final debe completar las demás fichas.")
                Cancelar()
                Return False
            End If

            '-------------------------- validar estado de cada ficha -----------------
            'Ficha social
            Dim entFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                        .Codigo = nFicSocialId
                    }
            Dim entFicCol As Entity.Clasificacion.InternoClasificacion.InternoFichaCol = bss.Listar_v2(entFic)

            If entFicCol Is Nothing OrElse entFicCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun no se ha generado la ficha social.")
                Return False
            End If
            If entFicCol.InternoClasificacion(0).Estado = enmEstadoRegistroFicha.Pendiente Or entFicCol.InternoClasificacion(0).Estado = enmEstadoRegistroFicha.Ninguno Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha social debe estar finalizada.")
                Return False
            End If

            'Ficha psicologica
            entFic.Codigo = nFicPsicoId
            entFicCol = bss.Listar_v2(entFic)
            If entFicCol Is Nothing OrElse entFicCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun no se ha generado la ficha psicológica.")
                Return False
            End If
            If entFicCol.InternoClasificacion(0).Estado = enmEstadoRegistroFicha.Pendiente Or entFicCol.InternoClasificacion(0).Estado = enmEstadoRegistroFicha.Ninguno Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha psicológica debe estar finalizada.")
                Return False
            End If

            'Ficha psicologica
            entFic.Codigo = nFicLegalId
            entFicCol = bss.Listar_v2(entFic)
            If entFicCol Is Nothing OrElse entFicCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Aun no se ha generado la ficha legal.")
                Return False
            End If
            If entFicCol.InternoClasificacion(0).Estado = enmEstadoRegistroFicha.Pendiente Or entFicCol.InternoClasificacion(0).Estado = enmEstadoRegistroFicha.Ninguno Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La ficha legal debe estar finalizada.")
                Return False
            End If

            '------------------------------------------------------------------------------------
            'verificar que todas las demas fichas esten finalizadas
            If lblSexo.Text = "" Or lblNacionalidad.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Tanto el sexo como la nacionalidad del interno deben estar registradas previamente.")
                Return False
            End If

            If Val(Me.NumeroClasificacion) = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el número de clasificación para este interno.")
                txtNumClasificacion.Focus()
                Return False
            End If
            If Me.FechaClasificacion = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Fecha de clasificación incorrecta.")
                dtpFecha.Focus()
                Return False
            End If
            If Me.PenalDestinoId <= 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Región y penal de ubicación inválida.")
                Return False
            End If
            If cbbRegimenPenal.Text = "" Then
                'pendientehnrb en futura version obtener de tabla
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione regimen penitenciario en función al puntaje obtenido.")
                Return False
            End If
            '------------ validar duplicados ----------------------->
            Dim entIntFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                                    .NumeroClasificacion = Me.NumeroClasificacion,
                                    .InternoId = Me._InternoID,
                                    .IngresoInpeId = Me._IngresoInpeId,
                                    .TipoFichaId = Me.GrillaTipoFicha
                                }

            Dim listIntFic As Entity.Clasificacion.InternoClasificacion.InternoFichaCol = bss.Listar_v2(entIntFic)

            If listIntFic.Count > 0 Then
                If Me.GrillaFichaCodigo < 0 Or listIntFic.InternoClasificacion(0).Codigo <> Me.GrillaFichaCodigo Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Número de clasificación ya existe.")
                    Return False
                End If
            End If
            '<---------------------------------------------------------
            Return True
        End Function

        Private Sub EvaluarCategoriaFinal_Grupo02()
            '----- determinar la categoria final en funcion a la categoria de las otras fichas ---->
            If Me.GrillaTipoFicha <> Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then Exit Sub

            Dim intNumClas As Integer = Me.GrillaFichaNumClasificacion

            Dim strCatFicLegal As String = ""
            Dim strCatFicPsicologica As String = ""
            Dim strCatFicSocial As String = ""

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("col_num_clasif", i).Value = intNumClas Then
                    Select Case dgwGrillaFicha.Item("tip_fic_id", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                            strCatFicLegal = dgwGrillaFicha.Item("col_cat_nom", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                            strCatFicPsicologica = dgwGrillaFicha.Item("col_cat_nom", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                            strCatFicSocial = dgwGrillaFicha.Item("col_cat_nom", i).Value
                    End Select
                End If
            Next

            If strCatFicLegal = "" Or strCatFicPsicologica = "" Or strCatFicSocial = "" Then Exit Sub

            'setear los valores
            Me._EtapaFichaId = -1
            Me.CategoriaFichaNombre = ""

            Dim cat As New CategoriaFicha_BE
            If strCatFicLegal = strCatFicSocial Then
                cat.FichaId = Me.GrillaFicha 'ficha final
                cat.CategoriaNombre = strCatFicLegal
                cat = (New Bussines.Clasificacion.CategoriaFicha).Listar(cat).CategoriaFicha(0)

                Me.CategoriaFichaNombre = cat.CategoriaNombre
                Me._EtapaFichaId = cat.Codigo
            End If
            If strCatFicLegal = strCatFicPsicologica Then
                cat.FichaId = Me.GrillaFicha 'ficha final
                cat.CategoriaNombre = strCatFicPsicologica

                cat = (New Bussines.Clasificacion.CategoriaFicha).Listar(cat).CategoriaFicha(0)

                Me.CategoriaFichaNombre = cat.CategoriaNombre
                Me._EtapaFichaId = cat.Codigo
            End If
            If strCatFicSocial = strCatFicPsicologica Then
                cat.FichaId = Me.GrillaFicha 'ficha final
                cat.CategoriaNombre = strCatFicSocial

                cat = (New Bussines.Clasificacion.CategoriaFicha).Listar(cat).CategoriaFicha(0)

                Me.CategoriaFichaNombre = cat.CategoriaNombre
                Me._EtapaFichaId = cat.Codigo
            End If
        End Sub

        Private Sub EvaluarCategoriaFinal_Grupo03()
            '----- determinar la categoria final en funcion a la categoria de las otras fichas ---->
            If Me.GrillaTipoFicha <> Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then Exit Sub

            Dim intNumClas As Integer = Me.GrillaFichaNumClasificacion

            Dim nPjtFicLegal As Integer = 0
            Dim nPjtFicSocial As Integer = 0
            Dim nPjtFicPsicologica As Integer = 0

            Dim nTotal As Integer = 0

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("col_num_clasif", i).Value = intNumClas Then
                    Select Case dgwGrillaFicha.Item("tip_fic_id", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                            nPjtFicLegal = dgwGrillaFicha.Item("col_ptje", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                            nPjtFicPsicologica = dgwGrillaFicha.Item("col_ptje", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                            nPjtFicSocial = dgwGrillaFicha.Item("col_ptje", i).Value
                    End Select
                End If
            Next

            nTotal = nPjtFicLegal + nPjtFicSocial + nPjtFicPsicologica
            txtPuntTotal.Text = nTotal

            Dim lst As Entity.EntityCol(Of Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE)
            '------------------ determinar etapas (categoria) ------------>>
            Dim cat As New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            Dim bssRss As New Bussines.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet
            '------------------ determinar regimen ------------>>
            cat = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            If lblSexo.Text = "MASCULINO" Then '
                cat.IDFichaResultado = 6 'PENAL DESTINO VARNOES
                lst = bssRss.Listar(cat)
                For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                    If nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                        Dim pen As Entity.General.Penal = (New Bussines.General.Penal).Listar(obj.IDTabla) 'obj.IDTabla id de tabla penal
                        Me.RegionDestinoId = pen.RegionID
                        Me.PenalDestinoId = pen.Codigo
                        Exit For
                    End If
                Next
            Else 'MUJERES
                cat.IDFichaResultado = 7 'PENAL DESTINO MUJERES
                If lblNacionalidad.Text = "PERUANO" Then
                    cat.NacionalidadInterno = 1 '1=peruano,2=extranjero, ambos
                    lst = bssRss.Listar(cat)
                    For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                        If nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                            Dim pen As Entity.General.Penal = (New Bussines.General.Penal).Listar(obj.IDTabla) 'obj.IDTabla id de tabla penal
                            Me.RegionDestinoId = pen.RegionID
                            Me.PenalDestinoId = pen.Codigo
                            Exit For
                        End If
                    Next
                Else 'EXTRANJERO
                    cat.NacionalidadInterno = 2 'extranjero
                    lst = bssRss.Listar(cat)
                    For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                        If nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                            Dim pen As Entity.General.Penal = (New Bussines.General.Penal).Listar(obj.IDTabla) 'obj.IDTabla id de tabla penal
                            Me.RegionDestinoId = pen.RegionID
                            Me.PenalDestinoId = pen.Codigo
                            Exit For
                        End If
                    Next

                    cat.NacionalidadInterno = 3 'peruano y extranjero
                    lst = bssRss.Listar(cat)
                    For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                        If nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                            Dim pen As Entity.General.Penal = (New Bussines.General.Penal).Listar(obj.IDTabla) 'obj.IDTabla id de tabla penal
                            Me.RegionDestinoId = pen.RegionID
                            Me.PenalDestinoId = pen.Codigo
                            Exit For
                        End If
                    Next
                End If
            End If
            '<<--------------------------------------------------

            cat = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            cat.IDFichaResultado = 8 'regimen
            Me.RegimenPenalId = -1 'seteamos el valor a vacio
            lst = bssRss.Listar(cat)
            For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                If nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                    Me.RegimenPenalId = obj.IDTabla
                    Exit For
                End If
            Next

        End Sub

        Private Sub EvaluarCategoriaFinal_Grupo04()
            '----- determinar la categoria final en funcion a la categoria de las otras fichas ---->
            If Me.GrillaTipoFicha <> Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then Exit Sub

            Dim intNumClas As Integer = Me.GrillaFichaNumClasificacion

            Dim nPjtFicLegal As Integer = 0
            Dim nPjtFicSocial As Integer = 0
            Dim nPjtFicPsicologica As Integer = 0

            Dim nTotal As Integer = 0

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("col_num_clasif", i).Value = intNumClas Then
                    Select Case dgwGrillaFicha.Item("tip_fic_id", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                            nPjtFicLegal = dgwGrillaFicha.Item("col_ptje", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                            nPjtFicPsicologica = dgwGrillaFicha.Item("col_ptje", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                            nPjtFicSocial = dgwGrillaFicha.Item("col_ptje", i).Value
                    End Select
                End If
            Next

            nTotal = nPjtFicLegal + nPjtFicSocial + nPjtFicPsicologica
            txtPuntTotal.Text = nTotal

            Dim lst As Entity.EntityCol(Of Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE)

            Dim cat As New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE

            Dim bssRss As New Bussines.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet


            '------------------ determinar regimen ------------>>
            cat = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            If lblSexo.Text = "MASCULINO" Then '
                cat.IDFichaResultado = 10 'PENAL DESTINO VARNOES
                lst = bssRss.Listar(cat)
                For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                    If Me.SitucionJuridicaId = obj.SituacionJuridicaId And nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                        Dim pen As Entity.General.Penal
                        pen = (New Bussines.General.Penal).Listar(obj.IDTabla) 'obj.IDTabla id de tabla penal
                        Me.RegionDestinoId = pen.RegionID
                        Me.PenalDestinoId = pen.Codigo
                        Exit For
                    End If
                Next
            Else 'MUJERES
                cat.IDFichaResultado = 11 'PENAL DESTINO MUJERES

                lst = bssRss.Listar(cat)
                For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                    If obj.SituacionJuridicaId = Me.SitucionJuridicaId And nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                        Dim pen As Entity.General.Penal
                        pen = (New Bussines.General.Penal).Listar(obj.IDTabla) 'obj.IDTabla id de tabla penal
                        Me.RegionDestinoId = pen.RegionID
                        Me.PenalDestinoId = pen.Codigo
                        Exit For
                    End If
                Next

            End If
            '<<--------------------------------------------------

            '------------------ determinar regimen ------------>>
            cat = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            cat.IDFichaResultado = 9 'regimen
            Me.RegimenPenalId = -1 'seteamos el valor a vacio

            lst = bssRss.Listar(cat)
            For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                If obj.SituacionJuridicaId = Me.SitucionJuridicaId AndAlso nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                    Me.RegimenPenalId = obj.IDTabla
                    'txtRegimen.Text = cbbRegimenPenal.Text ' obj.Descripcion.ToUpper
                    Exit For
                End If
            Next
            '<<--------------------------------------------------


        End Sub

        Private Sub EvaluarCategoriaFinal_Grupo10()
            '----- determinar la categoria final en funcion a la categoria de las otras fichas ---->
            If Me.GrillaTipoFicha <> Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then Exit Sub

            Dim intNumClas As Integer = Me.GrillaFichaNumClasificacion

            Dim nPjtFicLegal As Integer = 0
            Dim nPjtFicSocial As Integer = 0
            Dim nPjtFicPsicologica As Integer = 0

            Dim nTotal As Integer = 0

            For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                If dgwGrillaFicha.Item("col_num_clasif", i).Value = intNumClas Then
                    Select Case dgwGrillaFicha.Item("tip_fic_id", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                            nPjtFicLegal = dgwGrillaFicha.Item("col_ptje", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                            nPjtFicPsicologica = dgwGrillaFicha.Item("col_ptje", i).Value
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                            nPjtFicSocial = dgwGrillaFicha.Item("col_ptje", i).Value
                    End Select
                End If
            Next

            nTotal = nPjtFicLegal + nPjtFicSocial + nPjtFicPsicologica
            txtPuntTotal.Text = nTotal

            Dim lst As Entity.EntityCol(Of Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE)
            Dim cat As New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            Dim bssRss As New Bussines.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet

            '------------------ determinar regimen ------------>>
            cat = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            If lblSexo.Text = "MASCULINO" Then '
                cat.IDFichaResultado = 16 'PENAL DESTINO VARNOES
                lst = bssRss.Listar(cat)
                For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                    If Me.SitucionJuridicaId = obj.SituacionJuridicaId And nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                        Dim pen As Entity.General.Penal = (New Bussines.General.Penal).Listar(obj.IDTabla) 'obj.IDTabla id de tabla penal
                        Me.RegionDestinoId = pen.RegionID
                        Me.PenalDestinoId = pen.Codigo
                        Exit For
                    End If
                Next
            Else 'MUJERES
                cat.IDFichaResultado = 17 'PENAL DESTINO MUJERES

                lst = bssRss.Listar(cat)
                For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                    If obj.SituacionJuridicaId = Me.SitucionJuridicaId And nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                        Dim pen As Entity.General.Penal = (New Bussines.General.Penal).Listar(obj.IDTabla) 'obj.IDTabla id de tabla penal
                        Me.RegionDestinoId = pen.RegionID
                        Me.PenalDestinoId = pen.Codigo
                        Exit For
                    End If
                Next

            End If
            '<<--------------------------------------------------

            '------------------ determinar regimen ------------>>
            cat = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            cat.IDFichaResultado = 15 'regimen
            Me.RegimenPenalId = -1 'seteamos el valor a vacio
            lst = bssRss.Listar(cat)
            For Each obj As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE In lst
                If obj.SituacionJuridicaId = Me.SitucionJuridicaId AndAlso nTotal >= obj.PuntajeInicial And nTotal <= obj.PuntajeFinal Then
                    Me.RegimenPenalId = obj.IDTabla
                    Exit For
                End If
            Next
            '<<--------------------------------------------------


        End Sub

        Private Sub BloqueoDesbloqueoRegistro()
            Dim Bss As New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL
            Dim intFic As Entity.Clasificacion.InternoClasificacion.InternoFicha
            Dim filaActual As Integer = 0
            If Me._InternoID <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos básicos del interno.")
                Exit Sub
            End If
            If Me._IngresoInpeId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            If Me.GrillaFichaCodigo > 0 Then
                If Me.PerfilUsuario = EnumDependencia.Legal Or (Me.PerfilUsuario = EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3) Then
                    'nada
                Else
                    If btnBloqDesbloq.Tag = "UNLOCK" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ud. no está autorizado para habilitar el registro, coordinar con el jefe de junta.")
                        Exit Sub
                    End If
                End If

                intFic = Bss.Listar_V2(GrillaFichaCodigo)

                If GrillaTipoFicha = enmTipoFicha.Final Then
                    'para la ficha final todas las demas fichas deben estar finalizadas
                    For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                        If dgwGrillaFicha.Item("tip_fic_id", i).Value = enmTipoFicha.Final Then Continue For
                        If dgwGrillaFicha.Item("col_estado_id", i).Value = enmEstadoRegistroFicha.Pendiente Or dgwGrillaFicha.Item("col_estado_id", i).Value = enmEstadoRegistroFicha.Ninguno Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Para finalizar la ficha final todas las demas fichas deben estar en estado Finalizado.")
                            Exit Sub
                        End If
                    Next
                Else
                    For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                        If dgwGrillaFicha.Item("tip_fic_id", i).Value = enmTipoFicha.Final And dgwGrillaFicha.Item("col_estado_id", i).Value = enmEstadoRegistroFicha.Pendiente And dgwGrillaFicha.Item("col_cat_nom", i).Value <> "" Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede cambiar el estado de la ficha seleccionada porque la ficha final ya fue generada, para completar la operación debe eliminar la ficha final.")
                            Exit Sub
                        End If
                    Next
                    If intFic.FichaFinalId > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede cambiar el estado de la ficha seleccionada porque la ficha final ya fue generada, para completar la operación debe eliminar la ficha final.")
                        Exit Sub
                    End If
                End If

                Select Case Me.GrillaEstadoId
                    Case enmEstadoRegistroFicha.Pendiente
                        Dim str As String = ""
                        If Me.PerfilUsuario = EnumDependencia.Legal Then ' = enmTipoFicha.Legal Then
                            str = "Confirma finalizar el registro seleccionado?"
                        Else
                            str = "Confirma finalizar el registro seleccionado?, luego de finalizar ya no podrá modificar."
                        End If
                        If Legolas.Configuration.Aplication.MessageBox.Question(str) = DialogResult.Yes Then
                            filaActual = dgwGrillaFicha.CurrentRow.Index

                            intFic.Estado = enmEstadoRegistroFicha.Finalizado
                            Dim id As Integer = Bss.Grabar(intFic, "")
                            Listar()
                            ListarValores()
                            Try
                                dgwGrillaFicha.Rows(filaActual).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                                dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(filaActual).Cells("col_nom_fic")
                            Catch ex As Exception

                            End Try
                            'dgwGrilla
                        End If
                    Case enmEstadoRegistroFicha.Finalizado
                        If Me.PerfilUsuario <> EnumDependencia.Legal And Not (Me.PerfilUsuario = EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3) Then
                            Legolas.Configuration.Aplication.MessageBox.Information("El Registro se encuentra finalizado, para desbloquear solicite al usuario que tenga privilegios para el desbloqueo.")
                            Exit Sub
                        End If

                        If (Me.PerfilUsuario = EnumDependencia.Legal Or (Me.PerfilUsuario = EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3)) And Legolas.Configuration.Aplication.MessageBox.Question("Va a desbloquear el registro, desea continuar?") = DialogResult.Yes Then
                            filaActual = dgwGrillaFicha.CurrentRow.Index

                            'si es ficha final, verificar que no este en algun oficio de clasificacion activo' pendientehnrb
                            intFic.Estado = enmEstadoRegistroFicha.Pendiente
                            Dim id As Integer = Bss.Grabar(intFic, "")
                            Listar()
                            ListarValores()
                            Try
                                dgwGrillaFicha.Rows(filaActual).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                                dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(filaActual).Cells("col_nom_fic")
                            Catch ex As Exception

                            End Try
                        End If
                    Case enmEstadoRegistroFicha.Bloqueado
                        Legolas.Configuration.Aplication.MessageBox.Information("No es posible realizar ninguna acción, el oficio de clasificación ya fue generado y derivado.")
                End Select
                'Listar()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ficha con datos incompletos.")
            End If
        End Sub

#End Region

#Region "Otros"

        Private Function ConcatenarValores() As String
            Dim s As String = ""

            Select Case Me.GrillaTipoFicha
                Case enmTipoFicha.Final
                    s = Me.CategoriaFichaNombre & txtPuntTotal.Text & dtpFecha.ValueLong & txtNumClasificacion.Text & txtobservacion.Text & cbbRegionDestino.Text & cbbPenalDestino.Text & cbbRegimenPenal.Text
                Case enmTipoFicha.Legal, enmTipoFicha.Psicologica, enmTipoFicha.Social
                    s = Me.CategoriaFichaNombre & txtPuntTotal.Text & dtpFecha.ValueLong & txtNumClasificacion.Text & txtobservacion.Text
            End Select

            Return s
        End Function

        Private Sub ShowControl()
            Me.btnAgregar.Visible = _VisibleGrabar
            Me.btnEliminar.Visible = _VisibleEliminar
            Me.btnPrint.Visible = _VisibleImprimir
            Me.btnBloqDesbloq.Visible = _VisibleImprimir
            Me.btnAceptar.Visible = _VisibleGrabar
            'Me.cmdCancel.Visible = _VisibleGrabar
        End Sub

        Public Sub LoadUsc()
            Application.EnableVisualStyles()

            Me.PerfilUsuario = Legolas.Configuration.Usuario.OficinaID
            Me.NivelUsuario = Legolas.Configuration.Usuario.NivelUsuario
            Me.lblNacionalidad.Text = Me._Nacionalidad
            Me.lblSexo.Text = Me._Sexo
            Me.txtNumDni.Text = Me._NumDocIdentStr
            Me.lblDocIdent.Text = "Doc. Ident. " & _TipoDocIdentStr & ":"
            CargarCombo()
            Me.RegionDestinoId = -1
            Listar()
            ListarValores()
            If Me.txtNumDni.Text = "" Then
                Me.txtNumDni.BackColor = Color.Red
            Else
                Me.txtNumDni.BackColor = Color.White
            End If
        End Sub

        Private Sub CalcularPuntajeTotal_v2()
            Dim v As Integer = 0
            For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                If Val(dgvFichaVariables.Item("col_ptje_noprev", i).Value) = 0 Then
                    v = v + Val(dgvFichaVariables.Item("col_ptje2", i).Value)
                Else
                    v = v + Val(dgvFichaVariables.Item("col_ptje_noprev", i).Value)
                End If
            Next

            Dim cat As New CategoriaFicha_BE With {
                            .FichaId = Me._FichaId
                        }

            Dim colCat As CategoriaFichaCol_BE = (New Bussines.Clasificacion.CategoriaFicha).Listar(cat)


            If Me.GrillaTipoFicha <> enmTipoFicha.Final Then
                txtPuntTotal.Text = v
            End If

            For Each cat In colCat
                If Val(txtPuntTotal.Text) >= cat.ValorMinimo And Val(txtPuntTotal.Text) <= cat.ValorMaximo Then
                    Me.CategoriaFichaNombre = cat.CategoriaNombre
                    Me._EtapaFichaId = cat.Codigo
                    dtpFecha.Value = dgwGrillaFicha.SelectedRows(0).Cells("col_fec_cla").Value
                    Dim f As Date = Legolas.Components.FechaHora.FechaDate(dtpFecha.Value, True)
                    dtpHoraETAPA.Value = f
                    txtobservacion.Text = dgwGrillaFicha.SelectedRows(0).Cells("col_obs").Value
                    Me.NumeroClasificacion = dgwGrillaFicha.SelectedRows(0).Cells("col_num_clasif").Value
                    Exit Sub
                Else
                    Me.CategoriaFichaNombre = ""
                    Me._EtapaFichaId = -1
                    txtobservacion.Text = ""
                    Me.dtpFecha.Value = Nothing
                    Me.NumeroClasificacion = 0

                End If
            Next
        End Sub

        Private Sub HabilitarControles(Valor As Boolean)
            gbUbicacion.Enabled = Valor
            gbDetalle.Enabled = Valor
        End Sub

        Private Sub Cancelar()
            If Me._InternoID <= 0 Or Me._IngresoInpeId <= 0 Then
                flagValidarDatos = False
                cbbRegionDestino.SelectedValue = -1
                cbbPenalDestino.SelectedValue = -1
                cbbRegimenPenal.SelectedValue = -1
                Me.CategoriaFichaNombre = ""
                dtpFecha.ValueLong = 0
                txtNumClasificacion.Text = 0
                txtobservacion.Text = ""
                txtPuntTotal.Text = 0
                Exit Sub
            End If

            ListarValores()
        End Sub

        Private Sub imprimir()
            If Me._IngresoInpeId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningún Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar.")
                Exit Sub
            End If
            If Me._InternoID <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una ficha para imprimir.")
                Exit Sub
            End If
            If Me.GrillaEstadoId = enmEstadoRegistroFicha.Ninguno Or Me.GrillaEstadoId = enmEstadoRegistroFicha.Pendiente Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para poder imprimir la ficha debe finalizar el registro")
                Exit Sub
            End If
            If Me._GrupoFichaId > 2 And Me.GrillaTipoFicha <> 4 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo es posible imprimir la ficha final.")
                Exit Sub
            End If
            If Me.GrillaTipoFicha = 4 Then 'todas las fichas deben estar en estado finalizado
                Dim intNumClas As Integer = Me.GrillaFichaNumClasificacion

                'Dim strCatFicLegal As String = ""
                'Dim strCatFicPsicologica As String = ""
                'Dim strCatFicSocial As String = ""

                ActualizarGrillaFicha()

                For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                    If dgwGrillaFicha.Item("col_num_clasif", i).Value = intNumClas Then
                        'Select Case dgwGrillaFicha.Item("tip_fic_id", i).Value
                        '    Case enmTipoFicha.Legal
                        '        strCatFicLegal = dgwGrillaFicha.Item("col_cat_nom", i).Value
                        '    Case enmTipoFicha.Psicologica
                        '        strCatFicPsicologica = dgwGrillaFicha.Item("col_cat_nom", i).Value
                        '    Case enmTipoFicha.Social
                        '        strCatFicSocial = dgwGrillaFicha.Item("col_cat_nom", i).Value
                        'End Select

                        If dgwGrillaFicha.Item("col_estado_id", i).Value = enmEstadoRegistroFicha.Pendiente And dgwGrillaFicha.Item("tip_fic_id", i).Value <> enmTipoFicha.Final Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Todas las demás fichas deben estar en estado finalizado.")
                            Exit Sub
                        End If
                    End If
                Next

            End If
            RaiseEvent _Click_PrintFicha(Me.GrillaFichaCodigo, Me._GrupoFichaId, GrillaTipoFicha)
        End Sub

        Private Sub Aceptar()
            If Me._InternoID <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para completar la acción, grabe los datos básicos del interno.")
                Exit Sub
            End If

            If Me._IngresoInpeId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para completar la acción, registrar los datos del ingreso.")
                Exit Sub
            End If

            If Me._GrupoFichaId = 3 Then
                If lblSexo.Text = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible completar la operación, sexo del interno no especificado (ciertos indicadores dependen del sexo).")
                    Exit Sub
                End If
                If lblNacionalidad.Text = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible completar la operación, la nacionalidad no especificado (ciertos indicadores dependen de la nacionalidad).")
                    Exit Sub
                End If
            End If
            If (Me._GrupoFichaId = 4 Or Me._GrupoFichaId = 10) AndAlso (cboSitJuridica.Text = "[--SELECCIONE--]" Or cboSitJuridica.Text = String.Empty) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la situación jurídica del interno para su clasificación.")
                Exit Sub
            End If

            If UsuarioAutorizado() = False Then
                If Me.GrillaFichaCodigo = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, ud no esta autorizado para generar este tipo de ficha.")
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, no está autorizado para modificar el registro actual.")
                End If
                Exit Sub
            End If

            Select Case Me.PerfilUsuario
                Case EnumDependencia.Social
                    If GrillaTipoFicha <> enmTipoFicha.Social Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, no está autorizado para modificar el registro actual.")
                        Exit Sub
                    End If
                Case EnumDependencia.Psicologo
                    If GrillaTipoFicha <> enmTipoFicha.Psicologica Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, no está autorizado para modificar el registro actual.")
                        Exit Sub
                    End If
                Case EnumDependencia.Legal
                    If GrillaTipoFicha = enmTipoFicha.Psicologica Or GrillaTipoFicha = enmTipoFicha.Social Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, no está autorizado para modificar el registro actual.")
                        Exit Sub
                    End If
                Case EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3
                    Exit Select

                Case Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, no está autorizado para modificar el registro actual.")
                    Exit Sub
            End Select

            If Me.GrillaTipoFicha = Type.Enumeracion.Clasificacion.enmTipoFicha.Legal And Me.GrillaFichaCodigo > 0 And (Me._GrupoFichaId = 4 Or Me._GrupoFichaId = 10) Then
                For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                    If dgvFichaVariables.Item("col_val_nom", i).Value = "SITUACION JURIDICA" And dgvFichaVariables.Item("col_valor", i).Value = "" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la situación juridica.")
                        Exit Sub
                    End If
                Next
            End If

            btnAceptar.Enabled = False

            If Me.GrillaTipoFicha = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                If AGrabarFF() = False Then
                    btnAceptar.Enabled = True
                    Exit Sub
                End If
            Else
                If AGrabar() = False Then
                    btnAceptar.Enabled = True
                    Exit Sub
                End If
            End If
            btnAceptar.Enabled = True
            Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

            Dim indRegSel As Integer = -1
            indRegSel = If(dgwGrillaFicha.CurrentRow Is Nothing, 0, dgwGrillaFicha.CurrentRow.Index)

            Listar()

            Try
                dgwGrillaFicha.Rows(indRegSel).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(indRegSel).Cells("col_nom_fic")
            Catch ex As Exception

            End Try

            ListarValores()
            strDatosActual = ""
        End Sub
        Private Sub RefrescarGrillas()
            Dim filaActual As Integer = 0
            If Not dgwGrillaFicha.CurrentRow Is Nothing Then
                filaActual = dgwGrillaFicha.CurrentRow.Index
            End If
            Listar()
            ListarValores()
            Try
                dgwGrillaFicha.Rows(filaActual).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                dgwGrillaFicha.CurrentCell = dgwGrillaFicha.Rows(filaActual).Cells("col_nom_fic")
            Catch ex As Exception

            End Try
        End Sub

#End Region

#Region "Formulario"
        Dim bClick As Boolean = False
        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaFicha.CellClick
            bClick = True
            If bListadoIniciado = False Then
                If indiceFilaAnterior = dgwGrillaFicha.CurrentRow.Index Then Exit Sub
                ListarValores()
                dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.SelectionForeColor = dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.ForeColor
                Me.strDatosActual = ConcatenarValores()
            End If
            bClick = False
        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaFicha.CellEnter
            If bClick = True Then Exit Sub
            If bListadoIniciado = False Then
                If indiceFilaAnterior = dgwGrillaFicha.CurrentRow.Index Then Exit Sub
                ListarValores()
                dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.SelectionForeColor = dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.ForeColor
                Me.strDatosActual = ConcatenarValores()
            End If

            RaiseEvent _Show_AuditFicha(Me.GrillaFichaCodigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoFichaClasificacion)
        End Sub

        Private Sub dgwGrilla_CellLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaFicha.CellLeave

            dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.ForeColor = dgwGrillaFicha.CurrentRow.Cells("col_estado").Style.ForeColor

        End Sub

        Private Sub btnAddIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

            AgregarPlantillaFichas()

        End Sub

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrillaFicha.KeyDown
            Select Case e.KeyData
                Case (Keys.Shift Or Keys.Delete)
                    btnEliminar.PerformClick()
            End Select
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            AELiminarFicha()

        End Sub


        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            Aceptar()

        End Sub

        Private Sub dgvFichaVariables_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFichaVariables.CellClick
            Dim soloLectura As Boolean = False
            If e.RowIndex = -1 Then Exit Sub

            If dgvFichaVariables.Columns(e.ColumnIndex).Name = "col_buton" Then
                If Me._InternoID = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Para completar la acción, guardar los datos básicos del interno.")
                    Exit Sub
                End If
                If Me._IngresoInpeId <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningún Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar.")
                    Exit Sub
                End If
                If Me._EstadoInterno = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del interno se encuentra inactivo.")
                    soloLectura = True
                    '  Exit Sub
                End If
                If Me.SitucionJuridicaId <= 0 And (Me._GrupoFichaId = 4 Or Me._GrupoFichaId = 10) Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de realizar cualquier operación seleccione la situación juridica del interno y grabe los datos.")
                    Exit Sub
                End If
                If Me.SitucionJuridicaId > 0 And (Me._GrupoFichaId = 4 Or Me._GrupoFichaId = 10) And cboSitJuridica.Enabled = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe grabar los datos de la situación jurídica.")
                    Exit Sub
                End If
                Dim EntFichaDet As New Entity.Clasificacion.Documento.DatosFicha
                With EntFichaDet
                    .IndicadorId = dgvFichaVariables.Item("col_val_id_sel", e.RowIndex).Value
                    .MaeVariableId = dgvFichaVariables.SelectedRows(0).Cells("col_mae_var_id").Value
                    .MaeFichaId = Me.GrillaFicha
                    .VariableNombre = Me.GrillaVariableNombre
                    .ValorPuntaje = dgvFichaVariables.Item("col_ptje2", e.RowIndex).Value
                    .ValorNoPrevisto = dgvFichaVariables.Item("col_ptje_noprev", e.RowIndex).Value
                    .InternoFichaDetalleId = dgvFichaVariables.Item("col_fic_det_id", e.RowIndex).Value
                    .InternoSituacionJuridica = Me.SitucionJuridicaId
                    .GrupoFichaId = Me._GrupoFichaId
                    If Me.GrillaFichaNumClasificacion > 0 Or Me.GrillaEstadoId = enmEstadoRegistroFicha.Bloqueado Or Me.GrillaEstadoId = enmEstadoRegistroFicha.Finalizado Or soloLectura = True Then
                        .BloquearRegistro = True
                    Else
                        Select Case Me.PerfilUsuario
                            Case EnumDependencia.Legal
                                If Me.GrillaTipoFicha = enmTipoFicha.Psicologica Or Me.GrillaTipoFicha = enmTipoFicha.Social Then
                                    .BloquearRegistro = True
                                Else
                                    .BloquearRegistro = False
                                End If
                            Case EnumDependencia.SistemasInformacion And Me.NivelUsuario = 3
                                .BloquearRegistro = False
                                'Case Else
                                '   .BloquearRegistro = True
                        End Select
                    End If
                End With

                RaiseEvent _Click_FichaDetalle(EntFichaDet)
            End If
        End Sub

        Private Sub cbbRegionDestino__SelectedIndexChanged() Handles cbbRegionDestino._SelectedIndexChanged
            If Me._GrupoFichaId <> 3 Then
                Me.RegimenPenalId = -1
            End If
            ComboPenal()
            Me.PenalDestinoId = -1
        End Sub


        Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
            imprimir()
        End Sub

        Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click

            Cancelar()

        End Sub

        Private Sub cbbPenalDestino__SelectedIndexChanged() Handles cbbPenalDestino._SelectedIndexChanged
            If Me._GrupoFichaId <> 3 Then
                ComboRegimenPenitenciario()
            End If
        End Sub

        Private Sub btnBloqDesbloq_Click(sender As System.Object, e As System.EventArgs) Handles btnBloqDesbloq.Click

            BloqueoDesbloqueoRegistro()

        End Sub

#End Region

        Private Sub dgwGrilla_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrillaFicha.CellPainting

            If dgwGrillaFicha.Rows.Count = 0 Then Exit Sub

            If dgwGrillaFicha.Columns(e.ColumnIndex).Name = "col_num_clasif" AndAlso e.RowIndex <> -1 Then
                Dim tmp As Integer = 0
                For i As Integer = 0 To dgwGrillaFicha.Rows.Count - 1
                    If dgwGrillaFicha.Rows(i).Visible = True Then tmp = tmp + 1
                Next
                If tmp = 1 Then Exit Sub 'en caso sea un solo registro visible no debe hacer nada
                Using gridBrush As Brush = New SolidBrush(Me.dgwGrillaFicha.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                    Using gridLinePen As Pen = New Pen(gridBrush)
                        ' Clear cell   
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                        ' Draw line (bottom border and right border of current cell)   
                        'If next row cell has different content, only draw bottom border line of current cell   
                        If e.RowIndex = dgwGrillaFicha.Rows.Count - 1 OrElse dgwGrillaFicha.Item(e.ColumnIndex, e.RowIndex + 1).Value.ToString() <> e.Value.ToString() Then
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                        End If

                        ' Draw right border line of current cell   
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                        ' draw/fill content in current cell, and fill only one cell of multiple same cells   
                        If Not e.Value Is Nothing Then
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

        Private Sub dgwGrilla_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles dgwGrillaFicha.Scroll
            If e.Type = ScrollEventType.SmallDecrement Or e.Type = ScrollEventType.SmallIncrement Then
                If Not (dgwGrillaFicha.FirstDisplayedCell.RowIndex + dgwGrillaFicha.DisplayedRowCount(True) = dgwGrillaFicha.Rows.Count) Then dgwGrillaFicha.Refresh()
            End If
        End Sub

        Private Sub dgvFichaVariables_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFichaVariables.CellEnter
            dgvFichaVariables.CurrentRow.Cells("col_valor").Style.SelectionForeColor = dgvFichaVariables.CurrentRow.Cells("col_valor").Style.ForeColor
        End Sub

        Private Sub dgvFichaVariables_CellLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFichaVariables.CellLeave
            dgvFichaVariables.CurrentRow.Cells("col_valor").Style.ForeColor = dgvFichaVariables.CurrentRow.Cells("col_valor").Style.ForeColor
        End Sub

        Private Sub dgwGrilla_RowValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgwGrillaFicha.RowValidating
            If dgwGrillaFicha.Item("col_estado_id", e.RowIndex).Value > 0 Then
                flagValidarDatos = False
            End If
            indiceFilaAnterior = e.RowIndex
            If Me.GrillaEstadoNombre = "FINALIZADO" Or Me.GrillaTipoFicha = enmTipoFicha.Ninguno Then Exit Sub

            Dim actual As String = ConcatenarValores()

            If strDatosActual.Length = 0 Then Exit Sub

            If flagValidarDatos = True AndAlso actual <> strDatosActual Then
                e.Cancel = True
                If cmdCancel.Enabled = False Then
                    Cancelar()
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe grabar o cancelar los cambios efectuados.")
                End If
            End If
        End Sub

        Private Sub dgwGrilla_Enter(sender As System.Object, e As System.EventArgs) Handles dgwGrillaFicha.Enter
            Me.flagValidarDatos = True
        End Sub

        Private Sub dgwGrilla_Leave(sender As System.Object, e As System.EventArgs) Handles dgwGrillaFicha.Leave
            Me.flagValidarDatos = False
        End Sub

        Private Sub btnEdiPenal_Click(sender As System.Object, e As System.EventArgs) Handles btnEdiPenal.Click
            Dim s As String
            s = InputBox("Ingrese motivo por el cual va a modificar los datos del destino.", "Ingrese el motivo", lblModificadoPor.Text)

            If s.Length = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para modificar región, penal o régimen debe especificar el motivo.")
                Exit Sub
            End If
            lblModificadoPor.Text = s
            bEditManualPenDest = True
            cbbRegionDestino.Enabled = True
            cbbPenalDestino.Enabled = True
            cbbRegimenPenal.Enabled = True
            btnCancelPenal.Enabled = True
        End Sub

        Private Sub btnCancelPenal_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelPenal.Click
            ' ListarValores()
            EvaluarCategoriaFinal_Grupo03()
            bEditManualPenDest = False
            cbbRegionDestino.Enabled = False
            cbbPenalDestino.Enabled = False
            cbbRegimenPenal.Enabled = False
            lblModificadoPor.Text = ""
            btnCancelPenal.Enabled = False
        End Sub



        Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
            RefrescarGrillas()
        End Sub

        Private Function getVariableIndicador() As String
            Dim s As String = ""

            For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                If dgvFichaVariables.Item("col_ptje_noprev", i).Value > 0 Or dgvFichaVariables.Item("col_ptje2", i).Value > 0 Then
                    s = s & " *- " & dgvFichaVariables.Item("col_val_nom", i).Value & " ==> " & dgvFichaVariables.Item("col_valor", i).Value & vbCrLf
                End If
            Next

            Return s
        End Function

        Private Sub btnFormato06_legal_Click(sender As Object, e As EventArgs) Handles btnFormato06_legal.Click
            Dim v As Boolean = True

            If Me.GrillaEstadoNombre = "BLOQUEADO" Then v = False

            RaiseEvent _Click_btn_Formato06(Me.GrillaFichaCodigo, Me.getVariableIndicador(), v)
        End Sub

        Private Sub btnFormato06_social_Click(sender As Object, e As EventArgs) Handles btnFormato06_social.Click
            Dim v As Boolean = True

            If Me.GrillaEstadoNombre = "BLOQUEADO" Then v = False

            RaiseEvent _Click_btn_Formato06(Me.GrillaFichaCodigo, Me.getVariableIndicador(), v)
        End Sub

        Private Sub btnFormato06_psicologica_Click(sender As Object, e As EventArgs) Handles btnFormato06_psicologica.Click
            Dim v As Boolean = True

            If Me.GrillaEstadoNombre = "BLOQUEADO" Then v = False

            RaiseEvent _Click_btn_Formato06(Me.GrillaFichaCodigo, Me.getVariableIndicador(), v)
        End Sub

        Private Sub btnImprimirF06_Click(sender As Object, e As EventArgs) Handles btnImprimirF06.Click
            RaiseEvent _Click_PrintFormato06(Me.GrillaFichaCodigo, Me._GrupoFichaId)
        End Sub

    End Class

End Namespace