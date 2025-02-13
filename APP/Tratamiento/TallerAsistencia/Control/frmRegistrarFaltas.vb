Namespace Tratamiento.TallerAsistencia.Control
    Public Class frmRegistrarFaltas
        Private objBss As Bussines.Tratamiento.TallerAsistencia.InternoAsistencia = Nothing
        Private Property blnEntrada As Boolean = False
        Private Property blnSalida As Boolean = False

#Region "Propiedades_Busqueda_Internos"
        Private Property PrimerPaterno() As String
            Get
                Return Me.txtPrimerApellido.Text()
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value
            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtSegundoApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApellido.Text = value
            End Set
        End Property
        Private Property PreNombres() As String
            Get
                Return Me.txtPrenombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrenombres.Text = value
            End Set
        End Property
        Private ReadOnly Property ApellidosNombres() As String
            Get
                Return Me.PrimerPaterno & " " & Me.SegundoApellido & " " & Me.PreNombres
            End Get
        End Property
        Private Property TipoDocumento() As String
            Get
                Dim value As Integer = ""
                Return Me.txtTipoDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtTipoDoc.Text = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumeroDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumeroDoc.Text = value
            End Set
        End Property
        Private Property CodigoTaller As Integer = -1

        Public Property NombreTaller() As String
            Get
                Return txtActividadLaboral.Text
            End Get
            Set(ByVal value As String)
                txtActividadLaboral.Text = value
            End Set
        End Property

#End Region
#Region "Propiedades Faltas"
        Public Property _Codigo() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Private Property InternoID() As Integer = -1

        Public Property MotivoFaltaId() As Integer
            Get
                Return Me.cbbTipoJustificacion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoJustificacion.SelectedValue = value
            End Set
        End Property

        Private Property FechaInicio() As Long
            Get
                Return Me.dtpFechaInicio.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaInicio.ValueLong = value
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
        Private Property FechaDocumento() As Long
            Get
                Return Me.dtpFechaDocumento.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaDocumento.ValueLong = value
            End Set
        End Property
        Private Property Documento() As String
            Get
                Return Me.txtDocumento.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDocumento.Text = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObservacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()

            With Me.cbbTipoJustificacion
                ._Todos = True
                ._TodosMensaje = "[No Indica]"
                .ModuloTratamiento = True
                .ComboTipo = Type.Combo.Tratamiento.Trabajo.TallerAsistencia.tra_tal_asistencia_justificacion_mae
                .Combo(-1)
                .SelectedValue = -1
            End With

        End Sub

#End Region
#Region "Listar"
        Private Sub listarDatos_Interno(intInternoID As Integer)

            Dim bssT As New Bussines.Tratamiento.TallerAsistencia.InternoTaller
            Dim bss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim objT As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            Dim objColT As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol

            objT.InternoID = intInternoID
            objT.RegionID = Me._RegionID
            objT.PenalID = Me._PenalID
            objColT = bssT.ListarInt(objT)

            If objColT.Count > 0 Then
                With objColT.Item(0)
                    Me.InternoID = .InternoID
                    Me.PrimerPaterno = .ApellidoPaterno
                    Me.SegundoApellido = .ApellidoMaterno
                    Me.PreNombres = .Nombres
                    Me.TipoDocumento = .TipoDocumentoNombre
                    Me.NumeroDocumento = .NumeroDocumento
                    Me.CodigoTaller = .CodigoTaller
                    Me.NombreTaller = .NombreTaller
                End With
            End If
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            Dim strMensaje As String = "fecha de justificación"
            If Me.InternoID = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno.")
                Return False
            End If
            If Me.MotivoFaltaId = 7 Then
                strMensaje = "fecha de inicio"
            Else
                If Me.MotivoFaltaId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Justificación de la falta")
                    Me.cbbTipoJustificacion.Focus()
                    Return False
                End If
            End If

            If dtpFechaInicio.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar la " & strMensaje)
                Me.dtpFechaInicio.Focus()
                Return False
            End If
            If dtpFechaInicio.ValueLong > Now.ToFileTime Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La " & strMensaje & " no puede ser futura.")
                Me.dtpFechaInicio.Focus()
                Return False
            End If

            If Me.MotivoFaltaId = 7 Then
                If dtpFechaFin.ValueLong = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar la fecha fin")
                    Me.dtpFechaFin.Focus()
                    Return False
                End If
                If dtpFechaFin.ValueLong > Now.ToFileTime Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin no puede ser futura.")
                    Me.dtpFechaFin.Focus()
                    Return False
                End If
                If dtpFechaInicio.ValueLong > dtpFechaFin.ValueLong Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de inicio no puede ser mayor que la fecha fin.")
                    Me.dtpFechaFin.Focus()
                    Return False
                End If
                If Me.txtNumeroDoc.Text.Length < 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar el Nº de Documento, minimo de carateres.")
                    txtNumeroDoc.Focus()
                    Return False
                End If
            End If
            Return True
        End Function

        Private Sub Grabar()
            If Validar() = True Then
                Dim intValue As Integer = -1
                Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                Dim objbss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
                If Me.MotivoFaltaId > 0 And Me.MotivoFaltaId < 7 Then
                    With obj
                        obj.Codigo = Me._Codigo
                        obj.InternoID = Me.InternoID
                        obj.CodigoTaller = Me.CodigoTaller
                        obj.Fecha = Me.FechaInicio
                        obj.HoraEntrada = ""
                        obj.HoraSalida = ""
                        obj.MotivoJustificacionID = Me.MotivoFaltaId
                        obj.Documento = "" ' Me.Documento
                        obj.FechaDocumento = 0 ' Me.FechaDocumento
                        obj.FechaInicialRetiro = 0 ' Me.FechaInicio
                        obj.FechaFinalRetiro = 0 'Me.FechaFin
                        obj.EstadoJustificacion = 0 'Justifica inasistencia
                        obj.Observacion = Me.Observacion
                        obj.RegionID = Me._RegionID
                        obj.PenalID = Me._PenalID
                    End With
                    Dim strMensaje As String = ""
                    intValue = objbss.Grabar_v2(obj, strMensaje)
                ElseIf Me.MotivoFaltaId = 7 Then
                    Dim diaI As Integer = Legolas.Components.FechaHora.FechaDia(Me.FechaInicio)
                    Dim diaF As Integer = Legolas.Components.FechaHora.FechaDia(Me.FechaFin)
                    Dim MesI As Integer = Legolas.Components.FechaHora.FechaMes(Me.FechaInicio)
                    Dim AnioI As Integer = Legolas.Components.FechaHora.FechaAnio(Me.FechaInicio)
                    For i As Integer = diaI To diaF
                        Dim FechaDate As Date = i & "/" & MesI & "/" & AnioI
                        Dim FechaLong As Long = Legolas.Components.FechaHora.FechaLong(FechaDate)
                        With obj
                            obj.Codigo = -1
                            obj.InternoID = Me.InternoID
                            obj.CodigoTaller = Me.CodigoTaller
                            obj.Fecha = FechaLong
                            obj.HoraEntrada = ""
                            obj.HoraSalida = ""
                            obj.MotivoJustificacionID = Me.MotivoFaltaId
                            obj.Documento = Me.Documento
                            obj.FechaDocumento = Me.FechaDocumento
                            obj.FechaInicialRetiro = Me.FechaInicio
                            obj.FechaFinalRetiro = Me.FechaFin
                            obj.EstadoJustificacion = 0 'Justifica inasistencia
                            obj.Observacion = Me.Observacion
                            obj.RegionID = Me._RegionID
                            obj.PenalID = Me._PenalID
                        End With
                        Dim strMensaje As String = ""
                        intValue = objbss.Grabar_v2(obj, strMensaje)
                    Next
                End If
                If intValue > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha podido realizar la operacion vuelva ha intentarlo")
                End If
            End If

        End Sub
#End Region
#Region "Form"
        Private Sub frm_BuscarInterno()
            Dim frm As New Tratamiento.TallerAsistencia.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisibleRegionPenal = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.InternoID = ._GrillaInternoID
                    listarDatos_Interno(._GrillaInternoID)
                End If
            End With
        End Sub
#End Region
#Region "Otros"

        Private Sub ValoresxDefault()
            HabilitarControl()
            Combo()
            pnlDocumento.Visible = False
            Panel5.Dock = DockStyle.Fill
            lblObservacion.Dock = DockStyle.Left
            txtObservacion.Dock = DockStyle.Fill
            pnlOK.Visible = Me._FormEscritura
        End Sub
        Private Sub ConfigurarEntrada()
            blnEntrada = True
            blnSalida = False
            btnCargarInterno.Visible = True

        End Sub
        Private Sub Listar()
            If Me._Codigo < 1 Then
                Exit Sub
            End If
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim objCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim objbss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia

            obj.Codigo = Me._Codigo
            objCol = objbss.ListarAsistencia_v2(obj)
            obj = objCol.Item(0)
            Me.MotivoFaltaId = obj.MotivoJustificacionID

            If Me.MotivoFaltaId > 1 Then
                listarDatos_Interno(obj.InternoID)
                btnCargarInterno.Enabled = False
                Me.FechaInicio = obj.Fecha
                Me.Observacion = obj.Observacion
                ControlesJustificacion()
                If Me.MotivoFaltaId = 7 Then  'falta disciplinaria
                    Me.Documento = obj.Documento
                    Me.FechaDocumento = obj.FechaDocumento
                    Me.FechaInicio = obj.FechaInicialRetiro
                    Me.FechaFin = obj.FechaFinalRetiro
                    ControlesFaltaDisciplinaria()
                End If
            Else
                Exit Sub
            End If
        End Sub
        Private Sub ConfigurarSalida()
            blnEntrada = False
            blnSalida = True
            btnCargarInterno.Visible = False

        End Sub

        Private Sub HabilitarControl()
            If Me.MotivoFaltaId = 7 Then
                lblFecha.Text = "Fecha inicio :"
                lblFechaFin.Visible = True
                dtpFechaFin.Visible = True
                pnlDocumento.Visible = True
            Else
                lblFecha.Text = "Fecha"
                lblFechaFin.Visible = False
                dtpFechaFin.Visible = False
                pnlDocumento.Visible = False
            End If
        End Sub
        Private Sub ControlesJustificacion()
            cbbTipoJustificacion.Enabled = False
        End Sub
        Private Sub ControlesFaltaDisciplinaria()
            dtpFechaInicio.Enabled = False
            dtpFechaFin.Enabled = False
            btnOk.Enabled = False
        End Sub
#End Region

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            Grabar()

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub pnlOK_GotFocus(sender As Object, e As System.EventArgs) Handles pnlOK.GotFocus

            Me.btnOk.Focus()

        End Sub


        Private Sub rbtEntrada_CheckedChanged(sender As System.Object, e As System.EventArgs)
            ConfigurarEntrada()
        End Sub

        Private Sub rbtSalida_CheckedChanged(sender As System.Object, e As System.EventArgs)
            ConfigurarSalida()
        End Sub

        Private Sub btnCargarInterno_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarInterno.Click
            frm_BuscarInterno()
        End Sub

        Private Sub frmRegularizarAsistencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
            Listar()
        End Sub

        Private Sub frmRegularizarAsistencia__Buscar() Handles Me._Buscar

        End Sub
        Private Sub cbbTipoJustificacion__SelectedIndexChanged() Handles cbbTipoJustificacion._SelectedIndexChanged
            HabilitarControl()
        End Sub
    End Class

End Namespace
