Namespace Visita.Interno
    Public Class frmBuscar
        Private objBss As Bussines.Visita.Interno = Nothing
        Private objEntCol As Entity.Visita.InternoCol = Nothing
#Region "Propiedades_Grilla"        
        Private ReadOnly Property GrillaInternoID() As Integer
            Get              
                Return Me.UscInternoBuscar1._GrillaInternoID
            End Get
        End Property
        Private ReadOnly Property GrillaInternoApeNom() As String
            Get
                Return Me.UscInternoBuscar1._GrillaInterno
            End Get
        End Property
        Private ReadOnly Property GrillaRegionID() As Integer
            Get               
                Return Me.UscInternoBuscar1._GrillaRegionID
            End Get
        End Property
        Private ReadOnly Property GrillaRegionNombre() As String
            Get
                Return Me.UscInternoBuscar1._GrillaRegionNombre
            End Get
        End Property
        Private ReadOnly Property GrillaPenalID() As Integer
            Get
                Return Me.UscInternoBuscar1._GrillaPenalID
            End Get
        End Property
        Private ReadOnly Property GrillaPenalNombre() As String
            Get
                Return Me.UscInternoBuscar1._GrillaPenalNombre
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private Property RegionID() As Integer
            Get
                Return Me.UscInternoBuscar1._RegionID
            End Get
            Set(ByVal value As Integer)
                Me.UscInternoBuscar1._RegionID = value
            End Set
        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.UscInternoBuscar1._PenalID
            End Get
            Set(ByVal value As Integer)
                Me.UscInternoBuscar1._PenalID = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub LoadUsc()

            Me.UscInternoBuscar1._Visible_CheckSelect = True
            Me.UscInternoBuscar1._LoadUsc()

        End Sub

#End Region
#Region "Accion"

        Public Sub AExportar()
            Me.UscInternoBuscar1._Exportar()

        End Sub
#End Region
#Region "Form"
        
        Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean)

            Dim blnValue As Boolean = False
            Dim intInterno As Integer = -1
            Dim intRegionID As Integer = -1
            Dim strRegion As String = ""
            Dim intPenalID As Integer = -1
            Dim strPenal As String = ""

            If Nuevo = True Then

                Dim frm As New frmPenalPopup
                With frm
                    ._TipoCombo = frmPenalPopup.enumTipoCombo.Visitas
                    .BRegion = Me.RegionID
                    .BPenal = Me.PenalID

                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        intRegionID = .RegionID
                        strRegion = .RegionNombre
                        intPenalID = .PenalID
                        strPenal = .PenalNombre
                        blnValue = True
                    End If
                End With
            Else
                blnValue = True
                intInterno = Me.GrillaInternoID
                intRegionID = Me.GrillaRegionID
                strRegion = Me.GrillaRegionNombre
                intPenalID = Me.GrillaPenalID
                strPenal = Me.GrillaPenalNombre
            End If

            If blnValue = True Then

                Dim frm As New Visita.Interno.frmMant
                frm.MdiParent = Me.MdiParent
                With frm
                    ._InternoID = intInterno
                    ._RegionID = intRegionID
                    ._RegionNombre = strRegion
                    ._PenalID = intPenalID
                    ._PenalNombre = strPenal
                    'permisos
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                    .Show()
                End With
                'End If

            End If

        End Sub
        Private Sub FRM_Reporte()

            If Me.PenalID < 1 Then
                MessageBox.Show("Seleccione penal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim frm As New Visita.frmReportePopup
            With frm
                ._SelectIDRegion = Me.RegionID
                ._SelectIDPenal = Me.PenalID
                ._InternoID = Me.GrillaInternoID
                ._InternoApeNom = Me.GrillaInternoApeNom
                ._TipoSancion = Type.Enumeracion.Visita.Sancion.Interno
                .ShowDialog()
            End With

        End Sub

#End Region
#Region "Permisos/Acceso/Perfiles"

        Private Sub UsuarioPermisos()

            Me.pnlModificar.Visible = Me._FormEscritura
            Me.pnlExportar.Visible = Me._FormReporte
            Me.pnlReporte.Visible = Me._FormReporte

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

        End Sub

#End Region
        Private Sub frmInternoBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()            
            UsuarioPermisos()

        End Sub

        Private Sub btnSalirBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirBusqueda.Click

            Me.Close()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            AExportar()
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            FRM_Mantenimiento(True)

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            UscInternoBuscar1__CellDoubleClick_Grilla()

        End Sub

        Private Sub frmInternoBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Me.Refresh()
            LoadUsc()

        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click

            FRM_Reporte()

        End Sub

        Private Sub UscInternoBuscar1__CellDoubleClick_Grilla() Handles UscInternoBuscar1._CellDoubleClick_Grilla

            FRM_Mantenimiento(False)

        End Sub

        Private Sub btnInactivar_Click(sender As System.Object, e As System.EventArgs)

            Me.UscInternoBuscar1._InactivarInternoMasivo()

        End Sub

        Private Sub btnActivar_Click(sender As System.Object, e As System.EventArgs)

            Me.Cursor = Cursors.WaitCursor
            Me.UscInternoBuscar1._ActivarInterno()
            Me.Cursor = Cursors.Default

        End Sub

        Private Sub UscInternoBuscar1_Load(sender As Object, e As EventArgs) Handles UscInternoBuscar1.Load

        End Sub

        Private Sub pnlActivar_Paint(sender As Object, e As PaintEventArgs)

        End Sub
    End Class
End Namespace
