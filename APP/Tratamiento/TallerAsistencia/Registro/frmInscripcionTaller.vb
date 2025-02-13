Imports System.Windows.Forms
Namespace Tratamiento.TallerAsistencia
    Public Class frmInscripcionTaller
        Dim ws As APPWebService.ws_pope_ep_trat_asist_tall.ApiBiostarClient

        Private objBssAsi As Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
        Private bssIntTaller As New Bussines.Tratamiento.TallerAsistencia.InternoTaller
#Region "Propiedades"
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1

        Private Property IDInterno As Integer = -1
        Private Property IDTaller As Integer = -1
        Private Property FechaAsistenciaLong() As Long = 0
        Private Property FechaInscripcion() As Long
            Get
                Return Me.dtpFechaInscripcion.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaInscripcion.ValueLong = value
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

#Region "Propiedades_Interno"
        'Private Property Codigo() As Integer = -1
        Private Property TipoDocumentoID As Integer = -1
        Private Property CodigoRP() As String
            Get
                Return Me.txtCodigo.Text
            End Get
            Set(ByVal value As String)
                Me.txtCodigo.Text = value
            End Set
        End Property
        Private Property TipoDocumento() As String
            Get
                Return Me.txtTipoDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtTipoDoc.Text = value
            End Set
        End Property
        Private Property NumeroDNI() As String
            Get
                Return Me.txtNumeroDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumeroDoc.Text = value
            End Set
        End Property
        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtPrimerApellido.Text()
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtSegundoApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApellido.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtPrenombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrenombres.Text = value
            End Set
        End Property
        Private Property SexoID() As Integer = -1
        Private Property SexoNom() As String
            Get
                Return Me.txtSexo.Text
            End Get
            Set(ByVal value As String)
                Me.txtSexo.Text = value
            End Set
        End Property
        Private Property FechaNacimiento() As String
            Get
                Return Me.txtFechaNac.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaNac.Text = value
            End Set
        End Property
        Private Property Nacionalidad() As String
            Get
                Return Me.txtNacionalidad.Text
            End Get
            Set(ByVal value As String)
                Me.txtNacionalidad.Text = value
            End Set
        End Property
        Private Property FechaIngreso() As String
            Get
                Return Me.txtFechaIngreso.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaIngreso.Text = value
            End Set
        End Property

#End Region

#Region "Listar"
        Private Sub ListarDatosInterno(intInternoID As Integer)
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol

            objEnt.InternoID = intInternoID
            objEnt.RegionID = Me._RegionID
            objEnt.PenalID = Me._PenalID
            objEntCol = bssIntTaller.ListarInt_v2(objEnt)

            If objEntCol.Count > 0 Then
                With objEntCol.Item(0)
                    Me.IDInterno = .InternoID
                    Me.CodigoRP = .CodigoRP
                    Me.ApellidoPaterno = .ApellidoPaterno
                    Me.ApellidoMaterno = .ApellidoMaterno
                    Me.Nombres = .Nombres
                    Me.TipoDocumentoID = .TipoDocumentoID
                    Me.TipoDocumento = .TipoDocumentoNombre
                    Me.NumeroDNI = .NumeroDocumento
                    Me.FechaNacimiento = .FechaNacimientoString
                    Me.SexoNom = .SexoNombre
                    Me.Nacionalidad = .NacionalidadNombre
                    Me.FechaIngreso = .FechaIngresoString

                End With

                With UscFotografia_2v1
                    ._showFotoInternoPrincipal(Me.IDInterno, 2)
                End With

            End If
        End Sub
        'Private Sub ObtenerInternoAsistencia()
        '    objBssAsi = New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
        '    Dim ent As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
        '    Dim objCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
        '    ObtenerFecha()
        '    With ent
        '        .InternoID = Me.IDInterno
        '        .Fecha = Me.FechaAsistenciaLong
        '        .RegionID = Me._RegionID
        '        .PenalID = Me._PenalID
        '    End With
        '    objCol = objBssAsi.ListarIngreso(ent)
        'End Sub
#End Region
#Region "Grabar"
        Private Function ValidarTaller() As String

            Dim strResultado As String = ""
            Dim objCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoTaller

            obj.InternoID = Me.IDInterno
            obj.PenalID = Me._PenalID
            obj.RegionID = Me._RegionID
            obj.EstadoLaboralID = 1 'activo
            objCol = bssIntTaller.ListarTaller_v2(obj)

            If objCol.Count > 0 Then
                strResultado = objCol.Item(0).NombreTaller
            End If

            Return strResultado

        End Function
        Private Sub GrabarInternoTaller()
            Dim vincularConBio As Boolean = False
            If Me.IDTaller < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un Taller")
                Exit Sub
            End If

            If Me.txtGrupoAcceso.Text = "" Or Me.txtGrupoUsuario.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Falta especificar el registro maestro del grupo de acceso o grupo de usuario.")
                Exit Sub
            End If
            If Me.IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione interno")
                Me.btnCargarInterno.Focus()
                Exit Sub
            End If

            If Me.FechaInscripcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar fecha de inscripción")
                Me.dtpFechaInscripcion.Focus()
                Exit Sub
            End If

            Dim strMensaje As String = ValidarTaller()
            If strMensaje.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno se encuentra activo en el Taller " + strMensaje + Chr(13) +
                                                                    "para inscribirlo en un nuevo taller hay que darle de baja en el taller")
                Exit Sub
            End If

            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            With obj
                .InternoID = Me.IDInterno
                .CodigoTaller = Me.IDTaller
                .Fecha = Me.FechaInscripcion
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .Observacion = Me.Observacion
                .EstadoID = 1 'activo
                .GrupoAcceso = Me.txtGrupoAcceso.Text
                .GrupoUsuarioRaiz = Me.txtRaizGrupoUsuario.Text
                .GrupoUsuario = Me.txtGrupoUsuario.Text

                .ApellidoPaterno = Me.txtPrimerApellido.Text
                .ApellidoMaterno = Me.txtSegundoApellido.Text
                .Nombres = Me.txtPrenombres.Text
            End With

            If obj.Codigo = -1 Or obj.BioRegistroVinculado = False Then 'cuando es nuevo o no se pudo vincular 
                vincularConBio = True
            End If

            Dim val As Integer = bssIntTaller.Grabar_v2(obj)
            If val < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno ya esta registrado en este taller.")
                Exit Sub
            Else
                If vincularConBio = True Then
                    Dim v As Boolean = True
                    Dim Nombre As String = ""

                    obj.CodigoMarcacionID = bssIntTaller.Listar(val).CodigoMarcacionID
                    Nombre = obj.ApellidoPaterno & " " & obj.ApellidoMaterno & " " & obj.Nombres

                    Dim out_Eror As String = ""

                    Try
                        ws.CargaUsuarioSupremaV2(out_Eror, obj.CodigoMarcacionID, Nombre, obj.GrupoAcceso, obj.GrupoUsuario, obj.Email)
                        If out_Eror.ToUpper = "Duplicate User".ToUpper Then
                            If MsgBox("El usuario ya se encuentra vinculado en un actividad laboral distinta, desea vincular a la nueva actividad laboral " & Me.txtGrupoUsuario.Text.ToUpper & "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Dim valor As Boolean = False
                                valor = EliminarUsuarioDeBiometrico(obj.CodigoMarcacionID)
                                If valor = False Then
                                    out_Eror = "No se pudo eliminar el usuario del biométrico para vincular nuevamente, búsque al interno en la ventana principal de búsqueda e intente vincular."
                                    v = False
                                Else
                                    ws.CargaUsuarioSupremaV2(out_Eror, obj.CodigoMarcacionID, Nombre, obj.GrupoAcceso, obj.GrupoUsuario, obj.Email)
                                    If out_Eror.Length > 0 Then v = False
                                End If
                            Else
                                out_Eror = "Usuario duplicado en el biométrico."
                                v = False
                            End If
                        Else
                            If out_Eror.Length > 0 Then

                                ws.CargaUsuarioSupremaV2(out_Eror, obj.CodigoMarcacionID, Nombre, obj.GrupoAcceso, obj.GrupoUsuario, obj.Email) 'segundo intento

                                If out_Eror.Length > 0 Then v = False

                            End If
                        End If
                    Catch ex As Exception
                        out_Eror = ex.Message
                        v = False
                    End Try

                    If v = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Se ha asignado el interno al taller fatisfactoriamente pero no se pudo vincular con el biométrico, " & out_Eror)
                    Else
                        'confirmar vinculacion con biometrico
                        bssIntTaller.GrabarEstadoRegVinculacion(val, True)

                        Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                End If
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea agregar un nuevo interno en el taller seleccionado?") = Windows.Forms.DialogResult.Yes Then
                LimpiarInterno()
            Else
                LimpiarTallerInterno()
            End If

        End Sub

        Private Function EliminarUsuarioDeBiometrico(IdUsuario As String)
            Dim v As Boolean = True
            Dim out_Eror As String = ""
            ws.EliminarUsuario(out_Eror, IdUsuario)

            If out_Eror.Length > 0 Then
                v = False
            End If

            Return v
        End Function
#End Region
#Region "Form"
        Private Sub frm_AgregarInterno()
            Dim frm As New Registro.Busqueda.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisibleRegionPenal = False
                ._MostrarRadionButonEstado()
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarDatosInterno(._GrillaInternoID)
                End If
            End With
        End Sub
        Private Sub frm_BuscarTaller()

            Dim frm As New Tratamiento.TallerAsistencia.Buscar.frmBuscarTallerPopud

            With frm
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.IDTaller = frm.GrillaIDTaller
                    Me.txtNombreTaller.Text = frm.GrillaNombreTaller
                    Me.txtActividad.Text = frm.GrillaNombreActividad
                    Me.txtRespGestTaller.Text = frm._GrillaRespGestorProduccion
                    Me.txtRespSupervisor.Text = frm._GrillaRespControlLaboral
                    Me.txtGrupoUsuario.Text = frm._GrillaRespGrupoUsuario
                    Me.txtGrupoAcceso.Text = frm._GrillaRespGrupoAcceso
                    Me.txtRaizGrupoUsuario.Text = frm._GrillaRespGrupoAccesoRaiz

                    If GrupoUsuarioRegistradoEnBiometrico(txtGrupoUsuario.Text) = False Then

                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El grupo de usuario no se encuentra registrado en la base de datos del biométrico.")

                        Me.IDTaller = -1
                        Me.txtNombreTaller.Text = ""
                        Me.txtActividad.Text = ""
                        Me.txtRespGestTaller.Text = ""
                        Me.txtRespSupervisor.Text = ""
                        Me.txtGrupoUsuario.Text = ""
                        Me.txtGrupoAcceso.Text = ""
                        Me.txtRaizGrupoUsuario.Text = ""
                    End If

                End If
            End With
        End Sub

        Private Function GrupoUsuarioRegistradoEnBiometrico(GrupoUsuario As String)
            'select NM from t_usrgr where dep=2
            Dim out_Eror As String = ""
            Dim regEncontrado As Boolean = False
            Dim lst As APPWebService.ws_pope_ep_trat_asist_tall.ListaUsuarioGrupo

            lst = ws.ListarGrupoUsuario(out_Eror)
            For Each ent As APPWebService.ws_pope_ep_trat_asist_tall.UsuarioGrupo In lst.records
                If ent.name.ToUpper = GrupoUsuario.ToUpper Then
                    regEncontrado = True
                End If
            Next

            Return regEncontrado
        End Function
#End Region

#Region "Otros"
        Private Sub LimpiarInterno()
            Me.FechaInscripcion = 0
            ''''''
            txtCodigo.Text = ""
            txtTipoDoc.Text = ""
            txtNumeroDoc.Text = ""
            txtPrimerApellido.Text = ""
            txtSegundoApellido.Text = ""
            txtPrenombres.Text = ""
            txtFechaNac.Text = ""
            txtSexo.Text = ""
            txtNacionalidad.Text = ""
            txtFechaIngreso.Text = ""
            txtObservacion.Text = ""
            Me.UscFotografia_2v1._Show_Silueta()
        End Sub

        Private Sub LimpiarTallerInterno()
            Me.IDTaller = -1
            Me.txtNombreTaller.Text = ""
            txtActividad.Text = ""
            ''''''
            Me.FechaInscripcion = 0
            ''''''
            txtCodigo.Text = ""
            txtTipoDoc.Text = ""
            txtNumeroDoc.Text = ""
            txtPrimerApellido.Text = ""
            txtSegundoApellido.Text = ""
            txtPrenombres.Text = ""
            txtFechaNac.Text = ""
            txtSexo.Text = ""
            txtNacionalidad.Text = ""
            txtFechaIngreso.Text = ""
            txtObservacion.Text = ""
            txtGrupoUsuario.Text = ""
            txtGrupoAcceso.Text = ""
            Me.UscFotografia_2v1._Show_Silueta()
        End Sub
#End Region
        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnCargarInterno_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarInterno.Click
            frm_AgregarInterno()
        End Sub

        Private Sub ObtenerFecha()
            Me.FechaAsistenciaLong = Legolas.Configuration.Aplication.FechayHora.FechaLong
        End Sub

        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
            GrabarInternoTaller()
        End Sub

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
            frm_BuscarTaller()
        End Sub

        Private Sub frmInscripcionTaller_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Dim out_Error As String = ""
            Dim v As Boolean = False
            bssIntTaller = New Bussines.Tratamiento.TallerAsistencia.InternoTaller

            ws = New APPWebService.ws_pope_ep_trat_asist_tall.ApiBiostarClient
            ws.Endpoint.Address = New System.ServiceModel.EndpointAddress(APPWebService.PathURL.ws_trat_taller_asist)

            Try
                ws.test()
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Servicio web para vinculación con el biométrico no se encuentra disponible, comuníquese con el administrador del sistema.")
                Me.Close()
                Exit Sub
            End Try

            Try 'loguearse

                v = bssIntTaller.WS_IniciarLoggin(ws, out_Error)

                If out_Error.Length > 0 Then v = False

            Catch ex As Exception
                out_Error = ex.ToString
                v = False
            End Try

            If v = False Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo iniciar sessión con el biométrico por lo tanto no se podrá vincular el registro con el equipo biométrico; " & out_Error)
                Me.Close()
            End If
        End Sub
    End Class
End Namespace