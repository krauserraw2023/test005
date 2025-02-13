Namespace Visita.Visitante
    Public Class frmAnulacionPopup
        Private objBss As Bussines.Visita.InternoSancion = Nothing
        Private objEnt As Entity.Visita.InternoSancion = Nothing
#Region "Propiedades_Parametricas"
        Private intInternoID As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Public Property _InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
        Public Property _InternoApellidosyNombres As String = ""
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
#End Region
#Region "Propiedades"
        Public Property Codigo As Integer = -1
        Public Property SancionVisitanteID As Integer = -1
        Public Property Documento() As String
            Get
                Return Me.txtDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDoc.Text = value
            End Set
        End Property
        Public Property Motivo() As String
            Get
                Return Me.txtMotivo.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtMotivo.Text = value
            End Set
        End Property
        Public Property Observacion() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
        Public Property FechaAnu() As String
            Get
                Return Me.txtFecha.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtFecha.Text = value
            End Set
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
#Region "Propiedades_Return"
        Public Property _IDSancionReturn As Integer = -1
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Visita.InternoSancion
            objBss = New Bussines.Visita.InternoSancion

            objEnt = objBss.Listar(Me.Codigo)
            With objEnt

                Me.Documento = .Documento
                Me.Observacion = .Obs
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            'visitante 
          
            If Me.Documento.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar documento de anulacion.")
                txtDoc.Focus()
                blnValue = False
                Return blnValue
            End If
            If Me.Motivo.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar motivo de anulacion.")
                txtMotivo.Focus()
                blnValue = False
                Return blnValue
            End If
            If Me.Observacion.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar observacion de anulacion.")
                txtObs.Focus()
                blnValue = False
                Return blnValue
            End If
            If Me.txtDoc.Text.Trim = "" Or Me.txtObs.Text.Trim = "" Then
                blnValue = False
                Return blnValue
            End If

            Return blnValue
        End Function

        Private Sub AGrabar()
            If Validar() = True Then
                Dim entAnu As New Entity.Visita.VisitanteSancion
                Dim objBss As New Bussines.Visita.VisitanteSancion

                With entAnu
                    .Codigo = Me.SancionVisitanteID
                    .DocumentoAnulacion = Me.Documento
                    .MotivoAnulacion = Me.Motivo
                    .ObsAnulacion = Me.Observacion
                    .EstadoID = 0
                End With

                Me.SancionVisitanteID = objBss.GrabarAnu(entAnu)

                If Me.SancionVisitanteID > 0 Then
                    Me._IDSancionReturn = Me.SancionVisitanteID
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.btnOk.Visible = Me._VisibleGrabar
            Me.FechaAnu = Legolas.Configuration.Aplication.FechayHora.FechaDate
        End Sub
       
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub frmSancionPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmSancionPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()

        End Sub

       

        Private Sub MyTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtObs.TextChanged

        End Sub
    End Class
End Namespace

