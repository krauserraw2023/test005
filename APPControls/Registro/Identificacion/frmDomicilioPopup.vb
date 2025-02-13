Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion
    Public Class frmDomicilioPopup
        Private intUbigeoDomicilio As Integer = -1
#Region "Propiedades publicas"
        Public Property _Codigo As Integer = -1
        Public Property _InternoId As Integer = -1
        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property _IngresoId As Integer = -1
        Public Property _IngresoNroLetra As String = String.Empty
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property _InternoIngresoInpeId() As Integer = -1
#End Region
#Region "properties"
        Private Property DomicilioDepartamento() As Integer
            Get
                Try
                    Return Me.cbbDomicilioDepa.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDomicilioDepa.SelectedValue = value
            End Set
        End Property
        Private Property DomicilioProvincia() As Integer
            Get
                Try
                    Return Me.cbbDomicilioProv.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDomicilioProv.SelectedValue = value
            End Set
        End Property
        Private Property DomicilioDistrito() As Integer
            Get
                Try
                    Return Me.cbbDomicilioDist.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDomicilioDist.SelectedValue = value
            End Set
        End Property
        Private Property UbigeoDomicilio() As Integer
            Get
                Try
                    Return Me.cbbDomicilioDist.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)

                Dim intValue As Integer = -1
                intValue = value

                If intValue > 0 Then
                    ListarUbigeoDomicilio(intValue)
                Else
                    Me.cbbDomicilioDepa.SelectedValue = -1
                    Me.cbbDomicilioProv.SelectedValue = -1
                    Me.cbbDomicilioDist.SelectedValue = -1
                End If

            End Set
        End Property
        Private Property Direccion() As String
            Get
                Return Me.txtDireccion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDireccion.Text = value
            End Set
        End Property

        Private Property Referencia() As String
            Get
                Return Me.txtReferencia.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtReferencia.Text = value
            End Set
        End Property
#End Region

#Region "combos"
        Private blnComboDomDep As Boolean = False
        Private blnComboDomProv As Boolean = False

        Private Sub ComboDomicilioDepartamento()
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbDomicilioDepa
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Departamento, 85) 'peru
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboDomDep = True
        End Sub

        Private Sub ComboDomicilioProvincia()
            blnComboDomProv = False
            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbDomicilioProv
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Provincia, Me.DomicilioDepartamento)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboDomProv = True
        End Sub

        Private Sub ComboDomicilioDistrito()

            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbDomicilioDist
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Distrito, _
                Me.DomicilioProvincia)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub listar()

            If Me._Codigo = -1 Then Exit Sub

            Dim ent As New Entity.Registro.InternoDomicilio
            ent.Codigo = Me._Codigo
            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                ent = (New Bussines.Registro.InternoDomicilio).Listar_LM(Me._Codigo)

                Dim entIngInp As Entity.Registro.IngresoInpe
                entIngInp = (New Bussines.Registro.IngresoInpe).Listar(ent.IngresoInpeId)
                lblNroIngreso.Text = entIngInp.IngresoNroLetra

            Else
                ent = (New Bussines.Registro.InternoDomicilio).Listar(Me._Codigo)
            End If


            With ent
                ListarUbigeoDomicilio(.DistritoId)
                Me.Direccion = .Direccion
                Me.Referencia = .LugarReferencial
                Me._PenalId = .PenalId
                Me._RegionId = .RegionId
                Me._IngresoId = .IngresoId
            End With
        End Sub
        Private Sub ListarUbigeoDomicilio(ByVal Codigo As Integer)
            With (New Bussines.General.Ubigeo).Listar("lst_mant", Codigo, -1, -1, -1, -1, "").Ubigeo(0)
                Me.DomicilioDepartamento = .Departamento
                Me.DomicilioProvincia = .Provincia
                Me.DomicilioDistrito = .Distrito
            End With
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            If Me.DomicilioDepartamento <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el departamento.")
                cbbDomicilioDepa.Focus()
                Return False
            End If
            If Me.DomicilioProvincia <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione provincia.")
                cbbDomicilioProv.Focus()
                Return False
            End If
            If Me.DomicilioDistrito <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el distrito.")
                cbbDomicilioDist.Focus()
                Return False
            End If
            If Me._Codigo = -1 Then
                If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    If Me._InternoIngresoInpeId <= 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione un número de ingreso válido.")
                        Return False
                    End If
                Else
                    If Me._IngresoId <= 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione un número de ingreso válido.")
                        Return False
                    End If
                End If
                If Me._InternoId <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Valor Id del interno no válido, por favor, comuniquese con soporte de la sede central.")
                    Return False
                End If
                If Me._PenalId < 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Id del penal no especificado.")
                    Return False
                End If
                If Me._RegionId < 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Id de la región no especificado.")
                    Return False
                End If
            End If

            Return True
        End Function

        Private Sub Grabar()

            If Validar() = False Then Exit Sub

            Dim ent As New Entity.Registro.InternoDomicilio
            With ent
                .Codigo = Me._Codigo
                .IngresoId = Me._IngresoId
                .InternoId = Me._InternoId
                .PenalId = Me._PenalId
                .RegionId = Me._RegionId
                .DepartamentoId = Me.DomicilioDepartamento
                .ProvinciaId = Me.DomicilioProvincia
                .DistritoId = Me.DomicilioDistrito
                .LugarReferencial = Me.txtReferencia.Text
                .Direccion = txtDireccion.Text
                .IngresoInpeId = Me._InternoIngresoInpeId
            End With

            Dim id As Integer = -1
            Dim outSms As String = String.Empty

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                ent.IngresoId = -1
                id = (New Bussines.Registro.InternoDomicilio).Grabar_LM(ent, outSms, False)
            Else
                id = (New Bussines.Registro.InternoDomicilio).Grabar(ent, outSms)
            End If

            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Error, " & vbCrLf & outSms)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()
            ComboDomicilioDepartamento()
            Me.DomicilioDepartamento = -1
            If Me._Codigo = -1 Then
                lblNroIngreso.Text = Me._IngresoNroLetra
            Else
                lblNroIngreso.Text = ""
            End If

            listar()
        End Sub

        Private Sub Usuario_Permiso()

            Me.btnOK.Visible = Me._FormEscritura

        End Sub
#End Region

        Private Sub frmDireccionPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ValoresxDefault()
            Usuario_Permiso()
        End Sub

        Private Sub cbbDomicilioDepa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbDomicilioDepa.SelectedIndexChanged
            If blnComboDomDep = True Then
                ComboDomicilioProvincia()
                ComboDomicilioDistrito()
            End If
        End Sub

        Private Sub cbbDomicilioProv_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbDomicilioProv.SelectedIndexChanged
            If blnComboDomProv = True Then ComboDomicilioDistrito()
        End Sub

        Private Sub cbbDomicilioDist_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbDomicilioDist.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
            Grabar()
        End Sub
    End Class
End Namespace