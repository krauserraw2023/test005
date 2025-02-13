Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Linq
Imports Type.Enumeracion.Movimiento

Namespace Registro
    Public Class InternoMovimiento
        Private objEnt As Entity.Registro.InternoMovimiento = Nothing
        Private objEntCol As Entity.Registro.InternoMovimientoCol = Nothing
#Region "Funciones"
        Public Function CuentaMovimientoxIngreso(EntMov As Entity.Registro.InternoMovimiento) As Integer
            ' jeu 04112015 actualizado
            Return Data.Registro.InternoMovimiento.ListarOutput("lst", "lst_movimientoxIngreso", EntMov)
        End Function
        Public Function movimientoReferenciadoConDocumentoJud(idInterno As Integer, idIngresoInpe As Integer,
                                                              idIngreso As Integer, idDocumentoJudicial As Integer) As Boolean

            Dim value As Boolean = False

            Dim objEntFiltro As New Entity.Registro.InternoMovimiento
            Dim objListaMovimiento As New Entity.Registro.InternoMovimientoCol

            If idIngresoInpe > 0 Then
                objEntFiltro.InternoID = idInterno
                objEntFiltro.IngresoInpeId = idIngresoInpe
                objListaMovimiento = ListarGrilla_LM(objEntFiltro)
            Else
                objEntFiltro.InternoID = idInterno
                objEntFiltro.IngresoID = idIngreso
                objListaMovimiento = ListarGrilla(objEntFiltro)
            End If

            Dim query = From tabla As Entity.Registro.InternoMovimiento In objListaMovimiento
                        Where tabla.DocumJudicialID = idDocumentoJudicial
                        Select tabla

            For Each fila As Entity.Registro.InternoMovimiento In query
                value = fila.Codigo > 0
            Next

            Return value

        End Function

        Public Function fnGetTipoProcesoMovimientoLibertad(idInterno As Integer) As Short

            Dim value As Short = -1

            value = Data.Registro.InternoMovimiento.ListarOutput("lst", "lst_proceso_inimputable",
                                                         New Entity.Registro.InternoMovimiento With {.InternoID = idInterno})

            Return value

        End Function
#End Region
#Region "Validar"
        Public Function ValidaMovimientoInterno(EntMov As Entity.Registro.InternoMovimiento) As Integer
            Return Data.Registro.InternoMovimiento.ListarOutput("lst", "lst_validar_movimiento", EntMov)
        End Function
        Private Function validarEstadoDistritoJudicial(objEnt As Entity.Registro.InternoMovimiento)

            Dim value As Boolean = True
            If objEnt.AutoridadJudicialID > 0 Then

                Dim mensajeOut As String = ""
                Dim objBssDistritoJudicial As New Bussines.Mantenimiento.AutoridadJudicial
                value = objBssDistritoJudicial.validarEstadoDistiroJudicial(objEnt.AutoridadJudicialID, mensajeOut)

                If value = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(mensajeOut)
                End If

            End If

            Return value
        End Function
#End Region

#Region "Listar"
        Public Function Listar(EntMov As Entity.Registro.InternoMovimiento) As Entity.Registro.InternoMovimiento

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoMovimiento.Listar(sqlCon, "lst", "lst_mant", EntMov)
            objEnt = New Entity.Registro.InternoMovimiento
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .DocumJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumJudicialNum = sqlDr("doc_jud_num").ToString
                            .DocumJudicialFecharecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .DocumJudicialFecha = sqlDr("doc_jud_fec").ToString

                            .TipoAutoridadJudicialID = sqlDr("doc_jud_tip_aut_id").ToString
                            .AutoridadJudicialID = sqlDr("doc_jud_aut_id").ToString
                            .SalaJudicialID = sqlDr("doc_jud_sal_id").ToString
                            .DocJudJuez = sqlDr("doc_jud_jue").ToString
                            .DocJudSecretario = sqlDr("doc_jud_sec").ToString
                            '.DocJudObservacion = sqlDr("doc_jud_obs").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoSubMotivoID = sqlDr("mov_sub_mot_id").ToString
                            .MovimientoMotivoID = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
                            .MovimientoSubTipo = sqlDr("subtip_lib_nom").ToString
                            .MovimientoMotivoNombre = .MovimientoMotivoNombre & IIf(.MovimientoSubTipo.Length = 0, "", " (") & .MovimientoSubTipo & IIf(.MovimientoSubTipo.Length = 0, "", ")")
                            .Fecha = sqlDr("mov_fec").ToString
                            .RegionOrigenID = sqlDr("reg_org_id").ToString
                            .PenalOrigenID = sqlDr("mov_pen_org").ToString
                            .RegionDestinoID = sqlDr("reg_des_id").ToString
                            .PenalDestinoID = sqlDr("mov_pen_des").ToString
                            .OrigenNombre = sqlDr("mov_org_otr").ToString
                            .DestinoNombre = sqlDr("mov_des_otr").ToString
                            .EstadoID = sqlDr("mov_est_id").ToString
                            .Observacion = sqlDr("mov_obs").ToString
                            .Movimiento_Observacion_Estado_Ejecucion_IM = sqlDr("mov_est_ejec_obs").ToString
                            .PeriodoRetorno = sqlDr("mov_per_val").ToString
                            .PeriodoTipo = sqlDr("mov_per_tip").ToString
                            .FechaRetorno = sqlDr("mov_fec_ret").ToString
                            .DocJudicialReferencia_OTHSM = sqlDr("doc_jud_id_ref").ToString
                            .Estado_Ejecucion_Ejecutado = sqlDr("mov_est_ejec").ToString
                            .Movimiento_Observacion_Estado_Ejecucion_IM = sqlDr("mov_est_ejec_obs").ToString
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

        Public Function Listar_LM_v2(EntMov As Entity.Registro.InternoMovimiento) As Entity.Registro.InternoMovimientoCol
            Dim lst As New Entity.Registro.InternoMovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoMovimiento.Listar_LM(sqlCon, "lst", "lst_mant_LM", EntMov)

            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoMovimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .DocumJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumJudicialNum = sqlDr("doc_jud_num").ToString
                            .DocumJudicialFecharecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .DocumJudicialFecha = sqlDr("doc_jud_fec").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("doc_jud_tip_aut_id").ToString
                            .AutoridadJudicialID = sqlDr("doc_jud_aut_id").ToString
                            .SalaJudicialID = sqlDr("doc_jud_sal_id").ToString
                            .DocJudJuez = sqlDr("doc_jud_jue").ToString
                            .DocJudSecretario = sqlDr("doc_jud_sec").ToString
                            '.DocJudObservacion = sqlDr("doc_jud_obs").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoMotivoID = sqlDr("mov_mot_id").ToString
                            .MovimientoSubMotivoID = sqlDr("mov_sub_mot_id").ToString
                            .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
                            .MovimientoSubTipo = sqlDr("subtip_lib_nom").ToString
                            .MovimientoMotivoNombre = .MovimientoMotivoNombre & IIf(.MovimientoSubTipo.Length = 0, "", " (") & .MovimientoSubTipo & IIf(.MovimientoSubTipo.Length = 0, "", ")")
                            .Fecha = sqlDr("mov_fec").ToString
                            .RegionOrigenID = sqlDr("reg_org_id").ToString
                            .PenalOrigenID = sqlDr("mov_pen_org").ToString
                            .RegionDestinoID = sqlDr("reg_des_id").ToString
                            .PenalDestinoID = sqlDr("mov_pen_des").ToString
                            .OrigenNombre = sqlDr("mov_org_otr").ToString
                            .DestinoNombre = sqlDr("mov_des_otr").ToString
                            .EstadoID = sqlDr("mov_est_id").ToString
                            .Observacion = sqlDr("mov_obs").ToString
                            .PeriodoRetorno = sqlDr("mov_per_val").ToString
                            .PeriodoTipo = sqlDr("mov_per_tip").ToString
                            .FechaRetorno = sqlDr("mov_fec_ret").ToString
                            .EstadoPenalDestinoID = sqlDr("mov_est_des_id").ToString
                            ._PenalID = sqlDr("_penid").ToString
                            .DocJudicialReferencia_OTHSM = sqlDr("doc_jud_id_ref").ToString
                            .Estado_Ejecucion_Ejecutado = sqlDr("mov_est_ejec").ToString
                            .Movimiento_Observacion_Estado_Ejecucion_IM = sqlDr("mov_est_ejec_obs").ToString
                        End With
                        lst.Add(objEnt)
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
            Return lst
        End Function

        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.InternoMovimiento
            Dim EntMov As New Entity.Registro.InternoMovimiento
            EntMov.Codigo = Codigo

            Dim lst As New Entity.Registro.InternoMovimientoCol
            lst = Listar_LM_v2(EntMov)
            If lst.Count = 0 Then
                Return Nothing
            End If

            Return lst.InternoMovimiento(0)
        End Function

        Public Function Listar_LM(EntMov As Entity.Registro.InternoMovimiento) As Entity.Registro.InternoMovimiento
            Dim lst As New Entity.Registro.InternoMovimientoCol
            lst = Listar_LM_v2(EntMov)
            If lst.Count = 0 Then
                Return Nothing
            End If
            Return lst.InternoMovimiento(0)
        End Function

        ''' <summary>
        ''' 16/02/2024
        ''' Permite validar si existe algun movimiento generado referenciando un oficio de clasificacion en carceleta.
        ''' </summary>
        ''' <param name="EntMov"></param>
        ''' <returns></returns>
        Public Function Listar_LM_MovRefenciaOficioClasificacion(EntMov As Entity.Registro.InternoMovimiento) As Entity.Registro.InternoMovimiento
            objEnt = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoMovimiento.Listar_LM(sqlCon, "lst", "lst_mant_LM_VerificaOficioClasifRef", EntMov)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoMovimiento With {
                            .Codigo = sqlDr("mov_id").ToString
                            }
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
        ''' <summary>
        ''' Retorna el último movimiento del interno del ultimo ingreso.
        ''' </summary>
        ''' <param name="internoId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' <summary>
        ''' Retorna el último movimiento del interno del ultimo ingreso.
        ''' </summary>
        ''' <param name="internoId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UltimoMovimiento_LM(internoId As Integer) As Entity.Registro.InternoMovimiento
            '04.11.2015-jeu lst_mant
            Dim EntMov As New Entity.Registro.InternoMovimiento
            Dim lst As New Entity.Registro.InternoMovimientoCol
            EntMov.InternoID = internoId

            lst = ListarGrilla_LM(EntMov)
            If lst Is Nothing OrElse lst.Count = 0 Then Return Nothing

            Dim fecMayor As Long = 0
            Dim objTmp As Entity.Registro.InternoMovimiento

            objTmp = lst.InternoMovimiento(0)

            For Each o As Entity.Registro.InternoMovimiento In lst
                If fecMayor < o.Fecha Then
                    fecMayor = o.Fecha
                    objTmp = o
                End If
            Next

            Return objTmp
        End Function

        ''' <summary>
        ''' Retorne al primer movimiento de ingreso correspondientes al ultimo Ingreso INPE.
        ''' </summary>
        ''' <param name="internoId"></param>
        ''' <returns></returns>
        Public Function PrimerMovimientoIngreso_LM(internoId As Integer) As Entity.Registro.InternoMovimiento
            Dim EntMov As New Entity.Registro.InternoMovimiento
            Dim lst As New Entity.Registro.InternoMovimientoCol
            EntMov.InternoID = internoId
            EntMov.MovimientoGrupoID = 1 'ingresos
            lst = ListarGrilla_LM(EntMov)
            If lst Is Nothing OrElse lst.Count = 0 Then Return Nothing

            Dim fecMenor As Long = 0
            Dim objTmp As Entity.Registro.InternoMovimiento

            objTmp = lst.InternoMovimiento(0)
            fecMenor = lst.InternoMovimiento(0).Fecha

            For Each o As Entity.Registro.InternoMovimiento In lst
                If fecMenor > o.Fecha Then
                    fecMenor = o.Fecha
                    objTmp = o
                End If
            Next

            Return objTmp
        End Function

        Public Function ListarGrilla(objEnt As Entity.Registro.InternoMovimiento) As Entity.Registro.InternoMovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim TipoAutoridadConsulta As Integer = objEnt.TipoAutoridadJudicialID

            Dim sqlDr As SqlDataReader = Data.Registro.InternoMovimiento.Listar(sqlCon, "lst", IIf(TipoAutoridadConsulta = 74, "lst_grilla_OTHSM", "lst_grilla"), objEnt)

            Try
                objEntCol = New Entity.Registro.InternoMovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoMovimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .DocumJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumJudicialNum = sqlDr("doc_jud_num").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            .MovimientoGrupoNombre = (sqlDr("mov_grp_nom").ToString).ToString

                            If .MovimientoGrupoID = 1 Then
                                .MovimientoGrupoNombre = "I"
                            Else
                                .MovimientoGrupoNombre = "E"
                            End If

                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
                            .MovimientoMotivoID = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
                            .PenalOrigenID = sqlDr("mov_pen_org").ToString
                            .MovimientoSubMotivoID = sqlDr("mov_sub_mot_id").ToString

                            If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                                If .MovimientoSubMotivoID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado Then
                                    .OrigenNombre = "E.P. " & sqlDr("pen_org_nom").ToString
                                Else
                                    .OrigenNombre = ""
                                End If
                            Else
                                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Then
                                    If .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                                        .OrigenNombre = sqlDr("mov_org_otr").ToString
                                        If .OrigenNombre = "" Then
                                            .OrigenNombre = "E.P. " & sqlDr("pen_org_nom").ToString
                                        End If
                                    Else
                                        .OrigenNombre = "E.P. " & sqlDr("pen_org_nom").ToString
                                    End If
                                Else
                                    .OrigenNombre = sqlDr("pen_org_nom").ToString
                                    If .OrigenNombre <> "" Then
                                        .OrigenNombre = "E.P. " & sqlDr("pen_org_nom").ToString
                                    End If
                                    If .MovimientoTipoID = 10 Then
                                        .OrigenNombre = sqlDr("mov_org_otr").ToString
                                    End If
                                End If
                            End If

                            '/*destino*/
                            If .MovimientoTipoID = 3 Or .MovimientoTipoID = 4 Or .MovimientoTipoID = 5 Then
                                .DestinoNombre = ""
                            Else
                                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Then
                                    If .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                                        .DestinoNombre = sqlDr("mov_des_otr").ToString
                                        If .DestinoNombre = "" Then
                                            .DestinoNombre = "E.P. " & sqlDr("pen_des_nom").ToString
                                        End If
                                    Else
                                        .DestinoNombre = "E.P. " & sqlDr("pen_des_nom").ToString
                                    End If
                                ElseIf .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental Then
                                    .DestinoNombre = sqlDr("est_men_des_nom").ToString
                                Else
                                    If sqlDr("pen_des_nom").ToString = "" Then
                                        .DestinoNombre = ""
                                    Else
                                        .DestinoNombre = "E.P. " & sqlDr("pen_des_nom").ToString
                                    End If
                                End If
                            End If

                            If .DestinoNombre.Length < 2 And sqlDr("est_men_des_nom").ToString.Length > 3 Then
                                .DestinoNombre = sqlDr("est_men_des_nom").ToString
                            End If

                            '==============================
                            .Fecha = sqlDr("mov_fec").ToString
                            .EstadoID = sqlDr("mov_est_id").ToString

                            If .MovimientoMotivoID < 1 Then
                                .MovimientoMotivoNombre = "NO INDICA"
                            Else
                                .MovimientoMotivoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoMotivoNombre)
                            End If
                            Dim Cadena As String = sqlDr("subtip_lib_nom").ToString
                            .MovimientoMotivoNombre = .MovimientoMotivoNombre & IIf(Cadena.Length = 0, "", " (") & Cadena & IIf(Cadena.Length = 0, "", ")")
                            .Observacion = sqlDr("mov_obs").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString

                            If TipoAutoridadConsulta = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital_Nota Then
                                ' Fechas del Documento
                                .DocumJudicialFecharecepcion = sqlDr("fecha_recepcion").ToString
                                .DocumJudicialFecha = sqlDr("fecha_documento").ToString
                            End If
                            .Estado_Ejecucion_Ejecutado = sqlDr("mov_est_ejec").ToString
                            .DocJudicialReferencia_OTHSM = sqlDr("doc_jud_id_ref").ToString

                            'Campos en mayuscula
                            .MovimientoGrupoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoGrupoNombre)
                            .MovimientoTipoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoTipoNombre)
                            .OrigenNombre = Legolas.Components.Cadena.ProperCase(.OrigenNombre)
                            .DestinoNombre = Legolas.Components.Cadena.ProperCase(.DestinoNombre)
                            .EstadoNombreTramite = Legolas.Components.Cadena.ProperCase(.EstadoNombreTramite)

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

        Public Function ListarGrilla_LM(objEnt As Entity.Registro.InternoMovimiento) As Entity.Registro.InternoMovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoMovimiento.Listar_LM(sqlCon, "lst", "lst_grilla_LM", objEnt)

            Try
                objEntCol = New Entity.Registro.InternoMovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoMovimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .DocumJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumJudicialNum = sqlDr("doc_jud_num").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            .MovimientoGrupoNombre = (sqlDr("mov_grp_nom").ToString).ToString
                            If .MovimientoGrupoID = 1 Then
                                .MovimientoGrupoNombre = "I"
                            Else
                                .MovimientoGrupoNombre = "E"
                            End If
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
                            .MovimientoMotivoID = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
                            .PenalOrigenID = sqlDr("mov_pen_org").ToString
                            If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                                If .MovimientoMotivoID = 3 Then
                                    .OrigenNombre = "E.P. " & sqlDr("pen_org_nom").ToString
                                Else
                                    .OrigenNombre = ""
                                End If
                            Else
                                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Then
                                    If .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                                        .OrigenNombre = sqlDr("mov_org_otr").ToString
                                        If .OrigenNombre = "" Then
                                            .OrigenNombre = "E.P. " & sqlDr("pen_org_nom").ToString
                                        End If
                                    Else
                                        .OrigenNombre = "E.P. " & sqlDr("pen_org_nom").ToString
                                    End If
                                Else
                                    .OrigenNombre = sqlDr("pen_org_nom").ToString
                                    If .OrigenNombre <> "" Then
                                        .OrigenNombre = "E.P. " & sqlDr("pen_org_nom").ToString
                                    End If

                                End If
                            End If
                            '--------------------------------
                            If .MovimientoTipoID = 3 Or .MovimientoTipoID = 4 Or .MovimientoTipoID = 5 Then
                                .DestinoNombre = ""
                            Else
                                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Then
                                    If .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                                        .DestinoNombre = sqlDr("mov_des_otr").ToString
                                        If .DestinoNombre = "" Then
                                            .DestinoNombre = "E.P. " & sqlDr("pen_des_nom").ToString
                                        End If
                                    Else
                                        .DestinoNombre = "E.P. " & sqlDr("pen_des_nom").ToString
                                    End If
                                Else
                                    If sqlDr("pen_des_nom").ToString = "" Then
                                        .DestinoNombre = ""
                                    Else
                                        .DestinoNombre = "E.P. " & sqlDr("pen_des_nom").ToString
                                    End If
                                End If
                                If .MovimientoTipoID = 9 Then
                                    .DestinoNombre = sqlDr("mov_des_otr").ToString
                                End If
                                If .MovimientoTipoID = 10 Then
                                    .OrigenNombre = sqlDr("mov_org_otr").ToString
                                End If
                            End If

                            If .DestinoNombre.Length < 2 And sqlDr("est_men_des_nom").ToString.Length > 3 Then
                                .DestinoNombre = sqlDr("est_men_des_nom").ToString
                            End If

                            '==============================
                            .Fecha = sqlDr("mov_fec").ToString
                            .EstadoID = sqlDr("mov_est_id").ToString
                            'Campos en mayuscula
                            .MovimientoGrupoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoGrupoNombre)
                            .MovimientoTipoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoTipoNombre)

                            If .MovimientoMotivoID < 1 Then
                                .MovimientoMotivoNombre = "NO INDICA"
                            Else
                                .MovimientoMotivoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoMotivoNombre)
                            End If
                            Dim Cadena As String = sqlDr("subtip_lib_nom").ToString
                            .MovimientoMotivoNombre = .MovimientoMotivoNombre & IIf(Cadena.Length = 0, "", " (") & Cadena & IIf(Cadena.Length = 0, "", ")")
                            .OrigenNombre = Legolas.Components.Cadena.ProperCase(.OrigenNombre)
                            .DestinoNombre = Legolas.Components.Cadena.ProperCase(.DestinoNombre)
                            .EstadoNombreTramite = Legolas.Components.Cadena.ProperCase(.EstadoNombreTramite)
                            .Observacion = sqlDr("mov_obs").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
                            '.SedeRowId = sqlDr("_sed_rowid").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
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

        Public Function ListarMovimiento_Diferente(objEnt As Entity.Registro.InternoMovimiento) As Entity.Registro.InternoMovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoMovimiento.Listar(sqlCon, "lst", "lst_movimiento_diferente_x_mov_id", objEnt)

            Try
                objEntCol = New Entity.Registro.InternoMovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoMovimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .DocumJudicialID = sqlDr("doc_jud_id").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .Fecha = sqlDr("mov_fec").ToString
                            .EstadoID = sqlDr("mov_est_id").ToString
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

        Public Function ListarMovimiento_Diferente_LM(objEnt As Entity.Registro.InternoMovimiento) As Entity.Registro.InternoMovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoMovimiento.Listar_LM(sqlCon, "lst", "lst_movimiento_diferente_x_mov_id_LM", objEnt)

            Try
                objEntCol = New Entity.Registro.InternoMovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoMovimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .DocumJudicialID = sqlDr("doc_jud_id").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .Fecha = sqlDr("mov_fec").ToString
                            .EstadoID = sqlDr("mov_est_id").ToString
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
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Registro.InternoMovimiento) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If validarEstadoDistritoJudicial(objEnt) = False Then
                Return intValue
            End If
            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If
            intValue = Data.Registro.InternoMovimiento.Grabar(strAccion, strOpcion, objEnt)
            Return intValue
        End Function
        Public Function Grabar_LM(ByVal objEnt As Entity.Registro.InternoMovimiento) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If validarEstadoDistritoJudicial(objEnt) = False Then
                Return intValue
            End If

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If
            intValue = Data.Registro.InternoMovimiento.Grabar_LM(strAccion, strOpcion, objEnt)
            Return intValue
        End Function

        'Public Function ActualizarMovimiento(ByVal objEnt As Entity.Registro.InternoMovimiento) As Integer

        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = "aut"
        '    Dim strOpcion As String = "upd_ingreso"

        '    intValue = Data.Registro.InternoMovimiento.Grabar(strAccion, strOpcion, objEnt)
        '    Return intValue
        'End Function

        'Public Function ActualizarMovimientoIngresoTraslado(ByVal objEnt As Entity.Registro.InternoMovimiento) As Integer
        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""

        '    strAccion = "upd"
        '    strOpcion = "upd_movimiento_ing_tras"
        '    intValue = Data.Registro.InternoMovimiento.Grabar(strAccion, strOpcion, objEnt)
        '    Return intValue
        'End Function

        'Public Function ActualizarEstado(entMov As Entity.Registro.InternoMovimiento) As Integer
        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""
        '    strAccion = "upd"
        '    strOpcion = "upd_estado"
        '    intValue = Data.Registro.InternoMovimiento.Grabar(strAccion, strOpcion, entMov)
        '    Return intValue
        'End Function

        'artificio para cambiar el estado de los movimientos a movimiento efectuado cuando se genera un oficio de clasificacion
        Public Function Insertar_MovimientosDeEgresoPorClasificacion_Carceleta(ByVal lstMov As List(Of Entity.Registro.InternoMovimiento)) As Integer
            Return Data.Registro.InternoMovimiento.Insertar_MovimientosDeEgresoPorClasificacion_Carceleta(lstMov)
        End Function
        Public Function generarMovimientoOrdenTrasladoHospital(IDCodigoMov As Integer, idInterno As Integer,
                                                               IdIngreso As Integer, idIngresoInpe As Integer,
                                                               fechaIncripsion As Long, idDocumentoJudicial As Integer,
                                                               idRegion As Integer, idPenal As Integer,
                                                               IdDocumentoReferenciaOriginal As Integer,
                                                               IdTipoInimputable As Integer)
            Dim objEnty As New Entity.Registro.InternoMovimiento
            With objEnty
                .Codigo = IDCodigoMov
                .InternoID = idInterno
                .IngresoInpeId = idIngresoInpe
                .IngresoID = IdIngreso
                .DocumJudicialID = idDocumentoJudicial    'debe volver de documento judicial
                .MovimientoGrupoID = EnumMovGrupo.Egreso
                .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental
                .MovimientoMotivoID = IdTipoInimputable '
                .Fecha = fechaIncripsion
                .PenalOrigenID = idPenal

                .EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                .Observacion = ""
                ._RegionID = idRegion
                ._PenalID = idPenal
                .DocJudicialReferencia_OTHSM = IdDocumentoReferenciaOriginal
            End With

            Dim value As Integer = -1

            'If Me._TipoLicencia = enmTipoLicencia.Carceleta _
            '    Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
            '    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
            If idIngresoInpe > 0 Then
                '    If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then EntDocJud.FlagTransferenciaSede = 1
                value = Grabar_LM(objEnty)
            Else
                value = Grabar(objEnty)
            End If
            Return value
        End Function

#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, IngresoID As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.InternoMovimiento.Eliminar(strAccion, strOpcion, Codigo, IngresoID, FlagTransferenciaSede)
            Return intValue
        End Function

        Public Function Eliminar_LM(ByVal Codigo As Integer, InternoID As Integer, IngresoID As Integer, IngresoInpeId As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_LM"
            intValue = Data.Registro.InternoMovimiento.Eliminar_LM(strAccion, strOpcion, Codigo, InternoID, IngresoID, IngresoInpeId, FlagTransferenciaSede)
            Return intValue
        End Function
#End Region

    End Class
End Namespace

