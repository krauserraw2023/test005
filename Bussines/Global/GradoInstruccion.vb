Imports System.Data
Imports System.Data.SqlClient
Namespace Globall
    Public Class GradoInstruccion
        Private objEntGrado As Entity.Globall.GradoInstruccion = Nothing

        ''' <summary>
        ''' Retorna el nombre de grado de instruccion de acuerdo al id de la reniec
        ''' </summary>
        ''' <param name="CodigoGradInsRENIEC"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ListarNombreGradoReniec(CodigoGradInsRENIEC As Integer) As String
            Dim EntRnc As New Entity.Globall.GradoInstruccion

            EntRnc.Codigo = 0
            EntRnc.CodigoRnc = CodigoGradInsRENIEC
            EntRnc = Listar(EntRnc)
            If EntRnc Is Nothing Then
                Return ""
            End If
            Return EntRnc.Nombre
        End Function

        Public Function ListarIdGradoGradoInstruccion(CodigoGradInsRENIEC As Integer) As Integer
            Dim EntRnc As New Entity.Globall.GradoInstruccion

            EntRnc.Codigo = 0
            EntRnc.CodigoRnc = CodigoGradInsRENIEC
            EntRnc = Listar(EntRnc)
            If EntRnc Is Nothing Then
                Return ""
            End If
            Return EntRnc.Codigo
        End Function

        Public Function Listar(ObjRnc As Entity.Globall.GradoInstruccion) As Entity.Globall.GradoInstruccion
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim opcion As String = "lst_mant_rnc"
            Dim strValue As String = ""
            Dim sqlDr As SqlDataReader = Data.Globall.GradoInstruccion.Listar(sqlCon, "lst", opcion, ObjRnc)
            objEntGrado = New Entity.Globall.GradoInstruccion
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEntGrado
                            .Codigo = sqlDr("par_id").ToString
                            .CodigoRnc = sqlDr("cod_rnc").ToString
                            .Nombre = sqlDr("par_nom").ToString
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
            Return objEntGrado
        End Function



    End Class




End Namespace
