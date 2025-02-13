Namespace Mantenimiento.Busqueda
    Public Class frmMovimientoMotivoPopup
        Private objBss As Bussines.Mantenimiento.Registro.Movimiento = Nothing
        Private objEntCol As Entity.Mantenimiento.Registro.MovimientoCol = Nothing

#Region "Propiedades"

        Private Property IDTipoMovimiento() As Integer
            Get
                Return Me.cbbTipo.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbTipo.SelectedValue = value
            End Set
        End Property
        Private Property Nombre As String
            Get
                Return Me.txtNombre.Text
            End Get
            Set(value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"

        Public ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Public ReadOnly Property GrillaTipoNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_tip_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Public ReadOnly Property GrillaMotivoNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

#End Region
#Region "Combo"
        Private blnCombo As Boolean = False
        Private Sub Combo()

            objBss = New Bussines.Mantenimiento.Registro.Movimiento
            With Me.cbbTipo
                .DataSource = objBss.ComboTipo()
                .DisplayMember = "MovimientoTipoNombre"
                .ValueMember = "MovimientoTipoID"
            End With
            Me.IDTipoMovimiento = 3 'egresos 
            blnCombo = True

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            objEntCol = New Entity.Mantenimiento.Registro.MovimientoCol
            objBss = New Bussines.Mantenimiento.Registro.Movimiento

            objEntCol = objBss.ListarMotivo(Me.IDTipoMovimiento, Me.Nombre)

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount & " Reg."
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarBusqueda()

            Me.txtNombre.Text = ""
            Me.txtNombre.Focus()

        End Sub
#End Region
        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub
        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

            If Me.GrillaCodigo > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub txtDelitoGenerico_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
                Me.txtNombre.SelectAll()
                Me.txtNombre.Focus()
            End If

        End Sub

        Private Sub frmDelitoPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            Combo()

        End Sub

        Private Sub frmBuscarDelitoPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.txtNombre.Focus()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If dgwGrilla.Rows.Count < 1 Then
                Exit Sub
            End If

            btnOK_Click(Nothing, Nothing)

        End Sub

        Private Sub cbbTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbTipo.SelectedIndexChanged

            If blnCombo = True Then
                Buscar()
            End If

        End Sub

    End Class
End Namespace
