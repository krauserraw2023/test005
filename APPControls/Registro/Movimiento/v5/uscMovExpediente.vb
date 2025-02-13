Imports Type.Enumeracion.Licencia

Namespace Registro
    Public Class uscMovExpediente
        Private objEntExpedienteCol As New Entity.Registro.ExpedienteCol
#Region "Eventos"
        Public Event _Click_CargaListaExpedientes()
        Public Event _Click_GrillaExpediente()
        Public Event _Click_ListarDelito()
        Public Event _CellDoubleClick_GrillaExpediente(ingreso As Integer, codigo As Integer, EntExp As Entity.Registro.InternoMovimiento)
        Public Event _MostrarEstablecimientoMental()

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
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Retorno"
        Public Property _GrillaExpId As Integer = -1
        Public Property _ListaExpNoEliminados As List(Of Integer)
        Public Property _ListaExpOK_OUT As List(Of Integer)
        Public Property _RetornaOKEliminado As Boolean = False
        Public ReadOnly Property _GrillaExpedientesCount() As Integer
            Get
                Return dgwExpediente.Rows.Count
            End Get
        End Property
        Public ReadOnly Property _getCentroSaludMental As String
            Get
                Return Me.grillaCentroSaludNombre
            End Get
        End Property
        Public ReadOnly Property _getIdCentroSaludMental As Integer
            Get
                Return Me.grillaIdCentroSaludMental
            End Get
        End Property

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
        Private intGrillaCountExp As Integer = 0
        Public Property GrillaCountExp() As Integer
            Get
                Return intGrillaCountExp
            End Get
            Set(ByVal value As Integer)
                intGrillaCountExp = value
                Me.lblRegExp.Text = intGrillaCountExp.ToString & " Reg."
            End Set
        End Property

        Private ReadOnly Property grillaCentroSaludNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwExpediente
                        value = .SelectedRows(0).Cells("col_est_men_nom").Value
                    End With
                Catch ex As Exception

                End Try

                Return value
            End Get
        End Property

        Private ReadOnly Property grillaIdCentroSaludMental() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwExpediente
                        value = .SelectedRows(0).Cells("col_est_men_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return value
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
        Public Property _CargarExpedientes() As Boolean
            Get
                Return blnCargarExpedientes
            End Get
            Set(ByVal value As Boolean)
                blnCargarExpedientes = value
                If _CargarExpedientes = True Then

                    ListarExpediente2()

                End If
            End Set
        End Property
#End Region
#Region "Listar"
        Public Sub _ListarExpedientes()
            ListarExpediente()
        End Sub

        Private Sub ListarExpediente()
            If Me._MovimientoID < 1 Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Registro.Expediente
            Dim objEntCol As New Entity.Registro.ExpedienteCol
            Dim entExp As New Entity.Registro.Expediente
            ''entMov.MovimientoID = Me._MovimientoID
            entExp.InternoID = Me._InternoID
            entExp.IngresoID = Me._IngresoID
            entExp.IngresoInpeId = Me._InternoIngresoInpeId
            entExp.Codigo = Me._ExpedienteID
            entExp.ExpedienteVisible = 1
            entExp.IngresoInpeId = Me._InternoIngresoInpeId

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEntCol = objBss.Listar_LM(entExp)
            Else
                entExp.IngresoInpeId = -1
                objEntCol = objBss.Listar(entExp)
            End If

            With Me.dgwExpediente
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                Me.GrillaCountExp = .RowCount
            End With

            If Me.dgwExpediente.RowCount > 0 Then
                _GrillaExpId = dgwExpediente.SelectedRows(0).Cells("col_exp_id").Value
            Else
                _GrillaExpId = -1
            End If

            RaiseEvent _Click_ListarDelito()
        End Sub
        Public DocumentoTipoId As Integer = -1
        Public Sub CamposGrillaVisible()
            If Me.DocumentoTipoId = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                Me.col_exp_fec.Visible = False
                Me.col_est_men_nom.Visible = True
                'Me.col_exp_btn.Visible = True
                Me.col_exp_inmp.Visible = True
            End If
        End Sub
        Public Sub ListarExpediente2()

            If Me._DocumentoJudicialID < 1 Then Exit Sub

            Dim objBss As New Bussines.Registro.InternoMovimiento
            Dim objBssExp_ As New Bussines.Registro.Expediente

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEntCol = objBssExp_.ListarExpedientexResolucion_LM(Me._DocumentoJudicialID)
            Else
                objEntCol = objBssExp_.ListarExpedientexResolucion(Me._DocumentoJudicialID)
            End If

            Dim intValor As Integer = 0

            If objEntCol.Count = 0 Then Exit Sub
            If objEntCol.Count = 1 And objEntCol.Expediente(0).Codigo < 1 Then Exit Sub

            With Me.dgwExpediente
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                Me.GrillaCountExp = .RowCount
                If .Rows.Count > 0 Then
                    .Rows(0).Selected = True
                End If
                .Columns("colEliminarExpediente").Visible = False
            End With

            Dim expIntMov As Entity.Registro.InternoMovimiento = Nothing
            For Each obj As Entity.Registro.Expediente In objEntCol
                expIntMov = New Entity.Registro.InternoMovimiento
                With expIntMov
                    .Codigo = obj.Codigo
                    .DocumJudicialID = obj.DocumentoJudicialID
                    .TipoAutoridadJudicialID = obj.TipoAutoridadJudicialID
                    .AutoridadJudicialID = obj.DistritoJudicialID
                    .SalaJudicialID = obj.SalaJudicialID
                    .DocJudJuez = obj.ExpedienteJuez
                End With
                _ObjEntExpediente.Add(expIntMov)
            Next

            If Me.dgwExpediente.RowCount > 0 Then
                _GrillaExpId = dgwExpediente.SelectedRows(0).Cells("col_exp_id").Value
            Else
                _GrillaExpId = -1
            End If
            With dgwExpediente
                .Columns("col_DMP").Visible = False
                .Columns("col_SMP").Visible = False
            End With
            RaiseEvent _Click_ListarDelito()
        End Sub


        Private Sub CargarDatos()
            Dim Lista As New List(Of Integer)
            Dim ListaOK As New List(Of Integer)
            Lista = _Leer_Reg_Seleccionados()
            If Lista.Count > 0 Then
                Dim strMensaje As String = ""
                For Each ExpID As Integer In Lista
                    Dim blnExiste As Boolean = False

                    ListaOK.Add(ExpID)
                    'End If
                Next

                If ListaOK.Count > 0 Then
                    Me._ListaExpedienteOKID = ListaOK
                    Me._ListaExpedienteTotalID = Lista

                End If
                RaiseEvent _Click_GrillaExpediente()
                'Else
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione almenos un expediente")
            End If

        End Sub
        Public Sub _actualizarEstablecimientoMental(idCentroSalud As Integer, centroSaludNombre As String)

            dgwExpediente.SelectedRows(0).Cells("col_est_men_id").Value = idCentroSalud
            dgwExpediente.SelectedRows(0).Cells("col_est_men_nom").Value = centroSaludNombre

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
                Me.GrillaCountExp = .RowCount
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

        Public Sub LoadUsc()
            'ListarExpediente()
        End Sub
        Public Sub LoadUsc_()
            ListarExpediente2()
        End Sub
        Public Property _ListaExpedienteId As List(Of Integer)
        Public Property _ListaCopy As New List(Of Integer)
        Public _ObjEntExpediente As New Entity.Registro.InternoMovimientoCol
        Private Sub ListarExpedientes2()
            Dim objBss As New Bussines.Registro.InternoMovimiento
            Dim objEntCol As New Entity.Registro.InternoMovimientoCol

            Dim objEnt As New Entity.Registro.InternoMovimiento
            objEnt.Codigo = Me._DocumentoJudicialID

            objEntCol = objBss.ListarGrilla(objEnt)

            dgwExpediente.DataSource = Nothing
            With dgwExpediente
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AutoGenerateColumns = False
                .AllowUserToResizeRows = False
                .DataSource = objEntCol
                _ObjEntExpediente = objEntCol
                Me.GrillaCountExp = .RowCount
                .Refresh()
            End With


            If Me.dgwExpediente.RowCount > 0 And Me.GrillaExpedienteID <> -1 Then

                Me._GrillaExpId = Me.GrillaExpedienteID
                RaiseEvent _Click_GrillaExpediente()
            End If

            If Me._TipoListado = "Mov" Then
                RaiseEvent _Click_ListarDelito()
            Else

            End If

        End Sub
#End Region
#Region "Accion"
        Private Sub AELiminarMovExpediente()

            Dim dlgPregunta As DialogResult
            Dim strPregunta As String = "¿Esta Seguro de eliminar el Expediente del Movimiento? " + Chr(13) +
                "Esta accion eliminará el Expediente!"
            Dim strTitulo As String = "INPE-SIP-POPE"

            dlgPregunta = MessageBox.Show(strPregunta, strTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If GrillaCodigo < 1 Then
                'NO esta grabado
                If dlgPregunta = DialogResult.Yes Then
                    Dim lista As List(Of Integer)
                    lista = ListarExpIDGrilla(Me.dgwExpediente)
                    Me._ListaExpNoEliminados = lista
                    Me._ListaExpOK_OUT = Me._ListaExpOK_IN
                    Listar(lista, True)
                    Me._RetornaOKEliminado = True
                End If
            Else
                'SI esta grabado

                If dlgPregunta = DialogResult.Yes Then
                    Dim objBss As New Bussines.Registro.MovimientoExpediente
                    objBss.Eliminar(Me.GrillaCodigo, Legolas.Configuration.Usuario.Codigo)
                    ListarExpediente()
                End If
            End If
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

        Private Sub dgwExpediente_CellBorderStyleChanged(sender As Object, e As System.EventArgs) Handles dgwExpediente.CellBorderStyleChanged

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
        'Private Sub dgwExpediente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellClick

        '    If e.RowIndex >= 0 Then
        '        Select Case e.ColumnIndex
        '            'Case Me.dgwExpediente.Columns("colEliminarExpediente").Index
        '            '    If Me._VisibleGrabar = False Then
        '            '        MessageBox.Show("No tiene permiso para realizar esta operacion!", _
        '            '         Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, _
        '            '        MessageBoxIcon.Exclamation)
        '            '        Exit Sub
        '            '    End If
        '            '    AELiminarMovExpediente()

        '            Case Else
        '                If Me.dgwExpediente.RowCount > 0 And Me.GrillaExpedienteID > 0 Then
        '                    Me._GrillaExpId = Me.GrillaExpedienteID
        '                    RaiseEvent _Click_ListarDelito()

        '                End If
        '        End Select
        '    End If
        'End Sub
#End Region

        Private Sub uscMovExpediente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ListarExpediente2()
        End Sub

        Private Sub dgwExpediente_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyUp
            If Me.dgwExpediente.RowCount > 0 And Me.GrillaExpedienteID > 0 Then
                Me._GrillaExpId = Me.GrillaExpedienteID
                RaiseEvent _Click_ListarDelito()
            End If
        End Sub

        Private Sub dgwExpediente_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellContentClick
            dgwExpediente_CellClick(Nothing, Nothing)
            If e.RowIndex = -1 Then Exit Sub
            If dgwExpediente.Columns(e.ColumnIndex).Name = "col_exp_btn" Then
                If Me.DocumentoTipoId = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                    RaiseEvent _MostrarEstablecimientoMental()
                End If
            End If
        End Sub

        Private Sub dgwExpediente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwExpediente.CellClick

        End Sub
    End Class
End Namespace
