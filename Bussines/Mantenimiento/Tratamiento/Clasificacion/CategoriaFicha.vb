Imports System.Data.SqlClient

Namespace Clasificacion
    Public Class CategoriaFicha

        Private objEnt As Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE = Nothing
        Private objEntCol As Entity.Registro.Carceleta.Clasificacion.CategoriaFichaCol_BE = Nothing

        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE
            Dim entFich As New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE
            entFich.Codigo = Codigo
            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing

            Return objEntCol.CategoriaFicha(0)
        End Function

        Public Function Listar(entFich As Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE) As Entity.Registro.Carceleta.Clasificacion.CategoriaFichaCol_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.CategoriaFicha.Listar(sqlCon, "lst", "lst_mant", entFich)
            Try
                objEntCol = New Entity.Registro.Carceleta.Clasificacion.CategoriaFichaCol_BE
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE
                        With objEnt
                            .Codigo = sqlDr("pk_cat_fic_id").ToString
                            .FichaId = sqlDr("fk_fic_id").ToString
                            .CategoriaNombre = sqlDr("c_cat_desc").ToString
                            .CategoriaClasificacionId = sqlDr("fk_cat_cla_id").ToString
                            .ValorMinimo = sqlDr("n_val_min").ToString
                            .ValorMaximo = sqlDr("n_val_max").ToString
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
            objEntCol.Sort("ValorMinimo")
            Return objEntCol
        End Function
        Private Function Validar(_objEnt As Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE, ByRef outErr As String) As Boolean
            If _objEnt.FichaId = -1 Then outErr = "FichaId no valido"
            If _objEnt.CategoriaNombre.Length <= 0 Then outErr = outErr & "Nombre de categoria no válido" & vbCrLf
            If _objEnt.ValorMaximo <= 0 Then outErr = outErr & "Valor máximo no válido" & vbCrLf
            If _objEnt.ValorMinimo <= 0 Then outErr = outErr & "Valor mínimo no válido" & vbCrLf
            If _objEnt.ValorMaximo <= _objEnt.ValorMinimo Then outErr = outErr & "El Valor máximo no puede ser menor ni igual al valor mínimo" & vbCrLf

            objEnt = New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE
            objEnt.CategoriaNombre = _objEnt.CategoriaNombre
            objEnt.FichaId = _objEnt.FichaID
            If _objEnt.Codigo = -1 Then
                If Listar(objEnt).Count > 0 Then outErr = outErr & "La categoria con el nombre " & _objEnt.CategoriaNombre & " ya existe, cambie por otro nombre" & vbCrLf
            Else
                objEntCol = Listar(objEnt)
                If objEntCol.Count > 0 Then
                    If objEntCol.CategoriaFicha(0).Codigo <> _objEnt.Codigo Then outErr = outErr & "La categoria con el nombre " & _objEnt.CategoriaNombre & " ya existe, cambie por otro nombre" & vbCrLf
                End If
            End If

            If outErr.Length > 0 Then Return False
            Return True
        End Function
        Public Function Grabar(objEnt As Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE, ByRef outErr As String) As Integer
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
            v = Data.Clasificacion.CategoriaFicha.Grabar(strAccion, strOpcion, objEnt)
            Return v
        End Function
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByRef outErr As String) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Clasificacion.CategoriaFicha.Eliminar(strAccion, strOpcion, Codigo, outErr)
            Return intValue
        End Function
#End Region
    End Class
End Namespace
