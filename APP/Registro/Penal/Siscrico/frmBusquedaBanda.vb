Namespace Registro.Siscrico
    Public Class frmBusquedaBanda
        Private objBss As Bussines.Registro.Banda = Nothing
        Private objEntCol As Entity.Registro.BandaCol = Nothing
        Private objEntBand As Entity.Registro.Banda = Nothing

        Private intBandaIdSel As Integer = -1
        Private strBandaTipNomSel As String = ""
        Private strBandaNomSel As String = ""
        Private intRegionid As Integer = -1
        Private intPenalId As Integer = -1
        Private intFiltrarTipBandPor As Integer = -1
#Region "Propiedades"
        Private Property BandaTipoID() As Integer
            Get
                Return Me.cbbBandaTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbBandaTipo.SelectedValue = value
            End Set
        End Property
        Private Property BandaNombre() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property

        Public Property _BandaIdSel() As Integer
            Get
                Return intBandaIdSel
            End Get
            Set(value As Integer)
                intBandaIdSel = value
            End Set
        End Property
        Public Property _BandaNomSel() As String
            Get
                Return strBandaNomSel
            End Get
            Set(value As String)
                strBandaNomSel = value
            End Set
        End Property
        Public Property _BandaTipoIDSelect As Short = -1
        Public Property _BandaTipNomSel() As String
            Get
                Return strBandaTipNomSel
            End Get
            Set(value As String)
                strBandaTipNomSel = value
            End Set
        End Property
        Public Property _RegionIdSel() As Integer
            Get
                Return intRegionid
            End Get
            Set(value As Integer)
                intRegionid = value
            End Set
        End Property
        Public Property _PenalIdSel() As Integer
            Get
                Return intPenalId
            End Get
            Set(value As Integer)
                intPenalId = value
            End Set
        End Property
        Public Property _FiltrarTipoBandaPor() As Integer
            Get
                Return intFiltrarTipBandPor
            End Get
            Set(value As Integer)
                intFiltrarTipBandPor = value
            End Set
        End Property
        Public Property _InabilitarComboBanTip() As Boolean = False
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaID() As Integer
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
        Private Sub GrillaCount(ByVal Rows As Integer)
            Me.lblReg.Text = Rows.ToString & " Reg."
        End Sub
        Private ReadOnly Property _GrillaRegionId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property _GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property _GrillaRegionNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_nom_reg").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property _GrillaPenalNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_nom_pen").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()
            With Me.cbbBandaTipo
                ._Todos = True
                .LoadUsc()
            End With
        End Sub

#End Region
#Region "Listar"
        Private Sub Listar()

            objBss = New Bussines.Registro.Banda
            objEntCol = New Entity.Registro.BandaCol
            objEntBand = New Entity.Registro.Banda

            objEntBand.BandaTipoID = Me.BandaTipoID
            objEntBand.BandaNombre = Me.BandaNombre
            objEntCol = objBss.Listar(objEntBand)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                GrillaCount(.RowCount())
            End With
        End Sub
#End Region
#Region "Accion"
        Private Sub AMantBanda(ByVal Nuevo As Boolean)
            Dim frmb As New Mantenimiento.Banda.frmMantBandaPopup
            If Nuevo = True Then
                With frmb
                    .Codigo = -1
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        Listar()
                    End If
                End With
            Else 'editar banda 
                If dgwGrilla.Rows.Count < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                    "Debe buscar y seleccionar el registro para su edición")
                    Exit Sub
                End If
                With frmb
                    .Codigo = Me.GrillaID
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        Listar()
                    End If
                End With
            End If

        End Sub
        Private Sub AEliminar()
            If dgwGrilla.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Debe buscar y seleccionar el registro para completar la operación solicitada")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then
                objBss = New Bussines.Registro.Banda
                objBss.Eliminar(Me.GrillaID)
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Listar()
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            Combo()


            cbbBandaTipo.SelectedValue = Me._FiltrarTipoBandaPor
            If Me._InabilitarComboBanTip = True Then
                cbbBandaTipo.Enabled = False
            Else
                cbbBandaTipo.Enabled = True
            End If

            'Me.WindowState = FormWindowState.Normal
        End Sub
#End Region

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub txtNom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                Listar()
            End If
        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            Listar()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If dgwGrilla.Rows.Count < 1 Then Exit Sub
            Me._BandaIdSel = dgwGrilla.SelectedRows(0).Cells("col_id").Value
            Me._BandaNomSel = dgwGrilla.SelectedRows(0).Cells("colNombre").Value
            Me._BandaTipoIDSelect = dgwGrilla.SelectedRows(0).Cells("col_ban_tip_id").Value
            Me._BandaTipNomSel = dgwGrilla.SelectedRows(0).Cells("colTipo").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            btnAceptar_Click(Nothing, Nothing)
        End Sub

        Private Sub dgwGrilla_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                btnAceptar_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub frmBusquedaBanda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            txtNom.Select()
        End Sub
        Private Sub frmBusquedaBanda_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ValoresxDefault()
        End Sub
    End Class
End Namespace