Imports System.Net.Mail
Imports System.Net.Mime

Namespace Transferencia.Control
    Public Class frmShowSqlPopup
        Private strCorreoUsuario As String = "sip_pope@inpe.gob.pe"
        Private strCorreoClave As String = "098123"
        Private strServidorCorreo As String = "mail.inpe.gob.pe"
#Region "Propiedades"

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
        Private Property CorreoCC As String
            Get
                Return Me.txtCC.Text
            End Get
            Set(value As String)
                Me.txtCC.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Publicas"
        Public Property _sms As String = ""
        Public Property _RegionNombre As String = ""
        Public Property _PenalNombre As String = ""
#End Region
#Region "Otros"
        Private Function resaltarNodo(rtb As RichTextBox, sFindString As String, colorText As Color, Optional ByVal Negrita As Boolean = False) As Integer
            Dim lFoundPos As Long
            Dim lFindLength As Long
            Dim lOriginalSelStart As Long
            Dim lOriginalSelLength As Long
            Dim iMatchCount As Integer

            lOriginalSelStart = rtb.SelectionStart
            lOriginalSelLength = rtb.SelectionLength

            lFindLength = Len(sFindString)

            lFoundPos = rtb.Find(sFindString, 0, rtb.TextLength, RichTextBoxFinds.None)
            While lFoundPos > -1 And iMatchCount < rtb.TextLength
                iMatchCount = iMatchCount + 1

                rtb.SelectionStart = lFoundPos
                rtb.SelectionLength = lFindLength
                rtb.SelectionColor = colorText
                If Negrita = True Then
                    rtb.SelectionFont = New Font(rtb.SelectionFont, FontStyle.Bold)
                Else
                    rtb.SelectionFont = New Font(rtb.SelectionFont, FontStyle.Regular)
                End If

                lFoundPos = rtb.Find(sFindString, lFoundPos + lFindLength, rtb.TextLength, RichTextBoxFinds.None)
            End While

            rtb.SelectionStart = lOriginalSelStart
            rtb.SelectionLength = lOriginalSelLength
        End Function
        Private Function EnviarCorreo(ByVal ListaCorreoPara As String, ListaCorreoConcopia As String, ByVal Asunto As String, ByVal Mensaje As String,
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

                Dim en As New System.Text.UTF8Encoding
                Dim strComillas As String = """"
                Dim html As String = "<h4> <p style=" & strComillas & "color:#0A3F78" & strComillas & "> " + Mensaje + " </p> </h4>"

                Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, en, MediaTypeNames.Text.Html)

                If PathArchivoAdjunto.Length > 0 Then
                    Dim MyFile As String = System.IO.Path.GetFileName(PathArchivoAdjunto)
                    Dim info As New IO.FileInfo(PathArchivoAdjunto)
                    Dim attachmentFile As New Attachment(PathArchivoAdjunto)
                    mail.Attachments.Add(attachmentFile)
                End If

                mail.AlternateViews.Add(htmlView)
                mail.IsBodyHtml = True

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
        Private Sub frmShowSqlPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.RichTextBox1.Text = Me._sms
        End Sub

        Private Sub frmShowSqlPopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            'resaltarNodo(txtSql, "Update", Color.FromArgb(192, 0, 192), False)
            'resaltarNodo(txtSql, "Set", Color.Blue, False)
            'resaltarNodo(txtSql, "Where", Color.Blue, False)
            ''resaltarNodo(txtSql, "=", Color.Gray, False)
            ''resaltarNodo(txtSql, "And", Color.Gray, False)
            ''resaltarNodo(txtSql, "(", Color.Gray, False)
            ''resaltarNodo(txtSql, ")", Color.Gray, False)
            ''resaltarNodo(txtSql, ",", Color.Gray, False)

            Me.CorreoAsunto = Me.CorreoAsunto & " - " & Me._PenalNombre.ToUpper & "/" & Me._RegionNombre.ToUpper

        End Sub

        Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

            'txtSql.Select(0, txtSql.TextLength)
            'txtSql.Copy()

            Dim strQuery As New Text.StringBuilder

            Dim strSaludo As String = ""

            Select Case Now.Hour
                Case < 12
                    strSaludo = "Buenos Dias"
                Case < 18
                    strSaludo = "Buenas Tardes"
                Case < 24
                    strSaludo = "Buenas Noches"
            End Select

            strQuery.Append(strSaludo)
            strQuery.Append("<br>")
            strQuery.Append("Señores")
            strQuery.Append("<br>")
            strQuery.Append("<br>")
            strQuery.Append("Ejecutar el query dentro de los quince (15) minutos de recibido el correo, en el establecido penitenciario de " & Me._PenalNombre.ToUpper & ".")
            strQuery.Append("<br>")
            strQuery.Append("<br>")
            strQuery.Append("<br>")

            For Each str As String In Me.RichTextBox1.Lines
                strQuery.Append(str)
                strQuery.Append("<br>")
            Next

            Dim strMensajeError As String = ""
            EnviarCorreo(Me.CorreoPara, Me.CorreoCC, Me.CorreoAsunto, strQuery.ToString, "", strMensajeError)

            If strMensajeError.Trim <> "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Se encontraron problemas al enviar al correo; " & strMensajeError)
            Else
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
    End Class
End Namespace