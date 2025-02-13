Imports Type.Enumeracion.Licencia

Public Class uscVisorDocDigital
    Dim dirTmp As String = My.Computer.FileSystem.CurrentDirectory & "\tmp\doc_digitalizado"

#Region "Propiedades_Publicas"
    Public Property _Codigo As Integer = -1
    Public Property _RegionID() As Integer = -1
    Public Property _PenalID() As Integer = -1
    Public Property _InternoID As Integer = -1
    Public Property _IngresoID As Integer = -1
    Public Property _IngresoInpeID As Integer = -1
    Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region

#Region "eventos"
    Public Event _Click_Add()
    Public Event _ClicK_Modificar(Codigo As Integer)
#End Region

#Region "Propiedades_UserControl"
    Private blnVisibleGrabar As Boolean = False
    Private blnVisibleEliminar As Boolean = False

    Public Property _VisibleGrabar() As Boolean
        Get
            Return blnVisibleGrabar
        End Get
        Set(ByVal value As Boolean)
            blnVisibleGrabar = value 'gfgf
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

#Region "grilla"
    Private ReadOnly Property GrillaCodigo() As Integer
        Get
            Dim intValue As Integer = -1
            With Me.dgwGrilla
                If .Rows.Count > 0 Then
                    intValue = .SelectedRows(0).Cells("col_id").Value
                End If
            End With
            Return intValue
        End Get
    End Property

    Private ReadOnly Property GrillaIngreso() As Integer
        Get
            Dim intValue As Integer = -1
            With Me.dgwGrilla
                If .Rows.Count > 0 Then
                    intValue = .SelectedRows(0).Cells("col_ing_id").Value
                End If
            End With
            Return intValue
        End Get
    End Property

    Private ReadOnly Property GrillaIngresoInpe() As Integer
        Get
            Dim intValue As Integer = -1
            With Me.dgwGrilla
                If .Rows.Count > 0 Then
                    intValue = .SelectedRows(0).Cells("col_ing_inp_id").Value
                End If
            End With
            Return intValue
        End Get
    End Property

    Private ReadOnly Property GrillaTituloDoc() As String
        Get
            Dim cVal As String = ""
            With Me.dgwGrilla
                If .Rows.Count > 0 Then
                    cVal = .SelectedRows(0).Cells("col_titulo").Value.ToString.ToUpper
                End If
            End With
            Return cVal
        End Get
    End Property

    Private ReadOnly Property GrillaFechaReg() As String
        Get
            Dim cVal As String = ""
            With Me.dgwGrilla
                If .Rows.Count > 0 Then
                    cVal = .SelectedRows(0).Cells("col_fec_reg").Value.ToString.ToUpper
                End If
            End With
            Return cVal
        End Get
    End Property
#End Region
#Region "accion"
    Private Sub VisibleControles()
        Me.btnAddImgDig.Visible = Me._VisibleGrabar
        Me.btnDelImgDig.Visible = Me._VisibleEliminar
    End Sub

    Private Sub AEliminar()
        Dim objBss As New Bussines.Registro.Documento.DocumentoDigitalizado
        If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Está seguro de eliminar el registro seleccionado?, una vez eliminada el registro no podrá recuperarla.") = MsgBoxResult.Yes Then
            Dim intValue2 As Integer = objBss.Eliminar(Me.GrillaCodigo)
            If intValue2 = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo eliminar el registro seleccionado")
                Exit Sub
            End If
            Listar()
        End If
    End Sub

    Private Sub MostrarDetalle()
        Dim entOdnt As Entity.Globall.ArchivoDigitalizado
        Dim entOdntCol As Entity.Globall.ArchivoDigitalizadoCol

        Dim objBssArch As New Bussines.Globall.ArchivoDigitalizado
        Dim entFiltroAD As New Entity.Globall.ArchivoDigitalizado
        Dim sms As String = ""

        lblTitulo.Text = "Fecha: " & Me.GrillaFechaReg & "      Título: " & Me.GrillaTituloDoc

        entFiltroAD.IdRegistroForaneo = Me.GrillaCodigo
        entFiltroAD.TipoArchivoDigital = 2 'doc digital
        entOdntCol = objBssArch.Listar(entFiltroAD)
        If entOdntCol.Count = 0 Then Exit Sub
        entOdnt = entOdntCol.Archivodigital(0)

        If entOdnt.ArchivoDigitalByte Is Nothing Then Exit Sub

        If System.IO.Directory.Exists(dirTmp) = False Then System.IO.Directory.CreateDirectory(dirTmp)

        Dim NomArch As String = ""
        NomArch = "tmp_doc_dig_" & Now.ToFileTime & ".pdf"
        System.IO.File.WriteAllBytes(dirTmp & "\" & NomArch, entOdnt.ArchivoDigitalByte)

        Try
            WebBrowser1.Navigate(dirTmp & "\" & NomArch)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Listar()
        Dim objBss As New Bussines.Registro.Documento.DocumentoDigitalizado
        If Me.__IngresoInpeID = -1 Or Me.__InternoID < 1 Then Exit Sub

        Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Documento.DocumentoDigitalizado)
        Dim objIntBand As New Entity.Registro.Documento.DocumentoDigitalizado

        objIntBand.InternoId = Me.__InternoID
        objIntBand.IngresoInpeId = Me.__IngresoInpeID
        Select Case Me._TipoLicencia
            Case enmTipoLicencia.Carceleta
                'objIntBand.PenalId = Me._PenalId
            Case enmTipoLicencia.RegionLimaMetropolitana

            Case enmTipoLicencia.PenalLimaMetropolitana
                objIntBand.PenalId = Me.__PenalID
            Case Else
                objIntBand.IngresoInpeId = -1
                objIntBand.IngresoId = Me._IngresoID
        End Select

        objEntCol = objBss.Listar_grilla(objIntBand, Me._TipoLicencia)

        With Me.dgwGrilla
            .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            .DataSource = objEntCol
        End With
    End Sub

    Public Sub _LoadUsc()
        Listar()

        Select Case Me._TipoLicencia
            Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana
                col_num_ing_inp.Visible = True
                col_num_ing.Visible = False
            Case enmTipoLicencia.PenalLimaMetropolitana
                col_num_ing_inp.Visible = True
                col_num_ing.Visible = False
            Case Else
                col_num_ing_inp.Visible = False
                col_num_ing.Visible = True
        End Select
    End Sub
#End Region
  
    Private Sub btnAddImgDig_Click(sender As System.Object, e As System.EventArgs) Handles btnAddImgDig.Click
        RaiseEvent _Click_Add()
    End Sub

    Private Sub btnEditImgDig_Click(sender As System.Object, e As System.EventArgs) Handles btnEditImgDig.Click
        If Me.dgwGrilla.Rows.Count > 0 Then
            RaiseEvent _ClicK_Modificar(GrillaCodigo)
        Else
            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
        End If
    End Sub

    Private Sub btnDelImgDig_Click(sender As System.Object, e As System.EventArgs) Handles btnDelImgDig.Click
        If dgwGrilla.Rows.Count <= 0 Then Exit Sub

        AEliminar()
    End Sub

    Private Sub dgwGrilla_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellMouseEnter
        If dgwGrilla.Columns(e.ColumnIndex).Name = "col_ver" And e.RowIndex >= 0 Then dgwGrilla.Cursor = Cursors.Hand
    End Sub

    Private Sub dgwGrilla_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellMouseLeave
        If dgwGrilla.Columns(e.ColumnIndex).Name = "col_ver" And e.RowIndex >= 0 Then dgwGrilla.Cursor = Cursors.Default
    End Sub

    Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick
        If dgwGrilla.Columns(e.ColumnIndex).Name = "col_ver" And e.RowIndex >= 0 Then MostrarDetalle()
    End Sub

    Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
        btnEditImgDig.PerformClick()
    End Sub
End Class
