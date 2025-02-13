Imports System.Data
Imports System.Data.SqlClient


Namespace Panel
    Public Class Registro

        Public Shared Function LoadDataPanel1(ByVal vopcion As String, ByVal vdatedesde As Long, ByVal vdatahasta As Long, _
         ByVal vRegionId As Integer, ByVal vPenalId As Integer) As DataSet

            Dim sqlCOnn As New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            sqlCOnn.Open()
            Dim _strprocedure As String = "up_panel_1"


            Dim sqlcmd As New SqlCommand(_strprocedure, sqlCOnn)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.Add("@ing_dsd", SqlDbType.BigInt).Value = vdatedesde
            sqlcmd.Parameters.Add("@ing_hst", SqlDbType.BigInt).Value = vdatahasta
            sqlcmd.Parameters.Add("@reg_id", SqlDbType.Int).Value = vRegionId
            sqlcmd.Parameters.Add("@pen_id", SqlDbType.Int).Value = vPenalId
            sqlcmd.Parameters.Add("@opcion", SqlDbType.VarChar, 20).Value = vopcion


            Dim sqlda As New SqlDataAdapter(sqlcmd)

            Dim ds As New DataSet("Panel")
            sqlda.Fill(ds)


            Return ds
        End Function

    End Class
End Namespace

