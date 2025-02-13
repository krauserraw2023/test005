Imports System.Windows.Forms
Namespace Registro.RegionLima.Identificacion
    Public Class frmSelectInternoPopup
#Region "Propiedades"
        Public Property _TipoInterno As Short = -1

        Private ReadOnly Property TipoInterno As Short
            Get
                Dim value As Short = -1

                If Me.rdbInterno.Checked = True Then
                    value = Type.Enumeracion.Interno.enmTipoInterno.Interno
                End If

                If Me.rdbInternoFuera.Checked = True Then
                    value = Type.Enumeracion.Interno.enmTipoInterno.InternoExterno
                End If

                Return value
            End Get
        End Property
#End Region
        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

            Me.Close()

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

            Me._TipoInterno = Me.TipoInterno
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

            Me.rdbInterno.Checked = True

        End Sub

        Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

            Me.rdbInternoFuera.Checked = True

        End Sub
    End Class
End Namespace