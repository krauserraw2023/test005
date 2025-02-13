Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos

    Public Class frmMovimientoLibertadPoput
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntInt As Entity.Registro.InternoMovimiento = Nothing
        Private objExp As Bussines.Registro.Expediente = Nothing
        Private objBssDel As Bussines.Registro.Delito = Nothing
        Private objBssAgr As Bussines.Registro.InternoAgraviado = Nothing

        Public Property _Codigo() As Integer = -1
        Public Property _DocumJudicialID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _MovimientoMotivoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _TipoDocJudicialID As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

#Region "Propiedades_Parametricas"
        Private blnCargarExpedientes As Boolean = False
        Private Property DocumentoNumero() As String
            Get
                Return Me.txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
            End Set
        End Property

        Private Property DocumentoFechaRecepcion() As Long
            Get
                Return Me.dtpDocJudFecRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecRecep.ValueLong = value
            End Set
        End Property
        Private Property DocumentoFecha() As Long
            Get
                Return Me.dtpDocJudFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecha.ValueLong = value
            End Set
        End Property

        Private Property TipoAutoridadJudicialID() As Integer
            Get
                Return cbbTipoAutJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoAutJud.SelectedValue = value
            End Set
        End Property
        'Private Property DistritoJudicial() As Integer = -1
        Private Property DistritoJudicialID() As Integer
            Get
                Return cbbDistritoJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbDistritoJud.SelectedValue = value
            End Set
        End Property

        Public Property SalaJudicialID() As Integer
            Get
                Try
                    Return UscComboSala1._SalaJuzgadoID
                Catch ex As Exception
                    Return -1
                End Try

            End Get
            Set(ByVal value As Integer)
                Me.UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property
        Private Property _Juez() As String
            Get
                Return Me.txtJuez.Text
            End Get
            Set(ByVal value As String)
                txtJuez.Text = value
            End Set
        End Property
        Private Property _Secretario() As String
            Get
                Return Me.txtSecretario.Text
            End Get
            Set(ByVal value As String)
                txtSecretario.Text = value
            End Set
        End Property
        Private Property _OtroNombre() As String
            Get
                Return Me.txtOtraAutoridadNombre.Text
            End Get
            Set(ByVal value As String)
                txtOtraAutoridadNombre.Text = value
            End Set
        End Property
        Private Property _OtroCargo() As String
            Get
                Return Me.txtOtraAutoridadCargo.Text()
            End Get
            Set(ByVal value As String)
                txtOtraAutoridadCargo.Text = value
            End Set
        End Property
        Private Property Observacion() As String = ""
        Public Property _CargarExpedientes() As Boolean
            Get
                Return blnCargarExpedientes
            End Get
            Set(ByVal value As Boolean)
                blnCargarExpedientes = value
                If _CargarExpedientes = True Then
                    Me.uscMovDet._Codigo = Me._Codigo
                    Me.uscMovDet._InternoID = Me._InternoID
                    Me.uscMovDet._LoadUsc()
                End If

            End Set
        End Property

#End Region
#Region "Listar"
#Region "Combo"
        Private Sub ComboVarios()
            'expediente         
            Me.cbbTipoAutJud.LoadUsc()
            Me.cbbTipoAutJud.SelectedValue = 1

            ComboDistritoJudicial()
            If Me.DistritoJudicialID > 0 Then
                ComboSala()
            End If

        End Sub
        Private Sub ComboDistritoJudicial()
            Me.cbbDistritoJud.LoadUsc()
            cbbDistritoJud.SelectedValue = -1
        End Sub
        Private Sub ComboSala()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicialID
                ._Combo()
            End With
        End Sub
        Private Sub ComboSala2()

            With Me.UscComboSala1
                ._DistritoJudicialID = -1
                ._Combo()
            End With
        End Sub
#End Region
        Private Sub Listar_Usc()

            With uscMovDet
                ._Codigo = Me._Codigo
                ._MovimientoTipoID = Me._MovimientoTipoID
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._blnNuevo
                ._blnVisibleOrigenDestino = False
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
            End With
            ListarDocumentoJudicial()
            If uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                uscMovDet.ControlesReadOnly()
                ControlesReadOnly()
            End If
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)


        End Sub
        Private Sub ListarDocumentoJudicial()
            If Me._Codigo < 1 Then
                Exit Sub
            End If
            Dim objEntMov As New Entity.Registro.InternoMovimiento
            Dim objBss As New Bussines.Registro.DocumentoJudicial

            objEntMov.Codigo = Me._Codigo
            objEntMov.InternoID = Me._InternoID
            objEntMov.IngresoID = Me._IngresoID

            objBssInt = New Bussines.Registro.InternoMovimiento
            objEntMov = objBssInt.Listar(objEntMov)
            With objEntMov
                Me._Codigo = .Codigo
                Me._DocumJudicialID = -1
                Me.DocumentoNumero = .DocumJudicialNum
                Me.DocumentoFechaRecepcion = .DocumJudicialFecharecepcion
                Me.DocumentoFecha = .DocumJudicialFecha
                Me.TipoAutoridadJudicialID = .TipoAutoridadJudicialID
                Me.DistritoJudicialID = .AutoridadJudicialID
                Me.SalaJudicialID = .SalaJudicialID
                If Me.TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                    Me._Juez = .DocJudJuez
                    Me._Secretario = .DocJudSecretario
                Else
                    Me._OtroNombre = .DocJudJuez
                    Me._OtroCargo = .DocJudSecretario
                End If
                Me.Observacion = .Observacion
            End With
        End Sub
        Private Sub ControlesReadOnly()
            txtNumDocumento.ReadOnly = True
            txtJuez.ReadOnly = True
            txtSecretario.ReadOnly = True
            txtOtraAutoridadCargo.ReadOnly = True
            txtOtraAutoridadNombre.ReadOnly = True
            dtpDocJudFecha.Enabled = False
            dtpDocJudFecRecep.Enabled = False
            cbbDistritoJud.Enabled = False
            cbbTipoAutJud.Enabled = False
            UscComboSala1.Enabled = False
        End Sub

        Private Sub HabilitarPanel()
            If Me.TipoAutoridadJudicialID = 1 Then
                txtOtraAutoridadCargo.Text = ""
                txtOtraAutoridadNombre.Text = ""
                PnlOtraAutoridad.Visible = False
                PnlAutoridadJudicial.Visible = True
            Else
                PnlOtraAutoridad.Visible = True
                PnlAutoridadJudicial.Visible = False
                Me.DistritoJudicialID = -1
                Me.SalaJudicialID = -1
                txtJuez.Text = ""
                txtSecretario.Text = ""
            End If
        End Sub
#End Region
#Region "Accion"
        Private Sub AGrabar()
            If uscMovDet.Validar = True Then
                If ValidarGrabar() = True Then
                    Dim strMensajeGrabar As String = ""
                    If Me._Codigo < 1 Then
                        If uscMovDet.EstadoTramiteID < 1 Then
                            strMensajeGrabar = "Desea guardar los datos?"
                        Else
                            strMensajeGrabar = "Recuerde que en estado [Terminado] no podrá realizar ninguna modificación!" + Chr(13) +
                                         "Desea guardar los datos ?"

                        End If
                    Else
                        If Me.uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                            strMensajeGrabar = "Desea guardar los cambios ?"
                        Else
                            strMensajeGrabar = "Recuerde que en estado [Terminado] no podrá realizar ninguna modificación!" + Chr(13) +
                                          "Desea guardar los cambios ?"
                        End If
                    End If

                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensajeGrabar) = DialogResult.Yes Then
                        Dim intMovimientoID As Integer = 0
                        Dim entObj As New Entity.Registro.InternoMovimiento
                        With entObj
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            .DocumJudicialID = Me._DocumJudicialID
                            .DocumJudicialNum = Me.DocumentoNumero
                            .DocumJudicialFecharecepcion = Me.DocumentoFechaRecepcion
                            .DocumJudicialFecha = Me.DocumentoFecha
                            .TipoAutoridadJudicialID = Me.TipoAutoridadJudicialID
                            .AutoridadJudicialID = Me.DistritoJudicialID
                            .SalaJudicialID = Me.SalaJudicialID
                            .DocJudJuez = Me._Juez
                            .DocJudSecretario = Me._Secretario
                            .OtraAutoridadNombre = Me._OtroNombre
                            .OtraAutoridadCargo = Me._OtroCargo
                            .DocJudObservacion = Me.Observacion
                        End With
                        intMovimientoID = Me.uscMovDet.AGrabar(entObj)

                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If

                End If

            End If

        End Sub
        Private Function ValidarGrabar() As Boolean
            If Me.DocumentoNumero.Length < 1 Or Me.DocumentoNumero = "" Then
                MessageBox.Show("Ingrese numero de expediente, de la ficha Expediente", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNumDocumento.Focus()
                Return False
            End If
            '/*fecha exp
            If Me.DocumentoFecha < 1 Then
                MessageBox.Show("Ingrese fecha de expediente, de la ficha Expediente", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dtpDocJudFecha.Focus()
                Return False
            End If
            '/*fecha validacion
            If Me.DocumentoFechaRecepcion < 1 Then
                MessageBox.Show("Ingrese fecha de recepcion del expediente, de la ficha Expediente", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dtpDocJudFecRecep.Focus()
                Return False
            End If
            '/*comparacion de fechas*/
            If Me.DocumentoFecha > Me.DocumentoFechaRecepcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser mayor que la fecha de recepcion")
                Me.dtpDocJudFecha.Focus()
                Return False
            End If
            '/*autoridad judicial
            If Me.cbbTipoAutJud.SelectedValue < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la Autoridad Judicial, de la ficha Expediente")
                Me.cbbDistritoJud.Focus()
                Return False
            ElseIf Me.cbbTipoAutJud.SelectedValue = 1 Then
                If Me.DistritoJudicialID < 1 Then
                    MessageBox.Show("Seleccione la Autoridad Judicial, de la ficha Expediente", _
                     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.cbbDistritoJud.Focus()
                    Return False
                End If
                '*sala judicial
                If Me.SalaJudicialID < 1 Then
                    MessageBox.Show("Seleccione la Sala Judicial, de la ficha Expediente", _
                     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.UscComboSala1.Focus()
                    Return False
                End If
                If Me._Secretario = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                    Me.txtSecretario.Focus()
                    Return False
                End If
            Else
                If Me.txtOtraAutoridadNombre.Text = "" Then
                    MessageBox.Show("Ingrese nombre de la autoridad", _
                     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtOtraAutoridadNombre.Focus()
                    Return False
                End If
                If Me.txtOtraAutoridadCargo.Text = "" Then
                    MessageBox.Show("Ingrese cargo de la autoridad", _
                     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtOtraAutoridadCargo.Focus()
                    Return False
                End If
            End If
            '***********************
            Dim EntMov As New Entity.Registro.InternoMovimiento
            Dim EntColec As New Entity.Registro.InternoMovimientoCol
            objBssInt = New Bussines.Registro.InternoMovimiento
            If Me._Codigo < 1 Then
                If Me._MovimientoTipoID <> Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                    objBssInt = New Bussines.Registro.InternoMovimiento

                    EntMov.InternoID = Me._InternoID
                    EntMov.IngresoID = Me._IngresoID
                    EntColec = objBssInt.ListarGrilla(EntMov)
                    If uscMovDet._FechaMovimiento <= EntColec.InternoMovimiento(0).Fecha Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un moviento con fecha superior")
                        Return False
                    End If
                End If
            Else
                EntMov.Codigo = Me._Codigo
                EntMov.InternoID = Me._InternoID
                EntMov.IngresoID = Me._IngresoID
                EntColec = objBssInt.ListarMovimiento_Diferente(EntMov)
                '************************
                Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(uscMovDet._Fecha_Movimiento, True)
                fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                If fec_mov <= fec_ult_mov Then
                    'If Me._DocumJudicialID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior")
                    Return False
                    'End If
                End If
            End If
            Return True
        End Function
        'Private Sub EjecutarMovimiento()
        '    If ValidarEjecutar() = True Then

        '        If Me._InternoID < 1 Then
        '            Exit Sub
        '        End If

        '        objBssInt = New Bussines.Registro.InternoMovimiento
        '        If Me.uscMovDet.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
        '            Legolas.Configuration.Aplication.MessageBox.Exclamation("Este Movimiento ya tiene el estado como [Terminado]")
        '            'Exit Sub
        '        Else
        '            Dim strMensaje As String = ""
        '            strMensaje = "Esta seguro de poner en estado de Terminado, al movimiento !!!"
        '            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then
        '                Dim valor As Integer = 0
        '                If Me.uscMovDet.MovimientoGrupo = 1 Then
        '                    valor = 1
        '                Else
        '                    valor = 0
        '                End If
        '                Dim objEnt As New Entity.Registro.InternoMovimiento
        '                With objEnt
        '                    .Codigo = uscMovDet._Codigo
        '                    .EstadoID = valor
        '                    .InternoID = Me._InternoID
        '                    .IngresoID = Me._IngresoID
        '                    .MovimientoTipoID = uscMovDet.MovimientoTipo
        '                End With
        '                objBssInt.ActualizarEstado(objEnt)
        '                'Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
        '                'LoadUsc()
        '                Me.uscMovDet.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
        '                Me.uscMovDet.EstadoTramite = "Terminado"
        '                'Exit Sub
        '            End If
        '        End If
        '        Me.DialogResult = Windows.Forms.DialogResult.OK
        '        Me.Close()
        '    End If
        'End Sub


        Private Function ValidarEjecutar() As Boolean
            If Me._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Registrar primero el movimiento, operacion suspendida")
                Return False
            End If
            Return True
        End Function
#End Region
#Region "Forms"
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, EntExp As Entity.Registro.MovimientoExpediente)

            Dim blnListarDelito As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                Else
                    ._Codigo = ExpedienteCodigo
                    objExp = New Bussines.Registro.Expediente
                    Dim entExpobj As New Entity.Registro.Expediente
                    entExpobj.Codigo = ExpedienteCodigo
                    Dim objExpCol As New Entity.Registro.ExpedienteCol
                    objExpCol = objExp.Listar(entExpobj)
                    ._objEntExpediente = objExpCol.Expediente(0)
                End If
                ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, ByVal DelitoCodigo As Integer)

            'listar 4-5
            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm
                If Nuevo = True Then
                Else
                    objBssDel = New Bussines.Registro.Delito
                    ._objEntDelito = objBssDel.Listar(DelitoCodigo)
                    objBssAgr = New Bussines.Registro.InternoAgraviado
                    Dim entExp As New Entity.Registro.Expediente
                    entExp.InternoID = ._objEntDelito.InternoID
                    entExp.IngresoID = ._objEntDelito.IngresoID
                    entExp.InternoID = ._objEntDelito.Codigo
                    entExp.CreaDocJudicialId = ._objEntDelito.CreaDocJudicialId
                    ._objEntAgraviadoCol = objBssAgr.Listar2(entExp)
                End If
                ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If
            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            'Me.btnEjecutar.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub frmMovimientoLibertad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ComboVarios()
            Listar_Usc()

        End Sub



        Private Sub UscMovExpediente1__CellDoubleClick_GrillaExpediente(ingreso As System.Int32, codigo As System.Int32, EntExp As Entity.Registro.MovimientoExpediente)
            FRM_MantExpediente(False, ingreso, codigo, EntExp)
        End Sub


        'Private Sub btnEjecutar_Click(sender As System.Object, e As System.EventArgs)

        '    EjecutarMovimiento()
        '    'Me.Close()

        'End Sub

        Private Sub frmMovimientoLibertad_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Usuario_Permiso()

        End Sub

        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicialID
                ._Combo()
            End With
        End Sub
        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicialID = UscComboSala1._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJudicialID = UscComboSala1._SalaJuzgadoID_Seleccionado
        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            If Me.DistritoJudicialID > 0 Then
                ComboSala()
            End If
        End Sub

        Private Sub cbbDistritoJud_Load(sender As System.Object, e As System.EventArgs) Handles cbbDistritoJud.Load

        End Sub

        Private Sub txtNumDocumento_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumDocumento.TextChanged

        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            HabilitarPanel()
        End Sub

        Private Sub cbbTipoAutJud_Load(sender As System.Object, e As System.EventArgs) Handles cbbTipoAutJud.Load

        End Sub
    End Class
End Namespace

