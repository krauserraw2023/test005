Imports System.IO
Namespace Seguridad.Modulo
    Public Class frmMantPopup
        Private objBss As Legolas.LBusiness.Seguridad.Modulo = Nothing
#Region "Propiedades"
        Public Property Codigo() As Integer=-1            
        Private Property ModuloNivel() As Integer
            Get
                Return Me.nudNivel.Value
            End Get
            Set(ByVal value As Integer)

                If value < 0 Then
                    value = 0
                End If

                Me.nudNivel.Value = value
            End Set
        End Property
        Public Property CodigoPadre() As Integer=0            
        Private Property RutaIcono() As String
            Get
                Return Me.txtRuta.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtRuta.Text = value
            End Set
        End Property
        Private Property Nombre() As String
            Get
                Return Me.txtTitulo.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtTitulo.Text = value
            End Set
        End Property
        Private Property Objeto() As String
            Get
                Return Me.txtObjeto.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObjeto.Text = value
            End Set
        End Property
        Private Property Icono() As Byte()
            Get
                Try
                    Dim bmp As Bitmap = Me.PictureBox1.Image

                    Dim ms As MemoryStream = New MemoryStream()
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

                    Dim bmpBytes() As Byte = ms.GetBuffer()
                    bmp.Dispose()
                    ms.Close()

                    Return bmpBytes
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
            Set(ByVal value As Byte())

                If IsNothing(value) = False Then
                    If value.Length > 0 Then
                        Dim ms As New MemoryStream(value)
                        PictureBox1.Image = Image.FromStream(ms)
                    Else
                        PictureBox1.Image = My.Resources.windows
                        'PictureBox1.Image = Nothing
                    End If
                Else
                    PictureBox1.Image = My.Resources.windows
                    'PictureBox1.Image = Nothing
                End If

            End Set
        End Property
        Private Property NumOrden() As Integer
            Get
                Dim intValue As Integer

                If IsNumeric(Me.txtOrden.Text) Then
                    intValue = Integer.Parse(Me.txtOrden.Text)
                Else
                    intValue = 999
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Me.txtOrden.Text = value.ToString
            End Set
        End Property
        Private Property Activo() As Boolean
            Get
                Return Me.chkActivo.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkActivo.Checked = value
            End Set
        End Property
        Public Property HasSubModulo() As Boolean
            Get
                Return Me.chkSubmodulo.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkSubmodulo.Checked = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Legolas.LBusiness.Seguridad.Modulo
            Dim objEnt As New Legolas.LEntity.Seguridad.Modulo

            objEnt = objBss.Listar(Me.Codigo)

            If Not objEnt Is Nothing Then
                With objEnt
                    'Me.Codigo = .Codigo '
                    Me.ModuloNivel = .Nivel
                    Me.CodigoPadre = .CodigoPadre '
                    Me.Nombre = .Nombre '
                    Me.Objeto = .Objecto '
                    Me.Icono = .Icono '
                    Me.NumOrden = .Orden '
                    Me.Activo = .Activo
                    Me.HasSubModulo = .HasSeccion
                End With
            End If

        End Sub
#End Region
#Region "Accion"
        Private Sub AGrabar()

            objBss = New Legolas.LBusiness.Seguridad.Modulo
            Dim intCodigo As Integer = -1

            intCodigo = objBss.Grabar(Me.Codigo, Me.ModuloNivel, Me.HasSubModulo, Me.CodigoPadre, _
            Me.RutaIcono, Me.Nombre, _
            Me.Objeto, Me.Icono, Me.NumOrden, Me.Activo)

            If intCodigo > 0 Then

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

        End Sub
#End Region

        Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click

            'ofdPhoto.Filter = "Image Files(*.ICO; *.BMP;*.JPG;*.GIF)|*.ICO;*.BMP;*.JPG;*.GIF"
            ofdPhoto.Filter = "Image Files(*.PNG)|*.PNG|Image JPEG(*.JPG)|*.JPG"

            'dialog.Filter = "Documento Word|*.doc|Documento Excel|*.xls|" _
            '           & "Documento PDF |*.pdf|Documento Word 2007|*.docx|Documento Excel 2007|*.xlsx" _
            '           & "|Imagen JPG|*.jpg|Imagen TIF|*.tif"

            ofdPhoto.Title = "Seleccione Imagen..."

            If ofdPhoto.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.PictureBox1.Image = Image.FromFile(ofdPhoto.FileName)
            End If

        End Sub



        Private Sub frmMantPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmMantPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()

        End Sub

       
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub
    End Class
End Namespace


