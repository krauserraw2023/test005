Imports System.Windows.Forms
Namespace Tratamiento.AfiliacionSIS
    Public Class frmReniec
#Region "Propiedades_Publicas"
        Public objPersona As New APPWebService.ws_reniec_sede.NumeroDocumento
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
        Private Property ApePaterno() As String
            Get
                Return Me.txtPrimerApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value
            End Set
        End Property
        Private Property ApeMaterno() As String
            Get
                Return Me.txtSegundoApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApellido.Text = value
            End Set
        End Property
        Private Property ApellidoCasada() As String = ""
        Private Property Nombres() As String
            Get
                Return Me.txtPrenombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrenombres.Text = value
            End Set
        End Property
        Private intSexoID As Integer = -1
        Private Property SexoID() As Integer
            Get
                Return intSexoID
            End Get
            Set(ByVal value As Integer)
                intSexoID = value
                If SexoID = 1 Then
                    SexoNom = "MASCULINO"
                ElseIf SexoID = 2 Then
                    SexoNom = "FEMENINO"
                Else
                    SexoNom = ""
                End If
            End Set
        End Property
        Private Property SexoNom() As String
            Get
                Return Me.txtSexo.Text
            End Get
            Set(ByVal value As String)
                Me.txtSexo.Text = value
                If Len(txtSexo.Text) > 0 Then
                    Me.txtSexo.Text = Mid(txtSexo.Text, 1, 3)
                End If
            End Set
        End Property
        Private Property FechaNacimiento() As String
            Get
                Return Me.txtfechanac.Text
            End Get
            Set(ByVal value As String)
                Me.txtfechanac.Text = value
            End Set
        End Property
        Private Property EstadoCivilID As Integer = -1
        Private Property EstadoCivilNom As String
            Get
                Return Me.txtEstadoCivil.Text
            End Get
            Set(ByVal value As String)
                Me.txtEstadoCivil.Text = value
            End Set
        End Property
        Private Property NacimientoUbigeo() As String
            Get
                Return Me.txtUbigeoNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoNacimiento.Text = value
            End Set
        End Property
        Private Property Ubigeo() As String
            Get
                Return Me.txtUbigeo.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeo.Text = value
            End Set
        End Property
        Private Property DireccionUbigeo() As String
            Get
                Return Me.txtUbigeoDireccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoDireccion.Text = value
            End Set
        End Property
        Private Property Padre() As String
            Get
                Return Me.txtPadre.Text
            End Get
            Set(ByVal value As String)
                Me.txtPadre.Text = value
                Me.txtPadre.CharacterCasing = CharacterCasing.Upper
            End Set
        End Property
        Private Property Madre() As String
            Get
                Return Me.txtMadre.Text
            End Get
            Set(ByVal value As String)
                Me.txtMadre.Text = value
                Me.txtMadre.CharacterCasing = CharacterCasing.Upper
            End Set
        End Property

        Private Property GradoInstruccionID As Integer = -1

        Private Function NombreEstadoCivil(EstadoCivID As Integer) As String
            Dim strNombre As String = ""
            ' valores         -1= no se parecen,0=iguales
            Select Case EstadoCivID
                Case 1
                    strNombre = "SOLTERO"
                Case 2
                    strNombre = "CASADO"

                Case 3
                    strNombre = "VIUDO"

                Case 4
                    strNombre = "DIVORCIADO"
            End Select
            Return strNombre
        End Function
#End Region
#Region "Listar"
        Private Sub Listar()
            With objPersona
                Me.NumeroDni = .NumeroDNI
                Me.DigitoVerificacion = .DigitoVerificacion
                Me.ApePaterno = .ApellidoPaterno
                Me.ApeMaterno = .ApellidoMaterno
                Me.Nombres = .Nombres
                Me.FechaNacimiento = .FechaNacimiento
                Me.SexoID = .Sexo
                Me.NacimientoUbigeo = .DepartamentoNacimiento.Trim & "/" & .ProvinciaNacimiento.Trim & "/" & .DistritoNacimiento.Trim
                Me.Ubigeo = .DepartamentoDomicilio.Trim & "/" & .ProvinciaDomicilio.Trim & "/" & .DistritoDomicilio.Trim
                Me.DireccionUbigeo = Trim(.PrefijoDireccion) & " " & Trim(.Direccion) & " " & Trim(.NumeroDireccion) _
                              & " " & Trim(.BlockChalet) & " " & Trim(.Interior) & " " & Trim(.Urbanizacion) _
                             & " " & Trim(.Etapa) & " " & Trim(.Manzana) & " " & Trim(.Lote) _
                             & " " & Trim(.PrefijoBlockChalet) & " " & Trim(.PrefijoDepartamentoInterior) & " " & Trim(.PrefijoUrbanizacion)
                Me.EstadoCivilNom = NombreEstadoCivil(.EstadoCivil)
                Me.GradoInstruccionID = .CodigoGradoInstruccion
                Me.Padre = .NombrePadre
                Me.Madre = .NombreMadre
                Me._ShowFotoVisitante_Byte(.FotoByte)
            End With
        End Sub
        Public Sub _ShowFotoVisitante_Byte(objByte As Byte())

            Me.picFoto.Image = Legolas.Components.Archivo.FileByteConvertImagen(objByte)
            ' Me.picFoto.SizeMode = PictureBoxSizeMode.Zoom

        End Sub
#End Region



        Private Sub UscListaReniec1__CerrarFormulario()
            Me.Close()
        End Sub


       

        Private Sub btnOk2_Click(sender As System.Object, e As System.EventArgs)
            'AGrabar()
        End Sub

        Private Sub UscListaReniec31__Click_Cancelar()
            Me.Close()
        End Sub



        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub


        Private Sub frmReniec_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Listar()
        End Sub

        Private Sub frmReniec_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace