Imports System.Linq
Imports System.ComponentModel

Namespace Registro.Main.Carceleta
    Public Class frmBuscaInternoPopup

        Enum enmTipoAccion
            SIGUIENTE_OPCION_RENIEC = 1
            IMPORTAR_REGISTRO_SEDE = 2 'permite obtener datos basicos de la sede
            REGISTRO_EXISTENTE = 3 'para modificar registro existente en la bd local
            REGISTRO_INTERNO_MANUAL = 4 'para registrar los datos del interno como nuevo manualmente.
        End Enum


        Private clickBoton As Boolean = False

        Public Property _TipoAccion As enmTipoAccion
        Public Property _IDInternoSelecionado As Integer = -1
        Public Property IDRegion As Integer = -1
        Public Property IDPenal As Integer = -1
        Private Property PerfilActual As Integer

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
        Private ReadOnly Property IDGrillaSedeInternoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = CType(Me.dgwGrilla.SelectedRows(0).Cells("col_int_id").Value, Integer)
                Catch ex As Exception
                End Try
                Return intValue
            End Get
        End Property
        Private intInternoID As Integer = -1
        Private Property InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
#Region "Grilla"


        Private ReadOnly Property GrillaVersionRegistroInterno() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_reg_ver_int").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaCodigoRP() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_cod_rp").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaPenalNombre() As String
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

        Private ReadOnly Property GrillaTipDocIdentidad() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_tip_doc").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaNumDocIdentidad() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_num_doc").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property IDGrillaInterno() As Integer
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
        Private ReadOnly Property GrillaEstadoInternoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_est_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property



#End Region

#Region "propiedades"
        Private Property TipoDocumento() As Integer
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

#Region "combo"
        Private Sub ComboTipoDocumento()
            With Me.cbbTipoDoc
                ._Todos = True
                .LoadUsc()
            End With
        End Sub
#End Region

        Private Sub ValoresxDefault()

            ComboTipoDocumento()

            Me.TipoDocumento = 10
            txtApePat.Focus()
        End Sub

        Private Function Validar() As Boolean
            Dim value As Boolean = False
            If rdbPorDni.Checked = True Then
                If Me.TipoDocumento <= 0 Then 'And txtNumDoc.Text.Trim.Length >= 5 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de documento de identidad.")
                    Return False
                End If
                If Me.TipoDocumento > 0 And txtNumDoc.Text.Trim.Length <= 5 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El número de documento de identidad parece estar incorrecta, verifique.")
                    Return False
                End If
                If Me.TipoDocumento = 10 And IsNumeric(txtNumDoc.Text.Trim) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Error, número de documento de identidad contiene letras.")
                    Return False
                End If
                If Me.TipoDocumento = 10 And txtNumDoc.Text.Trim.Length <> 8 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La cantidad de digitos del número de documento de identidad es incorrecta.")
                    Return False
                End If
            Else
                If (txtApePat.Text.Length < 3 And txtApeMat.Text.Length < 3 And txtNom.Text.Length < 3) _
                                        Or (txtApePat.Text.Length < 3 And txtApeMat.Text.Length < 3 And txtNom.Text.Length > 3) _
                                        Or (txtApePat.Text.Length < 3 And txtApeMat.Text.Length > 3 And txtNom.Text.Length < 3) _
                                        Or (txtApePat.Text.Length > 3 And txtApeMat.Text.Length < 3 And txtNom.Text.Length < 3) Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese datos al menos a dos campos.")
                    Return False
                End If

                If txtApePat.Text.Length < 3 And txtApeMat.Text.Length <= 3 And txtNom.Text.Length > 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese al menos uno de los apellidos con cuatro letras minimo.")
                    Return False
                End If
                If txtApePat.Text.Length < 3 And txtApeMat.Text.Length > 3 And txtNom.Text.Length < 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese datos al menos a dos campos con cuatro letras minimas.")
                    Return False
                End If
                If txtApePat.Text.Length > 3 And txtApeMat.Text.Length < 3 And txtNom.Text.Length < 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese datos al menos a dos campos con cuatro letras minimas.")
                    Return False
                End If
            End If
            value = True
            Return value
        End Function

        Private Sub frmBuscaInternoPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ValoresxDefault()
        End Sub

        Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
            If MsgBox("Se va a proceder la búsqueda en la RENIEC, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Me._TipoAccion = enmTipoAccion.SIGUIENTE_OPCION_RENIEC
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Exit Sub
            Else
                Exit Sub
            End If

            Me.clickBoton = True
            Me.clickBoton = False

            dgwGrilla.DataSource = Nothing
        End Sub

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
            If Validar() = False Then Exit Sub

            lblTotReg01.Text = ""

            Dim objBss As New Bussines.Registro.Interno_Grilla
            Dim objEntFiltro As New Entity.Registro.Interno_Grilla

            If rdbPorDni.Checked = True Then
                With objEntFiltro
                    .IDTipoMovimiento = Me.TipoDocumento
                    .InternoNumeroDocumento = Me.NumeroDocumento
                End With
            Else
                With objEntFiltro
                    .PrimerApellido = Me.ApellidoPaterno
                    .SegundoApellido = Me.ApellidoMaterno
                    .PreNombres = Me.Nombres
                End With
            End If

            Dim intCol As New Entity.Registro.InternoCol

            intCol = (New Bussines.Registro.Interno_Grilla).ListarNivelNacional_LM_Carceleta(objEntFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = intCol
            End With

            If intCol.Count > 0 Then
                lblTotReg01.Text = String.Format("{0:00}", intCol.Count) & " registros encontrados"
                lblTotReg01.ForeColor = Color.Black
            Else
                lblTotReg01.Text = "No se encontraron coincidencias"
                lblTotReg01.ForeColor = Color.Brown
            End If
        End Sub

        Private Sub tabFiltro_Selecting(sender As System.Object, e As System.Windows.Forms.TabControlCancelEventArgs)
            If Me.clickBoton = False Then e.Cancel = True
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            Dim idIntSel As Integer = -1
            Dim lstIntXDni As New Entity.Registro.InternoCol
            Dim newInternoPenal As Boolean = False

            If Me.IDGrillaInterno = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe buscar el interno y en caso de encontrar seleccionar el registro y presionar el botón aceptar.")
                Exit Sub
            End If

            If dgwGrilla.Item("col_pen_id", dgwGrilla.CurrentRow.Index).Value = 35 Then 'si es de carceleta
                If MsgBox("El interno ya se encuentra registrado en carceleta, desea visualizar el detalle del interno?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    idIntSel = Me.IDGrillaInterno
                Else
                    Exit Sub
                End If
            End If

            '----------- verificar si el interno se encuentra activo---------------
            If Me.GrillaEstadoInternoId = 1 And Me.GrillaPenalNombre.Length > 0 Then
                Select Case Me.GrillaIdPenal
                    Case -1 'region nunca registra interno en estado activo
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Inconsistencia de registro, no puede existir un interno en estado activo registrado por la ORL, contactarse con el administrador del sistema.")
                        Exit Sub
                    Case ListarPenidLM(Me.GrillaIdPenal) '33, 38, 39, 40, 41, 42, 43, 52, 131, 208 'penales de lima metropolitana
                        If Me.GrillaVersionRegistroInterno = "V6_LM" Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno se encuentra ACTIVO en el penal E.P. " & Me.GrillaPenalNombre & " dentro del ámbito de lima metropolitana.")
                            Exit Sub
                        Else 'si es otra version registrar como si fuera epPorvincia

                            If Me.GrillaTipDocIdentidad = 10 And Me.GrillaNumDocIdentidad.Length = 8 And IsNumeric(Me.GrillaTipDocIdentidad) = True Then 'se exceptua los demas documentos de identidad

                                lstIntXDni = (New Bussines.Registro.Interno).ListarDuplicadosXNumDoc_LM(Me.GrillaTipDocIdentidad, Me.GrillaNumDocIdentidad) 'buscar si existe en ep LM

                            End If

                            If lstIntXDni.Count > 0 Then
                                If lstIntXDni.Item(0).PenalID = 35 Then
                                    Legolas.Configuration.Aplication.MessageBox.Information("En carceleta ya existe interno registrado con el mismo DNI.")
                                Else
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No esposible completar la operación, dentro de los penales de lima metropolitana existe " & lstIntXDni.Count & " registro(s) con el mismo número de documento de identidad, " &
                                                                                        "se recomienda hacer una NUEVA BUSQUEDA por tipo y número de documento de identidad y seleccionar el registro de preferencia al que corresponde a " &
                                                                                        "algún penal de lima metropolitana para no generar duplicidad de registros.")
                                End If
                                Exit Sub
                            End If

                            ' buscar por cod_rp dentro de ep lm con version V6_LM, si no existe registrar.
                            Dim tmpInt As New Entity.Registro.Interno
                            Dim tmpIntcol As New Entity.Registro.InternoCol
                            Dim bssInt As New Bussines.Registro.Interno

                            tmpInt.CodigoRP = Me.GrillaCodigoRP
                            tmpInt.VersionRegistro = "V6_LM"
                            tmpIntcol = bssInt.Listar_LM(tmpInt)
                            If tmpIntcol.Count > 0 Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("No esposible completar la operación, dentro de los penales de lima metropolitana existe " & lstIntXDni.Count & " registro(s) con el mismo código RP.")
                                Exit Sub
                            End If

                            idIntSel = ImportIntDeProvinciaDestinoCarceleta(Me.IDGrillaInterno) 'registrar datos basicos del interno (se hace uso de ImportIntDeProvinciaDestinoCarceleta por compatibilidad)

                            If idIntSel = -1 Then
                                idIntSel = ImportIntDeProvinciaDestinoCarceleta(Me.IDGrillaInterno) 'registrar datos basicos del interno (se hace uso de ImportIntDeProvinciaDestinoCarceleta por compatibilidad)
                            End If

                            'If idIntSel > 0 Then newInternoPenal = True
                        End If
                    Case Else 'si es provincia y es activo en origen

                        If Me.GrillaTipDocIdentidad = 10 And Me.GrillaNumDocIdentidad.Length = 8 And IsNumeric(Me.GrillaTipDocIdentidad) = True Then 'se exceptua los demas documentos de identidad

                            lstIntXDni = (New Bussines.Registro.Interno).ListarDuplicadosXNumDoc_LM(Me.GrillaTipDocIdentidad, Me.GrillaNumDocIdentidad) 'buscar si existe en ep LM

                        End If

                        If lstIntXDni.Count > 0 Then
                            If lstIntXDni.Item(0).PenalID = 35 Then
                                Legolas.Configuration.Aplication.MessageBox.Information("En carceleta ya existe interno registrado con el mismo DNI.")
                            Else
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("No esposible completar la operación, dentro de los penales de lima metropolitana existe " & lstIntXDni.Count & " registro(s) con el mismo DNI. " & Chr(13) & Chr(13) &
                                                                                    "Se recomienda hacer una NUEVA BUSQUEDA por DNI y seleccionar el registro de preferencia al que corresponde a " &
                                                                                    "algún penal de lima metropolitana para no generar duplicidad de registros.")
                            End If
                            Exit Sub
                        End If

                        ' buscar por cod_rp dentro de ep lm con version V6_LM, si no existe registrar.
                        Dim tmpInt As New Entity.Registro.Interno
                        Dim tmpIntcol As New Entity.Registro.InternoCol

                        tmpInt.CodigoRP = Me.GrillaCodigoRP
                        tmpInt.VersionRegistro = "V6_LM"
                        tmpIntcol = (New Bussines.Registro.Interno).Listar_LM(tmpInt)
                        If tmpIntcol.Count > 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No esposible completar la operación, dentro de los penales de lima metropolitana existe " & tmpIntcol.Count & " registro(s) con el mismo código RP.")
                            Exit Sub
                        End If

                        If MessageBox.Show("Tenga en cuenta que el interno seleccionado se encuentra ACTIVO sin traslado ni libertad en el penal origen E.P. " & Me.GrillaPenalNombre & ", aun asi desea continuar con el proceso de registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            idIntSel = ImportIntDeProvinciaDestinoCarceleta(Me.IDGrillaInterno)

                            If idIntSel = 1 Then 'segundo intento
                                idIntSel = ImportIntDeProvinciaDestinoCarceleta(Me.IDGrillaInterno)
                            End If

                            'If idIntSel > 0 Then newInternoPenal = True
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, el interno aun no tiene movimiento de traslado o libertad en el penal origen E.P. " & Me.GrillaPenalNombre & ".")
                                Exit Sub
                            End If
                End Select

            Else '-----INACTIVO

                Select Case Me.GrillaIdPenal
                    Case -1 'significa que es un interno agregado en region
                        If Me.GrillaVersionRegistroInterno = "" Then
                            Legolas.Configuration.Aplication.MessageBox.MensajeError("Inconsistencia de registro, no puede existir internos registrados por la ORL sin versión de registro, por favor contactese con el administrador del sistema e informe de este hecho.")
                            Exit Sub
                        End If

                        idIntSel = ActualizarInternoORL_ParaCarceleta(Me.IDGrillaInterno)

                        If idIntSel > 0 Then newInternoPenal = True

                    Case ListarPenidLM(Me.GrillaIdPenal) ' 33, 38, 39, 40, 41, 42, 43, 52, 131, 208 'ep lima metropolitana

                        If MessageBox.Show("Se va a registrar como nuevo el interno seleccionado, desea continuar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                            If Me.GrillaVersionRegistroInterno = "V6_LM" _
                                Or Me.GrillaVersionRegistroInterno = "V61_LM" Or Me.GrillaVersionRegistroInterno = "V62_LM" Or Me.GrillaVersionRegistroInterno = "V63_LM" Or Me.GrillaVersionRegistroInterno = "V64_LM" _
                                Or Me.GrillaVersionRegistroInterno = "V65_LM" Or Me.GrillaVersionRegistroInterno = "V66_LM" Or Me.GrillaVersionRegistroInterno = "V67_LM" Or Me.GrillaVersionRegistroInterno = "V68_LM" _
                                Or Me.GrillaVersionRegistroInterno = "V69_LM" Or Me.GrillaVersionRegistroInterno = "V7_LM" Then

                                idIntSel = ActualizarInternoEPLM_ParaCarceleta(Me.IDGrillaInterno)

                                If idIntSel > 0 Then newInternoPenal = True
                            Else
                                'buscar x dni si existe sugerir que busque por DNI y seleccione de preferencia 
                                'el registro el cual pertenece a algun penal de LM
                                If Me.GrillaTipDocIdentidad = 10 And Me.GrillaNumDocIdentidad.Length = 8 And IsNumeric(Me.GrillaTipDocIdentidad) = True Then 'se exceptua los demas documentos de identidad

                                    lstIntXDni = (New Bussines.Registro.Interno).ListarDuplicadosXNumDoc_LM(Me.GrillaTipDocIdentidad, Me.GrillaNumDocIdentidad) 'buscar si existe en ep LM

                                End If

                                If lstIntXDni.Count > 0 Then
                                    If lstIntXDni.Item(0).PenalID = 35 Then
                                        Legolas.Configuration.Aplication.MessageBox.Information("En carceleta ya existe interno registrado con el mismo DNI.")
                                    Else
                                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No esposible completar la operación, dentro de los penales de lima metropolitana existe " & lstIntXDni.Count & " registro(s) con el mismo DNI. " & Chr(13) & Chr(13) & _
                                                                                    "Se recomienda hacer una NUEVA BUSQUEDA por DNI y seleccionar el registro de preferencia al que corresponde a " & _
                                                                                    "algún penal de lima metropolitana para no generar duplicidad de registros.")
                                    End If
                                    Exit Sub
                                End If

                                ' buscar por cod_rp dentro de ep lm con version V6_LM, si no existe registrar.
                                Dim tmpInt As New Entity.Registro.Interno
                                Dim tmpIntcol As New Entity.Registro.InternoCol

                                tmpInt.CodigoRP = Me.GrillaCodigoRP
                                tmpInt.VersionRegistro = "V6_LM"
                                tmpIntcol = (New Bussines.Registro.Interno).Listar_LM(tmpInt)
                                If tmpIntcol.Count > 0 Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No esposible completar la operación, dentro de los penales de lima metropolitana existe " & lstIntXDni.Count & " registro(s) con el mismo código RP.")
                                    Exit Sub
                                End If

                                idIntSel = ImportIntDeProvinciaDestinoCarceleta(Me.IDGrillaInterno) 'por ahora permitir duplicar (
                                If idIntSel = -1 Then 'segundo intento
                                    idIntSel = ImportIntDeProvinciaDestinoCarceleta(Me.IDGrillaInterno) 'por ahora permitir duplicar (
                                End If

                                'If idIntSel > 0 Then newInternoPenal = True

                            End If
                        Else
                            Exit Sub
                        End If

                    Case Else 'provincia
                        If MessageBox.Show("Se va a registrar como nuevo el interno seleccionado, desea continuar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

                            'buscar x dni si existe sugerir que busque por DNI y seleccione de preferencia 
                            'el registro el cual pertenece a algun penal de LM
                            If Me.GrillaTipDocIdentidad = 10 And Me.GrillaNumDocIdentidad.Length = 8 And IsNumeric(Me.GrillaTipDocIdentidad) = True Then 'se exceptua los demas documentos de identidad

                                lstIntXDni = (New Bussines.Registro.Interno).ListarDuplicadosXNumDoc_LM(Me.GrillaTipDocIdentidad, Me.GrillaNumDocIdentidad) 'buscar si existe en ep LM

                            End If

                            If lstIntXDni.Count > 0 Then
                                If lstIntXDni.Item(0).PenalID = 35 Then
                                    Legolas.Configuration.Aplication.MessageBox.Information("En carceleta ya existe interno registrado con el mismo DNI.")
                                Else
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No esposible completar la operación, dentro de los penales de lima metropolitana existe " & lstIntXDni.Count & " registro(s) con el mismo DNI. " & Chr(13) & Chr(13) & _
                                                                                    "Se recomienda hacer una NUEVA BUSQUEDA por DNI y seleccionar el registro de preferencia al que corresponde a " & _
                                                                                    "algún penal de lima metropolitana para no generar duplicidad de registros.")
                                End If
                                Exit Sub
                            End If

                            ' buscar por cod_rp dentro de ep lm con version V6_LM, si no existe registrar.
                            Dim tmpInt As New Entity.Registro.Interno
                            Dim tmpIntcol As New Entity.Registro.InternoCol

                            tmpInt.CodigoRP = Me.GrillaCodigoRP
                            tmpInt.VersionRegistro = "V6_LM"
                            tmpIntcol = (New Bussines.Registro.Interno).Listar_LM(tmpInt)

                            If tmpIntcol.Count > 0 Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("No esposible completar la operación, dentro de los penales de lima metropolitana existe " & lstIntXDni.Count & " registro(s) con el mismo código RP.")
                                Exit Sub
                            End If

                            idIntSel = ImportIntDeProvinciaDestinoCarceleta(Me.IDGrillaInterno) 'si es de penal provincia

                            If idIntSel = -1 Then 'segundo intento
                                idIntSel = ImportIntDeProvinciaDestinoCarceleta(Me.IDGrillaInterno) 'si es de penal provincia
                            End If

                            'If idIntSel > 0 Then newInternoPenal = True
                        Else
                            Exit Sub
                        End If

                End Select

            End If

            If newInternoPenal = True Then

                Dim objBssInternoPenal As New Bussines.Registro.InternoPenal
                objBssInternoPenal.Grabar(idIntSel, idIntSel, 3, 35, 0) 'baja se activa con movimiento

            End If

            If idIntSel = -1 Then Exit Sub

            Me._TipoAccion = enmTipoAccion.REGISTRO_EXISTENTE
            Me._IDInternoSelecionado = idIntSel
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End Sub
        ''' <summary>
        ''' hnrb - 30/03/2019 05:08 pm
        ''' Retorna el Id del penal en caso el penal sea de lima metropolitana, caso contrario retorna -100
        ''' </summary>
        ''' <param name="penId"></param>
        ''' <returns>Id del penal LM</returns>
        Private Function ListarPenidLM(penId As Integer) As Integer
            Dim idPen As Integer = -100
            Dim bss As New Bussines.General.Penal
            Dim ent As Entity.General.Penal
            ent = bss.Listar_v2(penId)
            If ent.PenalTipoLicenciaId = 4 Then 'si el penal de LM debe retornar el id del penal
                idPen = penId
            End If
            Return idPen
        End Function

        Private Function ActualizarInternoORL_ParaCarceleta(intId As Integer) As Integer
           Dim entInt As New Entity.Registro.Interno
            entInt.Codigo = intId
            entInt.EstadoID = 0

            Dim id As Integer = -1
            Dim outSMS As String = ""
            id = (New Bussines.Registro.Interno).ActualizarInternoORL_ParaCarceleta(entInt, outSMS)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
            End If

            Return id
        End Function

        Private Function ActualizarInternoEPLM_ParaCarceleta(intId As Integer) As Integer
            Dim entInt As New Entity.Registro.Interno
            entInt.Codigo = intId

            Dim id As Integer = -1
            Dim outSMS As String = ""
            id = (New Bussines.Registro.Interno).ActualizarInternoEP_LM_ParaCarceleta(entInt, outSMS)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
            End If

            Return id
        End Function

        Private Function ImportIntDeProvinciaDestinoCarceleta(idInternoOrigen As Integer) As Integer
            Dim entInt As Entity.Registro.Interno
            Dim bss As New Bussines.Registro.Interno
            entInt = bss.Listar_LM(idInternoOrigen)

            Dim obEntInternoOrigen As New Entity.Registro.Interno
            With obEntInternoOrigen
                .CodigoRP = entInt.CodigoRP
                .CodigoUnicoInterno = entInt.CodigoUnicoInterno
                .CodigoUnicoInternoId = entInt.CodigoUnicoInternoId
                .NombreClaveInterno = entInt.NombreClaveInterno
                .Folio = entInt.Folio
                .Libro = entInt.Libro
                .ApellidoPaterno = entInt.ApellidoPaterno
                .ApellidoMaterno = entInt.ApellidoMaterno
                .Nombres = entInt.Nombres
                .SexoID = entInt.SexoID
                .FechaNacimiento = entInt.FechaNacimiento
                .NacimientoPaisID = entInt.NacimientoPaisID
                .NacimientoPaisID = entInt.NacimientoPaisID
                .NacimientoUbigeoID = entInt.NacimientoUbigeoID
                .NacimientoOtros = entInt.NacimientoOtros
                .NacionalidadID = entInt.NacionalidadID
                .TipoDocumentoID = entInt.TipoDocumentoID
                .NumeroDocumento = entInt.NumeroDocumento
                .DomicilioUbigeoID = entInt.DomicilioUbigeoID
                .Domicilio = entInt.Domicilio
                .Obs_DNI = entInt.Obs_DNI
                .EstadoCivilID = entInt.EstadoCivilID
                .NivelAcademicoID = entInt.NivelAcademicoID
                .ProfesionID = entInt.ProfesionID
                .OcupacionID = entInt.OcupacionID
                .Discapacidad = entInt.Discapacidad
                .ComunidadAndinaID = entInt.ComunidadAndinaID
                .ComunidadAndinaEspID = entInt.ComunidadAndinaEspID
                .Obs = entInt.Obs
                .PabellonID = entInt.PabellonID
                .PabellonNombre = entInt.PabellonNombre
                .Decadactilar = entInt.Decadactilar
                .Homonimia = entInt.Homonimia
                .GeneroId = entInt.GeneroId
                .ReligionId = entInt.ReligionId
                .CentroTrabajo = entInt.CentroTrabajo
                .CodigoFuerzaArmadaId = entInt.CodigoFuerzaArmadaId
                .CodigoRangoId = entInt.CodigoRangoId
                .IdiomaNativoId = entInt.IdiomaNativoId
                .NombreClaveInterno = entInt.NombreClaveInterno
                .SituacionJuridicaId = entInt.SituacionJuridicaId

                .EstadoID = 0
                .RegionID = 3 'region lima
                .PenalID = 35 'carceleta lima
                .EstadoEspecificoID = 1 'recluido
                .EstadoRncID = entInt.EstadoRncID
                .VersionRegistro = "V6_LM"
            End With

            Dim id As Integer = -1
            Dim outSMS As String = ""
            id = (New Bussines.Registro.Interno).Grabar_Carceleta(obEntInternoOrigen, outSMS)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
            End If

            Return id
        End Function

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            If MsgBox("Se va a cancelar la operación de registro, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Me._IDInternoSelecionado = -1
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                DialogResult = Windows.Forms.DialogResult.None
            End If
        End Sub

        Private Sub txtNumDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNumDoc.KeyDown
            If e.KeyCode = Keys.Enter Then btnBuscar.PerformClick()
        End Sub

        Private Sub rdbPorDni_Click(sender As Object, e As System.EventArgs) Handles rdbPorDni.Click
            GroupBox1.Enabled = True
            gbApe.Enabled = False
            txtNumDoc.Focus()
        End Sub

        Private Sub rdbApellidos_Click(sender As Object, e As System.EventArgs) Handles rdbApellidos.Click
            GroupBox1.Enabled = False
            gbApe.Enabled = True
            txtApePat.Focus()
        End Sub

        Private Sub btnRegNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnRegNuevo.Click
            If MsgBox("Se va a proceder a registrar los datos manualmente, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Me._TipoAccion = enmTipoAccion.REGISTRO_INTERNO_MANUAL
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Exit Sub
            End If
        End Sub

        Private Sub txtApeMat_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtApeMat.KeyDown, txtApePat.KeyDown, txtNom.KeyDown
            If e.KeyCode = Keys.Enter Then btnBuscar.PerformClick()
        End Sub
        Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            'Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
            'If Me.BackgroundWorker1.CancellationPending = True Then
            '    e.Cancel = True
            'Else
            '    e.Result = Listar(worker, e)
            'End If
        End Sub
        Private Sub dgwGrilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            ShowFotografia()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Private Sub ShowFotografia()

            If Me.UscFotografia_2v1._CheckImagen = False Or Me.IDGrillaSedeInternoId < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            If Me.InternoID = Me.IDGrillaSedeInternoId And Me.UscFotografia_2v1._HasImagen = True And PerfilFotografia = PerfilActual Then
                'nada
            Else

                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEnt As New Entity.Registro.InternoFoto
                Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente2(Me.IDGrillaSedeInternoId)
                Dim strRutServer As String = ""
                Dim intImagen As Integer = -1
                Dim intNombreImagen As String = ""

                objBssFoto = New Bussines.Registro.InternoFoto
                objEnt = objBssFoto.ListarGrilla(intCodigo)

                If objEnt.Codigo > 0 Then

                    With objEnt
                        Select Case Me.PerfilFotografia
                            Case 1 'izquierdo
                                PerfilActual = 1
                                intImagen = .PIzquierdoID
                                intNombreImagen = .PIzquierdoName
                                strRutServer = .PIzquierdoServerPath
                            Case 2 'frente
                                PerfilActual = 2
                                intImagen = .PFrenteID
                                intNombreImagen = .PFrenteName
                                strRutServer = .PFrenteServerPath
                            Case 3 'derecho
                                PerfilActual = 3
                                intImagen = .PDerechoID
                                intNombreImagen = .PDerechoName
                                strRutServer = .PDerechoServerPath
                        End Select
                    End With

                    Me.UscFotografia_2v1._ShowFotoInterno(intImagen)
                    Me.InternoID = Me.IDGrillaSedeInternoId
                Else
                    Me.UscFotografia_2v1._Limpiar()
                End If

            End If






        End Sub

        Private Sub rdbPI_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPI.Click, rdbPF.Click, rdbPD.Click
            ShowFotografia()
        End Sub
    End Class
End Namespace