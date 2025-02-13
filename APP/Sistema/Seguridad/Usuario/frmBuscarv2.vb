Namespace Sistema.Seguridad.Usuario
    Public Class frmBuscar
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
                Dim value As Integer = -1

                If Me.cbbNivelUsuario.SelectedIndex < 1 Then
                    value = -1
                Else
                    value = Me.cbbNivelUsuario.SelectedIndex
                End If

                Return value
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

                If Me.rdbActivo.Checked = True Then
                    intValue = 0
                End If

                If Me.rdbBaja.Checked = True Then
                    intValue = 1
                End If

                Return intValue

            End Get
        End Property

#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_usu_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaLogin() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_log").Value.ToString.ToUpper
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaApellidos() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_ape").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaNombres() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaApeNom() As String
            Get
                Dim strValue As String = ""
                strValue = Me.GrillaApellidos & ", " & Me.GrillaNombres
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

            Dim objBssDepe As New Bussines.Mantenimiento.General.Dependencia

            With Me.cbbDependencia
                .DataSource = objBssDepe.Listar(Me.NivelUsuario, True)
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

            Dim strValue As String = ""
            lblReg.Text = Me.NumeroReg & " Reg."

        End Sub
        Private Sub Buscar()

            Me.col_fec_cre.Tag = "fecha_hora"
            Me.col_fec_mod.Tag = "fecha_hora"

            objBss = New Bussines.Seguridad.Usuario
            objEntCol = New Legolas.LEntity.Seguridad.UsuarioCol

            objEntCol = objBss.ListarGrilla(-1, _
            Me.Login, Me.Apellidos, Me.Nombres, Me.NumeroDoc, Me.NivelUsuario, Me.IDDependenciaPerfil, Me.EstadoUsuario)

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

            If Me.GrillaCodigo < 1 Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            objBss = New Bussines.Seguridad.Usuario

            intValue = objBss.RestaurarClave(Me.GrillaCodigo, Me.GrillaLogin)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information( _
                "La contraseña ha sido restaurada satisfactoriamente")

                If Legolas.Configuration.Aplication.MessageBox.Question("Desea enviar los credenciales del usuario por correo electronico") = Windows.Forms.DialogResult.Yes Then
                    FRM_EnviarCorreo()
                End If

            End If

        End Sub
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                objBss = New Bussines.Seguridad.Usuario
                Dim intValue As Integer = -1

                objBss.Eliminar(Me.GrillaCodigo)
                Buscar()
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

            'Dim frm As New Sistema.Seguridad.Usuario.frmUsuarioPopupv4
            Dim frm As New Sistema.Seguridad.Usuario.frmUsuarioPopup_v5

            With frm
                If Nuevo = True Then
                    .IDUsuario = -1
                Else
                    .IDUsuario = Me.GrillaCodigo
                End If

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If
            End With
        End Sub
        Private Sub FRM_EnviarCorreo()

            Dim frm As New Sistema.Seguridad.Usuario.frmEnviarCorreo
            With frm
                ._IDUsuario = Me.GrillaCodigo
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                End If
            End With
        End Sub
#End Region

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
            AEliminar()
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

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                Mantenimiento(False)
            End If

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
        txtUsuario.KeyPress, _
        txtApellidos.KeyPress, _
 _
        txtNombres.KeyPress, _
        txtNumDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub


        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            Mantenimiento(True)

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


            If Me.dgwGrilla.RowCount > 0 Then
                Mantenimiento(False)
            End If

        End Sub

        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click

            ALimpiar()

        End Sub


        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting


            With Me.dgwGrilla

                Select Case e.ColumnIndex

                    Case .Columns("col_fec_cre").Index, .Columns("col_fec_mod").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If

                End Select

            End With

        End Sub
    End Class
End Namespace
