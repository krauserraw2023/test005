Namespace Tratamiento.TallerAsistencia
    Public Class frmRetiroTaller
        Private objBss As Bussines.Tratamiento.TallerAsistencia.InternoTaller = Nothing
        Dim ws As APPWebService.ws_pope_ep_trat_asist_tall.ApiBiostarClient
#Region "Propiedades"
        Public Property _IDInternoTaller() As Integer = -1
        Public Property _IDMotivoRetiro() As Integer = -1
        Public Property _IDInterno() As Integer = -1
        Public Property _IDRegion() As Short = -1
        Public Property _IDPenal() As Short = -1
        Private Property IDMotivoRetiro() As Integer
            Get
                Return cbbMotivoRetiro.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMotivoRetiro.SelectedValue = value
            End Set
        End Property
        Private Property Fecha() As Long
            Get
                Return dtpFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFecha.ValueLong = value
            End Set
        End Property
        Private Property FechaDoc() As Long
            Get
                Return dtpFinFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFinFecha.ValueLong = value
            End Set
        End Property
        Private Property Documento() As String
            Get
                Return Me.txtDocumento.Text
            End Get
            Set(ByVal value As String)
                Me.txtDocumento.Text = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub ComboMotivo()

            With Me.cbbMotivoRetiro
                ._LoadUsc(Type.Combo.Tratamiento.Trabajo.TallerAsistencia.tra_tal_motivo_retiro_mae, True)
            End With

        End Sub
#End Region
#Region "Validar"
        Private Function Validar() As Boolean
            Dim value As Boolean = False

            If cbbMotivoRetiro.SelectedValue < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione motivo de retiro")
                cbbMotivoRetiro.Focus()
                Return value
            End If

            If dtpFecha.ValueLong < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha de retiro")
                dtpFecha.Focus()
                Return value
            End If
            Select Case Me.IDMotivoRetiro
                Case 4, 5, 6
                Case Else
                    If Me.Documento.Length < 3 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el documento de referencia")
                        txtDocumento.Focus()
                        Return value
                    End If
            End Select
            value = True
            Return value
        End Function
#End Region
#Region "Accion"
        Private Sub AGrabar()

            If Validar() = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Desea realizar el registro de retiro del interno al taller actual") = Windows.Forms.DialogResult.Yes Then
                    Dim out_Eror As String = ""
                    Dim intValue As Integer = -1
                    objBss = New Bussines.Tratamiento.TallerAsistencia.InternoTaller
                    Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoTaller

                    With obj
                        .Codigo = Me._IDInternoTaller
                        .InternoID = Me._IDInterno
                        .RegionID = Me._IDRegion
                        .PenalID = Me._IDPenal
                        .MotivoRetiroID = Me.IDMotivoRetiro
                        .Fecha = Me.Fecha
                        .FechaDocumento = Me.FechaDoc
                        .NumeroDocumento = Me.Documento
                        .Observacion = Me.Observacion
                    End With

                    intValue = objbss.GrabarEstado(obj)

                    If intValue > 0 Then
                        Try
                            ws.test()
                        Catch ex As Exception
                            Legolas.Configuration.Aplication.MessageBox.MensajeError("Servicio web para intearctuar con el biométrico no se encuentra disponible, comuníquese con el administrador del sistema.")
                            Exit Sub
                        End Try

                        Dim codMarcacionId As Integer = -1
                        Dim v As Boolean = True
                        codMarcacionId = objBss.Listar(intValue).CodigoMarcacionID

                        Try
                            ws.DesHabUsuarioSupremaV2(out_Eror, codMarcacionId, 0)

                            If out_Eror.Length > 0 Then
                                v = False
                            Else
                                objBss.GrabarEstadoRegVinculacion(intValue, False)
                            End If

                        Catch ex As Exception
                            out_Eror = ex.Message
                            v = False
                        End Try

                        If v = False Then
                            Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo dar de baja en el biométrico. " & out_Eror)
                        End If

                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se realizó el registro, operación cancelada")
                    End If
                End If
            End If
        End Sub

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            ComboMotivo()
            pnlDocumento.Visible = False
            Me.pnlOK.Visible = Me._FormEscritura
            Listar
        End Sub
        Private Sub MostrarFechaFin()
            If Me.IDMotivoRetiro = Type.Enumeracion.Tratamiento.enmMotivoRetiro.SancionDisciplinaria Then
                lblFechaIni.Text = "Fecha Inicio:"
                lblFechaFin.Visible = True
                dtpFinFecha.Visible = True
            Else
                lblFechaIni.Text = "Fecha :"
                lblFechaFin.Visible = False
                dtpFinFecha.Visible = False
            End If
        End Sub
        Private Sub VisualizarControles()
            Select Case Me.IDMotivoRetiro
                Case 4, 5, 6 '2faltas, 4 faltas,endeudamiento
                    pnlDocumento.Visible = False
                Case Else
                    pnlDocumento.Visible = True
            End Select
        End Sub
        Private Sub HabilitarControles()
            cbbMotivoRetiro.Enabled = False
            dtpFecha.Enabled = False
            txtDocumento.ReadOnly = True
            dtpFinFecha.Enabled = False
            txtObservacion.ReadOnly = True
            btnOk.Visible = False
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()
            If Me._IDMotivoRetiro < 1 Then
                Exit Sub
            End If
            objBss = New Bussines.Tratamiento.TallerAsistencia.InternoTaller
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            Dim objCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            obj.Codigo = Me._IDInternoTaller
            objCol = objBss.ListarTaller_v2(obj)
            If objCol.Count > 0 Then
                With objCol.Item(0)
                    Me.IDMotivoRetiro = .MotivoRetiroID
                    Me.Fecha = .FechaRetiro
                    Me.Documento = .DocumentoRetiro
                    Me.FechaDoc = .FechaDocumento
                    Me.Observacion = .ObservacionRetiro
                End With
                HabilitarControles()
            End If
        End Sub
#End Region

        Private Sub frmSalidaPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub cbbMotivo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
            MostrarFechaFin()
        End Sub

        Private Sub cbbMotivoRetiro__SelectedIndexChanged() Handles cbbMotivoRetiro._SelectedIndexChanged
            VisualizarControles()
        End Sub

        Private Sub frmRetiroTaller_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Dim out_Error As String = ""
            Dim v As Boolean = False
            objBss = New Bussines.Tratamiento.TallerAsistencia.InternoTaller

            ws = New APPWebService.ws_pope_ep_trat_asist_tall.ApiBiostarClient
            ws.Endpoint.Address = New System.ServiceModel.EndpointAddress(APPWebService.PathURL.ws_trat_taller_asist)

            Try
                ws.test()
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Servicio web para intearctuar con el biométrico no se encuentra disponible, comuníquese con el administrador del sistema.")
                Exit Sub
            End Try

            Try 'loguearse

                v = objBss.WS_IniciarLoggin(ws, out_Error)

                If out_Error.Length > 0 Then v = False

            Catch ex As Exception
                out_Error = ex.ToString
                v = False
            End Try

            If v = False Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo iniciar sesión con el biométrico por lo tanto no se podrá interactuar con el equipo biométrico; " & out_Error)
                Me.Close()
            End If
        End Sub
    End Class

End Namespace
