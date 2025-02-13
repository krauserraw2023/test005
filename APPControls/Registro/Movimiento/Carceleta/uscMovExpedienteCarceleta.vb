Imports Type.Enumeracion.Licencia

Namespace Registro.Movimiento.Carceleta
    Public Class uscMovExpedienteCarceleta
        Private objEntExpedienteCol As New Entity.Registro.ExpedienteCol
        Public _ObjEntExpediente As New Entity.Registro.InternoMovimientoCol
#Region "Eventos"
        Public Event _Click_AddMandatoDet()

        Public Event _Click_CargaListaExpedientes()
        Public Event _Click_GrillaExpediente()
        Public Event _Click_ListarDelito()
        Public Event _CellDoubleClick_GrillaExpediente(ingreso As Integer, codigo As Integer, EntExp As Entity.Registro.InternoMovimiento)

        Public Property _ListaExpedienteOKID As List(Of Integer)
        Public Property _ListaExpedienteTotalID As List(Of Integer)
        Public objEntCol As New Entity.Registro.ExpedienteCol
#End Region

#Region "Propiedades"
        Private intExpedienteID As Integer = -1
        Public Property _DocumentoJudicialID() As Integer = -1
        Public Property _MovimientoID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _ExpedienteID() As Integer
            Get
                Return intExpedienteID
            End Get
            Set(ByVal value As Integer)
                intExpedienteID = value
                If dgwExpediente.Rows.Count > 0 Then
                    intExpedienteID = GrillaExpedienteID
                End If
            End Set
        End Property
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        'Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades OUT"
        Public Property _GrillaExpId As Integer = -1
        Public Property _ListaExpNoEliminados As List(Of Integer)
        Public Property _ListaExpOK_OUT As List(Of Integer)
        Public Property _RetornaOKEliminado As Boolean = False
#End Region
#Region "Propiedades IN"
        Public Property _ListaExpOK_IN As List(Of Integer)
#End Region
#Region "Propieades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwExpediente
                    intValue = .SelectedRows(0).Cells("ExpedienteID").Value
                End With
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteID() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwExpediente
                    If .Rows.Count > 0 Then
                        'If _DocumentoJudicialID > 0 Then
                        '   If _CargarExpedientes = True Then
                        intValue = .SelectedRows(0).Cells("col_exp_id").Value
                        'End If
                        'End If
                    End If
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaExpedienteNumero() As String
            Get
                Dim strValue As String = ""
                With Me.dgwExpediente
                    strValue = .SelectedRows(0).Cells("col_exp_numero").Value
                End With
                Return strValue
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
                ShowControl()
            End Set
        End Property
        Private blnVisibleColumna As Boolean = False
        Public Property _VisibleColumna() As Boolean
            Get
                Return blnVisibleColumna
            End Get
            Set(ByVal value As Boolean)
                blnVisibleColumna = value
                If _VisibleColumna = True Then
                    dgwExpediente.Columns("colEliminarExpediente").Visible = False
                    dgwExpediente.Columns("col_DMP").Visible = False
                    dgwExpediente.Columns("col_SMP").Visible = False
                End If
            End Set
        End Property
        Public ReadOnly Property _EntExpediente() As Entity.Registro.Expediente
            Get
                Dim tmp As Entity.Registro.Expediente
                Try
                    tmp = objEntExpedienteCol.Expediente(dgwExpediente.CurrentCell.RowIndex)
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return tmp
            End Get
        End Property
        Public Property _TipoListado As String = ""
        Private blnCargarExpedientes As Boolean = False
        'Public Property _CargarExpedientes() As Boolean
        '    Get
        '        Return blnCargarExpedientes
        '    End Get
        '    Set(ByVal value As Boolean)
        '        blnCargarExpedientes = value
        '        If _CargarExpedientes = True Then

        '            ListarExpediente2()

        '        End If
        '    End Set
        'End Property
#End Region
#Region "Listar"
        'lista expedientes de mandatos de detencion de ingreso.
        Private Sub ListarExpediente()
            'If Me._MovimientoID < 1 Then Exit Sub

            Dim objBss As New Bussines.Registro.Expediente
            Dim objEntCol As New Entity.Registro.ExpedienteCol
            Dim entExp As New Entity.Registro.Expediente
            entExp.InternoID = Me._InternoID
            entExp.ExpedienteVisible = 1
            entExp.IngresoInpeId = Me._InternoIngresoInpeId

            objEntCol = objBss.ListarMandatosCarceleta(entExp)


            With Me.dgwExpediente
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With

            If Me.dgwExpediente.RowCount > 0 Then
                _GrillaExpId = dgwExpediente.SelectedRows(0).Cells("col_exp_id").Value
            Else
                _GrillaExpId = -1
            End If

            RaiseEvent _Click_ListarDelito()
        End Sub

        'Public Sub ListarExpediente2()
        '    If Me._DocumentoJudicialID < 1 Then Exit Sub

        '    Dim objBss As New Bussines.Registro.InternoMovimiento
        '    Dim objBssExp_ As New Bussines.Registro.Expediente

        '    If Me._TipoLicencia = enmTipoLicencia.Carceleta _
        '        Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
        '        Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
        '        objEntCol = objBssExp_.ListarExpedientexResolucion_LM(Me._DocumentoJudicialID)
        '    Else
        '        objEntCol = objBssExp_.ListarExpedientexResolucion(Me._DocumentoJudicialID)
        '    End If


        '    Dim intValor As Integer = 0

        '    If objEntCol.Count = 0 Then Exit Sub
        '    If objEntCol.Count = 1 And objEntCol.Expediente(0).Codigo < 1 Then Exit Sub

        '    With Me.dgwExpediente
        '        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
        '        .AllowUserToResizeRows = False
        '        .AutoGenerateColumns = False
        '        .DataSource = objEntCol
        '        If .Rows.Count > 0 Then .Rows(0).Selected = True
        '        .Columns("colEliminarExpediente").Visible = False
        '    End With
        '    Dim expIntMov As Entity.Registro.InternoMovimiento = Nothing
        '    For Each obj As Entity.Registro.Expediente In objEntCol
        '        expIntMov = New Entity.Registro.InternoMovimiento
        '        With expIntMov
        '            .Codigo = obj.Codigo
        '            .DocumJudicialID = obj.DocumentoJudicialID
        '            .TipoAutoridadJudicialID = obj.TipoAutoridadJudicialID
        '            .AutoridadJudicialID = obj.DistritoJudicialID
        '            .SalaJudicialID = obj.SalaJudicialID
        '            .DocJudJuez = obj.ExpedienteJuez
        '        End With
        '        _ObjEntExpediente.Add(expIntMov)
        '    Next

        '    If Me.dgwExpediente.RowCount > 0 Then
        '        _GrillaExpId = dgwExpediente.SelectedRows(0).Cells("col_exp_id").Value
        '    Else
        '        _GrillaExpId = -1
        '    End If
        '    With dgwExpediente
        '        .Columns("col_DMP").Visible = False
        '        .Columns("col_SMP").Visible = False
        '    End With
        '    RaiseEvent _Click_ListarDelito()
        'End Sub


        Private Sub CargarDatos()
            Dim Lista As New List(Of Integer)
            Dim ListaOK As New List(Of Integer)
            Lista = _Leer_Reg_Seleccionados()
            If Lista.Count > 0 Then
                For Each ExpID As Integer In Lista
                    ListaOK.Add(ExpID)
                Next
                If ListaOK.Count > 0 Then
                    Me._ListaExpedienteOKID = ListaOK
                    Me._ListaExpedienteTotalID = Lista
                End If
                RaiseEvent _Click_GrillaExpediente()
            End If
        End Sub

        Public Function _Leer_Reg_Seleccionados() As List(Of Integer)
            Dim lista As New List(Of Integer)
            lista = Leer_Reg_Seleccionados(dgwExpediente)
            Return lista
        End Function

        Private Function BuscarExpId(ByVal MovID As Integer, ByVal ExpID As Integer) As Boolean
            Dim blnExiste As Boolean = False
            Dim objMovExpBss As New Bussines.Registro.MovimientoExpediente
            blnExiste = objMovExpBss.ValidarExpediente(MovID, ExpID)
            Return blnExiste
        End Function

        Private Function Leer_Reg_Seleccionados(dgw As DataGridView) As List(Of Integer)
            Dim lstInteger As New List(Of Integer)
            Dim seleccionado As Integer = -1
            Dim valorID As String = ""

            For Each fila As DataGridViewRow In dgw.Rows
                seleccionado = fila.Cells("col_exp_id").Value
                If seleccionado > 0 Then
                    valorID = fila.Cells("col_exp_id").Value
                    lstInteger.Add(valorID)
                End If
            Next
            Return lstInteger
        End Function

        Public Sub Listar(ListaExpID As List(Of Integer), blnDeEliminar As Boolean)
            'NO viene DeEliminar
            If Not blnDeEliminar Then
                Dim CodExpId As Integer
                For Each elemento As DataGridViewRow In dgwExpediente.Rows
                    CodExpId = elemento.Cells("col_exp_id").Value

                    If ListaExpID.Contains(CodExpId) Then
                    Else
                        ListaExpID.Add(CodExpId)
                    End If
                Next
            End If

            Dim objEntColAll As New Entity.Registro.MovimientoExpedienteCol
            Dim objEntCol As Entity.Registro.MovimientoExpedienteCol
            Dim objBss As New Bussines.Registro.MovimientoExpediente
            Dim entMov As New Entity.Registro.MovimientoExpediente
            entMov.MovimientoID = Me._MovimientoID
            entMov.InternoID = Me._InternoID
            entMov.IngresoID = Me._IngresoID
            For Each ExpID As Integer In ListaExpID
                objEntCol = New Entity.Registro.MovimientoExpedienteCol
                entMov.ExpedienteID = ExpID
                objEntCol = objBss.Listar(entMov)
                For Each Expediente As Entity.Registro.MovimientoExpediente In objEntCol
                    objEntColAll.Add(Expediente)
                Next
            Next

            With Me.dgwExpediente
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntColAll
            End With

            'If Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
            If Me.dgwExpediente.RowCount > 0 Then
                _GrillaExpId = GrillaExpedienteID
            Else
                _GrillaExpId = -1
            End If
            RaiseEvent _Click_ListarDelito()
            'End If

        End Sub

        Public Sub LoadUsc_()

            ListarExpediente()
        End Sub

#End Region
#Region "Accion"
        Private Sub AELiminarMovExpediente()

            'Dim dlgPregunta As DialogResult
            'Dim strPregunta As String = "¿Esta Seguro de eliminar el Expediente del Movimiento? " + Chr(13) +
            '    "Esta accion eliminará el Expediente!"
            'Dim strTitulo As String = "INPE-SIP-POPE"

            'dlgPregunta = MessageBox.Show(strPregunta, strTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            'If GrillaCodigo < 1 Then
            '    'NO esta grabado
            '    If dlgPregunta = DialogResult.Yes Then
            '        Dim lista As List(Of Integer)
            '        lista = ListarExpIDGrilla(Me.dgwExpediente)
            '        Me._ListaExpNoEliminados = lista
            '        Me._ListaExpOK_OUT = Me._ListaExpOK_IN
            '        Listar(lista, True)
            '        Me._RetornaOKEliminado = True
            '    End If
            'Else
            '    'SI esta grabado

            '    If dlgPregunta = DialogResult.Yes Then
            '        Dim objBss As New Bussines.Registro.MovimientoExpediente
            '        objBss.Eliminar(Me.GrillaCodigo, Legolas.Configuration.Usuario.Codigo)
            '        ListarExpediente()
            '    End If
            'End If
        End Sub
#End Region
#Region "Otros"
        Private Sub ShowControl()
            'Me.pnlExpeIzq.Visible = Me._VisibleGrabar
            Me.colEliminarExpediente.Visible = Me._VisibleGrabar
        End Sub
        Private Function ListarExpIDGrilla(dgv As DataGridView) As List(Of Integer)
            Dim idExp As Integer = dgwExpediente.SelectedRows(0).Cells("col_exp_id").Value
            Dim Lista As New List(Of Integer)
            For Each elemento As DataGridViewRow In dgv.Rows
                If elemento.Cells("col_exp_id").Value <> idExp Then
                    Lista.Add(elemento.Cells("col_exp_id").Value)
                End If
            Next
            Me._ListaExpOK_IN.Remove(idExp)
            Return Lista
        End Function
#End Region
#Region "Eventos"
        Private Sub btnAddExpediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            RaiseEvent _Click_CargaListaExpedientes()
        End Sub

        Private Sub dgwExpediente_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellDoubleClick
            If Me.dgwExpediente.RowCount > 0 Then
                Select Case e.ColumnIndex
                    Case 100 'Me.dgwExpediente.Columns("DMP").Index, Me.dgwExpediente.Columns("SMP").Index, Me.dgwExpediente.Columns("colEliminarExpediente").Index
                    Case Else
                        Dim EntExp As New Entity.Registro.InternoMovimiento
                        If objEntCol.Count > 0 Then
                            EntExp = _ObjEntExpediente.InternoMovimiento(dgwExpediente.SelectedRows(0).Index)
                        End If
                        RaiseEvent _CellDoubleClick_GrillaExpediente(Me._IngresoID, Me.GrillaExpedienteID, EntExp)
                End Select
            End If
        End Sub

        Private Sub dgwExpediente_Click(sender As Object, e As System.EventArgs) Handles dgwExpediente.Click
            Me._GrillaExpId = Me.GrillaExpedienteID
            RaiseEvent _Click_GrillaExpediente()
            RaiseEvent _Click_ListarDelito()
        End Sub
        'Los eventos KeyDown, se quedan dentro del USRControl, porque no generan accion con otro formulario.
        Private Sub dgwExpediente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyDown
            Select Case e.KeyData
                Case (Keys.Shift Or Keys.Delete)
                    AELiminarMovExpediente()
            End Select
        End Sub
        'Los eventos CellFormating, se quedan dentro del USRControl, porque no generan accion con otro formulario.
        Private Sub dgwExpediente_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwExpediente.CellFormatting
            If e.ColumnIndex = Me.dgwExpediente.Columns("colEliminarExpediente").Index Then
                With Me.dgwExpediente.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    .ToolTipText = "Eliminar Expediente"
                End With
            End If
        End Sub
#End Region

        Private Sub uscMovExpediente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ' ListarExpediente2()
        End Sub

        Private Sub dgwExpediente_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyUp
            If Me.dgwExpediente.RowCount > 0 And Me.GrillaExpedienteID > 0 Then
                Me._GrillaExpId = Me.GrillaExpedienteID
                RaiseEvent _Click_ListarDelito()
            End If
        End Sub

        Private Sub btnAgregarNomAsoc_Click(sender As System.Object, e As System.EventArgs)
            RaiseEvent _Click_AddMandatoDet()
        End Sub
    End Class
End Namespace
