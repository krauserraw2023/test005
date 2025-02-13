Public Class usrRegionPenal
    Public Event _ValueChanged()
    Public Event _RegionSelectedIndexChanged()
    Public Event _PenalSelectedIndexChanged()
#Region "Enum"
    Public Enum enmTipoCombo
        Usuario = 0
        Licencia = 1
        LicenciaTieneSistemaVisita = 2
    End Enum
    Public Property _TipoCombo As enmTipoCombo = enmTipoCombo.Usuario
#End Region
#Region "Propiedades_Publicas"
    Public Property _LicenciaID() As Integer = -1
    Public Property _UsuarioID() As Integer = -1
    Public Property _RegionID() As Integer
        Get
            Return Me.RegionID
        End Get
        Set(ByVal value As Integer)
            Me.RegionID = value
        End Set
    End Property
    Public ReadOnly Property _RegionNombre() As String
        Get
            Return Me.cbbRegion.Text
        End Get
    End Property
    Public Property _PenalID() As Integer
        Get
            Return Me.PenalID
        End Get
        Set(ByVal value As Integer)
            Me.PenalID = value
        End Set
    End Property
    Public ReadOnly Property _PenalNombre() As String
        Get
            Return Me.cbbPenal.Text
        End Get
    End Property
    Public Property _PenalTodos As Boolean = True
    Public Property _NivelUsuario As Short = -1
    Public Property _PerfilUsuario As Short = -1
#End Region
#Region "Propiedades"
    Private Property RegionID() As Integer
        Get
            Return Me.cbbRegion.SelectedValue
        End Get
        Set(ByVal value As Integer)
            Me.cbbRegion.SelectedValue = value
        End Set
    End Property
    Private Property PenalID() As Integer
        Get
            Return Me.cbbPenal.SelectedValue
        End Get
        Set(ByVal value As Integer)
            Me.cbbPenal.SelectedValue = value
        End Set
    End Property        
#End Region

#Region "Propiedades_UserControl"
    Public Property WidthRegion() As Integer
        Get
            Return Me.pnlRegion.Width
        End Get
        Set(ByVal value As Integer)
            Me.pnlRegion.Width = value
        End Set
    End Property
    Public Property _WidthLabelRegion As Integer
        Get
            Return Me.lblRegion.Width
        End Get
        Set(value As Integer)
            Me.lblRegion.Width = value
        End Set
    End Property

#End Region
#Region "Combo"
    Private blnComboRegion As Boolean = False
    Private blnComboPenal As Boolean = False
    Private Sub ComboRegion()
        blnComboRegion = False

        Select Case Me._TipoCombo
            Case enmTipoCombo.Usuario

                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionUsuario
                    .Parametro1 = Me._UsuarioID
                    .Parametro2 = Me._LicenciaID
                    .LoadUsc()
                End With

            Case enmTipoCombo.Licencia

                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                    .Parametro1 = Me._LicenciaID
                    .LoadUsc()
                End With

            Case enmTipoCombo.LicenciaTieneSistemaVisita

                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionLicencia_TieneSistemaVisita
                    .Parametro1 = Me._LicenciaID
                    .LoadUsc()
                End With

                '/*evaluar el modulo carceleta*/
                Select Case Legolas.Configuration.Usuario.NivelUsuario

                    Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta

                        Me.RegionID = 3 'region lima
                        Me.cbbRegion.Enabled = False

                    Case Else
                        'nada 
                End Select

        End Select

        blnComboRegion = True

    End Sub
    Private Sub ComboPenal()
        blnComboPenal = False

        Dim blnTodos As Boolean = False

         Select Me._TipoCombo
            Case enmTipoCombo.Usuario
                With Me.cbbPenal
                    .ComboTipo = Type.Combo.ComboTipo.PenalUsuario
                    .CodigoPadre = Me._RegionID
                    .Parametro1 = Me._UsuarioID
                    .Parametro2 = Me._LicenciaID
                    .LoadUsc()
                End With

            Case enmTipoCombo.Licencia

                If Me._LicenciaID = 1 And Me._PenalTodos = True Then 'licencia sede central
                    blnTodos = True
                End If

                With Me.cbbPenal
                    .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                    .CodigoPadre = Me._RegionID
                    .Parametro1 = Me._LicenciaID
                    ._Todos = blnTodos
                    .LoadUsc()
                End With

            Case enmTipoCombo.LicenciaTieneSistemaVisita

                If Me._LicenciaID = 1 And Me._PenalTodos = True Then 'licencia sede central
                    blnTodos = True
                End If

                With Me.cbbPenal
                    .ComboTipo = Type.Combo.ComboTipo.PenalLicencia_TieneSistemaVisita
                    .CodigoPadre = Me._RegionID
                    .Parametro1 = Me._LicenciaID
                    ._Todos = blnTodos
                    .LoadUsc()
                End With

                '/*evaluar el modulo carceleta*/
                Select Case Legolas.Configuration.Usuario.NivelUsuario

                    Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta

                        Me.PenalID = 35 'penal carceleta
                        Me.cbbPenal.Enabled = False

                    Case Else
                        'nada 
                End Select

        End Select

        blnComboPenal = True
    End Sub
#End Region
#Region "Otros"
    Public Sub _LoadUsc()
        ValoresxDefault()
    End Sub
    Public Sub LoadUsc()
        ValoresxDefault()
    End Sub
#End Region
    Private Sub ValoresxDefault()

        ComboRegion()
        ComboPenal()

    End Sub

    Private Sub usrRegionPenal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Height = 22
    End Sub

    Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

        If blnComboRegion = True Then
            ComboPenal()
            RaiseEvent _PenalSelectedIndexChanged()
        End If

    End Sub

    Private Sub cbbPenal__SelectedIndexChanged() Handles cbbPenal._SelectedIndexChanged

        If blnComboPenal = True Then
            RaiseEvent _PenalSelectedIndexChanged()
        End If

    End Sub

End Class
