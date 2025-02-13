Option Explicit On
Namespace Transferencia

    Public Class BandejaQuery
#Region "Type"
        Public Enum enmEstado
            Pendiente = 0
            Procesado = 1
        End Enum
#End Region
#Region "Grabar"

        Public Function Grabar(strCNBD_Monitoreo As String, intIDRegion As Short, intIDPenal As Short, intIDArchivoTransfer As Integer,
                               strArchivoTransferNombre As String, intArchivoTranferNumero As Integer,
                               objQuery As Dictionary(Of Short, String), ByRef strMensajeOut As String) As Boolean


            Dim value As Boolean = False
            Dim intID As Integer = -1
            Dim objEnt As Entity.Transferencia.BandejaQuery = Nothing

            For Each obj As KeyValuePair(Of Short, String) In objQuery
                objEnt = New Entity.Transferencia.BandejaQuery

                If obj.Value.Trim.Length > 5 Then

                    With objEnt
                        .IDRegion = intIDRegion
                        .IDPenal = intIDPenal
                        .IDArchivoTransfer = intIDArchivoTransfer
                        .ArchivoTransferNombre = strArchivoTransferNombre
                        .ArchivoTrasnferNumero = intArchivoTranferNumero
                        .TipoBD = obj.Key
                        .Query = obj.Value
                        .Estado = enmEstado.Pendiente
                    End With

                    intID = Grabar(strCNBD_Monitoreo, objEnt, strMensajeOut)

                    If intID > 0 Then
                        value = True
                    End If

                    If strMensajeOut.Trim.Length > 3 Then
                        value = False
                        Exit For
                    End If

                End If

            Next

            Return value

        End Function



        Private Function Grabar(strCNBD_Monitoreo As String, objEnt As Entity.Transferencia.BandejaQuery, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1

            value = Data.Transferencia.BandejaQuery.Grabar(strCNBD_Monitoreo, "ins", "ins_mant", objEnt, strMensajeOut)

            Return value
        End Function
#End Region
    End Class
End Namespace