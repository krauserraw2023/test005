Namespace Sistema.Seguridad.Licencia
    Public Class frmPenal
        Private objBss As Bussines.General.Penal = Nothing
        Private objEntCol As Entity.General.PenalCol = Nothing
#Region "Propiedades"
        Private intUsuarioID As Integer = -1
        Private intTipoForm As Integer = 1 '1-- licencia, 2 --instalacion
        Private intInstalacionID As Integer = -1
        Public Property UsuarioID() As Integer
            Get
                Return intUsuarioID
            End Get
            Set(ByVal value As Integer)
                intUsuarioID = value
            End Set
        End Property
        Public Property InstalacionID() As Integer
            Get
                Return intInstalacionID
            End Get
            Set(ByVal value As Integer)
                intInstalacionID = value
            End Set
        End Property
        Public Property TipoForm() As Integer
            Get
                Return intTipoForm
            End Get
            Set(ByVal value As Integer)
                intTipoForm = value
            End Set
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private Property RegionPenal() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property Establecimiento() As String
            Get
                Dim strValue As String = ""

                If Me.rdbOpc1.Checked = True Then
                    strValue = "1"
                End If

                If Me.rdbOpc2.Checked = True Then
                    strValue = "2,3"
                End If

                Return strValue
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaPenalID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwPenal
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRegion()
            Me.cbbRegion.LoadUsc()
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            objBss = New Bussines.General.Penal
            objEntCol = New Entity.General.PenalCol

            objEntCol = objBss.Listar(-1, "", "", Me.RegionPenal, -1, Me.Establecimiento)

            With Me.dgwPenal
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function AGrabarLicencia(ByVal RegionID As Integer, ByVal PenalID As Integer) As Integer

            Dim intValue As Integer = -1

            Dim objBss As New Bussines.Seguridad.Penal.Region

            intValue = objBss.Grabar(-1, Me.UsuarioID, RegionID, PenalID)

            Return intValue
        End Function
        Private Function AGrabarInstalacion(ByVal RegionID As Integer, ByVal PenalID As Integer, _
        ByVal Lectura As Boolean, ByVal Escrituta As Boolean) As Integer

            Dim intValue As Integer = -1

            Dim objBss As New Bussines.Sistema.InstalacionDetalle

            intValue = objBss.Grabar(-1, Me.InstalacionID, RegionID, PenalID, Lectura, Escrituta)

            Return intValue
        End Function
        Private Sub AGrabar()

            Dim intRegionID As Integer = -1
            Dim intPenalID As Integer = -1
            Dim blnLec As Boolean = False
            Dim blnEsc As Boolean = False

            For Each fila As DataGridViewRow In Me.dgwPenal.Rows

                If fila.Cells("col_chk").Value = True Then
                    intRegionID = fila.Cells("col_reg_id").Value
                    intPenalID = fila.Cells("col_pen_id").Value
                    blnLec = fila.Cells("col_lec").Value
                    blnEsc = fila.Cells("col_esc").Value

                    Select Case Me.TipoForm
                        Case 1 'licencia
                            AGrabarLicencia(intRegionID, intPenalID)
                        Case 2 'instalacion
                            If MessageBox.Show("Desea grabar los registros seleccionados", _
                             Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                            MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                                AGrabarInstalacion(intRegionID, intPenalID, blnLec, blnEsc)

                            End If

                    End Select

                End If
            Next

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End Sub
#End Region
#Region "Otros"
        Private Sub Habilitar(ByVal vf As Boolean)

            For Each fila As DataGridViewRow In Me.dgwPenal.Rows
                fila.Cells("col_chk").Value = vf
            Next

        End Sub
        Private Sub ValoresxDefault()

            ComboRegion()

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub frmUsuarioPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmUsuarioPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()

        End Sub

        Private Sub cbbRegion__ValueChanged() Handles cbbRegion._SelectedIndexChanged

            Listar()

        End Sub

        Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodos.Click
            Me.Habilitar(Me.chkTodos.Checked)
        End Sub

        Private Sub rdbOpc1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        rdbOpc1.Click, rdbOpc2.Click

            Listar()

        End Sub

        Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged

        End Sub

        Private Sub dgwPenal_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwPenal.CellContentClick

        End Sub
    End Class
End Namespace


