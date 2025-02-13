Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones.v5
    Public Class uscResolucionesDetalle

        Private objBss As Bussines.Registro.IngresoInpe = Nothing
        Private objEnt As Entity.Registro.IngresoInpe = Nothing
#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _DocumJudicialD() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public RegionDestinoID As Integer = -1
        Public PenalDestinoID As Integer = -1
        Public Property _EstablecimientomentalId As Integer = -1
        Private Property RegionDestino() As Integer
            Get
                Return cbbRegionDestino.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegionDestino.SelectedValue = value
            End Set
        End Property
        Private Property PenalDestino() As Integer
            Get
                Return cbbPenalDestino.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenalDestino.SelectedValue = value
            End Set
        End Property
        Public Property DocumentoTipo As Integer = -1
        Public Property _intCondicionGrupo() As Integer = -1
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
        Public Event _Click_Seleccionar_Motivo(MotivoId As Integer)
#End Region
#Region "Propiedades"
        Public Property _MovimientoGrupo() As Integer = -1
        Public Property _MovimientoTipo() As Integer
            Get
                Return Me.cbbMovTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovTipo.SelectedValue = value
            End Set
        End Property
        Public Property _MovimientoMotivo() As Integer
            Get
                Return Me.cbbMovMotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovMotivo.SelectedValue = value
            End Set
        End Property
        Public Property _MovimientoMotivoId() As Integer

        Private Property EstadoID() As Integer = -1

        Public Property _RegionID() As Integer = -1

        Public Property _PenalID() As Integer = -1
        Public Property _PenalID1() As Integer = -1

        Private Property Observacion() As String = ""
        Public Property _RegionDestino() As Integer
            Get
                Return Me.cbbRegionDestino.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegionDestino.SelectedValue = value
            End Set
        End Property
        Public Property _PenalDestino() As Integer
            Get
                Return Me.cbbPenalDestino.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenalDestino.SelectedValue = value
            End Set
        End Property

#End Region
#Region "Propiedades_Retorno"
        Public ReadOnly Property _getIdMovimientoMotivo As Short
            Get
                Return Me._MovimientoMotivo
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub CargarComboRegion()
            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select

            With Me.cbbRegionDestino
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With
            cbbRegionDestino.SelectedValue = 3 'Region Lima
            cbbRegionDestino.Enabled = False
        End Sub
        Private Sub CargarComboPenal()
            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select

            With Me.cbbPenalDestino
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.RegionDestino
                .LoadUsc()
            End With
            cbbPenalDestino.SelectedValue = -1
        End Sub

        Private Sub ComboMovimientoTipo()
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovTipo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoTipo
                .SelectedValue = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                .Enabled = False
            End With
        End Sub
        Private Sub ComboMovimientoMotivo()
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovMotivo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoMotivo_LM(Me._MovimientoTipo, Type.Combo.enmTipoTexto.Mayuscula, False, IIf(Me._DocumJudicialD < 1, "NUE", ""))
            End With

        End Sub

#End Region
#Region "Listar"
        Public MotivoAuxId As Integer = -1
        Private Sub Listar()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            Dim bss As New Bussines.Registro.IngresoInpe
            objEnt = New Entity.Registro.IngresoInpe
            objEnt = bss.Listar(Me._IngresoInpeID)
            objEnt.Codigo = Me._IngresoInpeID
            objEnt.IDTipoMovimiento = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
            objEnt = bss.Listar(objEnt)
            If objEnt.Codigo > 0 Then
                cbbMovTipo.SelectedValue = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                Me._MovimientoMotivo = IIf(objEnt.MotivoIngresoID = -1, Me._MovimientoMotivoId, objEnt.MotivoIngresoID)
            End If

            If Me._DocumJudicialD < 1 Then
                Dim bssM As New Bussines.Registro.InternoMovimiento
                Dim objM As New Entity.Registro.InternoMovimiento
                objM.InternoID = Me._InternoID
                objM.IngresoInpeId = Me._IngresoInpeID
                objM.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                objM.MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso

                cbbPenalDestino.SelectedValue = PenalDestinoID
                Me._MovimientoMotivo = -1
            Else
                cbbPenalDestino.SelectedValue = Me.PenalDestinoID
                Me.PenalDestino = Me.PenalDestinoID
            End If

        End Sub

#End Region
#Region "Accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = True
       
            Dim entMovCol As New Entity.Registro.InternoMovimientoCol
            Dim entMov As New Entity.Registro.InternoMovimiento
            entMov.InternoID = Me._InternoID
            entMov.IngresoInpeId = Me._IngresoInpeID
            If Me._MovimientoTipo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar tipo de Movimiento de Ingreso")
                cbbMovTipo.Focus()
                blnValue = False
            ElseIf Me._MovimientoMotivo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar tipo de Motivo de Ingreso")
                cbbMovMotivo.Focus()
                blnValue = False
            ElseIf Me._RegionDestino < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Region de destino")
                cbbRegionDestino.Focus()
                blnValue = False
            ElseIf Me._PenalDestino < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Penal de destino")
                cbbPenalDestino.Focus()
                blnValue = False
            End If
            'If Me._MovimientoMotivo = 178 Or Me._MovimientoMotivo = 179 Then
            '    If Me._EstablecimientomentalId < 1 Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar Establecimento mental")
            '        btnListaEstablecimientosmentales.Focus()
            '        Return False
            '    End If
            'End If
            Return blnValue
        End Function
       
        Public Function AGrabar() As Integer
            objBss = New Bussines.Registro.IngresoInpe
            Dim value As Integer = -1
            If objEnt.Codigo > 0 Then
                objEnt.IDTipoMovimiento = Me._MovimientoTipo
                objEnt.MotivoIngresoID = Me._MovimientoMotivo
                value = objBss.GrabarUpd(objEnt)
            End If
            Return value
        End Function
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ComboMovimientoTipo()
            ComboMovimientoMotivo()
            CargarComboRegion()
            CargarComboPenal()
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                Me.cbbMovMotivo.Enabled = False
                Me.cbbPenalDestino.Enabled = False
            End If
            Listar()
        End Sub
        Public Sub _LoadUsc()
            ValoresxDefault()
        End Sub

#End Region
        Private Sub cbbRegionIngreso__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            CargarComboPenal()
        End Sub

        Private Sub cbbMovTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbMovTipo.SelectedIndexChanged
            ComboMovimientoMotivo()
        End Sub

        Private Sub cbbMovMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMovMotivo.SelectedIndexChanged
            Select Case cbbMovMotivo.SelectedValue
                Case 115, 129
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El motivo de ingreso seleccionado no esta vigente, operación cancelada.")
                    cbbMovMotivo.SelectedValue = -1
                    Exit Sub
            End Select
            RaiseEvent _Click_Seleccionar_Motivo(cbbMovMotivo.SelectedValue)
        End Sub

        Private Sub btnListaEstablecimientosmentales_Click(sender As Object, e As EventArgs)

            Dim frm As New Registro.Expediente.frmDatosInimputablesPopup
            With frm
                ._idCentroSaludMental = _EstablecimientomentalId
                ._idTipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                'frm._blnReferenciado = IIf(UscExpeDeResolucionIng1.intReferenciado = 0, False, True)
                ._idTipoLicencia = Me._TipoLicencia

                If .ShowDialog = DialogResult.OK Then
                    _EstablecimientomentalId = ._getIdCentroSaludMental
                End If
            End With

        End Sub
    End Class
End Namespace
