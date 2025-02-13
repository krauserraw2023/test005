
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports APPWebService.ws_pope_sede_sanciones
Imports Microsoft.ReportingServices.Diagnostics.Utilities

Namespace Registro.Reniec
    Public Class uscValidacionDatosInternoV2
        Private objBssInterno As Bussines.Registro.Interno = Nothing
        Private objBssInternoRnc As Bussines.Registro.InternoReniec = Nothing
        Private objBssIntRncNomAso As Bussines.Registro.InternoReniecNomAsoc = Nothing
        Private objEntCol As Entity.Registro.NombreAsociadoCol = Nothing
        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Private objEnt As Entity.Registro.InternoReniec = Nothing
        Dim objIntNomAsocCol As New Entity.Registro.InternoReniecNomAsocCol

#Region "Eventos"
        Public Event _Click_DatosImagen(NumImagen As Integer, NomImagen As String)
        Public Event _Click_ListaCadenaInterno()
        Public Event _Click_Nuevo(Condicion As Integer, CodHistorico As Integer)
        Public Event _DobleClickGrilla(objEntCol As Entity.Registro.NombreAsociadoCol)
#End Region
#Region "Propiedades_Interno"
        Private blnValor As Boolean = False
        Private Property intInternoID As Integer = -1
        Public Property _InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
                ListarInternoCondicion()
            End Set
        End Property
        Public Property _Version() As Boolean = False
        Private Property CodigoInternoRP As String = ""
        Private Property TipoDocumentoID As String = ""
        Private Property NumeroDni() As String
            Get
                Return Me.txtNumeroDni.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumeroDni.Text = value
            End Set
        End Property
        Private Property DigitoVerificacion() As String = ""
        Private Property ApePaterno() As String
            Get
                Return Me.txtApePaterno.Text
            End Get
            Set(ByVal value As String)
                Me.txtApePaterno.Text = value
            End Set
        End Property
        Private Property ApeMaterno() As String
            Get
                Return Me.txtApeMaterno.Text
            End Get
            Set(ByVal value As String)
                Me.txtApeMaterno.Text = value
            End Set
        End Property
        Private Property ApellidoCasada() As String = ""
        Private Property Nombres() As String
            Get
                Return Me.txtNombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtNombres.Text = value
            End Set
        End Property
        Private intSexoID As Integer = -1
        Private Property SexoID() As Integer
            Get
                Return intSexoID
            End Get
            Set(ByVal value As Integer)
                intSexoID = value
                If SexoID = 1 Then
                    SexoNom = "MASCULINO"
                ElseIf SexoID = 2 Then
                    SexoNom = "FEMENINO"
                Else
                    SexoNom = ""
                End If
            End Set
        End Property
        Private Property SexoNom() As String
            Get
                Return Me.txtSexo.Text
            End Get
            Set(ByVal value As String)
                Me.txtSexo.Text = value
                If Len(txtSexo.Text) > 0 Then
                    Me.txtSexo.Text = Mid(txtSexo.Text, 1, 3)
                End If
            End Set
        End Property
        Private Property FechaNacimiento() As String
            Get
                Return Me.txtfechanac.Text
            End Get
            Set(ByVal value As String)
                Me.txtfechanac.Text = value
            End Set
        End Property
        Private Property EstadoCivilID As Integer = -1
        Private Property EstadoCivilNom As String
            Get
                Return Me.txtEstadoCivil.Text
            End Get
            Set(ByVal value As String)
                Me.txtEstadoCivil.Text = value
            End Set
        End Property
        Private Property NacimientoUbigeo() As String
            Get
                Return Me.txtNacimientoUbigeo.Text
            End Get
            Set(ByVal value As String)
                Me.txtNacimientoUbigeo.Text = value
            End Set
        End Property
        Private Property Padre() As String
            Get
                Return Me.txtPadre.Text
            End Get
            Set(ByVal value As String)
                Me.txtPadre.Text = value
                Me.txtPadre.CharacterCasing = CharacterCasing.Upper
            End Set
        End Property
        Private Property Madre() As String
            Get
                Return Me.txtMadre.Text
            End Get
            Set(ByVal value As String)
                Me.txtMadre.Text = value
                Me.txtMadre.CharacterCasing = CharacterCasing.Upper
            End Set
        End Property
        Private Property Conyuge() As String
            Get
                Return Me.txtConyuge.Text
            End Get
            Set(ByVal value As String)
                Me.txtConyuge.Text = value
                Me.txtConyuge.CharacterCasing = CharacterCasing.Upper
            End Set
        End Property
        Private Property Ubigeo() As String
            Get
                Return Me.txtUbigeoDomicilio.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoDomicilio.Text = value
            End Set
        End Property
        Private Property Direccion() As String
            Get
                Return Me.txtDireccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtDireccion.Text = value
            End Set
        End Property
        Private Property Talla() As String
            Get
                Return Me.txtEstatura.Text
            End Get
            Set(ByVal value As String)
                Me.txtEstatura.Text = value
            End Set
        End Property
        Private Property GradoInstruccionID As Integer = -1
        Private Property GradoInstruccionNom() As String
            Get
                Return Me.txtGradoInstruccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtGradoInstruccion.Text = value
                Me.txtGradoInstruccion.CharacterCasing = CharacterCasing.Upper
            End Set
        End Property
        Private Property Restriccion As String = ""
#End Region
#Region "Propiedades_Busqueda"
        Private Property Codigo() As Integer = -1
        Private Property Estado() As Integer = -1
        Private Property RegionID() As Integer = -1
        Private Property PenalID() As Integer = -1
        Public Property _ListaInternoCabecera As String = ""
        Public Property _ListaInternoData As String = ""
        Private Property ListaRncCabecera As String = ""
        Private Property ListaRncData As String = ""
        Private Property TipoComparacion() As Integer = -1
        Private Property NumFilasDgw() As Integer = -1
        Public Property _NombresAsociados() As String = ""
        Public Property _NombresAsociadosID() As String = ""
        Public Property _NombresAsociadosLista() As String = ""
        Public Property _CondicionBusqueda As Integer = 0
        Public Property _VarHistorico As Integer = 0
        Public Property _Contador As Integer = -1
        Public Property _TipoLicencia() As Integer = -1
#End Region
#Region "Propiedades_Fotografia"
        Private Property PerfilActual As Integer
        Private Property CopiaintImagen As Integer = -1
        Private Property CopiaNombreImagen As String = ""
        Private Property PerfilFotografia() As Integer
            Get
                Dim value As Integer = -1
                value = 2
                Return value
            End Get
            Set(ByVal value As Integer)
            End Set
        End Property
#End Region
#Region "Propiedades_Parametricas"
        Private Property TipoImagen() As Type.Enumeracion.ArchivoDigital.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
        Private Property SizeMode() As System.Windows.Forms.PictureBoxSizeMode
            Get
                Return Me.picFoto.SizeMode
            End Get
            Set(ByVal value As System.Windows.Forms.PictureBoxSizeMode)
                Me.picFoto.SizeMode = value
            End Set
        End Property
#End Region
#Region "Propiedades_UserControl"
        Private blnEnabledDobleClick As Boolean = True
        Private Property _EnabledDobleClick() As Boolean
            Get
                Return blnEnabledDobleClick
            End Get
            Set(ByVal value As Boolean)
                blnEnabledDobleClick = value
            End Set
        End Property
        Private Property HasImagen() As Boolean
#End Region
#Region "Listar"
        Private Sub ListarInternoCondicion()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            If Me._Contador < 1 Then
                'Var_Historico = -1
                lblHistorial.Visible = False
                ListarActual()
            Else 'contador >0
                If _VarHistorico = -1 Then
                    lblHistorial.Visible = False
                    ListarActual()
                Else
                    lblHistorial.Visible = True
                    ListarReniec()
                End If
            End If
        End Sub
        Private Sub ListarActual()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            objBssInterno = New Bussines.Registro.Interno
            If Me._VarHistorico = -1 Then
                objBssInterno = New Bussines.Registro.Interno
                Dim objEnt As New Entity.Registro.Interno
                objEnt.Codigo = Me._InternoID
                objEnt = objBssInterno.ListarInternoReniec(objEnt)
                With objEnt ' /*datos generales*/
                    'Me.InternoID = .Codigo
                    Me.CodigoInternoRP = .CodigoRP
                    Me.TipoDocumentoID = .TipoDocumentoID
                    If Me.TipoDocumentoID = 10 Then
                        Me.NumeroDni = .NumeroDocumento
                    Else
                        Me.NumeroDni = "No indica"
                    End If
                    Me.ApePaterno = .ApellidoPaterno
                    Me.ApeMaterno = .ApellidoMaterno
                    Me.Nombres = .Nombres
                    Me.SexoID = .SexoID
                    'Me.SexoNom = .SexoNombre
                    Me.FechaNacimiento = Legolas.Components.FechaHora.FechaDate(.FechaNacimiento)
                    If .Nac_Departamento = "" And .Nac_Provincia = "" And .Nac_Distrito = "" Then
                        Me.NacimientoUbigeo = ""
                    Else
                        Me.NacimientoUbigeo = IIf(.Nac_Departamento = "", "-", .Nac_Departamento) & "/" &
                        IIf(.Nac_Provincia = "", "-", .Nac_Provincia) & "/" & IIf(.Nac_Distrito = "", "-", .Nac_Distrito)
                    End If
                    Me.EstadoCivilID = .EstadoCivilID
                    Me.EstadoCivilNom = .EstadoCivilNombre
                    Me.Padre = .Padre
                    Me.Madre = .Madre
                    Me.Conyuge = .Conyugue
                    Dim medida As String = ""
                    Dim CopyTalla As String = .Estatura
                    If CopyTalla <> "" Then
                        If CopyTalla = 0 Then
                            medida = ""
                        ElseIf CopyTalla < 2 Then
                            medida = "m"
                        ElseIf CopyTalla > 100 Then
                            medida = "cm"
                        Else
                            medida = ""
                        End If
                        lblMedida.Text = medida
                    End If
                    Me.Talla = CopyTalla
                    Me.GradoInstruccionID = .NivelAcademicoID
                    Me.GradoInstruccionNom = .NivelAcademicoNombre
                    If .Departamento = "" And .Provincia = "" And .Distrito = "" Then
                        Me.Ubigeo = ""
                    Else
                        Me.Ubigeo = IIf(.Departamento = "", "-", .Departamento) & "/" &
                        IIf(.Provincia = "", "-", .Provincia) & "/" & IIf(.Distrito = "", "-", .Distrito)
                    End If
                    Me.Direccion = (.Domicilio).Replace("|", " ")
                    Dim varListaCabecera As String = Me.txtNumeroDni.Name & "|" & Me.txtApePaterno.Name & "|" & Me.txtApeMaterno.Name & "|" & Me.txtNombres.Name & "|" & Me.txtSexo.Name & "|" & Me.txtfechanac.Name & "|" &
                                                     Me.txtNacimientoUbigeo.Name & "|" & Me.txtEstadoCivil.Name & "|" & Me.txtUbigeoDomicilio.Name & "|" & Me.txtDireccion.Name & "|" &
                                                     Me.txtPadre.Name & "|" & Me.txtMadre.Name & "|" & Me.txtConyuge.Name & "|" & Me.txtGradoInstruccion.Name & "|" & Me.txtEstatura.Name
                    Dim varListaData As String = Me.NumeroDni & "|" & Me.txtApePaterno.Text & "|" & Me.txtApeMaterno.Text & "|" & Me.txtNombres.Text & "|" & Me.txtSexo.Text & "|" & Me.txtfechanac.Text & "|" &
                                                     Me.txtNacimientoUbigeo.Text & "|" & Me.txtEstadoCivil.Text & "|" & Me.Ubigeo & "|" &
                                                     Replace(Me.Direccion, ",", "-") & "|" &
                                                     Me.txtPadre.Text & "|" & Me.txtMadre.Text & "|" & Me.txtConyuge.Text & "|" & Me.txtGradoInstruccion.Text & "|" & Replace(Me.txtEstatura.Text, ",", ".")
                    Me._ListaInternoCabecera = varListaCabecera
                    Me._ListaInternoData = varListaData
                    Me.RegionID = .RegionID
                    Me.PenalID = .PenalID
                End With
                ListarNombresAsociadosActual()
                ShowFotografia()
                RaiseEvent _Click_ListaCadenaInterno()
            End If
        End Sub
        Private Sub ListarReniec()
            objEnt = New Entity.Registro.InternoReniec
            objBssInternoRnc = New Bussines.Registro.InternoReniec
            Dim EntInterno As New Entity.Registro.InternoReniec
            If Me._Contador > 0 Then
                EntInterno.InternoID = Me._InternoID
                EntInterno.Codigo = Me._VarHistorico
                If _VarHistorico = 0 Then
                    objEnt = objBssInternoRnc.ListarUltimaValidacion(EntInterno)
                Else ' me.CodigoHistorial >0
                    objEnt = objBssInternoRnc.Listar2(EntInterno)
                End If
                With objEnt ' /*datos generales*/
                    Me.Codigo = .Codigo
                    'Me.InternoID = .InternoID
                    'Me.CodigoHistorial = .CodigoHistorial
                    Me.RegionID = .RegionID
                    Me.PenalID = .PenalID
                    Me._ListaInternoData = .InternoSisData
                    Me.ListaRncData = .ReniecData
                    Me._NombresAsociadosLista = .NombresAsociadosNom
                    Dim strLista As String = Me._ListaInternoData
                    Dim Registro() As String = strLista.Split("|")
                    If Registro.Length = 1 Then
                        Registro = strLista.Split(",")
                        Exit Sub
                    End If
                    Me.NumeroDni = Registro(0)
                    Me.ApePaterno = Registro(1)
                    Me.ApeMaterno = Registro(2)
                    Me.Nombres = Registro(3)
                    Me.SexoNom = Registro(4)
                    Me.FechaNacimiento = Registro(5)
                    Me.NacimientoUbigeo = Registro(6)
                    Me.EstadoCivilNom = Registro(7)
                    Me.Ubigeo = Registro(8)
                    Me.Direccion = Registro(9)
                    If Registro.Length > 15 Then
                        For i As Integer = 9 To Registro.Length - 6
                            If i = 9 Then
                                Me.Direccion = Registro(i)
                            Else
                                Me.Direccion = Me.Direccion & "|" & Registro(i)
                            End If
                        Next
                        Registro(10) = Registro(Registro.Length - 5)
                        Registro(11) = Registro(Registro.Length - 4)
                        Registro(12) = Registro(Registro.Length - 3)
                        Registro(13) = Registro(Registro.Length - 2)
                        Registro(14) = Registro(Registro.Length - 1)
                    End If
                    Me.Padre = Registro(10)
                    Me.Madre = Registro(11)
                    Me.Conyuge = Registro(12)
                    Me.GradoInstruccionNom = Registro(13)
                    Me.Talla = Registro(14)
                End With
            End If

            'listar la fotografia del interno
            ShowFotografia2()

            ListarNombresAsociadosReniec()
        End Sub
        Private Sub ListarNombresAsociadosActual()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            objBss = New Bussines.Registro.NombreAsociado
            objEntCol = New Entity.Registro.NombreAsociadoCol

            Dim objEnt As New Entity.Registro.NombreAsociado
            objEnt.InternoID = Me._InternoID
            objEnt.Principal = 0
            objEnt.Estado = 1
            objEntCol = objBss.Listar(objEnt)
            With Me.dgwGrillaNombresAsociados
                .RowCount = 1
                Me.NumFilasDgw = objEntCol.Count
                If objEntCol.Count > 0 Then

                    Dim NomAso As String = ""
                    Dim NomAsoID As String = ""
                    Dim NomAsoLis As String = ""
                    Dim intConta As Integer = -1
                    Dim strData As String = ""
                    For Each EntAso As Entity.Registro.NombreAsociado In objEntCol
                        intConta = intConta + 1
                        strData = strData & IIf(intConta = 0, "", " | ") & EntAso.ApellidoPaterno & " " & EntAso.ApellidoMaterno & "," & EntAso.Nombres
                        NomAso = NomAso & IIf(intConta = 0, "", "|") & EntAso.Codigo & "," & EntAso.ApellidoPaterno & "," & EntAso.ApellidoMaterno & "," & EntAso.Nombres
                        NomAsoID = NomAsoID & IIf(intConta = 0, "", ",") & EntAso.Codigo
                        NomAsoLis = NomAsoLis & IIf(intConta = 0, "", "|") & EntAso.ApellidoPaterno & "," & EntAso.ApellidoMaterno & "," & EntAso.Nombres
                    Next
                    .Item(0, 0).Value = strData

                    Me._NombresAsociados = NomAso
                    Me._NombresAsociadosID = NomAsoID
                    Me._NombresAsociadosLista = NomAsoLis

                    Me.grpNombreAsociados.Visible = True
                    'Me.lblNombresAsociados.Visible = False
                Else
                    .Item(0, 0).Value = "El interno no cuenta con nombres asociados."
                End If
                dgwGrillaNombresAsociados.Columns(0).HeaderText = "Nombres Asociados    " & Me.NumFilasDgw & " Reg."
            End With
        End Sub
        Public Property Fecha() As Long = 0
        Public ReadOnly Property FechaHoraPM() As String
            Get
                Dim f As Date
                Dim Fecha_ As String
                Dim Hora As String
                Dim Minuto As String
                Fecha_ = Legolas.Components.FechaHora.FechaDate(Me.Fecha, False)
                f = Legolas.Components.FechaHora.FechaDate(Me.Fecha, True)
                Hora = CDate(f).Hour
                Minuto = CDate(f).Minute
                If Hora = 0 Then
                    Hora = "00"
                End If
                If Minuto = 0 Then
                    Minuto = "00"
                End If
                If Len(Hora) = 1 Then
                    Hora = 0 & Hora
                End If
                If Len(Minuto) = 1 Then
                    Hora = 0 & Hora
                End If
                Fecha_ = Fecha_ & " " & Hora & ":" & Minuto
                Return Fecha_
            End Get
        End Property
        Private Sub ListarNombresAsociadosReniec()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            With Me.dgwGrillaNombresAsociados
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                '.AutoGenerateColumns = False
                .DataSource = Nothing
                If Me._Version = False Then
                    If Me._NombresAsociadosLista <> "" Then
                        Dim strListaNA As String = Me._NombresAsociadosLista
                        Dim strCaracter As String = Me._NombresAsociadosLista
                        Dim ContaLetras As Integer = Len(strCaracter)
                        Dim ContaCarater As Integer = 1
                        For i As Integer = 1 To ContaLetras
                            If Mid(strCaracter, i, 1) = "|" Then
                                ContaCarater = ContaCarater + 1
                            End If
                        Next
                        .RowCount = ContaCarater
                        Dim strListaCadena() As String = strListaNA.Split("|")
                        For j As Integer = 0 To ContaCarater - 1
                            Dim Fila As String = strListaCadena(j)
                            Dim fila2 As String() = Fila.Split(",")
                            .Item(0, j).Value = j + 1
                            .Item(3, j).Value = fila2(0)
                            .Item(4, j).Value = fila2(1)
                            .Item(5, j).Value = fila2(2)
                        Next
                        Me.NumFilasDgw = .RowCount
                        Me.grpNombreAsociados.Visible = True
                        'Me.lblNombresAsociados.Visible = False
                    Else
                        Me.grpNombreAsociados.Visible = False
                        'Me.lblNombresAsociados.Visible = True
                    End If
                Else 'version actual
                    Dim objEnt As New Entity.Registro.InternoReniecNomAsoc
                    objEnt.InternoID = Me._InternoID
                    objEnt.InternoReniecID = Me._VarHistorico
                    objBssIntRncNomAso = New Bussines.Registro.InternoReniecNomAsoc
                    objIntNomAsocCol = objBssIntRncNomAso.Listar(objEnt)
                    With dgwGrillaNombresAsociados
                        .RowCount = 1 'objIntNomAsoc.Count
                        Me.NumFilasDgw = objIntNomAsocCol.Count
                        Dim strMensaje As String = ""
                        For i As Integer = 0 To objIntNomAsocCol.Count - 1
                            strMensaje = strMensaje & IIf(i = 0, "", " | ") & objIntNomAsocCol.Historial(i).ApellidoPaterno & " " & objIntNomAsocCol.Historial(i).ApellidoMaterno & "," & objIntNomAsocCol.Historial(i).Nombres
                            .Item(0, 0).Value = strMensaje
                        Next
                        If objIntNomAsocCol.Count > 0 Then
                            Me.grpNombreAsociados.Visible = True
                        Else
                            .Item(0, 0).Value = "El interno no cuenta con nombres asociados."
                        End If
                        dgwGrillaNombresAsociados.Columns(0).HeaderText = "Nombres Asociados    " & Me.NumFilasDgw & " Reg."
                    End With
                End If
            End With
        End Sub
#End Region
#Region "Function"

        Private Function ListarImagen_v2(ByVal ArchivoDigitalID As Integer, ByVal NameFile As String, PathServerFotoInt As String) As System.Drawing.Image

            'limpiar variables de las tablas
            blnFotoLocalEliminada = False
            idArchivoDigitalLocal = -1
            lblError.Text = ""
            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central

            Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital
            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            Catch ex As Exception
                intTipoLocal = -1
            End Try
            'validar la ruta
            If NameFile.Trim = "" Then
                Return objImagen
            End If
            If ArchivoDigitalID < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
                Me.HasImagen = False
            Else
                'si hay foto
                Dim objWS As New APPWebService.ws_foto.PopeLocal
                objWS.Timeout = -1
                objWS.Url = APPWebService.PathURL.WSPopeLocal

                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream
                Dim strFotoNameExtension As String = NameFile
                Dim ObjBss As New Bussines.Globall.ArchivoDigital
                Dim strMensajeError As String = ""

                Me.picFoto.Image = Nothing
                Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno

                Try
                    Select Case intTipoLocal
                        Case 2 'solo para regiones
                            objImagenByte = ObjBss.getArchivoDigitalByte_Region(ArchivoDigitalID, Me.TipoImagen, strMensajeError)
                        Case Else  'penales y sede central 

                            r = objWS.ListarArchivoDigital(ArchivoDigitalID, Me.TipoImagen)
                            objImagenByte = r.Resultado.ArchivoByte
                            objWS.Dispose()
                            objWS = Nothing
                    End Select

                Catch ex As Exception
                    objImagenByte = Nothing
                    MessageBox.Show(ex.Message)
                End Try

                If objImagenByte Is Nothing Then
                    CopiaintImagen = -1
                    Select Case intTipoLocal
                        Case 3, 2
                            objImagen = My.Resources.fotografia_por_transferir
                            CopiaNombreImagen = "Fotografia por transferir"
                        Case Else
                            objImagen = My.Resources.fotografia_eliminada
                            CopiaNombreImagen = "Fotografia eliminada"
                            blnFotoLocalEliminada = True
                            idArchivoDigitalLocal = ArchivoDigitalID
                    End Select
                    If intTipoLocal = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        ' MODIFICADO POR JONATAN 06/01/2025
                        ' EN CASO EL ARCHIVO NO SE ENCUENTRE LOCALMENTE, SE MOSTRARA UN MENSAJE, PERO IGUAL BUSCARA USANDO EL WS PARA OBTENER LA FOTO DESDE LIMA

                        Dim objBssFoto = New Bussines.Registro.InternoFoto

                        Dim objEnt As New Entity.Registro.InternoFoto

                        objEnt = objBssFoto.ObtenerCodigoFOTO_SEDE(ArchivoDigitalID)
                        Dim ArchivoDigitalIDLocal = ArchivoDigitalID
                        ArchivoDigitalID = objEnt.SedeRowId

                        lblError.Text = "No se encontró el archivo Localmente."
                        objWS = New APPWebService.ws_foto.PopeLocal
                        objWS.Url = APPWebService.PathURL.WSPopeSedeCentral

                        Try 'APPWebService.ws_foto.TipoCarpeta.Reniec
                            r = objWS.ListarArchivoDigital(ArchivoDigitalID, Me.TipoImagen)
                            objImagenByte = r.Resultado.ArchivoByte
                            objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
                            objImagen = Image.FromStream(objImagenStream)
                            objWS.Url = APPWebService.PathURL.WSPopeLocal
                            objWS.UploadImageJpg(objImagenByte, ObtenerNombre(ArchivoDigitalIDLocal), r.Resultado.Tipo)

                        Catch ex As Exception
                            objImagenByte = Nothing
                            objImagenStream = Nothing
                            objImagen = My.Resources.nspm_fotografia
                        End Try
                    End If

                    RaiseEvent _Click_DatosImagen(-1, CopiaNombreImagen)

                Else
                    objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
                    Try
                        objImagen = Image.FromStream(objImagenStream)
                    Catch ex As Exception
                        objImagen = My.Resources.nspm_fotografia
                    End Try
                    RaiseEvent _Click_DatosImagen(CopiaintImagen, CopiaNombreImagen)
                End If
                Me.HasImagen = True
            End If

            Return objImagen
        End Function
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

        Public Sub _ShowFotoInterno_v2(ByVal ArchivoDigitalID As Integer, ByVal FileName As String, PathServerFotoInt As String)
            Me.picFoto.Image = Nothing
            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
            Me.picFoto.Image = ListarImagen_v2(ArchivoDigitalID, FileName, PathServerFotoInt)

        End Sub
        Private Function ListarImagen(ByVal IDArchivoDigital As Integer) As System.Drawing.Image

            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central

            'validar la ruta
            If IDArchivoDigital < 1 Then
                Return objImagen
            End If

            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Url = APPWebService.PathURL.WSPopeLocal

            'test al web service
            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex As Exception
                objImagen = My.Resources.ws_config
                Return objImagen
            End Try

            'listamos el tipo de licencia donde estamos
            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            Catch ex As Exception
                intTipoLocal = -1
            End Try

            If IDArchivoDigital < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
                Me._HasImagen = False
            Else

                'si hay foto             
                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream

                Dim ObjBss As New Bussines.Globall.ArchivoDigital
                Dim strMensajeError As String = ""


                Try
                    objImagenByte = ObjBss.ListarArchivoDigitalByte(IDArchivoDigital, Me._TipoImagen, strMensajeError)

                    If strMensajeError.Trim = "" Then

                    Else
                        'si hay error
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeError)
                        objImagenByte = Nothing
                    End If

                Catch ex As Exception
                    objImagenByte = Nothing
                End Try

                If objImagenByte Is Nothing Then

                    Select Case intTipoLocal
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia,
                            Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                             Type.Enumeracion.Licencia.enmTipoLicencia.Sede

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
                Me._HasImagen = True
            End If

            Return objImagen

        End Function
        Public Sub _Limpiar()
            Me.picFoto.Image = My.Resources.sin_foto
            Me.HasImagen = False
        End Sub
        Private Sub ShowFotografia()
            If _InternoID < 1 Then
                _Limpiar()
                Exit Sub
            Else

                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEnt As New Entity.Registro.InternoFoto

                Dim intImagen As Integer = -1
                Dim intNombreImagen As String = ""
                Dim strPathServer As String = ""
                Dim blnFotoHistorico As Boolean = False

                Dim intCodigo As Integer

                intCodigo = objBssFoto.ListarIDFotoReciente(_InternoID)

                objBssFoto = New Bussines.Registro.InternoFoto

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana _
                    Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                    objEnt = objBssFoto.ListarGrilla_LM(intCodigo)
                Else
                    If objBssFoto.FotoVersionAntigua(_InternoID, -1) = True Then
                        objEnt = objBssFoto.Listar(intCodigo)
                    Else
                        objEnt = objBssFoto.ListarGrilla(intCodigo)
                    End If
                End If

                If objEnt.Codigo > 0 Then
                    With objEnt
                        Select Case Me.PerfilFotografia
                            Case 2 'frente
                                PerfilActual = 2
                                intImagen = .PFrenteID
                                intNombreImagen = .PFrenteName
                                strPathServer = .PFrenteServerPath
                        End Select
                    End With
                    Me.CopiaintImagen = intImagen
                    Me.CopiaNombreImagen = intNombreImagen

                    _ShowFotoInterno_v2(intImagen, intNombreImagen, strPathServer)
                    Exit Sub

                Else
                    _Limpiar()
                End If
            End If
        End Sub


        Public Sub _ShowFotoInterno(ByVal ArchivoDigitalID As Integer)

            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
            Me.picFoto.Image = ListarImagen(ArchivoDigitalID)

        End Sub
        Private Sub ShowFotografia2()
            If _InternoID < 1 Then
                _Limpiar()
                Exit Sub
            Else
                Dim objBssFoto As Bussines.Registro.InternoFoto
                Dim objBssRnc As New Bussines.Registro.InternoReniec
                Dim objEnt As New Entity.Registro.InternoReniec
                Dim intCodigo As Integer = objBssRnc.FotoIDRncReciente(_InternoID, Me._VarHistorico)
                Dim intImagen As String = ""
                Dim intNombreImagen As String = ""
                Dim strPath As String = ""
                objBssFoto = New Bussines.Registro.InternoFoto
                'objEnt = objBssFoto.ListarRncInt(intCodigo)
                objEnt = objBssFoto.ListarInternoReniec_v2(intCodigo)

                If objEnt.Codigo > 0 Then
                    With objEnt
                        Select Case Me.PerfilFotografia
                            Case 2 'frente
                                PerfilActual = 2
                                intImagen = .PFrenteInt
                                intNombreImagen = .NombreFotoInterno
                                strPath = .PthServidorFotoInterno
                        End Select
                    End With
                    If intImagen = "" Then
                        intImagen = "-1"
                    End If
                    Me.CopiaintImagen = intImagen
                    Me.CopiaNombreImagen = intNombreImagen

                    _ShowFotoInterno_v2(intImagen, intNombreImagen, strPath)
                Else
                    _Limpiar()
                End If
            End If
        End Sub
#End Region
#Region "Otros"
        Public Sub _Show_FotoAutoSize()
            Form_FotoAutoSize()
        End Sub
        Private Sub Form_FotoAutoSize()

            If Me._EnabledDobleClick = False Then
                Exit Sub
            End If

            If Me.picFoto.Image Is Nothing = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "No se puede hacer zoom a la foto")
                Exit Sub
            End If

            Dim frm As New Foto.frmFotoZoomPopup
            With frm
                ._pImagen = Me.picFoto.Image
                ._pSizeMode = PictureBoxSizeMode.Zoom
                .ShowDialog()
            End With

        End Sub

        Private blnFotoLocalEliminada As Boolean = False
        Private idArchivoDigitalLocal As Integer = -1
        Private Sub aDescargarFotografiaDesdeSede()

            If blnFotoLocalEliminada = True Then

                Dim strMensajeOut As String = ""
                Dim objWSFotoLocal As New APPWebService.Fotografia

                If idArchivoDigitalLocal > 0 Then

                    Dim intIDArchivoDigitalSedeRowID As Integer = -1
                    Dim objBssArchivoDigital As New Bussines.Globall.ArchivoDigital
                    intIDArchivoDigitalSedeRowID = objBssArchivoDigital.getSedeRowID(idArchivoDigitalLocal, strMensajeOut)

                    If intIDArchivoDigitalSedeRowID > 0 Then
                        Dim blnSeDescargoFoto As Boolean = False
                        blnSeDescargoFoto = objWSFotoLocal.ReDescargarFotografiaLocal(intIDArchivoDigitalSedeRowID, strMensajeOut)

                        If blnSeDescargoFoto = True Then
                            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                            ListarInternoCondicion()
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                        End If
                    End If

                End If

            End If

        End Sub
#End Region
#Region "ValoresxDefault"
        Private Sub FondoBlanco()
            Me.txtNumeroDni.BackColor = Color.White
            Me.txtApePaterno.BackColor = Color.White
            Me.txtApeMaterno.BackColor = Color.White
            Me.txtNombres.BackColor = Color.White
            Me.txtSexo.BackColor = Color.White
            Me.txtfechanac.BackColor = Color.White
            Me.txtNacimientoUbigeo.BackColor = Color.White
            Me.txtUbigeoDomicilio.BackColor = Color.White
            Me.txtDireccion.BackColor = Color.White
            Me.txtEstadoCivil.BackColor = Color.White
            Me.txtPadre.BackColor = Color.White
            Me.txtMadre.BackColor = Color.White
            Me.txtConyuge.BackColor = Color.White
            Me.txtGradoInstruccion.BackColor = Color.White
            Me.txtEstatura.BackColor = Color.White
            'Me.lblNombresAsociados.Location = New Size(2, 360)
        End Sub

#End Region
        Private Sub uscValidarInterno_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            FondoBlanco()
            dgwGrillaNombresAsociados.RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
        End Sub
        Private Sub pbFoto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picFoto.DoubleClick
            Form_FotoAutoSize()
        End Sub

        Private Sub lblNombresAsociados_Click(sender As System.Object, e As System.EventArgs)

        End Sub

        Private Sub txtEstatura_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEstatura.TextChanged

        End Sub

        Private Sub dgwGrillaNombresAsociados_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaNombresAsociados.CellContentClick

        End Sub

        Private Sub dgwGrillaNombresAsociados_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaNombresAsociados.CellDoubleClick

            If Not objEntCol Is Nothing Then
                RaiseEvent _DobleClickGrilla(objEntCol)
            End If

        End Sub

        Private Sub dgwGrillaNombresAsociados_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dgwGrillaNombresAsociados.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub picFoto_Click(sender As Object, e As EventArgs) Handles picFoto.Click

        End Sub

        Private Sub DescargarFotografiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarFotografiaToolStripMenuItem.Click

            aDescargarFotografiaDesdeSede()

        End Sub

        Private Sub picFoto_MouseDown(sender As Object, e As MouseEventArgs) Handles picFoto.MouseDown

            If blnFotoLocalEliminada = True Then
                Me.ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
            End If

        End Sub
    End Class
End Namespace


