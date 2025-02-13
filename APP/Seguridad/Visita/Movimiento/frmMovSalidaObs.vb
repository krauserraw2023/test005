Namespace Visita.Movimiento
    Public Class frmMovSalidaObs
#Region "Propiedades"
        Public Property _Observacion As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(value As String)
                Me.txtObs.Text = value
            End Set
        End Property


#End Region

        Private Sub frmVisitaSalidaPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.txtObs.Focus()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End Sub
    End Class
End Namespace


