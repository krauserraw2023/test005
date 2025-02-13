Namespace Visita
    Public Class frmVisitaSalidaPopup
#Region "Propiedades"
        Public ReadOnly Property _FechaSalida() As Long
            Get
                Return Legolas.Configuration.Aplication.FechayHora.FechaLong
            End Get
        End Property
        Public ReadOnly Property _HoraSalida() As String
            Get
                Return Me.lblHoraSal.Text.Trim
            End Get
        End Property
        Public Property _Observacion As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.lblHoraSal.Text = Legolas.LBusiness.Globall.DateTime.HoraServer
            Me.Timer1.Enabled = True

        End Sub
#End Region

        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

            Me.lblHoraSal.Text = CDate(Me.lblHoraSal.Text).AddSeconds(1).ToString("HH:mm:ss")

        End Sub

        Private Sub frmVisitaSalidaPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            If Me._Observacion.Length < 5 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese la observacion por el cual esta realizando la salida masiva")
                Me.txtObs.Focus()
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End Sub
    End Class
End Namespace


