Imports System.Linq
Namespace Seguridad.Paquetes
    Public Class uscBusquedaPaquete
        Private objBss As Bussines.Seguridad.Paquetes.Registro = Nothing
        Private objEntCol As Entity.Seguridad.Paquetes.RegistroCol = Nothing

#Region "Propiedades_Publicas"
        Public Property _idPenal() As Integer
        Public Property _idRegion() As Integer
#End Region
#Region "Propiedades_Buscar"
        Public Property FechaInicio() As Long
            Get
                Dim lngValue As Long = 0

                If Me.TipoFechaUnica = True Then
                    lngValue = Me.dtpFecha.ValueLong
                Else
                    lngValue = Me.dtpFechaIni.ValueLong
                End If

                Return lngValue
            End Get
            Set(value As Long)
                If Me.TipoFechaUnica = True Then
                    Me.dtpFecha.ValueLong = value
                Else
                    Me.dtpFechaIni.ValueLong = value
                End If
            End Set
        End Property
        Private ReadOnly Property fechaInicioDate As Date
            Get
                Return Date.FromFileTime(FechaInicio)
            End Get
        End Property
        Public Property FechaFin() As Long
            Get
                Dim lngValue As Long = 0

                If Me.TipoFechaUnica = True Then
                    lngValue = Me.dtpFecha.ValueLong
                Else
                    lngValue = Me.dtpFechaFin.ValueLong
                End If

                Return lngValue

            End Get
            Set(value As Long)
                If Me.TipoFechaUnica = True Then
                    Me.dtpFecha.ValueLong = value
                Else
                    Me.dtpFechaFin.ValueLong = value
                End If
            End Set
        End Property
        Private ReadOnly Property fechaFinDate As Date
            Get
                Return Date.FromFileTime(FechaFin)
            End Get
        End Property
        Private Property tipoPaquete As Short
            Get
                Dim value As Short = -1

                If Me.rbEntregaInterno.Checked = True Then
                    value = 1
                End If

                If Me.rbEntregaEconomato.Checked = True Then
                    value = 2
                End If

                If Me.rbEntregaTaller.Checked = True Then
                    value = 3
                End If

                Return value

            End Get
            Set(value As Short)

                Select Case value
                    Case 1
                        Me.rbEntregaInterno.Checked = True

                    Case 2
                        Me.rbEntregaEconomato.Checked = True

                    Case 3
                        Me.rbEntregaTaller.Checked = True
                End Select

            End Set
        End Property
        Private Property tipoPresentacion As Short
            Get
                Dim value As Short = -1

                If Me.rdbSobre.Checked = True Then
                    value = 1
                End If

                If Me.rdbBolsa.Checked = True Then
                    value = 2
                End If

                If Me.rdbSobreBolsa.Checked = True Then
                    value = 3
                End If

                If Me.rdbOtro.Checked = True Then
                    value = 4
                End If

                Return value
            End Get
            Set(value As Short)

                Select Case value
                    Case 1
                        Me.rdbSobre.Checked = True

                    Case 2
                        Me.rdbBolsa.Checked = True

                    Case 3
                        Me.rdbSobreBolsa.Checked = True

                    Case 4
                        Me.rdbOtro.Checked = True
                End Select

            End Set
        End Property

        Private Property idTipoArticulo As Integer
            Get
                Return Me.cbbTipoArticulo.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbTipoArticulo.SelectedValue = value
            End Set
        End Property
        Private Property VisitanteTipoDocumentoID() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property VisitaNumeroDoc() As String
            Get
                Return Me.txtVisNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVisNumDoc.Text = value
            End Set
        End Property
        Private Property VisitaApeNom() As String
            Get
                Return Me.txtVisApeNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVisApeNom.Text = value
            End Set
        End Property
        Private Property InternoNumeroDoc() As String
            Get
                Return Me.txtIntNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntNumDoc.Text = value
            End Set
        End Property
        Private Property InternoApeNom() As String
            Get
                Return Me.txtIntApeNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntApeNom.Text = value
            End Set
        End Property
        Private ReadOnly Property TipoFechaUnica() As Boolean
            Get
                Dim blnValue As Boolean = False

                If Me.rdbFechaUni.Checked = True Then
                    blnValue = True
                End If
                Return blnValue
            End Get
        End Property
        Private Property TipoParentesco As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbParentesco.Checked = True Then
                    value = 1
                End If

                Return value
            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbParentesco.Checked = True
                    Case Else
                        Me.rdbParentescoTodos.Checked = False
                End Select

            End Set
        End Property
        Private Property Parentesco() As Integer
            Get
                Return Me.cbbParentesco.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbParentesco.SelectedValue = value
            End Set
        End Property
        Private Property entregaDinero As Short
            Get
                Dim value As Short = -1

                If Me.rbDineroNo.Checked = True Then
                    value = 0
                End If

                If Me.rbDineroSi.Checked = True Then
                    value = 1
                End If

                Return value
            End Get
            Set(value As Short)

                Select Case value
                    Case 0
                        Me.rbDineroNo.Checked = True

                    Case 1
                        Me.rbDineroSi.Checked = True
                End Select

            End Set
        End Property
        Private Property entregaMedicamento As Short
            Get
                Dim value As Short = -1

                If Me.rbMedicaNo.Checked = True Then
                    value = 0
                End If

                If Me.rbMedicaSi.Checked = True Then
                    value = 1
                End If

                Return value
            End Get
            Set(value As Short)

                Select Case value
                    Case 0
                        Me.rbMedicaNo.Checked = True

                    Case 1
                        Me.rbMedicaSi.Checked = True
                End Select

            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property grillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwMovi
                        intValue = .SelectedRows(0).Cells("col_mov_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property grillaFotoVisitante() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_vis_fot_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property grillaidFotoPaquete() As String
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_id_fot_paq").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private Sub GrillaCount(ByVal RowCount As Integer)

            Dim strValue As String = ""
            Dim intValue As Integer = 0

            intValue = RowCount
            Me.lblReg.Text = intValue & " Reg."

        End Sub
#End Region
#Region "Propiedades_Otros"
        Private ReadOnly Property tipoFotografia() As Short
            Get
                Dim value As Short = -1

                If rbVerFotoVisitante.Checked = True Then
                    value = 1
                End If

                If rbVerFotoPaquete.Checked = True Then
                    value = 2
                End If

                Return value
            End Get

        End Property




#End Region
#Region "Combo"
        Private Sub ComboTipoArticulo()

            With Me.cbbTipoArticulo
                .ComboTipo = Type.Combo.ComboTipo.seg_pqt_tipoarticulo_mae 'tipo articulo de paqueteria
                ._Todos = True
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboTipoDoc()

            With Me.cbbTipoDoc
                .ComboTipo = Type.Combo.ComboTipo.TipoDoc
                ._Todos = True

                Dim lista As New List(Of Integer)
                lista.Add(Type.Enumeracion.enmTipoDocumento.LM) 'L.M. (Libreta Militar)
                lista.Add(Type.Enumeracion.enmTipoDocumento.PN) 'P.N. (Partida de Nacimiento)
                lista.Add(8) 'P.N. (CARNE IDENTIDAD PERSONAL)
                lista.Add(11) 'INDOCUMENTADO
                lista.Add(Type.Enumeracion.enmTipoDocumento.CC) 'CREDENCIAL CONSULAR
                lista.Add(14) 'CARNET FISCALIA
                lista.Add(15) 'CEDULA DE IDENTIDAD
                .ListaIdsParaExcluir = lista

                .LoadUsc()
            End With

        End Sub
        Private Sub ComboParentesco()

            With Me.cbbParentesco
                If Me.TipoParentesco = -1 Then
                    ._Todos = True
                Else
                    ._Todos = False
                End If
                .ComboTipo = Type.Combo.ComboTipo.Parentesco
                .CodigoPadre = Me.TipoParentesco
                .LoadUsc()
            End With
        End Sub

#End Region
#Region "Listar"
        Private Function Listar() As Boolean

            Dim blnValue As Boolean = False

            objBss = New Bussines.Seguridad.Paquetes.Registro
            objEntCol = New Entity.Seguridad.Paquetes.RegistroCol

            Dim objEntFiltro As New Entity.Seguridad.Paquetes.Registro

            With objEntFiltro
                '/*visita*/             
                .idVisitaTipoDocumento = Me.VisitanteTipoDocumentoID
                .visitaNumeroDocumento = Me.VisitaNumeroDoc
                .visitaApellidosNombres = Me.VisitaApeNom
                '/*interno*/                
                .internoNumeroDocumento = Me.InternoNumeroDoc
                .internoApellidosNombres = Me.InternoApeNom
                ''/*movimiento
                .fechaInicio = Me.fechaInicioDate
                .fechaFin = Me.fechaFinDate
                .idParentesco = Me.Parentesco
                .tipoPaquete = Me.tipoPaquete
                .tipoPresentacion = Me.tipoPresentacion
                .idTipoArticulo = Me.idTipoArticulo
                .filtroEntregaDinero = Me.entregaDinero
                .filtroEntregaMedicamento = Me.entregaMedicamento
                .idRegion = Me._idRegion
                .idPenal = Me._idPenal
            End With

            objEntCol = objBss.listarGrilla(objEntFiltro)

            With Me.dgwMovi
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol

                GrillaCount(.RowCount)

                If .RowCount > 0 Then
                    .SelectedRows(0).Selected = False
                End If
            End With

            blnValue = True

        End Function

        Private Sub mostrarFotografia(tipoFotografia As Short, ByVal nombreFoto As String)

            With Me.UscFoto1
                .SizeMode = PictureBoxSizeMode.Zoom

                Select Case tipoFotografia
                    Case 1
                        ._ShowFotoVisitante(nombreFoto)
                    Case 2
                        Dim fotoByte As Byte() = getFotografiaPaquete(Me.grillaidFotoPaquete)
                        ._mostrarFotoByte(fotoByte)
                End Select

            End With

        End Sub
        Public Sub _Buscar()

            Buscar()

        End Sub
        Private Sub Buscar()

            Me.col_fec_ing.Tag = "fecha"
            'Me.col_fec_sal.Tag = "fecha"

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            Listar()
            Me.UscFoto1._Limpiar()

        End Sub
        Private Function ValidarBusqueda() As Boolean

            Dim value As Boolean = False

            If Me.TipoFechaUnica = False Then

                '/*validar fecha inicio
                If Me.FechaInicio = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese fecha inicio")
                    Me.dtpFechaIni.Focus()
                    Return value
                End If

                '/*validar fecha fin*/
                If Me.FechaFin = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese fecha fin")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If

                '/*'fecha fin, no puede ser menor a la fecha de inicio*/
                If Me.FechaFin < Me.FechaInicio Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "La fecha final es menor a la fecha inicio, cambie las fechas")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If

            End If

            value = True

            Return value
        End Function
        Private Function getFotografiaPaquete(codigo As Integer) As Byte()

            Dim value As Byte() = Nothing

            If codigo < 1 Then
                Return value
            End If

            Dim objBssFotoPaquete As New Bussines.Seguridad.Paquetes.ArchivoDigital
            value = objBssFotoPaquete.getFotoByte(codigo)

            Return value

        End Function
#End Region
#Region "Accion"
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                objBss = New Bussines.Seguridad.Paquetes.Registro
                objBss.Eliminar(Me.grillaCodigo)
                Buscar()
            End If

        End Sub
        Public Sub AExportar()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwMovi)
        End Sub
#End Region
#Region "Otros"

        Private Sub HabilitarFecha()

            Me.dtpFecha.Enabled = False
            Me.dtpFechaIni.Enabled = False
            Me.dtpFechaFin.Enabled = False

            If Me.rdbFechaUni.Checked = True Then
                Me.dtpFecha.Enabled = False
            Else
                Me.dtpFechaIni.Enabled = True
                Me.dtpFechaFin.Enabled = True
            End If

        End Sub
        Private Sub ValoresxDefault()

            HabilitarFecha()
            ComboParentesco()
            ComboTipoDoc()
            ComboTipoArticulo()

            Me.UscFoto1._CheckImagen = True
            Me.dgwMovi.VisibleCampos = True

        End Sub
        Public Sub LoadUsc()

            ValoresxDefault()

        End Sub
        Private Sub HabilitarParentesco()

            Me.ComboParentesco()

        End Sub
#End Region

        Private Sub dgwMovi_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellClick

            Try
                With Me.dgwMovi
                    If e.RowIndex = -1 Then
                        .Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If
                End With

            Catch ex As Exception
                dgwMovi.Cursor = Cursors.Default
            End Try

        End Sub

        Private Sub txtVisNumDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtVisNumDoc.KeyPress,
        txtVisApeNom.KeyPress,
        txtIntNumDoc.KeyPress,
        txtIntApeNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub rdbFechaUni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbFechaUni.Click,
        rdbFechaRango.Click

            HabilitarFecha()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub dgwMovi_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwMovi.CellFormatting

            'With Me.dgwMovi
            '    Select Case e.ColumnIndex
            '        Case .Columns("col_fec_ing").Index, .Columns("col_fec_sal").Index

            '            If IsNumeric(e.Value) And e.Value > 1 Then
            '                e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
            '            Else
            '                e.Value = ""
            '            End If

            '            'Case .Columns("col_edad").Index
            '            '    If e.Value > 0 Then
            '            '        e.Value = e.Value
            '            '    Else
            '            '        e.Value = ""
            '            '    End If

            '    End Select
            'End With

        End Sub

        Private Sub dgwMovi_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellEnter

            If Me.dgwMovi.RowCount > 0 Then
                mostrarFotografia(Me.tipoFotografia, Me.grillaFotoVisitante)
            End If

        End Sub

        Private Sub dgwMovi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwMovi.KeyDown

            Select Case e.KeyData
                Case (Keys.Shift Or Keys.Delete)
                    AEliminar()
            End Select

        End Sub

        Private Sub rdbParentesco_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rdbParentesco.Click,
              rdbParentescoTodos.Click

            HabilitarParentesco()

        End Sub

        Private Sub rbVerFotoVisitante_Click(sender As Object, e As EventArgs) Handles rbVerFotoVisitante.Click, rbVerFotoPaquete.Click

            mostrarFotografia(tipoFotografia, Me.grillaFotoVisitante)

        End Sub

        Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

        End Sub
    End Class

End Namespace
