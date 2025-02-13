Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion.v5
    Public Class UserBandas_LM
        Public Event _ClikBandas(Nuevo As Boolean, BandaID As Integer, n_IngresoInpeId As Integer, objEntColBandas_ As Entity.Registro.InternoBandaCol)
        Public Event _DoubleClikBandas(Nuevo As Integer, AliasID As Integer, n_IngresoInpeId As Integer, objEntColBandas_ As Entity.Registro.InternoBandaCol, forzarRegistroSoloLectura As Boolean)
        Dim objEntColBandas As New Entity.Registro.InternoBandaCol
#Region "Propiedades_Publicas"
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property InternoID As Integer = -1
        Public Property IngresoInpeID As Integer = -1
        Public Property IngresoId As Integer = -1
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwMovbandas
                    If .Rows.Count > 0 Then
                        intValue = .SelectedRows(0).Cells("col_mov_ban_id").Value
                    End If
                End With
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIngreso() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwMovbandas
                    If .Rows.Count > 0 Then
                        intValue = .SelectedRows(0).Cells("col_ing_id").Value
                    End If
                End With
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwMovbandas
                    If .Rows.Count > 0 Then
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

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Registro.InternoBanda
            objEntColBandas = New Entity.Registro.InternoBandaCol
            Dim objEntBandas As New Entity.Registro.InternoBanda
            objEntBandas.InternoID = Me.InternoID
            objEntBandas.IngresoInpeID = Me.IngresoInpeID
            Select Case Me.TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    objEntBandas.PenalID = -1 'Me.PenalID
            End Select

            objEntColBandas = objBss.Listar_Grilla_LM(objEntBandas, Me.TipoLicencia)
            With Me.dgwMovbandas
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntColBandas
            End With
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana
                    col_ing_inpe_nro.Visible = True
                    col_ing_nro.Visible = False
                Case enmTipoLicencia.PenalLimaMetropolitana
                    col_ing_nro.Visible = False
                    col_ing_inpe_nro.Visible = True
                Case Else
                    col_ing_nro.Visible = True
                    col_ing_inpe_nro.Visible = False
            End Select
        End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()

            Me.pnlBandaAdd.Visible = Me._VisibleGrabar
            Me.pnlBandasEliminar.Visible = Me._VisibleEliminar
        End Sub
#End Region


        Private Sub dgwAlias_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovbandas.CellDoubleClick
            If Me.dgwMovbandas.RowCount > 0 Then
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me.PenalID Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If

                RaiseEvent _DoubleClikBandas(False, Me.GrillaCodigo, Me.GrillaIngreso, objEntColBandas, regForzarSoloLectura)
            End If
        End Sub

        Private Sub AEliminarMovBandas()

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If
            If Me.GrillaPenalId <> Me.PenalID Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación restringida, el registro es de solo lectura")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Dim objBss As New Bussines.Registro.InternoBanda
                Dim intValue As Integer = -1

                objBss.Eliminar(Me.GrillaCodigo)
                _Load()
            End If
        End Sub

        Private Sub dgwAlias_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwMovbandas.KeyDown
            If e.KeyCode = Keys.Delete Then
                btnEliAlias_Click(sender, e)
            End If
        End Sub

        Private Sub btnModAlias_Click(sender As System.Object, e As System.EventArgs) Handles btnModBanda.Click
            If dgwMovbandas.Rows.Count > 0 Then
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me.PenalID Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If

                RaiseEvent _DoubleClikBandas(False, Me.GrillaCodigo, Me.GrillaIngreso, objEntColBandas, regForzarSoloLectura)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                Exit Sub
            End If
        End Sub

        Private Sub btnAddAlias_Click(sender As System.Object, e As System.EventArgs) Handles btnAddBanda.Click
            RaiseEvent _ClikBandas(True, -1, -1, objEntColBandas)
        End Sub

        Private Sub btnEliAlias_Click(sender As System.Object, e As System.EventArgs) Handles btnEliBanda.Click
            If dgwMovbandas.Rows.Count > 0 Then
                AEliminarMovBandas()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If
        End Sub
    End Class
End Namespace