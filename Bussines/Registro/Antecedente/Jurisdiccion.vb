Namespace Registro.Antecedente
    Public Class Jurisdiccion

        Public Function ComboAmbitoJurisdiccion(blnAmbitoPenal As Boolean, Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable

            Dim objDT As New DataTable("AmbitoJurisdiccion")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If

            If blnAmbitoPenal = True Then
                objDT.Rows.Add(New Object() {Type.Enumeracion.AntecedenteJudicial.enmAmbitoJurisdiccionAutJud.Penal, "Penal"})
            Else
                objDT.Rows.Add(New Object() {Type.Enumeracion.AntecedenteJudicial.enmAmbitoJurisdiccionAutJud.Lima, "Lima"})
                objDT.Rows.Add(New Object() {Type.Enumeracion.AntecedenteJudicial.enmAmbitoJurisdiccionAutJud.Callao, "Callao"})
                objDT.Rows.Add(New Object() {Type.Enumeracion.AntecedenteJudicial.enmAmbitoJurisdiccionAutJud.Lima_Y_Callao, "Lima y Callao"})
            End If

            objDT.AcceptChanges()

            Return objDT

        End Function

    End Class

End Namespace
