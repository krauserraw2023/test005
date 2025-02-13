
Imports Ionic.Zip
Imports System.Drawing.Imaging
Namespace Registro
    Public Class frmPrintOdontograma
        Public Property _RutaImgOdont As String = ""
        Public Property _Codigo As Integer = -1 'para la impresion del odontograma es necesario enviar antes el id del odontograma.

        Private Sub CargarOdontograma()
            If Me._Codigo = -1 Then Exit Sub

            Dim entOdnt As Entity.Registro.Odontograma.InternoOdontograma
            Dim objBss As New Bussines.Registro.Odontograma.InternoOdontograma

            entOdnt = objBss.Listar(Me._Codigo)
            If entOdnt Is Nothing Then Exit Sub

            Dim entAD As New Entity.Globall.ArchivoDigitalizado
            Dim entADCol As Entity.Globall.ArchivoDigitalizadoCol

            entAD.IdRegistroForaneo = entOdnt.Codigo
            entAD.TipoArchivoDigital = 1 'odontograma
            entADCol = (New Bussines.Globall.ArchivoDigitalizado).Listar(entAD)

            If entADCol.Count = 0 Then Exit Sub

            entAD = entADCol.Archivodigital(0)

            Dim sms As String = ""
            Dim odont As Byte()
            AxCtlOdon1.Visible = True

            odont = entAD.ArchivoDigitalByte
            If odont Is Nothing Then Exit Sub
            Dim dirTmp As String = Legolas.Configuration.Path.PathTemp & "odontograma\"


            If System.IO.Directory.Exists(dirTmp) = False Then System.IO.Directory.CreateDirectory(dirTmp)
            '-------- descomprimir -------------------------
            Dim NomArch As String = ""
            NomArch = "tmp_odont_" & Now.ToFileTime & ".rar"
            System.IO.File.WriteAllBytes(dirTmp & "\" & NomArch, odont)


            Dim z As ZipFile = ZipFile.Read(dirTmp & "\" & NomArch)
            z.ExtractAll(dirTmp, ExtractExistingFileAction.OverwriteSilently)
            z.Dispose()

            Try
                AxCtlOdon1.OpenOdontograma(dirTmp & "\" & z.Item(0).FileName)
                System.IO.Directory.Delete(dirTmp, True)
            Catch ex As Exception

            End Try
            '-------------------------------------------------
           
        End Sub

        Private Sub frmPrintOdontograma_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            CargarOdontograma()
            Me.Refresh()

            Dim gr As Graphics = Me.CreateGraphics
            Dim fSize As Size = Me.Size

            Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
            Dim gr2 As Graphics = Graphics.FromImage(bm)

            gr2.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, fSize)

            _RutaImgOdont = Legolas.Configuration.Path.PathTemp & "tmp_odont.jpg"

            bm.Save(_RutaImgOdont, ImageFormat.Jpeg)
            Me.Close()
        End Sub

    End Class
End Namespace