Namespace Visita.Visitante
    Public Class uscVisitanteRestriccion
        Private objBss As Bussines.Visita.VisitanteRestriccion = Nothing
        Private objEntCol As Entity.Visita.VisitanteRestriccionCol = Nothing
        '/*eventos*/
        Public Event _ClickAgregar()
        Public Event _CellDoubleClick_Grilla(ByVal RestriccionID As Integer)
#Region "Propiedades_Parametricas"    
        Public Property _VisitanteID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
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
        Public Property _VisibleGrabar() As Boolean = False
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me._VisitanteID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.VisitanteRestriccion
            objEntCol = New Entity.Visita.VisitanteRestriccionCol

            Dim objEntFiltro As New Entity.Visita.VisitanteRestriccion

            With objEntFiltro
                .VisitanteID = Me._VisitanteID
            End With

            objEntCol = objBss.Listar(objEntFiltro)

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

            If Me._VisibleGrabar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No tiene permisos en el sistema, para poder anular la sancion")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question( _
            "Desea anular la sancion") <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim value As Integer = -1
            objBss = New Bussines.Visita.VisitanteRestriccion

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

#End Region
       
        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

            RaiseEvent _ClickAgregar()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                'AMantenimiento(False)
                RaiseEvent _CellDoubleClick_Grilla(Me.GrillaCodigo)
            End If

        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

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
                            e.Value = Legolas.Components.FechaHora.FechaString(e.Value)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub
    End Class

End Namespace