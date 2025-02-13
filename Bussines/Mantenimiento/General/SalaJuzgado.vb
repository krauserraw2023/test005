Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento
    Public Class SalaJuzgado
        Private objEnt As Entity.Mantenimiento.SalaJuzgado = Nothing
        Private objEntCol As Entity.Mantenimiento.SalaJuzgadoCol = Nothing
#Region "Functions"
        Public Function ListarID(ByVal DistritoJudicialCodigo As String, ByVal SalaJudidicalCodigo As String) As Integer

            Dim value As Integer = -1

            value = Data.Mantenimiento.SalaJuzgado.ListarOutput("lst", "lst_id_filtro", -1, -1, DistritoJudicialCodigo, SalaJudidicalCodigo, "")

            Return value

        End Function
        Public Shared Function Codigo(ByVal DistritoJudicialCodigo As String, ByVal SalaJudidicalCodigo As String) As Integer
            Dim value As Integer = -1

            value = Data.Mantenimiento.SalaJuzgado.ListarOutput("lst", "lst_id_filtro", -1, -1, DistritoJudicialCodigo, SalaJudidicalCodigo, "")

            Return value
        End Function
#End Region
#Region "Validacion"
        Private Function Validar(objEnt As Entity.Mantenimiento.SalaJuzgado, ByRef mensajeOut As String) As Boolean

            Dim mensajeValidacion As String = ""

            '1.- validar el nombre de la sala
            Dim objEntFiltro As New Entity.Mantenimiento.SalaJuzgado
            Dim tmpEntCol As New Entity.Mantenimiento.SalaJuzgadoCol

            objEntFiltro.Estado = 1 'activo
            objEntFiltro.Nombre = objEnt.Nombre

            tmpEntCol = Listar(objEntFiltro)

            For Each obj As Entity.Mantenimiento.SalaJuzgado In tmpEntCol

                If objEnt.Codigo > 0 Then
                    If (objEnt.Nombre = obj.Nombre) And objEnt.Codigo <> objEnt.Codigo Then
                        mensajeValidacion = If(mensajeValidacion.Length > 0, mensajeValidacion & vbCrLf, "") & "●- Nombre sala duplicado."
                    End If
                Else
                    If (objEnt.Nombre = obj.Nombre) Then
                        mensajeValidacion = If(mensajeValidacion.Length > 0, mensajeValidacion & vbCrLf, "") & "●- Nombre sala duplicado."
                    End If
                End If
            Next

            If mensajeValidacion.Trim.Length > 3 Then
                mensajeOut = mensajeValidacion
                Return False
            End If

            '2.- validar nombre corto
            If objEnt.NombreCorto.Trim.Length > 0 Then

                objEntFiltro = New Entity.Mantenimiento.SalaJuzgado

                objEntFiltro.Estado = 1 'activo
                objEntFiltro.NombreCorto = objEnt.NombreCorto

                tmpEntCol = Listar(objEntFiltro)

                If tmpEntCol.Count > 0 Then
                    objEntFiltro = tmpEntCol.Sala(0)
                    If objEnt.Codigo > 0 Then
                        If (objEnt.NombreCorto = objEntFiltro.NombreCorto) And objEnt.Codigo <> objEnt.Codigo Then
                            mensajeValidacion = If(mensajeValidacion.Length > 0, mensajeValidacion & vbCrLf, "") & "●- Nombre corto duplicado."
                        End If
                    Else
                        If (objEnt.NombreCorto = objEnt.NombreCorto) Then
                            mensajeValidacion = If(mensajeValidacion.Length > 0, mensajeValidacion & vbCrLf, "") & "●- Nombre corto duplicado."
                        End If
                    End If
                End If
            End If

            If mensajeValidacion.Trim.Length > 3 Then
                mensajeOut = mensajeValidacion
                Return False
            End If

            '3.- validar, sala en uso
            If validarSalaEnUso(objEnt.Codigo, objEnt) = True Then
                mensajeValidacion = "La Sala seleccionada no se puede modificar, ya que existen registros relacionados."
                mensajeOut = mensajeValidacion
                Return False
            End If

            Return True
        End Function
        Public Function validarSalaEnUso(intIDSalaJuzgado As Integer, objEnt As Entity.Mantenimiento.SalaJuzgado) As Boolean

            Dim value As Boolean = False
            Dim intCount As Integer = 0

            Dim objEntFiltro As New Entity.Mantenimiento.SalaJuzgado
            With objEntFiltro
                .SalaCodigo = intIDSalaJuzgado
            End With

            intCount = Data.Mantenimiento.SalaJuzgado.ListarOutput("lst", "val_sala_en_uso", intIDSalaJuzgado, -1, "", "", "")

            If intCount >= 1 Then

                Dim objEntRegistro As New Entity.Mantenimiento.SalaJuzgado
                objEntRegistro = Listar(intIDSalaJuzgado)

                If objEntRegistro.Nombre.Trim.ToUpper <> objEnt.Nombre.Trim.ToUpper Then
                    value = True
                End If

            End If

            Return value
        End Function
        Public Function validarSalaEnUso(intIDSalaJuzgado As Integer) As Boolean

            Dim value As Boolean = False
            Dim intCount As Integer = 0

            Dim objEntFiltro As New Entity.Mantenimiento.SalaJuzgado
            With objEntFiltro
                .SalaCodigo = intIDSalaJuzgado
            End With

            intCount = Data.Mantenimiento.SalaJuzgado.ListarOutput("lst", "val_sala_en_uso", intIDSalaJuzgado, -1, "", "", "")

            If intCount >= 1 Then
                value = True
            End If

            Return value
        End Function
#End Region
#Region "Listar"

        Public Function Listar(ByVal Codigo As Integer) As Entity.Mantenimiento.SalaJuzgado
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim ent As New Entity.Mantenimiento.SalaJuzgado
            ent.Codigo = Codigo

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.SalaJuzgado.Listar(sqlCon, "lst", "lst_mant", ent)
            objEnt = New Entity.Mantenimiento.SalaJuzgado

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .DistritoJudID = sqlDr("par_prn_id").ToString
                            .DistritoJudCodigo = sqlDr("par_cod_prn").ToString
                            .SalaCodigo = sqlDr("par_cod").ToString
                            .Nombre = sqlDr("par_nom").ToString.ToUpper
                            .NombreCorto = sqlDr("par_nom_cor").ToString.ToUpper
                            .Estado = sqlDr("sal_juz_est").ToString
                            .JurisdiccionId = sqlDr("fk_aut_jud_jur_id").ToString
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

        Public Function Listar(objEntFiltro As Entity.Mantenimiento.SalaJuzgado) As Entity.Mantenimiento.SalaJuzgadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.SalaJuzgado.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            Try
                objEntCol = New Entity.Mantenimiento.SalaJuzgadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.SalaJuzgado
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .DistritoJudID = sqlDr("par_prn_id").ToString
                            .DistritoJudicialNombre = sqlDr("aut_jud_nom").ToString.ToUpper
                            .DistritoJudCodigo = sqlDr("par_cod_prn").ToString
                            .SalaCodigo = sqlDr("par_cod").ToString
                            .Nombre = sqlDr("par_nom").ToString.ToUpper
                            .NombreCorto = sqlDr("par_nom_cor").ToString.ToUpper
                            .Estado = sqlDr("sal_juz_est").ToString
                            .JurisdiccionId = sqlDr("fk_aut_jud_jur_id").ToString
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

        Public Function ListarPopup(intDistritoJudicial As Integer, strNombreSala As String) As Entity.Mantenimiento.SalaJuzgadoCol

            Dim objEntFiltro As New Entity.Mantenimiento.SalaJuzgado
            With objEntFiltro
                .DistritoJudID = intDistritoJudicial
                .Nombre = strNombreSala
                .Estado = 1 'solo registros con estado de alta
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.SalaJuzgado.Listar(sqlCon, "lst", "lst_grilla_popup", objEntFiltro)

            Try
                objEntCol = New Entity.Mantenimiento.SalaJuzgadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.SalaJuzgado
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .DistritoJudID = sqlDr("par_prn_id").ToString
                            .DistritoJudicialNombre = sqlDr("aut_jud_nom").ToString.ToUpper
                            .Nombre = sqlDr("par_nom").ToString
                            .NombreCorto = sqlDr("par_nom_cor").ToString
                            .Estado = sqlDr("sal_juz_est").ToString
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


        '23/12/2016
        Public Function Grabar(objEnt As Entity.Mantenimiento.SalaJuzgado, ByRef outSMS As String) As Integer

            If Validar(objEnt, outSMS) = False Then
                Return False
            End If

            With objEnt
                .DistritoJudicialNombre = objEnt.DistritoJudicialNombre.Trim.ToUpper.Replace("  ", " ")
                .DistritoJudCodigo = objEnt.DistritoJudCodigo.Trim.ToUpper.Replace("  ", " ")
                .SalaCodigo = objEnt.SalaCodigo.Trim.ToUpper.Replace("  ", " ")
                .Nombre = objEnt.Nombre.Trim.ToUpper.Replace("  ", " ")
                .NombreCorto = .NombreCorto.Trim.ToUpper.Replace("  ", " ")
            End With

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Return Data.Mantenimiento.SalaJuzgado.Grabar(strAccion, strOpcion, objEnt)

        End Function
#End Region
#Region "Eliminar"


        Public Function Eliminar(ByVal Codigo As Integer, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If validarSalaEnUso(Codigo) = True Then
                strMensajeOut = "La Sala seleccionada no se puede eliminar, ya que existen registros relacionados."
                Return value
            End If

            strAccion = "del"
            strOpcion = "del_mant"
            value = Eliminar(strAccion, strOpcion, Codigo)

            Return value
        End Function

        Private Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer

            Dim intValue As Integer = -1

            intValue = Data.Mantenimiento.SalaJuzgado.Eliminar(accion, opcion, Codigo,
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function

#End Region
    End Class
End Namespace