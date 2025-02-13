Namespace Registro.Carceleta.Clasificacion.Documento
    Public Class frmDetGlosaPopup
        Public Property _Codigo As Integer

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub frmDetGlosaPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Dim ent As New Entity.Globall.GlosaDocumento

            ent = (New Bussines.Globall.GlosaDocumento).ListarPorCodigo(Me._Codigo)

            Me.txtCodGlosa.Text = ent.CodigoString
            Me.txtDescripcion.Text = ent.Texto
            Me.txtDescCorta.Text = ent.DescripcionCorta
        End Sub

        Private Sub frmDetGlosaPopup_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If (e.KeyCode = Keys.Escape) Then Me.Close()
        End Sub
    End Class
End Namespace