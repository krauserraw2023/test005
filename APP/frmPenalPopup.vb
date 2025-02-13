Public Class frmPenalPopup
    Public _frmLectura As Boolean = False
    Public _frmEscritura As Boolean = False
    Public _frmReporte As Boolean = False
    Public _frmImpresion As Boolean = False
    Public _frmEliminar As Boolean = False
#Region "Enum"
    Public Enum enumTipoCombo
        RegistroPenitenciario = 0
        Visitas = 1
        ParteDiario = 2
    End Enum
#End Region
#Region "Propiedades_Publicas"
    Public Property _TipoCombo() As enumTipoCombo = enumTipoCombo.RegistroPenitenciario
#End Region
#Region "Propiedades"
    Public Property RegionID() As Integer
        Get
            Return Me.cbbRegion.SelectedValue
        End Get
        Set(ByVal value As Integer)
            Me.cbbRegion.SelectedValue = value
        End Set
    End Property
    Public ReadOnly Property RegionNombre() As String
        Get
            Return Me.cbbRegion.Text
        End Get
    End Property
    Public Property PenalID() As Integer
        Get
            Return Me.cbbPenal.SelectedValue
        End Get
        Set(ByVal value As Integer)
            Me.cbbPenal.SelectedValue = value
        End Set
    End Property
    Public ReadOnly Property PenalNombre() As String
        Get
            Return Me.cbbPenal.Text.Trim
        End Get
    End Property
#End Region
#Region "Propiedades_Busqueda"
    Private intRegion As Integer = -1
    Private intPenal As Integer = -1
    Public Property BRegion() As Integer
        Get
            Return intRegion
        End Get
        Set(ByVal value As Integer)
            intRegion = value
        End Set
    End Property
    Public Property BPenal() As Integer
        Get
            Return intPenal
        End Get
        Set(ByVal value As Integer)
            intPenal = value
        End Set
    End Property
#End Region
#Region "Combo"

    Private Sub ComboRegion()

        Select Case Me._TipoCombo

            Case enumTipoCombo.RegistroPenitenciario

                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionUsuario
                    .Parametro1 = Legolas.Configuration.Usuario.Codigo
                    .Parametro2 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With

            Case enumTipoCombo.Visitas
                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With
            Case enumTipoCombo.ParteDiario
                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With
        End Select

    End Sub
    Private Sub ComboPenal()

        Select Case Me._TipoCombo
            Case enumTipoCombo.RegistroPenitenciario
                With Me.cbbPenal
                    .ComboTipo = Type.Combo.ComboTipo.PenalUsuario
                    .CodigoPadre = Me.RegionID
                    .Parametro1 = Legolas.Configuration.Usuario.Codigo
                    .Parametro2 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With
            Case enumTipoCombo.Visitas
                With Me.cbbPenal
                    .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                    .CodigoPadre = Me.RegionID
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With
            Case enumTipoCombo.ParteDiario
                With Me.cbbPenal
                    .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                    .CodigoPadre = Me.RegionID
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With
        End Select

    End Sub
#End Region
#Region "Accion"
    Private Function Validar() As Boolean

        Dim blnValue As Boolean = True

        If Me.PenalID < 1 Then
            blnValue = False
            MessageBox.Show("Seleccione Penal", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo,
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cbbPenal.Focus()
            Return blnValue
        End If

        Return blnValue

    End Function
    Private Sub AOK()

        If Me.Validar = False Then
            Exit Sub
        End If

        'Configuracion.Usuario.PenalID = Me.Penal
        'Configuracion.Usuario.PenalNombre = Me.PenalNombre

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
#End Region
#Region "Otros"
    Private Sub ValoresxDefault()

        ComboRegion()

        If Me.BRegion > 0 Then
            Me.RegionID = Me.BRegion
        End If

        ComboPenal()

        If Me.BPenal > 0 Then
            Me.PenalID = Me.BPenal
        End If


    End Sub
#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        AOK()

    End Sub

    Private Sub frmPenalPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ValoresxDefault()

    End Sub

    Private Sub cbbRegion__ValueChanged() Handles cbbRegion._SelectedIndexChanged

        Me.ComboPenal()

    End Sub

    Private Sub cbbRegion_Load(sender As System.Object, e As System.EventArgs) Handles cbbRegion.Load

    End Sub
End Class
