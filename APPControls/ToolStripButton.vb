
Partial Public Class MyToolStripButton
    Inherits System.Windows.Forms.ToolStripButton

    Public Sub New()
        InitializeComponent()
    End Sub
#Region "Propiedades"
    Private objEnt As New Legolas.LEntity.Seguridad.Modulo
    Private intIndex As Integer = 0
    Public Property Index()
        Get
            Return intIndex
        End Get
        Set(ByVal value)
            intIndex = value
        End Set
    End Property
    Public Property Modulo() As Legolas.LEntity.Seguridad.Modulo
        Get
            Return objEnt
        End Get
        Set(ByVal value As Legolas.LEntity.Seguridad.Modulo)
            objEnt = value
        End Set
    End Property
#End Region

End Class
