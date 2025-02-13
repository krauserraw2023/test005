Namespace Mantenimiento.Clasificacion
    Public Class frmFichaPopup

#Region "Propiedades_publicas"
        Public Property _Codigo() As Integer = -1
#End Region
#Region "Propiedades"
        Private Property AmbitoClasificacionId() As Integer
            Get
                Return cbbAmbitoClasificacion.SelectedValue
            End Get
            Set(value As Integer)
                cbbAmbitoClasificacion.SelectedValue = value
            End Set
        End Property
        Private Property TipoFichaId() As Integer
            Get
                Return cbbTipoFicha.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoFicha.SelectedValue = value
                If Type.Enumeracion.Clasificacion.enmTipoFicha.Final = value  Then
                    'tbpCatFicha.Parent = Nothing
                    tbpVarFicha.Parent = Nothing
                End If
                If Type.Enumeracion.Clasificacion.enmTipoFicha.Final <> value And Me._Codigo > 0 Then
                    'tbpCatFicha.Parent = TabControl1
                    tbpVarFicha.Parent = TabControl1
                    '    btnGrabar.Enabled = True
                End If
            End Set
        End Property
        Private Property NumOrden() As Integer
            Get
                Return Integer.Parse(If(txtNumOrd.Text.Length = 0, 0, txtNumOrd.Text))
            End Get
            Set(value As Integer)
                txtNumOrd.Text = value
            End Set
        End Property
        Private Property NombreFicha() As String
            Get
                Return txtNombre.Text
            End Get
            Set(value As String)
                txtNombre.Text = value
            End Set
        End Property
        Private Property DescripcionFicha() As String
            Get
                Return txtDescripcion.Text
            End Get
            Set(value As String)
                txtDescripcion.Text = value
            End Set
        End Property
        Private Property DocAprobacion() As String
            Get
                Return txtDocAprob.Text
            End Get
            Set(value As String)
                txtDocAprob.Text = value
            End Set
        End Property
        Private Property FechaDocumento() As Long
            Get
                Return dtpFechaDocAprob.ValueLong
            End Get
            Set(value As Long)
                dtpFechaDocAprob.ValueLong = value
            End Set
        End Property
        Private Property Estado() As Integer
            Get
                Return If(rbdActivo.Checked = True, 1, 0)
            End Get
            Set(value As Integer)
                If value = 1 Then
                    rbdActivo.Checked = True
                Else
                    dbrInactivo.Checked = True
                End If
            End Set
        End Property
#End Region
#Region "variables"
        Private flgGuardado As Boolean = False
#End Region
#Region "grilla_categorizacion"
        Private ReadOnly Property GrillaCatCodigo() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwCategorizacion
                        value = .Item("cat_col_codigo", .CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaCatNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwCategorizacion
                        value = .Item("cat_col_cat_nom", .CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaCatValMin() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwCategorizacion
                        value = .Item("cat_col_val_min", .CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaCatValMax() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwCategorizacion
                        value = .Item("cat_col_val_max", .CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaCatEstado() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwCategorizacion
                        value = .Item("cat_col_est_id", .CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
#End Region
#Region "grilla_variable"
        Private ReadOnly Property GrillaVarCodigo() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwVariable
                        value = .Item("var_col_codigo", .CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
#End Region
#Region "grilla_valores"
        Private ReadOnly Property GrillaValCodigo() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgvIndicador
                        value = .Item("col_ind_cod", .CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaValVariableId() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgvIndicador
                        value = .Item("col_ind_var_id", .CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()

            cbbAmbitoClasificacion._LoadUsc(Type.Combo.ComboTipo.ClasificacionAmbito)

            cbbTipoFicha._LoadUsc(Type.Combo.ComboTipo.ClasificacionTipoFicha)

            If Me._Codigo = -1 Then
                Me.AmbitoClasificacionId = -1
                Me.TipoFichaId = -1
            End If

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarIndicador()
            Dim ent As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE
            Dim entCol As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicadorCol_BE

            ent.VariableID = Me.dgwVariable.Item("var_col_codigo", dgwVariable.CurrentRow.Index).Value
            entCol = (New Bussines.Clasificacion.MaestroIndicador).Listar(ent)
            dgvIndicador.DataSource = entCol
        End Sub

        Private Sub ListarCategorizacionFicha()
            Dim ent As New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE

            ent.FichaId = Me._Codigo
            dgwCategorizacion.DataSource = (New Bussines.Clasificacion.CategoriaFicha).Listar(ent)
        End Sub

        Private Sub ListarVariables()
            Dim entVar As New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE

            entVar.FichaID = Me._Codigo
            dgwVariable.DataSource = (New Bussines.Clasificacion.MaestroVariable).Listar(entVar)

            Try
                Me.dgwVariable.ClearSelection()
                Me.dgwVariable.CurrentCell = Me.dgwVariable.Rows(0).Cells(2)

                Me.dgwVariable.Refresh()

                Dim x As New DataGridViewCellEventArgs(0, 0)
                dgwVariable_CellClick(dgwVariable, x)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub Listar()
            If Me._Codigo = -1 Then
                '???
            Else
                Dim entCat As New Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE

                entCat.Codigo = Me._Codigo
                entCat = (New Bussines.Clasificacion.MaestroFicha).Listar(Me._Codigo)
                With entCat
                    Me.AmbitoClasificacionId = .AmbitoClasificacionId
                    Me.TipoFichaId = .TipoFichaId
                    Me.Estado = .EstadoId
                    Me.NumOrden = .Secuencia
                    Me.NombreFicha = .Nombre
                    Me.DescripcionFicha = .Descripcion
                    Me.DocAprobacion = .DocAprobacion
                    Me.FechaDocumento = .DocAprobacionFecha

                    ListarCategorizacionFicha()
                    ListarVariables()
                End With
            End If

            If Type.Enumeracion.Clasificacion.enmTipoFicha.Final = Me.TipoFichaId Then
                tbpVarFicha.Parent = Nothing
            End If
        End Sub

        Private Sub ListarResultado()

            With Me.UscResultado1
                ._ListarGrilla(Me._Codigo)
            End With

        End Sub
        Private Sub ListarResultadoDet()

            With Me.UscResultadoDet1
                ._ListarGrilla(Me.UscResultado1._getCodigo)
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            If dtpFechaDocAprob.ValueLong > Now.ToFileTime Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Fecha de documento erroneo.")
                dtpFechaDocAprob.Select()
                Return False
            End If

            If Me.AmbitoClasificacionId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Seleccione el ámbito de clasificación.")
                cbbAmbitoClasificacion.Select()
                Return False
            End If

            If Me.TipoFichaId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Seleccione tipo de ficha.")
                cbbTipoFicha.Select()
                Return False
            End If

            Dim bs As New Bussines.Clasificacion.MaestroFicha
            Dim ent As New Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE

            ent.AmbitoClasificacionId = Me.AmbitoClasificacionId
            ent.TipoFichaId = Me.TipoFichaId
            ent.EstadoId = Me.Estado

            Dim entCol As New Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol_BE

            entCol = bs.Listar(ent)
            If Me._Codigo = -1 And entCol.Count > 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ya existe una ficha en estado activo con el mismo tipo y ámbito, para continuar debe dar de baja la ficha activa.")
                Return False
            End If

            If Me._Codigo > 0 And entCol.Count > 0 Then
                If entCol.Ficha(0).Codigo <> Me._Codigo Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Ya existe una ficha en estado activo con el mismo tipo y con el mismo ámbito, para continuar debe dar de baja la ficha activa.")
                    Return False
                End If
            End If

            Return True
        End Function

        Private Function AGrabarFicha() As Boolean

            If Validar() = False Then Return False

            Dim outErrSms As String = ""
            Dim ent As New Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE
            With ent
                .Codigo = Me._Codigo
                .AmbitoClasificacionId = Me.AmbitoClasificacionId
                .Descripcion = Me.DescripcionFicha
                .DocAprobacion = Me.DocAprobacion
                .DocAprobacionFecha = Me.FechaDocumento
                .EstadoId = Me.Estado
                .Nombre = Me.NombreFicha
                .Secuencia = Me.NumOrden
                .TipoFichaId = Me.TipoFichaId
            End With

            Dim id As Integer = -1

            id = (New Bussines.Clasificacion.MaestroFicha).Grabar(ent, outErrSms)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outErrSms)
                Return False
            End If

            Me._Codigo = id
            Return True
        End Function

        Private Function AEliminarVariable() As Boolean
            If dgwVariable.Rows.Count = 0 Then Return False

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Dim outErr As String = ""

                If (New Bussines.Clasificacion.MaestroVariable).Eliminar(Me.GrillaVarCodigo, outErr) = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo completar la operación, " & outErr)
                    Return False
                End If

                ListarVariables()
            End If
            Return True
        End Function

        Private Function AEliminarValor() As Boolean
            If dgvIndicador.Rows.Count = 0 Then Return False

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Dim outErr As String = ""

                If (New Bussines.Clasificacion.MaestroIndicador).Eliminar(Me.GrillaValCodigo, outErr) = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo completar la operación, " & outErr)
                    Return False
                End If

                ListarIndicador()
            End If
            Return True
        End Function
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            dgwVariable.AutoGenerateColumns = False
            dgwCategorizacion.AutoGenerateColumns = False
            dgvIndicador.AutoGenerateColumns = False

            If Me._Codigo = -1 Then
                tbpVarFicha.Parent = Nothing
            End If
        End Sub
#End Region

#Region "Indicadores"
        Private Sub dgvValores_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIndicador.CellDoubleClick
            btnEditarIndicador_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEditarIndicador_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarIndicador.Click
            If dgvIndicador.Rows.Count = 0 Then Exit Sub

            Dim colInd As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicadorCol_BE
            Dim entInd As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE

            With dgvIndicador
                For i As Integer = 0 To .Rows.Count - 1
                    entInd = New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE
                    entInd.Codigo = .Item("col_ind_cod", i).Value
                    entInd.Secuencia = .Item("col_ind_num_sec", i).Value
                    entInd.Descripcion = .Item("col_ind_nom", i).Value
                    entInd.Puntaje = .Item("col_ind_ptje", i).Value
                    colInd.Add(entInd)
                Next
            End With

            Dim f As New Clasificacion.frmManValoresPopup

            f._Codigo = Me.GrillaValCodigo
            f._VariableID = Me.GrillaValVariableId
            f._IndicadorCol = colInd

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListarIndicador()
            End If
        End Sub

        Private Sub btnNuevoIndicador_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoIndicador.Click
            If Me._Codigo = -1 Then If AGrabarFicha() = False Then Exit Sub

            If dgwVariable.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Primero debe agregar las variables")
                Exit Sub
            End If

            Dim colInd As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicadorCol_BE
            Dim entInd As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE

            With dgvIndicador
                For i As Integer = 0 To .Rows.Count - 1
                    entInd = New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE
                    entInd.Codigo = .Item("col_ind_cod", i).Value
                    entInd.Secuencia = .Item("col_ind_num_sec", i).Value
                    entInd.Descripcion = .Item("col_ind_nom", i).Value
                    entInd.Puntaje = .Item("col_ind_ptje", i).Value
                    colInd.Add(entInd)
                Next
            End With



            Dim f As New Clasificacion.frmManValoresPopup

            f._FichaId = _Codigo
            f._VariableID = Me.GrillaVarCodigo
            f._IndicadorCol = colInd

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListarIndicador()
            End If
        End Sub

#End Region
#Region "Variables"
        Private Sub dgwVariable_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwVariable.CellClick
            If e.RowIndex = -1 Then Exit Sub

            lblValorText.Text = "Indicador por variable (" & Me.dgwVariable.Item("var_col_nom", e.RowIndex).Value.ToString.ToUpper & ")"

            ListarIndicador()

        End Sub

        Private Sub dgwVariable_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwVariable.CellDoubleClick
            btnEditarVariable_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEditarVariable_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarVariable.Click
            If dgwVariable.Rows.Count = 0 Then Exit Sub

            Dim colVar As New Entity.Registro.Carceleta.Clasificacion.MaestroVariableCol_BE
            Dim entVar As New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE

            With dgwVariable
                For i As Integer = 0 To .Rows.Count - 1
                    entVar = New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE
                    entVar.Codigo = .Item("var_col_codigo", i).Value
                    entVar.NumeroOrden = .Item("var_col_num_ord", i).Value
                    entVar.Nombre = .Item("var_col_nom", i).Value
                    colVar.Add(entVar)
                Next
            End With
            


            Dim f As New Clasificacion.frmMantVariablePopup

            f._Codigo = Me.GrillaVarCodigo
            f._FichaId = Me._Codigo
            f._VariableCol = colVar

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListarVariables()
            End If
        End Sub

        Private Sub btnNuevoVariable_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoVariable.Click
            If Me._Codigo = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Para continuar es necesario completar los datos de la ficha y guardar")
                Exit Sub
            End If

            Dim colVar As New Entity.Registro.Carceleta.Clasificacion.MaestroVariableCol_BE
            Dim entVar As New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE

            With dgwVariable
                For i As Integer = 0 To .Rows.Count - 1
                    entVar = New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE
                    entVar.Codigo = .Item("var_col_codigo", i).Value
                    entVar.NumeroOrden = .Item("var_col_num_ord", i).Value
                    entVar.Nombre = .Item("var_col_nom", i).Value
                    colVar.Add(entVar)
                Next
            End With
            

            Dim f As New Clasificacion.frmMantVariablePopup

            f._FichaId = Me._Codigo
            f._VariableCol = colVar

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListarVariables()
            End If
        End Sub
#End Region
#Region "Categorizacion"
        Private Sub dgwCategorizacion_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwCategorizacion.CellDoubleClick
            btnEditarCat_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEditarCat_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarCat.Click
            If dgwCategorizacion.Rows.Count = 0 Then Exit Sub

            Dim colCat As New Entity.Registro.Carceleta.Clasificacion.CategoriaFichaCol_BE
            Dim Cat As New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE

            For i As Integer = 0 To dgwCategorizacion.Rows.Count - 1
                Cat = New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE
                Cat.Codigo = dgwCategorizacion.Item("cat_col_codigo", i).Value
                Cat.CategoriaNombre = dgwCategorizacion.Item("cat_col_cat_nom", i).Value
                Cat.ValorMinimo = dgwCategorizacion.Item("cat_col_val_min", i).Value
                Cat.ValorMaximo = dgwCategorizacion.Item("cat_col_val_max", i).Value
                colCat.Add(Cat)
            Next

            Dim f As New frmCategorizacionPopup

            f._Codigo = Me.GrillaCatCodigo
            f._FichaId = Me._Codigo
            f._CatFichaCol = colCat
            f._TipoFicha = Me.TipoFichaId

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListarCategorizacionFicha()
            End If
        End Sub

        Private Sub btnNuevoCat_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoCat.Click
            If Me._Codigo = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Para continuar es necesario completar los datos de la ficha y guardar.")
                Exit Sub
            End If

            Dim colCat As New Entity.Registro.Carceleta.Clasificacion.CategoriaFichaCol_BE
            Dim Cat As New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE

            For i As Integer = 0 To dgwCategorizacion.Rows.Count - 1
                Cat = New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE
                Cat.Codigo = dgwCategorizacion.Item("cat_col_codigo", i).Value
                Cat.CategoriaNombre = dgwCategorizacion.Item("cat_col_cat_nom", i).Value
                Cat.ValorMinimo = dgwCategorizacion.Item("cat_col_val_min", i).Value
                Cat.ValorMaximo = dgwCategorizacion.Item("cat_col_val_max", i).Value
                colCat.Add(Cat)
            Next

            Dim f As New frmCategorizacionPopup

            f._FichaId = Me._Codigo
            f._CatFichaCol = colCat
            f._TipoFicha = Me.TipoFichaId

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListarCategorizacionFicha()
            End If
        End Sub

        Private Sub btnEliminarCat_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarCat.Click
            If dgwCategorizacion.Rows.Count = 0 Then Exit Sub

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Dim outErr As String = ""

                If (New Bussines.Clasificacion.CategoriaFicha).Eliminar(Me.GrillaCatCodigo, outErr) = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo completar la operación, " & outErr)
                    Exit Sub
                End If

                ListarCategorizacionFicha()
            End If
        End Sub
#End Region

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            If Me.flgGuardado = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If

            Me.Close()
        End Sub

        Private Sub frmFichaPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Me.Refresh()
        End Sub

        Private Sub frmFichaPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ValoresxDefault()
            Combo()
            Listar()
        End Sub

        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
            If AGrabarFicha() = False Then Exit Sub

            If Me.TipoFichaId = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                tbpVarFicha.Parent = TabControl1
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.flgGuardado = True
            End If
        End Sub

        Private Sub cbbTipoFicha__SelectedIndexChanged() Handles cbbTipoFicha._SelectedIndexChanged
            Try
                Dim num As Integer = 0

                num = (New Bussines.Clasificacion.MaestroTipoFicha).Listar(Me.TipoFichaId).NumOrden

                Me.NumOrden = If(num = -1, 0, num)
                Me.TipoFichaId = Me.TipoFichaId 'artificio

            Catch ex As Exception

            End Try
        End Sub

        Private Sub btnEliminarVariable_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarVariable.Click
            If AEliminarVariable() = False Then Exit Sub
        End Sub

        Private Sub btnEliminarValor_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarIndicador.Click
            If AEliminarValor() = False Then Exit Sub
        End Sub
 
        Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedTab.Name
                Case tbpCatFicha.Name, tbpVarFicha.Name
                    If Me._Codigo = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("Para continuar es necesario completar los datos de la ficha y guardar.")
                        TabControl1.SelectedTab = tbpFicha
                        Exit Sub
                    End If
                    btnGrabar.Enabled = False
                Case tbpFicha.Name
                    btnGrabar.Enabled = True

                Case Me.tbpResultado.Name

                    ListarResultado()

            End Select
        End Sub

        Private Sub UscResultado1__Grilla_CellEnter() Handles UscResultado1._Grilla_CellEnter

            ListarResultadoDet()

        End Sub

        Private Sub UscResultado1_Load(sender As System.Object, e As System.EventArgs) Handles UscResultado1.Load

        End Sub
    End Class
End Namespace