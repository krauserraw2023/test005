Imports ScanAPIHelper
Public Class IdentificarDispositivo
    Private m_hDevice As Device    

#Region "Funciones"
    Public Function IdentificarDispositivo() As Type.Enumeracion.enumTipoDispositivo

        Dim value As Type.Enumeracion.enumTipoDispositivo = Type.Enumeracion.enumTipoDispositivo.RealScanG1

        Dim strNombreDispo As String = ""

        Dim objIden As New IdentificarDispositivo
        strNombreDispo = objIden.IniciarDispositivoFutronic()

        If strNombreDispo = "FS10" Then
            value = Type.Enumeracion.enumTipoDispositivo.FutronicFS10
        End If
        If strNombreDispo = "FS88H" Then
            value = Type.Enumeracion.enumTipoDispositivo.FutronicFS88H
        End If
        Return value

    End Function
#End Region

#Region "FS10"
    Public Function IniciarDispositivoFutronic() As String

        Dim value As String = ""
        Try
            m_hDevice = New Device()
            m_hDevice.Open()
            Dim dinfo As DeviceInfo = m_hDevice.Information

            Select Case (dinfo.DeviceCompatibility)
                Case 0
                    value = "FS80"

                Case 1
                    value = "FS80"

                Case 4
                    value = "FS80"

                Case 11
                    value = "FS80"

                Case 5
                    value = "FS88"

                Case 7
                    value = "FS50"
                Case 8
                    value = "FS60"
                Case 9
                    value = "FS25"

                Case 10
                    value = "FS10"
                Case 13
                    value = "FS80H"

                Case 14
                    value = "FS88H"

                Case 15
                    value = "FS64"
                Case 16
                    value = "FS26E"
                Case 17
                    value = "FS80HS"
                Case 18
                    value = "FS26"

                Case 20
                    value = "FS26EU"

                Case Else
                    value = "Dispositivo desconocido Futronic"
            End Select

            m_hDevice.InvertImage = True

        Catch ex As ScanAPIException
            If m_hDevice IsNot Nothing Then
                m_hDevice.Dispose()
                m_hDevice = Nothing
                value = "Dispositivo desconocido Futronic"
            End If
        End Try

        If Not m_hDevice Is Nothing Then
            m_hDevice.Dispose()
            m_hDevice = Nothing
        End If
        
        Return value

    End Function

#End Region
End Class
