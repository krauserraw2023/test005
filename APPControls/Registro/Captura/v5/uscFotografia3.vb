Imports System.IO
Imports Type.Enumeracion.ArchivoDigital

Namespace Registro.Captura
    Public Class uscFotografia3
        Private objBss As Bussines.Registro.InternoRasgo = Nothing
        Private objBssFoto As Bussines.Registro.InternoFoto = Nothing
        Private blnFotoHistorico As Boolean = True 'utilizado para identificar fotos registrados en la version y formato antigua
#Region "Eventos"
        Public Event _Clik_MantFotos(InternoFotId As Integer, RestringirEdicion As Boolean)
        Public Event _Clik_MantRasgos(RasgoId As Integer)
        Public Event _Clik_MantSeniaPart(SenPartId As Integer)
        Public Event _Clik_btnIngresofocus()
#End Region
#Region "Propiedades publicas"
        Public Property _InternoID() As Integer = -1
        Public Property _InternoCodigoRP() As String = ""
        Public Property InternoRasgoID() As Integer = -1
        Public Property InternoFotoID() As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property InternoIngresoId As Integer = -1
        Public Property InternoIngresoNro As Integer = -1
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

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            objBssFoto = New Bussines.Registro.InternoFoto
            Dim ent As New Entity.Registro.InternoFoto
            Dim objEntCol As New Entity.Registro.InternoFotoCol
            ent.InternoID = Me._InternoID
            ent.InternoIngresoId = InternoIngresoId
            objEntCol = objBssFoto.Listar_v2(ent)

            With Me.dgwFotos
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                '.RowHeadersVisible = True
                .DataSource = objEntCol
            End With
            'For i As Integer = 0 To dgwFotos.Rows.Count - 1
            '    dgwFotos.Rows(i).HeaderCell.Value = (i + 1).ToString
            'Next
        End Sub

        Public Sub ListarDataRasgo()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            Dim objEnt As New Entity.Registro.InternoRasgo
            objBss = New Bussines.Registro.InternoRasgo

            Dim objEntCol As New Entity.Registro.InternoRasgoCol
            Dim objEnt2 As New Entity.Registro.InternoRasgo
            objEnt2.InternoId = Me._InternoID
            objEnt2.InternoIngresoId = IIf(Me.InternoIngresoId < 1, -1, Me.InternoIngresoId)
            objEntCol = objBss.Listar(objEnt2)
            With Me.dgwGrillaRasgo
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With
        End Sub

        Public Sub ListarSenasParti()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            Dim objEntCol As New Entity.Registro.InternoSenaParticularCol
            Dim objBss As New Bussines.Registro.InternoSenaParticular

            Dim objEntSP As New Entity.Registro.InternoSenaParticular
            objEntSP.InternoID = Me._InternoID
            objEntSP.InternoIngresoId = Me.InternoIngresoId
            objEntCol = objBss.Listar(objEntSP)

            With Me.dgwGrillaSeniaPart
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                grbSenhasparticulares.Text = "Señas Particulares.          " & objEntCol.Count & " Reg."
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

                    Me.ImagenPD_Id = .PDerechoID
                    Me.ImagenNamePD = .PDerechoName
                    Me.ImagenServerPathPD = .PDerechoServerPath

                    Me.ImagenFecha = .Fecha
                End With

                ListarImagen(1, Me.ImagenPI_Id)
                ListarImagen(2, Me.ImagenPF_Id)
                ListarImagen(3, Me.ImagenPD_Id)

            Else
                LimpiarImagenes()
                LimpiarImagenVariables()
            End If

        End Sub

        Private Sub ListarImagen(ByVal ImagenPerfil As Integer, ByVal intIDArchivoDigital As Integer)

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

            If intIDArchivoDigital < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
            Else
                Dim objImagenByte As Byte()
                Dim objImagenStream As New MemoryStream
                Dim blnNohayImg As Boolean = False
                Dim strMensajeOut As String = ""

                Select Case intTipoLocal
                    Case 2 'solo para regiones

                        Dim ObjBss As New Bussines.Globall.ArchivoDigital
                        objImagenByte = ObjBss.getArchivoDigitalByte_Region(intIDArchivoDigital,
                                                                            Type.Enumeracion.ArchivoDigital.TipoImagen.Interno,
                                                                                        strMensajeOut)

                        If objImagenByte Is Nothing OrElse objImagenByte.Length < 1 Then
                            blnNohayImg = True
                        End If
                    Case Else

                        r = objWS.ListarArchivoDigital(intIDArchivoDigital, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno)

                        If r.Resultado Is Nothing Then
                            blnNohayImg = True
                        Else
                            If r.Resultado.ArchivoByte Is Nothing Then blnNohayImg = True
                        End If

                        'si hay foto
                        If blnNohayImg = False Then
                            objImagenByte = r.Resultado.ArchivoByte
                        End If

                End Select

                If blnNohayImg = True Then
                    Select Case intTipoLocal
                        Case 3, 2 'sede y region 
                            objImagen = My.Resources.fotografia_por_transferir
                        Case Else
                            objImagen = My.Resources.fotografia_eliminada
                    End Select
                Else

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
            Dim bssIng As New Bussines.Registro.Ingreso

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

            Dim objBss As New Bussines.Registro.Interno
            Return objBss.Validar(Me._InternoCodigoRP, Me.RegionID, Me.PenalID)

        End Function

        Private Sub AEliminarSenasParticulares()

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If
            If dgwGrillaSeniaPart.Rows.Count <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
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
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El usuario no tiene permiso para realizar esta operación")
                Exit Sub
            End If
            Dim out_msg As String = ""
            objBssFoto = New Bussines.Registro.InternoFoto

            Dim objBss As New Bussines.Registro.InternoReniec
            Dim objEnt As New Entity.Registro.InternoReniec
            objEnt.FotoInterno = ImagenPF_Id
            Dim intValue As Integer = objBss.ValidarFotoReniec(objEnt)


            If intValue < 1 Then
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
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El usuario no tiene permiso para realizar esta operacion")
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
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de realizar una operacion, grabe los datos basicos del interno.")
                Exit Sub
            End If

            If CuentaConIngresos() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            If Nuevo = True Then
                RaiseEvent _Clik_MantSeniaPart(-1)
            Else
                RaiseEvent _Clik_MantSeniaPart(GrillaSenaParticular)
            End If

        End Sub

        Private Sub Mant_Rasgo(ByVal Nuevo As Boolean)

            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de realizar una operacion, grabe los datos basicos del interno.")
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

                RaiseEvent _Clik_MantRasgos(-1)
            Else
                RaiseEvent _Clik_MantRasgos(GrillaRasgo)
            End If

        End Sub
#End Region

#Region "Otros"
        Private Function CuentaConIngresos() As Boolean

            Dim v As Boolean = False
            Dim objBssIng As New Bussines.Registro.Ingreso

            Dim objEntCol2 As New Entity.Registro.IngresoCol

            Dim objEntFiltro As New Entity.Registro.Ingreso
            With objEntFiltro
                .InternoID = Me._InternoID
                .PenalID = Me.PenalID
            End With

            objEntCol2 = objBssIng.Listar(objEntFiltro)
            If objEntCol2.Count > 0 Then
                v = True
            End If
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

            'Me.pnlFotografiaEli.Visible = Me._VisibleEliminar
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
            'Me.ImagenFecha = 0

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

            ListarFotosInterno()
            ListarSenasParti()
            ListarDataRasgo()

            Dim intInternoFotoId As Integer
            Dim blnFotoAntiguo As Boolean = False
            objBssFoto = New Bussines.Registro.InternoFoto
            Dim objEnt As New Entity.Registro.InternoFoto
            objEnt.InternoID = Me._InternoID
            objEnt.InternoIngresoId = Me.InternoIngresoId

            intInternoFotoId = objBssFoto.ListarIDFotoReciente2(Me._InternoID)
            If intInternoFotoId < 1 Or dgwFotos.Rows.Count <= 0 Then 'no tiene ninguna foto
                LimpiarImagenes()
                LimpiarImagenVariables()
                Exit Sub
            Else
                objEnt = objBssFoto.ListarGrilla(intInternoFotoId)
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
                'dgwFotos.Rows(f). .CurrentCell = dgwFotos.Rows(f).HeaderCell
                'dgwFotos.CurrentCell = dgwFotos.Rows(f).Cells("int_fot_per_fre")
                Me.ImagenPF_Id = dgwFotos.Rows(f).Cells("int_fot_per_fre").Value
                Me.ImagenPI_Id = dgwFotos.Rows(f).Cells("int_fot_per_izq").Value
                Me.ImagenPD_Id = dgwFotos.Rows(f).Cells("int_fot_per_der").Value

                dgwFotos.CurrentCell = dgwFotos.Rows(f).Cells("col_fec_reg") 'reactivar
                'objEnt.Codigo = dgwFotos.Rows(0).Cells("col_codigo").Value
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
            If Me.dgwGrillaSeniaPart.RowCount > 0 Then
                Mant_Senia(False)
            End If
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
            If Me.dgwGrillaRasgo.RowCount > 0 Then
                Mant_Rasgo(False)
            End If
        End Sub

        Private Sub dgwGrillaRasgo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGrillaRasgo.KeyDown

            Select Case e.KeyCode
                Case Keys.Delete
                    AEliminarRasgos()
            End Select

            'Select Case e.KeyData
            '    Case (Keys.Shift Or Keys.Delete)
            '        AEliminarRasgos()
            'End Select
        End Sub

        Private Sub btnAgregarFot_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarFot.Click

            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de realizar una operacion, grabe los datos basicos del interno.")
                Exit Sub
            End If

            If CuentaConIngresos() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                RaiseEvent _Clik_btnIngresofocus()
                Exit Sub
            End If

            Dim bssIng As New Bussines.Registro.Ingreso
            Dim ent As Entity.Registro.Ingreso

            ent = bssIng.ListarUltimoIngreso(Me._InternoID)

            If ent Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede agregar fotografias, hay que regularizar el Nª de ingreso. ")
                Exit Sub
            End If

            If ent.Codigo <> Me.InternoIngresoId Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo puede agregar fotografias sobre el último registro de ingreso, seleccione el ingreso Nª " & ent.IngresoNro)
                Exit Sub
            End If
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

        Private Sub dgwFotos_CellErrorTextNeeded(sender As Object, e As System.Windows.Forms.DataGridViewCellErrorTextNeededEventArgs) Handles dgwFotos.CellErrorTextNeeded

        End Sub

        Private Sub dgwFotos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwFotos.KeyDown

            Select Case e.KeyCode
                Case Keys.Delete
                    cmdEliminarFot_Click(Nothing, Nothing)
            End Select

        End Sub

        Private Sub dgwFotos_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwFotos.RowEnter
            Try
                If dgwFotos.Rows.Count < 1 Then Exit Sub

                Dim blnFotoAntiguo As Boolean = False

                objBssFoto = New Bussines.Registro.InternoFoto
                Dim objEnt As New Entity.Registro.InternoFoto

                objEnt = objBssFoto.ListarGrilla(Me.GrillaInternoFotoId)
                If objEnt.FotoVersionNueva = False Then
                    blnFotoAntiguo = True
                End If
                Me.InternoFotoID = objEnt.Codigo
                ListarImagen(objEnt)
            Catch ex As Exception
                Dim s As String
                s = s
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

        Private Sub dgwFotos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwFotos.CellContentClick

        End Sub

        Private Sub btnModificarfoto_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarFoto.Click
            If dgwFotos.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                Exit Sub
            End If
            If dgwFotos.Rows.Count < 1 Then Exit Sub
            Dim v As Boolean = False
            v = RestringirEdicion()
            'Me.InternoIngresoId 
            RaiseEvent _Clik_MantFotos(Me.GrillaInternoFotoId, v)
        End Sub

        Private Sub btnModRasgo_Click(sender As System.Object, e As System.EventArgs) Handles btnModRasgo.Click
            If Me.dgwGrillaRasgo.RowCount > 0 Then
                Mant_Rasgo(False)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            End If
        End Sub

        Private Sub dgwGrillaSeniaPart_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaSeniaPart.CellContentClick

        End Sub

        Private Sub btnModSeñas_Click(sender As System.Object, e As System.EventArgs) Handles btnModSeñas.Click
            If Me.dgwGrillaSeniaPart.RowCount > 0 Then
                Mant_Senia(False)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                Exit Sub
            End If
        End Sub

        Private Sub uscFotografia3_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        End Sub
    End Class
End Namespace

