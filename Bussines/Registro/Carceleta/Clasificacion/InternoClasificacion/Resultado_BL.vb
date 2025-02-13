Imports System.Data
Imports System.Data.SqlClient
Imports Data.Registro.Carceleta.Clasificacion.InternoClasificacion
Namespace Clasificacion.InternoClasificacion
    Public Class Resultado_BL
        Private objEnt As Entity.Clasificacion.InternoClasificacion.Resultado = Nothing
        Private objEntCol As Entity.Clasificacion.InternoClasificacion.ResultadoCol = Nothing
#Region "Listar"
        'Public Function Listar(ByVal Codigo As Integer) As Entity.Clasificacion.InternoClasificacion.Resultado

        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    Dim sqlDr As SqlDataReader = Resultado_DA.Listar(sqlCon, "lst", "", Codigo, -1, -1, -1, -1, -1, -1, -1, "", "", -1, "", 0)
        '    objEnt = New Entity.Clasificacion.InternoClasificacion.Resultado
        '    Try
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                With objEnt
        '                    .Codigo = sqlDr("int_cla_res_id").ToString
        '                    .InternoClasificacionID = sqlDr("int_cla_id").ToString
        '                    .InternoClasificacionFichaId = sqlDr("int_cla_fic_id").ToString
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .IngresoID = sqlDr("int_ing_id").ToString
        '                    .FichaID = sqlDr("fic_id").ToString
        '                    .VariableId = sqlDr("var_id").ToString
        '                    .Secuencia = sqlDr("var_sec").ToString
        '                    .VariableNombre = sqlDr("var_nom").ToString
        '                    .VariableDescripcion = sqlDr("var_des").ToString
        '                    .ValorId = sqlDr("val_id").ToString
        '                    .ValorDescripcion = sqlDr("val_des").ToString
        '                    .ValorNota = sqlDr("val_not").ToString
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
        'Public Function Listar(ByVal Codigo As Integer,
        'ByVal InternoClasificacionID As Integer,
        'ByVal InternoClasificacionFichaId As Integer,
        'ByVal InternoID As Integer,
        'ByVal IngresoID As Integer,
        'ByVal FichaID As Integer,
        'ByVal VariableId As Integer,
        'ByVal Secuencia As Integer,
        'ByVal VariableNombre As String,
        'ByVal VariableDescripcion As String,
        'ByVal ValorId As Integer,
        'ByVal ValorDescripcion As String,
        'ByVal ValorNota As Decimal
        ') As Entity.Clasificacion.InternoClasificacion.ResultadoCol

        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    Dim sqlDr As SqlDataReader = Resultado_DA.Listar(sqlCon, "lst", "", Codigo,
        '    InternoClasificacionID,
        '    InternoClasificacionFichaId,
        '    InternoID,
        '    IngresoID,
        '    FichaID,
        '    VariableId,
        '    Secuencia,
        '    VariableNombre,
        '    VariableDescripcion,
        '    ValorId,
        '    ValorDescripcion,
        '    ValorNota
        '    )
        '    Try
        '        objEntCol = New Entity.Clasificacion.InternoClasificacion.ResultadoCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Clasificacion.InternoClasificacion.Resultado
        '                With objEnt
        '                    .Codigo = sqlDr("int_cla_res_id").ToString
        '                    .InternoClasificacionID = sqlDr("int_cla_id").ToString
        '                    .InternoClasificacionFichaId = sqlDr("int_cla_fic_id").ToString
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .IngresoID = sqlDr("int_ing_id").ToString
        '                    .FichaID = sqlDr("fic_id").ToString
        '                    .VariableId = sqlDr("var_id").ToString
        '                    .Secuencia = sqlDr("var_sec").ToString
        '                    .VariableNombre = sqlDr("var_nom").ToString
        '                    .VariableDescripcion = sqlDr("var_des").ToString
        '                    .ValorId = sqlDr("val_id").ToString
        '                    .ValorDescripcion = sqlDr("val_des").ToString
        '                    .ValorNota = sqlDr("val_not").ToString
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
        'Public Function Grabar(ByVal Codigo As Integer,
        'ByVal InternoClasificacionID As Integer,
        'ByVal InternoClasificacionFichaId As Integer,
        'ByVal InternoID As Integer,
        'ByVal IngresoID As Integer,
        'ByVal FichaID As Integer,
        'ByVal VariableId As Integer,
        'ByVal Secuencia As Integer,
        'ByVal VariableNombre As String,
        'ByVal VariableDescripcion As String,
        'ByVal ValorId As Integer,
        'ByVal ValorDescripcion As String,
        'ByVal ValorNota As Decimal,
        'ByVal Usuario As Integer) As Integer
        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""
        '    If Codigo < 1 Then
        '        strAccion = "ins"
        '        strOpcion = "ins_mant"
        '    Else
        '        strAccion = "upd"
        '        strOpcion = "upd_mant"
        '    End If
        '    intValue = Resultado_DA.Grabar(strAccion, strOpcion, Codigo,
        '    InternoClasificacionID,
        '    InternoClasificacionFichaId,
        '    InternoID,
        '    IngresoID,
        '    FichaID,
        '    VariableId,
        '    Secuencia,
        '    VariableNombre,
        '    VariableDescripcion,
        '    ValorId,
        '    ValorDescripcion,
        '    ValorNota,
        '    Usuario)
        '    Return intValue
        'End Function
#End Region
#Region "Eliminar"
        'Public Function Eliminar(ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""
        '    strAccion = "del"
        '    strOpcion = "del_mant"
        '    intValue = Resultado_DA.Eliminar(strAccion, strOpcion, Codigo, Usuario)
        '    Return intValue
        'End Function
#End Region
    End Class
End Namespace