Namespace Registro.ConstanciaReclusion
    Public Class frmObsPopup
#Region "propiedades"
        Public Property _ObsAnulacion As String = ""
#End Region

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

            If Me.txtObsAnu.Text.Length > 3 Then

                Me._ObsAnulacion = Me.txtObsAnu.Text
                Me.DialogResult = DialogResult.OK
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el motivo de anulación")
                Me.txtObsAnu.Focus()
            End If

        End Sub

        Private Sub frmObsPopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            Me.txtObsAnu.Focus()

        End Sub
    End Class
End Namespace
