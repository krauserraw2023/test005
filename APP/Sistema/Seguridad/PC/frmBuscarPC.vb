
Namespace Seguridad
    Public Class frmBuscarPC
        Private objBss As Legolas.LBusiness.Seguridad.PC = Nothing
        Private objEntCol As Legolas.LEntity.Seguridad.PCCol = Nothing
#Region "Propiedades"
        Private Property HostName() As String
            Get
                Return Me.txtHostName.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtHostName.Text = value
            End Set
        End Property
        Private Property IP() As String
            Get
                Return Me.txtIp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIp.Text = value
            End Set
        End Property
        Private Property MAC() As String
            Get
                Return Me.txtMac.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtMac.Text = value
            End Set
        End Property
        Private Property SerialHD() As String
            Get
                Return Me.txtSerialHD.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSerialHD.Text = value
            End Set
        End Property
        Private Property Responsable() As String
            Get
                Return Me.txtResp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtResp.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pc_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_GrillaCount"
        Private intNumeroReg As Integer = 0
        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                ListarCount()
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarCount()
            Me.lblReg.Text = Me.NumeroReg & " Reg."
        End Sub
        Private Sub Buscar()

            objBss = New Legolas.LBusiness.Seguridad.PC
            objEntCol = New Legolas.LEntity.Seguridad.PCCol

            objEntCol = objBss.Listar(-1, Me.HostName, Me.IP, Me.MAC, Me.SerialHD, Me.Responsable)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.NumeroReg = .RowCount

            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                objBss = New Legolas.LBusiness.Seguridad.PC
                Dim intValue As Integer = -1

                objBss.Eliminar(Me.GrillaID)
                Buscar()
            End If
        End Sub
#End Region
#Region "Formulario"
        Private Sub AMantenimiento(ByVal Nuevo As Boolean)

            Dim frm As New Seguridad.frmPCMantPopup
            With frm
                If Nuevo = True Then
                    .Codigo = -1
                Else
                    If Me.GrillaID < 1 Then
                        Exit Sub
                    End If
                    .Codigo = Me.GrillaID
                End If

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If

            End With
        End Sub
#End Region
        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
            AMantenimiento(True)
        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            If Me.dgwGrilla.RowCount > 0 Then
                AMantenimiento(False)
            End If
        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub txtHostName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtHostName.KeyPress, _
        txtIp.KeyPress, _
        txtMac.KeyPress, _
        txtSerialHD.KeyPress, _
        txtResp.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

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
                AMantenimiento(False)
            End If

        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub frmBuscarPC_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized

        End Sub
    End Class
End Namespace
