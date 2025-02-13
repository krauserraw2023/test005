Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Bussines
Imports Entity

Namespace Visita.Visitante
    Public Class frmReniecLinea
        Public Enum enmTipoRespuesta As Short
            Ninguno = 0
            Omitir = 1
            Reemplazar = 2
        End Enum
#Region "Propiedades_Publicas"
        Public Property _objPersona1 As APPWebService.ws_reniec_sede.NumeroDocumento
        Public Property objPersona As New List(Of ResultReniec)
#End Region
#Region "Propiedades_Return"
        Public Property _HayRestriccion As Boolean = False
        Public Property _TipoRespuesta As enmTipoRespuesta = enmTipoRespuesta.Ninguno
#End Region
#Region "Propiedades"
        Private Property NumeroDni() As String
            Get
                Return Me.txtDni.Text
            End Get
            Set(ByVal value As String)
                Me.txtDni.Text = value
            End Set
        End Property
        Private Property DigitoVerificacion() As String
            Get
                Return Me.txtDigitoVeri.Text
            End Get
            Set(ByVal value As String)
                Me.txtDigitoVeri.Text = value
            End Set
        End Property
        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtPrimerApellido.Text()
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtSegundoApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApellido.Text = value
            End Set
        End Property
        Private Property ApellidoCasada() As String
            Get
                Return Me.txtApellidoCasada.Text
            End Get
            Set(ByVal value As String)
                Me.txtApellidoCasada.Text = value
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
        Private Property SexoID() As Integer = -1
        Private Property SexoNom() As String
            Get
                Return Me.txtSexo.Text
            End Get
            Set(ByVal value As String)
                Me.txtSexo.Text = value
            End Set
        End Property

        Private Property FechaNacimiento() As String
            Get
                Return Me.txtFechaNac.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaNac.Text = value
            End Set
        End Property
        Private Property FechaNacimientoLong As Long = 0

        Private Property Restriccion() As String
            Get
                Return Me.txtRestriccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRestriccion.Text = value
            End Set
        End Property
        Public Property FotoByte() As Byte() = Nothing

#End Region
#Region "Propieades_Otros"
        Private Property OrigenNumeroDocumento As String = ""
        Private Property OrigenPrimerApellido As String = ""
        Private Property OrigenSegundoApellido As String = ""
        Private Property OrigenPreNombres As String = ""
        Private Property OrigenIDSexo As Integer = -1
        Private Property OrigenFechaNacimiento As Long = 0
#End Region
#Region "Funcion"
        Public Sub _DatosOrigen(strNumeroDocumento As String, strPrimerApellido As String,
                                         strSegundoApellido As String,
                                         strPreNombres As String, intSexo As Short, lngFechaNacimiento As Long)

            Me.OrigenNumeroDocumento = strNumeroDocumento.Trim
            Me.OrigenPrimerApellido = strPrimerApellido
            Me.OrigenSegundoApellido = strSegundoApellido.Trim
            Me.OrigenPreNombres = strPreNombres.Trim
            Me.OrigenIDSexo = intSexo
            Me.OrigenFechaNacimiento = lngFechaNacimiento

        End Sub
        Private Sub CalcularFechaNacimientoLong()

            Dim value As Long = 0

            'calcular fecha de nacimiento                
            If Me.FechaNacimiento.Length > 8 Then
                Me.FechaNacimientoLong = Legolas.Components.FechaHora.FechaLong(Me.FechaNacimiento)
            End If

        End Sub
#End Region
#Region "Accion"
        Private Sub ListarDatos()

            With objPersona.Item(0)
                Me.NumeroDni = .numeroDNI
                Me.DigitoVerificacion = .digitoVerificacion.Trim
                Me.ApellidoPaterno = .apellidoPaterno.Trim
                Me.ApellidoMaterno = .apellidoMaterno.Trim
                Me.ApellidoCasada = .apellidoCasada.Trim
                Me.Nombres = .nombres.Trim
                Me.SexoID = IIf(.sexo.Trim = "", -1, .sexo.Trim)
                Me.SexoNom = IIf(Me.SexoID = "1", "MASCULINO", "FEMENINO")
                Me.FechaNacimiento = .fechaNacimiento.Trim
                CalcularFechaNacimientoLong()
                Dim imageBytes As Byte() = Convert.FromBase64String(.fotoByte)
                Me.FotoByte = imageBytes

                'Me.Restriccion = IIf(.Restriccion = "  ", "NINGUNA", .Restriccion.Trim)             
                Me.Restriccion = .restriccionMensaje.Trim
            End With

            '/*calcular edad*/
            Dim lngFechaHoy As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            Dim intEdad As Integer = Legolas.Components.FechaHora.FechaCalcularAnio(Me.FechaNacimientoLong, lngFechaHoy, True)
            Me.FechaNacimiento = Me.FechaNacimiento & " - " & intEdad & " Años"

            Me.picFoto.Image = Legolas.Components.Archivo.FileByteConvertImagen(Me.FotoByte)

            MostrarDiferencias()

        End Sub

#End Region
#Region "Otros"
        Private Function ValidarRestrinccion() As Boolean

            Dim value As Boolean = False
            Dim strMensaje As String = ""

            'validar si el visitante esta fallecido
            If Me.Restriccion.Trim.ToUpper = "FALLECIMIENTO".ToUpper Then
                strMensaje = "Los datos del Visitante tienen la restriccion [" & Me.Restriccion & "]. Por ello no se puede continuar con el proceso."
                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensaje)
                Return value
            End If

            value = True
            Return value
        End Function
        Private Sub MostrarDiferencias()

            Dim blnDifApePat As Boolean = False
            Dim blnDifApeMat As Boolean = False
            Dim blnDifNom As Boolean = False

            If Me.NumeroDni <> Me.OrigenNumeroDocumento Then
                Me.txtDni.BackColor = Color.IndianRed
            End If

            If Me.ApellidoPaterno <> Me.OrigenPrimerApellido Then
                Me.txtPrimerApellido.BackColor = Color.IndianRed
                blnDifApePat = True
            End If

            If Me.ApellidoMaterno <> Me.OrigenSegundoApellido Then
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

            If Me.FechaNacimientoLong <> Me.OrigenFechaNacimiento Then
                Me.txtFechaNac.BackColor = Color.IndianRed
            End If

            If Me.SexoID <> Me.OrigenIDSexo Then
                Me.txtSexo.BackColor = Color.IndianRed
            End If

            If Me.Restriccion.Trim <> "" Then
                Me.txtRestriccion.BackColor = Color.IndianRed
                Me._HayRestriccion = True
            End If

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

        Private Sub frmReniecLinea_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarDatos()

        End Sub

        Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click

            If ValidarRestrinccion() = False Then
                Exit Sub
            End If

            Dim strMensaje As String = "Esta seguro de continuar con el Proceso de Visita, recuerde que los datos no coinciden en su totalidad. Se realizará registros de auditoria por esta operacion"
            strMensaje = strMensaje & Chr(13) & "Haga clic en el boton [SI] para continuar"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                Me._TipoRespuesta = enmTipoRespuesta.Omitir
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End Sub

        Private Sub btnReemplazar_Click(sender As Object, e As EventArgs) Handles btnReemplazar.Click

            If ValidarRestrinccion() = False Then
                Exit Sub
            End If

            Dim strMensaje As String = "Esta seguro de reemplazar los datos del visitante con los datos del Servicio de Reniec. No se podra editar los datos del visitante."
            strMensaje = strMensaje & Chr(13) & "Haga clic en el boton [SI] para continuar"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                Me._TipoRespuesta = enmTipoRespuesta.Reemplazar
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
    End Class
End Namespace