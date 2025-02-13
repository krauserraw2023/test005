Imports System.Drawing
Public Class frmFoto
#Region "Propiedades"
    Private Property NombreImagen As String = ""
    Private Property PathFotoTemporal As String = Legolas.Configuration.Path.PathTemp
#End Region
#Region "Propiedades_Return"
    Public Property _PathImagenTemporal As String = ""
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
#Region "Accion"

    Private Sub ACapturarFoto()

        Me.NombreImagen = Now.ToFileTime

        If Me.NombreImagen = "" Or Me.NombreImagen.Length < 4 Then
            Exit Sub
        End If

        Dim strPath As String = Me.PathFotoTemporal & Me.NombreImagen & ".jpg"

        Me.PicResultado.Image = WebCam1.Imagen 'Pasa una muestra al PictureBox para ver el resultado

        If Me.PicResultado.Image Is Nothing Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Espere que cargue la WebCam")
            Exit Sub
        Else
            Dim imagen2 As New Bitmap(Me.AnchoPrede, Me.AltoPrede)
            Dim lienzo As Graphics = Graphics.FromImage(imagen2)
            Dim recorte As Rectangle = New Rectangle(Me.PosX, Me.PosY, Me.AnchoPrede, Me.AltoPrede)

            lienzo.DrawImage(Me.PicResultado.Image, 0, 0, recorte, GraphicsUnit.Pixel)
            imagen2.Save(strPath, Imaging.ImageFormat.Jpeg)
        End If

        'limpiar la ddl cam            
        Me.WebCam1.Stop()
        Me.WebCam1 = Nothing

        Dim blnOK As Boolean = False
        blnOK = Legolas.Components.Archivo.FileExiste(strPath)

        If blnOK = True Then
            Me._PathImagenTemporal = strPath
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
            "La fotografia no fue grabada, cierre la ventana y vuelve ha intentarlo")
            Me.Close()
        End If

    End Sub
    Public Function _EliminarArchivo(PathFotoName As String) As Boolean

        Dim value As Boolean = False

        If Legolas.Components.Archivo.FileExiste(PathFotoName) = True Then

            value = Legolas.Components.Archivo.FileDelete(PathFotoName)

        End If

        Return value

    End Function
#End Region
#Region "Otros"
    Private Sub ValoresxDefault()

    End Sub
#End Region

    Private Sub WebCam1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WebCam1.KeyDown

        e.Handled = False

    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapturar.Click

        ACapturarFoto()

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub frmFoto_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            Me.WebCam1.Stop()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmFoto_Load(sender As Object, e As System.EventArgs) Handles Me.Load


    End Sub

    Private Sub frmFoto_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown


        Me.Refresh()        
        Me.WebCam1.Start() 'Activa la WebCam

    End Sub
End Class
