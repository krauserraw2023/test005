Namespace Registro.Carceleta.Clasificacion
    Public Class frmDetIndicador
        Public Property _Puntaje As Integer
        Public Property _Indicador As String

        Private Sub frmDetIndicador_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            lblIndicador.Text = Me._Indicador
            lblPtjIndicador.Text = "PUNTAJE: " & _Puntaje & "  "
        End Sub

        Private Sub frmDetIndicador_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If (e.KeyCode = Keys.Escape) Then
                Me.Close()
            End If
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub
    End Class
End Namespace