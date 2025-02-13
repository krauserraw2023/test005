Namespace Visita
    Public Class uscBusqueda
        Private objBss As Bussines.Visita.Movimiento = Nothing
        Private objEntCol As Entity.Visita.MovimientoCol = Nothing
        Public Event _CellDoubleClick_RegistrarSalidaVisita(ByVal MovimientoID As Long, ByVal HoraIngreso As String,
                                                            intMovIngresaPor As Short)
#Region "Propiedades_Par"
        Public Property _PenalID() As Integer
        Public Property _RegionID() As Integer
#End Region
#Region "Propiedades"
        Private Property Config_RegimenVisitaID As Short = -1
        Private Property Config_HabilitarInternoPJ As Boolean = False
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
            Set(ByVal value As Long)

                If Me.TipoFechaUnica = True Then
                    Me.dtpFecha.ValueLong = value
                Else
                    Me.dtpFechaIni.ValueLong = value
                End If
            End Set

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
            Set(ByVal value As Long)

                If Me.TipoFechaUnica = True Then
                    Me.dtpFecha.ValueLong = value
                Else
                    Me.dtpFechaFin.ValueLong = value
                End If

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
        Private Property EstadoMovimiento() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbSinSal.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbConSal.Checked = True Then
                    intValue = 2
                End If

                If Me.rdbTodos.Checked = True Then
                    intValue = -1
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case -1
                        Me.rdbTodos.Checked = True
                    Case 1
                        Me.rdbSinSal.Checked = True
                    Case 2
                        Me.rdbConSal.Checked = True
                End Select
            End Set
        End Property
        Private Property MenoresTipo() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rb_menor_adulto.Checked = True Then
                    intValue = 1
                End If

                If Me.rb_menor_menor.Checked = True Then
                    intValue = 2
                End If

                If Me.rb_menor_todos.Checked = True Then
                    intValue = -1
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case -1
                        Me.rb_menor_todos.Checked = True
                    Case 1
                        Me.rb_menor_adulto.Checked = True
                    Case 2
                        Me.rb_menor_menor.Checked = True
                End Select
            End Set
        End Property
        Private ReadOnly Property MenoresCantidad() As Integer
            Get
                Dim intValue As Integer = 0

                If Me.chk_visitante_menor.Checked Then
                    intValue = 1
                End If
                Return intValue
            End Get

        End Property
        Private Property PaseNumero() As String
            Get
                Return Me.txtpasenumero.Text
            End Get
            Set(ByVal value As String)
                Me.txtpasenumero.Text = value
            End Set
        End Property
        Private Property TipoParentesco As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbParentesco.Checked = True Then
                    value = 1
                End If

                If Me.rdbTipoVisita.Checked = True Then
                    value = 2
                End If
                Return value
            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbParentesco.Checked = True
                    Case 2
                        Me.rdbTipoVisita.Checked = True
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
        Private Property RegimenVisitaID As Short
            Get
                Return Me.cbbTipoRegimen.SelectedValue
            End Get
            Set(ByVal value As Short)
                Me.cbbTipoRegimen.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private intNumeroReg As Integer = -1
        Public ReadOnly Property GrillaMovimiento() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwMovi
                        intValue = .SelectedRows(0).Cells("col_mov_id").Value '
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaMovimientoIDPadre() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwMovi
                        intValue = .SelectedRows(0).Cells("col_mov_id_pdr").Value '
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaVisitante() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwMovi
                        intValue = .SelectedRows(0).Cells("col_vis_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaHoraIngreso() As String
            Get
                Dim strValue As String = -1
                Try
                    With Me.dgwMovi
                        strValue = .SelectedRows(0).Cells("col_hor_ing").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Public ReadOnly Property GrillaFechaSal() As Long
            Get
                Dim value As Long = 0
                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_fec_sal").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaFotoVisitante() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwMovi
                        strValue = .SelectedRows(0).Cells("col_fot_vis").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaMovimientoIngresaPor As Short
            Get
                Dim value As Short = -1

                Try
                    With Me.dgwMovi
                        value = .SelectedRows(0).Cells("col_tip_ing_por").Value
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
        Private Sub GrillaCountVisitantes()

            Dim i As Integer = 0

            For Each fila As DataGridViewRow In Me.dgwMovi.Rows

                If fila.Cells("col_vis_ape_nom").Value.ToString.Trim.Length > 6 Then
                    i = i + 1
                End If
            Next

            Me.lblRegPersonas.Text = i & " Vis."
        End Sub
#End Region
#Region "Propiedades_Otros"
        Private blnModificarSalida As Boolean = False
        Public Property _ModificarSalida() As Boolean
            Get
                Return blnModificarSalida
            End Get
            Set(ByVal value As Boolean)
                blnModificarSalida = value
            End Set
        End Property

#End Region
#Region "Combo"
        Private Sub ComboTipoDoc()

            With Me.cbbTipoDoc
                .ComboTipo = Type.Combo.ComboTipo.TipoDoc
                ._Todos = True
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
        Private Sub ComboRegimenVisita()

            Dim objBss As New Bussines.General.Parametrica
            Dim objEntCol As New Entity.General.ParametricaCol
            Dim objEntColCombo As New Entity.General.ParametricaCol

            Dim blnRegimenEspe As Boolean = False
            Dim blnAddEnt As Boolean = False

            Listar_Config_Visita()

            If Me.Config_RegimenVisitaID = 2 Or Me.Config_RegimenVisitaID = 3 Then
                blnRegimenEspe = True
            End If

            objEntCol = objBss.Listar(Type.Combo.ComboTipo.VIS_RegimenVisita, -1, -1, -1, True, "[Todos]")

            For Each obj As Entity.General.Parametrica In objEntCol
                Select Case obj.Codigo
                    Case -1, 1, 4
                        blnAddEnt = True

                    Case Type.Enumeracion.Visita.RegimenVisita.PoderJudicial

                        If Me.Config_HabilitarInternoPJ = True Then
                            blnAddEnt = True
                        End If

                    Case 2, 3
                        If blnRegimenEspe = True Then
                            blnAddEnt = True
                        End If
                End Select

                If obj.Codigo <> 3 Then
                    If blnAddEnt = True Then
                        objEntColCombo.Add(obj)
                        blnAddEnt = False
                    End If
                End If

            Next

            With Me.cbbTipoRegimen
                .DataSource = objEntColCombo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub
#End Region
#Region "Listar"
        Private Function Listar() As Boolean

            Dim blnValue As Boolean = False

            objBss = New Bussines.Visita.Movimiento
            objEntCol = New Entity.Visita.MovimientoCol

            Dim objEntFiltro As New Entity.Visita.Movimiento

            With objEntFiltro
                '/*visita*/             
                .VisitanteTipoDocumento = Me.VisitanteTipoDocumentoID
                .VisitanteNumeroDocumento = Me.VisitaNumeroDoc
                .VisitanteApellidosyNombres = Me.VisitaApeNom
                '/*interno*/                
                .InternoNumeroDocumento = Me.InternoNumeroDoc
                .InternoApellidosyNombres = Me.InternoApeNom
                ''/*movimiento
                .FechaInicio = Me.FechaInicio
                .FechaFin = Me.FechaFin
                .MenoresCantidad = Me.MenoresCantidad
                .MenoresTipo = Me.MenoresTipo
                .EstadoID = Me.EstadoMovimiento
                .ParentescoID = Me.Parentesco
                .PaseNumero = Me.PaseNumero
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenVisitaID = Me.RegimenVisitaID
            End With

            objEntCol = objBss.ListarGrillaMovimiento(objEntFiltro)

            With Me.dgwMovi
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol

                GrillaCount(.RowCount)
                GrillaCountVisitantes()

                If .RowCount > 0 Then
                    .SelectedRows(0).Selected = False
                End If
            End With

            blnValue = True

        End Function
        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String)

            With Me.UscFoto1
                '._TipoImagen = Foto.uscFotografia.DirectotioTipo.Visitante
                .SizeMode = PictureBoxSizeMode.Zoom
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub
        Public Sub _Buscar()

            Buscar()

        End Sub
        Private Sub Buscar()

            Me.col_fec_ing.Tag = "fecha"
            Me.col_fec_sal.Tag = "fecha"

            Select Case Me.EstadoMovimiento
                Case 1
                    Me.col_hor_sal.Visible = False
                    Me.col_fec_sal.Visible = False
                    Me.col_min_per.Visible = False
                Case Else
                    Me.col_hor_sal.Visible = True
                    Me.col_fec_sal.Visible = True
                    Me.col_min_per.Visible = True
            End Select

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
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese fecha inicio")
                    Me.dtpFechaIni.Focus()
                    Return value
                End If

                '/*validar fecha fin*/
                If Me.FechaFin = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese fecha fin")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If

                '/*'fecha fin, no puede ser menor a la fecha de inicio*/
                If Me.FechaFin < Me.FechaInicio Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "La fecha final es menor a la fecha inicio, cambie las fechas")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If

            End If

            value = True

            Return value
        End Function
#End Region
#Region "Accion"
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                objBss = New Bussines.Visita.Movimiento
                objBss.Eliminar(Me.GrillaMovimiento)
                Buscar()
            End If

        End Sub
        Public Sub AExportar()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwMovi)
        End Sub
#End Region
#Region "Form"
        Private Sub Form_Salida()

            If Me.GrillaFechaSal > 0 Then
                Exit Sub
            End If

            Dim intMovimientoID As Long = -1
            Dim strHoraIngreso As String = ""
            Dim intMovIngresaPor As Short = -1

            If Me.GrillaMovimientoIDPadre > 0 Then
                intMovimientoID = GrillaMovimientoIDPadre

                objBss = New Bussines.Visita.Movimiento
                Dim objEnt As New Entity.Visita.Movimiento

                objEnt = objBss.Listar(intMovimientoID)
                strHoraIngreso = objEnt.HoraIngreso
                intMovIngresaPor = objEnt.TipoIngresoPor

            Else
                intMovimientoID = Me.GrillaMovimiento
                strHoraIngreso = Me.GrillaHoraIngreso
                intMovIngresaPor = Me.GrillaMovimientoIngresaPor
            End If

            'col_tip_ing_por
            RaiseEvent _CellDoubleClick_RegistrarSalidaVisita(intMovimientoID, strHoraIngreso, intMovIngresaPor)

        End Sub
#End Region
#Region "Permisos/Accesos"
        Private Sub Listar_Config_Visita()

            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As New Entity.Visita.Config

            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .Estado = 1 'alta
            End With

            objEnt = objBss.ListarConfigActual(objEntFiltro)

            If Not objEnt Is Nothing Then
                With objEnt
                    Me.Config_RegimenVisitaID = .RegimenTipoID
                    Me.Config_HabilitarInternoPJ = .HabilitarInternosPJ
                End With
            Else
                Me.Config_RegimenVisitaID = -1
                Me.Config_HabilitarInternoPJ = False
                'Me.RegimenTipoNombre = "Regimen Ordinario"                
            End If

        End Sub
#End Region
#Region "Otros"

        Private Sub HabilitarFecha()

            Me.dtpFecha.Enabled = False
            Me.dtpFechaIni.Enabled = False
            Me.dtpFechaFin.Enabled = False

            If Me.rdbFechaUni.Checked = True Then
                'Me.dtpFecha.Enabled = True
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
            ComboRegimenVisita()

            Me.UscFoto1._CheckImagen = True
            Me.dgwMovi.VisibleCampos = True

        End Sub
        Public Sub LoadUsc()

            ValoresxDefault()
            'HabilitarFecha()

        End Sub
        Private Sub HabilitarParentesco()

            Me.ComboParentesco()

        End Sub
#End Region

        Private Sub dgwMovi_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellClick

            Try
                With Me.dgwMovi
                    If e.RowIndex = -1 And e.ColumnIndex <> .Columns("col_ico_nin_men").Index Then
                        .Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If

                End With

            Catch ex As Exception

            End Try


        End Sub

        Private Sub txtVisNumDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtVisNumDoc.KeyPress, _
        txtVisApeNom.KeyPress, _
        txtIntNumDoc.KeyPress, _
        txtIntApeNom.KeyPress, _
        txtpasenumero.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub rdbFechaUni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbFechaUni.Click, _
        rdbFechaRango.Click

            HabilitarFecha()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub dgwMovi_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellDoubleClick

            If Me.dgwMovi.RowCount > 0 And e.RowIndex <> -1 And Me._ModificarSalida = True Then
                Form_Salida()
            End If

        End Sub

        Private Sub rdbSinSal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        rdbSinSal.Click, _
        rdbConSal.Click, _
        rdbTodos.Click

            Buscar()

        End Sub

        Private Sub dgwMovi_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwMovi.CellFormatting

            With Me.dgwMovi
                Select Case e.ColumnIndex
                    Case .Columns("col_fec_ing").Index, .Columns("col_fec_sal").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If
                        'Case .Columns("col_edad").Index
                        '    If e.Value > 0 Then
                        '        e.Value = e.Value
                        '    Else
                        '        e.Value = ""
                        '    End If

                End Select
            End With

        End Sub

        Private Sub dgwMovi_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellEnter

            If Me.dgwMovi.RowCount > 0 Then
                ImagenFotoVisitante(Me.GrillaFotoVisitante)
            End If

        End Sub

        Private Sub dgwMovi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwMovi.KeyDown

            Select Case e.KeyData
                Case (Keys.Shift Or Keys.Delete)
                    AEliminar()
            End Select

        End Sub

        Private Sub UscFoto1__CheckClick() Handles UscFoto1._CheckClick

            ImagenFotoVisitante(Me.GrillaFotoVisitante)

        End Sub

        Private Sub rdbParentesco_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rdbParentesco.Click, _
             rdbTipoVisita.Click, _
              rdbParentescoTodos.Click

            HabilitarParentesco()

        End Sub

        Private Sub dgwMovi_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellContentClick

        End Sub
    End Class

End Namespace
