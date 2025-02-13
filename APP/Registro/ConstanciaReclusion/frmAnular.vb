Namespace Registro.ConstanciaReclusion
    Public Class frmAnular

#Region "propiedades"
        Private Property accion As String = ""
        Private Property codigo As Integer = -1
        Private Property idRegion As Short = -1
        Private Property idPenal As Short = -1
        Public Property _observacion As String
            Get
                Return txtObservacionAnulado.Text
            End Get
            Set(value As String)
                txtObservacionAnulado.Text = value
            End Set
        End Property
#End Region

#Region "validar"
        Private Function Validar() As Boolean
            Dim blnValue As Boolean = False

            If Me.txtObservacionAnulado.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar el motivo de la anulación del documento")
                txtObservacionAnulado.Focus()
                Return blnValue
            End If

            Return True
        End Function
#End Region

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            If Validar() = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

    End Class

End Namespace