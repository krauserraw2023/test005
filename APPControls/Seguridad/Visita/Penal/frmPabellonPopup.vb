Namespace Visita
    Public Class frmPabellonPopup
#Region "Propiedades_Par"
        Public Property _RegionID As Short = -1
        Public Property _PenalID As Short = -1
#End Region
#Region "Propiedades_Return"
        Public ReadOnly Property _PabellonID() As Integer
            Get
                Return Me.PabellonID
            End Get
        End Property
        Public ReadOnly Property _PabellonNombre() As String
            Get
                Return Me.PabellonNombre
            End Get
        End Property
#End Region
#Region "Propiedades"
        Private Property PabellonID() As Integer
            Get
                Return Me.cbbPabellon._SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbPabellon._SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property PabellonNombre() As String
            Get
                Return Me.cbbPabellon._Text
            End Get
        End Property

#End Region
#Region "Combo"
        Private Sub ComboPabellon()

            With Me.cbbPabellon
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Ninguno = True
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AOK()

            If Me.PabellonID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Seleccione Pabellon")
                Me.cbbPabellon.Focus()
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            AOK()

        End Sub

        Private Sub frmPabellonPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ComboPabellon()

        End Sub

        Private Sub frmPabellonPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.cbbPabellon.Focus()

        End Sub
    End Class
End Namespace
