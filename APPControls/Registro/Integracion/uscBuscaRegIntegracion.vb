Imports System.ComponentModel

Namespace Registro.Integracion
    Public Class uscBuscaRegIntegracion
        Private Property FiltroNuevo As String = ""
        Private Property FiltroActual As String = ""

        Private objBss As Bussines.Registro.Integracion.IntegracionInterno = Nothing
        Private objEntCol As Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInterno) = Nothing

        Public Event _Grilla_CellDoubleClick()
        Public Event _Cell_Click_VerDetalleInterno(interno_id As Integer, interno_pen_id As Integer, interno_reg_id As Integer)

        Private frmLoad As Load.frmLoad = Nothing
#Region "propiedades"
        Private Property CodigoUnicoInterno As String
            Get
                Return txtCodigoUnicoInterno.Text
            End Get
            Set(value As String)
                txtCodigoUnicoInterno.Text = value
            End Set
        End Property
        Private Property NumeroDocumento As String
            Get
                Return txtNumDoc.Text
            End Get
            Set(value As String)
                txtNumDoc.Text = value
            End Set
        End Property
        Private Property CodigoUSR As String
            Get
                Return txtCodUSR.Text
            End Get
            Set(value As String)
                txtCodUSR.Text = value
            End Set
        End Property
        Private Property FechaIni As Long
            Get
                Return dtpFechaInicio.ValueLong
            End Get
            Set(value As Long)
                dtpFechaInicio.ValueLong = value
            End Set
        End Property
        Private Property FechaFin As Long
            Get
                Return dtpFechaFin.ValueLong
            End Get
            Set(value As Long)
                dtpFechaFin.ValueLong = value
            End Set
        End Property
        Private Property CodigoRP As String
            Get
                Return txtCodRp.Text
            End Get
            Set(value As String)
                txtCodRp.Text = value
            End Set
        End Property
        Private Property InternoNombres As String
            Get
                Return txtNom.Text
            End Get
            Set(value As String)
                txtNom.Text = value
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
#End Region

#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Long
            Get
                Dim value As Long = -1
                Try
                    value = Me.dgwGrilla.SelectedRows(0).Cells("col_codigo").Value
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaDetalleInternoId() As Long
            Get
                Dim value As Long = -1
                Try
                    With Me.dgwGrillaIntegracion
                        value = .SelectedRows(0).Cells("int_col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaDetalleInternoPenalId() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrillaIntegracion
                        value = .SelectedRows(0).Cells("int_col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaDetalleInternoRegionId() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrillaIntegracion
                        value = .SelectedRows(0).Cells("int_col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region

#Region "Propiedades_Load"

#End Region

#Region "accion"
        'Private Function validarFiltro() As Boolean
        '    Dim v As Boolean = True

        '    Return v
        'End Function
        Private Function Listar(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean

            If worker.CancellationPending = True Then
                e.Cancel = True
            Else

                ' If validarFiltro() = False Then Exit Function

                Dim objBss As New Bussines.Registro.Integracion.IntegracionInterno
                Dim objEntFiltro As New Entity.Registro.Integracion.IntegracionInterno

                Dim n_codSec As Integer = 0
                Dim c_tipNac As String = ""

                If Me.CodigoUnicoInterno.Trim.Length > 1 Then
                    Dim aux As String = ""
                    c_tipNac = Me.CodigoUnicoInterno.Substring(0, 1)
                    If IsNumeric(c_tipNac) = True Then
                        MsgBox("Error en el código único del interno en la nacionalidad el cual debe ser P=Peruano, E=Extranjero, X=desconocido, verique.")
                        Exit Function
                    End If
                    aux = Me.CodigoUnicoInterno.Substring(1, CodigoUnicoInterno.Length - 1)
                    If IsNumeric(aux) Then
                        n_codSec = aux
                    Else
                        MsgBox("Error en el código único del interno, verique.")
                        Exit Function
                    End If
                End If

                With objEntFiltro
                    .CodigoUnicoSecuencial = n_codSec
                    .TipoNacionalidadStr = c_tipNac
                    .FechaIntegracionIni = Me.FechaIni
                    .FechaIntegracionFin = Me.FechaFin
                    .NumeroDocumentoStr = Me.NumeroDocumento
                    .CodigoUsrUsuario = Me.CodigoUSR
                    .InternoCodigoRP = Me.CodigoRP
                    .InternoApePaterno = Me.InternoApePaterno
                    .InternoApeMaterno = Me.InternoApeMaterno
                    .InternoNombres = Me.InternoNombres
                End With
                objEntCol = objBss.Listar_Grilla(objEntFiltro)

                Return True
            End If

        End Function
#End Region

        Private Sub LoadPropiedades()

            'LoadCodigoRP = Me.CodigoRP
            'LoadApePat = Me.ApellidoPaterno
            'LoadApeMat = Me.ApellidoMaterno
            'LoadNombres = Me.Nombres
            'LoadNombresAlias = Me.NombresAlias
            'LoadSexo = Me.Sexo
            'LoadExtranjero = Me.NacionalidadExtranjero
            'LoadNacionalidadPais = Me.NacionalidadPais
            'LoadSitJur = Me.SituacionJuridicaID
            ''LoadFechaIni = Me.IngresoFechaDesde
            ''LoadFechaFin = Me.IngresoFechaHasta
            'LoadRegion = Me.RegionID
            'LoadPenal = Me.PenalID
            'LoadPenalMult = Me.PenalMultiple
            'LoadEstado = Me.Estado
            'LoadEstadoEspecifico = Me.EstadoEspecifico

        End Sub

        Private Function ValidarBusqueda() As Boolean

            Dim value As Boolean = False

            If (Me.FechaIni > 0 And Me.FechaFin = 0) Or (Me.FechaIni = 0 And Me.FechaFin > 0) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La búsqueda por fechas requiere que tanto la fecha inicio y fin tengan valores.")
                Return False
            End If

            If (Me.InternoApePaterno.Trim.Length = 0 And Me.InternoApeMaterno.Length > 0) Or (Me.InternoApePaterno.Trim.Length > 0 And Me.InternoApeMaterno.Length = 0) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese ambos apellidos del interno.")
                Return False
            End If

            If (Me.CodigoUnicoInterno = "" And Me.NumeroDocumento = "" And Me.CodigoUSR = "") _
                And (Me.FechaIni = 0 And Me.FechaFin = 0) And CodigoRP = "" And (Me.InternoApePaterno = "" Or Me.InternoApeMaterno = "") Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese algún valor como criterio de búsqueda.")
                Return False
            End If

            value = True

            Return value
        End Function


        Public Sub _ALimpiar()
            Me.CodigoUnicoInterno = ""
            Me.txtCodigoUnicoInterno.Text = ""
            Me.NumeroDocumento = ""
            Me.CodigoUSR = ""
            Me.FechaFin = 0
            Me.FechaIni = 0
            Me.CodigoRP = ""
            Me.InternoApePaterno = ""
            Me.InternoApeMaterno = ""
            Me.InternoNombres = ""
            dgwGrilla.DataSource = Nothing
            dgwGrillaIntegracion.DataSource = Nothing
        End Sub

        Public Sub _Buscar()
            If ValidarBusqueda() = False Then Exit Sub

            'FiltroActual = ConcatenarFiltro()

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0

            LoadPropiedades()

            Me.SuspendLayout()

            Me.BackgroundWorker1.RunWorkerAsync()

            frmLoad = New Load.frmLoad
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker1.CancelAsync()
                Me.BackgroundWorker1.Dispose()
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

            Dim dteFechaFin As Date = Now

            intSeg = DateDiff(DateInterval.Second, dteFechaIni, dteFechaFin)
        End Sub

        Public Function _GrillaInternoCodigo() As Integer
            Return Me.GrillaCodigo
        End Function

        Public Sub _LoadUsc()
            'ComboRegion()
            'ComboPenal()
            'Combo()
        End Sub
        Public Function _GrillaCount() As Integer
            Return Me.dgwGrilla.RowCount
        End Function

        Public Sub _Exportar()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else
                e.Result = Listar(worker, e)
            End If
        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                result = e.Result
            End If
        End Sub

        Private Sub txtCodigoUnicoSecuencial_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoUnicoInterno.KeyPress
            If e.KeyChar.ToString.ToUpper = "P" Or e.KeyChar.ToString.ToUpper = "E" Or e.KeyChar.ToString.ToUpper = "X" Then
                e.Handled = False
            ElseIf Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                RaiseEvent _Grilla_CellDoubleClick()
            End If
        End Sub

        Private Sub dgwGrilla_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            If dgwGrilla.Rows.Count = 0 Then Exit Sub

            Dim objDetIntegracion As New Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInternoDetalle)
            Dim ent As New Entity.Registro.Integracion.IntegracionInternoDetalle
            ent.IntegracionInternoId = Me.GrillaCodigo
            objDetIntegracion = (New Bussines.Registro.Integracion.IntegracionInternoDetalle).Listar(ent)
            Me.dgwGrillaIntegracion.AutoGenerateColumns = False
            Me.dgwGrillaIntegracion.DataSource = Nothing
            dgwGrillaIntegracion.DataSource = objDetIntegracion
        End Sub

        Private Sub dgwGrillaIntegracion_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaIntegracion.CellDoubleClick
            If dgwGrillaIntegracion.Rows.Count = 0 Then Exit Sub
            RaiseEvent _Cell_Click_VerDetalleInterno(Me.GrillaDetalleInternoId, Me.GrillaDetalleInternoPenalId, Me.GrillaDetalleInternoRegionId)
        End Sub

    End Class
End Namespace