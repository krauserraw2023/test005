Namespace Registro.Main.Antecedentes
    Public Class frmBuscarAntecedentesPopup

        Public Property _InternoNombres As String = ""
        Public Property _TipoCertAntJudId As Integer = -1 '1=Antecedente positivo,2=Antecedente negativo
        Public Property _SolicitudAntJudId As Integer = -1
        Public Property _EstadoCertAntJud As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud

#Region "propiedades_privadas"
        Private Property InternoCodigo() As String
            Get
                Return txtInternoCod.Text
            End Get
            Set(value As String)
                txtInternoCod.Text = value
            End Set
        End Property
        Private Property InternoApePaterno As String
            Get
                Return txtApePat.Text
            End Get
            Set(value As String)
                txtApePat.Text = value
            End Set
        End Property
        Private Property InternoApeMaterno As String
            Get
                Return txtApeMat.Text
            End Get
            Set(value As String)
                txtApeMat.Text = value
            End Set
        End Property
        Private Property InternoNombres As String
            Get
                Return txtNombres.Text
            End Get
            Set(value As String)
                txtNombres.Text = value
            End Set
        End Property
#End Region

#Region "action"
        Private Sub Buscar()
            Dim Lista As New Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            With ent
                .InternoApePaterno = Me.InternoApePaterno.Trim
                .InternoApeMaterno = Me.InternoApeMaterno.Trim
                .InternoCodigo = Me.InternoCodigo.Trim
                .InternoNombres = Me.InternoNombres.Trim
            End With

            Lista = (New Bussines.Registro.Antecedente.SolicitudAntecedente).ListarGrilla(ent)

            With dgwGrilla
                .AutoGenerateColumns = False
                .DataSource = Lista
            End With

        End Sub
#End Region

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            If dgwGrilla.Rows.Count = 0 Then Exit Sub

            Me._InternoNombres = dgwGrilla.Item("col_ape_pat", dgwGrilla.CurrentRow.Index).Value & " " & dgwGrilla.Item("col_ape_mat", dgwGrilla.CurrentRow.Index).Value & ", " & dgwGrilla.Item("col_nom", dgwGrilla.CurrentRow.Index).Value
            Me._SolicitudAntJudId = dgwGrilla.Item("col_cod", dgwGrilla.CurrentRow.Index).Value
            Me._TipoCertAntJudId = dgwGrilla.Item("col_tip_aj_id", dgwGrilla.CurrentRow.Index).Value
            Me._EstadoCertAntJud = dgwGrilla.Item("col_est_id", dgwGrilla.CurrentRow.Index).Value

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            btnOk.PerformClick()
        End Sub

        Private Sub txtApePat_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtApePat.KeyUp, txtApeMat.KeyUp, txtNombres.KeyUp, txtInternoCod.KeyUp
            If e.KeyCode = Keys.Enter Then
                If txtApePat.Text.Trim.Length < 4 Then Exit Sub
                tsbBuscar.PerformClick()
            End If
        End Sub

        Private Sub frmBuscarAntecedentesPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            txtApePat.Select()
        End Sub

        Private Sub frmBuscarAntecedentesPopup_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then Me.Close()
        End Sub
    End Class
End Namespace