Namespace Visita.InternoPJ
    Public Class frmInternoPopup
        Private objBss As Bussines.Visita.InternoPJ = Nothing
        Private objEntCol As Entity.Visita.InternoPJCol = Nothing

        Private frmLoad As Load.frmLoad = Nothing
#Region "Propiedades_Parametricas"
        Private lngFechaVisita As Long = 0
        Public Property _IDPenal() As Integer
            Get
                Return Me.UscRegionPenalLabel1._Penalid
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._Penalid = value
            End Set
        End Property
        Public Property _PenalNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._PenalNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._PenalNombre = value
            End Set
        End Property
        Public Property _IDRegion() As Integer
            Get
                Return Me.UscRegionPenalLabel1._RegionId
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._RegionId = value
            End Set
        End Property
        Public Property _RegionNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._RegionNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._RegionNombre = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private intNumeroReg As Integer = -1
        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                ListarNumeroReg()
            End Set
        End Property

        Private ReadOnly Property GrillaIDInternoPJ() As Integer
            Get
                Dim _int As Integer = -1

                If dgwGrilla.SelectedRows.Count = 1 Then
                    _int = dgwGrilla.SelectedRows(0).Cells("col_id").Value.ToString


                End If
                Return _int
            End Get
        End Property
        Public ReadOnly Property _GrillaIDInterno As Integer
            Get
                Return Me.GrillaIDInternoPJ
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
        Private idDocumentoControl As Integer = -1
#End Region

#Region "Propiedades_Return"
        Public ReadOnly Property _GrillaIDInternoPJ() As Integer
            Get
                Return Me.GrillaIDInternoPJ
            End Get
        End Property      
        Public Property _TipoForm() As Integer = 0
#End Region
#Region "Propiedades_Buscar"
        Private Property IDTipoDocumento() As Integer
            Get
                Return Me.cbbTipoDocumento.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDocumento.SelectedValue = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property Apellidos() As String
            Get
                Return Me.txtApe.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApe.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Load"
        Private intIDTipoDocumento As String = ""
        Private strLoadNumDoc As String = ""
        Private strLoadApe As String = ""
        Private strLoadNombres As String = ""
        Private intLoadEstado As Integer = -1
        Private intLoadRegion As Integer = -1
        Private intLoadPenal As Integer = -1
#End Region
#Region "Propiedades_Otros"

        'Private intTipoForm As Integer = 0

        'Public Property _TipoForm() As Integer
        '    Get
        '        Return intTipoForm
        '    End Get
        '    Set(ByVal value As Integer)
        '        intTipoForm = value
        '    End Set
        'End Property

        Public Property _VisibleRegionPenal() As Boolean
            Get
                Return Me.gbRegionPenal.Visible
            End Get
            Set(value As Boolean)
                Me.gbRegionPenal.Visible = value
            End Set
        End Property

#End Region
#Region "Functions"
        Private Function ValidarBusqueda() As Boolean
            Dim value As Boolean = False

            If Me.IDTipoDocumento < 1 And Me.NumeroDocumento.Trim = "" And Me.Apellidos.Trim = "" And Me.Nombres.Trim = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los apellidos a buscar")
                Me.txtApe.Focus()
                Return value
            End If

            value = True
            Return value
        End Function
#End Region

#Region "Combo"

        Private Sub Combo()

            With Me.cbbTipoDocumento
                ._Todos = True
                ._LoadUsc(Type.Combo.ComboTipo.TipoDoc)
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub LoadPropiedades()

            intIDTipoDocumento = Me.IDTipoDocumento
            strLoadNumDoc = Me.NumeroDocumento
            strLoadApe = Me.Apellidos
            strLoadNombres = Me.Nombres
            intLoadEstado = 1 'activo
            intLoadRegion = Me._IDRegion
            intLoadPenal = Me._IDPenal

        End Sub
        Private Sub ListarNumeroReg()

            Dim strValue As String = ""
            'Me.lblReg.Text = Me.NumeroReg & " Reg."
            Me.lblReg.Text = Me.dgwGrilla.RowCount() & " Reg."

        End Sub
        Private Function Listar() As Boolean

            objBss = New Bussines.Visita.InternoPJ
            objEntCol = New Entity.Visita.InternoPJCol

            Dim objEntFiltro As New Entity.Visita.InternoPJ
            With objEntFiltro

                .IDTipoDocumento = Me.intIDTipoDocumento
                .Apellidos = Me.strLoadApe
                .PreNombres = Me.strLoadNombres
                .NumeroDocumento = Me.strLoadNumDoc
                .Estado = 1 'internos activos
                .IDRegion = Me.intLoadRegion
                .IDPenal = Me.intLoadPenal
            End With

            objEntCol = objBss.ListarGrilla(objEntFiltro)

            Return True

        End Function
        Private Sub Buscar()

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            LoadPropiedades()

            Me.SuspendLayout()
            Me.Timer1.Start()
            frmLoad = New Load.frmLoad
            frmLoad.ShowDialog()
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.NumeroReg = .RowCount()

                If .Rows.Count > 0 Then
                    .Rows(0).Selected = True
                End If

            End With

        End Sub
#End Region

#Region "Accion"

        Private Sub AOk()

            If Me.dgwGrilla.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
        Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean)

            Dim blnValue As Boolean = False
            Dim intIDInterno As Integer = -1
            Dim intIDRegion As Integer = -1
            Dim strRegion As String = ""
            Dim intIDPenal As Integer = -1
            Dim strPenal As String = ""

            If Nuevo = True Then
                intIDRegion = Me._IDRegion
                strRegion = Me._RegionNombre
                intIDPenal = Me._IDPenal
                strPenal = Me._PenalNombre
            Else
                intIDInterno = Me.GrillaIDInternoPJ
                intIDRegion = Me._IDRegion ' Me.GrillaIDRegion
                strRegion = Me._RegionNombre
                intIDPenal = Me._IDPenal ' Me.GrillaIDPenal
                strPenal = Me._PenalNombre
            End If
            blnValue = True

            If blnValue = True Then

                Dim frm As New Visita.InternoPJ.frmMantInternoPopup
                frm.MdiParent = Me.MdiParent
                With frm
                    If Nuevo = True Then
                        ._IDInternoPJ = -1
                    Else
                        ._IDInternoPJ = Me.GrillaIDInternoPJ
                    End If
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
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        If Me.cbbTipoDocumento.SelectedValue > 0 Then
                            Buscar()
                        End If
                    End If

                End With
            End If

        End Sub
#End Region
#Region "Form"

#End Region
#Region "Otros"
        Private Sub ALimpiar()

            Me.IDTipoDocumento = -1
            Me.NumeroDocumento = ""
            Me.Apellidos = ""
            Me.Nombres = ""
            Me.txtApe.Focus()

        End Sub
        Private Sub ValoresxDefault()

            Combo()

            If Me._IDPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Falta enviar la Propiedad _PenalID")
                Exit Sub
            End If

        End Sub
#End Region
        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

            If Me.BackgroundWorker1.IsBusy Then Exit Sub
            ' inicializa la validacion del ping
            Me.BackgroundWorker1.RunWorkerAsync()

        End Sub

        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            e.Result = Listar()

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            'frmLoad.Dispose()
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                Me.Timer1.Stop()
                frmLoad.Close()
                result = e.Result
                ' procesa el resultado del metodo ping        
            End If

        End Sub
        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
 _
 _
        txtApe.KeyPress, _
 _
        txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

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

            If Me.dgwGrilla.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Busque y seleccione el interno")
                Exit Sub
            End If

            With Me.dgwGrilla
                AOk()
            End With


        End Sub

        Private Sub frmInternoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.txtApe.Focus()

        End Sub

        Private Sub frmInternoPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click

            ALimpiar()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            If Me.dgwGrilla.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Busque y seleccione el interno")
                Exit Sub
            End If

            With Me.dgwGrilla               
                AOk()
            End With

        End Sub

        Private Sub btnOtro_Click(sender As System.Object, e As System.EventArgs) Handles btnOtro.Click

            Me._TipoForm = 1
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
            FRM_Mantenimiento(True)
        End Sub

        Private Sub cbbTipoDocumento__SelectedIndexChanged() Handles cbbTipoDocumento._SelectedIndexChanged
            If Me.IDTipoDocumento <> idDocumentoControl Then
                idDocumentoControl = Me.IDTipoDocumento
                Me.txtNumDoc.Text = ""
                Me.txtNumDoc.Focus()
            End If
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

     
        Private Sub txtNumDoc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumDoc.TextChanged
            If Me.IDTipoDocumento = Type.Enumeracion.enmTipoDocumento.DNI Or Me.IDTipoDocumento = Type.Enumeracion.enmTipoDocumento.LM Then
                Select Case Me.NumeroDocumento
                    Case "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "V", "W", "X", "Y", "Z"
                        Me.NumeroDocumento = ""
                End Select
            End If
        End Sub

        Private Sub txtApe_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApe.TextChanged

        End Sub
    End Class
End Namespace


