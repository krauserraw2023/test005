Imports Type.Enumeracion.Clasificacion

Namespace Registro.Carceleta.Clasificacion.Documento
    Public Class frmMantDocClasificacion
        Private bssDetDoc As Bussines.Clasificacion.Documento.DetDocClasificacion_BL
        Private entDetDoc As Entity.Clasificacion.Documento.DetDocClasificacionCol

#Region "Propiedades publicas"
        Public Property _Codigo As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property _RegionId As Integer = -1
        Public Property _PenalNombre As String = ""
        Public Property _RegionNombre As String = ""
        Public ReadOnly Property RegionPenalNombre() As String
            Get
                Dim value As String = ""
                value = Me._RegionNombre & "-" & Me._PenalNombre
                Return value
            End Get
        End Property
#End Region

#Region "Propiedad privada"
        Private Property GlosaId()
            Get
                Return cboGlosa.SelectedValue
            End Get
            Set(value)
                cboGlosa.SelectedValue = value
            End Set
        End Property

        Private Property Anio As Integer
            Get
                Return Val(txtAnio.Text) 'Integer.Parse(txtAnio.Text)
            End Get
            Set(value As Integer)
                txtAnio.Text = value
            End Set
        End Property

        Private Property CorrelativoDoc As Integer
            Get
                Return Val(txtSerie.Text)
            End Get
            Set(value As Integer)
                txtSerie.Text = Format(value, "00000")
            End Set
        End Property

        Private Property NumDoc As String
            Get
                Return txtNumDoc.Text
            End Get
            Set(value As String)
                txtNumDoc.Text = value
            End Set
        End Property

        Private Property FechaClasificacion As Long
            Get
                Return dtpFechaEmision.ValueLong
            End Get
            Set(value As Long)
                dtpFechaEmision.ValueLong = value
            End Set
        End Property

        Private Property EstadoTramiteDoc As Integer
            Get
                Try
                    Return Me.cboEstado.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cboEstado.SelectedValue = value
            End Set
        End Property

        Private Property Observacion As String
            Get
                Return txtObvs.Text
            End Get
            Set(value As String)
                txtObvs.Text = value
            End Set
        End Property

        Private Property Destinatario() As String
            Get
                Return txtDestinatarioDoc.Text
            End Get
            Set(value As String)
                txtDestinatarioDoc.Text = value
            End Set
        End Property
#End Region

#Region "Grilla detalle"
        Private ReadOnly Property DetGrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgvDetalle
                        intValue = .SelectedRows(0).Cells("col_det_codigo").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region

#Region "Grilla internos clasificados"
        Private ReadOnly Property GrillaIntClasCodigo
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = Me.dgvInternosClasificados.SelectedRows(0).Cells("col_sel_codigo").Value
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region

#Region "Combo"
        Private Sub ComboEstadoTramite()
            With Me.cboEstado
                .LoadUsc()
            End With
        End Sub

        Private Sub ComboGlosa()
            cboGlosa.DataSource = (New Bussines.Globall.GlosaDocumento).Listar(Type.Enumeracion.TipoGlosa.ConsolidadoDocClasificacion)
            cboGlosa.ValueMember = "Codigo"
            cboGlosa.DisplayMember = "CodigoString"
        End Sub
#End Region

#Region "Listar"
        Private Sub ListarData()
            If Me._Codigo = -1 Then
                Me.EstadoTramiteDoc = -1
                Me.FechaClasificacion = Now.ToFileTime
                If cboGlosa.Items.Count > 1 Then
                    cboGlosa.SelectedValue = -1
                Else
                    cboGlosa.SelectedIndex = 0
                End If
                Me.Anio = Now.Year
                Me.CorrelativoDoc = (New Bussines.Clasificacion.Documento.DocClasificacion_BL).UltimoCorrelativoDoc(Me.Anio) + 1
            Else
                Dim ent As Entity.Clasificacion.Documento.DocClasificacion
                ent = (New Bussines.Clasificacion.Documento.DocClasificacion_BL).Listar(Me._Codigo)
                Me.Anio = ent.AnioDoc
                Me.CorrelativoDoc = ent.CorrelativoDoc
                Me.NumDoc = ent.NumeroDoc
                Me.FechaClasificacion = ent.FechaEmision
                Me.EstadoTramiteDoc = ent.EstadoDocId
                Me.Observacion = ent.Observacion
                Me._PenalId = ent.PenalId
                Me._PenalNombre = ent.PenalNombre
                Me._RegionId = ent.RegionId
                Me._RegionNombre = ent.RegionNombre
                Me.Destinatario = ent.NombreDestinoDoc
                Me.GlosaId = ent.GlosaDocId
                Dim det As New Entity.Clasificacion.Documento.DetDocClasificacion
                det.DocClasificacionId = Me._Codigo
                entDetDoc = (New Bussines.Clasificacion.Documento.DetDocClasificacion_BL).Listar(det)
                dgvDetalle.DataSource = entDetDoc.DataSource
            End If
            Me.txtRegionPenal.Text = Me.RegionPenalNombre
        End Sub

        Private Sub RefreshGrillaDetalle()
            Dim tmpCol As New Entity.Clasificacion.Documento.DetDocClasificacionCol
            For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In entDetDoc
                If obj.OBJ_ELIMINADO = False Then tmpCol.Add(obj)
            Next

            dgvDetalle.DataSource = tmpCol.DataSource
        End Sub
#End Region

#Region "Accion"
        Private Function Grabar() As Boolean
            Dim entDocCl As New Entity.Clasificacion.Documento.DocClasificacion

            bssDetDoc = New Bussines.Clasificacion.Documento.DetDocClasificacion_BL

            Dim outSms As String = ""
            Dim v As Boolean = True

            'validar
            If Me.FechaClasificacion > Now.ToFileTime Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("La fecha no puede ser futura.")
                Return False
            End If

            If Me.GlosaId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Seleccione una glosa")
                Return False
            End If
            If txtNumDoc.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ingrese número de documento" & outSms)
                Return False
            End If
            If Me._Codigo > 0 Then
                entDocCl = (New Bussines.Clasificacion.Documento.DocClasificacion_BL).Listar(Me._Codigo)
            Else
                entDocCl.Codigo = -1
                entDocCl.RegionId = Me._RegionId
                entDocCl.PenalId = Me._PenalId
            End If

            With entDocCl
                .AnioDoc = Me.Anio
                .CorrelativoDoc = Me.CorrelativoDoc
                .NumeroDoc = Me.NumDoc.ToUpper
                .Observacion = Me.Observacion
                .FechaEmision = Me.FechaClasificacion
                .EstadoDocId = Me.EstadoTramiteDoc
                .GlosaDocId = Me.GlosaId
                .NombreDestinoDoc = Me.Destinatario
            End With

            Dim id As Integer

            id = (New Bussines.Clasificacion.Documento.DocClasificacion_BL).Grabar(entDocCl, outSms)

            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Error, No se pudo guardar el registro " & outSms)
                Return False
            End If

            '------------------- grabar detalle ----------------------
            For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In entDetDoc
                If obj.Codigo < 0 Then 'insertar 
                    obj.DocClasificacionId = id
                    If obj.OBJ_ELIMINADO = False Then bssDetDoc.Grabar(obj, "")
                Else 'modificar
                    If obj.OBJ_ELIMINADO = True Then bssDetDoc.Eliminar(obj.Codigo, "")
                End If
            Next
            Return v
        End Function

        Private Function AgregarDetalle(indiceFila As Integer) As Boolean
            Select Case Me.EstadoTramiteDoc
                Case Type.Enumeracion.Clasificacion.enmEstadoTramiteDoc.Anulado
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible agregar internos en un documento anulado.")
                    Exit Function
                Case Type.Enumeracion.Clasificacion.enmEstadoTramiteDoc.Derivado
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible agregar internos en un documento derivado.")
                    Exit Function
            End Select

            Dim detEnt As New Entity.Clasificacion.Documento.DetDocClasificacion
            Dim ent As New Entity.Clasificacion.InternoClasificacion.InternoFicha

            ent.Codigo = dgvInternosClasificados.Item("col_sel_codigo", indiceFila).Value
            ent = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).ListarGrilla(ent).InternoClasificacion(0)

            With detEnt
                .InternoFichaId = ent.Codigo
                .CodigoInterno = ent.InternoCodigo
                .InternoId = ent.InternoId
                .FechaClasificacion = ent.FechaClasificacion
                .ApeMatInterno = ent.InternoApeMat
                .ApePatInterno = ent.InternoApePat
                .NomInterno = ent.InternoNombres
                .NumIngreso = ent.InternoIngresoNro
                .RegionId = ent.RegionId
                .PenalId = ent.PenalId
                .PenalDestinoNombre = ent.PenalDestinoNombre
            End With

            Dim enc As Boolean = False

            For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In entDetDoc
                If ent.Codigo = obj.InternoFichaId Then
                    enc = True
                    obj.OBJ_ELIMINADO = False
                    Exit For
                End If
            Next

            If enc = False Then entDetDoc.Add(detEnt)

            RefreshGrillaDetalle()
            RefreshGrillaInternosPendientes()

            Return True

        End Function
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()
            ComboEstadoTramite()
            ComboGlosa()
            dgvInternosClasificados.AutoGenerateColumns = False
            dgvDetalle.AutoGenerateColumns = False
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.TRA_ASI_MOV_DOCUMENTO)
            btnOk.Visible = Me._FormEscritura
            col_del.Visible = Me._FormEscritura
            col_sel.Visible = Me._FormEscritura
        End Sub

        Private Sub QuitarInternoClasificado()
            Select Case Me.EstadoTramiteDoc
                Case Type.Enumeracion.Clasificacion.enmEstadoTramiteDoc.Anulado
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible alterar el documento anulado.")
                    Exit Sub
                Case Type.Enumeracion.Clasificacion.enmEstadoTramiteDoc.Derivado
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible alterar un documento en estado derivado.")
                    Exit Sub
            End Select

            If dgvDetalle.Rows.Count = 0 Then Exit Sub ' Return False

            If Legolas.Configuration.Aplication.MessageBox.Question("Está seguro de quitar al interno seleccionado?") = DialogResult.Yes Then
                For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In entDetDoc
                    If obj.ID_CLASS = dgvDetalle.Item("col_id_class", dgvDetalle.CurrentRow.Index).Value Then
                        obj.OBJ_ELIMINADO = True
                        Exit For
                    End If
                Next
            End If

            RefreshGrillaDetalle()
            RefreshGrillaInternosPendientes()
        End Sub
        Private Sub RefreshGrillaInternosPendientes()
            Dim ent As New Entity.Clasificacion.InternoClasificacion.InternoFicha
            Dim colFicInt As New Entity.Clasificacion.InternoClasificacion.InternoFichaCol

            ent.TipoFichaId = Type.Enumeracion.Clasificacion.enmTipoFicha.Final
            colFicInt = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).ListarInternoSinDocClasificacion(ent) 'cargar internos pendientes de clasificar

            If Me._Codigo > 0 Then 'solo en caso que se modifique el registro
                For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In entDetDoc
                    With obj
                        If .OBJ_ELIMINADO = True Then

                            Dim entIntFic As New Entity.Clasificacion.InternoClasificacion.InternoFicha
                            Dim cod As Integer = .InternoFichaId

                            entIntFic = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).Listar_V2(cod)
                            entIntFic.InternoNombres = .NomInterno
                            entIntFic.InternoApePat = .ApePatInterno
                            entIntFic.InternoApeMat = .ApeMatInterno
                            entIntFic.PenalDestinoNombre = .PenalDestinoNombre
                            entIntFic.InternoCodigo = .CodigoInterno
                            entIntFic.InternoIngresoNro = .NumIngreso

                            Dim yaExiste As Boolean = False

                            For Each o As Entity.Clasificacion.InternoClasificacion.InternoFicha In colFicInt
                                If o.Codigo = .InternoFichaId Then
                                    yaExiste = True : Exit For
                                End If
                            Next

                            If yaExiste = False Then colFicInt.Add(entIntFic)

                        End If
                    End With
                Next
                colFicInt.Sort("PenalDestinoNombre")
            End If

            dgvInternosClasificados.DataSource = colFicInt

            'ocultar en laa grilla los duplicados para no ser agregados nuevamente
            dgvInternosClasificados.CurrentCell = Nothing 'artificio para no generar excepcion
            For i As Integer = 0 To dgvInternosClasificados.Rows.Count - 1
                For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In entDetDoc
                    If dgvInternosClasificados.Item("col_sel_codigo", i).Value = obj.InternoFichaId And obj.OBJ_ELIMINADO = False Then dgvInternosClasificados.Rows(i).Visible = False
                Next
            Next
        End Sub
#End Region

#Region "Evento forms"
        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmMantDocClasificacion_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            entDetDoc = New Entity.Clasificacion.Documento.DetDocClasificacionCol
            ValoresxDefault()
            ListarData()

            If Me._Codigo = -1 Then Me.EstadoTramiteDoc = enmEstadoTramiteDoc.Pendiente
            If Me.EstadoTramiteDoc = enmEstadoTramiteDoc.Anulado Or Me.EstadoTramiteDoc = enmEstadoTramiteDoc.Derivado Then btnOk.Enabled = False

            If Me.EstadoTramiteDoc = enmEstadoTramiteDoc.Derivado Then
                Panel5.Visible = False
            Else
                RefreshGrillaInternosPendientes()
            End If


        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            If Grabar() = False Then Exit Sub

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalle.Click
            If Me.GlosaId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una glosa.")
                Exit Sub
            End If

            Dim f As New Registro.Carceleta.Clasificacion.Documento.frmDetGlosaPopup
            f._Codigo = Me.GlosaId
            f.ShowDialog()
        End Sub

        Private Sub dgvInternosClasificados_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInternosClasificados.CellContentClick

            If e.RowIndex < 0 Then Exit Sub

            If dgvInternosClasificados.Columns(e.ColumnIndex).Name <> "col_sel" Then Exit Sub

            If AgregarDetalle(e.RowIndex) = False Then Exit Sub

        End Sub

        Private Sub dgvDetalle_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellContentClick
            If e.RowIndex < 0 Then Exit Sub
            If dgvDetalle.Columns(e.ColumnIndex).Name <> "col_del" Then Exit Sub
            QuitarInternoClasificado()
        End Sub

        Private Sub dgvDetalle_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellMouseEnter
            If dgvDetalle.Columns(e.ColumnIndex).Name = "col_del" And e.RowIndex >= 0 Then dgvDetalle.Cursor = Cursors.Hand
        End Sub

        Private Sub dgvDetalle_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellMouseLeave
            If dgvDetalle.Columns(e.ColumnIndex).Name = "col_del" And e.RowIndex >= 0 Then dgvDetalle.Cursor = Cursors.Default
        End Sub

        Private Sub dgvInternosClasificados_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInternosClasificados.CellMouseEnter
            If dgvInternosClasificados.Columns(e.ColumnIndex).Name = "col_sel" And e.RowIndex >= 0 Then dgvInternosClasificados.Cursor = Cursors.Hand
        End Sub

        Private Sub dgvInternosClasificados_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInternosClasificados.CellMouseLeave
            If dgvInternosClasificados.Columns(e.ColumnIndex).Name = "col_sel" And e.RowIndex >= 0 Then dgvInternosClasificados.Cursor = Cursors.Default
        End Sub

        'Private Sub dgvDetalle_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvDetalle.CellPainting

        '    If dgvDetalle.Rows.Count <= 1 Then Exit Sub

        '    If dgvDetalle.Columns(e.ColumnIndex).Name = "col_penid_dest" AndAlso e.RowIndex <> -1 Then
        '        'Using gridBrush As Brush = New SolidBrush( Me.dgvDetalle.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)
        '        Using gridBrush As Brush = New SolidBrush(Me.dgvDetalle.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

        '            Using gridLinePen As Pen = New Pen(gridBrush)
        '                ' Clear cell   
        '                e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

        '                ' Draw line (bottom border and right border of current cell)   
        '                'If next row cell has different content, only draw bottom border line of current cell   
        '                If e.RowIndex = dgvDetalle.Rows.Count - 1 OrElse dgvDetalle.Item(e.ColumnIndex, e.RowIndex + 1).Value.ToString() <> e.Value.ToString() Then
        '                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
        '                End If

        '                ' Draw right border line of current cell   
        '                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

        '                ' draw/fill content in current cell, and fill only one cell of multiple same cells   
        '                If Not e.Value Is Nothing Then
        '                    Dim previos As Integer = 0
        '                    Dim siguientes As Integer = 0
        '                    For i As Integer = e.RowIndex - 1 To 0 Step -1
        '                        If dgvDetalle.Item(e.ColumnIndex, i).Value <> e.Value Or i = 0 Or dgvDetalle.Item(e.ColumnIndex, i).Displayed = False Then
        '                            previos = e.RowIndex - i - 1
        '                            Exit For
        '                        End If
        '                    Next
        '                    For i As Integer = e.RowIndex + 1 To dgvDetalle.Rows.Count - 1
        '                        If dgvDetalle.Item(e.ColumnIndex, i).Value <> e.Value Or dgvDetalle.Rows.Count - 1 = i Or dgvDetalle.Item(e.ColumnIndex, i).Displayed = False Then
        '                            siguientes = i - e.RowIndex - 1
        '                            Exit For
        '                        End If
        '                    Next
        '                    If siguientes = previos Or siguientes - 1 = previos Then
        '                        e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 2, StringFormat.GenericDefault)
        '                    End If
        '                End If
        '                e.Handled = True
        '            End Using
        '        End Using

        '    End If
        'End Sub

        'Private Sub dgvInternosClasificados_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvInternosClasificados.CellPainting
        '    If dgvInternosClasificados.Rows.Count <= 1 Then Exit Sub

        '    If dgvInternosClasificados.Columns(e.ColumnIndex).Name = "col_sel_penid_dest" AndAlso e.RowIndex <> -1 Then
        '        'Using gridBrush As Brush = New SolidBrush( Me.dgvInternosClasificados.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)
        '        Using gridBrush As Brush = New SolidBrush(Me.dgvInternosClasificados.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

        '            Using gridLinePen As Pen = New Pen(gridBrush)
        '                ' Clear cell   
        '                e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

        '                ' Draw line (bottom border and right border of current cell)   
        '                'If next row cell has different content, only draw bottom border line of current cell   
        '                If e.RowIndex = dgvInternosClasificados.Rows.Count - 1 OrElse dgvInternosClasificados.Item(e.ColumnIndex, e.RowIndex + 1).Value.ToString() <> e.Value.ToString() Then
        '                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
        '                End If

        '                ' Draw right border line of current cell   
        '                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

        '                ' draw/fill content in current cell, and fill only one cell of multiple same cells   
        '                If Not e.Value Is Nothing Then
        '                    Dim previos As Integer = 0
        '                    Dim siguientes As Integer = 0
        '                    For i As Integer = e.RowIndex - 1 To 0 Step -1
        '                        If dgvInternosClasificados.Item(e.ColumnIndex, i).Value <> e.Value Or i = 0 Or dgvInternosClasificados.Item(e.ColumnIndex, i).Displayed = False Then
        '                            previos = e.RowIndex - i - 1
        '                            Exit For
        '                        End If
        '                    Next
        '                    For i As Integer = e.RowIndex + 1 To dgvInternosClasificados.Rows.Count - 1
        '                        If dgvInternosClasificados.Item(e.ColumnIndex, i).Value <> e.Value Or dgvInternosClasificados.Rows.Count - 1 = i Or dgvInternosClasificados.Item(e.ColumnIndex, i).Displayed = False Then
        '                            siguientes = i - e.RowIndex - 1
        '                            Exit For
        '                        End If
        '                    Next
        '                    If siguientes = previos Or siguientes - 1 = previos Then
        '                        e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 2, StringFormat.GenericDefault)
        '                    End If
        '                End If
        '                e.Handled = True
        '            End Using
        '        End Using

        '    End If

        'End Sub
#End Region
    End Class
End Namespace
