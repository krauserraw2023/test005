Imports APPControlHuellaVisita.Huellero.FS10

Public Class uscAutenticacionDactilar
    Public Event _HuellaCapturado_event()

    Public Sub _CancelarCapturaHuella()
        UscValidarHuellaModelOTRO._CancelarCapturaHuella()
    End Sub
    Public Sub _IniciarCapturaHuella()
        UscValidarHuellaModelOTRO._IniciarCapturaHuella()
    End Sub
    Public Function _TieneHuellaCapturada() As Boolean
        Return UscValidarHuellaModelOTRO._TieneHuellaCapturada()
    End Function
    Public Function _getTipoDedoSelectMano() As Integer
        Return UscValidarHuellaModelOTRO._getTipoDedoSelectMano()
    End Function
    Public Function _CompararHuella(huellaUsuarioDesdeBD As Byte()) As Boolean
        Return UscValidarHuellaModelOTRO._CompararHuella(huellaUsuarioDesdeBD)
    End Function

    Public Sub setTipoDedoSel(indTipoDedoIzq As Integer, indTipoDedoDer As Integer)
        UscValidarHuellaModelOTRO.setTipoDedoSel(indTipoDedoIzq, indTipoDedoDer)
    End Sub

    Private Sub UscValidarHuellaModelOTRO__HuellaCapturado_event() Handles UscValidarHuellaModelOTRO._HuellaCapturado_event
        RaiseEvent _HuellaCapturado_event()
    End Sub
End Class
