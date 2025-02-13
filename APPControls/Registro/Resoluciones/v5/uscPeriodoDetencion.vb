Imports Type.Enumeracion.Movimiento
Namespace Registro.Resoluciones
    Public Class uscPeriodoDetencion
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing

#Region "Propiedades_Parametricas"

        Public Property _Codigo As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
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
#Region "Eventos"
        Public Event _Click_VerFormulario()
#End Region
#Region "Propiedades"
        Public Property _DocumentoTipo() As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno

        Public Property ProlonDetencionFechIni As Long
            Get
                Return dtpFechIni.ValueLong
            End Get
            Set(value As Long)
                dtpFechIni.ValueLong = value
            End Set
        End Property
        Public Property ProlonDetencionFechFin As Long
            Get
                Return dtpFechFin.ValueLong
            End Get
            Set(value As Long)
                dtpFechFin.ValueLong = value
            End Set
        End Property
        Public Property ProlonDetencionTipoUnidad As String
            Get
                Dim stdVal As String = ""
                If Trim(cbbUnidad.Text) = "" Then stdVal = ""
                If cbbUnidad.Text = "AÑO" Then stdVal = "A"
                If cbbUnidad.Text = "DIA" Then stdVal = "D"
                If cbbUnidad.Text = "MES" Then stdVal = "M"
                Return stdVal
            End Get
            Set(value As String)
                If value = "" Then cbbUnidad.Text = ""
                If value = "A" Then cbbUnidad.Text = "AÑO"
                If value = "D" Then cbbUnidad.Text = "DIA"
                If value = "M" Then cbbUnidad.Text = "MES"
            End Set
        End Property
        Public Property ProlonDetencionValor As Integer
            Get
                Return Val(txtCant.Text)
            End Get
            Set(value As Integer)
                If value = 0 Then
                    txtCant.Text = ""
                Else
                    txtCant.Text = value
                End If
            End Set
        End Property
#End Region
#Region "Combo"

#End Region
#Region "Listar"
        Private Sub Listar()

            'Me.rdbFechas.Visible = False
            'Me.rdbValor.Visible = False

        End Sub
#End Region
#Region "accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = False

            'If rdbFechas.Checked = True Then
            If Not (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.MedioLibreLimaMetropolitana) Then
                    If Me.ProlonDetencionFechIni = 0 Or Me.ProlonDetencionFechFin = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe especificar la fecha inicial y final de la prolongación de detención")
                        If ProlonDetencionFechIni = 0 Then
                            dtpFechIni.Focus()
                        Else
                            dtpFechFin.Focus()
                        End If
                        Return blnValue
                    End If
                End If

            Return True
        End Function
        Public Function Validar(motivoId As Integer) As Boolean
            Dim blnValue As Boolean = True

            If motivoId <> Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoPrisionPreventiva Then Return True

            If Val(txtCant.Text) < 1 Then
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar el tiempo de la prisión preventiva.")
                'txtCant.Select()
                Return blnValue
            End If
            If Trim(cbbUnidad.Text) = "" Then
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de unidad de la prision preventiva (Día/Mes/Año).")
                'cbbUnidad.Select()
                Return blnValue
            End If

            Return True
        End Function
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            If Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                Me.gbPrisionpreventiva.Text = "Tiempo de Detención"
                Me.lblCantidad.Text = "Tiempo"
                'Me.rdbFechas.Visible = False
                'Me.rdbValor.Visible = False
            End If
        End Sub
        Public Sub _LoadUsc()
            Me._blnNuevo = IIf(_Codigo = -1, True, False)
            ValoresxDefault()
        End Sub
        Public Sub _Listar()
            Listar()
        End Sub
        Public Sub ConfigurarUscPrisionPreventiva()
            Me.gbPrisionpreventiva.Text = "Plazo de prisión preventiva:"
            'Me.lblFecini.Text = "Fecha de inicio"
            'Me.lblFecfin.Text = "Fecha fin"
            Me.lblCantidad.Text = "Tiempo"
        End Sub
#End Region
        Private Sub cbbUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbUnidad.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub
    End Class
End Namespace