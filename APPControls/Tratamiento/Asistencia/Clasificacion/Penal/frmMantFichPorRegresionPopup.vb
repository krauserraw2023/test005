Imports System.Data
Imports System.Linq
Imports System.Security.Cryptography.X509Certificates
Imports APPWebService.ws_sipga_sede_trabajador
Imports Bussines.Clasificacion
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Registro.Carceleta.Clasificacion
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class frmMantFichPorRegresionPopup
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmEliminar As Boolean = False

        Public Property _Codigo As Integer = -1 'InternoPenalFichaId tabla tra_asi_mov_interno_penal_ficha

        'Public Property _InternoPenFichaId As Integer = -1
        Public Property _PenId As Integer = -1
        Public Property _RegId As Integer = -1
        Public Property _InternoId As Integer = -1
        Public Property _InternoIngresoId As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1

#Region "Propiedades privadas"

        Private Property PisoId As Integer = -1
        Private Property AleroId As Integer = -1
        Private Property AmbienteId As Integer = -1

        Public Property IDPabellon As Integer = -1
        Private Property _IDInternoFicha As Integer = -1
        Private Property _strCalificacion As String = ""
        Private Property _strVariableNombreSel As String = ""
        Private Property _VariableIdSel As Integer = -1
        Private Property _GrillaIndicadorId_select As Integer = -1
        Private Property _FichaId As Integer = -1

        Private Property EstadoFicha As Integer = -1

        Private blnComboRegimen As Boolean = False

        Public ReadOnly Property ValorIdSeleccionado() As Integer
            Get
                Dim v As Integer = -1
                Try
                    Return webBrowser1.Document.InvokeScript("getValorIdSeleccionado")
                Catch ex As Exception

                End Try
                Return v
            End Get
        End Property
        Private Property IdRegionOrigen() As Integer
            Get
                Return Me.cbbRegionOrigen.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegionOrigen.SelectedValue = value
            End Set
        End Property
        Private Property IdPenalOrigen() As Short
            Get
                Return Me.cbbPenalOrigen.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbPenalOrigen.SelectedValue = value
            End Set
        End Property
        Private Property IdRegionDestino() As Integer
            Get
                Return Me.cbbRegionDestino.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegionDestino.SelectedValue = value
            End Set
        End Property
        Private Property IdPenalDestino() As Short
            Get
                Return Me.cbbPenalDestino.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbPenalDestino.SelectedValue = value
            End Set
        End Property
        Private Property IDRegimenEpOrigen() As Short
            Get
                Return Me.cbbRegimenEpOrigen.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbRegimenEpOrigen.SelectedIndex = value
            End Set
        End Property
        Private Property IDEtapaEpOrigen() As Short
            Get
                Return Me.cbbEtapaEpOrigen.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbEtapaEpOrigen.SelectedValue = value
            End Set
        End Property


        Private Property IdRegimenClasificacion() As Integer
            Get
                Return Me.cbbRegimenClasif.SelectedIndex
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegimenClasif.SelectedIndex = value
            End Set
        End Property
        Private Property IdEtapaClasificacion() As Integer
            Get
                Return Me.cbbEtapaClasif.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEtapaClasif.SelectedValue = value
            End Set
        End Property

        Private Property ObservacionClasificacion() As String
            Get
                Return txtObs.Text
            End Get
            Set(ByVal value As String)
                txtObs.Text = value
            End Set
        End Property
        Private Property FechaTraslado() As Long
            Get
                Return dtpFechaTraslado.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpFechaTraslado.ValueLong = value
            End Set
        End Property
        Private Property FechaResol() As Long
            Get
                Return dtpFechaResol.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpFechaResol.ValueLong = value
            End Set
        End Property
        Private Property ResolAutorizacion() As String
            Get
                Return txtResAutoriza.Text
            End Get
            Set(ByVal value As String)
                txtResAutoriza.Text = value
            End Set
        End Property
        Private Property Causal() As String
            Get
                Return txtCausal.Text
            End Get
            Set(ByVal value As String)
                txtCausal.Text = value
            End Set
        End Property
        Private Property HoraClasif() As String
            Get

                Return Me.nudHora._Value
            End Get
            Set(ByVal value As String)
                Me.nudHora._Value = value
            End Set
        End Property
        Private Property MinutoClasif() As String
            Get

                Return Me.nudMinutos._Value
            End Get
            Set(ByVal value As String)
                Me.nudMinutos._Value = value
            End Set
        End Property
        Private Property FechaClasificacion() As Long
            Get
                Return dtpFechaClasif.ValueLong
            End Get
            Set(value As Long)
                dtpFechaClasif.ValueLong = value
            End Set
        End Property
        Private ReadOnly Property FechaHoraClasificacion As Long
            Get
                Dim FechaTotal As String
                Dim Hora As String = "00"
                Dim Minutos As String = "00"

                Dim fecha As String = dtpFechaClasif.Value & " " & CStr(HoraClasif) & ":" & CStr(MinutoClasif) & ":00"
                FechaTotal = CDate(fecha).ToFileTime
                Return FechaTotal
            End Get
        End Property
        Private Property NumeroClasificacion() As Integer
            Get
                Return Me.txtNumClasificacion.Text
            End Get
            Set(value As Integer)
                Me.txtNumClasificacion.Text = value
            End Set
        End Property

#End Region

#Region "LISTAR"
        Private Sub ComboRegimenClasificación()
            With Me.cbbRegimenClasif
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Regimen Cerrado Ordinario - R.C.O.")
                .Items.Add("Regimen Cerrado Especial - R.C.E.")
            End With
            Me.IdRegimenClasificacion = 2
        End Sub
        Private Sub ComboEtapaClasificación(intIDRegimen As Short)

            Dim objDT As New DataTable("Regimen")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            Select Case intIDRegimen
                Case 1 'ordinario
                    objDT.Rows.Add(New Object() {1, "MINIMA SEGURIDAD"})
                    objDT.Rows.Add(New Object() {2, "MEDIANA SEGURIDAD"})
                    objDT.Rows.Add(New Object() {3, "MAXIMA SEGURIDAD"})

                Case 2
                    objDT.Rows.Add(New Object() {4, "A"})
                    objDT.Rows.Add(New Object() {5, "B"})
                    objDT.Rows.Add(New Object() {6, "C"})
                    objDT.Rows.Add(New Object() {7, ""})
            End Select

            objDT.AcceptChanges()

            With Me.cbbEtapaClasif
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objDT
            End With

        End Sub

        Private Sub ComboRegimenEpOrigen()
            blnComboRegimen = False
            With Me.cbbRegimenEpOrigen
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Regimen Cerrado Ordinario - R.C.O.")
                .Items.Add("Regimen Cerrado Especial - R.C.E.")
            End With
            Me.IDRegimenEpOrigen = 0
            blnComboRegimen = True
        End Sub
        Private Sub ComboEtapaEpOrigen(intIDRegimen As Short)

            Dim objDT As New DataTable("Regimen")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            Select Case intIDRegimen
                Case 1 'ordinario
                    objDT.Rows.Add(New Object() {1, "MINIMA SEGURIDAD"})
                    objDT.Rows.Add(New Object() {2, "MEDIANA SEGURIDAD"})
                    objDT.Rows.Add(New Object() {3, "MAXIMA SEGURIDAD"})

                Case 2
                    objDT.Rows.Add(New Object() {4, "A"})
                    objDT.Rows.Add(New Object() {5, "B"})
                    objDT.Rows.Add(New Object() {6, "C"})
            End Select

            objDT.AcceptChanges()

            With Me.cbbEtapaEpOrigen
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objDT
            End With

        End Sub
        Private Sub ComboRegionOrigen()
            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select
            With Me.cbbRegionOrigen
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboPenalOrigen()

            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select
            With Me.cbbPenalOrigen
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.IdRegionOrigen
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboRegionDestino()
            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select
            With Me.cbbRegionDestino
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboPenalDestino()

            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select
            With Me.cbbPenalDestino
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.IdRegionDestino
                .LoadUsc()
            End With
        End Sub
        Private Sub Listar()


            Dim entFicCol_ As New MaestroFichaCol_BE 'fichas plantilla original
            Dim entFicMae As New MaestroFicha_BE

            entFicMae.EstadoId = 1 'fichas activas
            entFicMae.AmbitoClasificacionId = 2 'penal
            entFicMae.TipoFichaId = 5 'ficha por regresion


            entFicCol_ = (New Bussines.Clasificacion.MaestroFicha).Listar(entFicMae)

            If entFicCol_.Count > 0 Then
                entFicMae = entFicCol_.Ficha(0)
                Me._FichaId = entFicMae.Codigo
            End If

            If Me._Codigo < 0 Then Exit Sub

            Dim entIntFic As InternoFicha_BE = (New InternoFicha_BL()).Listar(Me._Codigo)

            If entIntFic.Estado = 1 Then 'bloqueado
                btnAdd.Enabled = False
                btnGrabarClasificacion.Enabled = False
                dgvFichaVariables.Columns("col_button_elimina").Visible = False
                btnFinalizar.Enabled = False
            End If

            With entIntFic
                Me._InternoIngresoId = .IDInternoIngreso
                Me._InternoIngresoInpeId = .IDInternoIngresoInpe
                Me.NumeroClasificacion = .NumeroClasificacion
                Me.FechaClasificacion = .FechaClasificacion
                Me._IDInternoFicha = .Codigo

                Dim fc As Date = Legolas.Components.FechaHora.FechaDate(.FechaClasificacion, True)
                Me.HoraClasif = Format(fc, "HH")
                Me.MinutoClasif = Format(fc, "mm")

                Me.ObservacionClasificacion = .Observacion

                Me.IdRegimenClasificacion = .InternoIDRegimen
                Me.IdEtapaClasificacion = .InternoIDEtapa
                Me.EstadoFicha = .Estado
                lblEstado.Text = IIf(.Estado = 0, "PENDIENTE", "FINALIZADO")
                .InternoIDEtapa = -1
            End With

            Dim lstFicOtro As List(Of InternoFichaOtro_BE) = (New InternoFichaOtro_BL()).Listar(New InternoFichaOtro_BE With {.InternoPenalFichaId = entIntFic.Codigo})
            If lstFicOtro.Count > 0 Then
                With lstFicOtro.Item(0)
                    'Me.InternoFichaOtroId = .Codigo
                    Me.Causal = .Causal
                    Me.ResolAutorizacion = .ResolAutorizacion
                    Me.FechaResol = .FechaResolucion
                    Me.FechaTraslado = .FechaTraslado
                    Me.IdRegionOrigen = .RegionOrigenId
                    Me.IdPenalOrigen = .PenalOrigenId
                    Me.IdRegionDestino = .RegionDestinoId
                    Me.IdPenalDestino = .PenalDestinoId
                    Me.IDRegimenEpOrigen = .RegimenId_PenalOrigen
                    Me.IDEtapaEpOrigen = .EtapaId_PenalOrigen
                    Me.IDPabellon = .PabellonId
                    lblPabellon.Text = .PabellonNombre
                End With
            End If

            '------------- cargar detalle en grilla
            Dim entAux As New InternoFichaDetalle_BE()

            entAux.IDInternoFicha = entIntFic.Codigo


            Dim str As String = ""

            Dim lstDet As List(Of InternoFichaDetalle_BE) = (New InternoFichaDetalle_BL()).Listar(entAux)

            For Each det As InternoFichaDetalle_BE In lstDet
                Me._IDInternoFicha = det.IDInternoFicha
                With dgvFichaVariables
                    .Rows.Add()
                    .Rows(0).Cells("col_fic_det_id").Value = det.Codigo
                    .Rows(0).Cells("col_fic_id").Value = Me._FichaId
                    .Rows(0).Cells("col_variable_id").Value = det.IDVariable
                    .Rows(0).Cells("col_indicador_id").Value = det.IDIndicador

                    '------------------------- cargar indicador -------------------
                    Dim objEnt As New MaestroIndicador_BE With {
                                .Codigo = det.IDIndicador
                                }

                    Dim entValTmp As MaestroIndicadorCol_BE = (New Bussines.Clasificacion.MaestroIndicador).ListarGrillaAgrupada(objEnt)

                    Me._VariableIdSel = entValTmp.MaestroIndicador(0).VariableID
                    Me._strVariableNombreSel = entValTmp.MaestroIndicador(0).NombreVariable

                    Dim IndDescripConcat As String = ""

                    For Each entInd As MaestroIndicador_BE In entValTmp
                        IndDescripConcat = IndDescripConcat & ".- " & entInd.Descripcion & vbCrLf
                    Next

                    .Rows(0).Cells("col_variable_nom").Value = Me._strVariableNombreSel
                    .Rows(0).Cells("col_indicador_nom").Value = IndDescripConcat
                    .Rows(0).Cells("col_etapa").Value = entValTmp.MaestroIndicador(0).Calificacion

                    btnAdd.Visible = False
                End With

            Next

            With Me.dgvFichaVariables
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            End With

        End Sub
#End Region
        Private Sub ValoresxDefault()
            ComboRegionOrigen()
            ComboRegionDestino()
            'ComboPenalDestino()
            ComboRegimenEpOrigen()
            ComboRegimenClasificación()
            'Me.Text = Me.Text & " para la variable " & Me.VariableString.ToUpper

            'If Me._FormLectura = True Then btnOk.Visible = False
            'If Me.BloquearRegistro = True Then btnOk.Enabled = False
        End Sub
        Private Function AGrabar() As Boolean
            Dim v As Boolean = False
            If dtpFechaClasif.Value.Replace(" ", "").Length < 9 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Fecha de clasificación es necesarios.")
                Return False
            End If
            If cbbPenalOrigen.Text = "" Or cbbPenalDestino.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Penal origen y receptor son necesarios.")
                Return False
            End If
            If dtpFechaTraslado.Value = "" Or dtpFechaResol.Value = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Las fecha de resolución y traslado son necesarios.")
                Return False
            End If

            If txtCausal.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Causal no válido.")
                txtCausal.Focus()
                Return False
            End If
            If lblPabellon.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Pabellón no válido.")
                Return False
            End If

            If dgvFichaVariables.Rows.Count <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar el indicador.")
                Return False
            End If

            Dim idIntFic As Integer = -1
            Dim strMensajeOut As String = ""

            Dim objEnt As InternoFicha_BE = New InternoFicha_BE

            With objEnt
                .Codigo = Me._Codigo
                .CodigoPadre = -1
                .IDInterno = Me._InternoId
                .IDInternoIngreso = Me._InternoIngresoId
                .IDInternoIngresoInpe = Me._InternoIngresoInpeId
                .IDFicha = Me._FichaId
                .NumeroClasificacion = Me.NumeroClasificacion
                .FechaClasificacion = Me.FechaHoraClasificacion
                .Observacion = Me.ObservacionClasificacion
                .Puntaje = 0
                .Estado = 0 'pendiente
                .IDFichaTipo = 5 'FICHA POR REGRESION, tabla [dbo].[tra_asi_mae_tipo_ficha]
                .FichaGrupo = 0
                .InternoIDSituacionJuridica = -1
                .InternoIDRegimen = -1
                .InternoIDEtapa = -1
                .MotivoCambio = ""

                .InternoIDRegimen = Me.IdRegimenClasificacion
                .InternoIDEtapa = Me.IdEtapaClasificacion
                .IDRegion = Me._RegId
                .IDPenal = Me._PenId
            End With


            Dim ent As New InternoFichaOtro_BE


            With ent
                .Causal = Me.Causal
                .ResolAutorizacion = Me.ResolAutorizacion
                .FechaResolucion = Me.FechaResol
                .FechaTraslado = Me.FechaTraslado
                .RegionOrigenId = Me.IdRegionOrigen
                .PenalOrigenId = Me.IdPenalOrigen
                .RegionDestinoId = Me.IdRegionDestino
                .PenalDestinoId = Me.IdPenalDestino
                .RegimenId_PenalOrigen = Me.IDRegimenEpOrigen
                .EtapaId_PenalOrigen = Me.IDEtapaEpOrigen
                .InternoPenalFichaId = -1
                .PabellonId = Me.IDPabellon
                '.Estado = 1
                .IdRegion = Me._RegId
                .IdPenal = Me._PenId
            End With

            idIntFic = (New InternoFichaOtro_BL()).GrabarFichaRegresion(objEnt, ent, strMensajeOut)

            If idIntFic < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo grabar el registro, " & strMensajeOut)
                Return False
            End If


            If idIntFic > 0 Then
                For i As Integer = 0 To dgvFichaVariables.Rows.Count - 1
                    Dim entAux As New InternoFichaDetalle_BE()

                    entAux.Codigo = dgvFichaVariables.Rows(i).Cells("col_fic_det_id").Value
                    entAux.IDInternoFicha = idIntFic
                    entAux.IDVariable = dgvFichaVariables.Rows(i).Cells("col_variable_id").Value
                    entAux.IDIndicador = dgvFichaVariables.Rows(i).Cells("col_indicador_id").Value
                    entAux.Ponderacion = 0
                    entAux.PonderacionNoPrevista = 0
                    entAux.IDegion = Me._RegId
                    entAux.IDPenal = Me._PenId

                    Dim str As String = ""

                    Dim idTmp As Integer = (New InternoFichaDetalle_BL()).Grabar(entAux, str)
                Next
            End If
            Return True
        End Function
        Private Sub btnGrabarClasificacion_Click(sender As Object, e As EventArgs) Handles btnGrabarClasificacion.Click
            If AGrabar() = False Then Exit Sub
            Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
            If Me._Codigo <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Para finalizar debe guardar los datos de la ficha.")
                Exit Sub
            End If

            Dim sms As String = ""
            Dim strMensaje As String = "Confirma finalizar el registro?, luego de finalizar ya no podrá modificar."

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then
                Dim value As Integer = (New InternoFicha_BL()).GrabarEstado(Me._Codigo, 1, sms)
                If value = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo cambiar el estado, " & sms)
                    Exit Sub
                End If
                Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria.")

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub

        Private Sub frmMantFichPorRegresionPopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Listar()
        End Sub

        Private Sub ShowGrillaIndicador(InternoPenalFichaDetId As Integer, registroNuevo As Boolean)
            Me.pnlGrilla.Visible = False
            PnlBotonesPrincipal.Visible = False

            '------------------------ cargar variables ------------------------
            Dim entVarCol As MaestroVariableCol_BE
            entVarCol = (New Bussines.Clasificacion.MaestroVariable).Listar(New MaestroVariable_BE With {.FichaID = Me._FichaId})

            ''------- pintar sobre la grilla de la plantilla -------
            Me._VariableIdSel = entVarCol.Variable(0).Codigo
            Me._strVariableNombreSel = entVarCol.Variable(0).Nombre

            '------------------------- cargar indicador -------------------
            Dim bssval As New Bussines.Clasificacion.MaestroIndicador
            Dim entValTmp As MaestroIndicadorCol_BE
            Dim objEnt As New MaestroIndicador_BE

            objEnt.VariableID = Me._VariableIdSel

            'entValTmp = bssval.Listar2(objDetFin.IndicadorId, entVarCol.Variable(0).Codigo, Me.GrillaFicha)
            entValTmp = bssval.Listar(objEnt)

            Dim listaVariables As List(Of MaestroIndicador_BE) = entValTmp.OfType(Of MaestroIndicador_BE)().ToList()

            Dim LST_Grupos = From p In listaVariables
                             Group By Calificacion = p.Calificacion Into Grupo = Group
                             Select New With {
                    .Calificacion = Calificacion
                 }


            Dim listaIndicadorGrilla As New List(Of Object)()

            For Each grupo As Object In LST_Grupos

                Dim IndDescripConcat As String = ""
                Dim IdIndicador As Integer = -1
                For Each entInd As MaestroIndicador_BE In listaVariables
                    If entInd.Calificacion = grupo.Calificacion Then

                        IdIndicador = IIf(IdIndicador > 0, IdIndicador, entInd.Codigo)
                        IndDescripConcat = IndDescripConcat & ".- " & entInd.Descripcion & "<br>"
                    End If
                Next

                If IndDescripConcat <> "" Then listaIndicadorGrilla.Add(New With {.Codigo = IdIndicador, .Descripcion = IndDescripConcat, .Calificacion = grupo.Calificacion})

            Next

            Dim s As New System.Text.StringBuilder

            s.Append("<!DOCTYPE html>")
            s.Append("<html>")
            s.Append("<head>")
            s.Append("  <meta http-equiv='X-UA-Compatible' content='IE=edge'>")
            s.Append("  <style>")
            s.Append("    #tbl_indicador {")
            s.Append("      border-collapse: collapse;")
            s.Append("      width: 100%;")
            s.Append("    }")
            s.Append("    #tbl_indicador td, #tbl_indicador th {")
            s.Append("      border: 1px solid #ddd;")
            s.Append("      padding: 4px;font-size: 0.85em;")
            s.Append("    }")
            s.Append("    #tbl_indicador th {")
            s.Append("      padding-top: 10px;")
            s.Append("      padding-bottom: 10px;")
            s.Append("      text-align: center;")
            s.Append("      background-color: #4CAF50;")
            s.Append("      color: white;")
            s.Append("    }")
            s.Append("    .selected {")
            s.Append("        background-color: #253e96;")
            s.Append("        color: #ffffff;")
            s.Append("    }")
            s.Append("  </style>")
            s.Append("</head>")
            s.Append("<body>")
            s.Append("<div style='overflow-y: auto; height:350px' id='contenedor_tabla'>")
            s.Append("<table id='tbl_indicador'>")
            s.Append("<thead>")
            s.Append("  <tr>")
            s.Append("    <th style='display:none;'></th>")
            s.Append("    <th>DESCRIPCION</th>")
            s.Append("    <th width = '10%'>CLASIFICACION</th>")
            s.Append("  </tr>")
            s.Append("</thead>")
            s.Append("<tbody>")

            Dim ind As Integer = 0
            Dim fila_tabla_cel As Integer = -1

            For Each obj As Object In listaIndicadorGrilla
                s.Append("  <tr onClick='getRowIndex(this)'><td style='display:none;'>" & obj.Codigo & "</td><td>" & obj.Descripcion & "</td><td align = 'center'>" & obj.Calificacion & "</td></tr>")
            Next
            s.Append("</tbody>")
            s.Append("</table>")
            s.Append("</div>")

            s.Append("<br>")

            s.Append("<div style='text-align:right; padding-top:5px;padding-bottom:5px; border:1px solid gray;width:100%;background-color: #f5f5f5;'>")
            s.Append("    <label style='font-size: 1.4em;'>Clasificación: </label> ")
            s.Append("    <input type='text' id='txtPtje' readonly name='txtPtje' style='width:50px;font-size: 1.4em;;text-align:center' value = " & Me._strCalificacion & ">")
            s.Append("    <input type='hidden' id='txtIndicadorNom' name='txtIndicadorNom' value=''>")
            s.Append("    <input type='hidden' id='txtIndicadorId' name='txtIndicadorId' value=''>")
            s.Append("</div>")

            s.Append("<script>")
            s.Append("	document.oncontextmenu = function() {return false;};")
            s.Append("	var indice=" & fila_tabla_cel & ";")
            s.Append("	var table = document.getElementById('tbl_indicador'),")
            s.Append("		selected = table.getElementsByClassName('selected');")
            s.Append("		table.onclick = highlight;")
            s.Append("    function highlight(e) {")
            s.Append("		if (selected[0]) selected[0].className = '';")
            s.Append("		e.target.parentNode.className = 'selected';")
            s.Append("	}")
            s.Append("	function getRowIndex(fila){")
            s.Append("    	indice = fila.rowIndex;")
            s.Append("        	document.getElementById('txtPtje').value = table.rows[indice].cells.item(2).innerHTML;")
            s.Append("        	document.getElementById('txtIndicadorNom').value = table.rows[indice].cells.item(1).innerHTML;")
            s.Append("        	document.getElementById('txtIndicadorId').value = table.rows[indice].cells.item(0).innerHTML;")


            s.Append("    }")
            s.Append("    function poblarTabla(tabla ){")
            s.Append("    	document.getElementById('contenedor_tabla').innerHTML = tabla;")
            s.Append("    }")
            s.Append("    function loadPtje(ptjeNoPrev, ptje){")
            s.Append("    	document.getElementById('txtPtje').value = ptje;")
            s.Append("        document.getElementById('txtPtjeNoPrev').value = ptjeNoPrev;")
            s.Append("    	if(ptjeNoPrev>0){")
            s.Append("        	document.getElementById('txtPtje').disabled = true;")
            s.Append("            document.getElementById('txtPtjeNoPrev').disabled = false;")
            s.Append("        }else{")
            s.Append("        	document.getElementById('txtPtje').disabled = false;")
            s.Append("            document.getElementById('txtPtjeNoPrev').disabled = true;")
            s.Append("        }")
            s.Append("    }")
            s.Append("    function setTxtCalificacion(valor){")
            s.Append("    	document.getElementById('txtPtje').value = valor;")
            s.Append("    }")
            s.Append("    function getTxtCalificacion(){")
            s.Append("    	return document.getElementById('txtPtje').value;")
            s.Append("    }")
            s.Append("    function getTxtIndicadorNombre(){")
            s.Append("    	return document.getElementById('txtIndicadorNom').value;")
            s.Append("    }")
            s.Append("    function getTxtIndicadorId(){")
            s.Append("    	return document.getElementById('txtIndicadorId').value;")
            s.Append("    }")


            s.Append("    function getIndiceSelTabla(){")
            s.Append("    	return indice;")
            s.Append("    }    ")
            s.Append("    function getValorIdSeleccionado(){")
            s.Append("    	return table.rows[indice].cells.item(0).innerHTML;")
            s.Append("    }    ")
            s.Append("    function getValorNombreSeleccionado(){")
            s.Append("    	return table.rows[indice].cells.item(1).innerHTML;")
            s.Append("    }")
            s.Append("</script>")
            s.Append("</body>")
            s.Append("</html>")

            webBrowser1.DocumentText = s.ToString()

        End Sub

        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            Me._GrillaIndicadorId_select = -1
            ShowGrillaIndicador(Me._GrillaIndicadorId_select, True)
        End Sub

        Private Sub btnAceptIncador_Click(sender As Object, e As EventArgs) Handles btnAceptIncador.Click
            If webBrowser1.Document.InvokeScript("getTxtIndicadorId") Is Nothing Or webBrowser1.Document.InvokeScript("getTxtIndicadorId") = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar un indicador.")
                Exit Sub
            End If
            Dim idFicDetId As Integer = -1
            If Me._Codigo > 0 Then
                'grabar en BD
                Dim entAux As New InternoFichaDetalle_BE()

                entAux.Codigo = -1
                entAux.IDInternoFicha = Me._IDInternoFicha
                entAux.IDVariable = Me._VariableIdSel
                entAux.IDIndicador = webBrowser1.Document.InvokeScript("getTxtIndicadorId")
                entAux.Ponderacion = 0
                entAux.PonderacionNoPrevista = 0
                entAux.IDegion = Me._RegId
                entAux.IDPenal = Me._PenId

                Dim str As String = ""

                idFicDetId = (New InternoFichaDetalle_BL()).Grabar(entAux, str)
                If idFicDetId <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo guardar el registro.")
                    Exit Sub
                End If
            End If

            With dgvFichaVariables
                .Rows.Add()
                .Rows(0).Cells("col_fic_det_id").Value = idFicDetId
                .Rows(0).Cells("col_fic_id").Value = Me._FichaId
                .Rows(0).Cells("col_variable_id").Value = Me._VariableIdSel
                .Rows(0).Cells("col_indicador_id").Value = webBrowser1.Document.InvokeScript("getTxtIndicadorId")
                .Rows(0).Cells("col_variable_nom").Value = Me._strVariableNombreSel
                .Rows(0).Cells("col_indicador_nom").Value = webBrowser1.Document.InvokeScript("getTxtIndicadorNombre")
                .Rows(0).Cells("col_etapa").Value = webBrowser1.Document.InvokeScript("getTxtCalificacion")
            End With

            cbbEtapaClasif.Text = webBrowser1.Document.InvokeScript("getTxtCalificacion")
            pnlGrilla.Visible = True
            PnlBotonesPrincipal.Visible = True
            btnAdd.Visible = False
        End Sub

        Private Sub btnCancelIndicador_Click(sender As Object, e As EventArgs) Handles btnCancelIndicador.Click
            pnlGrilla.Visible = True
            PnlBotonesPrincipal.Visible = True
        End Sub



        Private Sub frmMantFichPorRegresionPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ValoresxDefault()
            btnFinalizar.Visible = Me._frmEscritura
            btnGrabarClasificacion.Visible = Me._frmEscritura
            btnAdd.Visible = Me._frmEscritura
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegionDestino._SelectedIndexChanged
            Me.ComboPenalDestino()
        End Sub

        Private Sub cbbRegimen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbRegimenEpOrigen.SelectedIndexChanged
            If Me.blnComboRegimen = True Then
                ComboEtapaEpOrigen(Me.IDRegimenEpOrigen)
            End If
        End Sub

        Private Sub cbbRegimenClasif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbRegimenClasif.SelectedIndexChanged
            ComboEtapaClasificación(Me.IdRegimenClasificacion)
            Me.IdEtapaClasificacion = 7
            Me.IDPabellon = -1
            lblPabellon.Text = ""
        End Sub

        Private Sub cbbRegionOrigen__SelectedIndexChanged() Handles cbbRegionOrigen._SelectedIndexChanged
            Me.ComboPenalOrigen()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnBuscarPabellon_Click(sender As Object, e As EventArgs) Handles btnBuscarPabellon.Click
            If dgvFichaVariables.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el indicador.")
                Exit Sub
            End If

            Dim frm As New Tratamiento.Asistencia.Clasificacion.Penal.frmGrillaPabellonPopup
            With frm
                ._IDEtapa = Me.IdEtapaClasificacion
                ._IDRegion = Me._RegId
                ._IDPenal = Me._PenId
                If .ShowDialog = DialogResult.OK Then
                    Me.IDPabellon = ._getIDPabellon
                    lblPabellon.Text = ._getPabellonNomre
                End If

            End With
        End Sub

        Private Sub cbbEtapaClasif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEtapaClasif.SelectedIndexChanged
            Me.IDPabellon = -1
            lblPabellon.Text = ""
        End Sub


        Private Sub dgvFichaVariables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFichaVariables.CellClick
            If e.RowIndex = -1 Then Exit Sub

            If dgvFichaVariables.Columns(e.ColumnIndex).Name = "col_button_elimina" Then
                Dim strMensaje As String = "Confirma eliminar el registro seleccionado?"
                If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then

                    If dgvFichaVariables.Item("col_fic_det_id", e.RowIndex).Value > 0 Then
                        Dim id As Integer = (New InternoFichaDetalle_BL()).Eliminar(dgvFichaVariables.Item("col_fic_det_id", e.RowIndex).Value)
                        If id = -1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo eliminar el registro.")
                            Exit Sub
                        End If
                    End If
                    Me.IdEtapaClasificacion = 7
                    dgvFichaVariables.Rows.RemoveAt(0)
                    btnAdd.Visible = True
                End If
            End If

            If dgvFichaVariables.Columns(e.ColumnIndex).Name = "col_button_edit" Then
                Me._GrillaIndicadorId_select = dgvFichaVariables.Item("col_fic_det_id", e.RowIndex).Value
                ShowGrillaIndicador(Me._GrillaIndicadorId_select, False)
            End If
        End Sub
    End Class

End Namespace
