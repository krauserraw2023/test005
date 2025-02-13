Namespace Load
    Public Class frmLoad02
        Public Enum enmTipoImagen
            Ninguno = 0
            Reniec = 1
            Migraciones = 2
        End Enum
        Public Property _TipoImagen As enmTipoImagen = enmTipoImagen.Reniec

        Private Sub frmLoad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

            If e.KeyCode = Keys.Escape Then
                Me.DialogResult = DialogResult.OK
            End If

        End Sub

        Private Sub frmEsperaPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Width = 160

            Select Case Me._TipoImagen
                Case enmTipoImagen.Reniec
                    Me.PictureBox1.Image = My.Resources.reniec03
                Case enmTipoImagen.Migraciones
                    Me.PictureBox1.Image = My.Resources.logo_migraciones
            End Select

        End Sub
    End Class
End Namespace


