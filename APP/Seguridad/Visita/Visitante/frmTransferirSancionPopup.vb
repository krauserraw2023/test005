Imports System.ComponentModel

Namespace Visita.Visitante
    Public Class frmTransferirSancionPopup
        Private frmLoad As Load.frmLoadEnviandoSede = Nothing
        Private blnCancelarVerificacion As Boolean = False
        Private blnProceso As Boolean = False
        Private strMensajeOut As String = ""
#Region "Propiedades"
        Public Property _IDSancion As Integer = -1
#End Region

        Private Function ProcesarHilo(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean

            Dim value As Boolean = False

            If worker.CancellationPending = True Then
                e.Cancel = True
            Else

                Threading.Thread.Sleep(1000 * 1)

                Dim strErrorCodigo As String = ""
                Dim strErrorMensaje As String = ""

                Try

                    'grabar en la ws de la sede central
                    Dim strMensajeOut As String = ""
                    Dim objBss As New Bussines.Visita.VisitanteSancionSede
                    value = objBss.SubirSancionSede(e.Argument, strMensajeOut)

                Catch ex As Exception
                    strMensajeOut = ex.Message
            End Try

            End If

            Return value

        End Function

        Private Sub IniciarTranferencia()

            If Legolas.LBusiness.Globall.WinApp.LicenciaApp <> "1" Then

                If Me._IDSancion > 0 Then

                    If Legolas.Components.PC.IsOnline Then

                        Me.SuspendLayout()
                        Me.BackgroundWorker1.RunWorkerAsync(Me._IDSancion)

                        blnCancelarVerificacion = False

                        frmLoad = New Load.frmLoadEnviandoSede
                        If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            Me.BackgroundWorker1.CancelAsync()
                            'Me.BackgroundWorker1.Dispose()
                            blnCancelarVerificacion = True
                        End If

                        Me.ResumeLayout(True)
                        frmLoad.Refresh()

                        If blnCancelarVerificacion = False Then

                            If blnProceso = False Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                            End If

                        End If

                    End If

                End If

            End If

            Me.Refresh()

            Me.Close()

        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As System.EventArgs) Handles BackgroundWorker1.Disposed

            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso")
                Me.BackgroundWorker1 = Nothing
            End If

        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else

                strMensajeOut = ""
                e.Result = ProcesarHilo(worker, e)

            End If

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                blnProceso = e.Result
            End If

        End Sub

        Private Sub frmTransferirSancionPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.Refresh()
            IniciarTranferencia()

        End Sub
    End Class
End Namespace

