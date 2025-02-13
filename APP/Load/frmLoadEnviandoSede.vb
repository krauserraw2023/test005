Namespace Load
    Public Class frmLoadEnviandoSede

        Private Sub frmLoad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

            If e.KeyCode = Keys.Escape Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

        Private Sub frmEsperaPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Width = 212
        End Sub
    End Class
End Namespace


