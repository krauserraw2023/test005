Imports System.Data.SqlClient
Imports System.Linq
Imports Data.Registro.Carceleta.Clasificacion.InternoClasificacion
Imports Type.Enumeracion.Clasificacion
Imports Type.Enumeracion.TipoDocJudicial

Namespace Clasificacion.InternoClasificacion
    Public Class InternoFicha_BL
        Private objEnt As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing
        Private objEntCol As Entity.Clasificacion.InternoClasificacion.InternoFichaCol = Nothing
#Region "Listar"
        Public Function Listar_V2(ByVal Codigo As Integer) As Entity.Clasificacion.InternoClasificacion.InternoFicha
            Dim entFich As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                    .Codigo = Codigo
                }

            objEntCol = Listar_v2(entFich)
            If objEntCol Is Nothing Then Return Nothing
            If objEntCol.Count = 0 Then Return Nothing

            Return objEntCol.InternoClasificacion(0)
        End Function

        Public Function Listar(entFich As Entity.Clasificacion.InternoClasificacion.InternoFicha) As Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim objEntCol As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol

            Try
                Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlDr = InternoClasificacion_DA.Listar(sqlCon, "lst", "lst_mant", entFich)
                        If sqlDr.HasRows Then
                            While sqlDr.Read()
                                Dim objEnt As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                            .Codigo = sqlDr("codigo").ToString(),
                            .InternoId = sqlDr("fk_int_id").ToString(),
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString(),
                            .FichaId = sqlDr("fk_fic_id").ToString(),
                            .FichaFinalId = sqlDr("fk_int_fic_id").ToString(),
                            .CategoriaFichaNombre = sqlDr("c_cat_desc").ToString(),
                            .CategoriaFichaId = sqlDr("fk_cat_fic_id").ToString(),
                            .RegionDestinoId = sqlDr("reg_dest_id").ToString(),
                            .PenalDestinoId = sqlDr("pen_dest_id").ToString(),
                            .RegimenPenalId = sqlDr("fk_regimen_pen_id").ToString(),
                            .PenalDestinoNombre = sqlDr("pen_dest_nom").ToString(),
                            .FechaClasificacion = sqlDr("fec_clasif").ToString(),
                            .Puntaje = sqlDr("puntaje").ToString(),
                            .Estado = sqlDr("estado_id").ToString(),
                            .PenalId = sqlDr("_PenId").ToString(),
                            .RegionId = sqlDr("_RegId").ToString(),
                            .NumeroClasificacion = sqlDr("num_cla").ToString(),
                            .Observacion = sqlDr("obs").ToString(),
                            .TipoFichaId = sqlDr("tipo_fic_id").ToString(),
                            .FichaNombres = sqlDr("nom_ficha").ToString()
                        }
                                objEntCol.Add(objEnt)
                            End While
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error en la función Listar: " & ex.Message, ex)
            End Try

            Return objEntCol
        End Function


        Public Function UltimaFichaFinalClasificadoConOficio(IngresoInpeID As Integer) As Entity.Clasificacion.InternoClasificacion.InternoFicha
            Dim objEnt As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing
            Dim entFich As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                                    .IngresoInpeId = IngresoInpeID
                                }

            Try
                Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlDr = InternoClasificacion_DA.Listar(sqlCon, "lst", "lst_ult_fich_final_clasificado_con_doc", entFich)
                        If sqlDr.HasRows AndAlso sqlDr.Read() Then
                            objEnt = New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                                            .RegionDestinoId = sqlDr("fk_reg_dest_id").ToString(),
                                            .PenalDestinoId = sqlDr("fk_pen_dest_id").ToString()
                                        }
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al obtener la última ficha final clasificada: " & ex.Message, ex)
            End Try

            Return objEnt
        End Function


        Public Function Listar_v2(entFich As Entity.Clasificacion.InternoClasificacion.InternoFicha) As Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim objEntCol As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol

            Try
                Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlDr = InternoClasificacion_DA.Listar(sqlCon, "lst", "lst_mant_v2", entFich)
                        If sqlDr.HasRows Then
                            While sqlDr.Read()
                                Dim objEnt As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                            .Codigo = sqlDr("codigo").ToString(),
                            .InternoId = sqlDr("fk_int_id").ToString(),
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString(),
                            .FichaId = sqlDr("fk_fic_id").ToString(),
                            .FichaFinalId = sqlDr("fk_int_fic_id").ToString(),
                            .CategoriaFichaNombre = sqlDr("c_cat_desc").ToString(),
                            .CategoriaFichaId = sqlDr("fk_cat_fic_id").ToString(),
                            .RegionDestinoId = sqlDr("reg_dest_id").ToString(),
                            .PenalDestinoId = sqlDr("pen_dest_id").ToString(),
                            .RegimenPenalId = sqlDr("fk_regimen_pen_id").ToString(),
                            .PenalDestinoNombre = sqlDr("pen_dest_nom").ToString(),
                            .FechaClasificacion = sqlDr("fec_clasif").ToString(),
                            .Puntaje = sqlDr("puntaje").ToString(),
                            .Estado = sqlDr("estado_id").ToString(),
                            .PenalId = sqlDr("_PenId").ToString(),
                            .RegionId = sqlDr("_RegId").ToString(),
                            .NumeroClasificacion = sqlDr("num_cla").ToString(),
                            .Observacion = sqlDr("obs").ToString(),
                            .FichaNombres = sqlDr("nom_ficha").ToString(),
                            .TipoFichaId = sqlDr("tipo_fic_id").ToString(),
                            .MotivoModifPenalDet = sqlDr("c_mot_mod_pen").ToString(),
                            .InternoSituacionJuridicaId = sqlDr("sit_jur_id").ToString(),
                            .Observacion_02_rtf = sqlDr("cla_obvs_2").ToString()
                        }
                                objEntCol.Add(objEnt)
                            End While
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al listar fichas: " & ex.Message, ex)
            End Try

            Return objEntCol
        End Function

        ''' <summary>
        ''' hnrb - 05/01/2020
        ''' retorna todas las fichas por ficha final
        ''' </summary>
        ''' <param name="FichaFinalId"></param>
        ''' <returns></returns>
        Public Function ListarFichas_x_fichaFinal(FichaFinalId As Integer) As Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim objEntCol As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim entFich As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                            .FichaFinalId = FichaFinalId
                        }

            Try
                Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlDr = InternoClasificacion_DA.Listar(sqlCon, "lst", "lst_fichas_x_ficha_finalid", entFich)
                        If sqlDr.HasRows Then
                            While sqlDr.Read()
                                Dim objEnt As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                            .Codigo = sqlDr("codigo").ToString(),
                            .InternoId = sqlDr("fk_int_id").ToString(),
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString(),
                            .FichaId = sqlDr("fk_fic_id").ToString(),
                            .FichaNombres = sqlDr("nom_ficha").ToString(),
                            .CategoriaFichaId = sqlDr("fk_cat_fic_id").ToString(),
                            .RegionDestinoId = sqlDr("reg_dest_id").ToString(),
                            .PenalDestinoId = sqlDr("pen_dest_id").ToString(),
                            .FechaClasificacion = sqlDr("fec_clasif").ToString(),
                            .Observacion = sqlDr("obs").ToString(),
                            .Estado = sqlDr("estado_id").ToString(),
                            .PenalId = sqlDr("_PenId").ToString(),
                            .RegionId = sqlDr("_RegId").ToString(),
                            .Puntaje = sqlDr("puntaje").ToString(),
                            .CategoriaFichaNombre = sqlDr("c_cat_desc").ToString(),
                            .TipoFichaId = sqlDr("tipo_fic_id").ToString(),
                            .Observacion_02_rtf = sqlDr("cla_obvs_2").ToString(),
                            .InternoSituacionJuridicaId = sqlDr("sit_jur_id").ToString()
                        }
                                objEntCol.Add(objEnt)
                            End While
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al listar fichas por ficha final: " & ex.Message, ex)
            End Try

            Return objEntCol
        End Function


        Public Function ListarFichaConVariableIndicador_x_fichaFinal(FichaFinalId As Integer) As Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim objEntCol As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim entFich As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                .FichaFinalId = FichaFinalId
            }

            Try
                Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlDr = InternoClasificacion_DA.Listar(sqlCon, "lst", "lst_ficha_con_variable_indicador_x_fichafinal", entFich)
                        If sqlDr.HasRows Then
                            While sqlDr.Read()
                                Dim objEnt As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                                    .Codigo = sqlDr("codigo").ToString(),
                                    .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString(),
                                    .FichaId = sqlDr("fk_fic_id").ToString(),
                                    .TipoFichaId = sqlDr("tipo_fic_id").ToString(),
                                    .VariableNombre = sqlDr("variable").ToString(),
                                    .IndicadorNombre = sqlDr("indicador").ToString(),
                                    .PuntajeProcesado = sqlDr("ptje_proc").ToString()
                                }
                                objEntCol.Add(objEnt)
                            End While
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al listar fichas con variable indicador: " & ex.Message, ex)
            End Try

            Return objEntCol
        End Function


        ''' <summary>
        ''' Autor:Hnrb -> 22/03/2016
        ''' Retorna la lista de todos los internos clasificados pero pendientes de generacion de documento para su derivación 
        ''' a los penales destino.
        ''' </summary>
        ''' <param name="entFich"></param>
        ''' <returns></returns>
        Public Function ListarInternoSinDocClasificacion(entFich As Entity.Clasificacion.InternoClasificacion.InternoFicha) As Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr = InternoClasificacion_DA.Listar(sqlCon, "lst", "lst_grilla_int_sin_doc", entFich)
            Try
                objEntCol = New Entity.Clasificacion.InternoClasificacion.InternoFichaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Clasificacion.InternoClasificacion.InternoFicha
                        With objEnt
                            .Codigo = sqlDr("codigo").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .FichaId = sqlDr("fk_fic_id").ToString
                            .FichaNombres = sqlDr("nom_ficha").ToString '
                            .CategoriaFichaId = sqlDr("fk_cat_fic_id").ToString
                            .RegionDestinoId = sqlDr("fk_reg_dest_id").ToString
                            .PenalDestinoId = sqlDr("fk_pen_dest_id").ToString
                            .FechaClasificacion = sqlDr("fec_cla").ToString
                            .Observacion = sqlDr("obs").ToString
                            .Estado = sqlDr("estado_id").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .Puntaje = sqlDr("puntaje").ToString
                            .CategoriaFichaNombre = sqlDr("c_cat_desc").ToString
                            .NumeroClasificacion = sqlDr("num_sec_clas").ToString
                            .TipoFichaId = sqlDr("tipo_fic_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString
                            .InternoNombres = sqlDr("int_nom").ToString
                            .InternoApePat = sqlDr("int_ape_pat").ToString
                            .InternoApeMat = sqlDr("int_ape_mat").ToString
                            .InternoIngresoNro = sqlDr("int_ing_nro").ToString
                            .RegionDestinoNombre = sqlDr("reg_nom_dest").ToString
                            .PenalDestinoNombre = sqlDr("pen_nom_dest").ToString
                        End With
                        If objEnt.Estado = enmEstadoRegistroFicha.Finalizado.GetHashCode Then
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
                If sqlCon IsNot Nothing Then
                    sqlCon.Close()
                    sqlCon.Dispose()
                End If
            End Try

            'ordenar por   pen_nom_dest,int_ape_pat
            Dim l2 As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim res = From d As Entity.Clasificacion.InternoClasificacion.InternoFicha In objEntCol Order By d.PenalDestinoNombre, d.InternoApePat

            For Each obj As Entity.Clasificacion.InternoClasificacion.InternoFicha In res
                l2.Add(obj)
            Next

            Return l2
        End Function

        Public Function ListarGrilla(entFich As Entity.Clasificacion.InternoClasificacion.InternoFicha) As Entity.Clasificacion.InternoClasificacion.InternoFichaCol
            Dim objEntCol As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol

            Try
                Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlDr = InternoClasificacion_DA.Listar(sqlCon, "lst", "lst_grilla", entFich)
                        If sqlDr.HasRows Then
                            While sqlDr.Read()
                                Dim objEnt As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                            .Codigo = sqlDr("codigo").ToString(),
                            .InternoId = sqlDr("fk_int_id").ToString(),
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString(),
                            .FichaId = sqlDr("fk_fic_id").ToString(),
                            .FichaNombres = sqlDr("nom_ficha").ToString(),
                            .CategoriaFichaId = sqlDr("fk_cat_fic_id").ToString(),
                            .RegionDestinoId = sqlDr("fk_reg_dest_id").ToString(),
                            .PenalDestinoId = sqlDr("fk_pen_dest_id").ToString(),
                            .FechaClasificacion = sqlDr("fec_cla").ToString(),
                            .Observacion = sqlDr("obs").ToString(),
                            .Estado = sqlDr("estado_id").ToString(),
                            .PenalId = sqlDr("_PenId").ToString(),
                            .RegionId = sqlDr("_RegId").ToString(),
                            .Puntaje = sqlDr("puntaje").ToString(),
                            .CategoriaFichaNombre = sqlDr("c_cat_desc").ToString(),
                            .NumeroClasificacion = sqlDr("num_sec_clas").ToString(),
                            .TipoFichaId = sqlDr("tipo_fic_id").ToString(),
                            .InternoCodigo = sqlDr("int_cod_rp").ToString(),
                            .InternoNombres = sqlDr("int_nom").ToString(),
                            .InternoApePat = sqlDr("int_ape_pat").ToString(),
                            .InternoApeMat = sqlDr("int_ape_mat").ToString(),
                            .InternoIngresoNro = sqlDr("int_ing_nro").ToString(),
                            .RegionDestinoNombre = sqlDr("reg_nom_dest").ToString(),
                            .PenalDestinoNombre = sqlDr("pen_nom_dest").ToString(),
                            .GrupoFichaId = sqlDr("n_grp_sec").ToString(),
                            .InternoSituacionJuridicaId = sqlDr("sit_jur_id").ToString(),
                            .NumOrdenTipFic = sqlDr("n_orden_tip_fic").ToString(),
                            .RegimenPenalId = sqlDr("fk_regimen_pen_id").ToString()
                        }
                                objEntCol.Add(objEnt)
                            End While
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al listar la grilla: " & ex.Message, ex)
            Finally

            End Try

            Return objEntCol
        End Function

#End Region
#Region "Validar"
        Private Function Validar(objEnt As Entity.Clasificacion.InternoClasificacion.InternoFicha, ByRef outErr As String) As Boolean

            Select Case objEnt.GrupoFichaId
                Case 2 'validacion de fichas resolucion RESOL. Nº 232-2011-INPE/P
                    If objEnt.CategoriaFichaId < 0 Then outErr = "Categoria incorrecta" : Return False
                Case 3, 4 'validacion de fichas 
                    If objEnt.Puntaje <= 0 And objEnt.TipoFicha = enmTipoFicha.Final Then outErr = "Puntaje incorrecto" : Return False
            End Select

            If objEnt.FechaClasificacion <= 0 Then outErr = "Fecha de clasificación incorrecta" : Return False

            If objEnt.TipoFicha = enmTipoFicha.Final Then
                If objEnt.NumeroClasificacion <= 0 Then outErr = "Número de clasificación incorrecto" : Return False

                If objEnt.Codigo > 0 Then

                    Dim tmp = (New InternoFicha_BL).Listar_V2(objEnt.Codigo)
                    'si el registro no se ha modificado no se hace nada
                    If tmp.NumeroClasificacion = objEnt.NumeroClasificacion And tmp.CategoriaFichaId = objEnt.CategoriaFichaId And
                        tmp.FechaClasificacion = objEnt.FechaClasificacion And tmp.Observacion.Trim = objEnt.Observacion.Trim And
                        tmp.PenalDestinoId = objEnt.PenalDestinoId And tmp.RegionDestinoId = objEnt.RegionDestinoId And
                        tmp.EstadoId = objEnt.EstadoId And tmp.RegimenPenalId = objEnt.RegimenPenalId And
                        tmp.MotivoModifPenalDet = objEnt.MotivoModifPenalDet Then
                        Return False
                    End If
                End If
            End If

            Return True
        End Function
#End Region
#Region "grabar"
        Public Function Grabar(objEnt As Entity.Clasificacion.InternoClasificacion.InternoFicha, ByRef outErr As String) As Integer
            If Validar(objEnt, outErr) = False Then Return -1
            Dim strOpcion As String
            Dim strAccion As String
            If objEnt.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Dim intFicFinalId = InternoClasificacion_DA.Grabar(strAccion, strOpcion, objEnt)

            Return intFicFinalId
        End Function

        Public Function Grabar_Observacion_rtf(objEnt As Entity.Clasificacion.InternoClasificacion.InternoFicha) As Integer

            Dim strOpcion As String = "upd_mant_obvs_rtf"
            Dim strAccion As String = "upd"

            Return InternoClasificacion_DA.Grabar(strAccion, strOpcion, objEnt)
        End Function
        ''' <summary>
        ''' Elimina la ficha del interno, en caso la ficha sea de tipo Ficha Final se debe setear el num de clasificacion a 0 de las demas fichas
        ''' asociadas o relacionadas eso con la finalidad de relacionar las fichas con las q se relacionaran con la nueva fich final en la interface de usuario
        ''' considerando que las fichas de clasificacion pendientes el num clasif debe ser 0.
        ''' </summary>
        ''' <param name="Codigo">Id de interno ficha</param>
        ''' <param name="outErr">Mensaje de error para retornar a la interface de usuario</param>
        ''' <returns>Retorna el Id del registro eliminado caso contrario si hay algun error retorna -1</returns>
        Public Function Eliminar(Codigo As Integer, ByRef outErr As String) As Integer
            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha
            ent = Listar_V2(Codigo)

            If ent.Estado = enmEstadoRegistroFicha.Bloqueado Then
                outErr = "No es posible eliminar el registro, estado de la ficha BLOQUEADO"
                Return -1
            End If

            'si existe ficha final y quiere eliminar las fichas dependientes no debe permitir, obligar a que elimine primero la ficha final
            If ent.Codigo > 0 And ent.TipoFichaId <> enmTipoFicha.Final And ent.FichaFinalId > 0 Then
                outErr = "El eliminar la ficha actual afectará a la ficha final por lo tanto primero debe eliminar la ficha final y luego la ficha actual"
                Return -1
            End If

            'si la ficha final fue referenciado en el documento de consolidado no debe permitir hasta retirar al interno clasificado del doc de consolidado.
            If ent.TipoFichaId = enmTipoFicha.Final Then
                Dim entDetDoc As New Entity.Clasificacion.Documento.DetDocClasificacion With {
                        .InternoFichaId = ent.Codigo
                    }

                Dim entDetDocCol = (New Clasificacion.Documento.DetDocClasificacion_BL).Listar(entDetDoc)
                If entDetDocCol.Count > 0 Then
                    Try

                        Dim entDoc = (New Clasificacion.Documento.DocClasificacion_BL).Listar(entDetDocCol.DetDocClasificacion(0).DocClasificacionId)
                        Dim numDoc = entDoc.NumeroDoc
                        If entDoc.EstadoDocId <> enmEstadoTramiteDoc.Anulado Then
                            outErr = "La ficha está referenciado en el documento de consolidado de clasificación N° " & numDoc & ", para completar la operación primero debe quitar la referencia en dicho documento"
                            Return -1
                        End If

                    Catch ex As Exception
                        outErr = "La ficha está referenciado en un documento de consolidado, para completar la operación primero debe quitar la referencia en dicho documento"
                        Return -1
                    End Try

                End If
            End If

            Return InternoClasificacion_DA.Eliminar("del", "del_mant", Codigo, ent.TipoFichaId)
        End Function
#End Region

    End Class
End Namespace