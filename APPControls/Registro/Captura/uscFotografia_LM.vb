Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports Type.Enumeracion.ArchivoDigital
Imports Type.Enumeracion.Licencia

Namespace Registro.Captura
    Public Class uscFotografia_LM
        Private objBss As Bussines.Registro.InternoRasgo = Nothing
        Private objBssFoto As Bussines.Registro.InternoFoto = Nothing
        Private blnFotoHistorico As Boolean = True 'utilizado para identificar fotos registrados en la version y formato antigua
#Region "Eventos"
        Public Event _Clik_MantFotos(InternoFotId As Integer, RestringirEdicion As Boolean)
        Public Event _Clik_MantRasgos(RasgoId As Integer, forzarRegistroSoloLectura As Boolean) 'fdsds
        Public Event _Clik_MantSeniaPart(SenPartId As Integer, forzarRegistroSoloLectura As Boolean)
        Public Event _Clik_btnIngresofocus()
#End Region
#Region "Propiedades publicas"
        Public Property _InternoID() As Integer = -1
        Public Property _InternoCodigoRP() As String = ""
        Public Property InternoRasgoID() As Integer = -1
        Public Property InternoFotoID() As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property InternoIngresoNro As Integer = -1
        'Public Property _InternoIngresoId As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Imagen"
        Private Property ImagenPI_Id() As Integer = -1
        Private Property ImagenPF_Id() As Integer = -1
        Private Property ImagenPD_Id() As Integer = -1

        Private Property ImagenNamePI() As String = ""
        Private Property ImagenNamePF() As String = ""
        Private Property ImagenNamePD() As String = ""

        Private Property ImagenRutaLocalPI() As String = ""
        Private Property ImagenRutaLocalPF() As String = ""
        Private Property ImagenRutaLocalPD() As String = ""

        Private Property ImagenServerRutaPI() As String = ""
        Private Property ImagenServerPathPF() As String = ""
        Private Property ImagenServerPathPD() As String = ""

        Private Property ImagenChangePI() As Boolean = False
        Private Property ImagenChangePF() As Boolean = False
        Private Property ImagenChangePD() As Boolean = False

        Private Property ImagenPerfilx() As Integer = -1
        Private Property ImagenFecha() As Long = 0


        Private Property ImagenTipo() As Integer
            Get
                Return 3
            End Get
            Set(ByVal value As Integer)

            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"

        Private ReadOnly Property GrillaSeniaParticularPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaSeniaPart
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaSenaParticular() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaSeniaPart
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property


        Private ReadOnly Property GrillaRasgoPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaRasgo
                        intValue = .SelectedRows(0).Cells("col_rasgo_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaRasgo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaRasgo
                        intValue = .SelectedRows(0).Cells("col_cod").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaInternoFotoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwFotos
                        intValue = .SelectedRows(0).Cells("col_codigo").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_UserControl"
        Private blnVisibleGrabar As Boolean = False
        Private blnVisibleEliminar As Boolean = False

        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
                VisibleControles()
            End Set
        End Property
        Public Property _VisibleEliminar As Boolean
            Get
                Return blnVisibleEliminar
            End Get
            Set(value As Boolean)
                blnVisibleEliminar = value
                VisibleControles()
            End Set
        End Property
        Public Sub MostrarGrillaRasgo(Optional v As Boolean = True)
            grbRasgos.Visible = v
        End Sub
        Public Sub MostrarGrillaSeniaParticular(Optional v As Boolean = True)
            grbSenhasparticulares.Visible = v
        End Sub
#End Region

#Region "Listar"
        Private Sub ListarFotosInterno()

            If Me._InternoID < 1 Then Exit Sub

            objBssFoto = New Bussines.Registro.InternoFoto
            Dim ent As New Entity.Registro.InternoFoto
            Dim objEntCol As New Entity.Registro.InternoFotoCol
            ent.InternoID = Me._InternoID
            ent.IngresoInpeId = _IngresoInpeID

            'If Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
            '    ent.InternoIngresoId = Me._InternoIngresoId
            'End If

            objEntCol = objBssFoto.Listar_LM(ent)

            With Me.dgwFotos
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                '.RowHeadersVisible = True
                .DataSource = objEntCol
            End With
        End Sub

        Public Sub ListarDataRasgo()

            If Me._InternoID < 1 Then Exit Sub

            Dim objEnt As New Entity.Registro.InternoRasgo
            objBss = New Bussines.Registro.InternoRasgo

            Dim objEntCol As New Entity.Registro.InternoRasgoCol
            Dim objEnt2 As New Entity.Registro.InternoRasgo
            objEnt2.InternoId = Me._InternoID 'se debe ver de todos los ingresos
            objEnt2.IngresoInpeId = Me._IngresoInpeID

            With Me.dgwGrillaRasgo
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objBss.Listar_LM(objEnt2)
            End With
        End Sub

        Public Sub ListarSenasParti()
            If Me._InternoID < 1 Then Exit Sub

            Dim objEntSP As New Entity.Registro.InternoSenaParticular
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.InternoSenaParticular)

            objEntSP.InternoID = Me._InternoID
            objEntSP.IngresoInpeId = Me._IngresoInpeID
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta
                    'objEntSP.PenalId = Me.PenalID
                    'Case enmTipoLicencia.RegionLimaMetropolitana
                    '    objEntSP.PenalId = -1
                    '    objEntSP.InternoIngresoId = -1
                    'Case enmTipoLicencia.PenalLimaMetropolitana
                    '    objEntSP.InternoIngresoId = Me._InternoIngresoId
            End Select

            objEntCol = (New Bussines.Registro.InternoSenaParticular).Listar_Grilla_LM(objEntSP, Me.TipoLicencia)

            With Me.dgwGrillaSeniaPart
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With
        End Sub

        Private Sub ListarImagen(objEnt As Entity.Registro.InternoFoto)
            If Me.InternoFotoID < 1 Then
                LimpiarImagenes()
                LimpiarImagenVariables()
                Exit Sub
            End If

            If objEnt.Codigo > 0 Then
                With objEnt
                    Me.ImagenPI_Id = .PIzquierdoID
                    Me.ImagenNamePI = .PIzquierdoName
                    Me.ImagenServerRutaPI = .PIzquierdoServerPath

                    Me.ImagenPF_Id = .PFrenteID
                    Me.ImagenNamePF = .PFrenteName
                    Me.ImagenServerPathPF = .PFrenteServerPath

                    Me.ImagenPD_Id = .PDerechoID    'Me.ImagenPD_Id
                    Me.ImagenNamePD = .PDerechoName
                    Me.ImagenServerPathPD = .PDerechoServerPath

                    Me.ImagenFecha = .Fecha
                End With


                ListarImagen(1, Me.ImagenPI_Id, Me.ImagenNamePI, Me.ImagenServerRutaPI)
                ListarImagen(2, Me.ImagenPF_Id, Me.ImagenNamePF, Me.ImagenServerPathPF)
                ListarImagen(3, Me.ImagenPD_Id, Me.ImagenNamePD, Me.ImagenServerPathPD)
                'End If
            Else
                LimpiarImagenes()
                LimpiarImagenVariables()
            End If

        End Sub

        Private Sub ListarImagen(ByVal ImagenPerfil As Integer, ByVal ArchivoDigitalID As Integer,
                                 ByVal NameFile As String, PathServer As String)

            Dim intTipoLocal As Integer = 3 'sede central
            Dim objImagen As Image = My.Resources.sin_fotografia
            Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital
            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Timeout = -1
            objWS.Url = APPWebService.PathURL.WSPopeLocal

            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex As Exception
                objImagen = My.Resources.ws_config
                MostrarImagen(ImagenPerfil, objImagen)
                Exit Sub
            End Try

            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo
            Catch ex As Exception
                intTipoLocal = -1
            End Try

            If ArchivoDigitalID < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
            Else
                Dim objImagenByte As Byte()
                Dim objImagenStream As New MemoryStream

                Dim strFotoNameExtension As String = NameFile
                objWS.Test()
                r = objWS.ListarArchivoDigital(ArchivoDigitalID, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno)

                Dim blnNoImg As Boolean = False

                If r.Resultado Is Nothing Then
                    blnNoImg = True
                Else
                    If r.Resultado.ArchivoByte Is Nothing Then blnNoImg = True
                End If

                If blnNoImg = True Then
                    Select Case intTipoLocal
                        Case 3, 2
                            objImagen = My.Resources.fotografia_por_transferir
                        Case Else
                            objImagen = My.Resources.fotografia_eliminada
                    End Select
                    If intTipoLocal = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        ' MODIFICADO POR JONATAN 06/01/2025
                        ' EN CASO EL ARCHIVO NO SE ENCUENTRE LOCALMENTE, SE MOSTRARA UN MENSAJE, PERO IGUAL BUSCARA USANDO EL WS PARA OBTENER LA FOTO DESDE LIMA

                        objBssFoto = New Bussines.Registro.InternoFoto
                        Dim objEnt As New Entity.Registro.InternoFoto


                        objEnt = objBssFoto.ObtenerCodigoFOTO_SEDE(ArchivoDigitalID)
                        Dim ArchivoDigitalIDLocal = ArchivoDigitalID
                        ArchivoDigitalID = objEnt.SedeRowId


                        objWS.Url = APPWebService.PathURL.WSPopeSedeCentral

                        Try 'APPWebService.ws_foto.TipoCarpeta.Reniec
                            r = objWS.ListarArchivoDigital(ArchivoDigitalID, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno)
                            objImagenByte = r.Resultado.ArchivoByte
                            objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
                            objImagen = Image.FromStream(objImagenStream)
                            objWS.Url = APPWebService.PathURL.WSPopeLocal
                            objWS.UploadImageJpg(objImagenByte, ObtenerNombre(ArchivoDigitalIDLocal), r.Resultado.Tipo)
                        Catch ex As Exception
                            objImagenByte = Nothing
                            objImagen = My.Resources.nspm_fotografia
                        End Try
                    End If

                Else
                    objImagenByte = r.Resultado.ArchivoByte
                    objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)

                    Try
                        objImagen = Image.FromStream(objImagenStream)
                    Catch ex As Exception
                        objImagen = My.Resources.nspm_fotografia
                    End Try
                End If

            End If
            MostrarImagen(ImagenPerfil, objImagen)
        End Sub
        ' MODIFICADO POR JONATAN 08/01/2025 -- OBTIENE LA RUTA DONDE SE ALMACENA EL ARCHIVO DE FOTO
        Private Function ObtenerNombre(ByVal ArchivoID As Int32) As String
            Try

                Dim Bss As New Bussines.Globall.ArchivoDigital

                Dim archivoDigital2 As Entity.Globall.ArchivoDigital = Bss.Listar_ArchivoDigital_v2(ArchivoID)

                Dim flag As Boolean = False
                Dim path As String

                If String.IsNullOrWhiteSpace(archivoDigital2.RutaServidor) Then
                    flag = True
                    path = archivoDigital2.NombreFisico
                Else
                    flag = False
                    path = IO.Path.Combine(archivoDigital2.RutaServidor, archivoDigital2.NombreFisico & "." & archivoDigital2.Extension)

                    If Not IO.File.Exists(path) Then
                        path = IO.Path.Combine(archivoDigital2.RutaServidor, archivoDigital2.NombreFisico)
                    End If
                End If
                Return path
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return ""
            End Try

        End Function

        Private Sub MostrarImagen(ByVal ImagenPerfil As Integer, objImagen As Image)

            Select Case ImagenPerfil
                Case 1
                    Me.pbIzquierdo.Image = objImagen
                Case 2
                    Me.pbFrente.Image = objImagen
                Case 3
                    Me.pbDerecho.Image = objImagen
            End Select
        End Sub
#End Region
#Region "Accion"
        Private Function ValidarFecha() As Boolean

            Dim blnValue As Boolean = True

            objBssFoto = New Bussines.Registro.InternoFoto
            blnValue = objBssFoto.ValidarFecha(Me._InternoID, Me.ImagenFecha)

            If blnValue = False Then
                MessageBox.Show("La fecha seleccionada ya existe, selecciona otra fecha para cargar las fotos",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Return blnValue

        End Function

        Private Function RestringirEdicion() As Boolean
            Dim max As Long = 0
            For i As Integer = 0 To dgwFotos.Rows.Count - 1
                If dgwFotos.Item("col_fec", i).Value > max Then
                    max = dgwFotos.Item("col_fec", i).Value
                End If
            Next
            If max <> dgwFotos.Item("col_fec", dgwFotos.CurrentRow.Index).Value Then Return True

            Return False
        End Function

        Private Function ValidarCodigoInterno() As Boolean
            Return (New Bussines.Registro.Interno).Validar(Me._InternoCodigoRP, Me.RegionID, Me.PenalID)
        End Function

        Private Sub AEliminarSenasParticulares()
            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If
            If dgwGrillaSeniaPart.Rows.Count <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If
            If Me.GrillaSeniaParticularPenalId <> Me.PenalID Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación restringida, el registro es de solo lectura")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                Dim objBss As New Bussines.Registro.InternoSenaParticular
                objBss.Eliminar(Me.GrillaSenaParticular)
                ListarSenasParti()
            End If
        End Sub

        Private Sub AEliminarInternoFoto()

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario no tiene permiso para realizar esta operación")
                Exit Sub
            End If
            Dim out_msg As String = ""
            objBssFoto = New Bussines.Registro.InternoFoto

            Dim objBss As New Bussines.Registro.InternoReniec
            Dim objEnt As New Entity.Registro.InternoReniec
            objEnt.Codigo = ImagenPF_Id
            Dim intValue As Integer = objBss.ValidarFotoReniec(objEnt)

            If intValue = 0 Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Está seguro de eliminar el registro seleccionado?, una vez eliminada el registro no podrá recuperarla.") = MsgBoxResult.Yes Then
                    Dim intValue2 As Integer = objBssFoto.Eliminar(Me.GrillaInternoFotoId, Legolas.Configuration.Usuario.Codigo, out_msg)

                    If intValue2 = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(out_msg)
                        Exit Sub
                    End If
                    LoadUsc()
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fotografia esta referenciada en la validación con la RENIEC, no es posible completar la operación")
                Exit Sub
            End If
        End Sub

        Private Sub AEliminarRasgos()
            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If

            If dgwGrillaRasgo.Rows.Count <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                Dim objBss As New Bussines.Registro.InternoRasgo
                objBss.Eliminar(Me.GrillaRasgo, Legolas.Configuration.Usuario.Codigo)
                ListarDataRasgo()
            End If

        End Sub

        Private Sub Mant_Senia(ByVal Nuevo As Boolean)
            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Exit Sub
            End If

            If CuentaConIngresos() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            If Nuevo = True Then
                RaiseEvent _Clik_MantSeniaPart(-1, False)
            Else
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaSeniaParticularPenalId <> Me._PenalID Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If
                RaiseEvent _Clik_MantSeniaPart(GrillaSenaParticular, regForzarSoloLectura)
            End If
        End Sub

        Private Sub Mant_Rasgo(ByVal Nuevo As Boolean)

            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Exit Sub
            End If

            If CuentaConIngresos() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            If Nuevo = True Then
                If dgwGrillaRasgo.Rows.Count >= 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Esta permitido un registro por ingreso")
                    Exit Sub
                End If

                RaiseEvent _Clik_MantRasgos(-1, False)
            Else
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaRasgoPenalId <> Me._PenalID Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If
                RaiseEvent _Clik_MantRasgos(GrillaRasgo, regForzarSoloLectura)
            End If

        End Sub
#End Region

#Region "Otros"
        Private Function CuentaConIngresos() As Boolean
            Dim v As Boolean = False
            'CREAR UN FUNCION EN EL INGRESO INPE QUE DEVUELVA LA CANTIDAD DE INGRESOS INPE, EN EL BUSSINESS
            'If Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then

            '    Dim objBssIng As New Bussines.Registro.Ingreso
            '    Dim objEntCol2 As New Entity.EntityCol(Of Entity.Registro.Ingreso)

            '    Dim objEntFiltroIng As New Entity.Registro.Ingreso
            '    With objEntFiltroIng
            '        .InternoID = Me._InternoID
            '        .PenalID = Me.PenalID
            '        .RegionID = Me.RegionID
            '    End With                

            '    objEntCol2 = objBssIng.Listar_LM(objEntFiltroIng)
            '    If objEntCol2.Count > 0 Then
            '        v = True
            '    End If

            'Else
            Dim objBssIng As New Bussines.Registro.IngresoInpe
            Dim objEntCol2 As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            objEntCol2 = objBssIng.ListarNroIngreso(Me._InternoID)
            If objEntCol2.Count > 0 Then
                v = True
            End If
            'End If
            Return v
        End Function

        Private Function SelectFilaGridFoto(v As Integer) As Integer
            Dim i As Integer = 0
            Dim valor As Integer = 0
            For i = 0 To dgwFotos.Rows.Count - 1
                Dim abc As Integer = dgwFotos.Item("col_codigo", i).Value
                If Val(dgwFotos.Item("col_codigo", i).Value) = v Then
                    valor = i
                    Return i
                End If
                valor = i
            Next
            Return valor
        End Function

        Private Sub FormZoom(ByVal Perfil As Integer)
            Dim frm As New Registro.frmFotoZoomPopup
            With frm
                Select Case Perfil
                    Case 1
                        ._pImagen = Me.pbIzquierdo.Image
                    Case 2
                        ._pImagen = Me.pbFrente.Image
                    Case 3
                        ._pImagen = Me.pbDerecho.Image
                End Select
                '._pFileName = FileName
                If .ShowDialog = DialogResult.OK Then

                End If
            End With
        End Sub

        Private Sub VisibleControles()

            Dim blnVisibleCabecera As Boolean = True

            Me.pnlFotografiaAdd.Visible = Me._VisibleGrabar
            Me.pnlRagosAdd.Visible = Me._VisibleGrabar
            Me.pnlSenaPartiAdd.Visible = Me._VisibleGrabar

            Me.pnlFotografiaEli.Visible = Me._VisibleEliminar
            Me.pnlRasgosEli.Visible = Me._VisibleEliminar
            Me.pnlSenaPartiEli.Visible = Me._VisibleEliminar

            If Me._VisibleGrabar = False And Me._VisibleEliminar = False Then
                blnVisibleCabecera = False
            End If

            Me.pnlAccionFotografia.Visible = blnVisibleCabecera
            Me.pnlAccionRasgo.Visible = blnVisibleCabecera
            Me.pnlAccionSenaParti.Visible = blnVisibleCabecera

        End Sub

        Private Sub LimpiarImagenVariables()
            Me.ImagenPI_Id = -1
            Me.ImagenRutaLocalPI = ""
            Me.ImagenPF_Id = -1
            Me.ImagenRutaLocalPF = ""
            Me.ImagenPD_Id = -1
            Me.ImagenRutaLocalPD = ""
        End Sub

        Private Sub LimpiarImagenes()
            Me.pbIzquierdo.Image = My.Resources.sin_fotografia
            Me.pbFrente.Image = My.Resources.sin_fotografia
            Me.pbDerecho.Image = My.Resources.sin_fotografia
        End Sub

        Private Function ImagenName(ByVal Perfil As Integer) As String
            Return Me.RegionID & "_" & Me.PenalID '& "_P" & PerfilstrValue
        End Function

        Public Sub LoadUsc()
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                    col_ras_ing_nro_inpe.Visible = True
                    col_num_ingre.Visible = False
                    col_num_ing.Visible = False
                    col_ing_nro_inpe.Visible = True
                Case Else
                    col_ras_ing_nro_inpe.Visible = False
                    col_num_ingre.Visible = True
                    col_num_ing.Visible = True
                    col_ing_nro_inpe.Visible = False
            End Select

            ListarFotosInterno()
            ListarSenasParti()
            ListarDataRasgo()

            Dim intInternoFotoId As Integer
            Dim blnFotoAntiguo As Boolean = False
            objBssFoto = New Bussines.Registro.InternoFoto
            Dim objEnt As New Entity.Registro.InternoFoto
            objEnt.InternoID = Me._InternoID
            objEnt.IngresoInpeId = Me._IngresoInpeID

            intInternoFotoId = objBssFoto.ListarIDFotoReciente_LM(Me._InternoID)
            If intInternoFotoId < 1 Or dgwFotos.Rows.Count <= 0 Then 'no tiene ninguna foto
                LimpiarImagenes()
                LimpiarImagenVariables()
                Exit Sub
            Else
                objEnt = objBssFoto.ListarGrilla_LM(intInternoFotoId)
                If objEnt.FotoVersionNueva = True Then
                    blnFotoAntiguo = False
                Else
                    blnFotoAntiguo = True
                End If
                Me.InternoFotoID = objEnt.Codigo

                Dim f As Integer = 0

                f = SelectFilaGridFoto(objEnt.Codigo) 'seleccionamos la fila activa perteneciente a la ultima foto
                If dgwFotos.Rows.Count > 0 Then
                    dgwFotos.Rows(f).Selected = True  'reactivar
                End If
                Me.ImagenPF_Id = dgwFotos.Rows(f).Cells("int_fot_per_fre").Value
                Me.ImagenPI_Id = dgwFotos.Rows(f).Cells("int_fot_per_izq").Value
                Me.ImagenPD_Id = dgwFotos.Rows(f).Cells("int_fot_per_der").Value

                dgwFotos.CurrentCell = dgwFotos.Rows(f).Cells("col_fec_reg") 'reactivar
                ListarImagen(objEnt)
            End If

        End Sub

        Public Sub DataGrieView_Click()
            Me.dgwFotos_RowEnter(Nothing, Nothing)
        End Sub
#End Region

#Region "Evento_Controles"
        Private Sub btnAddSeñas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSeñas.Click
            Mant_Senia(True)
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaSeniaPart.CellDoubleClick
            If Me.dgwGrillaSeniaPart.RowCount > 0 Then Mant_Senia(False)
        End Sub

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrillaSeniaPart.KeyDown
            Select Case e.KeyCode
                Case Keys.Delete
                    AEliminarSenasParticulares()
            End Select
        End Sub

        Private Sub pbIzquierdo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbIzquierdo.DoubleClick
            FormZoom(1)
        End Sub

        Private Sub pbFrente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbFrente.DoubleClick
            FormZoom(2)
        End Sub

        Private Sub pbDerecho_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbDerecho.DoubleClick
            FormZoom(3)
        End Sub

        Private Sub btnAddRasgo_Click(sender As System.Object, e As System.EventArgs) Handles btnAddRasgo.Click
            Mant_Rasgo(True)
        End Sub

        Private Sub dgwGrillaRasgo_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaRasgo.CellDoubleClick
            If Me.dgwGrillaRasgo.RowCount > 0 Then Mant_Rasgo(False)
        End Sub

        Private Sub dgwGrillaRasgo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGrillaRasgo.KeyDown
            If e.KeyCode = Keys.Delete Then AEliminarRasgos()
        End Sub

        Private Sub btnAgregarFot_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarFot.Click
            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Exit Sub
            End If

            If CuentaConIngresos() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                RaiseEvent _Clik_btnIngresofocus()
                Exit Sub
            End If

            'comentado--> x1, 02.03.2022

            'If Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
            '    Dim ent As Entity.Registro.Ingreso

            '    ent = (New Bussines.Registro.Ingreso).ListarUltimoIngreso_LM(Me._InternoID)

            '    If ent Is Nothing Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede agregar fotografias, hay que regularizar el Nª de ingreso. ")
            '        Exit Sub
            '    End If

            '    If ent.Codigo <> Me._IngresoInpeID Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo puede agregar fotografias sobre el último registro de ingreso, seleccione el ingreso Nª " & ent.IngresoNro)
            '        Exit Sub
            '    End If
            'Else
            Dim ent As Entity.Registro.IngresoInpe
            ent = (New Bussines.Registro.IngresoInpe).ListarUltimoIngresoInpe(Me._InternoID, Me.PenalID)

            If ent Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede agregar fotografias, hay que regularizar el Nª de ingreso. ")
                Exit Sub
            End If

            If ent.Codigo <> Me._IngresoInpeID Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo puede agregar fotografias sobre el último registro de ingreso, seleccione el ingreso Nª " & ent.IngresoNro)
                Exit Sub
            End If
            'End If

            RaiseEvent _Clik_MantFotos(-1, False)
        End Sub

        Private Sub cmdEliminarFot_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarFoto.Click
            If dgwFotos.Rows.Count <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If
            AEliminarInternoFoto()
        End Sub

        Private Sub btnEliminarRasgo_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarRasgo.Click
            AEliminarRasgos()
        End Sub

        Private Sub btnSenaParti_Click(sender As System.Object, e As System.EventArgs) Handles btnEliSenaParti.Click
            AEliminarSenasParticulares()
        End Sub

        Private Sub dgwFotos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwFotos.KeyDown

            Select Case e.KeyData
                Case (Keys.Shift Or Keys.D) 'shift + D==> PERMITE BORRAR 

                    'solo para osin-dev
                    Select Case Legolas.Configuration.Usuario.OficinaID
                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion 'osin dev

                            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar <> DialogResult.Yes Then
                                Exit Sub
                            End If

                            Dim strMensajeOut As String = ""
                            Dim sqlCone As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                            Dim lngFechaServer As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong

                            Dim strQuery As String = "update int_internofoto set _flg_trf=1, _flg_eli=1, _usu_eli=" & Legolas.Configuration.Usuario.Codigo &
                            ", _fec_eli = " & lngFechaServer & " where int_fot_id=" & Me.GrillaInternoFotoId

                            Legolas.Components.SQL.ExecuteBatchNonQuery(sqlCone, strQuery, strMensajeOut)

                            If strMensajeOut.Trim.Length > 3 Then
                                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeOut)
                            Else
                                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                            End If
                            ListarFotosInterno()

                    End Select
                    Exit Sub
            End Select

            If e.KeyCode = Keys.Delete Then
                cmdEliminarFot_Click(Nothing, Nothing)
            End If

        End Sub

        Private Sub dgwFotos_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwFotos.RowEnter
            Try
                If dgwFotos.Rows.Count < 1 Then Exit Sub

                Dim blnFotoAntiguo As Boolean = False

                Dim objEnt As New Entity.Registro.InternoFoto

                objEnt = (New Bussines.Registro.InternoFoto).ListarGrilla_LM(Me.GrillaInternoFotoId)

                If objEnt.FotoVersionNueva = False Then blnFotoAntiguo = True

                Me.InternoFotoID = objEnt.Codigo
                ListarImagen(objEnt)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub dgwFotos_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwFotos.CellDoubleClick
            If dgwFotos.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione un registro para modificar")
                Exit Sub
            End If

            If e Is Nothing Then Exit Sub
            If e.RowIndex = -1 Then Exit Sub

            Dim v As Boolean = False
            v = RestringirEdicion()

            'Me.InternoIngresoId 
            RaiseEvent _Clik_MantFotos(Me.GrillaInternoFotoId, v)
        End Sub
#End Region

        Private Sub btnModificarfoto_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarFoto.Click
            If dgwFotos.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                Exit Sub
            End If
            If dgwFotos.Rows.Count < 1 Then Exit Sub
            Dim v As Boolean = False
            v = RestringirEdicion()

            RaiseEvent _Clik_MantFotos(Me.GrillaInternoFotoId, v)
        End Sub

        Private Sub btnModRasgo_Click(sender As System.Object, e As System.EventArgs) Handles btnModRasgo.Click
            If Me.dgwGrillaRasgo.RowCount > 0 Then
                Mant_Rasgo(False)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            End If
        End Sub

        Private Sub btnModSeñas_Click(sender As System.Object, e As System.EventArgs) Handles btnModSeñas.Click
            If Me.dgwGrillaSeniaPart.RowCount > 0 Then
                Mant_Senia(False)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                Exit Sub
            End If
        End Sub

        Private Sub lblError1_Click(sender As Object, e As EventArgs) Handles lblError1.Click

        End Sub
    End Class
End Namespace

