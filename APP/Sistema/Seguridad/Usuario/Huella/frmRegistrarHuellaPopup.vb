Imports System.Data.SqlClient
Imports System.Threading
Namespace Sistema.Seguridad.Usuario.Huella

    Public Class frmRegistrarHuellaPopup
        Private objBssUsuario As Bussines.Seguridad.Usuario = Nothing
        Private objEntUsuario As Entity.Sistema.Seguridad.Usuario = Nothing
        Private blnHayDatos As Boolean = False


#Region "Propiedades_Buscar"
        Private Property BuscarNumeroDNI() As String
            Get
                Return Me.txtNumDocBuscar.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDocBuscar.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades"
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtApePaterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePaterno.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Huella"
        Private Property TipoDedoDerecho As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
        Private Property TipoDedoIzquierdo As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo

        Private Property HuellaIzquierda As APPControlHuellaVisita.uscThumbFinger = Nothing
        Private Property HuellaDerecha As APPControlHuellaVisita.uscThumbFinger = Nothing
#End Region
#Region "Listar"
        Private Sub Listar()

            If objEntUsuario.Codigo > 0 Then
                With objEntUsuario
                    Me.NumeroDocumento = .NumeroDocumento.ToUpper
                    Me.ApellidoPaterno = .ApellidoPaterno.ToUpper
                    Me.ApellidoMaterno = .ApellidoMaterno.ToUpper
                    Me.Nombres = .Nombres.ToUpper
                    blnHayDatos = True
                End With

                ConsultarCalidadHuella()

            End If

        End Sub
        Private Sub ConsultarCalidadHuella()

            Dim objWS As New APPWebService.ReniecBiometria
            Dim objEnt As New APPWebService.Result.CalidadHuella

            objEnt = objWS.CalidadHuellaUsuario(Me.NumeroDocumento, Legolas.Components.PC.GetIP, Legolas.Components.PC.GetMAC(True))

            If objEnt.HayError = False Then
                Me.lblManoIzquierda.Text = objEnt.DescripcionHuellaIzquierda
                Me.lblManoDerecha.Text = objEnt.DescripcionHuellaDerecha
                Me.TipoDedoDerecho = objEnt.TipoDedoDerecho
                Me.TipoDedoIzquierdo = objEnt.TipoDedoIzquierdo
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(objEnt.ErrorMensaje)
            End If

        End Sub
#End Region

#Region "Validar"
        Private Function ValidarNumeroDocumento() As Boolean

            Dim value As Boolean = False
            Dim strMensaje As String = ""

            'validar numero de dni
            If Me.BuscarNumeroDNI.Trim.Length <> 8 Then
                strMensaje = "El numero de DNI ingresado no es valido."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Me.txtNumDocBuscar.Focus()
                Return value
            End If

            'validar numero de dni ingresado vs el dni del usuario
            Dim strNumeroDoc As String = ""
            objEntUsuario = New Entity.Sistema.Seguridad.Usuario
            objBssUsuario = New Bussines.Seguridad.Usuario

            objEntUsuario = objBssUsuario.Listar(Legolas.Configuration.Usuario.Codigo)

            strNumeroDoc = objEntUsuario.NumeroDocumento

            If Me.BuscarNumeroDNI.Trim <> strNumeroDoc Then
                strMensaje = "El numero de DNI ingresado es diferente al numero de DNI del usuario."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Me.txtNumDocBuscar.Text = ""
                Me.txtNumDocBuscar.Focus()
                Return value
            End If

            value = True
            Return value

        End Function
        Private Function Validar() As Boolean

            Dim strMensaje As String = ""
            Dim value As Boolean = False

            'validar que los datos del usuario se listen
            If blnHayDatos = False Then
                strMensaje = "No se ha listado los datos del usuario. Ingrese el numero de DNI del usuario."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Me.txtNumDocBuscar.Focus()
                Return value
            End If

            'validar huella izquierda
            If Me.HuellaIzquierda Is Nothing OrElse Me.HuellaIzquierda._ImagenHuellaByte.Length < 5 Then
                strMensaje = "No se ha capturado la huella izquierda."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Return value
            End If

            'validar huella derecha
            If Me.HuellaDerecha Is Nothing OrElse Me.HuellaDerecha._ImagenHuellaByte.Length < 5 Then
                strMensaje = "No se ha capturado la huella derecha."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Return value
            End If

            value = True
            Return value

        End Function
        Private Function ValidarHuella() As Boolean

            Dim strMensaje As String = ""
            Dim value As Boolean = False

            'validar que los datos del usuario se listen
            If blnHayDatos = False Then
                strMensaje = "No se ha listado los datos del usuario. Ingrese el numero de DNI del usuario."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Me.txtNumDocBuscar.Focus()
                Return value
            End If

            value = True
            Return value

        End Function
#End Region
#Region "Accion"
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim strMensajeOut As String = ""
            Dim value As Integer = -1
            Dim obj As New APPWebService.ReniecBiometria

            value = obj.GrabarHuellaUsuario(Me.NumeroDocumento, Me.ApellidoPaterno, Me.ApellidoMaterno, Me.Nombres,
                                            Me.TipoDedoIzquierdo, Me.HuellaIzquierda._Wsq, Me.HuellaIzquierda._TemplateANSI,
                                            Me.TipoDedoDerecho, Me.HuellaDerecha._Wsq, Me.HuellaDerecha._TemplateANSI,
                                            Legolas.Configuration.Usuario.Codigo,
                                            Legolas.Configuration.Usuario.Login, strMensajeOut)

            If value > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.Close()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
            End If

        End Sub

#End Region
#Region "Otros"
        Private Function FRM_CapturarHuella(enmTipoDedo As Type.Enumeracion.Biometria.TipoDedo) As APPControlHuellaVisita.uscThumbFinger

            Dim uscHuellaActiva As New APPControlHuellaVisita.uscThumbFinger
            uscHuellaActiva._TipoDedo = enmTipoDedo

            'Dim frm As New APPControlHuellaVisita.frmCapturaMonoDac(uscHuellaActiva._TipoDedo)
            Dim frm As New APPControlHuellaVisita.frmCapturaMonoDac_v2(uscHuellaActiva._TipoDedo)
            With frm
                ._UsarBDHuella = False

                If .ShowDialog() = DialogResult.OK Then
                    uscHuellaActiva = frm._uscDedoActual
                End If
            End With

            Return uscHuellaActiva

        End Function

#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

            If ValidarNumeroDocumento() = False Then
                Exit Sub
            End If

            Listar()

        End Sub

        Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub frmRegistrarHuellaPopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            Me.txtNumDocBuscar.Focus()

        End Sub

        Private Sub btnCapturarHuella_Click(sender As Object, e As EventArgs) Handles btnCapturarHuellaIzq.Click

            If ValidarHuella() = False Then
                Exit Sub
            End If

            Me.HuellaIzquierda = FRM_CapturarHuella(Me.TipoDedoIzquierdo)
            Me.pbManoizquierda.Image = Me.HuellaIzquierda._Imagen

        End Sub

        Private Sub frmRegistrarHuellaPopup_Load(sender As Object, e As EventArgs) Handles Me.Load

            If Legolas.Components.PC.IsOnline = False Then
                MessageBox.Show("Para el registro de huellas, es necesario que cuente con una conexion a internet.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCapturarHuellaDer.Click

            If ValidarHuella() = False Then
                Exit Sub
            End If

            Me.HuellaDerecha = FRM_CapturarHuella(Me.TipoDedoDerecho)
            Me.pbManoDerecha.Image = Me.HuellaDerecha._Imagen

        End Sub

        Private Sub btnBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnBuscar.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Listar()
            End If

        End Sub
    End Class

End Namespace


