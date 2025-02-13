Namespace Registro.Expediente
    Public Class frmCargarProceso

#Region "Propiedades_Publicas"

        Public Property _NumeroExpediente() As String
            Get
                Return txtNumExpediente.Text
            End Get
            Set(ByVal value As String)
                txtNumExpediente.Text = value
            End Set
        End Property
        Public Property _SalaJudicial() As String
            Get
                Return txtSalaJudicial.Text
            End Get
            Set(ByVal value As String)
                txtSalaJudicial.Text = value
            End Set
        End Property
#End Region

#Region "Propiedades"

#End Region

#Region "Otros"
#End Region

        Private Sub frmCargarProceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load


            txtNumExpediente.Focus()

        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

            If Me.txtNumExpediente.Text.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar número de expediente / proceso vigente")
                txtNumExpediente.Focus()
                Exit Sub
            End If
            If Me.txtSalaJudicial.Text.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar sala judicial - distrito judicial")
                txtSalaJudicial.Focus()
                Exit Sub
            End If

            DialogResult = DialogResult.OK

        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

            DialogResult = DialogResult.Cancel

        End Sub


    End Class
End Namespace
