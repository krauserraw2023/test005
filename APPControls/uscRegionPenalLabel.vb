Public Class uscRegionPenalLabel
#Region "Propiedades"
    Private intUsuarioID As Integer = -1
    Private intVersionInstalacionFile As Integer
    Private intRegionId As Integer = -1
    Private intPenalId As Integer = -1
    Public Property UsuarioID() As Integer
        Get
            Return intUsuarioID
        End Get
        Set(ByVal value As Integer)
            intUsuarioID = value
        End Set
    End Property
    Public Property VersionInstalacionFile() As Integer
        Get
            Return intVersionInstalacionFile
        End Get
        Set(ByVal value As Integer)
            intVersionInstalacionFile = value
        End Set
    End Property
    Public Property _RegionId() As Integer
        Get
            Return intRegionId
        End Get
        Set(ByVal value As Integer)
            intRegionId = value
        End Set
    End Property
    Public Property _Penalid() As Integer
        Get
            Return intPenalId
        End Get
        Set(ByVal value As Integer)
            intPenalId = value
        End Set
    End Property
    Public Property _PenalNombre() As String
        Get
            Return Me.lbl_penal.Text
        End Get
        Set(ByVal value As String)
            Me.lbl_penal.Text = value
        End Set
    End Property
    Public Property _RegionNombre() As String
        Get
            Return Me.lbl_region.Text
        End Get
        Set(ByVal value As String)
            Me.lbl_region.Text = value
        End Set
    End Property
#End Region

#Region "Propiedades_UserControl"
    Public Property _WidthRegion() As Integer
        Get
            Return Me.pnlRegion.Width
        End Get
        Set(ByVal value As Integer)
            Me.pnlRegion.Width = value
        End Set
    End Property
#End Region

End Class
