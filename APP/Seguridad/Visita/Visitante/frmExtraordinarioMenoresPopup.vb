Namespace Visita.Visitante
    Public Class frmExtraordinarioMenoresPopup
        Private objBss As Bussines.Visita.Autorizacion = Nothing
        Private objEntCol As Entity.Visita.AutorizacionCol = Nothing
#Region "Propiedades_Par"
        Public Property _RegionID() As Integer
        Public Property _PenalID() As Integer
        Public Property _IDCalendarioDetalle As Integer = -1
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property _IDVisitanteGrilla() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_vis_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _IDTipoDocumentoVisitanteGrilla() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_tip_doc").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _GrillaVisitanteNumeroDocumento() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_num_doc").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _IDParentescoVisitanteGrilla() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_par_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _GrillaVisitanteParentesco() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_par_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

#End Region
#Region "Listar"
        Private Sub Listar()

            objBss = New Bussines.Visita.Autorizacion
            objEntCol = New Entity.Visita.AutorizacionCol

            Dim objEntFiltro As New Entity.Visita.Autorizacion

            With objEntFiltro
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .CalendarioDetalleID = Me._IDCalendarioDetalle
                .TipoID = 99 'extraordinario
                .Fecha = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            End With

            objEntCol = objBss.ListarExtraordinario_MenorEdad(objEntFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount() & " .Reg"
            End With

            If Me.dgwGrilla.RowCount < 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.Abort
            End If

        End Sub
#End Region
#Region "Accion"
        Private Sub AOK()

            If Me._IDVisitanteGrilla > 0 Then
                Me.DialogResult = DialogResult.OK
            End If

        End Sub

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

        End Sub
#End Region


        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            AOK()

        End Sub

        Private Sub frmBuscarPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                AOK()
            End If

        End Sub

        Private Sub frmBuscarPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.Refresh()
            Listar()

        End Sub
    End Class
End Namespace
