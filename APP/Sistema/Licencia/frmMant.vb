Namespace Sistema
    Public Class frmMant
        Private objBss As Bussines.Sistema.Instalacion = Nothing
        Private objEnt As Entity.Sistema.Instalacion = Nothing
        Private blncarga As Boolean = False
        Private blnComboRegion As Boolean = False

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
        Private Property Nombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Private Property TipoLicencia() As Integer
            Get
                Return Me.cbbTipoLicencia.SelectedIndex
            End Get
            Set(ByVal value As Integer)

                Me.cbbTipoLicencia.SelectedIndex = value

            End Set
        End Property
        Private Property NombreCorto() As String
            Get
                Return Me.txtNombreCor.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombreCor.Text = value
            End Set
        End Property
        Private Property Descripcion() As String
            Get
                Return Me.txtDes.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDes.Text = value
            End Set
        End Property
        Private Property Fecha() As Long
            Get
                Return Me.dtpFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFecha.ValueLong = value
            End Set
        End Property
        Private Property IDRegion() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property IDPenal() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private Property VersionApp() As String
            Get
                Return Me.txtVerApp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVerApp.Text = value
            End Set
        End Property
        Private Property VersionBD() As String
            Get
                Return Me.txtVerBD.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVerBD.Text = value
            End Set
        End Property
        Private Property LogMein() As Boolean
            Get
                Return Me.chkLogMein.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkLogMein.Checked = value
            End Set
        End Property
        Private Property Internet() As Boolean
            Get
                Return Me.chkInternet.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkInternet.Checked = value
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
#Region "Propiedades_Grilla"
        Private intNumeroReg As Integer = 0
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaInstalacion() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_ins_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaRegion() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaRegionNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_reg_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaPenal() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaPenalNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_pen_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboTipoLicencia()

            With Me.cbbTipoLicencia
                .Items.Add("")
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.Sede.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.MedioLibreLimaMetropolitana.ToString)
            End With

        End Sub
        Private Sub Combo()
            ComboTipoLicencia()
            Me.cbbRegion.LoadUsc()
            blnComboRegion = True
        End Sub
        Private Sub ComboPenal()

            Me.cbbPenal.CodigoPadre = Me.IDRegion
            Me.cbbPenal._LoadUsc(Type.Combo.ComboTipo.Penal)

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Sistema.Instalacion
            'objEnt =new  Entity.Sistema.Instalacion 

            objEnt = objBss.Listar(Me.Codigo)

            With objEnt
                Me.Nombre = .Nombre
                Me.TipoLicencia = .Tipo
                Me.NombreCorto = .NombreCorto
                Me.Descripcion = .Descripcion
                Me.Fecha = .Fecha
                Me.IDRegion = .RegionID
                Me.IDPenal = .IDPenal
                Me.VersionApp = .VersionApp
                Me.VersionBD = .VersionBD
                Me.LogMein = .Logmein
                Me.Internet = .Internet
                Me.Obs = .Obs
            End With

            MostrarPenal()
            ListarDetalle()

        End Sub
        Private Sub ListarDetalle()

            Dim objBss As New Bussines.Sistema.InstalacionDetalle
            Dim objEntCol As New Entity.Sistema.InstalacionDetalleCol

            objEntCol = objBss.Listar(-1, Me.Codigo, -1, -1, False, False)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

        End Sub

#End Region
#Region "Accion"
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Dim intValue As Integer = -1
                Dim objBss As New Bussines.Sistema.InstalacionDetalle
                intValue = objBss.Eliminar(Me.GrillaCodigo)

                If intValue > 0 Then
                    ListarDetalle()
                End If

            End If

        End Sub
        Private Function Validar() As Boolean
            Dim value As Boolean = False

            If Me.TipoLicencia < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de licencia")
                Me.cbbTipoLicencia.Focus()
                Return False
            End If

            Select Case Me.TipoLicencia

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana,
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia

                    If Me.IDPenal < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Penal")
                        Me.cbbPenal.Focus()
                        Return False
                    End If
                    
            End Select

            value = True
            Return value

        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            objBss = New Bussines.Sistema.Instalacion
            Dim intValue As Integer = -1

            intValue = objBss.Grabar(Me.Codigo, Me.TipoLicencia, Me.Nombre, Me.Descripcion, Me.Fecha, _
            Me.NombreCorto, Me.IDRegion, Me.IDPenal, _
            Me.LogMein, Me.Internet, Me.VersionApp, Me.VersionBD, Me.Obs)

            If intValue > 0 Then
                Me.Codigo = intValue
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub FRMPenal()

            If Me.Codigo < 1 Then
                MessageBox.Show("Haga clicl en [Aceptar], antes de agregar los penales", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim frm As New Seguridad.Licencia.frmPenal
            With frm
                .TipoForm = 2 'instalacion
                .InstalacionID = Me.Codigo
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarDetalle()
                End If
            End With

        End Sub
        Private Sub FRMInstalacionDetalle(ByVal Nuevo As Boolean)

            Dim frm As New Sistema.frmDetallePopup
            With frm
                If Nuevo = True Then
                    .Codigo = -1
                Else
                    .Codigo = Me.GrillaCodigo
                End If
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ListarDetalle()
                End If
            End With
        End Sub
        Private Sub MostrarPenal()

            Select Case Me.TipoLicencia

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana,
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
                     Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia

                    Me.pnlPenal.Visible = True

                Case Else

                    Me.pnlPenal.Visible = False
            End Select

        End Sub
        Private Sub ValoresxDefault()
            Combo()
            ComboPenal()
        End Sub
#End Region
       

        Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        End Sub

        Private Sub frmMant_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()
            ListarData()
            blncarga = True

        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                FRMInstalacionDetalle(False)
            End If

        End Sub

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete Then
                AEliminar()
            End If

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnAddPenal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPenal.Click
            FRMPenal()

        End Sub

        Private Sub cbbTipoLicencia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbTipoLicencia.SelectedIndexChanged

            If blncarga = True Then
                MostrarPenal()
            End If

        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            If blnComboRegion = True Then
                ComboPenal()
            End If

        End Sub

        Private Sub cbbRegion_Load(sender As System.Object, e As System.EventArgs) Handles cbbRegion.Load

        End Sub
    End Class
End Namespace
