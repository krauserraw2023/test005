Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class Familiar
        Private objEnt As Entity.Registro.Familiar = Nothing
        Private objEntCol As Entity.Registro.FamiliarCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Familiar

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Familiar.Listar(sqlCon, "lst", "lst_mant", Codigo, -1, -1, "", "", "", False)
            objEnt = New Entity.Registro.Familiar
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_fam_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FamiliarTipoID = sqlDr("int_fam_tip_id").ToString
                            .ApellidoPaterno = sqlDr("int_fam_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_fam_ape_mat").ToString
                            .Nombres = sqlDr("int_fam_nom").ToString
                            .Sexo = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fam_fec_nac").ToString
                            .Vive = sqlDr("int_fam_viv").ToString
                            .HijoReclucido = sqlDr("int_fam_hij_rec").ToString()
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
        ByVal FamiliarTipoID As Integer, _
        ByVal ApellidoPaterno As String, _
        ByVal ApellidoMaterno As String, _
        ByVal Nombres As String, _
        ByVal Vive As Boolean _
        ) As Entity.Registro.FamiliarCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Familiar.Listar(sqlCon, "lst", "lst_mant", Codigo, _
            InternoID, _
            FamiliarTipoID, _
            ApellidoPaterno, _
            ApellidoMaterno, _
            Nombres, _
            Vive _
            )
            Try
                objEntCol = New Entity.Registro.FamiliarCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Familiar
                        With objEnt
                            .Codigo = sqlDr("int_fam_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FamiliarTipoID = sqlDr("int_fam_tip_id").ToString
                            .FamiliarTipoNombre = sqlDr("int_fam_tip_nom").ToString
                            .ApellidoPaterno = sqlDr("int_fam_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_fam_ape_mat").ToString
                            .Nombres = sqlDr("int_fam_nom").ToString
                            .FechaNacimiento = sqlDr("int_fam_fec_nac").ToString
                            .Vive = sqlDr("int_fam_viv").ToString
                            .HijoReclucido = sqlDr("int_fam_hij_rec").ToString
                            '.IngresoID = sqlDr("int_ing_id").ToString
                            '.IngresoNro = sqlDr("int_ing_nro").ToString
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
       
        Public Function Listar(objEntFam As Entity.Registro.Familiar) As Entity.Registro.FamiliarCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Familiar.Listar(sqlCon, "lst", "lst_mant2", objEntFam)
            Try
                objEntCol = New Entity.Registro.FamiliarCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Familiar
                        With objEnt
                            .Codigo = sqlDr("int_fam_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FamiliarTipoID = sqlDr("int_fam_tip_id").ToString
                            .FamiliarTipoNombre = sqlDr("int_fam_tip_nom").ToString
                            .ApellidoPaterno = sqlDr("int_fam_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_fam_ape_mat").ToString
                            .Nombres = sqlDr("int_fam_nom").ToString
                            .FechaNacimiento = sqlDr("int_fam_fec_nac").ToString
                            .Vive = sqlDr("int_fam_viv").ToString
                            .HijoReclucido = sqlDr("int_fam_hij_rec").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
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
        Public Function Listar2(entFam As Entity.Registro.Familiar) As Entity.Registro.Familiar
            Dim tmpCol As New Entity.Registro.FamiliarCol
            tmpCol = Listar(entFam)
            If tmpCol.Count = 0 Then Return Nothing
            Return tmpCol.Familiar(0)
            'Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            'Dim sqlDr As SqlDataReader = Data.Registro.Familiar.Listar(sqlCon, "lst", "lst_mant2", entFam)
            'objEnt = New Entity.Registro.Familiar
            'Try
            '    If sqlDr.HasRows Then
            '        While sqlDr.Read
            '            With objEnt
            '                .Codigo = sqlDr("int_fam_id").ToString
            '                .InternoID = sqlDr("int_id").ToString
            '                .IngresoID = sqlDr("int_ing_id").ToString
            '                .FamiliarTipoID = sqlDr("int_fam_tip_id").ToString
            '                .ApellidoPaterno = sqlDr("int_fam_ape_pat").ToString
            '                .ApellidoMaterno = sqlDr("int_fam_ape_mat").ToString
            '                .Nombres = sqlDr("int_fam_nom").ToString
            '                .Sexo = sqlDr("sex_id").ToString
            '                .FechaNacimiento = sqlDr("int_fam_fec_nac").ToString
            '                .Vive = sqlDr("int_fam_viv").ToString
            '                .HijoReclucido = sqlDr("int_fam_hij_rec").ToString()
            '                .IngresoNro = sqlDr("int_ing_nro").ToString
            '            End With
            '        End While
            '    End If
            'Catch ex As Exception
            '    Throw New Exception(ex.ToString)
            'Finally
            '    sqlDr.Dispose()
            '    sqlDr.Close()
            '    sqlDr = Nothing
            '    sqlCon.Dispose()
            '    sqlCon.Close()
            '    sqlCon = Nothing
            'End Try

        End Function

        '17/05/2017 - 4:02 pm
        Public Function Listar_grilla_LM(objEntFam As Entity.Registro.Familiar, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia, ByRef outSms As String) As Entity.Registro.FamiliarCol
            Dim opc As String = ""
            opc = "lst_grilla_lm"

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Familiar.Listar_LM(sqlCon, "lst", opc, objEntFam)
            Dim objEntCol_ As New Entity.Registro.FamiliarCol
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Familiar
                        With objEnt
                            .Codigo = sqlDr("int_fam_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FamiliarTipoID = sqlDr("int_fam_tip_id").ToString
                            .FamiliarTipoNombre = sqlDr("int_fam_tip_nom").ToString
                            .ApellidoPaterno = sqlDr("int_fam_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_fam_ape_mat").ToString
                            .Nombres = sqlDr("int_fam_nom").ToString
                            .FechaNacimiento = sqlDr("int_fam_fec_nac").ToString
                            .Vive = sqlDr("int_fam_viv").ToString
                            .HijoReclucido = sqlDr("int_fam_hij_rec").ToString
                            .Sexo = sqlDr("sex_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("c_num_ing").ToString
                            .IngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                            .IngresoNroInpe = sqlDr("ing_inpe_nro").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .PenalID = sqlDr("_PenId").ToString
                        End With
                        objEntCol_.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                outSms = ex.Message
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

        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.Familiar
            Dim tmpCol As New Entity.Registro.FamiliarCol
            Dim entFam As New Entity.Registro.Familiar
            entFam.Codigo = Codigo
            tmpCol = Listar_LM(entFam, "")
            If tmpCol.Count = 0 Then Return Nothing
            Return tmpCol.Familiar(0)
        End Function
        Public Function Listar_LM(objEntFam As Entity.Registro.Familiar, ByRef outSms As String) As Entity.Registro.FamiliarCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Familiar.Listar_LM(sqlCon, "lst", "lst_mant_lm", objEntFam)
            Dim objEntCol_ As New Entity.Registro.FamiliarCol
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Familiar
                        With objEnt
                            .Codigo = sqlDr("int_fam_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FamiliarTipoID = sqlDr("int_fam_tip_id").ToString
                            .FamiliarTipoNombre = sqlDr("int_fam_tip_nom").ToString
                            .ApellidoPaterno = sqlDr("int_fam_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_fam_ape_mat").ToString
                            .Nombres = sqlDr("int_fam_nom").ToString
                            .FechaNacimiento = sqlDr("int_fam_fec_nac").ToString
                            .Vive = sqlDr("int_fam_viv").ToString
                            .HijoReclucido = sqlDr("int_fam_hij_rec").ToString
                            '.IngresoID = sqlDr("int_ing_id").ToString
                            .Sexo = sqlDr("sex_id").ToString
                            .IngresoNro = sqlDr("c_num_ing").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                        End With
                        objEntCol_.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                outSms = ex.Message
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

        'Public Function ListarFamilia(ByVal InternoID As Integer, ByVal FechaInicio As Long) As Entity.Registro.FamiliarCol
        '    'J.E.U 22/10/2015
        '    'Es usado por la opcion antigua del padin
        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

        '    Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_familia", -1, _
        '    -1, -1, InternoID, -1, -1, -1, FechaInicio, 0, 0)

        '    Try
        '        objEntCol = New Entity.Registro.FamiliarCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Registro.Familiar

        '                With objEnt
        '                    .Codigo = sqlDr("int_fam_id").ToString
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .FamiliarTipoID = sqlDr("int_fam_tip_id").ToString
        '                    '.FamiliarTipoNombre = sqlDr("int_fam_tip_nom").ToString
        '                    .ApellidoPaterno = sqlDr("int_fam_ape_pat").ToString
        '                    .ApellidoMaterno = sqlDr("int_fam_ape_mat").ToString
        '                    .Nombres = sqlDr("int_fam_nom").ToString
        '                    .Sexo = sqlDr("sex_id").ToString
        '                    .SexoNombre = sqlDr("sex_nom").ToString
        '                    .FechaNacimiento = sqlDr("int_fam_fec_nac").ToString
        '                    .Vive = sqlDr("int_fam_viv").ToString
        '                    .HijoReclucido = sqlDr("int_fam_hij_rec").ToString
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
#Region "Validar"
        Private Function Validar(ByVal FamiliaID As Integer, ByVal InternoID As Integer, _
        ByVal TipoFamilia As Integer) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = -1

            intValue = Data.Registro.Familiar.ListarOutput("lst", "validar_familia", FamiliaID, _
            InternoID, TipoFamilia, "", "", "", False)

            If intValue > 0 Then
                MsgBox("El tipo de familia que esta ingresando ya esta registrado", 48, _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                blnValue = False
                Return blnValue
            End If

            Return blnValue
        End Function

#End Region
#Region "Grabar"
        
        Public Function Grabar(EntFam As Entity.Registro.Familiar) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If EntFam.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            If Validar(EntFam.Codigo, EntFam.InternoID, EntFam.FamiliarTipoID) = False Then
                intValue = -1
                Return intValue
            End If
            EntFam.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Familiar.Grabar(strAccion, strOpcion, EntFam)

            Return intValue

        End Function
        Public Function Grabar2(EntFam As Entity.Registro.Familiar) As Integer

            'version nueva del pope
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If EntFam.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_v5"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2"
            End If

            EntFam.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Familiar.Grabar2(strAccion, strOpcion, EntFam)

            Return intValue

        End Function

        '17/05/2017 se agrego SedeRowId
        Public Function Grabar_LM(EntFam As Entity.Registro.Familiar) As Integer

            'version nueva del pope
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If EntFam.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            EntFam.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Familiar.Grabar_LM(strAccion, strOpcion, EntFam)

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
            intValue = Data.Registro.Familiar.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)
            Return intValue
        End Function
        Public Function Eliminar2(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_v5"
            intValue = Data.Registro.Familiar.Eliminar(strAccion, strOpcion, Codigo,
            Legolas.Configuration.Usuario.Codigo)
            Return intValue
        End Function
#End Region
    End Class
End Namespace