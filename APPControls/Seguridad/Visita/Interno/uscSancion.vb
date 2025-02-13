Namespace Visita.Interno
    Public Class uscSancion
        Private objBss As Bussines.Visita.InternoSancion = Nothing
        Private objEntCol As Entity.Visita.InternoSancionCol = Nothing
        '/*eventos*/
        Public Event _Click_Agregar()
        Public Event _CellDoubleClick_Grilla(ByVal SancionID As Integer)
#Region "Propiedades_Parametricas"
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private intInternoID As Integer = -1
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
        Public Property _InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
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
#Region "Propiedades_Otros"
        Private blnVisibleGrabar = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
            End Set
        End Property
#End Region
#Region "Listar"        
        Private Sub Listar()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.InternoSancion
            objEntCol = New Entity.Visita.InternoSancionCol

            objEntCol = objBss.Listar(-1, Me._InternoID, "", "", "", "", _
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

            objBss = New Bussines.Visita.InternoSancion

            value = objBss.GrabarEstado(Me.GrillaCodigo)

            If value > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Listar()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.pnlCabecera.Visible = Me._VisibleGrabar

        End Sub
        Public Sub _LoadUsc()

            ValoresxDefault()
            Listar()

        End Sub
        
#End Region
        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

            RaiseEvent _Click_Agregar()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
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