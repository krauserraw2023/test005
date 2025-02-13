Namespace Mantenimiento.Busqueda
    Public Class frmDistritoJudicialPopup
        Private objBss As Bussines.Mantenimiento.AutoridadJudicial = Nothing
        Private objEntCol As Entity.General.ParametricaCol = Nothing

#Region "Propiedades"

        Private Property nombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Private ReadOnly Property estado As Short
            Get
                Dim value As Short = -1

                If rbInactivo.Checked = True Then
                    value = 0
                End If

                If Me.rbVigente.Checked = True Then
                    value = 1
                End If

                If rbHistorico.Checked = True Then
                    value = 2
                End If

                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property grillaCodigo() As Integer
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
        Private ReadOnly Property grillaEstado() As Short
            Get
                Dim value As Short = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_est").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Publicas"
        Public Property getCodigo As Integer = -1

#End Region
#Region "Listar"

        Private Sub Buscar()

            objBss = New Bussines.Mantenimiento.AutoridadJudicial
            objEntCol = New Entity.General.ParametricaCol

            objEntCol = objBss.listarGrilla(Me.nombre, estado)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Color.Black
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount & " Reg."
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AOK()

            If Me.grillaCodigo > 0 Then

                'validar estado del registro, inactivo
                If Me.grillaEstado = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro seleccionado se encuentra en estado inactivo, seleccione otro registro")
                    Exit Sub
                End If

                Me.getCodigo = Me.grillaCodigo
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

            AOK()

        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub txtCodDisJud_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub frmSalaPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            dgwGrilla.VisibleCampos = False

        End Sub

        Private Sub frmBusquedaSala_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Buscar()
            Me.txtNombre.Focus()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            AOK()

        End Sub

        Private Sub rbVigente_Click(sender As Object, e As EventArgs) Handles rbVigente.Click, rbHistorico.Click, rbInactivo.Click, rbTodos.Click

            Buscar()

        End Sub

    End Class
End Namespace