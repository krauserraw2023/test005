Imports System.Data.SqlClient
Imports Data.Registro.Carceleta.Clasificacion.InternoClasificacion

Namespace Clasificacion.InternoClasificacion
    Public Class InternoFichaDetalle_BL
        Private objEnt As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle = Nothing
        Private objEntCol As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalleCol = Nothing
#Region "Listar"
        'Public Function Listar(ByVal Codigo As Integer) As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle
        '    Dim entFich As New Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle
        '    entFich.Codigo = Codigo
        '    objEntCol = Listar(entFich)
        '    If objEntCol Is Nothing Then Return Nothing
        '    Return objEntCol.InternoFichaDetalle(0)
        'End Function
        Public Function Listar(entFich As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle) As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalleCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoFichaDetalle_DA.Listar(sqlCon, "lst", "lst_mant", entFich)
            Try
                objEntCol = New Entity.Clasificacion.InternoClasificacion.InternoFichaDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle
                        With objEnt
                            .Codigo = sqlDr("pk_det_id").ToString
                            .InternoFichaId = sqlDr("fk_int_fic_id").ToString
                            .VariableId = sqlDr("fk_var_id").ToString
                            .IndicadorId = sqlDr("fk_ind_id").ToString
                            .Ponderacion = sqlDr("det_num_pond").ToString
                            .PonderacionNoPrevista = sqlDr("det_no_prev").ToString
                            .Estado = sqlDr("det_est").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
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
        Private Function Validar(objEnt As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle, ByRef outErr As String) As Boolean
            Return True
        End Function
#End Region
#Region "grabar"
        Public Function Grabar(objEnt As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle, ByRef outErr As String) As Integer
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
            Return InternoFichaDetalle_DA.Grabar(strAccion, strOpcion, objEnt)
        End Function

        'Public Function Eliminar(Codigo As Integer, ByRef outErr As String) As Integer
        '    Return InternoFichaDetalle_DA.Eliminar("ins", "ins_mant", Codigo)
        'End Function
#End Region
    End Class
End Namespace