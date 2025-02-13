Imports System.Data
Imports System.Data.SqlClient
Namespace Estadistica
    Public Class PadinDetalle
        Private Shared strNameProcedure As String = "UP_RPT_PadinDetalle"
        Private Shared _listar As SqlDataReader
#Region "Listar"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Long, _
        ByVal PadinID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal ExpedienteID As Integer, _
        ByVal DelitoID As Integer, _
        ByVal CodigoInterno As String, ByVal ApellidosNombresAsociados As String, SituacionJuridica As Integer, _
        ByVal FechaInicio As Long, ByVal FechaFin As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd

                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pad_det_id", SqlDbType.BigInt)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = PadinID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = DelitoID

                    .Parameters.Add(New SqlParameter("@pad_det_int_cod", SqlDbType.VarChar, 50)).Value = CodigoInterno
                    .Parameters.Add(New SqlParameter("@ape_nom_aso", SqlDbType.VarChar, 200)).Value = ApellidosNombresAsociados
                    .Parameters.Add(New SqlParameter("@pad_det_ing_sit_jur_id", SqlDbType.Int)).Value = SituacionJuridica
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = FechaInicio
                    .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = FechaFin

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listarv2(sqlCon As SqlConnection, accion As String, opcion As String, entObj As Entity.Estadistica.PadinDetalle) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandTimeout = 500
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pad_det_id", SqlDbType.BigInt)).Value = entObj.Codigo  '  Codigo
                    .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = entObj.PadinID  ' PadinID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = entObj.RegionID  '   RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = entObj.PenalID   '  PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = entObj.InternoID      'InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = entObj.IngresoID ' IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = entObj.ExpedienteID '  ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = entObj.DelitoID ' DelitoID

                    .Parameters.Add(New SqlParameter("@pad_det_int_cod", SqlDbType.VarChar, 50)).Value = entObj.InternoCodigo ' CodigoInterno
                    .Parameters.Add(New SqlParameter("@ape_nom_aso", SqlDbType.VarChar, 200)).Value = entObj.InternoApellidosyNombresAsociados ' ApellidosNombresAsociados
                    .Parameters.Add(New SqlParameter("@pad_det_ing_sit_jur_id", SqlDbType.Int)).Value = entObj.IngresoSituacionJuridicaID
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = entObj.SentenciaFechaIni
                    .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = entObj.FechaCorte  ' FechaFin

                    .Parameters.Add(New SqlParameter("@pad_det_vis", SqlDbType.Int)).Value = entObj.PadinDetalleVisible ' Visible
                    .Parameters.Add(New SqlParameter("@pad_det_tip_mov", SqlDbType.Int)).Value = entObj.PadinTipoMovimiento    ' TipMov
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_v2(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Long, _
        ByVal PadinID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal ExpedienteID As Integer, _
        ByVal DelitoID As Integer, _
        ByVal CodigoInterno As String, ByVal ApellidosNombresAsociados As String, _
        ByVal FechaInicio As Long, ByVal FechaFin As Long, doc_jud_id As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pad_det_id", SqlDbType.BigInt)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = PadinID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = DelitoID
                    .Parameters.Add(New SqlParameter("@pad_det_int_cod", SqlDbType.VarChar, 50)).Value = CodigoInterno
                    .Parameters.Add(New SqlParameter("@ape_nom_aso", SqlDbType.VarChar, 200)).Value = ApellidosNombresAsociados
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = FechaInicio
                    .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = FechaFin

                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = doc_jud_id
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function ListarDatosComplementarios(ByVal accion As String, ByVal opcion As String, strIdInterno As String, strIdsIngreso As String, idsTraslados As String, _
                                                         idsTrasladosEgreso As String, IdsEgresoExpediente As String, FechaCorte As Long) As Dictionary(Of String, DataTable)
            Dim list As New Dictionary(Of String, DataTable)

            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Using sqlCmd As SqlCommand = New SqlCommand("UP_RPT_PadinDetalle_Complementario", sqlCon)
                    sqlCon.Open()
                    With sqlCmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                        .Parameters.Add(New SqlParameter("@strIdsInterno", SqlDbType.VarChar, -1)).Value = strIdInterno
                        .Parameters.Add(New SqlParameter("@strIdsIngreso", SqlDbType.VarChar, -1)).Value = strIdsIngreso
                        .Parameters.Add(New SqlParameter("@strIdsTraslado", SqlDbType.VarChar, -1)).Value = idsTraslados
                        .Parameters.Add(New SqlParameter("@strIdsTrasladoEgreso", SqlDbType.VarChar, -1)).Value = idsTrasladosEgreso
                        .Parameters.Add(New SqlParameter("@strIdsExpediente", SqlDbType.VarChar, -1)).Value = IdsEgresoExpediente
                        .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt, 0)).Value = FechaCorte
                    End With


                    Dim sqlda As New SqlDataAdapter(sqlCmd)

                    Dim ds As New DataSet("DatosComplementarios")
                    sqlda.Fill(ds)
                    ds.Tables(0).TableName = "tblNombresAsociados"
                    ds.Tables(1).TableName = "tblInternoAlias"
                    ds.Tables(2).TableName = "tblInternoExpediente"
                    ds.Tables(3).TableName = "tblInternoDelito"
                    ds.Tables(4).TableName = "tblInternoAgraviado"
                    ds.Tables(5).TableName = "tblInternoFamiliar"
                    ds.Tables(6).TableName = "tblIngreso"
                    ds.Tables(7).TableName = "tblIngresoPorTraslado"
                    ds.Tables(8).TableName = "tblSentencia"
                    ds.Tables(9).TableName = "tblEgresoPorTraslado"
                    ds.Tables(10).TableName = "tblEgresoPorExpediente"
                    ds.Tables(11).TableName = "tblInternoSituacionJuridica"
                    For Each dstbl As DataTable In ds.Tables
                        list.Add(dstbl.TableName, dstbl)
                    Next
                End Using
            End Using

            Return list
        End Function
        Public Shared Function ListarDatosComplementarios_v5(ByVal accion As String, ByVal opcion As String, strIdInterno As String, strIdsIngreso As String, idsMovimientos As String, _
                                                         idsMovimientosEgreso As String, IdsDocumentosIngreso As String, IdsDocumentosEgreso As String, FechaCorte As Long) As Dictionary(Of String, DataTable)
            Dim list As New Dictionary(Of String, DataTable)

            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Using sqlCmd As SqlCommand = New SqlCommand("UP_RPT_PadinDetalle_Complementario", sqlCon)
                    sqlCon.Open()
                    With sqlCmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                        .Parameters.Add(New SqlParameter("@strIdsInterno", SqlDbType.VarChar, -1)).Value = strIdInterno
                        .Parameters.Add(New SqlParameter("@strIdsIngreso", SqlDbType.VarChar, -1)).Value = strIdsIngreso
                        .Parameters.Add(New SqlParameter("@strIdsMovimientos", SqlDbType.VarChar, -1)).Value = idsMovimientos
                        .Parameters.Add(New SqlParameter("@strIdsMovimientosEgreso", SqlDbType.VarChar, -1)).Value = idsMovimientosEgreso
                        .Parameters.Add(New SqlParameter("@strIdsDocIngresos", SqlDbType.VarChar, -1)).Value = IdsDocumentosIngreso
                        .Parameters.Add(New SqlParameter("@strIdsDocEgresos", SqlDbType.VarChar, -1)).Value = IdsDocumentosEgreso
                        .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt, 0)).Value = FechaCorte
                    End With

                    Try


                        Dim sqlda As New SqlDataAdapter(sqlCmd)

                        Dim ds As New DataSet("DatosComplementarios_v5")
                        sqlda.Fill(ds)
                        ds.Tables(0).TableName = "tblNombresAsociados"
                        ds.Tables(1).TableName = "tblInternoAlias"
                        ds.Tables(2).TableName = "tblInternoSiscrico"
                        ds.Tables(3).TableName = "tblInternoSituacionJuridica"
                        ds.Tables(4).TableName = "tblIngreso"
                        ds.Tables(5).TableName = "tblInternoExpedienteInternamiento"
                        ds.Tables(6).TableName = "tblInternoDelito"
                        ds.Tables(7).TableName = "tblInternoAgraviado"
                        ds.Tables(8).TableName = "tblSentencia"
                        ds.Tables(9).TableName = "tblEgresoMovimiento"
                        ds.Tables(10).TableName = "tblExpedienteEgreso"
                        ds.Tables(11).TableName = "tblInternoFamiliar"
                        ds.Tables(12).TableName = "tblInternoOtrosExpediente"
                        ds.Tables(13).TableName = "tblInternoOtrosDelito"
                        For Each dstbl As DataTable In ds.Tables
                            list.Add(dstbl.TableName, dstbl)
                        Next
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                End Using
            End Using

            Return list
        End Function
        Public Shared Function ListarDatosComplementarios_v6(ByVal accion As String, ByVal opcion As String, strIdInterno As String, strIdsIngreso As String, idsMovimientos As String,
                                                         idsMovimientosEgreso As String, IdsDocumentosIngreso As String, IdsDocumentosEgreso As String, FechaCorte As Long) As Dictionary(Of String, DataTable)
            Dim list As New Dictionary(Of String, DataTable)

            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Using sqlCmd As SqlCommand = New SqlCommand("UP_RPT_PadinDetalle_Complementario", sqlCon)
                    sqlCon.Open()
                    With sqlCmd
                        .CommandTimeout = 500
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                        .Parameters.Add(New SqlParameter("@strIdsInterno", SqlDbType.VarChar, -1)).Value = strIdInterno
                        .Parameters.Add(New SqlParameter("@strIdsIngreso", SqlDbType.VarChar, -1)).Value = strIdsIngreso
                        .Parameters.Add(New SqlParameter("@strIdsMovimientos", SqlDbType.VarChar, -1)).Value = idsMovimientos
                        .Parameters.Add(New SqlParameter("@strIdsMovimientosEgreso", SqlDbType.VarChar, -1)).Value = idsMovimientosEgreso
                        .Parameters.Add(New SqlParameter("@strIdsDocIngresos", SqlDbType.VarChar, -1)).Value = IdsDocumentosIngreso
                        .Parameters.Add(New SqlParameter("@strIdsDocEgresos", SqlDbType.VarChar, -1)).Value = IdsDocumentosEgreso
                        .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt, 0)).Value = FechaCorte
                    End With

                    Try
                        Dim sqlda As New SqlDataAdapter(sqlCmd)

                        Dim ds As New DataSet("DatosComplementarios_v5")
                        sqlda.Fill(ds)
                        ds.Tables(0).TableName = "tblNombresAsociados"
                        ds.Tables(1).TableName = "tblInternoAlias"
                        ds.Tables(2).TableName = "tblInternoSiscrico"
                        ds.Tables(3).TableName = "tblInternoSituacionJuridica"
                        ds.Tables(4).TableName = "tblIngreso"
                        ds.Tables(5).TableName = "tblInternoExpedienteInternamiento"
                        ds.Tables(6).TableName = "tblInternoDelito"
                        ds.Tables(7).TableName = "tblInternoAgraviado"
                        ds.Tables(8).TableName = "tblSentencia"
                        ds.Tables(9).TableName = "tblEgresoMovimiento"
                        ds.Tables(10).TableName = "tblExpedienteEgreso"
                        ds.Tables(11).TableName = "tblInternoFamiliar"
                        ds.Tables(12).TableName = "tblInternoOtrosExpediente"
                        ds.Tables(13).TableName = "tblInternoOtrosDelito"
                        ds.Tables(14).TableName = "tblInternoInimputable"
                        For Each dstbl As DataTable In ds.Tables
                            list.Add(dstbl.TableName, dstbl)
                        Next
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                End Using
            End Using

            Return list
        End Function

        Public Shared Function ListarExpedienteHijo(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entExpHijo As Entity.Estadistica.PadinDetalle) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd

                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pad_det_id", SqlDbType.BigInt)).Value = entExpHijo.Codigo ' Codigo
                    .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = entExpHijo.PadinID ' PadinID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = entExpHijo.RegionID ' RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = entExpHijo.PadinID ' PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = entExpHijo.InternoID ' InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = entExpHijo.IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = entExpHijo.ExpedienteID ' ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = entExpHijo.DelitoID ' DelitoID
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = entExpHijo.SentenciaID  ' DelitoID
                    '.Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = FechaInicio
                    '.Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = FechaFin

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function ListarDatosComplementarios_plm(ByVal accion As String, ByVal opcion As String, strIdInterno As String, strIdsIngreso As String,
                                                              idsMovimientos As String, idsMovimientosEgreso As String, IdsDocumentosIngreso As String,
                                                              IdsDocumentosEgreso As String, FechaCorte As Long) As Dictionary(Of String, DataTable)

            Dim list As New Dictionary(Of String, DataTable)

            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Using sqlCmd As SqlCommand = New SqlCommand("UP_RPT_PadinDetalle_Complementario", sqlCon)
                    sqlCon.Open()
                    With sqlCmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                        .Parameters.Add(New SqlParameter("@strIdsInterno", SqlDbType.VarChar, -1)).Value = strIdInterno
                        .Parameters.Add(New SqlParameter("@strIdsIngreso", SqlDbType.VarChar, -1)).Value = strIdsIngreso
                        .Parameters.Add(New SqlParameter("@strIdsMovimientos", SqlDbType.VarChar, -1)).Value = idsMovimientos
                        .Parameters.Add(New SqlParameter("@strIdsMovimientosEgreso", SqlDbType.VarChar, -1)).Value = idsMovimientosEgreso
                        .Parameters.Add(New SqlParameter("@strIdsDocIngresos", SqlDbType.VarChar, -1)).Value = IdsDocumentosIngreso
                        .Parameters.Add(New SqlParameter("@strIdsDocEgresos", SqlDbType.VarChar, -1)).Value = IdsDocumentosEgreso
                        .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt, 0)).Value = FechaCorte
                    End With

                    Try
                        Dim sqlda As New SqlDataAdapter(sqlCmd)
                        Dim ds As New DataSet("DatosComplementarios_v5")
                        sqlda.Fill(ds)
                        ds.Tables(0).TableName = "tblNombresAsociados"
                        ds.Tables(1).TableName = "tblInternoAlias"
                        ds.Tables(2).TableName = "tblInternoSiscrico"
                        ds.Tables(3).TableName = "tblInternoSituacionJuridica"
                        ds.Tables(4).TableName = "tblIngreso"
                        ds.Tables(5).TableName = "tblInternoExpedienteInternamiento"
                        ds.Tables(6).TableName = "tblInternoDelito"
                        ds.Tables(7).TableName = "tblInternoAgraviado"
                        ds.Tables(8).TableName = "tblSentencia"
                        ds.Tables(9).TableName = "tblEgresoMovimiento"
                        ds.Tables(10).TableName = "tblExpedienteEgreso"
                        ds.Tables(11).TableName = "tblInternoFamiliar"
                        ds.Tables(12).TableName = "tblInternoOtrosExpediente"
                        ds.Tables(13).TableName = "tblInternoOtrosDelito"
                        ds.Tables(14).TableName = "tblSentenciaPrimeraInstancia"
                        For Each dstbl As DataTable In ds.Tables
                            list.Add(dstbl.TableName, dstbl)
                        Next
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                End Using
            End Using

            Return list
        End Function

        Public Shared Function ListarDatosComplementarios_plm_v6(ByVal accion As String, ByVal opcion As String, strIdInterno As String, strIdsIngreso As String,
                                                              idsMovimientos As String, idsMovimientosEgreso As String, IdsDocumentosIngreso As String,
                                                              IdsDocumentosEgreso As String, FechaCorte As Long) As Dictionary(Of String, DataTable)

            Dim list As New Dictionary(Of String, DataTable)

            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Using sqlCmd As SqlCommand = New SqlCommand("UP_RPT_PadinDetalle_Complementario", sqlCon)
                    sqlCon.Open()
                    With sqlCmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandTimeout = 180 '3 minutos
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                        .Parameters.Add(New SqlParameter("@strIdsInterno", SqlDbType.VarChar, -1)).Value = strIdInterno
                        .Parameters.Add(New SqlParameter("@strIdsIngreso", SqlDbType.VarChar, -1)).Value = strIdsIngreso
                        .Parameters.Add(New SqlParameter("@strIdsMovimientos", SqlDbType.VarChar, -1)).Value = idsMovimientos
                        .Parameters.Add(New SqlParameter("@strIdsMovimientosEgreso", SqlDbType.VarChar, -1)).Value = idsMovimientosEgreso
                        .Parameters.Add(New SqlParameter("@strIdsDocIngresos", SqlDbType.VarChar, -1)).Value = IdsDocumentosIngreso
                        .Parameters.Add(New SqlParameter("@strIdsDocEgresos", SqlDbType.VarChar, -1)).Value = IdsDocumentosEgreso
                        .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt, 0)).Value = FechaCorte
                    End With

                    Try
                        Dim sqlda As New SqlDataAdapter(sqlCmd)
                        Dim ds As New DataSet("DatosComplementarios_v5")
                        sqlda.Fill(ds)
                        ds.Tables(0).TableName = "tblNombresAsociados"
                        ds.Tables(1).TableName = "tblInternoAlias"
                        ds.Tables(2).TableName = "tblInternoSiscrico"
                        ds.Tables(3).TableName = "tblInternoSituacionJuridica"
                        ds.Tables(4).TableName = "tblIngreso"
                        ds.Tables(5).TableName = "tblInternoExpedienteInternamiento"
                        ds.Tables(6).TableName = "tblInternoDelito"
                        ds.Tables(7).TableName = "tblInternoAgraviado"
                        ds.Tables(8).TableName = "tblSentencia"
                        ds.Tables(9).TableName = "tblEgresoMovimiento"
                        ds.Tables(10).TableName = "tblExpedienteEgreso"
                        ds.Tables(11).TableName = "tblInternoFamiliar"
                        ds.Tables(12).TableName = "tblInternoOtrosExpediente"
                        ds.Tables(13).TableName = "tblInternoOtrosDelito"
                        For Each dstbl As DataTable In ds.Tables
                            list.Add(dstbl.TableName, dstbl)
                        Next
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                End Using
            End Using

            Return list
        End Function
#End Region
#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Long, _
        ByVal PadinID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal PenalCodigo As String, _
        ByVal FechaCorte As Long, _
        ByVal InternoID As Integer, _
        ByVal InternoCodigo As String, _
        ByVal InternoTipoDocumentoID As Integer, _
        ByVal InternoTipoDOcumento As String, _
        ByVal InternoNumeroDocumento As String, _
        ByVal InternoPrimerApellido As String, _
        ByVal InternoSegundoApellido As String, _
        ByVal InternoPreNombres As String, _
        ByVal InternoNombresAsociados As String, _
        ByVal InternoAlias As String, _
        ByVal InternoClasificacion As String, _
        ByVal InternoPabellon As String, _
        ByVal FechaISP As Long, _
        ByVal FechaIngresoPenal As Long, _
        ByVal IngresoNumero As Integer, _
        ByVal IngresoSituacionJuridicaID As Integer, _
        ByVal IngresoSituacionJuridica As String, _
        ByVal DelitoGenericoID As Integer, _
        ByVal DelitoGenerico As String, _
        ByVal DelitoEspecificoID As Integer, _
        ByVal DelitoEspecifico As String, _
        ByVal DelitoOtros As String, _
        ByVal DelitoAgraviados As String, _
        ByVal ExpedienteDistritoJudicial As String, _
        ByVal ExpedienteSalaJuzgado As String, _
        ByVal ExpedienteJuez As String, _
        ByVal ExpedienteSecretario As String, _
        ByVal ExpedienteNumero As String, _
        ByVal ExpedienteSituacionJuridicaID As Integer, _
        ByVal ExpedienteSituacionJuridica As String, _
        ByVal ExpedienteNumeroOtros As String, _
        ByVal SentenciaFecha As Long, _
        ByVal SentenciaDistritoJudicial As String, _
        ByVal SentenciaSalaJuzgado As String, _
        ByVal SentenciaDocumento As String, _
        ByVal SentenciaDelitoGenerico As String, _
        ByVal SentenciaDelitoEspecificoID As Integer, _
        ByVal SentenciaDelitoEspecifico As String, _
        ByVal SentenciaPenaImpuestaAnio As Integer, _
        ByVal SentenciaPenaImpuestaMes As Integer, _
        ByVal SentenciaPenaImpuestaDia As Integer, _
        ByVal SentenciaFechaIni As Long, _
        ByVal SentenciaFechaFin As Long, _
        ByVal SentenciaObs As String, _
        ByVal IngresoMotivo As String, _
        ByVal IngresoOrigen As String, _
        ByVal IngresoDocumento As String, _
        ByVal IngresoMotivoTraslado As String, _
        ByVal InternoFechaNacimiento As Long, _
        ByVal InternoSexoID As Integer, _
        ByVal InternoSexo As String, _
        ByVal InternoNacimientoPaisID As Integer, _
        ByVal InternoNacimientoPais As String, _
        ByVal InternoNacimientoDepartamento As String, _
        ByVal InternoNacimientoProvincia As String, _
        ByVal InternoNacimientoDistrito As String, _
        ByVal InternoNacionalidad As String, _
        ByVal InternoNumeroHijo As Integer, _
        ByVal InternoEstadoCivilID As Integer, _
        ByVal InternoEstadoCivil As String, _
        ByVal InternoGradoInstruccionID As Integer, _
        ByVal InternoGradoInstruccion As String, _
        ByVal InternoOcupacionGenericoID As Integer, _
        ByVal InternoOcupacionGenerico As String, _
        ByVal InternoOcupacionEspecifico As String, _
        ByVal InternoComunidaNativaID As Integer, _
        ByVal InternoComunidaNativa As String, _
        ByVal InternoDiscapacidadID As Integer, _
        ByVal InternoDiscapacidad As String, _
        ByVal InternoPadre As String, _
        ByVal InternoMadre As String, _
        ByVal InternoDomicilio As String, _
        ByVal InternoDomicilioDepartamento As String, _
        ByVal InternoDomicilioProvincia As String, _
        ByVal InternoDomicilioDistrito As String, _
        ByVal InternoFiliacionPolitica As String, _
        ByVal EgresoFecha As Long, _
        ByVal EgresoTipoID As Integer, _
        ByVal EgresoTipo As String, _
        ByVal EgresoTipoMotivoID As Integer, _
        ByVal EgresoTipoMotivo As String, _
        ByVal EgresoDestino As String, _
        ByVal EgresoDistritoJudicial As String, _
        ByVal EgresoDocumentoLibertad As String, _
        ByVal EgresoDocumento As String, _
        ByVal EgresoJuez As String, _
        ByVal EgresoSecretario As String, _
        ByVal EgresoSalaJuzgado As String, _
        ByVal Observacion As String, _
        ByVal InternoEstadoID As Integer, _
        ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            'general
                            .Parameters.Add(New SqlParameter("@pad_det_id", SqlDbType.BigInt)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = PadinID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@pad_det_cod_pen", SqlDbType.VarChar, 10)).Value = PenalCodigo
                            .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = FechaCorte
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_cod", SqlDbType.VarChar, 50)).Value = InternoCodigo

                            'interno
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = InternoTipoDocumentoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_tip_doc", SqlDbType.VarChar, 50)).Value = InternoTipoDOcumento
                            .Parameters.Add(New SqlParameter("@pad_det_int_num_doc", SqlDbType.VarChar, 50)).Value = InternoNumeroDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_int_pri_ape", SqlDbType.VarChar, 60)).Value = InternoPrimerApellido
                            .Parameters.Add(New SqlParameter("@pad_det_int_seg_ape", SqlDbType.VarChar, 60)).Value = InternoSegundoApellido
                            .Parameters.Add(New SqlParameter("@pad_det_int_pre_nom", SqlDbType.VarChar, 60)).Value = InternoPreNombres
                            .Parameters.Add(New SqlParameter("@pad_det_int_nom_aso", SqlDbType.VarChar, 1200)).Value = InternoNombresAsociados
                            .Parameters.Add(New SqlParameter("@pad_det_int_ali", SqlDbType.VarChar, 500)).Value = InternoAlias
                            .Parameters.Add(New SqlParameter("@pad_det_int_cla", SqlDbType.VarChar, 50)).Value = InternoClasificacion
                            .Parameters.Add(New SqlParameter("@pad_det_int_pab", SqlDbType.VarChar, 50)).Value = InternoPabellon
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = InternoSexoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_sex", SqlDbType.VarChar, 50)).Value = InternoSexo
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_pai", SqlDbType.VarChar, 50)).Value = InternoNacimientoPais
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_dep", SqlDbType.VarChar, 50)).Value = InternoNacimientoDepartamento
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_pro", SqlDbType.VarChar, 50)).Value = InternoNacimientoProvincia
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_dis", SqlDbType.VarChar, 50)).Value = InternoNacimientoDistrito
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac", SqlDbType.VarChar, 50)).Value = InternoNacionalidad

                            .Parameters.Add(New SqlParameter("@pad_det_int_num_hij", SqlDbType.Int)).Value = InternoNumeroHijo
                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = InternoEstadoCivilID
                            .Parameters.Add(New SqlParameter("@pad_det_int_est_civ", SqlDbType.VarChar, 50)).Value = InternoEstadoCivil
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = InternoGradoInstruccionID
                            .Parameters.Add(New SqlParameter("@pad_det_int_grd_ins", SqlDbType.VarChar, 200)).Value = InternoGradoInstruccion
                            .Parameters.Add(New SqlParameter("@ocu_tip_id", SqlDbType.Int)).Value = InternoOcupacionGenericoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_ocu_gen", SqlDbType.VarChar, 200)).Value = InternoOcupacionGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_int_ocu_esp", SqlDbType.VarChar, 200)).Value = InternoOcupacionEspecifico
                            .Parameters.Add(New SqlParameter("@com_gen_id", SqlDbType.Int)).Value = InternoComunidaNativaID
                            .Parameters.Add(New SqlParameter("@pad_det_int_com_nat", SqlDbType.VarChar, 200)).Value = InternoComunidaNativa
                            .Parameters.Add(New SqlParameter("@dis_id", SqlDbType.Int)).Value = InternoDiscapacidadID
                            .Parameters.Add(New SqlParameter("@pad_det_int_dis", SqlDbType.VarChar, 200)).Value = InternoDiscapacidad
                            .Parameters.Add(New SqlParameter("@pad_det_int_pad", SqlDbType.VarChar, 200)).Value = InternoPadre
                            .Parameters.Add(New SqlParameter("@pad_det_int_mad", SqlDbType.VarChar, 200)).Value = InternoMadre
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom", SqlDbType.VarChar, 500)).Value = InternoDomicilio
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_dep", SqlDbType.VarChar, 50)).Value = InternoDomicilioDepartamento
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_pro", SqlDbType.VarChar, 50)).Value = InternoDomicilioProvincia
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_dis", SqlDbType.VarChar, 50)).Value = InternoDomicilioDistrito
                            .Parameters.Add(New SqlParameter("@pad_det_int_fil_pol", SqlDbType.VarChar, 200)).Value = InternoFiliacionPolitica
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = InternoNacimientoPaisID
                            .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = InternoEstadoID

                            'ingreso
                            .Parameters.Add(New SqlParameter("@pad_det_fec_isp", SqlDbType.BigInt)).Value = FechaISP
                            .Parameters.Add(New SqlParameter("@pad_det_fec_ing_pen", SqlDbType.BigInt)).Value = FechaIngresoPenal
                            .Parameters.Add(New SqlParameter("@pad_det_num_ing", SqlDbType.Int)).Value = IngresoNumero

                            .Parameters.Add(New SqlParameter("@pad_det_ing_sit_jur_id", SqlDbType.Int)).Value = IngresoSituacionJuridicaID
                            .Parameters.Add(New SqlParameter("@pad_det_ing_sit_jur", SqlDbType.VarChar, 50)).Value = IngresoSituacionJuridica

                            .Parameters.Add(New SqlParameter("@pad_det_ing_mot", SqlDbType.VarChar, 50)).Value = IngresoMotivo
                            .Parameters.Add(New SqlParameter("@pad_det_ing_org", SqlDbType.VarChar, 200)).Value = IngresoOrigen
                            .Parameters.Add(New SqlParameter("@pad_det_ing_doc", SqlDbType.VarChar, 50)).Value = IngresoDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_ing_mot_trs", SqlDbType.VarChar, 50)).Value = IngresoMotivoTraslado
                            .Parameters.Add(New SqlParameter("@pad_det_int_fec_nac", SqlDbType.BigInt)).Value = InternoFechaNacimiento

                            'delito
                            .Parameters.Add(New SqlParameter("@pad_det_del_gen_id", SqlDbType.Int)).Value = DelitoGenericoID
                            .Parameters.Add(New SqlParameter("@pad_det_del_gen", SqlDbType.VarChar, 500)).Value = DelitoGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_del_esp_id", SqlDbType.Int)).Value = DelitoEspecificoID
                            .Parameters.Add(New SqlParameter("@pad_det_del_esp", SqlDbType.VarChar, 500)).Value = DelitoEspecifico
                            .Parameters.Add(New SqlParameter("@pad_det_del_otr", SqlDbType.VarChar, 500)).Value = DelitoOtros
                            .Parameters.Add(New SqlParameter("@pad_det_del_agr", SqlDbType.VarChar, 500)).Value = DelitoAgraviados

                            'expediente
                            .Parameters.Add(New SqlParameter("@pad_det_exp_dis_jud", SqlDbType.VarChar, 100)).Value = ExpedienteDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sal_juz", SqlDbType.VarChar, 200)).Value = ExpedienteSalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_exp_jue", SqlDbType.VarChar, 200)).Value = ExpedienteJuez
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sec", SqlDbType.VarChar, 200)).Value = ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@pad_det_exp_num", SqlDbType.VarChar, 50)).Value = ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sit_jur_id", SqlDbType.Int)).Value = ExpedienteSituacionJuridicaID
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sit_jur", SqlDbType.VarChar, 50)).Value = ExpedienteSituacionJuridica
                            .Parameters.Add(New SqlParameter("@pad_det_exp_num_otr", SqlDbType.VarChar, 500)).Value = ExpedienteNumeroOtros

                            'sentencia
                            .Parameters.Add(New SqlParameter("@pad_det_sen_fec", SqlDbType.BigInt)).Value = SentenciaFecha
                            .Parameters.Add(New SqlParameter("@pad_det_sen_dis_jud", SqlDbType.VarChar, 100)).Value = SentenciaDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_sen_sal_juz", SqlDbType.VarChar, 200)).Value = SentenciaSalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_sen_doc", SqlDbType.VarChar, 50)).Value = SentenciaDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_gen", SqlDbType.VarChar, 500)).Value = SentenciaDelitoGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_esp_id", SqlDbType.Int)).Value = SentenciaDelitoEspecificoID
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_esp", SqlDbType.VarChar, 500)).Value = SentenciaDelitoEspecifico
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_anio", SqlDbType.Int)).Value = SentenciaPenaImpuestaAnio
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_mes", SqlDbType.Int)).Value = SentenciaPenaImpuestaMes
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_dia", SqlDbType.Int)).Value = SentenciaPenaImpuestaDia
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_fec_ini", SqlDbType.BigInt)).Value = SentenciaFechaIni
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_fec_fin", SqlDbType.BigInt)).Value = SentenciaFechaFin
                            .Parameters.Add(New SqlParameter("@pad_det_sen_obs", SqlDbType.VarChar, 500)).Value = SentenciaObs

                            'egreso
                            .Parameters.Add(New SqlParameter("@pad_det_egr_fec", SqlDbType.BigInt)).Value = EgresoFecha
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip_id", SqlDbType.Int)).Value = EgresoTipoID
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip", SqlDbType.VarChar, 50)).Value = EgresoTipo
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip_mov_id", SqlDbType.Int)).Value = EgresoTipoMotivoID
                            .Parameters.Add(New SqlParameter("@pad_det_egr_lib_trs", SqlDbType.VarChar, 200)).Value = EgresoTipoMotivo
                            .Parameters.Add(New SqlParameter("@pad_det_egr_des", SqlDbType.VarChar, 200)).Value = EgresoDestino
                            .Parameters.Add(New SqlParameter("@pad_det_egr_dis_jud", SqlDbType.VarChar, 100)).Value = EgresoDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_egr_doc_lib", SqlDbType.VarChar, 50)).Value = EgresoDocumentoLibertad
                            .Parameters.Add(New SqlParameter("@pad_det_egr_doc", SqlDbType.VarChar, 50)).Value = EgresoDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_egr_jue", SqlDbType.VarChar, 200)).Value = EgresoJuez
                            .Parameters.Add(New SqlParameter("@pad_det_egr_sec", SqlDbType.VarChar, 200)).Value = EgresoSecretario
                            .Parameters.Add(New SqlParameter("@pad_det_egr_sal_juz", SqlDbType.VarChar, 200)).Value = EgresoSalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_egr_obs", SqlDbType.VarChar, 500)).Value = Observacion

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))

                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Shared Function Grabar_v1_2(ByVal accion As String, ByVal opcion As String, ByVal Obj As Entity.Estadistica.PadinDetalle) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            'general
                            .Parameters.Add(New SqlParameter("@pad_det_id", SqlDbType.BigInt)).Value = Obj.Codigo
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = Obj.PadinID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = Obj.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = Obj.PenalID
                            .Parameters.Add(New SqlParameter("@pad_det_cod_pen", SqlDbType.VarChar, 10)).Value = Obj.PenalCodigo
                            .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = Obj.FechaCorte
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Obj.InternoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_cod", SqlDbType.VarChar, 50)).Value = Obj.InternoCodigo

                            .Parameters.Add(New SqlParameter("@grup_del_nom", SqlDbType.VarChar, 500)).Value = Obj.GruposDelictivosOtros
                            .Parameters.Add(New SqlParameter("@org_crim_pert", SqlDbType.Bit)).Value = Obj.OrgCriminalFormaParte
                            .Parameters.Add(New SqlParameter("@org_crim_nom", SqlDbType.VarChar, 500)).Value = Obj.OrgCriminalNombre
                            .Parameters.Add(New SqlParameter("@org_crim_cond", SqlDbType.VarChar, 250)).Value = Obj.OrgCriminalCondicion
                            .Parameters.Add(New SqlParameter("@int_del_flag", SqlDbType.Bit)).Value = Obj.DelitoFlagrante  ' Obj.DelitoFlagrante

                            'interno
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = Obj.InternoTipoDocumentoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_tip_doc", SqlDbType.VarChar, 50)).Value = Obj.InternoTipoDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_int_num_doc", SqlDbType.VarChar, 50)).Value = Obj.InternoNumeroDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_int_pri_ape", SqlDbType.VarChar, 60)).Value = Obj.InternoPrimerApellido
                            .Parameters.Add(New SqlParameter("@pad_det_int_seg_ape", SqlDbType.VarChar, 60)).Value = Obj.InternoSegundoApellido
                            .Parameters.Add(New SqlParameter("@pad_det_int_pre_nom", SqlDbType.VarChar, 60)).Value = Obj.InternoPreNombres
                            .Parameters.Add(New SqlParameter("@pad_det_int_nom_aso", SqlDbType.VarChar, 1200)).Value = Obj.InternoNombresAsociados
                            .Parameters.Add(New SqlParameter("@pad_det_int_ali", SqlDbType.VarChar, 500)).Value = Obj.InternoAlias
                            .Parameters.Add(New SqlParameter("@pad_det_int_cla", SqlDbType.VarChar, 50)).Value = Obj.InternoClasificacion
                            .Parameters.Add(New SqlParameter("@pad_det_int_pab", SqlDbType.VarChar, 50)).Value = Obj.PabellonNombre
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = Obj.InternoSexoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_sex", SqlDbType.VarChar, 50)).Value = Obj.InternoSexo
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_pai", SqlDbType.VarChar, 50)).Value = Obj.InternoNacimientoPais
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_dep", SqlDbType.VarChar, 50)).Value = Obj.InternoNacimientoDepartamento
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_pro", SqlDbType.VarChar, 50)).Value = Obj.InternoNacimientoProvincia
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_dis", SqlDbType.VarChar, 50)).Value = Obj.InternoNacimientoDistrito
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac", SqlDbType.VarChar, 50)).Value = Obj.InternoNacionalidad

                            .Parameters.Add(New SqlParameter("@pad_det_int_num_hij", SqlDbType.Int)).Value = Obj.InternoNumeroHijo
                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = Obj.InternoEstadoCivilID
                            .Parameters.Add(New SqlParameter("@pad_det_int_est_civ", SqlDbType.VarChar, 50)).Value = Obj.InternoEstadoCivil
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = Obj.InternoGradoInstruccionID
                            .Parameters.Add(New SqlParameter("@pad_det_int_grd_ins", SqlDbType.VarChar, 200)).Value = Obj.InternoGradoInstruccion
                            .Parameters.Add(New SqlParameter("@ocu_tip_id", SqlDbType.Int)).Value = Obj.InternoOcupacionGenericoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_ocu_gen", SqlDbType.VarChar, 200)).Value = Obj.InternoOcupacionGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_int_ocu_esp", SqlDbType.VarChar, 200)).Value = Obj.InternoOcupacionEspecifico
                            .Parameters.Add(New SqlParameter("@com_gen_id", SqlDbType.Int)).Value = Obj.InternoComunidaGenericaID
                            .Parameters.Add(New SqlParameter("@pad_det_int_com_nat", SqlDbType.VarChar, 200)).Value = Obj.InternoComunidaNativa
                            .Parameters.Add(New SqlParameter("@dis_id", SqlDbType.Int)).Value = Obj.InternoDiscapacidadID
                            .Parameters.Add(New SqlParameter("@pad_det_int_dis", SqlDbType.VarChar, 200)).Value = Obj.InternoDiscapacidad
                            .Parameters.Add(New SqlParameter("@pad_det_int_pad", SqlDbType.VarChar, 200)).Value = Obj.InternoPadre
                            .Parameters.Add(New SqlParameter("@pad_det_int_mad", SqlDbType.VarChar, 200)).Value = Obj.InternoMadre
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom", SqlDbType.VarChar, 500)).Value = Obj.InternoDomicilio
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_dep", SqlDbType.VarChar, 50)).Value = Obj.InternoDomicilioDepartamento
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_pro", SqlDbType.VarChar, 50)).Value = Obj.InternoDomicilioProvincia
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_dis", SqlDbType.VarChar, 50)).Value = Obj.InternoDomicilioDistrito
                            .Parameters.Add(New SqlParameter("@pad_det_int_fil_pol", SqlDbType.VarChar, 200)).Value = Obj.InternoFiliacionPolitica
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = Obj.InternoNacimientoPaisID
                            .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = Obj.InternoEstadoID

                            'ingreso
                            .Parameters.Add(New SqlParameter("@pad_det_fec_isp", SqlDbType.BigInt)).Value = Obj.FechaISP
                            .Parameters.Add(New SqlParameter("@pad_det_fec_ing_pen", SqlDbType.BigInt)).Value = Obj.FechaIngresoPenal
                            .Parameters.Add(New SqlParameter("@pad_det_num_ing", SqlDbType.Int)).Value = Obj.IngresoNumero

                            .Parameters.Add(New SqlParameter("@pad_det_ing_sit_jur_id", SqlDbType.Int)).Value = Obj.IngresoSituacionJuridicaID
                            .Parameters.Add(New SqlParameter("@pad_det_ing_sit_jur", SqlDbType.VarChar, 50)).Value = Obj.IngresoSituacionJuridica

                            .Parameters.Add(New SqlParameter("@pad_det_ing_mot", SqlDbType.VarChar, 50)).Value = Obj.IngresoMotivo
                            .Parameters.Add(New SqlParameter("@pad_det_ing_org", SqlDbType.VarChar, 200)).Value = Obj.IngresoOrigen
                            .Parameters.Add(New SqlParameter("@pad_det_ing_doc", SqlDbType.VarChar, 50)).Value = Obj.IngresoDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_ing_mot_trs", SqlDbType.VarChar, 50)).Value = Obj.IngresoMotivoTraslado
                            .Parameters.Add(New SqlParameter("@pad_det_int_fec_nac", SqlDbType.BigInt)).Value = Obj.InternoFechaNacimiento

                            'delito
                            .Parameters.Add(New SqlParameter("@pad_det_del_gen_id", SqlDbType.Int)).Value = Obj.DelitoGenericoID
                            .Parameters.Add(New SqlParameter("@pad_det_del_gen", SqlDbType.VarChar, 500)).Value = Obj.DelitoGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_del_esp_id", SqlDbType.Int)).Value = Obj.DelitoEspecificoID
                            .Parameters.Add(New SqlParameter("@pad_det_del_esp", SqlDbType.VarChar, 500)).Value = Obj.DelitoEspecifico
                            .Parameters.Add(New SqlParameter("@pad_det_del_otr", SqlDbType.VarChar, 500)).Value = Obj.DelitoOtros
                            .Parameters.Add(New SqlParameter("@pad_det_del_agr", SqlDbType.VarChar, 500)).Value = Obj.DelitoAgraviados

                            'expediente
                            .Parameters.Add(New SqlParameter("@pad_det_exp_dis_jud", SqlDbType.VarChar, 100)).Value = Obj.ExpedienteDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sal_juz", SqlDbType.VarChar, 200)).Value = Obj.ExpedienteSalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_exp_jue", SqlDbType.VarChar, 200)).Value = Obj.ExpedienteJuez
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sec", SqlDbType.VarChar, 200)).Value = Obj.ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@pad_det_exp_num", SqlDbType.VarChar, 50)).Value = Obj.ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sit_jur_id", SqlDbType.Int)).Value = Obj.ExpedienteSituacionJuridicaID
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sit_jur", SqlDbType.VarChar, 50)).Value = Obj.ExpedienteSituacionJuridica
                            .Parameters.Add(New SqlParameter("@pad_det_exp_num_otr", SqlDbType.VarChar, 500)).Value = Obj.ExpedienteNumeroOtros

                            'sentencia
                            .Parameters.Add(New SqlParameter("@pad_det_sen_fec", SqlDbType.BigInt)).Value = Obj.SentenciaFecha
                            .Parameters.Add(New SqlParameter("@pad_det_sen_dis_jud", SqlDbType.VarChar, 100)).Value = Obj.SentenciaDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_sen_sal_juz", SqlDbType.VarChar, 200)).Value = Obj.SentenciaSalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_sen_doc", SqlDbType.VarChar, 50)).Value = Obj.SentenciaDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_gen", SqlDbType.VarChar, 500)).Value = Obj.SentenciaDelitoGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_esp_id", SqlDbType.Int)).Value = Obj.SentenciaDelitoEspecificoID
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_esp", SqlDbType.VarChar, 500)).Value = Obj.SentenciaDelitoEspecifico
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_anio", SqlDbType.Int)).Value = Obj.SentenciaPenaImpuestaAnio
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_mes", SqlDbType.Int)).Value = Obj.SentenciaPenaImpuestaMes
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_dia", SqlDbType.Int)).Value = Obj.SentenciaPenaImpuestaDia
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_fec_ini", SqlDbType.BigInt)).Value = Obj.SentenciaFechaIni
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_fec_fin", SqlDbType.BigInt)).Value = Obj.SentenciaFechaFin
                            .Parameters.Add(New SqlParameter("@pad_det_sen_obs", SqlDbType.VarChar, 500)).Value = Obj.SentenciaObs

                            'egreso
                            .Parameters.Add(New SqlParameter("@pad_det_egr_fec", SqlDbType.BigInt)).Value = Obj.EgresoFecha
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip_id", SqlDbType.Int)).Value = Obj.EgresoTipoID
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip", SqlDbType.VarChar, 50)).Value = Obj.EgresoTipo
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip_mov_id", SqlDbType.Int)).Value = Obj.EgresoTipoMotivoID
                            .Parameters.Add(New SqlParameter("@pad_det_egr_lib_trs", SqlDbType.VarChar, 200)).Value = Obj.EgresoTipoMotivo
                            .Parameters.Add(New SqlParameter("@pad_det_egr_des", SqlDbType.VarChar, 200)).Value = Obj.EgresoDestino
                            .Parameters.Add(New SqlParameter("@pad_det_egr_dis_jud", SqlDbType.VarChar, 100)).Value = Obj.EgresoDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_egr_doc_lib", SqlDbType.VarChar, 50)).Value = Obj.EgresoDocumentoLibertad
                            .Parameters.Add(New SqlParameter("@pad_det_egr_doc", SqlDbType.VarChar, 50)).Value = Obj.EgresoDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_egr_jue", SqlDbType.VarChar, 200)).Value = Obj.EgresoJuez
                            .Parameters.Add(New SqlParameter("@pad_det_egr_sec", SqlDbType.VarChar, 200)).Value = Obj.EgresoSecretario
                            .Parameters.Add(New SqlParameter("@pad_det_egr_sal_juz", SqlDbType.VarChar, 200)).Value = Obj.EgresoSalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_egr_obs", SqlDbType.VarChar, 500)).Value = Obj.EgresoObservacion
                            .Parameters.Add(New SqlParameter("@pad_det_vis", SqlDbType.Int)).Value = Obj.PadinDetalleVisible
                            .Parameters.Add(New SqlParameter("@pad_det_tip_mov", SqlDbType.Int)).Value = Obj.PadinTipoMovimiento

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))

                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Function Grabar_v2(ByVal accion As String, ByVal opcion As String, ByVal Obj As Entity.Estadistica.PadinDetalle) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            'general
                            .Parameters.Add(New SqlParameter("@pad_det_id", SqlDbType.BigInt)).Value = Obj.Codigo
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = Obj.PadinID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = Obj.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = Obj.PenalID
                            .Parameters.Add(New SqlParameter("@pad_det_cod_pen", SqlDbType.VarChar, 10)).Value = Obj.PenalCodigo
                            .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = Obj.FechaCorte
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Obj.InternoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_cod", SqlDbType.VarChar, 50)).Value = Obj.InternoCodigo

                            .Parameters.Add(New SqlParameter("@grup_del_nom", SqlDbType.VarChar, 500)).Value = Obj.GruposDelictivosOtros
                            .Parameters.Add(New SqlParameter("@org_crim_pert", SqlDbType.Bit)).Value = Obj.OrgCriminalFormaParte
                            .Parameters.Add(New SqlParameter("@org_crim_nom", SqlDbType.VarChar, 500)).Value = Obj.OrgCriminalNombre
                            .Parameters.Add(New SqlParameter("@org_crim_cond", SqlDbType.VarChar, 250)).Value = Obj.OrgCriminalCondicion
                            .Parameters.Add(New SqlParameter("@int_del_flag", SqlDbType.Bit)).Value = Obj.DelitoFlagrante  ' Obj.DelitoFlagrante

                            'interno
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = Obj.InternoTipoDocumentoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_tip_doc", SqlDbType.VarChar, 50)).Value = Obj.InternoTipoDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_int_num_doc", SqlDbType.VarChar, 50)).Value = Obj.InternoNumeroDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_int_pri_ape", SqlDbType.VarChar, 60)).Value = Obj.InternoPrimerApellido
                            .Parameters.Add(New SqlParameter("@pad_det_int_seg_ape", SqlDbType.VarChar, 60)).Value = Obj.InternoSegundoApellido
                            .Parameters.Add(New SqlParameter("@pad_det_int_pre_nom", SqlDbType.VarChar, 60)).Value = Obj.InternoPreNombres
                            .Parameters.Add(New SqlParameter("@pad_det_int_nom_aso", SqlDbType.VarChar, 1200)).Value = Obj.InternoNombresAsociados
                            .Parameters.Add(New SqlParameter("@pad_det_int_ali", SqlDbType.VarChar, 500)).Value = Obj.InternoAlias
                            .Parameters.Add(New SqlParameter("@pad_det_int_cla", SqlDbType.VarChar, 50)).Value = Obj.InternoClasificacion
                            .Parameters.Add(New SqlParameter("@pad_det_int_pab", SqlDbType.VarChar, 50)).Value = Obj.PabellonNombre
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = Obj.InternoSexoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_sex", SqlDbType.VarChar, 50)).Value = Obj.InternoSexo
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_pai", SqlDbType.VarChar, 50)).Value = Obj.InternoNacimientoPais
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_dep", SqlDbType.VarChar, 50)).Value = Obj.InternoNacimientoDepartamento
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_pro", SqlDbType.VarChar, 50)).Value = Obj.InternoNacimientoProvincia
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac_dis", SqlDbType.VarChar, 50)).Value = Obj.InternoNacimientoDistrito
                            .Parameters.Add(New SqlParameter("@pad_det_int_nac", SqlDbType.VarChar, 50)).Value = Obj.InternoNacionalidad

                            .Parameters.Add(New SqlParameter("@pad_det_int_num_hij", SqlDbType.Int)).Value = Obj.InternoNumeroHijo
                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = Obj.InternoEstadoCivilID
                            .Parameters.Add(New SqlParameter("@pad_det_int_est_civ", SqlDbType.VarChar, 50)).Value = Obj.InternoEstadoCivil
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = Obj.InternoGradoInstruccionID
                            .Parameters.Add(New SqlParameter("@pad_det_int_grd_ins", SqlDbType.VarChar, 200)).Value = Obj.InternoGradoInstruccion
                            .Parameters.Add(New SqlParameter("@ocu_tip_id", SqlDbType.Int)).Value = Obj.InternoOcupacionGenericoID
                            .Parameters.Add(New SqlParameter("@pad_det_int_ocu_gen", SqlDbType.VarChar, 200)).Value = Obj.InternoOcupacionGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_int_ocu_esp", SqlDbType.VarChar, 200)).Value = Obj.InternoOcupacionEspecifico
                            .Parameters.Add(New SqlParameter("@com_gen_id", SqlDbType.Int)).Value = Obj.InternoComunidaGenericaID
                            .Parameters.Add(New SqlParameter("@pad_det_int_com_nat", SqlDbType.VarChar, 200)).Value = Obj.InternoComunidaNativa
                            .Parameters.Add(New SqlParameter("@dis_id", SqlDbType.Int)).Value = Obj.InternoDiscapacidadID
                            .Parameters.Add(New SqlParameter("@pad_det_int_dis", SqlDbType.VarChar, 200)).Value = Obj.InternoDiscapacidad
                            .Parameters.Add(New SqlParameter("@pad_det_int_pad", SqlDbType.VarChar, 200)).Value = Obj.InternoPadre
                            .Parameters.Add(New SqlParameter("@pad_det_int_mad", SqlDbType.VarChar, 200)).Value = Obj.InternoMadre
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom", SqlDbType.VarChar, 500)).Value = Obj.InternoDomicilio
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_dep", SqlDbType.VarChar, 50)).Value = Obj.InternoDomicilioDepartamento
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_pro", SqlDbType.VarChar, 50)).Value = Obj.InternoDomicilioProvincia
                            .Parameters.Add(New SqlParameter("@pad_det_int_dom_dis", SqlDbType.VarChar, 50)).Value = Obj.InternoDomicilioDistrito
                            .Parameters.Add(New SqlParameter("@pad_det_int_fil_pol", SqlDbType.VarChar, 200)).Value = Obj.InternoFiliacionPolitica
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = Obj.InternoNacimientoPaisID
                            .Parameters.Add(New SqlParameter("@pad_gen_nom", SqlDbType.VarChar, 100)).Value = Obj.InternoGenero
                            .Parameters.Add(New SqlParameter("@pad_pert_etn", SqlDbType.VarChar, 100)).Value = Obj.InternoPerteneciaEtnica
                            .Parameters.Add(New SqlParameter("@pad_leng_mat", SqlDbType.VarChar, 100)).Value = Obj.InternoLenguaMaterna
                            .Parameters.Add(New SqlParameter("@pad_det_lib", SqlDbType.VarChar, 20)).Value = Obj.InternoLibro
                            .Parameters.Add(New SqlParameter("@pad_det_fol", SqlDbType.VarChar, 20)).Value = Obj.InternoFolio
                            .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = Obj.InternoEstadoID

                            'ingreso
                            .Parameters.Add(New SqlParameter("@pad_det_fec_isp", SqlDbType.BigInt)).Value = Obj.FechaISP
                            .Parameters.Add(New SqlParameter("@pad_det_fec_ing_pen", SqlDbType.BigInt)).Value = Obj.FechaIngresoPenal
                            .Parameters.Add(New SqlParameter("@pad_det_num_ing", SqlDbType.Int)).Value = Obj.IngresoNumero

                            .Parameters.Add(New SqlParameter("@pad_det_ing_sit_jur_id", SqlDbType.Int)).Value = Obj.IngresoSituacionJuridicaID
                            .Parameters.Add(New SqlParameter("@pad_det_ing_sit_jur", SqlDbType.VarChar, 50)).Value = Obj.IngresoSituacionJuridica

                            .Parameters.Add(New SqlParameter("@pad_det_ing_mot", SqlDbType.VarChar, 50)).Value = Obj.IngresoMotivo
                            .Parameters.Add(New SqlParameter("@pad_det_ing_org", SqlDbType.VarChar, 200)).Value = Obj.IngresoOrigen
                            .Parameters.Add(New SqlParameter("@pad_det_ing_doc", SqlDbType.VarChar, 50)).Value = Obj.IngresoDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_ing_mot_trs", SqlDbType.VarChar, 50)).Value = Obj.IngresoMotivoTraslado
                            .Parameters.Add(New SqlParameter("@pad_det_int_fec_nac", SqlDbType.BigInt)).Value = Obj.InternoFechaNacimiento

                            'delito
                            .Parameters.Add(New SqlParameter("@pad_det_del_gen_id", SqlDbType.Int)).Value = Obj.DelitoGenericoID
                            .Parameters.Add(New SqlParameter("@pad_det_del_gen", SqlDbType.VarChar, 500)).Value = Obj.DelitoGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_del_esp_id", SqlDbType.Int)).Value = Obj.DelitoEspecificoID
                            .Parameters.Add(New SqlParameter("@pad_det_del_esp", SqlDbType.VarChar, 500)).Value = Obj.DelitoEspecifico
                            .Parameters.Add(New SqlParameter("@pad_det_del_otr", SqlDbType.VarChar, 500)).Value = Obj.DelitoOtros
                            .Parameters.Add(New SqlParameter("@pad_det_del_agr", SqlDbType.VarChar, 500)).Value = Obj.DelitoAgraviados

                            'expediente
                            .Parameters.Add(New SqlParameter("@pad_det_exp_dis_jud", SqlDbType.VarChar, 100)).Value = Obj.ExpedienteDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sal_juz", SqlDbType.VarChar, 200)).Value = Obj.ExpedienteSalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_exp_jue", SqlDbType.VarChar, 200)).Value = Obj.ExpedienteJuez
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sec", SqlDbType.VarChar, 200)).Value = Obj.ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@pad_det_exp_num", SqlDbType.VarChar, 50)).Value = Obj.ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sit_jur_id", SqlDbType.Int)).Value = Obj.ExpedienteSituacionJuridicaID
                            .Parameters.Add(New SqlParameter("@pad_det_exp_sit_jur", SqlDbType.VarChar, 50)).Value = Obj.ExpedienteSituacionJuridica
                            .Parameters.Add(New SqlParameter("@pad_det_exp_num_otr", SqlDbType.VarChar, 500)).Value = Obj.ExpedienteNumeroOtros

                            'sentencia
                            .Parameters.Add(New SqlParameter("@pad_det_sen_fec", SqlDbType.BigInt)).Value = Obj.SentenciaPIFecha
                            .Parameters.Add(New SqlParameter("@pad_det_sen_dis_jud", SqlDbType.VarChar, 100)).Value = Obj.SentenciaPIDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_sen_sal_juz", SqlDbType.VarChar, 200)).Value = Obj.SentenciaPISalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_sen_doc", SqlDbType.VarChar, 50)).Value = Obj.SentenciaPIExpedienteNumero
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_gen", SqlDbType.VarChar, 500)).Value = Obj.SentenciaDelitoGenerico
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_esp_id", SqlDbType.Int)).Value = Obj.SentenciaDelitoEspecificoID
                            .Parameters.Add(New SqlParameter("@pad_det_sen_del_esp", SqlDbType.VarChar, 500)).Value = Obj.SentenciaDelitoEspecifico
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_anio", SqlDbType.Int)).Value = Obj.SentenciaPenaImpuestaAnio
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_mes", SqlDbType.Int)).Value = Obj.SentenciaPenaImpuestaMes
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_imp_dia", SqlDbType.Int)).Value = Obj.SentenciaPenaImpuestaDia
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_fec_ini", SqlDbType.BigInt)).Value = Obj.SentenciaFechaIni
                            .Parameters.Add(New SqlParameter("@pad_det_sen_pen_fec_fin", SqlDbType.BigInt)).Value = Obj.SentenciaFechaFin
                            .Parameters.Add(New SqlParameter("@pad_det_sen_obs", SqlDbType.VarChar, 500)).Value = Obj.SentenciaObs

                            'sentencia Otros
                            .Parameters.Add(New SqlParameter("@pad_det_sen_si_dis_jud", SqlDbType.VarChar, 100)).Value = Obj.SentenciaSIDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_sen_si_sal_juz", SqlDbType.VarChar, 200)).Value = Obj.SentenciaSISalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_sen_si_doc", SqlDbType.VarChar, 100)).Value = Obj.SentenciaSIExpedienteNumero

                            'Inimputables
                            .Parameters.Add(New SqlParameter("@pad_det_inmp", SqlDbType.VarChar, 100)).Value = Obj.Inimputable
                            .Parameters.Add(New SqlParameter("@pad_det_est_men_des", SqlDbType.VarChar, 200)).Value = Obj.EstablecimientoMental

                            'egreso
                            .Parameters.Add(New SqlParameter("@pad_det_egr_fec", SqlDbType.BigInt)).Value = Obj.EgresoFecha
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip_id", SqlDbType.Int)).Value = Obj.EgresoTipoID
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip", SqlDbType.VarChar, 50)).Value = Obj.EgresoTipo
                            .Parameters.Add(New SqlParameter("@pad_det_egr_tip_mov_id", SqlDbType.Int)).Value = Obj.EgresoTipoMotivoID
                            .Parameters.Add(New SqlParameter("@pad_det_egr_lib_trs", SqlDbType.VarChar, 200)).Value = Obj.EgresoTipoMotivo
                            .Parameters.Add(New SqlParameter("@pad_det_egr_des", SqlDbType.VarChar, 200)).Value = Obj.EgresoDestino
                            .Parameters.Add(New SqlParameter("@pad_det_egr_dis_jud", SqlDbType.VarChar, 100)).Value = Obj.EgresoDistritoJudicial
                            .Parameters.Add(New SqlParameter("@pad_det_egr_doc_lib", SqlDbType.VarChar, 50)).Value = Obj.EgresoDocumentoLibertad
                            .Parameters.Add(New SqlParameter("@pad_det_egr_doc", SqlDbType.VarChar, 50)).Value = Obj.EgresoDocumento
                            .Parameters.Add(New SqlParameter("@pad_det_egr_jue", SqlDbType.VarChar, 200)).Value = Obj.EgresoJuez
                            .Parameters.Add(New SqlParameter("@pad_det_egr_sec", SqlDbType.VarChar, 200)).Value = Obj.EgresoSecretario
                            .Parameters.Add(New SqlParameter("@pad_det_egr_sal_juz", SqlDbType.VarChar, 200)).Value = Obj.EgresoSalaJuzgado
                            .Parameters.Add(New SqlParameter("@pad_det_egr_obs", SqlDbType.VarChar, 500)).Value = Obj.EgresoObservacion
                            .Parameters.Add(New SqlParameter("@pad_det_vis", SqlDbType.Int)).Value = Obj.PadinDetalleVisible
                            .Parameters.Add(New SqlParameter("@pad_det_tip_mov", SqlDbType.Int)).Value = Obj.PadinTipoMovimiento

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))

                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
#End Region
#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Long, ByVal Usuario As Integer) As Long
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_det_id", SqlDbType.BigInt)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
#End Region

    End Class
End Namespace