Imports System.Data.SqlClient
Imports Bussines.Globall.UtilAccesoBD
Imports System.Net

Namespace Registro
    Public Class InternoRegularizacion
        Private Property CNBDHuellaVisita As String = ""
        Public Sub New(strCNBDHuellaVisita As String)
            Me.CNBDHuellaVisita = strCNBDHuellaVisita
        End Sub
#Region "Clases"
        Public Class Interno
            Public Property IDInterno As Long = -1
            Public Property CodigoRP As String = ""
            Public Property IDRegion As Short = -1
            Public Property IDPenal As Short = -1
            Public Property VersionRegistro As String = ""
            Public Property IDTipoDocumento As Short = -1
            Public Property NumeroDocumento As String = ""
            Public Property PrimerApellido As String = ""
            Public Property SegundoApellido As String = ""
            Public Property Nombres As String = ""
            Public Property FechaNacimiento As Long = 0
            Public Property IDNacionalidad As Short = -1
            Public Property IDRow As Integer = -1
            Public Property InternoEstado As Short = -1
        End Class
        Public Class Ingreso
            Public Property IDIngreso As Integer = -1
            Public Property IDInterno As Integer = -1
            Public Property IDIngresoInpe As Integer = -1
            Public Property NumeroIngreso As Short = 0
            Public Property FechaIngresoInpe As Long = 0
            Public Property FechaIngreso As Long = 0
            Public Property IDMovimientoTipo As Short = -1
            Public Property IDMovimientoMotivo As Short = -1
            Public Property Observacion As String = ""
            Public Property IDRegion As Short = -1
            Public Property IDPenal As Short = -1
            Public Property IDUsuarioCreacion As Integer = -1
            Public Property FechaCreacion As Long = 0

            Public Property IDUsuarioModificacion As Integer = -1
            Public Property FechaModificacion As Long = 0

            Public Property Estado As Short = -1
        End Class
        Private Class InsertUpdate
            Public Property IDTablaLocal As Long
            Public Property IDInternoLocal As Integer = -1
            Public Property IDIngresoInpeLocal As Long = -1
            Public Property IDIngresoLocal As Long = -1
            Public Property IDocumentoCreacion As Integer = -1
            Public Property IDDocumentoAnulacion As Integer = -1

            Public Property IDTablaLocalInternoReniec As Integer = -1
            Public Property IDTablaLocalOdontograma As Integer = -1

            Public Property IDFotoIzquierda As Integer = -1
            Public Property IDFotoFrontal As Integer = -1
            Public Property IDFotoDerecha As Integer = -1
            Public Property IDFotoReniec As Integer = -1
            Public Property IDFotoInterno As Integer = -1
            Public Property IDReniec As Integer = -1
            Public Property IDNombreAsociado As Integer = -1

            Public Property IDUsuarioModificacion As Integer = -1
            Public Property IDRegionOrigen As Short = -1
            Public Property IDPenalOrigen As Short = -1

            Public Property IDTemplateHuella As Integer = -1
            Public Property IDHuellaMeniqueIzq As Integer = -1
            Public Property IDHuellaAnularIzq As Integer = -1
            Public Property IDHuellaMedioIzq As Integer = -1
            Public Property IDHuellaIndiceIzq As Integer = -1
            Public Property IDHuellaPulgarIzq As Integer = -1
            Public Property IDHuellaMeniqueDer As Integer = -1
            Public Property IDHuellaAnularDer As Integer = -1
            Public Property IDHuellaMedioDer As Integer = -1
            Public Property IDHuellaIndiceDer As Integer = -1
            Public Property IDHuellaPulgarDer As Integer = -1

            Public Property FechaHoy As Long = 0
        End Class
#End Region
#Region "Validacion"
        Private Function ValidarTablasInterno(intIDRegion As Short, intIDPenal As Short, intIDInterno As Long, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim strSql As New System.Text.StringBuilder
            Dim strArrayTablaxRegul As New ArrayList

            With strSql
                .AppendLine("select 'INT_InternoNombreAsociado' as tabla,count(*) as cant from INT_InternoNombreAsociado where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'REG_DOC_InternoNombresAsociados' as tabla,count(*) as cant from REG_DOC_InternoNombresAsociados where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'REG_DOC_Judicial' as tabla,count(*) as cant from REG_DOC_Judicial  where _penid=@pen_id and int_id=@int_id and doc_tip_id =13 and int_id=@int_id")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoFoto' as tabla,count(*) as cant from INT_InternoFoto where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1 ")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoRasgo' as tabla,count(*) as cant from INT_InternoRasgo where _penid=@pen_id and int_id=@int_id and  isnull(int_ing_id,-1)<1 ")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoSenaParticular' as tabla,count(*) as cant from INT_InternoSenaParticular where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoRENIEC' as tabla,count(*) as cant from INT_InternoRENIEC where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoReniec_NomAsoc' as tabla,count(*) as cant from INT_InternoReniec_NomAsoc where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoAlias' as tabla,count(*) as cant from INT_InternoAlias where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'reg_mov_internobanda' as tabla,count(*) as cant from reg_mov_internobanda where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoBanda' as tabla,count(*) as cant from INT_InternoBanda where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoFamiliar' as tabla,count(*) as cant from INT_InternoFamiliar where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")
                .AppendLine(" union all ")
                .AppendLine("select 'INT_InternoIngreso' as tabla,count(*) as cant from INT_InternoIngreso where _penid=@pen_id and int_id=@int_id and isnull(int_ing_id,-1)<1")

            End With

            Dim objDT As New DataTable

            Try
                Dim sqlReader As SqlDataReader = Nothing

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql.ToString, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.Text
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = intIDPenal
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = intIDInterno

                            sqlCon.Open()
                            sqlReader = .ExecuteReader

                            objDT.Load(sqlReader)
                        End With
                    End Using
                End Using

                Dim blnRegxRegularizar As Boolean = False
                Dim intCantidad As Short = 0
                Dim strTabla As String = ""

                'preguntar si hay registros en el query enviado
                If objDT.Rows.Count > 0 Then

                    For Each fila As DataRow In objDT.Rows

                        strTabla = fila.Item("tabla").ToString
                        intCantidad = Integer.Parse(fila.Item("cant").ToString)

                        Select Case strTabla.ToUpper
                            Case "INT_InternoFoto".ToUpper

                                If intCantidad > 0 Then
                                    'regularizar los registros de la foto del interno 
                                    ARegularizarInternoFoto(intIDPenal, intIDInterno)
                                End If

                            Case Else

                                If intCantidad > 0 Then
                                    blnRegxRegularizar = True
                                    strArrayTablaxRegul.Add("Tabla: " & fila.Item("tabla").ToString & ", cantidad de registros (" & intCantidad & ")")
                                End If

                        End Select

                    Next

                    If blnRegxRegularizar = True Then
                        strMensajeOut = "Se han encontrado registros del interno por regularizar (id del interno: " & intIDInterno & "); " & Chr(13)

                        For Each Str As String In strArrayTablaxRegul
                            strMensajeOut = strMensajeOut & Chr(13) & Str
                        Next
                        strMensajeOut = strMensajeOut & Chr(13) & Chr(13) & "Contactese con el administrador del sistema."
                    Else
                        'si no hay ningun problema
                        value = True
                    End If

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
                strMensajeOut = ex.Message
                value = False
                Return value
            End Try

            Return value

        End Function
        Private Function ARegularizarInternoFoto(intIDPenal As Short, intIDInterno As Integer) As Boolean

            Dim value As Boolean = False

            Dim strSql As New System.Text.StringBuilder
            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDT As New DataTable

            '1.- consultar el ultimo ingreso del interno
            With strSql
                .AppendLine("select top 1 int_ing_id from int_internoingreso where _penid=" & intIDPenal)
                .AppendLine(" and int_id=" & intIDInterno)
                .AppendLine(" order by int_ing_nro desc, int_ing_fec desc")
            End With

            objDT = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql.ToString)

            Dim intIDIngresoID As Integer = -1

            For Each fila As DataRow In objDT.Rows
                intIDIngresoID = fila("int_ing_id").ToString
            Next

            'si el interno tiene un ingreso valido
            If intIDIngresoID > 0 Then

                '2.- listar los registro de fotos que no tengan ingreso_id, para realizar el update
                Dim strMensajeOut As String = ""
                strSql = New System.Text.StringBuilder
                sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                With strSql
                    .AppendLine("select int_fot_id,int_id,int_ing_id from INT_InternoFoto where _penid=" & intIDPenal)
                    .AppendLine(" and int_id=" & intIDInterno)
                    .AppendLine(" and isnull(int_ing_id,-1)<1 ")
                End With

                objDT = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql.ToString)

                For Each fila As DataRow In objDT.Rows

                    strSql = New System.Text.StringBuilder
                    With strSql
                        .AppendLine("update INT_InternoFoto set ")
                        .AppendLine(" int_ing_id=" & intIDIngresoID)
                        .AppendLine(" ,_flg_trf=1")
                        .AppendLine(" where int_id= " & intIDInterno)
                        .AppendLine(" and int_fot_id= " & fila("int_fot_id").ToString)
                    End With

                    sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    value = Legolas.Components.SQL.ExecuteBatchNonQuery(sqlcn, strSql.ToString, strMensajeOut)

                Next

            End If

            Return value

        End Function
#End Region
#Region "Proceso"
        Public Function RegularizarDatosInterno2(objEnt As Registro.InternoRegularizacion.Interno, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            'aqui se debe poner el codigo que une a la web service para regularizar la dat existente antigua
            Select Case objEnt.VersionRegistro.ToUpper

                Case "V5_P".ToUpper, ""
                    'version 5, se debe regularizar la data existente

                    '1.- validar el codigo rp del interno                     
                    Dim objBssInterno As New Bussines.Registro.Interno
                    value = objBssInterno.ValidarCodigoRP(objEnt.CodigoRP, objEnt.IDRegion, objEnt.IDPenal, strMensajeOut)

                    If value = False Then
                        Return value
                    End If

                    '2.- validar que las tablas involucradas tengan el ingreso_id 
                    value = ValidarTablasInterno(objEnt.IDRegion, objEnt.IDPenal, objEnt.IDInterno, strMensajeOut)

                    If value = False Then
                        Return value
                    End If

                    '3.- realizar la busqueda del identificador con la ws
                    value = False

                    If Legolas.Components.PC.IsOnline = True Then
                        strMensajeOut = "No se puede regularizar los datos del interno existente"
                    Else
                        'no hay conexion a la sede central
                        strMensajeOut = "No se puede realizar la operacion porque no se puede conectar el E.P. hacia la Sede Central (www.inpe.gob.pe)."
                    End If

                Case "V6_LM".ToUpper, "V6_RLM.ToUpper"
                    'el registro pasa sin ningun inconveniente
                    value = True
            End Select

            Return value
        End Function
        Public Function RegularizarDatosInterno(blnRevincular As Boolean, objEnt As Registro.InternoRegularizacion.Interno, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            'aqui se debe poner el codigo que une a la web service para regularizar la data existente antigua
            Select Case objEnt.VersionRegistro.ToUpper

                Case "V5_P".ToUpper, ""
                    'version 5, se debe regularizar la data existente

                    '0.- validar las variables llenas
                    If objEnt.IDInterno < 1 Or objEnt.IDRow < 1 Then
                        strMensajeOut = "El registro del interno no se puede leer. (IDInterno o ROWID <1)"
                        Return value
                    End If

                    '1.- validar el codigo rp del interno                     
                    Dim objBssInterno As New Bussines.Registro.Interno
                    value = objBssInterno.ValidarCodigoRP(objEnt.CodigoRP, objEnt.IDRegion, objEnt.IDPenal, strMensajeOut)

                    If value = False Then
                        Return value
                    End If

                    If blnRevincular = False Then
                        '2.- validar que las tablas involucradas tengan el ingreso_id 
                        value = ValidarTablasInterno(objEnt.IDRegion, objEnt.IDPenal, objEnt.IDInterno, strMensajeOut)

                        If value = False Then
                            Return value
                        End If
                    End If

                    '3.- realizar la busqueda del identificador con la ws
                    value = False

                    Dim blnCambioEstadoInterno As Boolean = False
                    If Legolas.Components.PC.IsOnline = True Then

                        Dim objDTO As New APPWebService.ws_pope_sede_plm_Interno.DTO_Interno
                        Dim objDTOIngreso As APPWebService.ws_pope_sede_plm_Interno.DTOInternoIngreso = Nothing

                        Dim objWs As New APPWebService.ws_pope_sede_plm_Interno.InternoSede
                        objWs.Timeout = 1000 * (60 * 5) '5 minutos de espera 
                        objWs.Url = APPWebService.PathURL.ws_sede_plm_Interno

                        With objDTO
                            .CodigoRP = objEnt.CodigoRP
                            .TipoDocumentoID = objEnt.IDTipoDocumento
                            .NumeroDocumento = objEnt.NumeroDocumento
                            .ApellidoPaterno = objEnt.PrimerApellido
                            .ApellidoMaterno = objEnt.SegundoApellido
                            .Nombres = objEnt.Nombres
                            .FechaNacimiento = objEnt.FechaNacimiento
                            .IDNacionalidad = objEnt.IDNacionalidad
                            .IDRow = objEnt.IDRow
                            .IDRegion = objEnt.IDRegion
                            .IDPenal = objEnt.IDPenal
                        End With

                        '3.?.- listar los ingresos del penal
                        Dim objBssIngresos As New Bussines.Registro.Ingreso
                        Dim objEntColIngresos As New Entity.Registro.IngresoCol

                        objEntColIngresos = objBssIngresos.listarIngresos_LM(objEnt.IDInterno, True)

                        Dim objDts As New APPWebService.ws_pope_sede_plm_Interno.DTO_ResultOfDataSet

                        If objEntColIngresos.Count > 0 Then

                            For Each fila As Entity.Registro.Ingreso In objEntColIngresos

                                objDTOIngreso = New APPWebService.ws_pope_sede_plm_Interno.DTOInternoIngreso

                                With objDTOIngreso
                                    .IDIngresoLocal = fila.Codigo
                                    .IDTipoMovimiento = fila.IDMovimientoTipo
                                    .IDMovimientoMotivo = fila.MotivoIngresoID
                                    .FechaISP = fila.FechaISP
                                    .FechaIngreso = fila.FechaIngreso
                                    .NumeroIngreso = fila.IngresoNro
                                    .Observacion = fila.Observacion
                                    .IDUsuarioCreacion = fila.Audit_IDUsuarioCreacion
                                    .IDUsuarioModificacion = fila.Audit_IDUsuarioModificacion
                                End With

                                objDTO.IngresoDto = objDTOIngreso
                                objDts = objWs.InternoPLM_Match(objDTO)

                                If objDts.Error_cod = 0 Then

                                    If objDts.Error_Mensaje.Length > 0 Then
                                        strMensajeOut = objDts.Error_Mensaje
                                    Else

                                        If objDts.Resultado Is Nothing Then
                                            'no hay datos
                                        Else
                                            value = Procesar_InternoDataset(objEnt.IDRegion, objEnt.IDPenal, objEnt.IDInterno, objEnt.IDRow,
                                                                            objDTOIngreso.IDIngresoLocal,
                                                                            objDts.Resultado, strMensajeOut)
                                            blnCambioEstadoInterno = True

                                            'verificar el procesamiento de la regularizacion del interno
                                            If value = False Then
                                                'Return value
                                                Exit For
                                            End If

                                        End If

                                    End If
                                Else
                                    strMensajeOut = objDts.Error_Mensaje
                                End If

                            Next

                        Else
                            'el interno seleccionado no tiene ningun ingreso

                            Try
                                objDTO.IngresoDto = Nothing 'solo el ingreso
                                objDts = objWs.InternoPLM_Match(objDTO)

                            Catch ex As WebException
                                strMensajeOut = ex.Message & Chr(13) & "URL:" & objWs.Url
                                Return False
                            End Try

                            If objDts.Error_cod = 0 Then

                                If objDts.Error_Mensaje.Length > 0 Then
                                    strMensajeOut = objDts.Error_Mensaje
                                Else

                                    value = Procesar_InternoDataset(objEnt.IDRegion, objEnt.IDPenal, objEnt.IDInterno, objEnt.IDRow,
                                                                    0, objDts.Resultado, strMensajeOut)
                                    blnCambioEstadoInterno = True

                                End If
                            Else
                                strMensajeOut = objDts.Error_Mensaje
                            End If

                        End If

                        'restablecer el estado original del interno                
                        If blnCambioEstadoInterno = True Then
                            If objEnt.InternoEstado = 0 Then 'estado baja
                                Dim bss As New Bussines.Registro.Interno
                                bss.ActivarEstado_LM(objEnt.IDInterno, 0) 'baja                                                                
                            End If
                        End If

                        'cambiar la version de registro del interno
                        If value = True Then

                            Dim intRegAfec As Integer = 0
                            Dim lngFecha As Long = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong

                            'reprocesar los registro del interno involucrada en el modulo visitas
                            Dim blnGraboDatos As Boolean = False
                            blnGraboDatos = GrabarInternoPenal(objEnt.IDInterno, objEnt.IDRegion, objEnt.IDPenal, objEnt.InternoEstado, strMensajeOut) 'alta/baja

                            If blnGraboDatos = False Then
                                Return False
                            End If

                            If strMensajeOut.Trim.Length > 1 Then
                                Return False
                            End If

                            'grabar el estado final
                            intRegAfec = GrabarVersionInterno(objEnt.IDInterno, lngFecha, strMensajeOut)

                            If intRegAfec < 1 Then
                                Return False
                            End If

                            If strMensajeOut.Trim.Length > 1 Then
                                Return False
                            End If

                        End If

                    Else
                        'no hay conexion a la sede central
                        strMensajeOut = "No se puede realizar la operacion porque no se puede conectar el E.P. hacia la Sede Central (www.inpe.gob.pe)."
                    End If

                Case "V6_LM".ToUpper, "V6_RLM".ToUpper
                    'el registro pasa sin ningun inconveniente
                    value = True
            End Select

            Return value
        End Function
        Private Function Procesar_InternoDataset(intIDRegionOrigen As Short, intIDPenalOrigen As Short, intIDInternoLocal As Integer, intInternoRowID As Integer,
                                                 intIDIngresoPenal As Integer,
                                                 objDTS As DataSet, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            '[zxpdown_carceleta_interno_datos]' actualizar**********************

            Dim lngFecha As Long = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong

            Dim intIDRegionInteSede As Short = -1
            Dim intIDPenalInteSede As Short = -1

            Dim intIDTablaLocal As Long = -1
            Dim strNombreTabla As String = ""
            Dim strColumnaTabla As String = ""
            Dim intRowIDTablaLocal As Long = -1
            Dim intRowIDTablaSede As Integer = -1

            Dim intCountRegAfectados As Integer = 0
            Dim blnProcesoData As Boolean = False
            Dim objDataTable As DataTable = Nothing
            Dim blnNuevo As Boolean = False

            Dim intIDIngresoInpeSede As Integer = -1
            Dim intIDIngresoSede As Integer = -1
            Dim objTabla As New DataTable

            For Each objTablaSC As DataTable In objDTS.Tables

                strNombreTabla = ""
                intIDIngresoInpeSede = -1
                intIDIngresoSede = -1

                objTabla = objTablaSC.Copy

                Select Case objTabla.TableName.ToUpper

                    Case "int_interno".ToUpper

                        blnProcesoData = False
                        objDataTable = Nothing

                        '1.- evaluar el penal de origen del interno para establecer la prioridad

                        intIDRegionInteSede = objTabla.Rows(0).Item("_regid").ToString
                        intIDPenalInteSede = objTabla.Rows(0).Item("_PenId").ToString
                        intRowIDTablaSede = objTabla.Rows(0).Item("_sed_rowid").ToString

                        If intIDPenalOrigen = intIDPenalInteSede Then
                            'prevalace la informacion del penal de origen
                            intCountRegAfectados = GrabarInterno(intIDInternoLocal, intRowIDTablaSede, strMensajeOut)

                            If intCountRegAfectados < 1 Then
                                'ocurrio un error
                                Return value
                            End If

                        Else
                            'prevalace la informacion de carceleta
                            blnProcesoData = InsertUpdate_Interno(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                  intIDInternoLocal, intInternoRowID, objTabla, objTabla.Rows(0), strMensajeOut)

                            If blnProcesoData = False Then
                                'ocurrio un error
                                Return value
                            End If

                        End If

                        If intIDPenalInteSede = intIDPenalOrigen Then
                            If intIDIngresoPenal < 1 Then
                                'no tiene ingresos, x lo tanto no hay mas que procesar. salir del bucle
                                Exit For
                            End If
                        End If

                    Case "int_mov_interno_ingreso_inpe".ToUpper

                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDIngresoLocal_Sede As Integer = -1
                            Dim intNumeroIngreso As Short = 0
                            Dim lngFechaIngresoInpe As Long = 0
                            Dim intFechaIngresoPenal As Long = 0

                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString
                            intIDIngresoInpeSede = fila.Item("pk_ing_inp_id").ToString
                            intIDIngresoLocal_Sede = Isnulll(fila.Item("_rowid_fk_int_ing_id").ToString, -1)

                            intNumeroIngreso = fila.Item("c_num_ing").ToString
                            lngFechaIngresoInpe = fila.Item("n_fec_ing_inp").ToString
                            intFechaIngresoPenal = fila.Item("n_fec_mov_ing").ToString

                            'limpiar                            
                            intIDTablaLocal = -1
                            blnProcesoData = False

                            If intIDPenalOrigen = intIDPenalInteSede Then

                                'prevalece el penal de origen
                                intIDTablaLocal = getIDIngresoInpexRegionPenalRowID(intIDPenalOrigen, intIDRegionInteSede, intIDIngresoInpeSede, intIDIngresoLocal_Sede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                blnProcesoData = InsertUpdate_IngresoInpe(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                          intIDTablaLocal, intIDInternoLocal, objTabla, fila, strMensajeOut)

                                If blnProcesoData = False Then
                                    'ocurrio error
                                    Return value
                                End If

                            Else
                                'prevalece carceleta

                                intIDTablaLocal = getIDTablaxRowIDSede("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", intIDIngresoInpeSede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                'solo update
                                blnProcesoData = InsertUpdate_IngresoInpe(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                          intIDTablaLocal, intIDInternoLocal, objTabla, fila, strMensajeOut)

                                If blnProcesoData = False Then
                                    'ocurrio error
                                    Return value
                                End If

                            End If

                            'grabar en la tabla internoingreso
                            If blnProcesoData = True Then

                                '1.- obtener el id del ingreso inpe local 
                                Dim intIDIngresoInpeLocal As Integer = -1
                                intIDIngresoInpeLocal = getIDTablaxRowIDSede("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", intIDIngresoInpeSede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                '2.- obtener el id local del la tabla ingreso 
                                'If intIDIngresoSedeLocal > 0 Then

                                Dim intIDIngresoInternoLocal As Integer = -1
                                intIDIngresoInternoLocal = getIDIngresoxIDIngresoInpeLocal(intIDInternoLocal, intIDIngresoLocal_Sede, intIDIngresoInpeLocal,
                                                                                           intNumeroIngreso, lngFechaIngresoInpe, 0, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                ''si no existe
                                'If intIDIngresoInternoLocal < 1 Then
                                '    strMensajeOut = "El IDIngresoLocal [" & intIDIngresoInternoLocal & "]del interno no existe. "
                                '    Return value
                                'End If

                                '/*ingreso del interno*/
                                Dim objEntIngreso As New Ingreso
                                With objEntIngreso
                                    .IDInterno = intIDInternoLocal
                                    .IDIngresoInpe = intIDIngresoInpeLocal
                                    '.IDIngreso = intIDIngresoSedeLocal
                                    .IDIngreso = intIDIngresoInternoLocal
                                    .NumeroIngreso = fila.Item("c_num_ing").ToString
                                    .FechaIngresoInpe = fila.Item("n_fec_ing_inp").ToString
                                    .FechaIngreso = fila.Item("n_fec_mov_ing").ToString
                                    .IDMovimientoTipo = fila.Item("fk_mov_tip_id").ToString
                                    .IDMovimientoMotivo = fila.Item("fk_ing_mot_id").ToString
                                    .Observacion = fila.Item("c_obs").ToString
                                    .IDRegion = intIDRegionInteSede
                                    'intIDPenalInteSede = intIDPenalOrigen
                                    .IDPenal = intIDPenalOrigen
                                    .IDUsuarioCreacion = fila.Item("_usu_cre").ToString
                                    .FechaCreacion = fila.Item("_fec_cre").ToString
                                    .IDUsuarioModificacion = fila.Item("_usu_mod").ToString
                                    .FechaModificacion = fila.Item("_fec_mod").ToString
                                    .Estado = 1
                                End With

                                intCountRegAfectados = GrabarInternoIngreso(objEntIngreso, strMensajeOut)

                                If intCountRegAfectados < 1 Then
                                    'ocurrio un error
                                    Return value
                                End If

                            End If

                        Next

                    Case "INT_InternoAlias".ToUpper,
                        "INT_InternoRasgo".ToUpper,
                        "INT_InternoSenaParticular".ToUpper,
                        "INT_InternoFamiliar".ToUpper,
                        "reg_mov_internobanda".ToUpper,
                        "INT_InternoNombreAsociado".ToUpper

                        'limpiar
                        intIDTablaLocal = -1
                        blnNuevo = False
                        blnProcesoData = False
                        intCountRegAfectados = 0
                        intIDIngresoInpeSede = -1

                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1
                            Dim intIDIngresoLocal As Integer = -1
                            intIDIngresoInpeSede = -1

                            strNombreTabla = fila.Item("tabla").ToString

                            If strNombreTabla.ToUpper = "REG_DOC_Judicial_Siscrico".ToUpper Then
                                strNombreTabla = "REG_DOC_Judicial"
                                objTabla.TableName = strNombreTabla
                            End If

                            strColumnaTabla = fila.Item("key_name").ToString
                            intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                            intIDIngresoInpeSede = fila.Item("fk_ing_inp_id").ToString
                            intIDIngresoInpeLocal = getIDTablaxRowIDSede("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", intIDIngresoInpeSede, strMensajeOut)

                            intIDIngresoLocal = getIDIngresoxIDIngresoInpeLocal(intIDIngresoInpeLocal, strMensajeOut)

                            If intIDIngresoLocal < 1 Then
                                strMensajeOut = "En la tabla " & strNombreTabla & ". El campo IDIngresoLocal, no existe para el campo IDIngresoINPE: " & intIDIngresoInpeLocal
                                Return value
                            End If

                            'limpiar
                            intIDTablaLocal = -1
                            blnNuevo = False
                            blnProcesoData = False
                            intCountRegAfectados = 0

                            If intIDIngresoInpeLocal < 1 Then
                                'ocurrio error
                                strMensajeOut = "El registro de la tabla: " & strNombreTabla & ", codigo local: " & intIDTablaLocal _
                                    & ". El campo IDIngresoInpeSede no existe en la tabla destino (IDRowSede-InteroIngresoInpe=" & intIDIngresoInpeSede & ")"
                                Return value
                            End If

                            If intIDPenalOrigen = intIDPenalInteSede Then

                                'prevalace la informacion del penal de origen
                                intIDTablaLocal = getIDTablaxRegionPenalRowID(strNombreTabla, strColumnaTabla, intIDPenalOrigen, intIDRegionInteSede, intRowIDTablaLocal,
                                                                              strMensajeOut)

                                If intIDTablaLocal < 1 Then
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio error
                                        Return value
                                    Else
                                        blnNuevo = True
                                    End If
                                End If

                                If blnNuevo = True Then
                                    blnProcesoData = InsertUpdate_Tabla3N(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                          intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                            objTabla, fila, strMensajeOut)
                                    If blnProcesoData = False Then
                                        'ocurrio error
                                        Return value
                                    End If

                                Else
                                    'update 
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                    intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha,
                                                                       intRowIDTablaSede, strMensajeOut)

                                    If intCountRegAfectados < 1 Then
                                        'ocurrio un error
                                        Return value
                                    End If
                                End If

                            Else
                                'prevalace la informacion de carceleta
                                intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                blnProcesoData = InsertUpdate_Tabla3N(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                      intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                      objTabla, fila,
                                                                      strMensajeOut)

                                If blnProcesoData = False Then
                                    'ocurrio error
                                    Return value
                                End If

                            End If

                        Next

                        'el sistema listar los regitros de las tablas locales sin ingreso inpe
                        strNombreTabla = objTabla.TableName
                        strColumnaTabla = Legolas.Components.SQL.getColumnIdentity(Legolas.Configuration.Data.ConexionIni,
                                                                                   strNombreTabla, strMensajeOut)
                        objDataTable = New DataTable
                        objDataTable = ListarTabla(strNombreTabla, intIDInternoLocal)

                        For Each fila As DataRow In objDataTable.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1

                            intIDTablaLocal = fila.Item(strColumnaTabla).ToString
                            intIDIngresoInpeLocal = getIDIngresoInpexIDIngreso(fila.Item("int_ing_id").ToString, intIDInternoLocal, strMensajeOut)

                            'muestra el error cuando no hay un ingreso que no corresponde
                            If intIDIngresoInpeLocal < 1 Then
                                strMensajeOut = "El registro de la tabla: " & strNombreTabla & ", codigo local: " & intIDTablaLocal & ". El campo IDIngresoInpe no existe en la tabla local."
                                Return value
                            End If

                            'limpiar                                                                                    
                            intCountRegAfectados = 0

                            '/*proceso*/
                            intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha, -1, strMensajeOut)

                            If intCountRegAfectados < 1 Then
                                'ocurrio un error
                                Return value
                            End If
                        Next

                    Case "INT_InternoBanda".ToUpper

                        Dim intIDDocumentoCreacion As Integer = -1
                        Dim intIDDocumentoAnulacion As Integer = -1
                        Dim intIDDocCreaLocal As Integer = -1
                        Dim intIDDocAnuLocal As Integer = -1

                        'limpiar
                        intIDTablaLocal = -1
                        blnNuevo = False
                        blnProcesoData = False
                        intCountRegAfectados = 0

                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1
                            Dim intIDIngresoLocal As Integer = -1

                            strNombreTabla = fila.Item("tabla").ToString
                            strColumnaTabla = fila.Item("key_name").ToString
                            intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                            intIDIngresoInpeSede = fila.Item("fk_ing_inp_id").ToString
                            intIDIngresoInpeLocal = getIDTablaxRowIDSede("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", intIDIngresoInpeSede, strMensajeOut) 'getIDIngresoInpe(intIDIngresoInpeSede, strMensajeOut)
                            intIDIngresoLocal = getIDIngresoxIDIngresoInpeLocal(intIDIngresoInpeLocal, strMensajeOut)

                            'documento de creacion
                            intIDDocumentoCreacion = fila.Item("crea_doc_jud_id").ToString
                            intIDDocCreaLocal = getIDTablaxRowIDSede("REG_DOC_Judicial", "doc_jud_id", intIDDocumentoCreacion, strMensajeOut)

                            'documento de anulacion
                            intIDDocumentoAnulacion = fila.Item("anul_doc_jud_id").ToString
                            intIDDocAnuLocal = getIDTablaxRowIDSede("REG_DOC_Judicial", "doc_jud_id", intIDDocumentoAnulacion, strMensajeOut)

                            'limpiar
                            intIDTablaLocal = -1
                            blnNuevo = False
                            blnProcesoData = False
                            intCountRegAfectados = 0

                            If intIDIngresoInpeLocal < 1 Then
                                'ocurrio error
                                strMensajeOut = "El registro de la tabla: " & strNombreTabla & ", codigo local: " & intIDTablaLocal _
                                    & ". El campo IDIngresoInpeSede no existe en la tabla destino (IDRowSede-InteroIngresoInpe=" & intIDIngresoInpeSede & ")"
                                Return value
                            End If

                            If intIDPenalOrigen = intIDPenalInteSede Then

                                'prevalace la informacion del penal de origen
                                intIDTablaLocal = getIDTablaxRegionPenalRowID(strNombreTabla, strColumnaTabla, intIDPenalOrigen, intIDRegionInteSede, intRowIDTablaLocal,
                                                                              strMensajeOut)

                                If intIDTablaLocal < 1 Then
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio error
                                        Return value
                                    Else
                                        blnNuevo = True
                                    End If
                                End If

                                If blnNuevo = True Then

                                    blnProcesoData = InsertUpdate_InternoBanda(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                               intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                           intIDDocCreaLocal, intIDDocAnuLocal,
                                                                     objTabla, fila, strMensajeOut)

                                    If blnProcesoData = False Then
                                        'ocurrio error
                                        Return value
                                    End If

                                Else
                                    'update 
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                    intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha,
                                                                       intRowIDTablaSede, strMensajeOut)

                                    If intCountRegAfectados < 1 Then
                                        'ocurrio un error
                                        Return value
                                    End If
                                End If

                            Else
                                'prevalace la informacion de carceleta
                                intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                blnProcesoData = InsertUpdate_InternoBanda(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                           intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                             intIDDocCreaLocal, intIDDocAnuLocal,
                                                                       objTabla, fila, strMensajeOut)

                                If blnProcesoData = False Then
                                    'ocurrio error
                                    Return value
                                End If

                            End If

                        Next

                        'el sistema listar los regitros de las tablas locales sin ingreso inpe
                        strNombreTabla = objTabla.TableName
                        strColumnaTabla = Legolas.Components.SQL.getColumnIdentity(Legolas.Configuration.Data.ConexionIni,
                                                                                   strNombreTabla, strMensajeOut)
                        objDataTable = New DataTable
                        objDataTable = ListarTabla(strNombreTabla, intIDInternoLocal)

                        For Each fila As DataRow In objDataTable.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1

                            intIDTablaLocal = fila.Item(strColumnaTabla).ToString
                            intIDIngresoInpeLocal = getIDIngresoInpexIDIngreso(fila.Item("int_ing_id").ToString, intIDInternoLocal, strMensajeOut)
                            'limpiar                                                                                    
                            intCountRegAfectados = 0

                            '/*proceso*/
                            intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha, -1, strMensajeOut)

                            If intCountRegAfectados < 1 Then
                                'ocurrio un error
                                Return value
                            End If
                        Next

                    Case "int_mov_interno_domicilio".ToUpper,
                        "int_mov_interno_idioma".ToUpper,
                        "int_mov_interno_grado_ins".ToUpper,
                        "int_mov_interno_odontograma".ToUpper

                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1
                            Dim intIDIngresoLocal As Integer = -1

                            strNombreTabla = fila.Item("tabla").ToString
                            strColumnaTabla = fila.Item("key_name").ToString
                            intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                            intIDIngresoInpeSede = fila.Item("fk_ing_inp_id").ToString
                            intIDIngresoInpeLocal = getIDTablaxRowIDSede("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", intIDIngresoInpeSede, strMensajeOut) 'getIDIngresoInpe(intIDIngresoInpeSede, strMensajeOut)
                            intIDIngresoLocal = getIDIngresoxIDIngresoInpeLocal(intIDIngresoInpeLocal, strMensajeOut)

                            If intIDIngresoLocal < 1 Then
                                strMensajeOut = "La tabla " & strNombreTabla & ". El campo IDIngresoLocal, no existe para el campo IDIngresoINPE: " & intIDIngresoInpeLocal
                                Return value
                            End If

                            'limpiar
                            intIDTablaLocal = -1
                            blnProcesoData = False

                            If intIDIngresoInpeLocal < 1 Then
                                'ocurrio error
                                strMensajeOut = "El registro de la tabla: " & strNombreTabla & ", codigo local: " & intIDTablaLocal _
                                    & ". El campo IDIngresoInpeSede no existe en la tabla destino (IDRowSede-InteroIngresoInpe=" & intIDIngresoInpeSede & ")"
                                Return value
                            End If

                            'prevalace la informacion de carceleta, por ser tablas nuevas
                            intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                            If strMensajeOut.Trim.Length > 0 Then
                                'ocurrio un error
                                Return value
                            End If

                            blnProcesoData = InsertUpdate_Tabla3N(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                  intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                  objTabla, fila,
                                                                  strMensajeOut)

                            If blnProcesoData = False Then
                                'ocurrio error
                                Return value
                            End If

                        Next

                    Case "glo_mov_arch_digitalizado_odontograma".ToUpper

                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDInternoOdontograma As Integer = -1
                            strNombreTabla = fila.Item("tabla").ToString
                            strColumnaTabla = fila.Item("key_name").ToString
                            intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                            If IsDBNull(fila.Item("b_arch_dig_byte")) = True Then

                                'si es nulo se se proceso el archivo del odontograma
                            Else

                                Dim objByteArchivo As Byte() = fila.Item("b_arch_dig_byte")

                                'el archivo digitalizado debe tener contenido
                                If objByteArchivo.Length > 0 Then

                                    'id interno odontograma
                                    intIDInternoOdontograma = fila.Item("fk_reg_tbl_id").ToString
                                    intIDInternoOdontograma = getIDTablaxRowIDSede("int_mov_interno_odontograma", "pk_int_odn_id", intIDInternoOdontograma, strMensajeOut)

                                    'limpiar
                                    intIDTablaLocal = -1
                                    blnProcesoData = False

                                    'prevalace la informacion de carceleta, por ser tablas nuevas
                                    intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                    objTabla.TableName = strNombreTabla
                                    blnProcesoData = InsertUpdate_ArchivoDigitalOdontograma(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                          intIDTablaLocal, intIDInternoOdontograma, objTabla, fila,
                                                                          strMensajeOut)

                                    If blnProcesoData = False Then
                                        'ocurrio error
                                        Return value
                                    End If

                                End If

                            End If

                        Next

                    Case "GLO_ArchivoDigital_Interno".ToUpper,
                        "GLO_ArchivoDigital_Reniec".ToUpper

                        'limpiar
                        intIDTablaLocal = -1
                        blnNuevo = False
                        blnProcesoData = False
                        intCountRegAfectados = 0

                        '1.- procesar los registros de la nube
                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDRegistroTabla As Integer = -1
                            Dim intTipoArchivo As Short = -1

                            strNombreTabla = fila.Item("tabla").ToString
                            strColumnaTabla = fila.Item("key_name").ToString
                            intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString
                            intTipoArchivo = fila.Item("arc_dig_tip").ToString

                            'id local de la tabla origen
                            intIDRegistroTabla = fila.Item("int_id").ToString

                            If intTipoArchivo = 1 Then
                                intIDRegistroTabla = getIDTablaxRowIDSede("int_interno", "int_id", intIDRegistroTabla, strMensajeOut)
                            Else
                                intIDRegistroTabla = getIDTablaxRowIDSede("INT_InternoRENIEC", "int_rnc_id", intIDRegistroTabla, strMensajeOut)
                            End If

                            'limpiar
                            intIDTablaLocal = -1
                            blnNuevo = False
                            blnProcesoData = False
                            intCountRegAfectados = 0

                            If intIDPenalOrigen = intIDPenalInteSede Then

                                'prevalace la informacion del penal de origen
                                intIDTablaLocal = getIDTablaxRegionPenalRowID(strNombreTabla, strColumnaTabla, intIDPenalOrigen, intIDRegionInteSede, intRowIDTablaLocal,
                                                                              strMensajeOut)

                                If intIDTablaLocal < 1 Then
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio error
                                        Return value
                                    Else
                                        blnNuevo = True
                                    End If
                                End If

                                If blnNuevo = True Then

                                    objTabla.TableName = "GLO_ArchivoDigital"
                                    blnProcesoData = InsertUpdate_ArchivoDigital(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                                 intIDTablaLocal,
                                                                                 intIDRegistroTabla, objTabla, fila, strMensajeOut)
                                    If blnProcesoData = False Then

                                        'ocurrio error
                                        Return value
                                    End If

                                Else
                                    'update 
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                    intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, -1, lngFecha,
                                                                       intRowIDTablaSede, strMensajeOut, False)

                                    If intCountRegAfectados < 1 Then
                                        'ocurrio un error
                                        Return value
                                    End If
                                End If

                                'descargar foto al penal destino
                                Dim objFoto As Byte() = Nothing
                                objFoto = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(fila.Item("_sed_rowid").ToString,
                                                                                                          intTipoArchivo,
                                                                                                          strMensajeOut, True)
                                If objFoto Is Nothing Then
                                    'nada
                                Else

                                    Dim blnSubiFoto As Boolean = False

                                    If fila.Item("arc_dig_pth_ser").ToString.Length > 0 Then

                                        blnSubiFoto = APPWebService.Fotografia.SubirFotoByte_v2(objFoto,
                                                                                  fila.Item("arc_dig_nom_fis").ToString,
                                                                                  fila.Item("arc_dig_ext"),
                                                                                  fila.Item("arc_dig_pth_ser"),
                                                                                  intTipoArchivo,
                                                                                  strMensajeOut)

                                        If strMensajeOut.Trim.Length > 0 Then
                                            Return value
                                        End If

                                        If blnSubiFoto = False Then
                                            strMensajeOut = "No se pudo descargar el archivo digital de la tabla: " & strNombreTabla & ", con el _sedrowid =" & intRowIDTablaSede
                                            Return value
                                        End If

                                    End If

                                End If

                            Else
                                'prevalace la informacion de carceleta
                                intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                objTabla.TableName = "GLO_ArchivoDigital"
                                blnProcesoData = InsertUpdate_ArchivoDigital(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                             intIDTablaLocal, intIDRegistroTabla, objTabla, fila, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                If blnProcesoData = False Then
                                    'ocurrio error
                                    Return value
                                End If

                                'descargar foto al penal destino
                                Dim objFoto As Byte() = Nothing
                                objFoto = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(fila.Item("_sed_rowid").ToString,
                                                                                                          intTipoArchivo,
                                                                                                          strMensajeOut, True)
                                If objFoto Is Nothing Then
                                    'nada
                                Else

                                    'si el tamaño de la foto es mayor a cero
                                    If objFoto.Length > 0 Then

                                        Dim blnSubiFoto As Boolean = False
                                        If fila.Item("arc_dig_pth_ser").ToString.Length > 0 Then

                                            blnSubiFoto = APPWebService.Fotografia.SubirFotoByte_v2(objFoto,
                                                                                      fila.Item("arc_dig_nom_fis").ToString,
                                                                                      fila.Item("arc_dig_ext"),
                                                                                      fila.Item("arc_dig_pth_ser"),
                                                                                      intTipoArchivo,
                                                                                      strMensajeOut)

                                            If strMensajeOut.Trim.Length > 0 Then
                                                Return value
                                            End If

                                            If blnSubiFoto = False Then
                                                strMensajeOut = "No se pudo descargar el archivo digital de la tabla: " & strNombreTabla & ", con el _sedrowid =" & intRowIDTablaSede
                                                Return value
                                            End If

                                        End If
                                    End If

                                End If

                            End If

                        Next

                        '2.- listar los registros de la tabla sin rowidsede
                        strNombreTabla = "GLO_ArchivoDigital"
                        Select Case objTabla.TableName.ToUpper

                            Case "GLO_ArchivoDigital_Interno".ToUpper

                                strColumnaTabla = Legolas.Components.SQL.getColumnIdentity(Legolas.Configuration.Data.ConexionIni,
                                                                                           strNombreTabla, strMensajeOut)
                                objDataTable = New DataTable
                                objDataTable = Listar_ArchivoDigital(objTabla.TableName.ToUpper, intIDInternoLocal)

                                For Each fila As DataRow In objDataTable.Rows
                                    intIDTablaLocal = fila.Item(strColumnaTabla).ToString
                                    'limpiar                                                                                    
                                    intCountRegAfectados = 0

                                    '/*proceso*/
                                    intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, -1, lngFecha, -1, strMensajeOut, False)

                                    If intCountRegAfectados < 1 Then
                                        'ocurrio un error
                                        Return value
                                    End If
                                Next

                            Case "GLO_ArchivoDigital_Reniec".ToUpper

                                objDataTable = New DataTable
                                objDataTable = Listar_InternoReniec(intIDInternoLocal)

                                For Each fila As DataRow In objDataTable.Rows
                                    Dim intIDReniec As Integer = -1

                                    intIDReniec = fila.Item("int_rnc_id").ToString

                                    Dim objDataTable2 = New DataTable
                                    objDataTable2 = Listar_ArchivoDigital(strNombreTabla, intIDReniec)

                                    For Each fila2 As DataRow In objDataTable2.Rows
                                        intIDTablaLocal = fila2.Item(strColumnaTabla).ToString
                                        'limpiar                                                                                    
                                        intCountRegAfectados = 0

                                        '/*proceso*/
                                        intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, -1, lngFecha, -1, strMensajeOut, False)

                                        If intCountRegAfectados < 1 Then
                                            'ocurrio un error
                                            Return value
                                        End If
                                    Next
                                Next

                        End Select

                    Case "INT_InternoFoto".ToUpper

                        Dim intIDFotoIzqSede As Integer = -1
                        Dim intIDFotoFrenteSede As Integer = -1
                        Dim intIDFotoDerSede As Integer = -1

                        Dim intIDFotoIzqLocal As Integer = -1
                        Dim intIDFotoFrenteLocal As Integer = -1
                        Dim intIDFotoDerLocal As Integer = -1

                        'limpiar
                        intIDTablaLocal = -1
                        blnNuevo = False
                        blnProcesoData = False
                        intCountRegAfectados = 0

                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1
                            Dim intIDIngresoLocal As Integer = -1

                            strNombreTabla = fila.Item("tabla").ToString
                            strColumnaTabla = fila.Item("key_name").ToString
                            intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                            intIDIngresoInpeSede = fila.Item("fk_ing_inp_id").ToString
                            intIDIngresoInpeLocal = getIDTablaxRowIDSede("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", intIDIngresoInpeSede, strMensajeOut) 'getIDIngresoInpe(intIDIngresoInpeSede, strMensajeOut)
                            intIDIngresoLocal = getIDIngresoxIDIngresoInpeLocal(intIDIngresoInpeLocal, strMensajeOut)

                            'si el interno ingreso del interno es menor a cero, salir.
                            If intIDIngresoLocal < 1 Then
                                strMensajeOut = "La tabla " & strNombreTabla & ", SedeRoWID: " & intRowIDTablaSede & ". El campo IDIngresoLocal, no existe para el campo IDIngresoINPE: " & intIDIngresoInpeLocal
                                Return value
                            End If

                            'foto izquierda
                            intIDFotoIzqSede = fila.Item("int_fot_per_izq").ToString

                            If intIDFotoIzqSede > 0 Then
                                intIDFotoIzqLocal = getIDTablaxRowIDSede("GLO_ArchivoDigital", "arc_dig_id", intIDFotoIzqSede, strMensajeOut)
                            End If

                            'foto frente
                            intIDFotoFrenteSede = fila.Item("int_fot_per_fre").ToString
                            If intIDFotoFrenteSede > 0 Then
                                intIDFotoFrenteLocal = getIDTablaxRowIDSede("GLO_ArchivoDigital", "arc_dig_id", intIDFotoFrenteSede, strMensajeOut)
                            End If

                            'foto derecha
                            intIDFotoDerSede = fila.Item("int_fot_per_der").ToString
                            If intIDFotoDerSede > 0 Then
                                intIDFotoDerLocal = getIDTablaxRowIDSede("GLO_ArchivoDigital", "arc_dig_id", intIDFotoDerSede, strMensajeOut)
                            End If

                            'limpiar
                            intIDTablaLocal = -1
                            blnNuevo = False
                            blnProcesoData = False
                            intCountRegAfectados = 0

                            If intIDIngresoInpeLocal < 1 Then
                                'ocurrio error
                                strMensajeOut = "El registro de la tabla: " & strNombreTabla & ", codigo local: " & intIDTablaLocal _
                                    & ". El campo IDIngresoInpeSede no existe en la tabla destino (IDRowSede-InteroIngresoInpe=" & intIDIngresoInpeSede & ")"
                                Return value
                            End If

                            If intIDPenalOrigen = intIDPenalInteSede Then

                                'prevalace la informacion del penal de origen
                                intIDTablaLocal = getIDTablaxRegionPenalRowID(strNombreTabla, strColumnaTabla, intIDPenalOrigen, intIDRegionInteSede, intRowIDTablaLocal,
                                                                              strMensajeOut)

                                If intIDTablaLocal < 1 Then
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio error
                                        Return value
                                    Else
                                        blnNuevo = True
                                    End If
                                End If

                                If blnNuevo = True Then
                                    blnProcesoData = InsertUpdate_InternoFoto(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                              intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                              intIDFotoIzqLocal, intIDFotoFrenteLocal, intIDFotoDerLocal,
                                                                            objTabla, fila, strMensajeOut)
                                    If blnProcesoData = False Then
                                        'ocurrio error
                                        Return value
                                    End If

                                Else
                                    'update 
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                    intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha,
                                                                       intRowIDTablaSede, strMensajeOut)

                                    If intCountRegAfectados < 1 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                    'actualizar la tabla interno con los perfiles de la fotografia
                                    GrabarInterno_Fotografia(intIDInternoLocal, intIDFotoIzqLocal, intIDFotoFrenteLocal, intIDFotoDerLocal, strMensajeOut)

                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                End If

                            Else
                                'prevalace la informacion de carceleta
                                intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                blnProcesoData = InsertUpdate_InternoFoto(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                          intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                                intIDFotoIzqLocal, intIDFotoFrenteLocal, intIDFotoDerLocal,
                                                                              objTabla, fila, strMensajeOut)

                                If blnProcesoData = False Then
                                    'ocurrio error
                                    Return value
                                End If

                            End If

                        Next

                        'el sistema listar los regitros de las tablas locales sin ingreso inpe
                        strNombreTabla = objTabla.TableName
                        strColumnaTabla = Legolas.Components.SQL.getColumnIdentity(Legolas.Configuration.Data.ConexionIni,
                                                                                   strNombreTabla, strMensajeOut)
                        objDataTable = New DataTable
                        objDataTable = ListarTabla(strNombreTabla, intIDInternoLocal)

                        If Not objDataTable Is Nothing Then

                            For Each fila As DataRow In objDataTable.Rows

                                'no debe regularizar las fotos que se estan revinculando x la otro app
                                If fila.Item("_hostname").ToString.ToLower <> "RE_VIN_FOTO".ToLower Then

                                    Dim intIDIngresoInpeLocal As Integer = -1

                                    intIDTablaLocal = fila.Item(strColumnaTabla).ToString
                                    intIDIngresoInpeLocal = getIDIngresoInpexIDIngreso(fila.Item("int_ing_id").ToString, intIDInternoLocal, strMensajeOut)

                                    If intIDIngresoInpeLocal < 1 Then
                                        'ocurrio error
                                        strMensajeOut = "El registro de la tabla: " & strNombreTabla & ", codigo local: " & intIDTablaLocal _
                                            & ". El campo IDIngresoInpeLocal no existe en la tabla destino, relacionado con el IDInternoIngreso: " & fila.Item("int_ing_id").ToString
                                        Return value
                                    End If

                                    'limpiar                                                                                    
                                    intCountRegAfectados = 0

                                    '/*proceso*/
                                    intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha, -1, strMensajeOut)

                                    If intCountRegAfectados < 1 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                End If

                            Next

                        End If

                    Case "INT_InternoRENIEC".ToUpper

                        Dim intIDFotoReniec As Integer = -1
                        Dim intIDFotoReniecLocal As Integer = -1

                        Dim intIDFotoInterno As Integer = -1
                        Dim intIDFotoInternoLocal As Integer = -1

                        'limpiar
                        intIDTablaLocal = -1
                        blnNuevo = False
                        blnProcesoData = False
                        intCountRegAfectados = 0

                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1
                            Dim intIDIngresoLocal As Integer = -1

                            strNombreTabla = fila.Item("tabla").ToString
                            strColumnaTabla = fila.Item("key_name").ToString
                            intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                            intIDIngresoInpeSede = fila.Item("fk_ing_inp_id").ToString
                            intIDIngresoInpeLocal = getIDTablaxRowIDSede("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", intIDIngresoInpeSede, strMensajeOut) 'getIDIngresoInpe(intIDIngresoInpeSede, strMensajeOut)
                            intIDIngresoLocal = getIDIngresoxIDIngresoInpeLocal(intIDIngresoInpeLocal, strMensajeOut)

                            'foto reniec
                            intIDFotoReniec = fila.Item("fot_rnc").ToString

                            If intIDFotoReniec < 0 Then
                                intIDFotoReniecLocal = -1
                            Else
                                intIDFotoReniecLocal = getIDTablaxRowIDSede("GLO_ArchivoDigital", "arc_dig_id", intIDFotoReniec, strMensajeOut)
                            End If

                            'foto interno
                            intIDFotoInterno = fila.Item("fot_int").ToString

                            If intIDFotoInterno < 0 Then
                                intIDFotoInternoLocal = -1
                            Else
                                intIDFotoInternoLocal = getIDTablaxRowIDSede("GLO_ArchivoDigital", "arc_dig_id", intIDFotoInterno, strMensajeOut)
                            End If

                            'limpiar
                            intIDTablaLocal = -1
                            blnNuevo = False
                            blnProcesoData = False
                            intCountRegAfectados = 0

                            If intIDIngresoInpeLocal < 1 Then
                                'ocurrio error
                                strMensajeOut = "El registro de la tabla: " & strNombreTabla & ", codigo local: " & intIDTablaLocal _
                                    & ". El campo IDIngresoInpeSede no existe en la tabla destino (IDRowSede-InteroIngresoInpe=" & intIDIngresoInpeSede & ")"
                                Return value
                            End If

                            If intIDPenalOrigen = intIDPenalInteSede Then

                                'prevalace la informacion del penal de origen
                                intIDTablaLocal = getIDTablaxRegionPenalRowID(strNombreTabla, strColumnaTabla, intIDPenalOrigen, intIDRegionInteSede, intRowIDTablaLocal,
                                                                              strMensajeOut)

                                If intIDTablaLocal < 1 Then
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio error
                                        Return value
                                    Else
                                        blnNuevo = True
                                    End If
                                End If

                                If blnNuevo = True Then
                                    blnProcesoData = InsertUpdate_InternoRENIEC(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                                intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                              intIDFotoReniecLocal, intIDFotoInternoLocal,
                                                                              objTabla, fila, strMensajeOut)
                                    If blnProcesoData = False Then
                                        'ocurrio error
                                        Return value
                                    End If

                                Else
                                    'update 
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                    intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha,
                                                                       intRowIDTablaSede, strMensajeOut)

                                    If intCountRegAfectados < 1 Then
                                        'ocurrio un error
                                        Return value
                                    End If
                                End If

                            Else
                                'prevalace la informacion de carceleta
                                intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                blnProcesoData = InsertUpdate_InternoRENIEC(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                            intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                          intIDFotoReniecLocal, intIDFotoInternoLocal,
                                                                          objTabla, fila, strMensajeOut)
                                If blnProcesoData = False Then
                                    'ocurrio error
                                    Return value
                                End If

                            End If

                        Next

                        'el sistema listar los regitros de las tablas locales sin ingreso inpe
                        strNombreTabla = objTabla.TableName
                        strColumnaTabla = Legolas.Components.SQL.getColumnIdentity(Legolas.Configuration.Data.ConexionIni,
                                                                                   strNombreTabla, strMensajeOut)
                        objDataTable = New DataTable
                        objDataTable = ListarTabla(strNombreTabla, intIDInternoLocal)

                        For Each fila As DataRow In objDataTable.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1

                            intIDTablaLocal = fila.Item(strColumnaTabla).ToString
                            intIDIngresoInpeLocal = getIDIngresoInpexIDIngreso(fila.Item("int_ing_id").ToString, intIDInternoLocal, strMensajeOut)
                            'limpiar                                                                                    
                            intCountRegAfectados = 0

                            '/*proceso*/
                            intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha, -1, strMensajeOut)

                            If intCountRegAfectados < 1 Then
                                'ocurrio un error
                                Return value
                            End If
                        Next

                    Case "INT_InternoReniec_NomAsoc".ToUpper

                        Dim intIDReniec As Integer = -1
                        Dim intIDReniecLocal As Integer = -1

                        Dim intIDNombreAsoc As Integer = -1
                        Dim intIDNombreAsocLocal As Integer = -1

                        'limpiar
                        intIDTablaLocal = -1
                        blnNuevo = False
                        blnProcesoData = False
                        intCountRegAfectados = 0

                        For Each fila As DataRow In objTabla.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1
                            Dim intIDIngresoLocal As Integer = -1

                            strNombreTabla = fila.Item("tabla").ToString
                            strColumnaTabla = fila.Item("key_name").ToString
                            intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                            intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                            intIDIngresoInpeSede = fila.Item("fk_ing_inp_id").ToString
                            intIDIngresoInpeLocal = getIDTablaxRowIDSede("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", intIDIngresoInpeSede, strMensajeOut) 'getIDIngresoInpe(intIDIngresoInpeSede, strMensajeOut)
                            intIDIngresoLocal = getIDIngresoxIDIngresoInpeLocal(intIDIngresoInpeLocal, strMensajeOut)

                            'interno reniec
                            intIDReniec = fila.Item("n_fk_int_rnc_id").ToString
                            intIDReniecLocal = getIDTablaxRowIDSede("INT_InternoRENIEC", "int_rnc_id", intIDReniec, strMensajeOut)

                            'nombre asociado
                            intIDNombreAsoc = fila.Item("n_fk_int_aso_id").ToString
                            intIDNombreAsocLocal = getIDTablaxRowIDSede("INT_InternoNombreAsociado", "int_aso_id", intIDNombreAsoc, strMensajeOut)

                            'limpiar
                            intIDTablaLocal = -1
                            blnNuevo = False
                            blnProcesoData = False
                            intCountRegAfectados = 0

                            If intIDIngresoInpeLocal < 1 Then
                                'ocurrio error
                                strMensajeOut = "El registro de la tabla: " & strNombreTabla & ", codigo local: " & intIDTablaLocal _
                                    & ". El campo IDIngresoInpeSede no existe en la tabla destino (IDRowSede-InteroIngresoInpe=" & intIDIngresoInpeSede & ")"
                                Return value
                            End If

                            If intIDPenalOrigen = intIDPenalInteSede Then

                                'prevalace la informacion del penal de origen
                                intIDTablaLocal = getIDTablaxRegionPenalRowID(strNombreTabla, strColumnaTabla, intIDPenalOrigen, intIDRegionInteSede, intRowIDTablaLocal,
                                                                              strMensajeOut)

                                If intIDTablaLocal < 1 Then
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio error
                                        Return value
                                    Else
                                        blnNuevo = True
                                    End If
                                End If

                                If blnNuevo = True Then
                                    blnProcesoData = InsertUpdate_InternoReniecNombreAsoc(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                                          intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                              intIDReniecLocal, intIDNombreAsocLocal,
                                                                              objTabla, fila, strMensajeOut)
                                    If blnProcesoData = False Then
                                        'ocurrio error
                                        Return value
                                    End If

                                Else
                                    'update 
                                    If strMensajeOut.Trim.Length > 0 Then
                                        'ocurrio un error
                                        Return value
                                    End If

                                    intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha,
                                                                       intRowIDTablaSede, strMensajeOut)

                                    If intCountRegAfectados < 1 Then
                                        'ocurrio un error
                                        Return value
                                    End If
                                End If

                            Else
                                'prevalace la informacion de carceleta
                                intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                                If strMensajeOut.Trim.Length > 0 Then
                                    'ocurrio un error
                                    Return value
                                End If

                                blnProcesoData = InsertUpdate_InternoReniecNombreAsoc(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                                      intIDTablaLocal, intIDInternoLocal, intIDIngresoInpeLocal, intIDIngresoLocal,
                                                                               intIDReniecLocal, intIDNombreAsocLocal,
                                                                               objTabla, fila, strMensajeOut)
                                If blnProcesoData = False Then
                                    'ocurrio error
                                    Return value
                                End If

                            End If

                        Next

                        'el sistema listar los regitros de las tablas locales sin ingreso inpe
                        strNombreTabla = objTabla.TableName
                        strColumnaTabla = Legolas.Components.SQL.getColumnIdentity(Legolas.Configuration.Data.ConexionIni,
                                                                                   strNombreTabla, strMensajeOut)
                        objDataTable = New DataTable
                        objDataTable = ListarTabla(strNombreTabla, intIDInternoLocal)

                        For Each fila As DataRow In objDataTable.Rows

                            Dim intIDIngresoInpeLocal As Integer = -1

                            intIDTablaLocal = fila.Item(strColumnaTabla).ToString
                            intIDIngresoInpeLocal = getIDIngresoInpexIDIngreso(fila.Item("int_ing_id").ToString, intIDInternoLocal, strMensajeOut)
                            'limpiar                                                                                    
                            intCountRegAfectados = 0

                            '/*proceso*/
                            intCountRegAfectados = UpdateTabla(strNombreTabla, strColumnaTabla, intIDTablaLocal, intIDIngresoInpeLocal, lngFecha, -1, strMensajeOut)

                            If intCountRegAfectados < 1 Then
                                'ocurrio un error
                                Return value
                            End If
                        Next

                    Case Else

                End Select
            Next

            '1.- tabla template de la bd huella
            objTabla = New DataTable
            objTabla = objDTS.Tables("mov_template_huella")

            'hay registros del interno
            If Not objTabla Is Nothing Then

                For Each fila As DataRow In objTabla.Rows

                    strNombreTabla = fila.Item("tabla").ToString
                    strColumnaTabla = fila.Item("key_name").ToString
                    intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                    intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                    If IsDBNull(fila.Item("tmp_ansi")) = True Then
                        fila.Item("tmp_ansi") = 0
                    End If

                    'limpiar
                    intIDTablaLocal = -1
                    blnProcesoData = False

                    'prevalace la informacion de carceleta, por ser tablas nuevas
                    intIDTablaLocal = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                    If strMensajeOut.Trim.Length > 0 Then
                        'ocurrio un error
                        Return value
                    End If

                    blnProcesoData = InsertUpdate_HuellaTemplate(Me.CNBDHuellaVisita, intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                          intIDTablaLocal, objTabla, fila,
                                                          strMensajeOut)

                    If blnProcesoData = False Then
                        'ocurrio error
                        Return value
                    End If

                Next

            End If

            '2.- tabla wsq de la bd huella
            objTabla = New DataTable
            objTabla = objDTS.Tables("mov_huella_wsq")

            Dim intIDHuellaTemplate As Integer = -1
            Dim intIDHuellaTemplateLocal As Integer = -1

            'hay registros del interno
            If Not objTabla Is Nothing Then

                For Each fila As DataRow In objTabla.Rows

                    strNombreTabla = fila.Item("tabla").ToString
                    strColumnaTabla = fila.Item("key_name").ToString
                    intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                    intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                    If IsDBNull(fila.Item("wsq_file")) = True Then
                        fila.Item("wsq_file") = 0
                    End If

                    'id template de la huella
                    intIDHuellaTemplate = fila.Item("fk_tmp_id").ToString
                    intIDHuellaTemplateLocal = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaTemplate, strMensajeOut)

                    'limpiar
                    intIDTablaLocal = -1
                    blnNuevo = False
                    blnProcesoData = False
                    intCountRegAfectados = 0

                    'prevalace la informacion de carceleta, por ser tablas nuevas
                    intIDTablaLocal = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                    If strMensajeOut.Trim.Length > 0 Then
                        'ocurrio un error
                        Return value
                    End If

                    blnProcesoData = InsertUpdate_Huellawsq(Me.CNBDHuellaVisita, intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                            intIDTablaLocal, intIDHuellaTemplateLocal,
                                                            objTabla, fila,
                                                          strMensajeOut)

                    If blnProcesoData = False Then
                        'ocurrio error
                        Return value
                    End If

                Next
            End If


            '3.- tabla interno huella
            objTabla = New DataTable
            objTabla = objDTS.Tables("mov_interno_huella")

            Dim intIDHuellaMeniqueIzq As Integer = -1
            Dim intIDHuellaAnularIzq As Integer = -1
            Dim intIDHuellaMedioIzq As Integer = -1
            Dim intIDHuellaIndiceIzq As Integer = -1
            Dim intIDHuellaPulgarIzq As Integer = -1

            Dim intIDHuellaMeniqueDer As Integer = -1
            Dim intIDHuellaAnularDer As Integer = -1
            Dim intIDHuellaMedioDer As Integer = -1
            Dim intIDHuellaIndiceDer As Integer = -1
            Dim intIDHuellaPulgarDer As Integer = -1

            If Not objTabla Is Nothing Then

                For Each fila As DataRow In objTabla.Rows

                    strNombreTabla = fila.Item("tabla").ToString
                    strColumnaTabla = fila.Item("key_name").ToString
                    intRowIDTablaLocal = Isnulll(fila.Item("_rowid").ToString, -1)
                    intRowIDTablaSede = fila.Item("_sed_rowid").ToString

                    intIDHuellaMeniqueIzq = fila.Item("fk_hue_Men_Izq_id").ToString
                    If intIDHuellaMeniqueIzq > 0 Then
                        intIDHuellaMeniqueIzq = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaMeniqueIzq, strMensajeOut)
                    End If

                    intIDHuellaAnularIzq = fila.Item("fk_hue_Anu_Izq_id").ToString
                    If intIDHuellaAnularIzq > 0 Then
                        intIDHuellaAnularIzq = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaAnularIzq, strMensajeOut)
                    End If

                    intIDHuellaMedioIzq = fila.Item("fk_hue_Med_Izq_id").ToString
                    If intIDHuellaMedioIzq > 0 Then
                        intIDHuellaMedioIzq = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaMedioIzq, strMensajeOut)
                    End If

                    intIDHuellaIndiceIzq = fila.Item("fk_hue_Ind_Izq_id").ToString
                    If intIDHuellaIndiceIzq > 0 Then
                        intIDHuellaIndiceIzq = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaIndiceIzq, strMensajeOut)
                    End If

                    intIDHuellaPulgarIzq = fila.Item("fk_hue_Pul_Izq_id").ToString
                    If intIDHuellaPulgarIzq > 0 Then
                        intIDHuellaPulgarIzq = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaPulgarIzq, strMensajeOut)
                    End If

                    intIDHuellaPulgarDer = fila.Item("fk_hue_Pul_Der_id").ToString
                    If intIDHuellaPulgarDer > 0 Then
                        intIDHuellaPulgarDer = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaPulgarDer, strMensajeOut)
                    End If

                    intIDHuellaIndiceDer = fila.Item("fk_hue_Ind_Der_id").ToString
                    If intIDHuellaIndiceDer > 0 Then
                        intIDHuellaIndiceDer = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaIndiceDer, strMensajeOut)
                    End If

                    intIDHuellaMedioDer = fila.Item("fk_hue_Med_Der_id").ToString
                    If intIDHuellaMedioDer > 0 Then
                        intIDHuellaMedioDer = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaMedioDer, strMensajeOut)
                    End If

                    intIDHuellaAnularDer = fila.Item("fk_hue_Anu_Der_id").ToString
                    If intIDHuellaAnularDer > 0 Then
                        intIDHuellaAnularDer = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaAnularDer, strMensajeOut)
                    End If

                    intIDHuellaMeniqueDer = fila.Item("fk_hue_Men_Der_id").ToString
                    If intIDHuellaMeniqueDer > 0 Then
                        intIDHuellaMeniqueDer = getIDTablaxRowIDSede_BDHuella(Me.CNBDHuellaVisita, "mov_template_huella", "pk_tmp_id", intIDHuellaMeniqueDer, strMensajeOut)
                    End If

                    'limpiar
                    intIDTablaLocal = -1
                    blnProcesoData = False

                    'prevalace la informacion de carceleta, por ser tablas nuevas
                    intIDTablaLocal = getIDTablaxRowIDSede(strNombreTabla, strColumnaTabla, intRowIDTablaSede, strMensajeOut)

                    If strMensajeOut.Trim.Length > 0 Then
                        'ocurrio un error
                        Return value
                    End If

                    blnProcesoData = InsertUpdate_internohuella(intIDRegionOrigen, intIDPenalOrigen, lngFecha,
                                                                intIDTablaLocal, intIDInternoLocal,
                                                                intIDHuellaMeniqueIzq,
                                                                intIDHuellaAnularIzq,
                                                                intIDHuellaMedioIzq,
                                                                intIDHuellaIndiceIzq,
                                                                intIDHuellaPulgarIzq,
                                                                intIDHuellaMeniqueDer,
                                                                intIDHuellaAnularDer,
                                                                intIDHuellaMedioDer,
                                                                intIDHuellaIndiceDer,
                                                                intIDHuellaPulgarDer,
                                                                objTabla, fila,
                                                                strMensajeOut)

                    If blnProcesoData = False Then
                        'ocurrio error
                        Return value
                    End If

                Next

            End If

            value = True
            Return value
        End Function
        Private Function ListarTabla(strNombreTabla As String, intIDInternoLocal As Integer) As DataTable

            Dim value As New DataTable
            Dim strSql As String = ""
            Dim strSqlWhere As String = ""

            Select Case strNombreTabla.ToUpper
                Case "REG_DOC_Judicial_Siscrico".ToUpper
                    strNombreTabla = "REG_DOC_Judicial"
                    strSqlWhere = " And doc_tip_id=8" 'documentos siscrico
            End Select

            strSql = "select * from " & strNombreTabla & " where isnull(fk_ing_inp_id,-1) <1 And int_id= " & intIDInternoLocal & strSqlWhere

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            value = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

            Return value

        End Function
        Private Function Listar_ArchivoDigital(strNombreTabla As String, intIDTablaLocal As Integer) As DataTable

            Dim value As New DataTable
            Dim strSql As String = ""
            Dim intTipo As Short = -1

            Select Case strNombreTabla.ToUpper
                Case "GLO_ArchivoDigital_Interno".ToUpper
                    strNombreTabla = "GLO_ArchivoDigital"
                    intTipo = 1

                Case "GLO_ArchivoDigital_Reniec".ToUpper
                    strNombreTabla = "GLO_ArchivoDigital"
                    intTipo = 4
            End Select

            strSql = "select * from " & strNombreTabla & " where isnull(_sed_rowid,-1) <1 And isnull(arc_dig_tip,1)=" & intTipo & " And int_id= " & intIDTablaLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            value = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

            Return value

        End Function
        Private Function Listar_InternoReniec(intIDInternoLocal As Integer) As DataTable

            Dim value As New DataTable
            Dim strSql As String = ""

            strSql = "select int_rnc_id from INT_InternoRENIEC where int_id= " & intIDInternoLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            value = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

            Return value

        End Function
#End Region

#Region "Insert/Update"
        Private Function InsertUpdate_Interno(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                              intIDInternoLocal As Long, intInternoRowID As Integer,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDInternoLocal

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            objFila.Item("c_ver_reg") = ""
            objFila.Item("_RowId") = intInternoRowID

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_IngresoInpe(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                  intIDIngresoInpeLocal As Long, intIDInternoLocal As Long,
                                                  objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDIngresoInpeLocal
                .IDInternoLocal = intIDInternoLocal

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_Tabla3N(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                              intIDTablaLocal As Long,
                                              intIDInternoLocal As Integer, intIDIngresoInpeLocal As Long, intIDIngresoLocal As Long,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDInternoLocal = intIDInternoLocal
                .IDIngresoInpeLocal = intIDIngresoInpeLocal
                .IDIngresoLocal = intIDIngresoLocal

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_InternoBanda(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                   intIDTablaLocal As Long,
                                                intIDInternoLocal As Integer, intIDIngresoInpeLocal As Long, intIDIngresoLocal As Long,
                                                intIDocumentoCreacion As Integer, intIDDocumentoAnulacion As Integer,
                                             objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDInternoLocal = intIDInternoLocal
                .IDIngresoInpeLocal = intIDIngresoInpeLocal
                .IDIngresoLocal = intIDIngresoLocal
                .IDocumentoCreacion = intIDocumentoCreacion
                .IDDocumentoAnulacion = intIDDocumentoAnulacion

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_ArchivoDigital(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                     intIDTablaLocal As Long, intIDTablaLocalInternoReniec As Integer,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDTablaLocalInternoReniec = intIDTablaLocalInternoReniec

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_ArchivoDigitalOdontograma(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                     intIDTablaLocal As Long, intIDTablaLocalOdontograma As Integer,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDTablaLocalOdontograma = intIDTablaLocalOdontograma

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_InternoFoto(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                  intIDTablaLocal As Long,
                                              intIDInternoLocal As Integer, intIDIngresoInpeLocal As Long, intIDIngresoLocal As Long,
                                              intIDFotoIzquierda As Integer, intIDFotoFrontal As Integer, intIDFotoDerecha As Integer,
                                              objDataTable As System.Data.DataTable, objFila As DataRow,
                                              ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDInternoLocal = intIDInternoLocal
                .IDIngresoInpeLocal = intIDIngresoInpeLocal
                .IDIngresoLocal = intIDIngresoLocal
                .IDFotoIzquierda = intIDFotoIzquierda
                .IDFotoFrontal = intIDFotoFrontal
                .IDFotoDerecha = intIDFotoDerecha

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            'grabar en la tabla fotografia
            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            'grabar los perfiles de la fotografia
            value = GrabarInterno_Fotografia(intIDInternoLocal, intIDFotoIzquierda, intIDFotoFrontal, intIDFotoDerecha, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_InternoRENIEC(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                    intIDTablaLocal As Long,
                                              intIDInternoLocal As Integer, intIDIngresoInpeLocal As Long, intIDIngresoLocal As Long,
                                              intIDFotoReniec As Integer, intIDFotoInterno As Integer,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDInternoLocal = intIDInternoLocal
                .IDIngresoInpeLocal = intIDIngresoInpeLocal
                .IDIngresoLocal = intIDIngresoLocal
                .IDFotoReniec = intIDFotoReniec
                .IDFotoInterno = intIDFotoInterno

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_InternoReniecNombreAsoc(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                              intIDTablaLocal As Long,
                                              intIDInternoLocal As Integer, intIDIngresoInpeLocal As Long, intIDIngresoLocal As Long,
                                              intIDReniec As Integer, intIDNombreAsociado As Integer,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDInternoLocal = intIDInternoLocal
                .IDIngresoInpeLocal = intIDIngresoInpeLocal
                .IDIngresoLocal = intIDIngresoLocal
                .IDReniec = intIDReniec
                .IDNombreAsociado = intIDNombreAsociado

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_internohuella(intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                    intIDTablaLocal As Long, intIDInternoLocal As Integer,
                                                intIDHuellaMeniqueIzq As Integer,
                                                intIDHuellaAnularIzq As Integer,
                                                intIDHuellaMedioIzq As Integer,
                                                intIDHuellaIndiceIzq As Integer,
                                                intIDHuellaPulgarIzq As Integer,
                                                intIDHuellaMeniqueDer As Integer,
                                                intIDHuellaAnularDer As Integer,
                                                intIDHuellaMedioDer As Integer,
                                                intIDHuellaIndiceDer As Integer,
                                                intIDHuellaPulgarDer As Integer,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDInternoLocal = intIDInternoLocal

                .IDHuellaMeniqueIzq = intIDHuellaMeniqueIzq
                .IDHuellaAnularIzq = intIDHuellaAnularIzq
                .IDHuellaMedioIzq = intIDHuellaMedioIzq
                .IDHuellaIndiceIzq = intIDHuellaIndiceIzq
                .IDHuellaPulgarIzq = intIDHuellaPulgarIzq

                .IDHuellaPulgarDer = intIDHuellaPulgarDer
                .IDHuellaIndiceDer = intIDHuellaIndiceDer
                .IDHuellaMedioDer = intIDHuellaMedioDer
                .IDHuellaAnularDer = intIDHuellaAnularDer
                .IDHuellaMeniqueDer = intIDHuellaMeniqueDer

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(Legolas.Configuration.Data.ConexionIni, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function

        Private Function InsertUpdate_HuellaTemplate(strCNBD As String, intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                intIDTablaLocal As Long,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(strCNBD, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function
        Private Function InsertUpdate_Huellawsq(strCNBD As String, intIDRegion As Short, intIDPenal As Short, lngFechaHoy As Long,
                                                intIDTablaLocal As Long,
                                              intIDTemplateHuella As Long,
                                              objDataTable As System.Data.DataTable, objFila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEnt As New InsertUpdate
            With objEnt
                .IDTablaLocal = intIDTablaLocal
                .IDTemplateHuella = intIDTemplateHuella

                .IDRegionOrigen = intIDRegion
                .IDPenalOrigen = intIDPenal
                .IDUsuarioModificacion = Legolas.Configuration.Usuario.Codigo
                .FechaHoy = lngFechaHoy
            End With

            value = InsertUpdateTabla(strCNBD, objEnt, objDataTable, objFila, strMensajeOut)

            Return value

        End Function

        Private Function InsertUpdateTabla(strCNBaseDatos As String, objEnt As InsertUpdate, objDataTable As System.Data.DataTable,
                                           Fila As DataRow, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim strTablaNombre As String = objDataTable.TableName
            Dim strColumnaPK As String = ""

            Dim strQuery As String = ""
            Dim strQueryCondicion As String = ""
            Dim strQueryColumnasUpdate As String = ""
            Dim strQueryColumnasInsert As String = ""
            Dim strValueInsert As String = ""

            Dim strArrayColuma As New ArrayList
            Dim strArrayColumnaValor As ArrayList = Nothing

            Dim sqlcn As SqlConnection = Nothing

            '/*recorre las columas existentes en la base de datos local*/
            For Each columna As System.Data.DataColumn In objDataTable.Columns

                sqlcn = New SqlConnection(strCNBaseDatos)

                If Legolas.Components.SQL.ExisteCampo(sqlcn, strTablaNombre, columna.ColumnName) = True Then

                    strArrayColuma.Add(columna.Caption)

                    'pregunta si la columna es pk 
                    If strColumnaPK.Trim = "" Then
                        sqlcn = New SqlConnection(strCNBaseDatos)
                        If Legolas.Components.SQL.IsIdentityColumn(sqlcn, strTablaNombre, columna.Caption) = True Then
                            strColumnaPK = columna.Caption
                        End If
                    End If

                End If

            Next

            If strColumnaPK.Trim = "" Then
                strMensajeOut = "InternoRegularizacion\InsertUpdate; la tabla " & strTablaNombre & ", no tiene campo identity"
                Return value
            End If

            '/**/                       
            Dim cmdUp As SqlCommand = Nothing
            Dim cmdIns As SqlCommand = Nothing
            Dim cmdIdOn As SqlCommand = Nothing
            Dim cmdIdOff As SqlCommand = Nothing
            Dim blnPrimerInsert As Boolean = True

            Dim strArrayMensajeError As New ArrayList
            Dim strMensaje As String = ""

            sqlcn = New SqlConnection(strCNBaseDatos)
            sqlcn.Open()

            With Fila

                'limpiar variables
                strQuery = ""
                strQueryCondicion = ""
                strQueryColumnasUpdate = ""
                strQueryColumnasInsert = ""
                strValueInsert = ""
                strArrayColumnaValor = New ArrayList

                If objEnt.IDTablaLocal > 0 Then

                    cmdUp = New SqlCommand
                    cmdUp.Connection = sqlcn
                    cmdUp.CommandType = CommandType.Text

                    'update
                    strQuery = "update " & strTablaNombre & " set "

                    For i As Integer = 0 To strArrayColuma.Count - 1

                        'no se agrega la columna pk
                        If strColumnaPK.ToUpper.Trim <> strArrayColuma(i).ToString.ToUpper.Trim Then

                            'reemplazar los valores del dts sede central, x los valores locales de la base de datos
                            Select Case strArrayColuma(i).ToUpper

                                Case "fk_int_id".ToUpper, "int_id".ToUpper

                                    If strTablaNombre.ToUpper = "GLO_ArchivoDigital".ToUpper Then
                                        Fila(strArrayColuma(i)) = objEnt.IDTablaLocalInternoReniec
                                    Else
                                        Fila(strArrayColuma(i)) = objEnt.IDInternoLocal
                                    End If

                                Case "fk_ing_inp_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDIngresoInpeLocal

                                Case "int_ing_id".ToUpper, "fk_int_ing_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDIngresoLocal

                                Case "crea_doc_jud_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDocumentoCreacion

                                Case "anul_doc_jud_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDDocumentoAnulacion

                                Case "int_fot_per_izq".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoIzquierda

                                Case "int_fot_per_fre".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoFrontal

                                Case "int_fot_per_der".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoDerecha

                                Case "fot_rnc".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoReniec

                                Case "fot_int".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoInterno

                                Case "n_fk_int_rnc_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoInterno

                                Case "n_fk_int_aso_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDNombreAsociado

                                Case "fk_tmp_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDTemplateHuella

                                Case "fk_reg_tbl_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDTablaLocalOdontograma

                                Case "fk_hue_men_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaMeniqueIzq

                                Case "fk_hue_anu_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaAnularIzq

                                Case "fk_hue_med_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaMedioIzq

                                Case "fk_hue_ind_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaIndiceIzq

                                Case "fk_hue_pul_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaPulgarIzq

                                Case "fk_hue_men_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaMeniqueDer

                                Case "fk_hue_anu_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaAnularDer

                                Case "fk_hue_med_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaMedioDer

                                Case "fk_hue_ind_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaIndiceDer

                                Case "fk_hue_pul_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaPulgarDer

                                '/*auditoria*/
                                'Case "_usu_mod".ToUpper
                                '    Fila(strArrayColuma(i)) = objEnt.IDUsuarioModificacion

                                'Case "_fec_mod".ToUpper
                                '    Fila(strArrayColuma(i)) = objEnt.FechaHoy

                                Case "_regid".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDRegionOrigen

                                Case "_penid".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDPenalOrigen

                                Case Else

                            End Select

                            strArrayColumnaValor.Add(Fila(strArrayColuma(i)))

                            strQueryColumnasUpdate = strQueryColumnasUpdate & strArrayColuma(i).ToString & "=@" & strArrayColuma(i).ToString & ","
                            cmdUp.Parameters.Add(New SqlParameter(strArrayColuma(i).ToString, strArrayColumnaValor(i - 1)))
                        End If

                    Next

                    strQueryColumnasUpdate = strQueryColumnasUpdate.Substring(0, strQueryColumnasUpdate.Length - 1)
                    strQueryCondicion = " where " & strColumnaPK & "=" & objEnt.IDTablaLocal
                    strQuery = strQuery & strQueryColumnasUpdate & strQueryCondicion

                    Try
                        cmdUp.CommandText = strQuery
                        cmdUp.ExecuteNonQuery()
                    Catch ex As Exception
                        strMensajeOut = "InternoRegularizacion/InsertUpdateTabla_v2; Se ha producido un error en el procesamiento. " & ex.Message
                        Return value
                    End Try

                Else

                    'insert
                    cmdIns = New SqlCommand
                    'cmdIns.Connection = sql_cn_query
                    cmdIns.Connection = sqlcn
                    cmdIns.CommandType = CommandType.Text

                    strQuery = "insert into " & strTablaNombre

                    For i As Integer = 0 To strArrayColuma.Count - 1

                        'no se agrega la columna pk
                        If strColumnaPK.ToUpper.Trim <> strArrayColuma(i).ToString.ToUpper.Trim Then

                            strQueryColumnasInsert = strQueryColumnasInsert & strArrayColuma(i).ToString & ","

                            'reemplazar los valores del dts sede central, x los valores locales de la base de datos
                            Select Case strArrayColuma(i).ToUpper

                                Case "fk_int_id".ToUpper, "int_id".ToUpper

                                    If strTablaNombre.ToUpper = "GLO_ArchivoDigital".ToUpper Then
                                        Fila(strArrayColuma(i)) = objEnt.IDTablaLocalInternoReniec
                                    Else
                                        Fila(strArrayColuma(i)) = objEnt.IDInternoLocal
                                    End If

                                Case "fk_ing_inp_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDIngresoInpeLocal

                                Case "int_ing_id".ToUpper, "fk_int_ing_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDIngresoLocal

                                Case "crea_doc_jud_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDocumentoCreacion

                                Case "anul_doc_jud_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDDocumentoAnulacion

                                Case "int_fot_per_izq".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoIzquierda

                                Case "int_fot_per_fre".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoFrontal

                                Case "int_fot_per_der".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoDerecha

                                Case "fot_rnc".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoReniec

                                Case "fot_int".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoInterno

                                Case "n_fk_int_rnc_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDFotoInterno

                                Case "n_fk_int_aso_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDNombreAsociado

                                Case "fk_tmp_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDTemplateHuella

                                Case "fk_reg_tbl_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDTablaLocalOdontograma

                                Case "fk_hue_men_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaMeniqueIzq

                                Case "fk_hue_anu_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaAnularIzq

                                Case "fk_hue_med_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaMedioIzq

                                Case "fk_hue_ind_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaIndiceIzq

                                Case "fk_hue_pul_izq_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaPulgarIzq

                                Case "fk_hue_men_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaMeniqueDer

                                Case "fk_hue_anu_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaAnularDer

                                Case "fk_hue_med_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaMedioDer

                                Case "fk_hue_ind_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaIndiceDer

                                Case "fk_hue_pul_der_id".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDHuellaPulgarDer

                                '/*auditoria*/
                                'Case "_usu_mod".ToUpper
                                '    Fila(strArrayColuma(i)) = objEnt.IDUsuarioModificacion

                                'Case "_fec_mod".ToUpper
                                '    Fila(strArrayColuma(i)) = objEnt.FechaHoy

                                Case "_regid".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDRegionOrigen

                                Case "_penid".ToUpper
                                    Fila(strArrayColuma(i)) = objEnt.IDPenalOrigen

                                Case Else

                            End Select

                            strArrayColumnaValor.Add(Fila(strArrayColuma(i)))

                            strValueInsert = strValueInsert & "@" & strArrayColuma(i - 1) & ","
                            cmdIns.Parameters.Add(New SqlParameter(strArrayColuma(i - 1).ToString, strArrayColumnaValor(i - 1)))

                        End If

                    Next

                    strQueryColumnasInsert = strQueryColumnasInsert.Substring(0, strQueryColumnasInsert.Length - 1)
                    strValueInsert = strValueInsert.Substring(0, strValueInsert.Length - 1)

                    strQueryColumnasInsert = " (" & strQueryColumnasInsert & ")"

                    strValueInsert = strValueInsert & ")"

                    strQuery = strQuery & strQueryColumnasInsert & " values ( " & strValueInsert

                    Try

                        'insert del registro 
                        cmdIns.CommandText = strQuery
                        cmdIns.ExecuteNonQuery()
                    Catch ex As Exception

                        strMensajeOut = "InternoRegularizacion/InsertUpdateTabla_v2; Se ha producido un error en el procesamiento de la tabla " & strTablaNombre &
                        Chr(13) & "ID de la tabla: " & objEnt.IDTablaLocal & Chr(13) & ex.Message
                        Return value
                    End Try

                End If

            End With

            value = True
            sqlcn.Close()
            sqlcn = Nothing

            Return value

        End Function
#End Region
#Region "Grabar"
        Private Function GrabarInterno(intIDInternoLocal As Long, intIDSedeRowID As Long, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1

            Dim strSql As New System.Text.StringBuilder

            strSql.Append("update int_interno set _sed_rowid=@_sed_rowid,_flg_trf=1 where int_id=@int_id")

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql.ToString, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = intIDInternoLocal
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = intIDSedeRowID

                            sqlCon.Open()
                            value = .ExecuteNonQuery()
                            'If value > 0 Then
                            '    'Dim dt_ind As DataTable = Listar.EjecutarSQL("select max(pk_ing_inp_id) from int_mov_interno_ingreso_inpe")
                            '    Dim dt_ind As DataTable = Listar.EjecutarSQL(sqlCon, "select @@identity")
                            '    value = dt_ind.Rows(0).Item(0)
                            'End If
                            Return value

                        End With
                    End Using
                End Using
            Catch ex As Exception
                strMensajeOut = "InternoRegularizacion\GrabarInterno; " & ex.ToString
                Return -1
            End Try

        End Function
        Private Function GrabarInterno_Fotografia(intIDInternoLocal As Long, intFotoIzq As Integer, intFotoFro As Integer, intFotoDer As Integer,
                                                 ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1

            Dim strSql As New System.Text.StringBuilder

            strSql.Append("update int_interno set aut_fot_izq=@aut_fot_izq,aut_fot_fre=@aut_fot_fre,aut_fot_der=@aut_fot_der,_flg_trf=1 where int_id=@int_id")

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql.ToString, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = intIDInternoLocal
                            .Parameters.Add(New SqlParameter("@aut_fot_izq", SqlDbType.Int)).Value = intFotoIzq
                            .Parameters.Add(New SqlParameter("@aut_fot_fre", SqlDbType.Int)).Value = intFotoFro
                            .Parameters.Add(New SqlParameter("@aut_fot_der", SqlDbType.Int)).Value = intFotoDer

                            sqlCon.Open()
                            value = .ExecuteNonQuery()

                            Return value

                        End With
                    End Using
                End Using
            Catch ex As Exception
                strMensajeOut = "InternoRegularizacion\GrabarInterno_Fotografia; " & ex.ToString
                Return -1
            End Try

        End Function
        Private Function GrabarInternoIngreso(obj As Ingreso, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1

            Dim strSql As New System.Text.StringBuilder
            Dim blnNuevo As Boolean = False

            If obj.IDIngreso > 0 Then
                strSql.Append("update int_internoingreso set ")
                strSql.Append("fk_ing_inp_id=@fk_ing_inp_id, ")
                strSql.Append("int_ing_nro=@int_ing_nro,")
                strSql.Append("int_ing_fec_isp=@int_ing_fec_isp,")
                strSql.Append("int_ing_obs=@int_ing_obs,")
                strSql.Append("_flg_trf=@_flg_trf ")
                strSql.Append("where int_ing_id=@int_ing_id")
            Else

                blnNuevo = True
                strSql.Append("INSERT INTO INT_InternoIngreso (")
                strSql.Append("int_id, fk_ing_inp_id, reg_id, pen_id, int_ing_nro, int_ing_fec_isp, fk_mov_tip_id, ing_mot_id,")
                strSql.Append("int_ing_fec, int_ing_obs, _usu_cre, _fec_cre, _usu_mod, _fec_mod, _RegId, _PenId, _flg_trf, int_ing_est,_flg_eli")
                strSql.Append(" ) values ( ")
                strSql.Append("@int_id, @fk_ing_inp_id,  @_RegId, @_PenId, @int_ing_nro, @int_ing_fec_isp, @fk_mov_tip_id, @ing_mot_id, ")
                strSql.Append("@int_ing_fec, @int_ing_obs, @_usu_cre, @_fec_cre, @_usu_mod, @_fec_mod, @_RegId, @_PenId, @_flg_trf, @int_ing_est,@_flg_eli")
                strSql.Append(")")
            End If

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql.ToString, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text

                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = obj.IDIngreso
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = obj.IDIngresoInpe
                            .Parameters.Add(New SqlParameter("@int_ing_nro", SqlDbType.SmallInt)).Value = obj.NumeroIngreso
                            .Parameters.Add(New SqlParameter("@int_ing_fec_isp", SqlDbType.BigInt)).Value = obj.FechaIngresoInpe
                            .Parameters.Add(New SqlParameter("@int_ing_obs", SqlDbType.VarChar, 500)).Value = obj.Observacion

                            .Parameters.Add(New SqlParameter("@_flg_trf", SqlDbType.SmallInt)).Value = 1 'trasnferencia

                            If blnNuevo = True Then
                                .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = obj.IDInterno
                                .Parameters.Add(New SqlParameter("@int_ing_fec", SqlDbType.BigInt)).Value = obj.FechaIngreso
                                .Parameters.Add(New SqlParameter("@fk_mov_tip_id", SqlDbType.SmallInt)).Value = obj.IDMovimientoTipo
                                .Parameters.Add(New SqlParameter("@ing_mot_id", SqlDbType.SmallInt)).Value = obj.IDMovimientoMotivo

                                .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.SmallInt)).Value = obj.IDRegion
                                .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.SmallInt)).Value = obj.IDPenal
                                .Parameters.Add(New SqlParameter("@int_ing_est", SqlDbType.SmallInt)).Value = obj.Estado

                                .Parameters.Add(New SqlParameter("@_usu_cre", SqlDbType.Int)).Value = obj.IDUsuarioCreacion
                                .Parameters.Add(New SqlParameter("@_fec_cre", SqlDbType.BigInt)).Value = obj.FechaCreacion
                                .Parameters.Add(New SqlParameter("@_usu_mod", SqlDbType.Int)).Value = obj.IDUsuarioModificacion
                                .Parameters.Add(New SqlParameter("@_fec_mod", SqlDbType.BigInt)).Value = obj.FechaModificacion

                                .Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = 0
                            End If

                            sqlCon.Open()
                            value = .ExecuteNonQuery()

                            Return value

                        End With
                    End Using
                End Using
            Catch ex As Exception
                strMensajeOut = "InternoRegularizacion\GrabarInternoIngreso; " & ex.ToString
                Return -1
            End Try

        End Function
        Private Function UpdateTabla(strNombreTabla As String, strNombreColumna As String, intIDTablaLocal As Long, intIDIngresoInpe As Integer,
                                     lngFecha As Long, intIDSedeRowID As Long,
                                            ByRef strMensajeOut As String, Optional blnUpdateIDIngresoInpe As Boolean = True) As Integer

            Dim value As Integer = -1
            Dim strSql As New System.Text.StringBuilder

            Select Case strNombreTabla.ToUpper
                Case "REG_DOC_Judicial_Siscrico".ToUpper
                    strNombreTabla = "REG_DOC_Judicial"

                Case "GLO_ArchivoDigital_Interno".ToUpper,
                    "GLO_ArchivoDigital_Reniec".ToUpper
                    strNombreTabla = "GLO_ArchivoDigital"
            End Select

            strSql.Append("update " & strNombreTabla & " set ")

            If blnUpdateIDIngresoInpe = True Then
                strSql.Append("fk_ing_inp_id=@fk_ing_inp_id,")
            End If

            'strSql.Append("_fec_mod=@_fecha,")
            'strSql.Append("_usu_mod=@_usuario,")
            strSql.Append("_sed_rowid=@_sed_rowid,")
            strSql.Append("_flg_trf=1 ")
            strSql.Append(" where " & strNombreColumna & "=@codigo")

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql.ToString, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text
                            .Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = intIDTablaLocal

                            If blnUpdateIDIngresoInpe = True Then
                                .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = intIDIngresoInpe
                            End If

                            '.Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            '.Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = lngFecha
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = intIDSedeRowID

                            sqlCon.Open()
                            value = .ExecuteNonQuery()
                            Return value

                        End With
                    End Using
                End Using
            Catch ex As Exception
                strMensajeOut = "InternoRegularizacion\UpdateTabla; " & ex.ToString
                Return -1
            End Try

        End Function
        Private Function GrabarInternoPenal(intIDInternoPenal As Long, intIDRegion As Short, intIDPenal As Short, intEstado As Short,
                                            ByRef strMensajeOut As String) As Boolean

            Dim intIDInternoSede As Integer = -1
            Dim objBssInterno As New Bussines.Registro.Interno

            intIDInternoSede = objBssInterno.fnSedeRowID(intIDInternoPenal)

            If intIDInternoSede > 0 Then

                Dim objBssInternoPenal As New Bussines.Registro.InternoPenal
                Dim intIDTabla As Integer = -1
                intIDTabla = objBssInternoPenal.Grabar(intIDInternoSede, intIDInternoPenal, intIDRegion, intIDPenal, intEstado) 'alta/baja

                If intIDTabla > 0 Then

                    Dim strSqlMasivo As New System.Text.StringBuilder
                    With strSqlMasivo
                        .AppendLine("update VIS_Autorizacion set _flg_trf =1 where _penid =" & intIDPenal & " and int_id=" & intIDInternoPenal)
                        .AppendLine("update VIS_CalendarioDetalle set _flg_trf =1 where _penid =" & intIDPenal & " and int_id=" & intIDInternoPenal)
                        .AppendLine("update VIS_InternoEtapa set _flg_trf =1 where _penid =" & intIDPenal & " and int_id=" & intIDInternoPenal)
                        .AppendLine("update VIS_InternoSancion set _flg_trf =1 where _penid =" & intIDPenal & " and int_id=" & intIDInternoPenal)
                        .AppendLine("update VIS_Movimiento set _flg_trf =1 where _penid =" & intIDPenal & " and int_id=" & intIDInternoPenal)
                        .AppendLine("update VIS_VisitanteRestriccion set _flg_trf =1 where _penid =" & intIDPenal & " and int_id=" & intIDInternoPenal)
                    End With

                    Dim intResul As Integer = -1
                    intResul = UpdateQuery(strSqlMasivo.ToString(), strMensajeOut)

                    If strMensajeOut.Trim.Length > 0 Then
                        Return False
                    End If

                    If intResul >= 0 Then 'si todo esta ok
                        Return True
                    End If

                Else
                    strMensajeOut = "No se pudo completar la operacion de update del interno local: " & intIDInternoPenal & " en la tabla reg_mov_internopenal"
                End If

            Else
                strMensajeOut = "El interno local: " & intIDInternoPenal & " no tiene el valor SedeRowID"
            End If

        End Function
        Public Shared Function UpdateQuery(strSql As String, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Try

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text
                            .CommandTimeout = 60 * 3

                            sqlCon.Open()
                            value = .ExecuteNonQuery()

                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                strMensajeOut = "UpdateQuery/GrabarInternoPenal; " & ex.Message
                Return -1
            End Try

        End Function
        Private Function GrabarVersionInterno(intIDInternoLocal As Long, lngFecha As Long, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1

            Dim strSql As New System.Text.StringBuilder

            strSql.Append("update int_interno set c_ver_reg=@version,_flg_trf=1 where int_id=@int_id")

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql.ToString, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = intIDInternoLocal
                            .Parameters.Add(New SqlParameter("@version", SqlDbType.VarChar, 10)).Value = "V6_LM"

                            sqlCon.Open()
                            value = .ExecuteNonQuery()

                            Return value

                        End With
                    End Using
                End Using
            Catch ex As Exception
                strMensajeOut = "InternoRegularizacion\GrabarVersionInterno; " & ex.ToString
                Return -1
            End Try

        End Function
#End Region
#Region "Select_ID"
        Private Function getIDTablaxRegionPenalRowID(strTablaNombre As String, strNombreColumna As String,
                                   intIDPenal As Short, intIDRegion As Short, intIDRow As Long, ByRef strMensajeOut As String) As Long

            Dim value As Long = -1
            Dim strSql As String = ""

            Select Case strTablaNombre.ToUpper
                Case "REG_DOC_Judicial_Siscrico".ToUpper

                    strTablaNombre = "REG_DOC_Judicial"

                Case "GLO_ArchivoDigital_Interno".ToUpper,
                    "GLO_ArchivoDigital_Reniec".ToUpper

                    strTablaNombre = "GLO_ArchivoDigital"
            End Select

            strSql = "select " & strNombreColumna & " from " & strTablaNombre & " where _penid= " & intIDPenal & " And _regid=" & intIDRegion & " And _rowid=" & intIDRow

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

            If objDataTable.Rows.Count > 1 Then
                strMensajeOut = "El registro de la tabla: " & strTablaNombre & ", tiene registros duplicados (IDRegion=" _
                    & intIDRegion & ", IDPenal=" & intIDPenal & ", IDRow=" & intIDRow & ")"
            Else
                For Each fila As System.Data.DataRow In objDataTable.Rows
                    value = fila(strNombreColumna).ToString
                Next
            End If

            Return value

        End Function
        Private Function getIDTablaxRowIDSede(strTablaNombre As String, strNombreColumna As String, intIDRowSede As Long,
                                              ByRef strMensajeOut As String) As Long

            Dim value As Long = -1
            Dim strSql As String = ""

            Select Case strTablaNombre.ToUpper
                Case "REG_DOC_Judicial_Siscrico".ToUpper

                    strTablaNombre = "REG_DOC_Judicial"

                Case "GLO_ArchivoDigital_Interno".ToUpper,
                    "GLO_ArchivoDigital_Reniec".ToUpper

                    strTablaNombre = "GLO_ArchivoDigital"
            End Select

            strSql = "select " & strNombreColumna & " from " & strTablaNombre & " where _flg_eli=0 and _sed_rowid= " & intIDRowSede

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql, strMensajeOut)

            'error
            If strMensajeOut.Trim.Length > 0 Then
                Return value
            End If

            If objDataTable.Rows.Count > 1 Then
                strMensajeOut = "El registro de la tabla: " & strTablaNombre & ", tiene registros duplicados (IDRowSede=" & intIDRowSede & ")"
            Else
                For Each fila As System.Data.DataRow In objDataTable.Rows
                    value = fila(0).ToString
                Next
            End If

            Return value

        End Function
        Private Function getIDTablaxRowIDSede_BDHuella(strCNBD As String, strTablaNombre As String, strNombreColumna As String, intIDRowSede As Long,
                                              ByRef strMensajeOut As String) As Long

            Dim value As Long = -1
            Dim strSql As String = ""

            strSql = "select " & strNombreColumna & " from " & strTablaNombre & " where _sed_rowid= " & intIDRowSede

            Dim sqlcn As SqlConnection = New SqlConnection(strCNBD)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql, strMensajeOut)

            'error
            If strMensajeOut.Trim.Length > 0 Then
                Return value
            End If

            If objDataTable.Rows.Count > 1 Then
                strMensajeOut = "El registro de la tabla: " & strTablaNombre & ", tiene registros duplicados (IDRowSede=" & intIDRowSede & ")"
            Else
                For Each fila As System.Data.DataRow In objDataTable.Rows
                    value = fila(0).ToString
                Next
            End If

            Return value

        End Function

        Private Function getIDIngresoInpexRegionPenalRowID(intIDPenal As Short, intIDRegion As Short, intIDIngresoInpeSede As Integer, intIDRow As Long, ByRef strMensajeOut As String) As Long

            Dim value As Long = -1
            Dim strSql As String = ""

            If intIDRow < 1 Then
                strSql = "select pk_ing_inp_id from int_mov_interno_ingreso_inpe where _flg_eli=0 and _sed_rowid= " & intIDIngresoInpeSede
            Else
                strSql = "select pk_ing_inp_id from int_mov_interno_ingreso_inpe where _penid= " & intIDPenal & " And _regid=" & intIDRegion _
                    & " And _rowid_fk_int_ing_id=" & intIDRow
            End If

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql, strMensajeOut)

            If strMensajeOut.Trim.Length > 0 Then
                strMensajeOut = "InternoRegularizacion/getIDIngresoInpe; " & strMensajeOut
                Return value
            Else

                If objDataTable.Rows.Count > 1 Then
                    strMensajeOut = "El registro de la tabla: int_mov_interno_ingreso_inpe, tiene registros duplicados (IDRegion=" _
                        & intIDRegion & ", IDPenal=" & intIDPenal & ", IDRow=" & intIDRow & ", IDIngresoInpeSede=" & intIDIngresoInpeSede & ")"
                Else
                    For Each fila As System.Data.DataRow In objDataTable.Rows
                        value = fila(0).ToString
                    Next
                End If

            End If

            Return value

        End Function
        Private Function getIDIngresoInpexIDIngreso(intIDIngresoLocal As Long, intIDInternoLocal As Integer, ByRef strMensajeOut As String) As Long

            Dim value As Long = -1
            Dim intIDInternoSelect As Long = -1
            Dim strSql As String = ""

            strSql = "select isnull(fk_ing_inp_id,-1) as fk_ing_inp_id,int_id from int_internoingreso where int_ing_id= " & intIDIngresoLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

            If objDataTable.Rows.Count > 1 Then
                strMensajeOut = "El registro de la tabla: int_internoingreso, tiene registros duplicados (int_ing_id=" & intIDIngresoLocal & ")"
            Else
                For Each fila As System.Data.DataRow In objDataTable.Rows
                    value = fila(0).ToString
                    intIDInternoSelect = fila(1).ToString
                Next
            End If

            'si no existe el ingreso inpe para los registros locales, vamos a enviarlo al ultimo ingreso mayor
            If value < 1 Then
                strSql = "select top 1 isnull(fk_ing_inp_id,-1) as fk_ing_inp_id,int_id from int_internoingreso where _flg_eli=0 and isnull(fk_ing_inp_id,-1)>0 and int_id=" & intIDInternoLocal & " order by int_ing_nro desc,int_ing_fec_isp desc"

                sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                objDataTable = New DataTable
                objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

                For Each fila As System.Data.DataRow In objDataTable.Rows
                    value = fila(0).ToString
                    intIDInternoSelect = fila(1).ToString
                Next

            End If

            If intIDInternoLocal <> intIDInternoSelect Then 'si el id del interno no coincide con el ingresolocal, salir
                strMensajeOut = "El registro " & intIDIngresoLocal & " de la tabla: int_internoingreso, no tiene relacion con el interno: " & intIDInternoLocal
                value = -1
            End If

            Return value

        End Function
        Private Function getIDIngresoxIDIngresoInpeLocal(intIDInternoLocal As Integer, intIDIngresoLocal As Integer, intIDIngresoInpeLocal As Long, intNumeroIngreso As Short,
                                                         lngFechaIngresoInpe As Long, lngFechaIngresoPenal As Long,
                                                         ByRef strMensajeOut As String) As Long

            Dim value As Long = -1
            Dim strSql As String = ""

            If intIDIngresoLocal > 0 Then
                strSql = "select int_ing_id from int_internoingreso where _flg_eli=0 and int_ing_id= " & intIDIngresoLocal
            Else
                strSql = "select int_ing_id from int_internoingreso where _flg_eli=0 and fk_ing_inp_id= " & intIDIngresoInpeLocal
            End If

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

            If objDataTable.Rows.Count > 1 Then
                If intIDIngresoLocal > 0 Then
                    strMensajeOut = "El registro " & intIDIngresoLocal & " de la tabla: int_internoingreso, no existe"
                Else
                    strMensajeOut = "El registro de la tabla: int_internoingreso, tiene registros duplicados (fk_ing_inp_id=" & intIDIngresoInpeLocal & ")"
                End If
            Else
                For Each fila As System.Data.DataRow In objDataTable.Rows
                    value = fila(0).ToString
                Next
            End If

            'hacer match el ingreso del interno, x numero de ingreso y fecha de ingreso
            If value < 1 Then

                Dim dteFechaIngInpe As Date = Legolas.Components.FechaHora.FechaDate(lngFechaIngresoInpe, False)
                Dim dteFechaIngPenal As Date = Legolas.Components.FechaHora.FechaDate(lngFechaIngresoPenal, False)

                strSql = "select int_ing_id from int_internoingreso where _flg_eli=0 and int_id= " & intIDInternoLocal &
                    " and int_ing_nro=" & intNumeroIngreso &
                    " and (dbo.fn_fecha(isnull(int_ing_fec_isp,0))='" & lngFechaIngresoInpe & "')"

                sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                objDataTable = New DataTable
                objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

                If objDataTable.Rows.Count = 1 Then ' si solo devuelve un solo registro esta ok
                    For Each fila As System.Data.DataRow In objDataTable.Rows
                        value = fila(0).ToString
                    Next
                Else
                    'devuelva mas de un registro y no se puede determinar a que ingreso pertecene. Se enviara -1, para que se registre como nuevo                    
                End If

            End If

            Return value

        End Function
        Private Function getIDIngresoxIDIngresoInpeLocal(intIDIngresoInpeLocal As Long, ByRef strMensajeOut As String) As Long

            Dim value As Long = -1
            Dim strSql As String = ""
            strSql = "select int_ing_id from int_internoingreso where _flg_eli=0 and fk_ing_inp_id= " & intIDIngresoInpeLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSql)

            If objDataTable.Rows.Count > 1 Then
                strMensajeOut = "El registro de la tabla: int_internoingreso, tiene registros duplicados (fk_ing_inp_id=" & intIDIngresoInpeLocal & ")"
            Else
                For Each fila As System.Data.DataRow In objDataTable.Rows
                    value = fila(0).ToString
                Next
            End If

            Return value

        End Function
#End Region

    End Class

End Namespace
