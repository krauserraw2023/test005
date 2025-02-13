Imports System.Windows.Forms
'Imports System.Data.Linq
Imports System.Linq

Namespace Registro.Identificacion.RegionLM
    Public Class frmIngresoPopup_v2
        Private objBss As Bussines.Registro.IngresoInpe = Nothing
        Private objEnt As Entity.Registro.IngresoInpe = Nothing
        Private blnCargaGrilla As Boolean = False
#Region "Propiedades_Publicas"
        Public Property _IDInterno As Long = -1
        Public Property _AgregarNuevoIngreso As Boolean = False
#End Region
#Region "Propiedades"
        Private Property IDIngresoInpe As Long = -1
        Private Property RegistroCreaPenalID As Integer = -1 'id del penal donde se crea el registro
        'Private Property NumeroIngreso() As Integer = 0 'ingreso cero            
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
        Private Property MovimientoTipoNombre As String
            Get
                Return Me.txtMovimiento.Text.Trim
            End Get
            Set(value As String)
                Me.txtMovimiento.Text = value.ToUpper
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
        Private Property MovimientoMotivoNombre As String
            Get
                Return Me.txtModalidad.Text.Trim
            End Get
            Set(value As String)
                Me.txtModalidad.Text = value.ToUpper
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
        Private Property Observacion() As String
            Get
                Return Me.txtobservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtobservacion.Text = value
            End Set
        End Property
        Private ReadOnly Property IDRegion As Short
            Get
                Return 3 'region lima 
            End Get
        End Property
        Private ReadOnly Property IDPenal As Short
            Get
                Return -1
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDIngresoINPE() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIngreso
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIDPenal() As Short
            Get
                Dim value As Short = -1
                Try
                    With Me.dgwIngreso
                        value = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return value
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

#End Region
#Region "Propiedades_Config"
        Private ReadOnly Property UsuarioPerfil As Short
            Get
                Return Legolas.Configuration.Usuario.OficinaID
            End Get
        End Property
#End Region
#Region "Combo"

        Private Sub ComboMovimientoTipo()

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovTipo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoTipo_ORL
                '.DataSource = objBss.Combo_MovimientoTipo
            End With

        End Sub
        Private Sub ComboMovimientoMotivo()

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovMotivo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoMotivo_LM(Me.IDMovimientoTipo, Type.Combo.enmTipoTexto.Mayuscula, False, IIf(valorCombo = True, "NUE", ""))
                valorCombo = False
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me._IDInterno < 1 Or Me.GrillaIDIngresoINPE < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.IngresoInpe
            objEnt = New Entity.Registro.IngresoInpe

            objEnt = objBss.Listar(Me.GrillaIDIngresoINPE, Me._IDInterno)

            With objEnt
                Me.IDIngresoInpe = .Codigo
                Me.NumeroIngreso = .IngresoNro
                Me.IDMovimientoTipo = .IDTipoMovimiento
                Me.IDMovimientoMotivo = .MotivoIngresoID
                Me.MovimientoTipoNombre = .TipoMovimientoNombre
                Me.MovimientoMotivoNombre = .MotivoIngresoNombre
                Me.FechaISP = .FechaIngInpe
                'Me.FechaIngresoCarceleta = .FechaMovimientoIngreso xxxx
                Me.Observacion = .Observacion
                Me.RegistroCreaPenalID = .RegistroCreaPenalID
                Me.ckbHistorico.Checked = .Historico
                Me.ckbHistorico.Visible = .HistoricoVisible
            End With

            Me.UscAuditUser1.LoadAudit(Me.GrillaIDIngresoINPE, Type.Enumeracion.Auditoria.EnumTipTabla.int_mov_interno_ingreso_inpe)

        End Sub

        Private Sub ListarGrilla()

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            blnCargaGrilla = False

            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            Dim objEntFiltro As New Entity.Registro.IngresoInpe
            With objEntFiltro
                .InternoID = Me._IDInterno
            End With

            objEntCol = (New Bussines.Registro.IngresoInpe).Listar_Grilla(objEntFiltro)

            'ordenar
            Dim l2 As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            Dim res = From d As Entity.Registro.IngresoInpe In objEntCol Order By d.IngresoNro Descending, d.FechaIngInpe Descending

            For Each obj As Entity.Registro.IngresoInpe In res
                l2.Add(obj)
            Next


            With Me.dgwIngreso
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = l2
            End With

            blnCargaGrilla = True
        End Sub
#End Region
#Region "Accion"
        Private Function ValidarDatos() As Boolean

            Dim value As Boolean = False

            'interno id
            If Me._IDInterno < 1 Then
                MessageBox.Show("Seleccione el interno antes de grabar", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return value
            End If

            'tipo movimiento - movimiento
            If Me.IDMovimientoTipo < 1 Then
                MessageBox.Show("Seleccione el tipo de movimiento.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbMovTipo.Focus()
                Return value
            End If

            'motivo movimiento - modalidad 
            If Me.IDMovimientoMotivo < 1 Then
                MessageBox.Show("Seleccione el motivo del movimiento.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbMovMotivo.Focus()
                Return value
            End If

            'validar numero de ingreso
            If Me.NumeroIngreso < 1 Then
                MessageBox.Show("Ingrese un numero de ingreso INPE valido.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.NumericUpDown1.Focus()
                Return value
            End If

            '/*fecha de ingreso  al sistema penietenciario
            If Me.FechaISP < 1 Then
                MessageBox.Show("Ingrese fecha de ingreso al Sistema Penitenciario.",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dtpFecIngISP.Focus()
                Return value
            End If

            'validar numeros de ingresos duplicados
            For Each fila As DataGridViewRow In Me.dgwIngreso.Rows

                If Me.IDIngresoInpe <> fila.Cells("col_id").Value Then

                    'validar un solo ingreso x tipo pld
                    If fila.Cells("col_fec_isp_date").Value <> "" AndAlso Me.FechaISP = CType(fila.Cells("col_fec_isp_date").Value, DateTime).ToFileTime Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede ingresar el ingreso de tipo: " &
                                                                                Me.cbbMovTipo.Text & ". Porque existe un ingreso con la misma fecha.")
                        value = False
                        Me.cbbMovTipo.Focus()
                        Return value
                    End If

                    If Me.NumeroIngreso = fila.Cells("col_ing_nro").Value Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El número de ingreso ya existe.")
                        value = False
                        Me.NumericUpDown1.Focus()
                        Return value
                    End If
                End If
            Next
            'Validar docuemntos judiciales historicos
            If Me.IDIngresoInpe > 0 And Me.ckbHistorico.Checked = True Then
                Dim bssDoc As New Bussines.Registro.DocumentoJudicial
                Dim objDoc As New Entity.Registro.DocumentoJudicial
                objDoc.InternoId = Me._IDInterno
                objDoc.IngresoInpeId = Me.IDIngresoInpe
                Dim conDocumentoJudicial As Integer = bssDoc.Cantidad_DocJudicial_hist(objDoc)
                If conDocumentoJudicial = -1 Then ' no se ha configurado la fecha de libertad historica
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha configurado la fecha de libertad historica," + Chr(13) +
                                                                            "por lo tanto, no se puede activar Ingreso historico [✔].")
                    Me.ckbHistorico.Focus()
                    Return False
                ElseIf conDocumentoJudicial > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe documentos judiciales con fecha de recepcion mayor al: 31/12/2019" + Chr(13) +
                                                                            "por lo tanto, no se puede activar el Ingreso historico [✔].")
                    Me.ckbHistorico.Focus()
                    Return False
                End If
            End If

            value = True
                Return value
        End Function
        Dim valorCombo As Boolean = False
        Private Sub ANuevoSelect()

            Select Case Me.btnNuevo.Text

                Case "&Nuevo"

                    'detectar num de ingreso duplicado
                    Dim numIngDuplicado As Boolean = False
                    Dim numIng As Integer = -1
                    For i As Integer = 0 To dgwIngreso.Rows.Count - 1
                        numIng = dgwIngreso.Item("col_ing_nro", i).Value
                        For j As Integer = 0 To dgwIngreso.Rows.Count - 1
                            If dgwIngreso.Item("col_id", i).Value <> dgwIngreso.Item("col_id", j).Value And dgwIngreso.Item("col_ing_nro", j).Value = numIng Then '
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe número de ingreso duplicado, para continuar debe corregir.")
                                Exit Sub
                            End If
                        Next
                    Next
                    valorCombo = True
                    Limpiar()
                    HabilitarBotones(True)
                    Me.cbbMovTipo.Focus()

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
        Private Sub GrabarSelect()

            Select Case Me.btnGrabar.Text
                Case "&Modificar"

                    If Me.GrillaIDIngresoINPE < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                        Exit Sub
                    End If

                    'If Me.GrillaIDPenalCreaReg <> -1 Then 'registrado por otro penal
                    '    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible modificar el registro dado que fue registrado por el Establecimiento de " & GrillaNomPenalCreaReg & ", para su modificación coordine con quien generó el registro.")
                    '    Exit Sub
                    'End If

                    HabilitarBotones(True)

                    Me.btnGrabar.Text = "&Grabar"
                    Me.btnGrabar.Image = My.Resources.Drive___USB_32

                    Me.btnNuevo.Text = "&Cancelar"
                    Me.btnNuevo.Image = My.Resources.anular2

                Case "&Grabar"

                    If AGrabar() = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

            End Select

        End Sub
        Private Function AGrabar() As Boolean

            Dim value As Boolean = False

            If ValidarDatos() = False Then
                Exit Function
            End If

            If Me.ckbHistorico.Checked = True Then
                Dim IngNromay As Integer = -1
                Dim IngIdmay As Integer = -1
                For Each fila As DataGridViewRow In Me.dgwIngreso.Rows
                    If fila.Cells("col_ing_nro").Value > IngNromay Then
                        IngNromay = fila.Cells("col_ing_nro").Value
                        IngIdmay = fila.Cells("col_id").Value
                    End If
                Next
                If Me.IDIngresoInpe = IngIdmay Then
                    Dim strMensage As String = "Ha activado el control Ingreso historico [✔], por lo tanto" + Chr(13) +
                                           "el interno pasara a el estado de INACTIVO, desea continuar."
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensage) = DialogResult.No Then
                        Exit Function
                    End If
                End If
            End If

            objBss = New Bussines.Registro.IngresoInpe
            objEnt = New Entity.Registro.IngresoInpe
            With objEnt
                .Codigo = Me.IDIngresoInpe
                .InternoID = Me._IDInterno
                .IDTipoMovimiento = Me.IDMovimientoTipo
                .MotivoIngresoID = Me.IDMovimientoMotivo
                .FechaISP = Me.FechaISP
                .FechaIngInpe = Me.FechaISP
                .IngresoNro = Me.NumeroIngreso
                .Observacion = Me.Observacion
                .RegionID = Me.IDRegion
                .PenalID = Me.IDPenal
                .RegistroCreaPenalID = Me.RegistroCreaPenalID
                .FlagTransferenciaSede = 1
                .Historico = IIf(ckbHistorico.Checked = True, 1, 0)
            End With
            'If objEnt.Codigo = -1 Then
            '    objEnt.PenalID = 35 'cuando es nuevo para que pueda visualizarse en carceleta
            'End If
            Dim intValue As Integer = -1

            intValue = objBss.Grabar(objEnt)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                value = True
            End If
            '----------  verificar si tiene ingreso ----
            'Dim objEnting As New Entity.Registro.Ingreso
            'Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Ingreso)

            'With objEnting
            '    .IngresoInpeId = intValue
            '    .PenalID = 35
            '    .RegionID = 3
            'End With

            'objEntCol = (New Bussines.Registro.Ingreso).Listar_LM(objEnting)
            'If objEntCol.Count = 0 Then 'sino existe en carceleta insertar
            '    'insertar a carceleta
            '    With objEnt
            '        .InternoID = Me._IDInterno
            '        .IngresoInpeId = idIngPen
            '        .IngresoNro = Me.NumeroIngreso
            '        .IDMovimientoTipo = If(objEnt.Codigo = -1, Me.IDMovimientoTipo, objEnt.IDMovimientoTipo) 'solo si es nuevo
            '        .MotivoIngresoID = If(objEnt.Codigo = -1, Me.IDMovimientoMotivo, objEnt.MotivoIngresoID) 'solo si es nuevo
            '        .FechaISP = Me.FechaISP
            '        .FechaIngreso = Me.FechaIngresoyHora
            '        .Observacion = If(objEnt.Codigo = -1, Me.Observacion, objEnt.Observacion)
            '        .RegionID = Me._IDRegion
            '        .PenalID = Me._IDPenal
            '    End With
            'End If

            'actualizar el numIngreso xxxx

            '--------------------------------------------

            Return value
        End Function
#End Region
#Region "Otros"
        Private Sub Limpiar()

            Me.IDIngresoInpe = -1
            Me.NumeroIngreso = 0
            Me.IDMovimientoTipo = -1
            Me.IDMovimientoMotivo = -1
            Me.FechaISP = 0
            Me.Observacion = ""
            HabilitarBotones(False)

        End Sub

        Private Sub HabilitarBotones(vf As Boolean)

            Me.grbDatos.Enabled = vf
            Me.dgwIngreso.Enabled = Not vf

            Me.txtMovimiento.Visible = Not vf
            Me.txtModalidad.Visible = Not vf
            Me.cbbMovTipo.Visible = vf
            Me.cbbMovMotivo.Visible = vf

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
        Private Sub HabilitarFechaaCarceleta()

            Select Case Me.IDMovimientoTipo
                Case Type.Enumeracion.Movimiento.EnumMovTipo.IngresoPLD
                    Me.NumeroIngreso = 0
                    Me.pnlISP.Visible = True
                Case Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                    Me.FechaISP = 0
                    Me.pnlISP.Visible = False
                Case Else
                    Me.pnlISP.Visible = True
            End Select

        End Sub
#End Region
#Region "Usuarios_Permisos"
        Private Sub Permisos_Usuarios()


            If Me._FormEscritura = True Then

                Select Case Me.UsuarioPerfil
                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                        Type.Enumeracion.Usuario.EnumDependencia.RegistroAntecedentes,
                         Type.Enumeracion.Usuario.EnumDependencia.RegistroIgresoDetenciones,
                         Type.Enumeracion.Usuario.EnumDependencia.RegistroSentenciasLibertades

                    Case Else
                        Me._FormEscritura = False

                End Select

            End If

            Me.pnlEliminar.Visible = Me._FormEliminar

            Me.pnlGrabar.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub dgwIngreso_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIngreso.CellEnter

            If dgwIngreso.Rows.Count = 0 Then
                Exit Sub
            End If

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub dgwIngreso_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIngreso.CellClick

            If blnCargaGrilla = True Then
                ListarData()
            End If

        End Sub

        Private Sub frmIngresoPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            Permisos_Usuarios()
            Inicio()

        End Sub

        Private Sub frmIngresoPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarGrilla()
            Me.dgwIngreso.CurrentCell = Nothing
            Limpiar()
            If Me._AgregarNuevoIngreso = True Then
                ANuevoSelect()
            End If
        End Sub

        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click

            GrabarSelect()

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click

            Me.dgwIngreso.CurrentCell = Nothing
            ANuevoSelect()

        End Sub

        Private Sub cbbMovTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbMovTipo.SelectedIndexChanged
            ComboMovimientoMotivo()
            'HabilitarFechaaCarceleta()
        End Sub


        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            AEliminarIngresoInpe()
        End Sub

        Private Sub AEliminarIngresoInpe()
            If Me.GrillaIDPenalCreaReg <> -1 And Me.GrillaIDPenalCreaReg <> 35 Then 'registrado por otro penal
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible eliminar el registro dado que fue registrado por el Establecimiento de " & GrillaNomPenalCreaReg & ", para completar la operación coordine con quien generó el registro.")
                Exit Sub
            End If

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
            "Esta acción eliminará el ingreso y partes de la identificación del interno como (Datos personales, Datos Complementarios, Nombres asociados, Fotos, etc)" + Chr(13) +
            "Una vez eliminado los datos no podrá recuperarlos, ¿Desea continuar con la operación?."

            If Legolas.Configuration.Aplication.MessageBox.Question(strPregunta) = DialogResult.Yes Then
                Dim value As Long = -1
                Dim outSms As String = ""

                value = (New Bussines.Registro.IngresoInpe).Eliminar_ORL(Me.GrillaIDIngresoINPE, outSms)

                If value > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outSms)
                    Exit Sub
                End If

            End If
        End Sub

        Private Sub cbbMovMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMovMotivo.SelectedIndexChanged
            Select Case cbbMovMotivo.SelectedValue
                Case 115, 129
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El motivo de ingreso seleccionado no esta vigente, operación cancelada.")
                    cbbMovMotivo.SelectedValue = -1
                    Exit Sub
            End Select
        End Sub

        Private Sub dgwIngreso_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwIngreso.CellContentClick

        End Sub
    End Class
End Namespace