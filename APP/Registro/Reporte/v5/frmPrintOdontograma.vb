Imports System.Drawing.Imaging

Public Class frmPrintOdontograma
    Public Property _RutaImgOdont As String = ""

    Private Sub frmPrintOdontograma_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        Dim gr As Graphics = Me.CreateGraphics
        Dim fSize As Size = Me.Size
        ' Creamos el bitmap con el área que vamos a capturar
        ' En este caso, con el tamaño del formulario actual
        Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
        ' Un objeto Graphics a partir del bitmap
        Dim gr2 As Graphics = Graphics.FromImage(bm)
        ' Copiar el área de la pantalla que ocupa el formulario
        gr2.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, fSize)

        _RutaImgOdont = Legolas.Configuration.Path.PathTemp & "tmp_odont.jpg"

        bm.Save(_RutaImgOdont, ImageFormat.Jpeg)
        Me.Close()
    End Sub

End Class