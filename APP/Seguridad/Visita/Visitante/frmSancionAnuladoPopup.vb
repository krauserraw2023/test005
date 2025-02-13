Namespace Visita.Visitante
    Public Class frmSancionAnuladoPopup
        Private objBss As Bussines.Visita.VisitanteSancion = Nothing
        Private objEnt As Entity.Visita.VisitanteSancion = Nothing
#Region "Propiedades_Parametricas"
        Public Property _VisitanteID() As Integer = -1
        Public Property _VisitanteApeNom As String = ""
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
#End Region
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Private Property MotivoSancion() As String
            Get
                Return Me.txtMotivoSancion.Text
            End Get
            Set(ByVal value As String)
                Me.txtMotivoSancion.Text = value
            End Set
        End Property
       
        Private Property FechaSancion() As Long
        Private ReadOnly Property FechaSancionString() As String
            Get
                Dim valor As String = ""
                If Me.FechaSancion > 0 Then
                    Dim fec_mov As Date
                    fec_mov = Legolas.Components.FechaHora.FechaDate(Me.FechaSancion, False)
                    valor = fec_mov
                End If
                Return valor
            End Get
        End Property
      
        Private Property Documento() As String
            Get
                Return Me.txtDocumentoSancion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDocumentoSancion.Text = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObservacionSancion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacionSancion.Text = value
            End Set
        End Property

        Private Property DocumentoAnulado() As String
            Get
                Return Me.txtDocumentoAnulacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDocumentoAnulacion.Text = value
            End Set
        End Property
        Private Property MotivoAnulado() As String
            Get
                Return Me.txtMotivoAnulacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtMotivoAnulacion.Text = value
            End Set
        End Property
        Private Property ObservacionAnulado() As String
            Get
                Return Me.txtObservacionAnulacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacionAnulacion.Text = value
            End Set
        End Property
        Private Property FechaAnulacion() As Long = 0
        Private ReadOnly Property FechaAnulacionString() As String
            Get
                Dim valor As String = ""
                If Me.FechaAnulacion > 0 Then
                    Dim fec_mov As Date
                    fec_mov = Legolas.Components.FechaHora.FechaDate(Me.FechaAnulacion, True)
                    valor = fec_mov
                End If
                Return valor
            End Get
        End Property
#End Region
#Region "Propiedades_Otros"
        Private blnVisibleGrabar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
            End Set
        End Property

#End Region

#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Visita.VisitanteSancion
            objBss = New Bussines.Visita.VisitanteSancion

            objEnt = objBss.Listar(Me.Codigo)
            With objEnt
                Me.MotivoSancion = .TipoSancionNombre
                Me.Documento = .Documento
                Me.Observacion = .Observacion
                Me.FechaSancion = .Fecha
                Me.txtFechaSancion.Text = Me.FechaSancionString
                Me.txtFechaInicio.Text = .FechaIniDate
                Me.txtFechaFin.Text = .FechaFinDate
                Me.Observacion = .Observacion

                'HabilitarIndeterminado() 'funcion
                Me.DocumentoAnulado = .DocumentoAnulacion
                Me.MotivoAnulado = .MotivoAnulacion
                Me.ObservacionAnulado = .ObsAnulacion
                Me.FechaAnulacion = .FechaAnulacion
                Me.txtFechaAnulacion.Text = Me.FechaAnulacionString

            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            'visitante 
            If Me._VisitanteID < 1 Then
                blnValue = False
                Return blnValue
            End If

            Return blnValue
        End Function
      
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            InhabilitarControles()
        End Sub
        Private Sub InhabilitarControles()
            txtMotivoSancion.ReadOnly = True
            txtDocumentoSancion.ReadOnly = True
            txtObservacionSancion.ReadOnly = True
            txtFechaSancion.ReadOnly = True
            txtFechaInicio.ReadOnly = True
            txtFechaFin.ReadOnly = True

            txtDocumentoAnulacion.ReadOnly = True
            txtMotivoAnulacion.ReadOnly = True
            txtObservacionAnulacion.ReadOnly = True
            txtFechaAnulacion.ReadOnly = True
        End Sub

#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub



        Private Sub frmSancionPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmSancionPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()

        End Sub

        Private Sub chkIndeterminado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub chkIndeterminado_Click(ByVal sender As Object, ByVal e As System.EventArgs)

            'HabilitarIndeterminado()

        End Sub
    End Class
End Namespace

