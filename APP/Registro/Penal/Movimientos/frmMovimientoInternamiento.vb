Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos
    Public Class frmMovimientoInternamientoCarceleta
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntInt As Entity.Registro.InternoMovimiento = Nothing
        Private objBssDoc As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEntDoc As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.InternoMovimiento
        Private objBssExp As Bussines.Registro.Expediente = Nothing
        Private objBssDel As Bussines.Registro.Delito = Nothing
        Private objBssAgr As Bussines.Registro.InternoAgraviado = Nothing
#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Public Property _DocumJudicialID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _MovimientoGrupoID() As Integer = -1
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _MovimientoMotivoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
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

        Private Property DistritoJudicial() As Integer = -1
        Private Property SalaJuzgado() As Integer = -1
        Private Property Observacion() As String = ""
        Public Property _TipoDocJudicialID As Integer = -1
        Private blnCargarExpedientes As Boolean = False
        Public Property _TipoFormMov() As Integer = -1
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
        Private Property TipoAutoridadJudicialID As Integer = -1
        Private Property AutoridadJudicialID As Integer = -1
        Private Property SalaJudicialID As Integer = -1
        Private Property DocJudicialJuez As String = ""
        Private Property DocJudicialSecretario As String = ""
        Private Property DocJudicialObservacion As String = ""
#End Region
#Region "Listar"
        Private Sub Listar_Usc()
            With uscMovDet
                ._Codigo = Me._Codigo
                ._MovimientoTipoID = Me._MovimientoTipoID
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._blnNuevo
                ._blnVisibleOrigenDestino = True
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
                UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)
            End With
            ListarDocumentoJudicial()
            With UscMovExpediente1
                ._MovimientoID = Me._Codigo
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._VisibleColumna = True
                ._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                '._CargarExpedientes = True
            End With

            If uscMovDet.EstadoTramiteID = 1 Then
                'uscMovDet.ControlesReadOnly()
            End If

        End Sub
        Private Sub ListarDocumentoJudicial()

            Dim objEnt As New Entity.Registro.DocumentoJudicial
            Dim objBss As New Bussines.Registro.DocumentoJudicial

            If Me._DocumJudicialID < 1 Then
                Exit Sub
            End If
            btnCargarDocumento.Visible = False
            Dim ent As New Entity.Registro.DocumentoJudicial
            ent.Codigo = Me._DocumJudicialID
            objEnt = objBss.Listar_v2(ent)
            With objEnt
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.TipoAutoridadJudicialID = .TipoAutoridadJudicial
                Me.DistritoJudicial = .DistritoJudicial
                Me.SalaJuzgado = .SalaJuzgado
                Me.DocJudicialJuez = .JuezNombre
                Me.DocJudicialSecretario = .SecretarioNombre
                Me.DocJudicialObservacion = .Observacion
            End With
        End Sub
        Private Sub FRM_ListadoDocumentos()

            Dim frm As New frmListadoDocJudicialPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                '._Load()
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me._DocumJudicialID = ._DocJudicialID
                    ListarDocumentosJudicial()
                End If
            End With

        End Sub
        Dim _MovimientoMotivoAuxID As Integer = -1
        Private Sub ListarDocumentosJudicial()
            Dim bss As New Bussines.Registro.DocumentoJudicial
            Dim obj As New Entity.Registro.DocumentoJudicial
            obj.Codigo = Me._DocumJudicialID
            obj = bss.Listar(obj)
            Me.txtNumDocumento.Text = obj.DocumentoNumero
            dtpDocJudFecha.Value = obj.DocumentoFecha
            dtpDocJudFecRecep.Value = obj.DocumentoFechaRecepcion
            Select Case obj.DocumentoSubTipoId
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.NuevoIngreso
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.NuevoIngreso
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoRevocatoria
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoRevocatoria
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoPrisionPreventiva
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoPrisionPreventiva
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoReincidencia
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoReincidencia
            End Select
            UscMovExpediente1._DocumentoJudicialID = Me._DocumJudicialID
            UscMovExpediente1.LoadUsc_()
        End Sub
#End Region
#Region "Accion"
        'Graba internamiento
        Private Sub AGrabar()
            If uscMovDet.Validar = True Then
                If ValidarGrabar() = True Then
                    Dim strMensajeGrabar As String = ""
                    If Me._Codigo < 1 Then
                        If uscMovDet.EstadoTramiteID < Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                            strMensajeGrabar = "Desea guardar los datos?"
                        Else
                            strMensajeGrabar = "Recuerde que en estado 'Terminado' no podrá realizar ninguna modificación!" + Chr(13) +
                                         "Desea guardar los datos ?"
                        End If
                    Else
                        If Me.uscMovDet.EstadoTramiteID < Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Or Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                            strMensajeGrabar = "Desea guardar los cambios ?"
                        Else
                            strMensajeGrabar = "Recuerde que en estado 'Terminado' no podrá realizar ninguna modificación!" + Chr(13) +
                                          "Desea guardar los cambios ?"
                        End If
                    End If
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensajeGrabar) = DialogResult.Yes Then
                        objBssInt = New Bussines.Registro.InternoMovimiento
                        Dim entMov As New Entity.Registro.InternoMovimiento
                        With entMov
                            .InternoID = Me._InternoID
                            .IngresoID = Me._IngresoID
                            .MovimientoTipoID = uscMovDet.MovimientoTipo
                            .MovimientoGrupoID = uscMovDet.MovimientoGrupo
                        End With
                        Dim ContaVal As Integer = objBssInt.ValidaMovimientoInterno(entMov)
                        If ContaVal = -2 Then
                            Legolas.Configuration.Aplication.MessageBox.MensajeError("No es posible completar la operación el interno se reporta como fallecido")
                            Me.Close()
                            Exit Sub
                        ElseIf Me._Codigo = -1 Then
                            If ContaVal = -1 Then
                                Dim strMensaje As String = uscMovDet.MovimientoGrupoNom
                                Legolas.Configuration.Aplication.MessageBox.MensajeError("No es posible completar la operación el interno tiene un " & strMensaje & " vigente")
                                Me.Close()
                                Exit Sub
                            End If
                        End If


                        Dim intMovimientoID As Integer = 0
                        Dim entObj As New Entity.Registro.InternoMovimiento()
                        With entObj
                            .DocumJudicialID = Me._DocumJudicialID
                            .DocumJudicialNum = Me.DocumentoNumero
                            .DocumJudicialFecharecepcion = Me.DocumentoFechaRecepcion
                            .DocumJudicialFecha = Me.DocumentoFecha
                            .TipoAutoridadJudicialID = Me.TipoAutoridadJudicialID
                            .AutoridadJudicialID = Me.DistritoJudicial
                            .SalaJudicialID = Me.SalaJuzgado
                            .DocJudJuez = Me.DocJudicialJuez
                            .DocJudSecretario = Me.DocJudicialSecretario
                        End With
                        intMovimientoID = Me.uscMovDet.AGrabar(entObj)

                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If

            End If
        End Sub

        Private Function ValidarGrabar() As Boolean
            If uscMovDet.MovimientoTipo = 1 And Me._DocumJudicialID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Cargar Resolucion Judicial")
                Return False
            End If
            Return True
        End Function

#End Region
#Region "Forms"
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, EntExp As Entity.Registro.InternoMovimiento)
            If Me._InternoID < 1 Or IngresoCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el numero de ingreso")
                Exit Sub
            End If
            Dim blnListarDelito As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                Else
                    ._Codigo = ExpedienteCodigo
                    objBssExp = New Bussines.Registro.Expediente
                    Dim entObj As New Entity.Registro.Expediente
                    entObj.Codigo = ._Codigo
                    Dim entobjCol As New Entity.Registro.ExpedienteCol
                    entobjCol = objBssExp.Listar_v2(entObj)
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
                If Nuevo = True Then
                Else
                    objBssDel = New Bussines.Registro.Delito
                    ._objEntDelito = objBssDel.Listar(DelitoCodigo)


                    Dim entExp As New Entity.Registro.Expediente
                    entExp.InternoID = ._objEntDelito.InternoID
                    entExp.IngresoID = ._objEntDelito.IngresoID
                    entExp.InternoDelitoID = ._objEntDelito.Codigo
                    entExp.DelitoEspecificoID = ._objEntDelito.DelitoEspecifico
                    entExp.CreaDocJudicialId = ._objEntDelito.CreaDocJudicialId


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
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._ExpedienteID = Me.UscMovExpediente1._GrillaExpId
                ._TipoLicencia = Me._TipoLicencia
            End With
            Me.UscDelito1.LoadUsc()
        End Sub

        Private Sub frmMovimientoInternamiento_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Listar_Usc()
            Usuario_Permiso()
        End Sub

        Private Sub UscMovExpediente1__CellDoubleClick_GrillaExpediente(ingreso As System.Int32, codigo As System.Int32, EntExp As Entity.Registro.InternoMovimiento) Handles UscMovExpediente1._CellDoubleClick_GrillaExpediente
            FRM_MantExpediente(False, ingreso, codigo, EntExp)
        End Sub

        Private Sub UscDelito1__CellDoubleClick_GrillaDelito(IngresoID As System.Int32, ExpedienteCodigo As System.Int32, DelitoCodigo As System.Int32) Handles UscDelito1._CellDoubleClick_GrillaDelito
            FRM_MantDelito(False, -1, ExpedienteCodigo, DelitoCodigo)
        End Sub

        Private Sub btnCargarDocumento_Click(sender As Object, e As EventArgs) Handles btnCargarDocumento.Click
            FRM_ListadoDocumentos()
        End Sub

        Private Sub frmMovimientoInternamientoCarceleta_Load(sender As Object, e As EventArgs) Handles Me.Load

        End Sub
    End Class
End Namespace

