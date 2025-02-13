Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.General
    Public Class Delito
        Private objEnt As Entity.Mantenimiento.General.Delito = Nothing
        Private objEntCol As Entity.Mantenimiento.General.DelitoCol = Nothing
#Region "Combo"
        Public Function Combo_DelitoTipo(Optional intTipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno,
                                                Optional blnAddPrimeraFila As Boolean = False,
                                                Optional ByVal strMensaje As String = "[TODOS]") As Entity.Mantenimiento.General.DelitoCol

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_combo_delito_titulo", objEntFiltro)

            Try
                objEntCol = New Entity.Mantenimiento.General.DelitoCol

                If blnAddPrimeraFila = True Then
                    Dim objEntFila As New Entity.Mantenimiento.General.Delito
                    objEntFila.DelitoTipoID = -1
                    objEntFila.DelitoTipoNombre = strMensaje
                    objEntCol.Add(objEntFila)
                End If

                Dim strNombre As String = ""
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt

                            .DelitoTipoID = sqlDr("del_tip_id").ToString
                            .DelitoTipoNombre = sqlDr("del_tip_nom").ToString

                            strNombre = .DelitoTipoNombre

                            Select Case intTipoTexto
                                Case Type.Combo.enmTipoTexto.Mayuscula
                                    strNombre = strNombre.ToUpper

                                Case Type.Combo.enmTipoTexto.Minuscula
                                    strNombre = strNombre.ToLower
                                Case Type.Combo.enmTipoTexto.Propio
                                    strNombre = Legolas.Components.Cadena.ProperCase(strNombre)
                            End Select
                            .DelitoTipoNombre = strNombre
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

        Public Function Combo_DelitoEspEstado(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable

            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If

            objDT.Rows.Add(New Object() {0, "Anulado"})
            objDT.Rows.Add(New Object() {1, "Activo"})
            objDT.Rows.Add(New Object() {2, "Derogado"})
            objDT.AcceptChanges()

            Return objDT

        End Function

        Public Function Combo_DelitoGenerico(intIDDelitoTipo As Short, Optional intTipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno,
                                                Optional blnAddPrimeraFila As Boolean = False,
                                                Optional ByVal strMensaje As String = "") As Entity.Mantenimiento.General.DelitoCol

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            With objEntFiltro
                .DelitoTipoID = intIDDelitoTipo
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_combo_delito_generico", objEntFiltro)
            Try
                objEntCol = New Entity.Mantenimiento.General.DelitoCol

                If blnAddPrimeraFila = True Then
                    Dim objEntFila As New Entity.Mantenimiento.General.Delito
                    objEntFila.DelitoTipoID = -1
                    objEntFila.DelitoTipoNombre = strMensaje
                    objEntCol.Add(objEntFila)
                End If

                Dim strNombre As String = ""
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt

                            .DelitoGenericoID = sqlDr("del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoGenericoNumero = sqlDr("del_gen_num").ToString

                            strNombre = .DelitoGenericoNombre

                            Select Case intTipoTexto
                                Case Type.Combo.enmTipoTexto.Mayuscula
                                    strNombre = strNombre.ToUpper

                                Case Type.Combo.enmTipoTexto.Minuscula
                                    strNombre = strNombre.ToLower
                                Case Type.Combo.enmTipoTexto.Propio
                                    strNombre = Legolas.Components.Cadena.ProperCase(strNombre)
                            End Select
                            .DelitoTipoNombre = strNombre
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

        Public Function Combo_DelitoCapitulo(intIDDelitoGenerico As Short, Optional intTipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno,
                                                Optional blnAddPrimeraFila As Boolean = False,
                                                Optional ByVal strMensaje As String = "") As Entity.Mantenimiento.General.DelitoCol

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            With objEntFiltro
                .DelitoGenericoID = intIDDelitoGenerico
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_combo_delito_capitulo", objEntFiltro)
            Try
                objEntCol = New Entity.Mantenimiento.General.DelitoCol

                If blnAddPrimeraFila = True Then
                    Dim objEntFila As New Entity.Mantenimiento.General.Delito
                    objEntFila.DelitoTipoID = -1
                    objEntFila.DelitoTipoNombre = strMensaje
                    objEntCol.Add(objEntFila)
                End If

                Dim strNombre As String = ""
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt

                            .IDDelitoCapitulo = sqlDr("del_cap_id").ToString
                            .DelitoCapituloNombre = sqlDr("del_cap_nom").ToString
                            .DelitoCapituloNro = sqlDr("del_cap_num").ToString

                            strNombre = .DelitoCapituloNombre

                            Select Case intTipoTexto
                                Case Type.Combo.enmTipoTexto.Mayuscula
                                    strNombre = strNombre.ToUpper

                                Case Type.Combo.enmTipoTexto.Minuscula
                                    strNombre = strNombre.ToLower
                                Case Type.Combo.enmTipoTexto.Propio
                                    strNombre = Legolas.Components.Cadena.ProperCase(strNombre)
                            End Select
                            .DelitoTipoNombre = strNombre
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

        Public Function Combo_DelitoSeccion(intIDDelitoCapitulo As Short, Optional intTipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno,
                                                Optional blnAddPrimeraFila As Boolean = False,
                                                Optional ByVal strMensaje As String = "") As Entity.Mantenimiento.General.DelitoCol

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            With objEntFiltro
                .IDDelitoCapitulo = intIDDelitoCapitulo
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_combo_delito_secion", objEntFiltro)
            Try
                objEntCol = New Entity.Mantenimiento.General.DelitoCol

                If blnAddPrimeraFila = True Then
                    Dim objEntFila As New Entity.Mantenimiento.General.Delito
                    objEntFila.DelitoTipoID = -1
                    objEntFila.DelitoTipoNombre = strMensaje
                    objEntCol.Add(objEntFila)
                End If

                Dim strNombre As String = ""
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt

                            .IDDelitoSeccion = sqlDr("del_sec_id").ToString
                            .DelitoSeccionNombre = sqlDr("del_sec_nom").ToString
                            .DelitoSeccionNumero = sqlDr("del_sec_num").ToString

                            strNombre = .DelitoSeccionNombre

                            Select Case intTipoTexto
                                Case Type.Combo.enmTipoTexto.Mayuscula
                                    strNombre = strNombre.ToUpper

                                Case Type.Combo.enmTipoTexto.Minuscula
                                    strNombre = strNombre.ToLower
                                Case Type.Combo.enmTipoTexto.Propio
                                    strNombre = Legolas.Components.Cadena.ProperCase(strNombre)
                            End Select
                            .DelitoTipoNombre = strNombre
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

        Public Function Combo_DelitoEspecifico(intIDDelitoGenerico As Short, Optional intTipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno,
                                                Optional blnAddPrimeraFila As Boolean = False,
                                                Optional ByVal strMensaje As String = "") As Entity.Mantenimiento.General.DelitoCol

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            With objEntFiltro
                .DelitoGenericoID = intIDDelitoGenerico
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_combo_delito_especifico", objEntFiltro)
            Try
                objEntCol = New Entity.Mantenimiento.General.DelitoCol

                If blnAddPrimeraFila = True Then
                    Dim objEntFila As New Entity.Mantenimiento.General.Delito
                    objEntFila.DelitoTipoID = -1
                    objEntFila.DelitoTipoNombre = strMensaje
                    objEntCol.Add(objEntFila)
                End If

                Dim strNombre As String = ""
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt

                            .DelitoEspecificoID = sqlDr("del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString

                            strNombre = .DelitoEspecificoNombre

                            Select Case intTipoTexto
                                Case Type.Combo.enmTipoTexto.Mayuscula
                                    strNombre = strNombre.ToUpper

                                Case Type.Combo.enmTipoTexto.Minuscula
                                    strNombre = strNombre.ToLower
                                Case Type.Combo.enmTipoTexto.Propio
                                    strNombre = Legolas.Components.Cadena.ProperCase(strNombre)
                            End Select
                            .DelitoTipoNombre = strNombre
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
#Region "Listar"
        'Public Function Listar_DelitoEspecifico(intCodigo As Integer) As Entity.Mantenimiento.General.Delito

        '    'jmr-19.03.2018
        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

        '    Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
        '    With objEntFiltro
        '        .DelitoEspecificoID = intCodigo
        '    End With

        '    Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_mant_especifico", objEntFiltro)

        '    Try
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Mantenimiento.General.Delito
        '                With objEnt
        '                    .DelitoEspecificoID = sqlDr("del_esp_id").ToString
        '                    .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
        '                    .DelitoEspecificoCodigo = sqlDr("del_esp_cod").ToString
        '                    .DelitoArticulo = sqlDr("del_art_nom_cor").ToString
        '                    .DelitoEspObs = sqlDr("del_esp_obs").ToString
        '                    .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString
        '                    .DelitoEspMotivoBaja = sqlDr("del_esp_des_mot_baj").ToString
        '                    'grupos
        '                    .DelitoTipoID = sqlDr("del_tip_id").ToString

        '                    .DelitoGenericoID = sqlDr("del_gen_id").ToString
        '                    .DelitoGenericoCodigo = sqlDr("del_gen_cod").ToString
        '                    .DelitoTitulo = sqlDr("del_gen_num_tit").ToString
        '                    .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString

        '                    .IDDelitoCapitulo = sqlDr("del_cap_id").ToString
        '                    .DelitoCapituloCodigo = sqlDr("del_esp_cap_cod").ToString
        '                    .DelitoCapituloNombre = sqlDr("del_cap_nom").ToString()
        '                    .DelitoCapituloNro = sqlDr("del_cap_num").ToString()

        '                    .IDDelitoSeccion = sqlDr("del_sec_id").ToString()
        '                    .DelitoSeccionCodigo = sqlDr("del_esp_sec_cod").ToString
        '                    .DelitoSeccionNumero = sqlDr("del_sec_num").ToString()
        '                    .DelitoSeccionNombre = sqlDr("del_sec_nom").ToString()

        '                    .IDDelitoEspecificoPadre = sqlDr("fk_del_Esp_id_pdr").ToString
        '                    .DelitoEspecificoPadreCodigo = sqlDr("del_esp_pdr_cod").ToString
        '                End With

        '            End While
        '        End If
        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString)
        '    Finally
        '        sqlDr.Dispose()
        '        sqlDr.Close()
        '        sqlDr = Nothing
        '        sqlCon.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try
        '    Return objEnt
        'End Function
        Public Function Listar_DelitoEspecifico_v2(intCodigo As Integer) As Entity.Mantenimiento.General.Delito

            'jeu-19.07.2019
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            With objEntFiltro
                .DelitoEspecificoID = intCodigo
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_mant_especifico_v2", objEntFiltro)

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt
                            .DelitoEspecificoID = sqlDr("del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .DelitoEspecificoCodigo = sqlDr("del_esp_cod").ToString
                            .DelitoArticulo = sqlDr("del_art_nom_cor").ToString
                            .DelitoEspObs = sqlDr("del_esp_obs").ToString
                            .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString
                            .DelitoEspMotivoBaja = sqlDr("del_esp_des_mot_baj").ToString
                            .DelitoTipoID = sqlDr("del_tip_id").ToString
                            .DelitoGenericoID = sqlDr("del_gen_id").ToString
                            .DelitoGenericoCodigo = sqlDr("del_gen_cod").ToString
                            .DelitoTitulo = sqlDr("del_gen_num_tit").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .IDDelitoCapitulo = sqlDr("del_cap_id").ToString
                            .DelitoCapituloCodigo = sqlDr("del_esp_cap_cod").ToString
                            .DelitoCapituloNombre = sqlDr("del_cap_nom").ToString()
                            .DelitoCapituloNro = sqlDr("del_cap_num").ToString()
                            .IDDelitoSeccion = sqlDr("del_sec_id").ToString()
                            .DelitoSeccionCodigo = sqlDr("del_esp_sec_cod").ToString
                            .DelitoSeccionNumero = sqlDr("del_sec_num").ToString()
                            .DelitoSeccionNombre = sqlDr("del_sec_nom").ToString()
                            .IDDelitoEspecificoPadre = sqlDr("fk_del_Esp_id_pdr").ToString
                            .DelitoEspecificoPadreCodigo = sqlDr("del_esp_pdr_cod").ToString
                            'grupo delito -cuadro 002
                            .DelitoCuadroGrupoId = sqlDr("del_grp_cua_id").ToString
                            .DelitoGrupoGenericoNombre = sqlDr("del_grp_gen_nom").ToString
                            .DelitoGrupoEspecificoNombre = sqlDr("del_grp_esp_nom").ToString
                            .IDDelitoGrupoDelitoDet = sqlDr("pk_rpt_cua_2_det_id").ToString
                            .DelitoGrupoEspecificoId = sqlDr("del_grp_esp_id").ToString
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
        Public Function Listar_DelitoEspecifico_Codigo(intCodigo As Integer) As String

            Dim value As String = ""
            value = Listar_DelitoEspecifico_v2(intCodigo).DelitoEspecificoCodigo

            Return value

        End Function

        Private Function Listar_DelitoGenerico(intCodigo As Integer) As Entity.Mantenimiento.General.Delito

            'jmr-19.03.2018
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            With objEntFiltro
                .DelitoGenericoID = intCodigo
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_mant_delito_generico", objEntFiltro)

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt
                            .DelitoGenericoID = sqlDr("del_gen_id").ToString
                            .DelitoGenericoCodigo = sqlDr("del_gen_cod").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
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
        Public Function Listar_DelitoGenerico_Codigo(intCodigo As Integer) As String

            Dim value As String = ""
            value = Listar_DelitoGenerico(intCodigo).DelitoGenericoCodigo

            Return value

        End Function

        Private Function Listar_DelitoCapitulo(intCodigo As Integer) As Entity.Mantenimiento.General.Delito

            'jmr-19.03.2018
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            With objEntFiltro
                .IDDelitoCapitulo = intCodigo
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_mant_delito_capitulo", objEntFiltro)

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt
                            .IDDelitoCapitulo = sqlDr("del_cap_id").ToString
                            .DelitoCapituloCodigo = sqlDr("del_cap_cod").ToString
                            .DelitoCapituloNombre = sqlDr("del_cap_nom").ToString
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
        Public Function Listar_DelitoCapitulo_Codigo(intCodigo As Integer) As String

            Dim value As String = ""
            value = Listar_DelitoCapitulo(intCodigo).DelitoCapituloCodigo

            Return value

        End Function

        Private Function Listar_DelitoSeccion(intCodigo As Integer) As Entity.Mantenimiento.General.Delito

            'jmr-19.03.2018
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Mantenimiento.General.Delito
            With objEntFiltro
                .IDDelitoSeccion = intCodigo
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_mant_delito_seccion", objEntFiltro)

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt
                            .IDDelitoSeccion = sqlDr("del_sec_id").ToString
                            .DelitoSeccionCodigo = sqlDr("del_sec_cod").ToString
                            .DelitoSeccionNombre = sqlDr("del_sec_nom").ToString
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
        Public Function Listar_DelitoSeccion_Codigo(intCodigo As Integer) As String

            Dim value As String = ""
            value = Listar_DelitoSeccion(intCodigo).DelitoSeccionCodigo

            Return value

        End Function

        Public Function Listar_BusquedaGrilla(ByVal objEntFiltro As Entity.Mantenimiento.General.Delito) As Entity.Mantenimiento.General.DelitoCol
            '/*22.08.2014
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_busqueda_delito_popup", objEntFiltro)

            Try
                objEntCol = New Entity.Mantenimiento.General.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt
                            .DelitoEspecificoID = sqlDr("del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .DelitoGenericoID = sqlDr("del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoTitulo = sqlDr("del_gen_num_tit").ToString
                            .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString
                            .DelitoArticulo = sqlDr("del_art_nom_cor").ToString()
                            .DelitoTipoID = sqlDr("del_tip_id").ToString()
                            .DelitoCapituloNombre = sqlDr("del_cap_nom").ToString()
                            .DelitoCapituloNro = sqlDr("del_cap_num").ToString()
                            .DelitoSeccionNumero = sqlDr("del_sec_num").ToString()
                            .DelitoSeccionNombre = sqlDr("del_sec_nom").ToString()
                            .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString()
                            .DelitoCodigoSB = sqlDr("par_cod").ToString()
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

        Public Function Listar_Grilla(ByVal objEntFiltro As Entity.Mantenimiento.General.Delito) As Entity.Mantenimiento.General.DelitoCol
            '/*22.08.2014
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_grilla_especifico_mant", objEntFiltro)

            Try
                objEntCol = New Entity.Mantenimiento.General.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt
                            .DelitoEspecificoID = sqlDr("del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .DelitoTipoNombre = sqlDr("del_tip_nom").ToString
                            .DelitoGenericoID = sqlDr("del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoTitulo = sqlDr("del_gen_num_tit").ToString
                            .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString
                            .DelitoArticulo = sqlDr("del_art_nom_cor").ToString()
                            .DelitoTipoID = sqlDr("del_tip_id").ToString()
                            .DelitoCapituloNombre = sqlDr("del_cap_nom").ToString()
                            .DelitoCapituloNro = sqlDr("del_cap_num").ToString()
                            .DelitoSeccionNumero = sqlDr("del_sec_num").ToString()
                            .DelitoSeccionNombre = sqlDr("del_sec_nom").ToString()
                            .DelitoCodigoSB = sqlDr("par_cod").ToString()
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
        '/*j.e.u 22/07/2019*/
        Public Function Listar_Grilla_V2(ByVal objEntFiltro As Entity.Mantenimiento.General.Delito) As Entity.Mantenimiento.General.DelitoCol
            '/*22.08.2014
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar_v2(sqlCon, "lst", "lst_grilla_especifico_mant_v2", objEntFiltro)

            Try
                objEntCol = New Entity.Mantenimiento.General.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Delito
                        With objEnt
                            .DelitoEspecificoID = sqlDr("del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .DelitoTipoNombre = sqlDr("del_tip_nom").ToString
                            .DelitoGenericoID = sqlDr("del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoTitulo = sqlDr("del_gen_num_tit").ToString
                            .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString
                            .DelitoArticulo = sqlDr("del_art_nom_cor").ToString()
                            .DelitoTipoID = sqlDr("del_tip_id").ToString()
                            .DelitoCapituloNombre = sqlDr("del_cap_nom").ToString()
                            .DelitoCapituloNro = sqlDr("del_cap_num").ToString()
                            .DelitoSeccionNumero = sqlDr("del_sec_num").ToString()
                            .DelitoSeccionNombre = sqlDr("del_sec_nom").ToString()
                            .DelitoCodigoSB = sqlDr("par_cod").ToString()
                            .DelitoCuadroGrupoId = sqlDr("del_cua_id").ToString
                            '/*grupo delito-cuadro002-padin*/
                            .DelitoGrupoGenericoNombre = sqlDr("del_grp_gen_nom").ToString
                            .DelitoGrupoEspecificoNombre = sqlDr("del_grp_esp_nom").ToString
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

        'Public Function Listar2(ByVal objEntFiltro As Entity.Mantenimiento.General.Delito) As Entity.Mantenimiento.General.DelitoCol
        '    '/*22.08.2014
        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Delito.Listar(sqlCon, "lst", "lst_delito2", objEntFiltro)

        '    Try
        '        objEntCol = New Entity.Mantenimiento.General.DelitoCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Mantenimiento.General.Delito
        '                With objEnt
        '                    .DelitoTitulo = sqlDr("del_gen_num_tit").ToString
        '                    .DelitoEspecificoID = sqlDr("del_esp_id").ToString
        '                    .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
        '                    .DelitoGenericoID = sqlDr("del_gen_id").ToString
        '                    .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
        '                    .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString
        '                    .DelitoArticulo = sqlDr("del_art_nom_cor").ToString()
        '                    .DelitoTipoID = sqlDr("del_tip_id").ToString()
        '                    .DelitoCapituloNombre = sqlDr("del_cap_nom").ToString()
        '                    .DelitoCapituloNro = sqlDr("del_cap_num").ToString()
        '                    .DelitoSeccionNumero = sqlDr("del_sec_num").ToString()
        '                    .DelitoSeccionNombre = sqlDr("del_sec_nom").ToString()
        '                    .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString()
        '                End With
        '                objEntCol.Add(objEnt)
        '            End While
        '        End If
        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString)
        '    Finally
        '        sqlDr.Dispose()
        '        sqlDr.Close()
        '        sqlDr = Nothing
        '        sqlCon.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try
        '    Return objEntCol
        'End Function

#End Region

#Region "Grabar"
        Private Function ValidarxCodigoGenericoyEspecifico(ByVal objEntGrabar As Entity.Mantenimiento.General.Delito) As Boolean

            Dim value As Boolean = True
            Dim intCount As Short = 0

            intCount = Data.Mantenimiento.General.Delito.ListarOutput("val", "val_del_esp_x_cod_gen_esp", objEntGrabar)

            If intCount >= 1 Then
                value = False
            End If

            Return value
        End Function
        Private Function ValidarxNombre_AgrupadoDelGen(ByVal objEntGrabar As Entity.Mantenimiento.General.Delito) As Boolean

            Dim value As Boolean = True
            Dim intCount As Short = 0

            intCount = Data.Mantenimiento.General.Delito.ListarOutput("val", "val_del_esp_x_nombre", objEntGrabar)

            If intCount >= 1 Then
                value = False
            End If

            Return value
        End Function
        Private Function Validar(ByVal objEntGrabar As Entity.Mantenimiento.General.Delito, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            If ValidarxCodigoGenericoyEspecifico(objEntGrabar) = False Then
                strMensajeOut = "El codigo generico y especifico del delito ya existe en la base de datos. Verifique"
                Return value
            End If

            If ValidarxNombre_AgrupadoDelGen(objEntGrabar) = False Then
                strMensajeOut = "El nombre del delito, ya existe en el grupo delito generico (titulo). Verifique"
                Return value
            End If

            value = True
            Return value

        End Function
        Public Function Grabar(ByVal objEntGrabar As Entity.Mantenimiento.General.Delito, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            'If Validar(objEntGrabar, strMensajeOut) = False Then
            '    Return value
            'End If

            If objEntGrabar.DelitoEspecificoID < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_especifico"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_especifico"
            End If

            value = Data.Mantenimiento.General.Delito.Grabar(strAccion, strOpcion, objEntGrabar)

            Return value

        End Function

        Public Function Anular(intIDDelitoEspecifico As Integer) As Integer

            Dim value As Integer = -1
            
            Dim objEnt As New Entity.Mantenimiento.General.Delito
            With objEnt
                .DelitoEspecificoID = intIDDelitoEspecifico
                .DelitoEspecificoEstado = 0 'anulado
            End With

            value = Data.Mantenimiento.General.Delito.Grabar("upd", "upd_anular_delito_especifico", objEnt)

            Return value

        End Function
#End Region
#Region "Eliminar"
        Public Function ValidarDelitoEspeUso(idDelitoEspecifico As Integer, nombreDelito As String, nombreArticulo As String) As Boolean

            Dim value As Boolean = False
            Dim intCount As Integer = 0

            Dim objEnt As New Entity.Mantenimiento.General.Delito
            With objEnt
                .DelitoEspecificoID = idDelitoEspecifico
            End With

            intCount = Data.Mantenimiento.General.Delito.ListarOutput("val", "val_del_esp_en_uso", objEnt)

            If intCount >= 1 Then
                objEnt = New Entity.Mantenimiento.General.Delito
                objEnt = Listar_DelitoEspecifico_v2(idDelitoEspecifico)

                If Not objEnt Is Nothing AndAlso objEnt.DelitoEspecificoID > 0 Then
                    If objEnt.DelitoEspecificoNombre.Trim.ToUpper = nombreDelito.Trim.ToUpper And
                        objEnt.DelitoArticulo.Trim.ToUpper = nombreArticulo.Trim.ToUpper Then
                        intCount = 0 'no puede cambiar los demas datos
                    End If
                End If
            End If

            If intCount >= 1 Then
                value = True
            End If

            Return value
        End Function
        Public Function Eliminar(ByVal Codigo As Integer, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""


            If ValidarDelitoEspeUso(Codigo, "", "") = True Then
                strMensajeOut = "El delito seleccionado no se puede eliminar, ya que existen registros relacionados."
                Return value
            End If

            strAccion = "del"
            strOpcion = "del_mant_especifico"

            value = Data.Mantenimiento.General.Delito.Eliminar(strAccion, strOpcion, Codigo, Legolas.Configuration.Usuario.Codigo)

            Return value
        End Function
#End Region
    End Class

End Namespace