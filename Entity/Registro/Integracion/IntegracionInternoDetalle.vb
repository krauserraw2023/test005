Namespace Registro.Integracion
    Public Class IntegracionInternoDetalle
        Public Property Codigo As Integer = -1
        Public Property IntegracionInternoId As Integer = -1
        Public Property InternoId As Integer = -1
        Public Property Observacion As String = ""
       

        '------- auxiliar
        Public Property CodigoUnicoInternoId As Integer = -1
        Public Property CodigoUnicoInterno As String = ""
        Public Property Eliminado As Boolean = False


        '---------- propiedades axiliares rpt ---------
        Public Property InternoIdCrea As Integer = -1 'id del usuario quien crea el registro
        Public Property FechaCreacion As Long = 0
        Public Property CodigoRP As String = ""
        Public Property ApePaternoInterno As String = ""
        Public Property ApeMaternoInterno As String = ""
        Public Property NombresInterno As String = ""
        Public Property InternoRegionId As Integer = -1
        Public Property InternoPenalId As Integer = -1
        Public Property IntPenalStr As String = ""
        Public Property IntTipoNumDocIdent As String = ""

    End Class
End Namespace