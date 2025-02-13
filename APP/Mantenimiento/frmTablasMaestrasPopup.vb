Imports System.Data.SqlClient

Namespace Mantenimiento
    Public Class frmTablasMaestrasPopup
        Private sqlcn As SqlConnection = Nothing        

#Region "Sincronizar"
        Private Sub BarraProgreso(Nombre As String, valor As Integer, ValorMaximo As Integer)

            Me.lblCount.Text = valor & " de " & ValorMaximo.ToString
            Me.lblTabla.Text = Nombre
            Me.ProgressBar1.Value = (valor * 100 / ValorMaximo)
            Me.Refresh()

        End Sub
        Private Sub ActualizarData()

            Me.Cursor = Cursors.WaitCursor

            'validar las tablas 
            Select Case Configuracion.Licencia.Codigo
                Case 1 'sede central

                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Esta opcion solo esta disponible para las Instalaciones en Provincias")

                    Exit Sub
                Case Else

            End Select

            Dim objWS As APPWebService.ws_pope_sede_tp.TablaMaestras = Nothing
            objWS = New APPWebService.ws_pope_sede_tp.TablaMaestras
            objWS.Url = APPWebService.PathURL.ws_pope_sede_TablaMaestra

            Dim objDataTable As New System.Data.DataTable
            Dim strMensaje As String = ""
            Dim strMensajeError As String = ""
            Dim intIDLicencia As Integer = Legolas.LBusiness.Globall.WinApp.LicenciaApp
            Dim lngFecha As Long = 0
            Dim intIDTablaMaximo As Integer = 0

            If Legolas.Components.PC.IsOnline = True Then

                'obtener el id de la ultima tabla maestra 
                'objWS = New APPWebService.ws_pope_sede_tp.TablaMaestras
                'objWS.Url = APPWebService.PathURL.ws_pope_sede_TablaMaestra

                intIDTablaMaximo = objWS.Listar_IDMax(intIDLicencia, strMensajeError)

                If strMensajeError.Trim <> "" Then
                    strMensaje = "Se han encontrados algunos errores:" & strMensajeError
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensaje)
                    Exit Sub
                End If

                'recorremos todas las tablas maestras, para actualizarlo
                For i As Integer = 0 To intIDTablaMaximo

                    strMensajeError = ""
                    objDataTable = New System.Data.DataTable

                    If Legolas.Components.PC.IsOnline = True Then

                        lngFecha = TablaFecha(i, strMensajeError)

                        'la fecha de registro debe ser mayor a cero 

                        If lngFecha >= 0 Then
                            'objWS = New APPWebService.ws_pope_sede_tp.TablaMaestras
                            'objWS.Url = APPWebService.PathURL.ws_pope_sede_TablaMaestra
                            objDataTable = objWS.Listar(intIDLicencia, i, lngFecha, strMensajeError)
                        End If

                    End If

                    If strMensajeError.Trim <> "" Then

                        strMensaje = "No se pudo sincronizar la tabla ID : " & i.ToString & Chr(13)
                        strMensaje = strMensaje & "Error : " & strMensajeError
                        Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensaje)

                        If i = 0 Then
                            Me.Close()
                        End If

                    Else

                        If objDataTable Is Nothing Then
                            'no hay registros
                        Else

                            BarraProgreso(objDataTable.TableName, i, intIDTablaMaximo)

                            If objDataTable.Rows.Count > 0 Then

                                If InsertUpdateTabla_v2(objDataTable) = False Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                                        "No se pudo sincronizar la tabla : " & objDataTable.TableName.ToUpper & ". Por no contar con el campo identity")
                                End If

                            Else
                                'no hace nada
                            End If

                            'objWS.Dispose()
                            'objWS = Nothing

                        End If

                    End If

                Next

                objWS.Dispose()
                objWS = Nothing

                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()

            End If

            Me.Cursor = Cursors.Default

        End Sub

#End Region
#Region "SQL_Creator"
        Private Function TablaFecha(IDTabla As Integer, ByRef MensajeError As String) As Long

            Dim value As Long = 0
            Dim strQuery As String = ""
            Dim strQuery2 As String = ""
            Dim strNombreTabla As String = ""
            Dim objDataTable As DataTable = Nothing
            Dim strMensajeError As String = ""

            Select Case IDTabla
                Case 0
                    strQuery = "select 'SIS_Tabla'"
                Case Else
                    strQuery = "select tbl_nom from sis_tabla where tbl_id=" & IDTabla
            End Select

            ' ''mensaje de prueba
            'If IDTabla = 37 Then
            '    MessageBox.Show(IDTabla)
            'End If

            'seleccionamos el nombre de la tabla 
            sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            objDataTable = New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strQuery)

            For Each fila As System.Data.DataRow In objDataTable.Rows

                strNombreTabla = fila(0).ToString

            Next

            'verificar si la tabla existe en la bd local
            sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            If Legolas.Components.SQL.ExisteTabla(sqlcn, strNombreTabla) = False Then
                Return value
            End If

            'preguntamos si el campo "_fec_mod", existe en la tabla a consultar
            sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            If Legolas.Components.SQL.ExisteCampo(sqlcn, strNombreTabla, "_fec_mod") = True Then

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
                    MensajeError = "Se ha producido un error en la tabla: " & strNombreTabla & ". Error :" & strMensajeError
                    Return -1
                End If

            End If

            Return value

        End Function
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
        Private Function InsertUpdateTabla_v2(objDataTable As System.Data.DataTable) As Boolean

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

            'verificar si la tabla existe en la bd local
            sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            If Legolas.Components.SQL.ExisteTabla(sqlcn, strTablaNombre) = False Then
                Return True
            End If

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
            Dim blnPrimerInsert As Boolean = True

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

                    If blnPrimerInsert = True Then

                        'insert on
                        cmdIdOn = New SqlCommand
                        cmdIdOn.Connection = sql_cn_query
                        cmdIdOn.CommandType = CommandType.Text
                        cmdIdOn.CommandText = "SET IDENTITY_INSERT " & strTablaNombre & " ON"
                        cmdIdOn.ExecuteNonQuery()

                        blnPrimerInsert = False
                    End If

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

                        'insert del registro 
                        cmdIns.CommandText = strQuery
                        cmdIns.ExecuteNonQuery()

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

            If blnPrimerInsert = False Then
                'insert off
                cmdIdOff = New SqlCommand
                cmdIdOff.Connection = sql_cn_query
                cmdIdOff.CommandType = CommandType.Text
                cmdIdOff.CommandText = "SET IDENTITY_INSERT " & strTablaNombre & " OFF"
                cmdIdOff.ExecuteNonQuery()
            End If

            value = True

            sql_cn_query.Close()
            sql_cn_query = Nothing

            Return value

        End Function
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()

            Me.ProgressBar1.Minimum = 0
            Me.ProgressBar1.Maximum = 100

        End Sub

#End Region


        Private Sub frmActualizarWeb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            CheckForIllegalCrossThreadCalls = False
            ValoresxDefault()

        End Sub
        Private Sub frmActualizarWeb_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.Refresh()
            btnOk_Click(sender, e)

        End Sub


        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

            Dim strMensaje As String = ""
            strMensaje = "Desea sincronizar los registros con la sede central"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> Windows.Forms.DialogResult.Yes Then
                Me.Refresh()
                Me.Close()
                Exit Sub
            End If

            ActualizarData()
            Me.Close()

        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub


    End Class

End Namespace