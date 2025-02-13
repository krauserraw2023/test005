Namespace Registro.Penal.Sentencias
    Public Class frmListarResolucion
        Private objBss As Bussines.Registro.Expediente = Nothing
        Private objBssPad As Bussines.Registro.InternoExpedientePadre = Nothing
        Private objEnt As Entity.Registro.Expediente = Nothing
        Private objEntExpediente As Entity.Registro.Documento.DocumentoJudicialExpediente
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntPeriodoCondenaTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
        Private objEntDelitoCol As Entity.Registro.DelitoCol
        Private objEntAgraviadoCol As Entity.Registro.AgraviadoCol

#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _IngresoID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _TemporalNuevo As Boolean = False
        Public Property _NuevoExpediente As Boolean = False
        Public Property _SituacionJuridicaExpe As Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
        Public Property _TipoResolucion As Integer = -1

        Public ReadOnly Property _GrillaExpedienteIdSeleccionado() As Integer
            Get

                Return Me.GrillaExpedienteId

            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteId() As Integer
            Get
                Try
                    Return dgwExpediente2.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
#End Region
#Region "Variables_Temporales"
        Public _ResolucionTipoID As Integer = -1
        Public _ResolucionTipoNom As String = ""

        Public _MovimientoQuedaID As Integer = -1
        Public _MovimientoQuedaNom As String = ""
#End Region
#Region "Propiedades_Publicas"
        Private blnVisibleGrabar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
                ShowControl()
            End Set
        End Property
        Public Property _GrillaSeleccionMultiple As Boolean = True
        Public Event _Click_EnviarColection(EntExpCol As Entity.Registro.ExpedienteCol)
#End Region
#Region "Propiedades_Expediente"
        Public Property _TipoAutJudicial() As Integer = -1
        Public Property DocJudicialID As Integer = -1
#End Region

#Region "Listar"
        Public Sub _ListarResoluciones()

            With Me.dgwExpediente2
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objCol
                .Refresh()
            End With
            For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda Then
                    If dgwExpediente2.Rows(i).Cells("col_cod_lib").Value = Me._MovimientoQuedaID Then
                        dgwExpediente2.Rows(i).Selected = True
                        Exit Sub
                    Else
                        dgwExpediente2.Rows(0).Selected = False
                    End If
                Else
                    If dgwExpediente2.Rows(i).Cells("col_cod_lib").Value = Me._ResolucionTipoID Then
                        dgwExpediente2.Rows(i).Selected = True
                        Exit Sub
                    Else
                        dgwExpediente2.Rows(0).Selected = False
                    End If
                End If
            Next
        End Sub

#End Region
#Region "Accion"

        Private Sub AGrabar()
            If Validar(-1) = True Then
                Exit Sub
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Dim ValorInt As Integer = 0
        Dim objDocumJudicial_copia As New Entity.Registro.DocumentoJudicialCol
        Public Function Validar(IdExpe) As Boolean
            Dim blnValor As Boolean = False
            For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
                If dgwExpediente2.Item("colu_eleg", i).Selected = True Then
                    Me._ResolucionTipoID = dgwExpediente2.Item("col_cod_lib", i).Value
                    Me._ResolucionTipoNom = dgwExpediente2.Item("col_nom_lib", i).Value
                    blnValor = True
                    Exit Function
                Else
                    blnValor = False
                End If
            Next
            If blnValor = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("Debe seleccionar un registro de libertad")
                dgwExpediente2.Focus()
            End If
            Return blnValor
        End Function




#End Region
#Region "Permisos"
        Private Sub ShowControl()
            Me.btnOk.Visible = Me._VisibleGrabar
        End Sub
#End Region
#Region "Otros"
        Dim bss As New Bussines.General.Parametrica
        Dim objCol As New Entity.General.ParametricaCol
        Private Sub ValoresxDefault()

            Select Case Me._TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                    objCol = bss.Listar(Type.Combo.ComboTipo.TipoAclaratoriaExpediente, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda,
                                        Me._TipoResolucion, -1, False, "")

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida

                    objCol = bss.Listar(Type.Combo.ComboTipo.SentenciaSubTipoDetalle,
                                        Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema,
                                        Me._TipoResolucion, -1, False, "")

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria

                    objCol = bss.Listar(Type.Combo.ComboTipo.SentenciaSubTipoDetalle, -1, Me._TipoResolucion, -1, False, "")

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
                    Me.Size = New Size(350, 312)
                    objCol = bss.Listar(Type.Combo.ComboTipo.Establecimientomental, -1, Me._TipoResolucion, -1, False, "")

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental

                    'Me.Size = New Size(300, 312)
                    objCol = bss.Listar(Type.Combo.ComboTipo.Inimputable, -1, Me._TipoResolucion, -1, False, "")

                Case Else

                    objCol = bss.Listar(Type.Combo.ComboTipo.SentenciaSubTipoDetalle, -1, Me._TipoResolucion, -1, False, "")
            End Select

            _ListarResoluciones()
        End Sub
        Private Sub EvaluarClick()
            'For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
            Dim intPos As Integer = -1
            intPos = dgwExpediente2.Columns("colu_eleg").Index
            If dgwExpediente2.Item("colu_eleg", intPos).Value = True Then
                For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
                    If i <> intPos Then
                        dgwExpediente2.Item("colu_eleg", intPos).Value = False
                    End If
                Next
            End If
            'Next
        End Sub
#End Region

        Private Sub frmExpedientePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub dgwExpediente2_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente2.CellContentClick

            'If dgwExpediente2.Columns("colu_sele").Visible = True And dgwExpediente2.Columns("colu_sele").Index = e.ColumnIndex Then
            For i As Integer = 0 To dgwExpediente2.Rows.Count - 1 'obligar a marcar check a un solo registro (emular radio button)
                If i <> dgwExpediente2.CurrentCell.RowIndex Then
                    dgwExpediente2.Item("colu_eleg", i).Value = False
                End If
            Next
            'End If

        End Sub

        Private Sub dgwExpediente2_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente2.CellDoubleClick
            AGrabar()
        End Sub
    End Class
End Namespace
