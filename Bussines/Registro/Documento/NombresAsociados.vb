Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.Documento
    Public Class NombresAsociados
        Private objEnt As Entity.Registro.Documento.NombresAsociados = Nothing
        Private objEntCol As Entity.Registro.Documento.NombresAsociadosCol = Nothing
#Region "Funciones"
        Public Function ValidarDocumento(InternoId As Integer, IngresoInpeID As Integer, NombreAsociadoId As Integer) As Integer
            'jeu 04052019 actualizado
            Return Data.Registro.Documento.NombresAsociados.ListarOutput_LM("lst", "lst_val_documento_id_LM", InternoId, IngresoInpeID, NombreAsociadoId)
        End Function


#End Region
#Region "Listar"


        Public Function Listar(objEnt As Entity.Registro.Documento.NombresAsociados) As Entity.Registro.Documento.NombresAsociadosCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.NombresAsociados.Listar(sqlCon, "lst", "lst_grilla", objEnt)

            Try
                objEntCol = New Entity.Registro.Documento.NombresAsociadosCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.NombresAsociados
                        With objEnt
                            .Codigo = sqlDr("doc_int_nom_aso_id").ToString
                            .InternoNombreAsociadoID = sqlDr("int_nom_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                            .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                            .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                            .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                            .NAEstado = sqlDr("doc_int_nom_aso_est").ToString
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
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

        Public Function Listar_v2(objEnt As Entity.Registro.Documento.NombresAsociados) As Entity.Registro.Documento.NombresAsociadosCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.NombresAsociados.Listar(sqlCon, "lst", "lst_grilla_v2", objEnt)
            Dim DocumentoJudicialID As Integer = objEnt.DocumentoJudicialID
            Try
                objEntCol = New Entity.Registro.Documento.NombresAsociadosCol
                Dim pos As Integer = -1
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.NombresAsociados
                        With objEnt
                            .Posicion += 1
                            .Codigo = sqlDr("doc_int_nom_aso_id").ToString
                            .InternoNombreAsociadoID = sqlDr("int_nom_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            If DocumentoJudicialID < 1 Then
                                .NAEstado = -1
                                .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                .NANombres = sqlDr("doc_int_nom_aso_nom").ToString


                                '.NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                '.NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                '.NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                '.NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString
                            Else
                                .NAEstado = sqlDr("doc_int_nom_aso_est").ToString
                                .NAEstadoOri = sqlDr("doc_int_nom_aso_est").ToString
                                If .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then ' ingreso
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Ninguno Then 'no se hizo nada
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado Then 'aclarado
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Anulado Then 'anulado
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString

                                End If
                            End If

                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString

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
            End Try
            Return objEntCol
        End Function
        Public Function ListarLM(objEnt As Entity.Registro.Documento.NombresAsociados) As Entity.Registro.Documento.NombresAsociadosCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.NombresAsociados.Listar(sqlCon, "lst", "lst_mant", objEnt)

            Try
                objEntCol = New Entity.Registro.Documento.NombresAsociadosCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.NombresAsociados
                        With objEnt
                            .Codigo = sqlDr("doc_int_nom_aso_id").ToString
                            .InternoNombreAsociadoID = sqlDr("int_nom_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                            .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                            .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                            .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                            .NAEstado = sqlDr("doc_int_nom_aso_est").ToString
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
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
        'Listar_v2
        Public Function ListarGrilla_LM(objEnt As Entity.Registro.Documento.NombresAsociados) As Entity.Registro.Documento.NombresAsociadosCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.NombresAsociados.Listar(sqlCon, "lst", "lst_grilla_LM", objEnt)
            Dim DocumentoJudicialID As Integer = objEnt.DocumentoJudicialID
            Try
                objEntCol = New Entity.Registro.Documento.NombresAsociadosCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.NombresAsociados
                        With objEnt
                            .Codigo = sqlDr("doc_int_nom_aso_id").ToString
                            .InternoNombreAsociadoID = sqlDr("int_nom_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            If DocumentoJudicialID < 1 Then
                                .NAEstado = -1
                                .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                .NANombres = sqlDr("doc_int_nom_aso_nom").ToString

                            Else
                                .NAEstado = sqlDr("doc_int_nom_aso_est").ToString
                                .NAEstadoOri = sqlDr("doc_int_nom_aso_est").ToString
                                If .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then ' ingreso
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Ninguno Then 'no se hizo nada
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado Then 'aclarado
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Anulado Then 'anulado
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString

                                End If
                            End If
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString

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
            End Try
            Return objEntCol
        End Function
        Public Function Listar2_LM(objEnt As Entity.Registro.Documento.NombresAsociados) As Entity.Registro.Documento.NombresAsociadosCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.NombresAsociados.Listar(sqlCon, "lst", "lst_grilla2_LM", objEnt)
            Dim DocumentoJudicialID As Integer = objEnt.DocumentoJudicialID
            Try
                objEntCol = New Entity.Registro.Documento.NombresAsociadosCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.NombresAsociados
                        With objEnt
                            .Codigo = sqlDr("doc_int_nom_aso_id").ToString
                            .InternoNombreAsociadoID = sqlDr("int_nom_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            If DocumentoJudicialID < 1 Then
                                .NAEstado = -1
                                .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                .NANombres = sqlDr("doc_int_nom_aso_nom").ToString

                            Else
                                .NAEstado = sqlDr("doc_int_nom_aso_est").ToString
                                .NAEstadoOri = sqlDr("doc_int_nom_aso_est").ToString
                                If .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then ' ingreso
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Ninguno Then 'no se hizo nada
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado Then 'aclarado
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString
                                ElseIf .NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Anulado Then 'anulado
                                    .NAPrincipal = sqlDr("doc_int_nom_aso_pri").ToString
                                    .NAPaterno = sqlDr("doc_int_nom_aso_ape_pat").ToString
                                    .NAMaterno = sqlDr("doc_int_nom_aso_ape_mat").ToString
                                    .NANombres = sqlDr("doc_int_nom_aso_nom").ToString
                                    .NAPrincipal2 = sqlDr("doc_int_nom_aso_pri_acla").ToString
                                    .NAPaterno2 = sqlDr("doc_int_nom_aso_ape_pat_acla").ToString
                                    .NAMaterno2 = sqlDr("doc_int_nom_aso_ape_mat_acla").ToString
                                    .NANombres2 = sqlDr("doc_int_nom_aso_nom_acla").ToString

                                End If
                            End If
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString

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
            End Try
            Return objEntCol
        End Function
#End Region
#Region "Validar"
        Public Function ValidarDocumentoAclarados(ByVal InternoID As Integer, IngresoID As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "lst"
            strOpcion = "lst_validar_doc"
            intValue = Data.Registro.Documento.NombresAsociados.ListarOutput(strAccion, strOpcion, InternoID,
            IngresoID)
            Return intValue
        End Function

        Public Function ValidarDocumentoAclarados_LM(ByVal InternoID As Integer, IngresoInpeID As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "lst"
            strOpcion = "lst_validar_doc_LM"
            intValue = Data.Registro.Documento.NombresAsociados.ListarOutput_LM(strAccion, strOpcion, InternoID,
            IngresoInpeID)
            Return intValue
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(objDocNomAsoc As Entity.Registro.Documento.NombresAsociados) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If objDocNomAsoc.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If
            objDocNomAsoc.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Documento.NombresAsociados.Grabar(strAccion, strOpcion, objDocNomAsoc)

            Return intValue

        End Function
        Public Function Grabar_v2(objDocNomAsoc As Entity.Registro.Documento.NombresAsociados) As Integer

            'version nueva 
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If objDocNomAsoc.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2"
            End If
            objDocNomAsoc.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Documento.NombresAsociados.Grabar_v2(strAccion, strOpcion, objDocNomAsoc)

            Return intValue

        End Function

        Public Function Grabar_v2_LM(objDocNomAsoc As Entity.Registro.Documento.NombresAsociados) As Integer

            'version nueva 
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If objDocNomAsoc.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2_LM"
            End If
            objDocNomAsoc.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Documento.NombresAsociados.Grabar_LM(strAccion, strOpcion, objDocNomAsoc)

            Return intValue

        End Function

        Public Function ActualizarUltimoNA_LM(ByVal Codigo As Integer, InternoID As Integer, IngresoInpeID As Integer,
                                           intValueCodigo As Integer, EntNACop As Entity.Registro.Documento.NombresAsociados,
                                           Optional n_ActivarFlagTransferSede As Integer = 0) As Integer
            'ver buss 2
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            Dim intValue As Integer = -1
            Dim EntColNA As New Entity.Registro.Documento.NombresAsociadosCol
            EntColNA = New Entity.Registro.Documento.NombresAsociadosCol
            Dim EntNA As New Entity.Registro.Documento.NombresAsociados
            Dim BssNA As New Bussines.Registro.Documento.NombresAsociados

            EntNA.DocumentoJudicialID = intValueCodigo

            If intValueCodigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_ult_registroNA_LM"
                EntNA.InternoID = InternoID
                EntNA.IngresoID = -1
                EntNA.IngresoInpeId = IngresoInpeID
                EntNA.DocumentoJudicialID = intValueCodigo
                EntColNA = BssNA.ListarGrilla_LM(EntNA)
                For Each obj As Entity.Registro.Documento.NombresAsociados In EntColNA
                    obj.FlagTransferenciaSede = n_ActivarFlagTransferSede
                    intValue = Data.Registro.Documento.NombresAsociados.Eliminar_LM(strAccion, strOpcion, obj)
                Next
            Else
                strAccion = "upd"
                strOpcion = "upd_NombresNA"
                EntNACop.IngresoID = IngresoInpeID
                EntNACop.FlagTransferenciaSede = n_ActivarFlagTransferSede
                intValue = Data.Registro.Documento.NombresAsociados.Eliminar(strAccion, strOpcion, EntNACop)
            End If


            Return intValue
        End Function

        Public Function ActualizarUltimoNA(ByVal Codigo As Integer, InternoID As Integer, IngresoID As Integer,
                                           intValueCodigo As Integer, EntNACop As Entity.Registro.Documento.NombresAsociados,
                                           Optional n_ActivarFlagTransferSede As Integer = 0) As Integer
            'ver buss 2
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            Dim intValue As Integer = -1
            Dim EntColNA As New Entity.Registro.Documento.NombresAsociadosCol
            EntColNA = New Entity.Registro.Documento.NombresAsociadosCol
            Dim EntNA As New Entity.Registro.Documento.NombresAsociados
            Dim BssNA As New Bussines.Registro.Documento.NombresAsociados

            EntNA.DocumentoJudicialID = intValueCodigo

            If intValueCodigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_ult_registroNA"
                EntNA.InternoID = InternoID
                EntNA.IngresoID = IngresoID
                EntNA.DocumentoJudicialID = intValueCodigo
                EntColNA = BssNA.Listar_v2(EntNA)
                For Each obj As Entity.Registro.Documento.NombresAsociados In EntColNA
                    'obj.FlagTransferenciaSede = n_ActivarFlagTransferSede
                    intValue = Data.Registro.Documento.NombresAsociados.Eliminar(strAccion, strOpcion, obj)
                Next
            Else
                strAccion = "upd"
                strOpcion = "upd_NombresNA"
                EntNACop.IngresoID = IngresoID
                'EntNACop.FlagTransferenciaSede = n_ActivarFlagTransferSede
                intValue = Data.Registro.Documento.NombresAsociados.Eliminar(strAccion, strOpcion, EntNACop)
            End If


            Return intValue
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="EntNA"></param>
        ''' <param name="n_ActivarFlagTransferSede"></param>
        ''' <returns></returns>
        Public Function ActualizarNombrePrincipal_LM(EntNA As Entity.Registro.Documento.NombresAsociados,
                                           Optional n_ActivarFlagTransferSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim EntColNA As New Entity.Registro.Documento.NombresAsociadosCol
            EntColNA = New Entity.Registro.Documento.NombresAsociadosCol
            Dim BssNA As New Bussines.Registro.Documento.NombresAsociados

            If EntNA.Codigo > 0 Then
                Dim strAccion As String = "upd"
                Dim strOpcion As String = "upd_ape_nom_LM"
                EntNA.FlagTransferenciaSede = n_ActivarFlagTransferSede
                intValue = Data.Registro.Documento.NombresAsociados.Grabar_LM(strAccion, strOpcion, EntNA)
            End If
            Return intValue
        End Function
#End Region
#Region "Eliminar"

        Public Function Eliminar(ByVal Codigo As Integer, InternoID As Integer, IngresoID As Integer, Optional n_ActivarFlagTransferenciaSede As Integer = 0) As Integer
            'vr bussi 1
            Dim EntColNA As New Entity.Registro.Documento.NombresAsociadosCol
            Dim BssNA As New Bussines.Registro.Documento.NombresAsociados
            Dim EntNA As New Entity.Registro.Documento.NombresAsociados
            Dim EntNACop As New Entity.Registro.Documento.NombresAsociados

            EntNA.DocumentoJudicialID = Codigo
            EntNA.InternoID = InternoID
            EntNA.IngresoID = IngresoID
            EntColNA = BssNA.Listar_v2(EntNA)

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim intConta As Integer = -1
            Dim intValueCodigo As Integer = -1
            For Each obj As Entity.Registro.Documento.NombresAsociados In EntColNA
                strAccion = "del"
                strOpcion = "del_mant_doc_jud_id2"
                intConta = intConta + 1
                If obj.NAPrincipal = 1 And obj.NAEstado <> 0 Then
                    EntNACop = obj
                End If
                intValue = Data.Registro.Documento.NombresAsociados.Eliminar(strAccion, strOpcion, obj)
                If obj.InternoNombreAsociadoID > 0 Then
                    strAccion = "upd"
                    strOpcion = "upd_NAMayor"
                    Data.Registro.Documento.NombresAsociados.Grabar_v2(strAccion, strOpcion, obj)
                End If
            Next
            Dim bssHis As New Bussines.Registro.InternoHistorico
            Dim entHis As New Entity.Registro.InternoHistorico
            entHis.InternoID = InternoID
            entHis.IngresoID = IngresoID
            intValueCodigo = bssHis.Validar_DocumentoID(entHis)
            'Actualizar ultimo registro ANOMBRE ASOCIADO
            intValue = ActualizarUltimoNA(Codigo, InternoID, IngresoID, intValueCodigo, EntNACop)
            Return intValue
        End Function

        Public Function Eliminar_LM(ByVal Codigo As Integer, InternoID As Integer, IngresoInpeID As Integer, Optional n_ActivarFlagTransferenciaSede As Integer = 0) As Integer
            'vr bussi 1
            Dim EntColNA As New Entity.Registro.Documento.NombresAsociadosCol
            Dim BssNA As New Bussines.Registro.Documento.NombresAsociados
            Dim EntNA As New Entity.Registro.Documento.NombresAsociados
            Dim EntNACop As New Entity.Registro.Documento.NombresAsociados

            EntNA.DocumentoJudicialID = Codigo
            EntNA.InternoID = InternoID
            EntNA.IngresoID = -1
            EntNA.IngresoInpeId = IngresoInpeID
            EntColNA = BssNA.ListarGrilla_LM(EntNA)

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim intConta As Integer = -1
            Dim intValueCodigo As Integer = -1
            For Each obj As Entity.Registro.Documento.NombresAsociados In EntColNA
                obj.FlagTransferenciaSede = n_ActivarFlagTransferenciaSede
                strAccion = "del"
                strOpcion = "del_mant_doc_jud_id2_LM"
                intConta = intConta + 1
                If obj.NAPrincipal = 1 And obj.NAEstado <> 0 Then
                    EntNACop = obj
                End If
                intValue = Data.Registro.Documento.NombresAsociados.Eliminar_LM(strAccion, strOpcion, obj)
                If obj.InternoNombreAsociadoID > 0 Then
                    strAccion = "upd"
                    strOpcion = "upd_NAMayor_LM"
                    Data.Registro.Documento.NombresAsociados.Grabar_LM(strAccion, strOpcion, obj)
                End If
            Next
            Dim bssHis As New Bussines.Registro.InternoHistorico
            Dim entHis As New Entity.Registro.InternoHistorico
            entHis.InternoID = InternoID
            entHis.IngresoID = -1
            entHis.IngresoInpeId = IngresoInpeID
            intValueCodigo = bssHis.Validar_DocumentoID_LM(entHis)
            'Actualizar ultimo registro ANOMBRE ASOCIADO
            EntNACop.FlagTransferenciaSede = n_ActivarFlagTransferenciaSede
            intValue = ActualizarUltimoNA_LM(Codigo, InternoID, IngresoInpeID, intValueCodigo, EntNACop)
            Return intValue
        End Function
        Public Function EliminarDocumentoNA_LM(ByVal Codigo As Integer, InternoID As Integer, IngresoInpeID As Integer, Optional n_ActivarFlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim EntColNA As New Entity.Registro.Documento.NombresAsociadosCol
            Dim BssNA As New Bussines.Registro.Documento.NombresAsociados
            Dim EntNA As New Entity.Registro.Documento.NombresAsociados
            Dim EntNACop As New Entity.Registro.Documento.NombresAsociados

            EntNA.DocumentoJudicialID = Codigo
            EntNA.InternoID = InternoID
            EntNA.IngresoID = -1
            EntNA.IngresoInpeId = IngresoInpeID
            EntColNA = BssNA.ListarGrilla_LM(EntNA)

            For Each obj As Entity.Registro.Documento.NombresAsociados In EntColNA
                intValue = EliminarDoc_LM(obj, EntNA.DocumentoJudicialID, obj.InternoID, obj.IngresoInpeId)
            Next

            Return intValue
        End Function
        Public Function EliminarDoc_LM(objNADoc As Entity.Registro.Documento.NombresAsociados, ByVal Codigo As Integer, InternoID As Integer, IngresoInpeID As Integer, Optional n_ActivarFlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = "del"
            Dim strOpcion As String = "del_mant_doc_na_LM"

            intValue = Data.Registro.Documento.NombresAsociados.Eliminar_LM(strAccion, strOpcion, objNADoc)
        End Function
#End Region
    End Class
End Namespace