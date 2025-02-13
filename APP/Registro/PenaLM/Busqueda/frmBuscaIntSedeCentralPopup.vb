Imports System.ComponentModel
Imports System.Linq
Imports System.Runtime.InteropServices

Namespace Registro.PenalLM.Busqueda
    Public Class frmBuscaIntSedeCentralPopup
        Enum enmTipoAccion
            SIGUIENTE_OPCION_RENIEC = 1
            IMPORTAR_REGISTRO_SEDE = 2 'permite obtener datos basicos de la sede
            REGISTRO_EXISTENTE = 3 'para modificar registro existente en la bd local
            REGISTRO_MANUAL = 4
        End Enum
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = CType(Me.dgwGrilla.SelectedRows(0).Cells("col_int_id").Value, Integer)
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Private frmLoad As Load.frmProcesando = Nothing
        Private blnRealizoBusqueda As Boolean = False
        Private Property PerfilActual As Integer
        Private intInternoID As Integer = -1
        Private Property InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property

        Private Property PerfilFotografia() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbPI.Checked = True Then
                    value = 1
                End If

                If Me.rdbPF.Checked = True Then
                    value = 2
                End If

                If Me.rdbPD.Checked = True Then
                    value = 3
                End If

                Return value

            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbPI.Checked = True
                    Case 2
                        Me.rdbPF.Checked = True
                    Case 3
                        Me.rdbPD.Checked = True
                    Case Else
                        Me.rdbPI.Checked = False
                        Me.rdbPF.Checked = False
                        Me.rdbPD.Checked = False
                End Select
            End Set
        End Property

#Region "Propiedades"
        Public Property _TipoAccion As enmTipoAccion
        Public Property _IDInternoSelecionado As Integer = -1
        Public Property _IDRegion As Integer = -1
        Public Property _IDPenal As Integer = -1
#End Region

#Region "Grilla"

        Public ReadOnly Property GrillaCodigoRP() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_cod_rp").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaApePaterno() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_ape_pat").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaApeMaterno() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_ape_mat").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaNombres() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property IDGrillaSedeInternoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaIdRegion() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaIdPenal() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIdPenalNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFechaIngreso() As Long
            Get
                Dim value As Long = 0
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_ing_fec").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoInternoID() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_est_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoInterno() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_est_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region

#Region "propiedades"
        Private ReadOnly Property TipoBusqueda As Short
            Get
                Dim value As Short = -1

                If Me.rdbPorDni.Checked = True Then
                    value = 1
                End If

                If Me.rdbApellidos.Checked = True Then
                    value = 2
                End If

                Return value
            End Get
        End Property
        Private Property IDTipoDocumento() As Integer
            Get
                Try
                    Return Me.cbbTipoDoc.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property

        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property

        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property

        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property

        Private Property Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property

#End Region

#Region "Combo"
        Private Sub ComboTipoDocumento()
            With Me.cbbTipoDoc
                ._Todos = True
                .LoadUsc()
            End With
        End Sub
#End Region

#Region "Listar"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            Select Case Me.TipoBusqueda

                Case 1 'x dni


                    'numero documento 
                    If Me.IDTipoDocumento > 0 Then

                        If Me.NumeroDocumento.Trim.Length < 5 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El número de documento de identidad no puede ser menor a 05 digitos, verifique.")
                            Me.txtNumDoc.Focus()
                            Return False
                        End If

                        If Me.IDTipoDocumento = 10 Then

                            If Me.NumeroDocumento.Trim.Length <> 8 Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("La cantidad de digitos del número de documento de identidad es incorrecta.")
                                Return False
                            End If

                        End If

                    Else
                        If Me.NumeroDocumento.Trim.Length < 5 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El número de documento de identidad no puede ser menor a 05 digitos, verifique.")
                            Me.txtNumDoc.Focus()
                            Return False
                        End If
                    End If

                Case 2 ' x apellidos y nombres

                    If Me.ApellidoPaterno.Trim.Length < 2 And Me.ApellidoMaterno.Trim.Length < 2 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese al menos un apellido en la busqueda de internos")
                        Me.txtApePat.Focus()
                        Return False
                    End If

            End Select

            value = True

            Return value
        End Function

        Private Sub Buscar()

            Me.lblTotReg01.Text = "0. Reg"

            If Validar() = False Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim objBss As New Bussines.Registro.Interno_Grilla

            '------------------seteamos los demas valores---------------------
            Dim objEntFiltro As New APPWebService.ws_pope_sede_plm_Interno.DTO_Interno

            Select Case Me.TipoBusqueda
                Case 1 'x dni

                    With objEntFiltro
                        .TipoDocumentoID = Me.IDTipoDocumento
                        .NumeroDocumento = Me.NumeroDocumento
                    End With

                Case 2 'x apellidos y nombres

                    With objEntFiltro
                        .TipoDocumentoID = -1
                        .ApellidoPaterno = Me.ApellidoPaterno
                        .ApellidoMaterno = Me.ApellidoMaterno
                        .Nombres = Me.Nombres
                    End With

            End Select

            '----------------------------- conexion a la sede por ws ------------------->>
            Dim ws As New APPWebService.ws_pope_sede_plm_Interno.InternoSede
            Dim rpta As APPWebService.ws_pope_sede_plm_Interno.DTO_ResultOfDataTable
            ws.Url = APPWebService.PathURL.ws_sede_plm_Interno

            Try
                ws.getFecha()
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.Exclamation("En estos momentos el servicio de la Sede Central no está disponible, intente luego de unos instantes, caso contrario comunique al administrador de sistema o realice el registro manualmente.")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try

            Dim objDataTable As DataTable
            rpta = ws.ListarMovIntSede(objEntFiltro)

            If rpta.Error_cod < 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(rpta.Error_Mensaje, "Código de error:" & rpta.Error_cod)
            Else

                'sin errores
                If rpta.Error_Mensaje.Length > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(rpta.Error_Mensaje)
                Else

                    objDataTable = rpta.Resultado
                    '<<---------------------------------------------------------------------------
                    With Me.dgwGrilla
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = objDataTable
                    End With

                    blnRealizoBusqueda = True

                    If Not objDataTable Is Nothing Then

                        If objDataTable.Rows.Count > 0 Then
                            lblTotReg01.Text = String.Format("{0:00}", objDataTable.Rows.Count) & " registros encontrados"
                            lblTotReg01.ForeColor = Color.Black
                        End If

                    Else
                        lblTotReg01.Text = "No se encontraron coincidencias"
                        lblTotReg01.ForeColor = Color.Brown
                    End If

                End If

            End If

            Me.Cursor = Cursors.Default

        End Sub
        Private Sub ShowFotografia()
            If Me.UscFotografia_2v1._CheckImagen = False Or Me.GrillaInternoID < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            If Me.InternoID = Me.GrillaInternoID And Me.UscFotografia_2v1._HasImagen = True And Me.PerfilFotografia = PerfilActual Then
                'nada
            Else

                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEnt As New Entity.Registro.InternoFoto
                Select Case Me.PerfilFotografia
                    Case 1 'izquierdo
                        Me.PerfilActual = 1
                        Me.UscFotografia_2v1._ShowFotoInterno(CType(dgwGrilla.Item("col_pizq_arch_dig_id", dgwGrilla.CurrentCell.RowIndex).Value, Integer), True)
                    Case 2 'frente
                        Me.PerfilActual = 2
                        Me.UscFotografia_2v1._ShowFotoInterno(CType(dgwGrilla.Item("col_pfron_arch_dig_id", dgwGrilla.CurrentCell.RowIndex).Value, Integer), True)
                    Case 3 'derecho
                        Me.PerfilActual = 3
                        Me.UscFotografia_2v1._ShowFotoInterno(CType(dgwGrilla.Item("col_pder_arch_dig_id", dgwGrilla.CurrentCell.RowIndex).Value, Integer), True)
                End Select
                Me.InternoID = Me.GrillaInternoID
            End If
        End Sub


#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            ComboTipoDocumento()
            Me.IDTipoDocumento = 10
            Me.txtApePat.Focus()

            Me.grbBusDNI.Visible = False

        End Sub
        Private Sub HabilitarBusqueda()

            Me.grbBusDNI.Visible = False
            Me.grbBusApellidos.Visible = False

            ALimpiar()

            Select Case Me.TipoBusqueda
                Case 1 'dni
                    Me.grbBusDNI.Visible = True
                    Me.txtNumDoc.Focus()
                Case 2 'nombres 
                    Me.grbBusApellidos.Visible = True
                    Me.txtApePat.Focus()
            End Select

        End Sub
        Private Sub ALimpiar()

            Select Case Me.TipoBusqueda
                Case 1 'x dni

                    Me.IDTipoDocumento = 10
                    Me.NumeroDocumento = ""
                    Me.txtNumDoc.Focus()

                Case 2 'x apellidos y nombres

                    Me.ApellidoPaterno = ""
                    Me.ApellidoMaterno = ""
                    Me.Nombres = ""
                    Me.txtApePat.Focus()

            End Select

            Me.dgwGrilla.DataSource = Nothing
            Me.lblTotReg01.Text = "0. Reg."
            Me.blnRealizoBusqueda = False
            'Me.lblCodRp.Text = ""
            Me.UscFotografia_2v1._Limpiar()

        End Sub
#End Region

        Private Sub frmBuscaInternoPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ValoresxDefault()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            Dim idIntSel As Integer = -1
            Dim objCol As New Entity.Registro.InternoCol
            Dim bss As New Bussines.Registro.Interno_Grilla
            Dim bsInt As New Bussines.Registro.Interno

            'validar el registro seleccionado del interno
            If Me.IDGrillaSedeInternoId = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe buscar el interno y en caso de encontrar seleccionar el registro y presionar el botón aceptar.")
                Exit Sub
            End If

            'validar el interno en la bandeja de entrada
            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta
            Try
                ws._test()
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.Exclamation("En estos momentos el servicio de la Sede Central no está disponible, intente luego de unos instantes.")
                Exit Sub
            End Try

            Dim t As DataTable
            t = ws.ListaPendRecepTraslado(Me._IDPenal)

            For i As Integer = 0 To t.Rows.Count - 1
                If CInt(t.Rows(i).Item("int_id")) = Me.IDGrillaSedeInternoId Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno se encuentra en la bandeja de entrada de internos por traslado o conducción, por favor verifique.")
                    Exit Sub
                End If
            Next

            Dim objInt As New Entity.Registro.Interno
            objInt.SedeRowId = Me.IDGrillaSedeInternoId
            objCol = bsInt.Listar_LM(objInt)
            If objCol.Count > 0 Then
                objInt = objCol.Item(0)

                Me._IDInternoSelecionado = objInt.Codigo

                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Exit Sub
            End If

            '/*validar que el penal de recepcion no sea igual al penal de destino */
            If Me.GrillaIdPenal = Me._IDPenal Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Inconsistencia, no es posible realizar traslado hacia el mismo penal.")
                Exit Sub
            End If

            '/*validar el codigorp + apellidos + nombres, que no exista en la bd del ep*/
            Dim obj As New Entity.Registro.Interno_Grilla
            obj.InternoCodigoRP = Me.GrillaCodigoRP
            obj.PrimerApellido = Me.GrillaApePaterno
            obj.SegundoApellido = Me.GrillaApeMaterno
            obj.PreNombres = Me.GrillaNombres

            objCol = bss.ListarInternoBusqueda(obj)

            If objCol.Count > 0 Then
                If objCol.Count = 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno " & Chr(13) &
                                                                         Me.GrillaApePaterno & " " & Me.GrillaApeMaterno & " " & Me.GrillaNombres & Chr(13) &
                                                                         " ya se encuentra en el penal local, por favor verifique." & Chr(13) &
                                                                         "------------------------------" & Chr(13) &
                                                                        "Los datos del interno serán visualizados")
                    Me._IDInternoSelecionado = objCol.Item(0).Codigo
                    DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else 'si existe mas de un duplicado por datos personales.
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Existen " & objCol.Count & " registros en el penal con los nombres " & Chr(13) &
                                                                         Me.GrillaApePaterno & " " & Me.GrillaApeMaterno & " " & Me.GrillaNombres & " CodRP " & Me.GrillaCodigoRP & Chr(13) &
                                                                         "verificar y corregir de ser necesario, caso contrario contactese con el administrador del sistema.")
                End If
                Exit Sub
            End If

            'validar por el numero de dni del interno
            Dim ent As New Entity.Registro.Interno_Grilla

            '----------- buscar por DNI ----------
            If dgwGrilla.Item("col_tip_doc_id", dgwGrilla.CurrentRow.Index).Value = 10 _
                And Len(dgwGrilla.Item("col_num_doc", dgwGrilla.CurrentRow.Index).Value) = 8 _
                And IsNumeric(dgwGrilla.Item("col_num_doc", dgwGrilla.CurrentRow.Index).Value) Then

                ent = New Entity.Registro.Interno_Grilla
                Dim tmpCol As New Entity.Registro.InternoCol

                ent.InternoNumeroDocumento = dgwGrilla.Item("col_num_doc", dgwGrilla.CurrentRow.Index).Value
                ent.IDTipoDocIdentidad = dgwGrilla.Item("col_tip_doc_id", dgwGrilla.CurrentRow.Index).Value
                ent.IDRegion = Me._IDRegion
                ent.IDPenal = Me._IDPenal

                Dim bssInt As New Bussines.Registro.Interno_Grilla
                tmpCol = bssInt.ListarInternoBusqueda(ent)

                If tmpCol.Count > 0 Then 'existen x coincidencias de registros con el mismo numero de documento de identidad.
                    Dim s As String = ""
                    Dim tmpIntId As Integer = -1
                    Dim intEstado As Integer = 0

                    For Each x As Entity.Registro.Interno In tmpCol
                        tmpIntId = x.Codigo
                        intEstado = x.EstadoID

                        s = s & "CodRp: " & x.CodigoRP & "," + Chr(13) +
                                "Nombres: " & x.ApellidosyNombres & ". " + Chr(13) +
                                x.TipoDocumentoNombre & ": " & x.NumeroDocumento & vbCrLf
                    Next

                    If tmpCol.Count = 1 Then

                        If tmpCol.Item(0).CodigoRP = Me.GrillaCodigoRP Then
                            'el el mismo codigo rp del penal y de la sede central
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno: " & GrillaApePaterno & " " & GrillaApeMaterno & " " & GrillaNombres + Chr(13) +
                                                                               "se encuentra en el penal, con la coincidencia por el Tipo y número de documento de identidad." _
                                                                               & Chr(13) & s
                                                                               )
                            Me._IDInternoSelecionado = tmpCol.Item(0).Codigo
                            DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                            Exit Sub
                        Else
                            'pasa la condicion, xq se trata de otro interno x el codigo rp. 
                        End If

                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Se han encontrado las siguientes coincidencias x número de documento de identidad." & vbCrLf &
                                                                            "---------------------------------------------------------------------------" & vbCrLf &
                                                                            s & vbCrLf &
                                                                            "Debe resolver la duplicidad de número de documento de identidad en la base de datos local.")
                        Exit Sub

                    End If
                End If
            End If

            '/*grabar datos del interno*/
            Dim blnGrabarInternoProvincia As Boolean = False
            Dim strMensajeOut As String = ""
            Dim strMensajebox As String = "Confirma registrar al interno como nuevo registro?"

            If Me.GrillaIdRegion = 3 Then

                If Me.GrillaIdPenal = -1 Then ' si el interno fue registrado por la region

                    strMensajebox = strMensajebox & Chr(13) & "Codigo RP: " & GrillaCodigoRP & Chr(13) &
                        "Primer Apellido:" & GrillaApePaterno & Chr(13) &
                        "Segundo Apellido:" & GrillaApeMaterno & Chr(13) &
                        "Nombres: " & GrillaNombres

                    If MessageBox.Show(strMensajebox, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        idIntSel = GrabarDatosBasicosInternoSede_PLM(Me.IDGrillaSedeInternoId, strMensajeOut)
                        If idIntSel = -1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo registrar los datos, " & strMensajeOut)
                            Exit Sub
                        End If
                        GoTo sal_linea
                    Else
                        Exit Sub
                    End If

                Else
                    Dim tipLic As Integer = -1
                    Dim pen As Entity.General.Penal

                    pen = (New Bussines.General.Penal).Listar_v2(Me.GrillaIdPenal)
                    tipLic = pen.PenalTipoLicenciaId

                    If Me.GrillaEstadoInternoID = 1 Then 'si interno activo en el origen

                        If GrillaFechaIngreso <= Legolas.Components.FechaHora.FechaLong("18/03/2018") Then 'fecha de inicio de carceleta y orl
                            'se importa el interno de carceleta y orl, menor al 18/03/2019.

                            Select Case tipLic
                                Case 4, 6 'Carceleta, Penal LM(interno inactivo)

                                    strMensajebox = strMensajebox & Chr(13) & "Codigo RP: " & GrillaCodigoRP & Chr(13) &
                                    "Primer Apellido:" & GrillaApePaterno & Chr(13) &
                                    "Segundo Apellido:" & GrillaApeMaterno & Chr(13) &
                                    "Nombres: " & GrillaNombres

                                    If MessageBox.Show(strMensajebox, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                        idIntSel = GrabarDatosBasicosInternoSede_PLM(Me.IDGrillaSedeInternoId, strMensajeOut)
                                        If idIntSel = -1 Then
                                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo registrar los datos, " & strMensajeOut)
                                            Exit Sub
                                        End If
                                        GoTo sal_linea
                                    Else
                                        Exit Sub
                                    End If

                                Case Else
                                    blnGrabarInternoProvincia = True
                            End Select

                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno se encuentra activo en el penal origen, para registrar un interno dentro de su población penitenciaria el interno debe estar inactivo, por lo tanto se sugiere coordinar con el penal origen para su baja.")
                            Exit Sub
                        End If

                    Else 'inactivo

                        Select Case tipLic
                            Case 4, 6 'Carceleta, Penal LM(interno inactivo)

                                strMensajebox = strMensajebox & Chr(13) & "Codigo RP: " & GrillaCodigoRP & Chr(13) &
                                "Primer Apellido:" & GrillaApePaterno & Chr(13) &
                                "Segundo Apellido:" & GrillaApeMaterno & Chr(13) &
                                "Nombres: " & GrillaNombres

                                If MessageBox.Show(strMensajebox, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    idIntSel = GrabarDatosBasicosInternoSede_PLM(Me.IDGrillaSedeInternoId, strMensajeOut)
                                    If idIntSel = -1 Then
                                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo registrar los datos, " & strMensajeOut)
                                        Exit Sub
                                    End If
                                    GoTo sal_linea
                                Else
                                    Exit Sub
                                End If

                            Case Else
                                blnGrabarInternoProvincia = True
                        End Select

                    End If
                End If
            Else 'provincia
                    If Me.GrillaEstadoInternoID = 1 Then 'si interno activo en el origen
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno se encuentra activo en el penal origen, para registrar un interno dentro de su población penitenciaria el interno debe estar inactivo, por lo tanto se sugiere coordinar con el penal origen para su baja.")
                    Exit Sub
                Else
                    blnGrabarInternoProvincia = True
                End If
            End If

            If blnGrabarInternoProvincia = True Then
                strMensajebox = ""
                strMensajebox = "Confirma registrar al interno como nuevo registro con su número de ingreso Inpe y movimiento de ingreso por traslado?" & vbCrLf &
                    "Si acepta, se generará un número de ingreso inpe y movimiento de ingreso por traslado, luego debe modificar y asignar la fechas correctas." & vbCrLf

                If MsgBox(strMensajebox, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    Dim sms As String = ""
                    idIntSel = RegistrarIntDatBasicoEPProv(Me.IDGrillaSedeInternoId, sms)
                    If idIntSel = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo registrar los datos, " & sms)
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End If
            '<--------------------------------------------------------

sal_linea:

            If idIntSel = -1 Then Exit Sub

            Me._TipoAccion = enmTipoAccion.REGISTRO_EXISTENTE
            Me._IDInternoSelecionado = idIntSel
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End Sub

        Private Function RegistrarIntDatBasicoEPProv(idInternoSede As Integer, ByRef outSMS As String) As Integer

            Dim value As Integer = -1
            Dim objBss As New Bussines.Transferencia.RecepcionInternoTraslado(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno, Me._IDRegion, Me._IDPenal)

            value = objBss.RecepcionTrasladoOrigenEPProv(idInternoSede, outSMS)

            Return value

        End Function
        Private Function GrabarDatosBasicosInternoSede_PLM(idInternoSede As Integer, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim objBss As New Bussines.Transferencia.RecepcionInternoTraslado(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno, Me._IDRegion, Me._IDPenal)
            value = objBss.Grabar_DatosBasicosInternoSede_PLM(idInternoSede, strMensajeOut)

            Return value

        End Function


        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            If Legolas.Configuration.Aplication.MessageBox.Question("Se va a cancelar la operación de registro, desea continuar?") = Windows.Forms.DialogResult.Yes Then
                Me._IDInternoSelecionado = -1
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                DialogResult = Windows.Forms.DialogResult.None
            End If

        End Sub

        Private Sub btnRegNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnRegNuevo.Click

            Dim strMensaje As String = ""

            strMensaje = "Se recomienda hacer minimo la búsqueda del interno en la base de datos de la sede central con la finalidad de no duplicar registros."
            If blnRealizoBusqueda = False Then
                Legolas.Configuration.Aplication.MessageBox.Information(strMensaje)
                Exit Sub
            End If

            strMensaje = "Llegado a este punto significa que en la búsqueda no se ha encontrado al interno en la base de datos de la sede central, " &
                    "por lo tanto se va a proceder a registrar al interno manualmente como nuevo, desea continuar?"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                Me._IDInternoSelecionado = -1
                Me._TipoAccion = enmTipoAccion.REGISTRO_MANUAL
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub

        Private Sub rdbPorDni_Click(sender As System.Object, e As System.EventArgs) Handles _
            rdbPorDni.Click, rdbApellidos.Click

            HabilitarBusqueda()

        End Sub

        Private Sub txtApePat_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _
            txtApePat.KeyPress, txtApeMat.KeyPress, txtNom.KeyPress, txtNumDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub


        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
            ALimpiar()
        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_ing_fec").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value).Date.ToString("dd/MM/yyyy")
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub dgwGrilla_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrilla.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            Try
                If dgwGrilla.Rows(e.RowIndex).Cells("col_pen_id").Value = Me._IDPenal Then
                    e.CellStyle.BackColor = Color.PaleGreen
                End If
            Catch ex As Exception
                Dim S As String
                S = S
            End Try
        End Sub

        Private Sub rdbPI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles rdbPI.Click, rdbPF.Click, rdbPD.Click

            ShowFotografia()

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            ShowFotografia()
        End Sub

        Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick
            ShowFotografia()
        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter
            ShowFotografia()
            'lblCodRp.Text = Me.GrillaCodigoRP
        End Sub

    End Class
End Namespace