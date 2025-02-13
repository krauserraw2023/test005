Imports System.Data.SqlClient
Namespace Reporte
    Public Class Tratamiento
        Private Shared strNameProcedure As String = "UP_INT_Reporte"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, _
                                      ByVal accion As String, _
                                      ByVal opcion As String, _
        ByVal PenalID As Integer, _
        ByVal Cuadro2 As Integer, ByVal Nacionalidad As Integer, _
        ByVal InternoID As Long, ByVal IngresoID As Long, _
        ByVal ExpedienteID As Long, ByVal SentenciaID As Integer, _
        ByVal DelitoID As Long, _
        ByVal FechaIni As Long, _
        ByVal FechaFin As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.BigInt)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    '.Parameters.Add(New SqlParameter("@cuadro", SqlDbType.Int)).Value = Cuadro2
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = Nacionalidad
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = FechaIni
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = FechaFin

                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.BigInt)).Value = IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.BigInt)).Value = ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_sen_id", SqlDbType.BigInt)).Value = SentenciaID
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.BigInt)).Value = DelitoID

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal accion As String, ByVal opcion As String, RptCabeceraId As Integer) As DataTable
            Dim t As New DataTable

            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                    With sqlCmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                        .Parameters.Add(New SqlParameter("@pk_rpt_cab_id", SqlDbType.Int)).Value = RptCabeceraId
                        sqlCon.Open()
                        t.Load(sqlCmd.ExecuteReader(CommandBehavior.CloseConnection))
                    End With
                End Using
            End Using

            Return t
        End Function
        '/*Asistencia*/
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, _
                                      ByVal accion As String, ByVal opcion As String, ent As Entity.Reporte.Registro.Filtro) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.BigInt)).Value = ent.InternoID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = ent.PenalID
                    '.Parameters.Add(New SqlParameter("@cuadro", SqlDbType.Int)).Value = Cuadro2
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = -1
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = ent.FechaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = ent.FechaFin

                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.BigInt)).Value = ent.InternoIngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.BigInt)).Value = -1
                    .Parameters.Add(New SqlParameter("@int_sen_id", SqlDbType.BigInt)).Value = -1
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.BigInt)).Value = -1
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace

