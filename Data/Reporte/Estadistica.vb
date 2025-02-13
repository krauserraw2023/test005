Imports System.Data.SqlClient
Namespace Reporte
    Public Class Estadistica
        Private Shared strNameProcedure As String = "UP_EST_Reporte"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection,
                                      ByVal accion As String,
                                      ByVal opcion As String,
        ByVal PadinID As Integer, ByVal PenalID As Integer,
        ByVal intVersionReporte As Integer, ByVal Nacionalidad As Integer,
        ByVal InternoID As Long, ByVal IngresoID As Long,
        ByVal ExpedienteID As Long, ByVal SentenciaID As Integer,
        ByVal DelitoID As Long,
        ByVal FechaIni As Long,
        ByVal FechaFin As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 60 * 20 '20 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.BigInt)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = PadinID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@cuadro", SqlDbType.Int)).Value = intVersionReporte
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
    End Class
End Namespace