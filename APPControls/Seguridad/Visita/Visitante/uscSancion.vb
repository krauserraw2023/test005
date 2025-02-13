Namespace Visita.Visitante
    Public Class uscSancion
        Private objBss As Bussines.Visita.VisitanteSancion = Nothing
        Private objEntCol As Entity.Visita.VisitanteSancionCol = Nothing
        '/*eventos*/
        Public Event _ClickAgregar()
        Public Event _CellDoubleClick_Grilla(ByVal SancionID As Integer)
#Region "Propiedades_Parametricas"
        Private intvisitanteid As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Public Property _VisitanteID() As Integer
            Get
                Return intvisitanteid
            End Get
            Set(ByVal value As Integer)
                intvisitanteid = value
            End Set
        End Property
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
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
#End Region
#Region "Propiedades_UserControl"
        Private blnVisibleGrabar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
            End Set
        End Property
        Public Property _VisiblePanelBotones As Boolean
            Get
                Return Me.pnlBotones.Visible
            End Get
            Set(value As Boolean)
                Me.pnlBotones.Visible = value
            End Set
        End Property
        Public Property _VisibleLeyenda As Boolean
            Get
                Return Me.pnlPie.Visible
            End Get
            Set(value As Boolean)
                Me.pnlPie.Visible = value
            End Set
        End Property
#End Region
#Region "Listar"     
        Private Sub Listar()

            If Me._VisitanteID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.VisitanteSancion
            objEntCol = New Entity.Visita.VisitanteSancionCol

            objEntCol = objBss.Listar(-1, Me._VisitanteID, "", "", "", "", _
            0, 0, 0, -1, -1, -1)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With


        End Sub
#End Region
#Region "Accion"
        Private Sub AAnular()

            If _VisibleGrabar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No tiene permisos en el sistema, para poder anular la sancion")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question( _
            "Desea anular la sancion") <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim value As Integer = -1

            objBss = New Bussines.Visita.VisitanteSancion

            value = objBss.GrabarEstado(Me.GrillaCodigo)

            If value > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Listar()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.pnlBotones.Visible = Me._VisibleGrabar

        End Sub
        Public Sub _LoadUsc()

            ValoresxDefault()
            Listar()

        End Sub

        Public Sub _limpiarGrilla()

            Me.dgwGrilla.DataSource = Nothing

        End Sub

#End Region

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

            'AMantenimiento(True)
            RaiseEvent _ClickAgregar()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                'AMantenimiento(False)
                RaiseEvent _CellDoubleClick_Grilla(Me.GrillaCodigo)
            End If

        End Sub

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete And Me.dgwGrilla.RowCount > 0 Then
                AAnular()
            End If

        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_ini").Index, .Columns("col_fec_fin").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                            'e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub
    End Class
End Namespace