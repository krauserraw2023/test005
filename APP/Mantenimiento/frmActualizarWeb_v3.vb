Imports System.Data.SqlClient

Namespace Mantenimiento
    Public Class frmActualizarWeb_v3
        Private objWS As APPWebService.ws_pope_sede_tp_config.TablaMaestras_Config = Nothing
        Private sqlcn As SqlConnection = Nothing
#Region "Propiedades"
        Private Property Licencia() As Boolean
            Get
                Return Me.chkLicencia.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkLicencia.Checked = value
            End Set
        End Property
        Private Property Modulo() As Boolean
            Get
                Return Me.chkModulo.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkModulo.Checked = value
            End Set
        End Property
        Private Property Usuario() As Boolean
            Get
                Return Me.chkUsuario.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkUsuario.Checked = value
            End Set
        End Property
        Private ReadOnly Property IDLicencia As Integer
            Get
                'hola
                Return Legolas.LBusiness.Globall.WinApp.LicenciaApp
            End Get
        End Property
        Private Property MensajeError As String = ""
#End Region
#Region "Propiedades_Load"
        Private Property LoadLicencia() As Boolean = False
        Private Property LoadModulo() As Boolean = False
        Private Property LoadUsuario() As Boolean = False        
#End Region
#Region "Funciones"
        Private Function ID_Listar(TablaNombre As String, NombreColumna As String, Codigo As Long) As Long

            Dim value As Long = -1
            Dim strQuery As String = "select " & NombreColumna
            Dim strTabla As String = TablaNombre

            strQuery = strQuery & " from " & strTabla & " where " & NombreColumna & "=" & Codigo

            sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strQuery)

            For Each fila As System.Data.DataRow In objDataTable.Rows

                value = fila(NombreColumna).ToString

            Next

            Return value

        End Function
        Private Function InsertUpdateTabla(objDataTable As System.Data.DataTable) As Boolean

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

            '/*recorre las columas existentes en la base de datos local*/
            For Each columna As System.Data.DataColumn In objDataTable.Columns

                sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                If Legolas.Components.SQL.ExisteCampo(sqlcn, strTablaNombre, columna.ColumnName) = True Then

                    strArrayColuma.Add(columna.Caption)

                    'pregunta si la columna es pk 
                    If strColumnaPK.Trim = "" Then
                        sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                        If Legolas.Components.SQL.IsIdentityColumn(sqlcn, strTablaNombre, columna.Caption) = True Then
                            strColumnaPK = columna.Caption
                        End If
                    End If

                End If

            Next

            If strColumnaPK.Trim = "" Then
                Return value
            End If

            '/**/            
            Dim intCodigo As Long = -1
            Dim cmdUp As SqlCommand = Nothing
            Dim cmdIns As SqlCommand = Nothing
            Dim cmdIdOn As SqlCommand = Nothing
            Dim cmdIdOff As SqlCommand = Nothing

            Dim strArrayMensajeError As New ArrayList
            Dim strMensaje As String = ""

            Dim sql_cn_query As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            sql_cn_query.Open()

            For Each Fila As System.Data.DataRow In objDataTable.Rows

                'limpiar variables
                strQuery = ""
                strQueryCondicion = ""
                strQueryColumnasUpdate = ""
                strQueryColumnasInsert = ""
                strValueInsert = ""
                strArrayColumnaValor = New ArrayList

                intCodigo = Fila(strColumnaPK).ToString
                intCodigo = ID_Listar(strTablaNombre, strColumnaPK, intCodigo)

                If intCodigo >= 0 Then

                    cmdUp = New SqlCommand
                    cmdUp.Connection = sql_cn_query
                    cmdUp.CommandType = CommandType.Text

                    'update
                    strQuery = "update " & strTablaNombre & " set "

                    For i As Integer = 0 To strArrayColuma.Count - 1

                        If strColumnaPK.ToUpper.Trim = strArrayColuma(i).ToString.ToUpper.Trim Then
                            strArrayColumnaValor.Add(Fila(strArrayColuma(i)))
                        Else
                            strArrayColumnaValor.Add(Fila(strArrayColuma(i)))
                            strQueryColumnasUpdate = strQueryColumnasUpdate & strArrayColuma(i).ToString & "=@" & strArrayColuma(i).ToString & ","

                            cmdUp.Parameters.Add(New SqlParameter(strArrayColuma(i).ToString, strArrayColumnaValor(i)))
                        End If

                    Next

                    strQueryColumnasUpdate = strQueryColumnasUpdate.Substring(0, strQueryColumnasUpdate.Length - 1)
                    strQueryCondicion = " where " & strColumnaPK & "=" & intCodigo
                    strQuery = strQuery & strQueryColumnasUpdate & strQueryCondicion

                    Try
                        cmdUp.CommandText = strQuery
                        cmdUp.ExecuteNonQuery()
                    Catch ex As Exception

                        strArrayMensajeError.Add(ex.Message)

                        strMensaje = "Se ha producido un error en la sincronizacion. Verifique los detalles; " & Chr(13)
                        strMensaje = strMensaje & "Tabla: " & strTablaNombre & Chr(13)
                        strMensaje = strMensaje & "Mensaje de Error: " & ex.Message & Chr(13)
                        strMensaje = strMensaje & "Observacion: El error puede ser por los tipos de datos de la tabla " & strTablaNombre
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)

                    End Try


                Else
                    'insert
                    cmdIns = New SqlCommand
                    cmdIns.Connection = sql_cn_query
                    cmdIns.CommandType = CommandType.Text

                    strQuery = "insert into " & strTablaNombre

                    For i As Integer = 0 To strArrayColuma.Count - 1

                        strQueryColumnasInsert = strQueryColumnasInsert & strArrayColuma(i).ToString & ","
                        strArrayColumnaValor.Add(Fila(strArrayColuma(i)))

                        strValueInsert = strValueInsert & "@" & strArrayColuma(i) & ","

                        cmdIns.Parameters.Add(New SqlParameter(strArrayColuma(i).ToString, strArrayColumnaValor(i)))

                    Next

                    strQueryColumnasInsert = strQueryColumnasInsert.Substring(0, strQueryColumnasInsert.Length - 1)
                    strValueInsert = strValueInsert.Substring(0, strValueInsert.Length - 1)

                    strQueryColumnasInsert = " (" & strQueryColumnasInsert & ")"

                    strValueInsert = strValueInsert & ")"

                    strQuery = strQuery & strQueryColumnasInsert & " values ( " & strValueInsert

                    Try

                        'insert on
                        cmdIdOn = New SqlCommand
                        cmdIdOn.Connection = sql_cn_query
                        cmdIdOn.CommandType = CommandType.Text
                        cmdIdOn.CommandText = "SET IDENTITY_INSERT " & strTablaNombre & " ON"
                        cmdIdOn.ExecuteNonQuery()

                        'insert del registro 
                        cmdIns.CommandText = strQuery
                        cmdIns.ExecuteNonQuery()

                        'insert off
                        cmdIdOff = New SqlCommand
                        cmdIdOff.Connection = sql_cn_query
                        cmdIdOff.CommandType = CommandType.Text
                        cmdIdOff.CommandText = "SET IDENTITY_INSERT " & strTablaNombre & " OFF"
                        cmdIdOff.ExecuteNonQuery()

                    Catch ex As Exception

                        strArrayMensajeError.Add(ex.Message)

                        strMensaje = "Se ha producido un error en la sincronizacion. Verifique los detalles; " & Chr(13)
                        strMensaje = strMensaje & "Tabla: " & strTablaNombre & Chr(13)
                        strMensaje = strMensaje & "Mensaje de Error: " & ex.Message & Chr(13)
                        strMensaje = strMensaje & "Observacion: El error puede ser por los tipos de datos de la tabla " & strTablaNombre
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)

                    End Try


                End If

            Next

            value = True

            sql_cn_query.Close()
            sql_cn_query = Nothing

            Return value

        End Function
#End Region
#Region "Sincronizar"

        Private Function ASincronizarLicencia() As Boolean

            Dim blnValue As Boolean = False

            If Legolas.Components.PC.IsOnline = True Then

                Dim intTotalServer As Integer = 0

                objWS = New APPWebService.ws_pope_sede_tp_config.TablaMaestras_Config
                objWS.Url = APPWebService.PathURL.ws_pope_sede_TablaMaestra_config

                intTotalServer = objWS.Cantidad(IDLicencia, APPWebService.ws_pope_sede_tp_config.TipoTabla_Config.Licencia, MensajeError)

                Dim objDataSet As New System.Data.DataSet
                Dim objDataTable As New System.Data.DataTable

                objDataSet = objWS.Listar(IDLicencia, APPWebService.ws_pope_sede_tp_config.TipoTabla_Config.Licencia, MensajeError)

                objDataTable = objDataSet.Tables(0)
                objDataTable.TableName = "sys_instalacion"

                If objDataTable.Rows.Count = intTotalServer Then

                    blnValue = InsertUpdateTabla(objDataTable)
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                   "Se encontraron problemas de conexion, al actualizar los datos")
                End If

            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No se ha podido sincronizar la información, porque se ha dectectado una baja o nula conexión a internet con la Sede Central")
            End If

            Return blnValue

        End Function
        Private Function ASincronizarLicenciaDetalle() As Boolean

            Dim blnValue As Boolean = False

            If Legolas.Components.PC.IsOnline = True Then

                Dim intTotalServer As Integer = 0

                objWS = New APPWebService.ws_pope_sede_tp_config.TablaMaestras_Config
                objWS.Url = APPWebService.PathURL.ws_pope_sede_TablaMaestra_config

                intTotalServer = objWS.Cantidad(Me.IDLicencia, APPWebService.ws_pope_sede_tp_config.TipoTabla_Config.LicenciaDetalle, MensajeError)

                Dim objDataSet As New System.Data.DataSet
                Dim objDataTable As New System.Data.DataTable

                objDataSet = objWS.Listar(Me.IDLicencia, APPWebService.ws_pope_sede_tp_config.TipoTabla_Config.LicenciaDetalle, MensajeError)

                objDataTable = objDataSet.Tables(0)
                objDataTable.TableName = "sys_instalaciondetalle"

                If objDataTable.Rows.Count = intTotalServer Then

                    blnValue = InsertUpdateTabla(objDataTable)
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                   "Se encontraron problemas de conexion, al actualizar los datos")
                End If

            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
              "No se ha podido sincronizar la información, porque se ha dectectado una baja o nula conexión a internet con la Sede Central")
            End If

            Return blnValue

        End Function
        Private Function ASincronizarModulo() As Boolean

            Dim blnValue As Boolean = False

            If Legolas.Components.PC.IsOnline = True Then

                Dim intTotalServer As Integer = 0

                objWS = New APPWebService.ws_pope_sede_tp_config.TablaMaestras_Config
                objWS.Url = APPWebService.PathURL.ws_pope_sede_TablaMaestra_config

                intTotalServer = objWS.Cantidad(Me.IDLicencia, APPWebService.ws_pope_sede_tp_config.TipoTabla_Config.Modulo, MensajeError)

                Dim objDataSet As New System.Data.DataSet
                Dim objDataTable As New System.Data.DataTable

                objDataSet = objWS.Listar(Me.IDLicencia, APPWebService.ws_pope_sede_tp_config.TipoTabla_Config.Modulo, MensajeError)

                objDataTable = objDataSet.Tables(0)
                objDataTable.TableName = "SEC_Modulo"

                If objDataTable.Rows.Count = intTotalServer Then

                    blnValue = InsertUpdateTabla(objDataTable)
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                   "Se encontraron problemas de conexion, al actualizar los datos")
                End If

            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
              "No se ha podido sincronizar la información, porque se ha dectectado una baja o nula conexión a internet con la Sede Central")
            End If

            Return blnValue

        End Function

        Private Sub ActualizarData()

            Me.Cursor = Cursors.WaitCursor

            Select Case Configuracion.Licencia.Codigo
                Case 1 'sede central
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                   "Esta opcion solo esta disponible para las Instalaciones en Provincias")
                Case Else

                    If Me.LoadLicencia = True Then
                        ASincronizarLicencia()
                        ASincronizarLicenciaDetalle()
                    End If

                    If Me.LoadModulo = True Then
                        ASincronizarModulo()
                    End If

                    If Me.LoadUsuario = True Then
                        ASincronizarUsuario()
                    End If

                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            End Select

            Me.Cursor = Cursors.Default

        End Sub
#End Region
#Region "Sincronizar_Usuario"

        Private Function TablaFecha(ByRef strMensajeError As String) As Long

            Dim value As Long = 0
            Dim strQuery2 As String = ""
            Dim objDataTable As DataTable = Nothing
            Dim strNombreTabla As String = "sec_usuario"

            'buscamos la ultima fecha modificado de la tabla 
            strQuery2 = "select isnull(max(_fec_mod),0) from " & strNombreTabla
            sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            objDataTable = New DataTable
            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strQuery2, strMensajeError)

            If strMensajeError.Trim = "" Then
                For Each fila As System.Data.DataRow In objDataTable.Rows

                    value = fila(0).ToString

                Next
            Else
                strMensajeError = "Se ha producido un error en la tabla: " & strNombreTabla & ". Error :" & strMensajeError
                Return -1
            End If

            Return value

        End Function

        Private Function ASincronizarUsuario() As Boolean

            Dim value As Boolean = False

            If Legolas.Components.PC.IsOnline = True Then

                Dim objWSUsuario As New APPWebService.ws_pope_sede_usuario.Usuario
                objWSUsuario.Url = APPWebService.PathURL.WSPopeSedeUsuario

                Dim strMensajeError As String = ""

                Dim objDataSet As New System.Data.DataSet
                Dim objTableUsuario As New DataTable
                Dim objTableUsuarioModulo As New DataTable
                Dim objTableUsuarioRegion As New DataTable

                Dim lngFecha As Long = 0
                lngFecha = TablaFecha(strMensajeError)

                objDataSet = objWSUsuario.ListarxLicenciav2(Me.IDLicencia, lngFecha, strMensajeError)

                For Each tabla As DataTable In objDataSet.Tables

                    Select Case tabla.TableName.ToLower
                        Case "sec_usuario"
                            objTableUsuario = tabla
                        Case "sec_usuariomodulo"
                            objTableUsuarioModulo = tabla
                        Case "sec_usuarioregion"
                            objTableUsuarioRegion = tabla
                    End Select

                Next

                If objTableUsuario.Rows.Count > 0 Then

                    'Dim objBss As New Legolas.LBusiness.Seguridad.Usuario
                    ''objBss.EliminarTabla(-1)

                    value = InsertUpdateTabla(objTableUsuario)
                End If

                Dim objBssUsuMod As New Legolas.LBusiness.Seguridad.UsuarioModulo
                objBssUsuMod.EliminarTabla(-1)
                value = InsertUpdateTabla(objTableUsuarioModulo)                

                Dim objBssUsuReg As New Bussines.Seguridad.Penal.Region
                objBssUsuReg.EliminarTabla(-1)
                value = InsertUpdateTabla(objTableUsuarioRegion)

            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No se ha podido sincronizar la información, porque se ha dectectado una baja o nula conexión a internet con la Sede Central")
            End If

            Return value

        End Function

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

        End Sub

        Public Sub _ActualizarUsuario()

            Me.LoadUsuario = True            
            ActualizarData()
            Me.Close()

        End Sub       
        Public Sub _ActualizarLicencia()

            Me.LoadLicencia = True
            ActualizarData()
            Me.Close()

        End Sub
#End Region

        Private Sub frmActualizarWeb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub
        Private Sub frmActualizarWeb_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown


        End Sub


        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            Dim strMensaje As String = ""
            strMensaje = "Desea sincronizar los registros con la sede central"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            Me.LoadLicencia = Me.Licencia
            Me.LoadModulo = Me.Modulo
            Me.LoadUsuario = Me.Usuario
            
            ActualizarData()
            Me.Close()

        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

            Me.Close()

        End Sub
    End Class

End Namespace