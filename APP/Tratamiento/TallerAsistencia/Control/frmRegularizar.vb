Namespace Tratamiento.TallerAsistencia
    Public Class frmRegularizar
        Private objBss As Bussines.Tratamiento.TallerAsistencia.InternoAsistencia = Nothing
        'movimiento
        Private objBssMov As Bussines.Visita.Movimiento = Nothing
        Private objEntColMov As Entity.Visita.MovimientoCol = Nothing
#Region "Enum"
        Public Enum enmTipoSalida
            Ninguno = 0
            Salida = 1
            SalidaNumeroDocumento = 2
        End Enum
#End Region
#Region "Propiedades"
        Public Property _Codigo() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property MotivoJustificacionId() As Integer = -1
        Public Property MotivoJustificacionNombre() As String
            Get
                Return txtJustificacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtJustificacion.Text = value
            End Set
        End Property
        Public Property _FechaAsistencia() As String
            Get
                Return Me.txtFecha.Text
            End Get
            Set(ByVal value As String)
                Me.txtFecha.Text = value
            End Set
        End Property
        Public Property _HoraEntrada() As String
        Public Property _HoraIngreso() As Integer
            Get
                Return Me.nudInicioHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioHora.Value = value
            End Set
        End Property
        Public Property _MinutoIngreso() As Integer
            Get
                Return Me.nudInicioMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioMinuto.Value = value
            End Set
        End Property


        Public Property _HoraSalida() As Integer
            Get
                Return Me.nudFinHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudFinHora.Value = value
            End Set
        End Property

        Public Property _MinutoSalida() As Integer
            Get
                Return Me.nudFinMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudFinMinuto.Value = value
            End Set
        End Property
        Private ReadOnly Property HoraMinutosEntrada As String
            Get
                Dim val As String = ""
                val = IIf(Me._HoraIngreso > 9, Me._HoraIngreso, "0" & Me._HoraIngreso) & ":" & IIf(Me._MinutoIngreso > 9, Me._MinutoIngreso, "0" & Me._MinutoIngreso) & ":" & "00"
                Return val
            End Get
        End Property
        Private ReadOnly Property HoraMinutosSalida As String
            Get
                Dim val As String = ""
                val = IIf(Me._HoraSalida > 9, Me._HoraSalida, "0" & Me._HoraSalida) & ":" & IIf(Me._MinutoSalida > 9, Me._MinutoSalida, "0" & Me._MinutoSalida) & ":" & "00"
                Return val
            End Get
        End Property
        Public Property _Habilitar As Boolean = True
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaFecha() As String
            Get
                Dim strValue As String = ""
                Try
                    'With Me.dgwGrilla
                    '    strValue = Legolas.Configuration.Aplication.FechayHora.FechaLong
                    'End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region
#Region "Propiedades_Otros"
        Private Property Observacion() As String
            Get
                Return Me.txtObservacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
        Private ReadOnly Property IDUsuarioAutorizaSalida As Integer
            Get
                Return Legolas.Configuration.Usuario.Codigo
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()
            cbbHoraEntradaSalida.Items.Add("Hora E / S")
            cbbHoraEntradaSalida.Items.Add("Hora Entrada")
            cbbHoraEntradaSalida.Items.Add("Hora Salida")
            cbbHoraEntradaSalida.SelectedIndex = 0
        End Sub
#End Region
#Region "Validar"

        Private Property pnlHora As Object

        Private Function ValidarBusqueda() As Boolean
            Dim objCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            objBss = New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim value As Boolean = True

            Return value
        End Function
#End Region

#Region "Accion"
        Private Function Validar() As Boolean
            Dim value As Boolean = True

            If Me.MotivoJustificacionId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar una Justificacción")
                txtJustificacion.Focus()
                Return False
            End If
            If Me.nudInicioHora.Value = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar la Hora de entrada.")
                Me.nudInicioHora.Focus()
                Return False
            End If

            If Me.nudFinHora.Value = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar la Hora de salida.")
                Me.nudFinHora.Focus()
                Return False
            End If

            If nudInicioHora.Value > nudFinHora.Value And cbbHoraEntradaSalida.SelectedIndex = 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La hora de salida no puede ser mayor a la de ingreso.")
                Me.nudFinHora.Focus()
                Return False
            End If

            If Me.cbbHoraEntradaSalida.SelectedIndex = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe indicar si la Hora es de [entrada o salida]")
                cbbHoraEntradaSalida.Focus()
                Return False
            End If

            If Me.MotivoJustificacionId = 1 And Me.txtObservacion.Text.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe indicar una observación minima de 3 caracteres")
                txtObservacion.Focus()
                Return False
            End If

            Return value
        End Function
        Private Sub AOk()
            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim objbss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            obj.Codigo = Me._Codigo
            obj = objbss.ListarAsistenciaInterno(obj).Item(0)
            With obj
                obj.Codigo = Me._Codigo
                obj.MotivoJustificacionID = Me.MotivoJustificacionId
                obj.EstadoJustificacion = 1  'Estado justificacion  1=asistio,0=falta con justificacion
                obj.HoraEntrada = IIf(cbbHoraEntradaSalida.SelectedIndex = 1, Me.HoraMinutosEntrada, Me.HoraMinutosSalida)
                obj.HoraSalida = IIf(cbbHoraEntradaSalida.SelectedIndex = 2, Me.HoraMinutosEntrada, Me.HoraMinutosSalida)
                obj.Observacion = Me.Observacion
            End With
            intValue = objbss.Grabar_v2(obj, "")

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub
#End Region

#Region "Otros"

        Private Sub ValoresxDefault()
            Me.MotivoJustificacionId = 1 'omision
            Me.MotivoJustificacionNombre = "Omision de marcado"
            Combo()
            pnlHoraInicio.Enabled = Me._Habilitar
            Dim objbss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            obj.Codigo = Me._Codigo
            obj = objbss.ListarAsistencia_v2(obj).Item(0)

            txtFecha.Text = obj.FechaDate
                Dim horEnt As String = ""
                Dim horSal As String = ""
                horEnt = obj.HoraEntrada
                horSal = obj.HoraSalida
            If horEnt.Length > 0 Then
                If obj.MotivoJustificacionID > 0 Then
                    Me.MotivoJustificacionId = obj.MotivoJustificacionID
                End If
                nudInicioHora.Value = obj.HoraEntrada.Split(":")(0)
                nudInicioMinuto.Value = obj.HoraEntrada.Split(":")(1)
            End If
            If horSal.Length > 0 Then
                    cbbHoraEntradaSalida.SelectedIndex = 1
                    nudFinHora.Value = obj.HoraSalida.Split(":")(0)
                    nudFinMinuto.Value = obj.HoraSalida.Split(":")(1)
                End If
            txtObservacion.Text = obj.Observacion
        End Sub
        Private Sub HabilitarEtiqueta()
            Select Case cbbHoraEntradaSalida.SelectedIndex
                Case 1
                    lblHoraEntradaSalida.Text = "Hora Salida :"
                Case 2
                    lblHoraEntradaSalida.Text = "Hora Entrada :"
                Case Else
                    lblHoraEntradaSalida.Text = "Hora E/S :"
            End Select
        End Sub
#End Region

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOk()

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub pnlOK_GotFocus(sender As Object, e As System.EventArgs) Handles pnlOK.GotFocus

            Me.btnOk.Focus()

        End Sub


        Private Sub frmRegularizar_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            pnlOK.Visible = Me._FormEscritura
            ValoresxDefault()
        End Sub

        Private Sub frmRegularizar_Load(sender As Object, e As EventArgs) Handles Me.Load

        End Sub

        Private Sub cbbHoraEntradaSalida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbHoraEntradaSalida.SelectedIndexChanged
            HabilitarEtiqueta()
        End Sub
    End Class

End Namespace
