Namespace Registro.DocumentoDigital
    Public Class frmDetalleDocImg
        Public tokId As String
        Public tipReg As String
        Public numArch As String
        Public numGav As String
        Public numFic As String

        Private Sub frmDetalleDocImg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim ls_url As String = ""
            Dim root_visor As String = ""

            root_visor = APPWebService.PathURL.wsVisorDocumentosDigitalizados

            ls_url = root_visor & "home/DetalleDocDig" + "?TocId=" + tokId + "&tipReg=" + tipReg + "&numArch=" + numArch + "&numGav=" + numGav + "&numFic=" + numFic

            WebBrowser1.Navigate(ls_url)

        End Sub
    End Class
End Namespace