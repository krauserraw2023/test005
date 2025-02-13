Imports Entity.Registro.Carceleta.Clasificacion

Namespace Registro.Carceleta.Clasificacion
    Public Class frmDetalleFicha
#Region "Property"
        Public Property InternoFichaDetalleId() As Integer = -1
        Public Property VariableId() As Integer = -1
        Public Property FichaId() As Integer = -1
        Public Property VariableString() As String = ""
        Public Property IndicadorId() As Integer = -1
        Public Property BloquearRegistro As Boolean = False
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property _ValorNoPrevisto() As Integer = -1
        Public Property _ValorPuntaje() As Integer = -1
        Public Property GrupoFichaId As Integer = -1
        Public Property SituacionJuridicaId As Integer = -1

        Public ReadOnly Property ValorIdSeleccionado() As Integer
            Get
                Dim v As Integer = -1
                Try
                    Return dgvValores.Item("col_codigo", dgvValores.CurrentRow.Index).Value
                Catch ex As Exception

                End Try
                Return v
            End Get
        End Property
        Public ReadOnly Property ValorNombreSeleccionado() As String
            Get
                Dim v As String = ""
                Try
                    Return dgvValores.Item("col_desc", dgvValores.CurrentRow.Index).Value
                Catch ex As Exception

                End Try
                Return v
            End Get
        End Property

        Private Property ValorNoPrevisto() As Integer
            Get
                Return Val(txtPtjeNoPrevisto.Text)
            End Get
            Set(ByVal value As Integer)
                txtPtjeNoPrevisto.Text = value
            End Set
        End Property
        Private Property ValorPuntaje() As Integer
            Get
                Return Val(txtPtje.Text)
            End Get
            Set(ByVal value As Integer)
                txtPtje.Text = value
            End Set
        End Property
#End Region

#Region "LISTAR"
        Private Sub ListarValores()
            Dim bssFich As New Bussines.Clasificacion.MaestroIndicador
            Dim entVar As New MaestroIndicador_BE
            Dim entVarCol As New MaestroIndicadorCol_BE
            entVar.VariableID = Me.VariableId
            entVar.FichaId = Me.FichaId
            dgvValores.DataSource = bssFich.Listar(entVar)
            dgvValores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            'txtPtje.Text = 0


            Dim c() As Color = {Color.FromArgb(219, 243, 252), Color.FromArgb(199, 249, 238), Color.FromArgb(217, 252, 204), Color.FromArgb(255, 255, 192), _
                                Color.FromArgb(255, 242, 196), Color.FromArgb(255, 226, 227), Color.FromArgb(255, 255, 242)}

            Dim nomColPtje As String = ""

            If Me.GrupoFichaId < 4 Then
                nomColPtje = "col_ptje"
            Else
                If SituacionJuridicaId = 1 Then 'procesado
                    nomColPtje = "col_ptje_proc"
                    dgvValores.Columns("col_ptje").Visible = False
                    dgvValores.Columns("col_ptje_sen").Visible = False
                Else 'sentenciado
                    nomColPtje = "col_ptje_sen"
                    dgvValores.Columns("col_ptje").Visible = False
                    dgvValores.Columns("col_ptje_proc").Visible = False
                End If
            End If


            Dim v As Integer = 0
            v = dgvValores.Item(nomColPtje, 0).Value
            Dim grupo As Integer = 0
            For i As Integer = 0 To dgvValores.Rows.Count - 1
                If dgvValores.Item(nomColPtje, i).Value = v Then
                    dgvValores.Rows(i).DefaultCellStyle.BackColor = c(grupo)
                Else
                    grupo = grupo + 1
                    dgvValores.Rows(i).DefaultCellStyle.BackColor = c(grupo)
                    v = dgvValores.Item(nomColPtje, i).Value
                End If
            Next

            If Me.ValorPuntaje > 0 Or Me.ValorNoPrevisto > 0 Then
                'seleccionar fila de indicador
                For f As Integer = 0 To dgvValores.Rows.Count - 1
                    If dgvValores.Item("col_codigo", f).Value = Me.IndicadorId Then
                        dgvValores.Rows(f).Selected = True 'col_desc
                        dgvValores.CurrentCell = dgvValores.Rows(f).Cells("col_desc")
                    End If
                Next
            Else
                dgvValores.CurrentCell = Nothing
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            Me.ValorNoPrevisto = Me._ValorNoPrevisto
            Me.ValorPuntaje = Me._ValorPuntaje

            dgvValores.AutoGenerateColumns = False
            Me.Text = Me.Text & " para la variable " & Me.VariableString.ToUpper

            If Me.ValorNoPrevisto > 0 Then
                chNoPrev.Checked = True
                txtPtje.BackColor = Color.LightGray
                txtPtjeNoPrevisto.BackColor = Color.White
                txtPtjeNoPrevisto.Enabled = True
                txtPtje.Text = 0
            End If

            If Me._FormLectura = True Then btnOK.Visible = False
            If Me.BloquearRegistro = True Then btnOK.Enabled = False
        End Sub
#End Region

        Private Sub frmSelectValorPopup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
        End Sub

        Private Sub frmSelectValorPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarValores()
        End Sub

        Private Sub dgvValores_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvValores.CellClick
            If e.RowIndex = -1 Then Return
            If chNoPrev.Checked = True Then
                txtPtje.Text = 0
            Else
                If Me.GrupoFichaId = 4 Then
                    If Me.SituacionJuridicaId = 1 Then 'procesado
                        txtPtje.Text = Val(dgvValores.Item("col_ptje_proc", e.RowIndex).Value)
                    Else
                        txtPtje.Text = Val(dgvValores.Item("col_ptje_sen", e.RowIndex).Value)
                    End If
                Else
                    txtPtje.Text = Val(dgvValores.Item("col_ptje", e.RowIndex).Value)
                End If
                txtPtjeNoPrevisto.Text = 0
            End If
        End Sub

        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
            If chNoPrev.Checked = True Then
                'If Me.GrupoFichaId = 4 Then
                '    If dgvValores.Item("col_fic_id", dgvValores.CurrentRow.Index).Value > 0 And Val(txtPtjeNoPrevisto.Text) <= 0 Then
                '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el valor del puntaje no previsto.")
                '        txtPtjeNoPrevisto.Focus()
                '        Exit Sub
                '    End If
                'Else
                If Val(txtPtjeNoPrevisto.Text) <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el valor del puntaje no previsto.")
                    txtPtjeNoPrevisto.Focus()
                    Exit Sub
                End If
                'End If
                'evaluar el maximo valor(el valor no previsto no puede superar al max val)
                Dim maxPtj As Integer = 0
                Dim strCol As String = "col_ptje"

                If Me.SituacionJuridicaId = 1 Then strCol = "col_ptje_proc"
                If Me.SituacionJuridicaId = 2 Then strCol = "col_ptje_sen"


                For i As Integer = 0 To dgvValores.Rows.Count - 1
                    If dgvValores.Item(strCol, i).Value > maxPtj Then
                        maxPtj = dgvValores.Item(strCol, i).Value
                    End If
                Next
                If Val(txtPtjeNoPrevisto.Text) > maxPtj Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El valor de la variable no prevista no puede ser mayor a " & maxPtj)
                    Exit Sub
                End If
            Else
                If Me.GrupoFichaId = 4 Then
                    If dgvValores.Item("col_fic_id", dgvValores.CurrentRow.Index).Value <= 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar una fila del indicador.")
                        Exit Sub
                    End If
                Else
                    If Val(txtPtje.Text) = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar una fila del indicador.")
                        Exit Sub
                    End If
                End If
            End If

            Me._ValorNoPrevisto = Me.ValorNoPrevisto
            Me._ValorPuntaje = Me.ValorPuntaje


            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub dgvValores_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvValores.CellDoubleClick
            If e.RowIndex <> -1 Then
                btnOK.PerformClick()
            End If
        End Sub

        Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
            Me.WindowState = FormWindowState.Maximized
        End Sub

        Private Sub chNoPrev_Click(sender As System.Object, e As System.EventArgs) Handles chNoPrev.Click
            If dgvValores.CurrentCell Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione el indicador.")
                chNoPrev.Checked = Not chNoPrev.Checked
                Exit Sub
            End If
            If chNoPrev.Checked = True Then
                txtPtje.BackColor = Color.LightGray
                txtPtjeNoPrevisto.BackColor = Color.White
                txtPtjeNoPrevisto.Enabled = True
                txtPtje.Text = 0
                'col_check.ReadOnly = True
            Else
                txtPtjeNoPrevisto.BackColor = Color.LightGray
                txtPtjeNoPrevisto.Enabled = False
                txtPtjeNoPrevisto.Text = 0
                txtPtje.BackColor = Color.White

                Dim strCol As String = "col_ptje"

                If Me.SituacionJuridicaId = 1 Then strCol = "col_ptje_proc"
                If Me.SituacionJuridicaId = 2 Then strCol = "col_ptje_sen"

                txtPtje.Text = Val(dgvValores.Item(strCol, dgvValores.CurrentCell.RowIndex).Value) 'ObtenerNotaFilaCheck()
                'col_check.ReadOnly = False
            End If
        End Sub

        Private Sub btnVerDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnVerDetalle.Click
            If dgvValores.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione un indicador.")
                Exit Sub
            End If

            Dim strCol As String = "col_ptje"

            If Me.SituacionJuridicaId = 1 Then strCol = "col_ptje_proc"
            If Me.SituacionJuridicaId = 2 Then strCol = "col_ptje_sen"

            Dim f As New Registro.Carceleta.Clasificacion.frmDetIndicador
            f._Indicador = dgvValores.Item("col_desc", dgvValores.CurrentRow.Index).Value
            f._Puntaje = dgvValores.Item(strCol, dgvValores.CurrentRow.Index).Value
            f.ShowDialog()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
    End Class
End Namespace
