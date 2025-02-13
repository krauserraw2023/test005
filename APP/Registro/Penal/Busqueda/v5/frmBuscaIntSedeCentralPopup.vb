Option Strict On
Imports System.ComponentModel
Imports System.Linq
Imports System.Runtime.InteropServices

Namespace Registro.Penal.Busqueda.v5
    Public Class frmBuscaIntSedeCentralPopup

        Private frmLoad As Load.frmProcesando = Nothing
        Private blnRealizoBusqueda As Boolean = False
#Region "Enum"
        Enum enmTipoAccion
            SIGUIENTE_OPCION_RENIEC = 1
            IMPORTAR_REGISTRO_SEDE = 2 'permite obtener datos basicos de la sede
            REGISTRO_EXISTENTE = 3 'para modificar registro existente en la bd local
            REGISTRO_MANUAL = 4
        End Enum
#End Region
#Region "Propiedades"
        Private Property IDInternoSeleccion() As Integer = -1
        Private Property PerfilActual As Integer
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
#End Region
#Region "Propiedades_Publicas"
        Public Property _TipoAccion As enmTipoAccion
        Public Property _IDInternoSelecionado As Integer = -1
        Public Property _IDRegion As Integer = -1
        Public Property _IDPenal As Integer = -1
#End Region
#Region "Propiedades_Grilla"
        'Private ReadOnly Property GrillaInternoID() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        Try
        '            intValue = CType(Me.dgwGrilla.SelectedRows(0).Cells("col_int_id").Value, Integer)
        '        Catch ex As Exception
        '        End Try
        '        Return intValue
        '    End Get
        'End Property
        'Private ReadOnly Property GrillaPenalID() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        Try
        '            intValue = CType(Me.dgwGrilla.SelectedRows(0).Cells("col_pen_id").Value, Integer)
        '        Catch ex As Exception
        '        End Try
        '        Return intValue
        '    End Get
        'End Property
        Private ReadOnly Property GrillaCodigoRP() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_cod_rp").Value.ToString
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
                        intValue = .SelectedRows(0).Cells("col_ape_pat").Value.ToString
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
                        intValue = .SelectedRows(0).Cells("col_ape_mat").Value.ToString
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
                        intValue = .SelectedRows(0).Cells("col_nom").Value.ToString
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDInternoSede() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = CType(.SelectedRows(0).Cells("col_int_id").Value, Integer)
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
                        intValue = CType(.SelectedRows(0).Cells("col_reg_id").Value, Integer)
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDPenal() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = CType(.SelectedRows(0).Cells("col_pen_id").Value, Integer)
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
                        intValue = .SelectedRows(0).Cells("col_pen_nom").Value.ToString
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoInternoID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = CType(.SelectedRows(0).Cells("col_est_id").Value.ToString, Integer)
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoInternoNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_est_nom").Value.ToString
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
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

            'validar el acceso a la url de inpe
            If Legolas.Components.PC.IsOnline = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("En este momento no se puede realizar la busqueda. Verifique su conexion de internet.")
                Return value
            End If

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

                    If Me.Nombres.Trim.Length < 3 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese al menos un nombre en la busqueda de internos")
                        Me.txtNom.Focus()
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
                        .TipoDocumentoID = CType(Me.IDTipoDocumento, Short)
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
            ws.Url = APPWebService.PathURL.ws_sede_plm_Interno.ToString

            Try
                ws.getFecha()
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.Exclamation("En estos momentos el servicio de la Sede Central no está disponible, intente luego de unos instantes, caso contrario comunique al administrador de sistema o realice el registro manualmente.")
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
                        Else
                            lblTotReg01.Text = "No se encontraron coincidencias"
                            lblTotReg01.ForeColor = Color.Brown
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

            If Me.UscFotografia_2v1._CheckImagen = False Or Me.GrillaIDInternoSede < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            If Me.IDInternoSeleccion = Me.GrillaIDInternoSede And Me.UscFotografia_2v1._HasImagen = True And Me.PerfilFotografia = PerfilActual Then
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
                Me.IDInternoSeleccion = Me.GrillaIDInternoSede
            End If

        End Sub

#End Region
#Region "Validar"
        Private Function ValidarCaracteresDNI(strNumero As String) As Boolean

            Dim value As Boolean = True

            For Each c As Char In strNumero
                If IsNumeric(c) = False Then
                    value = False
                    Exit For
                End If
            Next

            Return value
        End Function
        Private Function ValidarTipoDocumento(intIDTipoDocumento As Short, strNumeroDocumento As String) As Boolean

            Dim value As Boolean = False

            If intIDTipoDocumento > 0 And strNumeroDocumento.Trim.Length > 3 Then

                Select Case intIDTipoDocumento
                    Case 10 'dni

                        If strNumeroDocumento.Length = 8 Then
                            value = True
                        Else
                            value = ValidarCaracteresDNI(strNumeroDocumento)
                        End If

                    Case Else
                        value = True
                End Select

            End If

            Return value

        End Function
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
            Me.UscFotografia_2v1._Limpiar()

        End Sub
#End Region

        Private Sub frmBuscaInternoPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ValoresxDefault()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            'jmr, 17.09.2019
            'validar que exista al menos un registro
            If Me.GrillaIDInternoSede = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe buscar el interno y en caso de encontrar seleccionar el registro y presionar el botón aceptar.")
                Exit Sub
            End If

            Dim strMensajebox As String = "Desea registrar al interno como nuevo registro. ?" & vbCrLf &
                                            "Si acepta, se generará un nuevo registro con sus datos" & vbCrLf &
                                            "basicos del penal de origen." & vbCrLf

            If MessageBox.Show(strMensajebox, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then
                Exit Sub
            End If

            'validar que el interno se inactivo en el penal de origen
            If Me.GrillaEstadoInternoID = 1 Then 'si interno activo en el origen
                strMensajebox = "El interno se encuentra en estado activo en el penal de " & GrillaIdPenalNombre + Chr(13) +
                        "____________________________________________________________"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajebox)
                Exit Sub
            End If

            'validar que el interno se encuentre activo
            If Me.GrillaEstadoInternoNombre = "ACTIVO" Then
                strMensajebox = "El interno se encuentra en estado activo en el penal de " & GrillaIdPenalNombre + Chr(13) +
                                        "____________________________________________________________"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajebox)
                Exit Sub
            End If

            'validar que los registros de la busqueda a nivel nacional sea distinto al penal 
            If Me.GrillaIDPenal = Me._IDPenal Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Inconsistencia, no es posible realizar traslado hacia el mismo penal.")
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim strMensajeSalida As String = ""
            Dim blnContinuarProceso As Boolean = True
            Dim blnGrabarInterno As Boolean = False

            Dim objEntInternoCol As New Entity.Registro.InternoCol
            Dim objBssInternoGrilla As New Bussines.Registro.Interno_Grilla
            Dim objBssInterno As New Bussines.Registro.Interno
            Dim objEntInternoGrilla As New Entity.Registro.Interno_Grilla
            Dim objEntInterno As New Entity.Registro.Interno

            'buscar el interno
            With objEntInternoGrilla
                .InternoCodigoRP = Me.GrillaCodigoRP
                .PrimerApellido = Me.GrillaApePaterno
                .SegundoApellido = Me.GrillaApeMaterno
                .PreNombres = Me.GrillaNombres
                .IDPenal = CType(Me._IDPenal, Short)
            End With

            objEntInternoCol = objBssInternoGrilla.ListarInternoBusqueda(objEntInternoGrilla)

            If objEntInternoCol.Count > 0 Then 'si el interno existe en la bd del penal 
                If objEntInternoCol.Count = 1 Then ' si solo hay un registro en la bd del penal 

                    strMensajebox = "El Interno :" & Chr(13) &
                                            Me.GrillaApePaterno & " " & Me.GrillaApeMaterno & " " & Me.GrillaNombres & Chr(13) &
                                            " ya se encuentra en el penal local." & Chr(13) &
                                            "------------------------------" & Chr(13) &
                                            "Desea visualizar los datos del interno?"


                    If Legolas.Configuration.Aplication.MessageBox.Question(strMensajebox) = DialogResult.Yes Then
                        blnContinuarProceso = False
                        Me._IDInternoSelecionado = objEntInternoCol.Item(0).Codigo
                        Me._TipoAccion = enmTipoAccion.REGISTRO_EXISTENTE
                        DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        blnContinuarProceso = False
                    End If

                Else 'si existe mas de un duplicado por datos personales.
                    Legolas.Configuration.Aplication.MessageBox.Question("Existen " & objEntInternoCol.Count & " registros en el penal con los nombres " & Chr(13) &
                                                                            Me.GrillaApePaterno & " " & Me.GrillaApeMaterno & " " & Me.GrillaNombres & " Codigo RP: " & Me.GrillaCodigoRP & Chr(13) &
                                                                            "verificar y corregir los datos de los internos.")
                    blnContinuarProceso = False
                End If
            Else

                objEntInternoGrilla.InternoCodigoRP = "" 'no enviar el codigo rp del penal de origen
                objEntInternoCol = objBssInternoGrilla.ListarInternoBusqueda(objEntInternoGrilla)
                If objEntInternoCol.Count > 0 Then

                    strMensajebox = "Se han encontrado coincidencias x nombres del Interno :" & Chr(13) &
                        Me.GrillaApePaterno & " " & Me.GrillaApeMaterno & " " & Me.GrillaNombres & Chr(13) &
                            "Se encuentra en el Penal local, pero con diferente Codigo RP." & Chr(13) &
                            "------------------------------------------------------------" & Chr(13) &
                            "De todas maneras desea registrar el interno en el Penal?"

                    If MessageBox.Show(strMensajebox, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        blnGrabarInterno = True
                    Else
                        blnContinuarProceso = False
                    End If

                End If

            End If

            'validar el proceso
            If blnContinuarProceso = True Then

                objBssInternoGrilla = New Bussines.Registro.Interno_Grilla
                objEntInternoGrilla = New Entity.Registro.Interno_Grilla
                objEntInternoCol = New Entity.Registro.InternoCol

                Dim strNumDoc As String = ""
                Dim intIDTipoDoc As Short = -1

                intIDTipoDoc = CType(dgwGrilla.Item("col_tip_doc_id", dgwGrilla.CurrentRow.Index).Value, Short)
                strNumDoc = dgwGrilla.Item("col_num_doc", dgwGrilla.CurrentRow.Index).Value.ToString

                If ValidarTipoDocumento(intIDTipoDoc, strNumDoc) = True Then

                    'buscar al interno
                    With objEntInternoGrilla
                        .InternoNumeroDocumento = strNumDoc
                        .IDTipoDocIdentidad = intIDTipoDoc
                        .IDRegion = CType(Me._IDRegion, Short)
                        .IDPenal = CType(Me._IDPenal, Short)
                    End With

                    objEntInternoCol = objBssInternoGrilla.ListarInternoBusqueda(objEntInternoGrilla)

                    If objEntInternoCol.Count > 0 Then 'existen x coincidencias de registros con el mismo numero de documento de identidad.
                        Dim strCodigo As String = ""
                        Dim tmpIntId As Integer = -1
                        Dim intEstado As Integer = 0

                        For Each objInterno As Entity.Registro.Interno In objEntInternoCol
                            tmpIntId = objInterno.Codigo
                            intEstado = objInterno.EstadoID

                            strCodigo = strCodigo & "CodRp: " & objInterno.CodigoRP & "," + Chr(13) +
                                    "Nombres: " & objInterno.ApellidosyNombres & ". " + Chr(13) +
                                    objInterno.TipoDocumentoNombre & ": " & objInterno.NumeroDocumento & vbCrLf
                        Next

                        If objEntInternoCol.Count = 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno: " & GrillaApePaterno & " " & GrillaApeMaterno & " " & GrillaNombres + Chr(13) +
                                                                                    "con N° de DNI : " & objEntInternoGrilla.InternoNumeroDocumento & " se encuentra en el penal.")
                            blnGrabarInterno = False
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Se han encontrado las siguientes coincidencias x número de documento de identidad." & vbCrLf &
                                                                                "---------------------------------------------------------------------------" & vbCrLf &
                                                                                strCodigo & vbCrLf &
                                                                                "Debe resolver la duplicidad de número de documento de identidad en el Penal.")
                            blnGrabarInterno = False
                        End If
                    Else
                        blnGrabarInterno = True
                    End If

                Else
                    'no tiene dni y tipo documento (en blanco)
                    blnGrabarInterno = True
                End If
            End If

            'grabar el interno desde la sede
            If blnGrabarInterno = True Then

                Dim intIDInterno As Integer = -1
                Dim objBss As New Bussines.Transferencia.ImportarInterno(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)

                intIDInterno = objBss.SedeCentral_a_Provincia(intIDInterno, Me.GrillaIDInternoSede, Me._IDPenal, Me._IDRegion, strMensajeSalida)

                If intIDInterno > 0 Then
                    Me._IDInternoSelecionado = intIDInterno
                    Me._TipoAccion = enmTipoAccion.REGISTRO_EXISTENTE
                    DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo registrar los datos del interno" & strMensajeSalida)
                End If
            End If
            Me.Cursor = Cursors.Default

        End Sub

        'Private Function RegistrarIntDatBasicoEPProv(idInternoSede As Integer, ByRef outSMS As String) As Integer

        '    Return (New Bussines.Transferencia.RecepcionInternoTraslado(Me._IDRegion, Me._IDPenal)).RecepcionTrasladoOrigenEPProv(idInternoSede, outSMS)

        'End Function
        'Private Function DatosBasicosInternoSede(idInternoSede As Integer, ByRef outSMS As String) As Integer

        '    Return (New Bussines.Transferencia.RecepcionInternoTraslado(Me._IDRegion, Me._IDPenal)).DatosBasicosInternoSede(idInternoSede, outSMS)

        'End Function


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

            Dim strMensaje As String = "Se recomienda hacer minimo la búsqueda del interno en la" + Chr(13) +
                                       "base de datos de la sede central con la finalidad de no duplicar registros." + Chr(13) +
                                       "__________________________________________________________" + Chr(13) +
                                       "A pesar de esta recomendacion usted deseae registrar a un" + Chr(13) +
                                       "interno como nuevo, esta informacion quedara auditada."
            If blnRealizoBusqueda = False Then
                If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                    Me._IDInternoSelecionado = -1
                    Me._TipoAccion = enmTipoAccion.REGISTRO_MANUAL
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
                Exit Sub
            End If

            strMensaje = "Llegado a este punto significa que en la búsqueda no se ha encontrado al interno en la base de datos de la sede central, " + Chr(13) +
                    "Se va a proceder a registrar los datos manualmente como nuevo, desea continuar?"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                Me._IDInternoSelecionado = -1
                Me._TipoAccion = enmTipoAccion.REGISTRO_MANUAL
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Exit Sub
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
            Me.UscFotografia_2v1._Limpiar()

        End Sub


        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
            ALimpiar()
        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_ing_fec").Index
                        If IsNumeric(e.Value) And CType(e.Value, Long) > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(CType(e.Value, Long)).Date.ToString("dd/MM/yyyy")
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub dgwGrilla_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrilla.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            Try
                If CType(dgwGrilla.Rows(e.RowIndex).Cells("col_pen_id").Value, Integer) = Me._IDPenal Then
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
            'ShowFotografia()
        End Sub

        Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick
            ShowFotografia()
        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter
            ShowFotografia()
        End Sub
        Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

            'validar el acceso a la url de inpe
            If Legolas.Components.PC.IsOnline = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("En este momento no se puede realizar la busqueda. Verifique su conexion de internet.")
                Exit Sub
            End If

            If MessageBox.Show("Se va a proceder la búsqueda en la RENIEC, desea continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me._TipoAccion = enmTipoAccion.SIGUIENTE_OPCION_RENIEC
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Exit Sub
            End If

            Me.dgwGrilla.DataSource = Nothing

        End Sub

        Private Sub frmBuscaIntSedeCentralPopup_Load(sender As Object, e As EventArgs) Handles Me.Load

            Me.UscFotografia_2v1._PanelCheck = False
            Me.pnlFoto.Visible = True
        End Sub

    End Class
End Namespace