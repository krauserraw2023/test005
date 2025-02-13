Namespace Visita.InternoPJ
    Public Class frmBuscar
        Private objBss As Bussines.Visita.InternoPJ = Nothing
        Private objEntCol As Entity.Visita.InternoPJCol = Nothing
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDInterno() As Integer
            Get
                Dim _int As Integer = -1

                If dgwGrilla.SelectedRows.Count = 1 Then
                    _int = dgwGrilla.SelectedRows(0).Cells("col_int_id").Value.ToString


                End If
                Return _int
            End Get
        End Property
        Private ReadOnly Property GrillaIDRegion() As Integer
            Get
                Dim value As Integer = -1
                Try
                    If dgwGrilla.SelectedRows.Count = 1 Then
                        value = dgwGrilla.SelectedRows(0).Cells("col_reg_id").Value.ToString
                    End If

                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaRegionNombre() As String
            Get
                Dim value As String = ""

                If dgwGrilla.SelectedRows.Count = 1 Then

                    value = dgwGrilla.SelectedRows(0).Cells("col_reg_nom").Value.ToString
                End If

                Return value
            End Get
        End Property
        Private Property GrillaIDPenal() As Integer
            Get
                Dim _int As Integer = -1

                If dgwGrilla.SelectedRows.Count = 1 Then
                    _int = dgwGrilla.SelectedRows(0).Cells("col_pen_id").Value.ToString

                End If
                Return _int
            End Get
            Set(ByVal value As Integer)

            End Set
        End Property
        Private ReadOnly Property GrillaPenalNombre() As String
            Get
                Dim value As String = ""

                If dgwGrilla.SelectedRows.Count = 1 Then

                    value = dgwGrilla.SelectedRows(0).Cells("col_pen_nom").Value.ToString
                End If

                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private Property IDRegion() As Integer
            Get
                Return Me.UsrRegionPenal1._RegionID
            End Get
            Set(ByVal value As Integer)
                Me.UsrRegionPenal1._RegionID = value
            End Set
        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.UsrRegionPenal1._RegionNombre
            End Get
        End Property
        Private Property IDPenal() As Integer
            Get
                Return Me.UsrRegionPenal1._PenalID
            End Get
            Set(ByVal value As Integer)
                Me.UsrRegionPenal1._PenalID = value
            End Set
        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.UsrRegionPenal1._PenalNombre
            End Get
        End Property

        Private Property PrimerApellido() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property PreNombres() As String
            Get
                Return Me.txtNom.Text
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private ReadOnly Property Estado() As Integer
            Get
                Dim _int As Integer = -1
                If Me.rb_activo.Checked Then
                    _int = 1
                ElseIf rb_pasivo.Checked Then
                    _int = 0
                End If
                Return _int
            End Get

        End Property
        Private Property IDTipoDocumento As Short
            Get
                Return Me.cbbTipoDocumento.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbTipoDocumento.SelectedValue = value
            End Set
        End Property
        Private Property NumeroDocumento As String
            Get
                Return Me.txtNumDoc.Text
            End Get
            Set(value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property PabellonID() As Short
            Get
                Return Me.cbbPabellon._SelectedValue
            End Get
            Set(ByVal value As Short)
                Me.cbbPabellon._SelectedValue = value
            End Set
        End Property
        Private idDocumentoControl As Integer = -1
#End Region
#Region "Combo"
        Private Sub ComboRegionPenal()

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._LoadUsc()
            End With

        End Sub
        Private Sub ComboPabellon()

            If Me.IDPenal > 0 Then
                With Me.cbbPabellon
                    ._RegionID = Me.IDRegion
                    ._PenalID = Me.IDPenal
                    ._Todos = True
                    ._LoadUsc()
                End With
            End If
        End Sub

        Private Sub Combo()
            Me.cbbTipoDocumento._Todos = True
            Me.cbbTipoDocumento.LoadUsc()
           
        End Sub
       
#End Region

#Region "Listar"
        Public Sub Buscar()


            objBss = New Bussines.Visita.InternoPJ
            objEntCol = New Entity.Visita.InternoPJCol

            Dim objEntFiltro As New Entity.Visita.InternoPJ

            With objEntFiltro
                .IDRegion = Me.IDRegion
                .IDPenal = Me.IDPenal
                .PrimerApellido = Me.PrimerApellido
                .SegundoApellido = Me.SegundoApellido
                .PreNombres = Me.PreNombres
                .Estado = Me.Estado
                .IDTipoDocumento = Me.IDTipoDocumento
                .NumeroDocumento = Me.NumeroDocumento
                .IDPabellon = Me.PabellonID
            End With

            objEntCol = objBss.ListarGrilla(objEntFiltro)

            'no aparecen la columna en la exportacion
            Me.col_chk.Tag = "1"

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AutoGenerateColumns = False
                .MultiSelect = False
                .DataSource = objEntCol

                Me.lblReg.Text = Me.dgwGrilla.RowCount() & " Reg."

            End With

        End Sub

#End Region
#Region "Accion"

        Public Sub AExportar()

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub
        Private Sub Limpiar()
            Me.NumeroDocumento = ""
            Me.PrimerApellido = ""
            Me.SegundoApellido = ""
            Me.PreNombres = ""
            Me.IDTipoDocumento = -1
            Me.PabellonID = -1
            Buscar()
            Me.txtApePat.Focus()
        End Sub
#End Region
#Region "Form"

        Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean)

            Dim blnValue As Boolean = False
            Dim intIDInterno As Integer = -1
            Dim intIDRegion As Integer = -1
            Dim strRegion As String = ""
            Dim intIDPenal As Integer = -1
            Dim strPenal As String = ""

            If Nuevo = True Then

                Dim frm As New frmPenalPopup
                With frm
                    ._TipoCombo = frmPenalPopup.enumTipoCombo.Visitas
                    .BRegion = Me.IDRegion
                    .BPenal = Me.IDPenal

                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        intIDRegion = .RegionID
                        strRegion = .RegionNombre
                        intIDPenal = .PenalID
                        strPenal = .PenalNombre
                        blnValue = True
                    End If
                End With
            Else
                blnValue = True
                intIDInterno = Me.GrillaIDInterno
                intIDRegion = Me.GrillaIDRegion
                strRegion = Me.GrillaRegionNombre
                intIDPenal = Me.GrillaIDPenal
                strPenal = Me.GrillaPenalNombre
            End If

            If blnValue = True Then

                Dim frm As New Visita.InternoPJ.frmMant
                frm.MdiParent = Me.MdiParent
                With frm
                    ._IDInternoPJ = intIDInterno
                    ._IDRegion = intIDRegion
                    ._RegionNombre = strRegion
                    ._IDPenal = intIDPenal
                    ._PenalNombre = strPenal
                    'permisos
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                    .Show()

                End With
            End If

        End Sub

#End Region
#Region "Permisos/Acceso/Perfiles"

        Private Sub UsuarioPermisos()

            Me.pnlModificar.Visible = Me._FormEscritura
            Me.pnlInactivar.Visible = Me._FormEscritura

            Me.pnlExportar.Visible = Me._FormReporte

        End Sub
#End Region
#Region "Otros"
        Private Sub InactivarInternoMasivo()

            'validar registro seleccionados
            Dim intCount As Integer = 0

            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows
                If fila.Cells("col_chk").Value = True Then
                    intCount = intCount + 1
                End If
            Next

            If intCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Selecione uno o mas internos, para utilizar esta opcion")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Esta seguro de inactivar a los interno(s) seleccionado(s)") _
                <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim intCodigo As Integer = -1

            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                If fila.Cells("col_chk").Value = True Then
                    intCodigo = fila.Cells("col_int_id").Value
                    InactivarInterno(intCodigo)
                End If

            Next

            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            Buscar()

        End Sub
        Private Function InactivarInterno(intIDInterno As Integer) As Integer

            Dim value As Integer = -1

            objBss = New Bussines.Visita.InternoPJ
            value = objBss.InactivarInterno(intIDInterno)

            Return value

        End Function
        Private Sub ValoresxDefault()

            ComboRegionPenal()
            ComboPabellon()
            Combo()

        End Sub

#End Region

        Private Sub frmBuscar_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
            Buscar()
        End Sub

        
        Private Sub frmInternoBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()
            UsuarioPermisos()

        End Sub

        Private Sub btnSalirBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirBusqueda.Click

            Me.Close()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            AExportar()
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            FRM_Mantenimiento(True)

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            FRM_Mantenimiento(False)

        End Sub

        Private Sub frmInternoBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            Me.col_fec_ing.Tag = "fecha"
            Me.col_fec_egr.Tag = "fecha"
            Me.WindowState = FormWindowState.Maximized
            Me.Refresh()

        End Sub


        Private Sub btnInactivar_Click(sender As System.Object, e As System.EventArgs) Handles btnInactivar.Click

            InactivarInternoMasivo()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If e.RowIndex >= 0 And Me.dgwGrilla.RowCount > 0 Then
                FRM_Mantenimiento(False)
            End If

        End Sub

        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click

            Limpiar()

        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_fec_ing").Index, .Columns("col_fec_egr").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Format(Legolas.Components.FechaHora.FechaDate(e.Value), "dd/MM/yyyy")
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

       
        Private Sub UsrRegionPenal1__PenalSelectedIndexChanged() Handles UsrRegionPenal1._PenalSelectedIndexChanged
            ComboPabellon()
        End Sub
        Private Sub chkSelect_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSelect.CheckedChanged
            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows
                If chkSelect.Checked = True Then
                    fila.Cells("col_chk").Value = True
                Else
                    fila.Cells("col_chk").Value = False
                End If
            Next
        End Sub

        Private Sub txtNumDoc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress
            Select Case Me.IDTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    txtNumDoc.MaxLength = 8
                    txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                Case Type.Enumeracion.enmTipoDocumento.LM
                    txtNumDoc.MaxLength = 20
                    txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                Case Else
                    txtNumDoc.MaxLength = 20
                    txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            End Select

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If
        End Sub

       
        Private Sub cbbTipoDocumento__SelectedIndexChanged() Handles cbbTipoDocumento._SelectedIndexChanged
            If Me.IDTipoDocumento <> idDocumentoControl Then
                idDocumentoControl = Me.IDTipoDocumento
                txtNumDoc.Text = ""
                txtNumDoc.Focus()
            End If
        End Sub

        Private Sub txtNumDoc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumDoc.TextChanged
            If Me.IDTipoDocumento = Type.Enumeracion.enmTipoDocumento.DNI Or Me.IDTipoDocumento = Type.Enumeracion.enmTipoDocumento.LM Then
                Select Case Me.NumeroDocumento
                    Case "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "V", "W", "X", "Y", "Z"
                        Me.NumeroDocumento = ""
                End Select
            End If

        End Sub

        Private Sub txtApePat_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApePat.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If
        End Sub

        Private Sub txtApeMat_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApeMat.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If
        End Sub

        Private Sub txtNom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If
        End Sub
    End Class
End Namespace
