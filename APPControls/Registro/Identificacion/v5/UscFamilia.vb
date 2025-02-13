Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion.v5
    Public Class uscFamilia
        Private objBss As Bussines.Registro.Familiar = Nothing
        Private objEntCol As Entity.Registro.FamiliarCol = Nothing
#Region "Eventos"
        Public Event _CellDoubleClick(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean)
        Public Event _ClickAdd(objEntFamCol As Entity.Registro.FamiliarCol)
        Public Event _ClickModificar(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean)
#End Region
#Region "Propiedades"
        Public Property _IDInterno As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _IDIngreso As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwFamilia
                    If .Rows.Count Then
                        intValue = .SelectedRows(0).Cells("col_fam_id").Value
                    End If
                End With
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwFamilia
                    If .Rows.Count Then
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End If
                End With
                Return intValue
            End Get
        End Property


        Private ReadOnly Property GrillaIDIngreso() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwFamilia
                    If .Rows.Count Then
                        intValue = .SelectedRows(0).Cells("col_num_ing_id").Value
                    End If
                End With
                Return intValue
            End Get
        End Property
        Private Property InternoNHijos() As Integer
            Get
                Dim intValue As Integer = 0

                If IsNumeric(Me.txtNumHijos.Text) = True Then
                    intValue = Integer.Parse(Me.txtNumHijos.Text)
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Me.txtNumHijos.Text = value.ToString
            End Set
        End Property

        Private Property InternoNHijosMen18() As Integer
            Get
                Dim intValue As Integer = 0

                If IsNumeric(Me.txtNHijos.Text) = True Then
                    intValue = Integer.Parse(Me.txtNHijos.Text)
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Me.txtNHijos.Text = value.ToString
            End Set
        End Property
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
#Region "Listar"
        Public Sub _LoadUsc()

            If Me._IDInterno < 1 Then
                Exit Sub
            End If
            objBss = New Bussines.Registro.Familiar
            objEntCol = New Entity.Registro.FamiliarCol
            Dim objEntFiltro As New Entity.Registro.Familiar

            objEntFiltro.InternoID = Me._IDInterno
            objEntFiltro.IngresoInpeID = Me._IngresoInpeID
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.RegionLimaMetropolitana
                    objEntCol = (New Bussines.Registro.Familiar).Listar_grilla_LM(objEntFiltro, Me.TipoLicencia, "")
                Case enmTipoLicencia.Carceleta
                    'objEntFiltro.PenalID = Me._PenalID'debe listar todo sin filtro de penal
                    objEntCol = (New Bussines.Registro.Familiar).Listar_grilla_LM(objEntFiltro, Me.TipoLicencia, "")
                Case enmTipoLicencia.PenalLimaMetropolitana
                    'objEntFiltro.PenalID = Me._PenalID 'por artificio sin filtro de penal
                    objEntCol = (New Bussines.Registro.Familiar).Listar_grilla_LM(objEntFiltro, Me.TipoLicencia, "")
                Case Else
                    objEntFiltro.IngresoInpeID = -1
                    objEntFiltro.IngresoID = Me._IDIngreso
                    objEntCol = objBss.Listar(objEntFiltro)
            End Select

            With Me.dgwFamilia
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

            ListarHijos()

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                    col_ing_nro_inpe.Visible = True
                    col_num_ing.Visible = False
                Case Else
                    col_num_ing.Visible = True
                    col_ing_nro_inpe.Visible = False
            End Select
        End Sub

        Private Sub ListarHijos()

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            Dim Contahijos As Integer = 0
            Dim ContaMenor As Integer = 0
            Dim dteFechaMay18 As Date = DateAdd(DateInterval.Year, -18, Now)
            For Each obj As Entity.Registro.Familiar In objEntCol

                If obj.FamiliarTipoID = 4 Then 'hijo
                    Dim dteFechaNac As Date = Legolas.Components.FechaHora.FechaDate(obj.FechaNacimiento, False)
                    Contahijos = Contahijos + 1
                    If obj.FechaNacimiento > 0 Then
                        If dteFechaNac > dteFechaMay18 Then
                            ContaMenor = ContaMenor + 1
                        End If
                    End If
                End If

            Next

            Me.InternoNHijos = Contahijos
            Me.InternoNHijosMen18 = ContaMenor

        End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()
            Me.pnlAliasAdd.Visible = Me._VisibleGrabar
            Me.pnlAliasEliminar.Visible = Me._VisibleEliminar
        End Sub
#End Region

        Private Sub dgwAlias_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs, objFamCol As Entity.Registro.FamiliarCol)
            If Me.dgwFamilia.RowCount > 0 Then
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me._PenalID Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If

                RaiseEvent _CellDoubleClick(Me.GrillaCodigo, objFamCol, regForzarSoloLectura)
            End If
        End Sub

        Private Sub AEliminar()
            If Me.dgwFamilia.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If
            If Me.GrillaPenalId <> Me._PenalID Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación restringida, el registro es de solo lectura")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then
                objBss = New Bussines.Registro.Familiar
                'If Me.TipoLicencia = enmTipoLicencia.Carceleta Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana And Me.TipoLicencia=enmTipoLicencia.RegionLimaMetropolitana  Then
                '    objBss.Eliminar_LM(Me.GrillaCodigo)
                'Else
                objBss.Eliminar(Me.GrillaCodigo)
                    'End If

                    _LoadUsc()
            End If
        End Sub

        Private Sub btnAddAlias_Click(sender As System.Object, e As System.EventArgs) Handles btnAddFamilia.Click
            RaiseEvent _ClickAdd(objEntCol)
        End Sub

        Private Sub dgwFamilia_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwFamilia.CellDoubleClick
            btnModFamilia_Click(sender, e)
        End Sub

        Private Sub btnEliFamilia_Click(sender As System.Object, e As System.EventArgs) Handles btnEliFamilia.Click
            AEliminar()
        End Sub

        Private Sub dgwFamilia_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwFamilia.KeyDown
            If e.KeyCode = Keys.Delete Then AEliminar()
        End Sub

        Private Sub btnModFamilia_Click(sender As System.Object, e As System.EventArgs) Handles btnModFamilia.Click
            If dgwFamilia.Rows.Count > 0 Then
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me._PenalID Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If
                RaiseEvent _ClickModificar(Me.GrillaCodigo, objEntCol, regForzarSoloLectura)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            End If
        End Sub

    End Class
End Namespace
