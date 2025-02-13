Namespace Registro.Resoluciones
    Public Class frmResolTraslado
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
#Region "propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _blnNuevoRegistro() As Boolean = False
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
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Resoluciones
#End Region
#Region "accion"
        Private Function AGrabar() As Integer
            Me._Codigo = uscResolTraslado.AGrabar()
            If Me._Codigo = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe este numero y tipo de documento")
                Return -1
            End If
            If Me._Codigo = -2 Then
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe este numero y tipo de documento")
                Return -2
            End If
        End Function
#End Region
#Region "Formularios"
        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    uscResolTraslado.DistritoJudicial = .getCodigo
                End If
            End With

        End Sub
#End Region
#Region "otros"
        Private Sub ValoresxDefault()
            With uscResolTraslado
                ._Codigo = Me._Codigo
                ._InternoId = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._TipoFormulario = Me._TipoFormulario
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
        End Sub
        Private Sub Usuario_Permiso()
           
            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If uscResolTraslado.Validar = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                    If AGrabar() > -1 Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close() '
                    End If
                End If
            End If
        End Sub

        Private Sub frmResolTraslado_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()

        End Sub

        Private Sub frmResolTraslado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        End Sub

        Private Sub uscResolTraslado__Click_VerFormulario() Handles uscResolTraslado._Click_VerFormulario
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = uscResolTraslado.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    uscResolTraslado.DistritoJudicial = ._DistritoJudicialID
                    uscResolTraslado.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub uscResolTraslado__Click_FrmBusquedaAutoridadJudicial() Handles uscResolTraslado._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial
        End Sub
    End Class
End Namespace