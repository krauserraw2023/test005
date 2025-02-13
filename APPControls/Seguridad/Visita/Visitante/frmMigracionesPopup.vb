Imports System.Windows.Forms
Namespace Visita.Visitante
    Public Class frmMigracionesPopup
        Public Enum enmTipoRespuesta As Short
            Ninguno = 0
            Omitir = 1
            Reemplazar = 2
        End Enum
#Region "Propiedades_Publicas"
        Public Property _objVisitanteServicio As APPWebService.Result.ConsultarExtranjero
#End Region
#Region "Propiedades_Return"
        Public Property _HayRestriccion As Boolean = False
        Public Property _TipoRespuesta As enmTipoRespuesta = enmTipoRespuesta.Ninguno
#End Region
#Region "Propiedades"
        Private Property IDTipoDocumento As Short = -1
        Private Property TipoDocumento() As String
            Get
                Return Me.txtTipoDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtTipoDoc.Text = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property PrimerApellido() As String
            Get
                Return Me.txtPrimerApellido.Text()
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value
            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtSegundoApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApellido.Text = value
            End Set
        End Property
        Private Property IDNacionalidad As Integer = -1
        Private Property Nacionalidad() As String
            Get
                Return Me.txtNacionalidad.Text
            End Get
            Set(ByVal value As String)
                Me.txtNacionalidad.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtPrenombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrenombres.Text = value
            End Set
        End Property
        Private Property IDSexo() As Integer = -1
        Private Property SexoNombre() As String
            Get
                Return Me.txtSexo.Text
            End Get
            Set(ByVal value As String)
                Me.txtSexo.Text = value
            End Set
        End Property
        Private Property FechaNacimientoLong As Long = 0
        Private Property FechaNacimiento() As String
            Get
                Return Me.txtFechaNac.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaNac.Text = value
            End Set
        End Property
        Private Property CalidadMigratoria As String
            Get
                Return Me.txtCalidadMigra.Text
            End Get
            Set(value As String)
                Me.txtCalidadMigra.Text = value
            End Set
        End Property
#End Region
#Region "Propieades_Otros"
        Private Property Origen_IDTipoDocumento As Short = -1
        Private Property OrigenNumeroDocumento As String = ""
        Private Property OrigenPrimerApellido As String = ""
        Private Property OrigenSegundoApellido As String = ""
        Private Property OrigenPreNombres As String = ""
        Private Property OrigenIDSexo As Integer = -1
        Private Property OrigenFechaNacimiento As Long = 0
        Private Property OrigenIDNacionalidad As Integer = -1
#End Region
#Region "Funcion"
        Public Sub _DatosOrigen(intTipoDocumento As Short, strNumeroDocumento As String, strPrimerApellido As String,
                                         strSegundoApellido As String,
                                         strPreNombres As String, intSexo As Short, lngFechaNacimiento As Long, strIDNacionalidad As Integer)

            Me.Origen_IDTipoDocumento = intTipoDocumento
            Me.OrigenNumeroDocumento = strNumeroDocumento.Trim
            Me.OrigenPrimerApellido = strPrimerApellido
            Me.OrigenSegundoApellido = strSegundoApellido.Trim
            Me.OrigenPreNombres = strPreNombres.Trim
            Me.OrigenIDSexo = intSexo
            Me.OrigenFechaNacimiento = lngFechaNacimiento
            Me.OrigenIDNacionalidad = strIDNacionalidad

        End Sub
#End Region
#Region "Accion"
        Private Sub ListarDatos()

            Dim lngFechaHoy As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong

            With _objVisitanteServicio
                Me.IDTipoDocumento = .IDTipoDocumento
                Me.TipoDocumento = .TipoDocumentoNombre
                Me.NumeroDocumento = .NumeroDocumento
                Me.PrimerApellido = .PrimerApellido
                Me.SegundoApellido = .SegundoApellido
                Me.Nombres = .Nombres.Trim
                Me.FechaNacimiento = .FechaNacimientoCadena
                Me.FechaNacimientoLong = .FechaNacimiento
                Me.IDSexo = .IDSexo
                Me.SexoNombre = .SexoCadena
                Me.Nacionalidad = .NacionalidadCadena
                Me.IDNacionalidad = .IDNacionalidad
                Me.CalidadMigratoria = .CalidadMigratoria
            End With

            '/*mostrar edad*/
            Dim intEdad As Integer = Legolas.Components.FechaHora.FechaCalcularAnio(Me._FechaNacimientoLong, lngFechaHoy, True)
            Me.FechaNacimiento = Me.FechaNacimiento & " - " & intEdad & " Años"

            Me.picFoto.Image = Legolas.Components.Archivo.FileByteConvertImagen(Me._objVisitanteServicio.FotoByte)
            MostrarDiferencias()

        End Sub
        'Private Function QuitarAcentos(strCadena As String) As String


        '    Dim tempBytes As Byte()
        '    tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(strCadena)
        '    Return System.Text.Encoding.UTF8.GetString(tempBytes)

        'End Function
#End Region
#Region "Otros"
        Private Sub MostrarDiferencias()

            Dim blnDifApePat As Boolean = False
            Dim blnDifApeMat As Boolean = False
            Dim blnDifNom As Boolean = False

            If Me.IDTipoDocumento <> Me.Origen_IDTipoDocumento Then
                Me.txtTipoDoc.BackColor = Color.IndianRed
                Me._HayRestriccion = True
            End If

            If Me.NumeroDocumento <> Me.OrigenNumeroDocumento Then
                Me.txtNumDoc.BackColor = Color.IndianRed
            End If

            If Me.PrimerApellido <> Me.OrigenPrimerApellido Then
                Me.txtPrimerApellido.BackColor = Color.IndianRed
                blnDifApePat = True
            End If

            If Me.SegundoApellido <> Me.OrigenSegundoApellido Then
                Me.txtSegundoApellido.BackColor = Color.IndianRed
                blnDifApeMat = True
            End If

            If Me.Nombres <> Me.OrigenPreNombres Then
                Me.txtPrenombres.BackColor = Color.IndianRed
                blnDifNom = True
            End If

            If blnDifApePat = True And blnDifApeMat = True And blnDifNom = True Then
                Me._HayRestriccion = True
            End If

            If Me.IDNacionalidad <> Me.OrigenIDNacionalidad Then
                Me.txtNacionalidad.BackColor = Color.IndianRed
            End If

            If Me.IDSexo <> Me.OrigenIDSexo Then
                Me.txtSexo.BackColor = Color.IndianRed
            End If

            If Me.FechaNacimientoLong <> Me.OrigenFechaNacimiento Then
                Me.txtFechaNac.BackColor = Color.IndianRed
            End If

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

        Private Sub frmReniecLinea_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarDatos()

        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

            Dim strMensaje As String = "Esta seguro de continuar con el Proceso de Visita, recuerde que los datos no coinciden en su totalidad. Se realizará registros de auditoria por esta operacion"
            strMensaje = strMensaje & Chr(13) & "Haga clic en el boton [SI] para continuar"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                Me._TipoRespuesta = enmTipoRespuesta.Omitir
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReemplazar.Click

            Dim strMensaje As String = "Esta seguro de reemplazar los datos del visitante con los datos del Servicio de Migraciones. No se podra editar los datos del visitante."
            strMensaje = strMensaje & Chr(13) & "Haga clic en el boton [SI] para continuar"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                Me._TipoRespuesta = enmTipoRespuesta.Reemplazar
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
    End Class
End Namespace