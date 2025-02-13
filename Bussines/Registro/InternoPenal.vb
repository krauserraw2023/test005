Namespace Registro
    Public Class InternoPenal
        Public Function Grabar(intIDInternoSede As Integer, intIDInternoPenal As Integer, intIDRegion As Short, intIDPenal As Short, intEstado As Short) As Integer

            Dim intCodigo As Integer = -1

            Dim objEntFiltro As New Entity.Registro.InternoPenal
            With objEntFiltro
                .IDInternoPenal = intIDInternoPenal
                .IDRegion = intIDRegion
                .IDPenal = intIDPenal
            End With

            intCodigo = Data.Registro.InternoPenal.ListarOutput("lst", "lst_get_codigo", objEntFiltro)

            Dim objEnt As New Entity.Registro.InternoPenal
            With objEnt
                .Codigo = intCodigo
                .IDInternoSede = intIDInternoSede
                .IDInternoPenal = intIDInternoPenal
                .IDRegion = intIDRegion
                .IDPenal = intIDPenal
                .Estado = intEstado
            End With

            intCodigo = Grabar(objEnt)

            Return intCodigo

        End Function
        Private Function Grabar(objEnt As Entity.Registro.InternoPenal) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoPenal.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function
    End Class

End Namespace
