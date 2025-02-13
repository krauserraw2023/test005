Public Class MigracionesConsulta
    Public Function WS_ConsultarExtranjero(strCNBD As String, intTipoDocumento As Short, strNumeroDoc As String) As Result.ConsultarExtranjero

        Dim value As Result.ConsultarExtranjero

        Dim objWS As New APPWebService.ws_migraciones_consulta.Service1
        Dim objDTOResult As APPWebService.ws_migraciones_consulta.ResultEOfMigracionesE44rCQrf7 = Nothing
        Dim objResult As New APPWebService.ws_migraciones_consulta.MigracionesE

        If Legolas.Components.PC.IsOnline = True Then

            objDTOResult = New APPWebService.ws_migraciones_consulta.ResultEOfMigracionesE44rCQrf7
            objDTOResult = objWS.Consultar_extranjero(intTipoDocumento, True, strNumeroDoc)

            If objDTOResult.Error_cod = 0 Then

                value = New Result.ConsultarExtranjero
                objResult = objDTOResult.Resultado

                With objResult
                    value.IDTipoDocumento = intTipoDocumento
                    value.NumeroCE = .NumeroCE
                    value.NumeroPTP = .Numero_PTP
                    value.PrimerApellido = Legolas.Components.Cadena.SinTildes(.ApePaterno)
                    value.SegundoApellido = Legolas.Components.Cadena.SinTildes(.ApeMaterno)
                    value.Nombres = Legolas.Components.Cadena.SinTildes(.Nombres)
                    value.FechaNacimientoCadena = .Fecha_Nacimiento
                    value.SexoCadena = .Genero
                    value.NacionalidadCadena = .PaisNacionalidad.Trim
                    value.IDNacionalidad = fn_IDNacionalidad(strCNBD, value.NacionalidadCadena)
                    value.CalidadMigratoria = .CalidadMigratorias
                    value.FotoCadena = .foto
                    value.ErrorCodigo = 0 'sin error 
                    value.ErrorMensaje = objDTOResult.Error_Mensaje
                End With

            Else
                value = New Result.ConsultarExtranjero
                value.ErrorCodigo = objDTOResult.Error_cod
                value.ErrorMensaje = objDTOResult.Error_Mensaje
            End If

        End If

        Return value

    End Function
    Private Function fn_IDNacionalidad(strCNBD As String, strNombreNacionalidad As String) As Integer

        Dim value As Integer = -1
        Dim strNombre As String = ""

        Select Case strNombreNacionalidad.ToUpper
            Case "EE.UU".ToUpper
                strNombre = "ESTADOUNIDENSE"
            Case "CHINA (R.P)".ToUpper
                strNombre = "CHINA"
            Case Else
                strNombre = strNombreNacionalidad
        End Select

        Dim strMensajeOut As String = ""
        Dim objDT As New DataTable
        Dim strSQL As String = "select par_id from GEN_Nacionalidad 
                where _flg_eli=0 and (pai_nom like '%" & strNombre & "%' or  par_nom like '%" & strNombre & "%')"

        Using sqlCN As New SqlClient.SqlConnection(strCNBD)
            objDT = Legolas.Components.SQL.Select_DataTable(sqlCN, strSQL, strMensajeOut)

            If objDT.Rows.Count > 0 Then
                value = objDT.Rows.Item(0).Item("par_id").ToString()
            End If

        End Using

        Return value

    End Function
End Class
