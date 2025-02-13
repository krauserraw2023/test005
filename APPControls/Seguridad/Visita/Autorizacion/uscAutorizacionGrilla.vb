Namespace Visita.Autorizacion
    Public Class uscAutorizacionGrilla
        Private objBss As Bussines.Visita.Autorizacion = Nothing
        Private objEntCol As Entity.Visita.AutorizacionCol = Nothing
        Public Event _CellDoubleClick(IDAutorizacion As Integer)

#Region "Propiedades_Par"
        Public Property _IDCalendarioDetalle As Integer = -1
        Public Property _IDInterno As Integer = -1
        Public Property _InternoApeNom As String = ""
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property _IDGrilla As Integer
            Get
                Return Me.IDGrilla
            End Get
        End Property
        Private ReadOnly Property IDGrilla() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get

        End Property
        Private ReadOnly Property IDVisitanteGrilla() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_vis_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value

            End Get
        End Property
        Private ReadOnly Property GrillaVisitante() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_vis_ape_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value

            End Get
        End Property
        Private ReadOnly Property IDParentescoGrilla() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_par_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value

            End Get
        End Property

#End Region
#Region "Listar"
        Private Sub Listar()

            objBss = New Bussines.Visita.Autorizacion
            Dim objEntFiltro As New Entity.Visita.Autorizacion

            With objEntFiltro
                .InternoID = Me._IDInterno
                .TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Extraordinario
                .EstadoID = 1 'activos
                .CalendarioDetalleID = Me._IDCalendarioDetalle
            End With

            objEntCol = objBss.ListarExtraordinario(objEntFiltro)

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .DataSource = objEntCol

                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Accion"
        Public Sub _AGrabarGrilla()

            Dim objEnt As Entity.Visita.Autorizacion = Nothing

            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                objEnt = New Entity.Visita.Autorizacion

                With objEnt
                    .Codigo = fila.Cells("col_id").Value
                    .InternoID = Me._IDInterno
                    .InternoApeNom = Me._InternoApeNom
                    .VisitanteID = fila.Cells("col_vis_id").Value
                    .VisitanteApeNom = fila.Cells("col_vis_ape_nom").Value
                    .ParentescoID = fila.Cells("col_par_id").Value
                End With

                objBss = New Bussines.Visita.Autorizacion
                objBss.GrabarGrillaAutorizacionExtraordinario(objEnt)
            Next

        End Sub

#End Region
#Region "Otros"
        Public Sub _LoasUsc()
            Listar()
        End Sub
#End Region

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            RaiseEvent _CellDoubleClick(Me.IDGrilla)

        End Sub
    End Class

End Namespace