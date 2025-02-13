Imports System.Data
Imports System.Data.SqlClient
Namespace Clasificacion
    Public Class MaestroFicha
        Private objEnt As Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE = Nothing
        Private objEntCol As Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol_BE = Nothing
#Region "Listar"
        Public Function Listar() As Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol_BE
            Dim entFich As New Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE
            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing
            Return objEntCol
        End Function

        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE
            Dim entFich As New Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE
            entFich.Codigo = Codigo
            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing

            Return objEntCol.Ficha(0)
        End Function

        'Public Function ListarFichaPermiso(blnVerFichaLegal As Boolean, blnVerFichaPsicologica As Boolean, blnVerFichaSocial As Boolean,
        '                       blnVerFichaFinal As Boolean, objEnt As Entity.Registro.Carceleta.Clasificacion.MaestroFicha) As Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol

        '    Dim value As New Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol
        '    objEntCol = New Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol
        '    objEntCol = Listar(objEnt)

        '    For Each objFila As Entity.Registro.Carceleta.Clasificacion.MaestroFicha In objEntCol

        '        If objFila.TipoFichaId = Type.Enumeracion.Clasificacion.enmTipoFicha.Legal Then
        '            If blnVerFichaLegal = True Then
        '                value.Add(objFila)
        '            End If
        '        End If

        '        If objFila.TipoFichaId = Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica Then
        '            If blnVerFichaPsicologica = True Then
        '                value.Add(objFila)
        '            End If
        '        End If

        '        If objFila.TipoFichaId = Type.Enumeracion.Clasificacion.enmTipoFicha.Social Then
        '            If blnVerFichaSocial = True Then
        '                value.Add(objFila)
        '            End If
        '        End If

        '        If objFila.TipoFichaId = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
        '            If blnVerFichaFinal = True Then
        '                value.Add(objFila)
        '            End If
        '        End If

        '    Next

        '    Return value

        'End Function
        Public Function Listar(entFich As Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE) As Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.MaestroFicha.Listar(sqlCon, "lst", "lst_mant", entFich)
            Try
                objEntCol = New Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol_BE
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE
                        With objEnt
                            .Codigo = sqlDr("pk_fic_id").ToString
                            .AmbitoClasificacionId = sqlDr("fk_amb_cla_id").ToString
                            .Nombre = sqlDr("c_fic_nom").ToString
                            .TipoFichaId = sqlDr("fk_tip_fic_id").ToString
                            .GrupoSecuencial = sqlDr("n_grp_sec").ToString
                            .Secuencia = sqlDr("n_fic_sec").ToString
                            .Descripcion = sqlDr("n_fic_des").ToString
                            .DocAprobacion = sqlDr("n_fic_doc").ToString
                            .DocAprobacionFecha = sqlDr("n_fic_doc_fec").ToString
                            .EstadoId = sqlDr("n_fic_est").ToString

                            .AmbitoClasificacionNombre = sqlDr("amb_clas_nom").ToString
                            .TipoFichaNombre = sqlDr("tip_fic_nom").ToString
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

        Private Function Validar(objEnt As Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE, ByRef outErr As String) As Boolean
            outErr = ""
            If objEnt.AmbitoClasificacionId = -1 Then outErr = "Ambito de clasificación no especificado" & vbCrLf
            If objEnt.Nombre.Length = 0 Then outErr = outErr & "Nombre de la ficha no especificada" & vbCrLf
            If objEnt.Secuencia <= 0 Then outErr = outErr & "Número de secuencia erroneo" & vbCrLf
            If objEnt.TipoFichaId = -1 Then outErr = outErr & "Tipo de ficha no especificado"

            If outErr.Length > 0 Then Return False

            Return True
        End Function
        Public Function Grabar(objEnt As Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE, ByRef outErr As String) As Integer
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
            Dim v As Integer
            v = Data.Clasificacion.MaestroFicha.Grabar(strAccion, strOpcion, objEnt)
            Return v
        End Function
        Public Function InactivarRegistro(Codigo As Integer) As Integer
            Dim strOpcion As String
            Dim strAccion As String
            objEnt = New Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE
            objEnt.Codigo = Codigo

            strAccion = "upd"
            strOpcion = "upd_mant"

            Dim v As Integer
            v = Data.Clasificacion.MaestroFicha.Grabar(strAccion, strOpcion, objEnt)
            Return v
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByRef outErr As String) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Clasificacion.MaestroFicha.Eliminar(strAccion, strOpcion, Codigo, outErr)
            Return intValue
        End Function
#End Region
    End Class
End Namespace