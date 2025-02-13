Namespace Visita.Programacion
    Public Class uscProgramacionBusqueda
        Private objBss As Bussines.Visita.Programacion.CalendarioDetalle = Nothing
        Private objEntCol As Entity.Visita.Programacion.CalendarioDetalleCol = Nothing        
#Region "Eventos"        
        Public Event _ClickAgregar()
        Public Event _CellDoubleClick_Grilla(ByVal Codigo As Integer)
        Public Event _Click_BuscarInterno()
#End Region
#Region "Propiedades_Publicas"
        Public Property _CalendarioID() As Integer = -1
        Public Property _RegimenVisitaID As Short = -1
        Public Property _TipoVisitaID() As Short = -1
        Public Property _RegionID() As Short = -1
        Public Property _PenalID() As Short = -1
        Public ReadOnly Property _GrillaCodigo As Integer
            Get
                Return Me.GrillaCodigo
            End Get
        End Property
        Public ReadOnly Property _GrillaEstado As Integer
            Get
                Return Me.GrillaEstado
            End Get
        End Property
        Public Property _InternoID() As Integer = -1
        Public Property _InternoApellidosyNombres() As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(value As String)
                Me.UscLabelBusqueda1._Value = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstado() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_est").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades"
        Private Property EtapaID() As Integer
            Get
                Return Me.cbbEtapa.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEtapa.SelectedValue = value
            End Set
        End Property
        Private Property Sexo() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbHombres.Checked = True Then
                    value = 1
                End If

                If Me.rdbMujeres.Checked = True Then
                    value = 0
                End If

                If Me.rdbSexoAmbos.Checked = True Then
                    value = 10
                End If

                Return value

            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case -1
                        Me.rdbMujeres.Checked = False
                        Me.rdbHombres.Checked = False
                        Me.rdbSexoAmbos.Checked = False

                    Case 0
                        Me.rdbMujeres.Checked = True
                    Case 1
                        Me.rdbHombres.Checked = True
                    Case 10
                        Me.rdbSexoAmbos.Checked = True
                    Case Else
                        Me.rdbHombres.Checked = False
                        Me.rdbMujeres.Checked = False
                End Select
            End Set
        End Property        
#End Region
#Region "Propiedades_Usc"
        Public Property _VisibleBotonAdd() As Boolean
            Get
                Return Me.pnlAdd.Visible
            End Get
            Set(value As Boolean)
                Me.pnlAdd.Visible = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()

            With Me.cbbEtapa
                ._Todos = True
                ._LoadUsc(Type.Combo.ComboTipo.VIS_Etapa)
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            If Me._CalendarioID < 1 Then
                Exit Sub
            End If

            'listar
            Dim objEntFiltro As New Entity.Visita.Programacion.CalendarioDetalle
            With objEntFiltro
                .CalendarioID = Me._CalendarioID
                .VisitaTipoID = Me._TipoVisitaID
                .EtapaID = Me.EtapaID
                .SexoID = Me.Sexo
                .InternoID = Me._InternoID
            End With

            objBss = New Bussines.Visita.Programacion.CalendarioDetalle
            objEntCol = New Entity.Visita.Programacion.CalendarioDetalleCol

            objEntCol = objBss.Listar(objEntFiltro)

            VisibleColumnas()

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor

                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With


        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Dim blnVisibleEtapa As Boolean = False

            Select Case Me._RegimenVisitaID
                Case 1 'ordinario
                    blnVisibleEtapa = False
                Case 2 'especial
                    blnVisibleEtapa = True
            End Select

            Select Case Me._TipoVisitaID
                Case 10 'extra
                    Me.pnlVisita.Visible = False
                    Me.pnlVisitaExtra.Visible = True
                Case 12 'abogado
                    blnVisibleEtapa = False
                Case Else

            End Select

            Me.grbEtapa.Visible = blnVisibleEtapa

        End Sub
        Private Sub VisibleColumnas()

            Me.col_fec_ini.Tag = "fecha"

            Dim blnVisibleEtapa As Boolean = True
            Dim blnVisibleSexo As Boolean = True

            Select Case Me._RegimenVisitaID
                Case 1 'ordinario
                    blnVisibleEtapa = False

                    Select Case Me._TipoVisitaID
                        Case 10 'extraordinario
                            Me.col_int_ape_nom.Visible = True
                            blnVisibleSexo = False                            
                            'Case 12 'abogados
                            '    blnVisibleEtapa = False
                    End Select

                Case 2 'especial
                    Select Case Me._TipoVisitaID
                        Case 10 'extraordinario
                            Me.col_int_ape_nom.Visible = True                            
                            blnVisibleSexo = False
                            blnVisibleEtapa = False
                        Case 12 'abogados
                            blnVisibleEtapa = False
                    End Select
            End Select

            Me.col_etp_nom.Visible = blnVisibleEtapa
            Me.col_sex_nom.Visible = blnVisibleSexo

        End Sub
        Public Sub _Buscar()

            Buscar()

        End Sub

        Public Sub _LoadUsc()

            Combo()
            ValoresxDefault()

        End Sub
        Public Sub _ExportarGrillaExcel()

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub
#End Region
        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

            RaiseEvent _ClickAgregar()

        End Sub

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then

                        Me.Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        Me.Cursor = Cursors.Default

                        .Refresh()

                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            RaiseEvent _CellDoubleClick_Grilla(Me.GrillaCodigo)

        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_ini").Index ', .Columns("col_fec_fin").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub rdbHombres_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
            rdbHombres.Click, _
            rdbMujeres.Click, _
            rdbSexoAmbos.Click, _
            rdbTodos.Click

            Buscar()

        End Sub

        Private Sub cbbEtapa__SelectedIndexChanged() Handles cbbEtapa._SelectedIndexChanged

            Buscar()

        End Sub
        Private Sub UscLabelBusqueda1__Click_Buscar() Handles UscLabelBusqueda1._Click_Buscar

            RaiseEvent _Click_BuscarInterno()

        End Sub

        Private Sub UscLabelBusqueda1__Click_Eliminar() Handles UscLabelBusqueda1._Click_Eliminar

            Me._InternoID = -1
            'Me._InternoApellidosyNombres = ""
            Buscar()

        End Sub

        Private Sub UscLabelBusqueda1__KeyDown_Suprimir() Handles UscLabelBusqueda1._KeyDown_Suprimir

            Me._InternoID = -1
            'Me._InternoApellidosyNombres = ""
            Buscar()

        End Sub

        Private Sub UscLabelBusqueda1_Load(sender As System.Object, e As System.EventArgs) Handles UscLabelBusqueda1.Load

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub
    End Class

End Namespace