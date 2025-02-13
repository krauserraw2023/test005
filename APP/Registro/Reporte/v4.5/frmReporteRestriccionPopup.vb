Namespace Registro.Reporte
    Public Class frmReporteRestriccionPopup
#Region "Propiedades"
        Private Property Nombre() As String
            Get
                Return Me.txtNombre.Text
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
#End Region
#Region "Return"
        Public ReadOnly Property _Nombre() As String
            Get
                Return Me.Nombre
            End Get
        End Property
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            If Me.Nombre.Trim = "" Then
                blnValue = False
                Return blnValue
            End If

            Return blnValue
        End Function

#End Region

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            If Validar() = False Then
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub frmReporteRestriccionPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.txtNombre.Focus()

        End Sub
    End Class

End Namespace