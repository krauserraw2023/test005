Imports System.Net.Mail
Imports System.Net.Mime

Namespace Sistema.Seguridad.Usuario
    Public Class frmEnviarCorreo
        Private strCorreoUsuario As String = "sip_pope@inpe.gob.pe"
        Private strCorreoClave As String = "098123"
        Private strServidorCorreo As String = "mail.inpe.gob.pe"

#Region "Propiedades"
        Public Property _IDUsuario As Integer = -1
        Private Property CorreoPara As String
            Get
                Return Me.txtCorreoPara.Text
            End Get
            Set(value As String)
                Me.txtCorreoPara.Text = value
            End Set
        End Property
        Private Property CorreoAsunto As String
            Get
                Return Me.txtAsunto.Text
            End Get
            Set(value As String)
                Me.txtAsunto.Text = value
            End Set
        End Property
#End Region

#Region "Accion"

        Private Sub ListarEnviarCorreo()

            If Me._IDUsuario < 1 Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Seguridad.Usuario
            Dim objEnt As New Entity.Sistema.Seguridad.Usuario 

            Dim strLogin As String = ""
            Dim strApePat As String = ""
            Dim strApeMat As String = ""
            Dim strNombres As String = ""
            Dim strNumDoc As String = ""

            objEnt = objBss.Listar(Me._IDUsuario)

            With objEnt
                strLogin = .Login
                strApePat = .ApellidoPaterno
                strApeMat = .ApellidoMaterno
                strNombres = .Nombres
                strNumDoc = .NumeroDocumento
            End With

            Me.CorreoPara = strNombres.ToString.Remove(1).ToUpper & strApePat.ToUpper & "@inpe.gob.pe"

            Dim strMensaje As String = ""
            strMensaje = "Cuenta de usuario; " & "<br>" & "<br>" & Chr(13) & Chr(13)
            'strMensaje = strMensaje & "Login : " & strLogin & "<br>"
            strMensaje = strMensaje & "Nro. Documento: " & strNumDoc & "<br>" & Chr(13)
            strMensaje = strMensaje & "Apellido Paterno: " & strApePat.ToUpper & "<br>" & Chr(13)
            strMensaje = strMensaje & "Apellido Materno: " & strApeMat.ToUpper & "<br>" & Chr(13)
            strMensaje = strMensaje & "Nombres: " & strNombres.ToUpper & "<br>" & "<br>" & Chr(13) & Chr(13)
            strMensaje = strMensaje & "Para efectos de ingresar (login) a los sistemas SIP, ingresar los siguientes datos; " & "<br>" & Chr(13)
            strMensaje = strMensaje & "Usuario:" & strLogin.ToUpper & "<br>" & Chr(13)
            strMensaje = strMensaje & "Clave: Es igual que el usuario (pero en mayuscula, todo seguido)" & "<br>" & "<br>" & Chr(13) & Chr(13)
            strMensaje = strMensaje & "Por motivos de seguridad, usted debe cambiar su clave inicial y realizar el mantenimiento de cambio de clave frecuentemente."

            If chkAdjunto.Checked = True Then
                strMensaje = strMensaje & "<br>" & "<br>" & Chr(13) & Chr(13)
                strMensaje = strMensaje & "Nota: Si su usuario pertenece al Penal o Region, debe replicar los permisos de los usuarios. Para ello debe ver los pasos que "
                strMensaje = strMensaje & "figuran en el archivo adjunto. No olvide que cuando haga clic en la opcion [Actualizar usuario], debe esperar el proceso y un "
                strMensaje = strMensaje & "mensaje indicando [Operacion realizada satisfactoriamente], para que pueda ingresar al sistema."

                Me.txtPathArchivo.Text = "D:\Desarrollo\DEV\SIP_POPE\Doc\replicar_usuario.png"
            Else
                Me.txtPathArchivo.Text = ""
            End If

            Me.RichTextBox1.Text = strMensaje

        End Sub

        Private Function EnviarCorreo(ByVal ListaCorreoPara As String, ListaCorreoConcopia As String, ByVal Asunto As String, ByVal Mensaje As String, _
        ByVal PathArchivoAdjunto As String, ByRef MensajeError As String) As Boolean

            Dim value As Boolean = False

            Try

                Dim mail As New MailMessage()
                mail.From = New MailAddress(strCorreoUsuario)

                If ListaCorreoPara.Trim.Length > 0 Then
                    mail.[To].Add(ListaCorreoPara)
                End If

                If ListaCorreoConcopia.Trim.Length > 0 Then
                    mail.[CC].Add(ListaCorreoConcopia)
                End If

                mail.Bcc.Add("desarrollo@inpe.gob.pe")

                mail.Subject = Asunto

                ' Creamos la vista para clientes que
                ' sólo pueden acceder a texto plano...

                Dim en As New System.Text.UTF8Encoding
                ' Ahora creamos la vista para clientes que 
                ' pueden mostrar contenido HTML...

                Dim strComillas As String = """"

                'Dim html As String = "<h3>" + Mensaje + "</h3>"
                Dim html As String = "<h3> <p style=" & strComillas & "color:#0A3F78" & strComillas & "> " + Mensaje + " </p> </h3>"

                'html = html + "<a href='" + Me.TextBox2.Text + "'>" + Me.TextBox1.Text + "</a><br>"

                Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, en, MediaTypeNames.Text.Html)

                ' Creamos el recurso a incrustar. Observad
                ' que el ID que le asignamos (arbitrario) está
                ' referenciado desde el código HTML como origen
                ' de la imagen (resaltado en amarillo)...

                'If PathArchivoAdjunto.Length > 0 Then
                '    html = html + "<img src='cid:imagen' />"
                '    'Dim img As New LinkedResource(PathArchivoAdjunto, TipoArchivo)
                '    Dim img As New LinkedResource(PathArchivoAdjunto, MediaTypeNames.Image.Jpeg)
                '    img.ContentId = "imagen"
                '    ' Lo incrustamos en la vista HTML...
                '    htmlView.LinkedResources.Add(img)
                'End If

                If PathArchivoAdjunto.Length > 0 Then


                    'html = html + "<img src='cid:imagen' />"
                    'Dim img As New LinkedResource(PathArchivoAdjunto, MediaTypeNames.Image.Jpeg)
                    'img.ContentId = "imagen"
                    '' Lo incrustamos en la vista HTML...
                    'htmlView.LinkedResources.Add(img)
                    Dim MyFile As String = System.IO.Path.GetFileName(PathArchivoAdjunto)
                    Dim info As New IO.FileInfo(PathArchivoAdjunto)
                    Dim attachmentFile As New Attachment(PathArchivoAdjunto)

                    mail.Attachments.Add(attachmentFile)

                End If


                ' Por último, vinculamos ambas vistas al mensaje...

                mail.AlternateViews.Add(htmlView)
                mail.IsBodyHtml = True
                ' Y lo enviamos a través del servidor SMTP...

                Dim smtp As New SmtpClient(strServidorCorreo)
                smtp.Credentials = New System.Net.NetworkCredential(strCorreoUsuario, strCorreoClave)
                smtp.Send(mail)
                value = True

            Catch ex As Exception
                MensajeError = ex.Message
                value = False
            End Try

            Return value

        End Function

#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            Dim strMensajeError As String = ""
            EnviarCorreo(Me.CorreoPara, "", Me.CorreoAsunto, Me.RichTextBox1.Text, Me.txtPathArchivo.Text, strMensajeError)

            If strMensajeError.Trim <> "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Se encontraron problemas al enviar al correo; " & strMensajeError)
            Else
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

        Private Sub frmEnviarCorreo_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarEnviarCorreo()

        End Sub

        Private Sub chkAdjunto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAdjunto.CheckedChanged

        End Sub

        Private Sub chkAdjunto_Click(sender As Object, e As System.EventArgs) Handles chkAdjunto.Click

            ListarEnviarCorreo()
            Me.txtPathArchivo.Enabled = Me.chkAdjunto.Checked

        End Sub
    End Class

End Namespace
