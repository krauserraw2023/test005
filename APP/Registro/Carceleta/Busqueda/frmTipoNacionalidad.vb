Namespace Registro.Main.Carceleta
    Public Class frmTipoNacionalidad
        Public Property _ValidarConReniec As Boolean = False
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            If MsgBox("Se va a cancelar la operación de registro, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                DialogResult = Windows.Forms.DialogResult.None
            End If
        End Sub

        Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
            If RadioButton1.Checked = True Then
                Me._ValidarConReniec = True
            Else
                Me._ValidarConReniec = False
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
    End Class
End Namespace