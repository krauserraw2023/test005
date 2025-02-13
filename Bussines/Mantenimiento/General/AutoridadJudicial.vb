Imports System.Data.SqlClient

Namespace Mantenimiento
    Public Class AutoridadJudicial
        Private objEnt As Entity.General.Parametrica = Nothing
#Region "Functions"

        Public Function validarEstadoDistiroJudicial(idDistritoJudicial As Integer, ByRef mensajeOut As String) As Boolean

            Dim value As Boolean = True

            objEnt = New Entity.General.Parametrica
            objEnt = Listar(idDistritoJudicial)

            If objEnt.estado = 0 Then 'estado inactivo del distrito judicial
                mensajeOut = "El distrito Judicial seleccionado se encuentra en estado inactivo, seleccione otro."
                value = False
            End If

            Return value
        End Function
        Public Function getCodigo(codigo As Integer) As String

            Dim value As String = ""
            objEnt = New Entity.General.Parametrica

            objEnt = Listar(codigo)

            If objEnt.Codigo > 0 Then
                value = objEnt.CodigoString
            End If

            Return value

        End Function
        Private Function Listar(intCodigo As Integer) As Entity.General.Parametrica

            'jmr-19.03.2018
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.General.Parametrica
            With objEntFiltro
                .Codigo = intCodigo
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.AutoridadJudicial.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.General.Parametrica
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .CodigoString = sqlDr("par_cod").ToString
                            .Nombre = sqlDr("par_nom").ToString
                            .estado = sqlDr("n_est").ToString
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
            Return objEnt

        End Function
        Public Function listarGrilla(nombre As String, estado As Short) As Entity.General.ParametricaCol

            'jmr-30.12.2021
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.General.Parametrica
            With objEntFiltro
                .Nombre = nombre
                .estado = estado
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.AutoridadJudicial.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            Dim value As New Entity.General.ParametricaCol

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.General.Parametrica
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = sqlDr("par_nom").ToString
                            .estado = sqlDr("n_est").ToString
                        End With
                        value.Add(objEnt)
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
            Return value

        End Function
#End Region
    End Class
End Namespace