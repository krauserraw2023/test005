Namespace Seguridad
    Public Class frmPCMantPopup
        Private objBss As Legolas.LBusiness.Seguridad.PC = Nothing
        Private objEnt As Legolas.LEntity.Seguridad.PC = Nothing
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
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
        Private Property SerialHD() As String
            Get
                Return Me.txtSerialHD.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSerialHD.Text = value
            End Set
        End Property
        Private Property Responsable() As String
            Get
                Return Me.txtResp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtResp.Text = value
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

            Me.HostName = My.Computer.Name
            Me.IP = Legolas.Components.PC.GetIP
            Me.MAC = Legolas.Components.PC.GetMAC
            Me.SerialHD = Legolas.Components.PC.GetSerialHardDisk

        End Sub
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Legolas.LBusiness.Seguridad.PC
            objEnt = New Legolas.LEntity.Seguridad.PC


            objEnt = objBss.Listar(Me.Codigo)

            With objEnt

                Me.HostName = .HostName
                Me.IP = .IP
                Me.MAC = .MAC
                Me.SerialHD = .SerialHD
                Me.Responsable = .Responsable
                Me.Obs = .Obs

            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            '/*hostname*/
            If Me.HostName.Length < 1 Or Me.HostName = "" Then
                MessageBox.Show("Ingrese el Nombre de la PC a registrar", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.txtHostname.Focus()
                Return blnValue
            End If

            '/*ip*/
            If Me.IP.Length < 1 Or Me.IP = "" Then
                MessageBox.Show("Ingrese el IP de la PC a registrar", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.txtIP.Focus()
                Return blnValue
            End If

            '/*mac*/
            If Me.MAC.Length < 1 Or Me.MAC = "" Then
                MessageBox.Show("Ingrese el numero de MAC de la PC a registrar", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.txtMAC.Focus()
                Return blnValue
            End If

            Return blnValue

        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            objBss = New Legolas.LBusiness.Seguridad.PC
            Dim intValue As Integer = -1

            intValue = objBss.Grabar(Me.Codigo, Me.HostName, Me.IP, Me.MAC, Me.SerialHD, Me.Responsable, Me.Obs)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.Codigo = intValue
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

        End Sub
#End Region
      

        Private Sub frmPCPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmPCMantPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()

        End Sub

        Private Sub bntOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntOk.Click

            AGrabar()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnPc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPc.Click

            ListarPC()

        End Sub
    End Class

End Namespace

