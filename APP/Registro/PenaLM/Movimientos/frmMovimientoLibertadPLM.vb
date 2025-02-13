Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.PenalLM.Movimientos

    Public Class frmMovimientoLibertadPLM
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
        Public Property _NroPendientes As Integer = 0
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

#Region "Propiedades_Parametricas"
        Private Property DistritoJudicialID() As Integer
            Get
                Return cbbDistritoJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Public Property DistritoJudicial() As Integer
            Get
                Return cbbDistritoJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Private Property SalaJuzgado() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property

        'Public Property SalaJudicialID As Integer = -1
        Public Property SalaJudicialID() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property

        Private blnCargarExpedientes As Boolean = False
        Private Property DocumentoNumero() As String
            Get
                Return Me.txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
                txtNumDocumento.ReadOnly = True
            End Set
        End Property

        Private Property DocumentoFechaRecepcion() As Long
            Get
                Return Me.dtpDocJudFecRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecRecep.ValueLong = value
                Me.dtpDocJudFecRecep.Enabled = False
            End Set
        End Property
        Private Property DocumentoFecha() As Long
            Get
                Return Me.dtpDocJudFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecha.ValueLong = value
                Me.dtpDocJudFecha.Enabled = False
            End Set
        End Property
        Private Property TipoAutoridadJudicialID() As Integer
            Get
                Return cbbTipoAutJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                cbbTipoAutJud.SelectedValue = value
            End Set
        End Property
        Private Property _DistritoJudicialID() As Integer
            Get
                Return Me.cbbDistritoJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Private Property _SalaJuzgado() As Integer
            Get
                Return Me.UscComboSala1._SalaJuzgadoID
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
                txtJuez.ReadOnly = True
            End Set
        End Property
        Private Property _Secretario() As String
            Get
                Return Me.txtSecretario.Text
            End Get
            Set(ByVal value As String)
                txtSecretario.Text = value
                txtSecretario.ReadOnly = True
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
                    Me.UscMovExpediente1._DocumentoJudicialID = Me._DocumJudicialID
                    Me.UscMovExpediente1._CargarExpedientes = True
                End If

            End Set
        End Property

        Private Property AutoridadOtroNombre() As String
            Get
                Return Me.txtOtraAutoridadNombre.Text
            End Get
            Set(ByVal value As String)
                txtOtraAutoridadNombre.Text = value
            End Set
        End Property
        Private Property AutoridadOtroCargo() As String
            Get
                Return Me.txtOtraAutoridadCargo.Text
            End Get
            Set(ByVal value As String)
                txtOtraAutoridadCargo.Text = value
            End Set
        End Property

        Private EstadoMovimientoID As Integer = -1
#End Region
#Region "Combo"
        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.LoadUsc()
            Me.cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.Inpe
        End Sub

        Private Sub ComboDistritoJudicial()
            Me.cbbDistritoJud.LoadUsc()
            Me.cbbDistritoJud.SelectedValue = -1
        End Sub

        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me._DistritoJudicialID
                ._Combo()
            End With
        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            ComboSalaJuzgado()
            'ConfigurarDatosMovimiento()
        End Sub
        Private Sub ConfigurarDatosMovimiento()
            rdbNo.Checked = True
        End Sub
        Private Sub HabilitarPanel()
            If Me.TipoAutoridadJudicialID = 1 Then
                lblDistritoJudicial.Text = "Distrito Judicial :"
                lblJuez.Text = "Juez :"

                lblSala.Visible = True
                lblSecretario.Visible = True
                cbbDistritoJud.Visible = True
                UscComboSala1.Visible = True

                txtOtraAutoridadCargo.Visible = False
                txtOtraAutoridadNombre.Visible = False
                txtJuez.Visible = True
                txtSecretario.Visible = True
            Else
                lblSala.Visible = False
                lblSecretario.Visible = False
                cbbDistritoJud.Visible = False
                UscComboSala1.Visible = False

                lblDistritoJudicial.Text = "Nombre Autoridad:"
                lblJuez.Text = "Cargo Aut. :"
                txtOtraAutoridadCargo.Visible = True
                txtOtraAutoridadNombre.Visible = True
                txtJuez.Visible = False
                txtSecretario.Visible = False
            End If
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar_Usc()
            With uscMovDet
                ._Codigo = Me._Codigo
                ._MovimientoTipoID = Me._MovimientoTipoID
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._blnNuevo
                ._blnVisibleOrigenDestino = False
                ._Documentos_sin_mov = True
                ._TipoLicencia = Me._TipoLicencia
                ._uscEscritura = Me._FormEscritura
                ._LoadUsc()
            End With

            ListarDocumentoJudicial()

            If uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                Me.EstadoMovimientoID = uscMovDet.EstadoTramiteID
                uscMovDet.ControlesReadOnly()
                Me.InhabilitarControles(True)
                gbReferenciar.Enabled = False
            End If

            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)

        End Sub

        Private Sub ListarDocumentoJudicial()

            Dim objEnt As New Entity.Registro.InternoMovimiento
            Dim objBss As New Bussines.Registro.InternoMovimiento

            objEnt.InternoID = Me._InternoID
            objEnt.IngresoInpeId = Me._InternoIngresoInpeId
            objEnt.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
            objEnt = objBss.Listar_LM(objEnt)
            If objEnt IsNot Nothing Then
                With objEnt
                    Me._DocumJudicialID = .DocumJudicialID
                    Me.DocumentoNumero = .DocumJudicialNum
                    Me.DocumentoFechaRecepcion = .DocumJudicialFecharecepcion
                    Me.DocumentoFecha = .DocumJudicialFecha
                    Me.TipoAutoridadJudicialID = .TipoAutoridadJudicialID
                    Me._DistritoJudicialID = .AutoridadJudicialID
                    Me._SalaJuzgado = .SalaJudicialID
                    If Me.TipoAutoridadJudicialID = 1 Then
                        Me._Juez = .DocJudJuez
                        Me._Secretario = .DocJudSecretario
                    Else
                        Me.AutoridadOtroNombre = .DocJudJuez
                        Me.AutoridadOtroCargo = .DocJudSecretario
                    End If
                    Me.Observacion = .Observacion
                    rdbSi.Checked = True
                End With
                UscMovExpediente1._DocumentoJudicialID = Me._DocumJudicialID
                UscMovExpediente1.ListarExpediente2()
            End If
        End Sub

        Private Sub FRM_ListadoDocumentos()
            Dim frm As New Registro.Movimientos.frmListadoDocJudicialPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                ._TipoLicencia = Me._TipoLicencia
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me._DocumJudicialID = ._DocJudicialID
                    ListarDocumentosJudicial()
                End If
            End With
        End Sub

        Private Sub ListarDocumentosJudicial()
            Dim bss As New Bussines.Registro.DocumentoJudicial
            Dim obj As New Entity.Registro.DocumentoJudicial
            obj.Codigo = Me._DocumJudicialID
            obj = bss.Listar(obj)
            With obj
                Me.txtNumDocumento.Text = .DocumentoNumero
                Me.dtpDocJudFecha.ValueLong = .DocumentoFecha
                Me.dtpDocJudFecRecep.ValueLong = .DocumentoFechaRecepcion
                Me.cbbTipoAutJud.SelectedValue = .TipoAutoridadJudicial
                Me.cbbDistritoJud.SelectedValue = .DistritoJudicial
                Me.UscComboSala1._SalaJuzgadoID = .SalaJuzgado
                Me.uscMovDet.MovimientoMotivo = .MovimientoMotivoId
                Me.uscMovDet.MovimientoMotivoId = .MovimientoMotivoId
                Me.uscMovDet.MovimientoMotivoNombre = .MovimientoMotivoNom
                Me.uscMovDet._FechaMovimiento = .FechaInscripcion
                If Me.TipoAutoridadJudicialID = 1 Then
                    Me.txtJuez.Text = .JuezNombre
                    Me.txtSecretario.Text = .SecretarioNombre
                Else
                    Me.txtOtraAutoridadCargo.Text = .AutoridadOtroCargo
                    Me.txtOtraAutoridadNombre.Text = .AutoridadOtroNombre
                End If
            End With
            UscMovExpediente1._DocumentoJudicialID = Me._DocumJudicialID
            UscMovExpediente1.LoadUsc_()
        End Sub
#End Region
#Region "Accion"
        Private Sub AGrabar()
            If uscMovDet.Validar = True Then
                If ValidarGrabar() = True Then

                    Dim strMensajeGrabar As String = ""
                    If uscMovDet.EstadoID <> Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                        strMensajeGrabar = "Desea guardar los cambios ?"
                    Else
                        strMensajeGrabar = "Recuerde que en estado 'Terminado' no podrá realizar ninguna modificación!" + Chr(13) + "Desea guardar los cambios ?"
                    End If

                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensajeGrabar) = DialogResult.Yes Then
                        Dim intMovimientoID As Integer = -1
                        Dim entMovimiento As New Entity.Registro.InternoMovimiento

                        With entMovimiento
                            .Codigo = Me._Codigo
                            .DocumJudicialID = Me._DocumJudicialID
                            .DocumJudicialNum = Me.DocumentoNumero
                            .DocumJudicialFecharecepcion = Me.DocumentoFechaRecepcion
                            .DocumJudicialFecha = Me.DocumentoFecha
                            .TipoAutoridadJudicialID = Me.TipoAutoridadJudicialID
                            .AutoridadJudicialID = Me._DistritoJudicialID
                            .SalaJudicialID = Me._SalaJuzgado
                            .DocJudJuez = Me._Juez
                            .DocJudSecretario = Me._Secretario
                            .DocJudObservacion = Me._Observacion
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            If Me.TipoAutoridadJudicialID > 1 Then
                                .OtraAutoridadNombre = Me.AutoridadOtroNombre
                                .OtraAutoridadCargo = Me.AutoridadOtroCargo
                            End If
                        End With

                        intMovimientoID = uscMovDet.AGrabar(entMovimiento)

                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        End Sub

        Private strMensajeGrabar As String = ""
        Private Function ValidarGrabar() As Boolean
            Dim blnValue As Boolean = True

            Dim EntMov As New Entity.Registro.InternoMovimiento
            Dim EntColec As New Entity.Registro.InternoMovimientoCol
            objBssInt = New Bussines.Registro.InternoMovimiento
            If Me._Codigo < 1 Then
                If Me._MovimientoTipoID <> Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                    objBssInt = New Bussines.Registro.InternoMovimiento

                    EntMov.InternoID = Me._InternoID
                    EntMov.IngresoID = -1
                    EntMov.IngresoInpeId = Me._InternoIngresoInpeId
                    EntColec = objBssInt.ListarGrilla(EntMov)
                    '************************
                    Dim fec_mov, fec_ult_mov As Date
                    fec_mov = Legolas.Components.FechaHora.FechaDate(uscMovDet._Fecha_Movimiento, True)
                    fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                    If fec_mov <= fec_ult_mov Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un moviento con fecha superior")
                        Return False
                    End If
                End If
            Else
                EntMov.Codigo = Me._Codigo
                EntMov.InternoID = Me._InternoID
                EntMov.IngresoID = Me._IngresoID
                EntMov.IngresoInpeId = Me._InternoIngresoInpeId
                EntColec = objBssInt.ListarMovimiento_Diferente(EntMov)
                '************************
                Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(uscMovDet._Fecha_Movimiento, True)
                fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                If fec_mov <= fec_ult_mov Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior")
                    Return False
                End If
            End If

            If uscMovDet.Enabletcontrol = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del Movimiento es 'Terminado', accion cancelada.")
                Return False
            End If

            If Me._NroPendientes > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe Movimientos anteriores con estado pendiente, acción cancelada")
                Return False
            End If

            'validar la referencia del documento de libertad
            If Me.rdbSi.Checked = True Then
                If Me._DocumJudicialID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Referencie el documento de libertad.")
                    Return False
                End If
            End If

            Return blnValue
        End Function
        Private Sub InhabilitarControles(Valor As Boolean)
            cbbTipoAutJud.Enabled = Not (Valor)
            cbbDistritoJud.Enabled = Not (Valor)
            UscComboSala1.Enabled = Not (Valor)
            dtpDocJudFecha.Enabled = Not (Valor)
            dtpDocJudFecRecep.Enabled = Not (Valor)
            txtNumDocumento.ReadOnly = Valor
            txtJuez.ReadOnly = Valor
            txtSecretario.ReadOnly = Valor
            txtOtraAutoridadNombre.ReadOnly = Valor
            txtOtraAutoridadCargo.ReadOnly = Valor
        End Sub
#End Region
#Region "Forms"
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, EntExp As Entity.Registro.InternoMovimiento)

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


                    objExpCol = objExp.Listar_v2(entExpobj)
                    ._objEntExpediente = objExpCol.Expediente(0)
                End If
                ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, ByVal DelitoCodigo As Integer)

            'listar 4-4
            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm
                If Nuevo = True Then
                Else
                    objBssDel = New Bussines.Registro.Delito
                    ._objEntDelito = objBssDel.Listar(DelitoCodigo)

                    Dim entExp As New Entity.Registro.Expediente
                    entExp.InternoID = ._objEntDelito.InternoID
                    entExp.IngresoID = ._objEntDelito.IngresoID
                    entExp.IngresoInpeId = ._objEntDelito.IngresoInpeId
                    entExp.InternoDelitoID = ._objEntDelito.Codigo
                    entExp.DelitoEspecificoID = ._objEntDelito.DelitoEspecifico

                    objBssAgr = New Bussines.Registro.InternoAgraviado
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
            ValoresxDefault()
            Listar_Usc()
        End Sub

        Private Sub UscMovExpediente1__Click_GrillaExpediente()
            If Me.UscMovExpediente1._GrillaExpId > 0 Then
                With UscDelito1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._IngresoInpeId = Me._InternoIngresoInpeId
                    ._ExpedienteID = Me.UscMovExpediente1._GrillaExpId
                    ._TipoLicencia = Me._TipoLicencia
                End With
                Me.UscDelito1.LoadUsc()
            End If
        End Sub
        Private Sub UscMovExpediente1__Click_ListarDelito() Handles UscMovExpediente1._Click_ListarDelito
            With UscDelito1
                ._InternoID = Me._InternoID
                ._IngresoID = -1 ' Me._IngresoID
                ._IngresoInpeId = Me._InternoIngresoInpeId
                ._ExpedienteID = Me.UscMovExpediente1._GrillaExpId
                ._TipoLicencia = Me._TipoLicencia
            End With
            Me.UscDelito1.LoadUsc()
        End Sub

        Private Sub UscMovExpediente1__CellDoubleClick_GrillaExpediente(ingreso As System.Int32, codigo As System.Int32, EntExp As Entity.Registro.InternoMovimiento)
            FRM_MantExpediente(False, ingreso, codigo, EntExp)
        End Sub

        Private Sub frmMovimientoLibertad_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Usuario_Permiso()
        End Sub

        Private Sub UscDelito1__CellDoubleClick_GrillaDelito(IngresoID As System.Int32, ExpedienteCodigo As System.Int32, DelitoCodigo As System.Int32)
            FRM_MantDelito(False, -1, ExpedienteCodigo, DelitoCodigo)
        End Sub

        Private Sub btnCargarDocumento_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarDocumento.Click
            FRM_ListadoDocumentos()
        End Sub


        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            HabilitarPanel()
        End Sub


        Private Sub rdbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNo.CheckedChanged
            btnCargarDocumento.Enabled = False
            InhabilitarControles(False)
        End Sub

        Private Sub rdbSi_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSi.CheckedChanged
            btnCargarDocumento.Enabled = True
            InhabilitarControles(True)
        End Sub

        Private Sub cbbDistritoJud_Load(sender As Object, e As EventArgs) Handles cbbDistritoJud.Load

        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            ComboSalaJuzgado()
        End Sub



        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicialID = UscComboSala1._DistritoJudicialID
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado
        End Sub

        Private Sub UscComboSala1__ClicK_VerFormulario() Handles UscComboSala1._Click_Buscar
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me.DistritoJudicialID
                If .ShowDialog = DialogResult.OK Then
                    Me.DistritoJudicialID = ._DistritoJudicialID
                    Me.SalaJudicialID = ._GrillaSalaID
                End If
            End With
        End Sub
    End Class
End Namespace

