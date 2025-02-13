Namespace Registro.Busqueda
    Public Class frmInternoPopup
        Private objBss As Bussines.Registro.Interno_Grilla = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
        Private frmLoad As Load.frmLoad = Nothing
#Region "Propiedades_Parametricas"
        Private lngFechaVisita As Long = 0
        Public Property _PenalID() As Integer
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
        Public Property _RegionID() As Integer
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
        Public ReadOnly Property _GrillaInternoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaInternoPadre() As Short
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_pdr").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _GrillaCodigoRP() As String
            Get
                Dim value As String = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_cod_rp").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _GrillaApellidos() As String
            Get
                Dim value As String = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_ape").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _GrillaPrimerApellido() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        If Me.GrillaInternoPadre = 0 Then
                            value = .SelectedRows(0).Cells("col_pri_ape").Value
                        Else
                            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                                If fila.Cells("col_int_id").Value = Me._GrillaInternoID _
                                And fila.Cells("col_pdr").Value = 0 Then

                                    value = fila.Cells("col_pri_ape").Value

                                End If
                            Next
                        End If

                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _GrillaSegundoApellido() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        If Me.GrillaInternoPadre = 0 Then
                            value = .SelectedRows(0).Cells("col_seg_ape").Value
                        Else
                            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                                If fila.Cells("col_int_id").Value = Me._GrillaInternoID _
                                And fila.Cells("col_pdr").Value = 0 Then

                                    value = fila.Cells("col_seg_ape").Value

                                End If
                            Next
                        End If

                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _GrillaNombres() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        If Me.GrillaInternoPadre = 0 Then
                            value = .SelectedRows(0).Cells("col_nom").Value
                        Else
                            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                                If fila.Cells("col_int_id").Value = Me._GrillaInternoID _
                                And fila.Cells("col_pdr").Value = 0 Then

                                    value = fila.Cells("col_nom").Value

                                End If
                            Next
                        End If

                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _GrillaApellidosyNombres() As String
            Get
                Dim value As String = ""
                value = Me._GrillaApellidos & ", " & Me._GrillaNombres
                Return value
            End Get
        End Property

        'Private ReadOnly Property GrillaApeNom() As String
        '    Get
        '        Dim strValue As String = -1
        '        Try
        '            With Me.dgwGrilla
        '                strValue = Me.GrillaApellidos
        '                strValue = strValue & ", " & Me.GrillaNombres
        '            End With
        '        Catch ex As Exception

        '        End Try
        '        Return strValue
        '    End Get
        'End Property
#End Region

#Region "Propiedades_Buscar"
        Private Property CodigoRP() As String
            Get
                Return Me.txtCodInterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
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
                Return Me.txtSegundoApe.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApe.Text = value
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
        Private ReadOnly Property IDEstadoInterno() As Integer
            Get
                Dim value As Integer = -1

                If rbFiltroInternoActivo.Checked = True Then
                    value = 1
                End If

                If Me.rbFiltroInternoInactivo.Checked = True Then
                    value = 0
                End If

                Return value
            End Get

        End Property
#End Region
#Region "Propiedades_Load"
        Private strLoadCodigoRP As String = ""
        Private strLoadNumDoc As String = ""
        Private strLoadPrimerApe As String = ""
        Private strLoadSegundoApe As String = ""
        Private strLoadNombres As String = ""
        Private intLoadEstado As Integer = -1
        Private intLoadRegion As Integer = -1
        Private intLoadPenal As Integer = -1
#End Region
#Region "Propiedades_Otros"

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
        Private Function GrillaCountInternosPrincipal() As Integer

            Dim value As Integer = 0
            Dim intCount As Integer = 0

            With Me.dgwGrilla
                .CurrentCell = Nothing
                For Each dr As DataGridViewRow In .Rows

                    If dr.Cells("col_pdr").Value = 0 Then
                        intCount = intCount + 1
                    End If
                Next
            End With
            value = intCount

            Return value

        End Function
        Private Function ValidarBusqueda() As Boolean
            Dim value As Boolean = False

            If Me.CodigoRP.Trim = "" And Me.NumeroDocumento.Trim = "" And Me.PrimerApellido.Trim = "" And Me.SegundoApellido.Trim = "" And Me.Nombres.Trim = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los apellidos del Interno a buscar")
                Me.txtApePat.Focus()
                Return value
            End If

            value = True
            Return value
        End Function


#End Region
#Region "Listar"
        Private Sub LoadPropiedades()

            strLoadCodigoRP = Me.CodigoRP
            strLoadNumDoc = Me.NumeroDocumento
            strLoadPrimerApe = Me.PrimerApellido
            strLoadSegundoApe = Me.SegundoApellido
            strLoadNombres = Me.Nombres
            intLoadEstado = Me.IDEstadoInterno
            intLoadRegion = Me._RegionID
            intLoadPenal = Me._PenalID

        End Sub
        Private Sub ListarNumeroReg()

            Dim strValue As String = ""
            'Me.lblReg.Text = Me.NumeroReg & " Reg."
            Me.lblReg.Text = GrillaCountInternosPrincipal() & " Reg."

        End Sub
        Private Function Listar() As Boolean

            objBss = New Bussines.Registro.Interno_Grilla
            objEntCol = New Entity.Registro.InternoCol

            Dim objEntFiltro As New Entity.Registro.Interno_Grilla
            With objEntFiltro
                .InternoCodigoRP = Me.strLoadCodigoRP
                .PrimerApellido = Me.strLoadPrimerApe
                .SegundoApellido = Me.strLoadSegundoApe
                .PreNombres = Me.strLoadNombres
                .InternoNumeroDocumento = Me.strLoadNumDoc
                .IDInternoEstado = Me.intLoadEstado
                .IDRegion = Me.intLoadRegion
                .IDPenal = Me.intLoadPenal
            End With

            objEntCol = objBss.ListarInternoBusqueda(objEntFiltro, True)

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


        Private Sub ListarInterno(ByVal InternoID As Integer)

            ListarInternoFotoVersion(InternoID)

        End Sub

#End Region
#Region "ListarFoto"
        Private Sub ListarInternoFotov(ByVal InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia2._CheckImagen = False Then
                Me.UscFotografia2._Limpiar()
                Exit Sub
            End If

            Dim objBssFoto As New Bussines.Registro.InternoFoto
            Dim objEnt As New Entity.Registro.InternoFoto
            Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente(InternoID)

            Dim intImagen As Integer = -1
            Dim intNombreImagen As String = ""

            objBssFoto = New Bussines.Registro.InternoFoto
            objEnt = objBssFoto.Listar(intCodigo)

            If objEnt.Codigo > 0 Then

                With objEnt
                    intImagen = .PFrenteID
                    intNombreImagen = .PFrenteName
                End With

                Me.UscFotografia2._ShowFotoInterno(intImagen, intNombreImagen)
            Else
                Me.UscFotografia2._Limpiar()
            End If

        End Sub
        Private Sub ListarInternoFotov5(ByVal InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia_2v1._CheckImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            Dim objBssFoto As New Bussines.Registro.InternoFoto
            Dim objEnt As New Entity.Registro.InternoFoto
            Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente2(InternoID)
            Dim intImagen As Integer = -1

            objBssFoto = New Bussines.Registro.InternoFoto
            objEnt = objBssFoto.ListarGrilla(intCodigo)

            If objEnt.Codigo > 0 Then

                With objEnt
                    intImagen = .PFrenteID
                End With

                Me.UscFotografia_2v1._ShowFotoInterno(intImagen)
            Else
                Me.UscFotografia_2v1._Limpiar()
            End If

        End Sub
        Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

            Dim blnVersion5 As Boolean = Bussines.General.Penal.Version5(Me._PenalID)

            If blnVersion5 = True Then
                ListarInternoFotov5(InternoID)
                Me.UscFotografia_2v1.BringToFront()
            Else
                ListarInternoFotov(InternoID)
                Me.UscFotografia2.BringToFront()

            End If

        End Sub
#End Region
#Region "Accion"

        Private Sub AOk()

            If Me.dgwGrilla.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ALimpiar()

            Me.txtCodInterno.Text = ""
            Me.txtNumDoc.Text = ""
            Me.txtApePat.Text = ""
            'Me.txtApeMat.Text = ""
            Me.txtNom.Text = ""
            Me.txtApePat.Focus()

        End Sub
        Private Sub ValoresxDefault()

            If Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "Falta enviar la Propiedad _PenalID")
                Exit Sub
            End If

        End Sub
        Public Sub _MostrarRadionButonEstado()
            Me.rbFiltroInternoActivo.Visible = False
            Me.rbFiltroInternoInactivo.Visible = False
            Me.rbFiltroTodos.Visible = False
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
        txtApePat.KeyPress, _
 _
        txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub


        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                AOk()
            End If

        End Sub

        Private Sub frmInternoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.txtApePat.Focus()

        End Sub

        Private Sub frmInternoPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub dgwGrilla_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

            If Me.dgwGrilla.RowCount > 0 And Me._GrillaInternoID > 0 Then
                ListarInterno(Me._GrillaInternoID)
            End If

        End Sub

        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click

            ALimpiar()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            If Me.dgwGrilla.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Busque y seleccione el interno")
                Me.txtApePat.Focus()
                Exit Sub
            End If

            AOk()

        End Sub

        Private Sub dgwGrilla_RowPrePaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint

            With Me.dgwGrilla

                Select Case (.Item("col_pdr", e.RowIndex).Value) 'estado color
                    Case 0 'padres
                        .Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White 'Color.PowderBlue
                        .Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(65, 91, 133) 'Color.Black
                    Case 1 'hijos
                        .Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                        .Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(0, 128, 0) 'Color.Black                        
                End Select
                .Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Black
                .Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            End With

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub txtApePat_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApePat.TextChanged

        End Sub
    End Class
End Namespace


