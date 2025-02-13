Imports Bussines.Registro
Imports Bussines.Registro.Integracion
Imports System.Linq
Namespace Registro.Expediente.v5
    Public Class frmListarlibertad
        Private objBss As Bussines.Registro.Expediente = Nothing
        Private objBssPad As Bussines.Registro.InternoExpedientePadre = Nothing
        Private objEnt As Entity.Registro.Expediente = Nothing
        Private objEntExpediente As Entity.Registro.Documento.DocumentoJudicialExpediente
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntPeriodoCondenaTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
        Private objEntDelitoCol As Entity.Registro.DelitoCol
        Private objEntAgraviadoCol As Entity.Registro.AgraviadoCol




#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _IngresoID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _TemporalNuevo As Boolean = False
        Public Property _NuevoExpediente As Boolean = False
        Public Property _SituacionJuridicaExpe As Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
        Public Property _TipoResolucion As Integer = -1

        Public ReadOnly Property _GrillaExpedienteIdSeleccionado() As Integer
            Get

                Return Me.GrillaExpedienteId

            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteId() As Integer
            Get
                Try
                    Return dgwExpediente2.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
#End Region
#Region "Variables_Temporales"

        Public _LibertadTipoID As Integer = -1
        Public _LibertadTipoNom As String = ""
        Public _SubLibertadTipoStrID As String = ""
        Public _SubLibertadTipoID As Integer = -1
        Public _SubLibertadTipoNom As String = ""
        Public _InimputableInterno As Integer = -1
#End Region
#Region "Propiedades_Publicas"
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
        Public Property _GrillaSeleccionMultiple As Boolean = True
        Public Event _Click_EnviarColection(EntExpCol As Entity.Registro.ExpedienteCol)
#End Region
#Region "Propiedades_Expediente"
        Public Property _TipoAutJudicial() As Integer = -1
        Public Property DocJudicialID As Integer = -1
#End Region

#Region "Listar"

        Dim LiscadenaCol As New Entity.General.ParametricaCol

        Public Sub _ListarLibertades()
            Dim Condicion1 As Integer = -1
            'VALIDAR SI ES INIMPUTABLES
            If Me._InimputableInterno = 178 Then
                Condicion1 = 178
            End If

            objCol = bss.Listar(Type.Combo.ComboTipo.MovimientoMotivo, Type.Enumeracion.Movimiento.EnumMovTipo.Libertad, Condicion1, -1, False, "")
            If Me.DocJudicialID > 0 And (Me._LibertadTipoID = 13 Or Me._LibertadTipoID = 14 Or Me._LibertadTipoID = 160) Then
            Else
                Dim objAuxCol As New Entity.General.ParametricaCol
                For Each obj As Entity.General.Parametrica In objCol
                    Select Case obj.Codigo
                        Case 136, 166, 137, 167, 168
                        Case Else
                            objAuxCol.Add(obj)
                    End Select
                Next
                objCol = objAuxCol
            End If
            Select Case Me._LibertadTipoID
                Case 13, 14, 160
                    dgwSublibertad.Visible = True
                    Me.Size = New Size(350, 312)
                Case Else
                    dgwSublibertad.Visible = False
                    Me.Size = New Size(310, 312)
            End Select
            With Me.dgwExpediente2
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objCol
                .Refresh()
            End With

            For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
                If dgwExpediente2.Rows(i).Cells("col_cod_lib").Value = Me._LibertadTipoID Then

                    dgwExpediente2.Rows(i).Selected = True
                    dgwExpediente2.Focus()
                    Select Case Me._LibertadTipoID
                        Case 13, 14, 160
                            dgwSublibertad.Visible = True
                            Me.Size = New Size(350, 312)
                        Case Else
                            dgwSublibertad.Visible = False
                            Me.Size = New Size(310, 312)
                    End Select
                    DesplazarDatagriew()
                    dgwExpediente2_CellClick(Nothing, Nothing)
                    Exit Sub
                Else
                    dgwExpediente2.Rows(0).Selected = False
                    'Me.dgwSublibertad.Visible = False
                    'Me.Size = New Size(310, 312)
                End If
            Next
        End Sub

        Private Sub _ListarSublibertades()
            objSubCol = bss.Listar(Type.Combo.ComboTipo.TipoAclaratoriaExpediente, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad, -1, -1, False, "")
            Dim objCol As New Entity.General.ParametricaCol
            Dim bln As Boolean = False
            For Each obj As Entity.General.Parametrica In objSubCol
                If dgwExpediente2.SelectedRows(0).Cells("col_cod_lib").Value = 160 Then
                    If obj.Codigo <> 108 Then
                        objCol.Add(obj)
                        bln = True
                    End If
                End If
            Next
            If bln = True Then
                objSubCol = objCol
                bln = False
            End If
            objSubCol = OrdenarCol(objSubCol)

            With dgwSublibertad

                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objSubCol
                .Refresh()

                .Columns("col_lib_ele").Width = 25
                .Columns(0).ReadOnly = False
                .Columns(2).ReadOnly = True
            End With
            If Me._SubLibertadTipoStrID.Length = 0 Then Exit Sub
            Dim cadenaCol() As String = Me._SubLibertadTipoStrID.Split("|"c)
            Dim objcadena As New Entity.General.Parametrica
            For i As Integer = 0 To dgwSublibertad.Rows.Count - 1
                For Each var As String In cadenaCol
                    If dgwSublibertad.Item("col_lib_sub_tip_id", i).Value = CInt(var) Then
                        dgwSublibertad.Item("col_lib_ele", i).Value = True
                        objcadena = New Entity.General.Parametrica
                        objcadena.Codigo = CInt(var)
                        objcadena.Nombre = dgwSublibertad.Item("col_nom", i).Value
                        LiscadenaCol.Add(objcadena)
                    End If
                Next
            Next
        End Sub

#End Region
#Region "Accion"

        Private Sub AGrabar()
            If Validar(-1) = True Then
                Exit Sub
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Dim ValorInt As Integer = 0
        Dim objDocumJudicial_copia As New Entity.Registro.DocumentoJudicialCol

        Public Function Validar(IdExpe) As Boolean
            Dim blnValor As Boolean = False
            Dim conta1 As Integer = 0
            Dim conta2 As Integer = 0
            Dim conVig As Integer = 0
            For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
                If dgwExpediente2.Item("colu_eleg", i).Selected = True Then
                    Me._LibertadTipoID = dgwExpediente2.Item("col_cod_lib", i).Value
                    Me._LibertadTipoNom = dgwExpediente2.Item("col_nom_lib", i).Value
                    blnValor = True
                    If dgwSublibertad.Visible = True Then
                        For j As Integer = 0 To dgwSublibertad.Rows.Count - 1
                            Dim abc As String = dgwSublibertad.Item("col_nom", j).Value
                            If dgwSublibertad.Item("col_lib_ele", j).Value = True Then
                                If dgwSublibertad.Item("col_lib_sub_tip_id", j).Value = 104 Then
                                    conta1 += 1
                                ElseIf dgwSublibertad.Item("col_lib_sub_tip_id", j).Value = 108 Then
                                    conVig += 1
                                Else
                                    conta2 += 1
                                End If
                            End If
                        Next
                        If conta1 = 0 And conta2 = 0 And conVig = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Information("Debe seleccionar un registro de sublibertad")
                            Return blnValor
                            dgwSublibertad.Focus()
                        End If
                        If conta1 = 1 And conta2 > 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Information("El suptipo [Común] no puede ser registrado con un D. Leg.")
                            Return blnValor
                            dgwSublibertad.Focus()
                        End If
                        If conVig = 1 And conta1 = 0 And conta2 = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Information("La [Vigilancia electronica personal] no puede ser registrado de forma independiente.")
                            Return blnValor
                            dgwSublibertad.Focus()
                        End If
                        Dim valida As Boolean = False
                        For k As Integer = 0 To dgwSublibertad.Rows.Count - 1
                            If dgwSublibertad.Item("col_lib_ele", k).Value = True Then
                                objSub = New Entity.General.Parametrica
                                objSub.Codigo = dgwSublibertad.Item("col_lib_sub_tip_id", k).Value
                                objSub.Nombre = dgwSublibertad.Item("col_nom", k).Value
                                objSub.estado = 1
                                objetoSubCol.Add(objSub)
                            Else
                                'For Each var As Entity.General.Parametrica In LiscadenaCol
                                '    If dgwSublibertad.Item("col_lib_sub_tip_id", k).Value = var.Codigo Then
                                '        valida = True
                                '        Exit For
                                '    End If
                                'Next
                                'If valida = True Then
                                '    objSub = New Entity.General.Parametrica
                                '    objSub.Codigo = dgwSublibertad.Item("col_lib_sub_tip_id", k).Value
                                '    objSub.Nombre = dgwSublibertad.Item("col_nom", k).Value
                                '    objSub.estado = 0
                                '    objetoSubCol.Add(objSub)
                                '    valida = False
                                'End If
                            End If
                        Next
                    End If
                    Exit Function
                Else
                    blnValor = False
                End If
            Next

            If blnValor = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("Debe seleccionar un registro de libertad")
                dgwExpediente2.Focus()
            End If
            Return blnValor
        End Function
        Private Sub DesplazarDatagriew()
            Dim fila_seleccionada As Int32 = Me.dgwExpediente2.SelectedRows(0).Index
            Me.dgwExpediente2.FirstDisplayedScrollingRowIndex = fila_seleccionada
        End Sub
        Private Function OrdenarCol(list As Entity.General.ParametricaCol) As Entity.General.ParametricaCol
            Dim objCol As New Entity.General.ParametricaCol
            'For Each o As Entity.General.Parametrica In list
            '    Select Case o.Codigo
            '        Case 104
            '    End Select
            'Next
            Dim result = From d As Entity.General.Parametrica In list Order By d.Codigo  ' d.FechaDocLong

            For Each obj As Entity.General.Parametrica In result
                objCol.Add(obj)
            Next

            Return objCol
        End Function
#End Region
#Region "Permisos"
        Private Sub ShowControl()
            Me.btnOk.Visible = Me._VisibleGrabar
        End Sub
#End Region
#Region "Otros"
        Dim bss As New Bussines.General.Parametrica
        Dim objCol As New Entity.General.ParametricaCol
        Public objSubCol As New Entity.General.ParametricaCol
        Public objetoSubCol As New Entity.General.ParametricaCol
        Public objetoEliSubCol As New Entity.General.ParametricaCol
        Dim objSub As New Entity.General.Parametrica
        Private Sub ValoresxDefault()
            _ListarLibertades()
            '_ListarSublibertades()
        End Sub
        Private Sub EvaluarClick()
            'For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
            Dim intPos As Integer = -1
            intPos = dgwExpediente2.Columns("colu_eleg").Index
            If dgwExpediente2.Item("colu_eleg", intPos).Value = True Then
                For i As Integer = 0 To dgwExpediente2.Rows.Count - 1
                    If i <> intPos Then
                        dgwExpediente2.Item("colu_eleg", intPos).Value = False
                    End If
                Next
            End If
            'Next
        End Sub
#End Region

        Private Sub frmExpedientePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmExpedientePopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'Me.Size = New Size(253, 312)
            'Me.dgwSublibertad.Visible = False
            'CargarSublibertad()
        End Sub


        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub dgwExpediente2_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente2.CellContentClick

            'If dgwExpediente2.Columns("colu_sele").Visible = True And dgwExpediente2.Columns("colu_sele").Index = e.ColumnIndex Then
            For i As Integer = 0 To dgwExpediente2.Rows.Count - 1 'obligar a marcar check a un solo registro (emular radio button)
                If i <> dgwExpediente2.CurrentCell.RowIndex Then
                    dgwExpediente2.Item("colu_eleg", i).Value = False
                End If
            Next
            Select Case dgwExpediente2.SelectedRows(0).Cells("col_cod_lib").Value
                Case 13, 14, 160 ' Liberacion condicional
                    Me.dgwSublibertad.Visible = True
                    Me.Size = New Size(340, 312)
                    If dgwExpediente2.SelectedRows(0).Cells("col_cod_lib").Value <> Me._LibertadTipoID Then
                        For i As Integer = 0 To dgwSublibertad.Rows.Count - 1
                            dgwSublibertad.Item("col_lib_ele", i).Value = False
                        Next
                    End If
                    _ListarSublibertades()
                Case Else
                    Me.dgwSublibertad.Visible = False
                    Me.Size = New Size(310, 312)
            End Select
        End Sub

        Private Sub dgwExpediente2_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            AGrabar()
        End Sub

        Private Sub dgwExpediente2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwExpediente2.CellClick
            For i As Integer = 0 To dgwExpediente2.Rows.Count - 1 'obligar a marcar check a un solo registro (emular radio button)
                If i <> dgwExpediente2.CurrentCell.RowIndex Then
                    dgwExpediente2.Item("colu_eleg", i).Value = False
                End If
            Next
            Select Case dgwExpediente2.SelectedRows(0).Cells("col_cod_lib").Value
                Case 13, 14, 160 ' Liberacion condicional
                    Me.dgwSublibertad.Visible = True
                    Me.Size = New Size(340, 312)
                    If dgwExpediente2.SelectedRows(0).Cells("col_cod_lib").Value <> Me._LibertadTipoID Then
                        For i As Integer = 0 To dgwSublibertad.Rows.Count - 1
                            dgwSublibertad.Item("col_lib_ele", i).Value = False
                        Next
                    End If
                    _ListarSublibertades()
                Case Else
                    Me.dgwSublibertad.Visible = False
                    Me.Size = New Size(310, 312)
            End Select
        End Sub

        Private Sub dgwExpediente2_KeyUp(sender As Object, e As KeyEventArgs) Handles dgwExpediente2.KeyUp
            dgwExpediente2_CellClick(Nothing, Nothing)
        End Sub
    End Class
End Namespace
