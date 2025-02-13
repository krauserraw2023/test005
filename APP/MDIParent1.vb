Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Threading
Imports System.Text
Imports APPWebService.ws_pope_sede_uploadfile
Imports System.Net
Imports Legolas.Components
Imports System.Threading.Tasks

Public Class MDIParent1
    Private showAvisoPopup As Boolean = False
    Private _objBotonesReversa() As ToolStripItem
    Dim contaRefreshSes As Integer = 0 'contadro para refrescar session del usuario en la BD X
#Region "Propiedades"
    Private ReadOnly Property IDLicencia As Short
        Get
            Return Configuracion.Licencia.Codigo
        End Get
    End Property
    Private ReadOnly Property LicenciaTipo As Short
        Get
            Dim value As Short = -1
            Dim objBss As New Bussines.Sistema.Instalacion
            value = objBss.ListarTipo(Me.IDLicencia)
            Return value
        End Get
    End Property
    Private ReadOnly Property UsuarioPerfil As Short
        Get
            Return Legolas.Configuration.Usuario.OficinaID
        End Get
    End Property

#End Region

#Region "Modulo_Menu"
    Private Sub AgregarBotonAlMenu(ByVal Modulo As Legolas.LEntity.Seguridad.Modulo)
        AgregarBotonAlMenu(Modulo, ToolStripItemAlignment.Left)
    End Sub
    Private Sub AgregarBotonAlMenu(ByVal Modulo As Legolas.LEntity.Seguridad.Modulo, ByVal Alineacion As ToolStripItemAlignment)

        Dim tsbModulo As New APPControls.MyToolStripButton

        tsbModulo.Modulo = Modulo
        tsbModulo.Text = Modulo.Nombre '.Replace(" ", Chr(13))
        tsbModulo.Alignment = Alineacion
        tsbModulo.ImageAlign = ContentAlignment.TopCenter
        tsbModulo.TextImageRelation = TextImageRelation.ImageAboveText
        tsbModulo.TextAlign = ContentAlignment.BottomCenter
        AddHandler tsbModulo.Click, AddressOf tsbModulo_ItemClick

        If Not Modulo.Icono Is Nothing Then
            Dim ms As New System.IO.MemoryStream(Modulo.Icono)

            Try
                tsbModulo.Image = Image.FromStream(ms)
            Catch ex As Exception
                tsbModulo.Image = My.Resources.windows
            End Try

        Else
            tsbModulo.Image = My.Resources.windows
        End If

        tspToolBar.Items.Add(tsbModulo)

        Dim tsbSeparador As New ToolStripSeparator
        tsbSeparador.Alignment = Alineacion
        tspToolBar.Items.Add(tsbSeparador)

    End Sub
    Private Sub ConfigurarBotonInicio()

        Dim tsbModulo As New APPControls.MyToolStripButton

        tsbModulo = New APPControls.MyToolStripButton
        tsbModulo.Modulo = New Legolas.LEntity.Seguridad.Modulo

        tsbModulo.Modulo.HasSeccion = True
        tsbModulo.Modulo.Codigo = 0
        tsbModulo.Modulo.CodigoPadre = 0
        tsbModulo.Modulo.Objecto = "frmInicio"
        tsbModulo.Text = "Ir a Inicio"
        tsbModulo.Alignment = ToolStripItemAlignment.Right
        tsbModulo.TextImageRelation = TextImageRelation.ImageAboveText
        AddHandler tsbModulo.Click, AddressOf tsbModulo_ItemClick

        tsbModulo.Image = My.Resources.house

        ReDim Preserve _objBotonesReversa(0)
        tsbModulo.Index = _objBotonesReversa.Length - 1
        _objBotonesReversa(0) = tsbModulo

    End Sub
    Private Sub PoblarMenu(ByVal CodigoPadre As Integer)

        'codigo temporal para lurigancho, luego borrar
        'Dim intLicencia As Integer = Configuracion.Licencia.Codigo

        Dim objBss As New Legolas.LBusiness.Seguridad.Modulo

        Dim entModulos As Legolas.LEntity.Seguridad.ModuloCol = objBss.Listar(
        Legolas.Configuration.Usuario.Codigo, -1, CodigoPadre, "")

        If Not entModulos Is Nothing Then
            tspToolBar.Items.Clear()

            For Each entModulo As Legolas.LEntity.Seguridad.Modulo In entModulos
                AgregarBotonAlMenu(entModulo)
            Next

            If Not _objBotonesReversa Is Nothing And CodigoPadre > 0 Then
                If _objBotonesReversa.Length > 0 Then
                    Dim i As Integer = 0
                    For Each objCtrl As APPControls.MyToolStripButton In _objBotonesReversa
                        If TypeOf objCtrl Is APPControls.MyToolStripButton Then
                            Dim objBoton As APPControls.MyToolStripButton = CType(objCtrl, APPControls.MyToolStripButton)

                            objBoton.Alignment = ToolStripItemAlignment.Right
                            tspToolBar.Items.Add(objBoton)

                            Dim tsbSeparador As New ToolStripSeparator
                            tsbSeparador.Alignment = ToolStripItemAlignment.Right
                            tspToolBar.Items.Add(tsbSeparador)

                            If i < _objBotonesReversa.Length - 1 Then
                                objBoton.Visible = True
                                tsbSeparador.Visible = True
                            Else
                                objBoton.Visible = False
                                tsbSeparador.Visible = False
                            End If

                            i += 1
                        End If
                    Next
                End If
            End If
        Else
            Dim _boolen As Boolean = True
            For Each tsp As Object In tspToolBar.Items
                If TypeOf tsp Is APPControls.MyToolStripButton Then
                    If tsp.Text = "Ir a Inicio" Then
                        _boolen = False
                    End If
                End If

            Next
            If _boolen Then
                If Not _objBotonesReversa Is Nothing And CodigoPadre > 0 Then
                    If _objBotonesReversa.Length > 0 Then
                        Dim i As Integer = 0

                        Dim objCtrl As APPControls.MyToolStripButton = _objBotonesReversa(0)
                        If TypeOf objCtrl Is APPControls.MyToolStripButton Then
                            Dim objBoton As APPControls.MyToolStripButton = CType(objCtrl, APPControls.MyToolStripButton)

                            objBoton.Alignment = ToolStripItemAlignment.Right
                            tspToolBar.Items.Add(objBoton)

                            Dim tsbSeparador As New ToolStripSeparator
                            tsbSeparador.Alignment = ToolStripItemAlignment.Right
                            tspToolBar.Items.Add(tsbSeparador)

                            If i < _objBotonesReversa.Length - 1 Then
                                objBoton.Visible = True
                                tsbSeparador.Visible = True
                            Else
                                objBoton.Visible = False
                                tsbSeparador.Visible = False
                            End If

                            i += 1
                        End If


                    End If
                End If


            End If
        End If
    End Sub
    Public Sub AbrirFormulario(ByVal ModuloID As Integer, ByVal ModuloNombre As String, ByVal ModuloObjeto As String)

        'actualizar la fecha del app con el server
        Legolas.Configuration.Aplication.FechayHora.FechaLong = Legolas.LBusiness.Globall.DateTime.FechaServerLong
        Me.lblFecha.Text = Legolas.Configuration.Aplication.FechayHora.FechaText

        Dim strBaseNamespace As String = "SIPPOPE"
        strBaseNamespace &= "." & ModuloObjeto

        If ModuloObjeto <> String.Empty Then

            Dim frm As Object = Nothing
            frm = New Legolas.APPUIComponents.Form

            If ModuloID > 0 Then

                Dim objEntUsuarioModuloCol As New Legolas.LEntity.Seguridad.UsuarioModuloCol
                Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioModulo

                objEntUsuarioModuloCol = objBss.Listar(Legolas.Configuration.Usuario.Codigo, -1, ModuloID)

                If objEntUsuarioModuloCol IsNot Nothing Then

                    If objEntUsuarioModuloCol.Count = 1 Then

                        frm = Activator.CreateInstance(System.Type.GetType(strBaseNamespace))

                        frm._FormNameSpace = strBaseNamespace
                        'frm = frm.Instance                        
                        frm.ModuloID = ModuloID
                        frm._FormEliminar = objEntUsuarioModuloCol.Item(0).Eliminar
                        'frm._FormLectura = objEntUsuarioModuloCol.Item(0).Lectura
                        frm._FormEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                        frm._FormReporte = objEntUsuarioModuloCol.Item(0).Reporte
                        frm._FormImpresion = objEntUsuarioModuloCol.Item(0).Impresion
                        frm._FormLectura = objEntUsuarioModuloCol.Item(0).Lectura
                        'frm._FormEliminar = objEntUsuarioModuloCol.Item(0).Eliminar
                        frm.AplicarSeguridad = True
                        frm.Text = ModuloNombre
                        'frm.MdiParent = Me
                        'frm.Show()

                        AbrirFormulario(frm, Me)
                        'Dim frm As Seguridad.frmBuscar = Config.Singleton2.Instance(Seguridad.frmBuscar)

                    End If
                End If
            Else
                'FormInicio()                
            End If
        End If

    End Sub
    Public Sub AbrirFormulario(ByVal FormularioChild As Legolas.APPUIComponents.Form, ByVal MDI As Form)

        Dim frmLlamado As Legolas.APPUIComponents.Form

        Dim blnFormExiste As Boolean = False

        Try

            'Chequea si el formulario ha sido cargado

            For Each frmLlamado In MDI.MdiChildren

                'Compara si es igual y retorna verdadero si lo es.

                If frmLlamado._FormNameSpace = FormularioChild._FormNameSpace Then

                    blnFormExiste = True   'Marca la bandera

                    Exit For      'Sale del loop si es verdadero

                End If
            Next

            If Not blnFormExiste Then
                'Carga el formulario si no esta llamado
                FormularioChild.MdiParent = MDI
                FormularioChild.Show()
            ElseIf blnFormExiste Then
                'frmLlamado.Focus()   'Enfoca el objeto
                frmLlamado.BringToFront()
            End If

        Catch ex As Exception
            Legolas.Configuration.Aplication.MessageBox.MensajeError(ex.Message)
        End Try

        FormularioChild = Nothing  'Limpiar todo
        frmLlamado = Nothing

    End Sub
    Private Sub tsbModulo_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim objBoton As APPControls.MyToolStripButton = CType(sender, APPControls.MyToolStripButton)

        If Not objBoton Is Nothing Then
            'CerrarFormularios()
            'PermisoEspecial(objBoton.Modulo.Codigo, objBoton.Modulo.Nombre)
            AbrirFormulario(objBoton.Modulo.Codigo, objBoton.Modulo.Nombre, objBoton.Modulo.Objecto)

            If objBoton.Modulo.HasSeccion Then
                If objBoton.Modulo.Codigo > 0 And objBoton.Modulo.CodigoPadre = 0 Then
                    ConfigurarBotonInicio()
                End If

                If objBoton.Modulo.Objecto <> String.Empty Or objBoton.Modulo.Codigo >= 0 Then

                    Dim i As Integer
                    If objBoton.Alignment = ToolStripItemAlignment.Left Then
                        i = _objBotonesReversa.Length
                    Else
                        i = objBoton.Index
                    End If

                    ReDim Preserve _objBotonesReversa(i)
                    objBoton.Index = i
                    _objBotonesReversa(i) = objBoton
                End If

                PoblarMenu(objBoton.Modulo.Codigo)
            End If
        End If

    End Sub
#End Region

#Region "Form"
    Private Sub FRM_Usuario()

        Dim frm As Sistema.Seguridad.Usuario.frmBuscar = Config.Singleton_Forms.Instance_frmSeguridad_frmBuscar
        With frm
            .MdiParent = Me
            .Show()
        End With

    End Sub
    Private Sub FRM_Modulo()

        Dim frm As Seguridad.Modulo.frmBuscar = Config.Singleton_Forms.Instance_Seguridad_Modulo_frmBuscar
        With frm
            .MdiParent = Me
            .Show()
        End With

    End Sub
    'Private Sub FRM_BloquearSistema()

    '    Dim frm As New Sistema.Seguridad.Usuario.frmBloquearSistema 'nueva version
    '    'Dim frm As New Seguridad.frmBloquearSistema
    '    With frm
    '        ._UsuarioLogin = Legolas.Configuration.Usuario.Login
    '        '.MdiParent = Me
    '        .ShowDialog()
    '    End With

    'End Sub
    Private Sub FRM_CambiarClave()

        Dim frm As New Sistema.Seguridad.Usuario.frmCambiarClave
        'Dim frm As New Seguridad.frmCambiarClave
        With frm
            '.MdiParent = Me
            .ShowDialog()
        End With

    End Sub
    Private Sub FRM_Actualizar_Tablas_Configuracion()

        Dim frm As New Mantenimiento.frmActualizarWeb_v3
        With frm
            .ShowDialog()
        End With

    End Sub
    Private Sub FRM_Acerca()

        Dim frm As New frmAboutBox
        With frm
            .ShowDialog()
        End With

    End Sub
    Private Sub FRM_ActualizarTablasMaestras()

        Select Case Configuracion.Licencia.Codigo

            Case 1 'sede central
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Esta opcion solo esta habilitado para provincias")

            Case Else

                Dim frm As New Mantenimiento.frmTablasMaestrasPopup
                With frm
                    .ShowDialog()
                End With

        End Select

    End Sub

#End Region

#Region "Otros"
    Private Sub NivelSeguridad()

        Me.SistemaToolStripMenuItem.Visible = Legolas.Configuration.Usuario.AdministrarModuloUsuario

        Dim blnVerMenu_Mante As Boolean = False
        Dim blnVerMenuRegistroHuella As Boolean = False

        Select Case IDLicencia

            Case 1 'sede

                Select Case UsuarioPerfil
                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                        blnVerMenu_Mante = True
                        blnVerMenuRegistroHuella = True
                    Case Else

                End Select

            Case Else 'penal lm, penal, provincias y region
                blnVerMenu_Mante = True

                If Me.LicenciaTipo = 1 Or Me.LicenciaTipo = 4 Then 'penales provincias y penales de lm
                    If UsuarioPerfil = Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario Then
                        blnVerMenuRegistroHuella = True
                    End If

                    If UsuarioPerfil = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                        blnVerMenuRegistroHuella = True
                    End If
                End If

        End Select

        Me.MantenimientoToolStripMenuItem.Visible = blnVerMenu_Mante

    End Sub

    ' METODO PARA INICIAR EL RE ENVIO EN SEGUNDO PLANO - JONATAN SILVA 14/01/2025
    Private Sub EjecutarEnSegundoPlano()

        Task.Run(Sub() ReprocesarFotosALIMA())
    End Sub
    ' METODO PARA EL RE ENVIO DE LAS FOTOS DEL PENAL A SEDE - JONATAN SILVA 14/01/2025
    Private Async Sub ReprocesarFotosALIMA()
        Try

            If Not Await ValidarWebService() Then
                Return
            End If
            Dim fecha = Legolas.LBusiness.Globall.WinApp.ListarString("reenvio_fotos_lima", -1)

            If fecha = "" Then
                Return
            Else
                Dim fechaComparar As Date = Date.Parse(fecha)
                ' Comparar si la fecha actual es mayor a la fecha almacenada
                If Date.Now.Date > fechaComparar Then
                    ' Ejecutar el proceso solo si la fecha actual es mayor
                    Iniciar()
                    Dim soloFecha As String = Date.Now.Date.ToString("dd/MM/yyyy")

                    Legolas.LBusiness.Globall.WinApp.Grabar("reenvio_fotos_lima", soloFecha, 0)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

    End Sub

    ' METODO PARA VALIDAR EL RE ENVIO DE LAS FOTOS DEL PENAL A SEDE - JONATAN SILVA 14/01/2025
    Public Async Function ValidarWebService() As Task(Of Boolean)
        Dim flag1 As Boolean = False
        Dim FotoSEDE As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_transferencia_foto_global", -1)
        Dim FotoLocal As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_foto", -1)

        ' Crear instancias de los objetos de servicio
        Dim objWS As New APPWebService.ws_foto.PopeLocal()
        Dim uploadFile As New APPWebService.ws_pope_sede_uploadfile.UploadFileSoapClient("UploadFileSoap")

        objWS.Url = FotoLocal

        Dim num As Long
        Dim flag2 As Boolean

        Try
            ' Usar una versión asincrónica de FechaHoy si está disponible
            num = Await Task.Run(Function() objWS.FechaHoy()) ' Se ejecuta en un hilo en segundo plano
        Catch ex As Exception
            flag2 = flag1
            Return flag2
        End Try

        Dim str As String
        Try
            ' Usar la versión asincrónica de Version si está disponible
            str = Await Task.Run(Function() uploadFile.Version()) ' Se ejecuta en un hilo en segundo plano
        Catch ex As Exception
            flag2 = flag1
            Return flag2
        End Try

        ' Validar los resultados
        If num > 0L AndAlso str.Length > 3 Then
            flag1 = True
        End If

        flag2 = flag1
        Return flag2
    End Function


    ' METODO PARA INICIAR EL RE ENVIO DE LAS FOTOS DEL PENAL A SEDE - JONATAN SILVA 14/01/2025
    Private Async Sub Iniciar()
        Dim strMensajeOut As String = ""
        Dim Resultado As New DataTable()
        Dim objBss As New Bussines.Sistema.Instalacion
        Dim PenalID = objBss.LicenciaIDPenal(Me.IDLicencia)

        ' Realizar la actualización y transferencia de fotos asincrónicamente
        Resultado = Await Task.Run(Function() ActualizarListarImagenesNOSUBIDAS_MALSUBIDAS(PenalID))

        ' Transferir fotos asincrónicamente si es necesario
        Await TransferirFotos(Resultado)
    End Sub
    'JONATAN SILVA 14/01/2025
    Private Async Function TransferirFotos(Resultado As DataTable) As Task
        Try
            Dim str1 As String = ""
            Dim str2 As String = ""
            Dim strMensajeOut As String = ""
            Dim dataTable As DataTable = Resultado

            ' Validación asincrónica
            If Not Await ValidarWebService() Then
                Return
            End If

            Try
                For Each row As DataRow In dataTable.Rows
                    Dim vcodigo As Integer = -1
                    Dim IDArchivoDigital As Integer = -1
                    Dim str3 As String = ""
                    Dim num1 As Integer = -1
                    Dim IDRegion As Short = -1
                    Dim IDPenal As Short = -1
                    Dim Anio As Short = -1
                    Dim num2 As Short = -1
                    Dim num3 As Short = -1
                    str2 = ""

                    If Not IsDBNull(row("img_id")) Then
                        vcodigo = Convert.ToInt32(row("img_id").ToString())
                    End If

                    If Not IsDBNull(row("arc_dig_id")) Then
                        IDArchivoDigital = Convert.ToInt32(row("arc_dig_id").ToString())
                    End If

                    If Not IsDBNull(row("img_nom")) Then
                        str3 = row("img_nom").ToString()
                    End If

                    If Not IsDBNull(row("img_tip_fot")) Then
                        num1 = Convert.ToInt32(row("img_tip_fot").ToString())
                    End If

                    If Not IsDBNull(row("_regid")) Then
                        IDRegion = Convert.ToInt16(row("_regid").ToString())
                    End If

                    If Not IsDBNull(row("_penid")) Then
                        IDPenal = Convert.ToInt16(row("_penid").ToString())
                    End If

                    If Not IsDBNull(row("img_anio")) Then
                        Anio = Convert.ToInt16(row("img_anio").ToString())
                    End If

                    If Not IsDBNull(row("img_mes")) Then
                        num2 = Convert.ToInt16(row("img_mes").ToString())
                    End If

                    If Not IsDBNull(row("img_mes_cor")) Then
                        num3 = Convert.ToInt16(row("img_mes_cor").ToString())
                    End If

                    If Not IsDBNull(row("img_path")) Then
                        str2 = row("img_path").ToString()
                    End If

                    Dim flag1 As Boolean = True

                    Select Case num1
                        Case 3
                            flag1 = True
                        Case 4
                            If num2 < 1 Then
                                str1 = ""
                                flag1 = False
                            End If
                    End Select

                    If flag1 Then
                        Dim MesCorrelativo As String = num2.ToString("00") & num3.ToString("000")

                        If row IsNot Nothing Then
                            Dim objByteArchivo As Byte() = Nothing
                            Dim flag2 As Boolean

                            ' Llamada asincrónica para descargar archivo
                            If num1 = 0 OrElse num1 = 6 Then
                                flag2 = False
                            Else
                                objByteArchivo = Await DescargarArchivoByte_Local(CType(num1, TipoArchivo), IDArchivoDigital, str3)
                                flag2 = True
                            End If

                            If objByteArchivo Is Nothing Then
                                If flag2 Then
                                    Await UpdatearTabla(vcodigo, 3)
                                End If
                            ElseIf Await TransferirFotoSede(CType(num1, TipoArchivo), IDRegion, IDPenal, Anio, MesCorrelativo, objByteArchivo, str3) = 1 Then
                                Await UpdatearTabla(vcodigo, 1)
                            Else
                                Await UpdatearTabla(vcodigo, 2)
                            End If
                        End If
                    End If
                Next
            Finally

            End Try
        Catch ex As Exception
            ' Manejo de errores si es necesario
        End Try
    End Function

    'JONATAN SILVA 14/01/2025
    Public Async Function TransferirFotoSede(
    TipoArchivo As TipoArchivo,
    IDRegion As Integer,
    IDPenal As Integer,
    Anio As Integer,
    MesCorrelativo As String,
    objByteArchivo As Byte(),
    NombreArchivo As String) As Task(Of Integer)

        ' Usamos Task.Run para ejecutar el método SubirArchivoByte_Sede de forma asincrónica
        Return Await Task.Run(Function() SubirArchivoByte_Sede(CShort(IDRegion), CShort(IDPenal), CShort(Anio), MesCorrelativo, objByteArchivo, NombreArchivo, TipoArchivo))
    End Function


    'JONATAN SILVA 14/01/2025
    Public Function SubirArchivoByte_Sede(
    RegionID As Short,
    PenalID As Short,
    Anio As Short,
    MesCorrelativo As String,
    objByte As Byte(),
    NombreArchivo As String,
    TipoArchivo As TipoArchivo) As Integer

        Dim result As Integer

        Try
            Dim uploadFile As New APPWebService.ws_pope_sede_uploadfile.UploadFileSoapClient("UploadFileSoap")

            Dim flag As Boolean = False

            Select Case TipoArchivo
                Case TipoArchivo.Interno
                    If Anio <= 1 Then
                        flag = uploadFile.UploadImageJpg(objByte, NombreArchivo, CType(TipoArchivo, Integer))
                    Else
                        flag = uploadFile.SubirArchivoByte(RegionID, PenalID, Anio, MesCorrelativo, objByte, NombreArchivo, CType(TipoArchivo, TipoArchivo))
                    End If

                Case TipoArchivo.Visitante
                    flag = uploadFile.UploadImageJpg(objByte, NombreArchivo, CType(TipoArchivo, Integer))

                Case TipoArchivo.Reniec
                    flag = uploadFile.SubirArchivoByte(RegionID, PenalID, Anio, MesCorrelativo, objByte, NombreArchivo, CType(TipoArchivo, TipoArchivo))
            End Select

            result = If(flag, 1, 0)
        Catch ex As Exception
            result = -1
        End Try

        Return result
    End Function
    'JONATAN SILVA 14/01/2025
    Public Async Function UpdatearTabla(vcodigo As Integer, vestado As Integer) As Task
        Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)
        Dim strSQl As New StringBuilder()

        strSQl.AppendLine("update glo_imagen")
        strSQl.AppendLine("set img_sub=" & vestado.ToString())
        strSQl.AppendLine("where img_id= " & vcodigo.ToString())

        ' Ejecutamos la consulta de forma asincrónica utilizando Task.Run
        Await Task.Run(Sub()
                           Legolas.Components.SQL.ExecuteBatchNonQuery(sqlCn, strSQl.ToString())
                       End Sub)
    End Function


    'JONATAN SILVA 14/01/2025
    Public Async Function DescargarArchivoByte_Local(
    TipoArchivo As TipoArchivo,
    IDArchivoDigital As Integer,
    strNombreArchivo As String) As Task(Of Byte())

        Dim result As Byte() = Nothing
        Dim FotoLocal As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_foto", -1)
        Dim popeLocal As New APPWebService.ws_foto.PopeLocal()
        popeLocal.Url = FotoLocal

        Try
            ' Ejecutamos la lógica de descarga de archivo de forma asincrónica
            Select Case TipoArchivo
                Case TipoArchivo.Interno, TipoArchivo.Reniec
                    ' Si el servicio tiene un método asincrónico disponible, lo usamos.
                    ' Si no, ejecutamos el método sincrónico en un hilo separado con Task.Run.
                    result = Await Task.Run(Function() popeLocal.ListarArchivoDigitalByte(IDArchivoDigital, CType(TipoArchivo, APPWebService.ws_foto.enmTipoImagen)).Resultado)

                Case TipoArchivo.Visitante
                    result = Await Task.Run(Function() popeLocal.LeerImageJpg(strNombreArchivo, CType(TipoArchivo, Integer)))
            End Select
        Catch ex As Exception
            ' Si ocurre un error, result ya es Nothing, no se necesita hacer nada más
            ' Se podría agregar un log para el error si es necesario.
        End Try

        Return result
    End Function

    'JONATAN SILVA 14/01/2025
    Private Function ActualizarListarImagenesNOSUBIDAS_MALSUBIDAS(ByVal PenalID As Integer) As DataTable
        Dim value As Integer = 0
        Dim objDT As New DataTable

        Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)
        Dim strSQl As New StringBuilder()

        strSQl.Append("UPDATE glo_imagen ")
        strSQl.Append("SET img_sub = 0 ")
        strSQl.Append("WHERE img_sub IN (2, 3) ")
        strSQl.Append("AND ISNULL(int_id, 0) > 0 ")
        strSQl.Append("AND ISNULL(img_path, '') <> '' ")
        strSQl.Append("And _penid = " & PenalID.ToString() & " ")
        strSQl.Append("AND _flg_eli = 0")

        strSQl.Append("select ")
        strSQl.Append("* ")
        strSQl.Append("from glo_imagen (NOLOCK) ")
        strSQl.Append("where ")
        strSQl.Append("img_sub IN (0) ")
        strSQl.Append("And ISNULL(int_id, 0) > 0 ")
        strSQl.Append("And ISNULL(img_path, '') <> '' ")
        strSQl.Append("And _penid = " & PenalID.ToString() & " ")
        strSQl.Append("And _flg_eli = 0")



        Try
            objDT = Legolas.Components.SQL.Select_DataTable(sqlCn, strSQl.ToString())
        Catch ex As Exception

        End Try

        Return objDT
    End Function
    Private Sub Show_ToolTipText()

        With Me.ToolTip1
            '.SetToolTip(Me.StatusStrip.Items(1).ToolTipText, "Haga doble click para cambiar el password del usuario actual")
        End With

        Me.StatusStrip.Items(2).ToolTipText = "Haga doble click para cambiar el password del usuario actual"

    End Sub

    Private Sub ValoresxDefault()

        Me.Text = "Sistema Integral Penitenciario"

        Me.lblUsuario.Text = "Usuario :" & Legolas.Configuration.Usuario.ApellidosyNombre
        Me.lblFecha.Text = Legolas.Configuration.Aplication.FechayHora.FechaText

        NivelSeguridad()
        Show_ToolTipText()

    End Sub

    Private Sub ActualizarTablasMaestrasHilo()

        Select Case Configuracion.Licencia.Codigo

            Case 1 'sede central
                'nada
            Case Else

                Select Case Legolas.Configuration.Data.CNDataBase.Trim.ToUpper
                    Case "db_inpe_gob_pe_sip_pope_dev".Trim.ToUpper
                        'nada 
                    Case Else

                        Select Case Legolas.Components.PC.PCNombre.ToUpper
                            Case "pccasajmr".ToUpper
                                'nada

                            Case Else
                                Dim objBss As New Mantenimiento.TablasMaestras
                                Try
                                    objBss.ActualizarData()
                                Catch ex As Exception

                                End Try
                        End Select

                End Select

        End Select

    End Sub
#End Region

#Region "Version"
    Private ReadOnly Property ExisteTablaVersion As Boolean
        Get

            Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim value As Boolean = Legolas.Components.SQL.ExisteTabla(sqlCn, "sis_versionpc")
            sqlCn.Close()
            sqlCn = Nothing

            Return value

        End Get
    End Property
    Private Function ListarVersionApp(MAC As String) As Integer

        Dim value As Integer = 0
        Dim objDT As New DataTable

        Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)
        Dim strSQl As String = "select * from sis_versionpc where c_ver_pc_mac='" & MAC & "' and c_ver_pc_pth='" & Configuracion.Path.Directorio & "'"

        objDT = Legolas.Components.SQL.Select_DataTable(sqlCn, strSQl)

        Try
            value = objDT.Rows(0).Item("n_ver_pc_app").ToString
        Catch ex As Exception

        End Try

        Return value

    End Function
#End Region

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.tspToolBar.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub MDIParent1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'si se cierra session forzada no debe consultar.
        If Main.FORZAR_CIERRE_SESSION_SISTEMA Then

            Me.Cursor = Cursors.WaitCursor

            Dim strTemporales As String = My.Application.Info.DirectoryPath

            Dim v As Boolean = (New Bussines.Seguridad.Usuario).RegistraCierreSesion(Legolas.Configuration.Usuario.Codigo)

            Try
                Legolas.Components.Archivo.DirectorioDeteleFileAll(strTemporales & "\tmp")
                Legolas.Components.Archivo.DirectorioDeteleFileAll(strTemporales & "\Foto")
            Catch ex As Exception

            End Try
            Me.Cursor = Cursors.Default
            Me.Dispose()

            Exit Sub
        End If

        If Legolas.Configuration.Aplication.MessageBox.Question("Desea cerrar el sistema") = Windows.Forms.DialogResult.Yes Then

            Me.Cursor = Cursors.WaitCursor

            Dim strTemporales As String = My.Application.Info.DirectoryPath

            Dim v As Boolean = (New Bussines.Seguridad.Usuario).RegistraCierreSesion(Legolas.Configuration.Usuario.Codigo)

            Try
                Legolas.Components.Archivo.DirectorioDeteleFileAll(strTemporales & "\tmp")
                Legolas.Components.Archivo.DirectorioDeteleFileAll(strTemporales & "\Foto")
            Catch ex As Exception

            End Try

            Me.Cursor = Cursors.Default
            Me.Dispose()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub MDIParent1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ValoresxDefault()

        Dim WorkerThread As Thread = New Thread(New ThreadStart(AddressOf ActualizarTablasMaestrasHilo))
        WorkerThread.Start()

        Select Case Legolas.Configuration.Usuario.Login.ToUpper
            Case "USR0023", "USR1690"
                Me.Timer1.Enabled = False
        End Select

        Select Case IDLicencia

            Case 1 'sede

            Case Else ' provincias 
                If Me.LicenciaTipo = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia Then

                    ReprocesarFotosALIMA()
                End If
        End Select

        If Legolas.Configuration.Usuario.OficinaID = 1 Then Timer2.Enabled = False 'si es sistemas no restringir

    End Sub

    Private Sub MDIParent1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Me.Refresh()

        Me.tsp_sts_lbl_Login.Text = "Usuario : " & Legolas.Configuration.Usuario.Login
        Me.tsp_sts_lbl_TipoUsuario.Text = "Nivel Usuario : " & Legolas.Configuration.Usuario.NivelUsuarioNombre
        Me.tsp_sts_lbl_Dependencia.Text = "Perfil: " & Legolas.Configuration.Usuario.Oficina

        If Configuracion.Licencia.Codigo <> 1 Then 'sede central
            Me.tsp_sts_lbl_VerBD.Visible = True
            Me.tsp_sts_lbl_VerBD.Text = Me.tsp_sts_lbl_VerBD.Text & Legolas.LBusiness.Globall.WinApp.VersionBD
        Else
            Me.tsp_sts_lbl_VerBD.Visible = False
        End If

        'version de aplicativo
        Dim strVersionAPP As String = ""
        If ExisteTablaVersion = True Then
            strVersionAPP = ListarVersionApp(Legolas.Components.PC.GetMAC)
            strVersionAPP = Legolas.Components.Cadena.Version(strVersionAPP)
        Else
            strVersionAPP = Legolas.Configuration.Aplication.VersionString
        End If

        Me.tsp_sts_lbl_VerApp.Text = Me.tsp_sts_lbl_VerApp.Text & strVersionAPP

        PoblarMenu(0)
        Me.Refresh()

        If Legolas.Configuration.Data.AmbienteTipo = 0 Then 'desarrollo
            Me.lblModulo.Text = Legolas.Components.Cadena.ProperCase("DESARROLLO: " & Legolas.Configuration.Data.CNDataBase & " Licencia : " & Legolas.LBusiness.Globall.WinApp.LicenciaApp)
        Else
            Me.lblModulo.Text = (New Bussines.Sistema.Instalacion).LicenciaNombre(Configuracion.Licencia.Codigo)
        End If

    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click

        FRM_Usuario()

    End Sub

    Private Sub ModuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloToolStripMenuItem.Click
        FRM_Modulo()
    End Sub

    Private Sub tsp_sts_lbl_CambiarClave_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsp_sts_lbl_CambiarClave.DoubleClick

        FRM_CambiarClave()

    End Sub

    Private Sub SincronizarTablaSedeCentralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SincronizarTablaSedeCentralToolStripMenuItem.Click

        FRM_Actualizar_Tablas_Configuracion()

    End Sub

    Private Sub ActualizarTablasParemtricasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarTablasParemtricasToolStripMenuItem.Click

        FRM_ActualizarTablasMaestras()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FRM_Acerca()
    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RolToolStripMenuItem.Click

        Dim frm As New Sistema.Seguridad.Usuario.frmBuscar
        With frm
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Dim valor As String
    Dim sw As Boolean = False
    Dim contador As Integer = 0
    Dim frm As Registro.AlertaSentencias.frmAlertasSentenciasCabecera
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case Legolas.Configuration.Usuario.NivelUsuario
            Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
                 Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia,
                 Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana,
                 Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                Select Case Me.UsuarioPerfil
                    Case 2, 16, 17, 18  'Reg. penitenciario, Antecedentes, Detenciones, Sentc. libertades
                    Case Else '1 informatica , todos
                        Exit Sub
                End Select
            Case Else '3 Sede , todos
                Exit Sub
        End Select

        valor = TimeString()

        Select Case valor
            Case "08:30:00", "14:30:00"
                sw = True
            Case Else
                contador = 0
                sw = False
        End Select

        If sw = True Then

            If contador = 0 Then
                contador = contador + 1
                sw = False

                If frm Is Nothing Then
                    frm = New Registro.AlertaSentencias.frmAlertasSentenciasCabecera
                    frm._LicenciaID = Me.IDLicencia
                    frm._TipoLicenciaID = Me.LicenciaTipo
                    frm._MdiParenAux = Me
                    If frm.ShowDialog = DialogResult.OK Then
                        frm = Nothing
                        'FRM_ModuloAlerta(frm._Codigo, frm._RegionID, frm._PenalID, frm._Fecha, frm._item)
                    Else
                        frm = Nothing
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub FRM_ModuloAlerta(intCodigo As Integer, RegionId As Integer, PenalId As Integer, Fecha As String, Item As Integer)

        '/*abrir el los permisos del usuario*/
        Dim objEntUsuarioModuloCol As New Legolas.LEntity.Seguridad.UsuarioModuloCol
        Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioModulo

        objEntUsuarioModuloCol = objBss.Listar(Legolas.Configuration.Usuario.Codigo, -1, 31) 'registro penal

        Dim blnLectura As Boolean = False
        Dim blnEscritura As Boolean = False
        Dim blnReporte As Boolean = False
        Dim blnEliminar As Boolean = False

        If objEntUsuarioModuloCol IsNot Nothing Then
            If objEntUsuarioModuloCol.Count = 1 Then
                blnLectura = objEntUsuarioModuloCol.Item(0).Lectura
                blnEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                blnReporte = objEntUsuarioModuloCol.Item(0).Reporte
                blnEliminar = objEntUsuarioModuloCol.Item(0).Eliminar
            End If
        End If

        '/*abrir el formulario de internos 2022*/
        Dim frm As New Registro.AlertaSentencias.frmAlertaSentenciaDetalle
        frm.MdiParent = Me
        With frm
            ._Codigo = intCodigo
            ._TipoLicenciaID = IIf(Me.LicenciaTipo = 3, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Me.LicenciaTipo)
            ._LicenciaID = Me.IDLicencia
            ._Fecha = Fecha
            ._Item = Item
            ._RegionId = RegionId
            If ._TipoLicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                ._PenalID = -1
            Else
                ._PenalID = PenalId
            End If
            ._FormLectura = blnLectura
            ._FormEscritura = blnEscritura
            ._FormReporte = blnReporte
            ._FormEliminar = blnEliminar
            .Show()
        End With

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim horAct As TimeSpan = TimeSpan.FromTicks(DateTime.Now.Ticks)

        contaRefreshSes = contaRefreshSes + 1
        If contaRefreshSes >= 300 Then '10 minutos
            'refrescar session en la BD
            Dim bssUsuario As New Bussines.Seguridad.Usuario
            bssUsuario.RefrescarSesion(Legolas.Configuration.Usuario.Codigo)
            contaRefreshSes = 0
        End If
        'para mostrar un mensaje N minutos antes
        Dim horAnt As TimeSpan = Main.HORA_CIERRE_SESSION.Subtract(New TimeSpan(0, 3, 0))

        If horAnt.Hours = horAct.Hours And horAnt.Minutes = horAct.Minutes And
                (horAnt.Seconds = horAct.Seconds _
                Or horAnt.Seconds = horAct.Seconds + 1 _
                Or horAnt.Seconds = horAct.Seconds + 2) Then
            showAvisoPopup = True

        End If

        If showAvisoPopup Then
            showAvisoPopup = False
            Dim f As New frmPopupAviso
            f.ShowDialog()
        End If

        If Main.HORA_CIERRE_SESSION.Hours = horAct.Hours And Main.HORA_CIERRE_SESSION.Minutes = horAct.Minutes And
                (Main.HORA_CIERRE_SESSION.Seconds = horAct.Seconds _
                Or Main.HORA_CIERRE_SESSION.Seconds = horAct.Seconds + 1 _
                Or Main.HORA_CIERRE_SESSION.Seconds = horAct.Seconds + 2) Then

            Main.FORZAR_CIERRE_SESSION_SISTEMA = True

            Dim formCollection As FormCollection = Application.OpenForms

            For i As Integer = formCollection.Count - 1 To 0 Step -1
                Dim frm As Form = formCollection(i)
                If frm.Name <> "MDIParent1" Then frm.Close()
            Next
            Me.Close()
        End If

    End Sub
End Class
