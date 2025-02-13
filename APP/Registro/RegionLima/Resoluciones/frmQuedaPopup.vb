Namespace Registro.RegionLima.Resoluciones
    Public Class frmQuedaPopup
        Public objDoc As New Entity.Registro.DocumentoJudicial
        Public objExpCol As New Entity.Registro.ExpedienteCol
        Public objDelCol As New Entity.Registro.DelitoCol
        Public objAgrCol As New Entity.Registro.AgraviadoCol
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
                    Return dgwExpediente.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property

        Public Property DocumentoLibertadId As Integer = -1
#End Region

#Region "Listar"
        Private Sub Listar()
            txtNumDocumento.Focus()
            txtNumDocumento.Text = ""
            dtpDocJudFecha.ValueLong = objDoc.DocumentoFechaRecepcion
            txtObservacion.Text = ""
            With Me.dgwExpediente
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objExpCol
                .Refresh()
            End With
        End Sub
#End Region

#Region "Accion"
        Dim bss As New Bussines.Registro.DocumentoJudicial
        Dim bssDel As New Bussines.Registro.Delito
        Dim bssAgr As New Bussines.Registro.InternoAgraviado
        Private Sub AGrabar()
            If Validar(-1) = True Then
                Exit Sub
            End If
            'objDoc.QuedaId = DocumentoLibertadId
            DocumentoLibertadId = objDoc.Codigo  ' (New Bussines.Registro.DocumentoJudicial).Grabar_LM(objDoc)

            objDoc.Codigo = -1
            objDoc.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
            objDoc.DocumentoNumero = txtNumDocumento.Text
            objDoc.SecretarioNombre = ""
            objDoc.TipoAutoridadJudicial = -1
            objDoc.DistritoJudicial = -1
            objDoc.SalaJuzgado = -1
            objDoc.Observacion = txtObservacion.Text
            Dim CodigoDoc As Integer = (New Bussines.Registro.DocumentoJudicial).Grabar_LM(objDoc)
            objDoc.Codigo = DocumentoLibertadId
            objDoc.QuedaId = CodigoDoc
            objDoc.FlagTransferenciaSede = 1
            DocumentoLibertadId = (New Bussines.Registro.DocumentoJudicial).GrabarQueda_LM(objDoc)

            For Each obj As Entity.Registro.Expediente In objExpCol
                Dim CodigoExpOri As Integer = obj.Codigo
                obj.Codigo = -1
                obj.CreaDocJudicialId = CodigoDoc
                obj._RegionId = objDoc._RegionID
                obj.FlagTransferenciaSede = 1
                Dim CodigoExp As Integer = (New Bussines.Registro.Expediente).Grabar_LM(obj)
                Dim CodigoExpVis As Integer = (New Bussines.Registro.Expediente).GrabarEstadoVisibilidad_LM(CodigoExpOri, 0)
                Dim objExpPad As New Entity.Registro.InternoExpedientePadre
                objExpPad.InternoID = objDoc.InternoId
                objExpPad.IngresoID = Me._IngresoID
                objExpPad.IngresoInpeId = objDoc.IngresoInpeId
                objExpPad._RegionId = objDoc._RegionID
                objExpPad.InternoExpedienteId = CodigoExp
                objExpPad.InternoExpedienteRefPadreId = CodigoExpOri
                objExpPad.DocJudicialID = CodigoDoc
                objExpPad.FlagTransferenciaSede = 1
                Dim CodigoPadre As Integer = (New Bussines.Registro.InternoExpedientePadre).Grabar_LM(objExpPad)

                Dim Del As New Entity.Registro.Delito
                Del.ExpedienteID = CodigoExpOri
                Del.InternoID = obj.InternoID
                objDelCol = bssDel.Listar2_LM(Del)
                For Each objdel As Entity.Registro.Delito In objDelCol
                    Dim CodigodelitoOri As Integer = objdel.Codigo
                    objdel.Codigo = -1
                    objdel.CreaDocJudicialId = CodigoDoc
                    objdel.ExpedienteID = CodigoExp
                    objdel.CodigodelitoPad = CodigodelitoOri
                    objdel.FlagTransferenciaSede = 1
                    Dim CodigoDel As Integer = (New Bussines.Registro.Delito).Grabar_LM(objdel)

                    Dim Agr As New Entity.Registro.Agraviado
                    Agr.DelitoID = CodigodelitoOri
                    Agr.InternoID = objdel.InternoID
                    objAgrCol = bssAgr.Listar_LM(Agr)
                    For Each objAgr As Entity.Registro.Agraviado In objAgrCol
                        Dim CodigoAgraviadoOri As Integer = objAgr.Codigo
                        objAgr.Codigo = -1
                        objAgr.DelitoID = CodigoDel
                        objAgr.ExpedienteID = CodigoExp
                        objAgr.CreaDocJudicialId = CodigoDoc
                        objAgr.RegionID = objDoc._RegionID
                        objAgr.CodigoagraviadoPad = CodigoAgraviadoOri
                        objAgr.FlagTransferenciaSede = 1
                        Dim CodigoAgr As Integer = (New Bussines.Registro.InternoAgraviado).Grabar_LM(objAgr)
                    Next
                Next
            Next
            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub


        Public Function Validar(IdExpe) As Boolean
            Dim blnValor As Boolean = False

            Return blnValor
        End Function
        Private Sub VerMotivoQueda()
            Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
            'frm._ResolucionTipoID = Me.UscExpeDeResolucion._GrillaMotivoQuedaID
            frm._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                dgwExpediente.SelectedRows(0).Cells("col_que_id").Value = frm._ResolucionTipoID
                dgwExpediente.SelectedRows(0).Cells("col_que_nom").Value = frm._ResolucionTipoNom
            End If
        End Sub
#End Region

#Region "Otros"
        'Dim bss As New Bussines.General.Parametrica
        Dim objCol As New Entity.General.ParametricaCol
        Private Sub ValoresxDefault()
            Listar()
        End Sub

#End Region

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub

        Private Sub frmQuedaPopup_Load(sender As Object, e As EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmQuedaPopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            ValoresxDefault()
        End Sub

        Private Sub dgwExpediente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwExpediente.CellContentClick
            dgwExpediente_CellClick(Nothing, Nothing)
            If e.RowIndex = -1 Then Exit Sub
            If dgwExpediente.Columns(e.ColumnIndex).Name = "col_que_btn" Then
                VerMotivoQueda()
            End If
        End Sub

        Private Sub dgwExpediente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwExpediente.CellClick

        End Sub
    End Class
End Namespace
