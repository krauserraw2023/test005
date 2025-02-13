Imports System.Data
Imports System.Data.SqlClient
Namespace Registro

    Public Class InternoGrilla_Nominal

        Private Shared strNameProcedure As String = "UP_INT_Interno_Grilla"
        'Private Shared strNameProcedure As String = "UP_INT_Interno_Grilla", cambiar x nuevo procedure UP_INT_Interno_Grilla_Nominal

#Region "Listar"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String,
       ByVal opcion As String, ByVal Codigo As Integer,
       ByVal CodigoRP As String,
       ByVal ApellidoPaterno As String,
       ByVal ApellidoMaterno As String,
       ByVal Nombres As String,
       ByVal RegionID As Integer,
       ByVal PenalID As Integer, ByVal PenalMultiple As String,
       ByVal SexoID As Integer,
       ByVal NacionalidadID As Integer,
       ByVal EstadoID As Integer,
       ByVal SituacionJuridicaID As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 900
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = Nombres
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 250)).Value = PenalMultiple
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = SexoID
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = NacionalidadID
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = EstadoID
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = SituacionJuridicaID

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