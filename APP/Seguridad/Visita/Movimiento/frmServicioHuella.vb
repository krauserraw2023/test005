Namespace Visita.Movimiento
    Public Class frmServicioHuella
        Private objBss As Bussines.Visita.ConfigHuella = Nothing
        Private objEnt As Entity.Visita.ConfigHuella = Nothing
        Public Enum enmTipoServicio
            Ninguno = 0
            Baja = 1
            Alta = 2
        End Enum
#Region "Propiedades_Publicas"
        Public Property _TipoServicio As enmTipoServicio = enmTipoServicio.Baja
#End Region
#Region "Propiedades"
        Private Property FechaRegistro As Long = 0        
        Private ReadOnly Property IDUsuario As Integer
            Get
                Return Legolas.Configuration.Usuario.Codigo
            End Get
        End Property
        Private Property UsuarioApeNom As String
            Get
                Return Me.lblUsuario.Text.Trim
            End Get
            Set(value As String)
                Me.lblUsuario.Text = value
            End Set
        End Property
        Private Property IDRegion As Short = -1
        Private Property IDPenal As Short = -1
#End Region
#Region "Propiedades_Baja"
        Private Property FechaRegistroString As String
            Get
                Return Me.lblFechaReg.Text.Trim
            End Get
            Set(value As String)
                Me.lblFechaReg.Text = value
            End Set
        End Property
        Private Property FechaBaja As Long = 0
        Private Property Motivo As String
            Get
                Return Me.txtMotivo.Text.Trim
            End Get
            Set(value As String)
                Me.txtMotivo.Text = value
            End Set
        End Property
        Private Property UsuarioApeNomAlta As String
            Get
                Return Me.lblUsuarioAlta.Text.Trim
            End Get
            Set(value As String)
                Me.lblUsuarioAlta.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Alta"
        Private Property FechaRegistroAltaString As String
            Get
                Return Me.lblFechaRegAlta.Text.Trim
            End Get
            Set(value As String)
                Me.lblFechaRegAlta.Text = value
            End Set
        End Property
        Private Property FechaAlta As Long = 0
        Private Property Solucion As String
            Get
                Return Me.txtSolucion.Text.Trim
            End Get
            Set(value As String)
                Me.txtSolucion.Text = value
            End Set
        End Property

#End Region
#Region "Listar"

#End Region
#Region "Accion"
        Private Sub AGrabar()

            Select Case Me._TipoServicio
                Case enmTipoServicio.Baja
                    GrabarBaja()
                Case enmTipoServicio.Alta
                    GrabarAlta()
            End Select


        End Sub
        Private Sub GrabarBaja()

            'validar el motivo de baja 
            If Me.Motivo.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el motivo de baja")
                Me.txtMotivo.Focus()
                Exit Sub
            End If

            objBss = New Bussines.Visita.ConfigHuella
            objEnt = New Entity.Visita.ConfigHuella

            Me.FechaBaja = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong

            With objEnt
                .Codigo = -1
                .Fecha = Me.FechaRegistro
                .FechaBaja = Me.FechaBaja
                .IDUsuarioBaja = IDUsuario
                .MotivoBaja = Me.Motivo
                .IDRegion = Me.IDRegion
                .IDPenal = Me.IDPenal
            End With

            Dim intCodigo As Integer = -1
            intCodigo = objBss.DeshabilitarHuella(objEnt)

            If intCodigo > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
        Private Sub GrabarAlta()

            'validar el motivo de alta 
            If Me.Solucion.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el motivo de alta del servicio")
                Me.txtSolucion.Focus()
                Exit Sub
            End If

            objBss = New Bussines.Visita.ConfigHuella
            objEnt = New Entity.Visita.ConfigHuella

            Me.FechaAlta = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
            Dim intCodigo As Integer = -1

            intCodigo = objBss.GetIDConfigHuella(Me.FechaRegistro, Me.IDRegion, Me.IDPenal)

            With objEnt
                .Codigo = intCodigo
                .FechaAlta = Me.FechaAlta
                .IDUsuarioAlta = IDUsuario
                .SolucionAlta = Me.Solucion
                .IDRegion = Me.IDRegion
                .IDPenal = Me.IDPenal
            End With

            intCodigo = objBss.HabilitarHuella(objEnt)

            If intCodigo > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
        Private Sub ValidarEstadadoBaja()

            Dim value As Boolean = False
            Dim objBss As New Bussines.Visita.ConfigHuella

            value = objBss.ValidarServicioBaja(Me.FechaRegistro, Me.IDRegion, Me.IDPenal)

            If value = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El servicio de Biometria (Huella Digital) ya se encuentra de baja")
                Me.Close()
            End If

        End Sub
        Private Sub ValidarEstadadoAlta()

            Dim value As Boolean = False
            Dim objBss As New Bussines.Visita.ConfigHuella

            Dim intCodigo As Integer = -1            
            intCodigo = objBss.GetIDConfigHuella(Me.FechaRegistro, Me.IDRegion, Me.IDPenal)

            If intCodigo > 0 Then
                value = objBss.ValidarServicioAlta(intCodigo, Me.IDRegion, Me.IDPenal)
            Else
                value = True
            End If

            If value = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El servicio de Biometria (Huella Digital) ya se encuentra de Alta")
                Me.Close()
            End If

        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresIniciales()

            Dim objBssLic As New Bussines.Sistema.Instalacion

            Me.IDRegion = objBssLic.LicenciaIDRegion(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            Me.IDPenal = objBssLic.LicenciaIDPenal(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            Me.FechaRegistro = Legolas.LBusiness.Globall.DateTime.FechaServerLong

            'baja
            Me.FechaRegistroString = Legolas.Components.FechaHora.FechaString(Me.FechaRegistro)
            Me.UsuarioApeNom = Legolas.Configuration.Usuario.ApellidosyNombre

            'alta
            Me.FechaRegistroAltaString = Me.FechaRegistroString
            Me.UsuarioApeNomAlta = Me.UsuarioApeNom

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub frmServicioHuella_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ValoresIniciales()

            Select Case Me._TipoServicio
                Case enmTipoServicio.Baja
                    Me.Text = "Desactivar el Servicio de Biometria (Huella Digital)"
                    Me.grbBaja.Visible = True
                    Me.grbAlta.Visible = False
                    ValidarEstadadoBaja()
                Case enmTipoServicio.Alta
                    Me.Text = "Habilitar el Servicio de Biometria (Huella Digital)"
                    Me.grbBaja.Visible = False
                    Me.grbAlta.Visible = True
                    ValidarEstadadoAlta()
            End Select

        End Sub
    End Class
End Namespace