
Namespace Sistema.Seguridad.Usuario
    Public Class frmCambiarClave
#Region "Propiedades"
        Private Property ClaveOld() As String
            Get
                Return Me.txtClaveOld.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtClaveOld.Text = value
            End Set
        End Property     
        Private Property Clave() As String
            Get
                Return Me.txtClave.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtClave.Text = value
            End Set
        End Property     
        Private Property ReClave() As String
            Get
                Return Me.txtReClave.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtReClave.Text = value
            End Set
        End Property       
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            'clave old
            If Me.ClaveOld.Length < 1 Or Me.ClaveOld = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Ingrese la contraseña anterior")
                Me.txtClaveOld.Focus()
                Return value
            End If

            'clave nueva
            If Me.Clave.Length < 6 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese una contraseña, mayor a 6 digitos")
                Me.txtClave.Focus()
                Return value
            End If

            'confirmacion de clave
            If Me.ReClave.Length < 6 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese una contraseña, mayor a 6 digitos")
                Me.txtReClave.Focus()
                Return value
            End If

            'coincidir clave y reclave
            If Me.Clave <> Me.ReClave Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "La confirmacion de contraseña no coincide")
                Me.txtReClave.Focus()
                Return value
            End If

            'la clave no puede ser igual q el usuario
            If Me.ReClave.ToString.Trim.ToLower = Legolas.Configuration.Usuario.Login.ToLower Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "La nueva contraseña, no puede ser igual que el usuario")
                Return value
            End If

            value = True
            Return value

        End Function
        Private Sub ACambiarClave()

            If Validar() = False Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Seguridad.Usuario
            Dim objEnt As New Legolas.LEntity.Seguridad.Usuario
            Dim blnLogeo As Boolean = False

            blnLogeo = objBss.LoginUsuario(Legolas.Configuration.Usuario.Login, Me.ClaveOld)

            If blnLogeo = True Then

                If Me.Clave = Me.ReClave Then

                    Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                        Case 1 'SEDE CENTRAL

                            objBss.CambiarClave(Legolas.Configuration.Usuario.Codigo, Me.ReClave)
                            Legolas.Configuration.Aplication.MessageBox.Information( _
                            "Su contraseña fue cambiada satisfactoriamente")
                            Me.DialogResult = Windows.Forms.DialogResult.OK

                        Case Else
                            'todas las provincias

                            If Legolas.Components.PC.IsOnline = True Then

                                Dim intUsuario As Integer = -1
                                Dim objWs As New APPWebService.ws_pope_sede_usuario.Usuario
                                objWs.Url = APPWebService.PathURL.WSPopeSedeUsuario

                                Dim strClaveCifrada As String = ""
                                Dim bytClaveCifrada As Byte()

                                strClaveCifrada = Legolas.Components.Cifrado.Encriptar(Me.ReClave)

                                Dim obj As New System.Text.ASCIIEncoding
                                bytClaveCifrada = obj.GetBytes(strClaveCifrada.ToString)

                                intUsuario = objWs.CambiarClaveCifrado(Legolas.Configuration.Usuario.Codigo, bytClaveCifrada)

                                If intUsuario > 0 Then

                                    objBss.CambiarClave(Legolas.Configuration.Usuario.Codigo, Me.ReClave)
                                    Legolas.Configuration.Aplication.MessageBox.Information( _
                                    "Su contraseña fue cambiada satisfactoriamente")
                                    Me.DialogResult = Windows.Forms.DialogResult.OK

                                Else
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                                    "No se pudo tener acceso con la Sede Central, por favor vuelva ha intentar")

                                End If

                            Else
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                                "No se pudo tener acceso con la Sede Central, por favor vuelva ha intentarlo mas tarde")
                                Me.DialogResult = Windows.Forms.DialogResult.OK                                
                            End If

                    End Select

                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "La confirmacion de la contraseña no coincide")
                    Me.txtReClave.Focus()
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "La contraseña anterior no es valida")
                Me.txtClaveOld.Focus()
            End If

        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            ACambiarClave()

        End Sub

        Private Sub txtReClave_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtReClave.KeyPress

            If e.KeyChar = Chr(Keys.Enter) Then
                ACambiarClave()
            End If

        End Sub

        Private Sub txtReClave_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReClave.TextChanged

        End Sub
    End Class

End Namespace
