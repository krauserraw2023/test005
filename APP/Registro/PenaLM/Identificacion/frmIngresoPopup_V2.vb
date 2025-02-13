Imports System.Windows.Forms
Imports System.Data.Linq
Imports System.Linq

Namespace Registro.PenalLM.Identificacion
    Public Class frmIngresoPopup_V2
        Private objBssIngresoInpe As Bussines.Registro.IngresoInpe = Nothing
        Private objEntIngresoInpe As Entity.Registro.IngresoInpe = Nothing

        Private objBssIngreso As Bussines.Registro.Ingreso = Nothing
        Private objEntIngreso As Entity.Registro.Ingreso = Nothing

#Region "Propiedades_Publicas"
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
        Public Property _IDInterno As Long = -1
        Public Property _AgregarNuevoIngreso As Boolean = False
        Public Property _EstadoInternoId As Integer = -1
        Public Property _InternoSedeRowId As Integer = -1
#End Region
#Region "Propiedades"
        Private Property IDIngresoInpe As Long = -1
        Private Property RegistroCreaPenalID As Integer = -1 'id del penal donde se crea el registro
        Private Property IDIngreso As Long = -1
        Private Property IngresoInpeSedeRowId As Integer = -1
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
            Set(value As Integer)
                Me.cbbMovTipo.SelectedValue = value
            End Set
        End Property
        Private Property IDMovimientoMotivo() As Integer
            Get
                Return Me.cbbMovMotivo.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbMovMotivo.SelectedValue = value
            End Set
        End Property
        Private Property FechaISP As Long
            Get
                Return Me.dtpFecIngISP.ValueLong
            End Get
            Set(value As Long)
                Me.dtpFecIngISP.ValueLong = value
            End Set
        End Property
        Private Property FechaIngresoEP As Long
            Get
                Return Me.dtpFechIng.ValueLong
            End Get
            Set(value As Long)
                Me.dtpFechIng.ValueLong = value
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

                value = Legolas.Components.FechaHora.FechaTimeLong(Me.FechaIngresoEP, strHora)

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
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDIngresoINPE() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIngreso
                        intValue = .SelectedRows(0).Cells("col_ing_inpe_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDIngreso() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIngreso
                        intValue = .SelectedRows(0).Cells("col_ing_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        'Private ReadOnly Property GrillaIngInpeSedRowId() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        Try
        '            With Me.dgwIngreso
        '                intValue = .SelectedRows(0).Cells("ing_inp_col_sedrowid").Value
        '            End With
        '        Catch ex As Exception

        '        End Try

        '        Return intValue
        '    End Get
        'End Property
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
        Private ReadOnly Property GrillaIngSedRowId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIngreso
                        intValue = .SelectedRows(0).Cells("col_sed_row_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboMovimientoTipo_ORL()

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovTipo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoTipo_ORL
            End With

        End Sub
        Private Sub ComboMovimientoTipo()

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovTipo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoTipo
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

            objBssIngresoInpe = New Bussines.Registro.IngresoInpe
            objEntIngresoInpe = New Entity.Registro.IngresoInpe

            objEntIngresoInpe = objBssIngresoInpe.Listar(Me.GrillaIDIngresoINPE)

            cbbMovTipo.DataSource = Nothing

            If objEntIngresoInpe.IDTipoMovimiento = 7 Then
                ComboMovimientoTipo_ORL()
            Else
                ComboMovimientoTipo()
            End If

            With objEntIngresoInpe
                Me.IDIngresoInpe = .Codigo
                Me.NumeroIngreso = .IngresoNro
                Me.IDMovimientoTipo = .IDTipoMovimiento
                Me.IDMovimientoMotivo = .MotivoIngresoID
                Me.FechaISP = .FechaISP
                Me.Observacion = .Observacion
                Me.IngresoInpeSedeRowId = .SedeRowId
                Me.RegistroCreaPenalID = .RegistroCreaPenalID
            End With

            If Me.GrillaIDIngreso > 0 Then
                ListarDataIngreso(Me.GrillaIDIngreso)
            End If

            Me.UscAuditUser1.LoadAudit(Me.GrillaIDIngreso, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoIngreso)
        End Sub
        Private Sub ListarDataIngreso(intIDIngreso As Long)

            If intIDIngreso <= 0 Then
                Me.IDIngreso = -1
                Me.FechaIngresoEP = 0
                Me.HoraMovimiento = 0
                Me.MinutoMovimiento = 0
                Exit Sub
            End If

            objBssIngreso = New Bussines.Registro.Ingreso
            objEntIngreso = New Entity.Registro.Ingreso
            Dim dteFechaIng As Date = Now

            objEntIngreso = objBssIngreso.Listar_LM(intIDIngreso)

            With objEntIngreso
                dteFechaIng = Legolas.Components.FechaHora.FechaDate(.FechaIngreso, True)
                Me.IDIngreso = objEntIngreso.Codigo
                Me.FechaIngresoEP = .FechaIngreso
                Me.HoraMovimiento = dteFechaIng.Hour
                Me.MinutoMovimiento = dteFechaIng.Minute
            End With

        End Sub
        Private Sub ListarGrilla()

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            objBssIngresoInpe = New Bussines.Registro.IngresoInpe
            Dim objEntFiltro As New Entity.Registro.IngresoInpe
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            With objEntFiltro
                .InternoID = Me._IDInterno
            End With

            objEntCol = (New Bussines.Registro.IngresoInpe).Listar_Grilla_PLM(objEntFiltro)


            Dim l2 As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            Dim res = From d As Entity.Registro.IngresoInpe In objEntCol Order By d.IngresoNro Descending, d.FechaIngInpe Descending

            For Each obj As Entity.Registro.IngresoInpe In res
                l2.Add(obj)
            Next

            With Me.dgwIngreso
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = l2 'objBssIngresoInpe.Listar_Grilla_PLM(objEntFiltro)
            End With

            Me.lblCount.Text = dgwIngreso.RowCount & " Reg."

        End Sub
#End Region
#Region "Validar"
        Private Function ValidarDatos() As Boolean

            Dim value As Boolean = False

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

            If Me.IDMovimientoTipo < 1 Then
                MessageBox.Show("Seleccione el tipo de movimiento",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbMovTipo.Focus()
                Return value
            End If

            If Me.IDMovimientoMotivo < 1 Then
                MessageBox.Show("Seleccione el motivo del movimiento",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbMovMotivo.Focus()
                Return value
            End If

            '/*fecha de ingreso  al INPE
            If Me.FechaIngresoEP < 1 Then
                MessageBox.Show("Ingrese fecha de ingreso al Sistema Penitenciario.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dtpFechIng.Focus()
                Return value
            End If

            'validar numero de ingresos abiertos
            objBssIngresoInpe = New Bussines.Registro.IngresoInpe
            If objBssIngresoInpe.ValidarNumeroIngresoAbierto(Me._IDInterno, Me._IDRegion, Me._IDPenal) > 3 Then
                MessageBox.Show("Solo puede existir 3 ingresos sin libertad como maximo.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return value
            End If

            'validar numeros de ingresos duplicados
            For Each fila As DataGridViewRow In Me.dgwIngreso.Rows
                If Me.IDIngresoInpe <> fila.Cells("col_ing_inpe_id").Value Then
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

        'Private Function ValidarNumeroIngreso() As Boolean

        '    Dim value As Boolean = False
        '    'validar ingresos ceros
        '    For Each obj As Entity.Registro.Ingreso In objEntCol
        '        If obj.IngresoNro = 0 Then
        '            Legolas.Configuration.Aplication.MessageBox.Exclamation("Regularizar el Nº de ingreso [0]")
        '            Return value
        '        End If
        '    Next

        '    'validar ingresos duplicados            
        '    For Each obj As Entity.Registro.Ingreso In objEntCol
        '        If obj.IngresoNro = obj.IngresoNro Then
        '            Legolas.Configuration.Aplication.MessageBox.Exclamation("Regularizar Nº de ingresos duplicados.")
        '            Return value
        '        End If
        '    Next

        '    value = True

        '    Return value

        'End Function

        'Private Function FechaISPLong() As Long
        '    Dim v As Long = 0
        '    For i As Integer = 0 To dgwIngreso.Rows.Count - 1
        '        If dgwIngreso.Item("col_fec_isp", i).Value > 0 Then
        '            v = dgwIngreso.Item("col_fec_isp", i).Value
        '            Exit For
        '        End If
        '    Next
        '    Return v
        'End Function
#End Region
#Region "Accion"
        Private Sub ANuevoSelect()

            Select Case Me.btnNuevo.Text

                Case "&Nuevo"
                    If ValidarNuevoIngreso() Then
                        Limpiar()
                        HabilitarBotones(True)

                        Me.NumericUpDown1.Focus()

                        Me.btnNuevo.Text = "&Cancelar"
                        Me.btnNuevo.Image = My.Resources.anular2

                        Me.btnGrabar.Text = "&Grabar"
                        Me.btnGrabar.Image = My.Resources.Drive___USB_32

                    End If
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

                    If Me.GrillaIDPenalCreaReg <> Me._IDPenal Then 'registrado por otro penal

                        Dim s As String = ""

                        If Me.GrillaIDPenalCreaReg = -1 Then
                            s = "No es posible modificar el registro dado que fue registrado por la O.R.L., para su modificación coordine con quien generó el registro."
                        Else
                            s = "No es posible modificar el registro dado que fue registrado por el Establecimiento de " & GrillaNomPenalCreaReg & ", para su modificación coordine con quien generó el registro."
                        End If

                        Legolas.Configuration.Aplication.MessageBox.Exclamation(s)
                        Exit Sub

                    End If

                    If Me.GrillaIDIngreso < 1 And IDIngresoInpe < 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro que desea modificar.")
                        Exit Sub
                    End If

                    If Me._EstadoInternoId = 1 And esUltimoIngreso() = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede modificar ingresos anteriores.")
                        Exit Sub
                    End If
                    If Me.IngresoInpeSedeRowId > 0 Then 'ya fue sincronizado con la sede
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible modificar el registro seleccionado.")
                        Exit Sub
                    End If
                    HabilitarBotones(True)

                    Me.btnGrabar.Text = "&Grabar"
                    Me.btnGrabar.Image = My.Resources.Drive___USB_32

                    Me.btnNuevo.Text = "&Cancelar"
                    Me.btnNuevo.Image = My.Resources.anular2

                    'validar la modificacion de la fecha de ingreso al sistema penitenciario 
                    If Me.GrillaIngSedRowId > 0 Then
                        If Me.FechaISP > 0 Then
                            dtpFecIngISP.Enabled = False
                        End If
                    End If

                Case "&Grabar"

                    If AGrabarInpe() < 1 Then
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

        Private Function AGrabarInpe() As Integer

            Dim value As Integer = -1

            If ValidarDatos() = False Then
                Return value
            End If

            Dim blnDatosOK As Boolean = False
            Dim mensajeOut As String = ""
            objEntIngresoInpe = New Entity.Registro.IngresoInpe

            With objEntIngresoInpe
                .Codigo = Me.IDIngresoInpe
                .InternoID = Me._IDInterno
                .IngresoNro = Me.NumeroIngreso
                .IDTipoMovimiento = Me.IDMovimientoTipo
                .MotivoIngresoID = Me.IDMovimientoMotivo
                .FechaIngInpe = Me.FechaISP
                .FechaMovimientoIngreso = Me.FechaIngresoEP
                .Observacion = Me.Observacion
                .RegionID = Me._IDRegion
                .PenalID = Me._IDPenal
                .RegistroCreaPenalID = Me.RegistroCreaPenalID
            End With

            objBssIngresoInpe = New Bussines.Registro.IngresoInpe
            Me.IDIngresoInpe = objBssIngresoInpe.Grabar(objEntIngresoInpe)

            'si es satifactario, grabar el ingreso del interno 
            If Me.IDIngresoInpe > 0 Then
                '1.- grabar el ingreso del interno, solo para el penal
                Me.IDIngreso = AGrabarIngreso(mensajeOut)

                '2.-grabar el movimiento del interno
                If Me.IDIngreso > 0 Then

                    Dim intEstado As Short = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente

                    AGrabarMovimiento(Me._IDRegion, Me._IDPenal, Me._IDInterno, Me.IDIngresoInpe, Me.IDIngreso,
                                      Me.IDMovimientoTipo, IDMovimientoMotivo, Me.FechaIngresoyHora, Me.Observacion, intEstado)

                    '3.- grabar la tabla interno historico       
                    Dim intValueHis As Long = -1
                    intValueHis = AGrabarHistorico(Me._IDInterno, Me.IDIngresoInpe, Me.IDIngreso)

                    If intValueHis > 0 Then
                        value = Me.IDIngresoInpe
                    End If
                Else
                    If mensajeOut.Trim.Length > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError(mensajeOut)
                    End If
                End If
            End If

            If value > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Function

        Private Function AGrabarIngreso(ByRef mensajeOut As String) As Integer

            Dim value As Integer = -1
            'grabar el ingreso del interno
            Dim objBss As New Bussines.Registro.Ingreso
            Dim objEnt As New Entity.Registro.Ingreso

            With objEnt
                .Codigo = Me.IDIngreso
                .InternoID = Me._IDInterno
                .IngresoInpeId = Me.IDIngresoInpe
                .RegionID = Me._IDRegion
                .PenalID = Me._IDPenal
                .IngresoNro = Me.NumeroIngreso
                .FechaISP = Me.FechaISP
                .IDMovimientoTipo = Me.IDMovimientoTipo
                .MotivoIngresoID = Me.IDMovimientoMotivo
                .FechaIngreso = Me.FechaIngresoyHora
                .Observacion = Me.Observacion
            End With

            value = objBss.Grabar_LM(objEnt, mensajeOut)

            Return value

        End Function

        Private Function AGrabarMovimiento(intIDRegion As Short, intIDPenal As Short,
                                           intIDInterno As Integer, intIDIngresoInpe As Integer, intIDIngreso As Integer,
                                           intIDTipoMovimiento As Short, intIDMotivoMovimiento As Short, lngFechaIngreso As Long,
                                           strObs As String, intEstado As Short) As Long

            Dim value As Long = -1

            Dim objEntFiltro As New Entity.Registro.InternoMovimiento
            Dim objBssMov As New Bussines.Registro.InternoMovimiento

            Dim objEnt As New Entity.Registro.InternoMovimiento

            With objEntFiltro
                .InternoID = intIDInterno
                .IngresoInpeId = intIDIngresoInpe
                .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                .MovimientoTipoID = -1 ' intIDTipoMovimiento 
            End With

            objEnt = objBssMov.Listar_LM(objEntFiltro)

            If objEnt Is Nothing OrElse objEnt.Codigo < 1 Then

                objEnt = New Entity.Registro.InternoMovimiento
                'registro nuevo
                With objEnt
                    .Codigo = -1
                    .InternoID = intIDInterno
                    .IngresoID = intIDIngreso
                    .IngresoInpeId = intIDIngresoInpe
                    .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                    .MovimientoTipoID = intIDTipoMovimiento
                    .MovimientoMotivoID = intIDMotivoMovimiento
                    .Fecha = lngFechaIngreso
                    .RegionDestinoID = intIDRegion
                    .PenalDestinoID = intIDPenal
                    ._RegionID = intIDRegion
                    ._PenalID = intIDPenal
                    .EstadoID = intEstado
                    .Observacion = strObs
                End With
            Else
                With objEnt
                    .Codigo = .Codigo
                    '.InternoID = intIDInterno
                    '.IngresoID = IngresoID
                    '.IngresoInpeId = intIDIngresoInpe
                    '.MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                    .MovimientoTipoID = intIDTipoMovimiento
                    .MovimientoMotivoID = intIDMotivoMovimiento
                    .Fecha = lngFechaIngreso
                    '.RegionDestinoID = intIDRegion
                    '.PenalDestinoID = intIDPenal
                    ._RegionID = intIDRegion
                    ._PenalID = intIDPenal
                    .Observacion = strObs
                    '.EstadoID = intEstado
                End With
            End If

            Dim objBss As New Bussines.Registro.InternoMovimiento
            value = objBss.Grabar_LM(objEnt)

            Return value

        End Function

        Private Function AGrabarHistorico(intIDInterno As Integer, intIDIngresoInpe As Integer, intIDIngreso As Integer) As Long

            Dim value As Long = -1

            Dim objEntFiltro As New Entity.Registro.InternoHistorico
            Dim objBssHis As New Bussines.Registro.InternoHistorico

            Dim objEnt As New Entity.Registro.InternoHistorico

            With objEntFiltro
                .InternoID = intIDInterno
                .IngresoInpeId = intIDIngresoInpe
            End With

            objEnt = objBssHis.Listar_LM(objEntFiltro)

            If objEnt Is Nothing Then

                'If objEnt.Codigo < 1 Then
                Dim intIDIngresoActual As Integer = -1
                value = objBssHis.Grabar_HistoricoCopia_LM(intIDInterno, intIDIngresoActual, intIDIngreso, intIDIngresoInpe, Me._IDRegion, Me._IDPenal)
                'End If

            Else
                value = objEnt.Codigo
            End If

            Return value

        End Function
        Private Sub AEliminarIngresoInpe()
            If Me.GrillaIDPenalCreaReg <> Me._IDPenal Then 'registrado por otro penal

                Dim s As String = ""

                If Me.GrillaIDPenalCreaReg = -1 Then
                    s = "No es posible eliminar el registro dado que fue registrado por la O.R.L., para su modificación coordine con quien generó el registro."
                Else
                    s = "No es posible modificar el registro dado que fue registrado por el Establecimiento de " & GrillaNomPenalCreaReg & ", para su modificación coordine con quien generó el registro."
                End If

                Legolas.Configuration.Aplication.MessageBox.Exclamation(s)
                Exit Sub

            End If

            If Me.GrillaIDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
                Exit Sub
            End If

            If Me._FormEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No tiene permiso para realizar esta operación!")
                Exit Sub
            End If

            If ExisteDocJudicialXDescargarEnSedeZXP() = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Primero debe descargar lo documentos judiciales de la sede central.")
                Exit Sub
            End If

            Dim strPregunta As String = "¿Está Seguro de eliminar el Ingreso? " + Chr(13) +
            "" + Chr(13) +
            "Esta acción eliminará los siguientes datos: " + Chr(13) +
            "   1. Identificacion del Interno " + Chr(13) +
            "      (Datos personales, Datos Complementarios, Nombres asociados, Fotos, etc)" + Chr(13) +
            "   2. Datos de Mandato Detención " + Chr(13) +
            "   3. Datos de Movimiento de ingreso y egreso." + Chr(13) +
            "" + Chr(13) +
             "" +
            "Una vez eliminado los datos no podra recuperarlo, desea continuar con la operación"

            If Legolas.Configuration.Aplication.MessageBox.Question(strPregunta) = DialogResult.Yes Then
                Dim value As Long = -1

                value = (New Bussines.Registro.IngresoInpe).Eliminar(Me.GrillaIDIngresoINPE)

                If value > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If
        End Sub

        Private Function ExisteDocJudicialXDescargarEnSedeZXP() As Boolean

            If Me._InternoSedeRowId = -1 Then Return False

            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Timeout = Threading.Timeout.Infinite
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta

            Try
                ws._test()
            Catch ex As Exception
                Return False
            End Try

            Dim dts As DataSet

            dts = ws.ListarDocumentosZXP(Me._InternoSedeRowId, Me._IDPenal)

            If dts Is Nothing Then Return False

            If dts.Tables.Count = 0 Then Return False

            Return True
        End Function
#End Region
#Region "Otros"
        Private Function ValidarNuevoIngreso() As Boolean
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
                        If f.Item("_sed_rowid") = Me._InternoSedeRowId Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento de traslado pendiente para este interno, verifique la bandeja de entrada.")
                            Return False
                        End If
                    Next
                End If
            End If


            If dgwIngreso.Rows.Count > 0 Then
                With dgwIngreso
                    Dim Mayor As Integer = 0
                    Dim FechaIng As String = ""
                    Dim FechaLib As String = ""
                    For i As Integer = 0 To .Rows.Count - 1
                        If .Item("col_ing_nro", i).Value > Mayor Then
                            Mayor = .Item("col_ing_nro", i).Value
                            FechaIng = .Item("col_fec_ing_pen", i).Value
                            FechaLib = .Item("col_fec_lib", i).Value
                        End If
                    Next
                    If FechaIng.Length > 0 And FechaLib.Length > 0 Then
                        Return True
                    Else
                        If MessageBox.Show("El último ingreso del interno no tiene fecha de libertad, fuga o traslado a provincia, por lo tanto se deduce que se encuentra recluido en algún otro penal dentro de lima metropolitana. " & vbCrLf &
                                               "Desea continuar agregando el ingreso del interno como nuevo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                            Return False
                        End If
                        'Legolas.Configuration.Aplication.MessageBox.Exclamation("El ingreso Nº " & Mayor & ", no posee fecha de libertad." & Chr(13) &
                        '                                                        "no se podra realizar ninguna acción.")
                        'Return False
                    End If
                End With
            End If

            Return True
        End Function
        Private Sub Limpiar()

            Me.IDIngresoInpe = -1
            Me.IDIngreso = -1
            Me.NumeroIngreso = 0
            Me.IDMovimientoTipo = -1
            Me.IDMovimientoMotivo = -1
            Me.FechaISP = 0
            Me.FechaIngresoEP = 0
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

        End Sub

#End Region
#Region "Usuarios"
        Private Sub Permiso_Usuario()

            Me.pnlGrabar.Visible = Me._FormEscritura

            Select Case Legolas.Configuration.Usuario.OficinaID

                Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                    Me.pnlEliminar.Visible = Me._FormEliminar
                Case Else
                    Me.pnlEliminar.Visible = False
            End Select

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
            ListarData()
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

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click

            ANuevoSelect()

        End Sub

        Private Sub cbbMovTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbMovTipo.SelectedIndexChanged

            ComboMovimientoMotivo()

        End Sub


    End Class
End Namespace