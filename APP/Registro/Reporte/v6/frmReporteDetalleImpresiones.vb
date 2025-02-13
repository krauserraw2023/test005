Namespace Registro.Reporte.V6
    Public Class frmReporteDetalleImpresiones
        Private Property ReporteCabeceraId As Integer = -1
        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub frmReporteDetalleImpresiones_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Dim bss As New Bussines.Reporte.ReporteCabecera
            dgwDetallePrint.AutoGenerateColumns = False
            dgwDetallePrint.DataSource = bss.ListarGrillaImpresiones(Me.ReporteCabeceraId)
            lblTotal.Text = dgwDetallePrint.Rows.Count.ToString("00")
        End Sub

        Public Sub New(ReporteCabeceraId As Integer)

            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            Me.ReporteCabeceraId = ReporteCabeceraId
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        End Sub
    End Class
End Namespace