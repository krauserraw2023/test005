Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.Carceleta.Clasificacion.InternoClasificacion
    Public Class Expediente_DA
        Private Shared strNameProcedure As String = "pa_tra_asi_mov_internoexpediente"
#Region "Listar"


        'Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As SqlDataReader
        '    Dim sqlReader As SqlDataReader = Nothing

        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Codigo
        '            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
        '            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = objIntExp.AutoridadJudicialID
        '            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = objIntExp.SalaJudicialID
        '            .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = objIntExp.ExpedienteNumero
        '            .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFecha

        '            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objIntExp.CreaDocJudicialId
        '            .Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = objIntExp.ExpedienteVisible

        '            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objIntExp.SituacionJuridicaID

        '        End With
        '        sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader
        'End Function

        'Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As SqlDataReader
        '    Dim sqlReader As SqlDataReader = Nothing

        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Codigo
        '            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
        '            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId

        '            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = objIntExp.AutoridadJudicialID
        '            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = objIntExp.SalaJudicialID
        '            .Parameters.Add(New SqlParameter("@int_ing_exp_num", SqlDbType.VarChar, 100)).Value = objIntExp.ExpedienteNumero
        '            .Parameters.Add(New SqlParameter("@int_ing_exp_fec", SqlDbType.BigInt)).Value = objIntExp.ExpedienteFecha

        '            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objIntExp.CreaDocJudicialId
        '            .Parameters.Add(New SqlParameter("@int_exp_visible", SqlDbType.Int)).Value = objIntExp.ExpedienteVisible

        '            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objIntExp.SituacionJuridicaID

        '        End With
        '        sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader
        'End Function

#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objIntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.Codigo
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
                            .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = objIntExp.FichaFinalId

                            .Parameters.Add(New SqlParameter("@int_exp_pri_sen", SqlDbType.Bit)).Value = objIntExp.SentenciaPrincipal
                            .Parameters.Add(New SqlParameter("@int_exp_pri", SqlDbType.Bit)).Value = objIntExp.Principal

                            '/*libertad*/
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = objIntExp.DistritoJudicialID
                            .Parameters.Add(New SqlParameter("@juz_id", SqlDbType.Int)).Value = objIntExp.JuzgadoID
                            .Parameters.Add(New SqlParameter("@int_exp_est", SqlDbType.VarChar, 500)).Value = objIntExp.Estado
                            .Parameters.Add(New SqlParameter("@int_sen_pad", SqlDbType.Bit)).Value = objIntExp.int_sen_pad

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objIntExp._RegioId
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
                Dim s As String = ""
                s = s
                Throw New Exception(ex.Message)
            End Try
        End Function

#End Region

#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = Codigo

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
#End Region
    End Class

End Namespace
