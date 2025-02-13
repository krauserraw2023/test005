Imports Bussines.Tratamiento.Asistencia.Clasificacion
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Registro.Carceleta.Clasificacion
Imports Entity.Tratamiento.Asistencia.Clasificacion
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Imports System.Data
Imports System.Linq

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class frmMantFichClasifTrasladoPopup
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmEliminar As Boolean = False

        Private TIPO_FICHA_CLASIFICACION_POR_TRASLADO As Integer = 6

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

        Private Property CausalTralado() As Short
            Get
                Return Me.cboCausal.SelectedValue
            End Get
            Set(value As Short)
                Me.cboCausal.SelectedValue = value
            End Set
        End Property


        'Private Property IDRegimenEpOrigen() As Short
        '    Get
        '        Return Me.cbbRegimenEpOrigen.SelectedIndex
        '    End Get
        '    Set(value As Short)
        '        Me.cbbRegimenEpOrigen.SelectedIndex = value
        '    End Set
        'End Property
        'Private Property IDEtapaEpOrigen() As Short
        '    Get
        '        Return Me.cbbEtapaEpOrigen.SelectedValue
        '    End Get
        '    Set(value As Short)
        '        Me.cbbEtapaEpOrigen.SelectedValue = value
        '    End Set
        'End Property


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
        Private Property FechaInicioRegimen As Long
            Get
                Return dtpFechaIniRegimen.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpFechaIniRegimen.ValueLong = value
            End Set
        End Property
        Private Property FechaInicioEtapa As Long
            Get
                Return dtpFechaIniEtapa.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpFechaIniEtapa.ValueLong = value
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
        'Private Property Causal() As String
        '    Get
        '        Return txtCausal.Text
        '    End Get
        '    Set(ByVal value As String)
        '        txtCausal.Text = value
        '    End Set
        'End Property
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
        Private Sub ComboCausalTraslado()
            Dim ent As New CausalTraslado_BE() With {
                 .Codigo = -1
                }

            Dim ls As List(Of CausalTraslado_BE) = (New CausalTraslado_BL).Listar(ent)
            ls.Add(New CausalTraslado_BE() With {
                .Codigo = -1,
                .Causal = "[SELECCIONE OPCION]"
                   })

            ls = ls.OrderBy(Function(causal) causal.Codigo).ToList()

            cboCausal.DataSource = ls

            cboCausal.DisplayMember = "Causal" ' Reemplaza "Nombre" por el nombre de la propiedad que deseas mostrar
            cboCausal.ValueMember = "Codigo" ' Reemplaza "Id" por el nombre de la propiedad que contiene el Id

        End Sub
        Private Sub ComboRegimenClasificación()
            With Me.cbbRegimenClasif
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Regimen Cerrado Ordinario - R.C.O.")
                .Items.Add("Regimen Cerrado Especial - R.C.E.")
            End With
            Me.IdRegimenClasificacion = 0
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
            'With Me.cbbRegimenEpOrigen
            '    .Items.Clear()
            '    .Items.Add("[Seleccione]")
            '    .Items.Add("Regimen Cerrado Ordinario - R.C.O.")
            '    .Items.Add("Regimen Cerrado Especial - R.C.E.")
            'End With
            'Me.IDRegimenEpOrigen = 0
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

            'With Me.cbbEtapaEpOrigen
            '    .ValueMember = "Codigo"
            '    .DisplayMember = "Nombre"
            '    .DataSource = objDT
            'End With

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
            entFicMae.TipoFichaId = Me.TIPO_FICHA_CLASIFICACION_POR_TRASLADO


            entFicCol_ = (New Bussines.Clasificacion.MaestroFicha).Listar(entFicMae)

            If entFicCol_.Count > 0 Then
                entFicMae = entFicCol_.Ficha(0)
                Me._FichaId = entFicMae.Codigo
            End If

            If Me._Codigo < 0 Then Exit Sub

            Dim entIntFic As InternoFicha_BE = (New InternoFicha_BL()).Listar(Me._Codigo)

            If entIntFic.Estado = 1 Then 'bloqueado
                btnGrabarClasificacion.Enabled = False
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
                Me.FechaInicioRegimen = .FechaInicioRegimen
                Me.FechaInicioEtapa = .FechaInicioEtapa
                lblEstado.Text = IIf(.Estado = 0, "PENDIENTE", "FINALIZADO")
                .InternoIDEtapa = -1
            End With

            Dim lstFicOtro As List(Of InternoFichaOtro_BE) = (New InternoFichaOtro_BL()).Listar(New InternoFichaOtro_BE With {.InternoPenalFichaId = entIntFic.Codigo})
            If lstFicOtro.Count > 0 Then
                With lstFicOtro.Item(0)
                    'Me.InternoFichaOtroId = .Codigo
                    'Me.Causal = .Causal
                    cboCausal.SelectedValue = .CausalId
                    Me.ResolAutorizacion = .ResolAutorizacion
                    Me.FechaResol = .FechaResolucion
                    Me.FechaTraslado = .FechaTraslado
                    Me.IdRegionOrigen = .RegionOrigenId
                    Me.IdPenalOrigen = .PenalOrigenId
                    Me.IdRegionDestino = .RegionDestinoId
                    Me.AmbienteStr = .Ambiente
                    Me.AleroId  = .AleroId 
                    Me.IdPenalDestino = .PenalDestinoId
                    Me.IDPabellon = .PabellonId
                    Me.AmbienteStr = .Ambiente
                    Me.PisoStr = .Piso
                    Me.AleroStr = .Alero
                    Me.CamaStr = .Cama

                    lblPabellon.Text = .PabellonNombre
                End With
            End If




        End Sub
#End Region
        Private Sub ValoresxDefault()
            ComboRegionOrigen()
            ComboRegionDestino()
            'ComboPenalDestino()
            ComboRegimenEpOrigen()
            ComboRegimenClasificación()
            ComboCausalTraslado()
            'Me.Text = Me.Text & " para la variable " & Me.VariableString.ToUpper

            'If Me._FormLectura = True Then btnOk.Visible = False
            'If Me.BloquearRegistro = True Then btnOk.Enabled = False
        End Sub
        Private Function AGrabar() As Boolean
            Dim v As Boolean = False
            If dtpFechaClasif.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Fecha de clasificación es necesarios.")
                Return False
            End If
            If dtpFechaResol.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Fecha de resolución incorrecta.")
                Return False
            End If
            If dtpFechaTraslado.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Fecha de trslado incorrecto.")
                Return False
            End If
            If dtpFechaIniRegimen.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Fecha de inicio de régimen incorrecta.")
                Return False
            End If
            If dtpFechaIniEtapa.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Fecha de inicio de etapa incorrecta.")
                Return False
            End If
            If cbbPenalOrigen.Text = "" Or cbbPenalDestino.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Penal origen y receptor son necesarios.")
                Return False
            End If

            If Me.CausalTralado = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Causal no válido.")
                Return False
            End If
            If lblPabellon.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Pabellón no válido.")
                Return False
            End If
            If Me.AleroId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el alero.")
                Return False
            End If
            If Me.AmbienteStr = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingres el ambiente.")
                Return False
            End If
            If cbbEtapaClasif.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione etapa.")
                Return False
            End If
            If txtCama.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Falta indicar cama.")
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
                .IDFichaTipo = Me.TIPO_FICHA_CLASIFICACION_POR_TRASLADO
                .FichaGrupo = 0
                .InternoIDSituacionJuridica = -1
                .MotivoCambio = ""

                .InternoIDRegimen = Me.IdRegimenClasificacion
                .InternoIDEtapa = Me.IdEtapaClasificacion
                .FechaInicioRegimen = Me.FechaInicioRegimen
                .FechaInicioEtapa = Me.FechaInicioEtapa
                .IDRegion = Me._RegId
                .IDPenal = Me._PenId
            End With


            Dim ent As New InternoFichaOtro_BE


            With ent
                .CausalId = Me.CausalTralado
                .ResolAutorizacion = Me.ResolAutorizacion
                .FechaResolucion = Me.FechaResol
                .FechaTraslado = Me.FechaTraslado
                .RegionOrigenId = Me.IdRegionOrigen
                .PenalOrigenId = Me.IdPenalOrigen
                .RegionDestinoId = Me.IdRegionDestino
                .PenalDestinoId = Me.IdPenalDestino
                .InternoPenalFichaId = -1

                .Cama = Me.CamaStr
                .PabellonId = Me.IDPabellon
                .Ambiente = Me.AmbienteStr
                .AleroId = Me.AleroId
                '.Estado = 1
                .IdRegion = Me._RegId
                .IdPenal = Me._PenId
            End With

            idIntFic = (New InternoFichaOtro_BL()).GrabarFichaClasifTralado(objEnt, ent, strMensajeOut)

            If idIntFic < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo grabar el registro, " & strMensajeOut)
                Return False
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
                Legolas.Configuration.Aplication.MessageBox.Information("Para finalizar debe grabar los datos.")
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




        Private Sub frmMantFichPorRegresionPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ValoresxDefault()
            btnFinalizar.Visible = Me._frmEscritura
            btnGrabarClasificacion.Visible = Me._frmEscritura
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegionDestino._SelectedIndexChanged
            Me.ComboPenalDestino()
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
            If cbbEtapaClasif.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione etapa.")
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
                    Me.PisoStr = ""
                    Me.AleroStr = ""
                    Me._AleroId = -1
                End If

            End With
        End Sub

        Private Sub cbbEtapaClasif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEtapaClasif.SelectedIndexChanged
            Me.IDPabellon = -1
            lblPabellon.Text = ""
        End Sub

        Private Sub btnAlero_Click(sender As Object, e As EventArgs) Handles btnAlero.Click

            Dim f As New frmSelectAleroPopup
            f._PabellonId = Me.IDPabellon

            If f.ShowDialog = DialogResult.OK Then
                Me.PisoStr = f._PisoNom
                Me.AleroStr = f._AleroNom
                Me._AleroId = f._AleroId
            End If
        End Sub
    End Class
End Namespace