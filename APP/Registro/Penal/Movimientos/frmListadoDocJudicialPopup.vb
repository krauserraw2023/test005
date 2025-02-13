Imports System.Windows.Forms
Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos
    Public Class frmListadoDocJudicialPopup

        Private intIngresoID As Integer = -1
        Private objEntCol As Entity.Registro.DocumentoJudicialCol
#Region "Propiedades_Parametricas"
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer
            Get
                Return intIngresoID
            End Get
            Set(ByVal value As Integer)
                intIngresoID = value
                If dgwExpediente.Rows.Count > 0 Then
                    intIngresoID = GrillaIDIngresoInterno
                End If
            End Set
        End Property
        Public Property _GrupoID() As Integer = -1
        Public Property _DocJudicialID() As Integer = -1
        Public Property _TipoDocJudicialID() As Integer = -1
        Public Property _SubTipoDocJudicialID() As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        Public Property _TIpoMovimientoHospitalMental As Integer = -1
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDDocumentoJudicial() As String
            Get
                Dim strValue As String = ""
                With Me.dgwExpediente
                    strValue = .SelectedRows(0).Cells("col_id").Value
                End With
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDIngresoInterno() As String
            Get
                Dim strValue As String = ""
                With Me.dgwExpediente
                    If .Rows.Count > 0 Then
                        strValue = .SelectedRows(0).Cells("col_ing_id").Value
                    End If

                End With
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaFechaDocumento() As String
            Get
                Dim strValue As String = ""
                With Me.dgwExpediente
                    If .Rows.Count > 0 Then
                        strValue = .SelectedRows(0).Cells("col_fec_doc").Value
                    End If

                End With
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaRegionDestinoID() As Integer
            Get
                Dim strValue As Integer = -1
                With Me.dgwExpediente
                    If .Rows.Count > 0 Then
                        strValue = .SelectedRows(0).Cells("col_reg_des_id").Value
                    End If

                End With
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaPenalDestinoID() As Integer
            Get
                Dim strValue As Integer = -1
                With Me.dgwExpediente
                    If .Rows.Count > 0 Then
                        strValue = .SelectedRows(0).Cells("col_pen_des_id").Value
                    End If

                End With
                Return strValue
            End Get
        End Property
#End Region
#Region "Listar"

        Public Function _Leer_Reg_Seleccionados() As List(Of Integer)
            Dim lista As New List(Of Integer)
            lista = Leer_Reg_Seleccionados(dgwExpediente)
            Return lista
        End Function
        Private Function Leer_Reg_Seleccionados(dgw As DataGridView) As List(Of Integer)

            Dim lstInteger As New List(Of Integer)
            Dim seleccionado As Integer = -1
            Dim valorID As String = ""

            valorID = dgwExpediente.SelectedRows(0).Cells("col_id").Value
            lstInteger.Add(valorID)

            Return lstInteger
        End Function
        Public Function Grilla_ObjetoSeleccionado() As Entity.Registro.DocumentoJudicial
            Dim objExp As New Entity.Registro.DocumentoJudicial

            For i As Integer = 0 To objEntCol.Count - 1
                If dgwExpediente.SelectedRows(0).Index = i Then
                    objExp = objEntCol.DocumentoJudicial(i)
                End If
            Next
            If objEntCol.Count = Nothing Then
                Return Nothing
            Else
                Return objExp
            End If
        End Function

        Private Sub listarGrilla()

            Dim objDocJud As New Bussines.Registro.DocumentoJudicial
            Dim objEntFiltroDocJudicial As New Entity.Registro.DocumentoJudicial
            objEntCol = New Entity.Registro.DocumentoJudicialCol

            With objEntFiltroDocJudicial
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._IngresoID
                .DocumentoTipo = Me._TipoDocJudicialID
                .DocumentoSubTipoId = Me._SubTipoDocJudicialID
                .IngresoInpeId = Me._InternoIngresoInpeId

                If Me._TipoDocJudicialID = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital Or
                     Me._TipoDocJudicialID = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital_Nota Or
                     Me._TipoDocJudicialID = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad Then

                    dgwExpediente.Columns("col_doc_mot_id").Visible = False
                    If _TIpoMovimientoHospitalMental = Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental Then
                        .EstadoEjecucionId = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo
                    ElseIf _TIpoMovimientoHospitalMental = Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental Then
                        .EstadoEjecucionId = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Apto
                    Else
                        .EstadoEjecucionId = -1
                    End If
                Else
                    .EstadoEjecucionId = -1
                End If

            End With

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta And Me._TipoDocJudicialID <= 0 Then
                If Me._GrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                    objEntCol = objDocJud.Listar_DocumentosClasificacion(objEntFiltroDocJudicial)
                Else
                    objEntFiltroDocJudicial.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionCarceleta
                    objEntCol = objDocJud.Listar_DocumentosJudiciales_LM(objEntFiltroDocJudicial)
                End If
            Else
                If Me._TipoLicencia = enmTipoLicencia.Carceleta Or
                    Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then

                    If _TIpoMovimientoHospitalMental = 9 Or _TIpoMovimientoHospitalMental = 10 Then
                        objEntCol = objDocJud.Listar_DocumentosJudiciales_LM_OTHSM(objEntFiltroDocJudicial, True)
                    Else
                        objEntCol = objDocJud.Listar_DocumentosJudiciales_LM(objEntFiltroDocJudicial, True)
                        If objEntFiltroDocJudicial.DocumentoTipo = 6 And objEntCol.Count > 1 Then 'Tipo libertad
                            Dim max As Integer = 0
                            Dim objAux As New Entity.Registro.DocumentoJudicial
                            For Each obj As Entity.Registro.DocumentoJudicial In objEntCol
                                If obj.Codigo > max Then
                                    max = obj.Codigo
                                    objAux = New Entity.Registro.DocumentoJudicial
                                    objAux = obj
                                End If
                            Next
                            objEntCol = New Entity.Registro.DocumentoJudicialCol
                            objEntCol.Add(objAux)
                        End If
                    End If
                Else
                    'objEntCol = objDocJud.Listar_DocumentosJudiciales(objEntFiltroDocJudicial)
                    If _TIpoMovimientoHospitalMental = 9 Or _TIpoMovimientoHospitalMental = 10 Then
                        objEntCol = objDocJud.Listar_DocumentosJudiciales_OTHSM(objEntFiltroDocJudicial)
                    Else
                        objEntCol = objDocJud.Listar_DocumentosJudiciales(objEntFiltroDocJudicial)
                    End If
                End If
            End If

            visibleColumnas()

            With Me.dgwExpediente
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With

        End Sub
        Private Function BuscarExpedienteID(ByVal MovID As Integer, ByVal ExpID As Integer) As Boolean
            Dim blnExiste As Boolean = False
            Dim objMovExpBss As New Bussines.Registro.MovimientoExpediente
            blnExiste = objMovExpBss.ValidarExpediente(MovID, ExpID)
            Return blnExiste
        End Function
#End Region
#Region "Otros"
        Private Sub visibleColumnas()

            Dim verColumnaOrigen As Boolean = False
            Dim verColumnaDestino As Boolean = False

            Select Case Me._GrupoID
                Case Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                    verColumnaOrigen = True

                Case Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso
                    verColumnaDestino = True
            End Select

            Me.col_org.Visible = verColumnaOrigen
            Me.col_des.Visible = verColumnaDestino

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            Dim Lista As New List(Of Integer)
            Dim ListaOK As New List(Of Integer)
            Grilla_ObjetoSeleccionado()

            If dgwExpediente.Rows.Count > 0 Then
                Lista = _Leer_Reg_Seleccionados()
                For Each ExpID As Integer In Lista
                    ListaOK.Add(ExpID)
                Next

                If ListaOK.Count > 0 Then
                    Me._DocJudicialID = GrillaIDDocumentoJudicial
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione documento...")
            End If
        End Sub

        Private Sub dgwExpediente_DoubleClick(sender As Object, e As System.EventArgs) Handles dgwExpediente.DoubleClick
            btnAceptar_Click(Nothing, Nothing)
        End Sub

        Private Sub frmListadoDocJudicialPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            listarGrilla()
        End Sub
    End Class
End Namespace

