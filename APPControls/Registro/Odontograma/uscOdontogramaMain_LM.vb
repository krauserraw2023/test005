Imports Ionic.Zip
Imports Type.Enumeracion.Licencia

Namespace Registro.Odontograma
    Public Class uscOdontogramaMain_LM
        Dim objBss As Bussines.Registro.Odontograma.InternoOdontograma
        'Dim objEntCol = New Entity.Registro.Odontograma.InternoOdontogramaCol
        Dim dirTmp As String = My.Computer.FileSystem.CurrentDirectory & "\tmp\odontograma"
#Region "propiedades_Publicas"
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoID As Integer = -1 'para una posterior publicacion eliminar, ya existe me._IngresoID
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _PenalId() As Integer = -1
        Public Property _RegionId() As Integer = -1
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region
#Region "propiedades_grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwOdontograma
                    Try
                        intValue = .SelectedRows(0).Cells("col_codigo").Value
                    Catch ex As Exception

                    End Try

                End With
                Return intValue
            End Get
        End Property
        'Private ReadOnly Property GrillaArchivoDigitalId() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        With Me.dgwOdontograma
        '            intValue = .SelectedRows(0).Cells("col_arch_dig_id").Value
        '        End With
        '        Return intValue
        '    End Get
        'End Property
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
#Region "Eventos"
        Public Event _Click_Nuevo()
        Public Event _ClicK_Modificar(OdontogramaId As Integer)
#End Region
#Region "Accion"
        Private Sub VisibleControles()

            Me.pnlAdd.Visible = Me._VisibleGrabar
            Me.pnlEliminar.Visible = Me._VisibleEliminar

        End Sub

        Private Sub AEliminar()

            objBss = New Bussines.Registro.Odontograma.InternoOdontograma
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Está seguro de eliminar el registro seleccionado?, una vez eliminada el registro no podrá recuperarla.") = MsgBoxResult.Yes Then

                Dim intValue2 As Integer = objBss.Eliminar(Me.GrillaCodigo)
                If intValue2 = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo eliminar el registro seleccionado")
                    Exit Sub
                    'Else
                    '    'eliminar archivo de odontograma
                    '    Dim b As New Bussines.Globall.ArchivoDigital
                    '    b.Eliminar(Me.GrillaArchivoDigitalId)
                End If
                Listar()
            End If

        End Sub
#End Region
#Region "Listar"

        Private Sub Listar()

            If Me._InternoId < 1 Then Exit Sub

            AxCtlOdon1.NewOdontograma()
            objBss = New Bussines.Registro.Odontograma.InternoOdontograma
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)

            Dim objIntBand As New Entity.Registro.Odontograma.InternoOdontograma
            objIntBand.InternoId = Me._InternoId
            objIntBand.IngresoInpeId = Me._IngresoInpeID
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta
                    'objIntBand.PenalId = Me._PenalId
                Case enmTipoLicencia.RegionLimaMetropolitana

                Case enmTipoLicencia.PenalLimaMetropolitana
                    objIntBand.PenalId = Me._PenalId
                Case Else
                    objIntBand.IngresoInpeId = -1
                    objIntBand.IngresoId = Me._IngresoID
            End Select

            objEntCol = objBss.Listar_grilla(objIntBand, Me.TipoLicencia)

            With Me.dgwOdontograma
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                If .RowCount > 0 Then .SelectedRows(0).Selected = False
            End With

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                    col_ing_nro_inpe.Visible = True
                    col_num_ing.Visible = False
                Case Else
                    col_num_ing.Visible = True
                    col_ing_nro_inpe.Visible = False
            End Select

            If dgwOdontograma.Rows.Count = 0 Then Exit Sub
            dgwOdontograma.Rows(0).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
            MostrarDetalle()

            
        End Sub

        Public Sub _LoadUsc()
            Listar()
        End Sub
        Private Sub MostrarDetalle()
            Dim entOdnt As Entity.Globall.ArchivoDigitalizado
            Dim entOdntCol As Entity.Globall.ArchivoDigitalizadoCol

            Dim objBssArch As New Bussines.Globall.ArchivoDigitalizado
            Dim entFiltroAD As New Entity.Globall.ArchivoDigitalizado
            Dim sms As String = ""

            entFiltroAD.IdRegistroForaneo = Me.GrillaCodigo
            entFiltroAD.TipoArchivoDigital = 1 'odontograma
            entOdntCol = objBssArch.Listar(entFiltroAD)
            If entOdntCol.Count = 0 Then Exit Sub
            entOdnt = entOdntCol.Archivodigital(0)

            If entOdnt.ArchivoDigitalByte Is Nothing Then Exit Sub

            If System.IO.Directory.Exists(dirTmp) = False Then System.IO.Directory.CreateDirectory(dirTmp)

            Dim NomArch As String = ""
            NomArch = "tmp_odont_" & Now.ToFileTime & ".rar"
            System.IO.File.WriteAllBytes(dirTmp & "\" & NomArch, entOdnt.ArchivoDigitalByte)

            Dim z As ZipFile = ZipFile.Read(dirTmp & "\" & NomArch)
            z.ExtractAll(dirTmp, ExtractExistingFileAction.OverwriteSilently)
            z.Dispose()

            Try
                AxCtlOdon1.OpenOdontograma(dirTmp & "\" & z.Item(0).FileName)
                System.IO.Directory.Delete(dirTmp, True)
            Catch ex As Exception

            End Try

        End Sub
#End Region

        Private Sub btnAgregarOdont_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarOdont.Click
            RaiseEvent _Click_Nuevo()
        End Sub

        Private Sub btnModificarOdont_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarOdont.Click
            If Me.dgwOdontograma.Rows.Count > 0 Then
                RaiseEvent _ClicK_Modificar(Me.GrillaCodigo)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            End If
        End Sub

        Private Sub btnEliminarOdont_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarOdont.Click

            If dgwOdontograma.Rows.Count <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If

            AEliminar()
        End Sub

        Private Sub dgwOdontograma_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwOdontograma.CellClick
            If e.RowIndex = -1 Then Exit Sub
            MostrarDetalle()
        End Sub

        Private Sub dgwOdontograma_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwOdontograma.CellDoubleClick
            btnModificarOdont_Click(Nothing, Nothing)
        End Sub
    End Class

End Namespace
