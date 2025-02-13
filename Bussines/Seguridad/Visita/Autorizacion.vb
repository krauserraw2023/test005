Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Autorizacion
        Private objEnt As Entity.Visita.Autorizacion = Nothing
        Private objEntCol As Entity.Visita.AutorizacionCol = Nothing
        Private objEntCol2 As List(Of Entity.Visita.Autorizacion) = Nothing
#Region "Validar"
        Public Function ValidarVerificarVisitante(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Boolean

            Dim value As Boolean = False
            Dim intCount As Integer = 0

            intCount = Data.Visita.Autorizacion.ListarOutput("lst", "lst_verificar_visitante", objEntFiltro)

            If intCount > 0 Then
                value = True
            End If

            Return value

        End Function

        Public Function ValidarSumaVisitanteAutorizacionActivos(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Integer

            Dim intCount As Integer = 0

            intCount = Data.Visita.Autorizacion.ListarOutput("lst", "lst_suma_visitante_autorizados_activos", objEntFiltro)

            Return intCount

        End Function

        Public Function ValidarSumaVisitaPorInterno(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Integer

            Dim intCount As Integer = 0

            intCount = Data.Visita.Autorizacion.ListarOutput("lst", "lst_suma_visita_por_interno_nuevo", objEntFiltro)

            Return intCount

        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.Autorizacion

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Visita.Autorizacion
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Visita.Autorizacion.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            objEnt = New Entity.Visita.Autorizacion
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("aut_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .InternoApeNom = sqlDr("int_ape_nom").ToString
                            'datos de la visita
                            .VisitanteID = sqlDr("vis_id").ToString
                            .VisitantePrimerApe = sqlDr("vis_ape_pat").ToString
                            .VisitanteSegundoApe = sqlDr("vis_ape_mat").ToString
                            .VisitanteNombres = sqlDr("vis_nom").ToString
                            .VisitanteApeNom = sqlDr("vis_ape_nom").ToString
                            .VisitanteTipoDocumentoNombre = sqlDr("vis_tip_doc_nom").ToString
                            .VisitanteNumeroDocumento = sqlDr("vis_num_doc").ToString
                            '******************
                            .TipoID = sqlDr("aut_tip_id").ToString
                            .CalendarioDetalleID = sqlDr("cal_det_id").ToString
                            .Documento = sqlDr("aut_doc").ToString
                            .Fecha = sqlDr("aut_doc_fec").ToString                         
                            .ParentescoID = sqlDr("par_id").ToString
                            .EstadoID = sqlDr("aut_est_id").ToString
                            .Observacion = sqlDr("aut_obs").ToString
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
        Public Function ListarExtraordinario(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Entity.Visita.AutorizacionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Autorizacion.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.AutorizacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Autorizacion
                        With objEnt
                            .Codigo = sqlDr("aut_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .InternoApeNom = sqlDr("int_ape_nom").ToString
                            .VisitanteID = sqlDr("vis_id").ToString
                            .VisitanteTipoDocumentoNombre = sqlDr("vis_tip_doc_nom").ToString
                            .VisitanteNumeroDocumento = sqlDr("vis_num_doc").ToString
                            .VisitanteApeNom = sqlDr("vis_ape_nom").ToString
                            .TipoID = sqlDr("aut_tip_id").ToString
                            .CalendarioDetalleID = sqlDr("cal_det_id").ToString
                            .Documento = sqlDr("aut_doc").ToString
                            .Fecha = sqlDr("aut_doc_fec").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .Parentesco = sqlDr("par_nom").ToString
                            .EstadoID = sqlDr("aut_est_id").ToString
                            .Observacion = sqlDr("aut_obs").ToString
                            'cadena-propio
                            .InternoApeNom = Legolas.Components.Cadena.ProperCase(.InternoApeNom)
                            .VisitanteApeNom = Legolas.Components.Cadena.ProperCase(.VisitanteApeNom)
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
        Public Function Listar(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Entity.Visita.AutorizacionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Autorizacion.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.AutorizacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Autorizacion
                        With objEnt
                            .Codigo = sqlDr("aut_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .InternoApeNom = sqlDr("int_ape_nom").ToString
                            .VisitanteID = sqlDr("vis_id").ToString
                            .VisitanteTipoDocumentoNombre = sqlDr("vis_tip_doc_nom").ToString
                            .VisitanteNumeroDocumento = sqlDr("vis_num_doc").ToString
                            .VisitanteApeNom = sqlDr("vis_ape_nom").ToString
                            .TipoID = sqlDr("aut_tip_id").ToString
                            .CalendarioDetalleID = sqlDr("cal_det_id").ToString
                            .Documento = sqlDr("aut_doc").ToString
                            .Fecha = sqlDr("aut_doc_fec").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .Parentesco = sqlDr("par_nom").ToString
                            .EstadoID = sqlDr("aut_est_id").ToString
                            .Observacion = sqlDr("aut_obs").ToString

                            .Usuario_Registro = sqlDr("usu_registro").ToString
                            .Fecha_Registro = sqlDr("fec_registro").ToString
                            'cadena-propio
                            .InternoApeNom = Legolas.Components.Cadena.ProperCase(.InternoApeNom)
                            .VisitanteApeNom = Legolas.Components.Cadena.ProperCase(.VisitanteApeNom)
                        End With

                        If (objEnt.TipoID <> 99) Then 'extra 
                            objEntCol.Add(objEnt)
                        End If

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
        Public Function ListarVisitante(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Entity.Visita.AutorizacionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Autorizacion.Listar(sqlCon, "lst", "lst_visitante", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.AutorizacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Autorizacion
                        With objEnt
                            .Codigo = sqlDr("aut_id").ToString
                            .InternoID = sqlDr("int_id").ToString                            
                            .VisitanteID = sqlDr("vis_id").ToString                            
                            .ParentescoID = sqlDr("par_id").ToString
                            .Parentesco = sqlDr("par_nom").ToString
                            .EstadoID = sqlDr("aut_est_id").ToString
                            .Observacion = sqlDr("aut_obs").ToString
                            'cadena-propio
                            .InternoApeNom = Legolas.Components.Cadena.ProperCase(.InternoApeNom)
                            .VisitanteApeNom = Legolas.Components.Cadena.ProperCase(.VisitanteApeNom)
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
        Public Function ListarVisitante_Extraordinario(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Entity.Visita.AutorizacionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Autorizacion.Listar(sqlCon, "lst", "lst_visitante_extraordinario", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.AutorizacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Autorizacion
                        With objEnt
                            .Codigo = sqlDr("aut_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .VisitanteID = sqlDr("vis_id").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .Parentesco = sqlDr("par_nom").ToString
                            .EstadoID = sqlDr("aut_est_id").ToString
                            .Observacion = sqlDr("aut_obs").ToString
                            'cadena-propio
                            .InternoApeNom = Legolas.Components.Cadena.ProperCase(.InternoApeNom)
                            .VisitanteApeNom = Legolas.Components.Cadena.ProperCase(.VisitanteApeNom)
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
        Public Function ListarExtraordinario_MenorEdad(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Entity.Visita.AutorizacionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Autorizacion.Listar(sqlCon, "lst", "lst_visitante_extraordinario", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.AutorizacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Autorizacion
                        With objEnt
                            .Codigo = sqlDr("aut_id").ToString
                            .CalendarioDetalleID = sqlDr("cal_det_id").ToString
                            .TipoID = sqlDr("aut_tip_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .VisitanteID = sqlDr("vis_id").ToString
                            .IDTipoDocumentoVisitante = sqlDr("doc_tip_id").ToString
                            .VisitanteTipoDocumentoNombre = sqlDr("vis_tip_doc_nom").ToString
                            .VisitanteNumeroDocumento = sqlDr("vis_doc_num").ToString
                            .VisitantePrimerApe = sqlDr("vis_ape_pat").ToString.ToUpper
                            .VisitanteSegundoApe = sqlDr("vis_ape_mat").ToString.ToUpper
                            .VisitanteNombres = sqlDr("vis_nom").ToString.ToUpper
                            .VisitanteFechaNacimiento = sqlDr("vis_fec_nac").ToString
                            'parentesco
                            .ParentescoID = sqlDr("par_id").ToString
                            .Parentesco = sqlDr("par_nom").ToString
                        End With

                        'aqui se restringe las programaciones extraordinarias de menores de edad, fecha nacimiento mayor a cero y que sea menores a 18 años
                        With objEnt
                            If .VisitanteFechaNacimiento > 0 And objEnt.VisitanteEdad < 18 Then
                                objEntCol.Add(objEnt)
                            End If
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
            Return objEntCol
        End Function
#Region "Internos"
        Public Function ListarInternos(ByVal objEntFiltro As Entity.Visita.Autorizacion) As Entity.Visita.AutorizacionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Autorizacion.Listar(sqlCon, "lst", "lst_grilla_interno", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.AutorizacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Autorizacion
                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString
                            .InternoApePaterno = sqlDr("int_ape_pat").ToString
                            .InternoApeMaterno = sqlDr("int_ape_mat").ToString
                            .InternoNombres = sqlDr("int_nom").ToString
                            .InternoSitJuridica = sqlDr("sit_jur_nom").ToString
                            .InternoEstado = sqlDr("int_est_id").ToString
                            '/**/
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
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

            'Return objEntCol
            Dim objValue As New Entity.Visita.AutorizacionCol

            'llenar nombres asociados
            objValue = ListarNombresAsociadosAll(objEntCol, objEntFiltro.RegionID, objEntFiltro.PenalID)

            Return objValue

        End Function
        Private Function ListarNombresAsociadosAll(ByVal objEntCol As Entity.Visita.AutorizacionCol, ByVal RegionID As Integer, _
                                       ByVal PenalID As Integer) As Entity.Visita.AutorizacionCol

            'recorre los id de los internos filtrados
            Dim CadID As String = ""
            For Each interno As Entity.Visita.Autorizacion In objEntCol
                CadID = CadID & interno.InternoID & ","
            Next
            If CadID.Length > 0 Then
                CadID = CadID.Substring(0, CadID.Length - 1)
            End If

            'filtro de nombres asociados
            Dim objEntFiltroNA As New Entity.Registro.NombreAsociado
            Dim objEntColNA As New Entity.Registro.NombreAsociadoCol
            Dim objBss As New Bussines.Registro.NombreAsociado

            With objEntFiltroNA
                .InternoIDString = CadID
                .Principal = 0 'solo asociados
                .Estado = 1 'estado activos
                .RegionID = RegionID
                .PenalID = PenalID
            End With

            objEntColNA = objBss.Listar_Grilla_v2(objEntFiltroNA)

            '/**/
            Dim objEntAll As Entity.Visita.Autorizacion
            Dim objEntColAll As New Entity.Visita.AutorizacionCol

            For Each obj As Entity.Visita.Autorizacion In objEntCol

                objEntAll = New Entity.Visita.Autorizacion
                With objEntAll
                    .InternoCodigoPadre = 0
                    .InternoID = obj.InternoID
                    .InternoCodigo = obj.InternoCodigo
                    .InternoApePaterno = obj.InternoApePaterno
                    .InternoApeMaterno = obj.InternoApeMaterno
                    .InternoNombres = obj.InternoNombres
                    .InternoEstado = obj.InternoEstado
                    '/**/
                    .RegionID = obj.RegionID
                    .PenalID = obj.PenalID
                End With

                objEntColAll.Add(objEntAll)

                For Each obj2 As Entity.Registro.NombreAsociado In objEntColNA

                    If obj.InternoID = obj2.InternoID Then

                        objEntAll = New Entity.Visita.Autorizacion
                        With objEntAll
                            .InternoCodigoPadre = 1
                            .InternoID = obj2.InternoID
                            .InternoApePaterno = obj2.ApellidoPaterno
                            .InternoApeMaterno = obj2.ApellidoMaterno
                            .InternoNombres = obj2.Nombres
                            '/**/
                            .RegionID = obj.RegionID
                            .PenalID = obj.PenalID
                        End With
                        objEntColAll.Add(objEntAll)
                    End If
                Next
            Next
            Return objEntColAll
        End Function
#End Region
#End Region
#Region "Grabar"
        Public Function Validar(ByVal objEnt As Entity.Visita.Autorizacion, ByRef MensajeError As String) As Boolean
            Dim value As Boolean = True

            With objEnt
                'valor el id del visitante 
                If .VisitanteID < 1 Then
                    MensajeError = "No ha ingresado los datos del visitante"
                    Return value
                End If
            End With

            Return value
        End Function
        Public Function Grabar(ByVal objEnt As Entity.Visita.Autorizacion) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            'If Validar(objEnt, MensajeError) = False Then
            '    Return Value
            'End If

            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
            End With

            Value = Data.Visita.Autorizacion.Grabar(strAccion, strOpcion, objEnt)

            Return Value
        End Function
        Public Function GrabarAnulados(ByVal objEnt As Entity.Visita.Autorizacion) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "ins"
            strOpcion = "ins_anulados" 'inactivo 0

            'With objEnt                
            '    objEnt.EstadoID = 1 'activo
            'End With

            Value = Data.Visita.Autorizacion.Grabar(strAccion, strOpcion, objEnt)

            Return Value
        End Function
        Public Function GrabarEstadoInactivo(ByVal Codigo As Integer) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_estado" 'inactivo 0

            Dim objEnt As New Entity.Visita.Autorizacion

            With objEnt
                .Codigo = Codigo
                .EstadoID = 0 'inactivo
            End With

            Value = Data.Visita.Autorizacion.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
        Public Function GrabarParentesco(ByVal objEnt As Entity.Visita.Autorizacion) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant_parentesco"

            Value = Data.Visita.Autorizacion.Grabar(strAccion, strOpcion, objEnt)

            Return Value
        End Function

        Public Function GrabarGrillaAutorizacionExtraordinario(ByVal objEnt As Entity.Visita.Autorizacion) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant_grilla_autorizacion_extraordinario"

            Value = Data.Visita.Autorizacion.Grabar(strAccion, strOpcion, objEnt)

            Return Value
        End Function

#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.Autorizacion) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Visita.Autorizacion.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace