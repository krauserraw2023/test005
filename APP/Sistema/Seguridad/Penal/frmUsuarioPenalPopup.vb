Namespace Seguridad.Penal
    Public Class frmUsuarioPenalPopup
        Private objBss As Bussines.Seguridad.Penal.Region = Nothing
        Private objEntCol As Entity.Seguridad.Penal.RegionCol = Nothing
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private strApellidos As String = ""
        Private strNombres As String = ""
        Public Property UsuarioID() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property Login() As String
            Get
                Return Me.txtUsuario.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtUsuario.Text = value
            End Set
        End Property
        Public Property Apellidos() As String
            Get
                Return strApellidos
            End Get
            Set(ByVal value As String)
                strApellidos = value
            End Set
        End Property
        Public Property Nombres() As String
            Get
                Return strNombres
            End Get
            Set(ByVal value As String)
                strNombres = value
            End Set
        End Property
        Private ReadOnly Property ApellidosyNombres() As String
            Get
                Dim strValue As String = ""

                strValue = Me.Apellidos & ", " & Me.Nombres

                Return strValue
            End Get

        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwPenal
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Listar"
        Private Sub ListarPenal()

            If Me.UsuarioID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Seguridad.Penal.Region
            objEntCol = New Entity.Seguridad.Penal.RegionCol

            objEntCol = objBss.Listar(-1, Me.UsuarioID, "", "", "", "", -1, -1)

            With Me.dgwPenal
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminarMasivo()

            If MessageBox.Show("Desea eliminar los registros seleccionados", _
             Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim intValue As Integer = -1
                Dim intCodigo As Integer = -1
                objBss = New Bussines.Seguridad.Penal.Region

                For Each fila As DataGridViewRow In Me.dgwPenal.Rows

                    If fila.Cells("col_chk").Value = True Then
                        intCodigo = fila.Cells("col_id").Value
                        intValue = objBss.Eliminar(intCodigo)
                    End If
                Next

                If intValue > 0 Then
                    ListarPenal()
                End If

            End If

        End Sub
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Dim intValue As Integer = -1
                objBss = New Bussines.Seguridad.Penal.Region
                intValue = objBss.Eliminar(Me.GrillaCodigo)

                If intValue > 0 Then
                    ListarPenal()
                End If

            End If

        End Sub
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            Return blnValue
        End Function
#End Region
#Region "FRM"
        Private Sub FRMPenal()

            Dim frm As New Sistema.Seguridad.Licencia.frmPenal
            With frm
                .UsuarioID = Me.UsuarioID
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarPenal()
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub Habilitar(ByVal vf As Boolean)

            For Each fila As DataGridViewRow In Me.dgwPenal.Rows
                fila.Cells("col_chk").Value = vf
            Next

        End Sub
        Private Sub ValoresxDefault()

            Me.txtApeNom.Text = Me.ApellidosyNombres

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End Sub

        Private Sub frmUsuarioPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmUsuarioPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarPenal()

        End Sub

        Private Sub dgwPC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwPenal.KeyDown

            If e.KeyCode = Keys.Delete Then
                AEliminar()
            End If

        End Sub

        Private Sub chkTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodos.Click

            Me.Habilitar(Me.chkTodos.Checked)

        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

            If Me.dgwPenal.RowCount > 0 Then

                AEliminarMasivo()

            End If

        End Sub

        Private Sub btnAddPenal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPenal.Click
            FRMPenal()
        End Sub

        Private Sub dgwPenal_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwPenal.CellContentClick

        End Sub

        Private Sub chkTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTodos.CheckedChanged

        End Sub
    End Class
End Namespace


