Namespace Registro.Resoluciones
    Public Class frmNotaPeriodo
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
#Region "Propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _blnNuevoRegistro() As Boolean = False
        Public Property _CodigoInterno() As String
            Get
                Return lblCodInterno.Text
            End Get
            Set(ByVal value As String)
                lblCodInterno.Text = value
            End Set
        End Property
        Public Property _NombresInterno() As String
            Get
                Return lblInterno.Text
            End Get
            Set(ByVal value As String)
                lblInterno.Text = value
            End Set
        End Property
        Public Property _Subtipo As Integer = -1
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
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Resoluciones
#End Region
#Region "Accion"
        Private Sub AGrabar()
            If UscNotas1.Validar = True Then
                If UscPeriodoCondena1.Validar = True Then
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                        UscNotas1._TotalAnhos = IIf(UscPeriodoCondena1._TotalAnhos.Length = 0, 0, UscPeriodoCondena1._TotalAnhos)
                        UscNotas1._TotalMeses = IIf(UscPeriodoCondena1._TotalMes.Length = 0, 0, UscPeriodoCondena1._TotalMes)
                        UscNotas1._TotalDias = IIf(UscPeriodoCondena1._TotalDias.Length = 0, 0, UscPeriodoCondena1._TotalDias)
                        Me._Codigo = UscNotas1.AGrabar()

                        UscPeriodoCondena1._Grabar(Me._Codigo, _blnNuevoRegistro, objEnt)

                        If Me._Codigo > 0 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub
#End Region
#Region "Otros"
        Public Sub ValoresxDefault()
            With UscNotas1
                ._InternoID = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._SubTipo = Me._Subtipo
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
            With UscPeriodoCondena1
                ._InternoId = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                ._TotalAnhos = UscNotas1._TotalAnhos
                ._TotalMes = UscNotas1._TotalMeses
                ._TotalDias = UscNotas1._TotalDias
                ._ListarPeriodo(Me._Codigo)
            End With
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura
        End Sub
        Private Sub FRM_MantPeriodoSentencia(ByVal Nuevo As Boolean, objEntPeriodoSentencia As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Dim frm As New Sentencias.frmPeriodoCondenaSentencia
            With frm
                ._EntPeriodoCondena = objEntPeriodoSentencia
                ._RegionId = Me._RegionID
                ._PenalId = Me._PenalID
                ._TemporalNuevo = Nuevo
                ._objEntExpedienteTempoCol = UscPeriodoCondena1.objEntExpedienteTempoCol
                ._TipoDocumentoId = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscPeriodoCondena1._Temporal_GrabarPeriodoCondena(._EntPeriodoCondena)
                End If
            End With
        End Sub
#End Region

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            AGrabar()

        End Sub

        Private Sub frmNota_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        End Sub

        Private Sub frmNota_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            Me.ValoresxDefault()
            Usuario_Permiso()

        End Sub

        Private Sub UscNotas1__Click_VerFormulario()
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UscNotas1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    UscNotas1.DistritoJudicial = ._DistritoJudicialID
                    UscNotas1.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub UscPeriodoCondena1__Click_PeriodoCondena_Agregar() Handles UscPeriodoCondena1._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub UscPeriodoCondena1__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscPeriodoCondena1._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub
    End Class
End Namespace