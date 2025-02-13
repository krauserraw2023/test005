Imports Type.Enumeracion.Licencia

Namespace Registro

    Public Class uscGrillaNombresAsociadosV2
        Private objEntCol As Entity.Registro.NombreAsociadoCol = Nothing
        Private objBss As New Bussines.Registro.NombreAsociado

        Public Event _AddNombreAsociado()
        Public Event _MostrarResolucionesAclarados()
        Public Event _UpdNombreAsociado(ByVal id As Integer, objCol As Entity.Registro.NombreAsociado, forzarRegistroSoloLectura As Boolean)
        Public Event _AnularNombreAsociado()
        Public Event _Clik_btnIngresofocus()

#Region "Propiedades_Grilla" 'ninguna
        Public ReadOnly Property GrillaID() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_id").Value
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_pen_id").Value
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaIngresoID() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_ing_id").Value
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaDocumentoNAID As Integer
            Get

                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_doc_nom_aso_id").Value
                End With
                Return intValue

            End Get
        End Property
        Public ReadOnly Property GrillaDocumentoJudicialID As Integer
            Get

                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_doc_jud_id").Value
                End With
                Return intValue

            End Get
        End Property
        Public ReadOnly Property GrillaNombrePrincipal As Integer
            Get

                Dim intValue As Integer = 0
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_nom_aso_pri").Value
                End With
                Return intValue

            End Get
        End Property
#End Region
#Region "Propiedades_Par"
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _Documentos_sin_mov As Boolean = False
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_UserControl"
        Private blnVisibleGrabar As Boolean = False
        Private blnVisibleEliminar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
                VisibleControles()
            End Set
        End Property
        Public Property _VisibleEliminar() As Boolean
            Get
                Return blnVisibleEliminar
            End Get
            Set(value As Boolean)
                blnVisibleEliminar = value
                VisibleControles()
            End Set
        End Property
#End Region
#Region "Propiedades_Busqueda"
        Private Property Estado() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbActivos.Checked = True Then
                    value = 1
                End If

                If Me.rdbAnulados.Checked = True Then
                    value = 0
                End If

                Return value

            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 0
                        Me.rdbAnulados.Checked = True
                    Case 1
                        Me.rdbActivos.Checked = True
                    Case -1
                        Me.rdbTodos.Checked = True
                End Select
            End Set
        End Property
#End Region
#Region "Listar"
        Public Sub Listar()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.NombreAsociado
            objEntCol = New Entity.Registro.NombreAsociadoCol

            Dim objEnt As New Entity.Registro.NombreAsociado
            objEnt.InternoID = Me._InternoID
            objEnt.IngresoInpeID = Me._IngresoInpeID

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta
                    objEntCol = objBss.ListarNombresAsocxIngInpe_LM(objEnt, Me.TipoLicencia)
                Case enmTipoLicencia.RegionLimaMetropolitana
                    objEntCol = objBss.ListarNombresAsocxIngInpe_LM(objEnt, Me.TipoLicencia)
                Case enmTipoLicencia.PenalLimaMetropolitana
                    'objEnt.PenalID = Me._PenalID
                    objEntCol = objBss.ListarNombresAsocxIngInpe_LM(objEnt, Me.TipoLicencia)
                Case Else
                    objEnt.IngresoID = Me._IngresoID
                    objEnt.Estado = Me.Estado
                    objEntCol = objBss.ListarNombresAsociadosxIngreso(objEnt)
            End Select

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol

                For i As Integer = 0 To .Rows.Count - 1
                    .Item("col_nro", i).Value = i + 1
                Next
                lblReg.Text = objEntCol.Count & " Reg."
            End With

        End Sub
#End Region
#Region "Accion"
        Public Sub AAnularNombresAsociados(ByVal DocumentoJudicialID As Long)

            Dim value As Integer = -1
            Dim intInterno As Integer = -1
            Dim intPrincipal As Integer = -1
            Dim strApePat As String = ""
            Dim strApeMat As String = ""
            Dim strNom As String = ""
            Dim intEstado As Integer = -1

            Me.dgwGrilla.CurrentCell = Nothing
            For Each row As DataGridViewRow In Me.dgwGrilla.Rows
                'hola
                If row.Cells("col_chk").Value = True Then
                    value = row.Cells("col_id").Value
                    intInterno = row.Cells("col_int_id").Value
                    intPrincipal = row.Cells("col_nom_aso_pri").Value
                    strApePat = row.Cells("col_ape_pat").Value
                    strApeMat = row.Cells("col_ape_mat").Value
                    strNom = row.Cells("col_nom").Value
                    intEstado = row.Cells("col_est_id").Value

                    If intPrincipal = 1 Then

                        Dim strMensaje As String = ""
                        strMensaje = "No puede anular un nombre asociado principal, antes registre un nombre asociado como principal."
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub

                    Else
                        Dim intAsoID As Integer = -1

                        objBss = New Bussines.Registro.NombreAsociado
                        value = objBss.GrabarEstado(value, 0)

                        'detalle nombres asociados
                        Dim objBssNA As New Bussines.Registro.Documento.NombresAsociados
                        Dim objEntNA As New Entity.Registro.Documento.NombresAsociados
                        With objEntNA
                            .Codigo = -1
                            .InternoNombreAsociadoID = value
                            .InternoID = intInterno
                            .DocumentoJudicialID = DocumentoJudicialID
                            .NAPrincipal = intPrincipal
                            .NAPaterno = strApePat
                            .NAMaterno = strApeMat
                            .NANombres = strNom
                            .NAEstado = 0
                            .RegionID = Me._RegionID
                            .PenalID = Me._PenalID
                        End With
                        objBssNA.Grabar_v2(objEntNA)
                        'objBssNA.Grabar(-1, value, intInterno, DocumentoJudicialID, intPrincipal, _
                        '                           strApePat, strApeMat, strNom, _
                        '              0, Me._RegionID, Me._PenalID)
                    End If
                End If
            Next

        End Sub
        Private Sub AEliminar()

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Esta operacion no esta permitida por esta opcion, haga doble clic sobre el registro")
                Exit Sub
            Else
                btnAnular.PerformClick()
            End If

        End Sub
        Private Sub AMantenimiento(ByVal Nuevo As Boolean)
            Dim bssReg As New Bussines.Registro.DocumentoJudicial
            Dim EntReg As New Entity.Registro.DocumentoJudicial
            Dim EntRegDoc As New Entity.Registro.DocumentoJudicial
            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Antes de grabar algun registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._IngresoInpeID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe Ningun Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar")
                    RaiseEvent _Clik_btnIngresofocus()
                    Exit Sub
                End If
            Else
                If Me._IngresoID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe Ningun Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar")
                    RaiseEvent _Clik_btnIngresofocus()
                    Exit Sub
                End If
            End If


            If Nuevo = True Then
                RaiseEvent _AddNombreAsociado()
                _LoadUsc()
            Else    'ElseIf Nuevo = False Then
                If Me.GrillaID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre debe ser regularizado, hacer click en" + Chr(13) +
                                                                            "[Documentos judiciales y Movimiento] /" + Chr(13) +
                                                                            "[Documentos judiciales y Resoluciones] y asiganarle un documento")
                    Exit Sub
                Else
                    Dim regForzarSoloLectura As Boolean = False
                    RaiseEvent _UpdNombreAsociado(Me.GrillaID, objEntCol.NombreAsociado(dgwGrilla.SelectedRows(0).Index), regForzarSoloLectura)
                End If
                _LoadUsc()
            End If
        End Sub
        Private Sub AAnular()
            If Me._Documentos_sin_mov = True Or btnAnular.Text = "Eliminar" Then
                Dim regForzarSoloLectura As Boolean = False

                If Me.TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                    If Me.GrillaPenalId <> Me._PenalID Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede eliminar, el registro es de solo lectura.")
                        Exit Sub
                    End If
                End If

                If Me.dgwGrilla.RowCount = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar.")
                    Exit Sub
                ElseIf dgwGrilla.SelectedRows(0).Selected = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar.")
                    Exit Sub
                Else
                    Dim intContaPrin As Integer = 0
                    For Each objnom As Entity.Registro.NombreAsociado In objEntCol
                        If objnom.Principal = Type.Enumeracion.NombreAsociado.EnmTipo.Principal Then
                            intContaPrin += 1
                        End If
                    Next
                    If Me.GrillaNombrePrincipal = Type.Enumeracion.NombreAsociado.EnmTipo.Principal Then
                        If intContaPrin = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede eliminar un nombre asociado principal, antes registre un nombre asociado como principal.")
                            Exit Sub
                        End If
                    End If
                    Dim bss As New Bussines.Registro.Documento.NombresAsociados
                    Dim obj As New Entity.Registro.Documento.NombresAsociados
                    obj.InternoID = Me._InternoID
                    obj.InternoNombreAsociadoID = Me.GrillaID

                    If bss.Listar(obj).Count > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede eliminar este nombre asociado, porque ha sido referenciado por un documento.")
                        Exit Sub
                    End If
                    Dim bssrnc As New Bussines.Registro.InternoReniec
                    Dim objr As New Entity.Registro.InternoReniec
                    objr.InternoID = Me._InternoID
                    objr.NombreAsociadoVal_ID = Me.GrillaID
                    objr.PenalID = Me._PenalID
                    If bssrnc.Listar(objr).Codigo > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede eliminar este nombre asociado, porque ha sido validado con RENIEC.")
                        Exit Sub
                    End If
                    If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                        objBss.Eliminar(Me.GrillaID)
                        RaiseEvent _AnularNombreAsociado()
                    End If
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para anular un nombre asociado, se realiza desde un documento.")
                Exit Sub
                If Me.GrillaCheckCount < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Para anular los nombres asociados, seleccione los nombres")
                    Exit Sub
                End If

                '/*******************************/
                Dim intPrincipal As Integer = -1

                Me.dgwGrilla.CurrentCell = Nothing
                For Each row As DataGridViewRow In Me.dgwGrilla.Rows
                    If row.Cells("col_chk").Value = True Then
                        intPrincipal = row.Cells("col_nom_aso_pri").Value

                        If intPrincipal = 1 Then

                            Dim strMensaje As String = ""
                            strMensaje = "No puede anular un nombre asociado principal, antes registre un nombre asociado como principal."
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                            Exit Sub
                        End If
                    End If

                Next

                RaiseEvent _AnularNombreAsociado()
            End If
        End Sub
        'Private Sub ComboNumIngreso()
        '    Dim objBssIng As New Bussines.Registro.Ingreso
        '    Dim objEntCol2 As New Entity.Registro.IngresoCol

        '    objEntCol2 = objBssIng.ListarNroIngreso(Me._InternoID, Me._PenalID)

        'End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()

            Me.pnlAddNombreAsoc.Visible = Me._VisibleGrabar

        End Sub
        Private Sub ValoresxDefault()

            dgwGrilla.Columns("col_ing_nro").ReadOnly = True
            dgwGrilla.Columns("col_doc_exist").ReadOnly = True
            'If Me._Documentos_sin_mov = True Then
            btnAnular.Text = "Eliminar"
            'End If
        End Sub
        Private Function GrillaCheckCount() As Integer

            Dim value As Integer = 0

            Me.dgwGrilla.CurrentCell = Nothing
            For Each row As DataGridViewRow In Me.dgwGrilla.Rows
                If row.Cells("col_chk").Value = True Then
                    value = value + 1
                End If
            Next

            Return value

        End Function
#End Region
#Region "ValoresxDefault"
        Dim intValor As Integer = 0
        Public Sub _LoadUsc()
            Select Case Me.TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    col_ing_nro_inpe.Visible = True
                    col_ing_nro.Visible = False
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    col_ing_nro.Visible = False
                    col_ing_nro_inpe.Visible = True
                Case Else
                    col_ing_nro.Visible = True
                    col_ing_nro_inpe.Visible = False
            End Select

            Listar()
        End Sub

#End Region
        Private Sub dgwNombreAsoc_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwNombreAsoc_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            If Me.dgwGrilla.RowCount > 0 Then AMantenimiento(False)
        End Sub

        Private Sub btnAddNombreAsoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            AMantenimiento(True)
        End Sub

        Private Sub dgwNombreAsoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown
            If e.KeyCode = Keys.Delete Then AEliminar()
        End Sub

        Private Sub dgwGrilla_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint
            With Me.dgwGrilla
                .Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Black
                .Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            End With
        End Sub

        Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click

            If dgwGrilla.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar.")
                Exit Sub
            End If

            AAnular()
        End Sub

        Private Sub rdbActivos_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles rdbActivos.Click, _
        rdbAnulados.Click, _
        rdbTodos.Click

            Listar()

        End Sub
        Private Sub uscGrillaNombresAsociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub cbbNroIngresos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
            _LoadUsc()
        End Sub

        Private Sub btnModNombreAsoc_Click(sender As System.Object, e As System.EventArgs) Handles btnModNombreAsoc.Click

            If dgwGrilla.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar.")
                Exit Sub
            Else

                If Me._Documentos_sin_mov = True Then
                    dgwNombreAsoc_CellDoubleClick(Nothing, Nothing)
                Else
                    Dim bss As New Bussines.Registro.Documento.NombresAsociados
                    Dim ent As New Entity.Registro.Documento.NombresAsociados
                    Dim entCol As New Entity.Registro.Documento.NombresAsociadosCol
                    ent.InternoNombreAsociadoID = Me.GrillaDocumentoNAID
                    ent.InternoID = Me._InternoID
                    entCol = bss.Listar(ent)
                    If entCol.Count > 0 Then
                        RaiseEvent _MostrarResolucionesAclarados()
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningun documento de aclaratoria de nombre para modificar.")
                    End If
                End If
            End If
        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            RaiseEvent _AddNombreAsociado()
        End Sub

    End Class
End Namespace

