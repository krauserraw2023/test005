Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class ExpedienteLibertadSubtipo
        Private Shared strNameProcedure As String = "UP_INT_InternoLibertadSubtipo"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, objIntLibSubtipo As Entity.Registro.ExpedienteLibertadSubtipo) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntLibSubtipo.ExpedienteId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntLibSubtipo.IngresoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntLibSubtipo.InternoID
                            .Parameters.Add(New SqlParameter("@subtip_lib_id", SqlDbType.Int)).Value = objIntLibSubtipo.LibertadSubTipoID
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = objIntLibSubtipo.LibertadTipoID
                            '.Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = ExpedienteNumero
                            '.Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = ExpedienteFecha
                            '.Parameters.Add(New SqlParameter("@int_lib_fec", SqlDbType.BigInt)).Value = FechaLibertad

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value
                            Return intValue
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Function Listar(ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Registro.ExpedienteLibertadSubtipo) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandTimeout = 300
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId

                    .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = objIntExp.AutoridadJudicialID
                    .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = objIntExp.ExpedienteNumero
                    .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFecha
                    .Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFechaDocRecepcion

                    .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objIntExp.CreaDocJudicialId
                    .Parameters.Add(New SqlParameter("@aux_ref_doc_jud_id", SqlDbType.Int)).Value = objIntExp.AuxRefDocJudId
                    .Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = objIntExp.ExpedienteVisible


                    .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objIntExp.DocumentoTipoID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Registro.Expediente) As SqlDataReader

            '16-06-2014 x hnrb, version con entity

            Dim sqlReader As SqlDataReader = Nothing

            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandTimeout = 50
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objIntExp.SedeRowId

                    .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = objIntExp.AutoridadJudicialID
                    .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = objIntExp.SalaJudicialID
                    .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = objIntExp.ExpedienteNumero
                    .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFecha
                    .Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFechaDocRecepcion

                    .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objIntExp.CreaDocJudicialId
                    .Parameters.Add(New SqlParameter("@aux_ref_doc_jud_id", SqlDbType.Int)).Value = objIntExp.AuxRefDocJudId
                    .Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = objIntExp.ExpedienteVisible

                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objIntExp.SituacionJuridicaID
                    .Parameters.Add(New SqlParameter("@n_int_exp_est_anu", SqlDbType.Int)).Value = objIntExp.Anulacion
                    .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objIntExp.DocumentoTipoID
                    .Parameters.Add(New SqlParameter("@int_exp_extramuro", SqlDbType.SmallInt)).Value = objIntExp.Extramuro
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar_QuedaExp(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal DocJud_id As Integer, ByVal interno_id As Integer, ByVal ingreso_id As Integer, ByVal ingreso_inpe_id As Integer) As SqlDataReader

            '16-06-2014 x hnrb, version con entity

            Dim sqlReader As SqlDataReader = Nothing

            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_InternoExpediente_Queda", sqlCon)
                With sqlCmd
                    .CommandTimeout = 200
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = -1 'objIntExp.Codigo
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = ingreso_id '-1 'objIntExp.IngresoID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = interno_id ' -1 'objIntExp.InternoID
                    .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = -1
                    .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = -1
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = -1
                    '.Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = ""
                    '.Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = ExpedienteFecha
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = -1
                    '.Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = RegistroVisible
                    .Parameters.Add(New SqlParameter("@n_int_exp_est_anu", SqlDbType.Int)).Value = -1 'objIntExp.Anulacion
                    .Parameters.Add(New SqlParameter("@exp_lib_id", SqlDbType.Int)).Value = DocJud_id
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            Finally

            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar_Queda_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Registro.Expediente, Exp_Lib_id As Integer) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                ' Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_InternoExpediente_Queda", sqlCon)

                With sqlCmd
                    .CommandTimeout = 300
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = -1 'objIntExp.Codigo
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = -1 'objIntExp.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                    .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = -1
                    .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = -1
                    '.Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = ""
                    '.Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = ExpedienteFecha
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = -1
                    '.Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = RegistroVisible
                    .Parameters.Add(New SqlParameter("@n_int_exp_est_anu", SqlDbType.Int)).Value = -1 'objIntExp.Anulacion
                    .Parameters.Add(New SqlParameter("@exp_lib_id", SqlDbType.Int)).Value = Exp_Lib_id



                    '.CommandTimeout = 50
                    '.CommandType = CommandType.StoredProcedure
                    '.Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    '.Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    '.Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Codigo
                    '.Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                    '.Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                    '.Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId
                    '.Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objIntExp.SedeRowId

                    '.Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = objIntExp.AutoridadJudicialID
                    '.Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = objIntExp.SalaJudicialID
                    '.Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = objIntExp.ExpedienteNumero
                    '.Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFecha
                    '.Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFechaDocRecepcion

                    '.Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objIntExp.CreaDocJudicialId
                    '.Parameters.Add(New SqlParameter("@aux_ref_doc_jud_id", SqlDbType.Int)).Value = objIntExp.AuxRefDocJudId
                    '.Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = objIntExp.ExpedienteVisible

                    '.Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objIntExp.SituacionJuridicaID
                    '.Parameters.Add(New SqlParameter("@n_int_exp_est_anu", SqlDbType.Int)).Value = objIntExp.Anulacion
                    '.Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objIntExp.DocumentoTipoID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_Queda(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Registro.Expediente, Exp_Lib_id As Integer) As SqlDataReader

            '16-06-2014 x hnrb, version con entity

            Dim sqlReader As SqlDataReader = Nothing

            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_InternoExpediente_Queda", sqlCon)
                With sqlCmd
                    '.CommandTimeout = 300
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = -1 'objIntExp.Codigo
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                    .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = -1
                    .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = -1
                    '.Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = ""
                    '.Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = ExpedienteFecha
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = -1
                    '.Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = RegistroVisible
                    .Parameters.Add(New SqlParameter("@n_int_exp_est_anu", SqlDbType.Int)).Value = -1 'objIntExp.Anulacion
                    .Parameters.Add(New SqlParameter("@exp_lib_id", SqlDbType.Int)).Value = Exp_Lib_id
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            Finally

            End Try
            Return sqlReader
        End Function

#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
       ByVal IngreoId As Integer,
       ByVal InternoId As Integer, ByVal Internamiento As Boolean,
       ByVal AutoridadJudicialId As Integer,
       ByVal SalaJudicialId As Integer, ByVal ExpedienteJuez As String, ByVal ExpedienteSecretario As String,
       ByVal ExpedienteNumero As String,
       ByVal ExpedienteFechaDocRecepcion As Long, ByVal ExpedienteFecha As Long,
       ByVal SituacionJuridicaId As Integer, ByVal Observacion As String,
       ByVal DistritoJudicialID As Integer, ByVal JuzgadoID As Integer,
       ByVal AutoridadOtro As String, ByVal AutoridadCargoOtro As String,
       ByVal EgresoJuez As String, ByVal EgresoSecretario As String,
       ByVal DocumentoLibertad As String, ByVal EgresoFechaDocRecepcion As Long,
       ByVal DocLibFecha As Long,
       ByVal TipoLibertad As Integer, ByVal FechaLibertad As Long, ByVal ObsLibertad As String,
       RegionID As Integer, PenalID As Integer, ByVal Estado As Integer, ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 900
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngreoId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                            .Parameters.Add(New SqlParameter("@int_exp_itn", SqlDbType.Bit)).Value = Internamiento
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = AutoridadJudicialId
                            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = SalaJudicialId
                            .Parameters.Add(New SqlParameter("@int_exp_jue", SqlDbType.VarChar, 200)).Value = ExpedienteJuez
                            .Parameters.Add(New SqlParameter("@int_exp_sec", SqlDbType.VarChar, 200)).Value = ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 120)).Value = ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = ExpedienteFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = ExpedienteFecha
                            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = SituacionJuridicaId
                            .Parameters.Add(New SqlParameter("@int_exp_obs", SqlDbType.VarChar, 500)).Value = Observacion
                            .Parameters.Add(New SqlParameter("@int_exp_otr_nom", SqlDbType.VarChar, 120)).Value = AutoridadOtro
                            .Parameters.Add(New SqlParameter("@int_exp_otr_cgo", SqlDbType.VarChar, 120)).Value = AutoridadCargoOtro

                            '/*libertad*/
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = DistritoJudicialID
                            .Parameters.Add(New SqlParameter("@juz_id", SqlDbType.Int)).Value = JuzgadoID
                            .Parameters.Add(New SqlParameter("@int_exp_lib_sec", SqlDbType.VarChar, 200)).Value = EgresoSecretario
                            .Parameters.Add(New SqlParameter("@int_exp_lib_jue", SqlDbType.VarChar, 200)).Value = EgresoJuez
                            .Parameters.Add(New SqlParameter("@int_lib_doc", SqlDbType.VarChar, 120)).Value = DocumentoLibertad
                            .Parameters.Add(New SqlParameter("@int_lib_doc_fec", SqlDbType.BigInt)).Value = DocLibFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = TipoLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_lib_fec_doc_rcp", SqlDbType.BigInt)).Value = EgresoFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_lib_fec", SqlDbType.BigInt)).Value = FechaLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_obs_lib", SqlDbType.VarChar, 500)).Value = ObsLibertad

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@int_exp_est", SqlDbType.VarChar, 500)).Value = Estado


                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
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
        Public Shared Function GrabarF(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
     ByVal IngreoId As Integer,
     ByVal InternoId As Integer, ByVal Internamiento As Boolean,
     ByVal AutoridadJudicialId As Integer,
     ByVal SalaJudicialId As Integer, ByVal ExpedienteJuez As String, ByVal ExpedienteSecretario As String,
     ByVal ExpedienteNumero As String,
     ByVal ExpedienteFechaDocRecepcion As Long, ByVal ExpedienteFecha As Long,
     ByVal SituacionJuridicaId As Integer, Flagrancia As Boolean, ByVal Observacion As String,
     ByVal DistritoJudicialID As Integer, ByVal JuzgadoID As Integer,
     ByVal AutoridadOtro As String, ByVal AutoridadCargoOtro As String,
     ByVal EgresoJuez As String, ByVal EgresoSecretario As String,
     ByVal DocumentoLibertad As String, ByVal EgresoFechaDocRecepcion As Long,
     ByVal DocLibFecha As Long,
     ByVal TipoLibertad As Integer, ByVal FechaLibertad As Long, ByVal ObsLibertad As String,
     RegionID As Integer, PenalID As Integer, ByVal Estado As Integer, ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngreoId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                            .Parameters.Add(New SqlParameter("@int_exp_itn", SqlDbType.Bit)).Value = Internamiento
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = AutoridadJudicialId
                            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = SalaJudicialId
                            .Parameters.Add(New SqlParameter("@int_exp_jue", SqlDbType.VarChar, 200)).Value = ExpedienteJuez
                            .Parameters.Add(New SqlParameter("@int_exp_sec", SqlDbType.VarChar, 200)).Value = ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 120)).Value = ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = ExpedienteFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = ExpedienteFecha
                            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = SituacionJuridicaId
                            .Parameters.Add(New SqlParameter("@int_exp_flag", SqlDbType.Bit)).Value = Flagrancia
                            .Parameters.Add(New SqlParameter("@int_exp_obs", SqlDbType.VarChar, 500)).Value = Observacion
                            .Parameters.Add(New SqlParameter("@int_exp_otr_cgo", SqlDbType.VarChar, 120)).Value = AutoridadOtro
                            .Parameters.Add(New SqlParameter("@int_exp_otr_nom", SqlDbType.VarChar, 120)).Value = AutoridadCargoOtro

                            '/*libertad*/
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = DistritoJudicialID
                            .Parameters.Add(New SqlParameter("@juz_id", SqlDbType.Int)).Value = JuzgadoID
                            .Parameters.Add(New SqlParameter("@int_exp_lib_sec", SqlDbType.VarChar, 200)).Value = EgresoSecretario
                            .Parameters.Add(New SqlParameter("@int_exp_lib_jue", SqlDbType.VarChar, 200)).Value = EgresoJuez
                            .Parameters.Add(New SqlParameter("@int_lib_doc", SqlDbType.VarChar, 120)).Value = DocumentoLibertad
                            .Parameters.Add(New SqlParameter("@int_lib_doc_fec", SqlDbType.BigInt)).Value = DocLibFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = TipoLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_lib_fec_doc_rcp", SqlDbType.BigInt)).Value = EgresoFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_lib_fec", SqlDbType.BigInt)).Value = FechaLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_obs_lib", SqlDbType.VarChar, 500)).Value = ObsLibertad

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@int_exp_est", SqlDbType.VarChar, 500)).Value = Estado


                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
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
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
    ByVal IngreoId As Integer,
    ByVal InternoId As Integer, ByVal Internamiento As Boolean,
    ByVal AutoridadJudicialId As Integer,
    ByVal SalaJudicialId As Integer, ByVal ExpedienteJuez As String, ByVal ExpedienteSecretario As String,
    ByVal ExpedienteNumero As String,
    ByVal ExpedienteFechaDocRecepcion As Long, ByVal ExpedienteFecha As Long,
    ByVal SituacionJuridicaId As Integer, Flagrancia As Boolean, ByVal Observacion As String,
    ByVal DistritoJudicialID As Integer, ByVal JuzgadoID As Integer,
    ByVal AutoridadOtro As String, ByVal AutoridadCargoOtro As String,
    ByVal EgresoJuez As String, ByVal EgresoSecretario As String,
    ByVal DocumentoLibertad As String, ByVal EgresoFechaDocRecepcion As Long,
    ByVal DocLibFecha As Long,
    ByVal TipoLibertad As Integer, ByVal FechaLibertad As Long, ByVal ObsLibertad As String,
    RegionID As Integer, PenalID As Integer, ByVal Estado As Integer, ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngreoId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                            .Parameters.Add(New SqlParameter("@int_exp_itn", SqlDbType.Bit)).Value = Internamiento
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = AutoridadJudicialId
                            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = SalaJudicialId
                            .Parameters.Add(New SqlParameter("@int_exp_jue", SqlDbType.VarChar, 200)).Value = ExpedienteJuez
                            .Parameters.Add(New SqlParameter("@int_exp_sec", SqlDbType.VarChar, 200)).Value = ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 120)).Value = ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = ExpedienteFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = ExpedienteFecha
                            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = SituacionJuridicaId
                            .Parameters.Add(New SqlParameter("@int_exp_flag", SqlDbType.Bit)).Value = Flagrancia
                            .Parameters.Add(New SqlParameter("@int_exp_obs", SqlDbType.VarChar, 500)).Value = Observacion
                            .Parameters.Add(New SqlParameter("@int_exp_otr_cgo", SqlDbType.VarChar, 120)).Value = AutoridadOtro
                            .Parameters.Add(New SqlParameter("@int_exp_otr_nom", SqlDbType.VarChar, 120)).Value = AutoridadCargoOtro

                            '/*libertad*/
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = DistritoJudicialID
                            .Parameters.Add(New SqlParameter("@juz_id", SqlDbType.Int)).Value = JuzgadoID
                            .Parameters.Add(New SqlParameter("@int_exp_lib_sec", SqlDbType.VarChar, 200)).Value = EgresoSecretario
                            .Parameters.Add(New SqlParameter("@int_exp_lib_jue", SqlDbType.VarChar, 200)).Value = EgresoJuez
                            .Parameters.Add(New SqlParameter("@int_lib_doc", SqlDbType.VarChar, 120)).Value = DocumentoLibertad
                            .Parameters.Add(New SqlParameter("@int_lib_doc_fec", SqlDbType.BigInt)).Value = DocLibFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = TipoLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_lib_fec_doc_rcp", SqlDbType.BigInt)).Value = EgresoFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_lib_fec", SqlDbType.BigInt)).Value = FechaLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_obs_lib", SqlDbType.VarChar, 500)).Value = ObsLibertad

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@int_exp_est", SqlDbType.VarChar, 500)).Value = Estado


                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
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
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Registro.Expediente) As Integer

            '16-05-2014, version grabar con entity

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Codigo
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                            .Parameters.Add(New SqlParameter("@int_exp_itn", SqlDbType.Bit)).Value = objIntExp.Internamiento
                            .Parameters.Add(New SqlParameter("@tip_aut_jud_id", SqlDbType.Int)).Value = objIntExp.TipoAutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = objIntExp.AutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = objIntExp.SalaJudicialID
                            .Parameters.Add(New SqlParameter("@int_exp_jue", SqlDbType.VarChar, 200)).Value = objIntExp.ExpedienteJuez
                            .Parameters.Add(New SqlParameter("@int_exp_sec", SqlDbType.VarChar, 200)).Value = objIntExp.ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 120)).Value = objIntExp.ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFecha
                            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objIntExp.SituacionJuridicaID
                            .Parameters.Add(New SqlParameter("@int_exp_flag", SqlDbType.Bit)).Value = objIntExp.Flagrancia
                            .Parameters.Add(New SqlParameter("@int_exp_obs", SqlDbType.VarChar, 500)).Value = objIntExp.Observacion
                            .Parameters.Add(New SqlParameter("@int_exp_otr_nom", SqlDbType.VarChar, 120)).Value = objIntExp.AutoridadOtro
                            .Parameters.Add(New SqlParameter("@int_exp_otr_cgo", SqlDbType.VarChar, 120)).Value = objIntExp.AutoridadOtroCargo
                            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objIntExp.CreaDocJudicialId
                            .Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = objIntExp.ExpedienteVisible

                            .Parameters.Add(New SqlParameter("@int_exp_pri_sen", SqlDbType.Bit)).Value = objIntExp.SentenciaPrincipal
                            .Parameters.Add(New SqlParameter("@int_exp_pri", SqlDbType.Bit)).Value = objIntExp.Principal

                            '/*libertad*/
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = objIntExp.DistritoJudicialID
                            .Parameters.Add(New SqlParameter("@juz_id", SqlDbType.Int)).Value = objIntExp.JuzgadoID
                            .Parameters.Add(New SqlParameter("@int_exp_lib_sec", SqlDbType.VarChar, 200)).Value = objIntExp.EgresoSecretario
                            .Parameters.Add(New SqlParameter("@int_exp_lib_jue", SqlDbType.VarChar, 200)).Value = objIntExp.EgresoJuez
                            .Parameters.Add(New SqlParameter("@int_lib_doc", SqlDbType.VarChar, 120)).Value = objIntExp.DocumentoLibertad
                            .Parameters.Add(New SqlParameter("@int_lib_doc_fec", SqlDbType.BigInt)).Value = objIntExp.DocumentoLibertadFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = objIntExp.LibertadTipoID
                            .Parameters.Add(New SqlParameter("@subtip_lib_id", SqlDbType.VarChar, 120)).Value = objIntExp.LibertadSubTipoID
                            .Parameters.Add(New SqlParameter("@int_exp_lib_fec_doc_rcp", SqlDbType.BigInt)).Value = objIntExp.EgresoFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_lib_fec", SqlDbType.BigInt)).Value = objIntExp.FechaLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_obs_lib", SqlDbType.VarChar, 500)).Value = objIntExp.ObsLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_est", SqlDbType.VarChar, 500)).Value = objIntExp.Estado
                            .Parameters.Add(New SqlParameter("@int_sen_pad", SqlDbType.Bit)).Value = objIntExp.int_sen_pad
                            .Parameters.Add(New SqlParameter("@n_int_exp_est_anu", SqlDbType.Int)).Value = objIntExp.Anulacion
                            .Parameters.Add(New SqlParameter("@n_int_exp_res_id", SqlDbType.Int)).Value = objIntExp.ResolucionID
                            .Parameters.Add(New SqlParameter("@n_int_exp_que_id", SqlDbType.Int)).Value = objIntExp.MotivoQuedaID
                            .Parameters.Add(New SqlParameter("@n_int_exp_mot_id", SqlDbType.Int)).Value = objIntExp.MotivoIngresoID
                            .Parameters.Add(New SqlParameter("@est_men_des_id", SqlDbType.Int)).Value = objIntExp.EstablecimientomentalId
                            .Parameters.Add(New SqlParameter("@nue_int_exp_mot_id", SqlDbType.Int)).Value = objIntExp.NuevoMotivoInimputableId
                            .Parameters.Add(New SqlParameter("@nue_est_men_des_id", SqlDbType.Int)).Value = objIntExp.NuevoEstablecimientomentalId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objIntExp.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@int_exp_extramuro", SqlDbType.SmallInt)).Value = objIntExp.Extramuro

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objIntExp._RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objIntExp._PenalId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Registro.Expediente) As Integer
            '16-05-2014, version grabar con entity
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 900
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Codigo
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                            .Parameters.Add(New SqlParameter("@int_exp_itn", SqlDbType.Bit)).Value = objIntExp.Internamiento
                            .Parameters.Add(New SqlParameter("@tip_aut_jud_id", SqlDbType.Int)).Value = objIntExp.TipoAutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = objIntExp.AutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = objIntExp.SalaJudicialID
                            .Parameters.Add(New SqlParameter("@int_exp_jue", SqlDbType.VarChar, 200)).Value = objIntExp.ExpedienteJuez
                            .Parameters.Add(New SqlParameter("@int_exp_sec", SqlDbType.VarChar, 200)).Value = objIntExp.ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 120)).Value = objIntExp.ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFecha
                            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objIntExp.SituacionJuridicaID
                            .Parameters.Add(New SqlParameter("@int_exp_flag", SqlDbType.Bit)).Value = objIntExp.Flagrancia
                            .Parameters.Add(New SqlParameter("@int_exp_obs", SqlDbType.VarChar, 500)).Value = objIntExp.Observacion
                            .Parameters.Add(New SqlParameter("@int_exp_otr_nom", SqlDbType.VarChar, 120)).Value = objIntExp.AutoridadOtro
                            .Parameters.Add(New SqlParameter("@int_exp_otr_cgo", SqlDbType.VarChar, 120)).Value = objIntExp.AutoridadOtroCargo
                            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.VarChar, 120)).Value = objIntExp.CreaDocJudicialId
                            .Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = objIntExp.ExpedienteVisible
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objIntExp.SedeRowId

                            .Parameters.Add(New SqlParameter("@int_exp_pri_sen", SqlDbType.Bit)).Value = objIntExp.SentenciaPrincipal
                            .Parameters.Add(New SqlParameter("@int_exp_pri", SqlDbType.Bit)).Value = objIntExp.Principal

                            '/*libertad*/
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = objIntExp.DistritoJudicialID
                            .Parameters.Add(New SqlParameter("@juz_id", SqlDbType.Int)).Value = objIntExp.JuzgadoID
                            .Parameters.Add(New SqlParameter("@int_exp_lib_sec", SqlDbType.VarChar, 200)).Value = objIntExp.EgresoSecretario
                            .Parameters.Add(New SqlParameter("@int_exp_lib_jue", SqlDbType.VarChar, 200)).Value = objIntExp.EgresoJuez
                            .Parameters.Add(New SqlParameter("@int_lib_doc", SqlDbType.VarChar, 120)).Value = objIntExp.DocumentoLibertad
                            .Parameters.Add(New SqlParameter("@int_lib_doc_fec", SqlDbType.BigInt)).Value = objIntExp.DocumentoLibertadFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = objIntExp.LibertadTipoID
                            .Parameters.Add(New SqlParameter("@int_exp_lib_fec_doc_rcp", SqlDbType.BigInt)).Value = objIntExp.EgresoFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_lib_fec", SqlDbType.BigInt)).Value = objIntExp.FechaLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_obs_lib", SqlDbType.VarChar, 500)).Value = objIntExp.ObsLibertad
                            .Parameters.Add(New SqlParameter("@int_exp_est", SqlDbType.VarChar, 500)).Value = objIntExp.Estado
                            .Parameters.Add(New SqlParameter("@int_sen_pad", SqlDbType.Bit)).Value = objIntExp.int_sen_pad
                            .Parameters.Add(New SqlParameter("@n_int_exp_est_anu", SqlDbType.Int)).Value = objIntExp.Anulacion
                            .Parameters.Add(New SqlParameter("@n_int_exp_res_id", SqlDbType.Int)).Value = objIntExp.ResolucionID
                            .Parameters.Add(New SqlParameter("@n_int_exp_que_id", SqlDbType.Int)).Value = objIntExp.MotivoQuedaID
                            .Parameters.Add(New SqlParameter("@n_int_exp_mot_id", SqlDbType.Int)).Value = objIntExp.MotivoIngresoID
                            .Parameters.Add(New SqlParameter("@est_men_des_id", SqlDbType.Int)).Value = objIntExp.EstablecimientomentalId
                            .Parameters.Add(New SqlParameter("@nue_int_exp_mot_id", SqlDbType.Int)).Value = objIntExp.NuevoMotivoInimputableId
                            .Parameters.Add(New SqlParameter("@nue_est_men_des_id", SqlDbType.Int)).Value = objIntExp.NuevoEstablecimientomentalId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objIntExp.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@int_exp_extramuro", SqlDbType.SmallInt)).Value = objIntExp.Extramuro

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objIntExp._RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objIntExp._PenalId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
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

        Public Shared Function GrabarQuedaExp(ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Registro.ExpedienteCol, Exp_Jud_Id As Integer) As Integer
            '16-05-2014, version grabar con entity
            Try
                Dim intCodigo As Integer = -1
                Dim i As Integer
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    If IsNothing(objIntExp) = False Then
                        sqlCon.Open()
                        For i = 0 To objIntExp.Count - 1
                            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                                With sqlCmd
                                    .CommandTimeout = 50
                                    .CommandType = CommandType.StoredProcedure
                                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Item(i).Codigo
                                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.Item(i).IngresoID
                                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.Item(i).IngresoInpeId
                                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.Item(i).InternoID
                                    .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = Exp_Jud_Id

                                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objIntExp.Item(i)._RegionId
                                    .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objIntExp.Item(i)._PenalId

                                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                                    .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                                    .Parameters("@variable_out").Direction = ParameterDirection.Output

                                    .ExecuteNonQuery()
                                    'intCodigo = .Parameters("@variable_out").Value
                                    'Return intCodigo
                                End With
                            End Using

                        Next
                    End If
                End Using

            Catch ex As SqlException
                Dim i As Integer
                Dim MensajeError As String
                MensajeError = "No determinado."
                For i = 0 To ex.Errors.Count - 1
                    MensajeError = ("Error #" & i.ToString() & vbCrLf _
                                & "Mensaje: " & ex.Errors(i).Message & ControlChars.NewLine _
                                & "Linea: " & ex.Errors(i).LineNumber & ControlChars.NewLine _
                                & "Fuente: " & ex.Errors(i).Source & ControlChars.NewLine _
                                & "Procedimiento: " & ex.Errors(i).Procedure & ControlChars.NewLine _
                                & "Recomendación: Volver a ejecutar el Proceso.")
                Next i
                MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")

                'Throw New Exception(ex.Message)
                Return -1
            Finally

            End Try
        End Function

        Public Shared Function GrabarSubtipoLibertad(ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Registro.ExpedienteLibertadSubtipo) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_lib_subtip_id", SqlDbType.Int)).Value = objIntExp.Codigo
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.ExpedienteId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                            .Parameters.Add(New SqlParameter("@int_exp_itn", SqlDbType.Bit)).Value = objIntExp.Internamiento
                            .Parameters.Add(New SqlParameter("@tip_aut_jud_id", SqlDbType.Int)).Value = objIntExp.TipoAutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = objIntExp.AutoridadJudicialID

                            .Parameters.Add(New SqlParameter("@int_exp_sec", SqlDbType.VarChar, 200)).Value = objIntExp.ExpedienteSecretario
                            .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 120)).Value = objIntExp.ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@int_exp_fec_doc_rcp", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFechaDocRecepcion
                            .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFecha

                            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objIntExp.CreaDocJudicialId
                            .Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = objIntExp.ExpedienteVisible

                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = objIntExp.LibertadTipoID
                            .Parameters.Add(New SqlParameter("@subtip_lib_id", SqlDbType.Int)).Value = objIntExp.LibertadSubTipoID

                            .Parameters.Add(New SqlParameter("@int_exp_est", SqlDbType.VarChar, 500)).Value = objIntExp.Estado
                            .Parameters.Add(New SqlParameter("@int_sen_pad", SqlDbType.Bit)).Value = objIntExp.int_sen_pad

                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objIntExp.FlagTransferenciaSede


                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objIntExp._RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objIntExp._PenalId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
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

        Public Shared Function EliminarQuedaExp(ByVal accion As String, ByVal opcion As String, Exp_Jud_Id As Integer) As Integer
            '16-05-2014, version grabar con entity
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)

                        With sqlCmd
                            .CommandTimeout = 50
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = Exp_Jud_Id

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As SqlException
                Dim i As Integer
                Dim MensajeError As String
                MensajeError = "No determinado."
                For i = 0 To ex.Errors.Count - 1
                    MensajeError = ("Error #" & i.ToString() & vbCrLf _
                                & "Mensaje: " & ex.Errors(i).Message & ControlChars.NewLine _
                                & "Linea: " & ex.Errors(i).LineNumber & ControlChars.NewLine _
                                & "Fuente: " & ex.Errors(i).Source & ControlChars.NewLine _
                                & "Procedimiento: " & ex.Errors(i).Procedure & ControlChars.NewLine _
                                & "Recomendación: Volver a ejecutar el Proceso.")
                Next i
                MsgBox(MensajeError, 64, "Sistema de Internos Penitenciario")
                'Throw New Exception(ex.Message)
                Return -1
            Finally
            End Try
        End Function


#End Region

#Region "reg_doc_jucial_expediente"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEntity As Entity.Registro.ExpedienteLibertadSubtipo) As SqlDataReader

            'jmondalgo-28.08.2015

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEntity.ExpedienteId
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntity.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntity.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEntity.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEntity.CreaDocJudicialId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region
    End Class

End Namespace
