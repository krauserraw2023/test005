Namespace Visita.Programacion
    Public Class frmDetalleExtraordinarioPopup
        Private objBss As Bussines.Visita.Autorizacion = Nothing
        Private objEnt As Entity.Visita.Autorizacion = Nothing
#Region "Propiedades_Par"
        Public Property _Codigo As Integer = -1
        Public Property _CalendarioDetUsado As Boolean = False
#End Region

#Region "Propiedades"
        Private Property VisitanteID() As Integer = -1
        Private Property VisitanteApeNom() As String
            Get
                Return Me.txtVisitante.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVisitante.Text = value.ToString.ToUpper
            End Set
        End Property
        Private Property VisitanteTipoyNumDoc() As String
            Get
                Return Me.txtTipoDocNum.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtTipoDocNum.Text = value.ToString.ToUpper
            End Set
        End Property
        Private Property ParentescoID() As Integer
            Get
                Return Me.cbbParentesco.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbParentesco.SelectedValue = value
            End Set
        End Property        
#End Region
#Region "Combo"
        Private Sub ComboParentesco()

            Dim objBss As New Bussines.Globall.Parentesco
            Dim objEntCol As New Entity.Globall.ParentescoCol

            objEntCol = objBss.ComboTipo1SinAbogado(False)

            With Me.cbbParentesco
                .DataSource = objEntCol
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Visita.Autorizacion
            objBss = New Bussines.Visita.Autorizacion

            objEnt = objBss.Listar(Me._Codigo)

            With objEnt

                Me.VisitanteID = .VisitanteID
                Me.VisitanteApeNom = .VisitanteApellidosyNombres
                Me.VisitanteTipoyNumDoc = .VisitanteTipoDoc_Numero
                Me.ParentescoID = .ParentescoID
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            If _CalendarioDetUsado = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El registro actual no permite modificar los datos, debido que ya se encuentra en uso en el modulo de visita.")
                value = False
                Return value
            End If

            value = True
            Return value

        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Dim value As Integer = -1
            objBss = New Bussines.Visita.Autorizacion

            Dim objEnt As New Entity.Visita.Autorizacion

            With objEnt
                .Codigo = Me._Codigo
                .ParentescoID = Me.ParentescoID
            End With

            value = objBss.GrabarParentesco(objEnt)

            If value > 0 Then
                Me.DialogResult = DialogResult.OK
            End If

        End Sub
#End Region
#Region "Otros"

        Private Sub ValoresxDefault()

            ComboParentesco()

        End Sub

#End Region
        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            AOK()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub frmAutorizacionPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmAutorizacionPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()

        End Sub
    End Class

End Namespace