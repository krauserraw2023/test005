
Imports System.Windows.Forms
Imports Type.Enumeracion.Licencia

Namespace Registro.Reniec
    Public Class frmTipoValidacionV2
        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Private objEntCol As Entity.Registro.NombreAsociadoCol = Nothing
#Region "Propiedades"
        Public Property _InternoID As Integer = -1
        Public Property _TipoDocumento As Integer = -1
        Public Property _NumeroDocumento As String = ""
        Public Property _Estado As Integer = -1

        Public Property _ImagenSis As Integer = -1
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1

        Public Property _ListaInternoSisCabecera As String = ""
        Public Property _ListaInternoSisData As String = ""
        Public Property _NombresAsociados As String = ""

        Public Property _ApellidoPaterno As String = ""
        Public Property _ApellidoMaterno As String = ""
        Public Property _Nombres As String = ""

        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

        Private ReadOnly Property TipoValidacionReniec() As Short
            Get

                Dim value As Short = -1
                'dni
                If Me.rdbDni.Checked = True Then
                    value = 1
                End If

                'nombre principal
                If Me.rdbNombreprincipal.Checked = True Then
                    value = 2
                End If

                'nombre asociado
                If Me.rdbNombresAsociados.Checked = True Then
                    value = 3
                End If

                Return value

            End Get

        End Property
#End Region
#Region "Propiedades_Grilla"
        'Public ReadOnly Property GrillaCodigo() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        Try
        '            With Me.dgwGrillaNombresAsociados
        '                intValue = .SelectedRows(0).Cells("col_nom_aso_id").Value
        '            End With
        '        Catch ex As Exception
        '        End Try
        '        Return intValue
        '    End Get
        'End Property
        Public ReadOnly Property _GrillaNombreAsociadoID() As Integer
            Get
                Dim intValue As Integer = -1

                With Me.dgwGrillaNombresAsociados
                    If .Rows.Count > 0 Then
                        intValue = .SelectedRows(0).Cells("col_nom_aso_id").Value
                    End If
                End With

                Return intValue
            End Get
        End Property


        Public ReadOnly Property _GrillaApellidoPaterno() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrillaNombresAsociados
                        intValue = .SelectedRows(0).Cells("col_ape_pat").Value
                    End With
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property _GrillaApellidoMaterno() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrillaNombresAsociados
                        intValue = .SelectedRows(0).Cells("col_ape_mat").Value
                    End With
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property _GrillaNombres() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrillaNombresAsociados
                        intValue = .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Public Property _NroIngresoID() As Integer = -1
        Public Property _IngresoInpeID As Integer = -1

#End Region
#Region "Propiedades_Return"
        Private intTipoValidacionReniec As Short = -1
        Public Property _TipoValidacionReniec As Short
            Get
                Return intTipoValidacionReniec
            End Get
            Set(value As Short)
                intTipoValidacionReniec = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarNombresAsociadosActual()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.NombreAsociado
            objEntCol = New Entity.Registro.NombreAsociadoCol

            Dim objEnt As New Entity.Registro.NombreAsociado
            objEnt.InternoID = Me._InternoID
            objEnt.Principal = 0
            objEnt.Estado = 1
            objEntCol = objBss.Listar(objEnt)
            With Me.dgwGrillaNombresAsociados
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                If .RowCount > 0 Then
                    '.SelectedRows(0).Selected = True
                    For i As Integer = 0 To .RowCount - 1
                        .Item(0, i).Value = i + 1
                    Next
                Else
                    'Me.Size = New Size(220, 192)
                    'Me.dgwGrillaNombresAsociados.Visible = False

                End If
            End With
        End Sub
#End Region
#Region "Accion" '444
        Private Function ValidarNombreAsociado() As Boolean

            Dim value As Boolean = False
            ListarNombresAsociadosActual()

            If Me.dgwGrillaNombresAsociados.RowCount > 0 Then
                value = True
            End If

            Return value

        End Function
        Private Sub MostrarGrilla()

            Dim intAlto As Integer = 218
            Dim blnMostrarGrilla As Boolean = False

            Select Case Me.TipoValidacionReniec
                Case 1, 2, 4, -1 'dni, nombre principal
                    intAlto = intAlto
                Case 3 'asociados
                    If ValidarNombreAsociado() = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "No se puede validar, El interno no cuenta con nombres asociados")
                        Exit Sub
                    End If
                    intAlto = 310
                    blnMostrarGrilla = True
            End Select

            Me.Size = New Size(Me.Width, intAlto)
            Me.dgwGrillaNombresAsociados.Visible = blnMostrarGrilla
            Me.Refresh()

        End Sub
        Private Sub AOK()
            Me.Cursor = Cursors.WaitCursor
            Dim blnOK As Boolean = False
            If Validar() = True Then
                Select Case Me.TipoValidacionReniec
                    Case 1, 2, 4, -1
                        blnOK = True
                    Case 3
                        If Me._GrillaNombreAsociadoID > 0 Then
                            blnOK = True
                        Else
                            blnOK = False
                            Me.Cursor = Cursors.Default
                        End If
                End Select

                If blnOK = True Then
                    If Me.TipoValidacionReniec = 4 Or Me.TipoValidacionReniec = -1 Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("No se ha encontrado al interno en la busqueda por:" + Chr(13) +
                                                                                      "1.DNI" + Chr(13) +
                                                                                      "2.Nombre principal" + Chr(13) +
                                                                                      "3.Nombres asociados" + Chr(13) +
                                                                                      "Esta seguro de registrarlo como [No figura en Reniec]") = DialogResult.Yes Then
                            ProcesarNoEncontrado()
                        End If
                    Else
                        Me._TipoValidacionReniec = Me.TipoValidacionReniec
                        ProcesarReniec()
                    End If
                End If
                Me.Cursor = Cursors.Default
            End If
        End Sub
        Private Async Sub ProcesarReniec()
            ' Me.Cursor = Cursors.WaitCursor
            Dim TipoValidacion As Integer = -1
            TipoValidacion = Me._TipoValidacionReniec

            Dim frm As New Registro.Reniec.frmReniecLineaV2
            With frm
                .UsrInternoReniecLineaV31._InternoID = Me._InternoID
                .UsrInternoReniecLineaV31._IngresoID = Me._NroIngresoID
                .UsrInternoReniecLineaV31._IngresoInpeID = Me._IngresoInpeID
                .UsrInternoReniecLineaV31._TipoLicencia = Me._TipoLicencia
                .UsrInternoReniecLineaV31._ImagenSis = Me._ImagenSis
                .UsrInternoReniecLineaV31._RegionID = Me._RegionID
                .UsrInternoReniecLineaV31._PenalID = Me._PenalID

                .UsrInternoReniecLineaV31._ListaInternoSisCabecera = Me._ListaInternoSisCabecera
                .UsrInternoReniecLineaV31._ListaInternoSisData = Me._ListaInternoSisData
                .UsrInternoReniecLineaV31._NombresAsociados = Me._NombresAsociados

                Dim blnValorData As Boolean = False
                ._InternoID = Me._InternoID

                If Me._TipoValidacionReniec = 1 Then
                    frm.lblLeyenda.Visible = False
                    frm._NumeroDNI = Me._NumeroDocumento
                    frm._Comparacion = TipoValidacion
                Else   '     If TipoValidacion = 2,3
                    frm.lblLeyenda.Visible = True
                    frm._ApellidoPaterno = IIf(TipoValidacion = 2, Me._ApellidoPaterno, Me._GrillaApellidoPaterno)
                    frm._ApellidoMaterno = IIf(TipoValidacion = 2, Me._ApellidoMaterno, Me._GrillaApellidoMaterno)
                    frm._Nombres = IIf(TipoValidacion = 2, Me._Nombres, Me._GrillaNombres)
                    frm._NombreAsociadoValID = IIf(TipoValidacion = 3, Me._GrillaNombreAsociadoID, -1)
                    frm._Comparacion = TipoValidacion
                End If

                Dim cargaExitosa As Boolean = Await frm._Load()

                If cargaExitosa = False Then

                    Me.Cursor = Cursors.Default
                    Dim strmensaje As String = ""
                    Dim strCodigo As String = ""
                    Dim strCabecera As String = ""

                    If Me._TipoValidacionReniec = 1 Then
                        strmensaje = frm.UsrInternoReniecLineaV31.strMensaje
                        strCodigo = frm.UsrInternoReniecLineaV31.strCodigo
                        strCabecera = frm.UsrInternoReniecLineaV31.strCabecera
                    Else
                        strmensaje = frm.UscListaReniec31.strMensaje
                        strCodigo = frm.UscListaReniec31.strCodigo
                        strCabecera = frm.UscListaReniec31.strCabecera
                    End If
                    If strCodigo = "INACTIVO" Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError(strmensaje, strCabecera)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strmensaje, strCabecera)
                    End If
                Else
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        'Me.Close()
                    Else
                        Me.Cursor = Cursors.Default
                    End If
                End If

            End With
        End Sub
        Private Sub ProcesarNoEncontrado()
            Dim bssren As New Bussines.Registro.InternoReniec
            Dim objRen As New Entity.Registro.InternoReniec
            With objRen
                .InternoID = Me._InternoID
                .IngresoID = Me._NroIngresoID
                .IngresoInpeId = Me._IngresoInpeID
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .ComparacionID = Type.Enumeracion.Reniec.EnmTipoValidacion.Ninguna
                .TipoBusquedaID = Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado
                .InternoSisMetadata = Me._ListaInternoSisCabecera
                .InternoSisData = Me._ListaInternoSisData
                .FotoInterno = Me._ImagenSis
                .Observaciones = "NO FIGURA EN RENIEC"
            End With
            Dim ReniecID As Integer = -1

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objRen.IngresoID = -1
                ReniecID = bssren.Grabar2_LM(objRen)
            Else
                ReniecID = bssren.Grabar2(objRen)
            End If


            If ReniecID > 0 Then
                objBss = New Bussines.Registro.NombreAsociado
                objEntCol = New Entity.Registro.NombreAsociadoCol

                Dim objEnt As New Entity.Registro.NombreAsociado
                objEnt.InternoID = Me._InternoID
                objEnt.Principal = 0
                objEnt.Estado = 1
                objEntCol = objBss.Listar(objEnt)


                Dim bssrenA As New Bussines.Registro.InternoReniecNomAsoc
                Dim objRenA As Entity.Registro.InternoReniecNomAsoc

                For Each ent As Entity.Registro.NombreAsociado In objEntCol
                    objRenA = New Entity.Registro.InternoReniecNomAsoc
                    With objRenA
                        .InternoID = Me._InternoID
                        .IngresoID = Me._NroIngresoID
                        .IngresoInpeId = Me._IngresoInpeID
                        .CodigoNomAsoc = ent.Codigo
                        .InternoReniecID = ReniecID
                        .ApellidoPaterno = ent.ApellidoPaterno
                        .ApellidoMaterno = ent.ApellidoMaterno
                        .Nombres = ent.Nombres
                    End With
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                        Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                        Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        objRenA.IngresoID = -1
                        bssrenA.Grabar_LM(objRenA)
                    Else
                        bssrenA.Grabar(objRenA)
                    End If


                Next
            End If
            Me.Close()
        End Sub
        Private Function Validar() As Boolean

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._IngresoInpeID < 1 Then
                    Me.Cursor = Cursors.Default
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con Nro de ingreso")
                    Return False
                End If
            Else
                If Me._NroIngresoID < 1 Then
                    Me.Cursor = Cursors.Default
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con Nro de ingreso")
                    Return False
                End If
            End If
            

            If rdbDni.Checked = True And Me._TipoDocumento <> 10 Then
                Me.Cursor = Cursors.Default
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con tipo de documento [DNI]")
                rdbDni.Focus()
                Return False
            End If
            Dim longitud As Integer = Len(Me._NumeroDocumento)
            If rdbDni.Checked = True And longitud = 0 Then
                Me.Cursor = Cursors.Default
                Legolas.Configuration.Aplication.MessageBox.Exclamation("DNI - vacio")
                rdbDni.Focus()
                Return False
            ElseIf rdbDni.Checked = True And longitud <> 8 Then
                Me.Cursor = Cursors.Default
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Numero de digitos de [DNI] incorrectos")
                rdbDni.Focus()
                Return False
            End If
            If rdbNombresAsociados.Checked = True Then
                If Me.dgwGrillaNombresAsociados.Rows.Count = 0 Then
                    Me.Cursor = Cursors.Default
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no posee nombres asociados para la validacion")
                    'cbbNroIngresos.Focus()
                    Return False
                End If
            End If
            Return True
        End Function
#End Region

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            AOK()
        End Sub

        Private Sub dgwGrillaNombresAsociados_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaNombresAsociados.CellDoubleClick
            AOK()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub rdbDni_Click(sender As Object, e As System.EventArgs) Handles _
            rdbDni.Click, _
            rdbNombreprincipal.Click, _
            rdbNombresAsociados.Click, _
            rdbNofigura.Click

            MostrarGrilla()

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs)
            AOK()
        End Sub

        Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
            AOK()
        End Sub

        Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
            AOK()
        End Sub

    End Class

End Namespace