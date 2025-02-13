Namespace Foto
    Public Class frmCamaraWebPopup
#Region "Propiedades"
        Private strPathFile As String = ""
        Private strFileName As String = ""
        Public Property _pPathFile() As String
            Get
                Return strPathFile
            End Get
            Set(ByVal value As String)
                strPathFile = value
            End Set
        End Property
        Public Property _pFileName() As String
            Get
                Return strFileName
            End Get
            Set(ByVal value As String)
                strFileName = value
            End Set
        End Property
        Private ReadOnly Property PathFileName() As String
            Get
                Dim value As String = ""
                value = Me._pPathFile & Me._pFileName & "xyz" & ".jpg"
                Return value
            End Get
        End Property
        Private ReadOnly Property PathFileNameRecortada() As String
            Get
                Dim value As String = ""
                value = Me._pPathFile & Me._pFileName & ".jpg"
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Return"
        Public ReadOnly Property _PathFileName() As String
            Get
                Return Me.PathFileNameRecortada
            End Get
        End Property
#End Region
#Region "Accion"
        Private Sub ACapturarImagen()

            Me.Cursor = Cursors.WaitCursor

            Me.PicResultado.Image = WebCam1.Imagen 'Pasa una muestra al PictureBox para ver el resultado

            Me.PicResultado.Image.Save(Me.PathFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Me.PictureBox1.Image = Me.PicResultado.Image

            'limpiar la ddl cam            
            Me.WebCam1.Stop()
            Me.WebCam1 = Nothing

            If Legolas.Components.Archivo.FileExiste(Me.PathFileName) = True Then

                Dim imagen2 As New Bitmap(Me.AnchoPrede, Me.AltoPrede)
                Dim lienzo As Graphics = Graphics.FromImage(imagen2)
                Dim recorte As Rectangle = New Rectangle(Me.PosX, Me.PosY, Me.AnchoPrede, Me.AltoPrede)

                lienzo.DrawImage(Me.PicResultado.Image, 0, 0, recorte, GraphicsUnit.Pixel)
                imagen2.Save(PathFileNameRecortada, Imaging.ImageFormat.Jpeg)

                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Se encontraron problemas al capturar la imagen, intente nuevamente")
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If

            Me.Cursor = Cursors.Default

        End Sub
#End Region
#Region "Propiedades_Otros"
        Private ReadOnly Property AnchoPrede() As Integer
            Get
                Return 339
            End Get
        End Property
        Private ReadOnly Property AltoPrede() As Integer
            Get
                Return 452
            End Get
        End Property
        Private ReadOnly Property PosX() As Integer
            Get
                Return 99
            End Get
        End Property
        Private ReadOnly Property PosY() As Integer
            Get
                Return 0
            End Get
        End Property
#End Region
        Private Sub ButMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            ACapturarImagen()

        End Sub

        Private Sub ButDetener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Me.WebCam1.Stop()  'Simplemente detiene la camara y deja los últimos fotogramas      
            Me.Close()

        End Sub


        Private Sub ButConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            WebCam1.Configuracion() 'Abre una pantalla de configuracion de la webcam

        End Sub

        Private Sub frmCamaraWebPopup_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

            Try
                Me.WebCam1.Stop()
            Catch ex As Exception

            End Try

        End Sub

        Private Sub frmCamaraWebPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.Timer1.Enabled = True

        End Sub

        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


            Me.WebCam1.Start() 'Activa la WebCam
            Me.Timer1.Enabled = False

        End Sub


        Private Sub WebCam1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WebCam1.KeyDown

            e.Handled = False

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click

            ACapturarImagen()

        End Sub
    End Class
End Namespace
