Imports System.Linq

Namespace Registro.Carceleta.Identificacion
    Public Class frmIngresoPopup_V2
        Private objBss As Bussines.Registro.Ingreso = Nothing
        Private objBssInp As Bussines.Registro.IngresoInpe = Nothing
        Private objEntCol As Entity.Registro.IngresoCol = Nothing
        Private objEntInpCol As Entity.EntityCol(Of Entity.Registro.IngresoInpe) = Nothing

        Private blnCargaGrilla As Boolean = False
#Region "Propiedades_Publicas"
        Public Property _IDRegion As Integer = -1
        Public Property _IDPenal As Integer = -1
        Public Property _IDInterno As Long = -1
        Public Property _AgregarNuevoIngreso As Boolean = False
        Public Property _EstadoInternoCarceleta As Integer = 0 'inactivo =0, activo=1
#End Region
#Region "Propiedades"
        Private Property Codigo As Long = -1
        Private Property RegistroCreaPenalID As Long = -1
        Private Property NumeroIngreso() As Integer
            Get
                Try
                    Return Integer.Parse(Me.NumericUpDown1.Value)
                Catch ex As Exception

                End Try
            End Get
            Set(ByVal value As Integer)
                Try
                    Me.NumericUpDown1.Value = value
                Catch ex As Exception

                End Try
            End Set
        End Property

        Private Property IDMovimientoTipo() As Integer
            Get
                Return Me.cbbMovTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovTipo.SelectedValue = value
            End Set
        End Property

        Private Property IDMovimientoMotivo() As Integer
            Get
                Return Me.cbbMovMotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovMotivo.SelectedValue = value
            End Set
        End Property
        Private Property FechaISP As Long
            Get
                Return Me.dtpFechaIngresoISP.ValueLong
            End Get
            Set(value As Long)
                Me.dtpFechaIngresoISP.ValueLong = value
            End Set
        End Property
        Private Property FechaMovIngresoEP As Long
            Get
                Return Me.dtpFechaMovIngEP.ValueLong
            End Get
            Set(value As Long)
                Me.dtpFechaMovIngEP.ValueLong = value
            End Set
        End Property
        Private Property HoraMovimiento() As String
            Get
                Return Me.nudHora._Value
            End Get
            Set(ByVal value As String)
                Me.nudHora._Value = value
            End Set
        End Property
        Private Property MinutoMovimiento() As String
            Get
                Return Me.nudMinutos._Value
            End Get
            Set(ByVal value As String)
                Me.nudMinutos._Value = value
            End Set
        End Property
        Private ReadOnly Property FechaIngresoyHora As Long
            Get
                Dim value As Long = 0

                Dim strHora As String = ""
                Dim strHor As String = Me.HoraMovimiento
                Dim strMin As String = Me.MinutoMovimiento

                strHora = Legolas.Components.Cadena.Format(strHor, "00") & ":" & Legolas.Components.Cadena.Format(strMin, "00")

                value = Legolas.Components.FechaHora.FechaTimeLong(Me.FechaMovIngresoEP, strHora)

                Return value
            End Get

        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtobservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtobservacion.Text = value
            End Set
        End Property
        Private Property ObservacionMovimiento As String = ""
        'Private ReadOnly Property IDMovimientoInternamiento As Long
        '    Get
        '        Dim value As Long = -1

        '        Dim objEntMovFiltro As New Entity.Registro.InternoMovimiento
        '        Dim objBss As New Bussines.Registro.InternoMovimiento
        '        Dim objEntMovCol As New Entity.Registro.InternoMovimientoCol

        '        With objEntMovFiltro
        '            .InternoID = Me._IDInterno
        '            .IngresoID = Me.Codigo
        '            .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
        '            .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
        '        End With
        '        objEntMovCol = objBss.ListarGrilla(objEntMovFiltro)

        '        For Each obj As Entity.Registro.InternoMovimiento In objEntMovCol
        '            value = obj.Codigo
        '            Me.ObservacionMovimiento = obj.Observacion
        '        Next

        '        Return value

        '    End Get
        'End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDIngresoINPE() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIngreso
                        intValue = .SelectedRows(0).Cells("col_ing_inp_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDPenalCreaReg() As Short
            Get
                Dim value As Short = -1
                Try
                    With Me.dgwIngreso
                        value = .SelectedRows(0).Cells("col_pen_id_crea_reg").Value
                    End With
                Catch ex As Exception

                End Try

                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaNomPenalCreaReg() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwIngreso
                        value = .SelectedRows(0).Cells("Column1").Value
                    End With
                Catch ex As Exception

                End Try

                Return value
            End Get
        End Property
        'Private ReadOnly Property GrillaIDIngreso() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        Try
        '            With Me.dgwIngreso
        '                intValue = .SelectedRows(0).Cells("col_ing_id").Value
        '            End With
        '        Catch ex As Exception

        '        End Try

        '        Return intValue
        '    End Get
        'End Property
#End Region
#Region "Combo"

        Private Sub ComboMovimientoTipo()

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovTipo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoTipo
            End With

        End Sub

        'cuando es un ingreso que registrado por ORL y es de tipo PLD
        Private Sub ComboMovimientoTipo_ORL()

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovTipo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoTipo_ORL
            End With

        End Sub

        Private Sub ComboMovimientoMotivo()

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovMotivo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoMotivo_LM(Me.IDMovimientoTipo, Type.Combo.enmTipoTexto.Mayuscula)
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me._IDInterno < 1 Or Me.GrillaIDIngresoINPE < 1 Then
                Exit Sub
            End If

            objBssInp = New Bussines.Registro.IngresoInpe
            Dim objEnt As New Entity.Registro.IngresoInpe
            Dim entIng As New Entity.Registro.Ingreso
            Dim lstEntIng As Entity.EntityCol(Of Entity.Registro.Ingreso)

            objEnt = objBssInp.Listar(Me.GrillaIDIngresoINPE)
            entIng.IngresoInpeId = objEnt.Codigo
            lstEntIng = (New Bussines.Registro.Ingreso).Listar_LM(entIng)

            If lstEntIng Is Nothing OrElse lstEntIng.Count = 0 Then
            Else
                entIng = lstEntIng.Item(0)
            End If

            cbbMovTipo.DataSource = Nothing

            If objEnt.IDTipoMovimiento = 7 Then
                ComboMovimientoTipo_ORL()
            Else
                ComboMovimientoTipo()
            End If

            With objEnt
                Me.Codigo = .Codigo
                Me.NumeroIngreso = .IngresoNro
                Me.IDMovimientoTipo = .IDTipoMovimiento
                Me.IDMovimientoMotivo = .MotivoIngresoID
                Me.FechaISP = .FechaISP
                Me.FechaMovIngresoEP = entIng.FechaIngreso ' .FechaMovimientoIngreso

                If entIng.FechaIngreso > 0 Then
                    Dim dteFechaIng As Date = Now
                    dteFechaIng = Legolas.Components.FechaHora.FechaDate(entIng.FechaIngreso, True)

                    Me.HoraMovimiento = dteFechaIng.Hour
                    Me.MinutoMovimiento = dteFechaIng.Minute
                Else
                    Me.HoraMovimiento = 0
                    Me.MinutoMovimiento = 0
                End If

                Me.Observacion = .Observacion
                Me.RegistroCreaPenalID = .RegistroCreaPenalID
            End With

            Me.UscAuditUser1.LoadAudit(Me.GrillaIDIngresoINPE, Type.Enumeracion.Auditoria.EnumTipTabla.int_mov_interno_ingreso_inpe)
        End Sub

        Private Sub ListarGrilla()

            If Me._IDInterno < 1 Then Exit Sub

            blnCargaGrilla = False

            Dim objEntFiltro As New Entity.Registro.IngresoInpe
            objBssInp = New Bussines.Registro.IngresoInpe
            objEntInpCol = New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            objEntFiltro.InternoID = Me._IDInterno
            objEntInpCol = objBssInp.Listar_Grilla(objEntFiltro)

            'ordenar
            Dim l2 As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            Dim res = From d As Entity.Registro.IngresoInpe In objEntInpCol Order By d.IngresoNro Descending, d.FechaIngInpe Descending

            For Each obj As Entity.Registro.IngresoInpe In res
                l2.Add(obj)
            Next

            With Me.dgwIngreso
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = l2 ' IIf(Me._IngresoInpe = True, objEntInpCol, objEntCol)
            End With

            Me.lblCount.Text = dgwIngreso.RowCount & " Reg."

            blnCargaGrilla = True

        End Sub
#End Region
#Region "Validar"
        Private Function ValidarDatos() As Boolean

            Dim value As Boolean = False

            If Me.FechaISP > Now.ToFileTime Then
                MessageBox.Show("La fecha ISP no puede ser futura, verifique",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.NumericUpDown1.Focus()
                Return value
            End If

            If Me.FechaMovIngresoEP > Now.ToFileTime Then
                MessageBox.Show("La fecha de movimiento de ingreso no puede ser futura.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.NumericUpDown1.Focus()
                Return value
            End If
            'interno id
            If Me._IDInterno < 1 Then
                MessageBox.Show("Seleccione el interno antes de grabar", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return value
            End If

            '/*numero de ingreso minimo
            If Me.NumeroIngreso < 1 Then
                MessageBox.Show("El numero de ingreso no puede ser menor a 1",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.NumericUpDown1.Focus()
                Return value
            End If

            '/*numero de ingreso maximo
            If Me.NumeroIngreso > 99 Then
                MessageBox.Show("El numero de ingreso no puede ser mayor a 99",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.NumericUpDown1.Focus()
                Return value
            End If
            '/*Tipo Mov*/
            If Me.IDMovimientoTipo < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de Internamiento")
                Me.cbbMovTipo.Focus()
                Return value
            End If
            '/*motivo*/
            If Me.IDMovimientoMotivo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el motivo de Internamiento")
                Me.cbbMovMotivo.Focus()
                Return value
            End If

            '/*fecha de ingreso  al sistema penietenciario
            If Me.FechaISP < 1 Then
                MessageBox.Show("Ingrese fecha de ingreso al Sistema Penitenciario.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dtpFechaIngresoISP.Focus()
                Return value
            End If

            '/*fecha de ingreso  al sistema penietenciario
            If Me.FechaMovIngresoEP < 1 Then
                MessageBox.Show("Ingrese fecha de ingreso.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dtpFechaMovIngEP.Focus()
                Return value
            End If

            'validar numero de ingresos abiertos
            'Dim objBssIngInpe As New Bussines.Registro.IngresoInpe
            'If objBssIngInpe.ValidarNumeroIngresoAbierto(Me._IDInterno, Me._IDRegion, Me._IDPenal) > 3 Then
            '    MessageBox.Show("Solo puede existir 3 ingresos sin libertad como maximo.",
            '    Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.dtpFechaMovIngEP.Focus()
            '    Return value
            'End If

            'validar numeros de ingresos duplicados
            For Each fila As DataGridViewRow In Me.dgwIngreso.Rows

                If Me.Codigo <> fila.Cells("col_ing_inp_id").Value Then

                    If Me.NumeroIngreso = fila.Cells("col_ing_nro").Value Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El numero de ingreso ya existe, cambie los datos.")
                        value = False
                        Me.NumericUpDown1.Focus()
                        Return value
                    End If
                End If

            Next

            value = True

            Return value
        End Function

#End Region
#Region "Accion"
        Private Function AGrabar() As Boolean
            Dim objMovimiento As New Entity.Registro.InternoMovimiento
            Dim value As Boolean = False
            Dim idIngPen As Integer = -1

            If ValidarDatos() = False Then
                Return value
            End If

            idIngPen = AGrabarInpe()

            objBss = New Bussines.Registro.Ingreso
            Dim objEnt As New Entity.Registro.Ingreso
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Ingreso)
            Dim movIngNuevo As Boolean = True
            Dim entMovCol As New Entity.Registro.InternoMovimientoCol

            objEnt.IngresoInpeId = idIngPen
            objEnt.PenalID = Me._IDPenal
            objEnt.RegionID = Me._IDRegion

            objEntCol = objBss.Listar_LM(objEnt)
            If objEntCol.Count > 0 Then
                objEnt = objEntCol.Item(0)

                movIngNuevo = False

                objMovimiento.InternoID = Me._IDInterno
                objMovimiento.IngresoInpeId = Me.Codigo
                objMovimiento.MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                objMovimiento._PenalID = Me._IDPenal

                entMovCol = (New Bussines.Registro.InternoMovimiento).Listar_LM_v2(objMovimiento)

                If Not entMovCol Is Nothing AndAlso entMovCol.Count > 0 Then
                    'obtener el ultimo movimiento de ingreso
                    objMovimiento = entMovCol.InternoMovimiento(0)
                    For Each mov As Entity.Registro.InternoMovimiento In entMovCol
                        If mov.Fecha > objMovimiento.Fecha Then
                            objMovimiento = mov
                        End If
                    Next

                End If

                Select Case objMovimiento.MovimientoTipoID
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento,
                        Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                    Case Else
                        objMovimiento = New Entity.Registro.InternoMovimiento
                End Select
            End If

            With objEnt
                .InternoID = Me._IDInterno
                .IngresoInpeId = idIngPen
                .IngresoNro = Me.NumeroIngreso
                .IDMovimientoTipo = If(objEnt.Codigo = -1, Me.IDMovimientoTipo, objEnt.IDMovimientoTipo) 'solo si es nuevo
                .MotivoIngresoID = If(objEnt.Codigo = -1, Me.IDMovimientoMotivo, objEnt.MotivoIngresoID) 'solo si es nuevo
                .FechaISP = Me.FechaISP
                .FechaIngreso = Me.FechaIngresoyHora
                .Observacion = If(objEnt.Codigo = -1, Me.Observacion, objEnt.Observacion)
                .RegionID = Me._IDRegion
                .PenalID = Me._IDPenal
            End With

            '/*verificar si el numero nuevo numero de ingreso es mayor al anterior*/
            Dim objEntNroIngresoInpeCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            Dim objBssIngInpe As New Bussines.Registro.IngresoInpe
            Dim lngIDIngresoInpeId As Long = -1

            Dim objEntFiltroIngInpe As New Entity.Registro.IngresoInpe
            With objEntFiltroIngInpe
                .Codigo = idIngPen
                .InternoID = Me._IDInterno
            End With

            objEntNroIngresoInpeCol = objBssIngInpe.Listar_Grilla(objEntFiltroIngInpe)

            For Each obj As Entity.Registro.IngresoInpe In objEntNroIngresoInpeCol
                If Me.NumeroIngreso > obj.IngresoNro Then
                    lngIDIngresoInpeId = obj.Codigo
                    Exit For
                End If
            Next

            '/*grabar el ingreso del interno*/
            Dim intValue As Integer = -1
            Dim blnGrabarOK As Boolean = False
            intValue = objBss.Grabar_LM(objEnt, "")

            If intValue > 0 Then blnGrabarOK = True

            If idIngPen > 0 And movIngNuevo = True Then
                '/*grabar el movimiento de internamiento  --   o traslado de ingreso*/
                objMovimiento.Codigo = -1
                objMovimiento.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                AGrabarMovimiento(objMovimiento, idIngPen, intValue)
                If Me.Codigo < 1 Then
                    '/*grabar la copia del la tabla interno_historico*/
                    Dim intValueHis As Integer = -1
                    Dim objBssHis As New Bussines.Registro.InternoHistorico
                    'faltaaaaaaaaaaaa--->
                    intValueHis = objBssHis.Grabar_HistoricoCopia_LM(Me._IDInterno, lngIDIngresoInpeId, intValue, idIngPen, Me._IDRegion, Me._IDPenal)
                End If
                blnGrabarOK = True
            ElseIf idIngPen > 0 And movIngNuevo = False Then
                If objMovimiento.EstadoID < 1 Then
                    objMovimiento.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                End If
                AGrabarMovimiento(objMovimiento, idIngPen, intValue)
            End If

            Me.Codigo = idIngPen

            If blnGrabarOK = True Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If

            value = True

            Return value

        End Function
        Private Function AGrabarInpe() As Integer

            Dim value As Integer = -1

            objBssInp = New Bussines.Registro.IngresoInpe
            Dim objEnt As New Entity.Registro.IngresoInpe
            With objEnt
                .Codigo = Me.Codigo
                .InternoID = Me._IDInterno
                .IDTipoMovimiento = Me.IDMovimientoTipo
                .MotivoIngresoID = Me.IDMovimientoMotivo
                .FechaIngInpe = Me.FechaISP
                '.FechaMovimientoIngreso = Me.FechaIngresoyHora
                .IngresoNro = Me.NumeroIngreso
                .Observacion = Me.Observacion
                .RegionID = Me._IDRegion
                .PenalID = Me._IDPenal
                .FechaISP = Me.FechaISP
                .RegistroCreaPenalID = Me.RegistroCreaPenalID
            End With

            If objEnt.Codigo = -1 Then 'solo si es nuevo
                objEnt.RegistroCreaPenalID = Me._IDPenal
            End If

            Return objBssInp.Grabar(objEnt)

        End Function
        Private Function AGrabarMovimiento(objEnt As Entity.Registro.InternoMovimiento, idIngresoInpe As Integer, IDIngreso As Long) As Long

            Dim value As Long = -1

            With objEnt
                '.Codigo = CodMov 'Me.IDMovimientoInternamiento
                .InternoID = Me._IDInterno
                .IngresoID = IDIngreso
                .IngresoInpeId = idIngresoInpe
                .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                .MovimientoTipoID = If(objEnt.Codigo = -1, Me.IDMovimientoTipo, objEnt.MovimientoTipoID)
                .MovimientoMotivoID = If(objEnt.Codigo = -1, Me.IDMovimientoMotivo, objEnt.MovimientoMotivoID)
                '.MovimientoSubMotivoID = -1
                .Fecha = Me.FechaIngresoyHora
                .EstadoID = objEnt.EstadoID
                .RegionDestinoID = Me._IDRegion
                .PenalDestinoID = Me._IDPenal
                '/*auditoria*/
                ._RegionID = Me._IDRegion
                ._PenalID = Me._IDPenal
                '/**/
                '.DocumJudicialID = -1
                '.DocumJudicialNum = ""
                '.DocumJudicialFecha = 0
                '.DocumJudicialFecharecepcion = 0
                '.TipoAutoridadJudicialID = -1
                '.AutoridadJudicialID = -1
                '.SalaJudicialID = -1
                '.DocJudJuez = ""
                '.DocJudSecretario = ""
                '.RegionOrigenID = -1
                '.PenalOrigenID = -1
                '.OrigenNombre = ""
                '.DestinoNombre = ""
                '.PeriodoRetorno = ""
                '.PeriodoTipo = -1
                '.FechaRetorno = 0
                '.FechaFallecimiento = 0
                '.Observacion = Me.Observacion
            End With

            Dim objBss As New Bussines.Registro.InternoMovimiento
            value = objBss.Grabar_LM(objEnt)

            Return value

        End Function

        Private Function esUltimoIngreso() As Boolean
            Dim v As Boolean = False
            Dim numIng As Int16 = 0
            For i As Integer = 0 To dgwIngreso.Rows.Count - 1
                If dgwIngreso.Item("col_ing_nro", i).Value > numIng Then
                    numIng = dgwIngreso.Item("col_ing_nro", i).Value
                End If
            Next

            If numIng = dgwIngreso.Item("col_ing_nro", dgwIngreso.CurrentRow.Index).Value Then
                v = True
            Else
                v = False
            End If

            Return v
        End Function

        Private Sub GrabarSelect()

            Select Case Me.btnGrabar.Text
                Case "&Modificar"

                    If GrillaIDIngresoINPE < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro que desea modificar.")
                        Exit Sub
                    End If

                    'por el momento quitar la validacion, (analizar cuan
                    If Me._EstadoInternoCarceleta = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno se encuentra inactivo.")
                        Exit Sub
                    End If

                    If Me._EstadoInternoCarceleta = 1 And esUltimoIngreso() = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede modificar ingresos anteriores.")
                        Exit Sub
                    End If


                    HabilitarBotones(True)

                    Me.btnGrabar.Text = "&Grabar"
                    Me.btnGrabar.Image = My.Resources.Drive___USB_32

                    Me.btnNuevo.Text = "&Cancelar"
                    Me.btnNuevo.Image = My.Resources.anular2

                Case "&Grabar"
                    If AGrabar() = False Then
                        Exit Sub
                    End If
                    HabilitarBotones(False)

                    Me.btnGrabar.Text = "&Modificar"
                    Me.btnGrabar.Image = My.Resources._1277961326_folder_edit

                    Me.btnNuevo.Text = "&Nuevo"
                    Me.btnNuevo.Image = My.Resources._1277961158_folder_new
                    Me.DialogResult = Windows.Forms.DialogResult.OK
            End Select
        End Sub

        Private Sub ANuevoSelect()

            Select Case Me.btnNuevo.Text

                Case "&Nuevo"
                    'verificar si existe algun traslado del interno pendiente hacia carceleta.
                    Dim wsDisponible As Boolean = True
                    Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
                    ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta
                    Try
                        ws._test()
                    Catch ex As Exception
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Servicio web de la bandeja de los pendientes por traslado no disponible, contactese con el administrador del sistema.")
                        wsDisponible = False
                    End Try

                    Dim t As DataTable
                    If wsDisponible = True Then
                        t = ws.ListaPendRecepTraslado(Me._IDPenal)
                        If Not t Is Nothing Then
                            For Each f As DataRow In t.Rows
                                If f.Item("int_id") = Me._IDInterno Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento de traslado pendiente para este interno, verifique la bandeja de entrada.")
                                    Exit Sub
                                End If
                            Next
                        End If
                    End If

                    Dim entIngInp As New Entity.Registro.IngresoInpe
                    entIngInp = (New Bussines.Registro.IngresoInpe).ListarUltimoIngresoInpe(Me._IDInterno, Me._IDPenal)
                    If Not entIngInp Is Nothing Then
                        If entIngInp.FechaLibertad = 0 Then
                            If MessageBox.Show("El último ingreso del interno no tiene fecha de libertad, fuga o traslado, por lo tanto se deduce que se encuentra recluido en algún penal dentro del ámbito de lima metropolitana. " & vbCrLf &
                                                "Recuerde que solo se agrega un nuevo ingreso cuando el interno:" & vbCrLf &
                                                "   .- Ingresa por primera vez." & vbCrLf &
                                                "   .- Proviene por traslado desde E.P. Provincia." & vbCrLf &
                                                "   .- Reingresa nuevamente luego de una libertad anterior." & vbCrLf &
                                                "------------------------------------------------------------" & vbCrLf &
                                               "Desea continuar agregando el ingreso del interno como nuevo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                Exit Sub
                            End If
                        End If
                    End If

                    '------------------- si interno activo en algun penal no permitir agregar ingreso --------------
                    'Dim entInt As Entity.Registro.Interno
                    'entInt = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)
                    'If Not entInt Is Nothing AndAlso entInt.EstadoID = 1 And dgwIngreso.Rows.Count > 0 Then
                    '    If entInt.TrasladadoDeCarceleta = 0 Then
                    '        '    '    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible agregar un nuevo ingreso, el interno se encuentra activo.")
                    '        '    '    Exit Sub
                    '    End If
                    '    '    Dim bssMov As New Bussines.Registro.InternoMovimiento
                    '    '    Dim entMov As Entity.Registro.InternoMovimiento
                    '    '    entMov = bssMov.UltimoMovimiento_LM(Me._IDInterno)
                    '    '    If entMov Is Nothing Then
                    '    '        Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible agregar un nuevo ingreso, el interno se encuentra activo.")
                    '    '    Else
                    '    '        Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible agregar un nuevo ingreso, el interno se encuentra activo en " & entMov.DestinoNombre & ".")
                    '    '    End If
                    '    '    Exit Sub
                    'End If
                    '-----------------------------------------------------------------------------------------------

                    Limpiar()
                    HabilitarBotones(True)
                    Me.NumericUpDown1.Focus()

                    Me.btnNuevo.Text = "&Cancelar"
                    Me.btnNuevo.Image = My.Resources.anular2

                    Me.btnGrabar.Text = "&Grabar"
                    Me.btnGrabar.Image = My.Resources.Drive___USB_32


                Case "&Cancelar"

                    Limpiar()
                    ListarGrilla()
                    Me.dgwIngreso.CurrentCell = Nothing
                    HabilitarBotones(False)

                    Me.btnNuevo.Text = "&Nuevo"
                    Me.btnNuevo.Image = My.Resources._1277961158_folder_new

                    Me.btnGrabar.Text = "&Modificar"
                    Me.btnGrabar.Image = My.Resources._1277961326_folder_edit

            End Select

        End Sub
        Private Sub AEliminarIngresoInpe()

            If Me.GrillaIDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If

            If Me._FormEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No tiene permiso para realizar esta operación!")
                Exit Sub
            End If

            Dim strPregunta As String = "¿Está Seguro de eliminar el Ingreso? " + Chr(13) +
            "" + Chr(13) +
            "Esta acción eliminará los siguientes datos: " + Chr(13) +
                 "1. Identificación del Interno " + Chr(13) +
                 "   (Datos personales, Datos Complementarios, Nombres asociados, Fotos, etc)" + Chr(13) +
                 "2. Datos de Clasificación " + Chr(13) +
                   "   (Ficha Social, Ficha Psicológica, Ficha Legal y Ficha Final)" + Chr(13) +
                 "3. Datos de Mandato Detención " + Chr(13) +
                 "4. Datos de Movimiento de ingreso y egreso." + Chr(13) +
                 "" + Chr(13) +
                 "" +
            "Una vez eliminado los datos no podrá recuperarlo, desea continuar con la operación"

            If Legolas.Configuration.Aplication.MessageBox.Question(strPregunta) = DialogResult.Yes Then
                Dim value As Long = -1
                Dim objEnt As New Entity.Registro.IngresoInpe
                Dim outSMS As String = ""

                value = objBssInp.Eliminar_Carceleta(Me.GrillaIDIngresoINPE, outSMS)

                If value > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
                End If
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub Limpiar()

            Me.Codigo = -1
            Me.NumeroIngreso = 0
            Me.IDMovimientoTipo = -1
            Me.IDMovimientoMotivo = -1
            Me.FechaISP = 0
            Me.FechaMovIngresoEP = 0
            Me.HoraMovimiento = 0
            Me.MinutoMovimiento = 0
            Me.Observacion = ""
            HabilitarBotones(False)

        End Sub

        Private Sub HabilitarBotones(vf As Boolean)

            Me.grbDatos.Enabled = vf
            Me.dgwIngreso.Enabled = Not vf

            If Me.dgwIngreso.Enabled = True Then
                Me.dgwIngreso.BackgroundColor = Color.White
            Else
                Me.dgwIngreso.BackgroundColor = Color.Gainsboro
            End If

        End Sub

        Private Sub Inicio()

            Me.btnGrabar.Text = "&Modificar"
            Me.btnGrabar.Image = My.Resources._1277961326_folder_edit
            ComboMovimientoTipo()
            Me.IDMovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento

        End Sub
#End Region
#Region "Usuarios"
        Private Sub Permiso_Usuario()
            Me.pnlGrabar.Visible = Me._FormEscritura
            If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                Me.pnlEliminar.Visible = Me._FormEliminar
            Else
                Me.pnlEliminar.Visible = False
            End If
        End Sub
#End Region
        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
            GrabarSelect()
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            AEliminarIngresoInpe()
        End Sub

        Private Sub dgwIngreso_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIngreso.CellClick
            If blnCargaGrilla = True Then ListarData()
        End Sub

        Private Sub frmIngresoPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Permiso_Usuario()
            Inicio()
        End Sub

        Private Sub frmIngresoPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarGrilla()
            Me.dgwIngreso.CurrentCell = Nothing
            Limpiar()

            If Me._AgregarNuevoIngreso = True Then
                Me.btnNuevo.PerformClick()
            End If

        End Sub

        Private Sub btnIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            ANuevoSelect()
        End Sub

        Private Sub cbbMovTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbMovTipo.SelectedIndexChanged
            ComboMovimientoMotivo()
        End Sub

        Private Sub dgwIngreso_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIngreso.CellContentClick

        End Sub
    End Class
End Namespace