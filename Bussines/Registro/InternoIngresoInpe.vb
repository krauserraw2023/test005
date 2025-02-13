Imports System.Data
Imports System.Data.SqlClient
Imports Bussines.Globall.UtilAccesoBD
Namespace Registro
    Public Class IngresoInpe
        Private objEntCol As Entity.EntityCol(Of Entity.Registro.IngresoInpe) = Nothing
#Region "Validar"
        Public Function ValidarNumeroIngresoAbierto(ByVal InternoID As Integer,
        ByVal intIDRegion As Short, ByVal intIDPenal As Short) As Integer

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0

            Dim objEntFiltro As New Entity.Registro.IngresoInpe
            With objEntFiltro
                .InternoID = InternoID
                .RegionID = intIDRegion
                .PenalID = intIDPenal
            End With

            intValue = Data.Registro.IngresoInpe.ListarOutput("lst", "validar_ingreso_Abierto", objEntFiltro)

            Return intValue

        End Function
        Public Function ValidarCantidadIngresosRegistradosXORL(ByVal InternoID As Integer) As Integer

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0

            Dim objEntFiltro As New Entity.Registro.IngresoInpe
            With objEntFiltro
                .InternoID = InternoID
            End With

            intValue = Data.Registro.IngresoInpe.ListarOutput("lst", "lst_count_ingresos_registrado_orl", objEntFiltro)

            Return intValue

        End Function
#End Region
#Region "Combo"
        Public Function ComboPLM(ByVal InternoId As Integer, Optional ByVal RegionLimaID As Integer = -1) As Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            Dim entIng As New Entity.Registro.IngresoInpe
            entIng.InternoID = InternoId
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.IngresoInpe.Listar(sqlCon, "lst", "lst_combo_ingreso", entIng)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Registro.IngresoInpe
                        With objEnt
                            .RegionLimaID = RegionLimaID
                            .Codigo = sqlDr("pk_ing_inp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IDIngreso = Isnulll(sqlDr("int_ing_id").ToString, -1)
                            .IngresoNro = sqlDr("ing_inpe_nro").ToString
                            .PenalNom = sqlDr("pen_nom").ToString
                            .FechaIngInpe = sqlDr("n_fec_ing_inp").ToString
                            .IDTipoMovimiento = sqlDr("fk_mov_tip_id").ToString
                            .TipoMovimientoNombre = sqlDr("mov_tip_nom").ToString
                            .MotivoIngresoID = sqlDr("fk_ing_mot_id").ToString
                            .FechaISP = sqlDr("n_fec_ing_inp").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .EstadoId = sqlDr("int_ing_est").ToString

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
#Region "Listar"

        Public Function Listar(intCodigo As Integer, Optional InternoId As Integer = -1) As Entity.Registro.IngresoInpe

            Dim objEntFiltro As New Entity.Registro.IngresoInpe
            Dim entCol As Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            objEntFiltro.Codigo = intCodigo
            objEntFiltro.InternoID = InternoId

            entCol = Listar_Grilla(objEntFiltro)

            If entCol.Count = 0 Then
                Return Nothing
            End If

            Return entCol.Item(0)

        End Function
        Public Function Listar(obj As Entity.Registro.IngresoInpe) As Entity.Registro.IngresoInpe

            Dim objEntFiltro As New Entity.Registro.IngresoInpe
            Dim entCol As Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            objEntFiltro.Codigo = obj.Codigo
            objEntFiltro.IDTipoMovimiento = obj.IDTipoMovimiento

            entCol = Listar_Grilla(objEntFiltro)

            If entCol.Count = 0 Then
                Return Nothing
            End If

            Return entCol.Item(0)

        End Function
        Public Function Listar_V2(objEntFiltro As Entity.Registro.IngresoInpe) As Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.IngresoInpe.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Registro.IngresoInpe
                        With objEnt

                            .FlagTransferenciaSede = sqlDr("_sed_flg_trf").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .Codigo = sqlDr("pk_ing_inp_id").ToString
                            .InternoID = sqlDr("fk_int_id").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .IngresoNro = sqlDr("c_num_ing").ToString
                            .FechaIngInpe = sqlDr("n_fec_ing_inp").ToString
                            .FechaMovimientoIngreso = sqlDr("n_fec_mov_ing").ToString
                            .IDTipoMovimiento = sqlDr("fk_mov_tip_id").ToString
                            .MotivoIngresoID = sqlDr("fk_ing_mot_id").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .SituacionJuridicaID = sqlDr("fk_sit_jur_id").ToString
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString

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

        Public Function Listar_Grilla(entIng As Entity.Registro.IngresoInpe) As Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.IngresoInpe.Listar(sqlCon, "lst", "lst_grilla", entIng)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Registro.IngresoInpe
                        With objEnt
                            .Codigo = sqlDr("pk_ing_inp_id").ToString
                            .InternoID = Isnulll(sqlDr("fk_int_id").ToString, -1)
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
                            .IDTipoMovimiento = sqlDr("fk_mov_tip_id").ToString
                            .TipoMovimientoNombre = sqlDr("mov_tip_nom").ToString
                            .MotivoIngresoID = sqlDr("fk_ing_mot_id").ToString
                            .MotivoIngresoNombre = sqlDr("ing_mot_nom").ToString
                            .FechaISP = sqlDr("n_fec_ing_inp").ToString
                            .FechaIngInpe = sqlDr("n_fec_ing_inp").ToString
                            .FechaMovimientoIngreso = sqlDr("n_fec_mov_ing").ToString   'Fecha Carceleta                         
                            .IngresoNro = sqlDr("c_num_ing").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .Historico = sqlDr("int_ing_hist").ToString
                            .HistoricoVisible = sqlDr("ing_hist_vis").ToString
                            Try
                                .LibertadTipoID = sqlDr("tip_lib_id").ToString
                                .FechaLibertad = sqlDr("tip_lib_fec").ToString
                                .RegistroCreaPenalID = sqlDr("_crea_reg_pen_id").ToString

                                If .RegistroCreaPenalID > 0 Then
                                    .getROrigen = (New General.Penal).Listar_v2(.RegistroCreaPenalID).Nombre
                                Else
                                    .getROrigen = "O.R. Lima"
                                End If
                            Catch ex As Exception

                            End Try
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

        Public Function Listar_Grilla_PLM(objEntFiltro As Entity.Registro.IngresoInpe) As Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.IngresoInpe.Listar(sqlCon, "lst", "lst_grilla_plm", objEntFiltro)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Registro.IngresoInpe
                        With objEnt
                            .Codigo = sqlDr("pk_ing_inp_id").ToString
                            .InternoID = Isnulll(sqlDr("fk_int_id").ToString, -1)
                            .IDIngreso = Isnulll(sqlDr("int_ing_id").ToString, -1)
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
                            .IDTipoMovimiento = sqlDr("fk_mov_tip_id").ToString
                            .TipoMovimientoNombre = sqlDr("mov_tip_nom").ToString
                            .MotivoIngresoID = sqlDr("fk_ing_mot_id").ToString
                            .MotivoIngresoNombre = sqlDr("ing_mot_nom").ToString
                            .FechaISP = sqlDr("n_fec_ing_inp").ToString
                            .FechaIngInpe = sqlDr("n_fec_ing_inp").ToString
                            .FechaMovimientoIngreso = sqlDr("n_fec_mov_ing").ToString
                            .FechaIngresoPenal = Isnulll(sqlDr("fec_ing_pen").ToString, 0)
                            .IngresoNro = sqlDr("c_num_ing").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            Try
                                .RegistroCreaPenalID = sqlDr("_crea_reg_pen_id").ToString
                                If .RegistroCreaPenalID > 0 Then
                                    .getROrigen = (New General.Penal).Listar_v2(.RegistroCreaPenalID).Nombre
                                Else
                                    .getROrigen = "O.R. Lima"
                                End If
                            Catch ex As Exception

                            End Try
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

        Public Function ListarNroIngreso(ByVal InternoId As Integer, Optional ByVal RegionLimaID As Integer = -1) As Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            Dim entIng As New Entity.Registro.IngresoInpe
            entIng.InternoID = InternoId
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.IngresoInpe.Listar(sqlCon, "lst", "lst_nro_ingresos", entIng)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Registro.IngresoInpe
                        With objEnt
                            .RegionLimaID = RegionLimaID
                            .Codigo = sqlDr("pk_ing_inp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoNro = sqlDr("ing_inpe_nro").ToString
                            .PenalNom = sqlDr("pen_nom").ToString
                            .FechaIngInpe = sqlDr("n_fec_ing_inp").ToString
                            .IDTipoMovimiento = sqlDr("fk_mov_tip_id").ToString
                            .TipoMovimientoNombre = sqlDr("mov_tip_nom").ToString
                            .MotivoIngresoID = sqlDr("fk_ing_mot_id").ToString
                            .FechaISP = sqlDr("n_fec_ing_inp").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .Historico = sqlDr("int_ing_hist").ToString
                            .HistoricoFecha = sqlDr("int_ing_hist_fec").ToString
                            Try
                                .LibertadTipoID = sqlDr("tip_lib_id").ToString
                                .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            Catch ex As Exception

                            End Try
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception("dentro de ListarNroIngreso(...) clase InternoIngresoInpe, " & ex.ToString)
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

        Public Function ListarUltimoIngresoInpe(ByVal InternoId As Integer, idPenal As Short) As Entity.Registro.IngresoInpe
            Dim tmpEntIng As Entity.Registro.IngresoInpe = Nothing
            Dim list As Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            list = ListarNroIngreso(InternoId)

            Dim intNum As Integer = 0

            For Each obj As Entity.Registro.IngresoInpe In list

                'los ingresos solo deben ser del mismo penal
                If idPenal > 0 Then
                    If obj.PenalID = idPenal Then
                        If obj.IngresoNro > intNum Then
                            intNum = obj.IngresoNro
                            tmpEntIng = obj
                        End If
                    End If
                Else
                    If obj.IngresoNro > intNum Then
                        intNum = obj.IngresoNro
                        tmpEntIng = obj
                    End If
                End If
            Next
            Return tmpEntIng
        End Function

        Public Function ListarResumen(objEnti As Entity.Registro.IngresoInpe, Optional Condicion As Boolean = False) As Entity.Registro.IngresoInpe

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.IngresoInpe.Listar(sqlCon, "lst", "lst_ingreso_resumen_orl", objEnti)

            Dim objEnt As New Entity.Registro.IngresoInpe
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .FechaMovimientoIngreso = sqlDr("int_ing_fec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur").ToString
                            .LibertadTipoNombre = sqlDr("tip_lib_nom").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            .TipoMovimientoNombre = sqlDr("NombreMov").ToString
                            .PenalNom = sqlDr("pen_cla_nom").ToString
                            .DocumentoClasificID = sqlDr("doc_cla_id").ToString
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
            If Condicion = True Then
                With objEnt
                    .IngresoNro = IIf(.IngresoNro < 1, 0, .IngresoNro)
                    .FechaMovimientoIngreso = .FechaMovimientoIngreso
                    .TipoMovimientoNombre = IIf(.TipoMovimientoNombre = "", "NO REGISTRA", .TipoMovimientoNombre)
                    .FechaLibertad = .FechaLibertad
                    .PenalNom = IIf(.PenalNom = "", "NO REGISTRA", .PenalNom.ToUpper)
                    Select Case .PerfilUsuarioId
                        Case Type.Enumeracion.Usuario.EnumDependencia.Legal,
                            Type.Enumeracion.Usuario.EnumDependencia.Social,
                            Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                            Type.Enumeracion.Usuario.EnumDependencia.SecretariaJuntaClasificacion
                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                        Case Else
                            Select Case .DocumentoClasificID
                                Case -1
                                    .PenalNom = "NO REGISTRA"
                            End Select
                    End Select
                End With
            End If
            Return objEnt
        End Function

        Public Function ListarResumenPLM(objEnti As Entity.Registro.IngresoInpe, Optional Condicion As Boolean = False) As Entity.Registro.IngresoInpe

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.IngresoInpe.Listar(sqlCon, "lst", "lst_ingreso_resumen_plm", objEnti)

            Dim objEnt As New Entity.Registro.IngresoInpe
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .FechaMovimientoIngreso = sqlDr("int_ing_fec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur").ToString
                            .LibertadTipoNombre = sqlDr("tip_lib_nom").ToString
                            .FechaLibertad = sqlDr("tip_lib_fec").ToString
                            .TipoMovimientoNombre = sqlDr("NombreMov").ToString
                            '.PenalNom = sqlDr("pen_cla_nom").ToString
                            '.DocumentoClasificID = sqlDr("doc_cla_id").ToString
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
            If Condicion = True Then
                With objEnt
                    .IngresoNro = IIf(.IngresoNro < 1, 0, .IngresoNro)
                    .FechaMovimientoIngreso = .FechaMovimientoIngreso
                    .TipoMovimientoNombre = IIf(.TipoMovimientoNombre = "", "NO REGISTRA", .TipoMovimientoNombre)
                    .FechaLibertad = .FechaLibertad
                    .PenalNom = IIf(.PenalNom = "", "NO REGISTRA", .PenalNom.ToUpper)
                    Select Case .PerfilUsuarioId
                        Case Type.Enumeracion.Usuario.EnumDependencia.Legal,
                            Type.Enumeracion.Usuario.EnumDependencia.Social,
                            Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                            Type.Enumeracion.Usuario.EnumDependencia.SecretariaJuntaClasificacion
                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                        Case Else
                            Select Case .DocumentoClasificID
                                Case -1
                                    .PenalNom = "NO REGISTRA"
                            End Select
                    End Select
                End With
            End If
            Return objEnt
        End Function

#End Region
#Region "Grabar"

        Public Function Grabar(ByVal objEnt As Entity.Registro.IngresoInpe) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.IngresoInpe.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function GrabarUpd(ByVal objEnt As Entity.Registro.IngresoInpe) As Integer

            'CAMBIAR NOMBRE DE LA FUNCION-JEU
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then

                strAccion = "upd"
                strOpcion = "upd_mant_mov"
            End If

            intValue = Data.Registro.IngresoInpe.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

#End Region

#Region "Eliminar"

        Public Function Eliminar(codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"

            intValue = Data.Registro.IngresoInpe.Eliminar(strAccion, strOpcion, codigo, FlagTransferenciaSede)
            Return intValue
        End Function

        Public Function Eliminar_Carceleta(CodigoIngInpeId As Integer, ByRef outSMS As String) As Integer

            'que no tenga movimiento.
            Dim m As New Entity.Registro.InternoMovimiento

            m.IngresoInpeId = CodigoIngInpeId
            m = (New InternoMovimiento).Listar_LM(m)

            If Not m Is Nothing Then

                If m._PenalID = 35 Then
                    outSMS = "Para completar la operación elimine todos los movimientos relacionados al ingreso que desea eliminar."
                Else
                    outSMS = "El ingreso tiene registro de movimientos relacionados registrados por el penal, para completar la operación coordine con el penal el cual debe eliminar todos los movimientos del interno relacionados al ingreso."
                End If

                Return -1
            End If

            'que no tenga documentos.
            Dim docJud As New Entity.Registro.DocumentoJudicial
            Dim docJudCol As New Entity.Registro.DocumentoJudicialCol

            docJud.IngresoInpeId = CodigoIngInpeId

            docJudCol = (New DocumentoJudicial).ListarDocJud_v2_LM(docJud)

            If docJudCol.Count > 0 Then

                Dim existeMDCarceleta As Boolean = False
                Dim existeOtrosDoc As Boolean = False

                For Each obj As Entity.Registro.DocumentoJudicial In docJudCol
                    If obj.DocumentoTipo = 35 Then
                        existeMDCarceleta = True
                    Else
                        existeOtrosDoc = True
                    End If
                Next

                If existeOtrosDoc Then
                    outSMS = "El ingreso tiene registro de documentos relacionados, para completar la operación coordine con la ORL para que elimine todos los documentos relacionados al ingreso que se desea eliminar."
                    Return -1
                End If

                If existeMDCarceleta Then
                    outSMS = "Para completar la operación, primero elimine el expediente relacionado al ingreso que desea eliminar."
                    Return -1
                End If
            End If

            Dim intValue As Integer = -1

            intValue = Eliminar(CodigoIngInpeId, 1)

            Return intValue
        End Function

        Public Function Eliminar_ORL(CodigoIngInpeId As Integer, ByRef outSMS As String) As Integer

            'que no tenga movimiento.
            Dim m As New Entity.Registro.InternoMovimiento
            Dim movCol As New Entity.Registro.InternoMovimientoCol
            Dim existeMovDePenal As Boolean = False

            m.IngresoInpeId = CodigoIngInpeId
            movCol = (New InternoMovimiento).Listar_LM_v2(m)

            For Each mov As Entity.Registro.InternoMovimiento In movCol
                If mov._PenalID <> 35 Then 'si es mov de penal
                    existeMovDePenal = True
                    outSMS = "El ingreso tiene registro de movimientos relacionados, para completar la operación coordine con el Establecimiento el cual debe eliminar todos los movimientos del interno relacionados al ingreso."
                    Return -1
                    Exit For
                End If
            Next


            'que no tenga documentos.
            Dim docJud As New Entity.Registro.DocumentoJudicial
            Dim docJudCol As New Entity.Registro.DocumentoJudicialCol

            docJud.IngresoInpeId = CodigoIngInpeId

            docJudCol = (New DocumentoJudicial).ListarDocJud_v2_LM(docJud)

            If docJudCol.Count > 0 Then

                Dim existeMDCarceleta As Boolean = False
                Dim existeOtrosDoc As Boolean = False

                For Each obj As Entity.Registro.DocumentoJudicial In docJudCol
                    If obj.DocumentoTipo = 35 Then
                        existeMDCarceleta = True
                    Else
                        existeOtrosDoc = True
                    End If
                Next

                If existeOtrosDoc Then
                    outSMS = "El ingreso tiene registro de documentos relacionados, para completar la operación elimine todos los documentos relacionados al ingreso que se desea eliminar."
                    Return -1
                End If

                If existeMDCarceleta Then
                    outSMS = "El ingreso tiene registro de documentos de carceleta relacionados, para completar la operación coordine con carceleta para la eliminación del documento relacionado al ingreso que se desea eliminar."
                    Return -1
                End If
            End If

            Dim intValue As Integer = -1

            intValue = Eliminar(CodigoIngInpeId, 1)

            Return intValue
        End Function
#End Region
    End Class
End Namespace