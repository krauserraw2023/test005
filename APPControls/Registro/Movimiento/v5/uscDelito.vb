Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.Movimiento

Namespace Registro.Documento
    Public Class uscDelito
#Region "Propiedades"
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _IngresoInpeId() As Integer = -1
        Public Property _ExpedienteID() As Integer = -1
        Public Property _TipoDocumentoID() As Integer = -1
        Public Property _TipoMovimineto() As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propieades_Grilla"
        Private ReadOnly Property GrillaDelitoCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = Me.dgwDelito.SelectedRows(0).Cells("col_del_id").Value
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaExpedienteID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = Me.dgwDelito.SelectedRows(0).Cells("col_del_id").Value
                Catch ex As Exception
                End Try

                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_GrillaCount"
        Private Property GrillaCountDel() As Integer = 0
#End Region
#Region "Propiedades_UserControl"
        Public Event _CellDoubleClick_GrillaDelito(IngresoID As Integer, ExpedienteCodigo As Integer, DelitoCodigo As Integer)
        Public Event _CellDoubleClick_GrillaDelito2(_ObjEntDel As Entity.Registro.Delito)
#End Region
#Region "Listar"
        Private objEntCol2 As New Entity.Registro.DelitoCol
        Private Sub ListarDelito()
            If Me._TipoMovimineto = EnumMovTipo.Internamiento Then
                With dgwDelito
                    .Columns("DelitoMayorPena").Visible = False
                    .Columns("SentenciaMayorPena").Visible = False
                End With
            End If
            If Me._ExpedienteID < 1 Then
                Me.dgwDelito.DataSource = Nothing
                Exit Sub
            End If

            Dim objBss As New Bussines.Registro.Delito
            Dim objEntCol As New Entity.Registro.DelitoCol

            If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                Me._IngresoID = -1
                objEntCol = objBss.Listar_LM(-1, Me._IngresoID, _IngresoInpeId, Me._InternoID, Me._ExpedienteID, -1, -1)
            Else
                objEntCol = objBss.Listar(-1, Me._IngresoID, Me._InternoID, Me._ExpedienteID, -1, -1)
            End If

            objEntCol2 = objEntCol
            With Me.dgwDelito
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                Me.GrillaCountDel = .RowCount
            End With
        End Sub
#End Region
#Region "Otros"
        Public Sub LoadUsc()
            ListarDelito()
        End Sub
#End Region
#Region "Eventos"
        Private _ObjEntDel As New Entity.Registro.Delito
        Private Sub dgwDelito_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellDoubleClick
            For Each EntDel As Entity.Registro.Delito In objEntCol2
                If dgwDelito.SelectedRows(0).Cells("col_del_id").Value = EntDel.Codigo Then
                    Me._ObjEntDel = EntDel
                    Exit For
                End If
            Next
            RaiseEvent _CellDoubleClick_GrillaDelito(Me._IngresoID, Me._ExpedienteID, Me.GrillaDelitoCodigo)
        End Sub
#End Region

    End Class
End Namespace
