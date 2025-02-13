Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoAlias
        Private objEnt As Entity.Registro.InternoAlias = Nothing
        Private objEntCol As Entity.Registro.InternoAliasCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.InternoAlias

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoAlias.Listar(sqlCon, "lst", "lst_mant", Codigo, -1, "")
            objEnt = New Entity.Registro.InternoAlias
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ali_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Nombres = sqlDr("int_ali_nom").ToString
                            '.IngresoID = sqlDr("int_ing_id").ToString
                            '.IngresoNro = sqlDr("int_ing_nro").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function Listar2(ByVal Codigo As Integer) As Entity.Registro.InternoAlias

            Dim ent As New Entity.Registro.InternoAlias
            Dim entCol As New Entity.Registro.InternoAliasCol
            ent.Codigo = Codigo
            entCol = Listar2(ent)
            If entCol.Count = 0 Then Return Nothing

            Return entCol.InternoAlias(0)
        End Function

        Public Function Listar(ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal Nombres As String _
        ) As Entity.Registro.InternoAliasCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoAlias.Listar(sqlCon, "lst", "lst_mant", Codigo, _
            InternoID, _
            Nombres _
            )
            Try
                objEntCol = New Entity.Registro.InternoAliasCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoAlias
                        With objEnt
                            .Codigo = sqlDr("int_ali_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Nombres = sqlDr("int_ali_nom").ToString
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

        Public Function Listar2(objEntAlias As Entity.Registro.InternoAlias) As Entity.Registro.InternoAliasCol
            ''/*Lista Alias segun el numero de ingreso*/
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoAlias.Listar(sqlCon, "lst", "lst_mant2", objEntAlias)
            Try
                objEntCol = New Entity.Registro.InternoAliasCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoAlias
                        With objEnt
                            .Codigo = sqlDr("int_ali_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Nombres = sqlDr("int_ali_nom").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
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

        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.InternoAlias
            Dim ent As New Entity.Registro.InternoAlias
            ent.Codigo = Codigo
            Return Listar_LM(ent).Entity(0)
        End Function

        Public Function Listar_LM(objEntAlias As Entity.Registro.InternoAlias) As Entity.EntityCol(Of Entity.Registro.InternoAlias)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoAlias.Listar_LM(sqlCon, "lst", "lst_mant_LM", objEntAlias)
            Dim objEntCol_ As New Entity.EntityCol(Of Entity.Registro.InternoAlias)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoAlias
                        With objEnt
                            .Codigo = sqlDr("int_ali_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Nombres = sqlDr("int_ali_nom").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .RegionID = sqlDr("_RegId").ToString
                        End With
                        objEntCol_.Add(objEnt)
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
            Return objEntCol_
        End Function

        Public Function Listar_Grilla_LM(objEntAlias As Entity.Registro.InternoAlias, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.EntityCol(Of Entity.Registro.InternoAlias)
            Dim opc As String = ""
            opc = "lst_grilla_LM"

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoAlias.Listar_LM(sqlCon, "lst", opc, objEntAlias)
            Dim objEntCol_ As New Entity.EntityCol(Of Entity.Registro.InternoAlias)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoAlias
                        With objEnt
                            .Codigo = sqlDr("int_ali_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Nombres = sqlDr("int_ali_nom").ToString

                            .IngresoNro = sqlDr("ing_inpe_nro").ToString
                            .IngresoID = sqlDr("fk_ing_inp_id").ToString

                            .IngresoNroInpe = sqlDr("ing_inpe_nro").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                        End With
                        objEntCol_.Add(objEnt)
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
            Return objEntCol_
        End Function
#End Region
#Region "Validar"
        Private Function ValidarNombre(ByVal InternoID As Integer, ByVal NombreAlias As String) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = -1

            intValue = Data.Registro.InternoAlias.ListarOutput("lst", "lst_validar", -1, InternoID, NombreAlias)

            If intValue > 0 Then
                blnValue = False
            End If

            Return blnValue
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal Nombres As String, IDRegion As Integer, IDPenal As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                If ValidarNombre(InternoID, Nombres) = False Then
                    intValue = -1
                    MsgBox("El Nombre de alias ya existe", 48, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)

                    Return intValue
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoAlias.Grabar(strAccion, strOpcion, Codigo, _
            InternoID, _
            Nombres, IDRegion, IDPenal, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function

        Public Function Grabar(EntAlias As Entity.Registro.InternoAlias) As Integer

            'version nueva 
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If EntAlias.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_v5"

                If ValidarNombre(EntAlias.InternoID, EntAlias.Nombres) = False Then
                    intValue = -1
                    MsgBox("El Nombre de alias ya existe", 48, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)

                    Return intValue
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2"
            End If

            intValue = Data.Registro.InternoAlias.Grabar(strAccion, strOpcion, EntAlias)


            Return intValue
        End Function

        Public Function Grabar_LM(EntAlias As Entity.Registro.InternoAlias) As Integer

            'version nueva 
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If EntAlias.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"

                If ValidarNombre(EntAlias.InternoID, EntAlias.Nombres) = False Then
                    intValue = -1
                    MsgBox("El Nombre de alias ya existe", 48, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)

                    Return intValue
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            intValue = Data.Registro.InternoAlias.Grabar_LM(strAccion, strOpcion, EntAlias)


            Return intValue
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.InternoAlias.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)
            Return intValue
        End Function
#End Region
    End Class
End Namespace
'sfd