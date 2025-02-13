Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class Banda
        Private objEnt As Entity.Registro.Banda = Nothing
        Private objEntCol As Entity.Registro.BandaCol = Nothing

#Region "Funciones"
        Public Function ListarID(ByVal Codigo As Integer) As Integer

            Dim value As Integer = -1
            objEnt = New Entity.Registro.Banda

            objEnt.Codigo = Codigo

            value = Data.Registro.Banda.ListarOutput("lst", "lst_id", objEnt)

            Return value

        End Function
        Public Function ActualizarTabla(ByVal Tabla As System.Data.DataTable) As Boolean

            Dim blnValue As Boolean = False
            Dim intCodigoWs As Integer = -1
            Dim intCodigoLocal As Integer = -1

            If Not Tabla Is Nothing Then

                Dim intBandaTipo As Integer = -1
                Dim strBandaNombre As String = ""
                Dim strBandaDes As String = ""

                For Each Fila As System.Data.DataRow In Tabla.Rows

                    intCodigoWs = Fila("ban_id").ToString
                    intCodigoLocal = ListarID(intCodigoWs)

                    If IsDBNull(Fila("ban_tip_id")) = False Then
                        intBandaTipo = Fila("ban_tip_id").ToString
                    Else
                        intBandaTipo = -1
                    End If

                    If IsDBNull(Fila("ban_nom")) = False Then
                        strBandaNombre = Fila("ban_nom").ToString
                    Else
                        strBandaNombre = ""
                    End If

                    If IsDBNull(Fila("ban_des")) = False Then
                        strBandaDes = Fila("ban_des").ToString
                    Else
                        strBandaDes = ""
                    End If

                    Try
                        Dim strAccion As String = ""
                        Dim strOpcion As String = ""

                        objEnt = New Entity.Registro.Banda

                        With objEnt
                            .Codigo = intCodigoWs
                            .BandaTipoID = intBandaTipo
                            .BandaNombre = strBandaNombre
                            .BandaDescripcion = strBandaDes
                        End With

                        If intCodigoLocal > 0 Then
                            strAccion = "upd"
                            strOpcion = "upd_mant"
                        Else
                            strAccion = "ins"
                            strOpcion = "ins_mant_local"
                        End If

                        Grabar(strAccion, strOpcion, objEnt)

                    Catch ex As Exception
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        intCodigoLocal.ToString & ".- " & ex.ToString)
                    End Try

                Next
                blnValue = True

            End If

            Return blnValue

        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Banda

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Banda.Listar(sqlCon, "lst", "lst_mant", Codigo, -1, "")
            objEnt = New Entity.Registro.Banda
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("ban_id").ToString
                            .BandaTipoID = sqlDr("ban_tip_id").ToString
                            .BandaTipoNombre = sqlDr("ban_tip_nom").ToString()
                            .BandaNombre = sqlDr("ban_nom").ToString()
                            .BandaDescripcion = sqlDr("ban_des").ToString
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
        Public Function Listar(objBanda As Entity.Registro.Banda) As Entity.Registro.BandaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Banda.Listar(sqlCon, "lst", "lst_mant", objBanda)

            objEntCol = New Entity.Registro.BandaCol

            Try
                objEntCol = New Entity.Registro.BandaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Banda
                        With objEnt
                            .Codigo = sqlDr("ban_id").ToString
                            .BandaTipoID = sqlDr("ban_tip_id").ToString
                            .BandaTipoNombre = sqlDr("ban_tip_nom").ToString()
                            .BandaNombre = sqlDr("ban_nom").ToString()
                            .BandaDescripcion = sqlDr("ban_des").ToString                        
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
        Private Function ValidarNombre(ByVal BandaId As Integer, ByVal TipoBandaID As Integer, ByVal NombreBanda As String) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = -1
            If BandaId > 0 Then
                intValue = Data.Registro.Banda.ListarOutput("lst", "lst_validar_upd", BandaId, TipoBandaID, NombreBanda)
            Else
                intValue = Data.Registro.Banda.ListarOutput("lst", "lst_validar_ins", BandaId, TipoBandaID, NombreBanda)
            End If

            If intValue > 0 Then
                blnValue = False
            End If

            Return blnValue
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objBanda As Entity.Registro.Banda, ByRef strOutSms As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objBanda.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            objBanda.BandaNombre = objBanda.BandaNombre.Trim.Replace(" ", "").Replace("'", "").ToUpper
            objBanda.BandaDescripcion = objBanda.BandaDescripcion.Trim.Replace(" ", "").Replace("'", "").ToUpper

            If ValidarNombre(objBanda.Codigo, objBanda.BandaTipoID, objBanda.BandaNombre) = False Then
                strOutSms = "El Nombre de la Banda u Organización criminal ya existe."
            Else
                intValue = Data.Registro.Banda.Grabar(strAccion, strOpcion, objBanda)
            End If

            Return intValue

        End Function

        Public Function Grabar(Accion As String, Opcion As String, ByVal objBanda As Entity.Registro.Banda) As Integer

            Dim value As Integer = -1

            value = Data.Registro.Banda.Grabar(Accion, Opcion, objBanda)

            Return value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Banda.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
#End Region
    End Class
End Namespace