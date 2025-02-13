Imports System.Data
Imports System.Data.SqlClient

Namespace General

    Public Class Ubigeo

#Region "Listar"
        Public Function Listar( _
        ByVal Opcion As String, _
        ByVal Codigo As Integer, _
        ByVal Pais As Integer, _
        ByVal Departamento As Integer, _
        ByVal Provincia As Integer, _
        ByVal Distrito As Integer, _
        ByVal Nombre As String) As Entity.General.UbigeoCol

            Dim sqlDr As SqlDataReader = Data.General.Ubigeo.Listar(Opcion, Codigo, Pais, _
            Departamento, Provincia, Distrito, Nombre)
            Dim objUbigeoCollection As Entity.General.UbigeoCol = Nothing

            Try
                If sqlDr.HasRows Then
                    objUbigeoCollection = New Entity.General.UbigeoCol

                    While sqlDr.Read
                        Dim objUbigeoEntity As New Entity.General.Ubigeo

                        With objUbigeoEntity
                            .Codigo = sqlDr("ubi_id").ToString
                            .Pais = sqlDr("ubi_pai_id").ToString
                            .Departamento = sqlDr("ubi_dep_id").ToString
                            .Provincia = sqlDr("ubi_pro_id").ToString
                            .Distrito = sqlDr("ubi_dis_id").ToString
                            .Nombre = sqlDr("ubi_nom").ToString()
                        End With

                        objUbigeoCollection.Add(objUbigeoEntity)
                    End While
                End If

            Catch ex As Exception

                Throw New Exception(ex.ToString)
            End Try

            Return objUbigeoCollection
        End Function
        
#End Region

    End Class
End Namespace