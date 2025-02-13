Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion.v5
    Public Class uscAlias2
        Public Event _ClickAdd()
        Public Event _ClickMod(AliasID As Integer, IngresoID As Integer, forzarRegistroSoloLectura As Boolean)
        Public Event _DoubleClick(AliasID As Integer, IngresoID As Integer, forzarRegistroSoloLectura As Boolean)

        Private objEntColAlias As New Entity.Registro.InternoAliasCol
#Region "Propiedades_Pub"
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property InternoID As Integer = -1
        Public Property IngresoID As Integer = -1
        Public Property IngresoInpeID As Integer = -1
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaAliasCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwAlias
                    If .Rows.Count Then
                        intValue = .SelectedRows(0).Cells("col_ali_id").Value
                    End If
                End With
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaAliasIngreso() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwAlias
                    If .Rows.Count Then
                        intValue = .SelectedRows(0).Cells("col_ing_id").Value
                    End If
                End With
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwAlias
                    If .Rows.Count Then
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End If
                End With
                Return intValue
            End Get
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
        Public Sub _Load()
            If Me.InternoID < 1 Then Exit Sub

            Select Case Me.TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    col_ing_nro_inpe.Visible = True
                    col_ing_nro.Visible = False
                Case Else
                    col_ing_nro.Visible = True
                    col_ing_nro_inpe.Visible = False
            End Select

            If Not (Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
               Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If Me._IngresoID <= 0 Then Exit Sub
            End If

            Dim objBss As New Bussines.Registro.InternoAlias
            objEntColAlias = New Entity.Registro.InternoAliasCol
            Dim objEntCol = New Entity.EntityCol(Of Entity.Registro.InternoAlias)
            Dim objEntAlias As New Entity.Registro.InternoAlias

            objEntAlias.InternoID = Me.InternoID
            objEntAlias.IngresoInpeId = Me.IngresoInpeID

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta
                    'objEntAlias.PenalID = Me.PenalID
                    objEntCol = objBss.Listar_Grilla_LM(objEntAlias, Me.TipoLicencia)
                    With Me.dgwAlias
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = objEntCol
                    End With
                Case enmTipoLicencia.PenalLimaMetropolitana
                    objEntAlias.PenalID = -1 ' Me.PenalID
                    objEntCol = objBss.Listar_Grilla_LM(objEntAlias, Me.TipoLicencia)
                    With Me.dgwAlias
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = objEntCol
                    End With
                Case enmTipoLicencia.RegionLimaMetropolitana

                    objEntCol = objBss.Listar_Grilla_LM(objEntAlias, Me.TipoLicencia)
                    With Me.dgwAlias
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = objEntCol
                    End With
                Case Else
                    objEntAlias.IngresoID = Me.IngresoID
                    objEntAlias.IngresoInpeId = -1
                    objEntColAlias = objBss.Listar2(objEntAlias)
                    With Me.dgwAlias
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False

                        .DataSource = objEntColAlias
                    End With
            End Select

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
               Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then

            ElseIf Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then

            Else

            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()

            Me.pnlAliasAdd.Visible = Me._VisibleGrabar
            Me.pnlAliasEliminar.Visible = Me._VisibleEliminar

        End Sub
#End Region

        Private Sub dgwAlias_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwAlias.CellDoubleClick
            If Me.dgwAlias.RowCount > 0 Then
                If (Me.TipoLicencia = enmTipoLicencia.Carceleta _
                   Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                   Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then

                    Dim regForzarSoloLectura As Boolean = False

                    If Me.GrillaPenalId <> Me.PenalID Then
                        regForzarSoloLectura = True
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                    End If

                    RaiseEvent _DoubleClick(Me.GrillaAliasCodigo, -1, regForzarSoloLectura)
                Else
                    RaiseEvent _DoubleClick(Me.GrillaAliasCodigo, Me.GrillaAliasIngreso, False)
                End If
            End If
        End Sub


        Private Sub AEliminarAlia()

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario no tiene permiso para realizar esta operación")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Dim objBss As New Bussines.Registro.InternoAlias

                objBss.Eliminar(Me.GrillaAliasCodigo)
                _Load()
            End If
        End Sub


        Private Sub dgwAlias_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwAlias.KeyDown
            If e.KeyCode = Keys.Delete Then
                btnEliAlias_Click(sender, e)
            End If
        End Sub

        Private Sub btnModAlias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModAlias.Click
            If dgwAlias.Rows.Count > 0 Then
                If (Me.TipoLicencia = enmTipoLicencia.Carceleta _
                   Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                   Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then

                    Dim regForzarSoloLectura As Boolean = False

                    If Me.GrillaPenalId <> Me.PenalID Then
                        regForzarSoloLectura = True
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                    End If
                    RaiseEvent _ClickMod(Me.GrillaAliasCodigo, -1, regForzarSoloLectura)
                Else
                    RaiseEvent _ClickMod(Me.GrillaAliasCodigo, Me.GrillaAliasIngreso, False)
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            End If
        End Sub

        Private Sub btnAddAlias_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAlias.Click
            RaiseEvent _ClickAdd()
        End Sub

        Private Sub btnEliAlias_Click(sender As System.Object, e As System.EventArgs) Handles btnEliAlias.Click
            If dgwAlias.Rows.Count > 0 Then
                If Me.GrillaPenalId <> Me.PenalID Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación restringida, el registro es de solo lectura")
                    Exit Sub
                End If
                AEliminarAlia()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
            End If
        End Sub
    End Class
End Namespace
