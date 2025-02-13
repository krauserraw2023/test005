Namespace Estadistica
    Public Class frmReportePopup
#Region "Propiedades_Parametricas"
        Public Property _IDPadin As Integer = -1
        Public Property _IDRegion As Integer = -1
        Public Property _RegionNombre As String = ""
        Public Property _IDPenal As Integer = -1
        Public Property _PenalNombre As String = ""

        Public Property _Anio As Integer = -1
        Public Property _Mes As Integer = -1
        Public Property _FechaInicio As Long = 0
        Public Property _FechaFin As Long = 0
        Public Property _NumeroPadin As Integer = 0
        Public Property _EstadoPadin As Integer = 0
#End Region

#Region "Propiedades_UserControls"
    
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
#Region "Propiedades_Filtros"


        Private Property RegionNombre() As String
            Get
                Return Me.txtRegion.Text
            End Get
            Set(value As String)
                Me.txtRegion.Text = value
            End Set
        End Property
        Private Property PenalNombre() As String
            Get
                Return Me.txtPenal.Text
            End Get
            Set(value As String)
                Me.txtPenal.Text = value
            End Set
        End Property

        Private ReadOnly Property TipoNacionalidad() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbPerua.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbExtran.Checked = True Then
                    intValue = 2
                End If

                Return intValue
            End Get
        End Property

#End Region
#Region "Combo"
    
#End Region
#Region "Listar"
        Private Sub ListarReporte()

            Dim strReporte As String = "1,2,3"

            Dim objEntFiltro As New Legolas.LEntity.Globall.Reporte
            Dim objEntCol As New Legolas.LEntity.Globall.ReporteCol

            Dim objBss As New Legolas.LBusiness.Globall.Reporte

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

            Select Case Me.GrillaCodigo
                Case 1

            End Select

            value = True
            Return value

        End Function
        
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Select Case Me.GrillaCodigo
                Case 1
                    FRM_ReporteF1()
                Case 2 'constanacia de reclusion
                    FRM_ReporteCuadro14()
                Case 3
                    FRM_ReporteCuadro15()              
            End Select

        End Sub

#End Region
#Region "Form"
      
        Private Sub FRM_ReporteF1()
            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte1
                ._PadinID = Me._IDPadin
                ._PenalID = Me._IDPenal                
                ._FechaInicio = Me._FechaInicio
                ._FechaFin = Me._FechaFin
                'como parametro para el reporte
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._Correlativo = Me._NumeroPadin
                ._EstadoPadin = Me._EstadoPadin
                .ShowDialog()
            End With
        End Sub

        Private Sub FRM_ReporteCuadro14()
            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte2
                ._PadinID = Me._IDPadin
                ._PenalID = Me._IDPenal                
                ._Nacionalidad = Me.TipoNacionalidad                                
                'como parametro para el reporte
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._Correlativo = Me._NumeroPadin
                ._EstadoPadin = Me._EstadoPadin
                .Show()
            End With
        End Sub

        Private Sub FRM_ReporteCuadro15()
            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte3
                ._PadinID = Me._IDPadin
                ._PenalID = Me._IDPenal
                'como parametro para el reporte
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._FechaFin = Me._FechaFin
                ._Correlativo = Me._NumeroPadin
                ._EstadoPadin = Me._EstadoPadin
                .ShowDialog()
            End With
        End Sub

#End Region
#Region "Otros"
        Private Sub HabilitarReporte()

            Dim blnRegionPenal As Boolean = False
            Dim blnMostrarNacionalidad As Boolean = False
            
            Select Case Me.GrillaCodigo

                Case 1 'reporte f1

                    blnRegionPenal = True
                  
                Case 2

                    blnRegionPenal = True
                    blnMostrarNacionalidad = True

                Case 3

                    blnRegionPenal = True
                 
            End Select


            Me.grbRegionPenal.Enabled = blnRegionPenal
            Me.grbNacionalidad.Enabled = blnMostrarNacionalidad

        End Sub
        
        Private Sub ValoresxDefault()

            Me.RegionNombre = Me._RegionNombre
            Me.PenalNombre = Me._PenalNombre

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


        Private Sub frmReportePopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarReporte()
            HabilitarReporte()
        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            HabilitarReporte()

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter
            HabilitarReporte()
        End Sub

   
    End Class
End Namespace