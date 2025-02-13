
Namespace Sistema
    Public Class frmDetallePopup
        Private objBss As Bussines.Sistema.InstalacionDetalle = Nothing
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intInstalacionID As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Private Property InstalacionID() As Integer
            Get
                Return intInstalacionID
            End Get
            Set(ByVal value As Integer)
                intInstalacionID = value
            End Set
        End Property
        Private Property RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Private Property RegionNombre() As String
            Get
                Return Me.txtRegion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtRegion.Text = value
            End Set
        End Property
        Private Property PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Private Property PenalNombre() As String
            Get
                Return Me.txtPenal.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtPenal.Text = value
            End Set
        End Property
        Private Property Lectura() As Boolean
            Get
                Return Me.chkLectura.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkLectura.Checked = value
            End Set
        End Property
        Private Property Escritura() As Boolean
            Get
                Return Me.chkEscritura.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkEscritura.Checked = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            Dim objEnt As New Entity.Sistema.InstalacionDetalle
            objBss = New Bussines.Sistema.InstalacionDetalle

            objEnt = objBss.Listar(Me.Codigo)
            With objEnt
                Me.InstalacionID = .InstalacionID
                Me.RegionID = .RegionID
                Me.RegionNombre = .RegionNombre
                Me.PenalID = .PenalID
                Me.PenalNombre = .PenalNombre
                Me.Lectura = .Lectura
                Me.Escritura = .Escritura
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AGrabar()

            Dim intValue As Integer = -1
            objBss = New Bussines.Sistema.InstalacionDetalle

            intValue = objBss.Grabar(Me.Codigo, Me.InstalacionID, Me.RegionID, Me.PenalID, _
            Me.Lectura, Me.Escritura)

            If intValue > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If        

        End Sub
#End Region
        

        Private Sub frmDetallePopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub
    End Class
End Namespace


