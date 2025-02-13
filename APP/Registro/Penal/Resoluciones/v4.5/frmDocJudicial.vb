Imports Type.Enumeracion.Licencia

Namespace Registro.Documento
    Public Class frmDocJudicial
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing

#Region "Propiedades_Publicas"
        Private intTipoDocumentoJudicial As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno
        Public Property _TipoDocumentoJudicial() As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial
            Get
                Return intTipoDocumentoJudicial
            End Get
            Set(ByVal value As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial)
                intTipoDocumentoJudicial = value
            End Set
        End Property
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _PenalLM As Boolean = False
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades"
        Private intDocumentoJudicialID As Integer = -1
        Public Property _DocumentoJudicialID() As Integer
            Get
                Return intDocumentoJudicialID
            End Get
            Set(ByVal value As Integer)
                intDocumentoJudicialID = value
            End Set
        End Property
#End Region
#Region "Propiedades_Par"
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Public Property _FormText() As String
            Get
                Return Me.Text
            End Get
            Set(ByVal value As String)
                Me.Text = value
            End Set
        End Property
        Public Property _RegionID() As Short = -1
        Public Property _PenalID() As Short = -1
        Public Property _Vesion() As Boolean = False
#End Region

#Region "Listar"
        Private Sub Listar()
            ucsDocJud._ListarDocJudicial()
        End Sub
#End Region
#Region "Accion"

        Private Sub AGrabar()
            ucsDocJud._TipoDocumentoJudicial = Me._TipoDocumentoJudicial '  Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Rectificacion_Nombres
            ucsDocJud._InternoID = Me._InternoID
            ucsDocJud._IngresoInpeID = Me._IngresoInpeID
            ucsDocJud._IngresoID = Me._IngresoID
            ucsDocJud.TipoLicencia = Me.TipoLicencia
            ucsDocJud._RegionID = Me._RegionID
            ucsDocJud._Penal = Me._PenalID
            ucsDocJud._Version = Me._Vesion
            Me._DocumentoJudicialID = ucsDocJud._GuardarDocJud()
            If Me._DocumentoJudicialID > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ucsDocJud._TipoDocumentoJudicial = Me._TipoDocumentoJudicial  ' _TipoDocumentoJudicial
            ucsDocJud._LoadValorxDefault()
            ucsDocJud._DocumentoJudicialID = Me._DocumentoJudicialID
        End Sub
        Private Sub UsuarioPermisos()
            Me.btnOk.Visible = Me._FormEscritura
        End Sub

#End Region
#Region "Eventos Formulario"
        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()

        End Sub
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub frmDocJudicial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub
        Private Sub frmDocJudicial_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Listar()
            UsuarioPermisos()
        End Sub

#End Region

    End Class

End Namespace
