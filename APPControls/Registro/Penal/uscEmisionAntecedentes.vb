Namespace Penal
    Public Class uscEmisionAntecedentes
        Private Property FiltroNuevoCAJ As String = ""
        Private Property FiltroActualCAJ As String = ""
        Public Event _Modificar_CellDoubleClick(intIDCodigo As Integer, intTipoCertificado As Short)
#Region "Propiedades_Publicas"
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
#End Region

#Region "Propiedades"
        Private Property IDTipoCertificado As Integer
            Get
                Dim value As Integer = -1

                If rbNoProPendMD.Checked Then value = 2
                If drbPositivo.Checked Then value = 3
                If rdbNegativo.Checked Then value = 1
                If rdbTodosTipAnt.Checked Then value = -1

                Return value
            End Get
            Set(value As Integer)
                Select Case value
                    Case -1
                        rdbTodosTipAnt.Checked = True
                    Case 1
                        rdbNegativo.Checked = True
                    Case 2
                        rbNoProPendMD.Checked = True
                    Case 3
                        drbPositivo.Checked = True
                End Select
            End Set
        End Property
        Private Property EstadoCertificadoCAJ As Integer
            Get
                Dim v As Integer = -1
                If rdbPendiente.Checked Then v = 0
                If rdbTerminado.Checked Then v = 1
                If rdbImpreso.Checked Then v = 2
                If rdbAnulado.Checked Then v = 3
                If rdbTodos.Checked Then v = -1
                Return v
            End Get
            Set(value As Integer)
                Select Case value
                    Case 0
                        rdbPendiente.Checked = True
                    Case 1
                        rdbTerminado.Checked = True
                    Case 2
                        rdbImpreso.Checked = True
                    Case 3
                        rdbAnulado.Checked = True
                    Case Else
                        rdbTodos.Checked = True
                End Select
            End Set
        End Property
        Private Property ApeMaternoCAJ As String
            Get
                Return txtApeMatCAJ.Text
            End Get
            Set(value As String)
                txtApeMatCAJ.Text = value
            End Set
        End Property
        Private Property ApePaternoCAJ As String
            Get
                Return txtApePatCAJ.Text
            End Get
            Set(value As String)
                txtApePatCAJ.Text = value
            End Set
        End Property
        Private Property NombresCAJ As String
            Get
                Return txtNombresCAJ.Text
            End Get
            Set(value As String)
                txtNombresCAJ.Text = value
            End Set
        End Property
        Private Property CodInternoCAJ As String
            Get
                Return txtInternoCodCAJ.Text
            End Get
            Set(value As String)
                txtInternoCodCAJ.Text = value
            End Set
        End Property
        Private Property NumSolicitudCAJ As String
            Get
                Return txtDocSolicitudCAJ.Text
            End Get
            Set(value As String)
                txtDocSolicitudCAJ.Text = value
            End Set
        End Property
        Private Property FechaDesdeCAJ As Long
            Get
                Return dtpFechaIniCAJ.ValueLong
            End Get
            Set(value As Long)
                dtpFechaIniCAJ.ValueLong = value
            End Set
        End Property
        Private Property FechaHastaCAJ As Long
            Get
                Return dtpFechaFinCAJ.ValueLong
            End Get
            Set(value As Long)
                dtpFechaFinCAJ.ValueLong = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property GrillaIDCodigo() As Integer
            Get
                Dim value As Integer = -1
                Try

                    With Me.dgwGrillaCAJ
                        value = .SelectedRows(0).Cells("col_cod_caj").Value
                    End With

                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaTipoCertificado As Short
            Get

                Dim value As Integer = -1
                Try
                    With Me.dgwGrillaCAJ
                        value = .SelectedRows(0).Cells("col_tip_aj_id_caj").Value
                    End With
                Catch ex As Exception

                End Try
                Return value

            End Get
        End Property
        Public ReadOnly Property GrillaEstadoCAJ() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaCAJ
                        intValue = .SelectedRows(0).Cells("col_est_id_caj").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaCount() As Integer
            Get
                Return Me.dgwGrillaCAJ.Rows.Count
            End Get
        End Property
        Public ReadOnly Property GrillaIDRegion As Short
            Get

                Dim value As Integer = -1
                Try
                    With Me.dgwGrillaCAJ
                        value = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value

            End Get
        End Property
        Public ReadOnly Property GrillaRegionNombre As String
            Get

                Dim value As String = ""
                Try
                    With Me.dgwGrillaCAJ
                        value = .SelectedRows(0).Cells("col_reg_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value

            End Get
        End Property
#End Region
#Region "Funciones"
        Public Function _GrillaCount() As Integer

            Return Me.dgwGrillaCAJ.RowCount

        End Function

#End Region
#Region "Validar"
        Private Function ValidarBusquedaCAJ() As Boolean
            Dim v As Boolean = False
            If txtDocSolicitudCAJ.Text.Length > 0 And txtDocSolicitudCAJ.Text.Length < 5 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe proporcionar mas datos al número de documento de solicitud.")
                Return False
            End If
            If (Me.FechaDesdeCAJ > 0 And Me.FechaHastaCAJ = 0) Or (Me.FechaDesdeCAJ = 0 And Me.FechaHastaCAJ > 0) Then
                If Me.FechaDesdeCAJ = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha de inicio para la búsqueda")
                    Me.dtpFechaIniCAJ.Focus()
                End If
                If Me.FechaHastaCAJ = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha fin para la búsqueda")
                    Me.dtpFechaFinCAJ.Focus()
                End If
                If Me.FechaHastaCAJ < Me.FechaDesdeCAJ Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin no puede ser menor a la fecha de inicio")
                    Me.dtpFechaFinCAJ.Focus()
                End If
                Return v
            End If
            Return True
        End Function
#End Region
#Region "Listar"
        Public Sub _Buscar()

            If ValidarBusquedaCAJ() = False Then
                Exit Sub
            End If

            FiltroActualCAJ = ConcatenarFiltroCAJ()

            Dim objEntCol As New Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim objEntFiltro As New Entity.Registro.Antecedente.SolicitudAntecedente

            With objEntFiltro
                .RegionId = Me._IDRegion
                .PenalId = Me._IDPenal
                .TipoAntecedenteId = Me.IDTipoCertificado
                .EstadoSolicitudId = Me.EstadoCertificadoCAJ
                .InternoApePaterno = Me.ApePaternoCAJ
                .InternoApeMaterno = Me.ApeMaternoCAJ
                .InternoCodigo = Me.CodInternoCAJ
                .InternoNombres = Me.NombresCAJ
                .DocumentoNumero = txtDocSolicitudCAJ.Text.Trim
                .FechaDesde = Me.FechaDesdeCAJ
                .FechaHasta = Me.FechaHastaCAJ
            End With

            objEntCol = (New Bussines.Registro.Antecedente.SolicitudAntecedente).ListarGrilla_Penal(objEntFiltro)

            With dgwGrillaCAJ
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Otros"
        Private Function ConcatenarFiltroCAJ() As String
            Dim objLista As New ArrayList
            'texto
            objLista.Add(Me.ApePaternoCAJ)
            objLista.Add(Me.ApeMaternoCAJ)
            objLista.Add(Me.NombresCAJ)
            objLista.Add(Me.CodInternoCAJ)
            objLista.Add(Me.NumSolicitudCAJ)
            'combos
            'objLista.Add(Me.TipoCertificadoId)
            objLista.Add(Me.EstadoCertificadoCAJ)

            'fecha
            objLista.Add(Me.FechaDesdeCAJ)
            objLista.Add(Me.FechaHastaCAJ)
            Dim FiltroConcatenado As String = ""
            For Each obj As String In objLista
                FiltroConcatenado = FiltroConcatenado & obj
            Next
            Return FiltroConcatenado
        End Function
#End Region
#Region "Eventos"
        Public Sub _Anular()

            If dgwGrillaCAJ.Rows.Count = 0 Then Exit Sub

            If dgwGrillaCAJ.CurrentRow.Selected = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una fila")
                Exit Sub
            End If

            Dim sms As String = ""
            Select Case Me.GrillaEstadoCAJ
                Case 0
                    'sms = "El registro se encuentra en estado pendiente"
                Case 3
                    sms = "El registro ya se encuentra anulado"
            End Select
            If sms.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(sms)
                Exit Sub
            End If

            If MessageBox.Show("Confirma anular el registro seleccionado", "ANULAR SOLICITUD DE ANTECEDENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim objBss As New Bussines.Registro.Antecedente.SolicitudAntecedente
                Dim id As Integer = -1
                Dim outSms As String = ""
                Dim fila As Integer = -1
                Dim strMotAnulacion As String = ""
                strMotAnulacion = InputBox("Ingrese el motivo por el cual anula el registro.", "Motivo de anulación")
                If strMotAnulacion = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Operación de anulación cancelada")
                    Exit Sub
                End If
                fila = dgwGrillaCAJ.CurrentRow.Index
                id = objBss.CambiarEstado(Me.GrillaIDCodigo, Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado.GetHashCode, outSms,
                                          strMotAnulacion, Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong)

                If id = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Error al anular registro, " & outSms)
                    Exit Sub
                End If
                _Buscar()
                Try

                    dgwGrillaCAJ.Rows(fila).Selected = True
                Catch ex As Exception

                End Try
            End If
        End Sub
        Public Sub _Exportar()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrillaCAJ)
        End Sub
        Public Sub _Limpiar()
            Me.ApePaternoCAJ = ""
            Me.ApeMaternoCAJ = ""
            Me.CodInternoCAJ = ""
            Me.NombresCAJ = ""
            Me.NumSolicitudCAJ = ""
            Me.EstadoCertificadoCAJ = -1
            'Me.TipoCertificadoId = -1
            Me.FechaDesdeCAJ = 0
            Me.FechaHastaCAJ = 0
        End Sub
#End Region

        Private Sub dgwGrillaCAJ_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaCAJ.CellContentClick

        End Sub

        Private Sub dgwGrillaCAJ_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaCAJ.CellDoubleClick

            If dgwGrillaCAJ.Rows.Count = 0 Then Exit Sub

            If e.RowIndex <> -1 Then
                RaiseEvent _Modificar_CellDoubleClick(Me.GrillaIDCodigo, Me.GrillaTipoCertificado)
            End If

        End Sub

        Private Sub dgwGrillaCAJ_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrillaCAJ.CellFormatting
            If dgwGrillaCAJ.Columns(e.ColumnIndex).Name = "col_est_caj" Then
                Select Case dgwGrillaCAJ.Item("col_est_id_caj", e.RowIndex).Value
                    Case 0 'pendiente
                        e.CellStyle.BackColor = Color.FromArgb(249, 241, 151)
                        Me.dgwGrillaCAJ.Rows(e.RowIndex).Cells("col_est_caj").Style.SelectionBackColor = Color.FromArgb(249, 241, 151)
                    Case 1 'terminado
                        e.CellStyle.BackColor = Color.FromArgb(175, 184, 69)
                        Me.dgwGrillaCAJ.Rows(e.RowIndex).Cells("col_est_caj").Style.SelectionBackColor = Color.FromArgb(175, 184, 69)
                    Case 2 'impreso
                        e.CellStyle.BackColor = Color.FromArgb(180, 223, 237)
                        Me.dgwGrillaCAJ.Rows(e.RowIndex).Cells("col_est_caj").Style.SelectionBackColor = Color.FromArgb(180, 223, 237)
                    Case 3 'anulado
                        e.CellStyle.BackColor = Color.FromArgb(221, 68, 72)
                        Me.dgwGrillaCAJ.Rows(e.RowIndex).Cells("col_est_caj").Style.SelectionBackColor = Color.FromArgb(221, 68, 72)
                End Select
            End If
        End Sub
    End Class
End Namespace