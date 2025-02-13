Namespace Mantenimiento.Reporte
    Public Class frmBuscarPopup
        Private objBss As Bussines.Mantenimiento.Reportecuadro2 = Nothing
        Private objEntCol As Entity.Mantenimiento.ReporteCuadro2Col = Nothing
#Region "Propiedades_Buscar"
        Private Property DelitoGenerico() As String
            Get
                Return Me.txtDelGene.Text
            End Get
            Set(ByVal value As String)
                Me.txtDelGene.Text = value
            End Set
        End Property
        Private Property DelitoEspecifico() As String
            Get
                Return Me.txtDelEsp.Text
            End Get
            Set(ByVal value As String)
                Me.txtDelEsp.Text = value
            End Set
        End Property
        Private ReadOnly Property Cuadro As Integer = 3
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
        Private Sub GrillaCount(ByVal NumeroReg As Integer)

            Me.lblReg.Text = NumeroReg.ToString & " Reg."

        End Sub
#End Region
#Region "Propiedades_Return"
        Public Property _getIDCuadro() As Integer = -1
        Public Property _getGrupoGenerico() As String = ""
        Public Property _getGrupoEspecifico As String = ""
#End Region
#Region "Listar"
        Private Sub Buscar()

            objBss = New Bussines.Mantenimiento.Reportecuadro2
            objEntCol = objBss.Listar(-1, Me.DelitoGenerico, Me.DelitoEspecifico, Me.Cuadro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                GrillaCount(.RowCount)
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

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

        Private Sub txtDelGene_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtDelGene.KeyPress,
        txtDelEsp.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            If Me.GrillaCodigo < 1 Then
                MessageBox.Show("Seleccione registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Me._getIDCuadro = Me.GrillaCodigo
            Me._getGrupoGenerico = dgwGrilla.SelectedRows(0).Cells("col_gen_nom").Value
            Me._getGrupoEspecifico = dgwGrilla.SelectedRows(0).Cells("col_esp_nom").Value
            DialogResult = DialogResult.OK

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_esp_nom").Index

                        If (e.Value).ToString.ToUpper = "Otrosv".ToUpper Then
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub
    End Class
End Namespace
