Namespace Visita
    Public Class frmVisitaSinSalidaPopup
        Private objBss As Bussines.Visita.Movimiento = Nothing
        Private objEntCol As Entity.Visita.MovimientoCol = Nothing
#Region "Propiedades_Parametricas"
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private blnBuscarAuto As Boolean = False
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set

        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Public Property _BuscarAuto() As Boolean
            Get
                Return blnBuscarAuto
            End Get
            Set(ByVal value As Boolean)
                blnBuscarAuto = value
            End Set
        End Property
        Public Property _Mensaje() As Boolean = False

#End Region
#Region "Propiedades"        
        Private Property FechaSalida() As Long=0            
        Private Property HoraSalida() As String = ""
        Private Property Observacion As String = ""
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCount() As Integer
            Get
                Dim intValue As Integer = -1
                intValue = Me.dgwGrilla.RowCount
                Return intValue
            End Get
        End Property
#End Region
#Region "Listar"        
     
        Private Function Listar() As Boolean

            objBss = New Bussines.Visita.Movimiento
            objEntCol = New Entity.Visita.MovimientoCol

            objEntCol = objBss.ListarVisitaFueraFecha(Me._RegionID, Me._PenalID)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

            Me.lblCantReg.Text = Me.GrillaCount & " Reg."

        End Function
        Private Sub Buscar()

            Listar()           

            If Me.GrillaCount < 1 Then

                If Me._Mensaje = True Then
                    Legolas.Configuration.Aplication.MessageBox.Information( _
                    "No existen registros pendientes sin salida")
                End If                
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Accion"
        Private Sub AGrabar()

            Dim intMov As Integer = -1

            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                If fila.Cells("col_chk").Value = True Then
                    intMov = fila.Cells("col_mov_id").Value
                    AGrabar(intMov)
                End If
            Next

            Buscar()

        End Sub

        Private Sub AGrabar(ByVal MovimientoID As Integer)

            Dim intIDUsuarioAutoriza As Integer = Legolas.Configuration.Usuario.Codigo
            Dim intTipoSalida As Short = 0 'salida masiva 
            objBss = New Bussines.Visita.Movimiento

            objBss.GrabarSalida_v3(MovimientoID, Me.FechaSalida, Me.HoraSalida, intIDUsuarioAutoriza, Me.Observacion, intTipoSalida, -1)

        End Sub
#End Region
#Region "Formulario"
        Private Sub FRMVisitaSalida()

            Dim intCount As Integer = 0
            Me.dgwGrilla.CurrentCell = Nothing

            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                If fila.Cells("col_chk").Value = True Then
                    intCount = intCount + 1
                End If
            Next

            If intCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "No ha seleccionado ningun movimiento, para registrar la salida")
                Exit Sub
            End If

            Dim blnGrabar As Boolean = False

            Dim frm As New Visita.frmVisitaSalidaPopup
            With frm
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.FechaSalida = ._FechaSalida
                    Me.HoraSalida = ._HoraSalida
                    Me.Observacion = ._Observacion
                    blnGrabar = True
                End If
            End With

            If blnGrabar = True Then

                If Legolas.Configuration.Aplication.MessageBox.Question( _
                    "Desea grabar la hora de salida a los registros seleccionados") = Windows.Forms.DialogResult.Yes Then
                    AGrabar()
                End If

            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permisos()

            Me.btnOk.Visible = Me._FormEscritura

        End Sub
        Private Sub Habilitar(ByVal vf As Boolean)

            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows
                fila.Cells("col_chk").Value = vf
            Next

        End Sub
        Private Sub ValoresxDefault()

            Usuario_Permisos()

        End Sub
#End Region

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then
                        .Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub frmVisitaSinSalidaPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            If Me._BuscarAuto = True Then
                Buscar()
            End If

        End Sub

        Private Sub chkTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodos.Click

            Me.Habilitar(Me.chkTodos.Checked)

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            FRMVisitaSalida()

        End Sub

        Private Sub frmVisitaSinSalidaPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()

        End Sub

        Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged

        End Sub
    End Class

End Namespace

