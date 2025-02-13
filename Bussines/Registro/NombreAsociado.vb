Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class NombreAsociado
        Private objEnt As Entity.Registro.NombreAsociado = Nothing
        Private objEntCol As Entity.Registro.NombreAsociadoCol = Nothing
#Region "Funciones"
        Public Function ListarNombresAsociados(intIDInterno As Integer) As String

            Dim value As String = ""
            Dim objEntFiltro As New Entity.Registro.NombreAsociado
            objEntCol = New Entity.Registro.NombreAsociadoCol

            With objEntFiltro
                .InternoID = intIDInterno
                .Principal = 0 'asociados
                .Estado = 1 'activos
            End With

            objEntCol = Listar_Grilla_v2(objEntFiltro)

            Dim strNombreAsoc As String = ""

            For Each obj As Entity.Registro.NombreAsociado In objEntCol
                strNombreAsoc = obj.ApellidosyNombres
                value = value & strNombreAsoc & "; "
            Next

            'If value.Trim.Length > 0 Then
            '    value = value.Substring(1, value.Length - 1)
            'End If

            Return value

        End Function
#End Region

#Region "Listar"
        Public Function Listar_LM(ByVal Codigo As Integer) As Entity.Registro.NombreAsociado
            Dim objEnt As New Entity.Registro.NombreAsociado
            Dim col As Entity.Registro.NombreAsociadoCol
            objEnt.Codigo = Codigo
            col = Listar_LM(objEnt)
            If col.Count = 0 Then Return Nothing
            Return col.NombreAsociado(0)
        End Function

        Public Function Listar_LM(ByVal objEntFiltro As Entity.Registro.NombreAsociado) As Entity.Registro.NombreAsociadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar_LM(sqlCon, "lst", "lst_mant_LM", objEntFiltro)

            Try
                Dim conta As Integer = 0
                objEntCol = New Entity.Registro.NombreAsociadoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.NombreAsociado
                        With objEnt
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.NombreAsociado
            Dim objEnt As New Entity.Registro.NombreAsociado
            objEnt.Codigo = Codigo
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar(sqlCon, "lst", "lst_mant", objEnt)

            objEnt = New Entity.Registro.NombreAsociado
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function Listar(ByVal objEntFiltro As Entity.Registro.NombreAsociado) As Entity.Registro.NombreAsociadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            Try
                Dim conta As Integer = 0
                objEntCol = New Entity.Registro.NombreAsociadoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.NombreAsociado
                        With objEnt
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function Listar_Grilla_v2(ByVal objEntFiltro As Entity.Registro.NombreAsociado) As Entity.Registro.NombreAsociadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar(sqlCon, "lst", "lst_grilla_v2", objEntFiltro)

            Try
                objEntCol = New Entity.Registro.NombreAsociadoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.NombreAsociado
                        With objEnt
                            '.Numero = conta + 1
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarNombresAsociadosxIngreso(ByVal objEntFiltro As Entity.Registro.NombreAsociado) As Entity.Registro.NombreAsociadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar(sqlCon, "lst", "lst_grilla_x_ingreso", objEntFiltro)

            Try
                objEntCol = New Entity.Registro.NombreAsociadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.NombreAsociado
                        With objEnt
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .DocumentoNombreAsociadoID = sqlDr("doc_int_nom_aso_id").ToString
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumentoExiste = IIf(.DocumentoJudicialID > 0, True, False)
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarNombresAsocxIngInpe_LM(ByVal objEntFiltro As Entity.Registro.NombreAsociado, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.Registro.NombreAsociadoCol
            Dim opc As String = ""
            opc = "lst_grilla_lm"
     
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar_LM(sqlCon, "lst", opc, objEntFiltro)

            Try
                objEntCol = New Entity.Registro.NombreAsociadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.NombreAsociado
                        With objEnt
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                            '.IngresoID = sqlDr("int_ing_id").ToString
                            '.IngresoNro = sqlDr("int_ing_nro").ToString
                            .IngresoNroInpe = sqlDr("ing_inp_nro").ToString
                            .DocumentoNombreAsociadoID = sqlDr("doc_int_nom_aso_id").ToString
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumentoExiste = IIf(.DocumentoJudicialID > 0, True, False)
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .DocumentoReferencia = sqlDr("doc_ref").ToString
                            .Observacion = sqlDr("obs").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
#End Region
#Region "Validar"
        Public Function ValidarNombre(ByVal objEnt As Entity.Registro.NombreAsociado) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = -1

            intValue = Data.Registro.NombreAsociado.ListarOutput("lst", "lst_validar", objEnt)

            If intValue > 0 Then
                blnValue = False
            End If

            Return blnValue
        End Function
        Public Function ValidarNombre2(ByVal objEnt As Entity.Registro.NombreAsociado) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = -1
            Dim opcion As String = ""
            If objEnt.Codigo < 1 Then
                opcion = "lst_validarnombre2"
            Else
                opcion = "lst_validarUpd"
            End If

            intValue = Data.Registro.NombreAsociado.ListarOutput("lst", opcion, objEnt)
            If intValue = 0 Then
                blnValue = False
            End If

            Return blnValue
        End Function

        Public Function ValidarNombre_LM(ByVal objEnt As Entity.Registro.NombreAsociado) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = -1
            Dim opcion As String = ""
            If objEnt.Codigo < 1 Then
                opcion = "lst_validarnombre_lm"
            Else
                opcion = "lst_validarUpd_lm"
            End If

            intValue = Data.Registro.NombreAsociado.ListarOutput("lst", opcion, objEnt)
            If intValue = 0 Then
                blnValue = False
            End If

            Return blnValue
        End Function
#End Region
#Region "Grabar"

        Public Function Grabar(ByVal ObjEnt As Entity.Registro.NombreAsociado) As Integer
            'usa la version antigua
            Dim intDocJudNomAsoID As Integer = ObjEnt.DocumentoNomAsociadoId
            Dim value As Integer = -1
            '/**********************/
            Dim intValue As Integer = -1
            Dim intOldCodigo As Integer = -1
            Dim intOldPrincipal As Integer = 0
            Dim strOldApePaterno As String = ""
            Dim strOldApeMaterno As String = ""
            Dim strOldNombres As String = ""
            Dim intOldEstado As Integer = -1

            If ObjEnt.Principal = 1 Then 'si es principal, sacar la copia del anterior principal

                Dim objEntTmp As New Entity.Registro.NombreAsociado
                objEntTmp.Codigo = -1
                objEntTmp.InternoID = ObjEnt.InternoID
                objEntTmp.Estado = 1

                Dim objEntCol As New Entity.Registro.NombreAsociadoCol
                objEntCol = Listar(objEntTmp) 'activos

                For Each obj As Entity.Registro.NombreAsociado In objEntCol
                    With obj
                        If .Principal = 1 Then 'el old principal, recuperar todos los datos
                            intOldCodigo = .Codigo
                            strOldApePaterno = .ApellidoPaterno
                            strOldApeMaterno = .ApellidoMaterno
                            strOldNombres = .Nombres
                            intOldEstado = .Estado
                            Exit For
                        End If
                    End With
                Next
            Else
                'nada
            End If

            value = GrabarNA(ObjEnt)

            If value > 0 Then
                Dim objBssNA As New Bussines.Registro.Documento.NombresAsociados
                'ingresamos los datos del nombre asociado old, si hay codigo
                'If intOldCodigo > 0 Then
                '    objBssNA = New Bussines.Registro.Documento.NombresAsociados

                '    intValue = objBssNA.Grabar(-1, intOldCodigo, ObjEnt.InternoID, ObjEnt.DocumentoJudicialID, _
                '                               intOldPrincipal, strOldApePaterno, strOldApeMaterno, _
                '                               strOldNombres, intOldEstado, ObjEnt.RegionID, ObjEnt.PenalID)
                'End If
                'detalle nombres asociados
                objBssNA = New Bussines.Registro.Documento.NombresAsociados
                Dim objEntNA As New Entity.Registro.Documento.NombresAsociados
                With objEntNA
                    .Codigo = intDocJudNomAsoID
                    .InternoNombreAsociadoID = value
                    .InternoID = ObjEnt.InternoID
                    .DocumentoJudicialID = ObjEnt.DocumentoJudicialID
                    .NAPrincipal = ObjEnt.Principal
                    .NAPaterno = ObjEnt.ApellidoPaterno
                    .NAMaterno = ObjEnt.ApellidoMaterno
                    .NANombres = ObjEnt.Nombres
                    .NAEstado = ObjEnt.Estado
                    .RegionID = ObjEnt.RegionID
                    .PenalID = ObjEnt.PenalID
                End With
                intValue = objBssNA.Grabar(objEntNA)
             
            End If

            Return value

        End Function

        Private Function GrabarNA(ByVal objEnt As Entity.Registro.NombreAsociado) As Integer
            'usa la version antigua
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
                If ValidarNombre(objEnt) = False Then
                    intValue = -1
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El Nombre Asociado ya existe")
                    Return intValue
                End If
                intValue = Data.Registro.NombreAsociado.Grabar(strAccion, strOpcion, objEnt)
            Else

                strAccion = "upd"
                strOpcion = "upd_mant"
                intValue = Data.Registro.NombreAsociado.Grabar(strAccion, strOpcion, objEnt)

            End If


            Return intValue

        End Function

        Public Function GrabarNA2(ByVal objEnt As Entity.Registro.NombreAsociado) As Integer
            'paso 1
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_man_v5"

                intValue = Data.Registro.NombreAsociado.Grabar_V2(strAccion, strOpcion, objEnt)
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_v5"
                If ValidarNombre2(objEnt) = False Then
                    intValue = objEnt.Codigo
                Else
                    intValue = Data.Registro.NombreAsociado.Grabar_V2(strAccion, strOpcion, objEnt)
                End If
            End If
            Return intValue

        End Function

        Public Function GrabarNA2_LM(ByVal objEnt As Entity.Registro.NombreAsociado) As Integer
            'paso 1
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            objEnt.FlagTransferenciaSede = 1

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_lm"

                intValue = Data.Registro.NombreAsociado.Grabar_LM(strAccion, strOpcion, objEnt)
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_lm"
                If ValidarNombre2(objEnt) = False Then
                    intValue = objEnt.Codigo
                Else
                    intValue = Data.Registro.NombreAsociado.Grabar_LM(strAccion, strOpcion, objEnt)
                End If
            End If
            Return intValue
        End Function

        ''' <summary>
        ''' 03/05/2019 - hnrb
        ''' Registro de nombre asociado sin documento de aclaratoria, valido solo para ORL
        ''' </summary>
        ''' <param name="objEnt"></param>
        ''' <returns></returns>
        Public Function GrabarSinDoc_ORL(ByVal objEnt As Entity.Registro.NombreAsociado) As Integer
            'paso 1
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            objEnt.FlagTransferenciaSede = 1

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_ORL_sin_doc"

                intValue = Data.Registro.NombreAsociado.Grabar_LM(strAccion, strOpcion, objEnt)
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_ORL_sin_doc"
                'If ValidarNombre2(objEnt) = False Then
                '    intValue = objEnt.Codigo
                'Else
                intValue = Data.Registro.NombreAsociado.Grabar_LM(strAccion, strOpcion, objEnt)
                'End If
            End If
            Return intValue
        End Function

        Public Function GrabarNA_Car(ByVal objEnt As Entity.Registro.NombreAsociado) As Integer
            'paso 1
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_carceleta"

                intValue = Data.Registro.NombreAsociado.Grabar_LM(strAccion, strOpcion, objEnt)
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_lm"
                If ValidarNombre2(objEnt) = False Then
                    intValue = objEnt.Codigo
                Else
                    intValue = Data.Registro.NombreAsociado.Grabar_LM(strAccion, strOpcion, objEnt)
                End If
            End If
            Return intValue
        End Function

        Public Function GrabarEstado(ByVal Codigo As Integer, ByVal Estado As Integer) As Integer
            Dim objEnt As New Entity.Registro.NombreAsociado
            objEnt.Codigo = Codigo
            objEnt.Estado = Estado

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_estado"

            intValue = Data.Registro.NombreAsociado.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function GrabarIngreso(ByVal Codigo As Integer, ByVal Ingreso As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim objEnt As New Entity.Registro.NombreAsociado
            objEnt.Codigo = Codigo
            objEnt.IngresoID = Ingreso
            'objEnt.FlagTransferenciaSede = FlagTransferenciaSede

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ingreso"

            intValue = Data.Registro.NombreAsociado.Grabar_V2(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function GrabarIngreso_LM(ByVal Codigo As Integer, ByVal ingresoInpeId As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim objEnt As New Entity.Registro.NombreAsociado
            objEnt.Codigo = Codigo
            objEnt.IngresoInpeID = ingresoInpeId
            objEnt.FlagTransferenciaSede = FlagTransferenciaSede

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ingreso_inpe"

            intValue = Data.Registro.NombreAsociado.Grabar_LM(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
#End Region
#Region "Eliminar"
        'hnrb->23-06-2014
        Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.NombreAsociado.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)
            Return intValue
        End Function
        Public Function Eliminar(ent As Entity.Registro.Documento.NombresAsociados, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_nom_lm"
            intValue = Data.Registro.NombreAsociado.Eliminar(strAccion, strOpcion, ent, Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)
            Return intValue
        End Function

#End Region
    End Class
End Namespace