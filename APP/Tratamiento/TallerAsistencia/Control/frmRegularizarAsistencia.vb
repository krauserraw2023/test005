Namespace Tratamiento.TallerAsistencia
    Public Class frmRegularizarAsistencia
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
        Private Property ActividadLaboral() As String
            Get
                Return Me.txtActividadLaboral.Text
            End Get
            Set(ByVal value As String)
                Me.txtActividadLaboral.Text = value
            End Set
        End Property

#End Region
#Region "Propiedades"
        Private Property _Codigo() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Private Property InternoID() As Integer = -1
        Private Property ActividadLaboralId() As Integer = -1

        Public Property MotivoJustificacionId() As Integer
            Get
                Return Me.cbbTipoJustificacion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoJustificacion.SelectedValue = value
            End Set
        End Property
        Private Property FechaAsistencia() As Long
            Get
                Return Me.dtpFechaAsistencia.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaAsistencia.ValueLong = value
            End Set
        End Property

        Private Property HoraEntrada() As Integer
            Get
                Return Me.nudInicioHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioHora.Value = value
            End Set
        End Property
        Private Property MinutoIngreso() As Integer
            Get
                Return Me.nudInicioMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioMinuto.Value = value
            End Set
        End Property
        Private ReadOnly Property HoraMinutosEntrada As String
            Get
                Dim val As String = ""
                val = IIf(Me.HoraEntrada > 9, Me.HoraEntrada, "0" & Me.HoraEntrada) & ":" & IIf(Me.MinutoIngreso > 9, Me.MinutoIngreso, "0" & Me.MinutoIngreso) & ":" & "00"
                Return val
            End Get
        End Property
        Private Property HoraSalida() As Integer
            Get
                Return Me.nudFinHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudFinHora.Value = value
            End Set
        End Property

        Private Property MinutoSalida() As Integer
            Get
                Return Me.nudFinMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudFinMinuto.Value = value
            End Set
        End Property

        Private ReadOnly Property HoraMinutosSalida As String
            Get
                Dim val As String = ""
                val = IIf(Me.HoraSalida > 9, Me.HoraSalida, "0" & Me.HoraSalida) & ":" & IIf(Me.MinutoSalida > 9, Me.MinutoSalida, "0" & Me.MinutoSalida) & ":" & "00"
                Return val
            End Get
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
                    Me.ActividadLaboral = .NombreTaller
                    Me.ActividadLaboralId = .CodigoActividad
                End With
            End If
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            If Me.InternoID = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno.")
                Return False
            End If

            If Me.MotivoJustificacionId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar Justificación")
                Me.cbbTipoJustificacion.Focus()
                Return False
            End If

            If dtpFechaAsistencia.ValueLong = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar la fecha.")
                Me.dtpFechaAsistencia.Focus()
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

            If nudInicioHora.Value > nudFinHora.Value Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La hora de salida no puede ser mayor a la de ingreso.")
                Me.nudFinHora.Focus()
                Return False
            End If

            If Me.MotivoJustificacionId = 1 And Me.Observacion.Length < 5 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El motivo OTROS, requiere ingresar una observacion minima de 5 caracteres.")
                Me.txtObservacion.Focus()
                Return False
            End If

            If Me.txtObservacion.Text.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe indicar el motivo por el cual se está registrando de manualmente.")
                txtObservacion.Focus()
                Return False
            End If

            If dtpFechaAsistencia.ValueLong > Now.ToFileTime Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha no puede ser futura.")
                Me.dtpFechaAsistencia.Focus()
                Return False
            End If

            Return True
        End Function

        Private Sub Grabar()

            If Validar() = True Then

                Dim intValue As Integer = -1
                Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                Dim objbss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia

                With obj

                    If Me.blnEntrada = True Then
                        obj.Codigo = -1
                    ElseIf Me.blnSalida = True Then
                        obj.Codigo = Me._Codigo
                    End If

                    obj.InternoID = Me.InternoID
                    obj.CodigoTaller = Me.CodigoTaller
                    obj.MotivoJustificacionID = Me.MotivoJustificacionId
                    obj.Fecha = Me.FechaAsistencia
                    obj.HoraEntrada = Me.HoraMinutosEntrada
                    obj.HoraSalida = Me.HoraMinutosSalida
                    obj.Observacion = Me.Observacion
                    obj.EstadoJustificacion = 0 ' falto con justificacion
                    obj.RegionID = Me._RegionID
                    obj.PenalID = Me._PenalID
                End With

                Dim strMensaje As String = ""
                intValue = objbss.Grabar_v2(obj, strMensaje)

                If intValue > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                Else
                    If strMensaje.Trim.Length > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha podido realizar la operacion vuelva ha intentarlo")
                    End If
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
            Combo()
            pnlOK.Visible = Me._FormEscritura
        End Sub
        Private Sub ConfigurarEntrada()
            blnEntrada = True
            blnSalida = False
            btnCargarInterno.Visible = True
            Me.nudInicioHora.Enabled = True
            Me.nudInicioMinuto.Enabled = True
        End Sub

        Private Sub ConfigurarSalida()
            blnEntrada = False
            blnSalida = True
            btnCargarInterno.Visible = False
            Me.nudInicioHora.Enabled = False
            Me.nudInicioMinuto.Enabled = False

            Me.nudFinHora.Enabled = True
            Me.nudFinMinuto.Enabled = True
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
        End Sub

        Private Sub frmRegularizarAsistencia__Buscar() Handles Me._Buscar

        End Sub
    End Class

End Namespace
