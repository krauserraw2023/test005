Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos.Carceleta
    Public Class frmInternamiento

#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Public Property _DocumJudicialID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _MovimientoGrupoID() As Integer = -1
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _PenalDestinoID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Private Property DistritoJudicial() As Integer = -1
        Private Property SalaJuzgado() As Integer = -1
        Public Property _TipoDocJudicialID As Integer = -1
        Public Property _TipoFormMov() As Integer = -1
        Private Property TipoAutoridadJudicialID As Integer = -1
        Private Property AutoridadJudicialID As Integer = -1
        Private Property SalaJudicialID As Integer = -1
        Private Property DocJudicialJuez As String = ""
        Private Property DocJudicialSecretario As String = ""
        Private Property DocJudicialObservacion As String = ""
        Public Property _GrupoID() As Integer = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
        Public Property _Grupo() As String
            Get
                Return Me.txtMovimientoGrupo.Text
            End Get
            Set(ByVal value As String)
                Me.txtMovimientoGrupo.Text = value
            End Set
        End Property
        Public Property _Movimiento() As String
            Get
                Return Me.txtMovimientoTipo.Text
            End Get
            Set(ByVal value As String)
                Me.txtMovimientoTipo.Text = value
            End Set
        End Property

        Public Property _MovimientoMotivoID() As Integer
            Get
                Return Me.cbbMovMotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovMotivo.SelectedValue = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return txtObservacion.Text
            End Get
            Set(ByVal value As String)
                txtObservacion.Text = value
            End Set
        End Property
        Public Property EstadoID() As Integer
            Get
                Return cbbEstado.SelectedValue
            End Get
            Set(ByVal value As Integer)
                cbbEstado.SelectedValue = value
            End Set
        End Property
        Public Property _FechaMovimiento() As Long
            Get
                Return Me.dtpFechaMov.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaMov.ValueLong = value
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
        Private ReadOnly Property FechaCompletaMovimiento As Long
            Get
                Dim FechaTotal As String
                Dim Hora As String = "00"
                Dim Minutos As String = "00"

                Dim fecha As String = Me.dtpFechaMov.Value & " " & CStr(HoraMovimiento) & ":" & CStr(MinutoMovimiento) & ":00"
                FechaTotal = CDate(fecha).ToFileTime
                Return FechaTotal
            End Get
        End Property
        Public ReadOnly Property _Fecha_Movimiento() As Long
            Get
                Dim FechaTotal As String

                Dim fecha As String = dtpFechaMov.Value & " " & CStr(Me.HoraMovimiento) & ":" & CStr(Me.MinutoMovimiento) & ":00"
                FechaTotal = CDate(fecha).ToFileTime
                Return FechaTotal
            End Get
        End Property
        Public Property _TipoLicencia() As Integer = -1
        Public Property _CargarExpedientes() As Integer = -1
#End Region
#Region "Combo"

        Private Sub ComboMovimientoMotivo()
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovMotivo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoMotivo_LM(Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento,
                                                                Type.Combo.enmTipoTexto.Mayuscula)
            End With
        End Sub
        Private Sub ComboEstado()
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbEstado
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.ComboMovimientoEstado(False, "[Seleccionar estado]")
                '.DataSource = objBss.ComboMovimientoEstado(Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento, Type.Combo.enmTipoTexto.Mayuscula)
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar_Usc()
            Me._Grupo = "INGRESO"
            Me._Movimiento = "INTERNAMIENTO"
            ComboMovimientoMotivo()
            ComboEstado()
            _Listar()
            With UscMovExpediente1
                ._MovimientoID = Me._Codigo
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._VisibleColumna = True
                ._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                .LoadUsc_()
            End With
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)
        End Sub

        Private Sub ListarDocumentoJudicial()
            If Me._DocumJudicialID < 1 Then Exit Sub

            Dim objEnt As New Entity.Registro.DocumentoJudicial
            objEnt.Codigo = Me._DocumJudicialID

            objEnt = (New Bussines.Registro.DocumentoJudicial).Listar_v2(objEnt)

            With objEnt
                Me.TipoAutoridadJudicialID = .TipoAutoridadJudicial
                Me.DistritoJudicial = .DistritoJudicial
                Me.SalaJuzgado = .SalaJuzgado
                Me.DocJudicialJuez = .JuezNombre
                Me.DocJudicialSecretario = .SecretarioNombre
                Me.DocJudicialObservacion = .Observacion
            End With
        End Sub
        Private EstadoAuxID As Integer = -1
        Private Sub _Listar()
            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Registro.InternoMovimiento
            objBss = New Bussines.Registro.InternoMovimiento

            Dim EntMov As New Entity.Registro.InternoMovimiento
            With EntMov
                .Codigo = Me._Codigo
            End With

                objEnt = objBss.Listar_LM(EntMov)
         

            With objEnt
               
                Me._Codigo = .Codigo
                Me._MovimientoMotivoID = .MovimientoMotivoID
                Me._FechaMovimiento = .Fecha
                Dim f As Date
                f = Legolas.Components.FechaHora.FechaDate(.Fecha, True)
                Me.HoraMovimiento = Format(f, "HH")
                Me.MinutoMovimiento = Format(f, "mm")

                Me.Observacion = .Observacion
                Me.EstadoID = .EstadoID
                Me._PenalDestinoID = .PenalDestinoID
                If Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    Me.EstadoAuxID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado

                    ControlesCarceletaReadOnly()

                End If
            End With
        End Sub
        Public Sub ControlesCarceletaReadOnly()
            dtpFechaMov.Enabled = False
            nudHora.Enabled = False
            nudMinutos.Enabled = False
            cbbEstado.Enabled = False
            cbbMovMotivo.Enabled = False
            txtObservacion.ReadOnly = True
            cbbEstado.Enabled = False
        End Sub
#End Region
#Region "Accion"
        Dim objBss As Bussines.Registro.InternoMovimiento
        Dim objEnt As Entity.Registro.InternoMovimiento
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = True
            '/*Fecha de Movimiento*/
            If Me._FechaMovimiento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha del Movimiento")
                blnValue = False
                Me.dtpFechaMov.Focus()
                Return blnValue
            End If
            If Me._MovimientoMotivoID < -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese motivo del movimiento")
                blnValue = False
                Return blnValue
            End If
            objBss = New Bussines.Registro.InternoMovimiento
            objEnt = New Entity.Registro.InternoMovimiento
            objEnt = New Entity.Registro.InternoMovimiento
            objEnt.InternoID = Me._InternoID
            objEnt.IngresoID = Me._IngresoID
            objEnt.IngresoInpeId = Me._InternoIngresoInpeId
            Dim EntColec As New Entity.Registro.InternoMovimientoCol
            If Me._Codigo < 1 Then
                EntColec = objBss.ListarGrilla_LM(objEnt)
                '************************
                Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(_Fecha_Movimiento, True)
                If EntColec.Count > 0 Then
                    fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                    If fec_mov <= fec_ult_mov Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior")
                        Return False
                    End If
                End If
            Else
                objEnt.Codigo = Me._Codigo
               
                    EntColec = objBss.ListarMovimiento_Diferente_LM(objEnt)

                Dim valor As Boolean = False
                '************************
                Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(_Fecha_Movimiento, True)

                For i As Integer = 0 To EntColec.Count - 1
                    If Me._Codigo <> EntColec.InternoMovimiento(i).Codigo Then
                        fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(i).Fecha, True)
                        If fec_mov >= fec_ult_mov Then
                            valor = True
                            Exit For
                        End If
                    End If
                Next
                If valor = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior")
                    Return False
                End If
            End If
        
            If Me._Codigo > 0 And Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado And _
                Me.EstadoAuxID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado de este movimiento es [Terminado], no se puede realizar ninguna accion")
                Return False
            End If

            Return blnValue
        End Function
        'Graba internamiento
        Private Sub AGrabar()
            If Validar() = True Then
                Dim strMensajeGrabar As String = strMensaje()
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensajeGrabar) = DialogResult.Yes Then

                    Dim bss As New Bussines.Registro.IngresoInpe
                    Dim intMovimientoID As Integer = 0
                    Dim entObj As New Entity.Registro.InternoMovimiento()
                    With entObj
                        .Codigo = Me._Codigo
                        .DocumJudicialID = Me._DocumJudicialID
                        .TipoAutoridadJudicialID = Me.TipoAutoridadJudicialID
                        .AutoridadJudicialID = Me.DistritoJudicial
                        .SalaJudicialID = Me.SalaJuzgado
                        .DocJudJuez = Me.DocJudicialJuez
                        .DocJudSecretario = Me.DocJudicialSecretario
                        .InternoID = Me._InternoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .IngresoID = Me._IngresoID
                        .MovimientoGrupoID = Me._GrupoID
                        .Fecha = Me.FechaCompletaMovimiento
                        .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                        .MovimientoMotivoID = Me._MovimientoMotivoID
                        .Observacion = txtObservacion.Text
                        .EstadoID = Me.EstadoID
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                        .PenalDestinoID = Me._PenalDestinoID
                    End With
                    Dim bssInt As New Bussines.Registro.InternoMovimiento
                    intMovimientoID = bssInt.Grabar_LM(entObj)

                    If intMovimientoID > 0 Then
                        Dim obj As New Entity.Registro.IngresoInpe
                        With obj
                            .Codigo = entObj.IngresoInpeId
                            .IDTipoMovimiento = Me._MovimientoTipoID
                            .MotivoIngresoID = Me._MovimientoMotivoID
                            '.FechaMovimientoIngreso = Me.FechaCompletaMovimiento '29/11/2018 la fechas de movimiento se almacenan en internoIngreso
                            .Observacion = Me.Observacion
                        End With
                        bss.GrabarUpd(obj)
                    End If
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End Sub
        Private Function strMensaje() As String
            Dim strMensajeGrabar As String = ""
            If Me._Codigo < 1 Then
                If Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                    strMensajeGrabar = "Desea guardar los datos?"
                Else
                    strMensajeGrabar = "Recuerde que en estado 'Terminado' no podrá realizar ninguna modificación!" + Chr(13) +
                                 "Desea guardar los datos ?"
                End If
            Else
                If Me.EstadoID <= Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                    strMensajeGrabar = "Desea guardar los cambios ?"
                Else
                    strMensajeGrabar = "Recuerde que en estado 'Terminado' no podrá realizar ninguna modificación!" + Chr(13) +
                                  "Desea guardar los cambios ?"
                End If
            End If


            Dim entMov As New Entity.Registro.InternoMovimiento
            With entMov
                .InternoID = Me._InternoID
                .IngresoID = Me._IngresoID
                '.MovimientoTipoID = uscMovDet.MovimientoTipo
                '.MovimientoGrupoID = uscMovDet.MovimientoGrupo
            End With

            Dim ContaVal As Integer = (New Bussines.Registro.InternoMovimiento).ValidaMovimientoInterno(entMov)

            If ContaVal = -2 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No es posible completar la operación el interno se reporta como fallecido")
                Me.Close()
                Return False
            ElseIf Me._Codigo = -1 Then
                If ContaVal = -1 Then
                    'Legolas.Configuration.Aplication.MessageBox.MensajeError("No es posible completar la operación el interno tiene un " & uscMovDet.MovimientoGrupoNom & " vigente")
                    Me.Close()
                    Return False
                End If
            End If

            Return strMensajeGrabar
        End Function
        
#End Region
#Region "Forms"
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, EntExp As Entity.Registro.InternoMovimiento)
            If Me._InternoID < 1 Or IngresoCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el numero de ingreso")
                Exit Sub
            End If

            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                Else
                    ._Codigo = ExpedienteCodigo

                    Dim entObj As New Entity.Registro.Expediente
                    entObj.Codigo = ._Codigo

                    Dim entobjCol As New Entity.Registro.ExpedienteCol
                    entobjCol = (New Bussines.Registro.Expediente).Listar_v2(entObj)
                    ._objEntExpediente = entobjCol.Expediente(0)
                End If
                ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                End If
            End With
        End Sub

        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, ByVal DelitoCodigo As Integer)
            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm
                If Nuevo = False Then

                    ._objEntDelito = (New Bussines.Registro.Delito).Listar(DelitoCodigo)

                    Dim entExp As New Entity.Registro.Expediente
                    entExp.InternoID = ._objEntDelito.InternoID
                    entExp.IngresoID = ._objEntDelito.IngresoID
                    entExp.InternoDelitoID = ._objEntDelito.Codigo
                    entExp.DelitoEspecificoID = ._objEntDelito.DelitoEspecifico
                    entExp.CreaDocJudicialId = ._objEntDelito.CreaDocJudicialId

                    ._objEntAgraviadoCol = (New Bussines.Registro.InternoAgraviado).Listar2(entExp)
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

        Private Sub UscMovExpediente1__Click_GrillaExpediente()
            With UscDelito1
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._ExpedienteID = Me.UscMovExpediente1._GrillaExpId
                ._TipoDocumentoID = 2
                ._TipoMovimineto = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
            End With
            Me.UscDelito1.LoadUsc()
        End Sub

        Private Sub UscMovExpediente1__Click_ListarDelito() Handles UscMovExpediente1._Click_ListarDelito
            With UscDelito1
                ._InternoID = -1 'Me._InternoID
                ._IngresoID = -1 'Me._IngresoID
                ._ExpedienteID = Me.UscMovExpediente1._GrillaExpId
            End With
            Me.UscDelito1.LoadUsc()
        End Sub

        Private Sub frmMovimientoInternamiento_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Usuario_Permiso()
            Listar_Usc()
        End Sub

        Private Sub UscMovExpediente1__CellDoubleClick_GrillaExpediente(ingreso As System.Int32, codigo As System.Int32, EntExp As Entity.Registro.InternoMovimiento) Handles UscMovExpediente1._CellDoubleClick_GrillaExpediente
            FRM_MantExpediente(False, ingreso, codigo, Nothing)
        End Sub

        Private Sub UscDelito1__CellDoubleClick_GrillaDelito(IngresoID As System.Int32, ExpedienteCodigo As System.Int32, DelitoCodigo As System.Int32) Handles UscDelito1._CellDoubleClick_GrillaDelito
            FRM_MantDelito(False, -1, ExpedienteCodigo, DelitoCodigo)
        End Sub

        Private Sub frmInternamiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace

