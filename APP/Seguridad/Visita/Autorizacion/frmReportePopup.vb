Namespace Visita.Autorizacion
    Public Class frmReportePopup
#Region "Propiedades_Par"
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _InternoApeNom As String = ""        
        '/*/
        Public Property _VisibleBuscar() As Boolean = True
        Public Property _Reporte20 As Boolean = False
        Public Property _Reporte21 As Boolean = False
        Public Property _EnabledTipoInterno() As Boolean = False
#End Region
#Region "Propiedades_Grilla"
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
#End Region
#Region "Propiedades"
        Private Property TipoSeleccionInterno() As Short
            Get

                Dim value As Short = -1

                If Me.rdbSeleccionarInterno.Checked = True Then
                    value = 1
                End If

                Return value

            End Get
            Set(value As Short)
                Select Case value
                    Case 1
                        Me.rdbSeleccionarInterno.Checked = True
                    Case Else
                        Me.rdbInternoTodos.Checked = True
                End Select
            End Set
        End Property
        Private Property InternoID As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(ByVal value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property Interno As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(ByVal value As String)
                Me.UscLabelBusqueda1._Value = value.ToUpper
            End Set
        End Property
        Private Property IDPabellon As Integer = -1

        Private Property Estado() As Integer
            Get

                Dim value As Short = -1

                If Me.rdbActivo.Checked = True Then
                    value = 1
                End If

                If Me.rdbInactivo.Checked = True Then
                    value = 2
                End If

                Return value

            End Get
            Set(value As Integer)

                Select Case value
                    Case 1
                        Me.rdbActivo.Checked = True
                    Case 2
                        Me.rdbInactivo.Checked = True
                    Case Else
                        Me.rdbTodos.Checked = True
                End Select
            End Set
        End Property

#End Region
#Region "Listar"
        Private Sub ListarReporte()

            Dim strReporte As String = "14,18"
            Dim strReporte20 As String = "20"
            Dim strReporte21 As String = "21"
            Dim strComa As String = ","

            Dim objEntFiltro As New Legolas.LEntity.Globall.Reporte
            Dim objEntCol As New Legolas.LEntity.Globall.ReporteCol

            Dim objBss As New Legolas.LBusiness.Globall.Reporte

            If Me._Reporte20 = True Then
                strReporte = strReporte & strComa & strReporte20
            End If

            If Me._Reporte21 = True Then
                strReporte = strReporte & strComa & strReporte21
            End If

            With objEntFiltro
                .CodigoMultiple = strReporte
            End With

            objEntCol = objBss.Listar(objEntFiltro)

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor

                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            Select Case Me.TipoSeleccionInterno
                Case 1
                    ' x Interno
                    If Me.InternoID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Seleccione el Interno")
                        Return value
                    Else
                        value = True
                    End If
                Case Else
                    'todos
                    If Legolas.Configuration.Aplication.MessageBox.Question(
                        "Esta seguro de visualizar el reporte con todos los internos. Esta opcion tomara mas tiempo, desea continuar de todas maneras") = Windows.Forms.DialogResult.Yes Then
                        value = True
                    End If
            End Select

            Return value

        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Dim frm As New APPReporte.Visita.ReporteCrystal
            With frm
                ._Filtro.Text = Me.Text
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.RegionID = Me._RegionID
                ._Filtro.PenalID = Me._PenalID
                ._Filtro.PabellonID = Me.IDPabellon
                ._Filtro.EstadoID = Me.Estado
                ._TipoReporte = Me.GrillaCodigo
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_BuscarInterno()

            Dim frm As New Visita.Interno.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisibleRegionPenal = False
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong
                ._VisibleBotonHistorial = False

                If .ShowDialog() = DialogResult.OK Then
                    Me.InternoID = ._GrillaInternoID
                    Me.Interno = ._GrillaApellidosyNombres
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarReporte()

            Dim blnHabilitarEstadoAuto As Boolean = False
            Dim blnHabilitarSelectInterno As Boolean = False
            Dim blnHabilitarPabellon As Boolean = False

            Select Case Me.GrillaCodigo
                Case 14 'Visitas autorizados por el Interno(a)
                    Me.TipoSeleccionInterno = 1
                    blnHabilitarEstadoAuto = True
                    blnHabilitarSelectInterno = False
                    HabilitarTipoInterno()
                Case 18 'Visitas autorizados Anexo 02
                    Me.TipoSeleccionInterno = 1
                    Me.Estado = 1
                    blnHabilitarEstadoAuto = True
                    blnHabilitarSelectInterno = True
                    HabilitarTipoInterno()
                Case 20  'rpt_autorizacion_grupo

                    Me.TipoSeleccionInterno = -1
                    Me.Estado = 1
                    blnHabilitarEstadoAuto = False
                    blnHabilitarSelectInterno = False
                    HabilitarTipoInterno()
                Case 21 ' rpt_autorizacion_estadistico

                    Me.TipoSeleccionInterno = -1
                    Me.Estado = 1
                    blnHabilitarEstadoAuto = False
                    blnHabilitarSelectInterno = False
                    HabilitarTipoInterno()
            End Select

            If _EnabledTipoInterno = False Then
                blnHabilitarSelectInterno = _EnabledTipoInterno
            End If

            Me.grbEstadoAut.Enabled = blnHabilitarEstadoAuto
            Me.grbBuscarInterno.Enabled = blnHabilitarSelectInterno

        End Sub
        Private Sub HabilitarTipoInterno()

            Select Case Me.TipoSeleccionInterno
                Case 1
                    Me.pnlSeleccionarInterno.Enabled = True
                Case Else

                    Me.InternoID = -1
                    Me.Interno = "[SELECCIONE]"
                    Me.pnlSeleccionarInterno.Enabled = False
            End Select

        End Sub
        Private Sub ValoresxDefault()

            If Me._InternoID > 0 Then
                Me.InternoID = Me._InternoID
                Me.Interno = Me._InternoApeNom
            End If

            Me.grbBuscarInterno.Enabled = Me._EnabledTipoInterno

            Me.UscLabelBusqueda1._Visible_Buscar = Me._VisibleBuscar

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOK()

        End Sub

        Private Sub frmReporteHistorialPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub UscBusquedaVisitante1__Buscar_Click() Handles UscLabelBusqueda1._Click_Buscar

            FRM_BuscarInterno()

        End Sub

        Private Sub UscLabelBusqueda1_Load(sender As System.Object, e As System.EventArgs) Handles UscLabelBusqueda1.Load

        End Sub

        Private Sub rdbSeleccionarInterno_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbSeleccionarInterno.CheckedChanged

        End Sub

        Private Sub rdbSeleccionarInterno_Click(sender As Object, e As System.EventArgs) Handles _
            rdbSeleccionarInterno.Click, _
             rdbInternoTodos.Click

            HabilitarTipoInterno()

        End Sub

        Private Sub rdbInternoTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbInternoTodos.CheckedChanged

        End Sub

        Private Sub rdbInternoTodos_Click(sender As Object, e As System.EventArgs) Handles rdbInternoTodos.Click

        End Sub

        Private Sub frmReportePopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarReporte()
            HabilitarReporte()

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            HabilitarReporte()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter



        End Sub
    End Class
End Namespace