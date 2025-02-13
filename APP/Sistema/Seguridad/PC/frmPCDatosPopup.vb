Namespace Seguridad
    Public Class frmPCDatosPopup
#Region "Propiedades"
        Private Property HostName() As String
            Get
                Return Me.txtHostname.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtHostname.Text = value
            End Set
        End Property
        Private Property IP() As String
            Get
                Return Me.txtIP.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIP.Text = value
            End Set
        End Property
        Private Property MAC() As String
            Get
                Return Me.txtMAC.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtMAC.Text = value
            End Set
        End Property
        Private Property Serial() As String
            Get
                Return Me.txtSerialHD.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSerialHD.Text = value
            End Set
        End Property
        Private Property Obs() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarPC()

            Me.txtHostname.Text = My.Computer.Name
            Me.txtIP.Text = Legolas.Components.PC.GetIP
            Me.txtMAC.Text = Legolas.Components.PC.GetMAC
            Me.txtSerialHD.Text = Legolas.Components.PC.GetSerialHardDisk

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ListarPC()
        End Sub
#End Region


        Private Sub frmPCPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub btnCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorreo.Click

            Dim strCorreo As String = "lst_pope@inpe.gob.pe"
            Dim strAsunto As String = "registro de pc - externo"            
            Dim strComilla As String = """"

            Dim strMensaje2 As New System.Text.StringBuilder

            With strMensaje2
                .AppendLine(Me.lblHost.Text & strComilla & Me.HostName & strComilla)
                .AppendLine(Me.lblIp.Text & strComilla & Me.IP & strComilla)
                .AppendLine(Me.lblMac.Text & strComilla & Me.MAC & strComilla)
                .AppendLine(Me.lblSerial.Text & strComilla & Me.Serial & strComilla)
                .AppendLine("Observacion :" & Me.Obs)
            End With

            Dim blnValue As Boolean = False

            blnValue = Legolas.Configuration.Correo.Enviar(strCorreo, strAsunto, strMensaje2.ToString, _
            Net.Mail.MailPriority.Normal)

            If blnValue = True Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            End If

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub
    End Class

End Namespace

