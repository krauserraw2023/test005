Imports System.Data
Imports System.Data.SqlClient
Imports Bussines.Globall.UtilAccesoBD
Namespace Registro
    Public Class Ingreso
        Private objEnt As Entity.Registro.Ingreso = Nothing
        Private objEntCol As Entity.Registro.IngresoCol = Nothing

#Region "Validar"
        Private Function Validar(ByVal InternoID As Integer, ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0

            intValue = Data.Registro.Ingreso.ListarOutput("lst", "validar_ingreso", -1, InternoID, RegionID, PenalID, _
            -1, 0, -1, -1, "", 0, -1, 0, "")

            If intValue > 0 Then
                MsgBox("Para registrar un nuevo ingreso, el anterior ingreso debe contar con los datos de libertad", _
                48, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                blnValue = False
                Return blnValue
            End If

            Return blnValue
        End Function
        Private Function ValidarNumeroIngreso(ByVal InternoID As Integer, ByVal NumeroIngreso As Integer, _
        ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0

            intValue = Data.Registro.Ingreso.ListarOutput("lst", "validar_numero_ingreso", -1, _
            InternoID, RegionID, PenalID, -1, 0, NumeroIngreso, -1, "", 0, -1, 0, "")

            If intValue > 0 Then
                MsgBox("El numero de ingreso ya existe, cambie los datos", _
                48, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                blnValue = False
                Return blnValue
            End If
            Return blnValue

        End Function
        'Public Function ValidarNumeroIngreso(EntIng As Entity.Registro.Ingreso) As Boolean

        '    Dim blnValue As Boolean = True
        '    Dim intValue As Integer = 0
        '    Dim accion As String = "lst"
        '    Dim opcion As String = ""
        '    If EntIng.Codigo < 1 Then
        '        opcion = "validar_numero_ingreso"
        '    Else
        '        opcion = "validar_numero_ingreso_upd"
        '    End If

        '    intValue = Data.Registro.Ingreso.ListarOutput(accion, opcion, EntIng)

        '    If intValue > 0 Then
        '        MsgBox("El numero de ingreso ya existe, cambie los datos", _
        '        48, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
        '        blnValue = False
        '        Return blnValue
        '    End If
        '    Return blnValue
        'End Function
        Public Function ValidarNumeroIngresoAbierto(ByVal InternoID As Integer, _
        ByVal RegionID As Integer, ByVal PenalID As Integer) As Integer

            'version 4.5 y version 5
            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0

            intValue = Data.Registro.Ingreso.ListarOutput("lst", "validar_ingreso_Abierto", -1, InternoID, RegionID, PenalID, _
            -1, 0, -1, -1, "", 0, -1, 0, "")

            Return intValue

        End Function

#End Region
#Region "Funcion"
        Public Function ListarUltimoIngreso(ByVal InternoId As Integer) As Entity.Registro.Ingreso
            Dim tmpEntIng As Entity.Registro.Ingreso = Nothing
            Dim list As Entity.Registro.IngresoCol

            'VERSION 4.5 Y VERSION 5
            list = ListarNroIngreso(InternoId, -1)

            Dim intNum As Integer = 0

            For Each obj As Entity.Registro.Ingreso In list
                If obj.IngresoNro > intNum Then
                    intNum = obj.IngresoNro
                    tmpEntIng = obj
                End If
            Next
            Return tmpEntIng
        End Function

#End Region
#Region "Listar"

        Public Function Listar(ByVal Codigo As Integer, Optional InternoId As Integer = -1) As Entity.Registro.Ingreso

            'VERSION 4.5 Y VERSION 5
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar(sqlCon, "lst", "lst_mant", Codigo, InternoId, -1, -1, -1, 0, -1, -1, "", 0, -1, 0, "")
            Dim objEnt = New Entity.Registro.Ingreso
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .FechaISP = sqlDr("int_ing_fec_isp").ToString
                            .DocumentoIngreso = sqlDr("int_ing_doc").ToString
                            .DocumentoFechaRecepcion = sqlDr("int_ing_doc_fec_rcp").ToString
                            .DocumentoIngresoFecha = sqlDr("int_ing_doc_fec").ToString
                            .MotivoIngresoID = sqlDr("ing_mot_id").ToString
                            .FechaIngreso = sqlDr("int_ing_fec").ToString
                            .DocumentoLibertad = sqlDr("tip_lib_doc").ToString
                            .DocumentoLibertadFecha = sqlDr("int_ing_lib_doc_fec").ToString
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .LibertadTipoNombre = sqlDr("tip_lib_nom").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            '.PenalNum = sqlDr("Pen_num").ToString
                            .Observacion = sqlDr("int_ing_obs").ToString
                            .historico = sqlDr("int_ing_hist").ToString
                            .historicoVisible = sqlDr("ing_hist_vis").ToString
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

        Public Function Listar(ByVal Codigo As Integer, _
        ByVal InternoId As Integer, _
        ByVal RegionId As Integer, _
        ByVal PenalId As Integer, _
        ByVal PenalNum As Integer, _
        ByVal IngresoFecha As Long, _
        ByVal IngresoNro As Integer, _
        ByVal MotivoIngresoId As Integer, _
        ByVal IngresoDocumento As String, _
        ByVal IngresoDocumentoFecha As Long, _
        ByVal LibertadTipoId As Integer, _
        ByVal LibertadFecha As Long, _
        ByVal LibertadDocumento As String _
        ) As Entity.Registro.IngresoCol

            'VERSION 4.5 Y VERSION 5

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar(sqlCon, "lst", "lst_mant", Codigo, _
            InternoId, RegionId, PenalId, PenalNum, IngresoFecha, IngresoNro, MotivoIngresoId, _
            IngresoDocumento, IngresoDocumentoFecha, LibertadTipoId, LibertadFecha, LibertadDocumento)

            Try
                objEntCol = New Entity.Registro.IngresoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Ingreso
                        With objEnt

                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString

                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .DocumentoIngreso = sqlDr("int_ing_doc").ToString
                            .DocumentoIngresoFecha = sqlDr("int_ing_doc_fec").ToString
                            .MotivoIngresoID = sqlDr("ing_mot_id").ToString
                            .MotivoIngresoNombre = sqlDr("ing_mot_nom").ToString
                            .FechaISP = sqlDr("int_ing_fec_isp").ToString
                            .FechaIngreso = sqlDr("int_ing_fec").ToString

                            .DocumentoLibertad = sqlDr("tip_lib_doc").ToString
                            .DocumentoLibertadFecha = sqlDr("int_ing_lib_doc_fec").ToString
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .LibertadTipoNombre = sqlDr("tip_lib_nom").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            ''Auditoria
                            .Audit_UsuarioCreacion = sqlDr("_usu_cre_nom").ToString
                            .Audit_UsuarioModificacion = sqlDr("_usu_mod_nom").ToString
                            .Audit_FechaCreacion = sqlDr("_fec_cre").ToString
                            .Audit_FechaModificacion = sqlDr("_fec_mod").ToString

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

        Public Function Listar(entIng As Entity.Registro.Ingreso) As Entity.Registro.IngresoCol

            'VERSION 4.5 Y VERSION 5

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar(sqlCon, "lst", "lst_mant", entIng)

            Try
                objEntCol = New Entity.Registro.IngresoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt = New Entity.Registro.Ingreso
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .RegionNom = sqlDr("reg_nom").ToString
                            .PenalNom = sqlDr("pen_nom").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            Dim val As Integer = .ingresoNro
                            .DocumentoIngreso = sqlDr("int_ing_doc").ToString
                            .DocumentoIngresoFecha = sqlDr("int_ing_doc_fec").ToString
                            .MotivoIngresoID = sqlDr("ing_mot_id").ToString
                            .MotivoIngresoNombre = sqlDr("ing_mot_nom").ToString
                            .FechaISP = sqlDr("int_ing_fec_isp").ToString
                            .FechaIngreso = sqlDr("int_ing_fec").ToString

                            .DocumentoLibertad = sqlDr("tip_lib_doc").ToString
                            .DocumentoLibertadFecha = sqlDr("int_ing_lib_doc_fec").ToString
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .LibertadTipoNombre = sqlDr("tip_lib_nom").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            '.Historico = sqlDr("int_ing_hist").ToString
                            Dim valfec As Long = .FechaLibertad
                            '.Estado = sqlDr("int_ing_est").ToString
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

        Public Function ListarNroIngreso(ByVal InternoId As Integer, PenalID As Integer) As Entity.Registro.IngresoCol

            'version 4.5 y version 5
            Dim entIng As New Entity.Registro.Ingreso
            entIng.InternoID = InternoId
            entIng.PenalID = PenalID
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar(sqlCon, "lst", "lst_nro_ingresos", entIng)

            Try
                objEntCol = New Entity.Registro.IngresoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt = New Entity.Registro.Ingreso
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
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

        Public Function ListarResumen(ByVal InternoID As Integer) As Entity.Registro.Ingreso

            'VERSION 4.5
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar(sqlCon, "lst", "lst_ingreso_resumen", _
                                                                      -1, InternoID, -1, -1, -1, 0, -1, -1, "", 0, -1, 0, "")

            Dim objEnt = New Entity.Registro.Ingreso
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .FechaIngreso = sqlDr("int_ing_fec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur").ToString
                            .LibertadTipoNombre = sqlDr("tip_lib_nom").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString

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

        Public Function ListarResumen(objEnti As Entity.Registro.Ingreso) As Entity.Registro.Ingreso

            'Version 5, usa el formulario busqueda nombres asociados 03
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar(sqlCon, "lst", "lst_ingreso_resumen_v5", objEnti)

            Dim objEnt As New Entity.Registro.Ingreso
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .FechaIngreso = sqlDr("int_ing_fec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur").ToString
                            .LibertadTipoNombre = sqlDr("tip_lib_nom").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            .MovimientoNombre = sqlDr("NombreMov").ToString
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

        'Public Function ListarInternoFechaIngreso(ByVal objFiltro As Entity.Registro.Ingreso) As Entity.Registro.IngresoCol

        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

        '    Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar(sqlCon, "lst", "lst_interno_fecha_ingreso", objFiltro)

        '    Try
        '        objEntCol = New Entity.Registro.IngresoCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                Dim objEnt = New Entity.Registro.Ingreso
        '                With objEnt
        '                    .InternoID = sqlDr("int_id").ToString
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
#Region "Carceleta"
        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.Ingreso
            Dim lst As New Entity.EntityCol(Of Entity.Registro.Ingreso)
            Dim entIng As New Entity.Registro.Ingreso
            entIng.Codigo = Codigo
            lst = Listar_LM(entIng)

            If lst Is Nothing Then
                Return Nothing
            End If

            If lst.Count = 0 Then
                Return Nothing
            End If

            entIng = lst.Item(0)
            Return entIng
        End Function
        Public Function Listar_LM(entIng As Entity.Registro.Ingreso) As Entity.EntityCol(Of Entity.Registro.Ingreso)

            'VERSION CARCELETA, PLM
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            'Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar_LM(sqlCon, "lst", "lst_lima_metropolitana", entIng)
            Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar_LM(sqlCon, "lst", "lst_mant_lm", entIng)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Ingreso)
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Registro.Ingreso
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .IDMovimientoTipo = sqlDr("fk_mov_tip_id").ToString
                            .MotivoIngresoID = sqlDr("ing_mot_id").ToString
                            .FechaISP = sqlDr("int_ing_fec_isp").ToString
                            .FechaIngreso = sqlDr("int_ing_fec").ToString
                            .Observacion = sqlDr("int_ing_obs").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            .Estado = sqlDr("int_ing_est").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString

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

        Public Function listarIngresos_LM(ByVal intIDInterno As Integer, Optional blnVerIngresoCero As Boolean = True) As Entity.Registro.IngresoCol

            'jmr, 07.02.2019, se exlucye el ingreso cero
            Dim objEntIngFiltro As New Entity.Registro.Ingreso
            objEntIngFiltro.InternoID = intIDInterno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Ingreso.Listar_LM(sqlCon, "lst", "lst_nro_ingresos_lm", objEntIngFiltro)

            Try
                objEntCol = New Entity.Registro.IngresoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Registro.Ingreso
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoInpeId = Isnulll(sqlDr("fk_ing_inp_id").ToString, -1)
                            .IngresoNro = Isnulll(sqlDr("int_ing_nro").ToString, 0)
                            .IDMovimientoTipo = Isnulll(sqlDr("fk_mov_tip_id").ToString, -1)
                            .MotivoIngresoID = Isnulll(sqlDr("ing_mot_id").ToString, -1)
                            .FechaISP = Isnulll(sqlDr("int_ing_fec_isp").ToString, 0)
                            .FechaIngreso = Isnulll(sqlDr("int_ing_fec").ToString, 0)
                            .Observacion = Isnulll(sqlDr("int_ing_obs").ToString, "")
                            .Audit_IDUsuarioCreacion = Isnulll(sqlDr("_usu_cre").ToString, -1)
                            .Audit_FechaCreacion = Isnulll(sqlDr("_fec_cre").ToString, 0)
                            .Audit_IDUsuarioModificacion = Isnulll(sqlDr("_usu_mod").ToString, -1)
                            .Audit_FechaModificacion = Isnulll(sqlDr("_fec_mod").ToString, 0)
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .Estado = Isnulll(sqlDr("int_ing_est").ToString, -1)
                        End With

                        If blnVerIngresoCero = False Then
                            If objEnt.IngresoNro <> 0 Then
                                objEntCol.Add(objEnt)
                            End If
                        Else
                            objEntCol.Add(objEnt)
                        End If

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

        Public Function ListarUltimoIngreso_LM(ByVal InternoId As Integer) As Entity.Registro.Ingreso
            Dim tmpEntIng As Entity.Registro.Ingreso = Nothing
            Dim list As Entity.Registro.IngresoCol

            list = listarIngresos_LM(InternoId)

            Dim intNum As Integer = 0

            For Each obj As Entity.Registro.Ingreso In list
                If obj.IngresoNro > intNum Then
                    intNum = obj.IngresoNro
                    tmpEntIng = obj
                End If
            Next
            Return tmpEntIng
        End Function
#End Region

#Region "Grabar"

        Public Function Grabar(ByVal objEnt As Entity.Registro.Ingreso) As Integer

            'VERSION 4.5
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                If ValidarNumeroIngreso(objEnt.InternoID, objEnt.IngresoNro, objEnt.RegionID, objEnt.PenalID) = False Then
                    intValue = -1
                    Return intValue
                End If

                If Validar(objEnt.InternoID, objEnt.RegionID, objEnt.PenalID) = False Then
                    intValue = -1
                    Return intValue
                End If

            Else

                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Ingreso.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function Grabar2(ByVal objEnt As Entity.Registro.Ingreso) As Integer

            'VERSION 5
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_v2"

                If ValidarNumeroIngreso(objEnt.InternoID, objEnt.IngresoNro, objEnt.RegionID, objEnt.PenalID) = False Then
                    intValue = -1
                    Return intValue
                End If

                If Validar(objEnt.InternoID, objEnt.RegionID, objEnt.PenalID) = False Then
                    intValue = -1
                    Return intValue
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_v2"
            End If

            intValue = Data.Registro.Ingreso.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function Grabar_LM(ByVal objEnt As Entity.Registro.Ingreso, ByRef outSMS As String) As Integer

            'VERSION CARCELETA Y PLM
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"

                Dim entIng As New Entity.Registro.Ingreso
                Dim entIngcol As Entity.EntityCol(Of Entity.Registro.Ingreso)
                entIng.RegionID = objEnt.RegionID
                entIng.PenalID = objEnt.PenalID
                entIng.IngresoInpeId = objEnt.IngresoInpeId
                entIng.IngresoNro = objEnt.IngresoNro

                entIngcol = Listar_LM(entIng)

                If entIngcol.Count > 0 Then
                    outSMS = "El numero de ingreso ya existe, cambie por favor"
                    Return -1
                End If

                If Validar(objEnt.InternoID, objEnt.RegionID, objEnt.PenalID) = False Then
                    intValue = -1
                    Return intValue
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            intValue = Data.Registro.Ingreso.Grabar_LM(strAccion, strOpcion, objEnt, outSMS)

            Return intValue
        End Function

        Public Function GrabarRevocarLibertad(ByVal objEnt As Entity.Registro.Ingreso) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_revocatoria"

            intValue = Data.Registro.Ingreso.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

#End Region

#Region "Eliminar"

        Public Function Eliminar(entIngreso As Entity.Registro.Ingreso) As Integer
            'VERSION 4.5
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            entIngreso.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Ingreso.Eliminar(strAccion, strOpcion, entIngreso)
            Return intValue
        End Function

        Public Function Eliminar2(entIngreso As Entity.Registro.Ingreso) As Integer
            'VERSION 5
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_v2"
            entIngreso.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Ingreso.Eliminar(strAccion, strOpcion, entIngreso)
            Return intValue
        End Function

        Public Function Eliminar_LM(entIngreso As Entity.Registro.Ingreso) As Integer

            'VERSION, CAMBIAR DE NOMBRE
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_LM"
            entIngreso.Audit_UsuarioCreacion = Legolas.Configuration.Usuario.Codigo
            intValue = Data.Registro.Ingreso.Eliminar(strAccion, strOpcion, entIngreso)
            Return intValue
        End Function
#End Region
    End Class
End Namespace