Imports Type.Enumeracion

Namespace Estadistica
    Public Class frmPadinDetalleMensajePopup
#Region "Propiedades"
        Public Property strMensaje As String
#End Region

#Region "Otros"

        Private Sub ValoresxDefault()

            If strMensaje.Trim.Length > 0 Then
                Dim valor() As String
                valor = strMensaje.Split("*")

                With dgvMensaje
                    .RowCount = valor.Length - 1
                    For i As Integer = 0 To valor.Length - 1
                        If i > 0 Then
                            .Item(0, i - 1).Value = i
                            .Item(1, i - 1).Value = valor(i)
                        End If
                    Next
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                    .CurrentCell = Nothing
                End With
            End If

        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub frmPadinDetalleMensajePopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()

        End Sub

        Private Sub btnDetalleInterno_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalleInterno.Click
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
    End Class
End Namespace