Namespace Registro.Siscrico
    Public Class frmReporteFichInterno
        Private blnImpresion As Boolean = False
        Public Property _FormImpresion() As Boolean
            Get
                Return blnImpresion
            End Get
            Set(value As Boolean)
                blnImpresion = value
                UscContentReport1._CambiarEstadoImpresion = value
            End Set
        End Property
        Public Sub New(idsInterno As String)

            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            UscContentReport1.CargarReporte(idsInterno)
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        End Sub

        Private Sub Click_CerrarVentanReporte() Handles UscContentReport1.Click_CerrarVentanReporte
            Me.Close()
        End Sub

        Private Sub UscContentReport1_Load(sender As System.Object, e As System.EventArgs) Handles UscContentReport1.Load

        End Sub
    End Class
End Namespace
