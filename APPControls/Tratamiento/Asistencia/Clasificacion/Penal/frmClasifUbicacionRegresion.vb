Imports System.Data
Imports System.Linq
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Registro.Carceleta.Clasificacion
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class frmClasifUbicacionRegresion
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
        'Private Property AmbienteId As Integer = -1

        Public Property IDPabellon As Integer = -1
        Private Property _IDInternoFicha As Integer = -1
        Private Property _strCalificacion As String = ""
        Private Property _strVariableNombreSel As String = ""
        Private Property _VariableIdSel As Integer = -1
        Private Property _GrillaIndicadorId_select As Integer = -1
        Private Property _FichaId As Integer = -1

        Private Property EstadoFicha As Integer = -1

        Private blnComboRegimen As Boolean = False
        Private Property HoraClasif() As String
            Get

                Return Me.nudHoraUbic._Value
            End Get
            Set(ByVal value As String)
                Me.nudHoraUbic._Value = value
            End Set
        End Property
        Private Property MinutoClasif() As String
            Get

                Return Me.nudMinutosUbic._Value
            End Get
            Set(ByVal value As String)
                Me.nudMinutosUbic._Value = value
            End Set
        End Property
        Private Property FechaClasificacionUbic() As Long
            Get
                Return dtpFechaClasifUbic.ValueLong
            End Get
            Set(value As Long)
                dtpFechaClasifUbic.ValueLong = value
            End Set
        End Property
        Private ReadOnly Property FechaHoraClasificacionUbic As Long
            Get
                Dim FechaTotal As String
                Dim Hora As String = "00"
                Dim Minutos As String = "00"

                Dim fecha As String = dtpFechaClasifUbic.Value & " " & CStr(HoraClasif) & ":" & CStr(MinutoClasif) & ":00"
                FechaTotal = CDate(fecha).ToFileTime
                Return FechaTotal
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
        Private Property PisoStr() As String
            Get
                Return Me.txtPiso.Text
            End Get
            Set(value As String)
                Me.txtPiso.Text = value
            End Set
        End Property
        Private Property AmbienteStr() As String
            Get
                Return txtAmbiente.Text
            End Get
            Set(value As String)
                txtAmbiente.Text = value
            End Set
        End Property
        Private Property AleroStr() As String
            Get
                Return txtAlero.Text
            End Get
            Set(value As String)
                txtAlero.Text = value
            End Set
        End Property
        Private Property CamaStr() As String
            Get
                Return txtCama.Text
            End Get
            Set(value As String)
                txtCama.Text = value
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

            'With Me.cbbRegion
            '    .ComboTipo = Type.Combo.ComboTipo.Region
            '    ._Todos = True
            '    .LoadUsc()
            'End With

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

            'With Me.cbbRegion
            '    .ComboTipo = Type.Combo.ComboTipo.Region
            '    ._Todos = True
            '    .LoadUsc()
            'End With

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



            With entIntFic
                Me._InternoIngresoId = .IDInternoIngreso
                Me._InternoIngresoInpeId = .IDInternoIngresoInpe
                Me.NumeroClasificacion = .NumeroClasificacion

                lblFechaClasif.Text = System.DateTime.FromFileTime(.FechaClasificacion)

                Me._IDInternoFicha = .Codigo
                Me.ObservacionClasificacion = .Observacion
                Me.IdRegimenClasificacion = .InternoIDRegimen
                Me.IdEtapaClasificacion = .InternoIDEtapa
                Me.EstadoFicha = .Estado

                .InternoIDEtapa = -1
            End With

            Dim lstFicOtro As List(Of InternoFichaOtro_BE) = (New InternoFichaOtro_BL()).Listar(New InternoFichaOtro_BE With {.InternoPenalFichaId = entIntFic.Codigo})

            If lstFicOtro(0).EstadoClasificacionUbicacionOTT = 1 Then 'bloqueado
                btnGrabarClasificacion.Enabled = False

                btnFinalizar.Enabled = False
            End If

            If lstFicOtro.Count > 0 Then
                With lstFicOtro.Item(0)
                    'Me.InternoFichaOtroId = .Codigo
                    Me.Causal = .Causal
                    Me.ResolAutorizacion = .ResolAutorizacion
                    Me.IdRegionOrigen = .RegionOrigenId
                    Me.IdPenalOrigen = .PenalOrigenId
                    Me.IdRegionDestino = .RegionDestinoId
                    Me.IdPenalDestino = .PenalDestinoId
                    Me.IDRegimenEpOrigen = .RegimenId_PenalOrigen
                    Me.IDEtapaEpOrigen = .EtapaId_PenalOrigen
                    Me.IDPabellon = .PabellonId
                    Me.AmbienteStr = .Ambiente
                    Me.AleroId = .AleroId
                    lblEstado.Text = .EstadoClasificacionUbicacionOTTNom
                    Me.FechaClasificacionUbic = .FechaClasificacionUbicacion
                    Dim fc As Date = Legolas.Components.FechaHora.FechaDate(.FechaClasificacionUbicacion, True)
                    Me.HoraClasif = Format(fc, "HH")
                    Me.MinutoClasif = Format(fc, "mm")
                    lblPabellon.Text = .PabellonNombre
                    Me.AmbienteStr = .Ambiente
                    Me.PisoStr = .Piso
                    Me.AleroStr = .Alero
                    Me.CamaStr = .Cama
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

                End With

            Next



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
        Private Sub btnGrabarClasificacion_Click(sender As Object, e As EventArgs) Handles btnGrabarClasificacion.Click

            If dgvFichaVariables.Rows.Count <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar el indicador.")
                Exit Sub
            End If

            If dtpFechaClasifUbic.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese una fecha válida.")
                Exit Sub
            End If

            If txtAmbiente.Text = "" Or txtCama.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Los campos ambiente y cama no pueden ser vacios.")
                Exit Sub
            End If


            If Me.AleroId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Falta indicar alero")
                Exit Sub
            End If

            Dim idIntFic As Integer = -1
            Dim strMensajeOut As String = ""


            Dim ent As New InternoFichaOtro_BE


            With ent
                .InternoPenalFichaId = Me._Codigo
                .Cama = Me.CamaStr
                .PabellonId = Me.IDPabellon
                .Ambiente = Me.AmbienteStr
                .AleroId = Me.AleroId
                .FechaClasificacionUbicacion = Me.FechaHoraClasificacionUbic
                '.Estado = 1
                .IdRegion = Me._RegId
                .IdPenal = Me._PenId
            End With

            idIntFic = (New InternoFichaOtro_BL()).GrabarFichaUbicacion(ent, strMensajeOut)

            If idIntFic < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo grabar el registro, " & strMensajeOut)
                Exit Sub
            End If

            Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria")

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
            If dgvFichaVariables.Rows.Count <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar el indicador.")
                Exit Sub
            End If

            If dtpFechaClasifUbic.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese una fecha válida.")
                Exit Sub
            End If

            If txtAmbiente.Text = "" Or txtCama.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Los campos ambiente y cama no pueden ser vacios.")
                Exit Sub
            End If
            If Me.AleroId = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el alero.")
                Exit Sub
            End If

            Dim idIntFic As Integer = -1
            Dim strMensajeOut As String = ""


            Dim ent As New InternoFichaOtro_BE


            With ent
                .InternoPenalFichaId = Me._Codigo
                .Cama = Me.CamaStr
                .PabellonId = Me.IDPabellon
                .Ambiente = Me.AmbienteStr
                .AleroId = Me.AleroId
                .FechaClasificacionUbicacion = Me.FechaHoraClasificacionUbic
                '.Estado = 1
                .IdRegion = Me._RegId
                .IdPenal = Me._PenId
            End With

            idIntFic = (New InternoFichaOtro_BL()).GrabarFichaUbicacion(ent, strMensajeOut)

            If idIntFic < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo grabar el registro, " & strMensajeOut)
                Exit Sub
            End If


            Dim sms As String = ""
            Dim strMensaje As String = "Confirma finalizar el registro?, luego de finalizar ya no podrá modificar."

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then
                '
                Dim value As Integer = (New InternoFichaOtro_BL()).GrabarEstadoUbicacion(Me._Codigo, 1, sms)
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



        Private Sub frmMantFichPorRegresionPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ValoresxDefault()
            btnFinalizar.Visible = Me._frmEscritura
            btnGrabarClasificacion.Visible = Me._frmEscritura
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

        Private Sub btnBuscarPabellon_Click(sender As Object, e As EventArgs)
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

        Private Sub btnAlero_Click(sender As Object, e As EventArgs) Handles btnAlero.Click
            If dgvFichaVariables.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el indicador.")
                Exit Sub
            End If

            Dim f As New frmSelectAleroPopup
            f._PabellonId = Me.IDPabellon

            If f.ShowDialog = DialogResult.OK Then
                Me.PisoStr = f._PisoNom
                Me._PisoId = f._PisoId
                Me.AleroStr = f._AleroNom
                Me._AleroId = f._AleroId
            End If
        End Sub

    End Class
End Namespace