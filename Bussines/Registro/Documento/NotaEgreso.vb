Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.Documento
    Public Class NotaEgreso
        Private objEnt As Entity.Registro.Documento.NotaEgreso = Nothing
        Private objEntCol As Entity.Registro.Documento.NotaEgresoCol = Nothing

#Region "Grabar"
        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal DocumentoJudicialID As Integer, _
        ByVal InternoID As Integer, _
        ByVal IngresoID As Integer, _
        ByVal ExpedienteID As Integer, _
        ByVal EgresoTipo As Integer, _
        ByVal EgresoFecha As Long, _
        ByVal Observacion As String, ByVal _RegionID As Integer, ByVal _PenalID As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Documento.NotaEgreso.Grabar(strAccion, strOpcion, Codigo, _
            DocumentoJudicialID, _
            InternoID, _
            IngresoID, _
            ExpedienteID, _
            EgresoTipo, _
            EgresoFecha, _
            Observacion, _RegionID, _PenalID, _
            Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)

            Return intValue
        End Function
#End Region

    End Class
End Namespace