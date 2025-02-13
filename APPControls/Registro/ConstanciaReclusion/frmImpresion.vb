Namespace Registro.ConstanciaReclusion

    Public Class frmImpresion

        Private idTramiteCR As Integer = -1
        Public Sub New(idTramite As Integer, numeroTramite As String, NumeroCR As String)

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.idTramiteCR = idTramite
            Me.numeroTramite = numeroTramite
            Me.numeroCR = NumeroCR

        End Sub
#Region "propiedades"
        Public Property numeroTramite As String
            Get
                Return txtNumeroTramite.Text
            End Get
            Set(value As String)
                txtNumeroTramite.Text = value
            End Set
        End Property

        Public Property numeroCR As String
            Get
                Return txtNumeroCR.Text
            End Get
            Set(value As String)
                txtNumeroCR.Text = value
            End Set
        End Property

#End Region

#Region "Listar"
        Public Sub buscar()

            Dim objFiltro As New Entity.Registro.ConstanciaReclusion.Impresion
            Dim objBss As New Bussines.Registro.ConstanciaReclusion.Impresion

            With objFiltro
                .codigoCR = Me.idTramiteCR
            End With

            Dim lista As New List(Of Entity.Registro.ConstanciaReclusion.Impresion)
            objBss = New Bussines.Registro.ConstanciaReclusion.Impresion

            lista = objBss.listarGrilla(objFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = lista
            End With
        End Sub

        Private Sub frmImpresion_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            buscar()

        End Sub
#End Region
    End Class
End Namespace
