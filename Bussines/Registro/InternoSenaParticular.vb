Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoSenaParticular
        Private objEnt As Entity.Registro.InternosenaParticular = Nothing
        Private objEntCol As Entity.Registro.InternosenaParticularCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.InternosenaParticular

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoSenaParticular.Listar(sqlCon, "lst", "lst_mant", Codigo, -1, -1, -1, -1, -1, -1)
            objEnt = New Entity.Registro.InternosenaParticular
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_sen_par_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .NaturalezaID = sqlDr("sen_part_nat_id").ToString
                            .FormaID = sqlDr("sen_part_for_id").ToString
                            .UbicacionID = sqlDr("sen_part_ubi_id").ToString
                            .PosicionID = sqlDr("sen_part_pos_id").ToString
                            .Cantidad = sqlDr("int_sen_par_can").ToString
                            .Obs = sqlDr("int_sen_par_obs").ToString

                            Try
                                .InternoIngresoId = sqlDr("int_ing_id").ToString

                            Catch ex As Exception

                            End Try
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
        Public Function Listar(ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal NaturalezaID As Integer, _
        ByVal FormaID As Integer, _
        ByVal UbicacionID As Integer, _
        ByVal PosicionID As Integer, _
        ByVal Cantidad As Integer _
        ) As Entity.Registro.InternosenaParticularCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Internosenaparticular.Listar(sqlCon, "lst", "lst_grilla", _
            Codigo, _
            InternoID, _
            NaturalezaID, _
            FormaID, _
            UbicacionID, _
            PosicionID, _
            Cantidad _
            )
            Try
                objEntCol = New Entity.Registro.InternosenaParticularCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternosenaParticular
                        With objEnt
                            .Codigo = sqlDr("int_sen_par_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .NaturalezaID = sqlDr("sen_part_nat_id").ToString
                            .NaturalezaNombre = sqlDr("sen_part_nat_nom").ToString
                            .FormaID = sqlDr("sen_part_for_id").ToString
                            .FormaNombre = sqlDr("sen_part_for_nom").ToString
                            .UbicacionID = sqlDr("sen_part_ubi_id").ToString
                            .UbicacionNombre = sqlDr("sen_part_ubi_nom").ToString
                            .PosicionID = sqlDr("sen_part_pos_id").ToString
                            .PosicionNombre = sqlDr("sen_part_pos_nom").ToString
                            .Cantidad = sqlDr("int_sen_par_can").ToString
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
        Public Function Listar(objEntSP As Entity.Registro.InternoSenaParticular) As Entity.Registro.InternoSenaParticularCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoSenaParticular.Listar(sqlCon, "lst", "lst_grilla2", objEntSP)
            Try
                objEntCol = New Entity.Registro.InternoSenaParticularCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoSenaParticular
                        With objEnt
                            .Codigo = sqlDr("int_sen_par_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .NaturalezaID = sqlDr("sen_part_nat_id").ToString
                            .NaturalezaNombre = sqlDr("sen_part_nat_nom").ToString
                            .FormaID = sqlDr("sen_part_for_id").ToString
                            .FormaNombre = sqlDr("sen_part_for_nom").ToString
                            .UbicacionID = sqlDr("sen_part_ubi_id").ToString
                            .UbicacionNombre = sqlDr("sen_part_ubi_nom").ToString
                            .PosicionID = sqlDr("sen_part_pos_id").ToString
                            .PosicionNombre = sqlDr("sen_part_pos_nom").ToString
                            .Cantidad = sqlDr("int_sen_par_can").ToString
                            .NumIngreso = IIf(Val(sqlDr("int_ing_nro").ToString) = 0, "", sqlDr("int_ing_nro").ToString)
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

        Public Function Listar_LM(codigo As Integer) As Entity.Registro.InternoSenaParticular
            If codigo = -1 Then Return Nothing

            Dim ent As New Entity.Registro.InternoSenaParticular
            ent.Codigo = codigo
            Try
                ent = Listar_LM(ent).Entity(0)
            Catch ex As Exception
                ent = Nothing
            End Try

            Return ent
        End Function
        'se agrego columna sedRowId,IngresoInpeId
        Public Function Listar_LM(objEntSP As Entity.Registro.InternoSenaParticular) As Entity.EntityCol(Of Entity.Registro.InternoSenaParticular)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoSenaParticular.Listar_LM(sqlCon, "lst", "lst_mant_LM", objEntSP)
            Dim objEntCol_ As New Entity.EntityCol(Of Entity.Registro.InternoSenaParticular)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoSenaParticular
                        With objEnt
                            .Codigo = sqlDr("int_sen_par_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .NaturalezaID = sqlDr("sen_part_nat_id").ToString
                            .NaturalezaNombre = sqlDr("sen_part_nat_nom").ToString
                            .FormaID = sqlDr("sen_part_for_id").ToString
                            .FormaNombre = sqlDr("sen_part_for_nom").ToString
                            .UbicacionID = sqlDr("sen_part_ubi_id").ToString
                            .UbicacionNombre = sqlDr("sen_part_ubi_nom").ToString
                            .PosicionID = sqlDr("sen_part_pos_id").ToString
                            .PosicionNombre = sqlDr("sen_part_pos_nom").ToString
                            .Cantidad = sqlDr("int_sen_par_can").ToString
                            .NumIngreso = IIf(Val(sqlDr("int_ing_nro").ToString) = 0, "", sqlDr("int_ing_nro").ToString)
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .Obs = sqlDr("int_sen_par_obs").ToString
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

        Public Function Listar_Grilla_LM(objEntSP As Entity.Registro.InternoSenaParticular, tipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.EntityCol(Of Entity.Registro.InternoSenaParticular)
            Dim opc As String = ""
            opc = "lst_grilla_LM"
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoSenaParticular.Listar_LM(sqlCon, "lst", opc, objEntSP)
            Dim objEntCol_ As New Entity.EntityCol(Of Entity.Registro.InternoSenaParticular)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoSenaParticular
                        With objEnt
                            .Codigo = sqlDr("int_sen_par_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .NaturalezaID = sqlDr("sen_part_nat_id").ToString
                            .NaturalezaNombre = sqlDr("sen_part_nat_nom").ToString
                            .FormaID = sqlDr("sen_part_for_id").ToString
                            .FormaNombre = sqlDr("sen_part_for_nom").ToString
                            .UbicacionID = sqlDr("sen_part_ubi_id").ToString
                            .UbicacionNombre = sqlDr("sen_part_ubi_nom").ToString
                            .PosicionID = sqlDr("sen_part_pos_id").ToString
                            .PosicionNombre = sqlDr("sen_part_pos_nom").ToString
                            .Cantidad = sqlDr("int_sen_par_can").ToString
                            .NumIngreso = sqlDr("int_ing_nro")
                            .IngresoNroInpe = sqlDr("ing_pen_nro")
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .PenalId = sqlDr("_penid").ToString
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
#Region "Grabar"
        '
        Public Function Grabar(entSenPart As Entity.Registro.InternoSenaParticular) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If entSenPart.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoSenaParticular.Grabar(strAccion, strOpcion, entSenPart)

            Return intValue
        End Function

        Public Function Grabar_LM(entSenPart As Entity.Registro.InternoSenaParticular) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If entSenPart.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            intValue = Data.Registro.InternoSenaParticular.Grabar_LM(strAccion, strOpcion, entSenPart)

            Return intValue
        End Function

        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal NaturalezaID As Integer, _
        ByVal FormaID As Integer, _
        ByVal UbicacionID As Integer, _
        ByVal PosicionID As Integer, _
        ByVal Cantidad As Integer, ByVal Obs As String, IDRegion As Integer, IDPenal As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoSenaParticular.Grabar(strAccion, strOpcion, Codigo, _
            InternoID, _
            NaturalezaID, _
            FormaID, _
            UbicacionID, _
            PosicionID, _
            Cantidad, Obs, IDRegion, IDPenal, _
            Legolas.Configuration.Usuario.Codigo)

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

            intValue = Data.Registro.InternoSenaParticular.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
#End Region
    End Class
End Namespace