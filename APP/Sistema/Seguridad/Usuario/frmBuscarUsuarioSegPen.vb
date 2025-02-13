Namespace Sistema.Seguridad.Usuario
    Public Class frmBuscarUsuarioSegPen
        Private objBss As Bussines.Seguridad.Usuario = Nothing
        Private objEntCol As Legolas.LEntity.Seguridad.UsuarioCol = Nothing
#Region "Instancia"
        'Variable Shared que contiene la única instancia del formulario.
        Private Shared ChildInstance As Sistema.Seguridad.Usuario.frmBuscar = Nothing
        'controla que sólo exista una instancia del formulario.
        Public Shared Function Instance() As Sistema.Seguridad.Usuario.frmBuscar
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New Sistema.Seguridad.Usuario.frmBuscar
            End If
            ChildInstance.BringToFront()
            Return ChildInstance
        End Function

        Private ReadOnly Property PerfilUsuarioEnSession As Type.Enumeracion.Usuario.EnumDependencia
            Get
                Return Legolas.Configuration.Usuario.OficinaID
            End Get
        End Property
        Private ReadOnly Property IDLicenciaEnSession As Short
            Get
                Return Legolas.LBusiness.Globall.WinApp.LicenciaApp
            End Get
        End Property
        Private ReadOnly Property IDNivelUsuarioEnSession As Type.Enumeracion.Licencia.enmTipoLicencia
            Get
                Return Legolas.Configuration.Usuario.NivelUsuario
            End Get
        End Property

#End Region
#Region "Propiedades_Buscar"
        Private intNumeroReg As Integer = 0
        Private Property Login() As String
            Get
                Return Me.txtUsuario.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtUsuario.Text = value
            End Set
        End Property
        Private Property NumeroDoc() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property Apellidos() As String
            Get
                Return Me.txtApellidos.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApellidos.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNombres.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombres.Text = value
            End Set
        End Property

        Private Property NivelUsuario() As Integer
            Get
                Return If(Me.cbbNivelUsuario.SelectedIndex < 1, -1, Me.cbbNivelUsuario.SelectedIndex)
            End Get
            Set(ByVal value As Integer)
                Me.cbbNivelUsuario.SelectedIndex = value
            End Set
        End Property
        Private Property IDDependenciaPerfil() As Integer
            Get
                Return Me.cbbDependencia.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDependencia.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property EstadoUsuario() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbActivo.Checked = True Then intValue = 0
                If Me.rdbBaja.Checked = True Then intValue = 1

                Return intValue

            End Get
        End Property

#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = dgwGrilla.SelectedRows(0).Cells("col_usu_id").Value
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaLogin() As String
            Get
                Dim strValue As String = ""
                Try
                    strValue = Me.dgwGrilla.SelectedRows(0).Cells("col_log").Value.ToString.ToUpper
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaApellidos() As String
            Get
                Dim strValue As String = ""
                Try
                    strValue = Me.dgwGrilla.SelectedRows(0).Cells("col_ape").Value
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaNombres() As String
            Get
                Dim strValue As String = ""
                Try
                    strValue = Me.dgwGrilla.SelectedRows(0).Cells("col_nom").Value
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property

        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                ListarNumeroReg()
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub ComboDependencia()
            With Me.cbbDependencia
                .DataSource = (New Bussines.Mantenimiento.General.Dependencia).Listar(Me.NivelUsuario, True)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
        End Sub

        Private Sub ComboTipoLicencia()

            With Me.cbbNivelUsuario
                .Items.Add("[Todos]")
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.Sede.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta.ToString)
                .SelectedIndex = 0
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarNumeroReg()
            lblReg.Text = Me.NumeroReg & " Reg."
        End Sub
        Private Sub Buscar()

            Me.col_fec_cre.Tag = "fecha_hora"
            Me.col_fec_mod.Tag = "fecha_hora"

            objBss = New Bussines.Seguridad.Usuario
            objEntCol = New Legolas.LEntity.Seguridad.UsuarioCol
            Dim tmpNivUsu As Integer = Legolas.Configuration.Usuario.NivelUsuario
            If Legolas.Configuration.Usuario.NivelUsuario = 3 Then tmpNivUsu = -1 'si es sede, no filtrar para mostrar todo

            Select Case PerfilUsuarioEnSession
                Case Type.Enumeracion.Usuario.EnumDependencia.JefeGrupoSeguridad,
                      Type.Enumeracion.Usuario.EnumDependencia.JefeSeguridad
                    objEntCol = objBss.ListarGrillaUsuSeguridad(-1, Me.Login, Me.Apellidos, Me.Nombres, Me.NumeroDoc, tmpNivUsu, Me.IDDependenciaPerfil, Me.EstadoUsuario)
                Case Else
                    objEntCol = objBss.ListarGrillaUsuTratamiento(-1, Me.Login, Me.Apellidos, Me.Nombres, Me.NumeroDoc, tmpNivUsu, Me.IDDependenciaPerfil, Me.EstadoUsuario)
            End Select

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                Me.NumeroReg = .RowCount
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub ARestaurarClave()

            If Me.GrillaCodigo < 1 Then Exit Sub

            If (New Bussines.Seguridad.Usuario()).RestaurarClave(Me.GrillaCodigo, Me.GrillaLogin) > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("La contraseña ha sido restaurada satisfactoriamente")

                'If Legolas.Configuration.Aplication.MessageBox.Question("Desea enviar los credenciales del usuario por correo electronico") = Windows.Forms.DialogResult.Yes Then
                '    FRM_EnviarCorreo()
                'End If

            End If

        End Sub

        Private Sub ALimpiar()

            Me.Login = ""
            Me.Apellidos = ""
            Me.Nombres = ""
            Me.NumeroDoc = ""

            Me.NivelUsuario = 0
            Me.IDDependenciaPerfil = -1
            Me.rdbActivo.Checked = True

            Me.txtUsuario.Focus()

        End Sub
#End Region
#Region "Form"

        Private Sub Mantenimiento(ByVal Nuevo As Boolean)
            Dim frm As Object

            Select Case PerfilUsuarioEnSession
                Case Type.Enumeracion.Usuario.EnumDependencia.JefeGrupoSeguridad,
                      Type.Enumeracion.Usuario.EnumDependencia.JefeSeguridad
                    frm = New Sistema.Seguridad.Usuario.frmUsuarioPopup_v5
                Case Else
                    frm = New Sistema.Seguridad.Usuario.frmUsuarioPopupBasico
            End Select

            frm._limitarAccesoSoloHuella = True
            frm.IDUsuario = If(Nuevo, -1, Me.GrillaCodigo)

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Buscar()
            End If

        End Sub
        Private Sub FRM_EnviarCorreo()

            Dim frm As New Sistema.Seguridad.Usuario.frmEnviarCorreo

            frm._IDUsuario = Me.GrillaCodigo
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            End If

        End Sub
#End Region

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub


        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then
                        .Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then Mantenimiento(False)

        End Sub

        Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurar.Click

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea restaurar la clave del usuario seleccionado") = Windows.Forms.DialogResult.Yes Then
                ARestaurarClave()
                Buscar()
            End If

        End Sub

        Private Sub frmBuscar_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ComboDependencia()
            ComboTipoLicencia()

        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Buscar()

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtUsuario.KeyPress, txtApellidos.KeyPress, txtNombres.KeyPress, txtNumDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then Buscar()

        End Sub


        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
            If Me.dgwGrilla.RowCount > 0 Then Mantenimiento(False)
        End Sub

        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
            ALimpiar()
        End Sub


        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            Select Case e.ColumnIndex
                Case Me.dgwGrilla.Columns("col_fec_cre").Index, Me.dgwGrilla.Columns("col_fec_mod").Index
                    If IsNumeric(e.Value) And e.Value > 1 Then
                        e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                    Else
                        e.Value = ""
                    End If
            End Select


        End Sub
    End Class
End Namespace
