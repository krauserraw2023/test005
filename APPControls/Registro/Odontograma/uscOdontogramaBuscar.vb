Imports System.IO
Imports Ionic.Zip
Imports Type.Enumeracion.Licencia

Namespace Registro.Odontograma
    Public Class uscOdontogramaBuscar
        Private bssInternoOdon As Bussines.Registro.Odontograma.InternoOdontograma = Nothing
        Private bssArchivoOdon As Bussines.Globall.ArchivoDigitalizado = Nothing

        Private pathCarpetaTempoOdon As String = My.Computer.FileSystem.CurrentDirectory & "\tmp\odontograma\"

        Public Event _ClicK_Modificar(OdontogramaId As Integer)

#Region "Propiedades"
        Private Property codigo As Integer = -1
        Private Property idInterno() As Integer = -1
        Private Property idIngresoInpe() As Integer = -1
        Private Property idIngreso() As Integer = -1
        Private Property idRegion() As Short = -1
        Private Property idPenal() As Short = -1
        Private Property esPLM As Boolean = False
        Private Property observacion As String = ""
        Private Property especificacion As String = ""
        Private Property idOdontogramaSelect As Integer = -1
#End Region
#Region "propiedades_grilla"
        Private ReadOnly Property grillaCodigo() As Integer
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
        Private ReadOnly Property grillaVersionOdontograma() As Short
            Get
                Dim intValue As Integer = -1
                With Me.dgwOdontograma
                    intValue = .SelectedRows(0).Cells("col_ver").Value
                End With
                Return intValue
            End Get
        End Property
        Private ReadOnly Property grillaArchivoNombreOdo() As String
            Get
                Dim value As String = ""
                With Me.dgwOdontograma
                    value = .SelectedRows(0).Cells("col_nom_arc_odo").Value
                End With
                Return value
            End Get
        End Property
        Private ReadOnly Property grillaObs() As String
            Get
                Dim value As String = ""
                With Me.dgwOdontograma
                    value = .SelectedRows(0).Cells("col_obs").Value
                End With
                Return value
            End Get
        End Property
        Private ReadOnly Property grillaEspe() As String
            Get
                Dim value As String = ""
                With Me.dgwOdontograma
                    value = .SelectedRows(0).Cells("col_espe").Value
                End With
                Return value
            End Get
        End Property

#End Region
#Region "Propiedades_UserControl"
        Private blnVisibleGrabar As Boolean = False
        Private blnVisibleEliminar As Boolean = False
        Public Property _visibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
                visibleControles()
            End Set
        End Property
        Public Property _visibleEliminar() As Boolean
            Get
                Return blnVisibleEliminar
            End Get
            Set(value As Boolean)
                blnVisibleEliminar = value
                visibleControles()
            End Set
        End Property
#End Region
#Region "Listar"

        Public Sub _loadUsc(idInterno As Integer, idIngresoInpe As Integer, idIngreso As Integer, idRegion As Short, idPenal As Short,
                            esPLM As Boolean)

            Me.idInterno = idInterno
            Me.idIngresoInpe = idIngresoInpe
            Me.idIngreso = idIngreso
            Me.idRegion = idRegion
            Me.idPenal = idPenal
            Me.esPLM = esPLM

            listarGrilla()
        End Sub
        Private Sub listarGrilla()

            If Me.idInterno < 1 Then Exit Sub

            bssInternoOdon = New Bussines.Registro.Odontograma.InternoOdontograma
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)

            Dim filtroInternoOdon As New Entity.Registro.Odontograma.InternoOdontograma
            With filtroInternoOdon
                .InternoId = Me.idInterno
                .IngresoInpeId = Me.idIngresoInpe
                .IngresoId = Me.idIngreso
                .RegionId = Me.idRegion
                .PenalId = Me.idPenal
            End With

            objEntCol = bssInternoOdon.listarGrilla(filtroInternoOdon)

            With Me.dgwOdontograma
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                If .RowCount > 0 Then .SelectedRows(0).Selected = False
            End With

            If Me.esPLM = True Then
                col_ing_nro_inpe.Visible = True
                col_num_ing.Visible = False
            Else
                col_ing_nro_inpe.Visible = False
                col_num_ing.Visible = True
            End If

            If dgwOdontograma.Rows.Count = 0 Then Exit Sub
            dgwOdontograma.Rows(0).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
            mostrarOdontograma()

        End Sub

        Private Function getPathFileJsonOdo(idOdontograma As Integer) As String

            Dim entOdon As Entity.Globall.ArchivoDigitalizado = Nothing
            bssArchivoOdon = New Bussines.Globall.ArchivoDigitalizado

            entOdon = bssArchivoOdon.listarMant(idOdontograma)

            Dim nombreArchivo As String = entOdon.NombreArchivo
            Dim pathFileZip As String = pathCarpetaTempoOdon + nombreArchivo + ".zip"
            Dim pathFileJson As String = pathCarpetaTempoOdon + nombreArchivo + ".json"

            'crear directorio temporal
            If Directory.Exists(pathCarpetaTempoOdon) = False Then
                Directory.CreateDirectory(pathCarpetaTempoOdon)
            End If

            Legolas.Components.Archivo.FileCreateByte(entOdon.ArchivoDigitalByte, pathFileZip)
            'System.IO.File.WriteAllBytes(pathFileZip, entOdon.ArchivoDigitalByte)

            Dim zip As ZipFile = ZipFile.Read(pathFileZip)
            zip.Password = "1np3@0d0nt0gr@m@"
            zip.ExtractAll(pathCarpetaTempoOdon, ExtractExistingFileAction.OverwriteSilently)
            zip.Dispose()

            Return pathFileJson

        End Function
#End Region
#Region "Accion"
        Private Function grabarOdontograma(archivoJsonByte As Byte()) As Boolean

            Dim entInternoOdo As New Entity.Registro.Odontograma.InternoOdontograma
            With entInternoOdo
                .Codigo = Me.codigo
                .InternoId = Me.idInterno
                .IngresoInpeId = Me.idIngresoInpe
                .IngresoId = Me.idIngreso
                .Observaciones = Me.observacion
                .Especificaciones = Me.especificacion
                .version = 2 ' nueva version del odontograma
                .nombreArchivo = Me.grillaArchivoNombreOdo
                .RegionId = Me.idRegion
                .PenalId = Me.idPenal
            End With

            Dim outSMS As String = ""
            Dim intOdontId As Integer = -1

            bssInternoOdon = New Bussines.Registro.Odontograma.InternoOdontograma

            intOdontId = bssInternoOdon.Grabar(entInternoOdo, outSMS)

            If intOdontId = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSMS)
                Return False
            End If

            'grabar archivo digitalizado del odontograma
            Dim entAD As New Entity.Globall.ArchivoDigitalizado
            Dim entADCol As New Entity.Globall.ArchivoDigitalizadoCol

            entADCol = (New Bussines.Globall.ArchivoDigitalizado).Listar(New Entity.Globall.ArchivoDigitalizado With {.IdRegistroForaneo = intOdontId,
                                                                                                                        .TipoArchivoDigital = 1})
            If Not entADCol Is Nothing Then
                If entADCol.Count > 0 Then entAD = entADCol.Archivodigital(0)
            End If

            'convetir el archivo byte json, a zip comprimido con clave
            Dim file As Byte()
            file = fnConvertirZipByte(archivoJsonByte, Me.idRegion, Me.idPenal, intOdontId)

            With entAD
                .ArchivoDigitalByte = file
                .Extension = "zip"
                .IdRegistroForaneo = intOdontId
                .Ip = Legolas.Components.PC.GetIP
                .Mac = Legolas.Components.PC.GetMAC
                .NombrePc = Legolas.Components.PC.PCNombre
                .PesoByte = file.Length
                .TipoArchivoDigital = 1 'odontograma
                .RegionId = Me.idRegion
                .PenalId = Me.idPenal
            End With

            Dim id As Integer = -1
            outSMS = ""
            id = (New Bussines.Globall.ArchivoDigitalizado).Grabar(entAD, outSMS)

            If id < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSMS)
                Return False
            End If

            Return True

        End Function
        Private Function fnConvertirZipByte(archivoJson As Byte(), idRegion As Short, idPenal As Short, idOdontograma As Integer) As Byte()

            Dim value As Byte() = Nothing
            Dim nombreArchivo As String = "odo_" + idRegion.ToString + "_" + idPenal.ToString + "_" + idOdontograma.ToString
            Dim pathFileJson As String = pathCarpetaTempoOdon + nombreArchivo + ".json"
            Dim pathFileZIP As String = pathCarpetaTempoOdon + nombreArchivo + ".zip"

            'crear directorio temporal
            If Directory.Exists(pathCarpetaTempoOdon) = False Then
                Directory.CreateDirectory(pathCarpetaTempoOdon)
            End If

            Legolas.Components.Archivo.FileCreateByte(archivoJson, pathFileJson)

            Dim zip As New ZipFile
            zip.Password = "1np3@0d0nt0gr@m@"
            zip.AddFile(pathFileJson, "")
            zip.Save(pathFileZIP)
            zip.Dispose()

            value = Legolas.Components.Archivo.FileConvertByte(pathFileZIP)

            Try
                Legolas.Components.Archivo.FileDelete(pathFileJson)
                Legolas.Components.Archivo.FileDelete(pathFileZIP)
            Catch ex As Exception

            End Try

            Return value

        End Function

        Private Sub modificarRegistro()

            Select Case Me.grillaVersionOdontograma
                Case 2
                    frmOdontogramaMant(False)
                Case Else
                    RaiseEvent _ClicK_Modificar(Me.grillaCodigo)
            End Select

        End Sub
        Private Sub AEliminar()

            bssInternoOdon = New Bussines.Registro.Odontograma.InternoOdontograma
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Está seguro de eliminar el registro seleccionado?, una vez eliminada el registro no podrá recuperarlo.") = MsgBoxResult.Yes Then

                Dim value As Integer = bssInternoOdon.Eliminar(Me.grillaCodigo)
                If value < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo eliminar el registro seleccionado.")
                    Exit Sub
                End If
                listarGrilla()
            End If

        End Sub
#End Region
#Region "Funciones_Publicas"
        Public Sub _listarGrilla()
            listarGrilla()
        End Sub
#End Region
#Region "Formulario"
        Private Sub frmOdontogramaMant(nuevo As Boolean)

            Dim cargarGrilla As Boolean = False
            Dim pathFileJson As String = ""

            If nuevo = False Then
                Me.codigo = Me.grillaCodigo
                pathFileJson = getPathFileJsonOdo(Me.grillaCodigo)
            End If

            'Dim frm As New Odontograma.frmOdontogramaPopup(Me.grillaCodigo, pathFileJson, Me.grillaObs, Me.grillaEspe)
            'With frm
            '    ._FormEscritura = _visibleGrabar
            '    If .ShowDialog() = DialogResult.OK Then

            '        Me.observacion = ._getObservacion
            '        Me.especificacion = ._getEspecificacion
            '        cargarGrilla = grabarOdontograma(._archivoByteJson)

            '        Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            '    End If
            'End With

            If cargarGrilla = True Then
                '  Me.UscOdontograma1._limpiarTemporales()
                listarGrilla()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub mostrarOdontograma()

            Me.UscOdontograma1.Visible = False
            Me.AxCtlOdon1.Visible = False

            Select Case Me.grillaVersionOdontograma
                Case 2
                    mostrarOdontogramaJson(Me.grillaCodigo)
                    Me.UscOdontograma1.Visible = True
                Case Else
                    mostrarOdontogramaOCX(Me.grillaCodigo)
                    Me.AxCtlOdon1.Visible = True
            End Select

        End Sub
        Private Sub mostrarOdontogramaOCX(idOdontograma As Integer)

            AxCtlOdon1.NewOdontograma()

            Dim entOdnt As Entity.Globall.ArchivoDigitalizado
            Dim entOdntCol As Entity.Globall.ArchivoDigitalizadoCol

            Dim objBssArch As New Bussines.Globall.ArchivoDigitalizado
            Dim entFiltroAD As New Entity.Globall.ArchivoDigitalizado
            Dim sms As String = ""

            entFiltroAD.IdRegistroForaneo = idOdontograma
            entFiltroAD.TipoArchivoDigital = 1 'odontograma
            entOdntCol = objBssArch.Listar(entFiltroAD)
            If entOdntCol.Count = 0 Then Exit Sub
            entOdnt = entOdntCol.Archivodigital(0)

            If entOdnt.ArchivoDigitalByte Is Nothing Then Exit Sub

            If System.IO.Directory.Exists(pathCarpetaTempoOdon) = False Then System.IO.Directory.CreateDirectory(pathCarpetaTempoOdon)

            Dim NomArch As String = ""
            NomArch = "tmp_odont_" & Now.ToFileTime & ".rar"
            System.IO.File.WriteAllBytes(pathCarpetaTempoOdon & "\" & NomArch, entOdnt.ArchivoDigitalByte)

            Dim z As ZipFile = ZipFile.Read(pathCarpetaTempoOdon & "\" & NomArch)
            z.ExtractAll(pathCarpetaTempoOdon, ExtractExistingFileAction.OverwriteSilently)
            z.Dispose()

            Try
                AxCtlOdon1.OpenOdontograma(pathCarpetaTempoOdon & "\" & z.Item(0).FileName)
                System.IO.Directory.Delete(pathCarpetaTempoOdon, True)
            Catch ex As Exception

            End Try
            Me.idOdontogramaSelect = idOdontograma

        End Sub
        Private Sub mostrarOdontogramaJson(idOdontograma As Integer)

            ' Me.UscOdontograma1._uscLoad()
            Dim pathFileZip As String = ""
            pathFileZip = getPathFileJsonOdo(idOdontograma)

            'Me.UscOdontograma1._leerJson(pathFileZip, True)
            Me.idOdontogramaSelect = idOdontograma

        End Sub
        Private Sub visibleControles()

            Me.pnlAdd.Visible = Me._visibleGrabar
            Me.pnlEliminar.Visible = Me._visibleEliminar

        End Sub
#End Region
        Private Sub btnAgregarOdont_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarOdont.Click

            frmOdontogramaMant(True)

        End Sub

        Private Sub btnModificarOdont_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarOdont.Click

            If Me.dgwOdontograma.Rows.Count > 0 Then
                modificarRegistro
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

            If Me.idOdontogramaSelect <> Me.grillaCodigo Then
                mostrarOdontograma()
            End If

        End Sub

        Private Sub dgwOdontograma_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwOdontograma.CellDoubleClick

            btnModificarOdont_Click(Nothing, Nothing)

        End Sub
    End Class

End Namespace
