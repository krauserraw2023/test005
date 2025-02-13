
Namespace Sistema.Seguridad.Usuario
    Public Class frmBloquearSistema
#Region "Propiedades"
        Public Property _UsuarioLogin As String
            Get
                Return Me.txtUsuarioLogin.Text.Trim
            End Get
            Set(value As String)
                Me.txtUsuarioLogin.Text = value
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
        'Private ReadOnly Property ClaveEncript() As Byte()
        '    Get
        '        Dim obj As New System.Text.ASCIIEncoding
        '        Return obj.GetBytes(Me.Clave.ToString)

        '    End Get
        'End Property
#End Region
#Region "Propiedades_Otros"
        Private intIntentos As Integer = 0
        Private Property EtapaClave As Short = 1
        Private Property EtapaUsuarioClave As String = ""
        Private ReadOnly Property EtapaUsuarioClaveEncryp() As Byte()
            Get
                Dim objencoding As New System.Text.ASCIIEncoding()
                Return objencoding.GetBytes(Me.EtapaUsuarioClave)
            End Get
        End Property
        Private Property ClaveCorrecta As Boolean = False
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            'clave nueva
            If Me.Clave.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese una contraseña")
                Me.txtClave.Focus()
                Return value
            End If


            value = True
            Return value

        End Function
        Private Sub AEntrar()

            If Validar() = False Then Exit Sub

            Dim bssUsuario As New Bussines.Seguridad.Usuario
            Dim blnIngresa As Boolean = False

            Try

                blnIngresa = bssUsuario.LoginUsuario(Me._UsuarioLogin, Me.Clave)

                If blnIngresa = True Then

                    ClaveCorrecta = True
                    Me.Close()

                Else

                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Usuario o contraseña incorrecta, por favor vuelva ha intentarlo")
                    intIntentos += 1

                    Me.Clave = ""
                    Me.txtClave.Focus()

                    If intIntentos >= 3 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Muchos intentos incorrectos, el sistema se cerrará")
                        End
                    End If

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea cerrar el sistema") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                End
            End If

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AEntrar()

        End Sub

        Private Sub frmBloquearSistema_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        End Sub

        Private Sub frmBloquearSistema_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

            If ClaveCorrecta = True Then
                'clave correcta

            Else

                If Legolas.Configuration.Aplication.MessageBox.Question("Desea cerrar el sistema") = Windows.Forms.DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor
                    End
                Else
                    e.Cancel = True
                End If

            End If

        End Sub

        Private Sub frmBloquearSistema_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.txtClave.Focus()

        End Sub

        Private Sub txtClave_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress

            If e.KeyChar = Chr(Keys.Enter) Then
                AEntrar()
            End If

        End Sub

        Private Sub txtClave_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtClave.TextChanged

        End Sub
    End Class

End Namespace
