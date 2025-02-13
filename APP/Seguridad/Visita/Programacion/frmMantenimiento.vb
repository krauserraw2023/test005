Namespace Visita.Programacion

    Public Class frmMantenimiento
        Private objEnt As Entity.Visita.Programacion.Calendario = Nothing
        Private objBss As Bussines.Visita.Programacion.Calendario = Nothing      
#Region "Propiedades_Parametricas"
        Public Property _CalendarioID() As Integer = -1
        Public Property _RegimenVisitaID As Short = -1
        Public Property _RegimenVisitaNombre() As String
            Get
                Return Me.lblRegimenVisitaNom.Text
            End Get
            Set(ByVal value As String)
                Me.lblRegimenVisitaNom.Text = value.ToUpper
            End Set
        End Property
        Public Property _TipoVisitaID() As Short = -1
        Public Property _TipoVisitaNombre() As String
            Get
                Return Me.lblTipoVisita.Text
            End Get
            Set(ByVal value As String)
                Me.lblTipoVisita.Text = value.ToUpper
            End Set
        End Property
        Public Property _RegionID() As Short
            Get
                Return Me.UscRegionPenalLabel1._RegionId
            End Get
            Set(ByVal value As Short)
                Me.UscRegionPenalLabel1._RegionId = value
            End Set
        End Property
        Public Property _RegionNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._RegionNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._RegionNombre = value
            End Set
        End Property
        Public Property _PenalID() As Short
            Get
                Return Me.UscRegionPenalLabel1._Penalid
            End Get
            Set(ByVal value As Short)
                Me.UscRegionPenalLabel1._Penalid = value
            End Set
        End Property
        Public Property _PenalNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._PenalNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._PenalNombre = value
            End Set
        End Property
#End Region
#Region "Propiedades"

#End Region
#Region "Listar"
        Private Sub Listar()

            If Me._CalendarioID < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Visita.Programacion.Calendario
            objBss = New Bussines.Visita.Programacion.Calendario

            objEnt = objBss.Listar(Me._CalendarioID)

            With objEnt
                Me._RegionID = .RegionID
                Me._RegionNombre = .RegionNombre
                Me._PenalID = .PenalID
                Me._PenalNombre = .PenalNombre
                Me._RegimenVisitaID = .RegimenVisitaID
                Me._TipoVisitaID = .VisitaTipoID
            End With

            BuscarDetalle()

        End Sub
        Private Sub BuscarDetalle()

            With Me.UscProgramacionBusqueda1
                ._CalendarioID = Me._CalendarioID
                ._TipoVisitaID = Me._TipoVisitaID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Buscar()
            End With

        End Sub
        Private Sub LoadUscBusqueda()

            With Me.UscProgramacionBusqueda1
                ._CalendarioID = Me._CalendarioID
                ._RegimenVisitaID = Me._RegimenVisitaID
                ._TipoVisitaID = Me._TipoVisitaID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminar()

            Dim intCodigo As Integer = Me.UscProgramacionBusqueda1._GrillaCodigo
            If intCodigo > 0 Then

                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                    Dim objEnt As New Bussines.Visita.CalendarioDetalle
                    Dim objBss As New Bussines.Visita.Programacion.CalendarioDetalle

                    Dim objEntFiltro As New Entity.Visita.Programacion.CalendarioDetalle
                    With objEntFiltro
                        .CalendarioDetalleID = intCodigo
                    End With

                    objBss.Eliminar(objEntFiltro)

                    BuscarDetalle()

                End If

            End If

        End Sub
        Private Sub AAnular()

            Dim intEstado As Integer = 0 'baja

            Dim intCodigo As Integer = Me.UscProgramacionBusqueda1._GrillaCodigo
            If intCodigo > 0 Then

                If Legolas.Configuration.Aplication.MessageBox.Question( _
                    "Desea anular el registro seleccionado, una vez anulado no podra recuperarlo") = Windows.Forms.DialogResult.Yes Then

                    Dim intEstadoDetalle As Integer = Me.UscProgramacionBusqueda1._GrillaEstado

                    If intEstadoDetalle = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "El registro actual no se puede anular, porque ya se encuentra anulado")
                        Exit Sub
                    End If

                    Dim objEnt As New Bussines.Visita.CalendarioDetalle
                    Dim objBss As New Bussines.Visita.Programacion.CalendarioDetalle

                    objBss.GrabarEstado(intCodigo, intEstado)

                    BuscarDetalle()

                End If

            End If

        End Sub
        Private Sub AGrabar()

            objEnt = New Entity.Visita.Programacion.Calendario
            With objEnt
                .CalendarioID = Me._CalendarioID
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenVisitaID = Me._RegimenVisitaID
                .VisitaTipoID = Me._TipoVisitaID
                .FechaRegistro = Legolas.Configuration.Aplication.FechayHora.FechaLong
                .Estado = 1 'activo
            End With

            objBss = New Bussines.Visita.Programacion.Calendario
            Me._CalendarioID = objBss.Grabar(objEnt)

            If Me._CalendarioID > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            End If

        End Sub
#End Region
#Region "FRM"
        Private Sub FRM_Detalle(ByVal Nuevo As Boolean, ByVal Codigo As Integer)

            If Me._CalendarioID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Antes de registrar los detalles del horario, grabe los datos")
                Exit Sub
            End If

            Dim frm As New Visita.Programacion.frmDetallePopup
            With frm
                ._Codigo = Codigo
                ._Calendario = Me._CalendarioID
                ._RegionID = Me._RegionID
                ._RegionNombre = Me._RegionNombre
                ._PenalID = Me._PenalID
                ._PenalNombre = Me._PenalNombre
                ._RegimenVisitaID = Me._RegimenVisitaID
                ._TipoVisitaID = Me._TipoVisitaID
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormEliminar = Me._FormEliminar
                ._FormImpresion = Me._FormImpresion

                If .ShowDialog = vbOK Then
                    BuscarDetalle()
                End If
            End With

        End Sub
        Private Sub FRM_BuscarInterno()

            Dim frm As New Visita.Interno.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID
                ._RegionNombre = Me._RegionNombre
                ._PenalID = Me._PenalID
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.UscProgramacionBusqueda1._InternoID = ._GrillaInternoID
                    Me.UscProgramacionBusqueda1._InternoApellidosyNombres = ._GrillaApellidosyNombres
                    Me.UscProgramacionBusqueda1._Buscar()
                End If

            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub Usuarios_Permisos()

            Me.UscProgramacionBusqueda1._VisibleBotonAdd = Me._FormEscritura
            Me.pnlModificar.Visible = Me._FormEscritura
            Me.pnlEliminar.Visible = Me._FormEliminar

        End Sub
        Private Sub ValoresxDefault()

            Usuarios_Permisos()
            LoadUscBusqueda()

        End Sub
#End Region

        Private Sub frmMantenimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmMantenimiento_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Listar()

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub UscProgramacionBusqueda1__CellDoubleClick_Grilla(ByVal Codigo As Integer) Handles UscProgramacionBusqueda1._CellDoubleClick_Grilla

            FRM_Detalle(True, Codigo)

        End Sub

        Private Sub UscProgramacionBusqueda1__Click_BuscarInterno() Handles UscProgramacionBusqueda1._Click_BuscarInterno

            FRM_BuscarInterno()

        End Sub

        Private Sub UscProgramacionBusqueda1__ClickAgregar() Handles UscProgramacionBusqueda1._ClickAgregar

            FRM_Detalle(True, -1)

        End Sub

        Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

            AGrabar()

        End Sub

        Private Sub UscProgramacionBusqueda1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UscProgramacionBusqueda1.Load

        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
            AAnular()
        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            Me.UscProgramacionBusqueda1._ExportarGrillaExcel()

        End Sub
    End Class
End Namespace