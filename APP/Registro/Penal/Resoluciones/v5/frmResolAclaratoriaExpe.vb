Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class frmResolAclaratoriaExpe
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing

#Region "Propiedades_Publicas"
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Ninguno
#End Region
#Region "Propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _InternoNAIngresoId() As Integer = -1
        Public Property _NuevoRegistro() As Boolean = False
        Public Property _TipoAclaratoria As Integer = -1 'Permite dejar por defecto el tipo de aclaratoria
        Public Property _TipoAclaratoriaCon As Boolean = False  'Permite dejar por defecto el tipo de aclaratoria
        Public Property _Condicion As Boolean = False 'Permite seleccionar el tipo de documento en nombres asociados
        Public Property _Subtipo As Integer = -1 'Subtipo
        Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre = Nothing

        Public Property _CodigoInterno() As String
            Get
                Return lblCodInterno.Text
            End Get
            Set(value As String)
                lblCodInterno.Text = value
            End Set
        End Property
        Public Property _NombresInterno() As String
            Get
                Return lblInterno.Text
            End Get
            Set(value As String)
                lblInterno.Text = value
            End Set
        End Property
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
#End Region
#Region "Validar"
        Private Function Validar() As Boolean

            If uscResolAclaratoria._DocSubTipoID = 1 Then
                If UscExpeDeResolucion.Validar(-1) = False Then
                    Return False
                End If
            ElseIf uscResolAclaratoria._DocSubTipoID = 2 Then 'nombres
                If Me._Codigo < 1 Then
                    If uscResolAclaratoria.GrillaRegistroNomAsoc = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista de nombres asociados, debe tener por lo menos un registro")
                        Return False
                    End If
                End If
            Else
                If Me._Codigo < 1 Then
                    If uscResolAclaratoria.GrillaRegistroNomAsoc = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista de nombres asociados, debe tener por lo menos un registro")
                        Return False
                    End If
                End If
                If UscExpeDeResolucion.Validar(-1) = False Then
                    Return False
                End If
            End If
            Return True
        End Function
#End Region
#Region "Accion"
        Private Function AGrabar() As Integer

            If Me._Codigo < 1 Then
                Me._NuevoRegistro = True
            Else
                Me._NuevoRegistro = False
            End If

            uscResolAclaratoria._TipoLicencia = Me._TipoLicencia
            'jmr, correcion del avocamiento
            Dim objDocVacio As New Entity.Registro.DocumentoJudicial
            Me._Codigo = uscResolAclaratoria.AGrabar(objDocVacio)
            'RESOLUCION NUEVO
            If uscResolAclaratoria._DocSubTipoID > 1 Then
                With UscResolAclaratoriaNombresAsoc1
                    ._TipoLicencia = Me._TipoLicencia
                    ._InternoID = Me._InternoId
                    ._InternoIngresoId = Me._InternoIngresoId
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._TipoLicencia = Me._TipoLicencia
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                        Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                        Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        .AgrabarNombresasociados_LM(Me._Codigo, _NuevoRegistro)
                    Else
                        .AgrabarNombresasociados(Me._Codigo, _NuevoRegistro)
                    End If

                End With
            End If
            'RESOLUCION NUEVO
            UscExpeDeResolucion._Grabar(Me._Codigo, Me._NuevoRegistro)
            Return Me._Codigo

        End Function
#End Region
#Region "Form"
        Private Sub FRM_Grilla()

            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmListaExpedientePopup
            With frm
                ._InternoID = Me._InternoId
                ._IngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                .objEntExpedienteTempoColCopi2 = UscExpeDeResolucion.objEntExpedienteTempoCol
                .DocJudicialID = Me._Codigo
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.UscExpeDeResolucion._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                    End If
                End If
            End With

            If blnNuevoExpediente = True Then
                Dim frm2 As New Expediente.v5.frmExpedientePopup3
                frm2._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                frm2._objEntExpedienteCol = UscExpeDeResolucion.objEntExpedienteTempoCol
                With frm2
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoId
                        If UscExpeDeResolucion._Grilla_NroRegistroExpediente = 0 Then
                            Me.UscExpeDeResolucion._Temporal_GrabarExpediente(._objEntExpediente)
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista solo puede tener un expediente")
                        End If
                    End If

                End With
            End If
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)
            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm

                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoId
                    ._IngresoID = Me._InternoIngresoId
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._ExpedienteID = UscExpeDeResolucion._GrillaExpedienteID
                    ._ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente

                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato                    
                    ._objEntAgraviadoCol = objEntCol
                    objEnt_.DelitoItem = Me.UscExpeDeResolucion._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelCol
                .UscComboDelito1._objEntDelitoCol = objEntDelCol
                ._DelitoItem = UscExpeDeResolucion._GrillaItemDelito
                ._objEntDelito = objEnt_
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ._objEntDelito.ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente
                    If ._TemporalNuevo = False Then
                        ._objEntDelito.DelitoAuxiliar = False
                        ._objEntDelito.DelitoItem = ._DelitoItem
                    End If
                    Me.UscExpeDeResolucion._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol, ._objEntAgravCol_Ind)
                End If


            End With
        End Sub
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoId
                    ._IngresoID = Me._InternoIngresoId
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._TemporalNuevo = Nuevo 'temporal nuevo
                    objEnt.Nuevo = Nuevo
                Else
                    ._Codigo = objEnt.Codigo
                    ._TemporalNuevo = Nuevo 'temporal edidato
                    objEnt.Nuevo = Nuevo
                End If
                ._objEntExpediente = objEnt
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.UscExpeDeResolucion._Temporal_GrabarExpediente(._objEntExpediente)
                End If
            End With
        End Sub
        Private Sub FRM_MantAgraviado(ByVal Nuevo As Boolean, objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)

            Dim frm As New Registro.Expediente.v5.frmAgraviadoPopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    ._AgraviadoNombre = ""
                    ._Observacion = ""
                Else
                    ._objEntAgraviado = objEnt
                End If
                ._NuevoGrabar = UscExpeDeResolucion.blnVaorAgr
                ._objEntAgraviadoCol = UscExpeDeResolucion.objEntAgraviadoTempoColGrilla
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    With ._objEntAgraviado
                        .ExpedienteID = UscExpeDeResolucion._GrillaExpedienteID
                        .DelitoID = UscExpeDeResolucion._GrillaDelitoID
                        .ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente
                        .DelitoItem = UscExpeDeResolucion._GrillaItemDelito
                    End With
                    Me.UscExpeDeResolucion._Temporal_GrabarAgraviado(._objEntAgraviado)
                End If
            End With
        End Sub
        Public Function ValidarExpedienteReferenciado(Condicion As String) As Boolean
            If Me._Codigo > 0 Then
                Dim strMensaje As String = ""
                Dim intValorpadre As Integer = 0
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                Select Case Condicion
                    Case 1
                        strMensaje = "no se puede agregar expedientes"
                    Case 2
                        strMensaje = "no se puede agregar delitos"
                    Case 3
                        strMensaje = "no se puede agregar agraviados"
                    Case 4
                        strMensaje = "No se puede modificar el documento porque forma parte del expediente"
                    Case 7
                        strMensaje = " [Operación cancelada]"
                End Select

                For Each objEntExpediente As Entity.Registro.Expediente In UscExpeDeResolucion.objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    If objEntExpediente.Codigo > 0 Then
                        objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                        Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                        If blnValor = False Then
                            intValorpadre = intValorpadre + 1
                        End If
                    End If
                Next


                If intValorpadre > 0 Then
                    'Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)
                    Return False
                End If
            End If
            Return True
        End Function
        Private Sub FMR_MantNombresAsoc(ByVal Nuevo As Boolean, ByVal EntNomAsoc As Entity.Registro.Documento.NombresAsociados, ByVal EntNomAsocCol As Entity.Registro.Documento.NombresAsociadosCol, Accion As Integer)
            If UscResolAclaratoriaNombresAsoc1._ValorAniadir = True Then
                If Me._Codigo > 0 Then
                    If ValidarExpedienteReferenciado(7) = False Then
                        UscResolAclaratoriaNombresAsoc1._ValorAniadir = False
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
                        Exit Sub
                    End If
                End If
            End If
            If Nuevo = True Then
                If Me._NuevoRegistro = True Then
                    Dim f As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
                    f._TipoFormulario = Type.Formulario.Registro.UserControl.Resoluciones
                    f._TipoAcion = Accion
                    f._Nuevobln = True
                    f.InternoID = Me._InternoId
                    f.IngresoID = Me._InternoIngresoId
                    f._IngresoInpeID = Me._InternoIngresoInpeId
                    f._RegionID = Me._RegionID
                    f._PenalID = Me._PenalID
                    f.objEntDoc = EntNomAsoc
                    f.objEntDocumen = EntNomAsoc
                    f.objEntDocumenCol = EntNomAsocCol
                    f.objEntDocumenCol2 = UscResolAclaratoriaNombresAsoc1.objEntNACol
                    f._VisibleRadioButonNombresAsociados
                    'permisos
                    f._FormEscritura = Me._FormEscritura
                    f._FormLectura = Me._FormLectura
                    f._FormEliminar = Me._FormEliminar
                    If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                        UscResolAclaratoriaNombresAsoc1.AgregarNombresAsociados(f.objEntDocumen)
                    End If
                Else
                    Dim f As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
                    f._TipoFormulario = Type.Formulario.Registro.UserControl.Resoluciones
                    f._TipoAcion = Accion
                    f._Nuevobln = False
                    f.InternoID = Me._InternoId
                    f.IngresoID = Me._InternoIngresoId
                    f._IngresoInpeID = Me._InternoIngresoInpeId
                    f._RegionID = Me._RegionID
                    f._PenalID = Me._PenalID
                    f.objEntDoc = EntNomAsoc
                    f.objEntDocumen = EntNomAsoc
                    f.objEntDocumenCol = EntNomAsocCol
                    f.objEntDocumenCol2 = UscResolAclaratoriaNombresAsoc1.objEntNACol
                    f.objEntExpedienteTempoCol = UscExpeDeResolucion.objEntExpedienteTempoCol
                    'permisos
                    f._FormEscritura = Me._FormEscritura
                    f._FormLectura = Me._FormLectura
                    f._FormEliminar = Me._FormEliminar
                    If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                        UscResolAclaratoriaNombresAsoc1.AgregarNombresAsociados(f.objEntDocumen)
                    End If
                End If
            Else
                Dim f As New Registro.Identificacion.frmNombreAsociadoPopup2(IIf(EntNomAsoc.NAEstado = -1, Nothing, EntNomAsoc))
                f._TipoFormulario = Type.Formulario.Registro.UserControl.Resoluciones
                f._TipoAcion = Accion
                f._Nuevobln = False
                f._RegionID = Me._RegionID
                f._PenalID = Me._PenalID
                f.InternoID = Me._InternoId
                f.IngresoID = Me._InternoIngresoId
                f._IngresoInpeID = Me._InternoIngresoInpeId
                f.objEntDoc = EntNomAsoc
                f.objEntDocumen = EntNomAsoc
                f.objEntDocumenCol = EntNomAsocCol
                f.objEntDocumenCol2 = UscResolAclaratoriaNombresAsoc1.objEntNACol
                f.DocumentoJudicialID = Me._Codigo
                f.objEntExpedienteTempoCol = UscExpeDeResolucion.objEntExpedienteTempoCol
                'permisos
                f._FormEscritura = Me._FormEscritura
                f._FormLectura = Me._FormLectura
                f._FormEliminar = Me._FormEliminar
                f.ListarData()
                If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscResolAclaratoriaNombresAsoc1.EditarNombresAsociados(f.objEntDocumen)
                End If


            End If

        End Sub
        Private Sub FRM_BusquedaSalasJuzgados()

            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = uscResolAclaratoria.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    uscResolAclaratoria.DistritoJudicial = ._DistritoJudicialID
                    uscResolAclaratoria.SalaJuzgado = ._GrillaSalaID

                End If
            End With

        End Sub
        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    uscResolAclaratoria.DistritoJudicial = .getCodigo
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            With Me.uscResolAclaratoria
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoID = Me._InternoId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._TipoAclaratoriaCon = Me._TipoAclaratoriaCon
                ._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                ._DocSubTipoID = Me._Subtipo
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
                Me._Subtipo = ._DocSubTipoID
                RedimensionarFormulario(._DocSubTipoID)
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
            '-------------------
            With UscExpeDeResolucion
                ._TipoLicencia = Me._TipoLicencia
                '._VisiblePanelMantExpediente = True
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                ._SubTipo = Me._Subtipo

                If _Codigo = -1 Then
                    '._EnabledBotonAgregarExpediente = True
                Else 'edicion
                    Me._NuevoRegistro = False
                End If
                '._EnabledBotonEliminarExpediente = True
                ._InternoIngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoId
                ._DocumentoJudicialID = _Codigo
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._ListarExpediente(uscResolAclaratoria.objEnt, False)
            End With
            With Me.UscResolAclaratoriaNombresAsoc1
                ._Codigo = Me._Codigo
                ._DocumentoJudicialID = Me._Codigo
                ._DocumentoTipoId = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                ._InternoID = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._DocumentoSubTipoId = Me._Subtipo
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
            End With
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Dim blnEliminar As Boolean = False

            Select Case Me._TipoFormulario
                Case Type.Formulario.Registro.UserControl.AclaratoriaNombre
                    blnEliminar = True
                Case Type.Formulario.Registro.UserControl.Ninguno
                    blnEliminar = False
            End Select
            PnlGrabar.Visible = Me._FormEscritura
        End Sub
        Private Sub RedimensionarFormulario(Tipo As Integer)

            Select Case Tipo
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Expediente 'expedientes

                    Me.UscResolAclaratoriaNombresAsoc1.Visible = False
                    Me.UscExpeDeResolucion.Visible = True
                    Label2.Text = "RESOLUCION: ACLARATORIA DE EXPEDIENTE"
                    Me.Size = New Size(Me.Width, 554)

                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Nombre

                    Me.UscResolAclaratoriaNombresAsoc1.Visible = True
                    Me.UscExpeDeResolucion.Visible = False
                    Me.UscResolAclaratoriaNombresAsoc1.Size = New Size(Me.Width, 200)

                    Me.Size = New Size(Me.Width, 510)
                    Label2.Text = "RESOLUCION: ACLARATORIA DE NOMBRE"

                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_ExpedienteNombres

                    Me.UscResolAclaratoriaNombresAsoc1.Visible = True
                    Me.UscExpeDeResolucion.Visible = True
                    Label2.Text = "RESOLUCION: ACLARATORIA DE EXPEDIENTE - NOMBRES"
            End Select

        End Sub
#End Region

        Private Sub UscExpeDeResolucion1__Click_AgregarAgraviado(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Expediente_Agregar() Handles UscExpeDeResolucion._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub


        Private Sub frmResolAclaratoriaExpe_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            Usuario_Permiso()
            ValoresxDefault()

        End Sub
        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            If uscResolAclaratoria.Validar = True Then
                If UscExpeDeResolucion.Validar(uscResolAclaratoria._DocSubTipoID) = True Then
                    If UscResolAclaratoriaNombresAsoc1.Validar(uscResolAclaratoria._DocSubTipoID) = True Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                            If AGrabar() > -1 Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If

        End Sub

        Private Sub uscResolAclaratoria__Click_EnabledExpedientes(TipoAclaratoria As Integer) Handles uscResolAclaratoria._Click_EnabledExpedientes

            With UscExpeDeResolucion

                Select Case TipoAclaratoria
                    Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Expediente   'solo expedientes

                    Case Else  'solo nombres  ; expedientes-nombres      
                        If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                            Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                            UscResolAclaratoriaNombresAsoc1.ListarNombreAsociadoBD_LM(Me._Codigo, Me._InternoId, Me._InternoIngresoId, Me._InternoIngresoInpeId)
                        Else
                            UscResolAclaratoriaNombresAsoc1.ListarNombreAsociadoBD(Me._Codigo, Me._InternoId, Me._InternoIngresoId)
                        End If
                End Select
                RedimensionarFormulario(TipoAclaratoria)
            End With
        End Sub
   
        Private Sub UscExpeDeResolucion__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscExpeDeResolucion._Click_Expediente_Editar
            FRM_MantExpediente(False, objEnt)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Agregar_(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEnt As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEnt, objEntCol, objEntDelCol)
        End Sub

        Private Sub uscResolAclaratoria__Click_ValidarNombreAsociado() Handles uscResolAclaratoria._Click_ValidarNombreAsociado
            If UscExpeDeResolucion.GrillaReferenciado = True Then
                uscResolAclaratoria.ValorVal = True
            End If
        End Sub


        Private Sub UscResolAclaratoriaNombresAsoc1__Click_BtnAgregarNombreAsociado(EntNomAso As Entity.Registro.Documento.NombresAsociados, EntNomAsoCol As Entity.Registro.Documento.NombresAsociadosCol, Accion As Integer) Handles UscResolAclaratoriaNombresAsoc1._Click_BtnAgregarNombreAsociado
            If UscExpeDeResolucion.ValidarExpedienteReferenciado(7) = False Then
                Exit Sub
            End If
            FMR_MantNombresAsoc(True, EntNomAso, EntNomAsoCol, Accion)
        End Sub

        Private Sub UscResolAclaratoriaNombresAsoc1__Click_BtnEditarNombreAsociado(EntNomAso As Entity.Registro.Documento.NombresAsociados, EntNomAsoCol As Entity.Registro.Documento.NombresAsociadosCol, Accion As Integer) Handles UscResolAclaratoriaNombresAsoc1._Click_BtnEditarNombreAsociado
            FMR_MantNombresAsoc(False, EntNomAso, EntNomAsoCol, Accion)
        End Sub

        Private Sub UscResolAclaratoriaNombresAsoc1__Click_ConsultarExpedienteReferenciado() Handles UscResolAclaratoriaNombresAsoc1._Click_ConsultarExpedienteReferenciado
            If UscExpeDeResolucion.ValidarExpedienteReferenciado(7) = False Then
                UscResolAclaratoriaNombresAsoc1._ValorReferencia = True
            End If
        End Sub

        Private Sub uscResolAclaratoria__Click_VerFormulario() Handles uscResolAclaratoria._Click_FrmBusquedaSalaJuzgado
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = uscResolAclaratoria.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then
                    uscResolAclaratoria.DistritoJudicial = ._DistritoJudicialID
                    uscResolAclaratoria.SalaJuzgado = ._GrillaSalaID
                    uscResolAclaratoria.ControlFocus()
                End If
            End With
        End Sub

        Private Sub uscResolAclaratoria__Click_FrmBusquedaAutoridadJudicial() Handles uscResolAclaratoria._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial
        End Sub
    End Class
End Namespace