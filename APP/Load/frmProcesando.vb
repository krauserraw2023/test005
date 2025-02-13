Namespace Load
    Public Class frmProcesando
        Public Property _PermitirCancelar As Boolean = True
        Private Sub frmProcesando_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

            If e.KeyCode = Keys.Escape And _PermitirCancelar = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

        Private Sub frmProcesando_Load(sender As Object, e As EventArgs) Handles Me.Load

            Me.Width = 212

        End Sub
    End Class
End Namespace
