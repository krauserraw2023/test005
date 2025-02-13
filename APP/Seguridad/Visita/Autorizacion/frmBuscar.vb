Namespace Visita.Autorizacion
    Public Class frmBuscar
#Region "Propiedades"
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Return Me.UscInternoBuscar1._GrillaInternoID
            End Get
        End Property
        Private ReadOnly Property GrillaInterno() As String
            Get
                Return Me.UscInternoBuscar1._GrillaInterno
            End Get
        End Property
        Private ReadOnly Property GrillaInternoEtapa() As String
            Get
                Return Me.UscInternoBuscar1._GrillaInternoEtapa
            End Get
        End Property
        Private ReadOnly Property GrillaInternoPabellon() As String
            Get
                Return Me.UscInternoBuscar1._GrillaInternoPabellon
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
#Region "Listar"
        Private Sub LoadUsc()

            Me.UscInternoBuscar1._Visible_CheckSelect = False
            Me.UscInternoBuscar1._LoadUsc()

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_AutorizacionMant(ByVal Nuevo As Boolean)

            If Me.GrillaInternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Seleccione el Interno")
                Exit Sub
            End If

            Dim frm As New Visita.Autorizacion.frmAutorizacionMant
            frm.MdiParent = Me.MdiParent
            With frm
                ._InternoID = Me.GrillaInternoID
                ._InternoApeNom = Me.GrillaInterno
                ._InternoEtapa = Me.GrillaInternoEtapa
                ._InternoPabellon = Me.GrillaInternoPabellon
                ._RegionID = Me.GrillaRegionID
                ._RegionNombre = Me.GrillaRegionNombre
                ._PenalID = Me.GrillaPenalID
                ._PenalNombre = Me.GrillaPenalNombre
                ._blnNuevo = Nuevo
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                ._FormImpresion = Me._FormImpresion
                .Show()
            End With

        End Sub
        Private Sub Form_Reporte()

            'validar penal
            If Me.UscInternoBuscar1._PenalID < 1 Then
                MessageBox.Show("Seleccione penal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim frm As New Visita.Autorizacion.frmReportePopup
            With frm
                ._RegionID = Me.UscInternoBuscar1._RegionID
                ._PenalID = Me.UscInternoBuscar1._PenalID                
                ._InternoID = Me.GrillaInternoID
                ._InternoApeNom = Me.GrillaInterno
                '/**/
                ._Reporte20 = True
                ._Reporte21 = True
                ._EnabledTipoInterno = True
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuarios_Permisos()

            Dim blnEscritura As Boolean = False

            Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                Case 1 'sede central
                    If Legolas.Configuration.Usuario.NivelUsuario = Type.Enumeracion.Usuario.EnumTipoUsuario.Nacional Then
                        If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                            blnEscritura = Me._FormEscritura
                        End If
                    End If
                Case Else 'otras licencias
                    blnEscritura = Me._FormEscritura
            End Select

            Me._FormEscritura = blnEscritura

            Me.pnlModificar.Visible = Me._FormEscritura
            Me.pnlExportar.Visible = Me._FormReporte
            Me.pnlReporte.Visible = Me._FormReporte

        End Sub
        Private Sub ValoresxDefaul()
            Usuarios_Permisos()

        End Sub
#End Region

        Private Sub btnSalirBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirBusqueda.Click

            Me.Close()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Me.UscInternoBuscar1._Exportar()

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            FRM_AutorizacionMant(False)

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            FRM_AutorizacionMant(True)

        End Sub

        Private Sub frmBuscar_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefaul()

        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Me.Refresh()
            LoadUsc()

        End Sub

        Private Sub UscInternoBuscar1__CellDoubleClick_Grilla() Handles UscInternoBuscar1._CellDoubleClick_Grilla

            FRM_AutorizacionMant(False)

        End Sub

        Private Sub UscInternoBuscar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UscInternoBuscar1.Load

        End Sub

        Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click

            Form_Reporte()

        End Sub
    End Class
End Namespace