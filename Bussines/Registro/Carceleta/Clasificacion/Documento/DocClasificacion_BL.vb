Imports System.Data.SqlClient
Imports Bussines.Clasificacion.InternoClasificacion
Imports Data.Registro.Carceleta.Clasificacion.Documento
Imports Type.Enumeracion.Clasificacion

Namespace Clasificacion.Documento
    'tra_asi_mov_documento
    Public Class DocClasificacion_BL
        Private objEnt As Entity.Clasificacion.Documento.DocClasificacion = Nothing
        Private objEntCol As Entity.Clasificacion.Documento.DocClasificacionCol = Nothing

#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Clasificacion.Documento.DocClasificacion
            Dim entFich As New Entity.Clasificacion.Documento.DocClasificacion With {
                .Codigo = Codigo
            }

            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing

            Return objEntCol.DocClasificacion(0)
        End Function

        Public Function UltimoCorrelativoDoc(Anio As Integer) As Integer
            Dim ultNumCor As Integer = 0
            Dim opc As String = "lst_ult_corr_doc"
            Dim entFich As New Entity.Clasificacion.Documento.DocClasificacion With {
                        .AnioDoc = Anio
                    }

            Dim sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr = DocClasificacion_DA.Listar(sqlCon, "lst", opc, entFich)
            Try
                objEntCol = New Entity.Clasificacion.Documento.DocClasificacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Clasificacion.Documento.DocClasificacion With {
                                        .CorrelativoDoc = sqlDr("n_doc_corr").ToString
                                    }

                        objEntCol.Add(objEnt)
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

            If objEntCol.Count > 0 Then
                ultNumCor = objEntCol.DocClasificacion(0).CorrelativoDoc
            End If
            Return ultNumCor
        End Function

        ''' <summary>
        ''' Retorna los 10 últimos registros agregados
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ListarUltimosRegistros() As Entity.Clasificacion.Documento.DocClasificacionCol
            Return Listar(New Entity.Clasificacion.Documento.DocClasificacion, "lst_mant_ult_reg")
        End Function

        Public Function Listar(entFich As Entity.Clasificacion.Documento.DocClasificacion) As Entity.Clasificacion.Documento.DocClasificacionCol
            Return Listar(entFich, "lst_mant")
        End Function

        Private Function Listar(entFich As Entity.Clasificacion.Documento.DocClasificacion, opcion As String) As Entity.Clasificacion.Documento.DocClasificacionCol

            Dim sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr = DocClasificacion_DA.Listar(sqlCon, "lst", opcion, entFich)
            Try
                objEntCol = New Entity.Clasificacion.Documento.DocClasificacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Clasificacion.Documento.DocClasificacion With {
                            .Codigo = sqlDr("pk_doc_id").ToString,
                            .NumeroDoc = sqlDr("c_doc_num").ToString,
                            .Observacion = sqlDr("c_doc_obs").ToString,
                            .EstadoDocId = sqlDr("fk_est_doc").ToString,
                            .FechaEmision = sqlDr("n_doc_fec_emi").ToString,
                            .AnioDoc = sqlDr("n_doc_anio").ToString,
                            .CorrelativoDoc = sqlDr("n_doc_corr").ToString,
                            .PenalId = sqlDr("_PenId").ToString,
                            .RegionId = sqlDr("_RegId").ToString,
                            .EstadoDocString = sqlDr("estado_nom").ToString,
                            .PenalNombre = sqlDr("pen_nom").ToString,
                            .RegionNombre = sqlDr("reg_nom").ToString,
                            .NombreDestinoDoc = sqlDr("c_doc_dest_nom").ToString,
                            .GlosaDocId = sqlDr("fk_glo_doc_id").ToString
                        }
                        objEntCol.Add(objEnt)
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
            Return objEntCol
        End Function
        ''' <summary>
        ''' Retorma la lista de documentos validos sin anulados ni eliminados por numero de documento
        ''' </summary>
        ''' <param name="NumDoc">Numero de documento</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function ListarDocDuplicadosValidos(NumDoc As String) As Entity.Clasificacion.Documento.DocClasificacionCol

            Dim sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr = DocClasificacion_DA.Listar(sqlCon, "lst", "lst_doc_dup_validos", NumDoc.ToUpper)
            Try
                objEntCol = New Entity.Clasificacion.Documento.DocClasificacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Clasificacion.Documento.DocClasificacion With {
                            .Codigo = sqlDr("pk_doc_id").ToString,
                            .NumeroDoc = sqlDr("c_doc_num").ToString,
                            .Observacion = sqlDr("c_doc_obs").ToString,
                            .EstadoDocId = sqlDr("fk_est_doc").ToString,
                            .FechaEmision = sqlDr("n_doc_fec_emi").ToString,
                            .AnioDoc = sqlDr("n_doc_anio").ToString,
                            .CorrelativoDoc = sqlDr("n_doc_corr").ToString,
                            .PenalId = sqlDr("_PenId").ToString,
                            .RegionId = sqlDr("_RegId").ToString,
                            .EstadoDocString = sqlDr("estado_nom").ToString,
                            .PenalNombre = sqlDr("pen_nom").ToString,
                            .RegionNombre = sqlDr("reg_nom").ToString,
                            .NombreDestinoDoc = sqlDr("c_doc_dest_nom").ToString,
                            .GlosaDocId = sqlDr("fk_glo_doc_id").ToString
                        }

                        objEntCol.Add(objEnt)
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
            Return objEntCol
        End Function
#End Region

#Region "Otros"
        Private Function Validar(objEnt As Entity.Clasificacion.Documento.DocClasificacion, ByRef outErr As String) As Boolean
            Dim ColObj = ListarDocDuplicadosValidos(objEnt.NumeroDoc)

            If ColObj Is Nothing Then Return True
            'If ColObj.Count = 0 Then Return True

            If objEnt.GlosaDocId = -1 Then
                outErr = "Glosa incorrecto"
                Return False
            End If

            If objEnt.Codigo = -1 And ColObj.Count > 0 Then 'si es nuevo
                outErr = "Número de documento duplicado"
                Return False
            End If

            If objEnt.Codigo > 0 Then
                If ColObj.Count > 0 AndAlso ColObj.DocClasificacion(0).Codigo <> objEnt.Codigo Then
                    outErr = "Número de documento duplicado"
                    Return False
                End If
            End If

            Dim n As New Entity.Clasificacion.Documento.DocClasificacion With {
                    .CorrelativoDoc = objEnt.CorrelativoDoc,
                    .AnioDoc = objEnt.AnioDoc
                }

            ColObj = Listar(n)
            If ColObj.Count > 0 Then
                If objEnt.Codigo = -1 And ColObj.Count > 0 Then 'si es nuevo
                    outErr = "Número correlativo duplicado"
                    Return False
                End If
                If objEnt.Codigo <> ColObj.DocClasificacion(0).Codigo Then
                    outErr = "Número correlativo ya existe"
                    Return False
                End If
            End If

            'antes de anular se debe verificar que no esté referenciado en ningun movimiento.
            If objEnt.EstadoDocId = enmEstadoTramiteDoc.Anulado Then
                Dim entMov As New Entity.Registro.InternoMovimiento With {
                        .DocumJudicialID = objEnt.Codigo,
                        .MovimientoGrupoID = 2, 'egreso
                        ._PenalID = 35,
                        .MovimientoTipoID = 2 'traslado
                    }
                Dim mm = (New Bussines.Registro.InternoMovimiento).Listar_LM_v2(entMov)
                If mm.Count > 0 Then
                    Dim ids As String = ""
                    For Each obj As Entity.Registro.InternoMovimiento In mm
                        ids = ids & "Id Interno: " & obj.InternoID
                    Next
                    outErr = "El documento ha sido referenciado en el movimiento de traslado, debe quitar dicha referencia en el movimiento o eliminar el registro de movimiento. " & vbCrLf & ids
                    Return False
                End If
            End If

            Return True
        End Function

        ''' <summary>
        ''' hnrb -> 22/03/2016
        ''' Permite cambiar el estado de la ficha de clasificacion a bloqueado para no ser alterado
        ''' </summary>
        ''' <param name="DocumentoClasificacionId"></param>
        ''' <remarks></remarks>
        Private Sub BloquearClasificacion(DocumentoClasificacionId As Integer)
            Dim bss As New InternoFicha_BL
            Dim ent As New Entity.Clasificacion.Documento.DetDocClasificacion With {
                    .DocClasificacionId = DocumentoClasificacionId
                }

            Dim colDetDoc = (New DetDocClasificacion_BL).Listar(ent)

            For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In colDetDoc

                Dim intFic = bss.Listar_V2(obj.InternoFichaId)
                intFic.Estado = enmEstadoRegistroFicha.Bloqueado

                Dim id = bss.Grabar(intFic, "")

                'cambiar el estado de las fichas relacionadas a la ficha final
                Dim entFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                        .FichaFinalId = obj.InternoFichaId
                    }

                Dim entFicCol = (New InternoFicha_BL).Listar_v2(entFic)
                For Each fic As Entity.Clasificacion.InternoClasificacion.InternoFicha In entFicCol
                    fic.Estado = enmEstadoRegistroFicha.Bloqueado
                    id = bss.Grabar(fic, "")
                Next

            Next
        End Sub

        ''' <summary>
        ''' hnrb -> 22/03/2016
        ''' Permite cambiar el estado de la ficha de clasificacion de BLOQUEADO a PENDIENTE
        ''' </summary>
        ''' <param name="DocumentoClasificacionId"></param>
        ''' <remarks></remarks>
        Private Sub DesBloquearClasificacion(DocumentoClasificacionId As Integer)
            Dim bss As New InternoFicha_BL

            Dim ent As New Entity.Clasificacion.Documento.DetDocClasificacion With {
                    .DocClasificacionId = DocumentoClasificacionId
                }

            Dim colDetDoc = (New DetDocClasificacion_BL).Listar(ent)
            For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In colDetDoc
                Dim intFic = bss.Listar_V2(obj.InternoFichaId)
                intFic.Estado = enmEstadoRegistroFicha.Finalizado
                Dim id As Integer = bss.Grabar(intFic, "")

                'cambiar el estado de las fichas relacionadas a la ficha final
                Dim entFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                        .FichaFinalId = obj.InternoFichaId
                    }

                Dim entFicCol = (New InternoFicha_BL).Listar_v2(entFic)
                For Each fic As Entity.Clasificacion.InternoClasificacion.InternoFicha In entFicCol
                    fic.Estado = enmEstadoRegistroFicha.Finalizado
                    bss.Grabar(fic, "")
                Next
            Next
        End Sub
#End Region

#Region "Grabar"
        Public Function Grabar(objEnt As Entity.Clasificacion.Documento.DocClasificacion, ByRef outErr As String) As Integer
            If Validar(objEnt, outErr) = False Then Return -1

            objEnt.NumeroDoc = objEnt.NumeroDoc.ToUpper.Trim
            objEnt.NombreDestinoDoc = objEnt.NombreDestinoDoc.Trim.ToUpper

            Dim strOpcion As String
            Dim strAccion As String
            If objEnt.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Dim v = DocClasificacion_DA.Grabar(strAccion, strOpcion, objEnt)

            If v > 0 And objEnt.EstadoDocId = enmEstadoTramiteDoc.Derivado Then BloquearClasificacion(objEnt.Codigo)
            If v > 0 And objEnt.EstadoDocId = enmEstadoTramiteDoc.Anulado Then DesBloquearClasificacion(objEnt.Codigo)

            Return v
        End Function

        Public Function Eliminar(ByVal Codigo As Integer, ByRef outErr As String) As Integer
            Dim intValue = DocClasificacion_DA.Eliminar("del", "del_mant", Codigo)
            If intValue > 0 Then DesBloquearClasificacion(Codigo)
            Return intValue
        End Function
#End Region
    End Class
End Namespace