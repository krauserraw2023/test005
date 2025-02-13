Public Class frmObservacion
    'Public Property _DedoEsAmputado() As Boolean

    Public Property _Observacion() As String
        Get
            Return txtObservacion.Text
        End Get
        Set(value As String)
            txtObservacion.Text = value
        End Set
    End Property
    'Public Property _HuellaEsObservada As Boolean
    '    Get
    '        Return chkObservado.CheckState
    '    End Get
    '    Set(value As Boolean)
    '        chkObservado.Checked = value
    '    End Set
    'End Property

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If txtObservacion.Text = "" Then
            MsgBox("No ha ingresado observación.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub chkObservado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkObservado.CheckedChanged

    End Sub

    Private Sub chkObservado_Click(sender As Object, e As System.EventArgs) Handles chkObservado.Click
        'If Me._DedoEsAmputado = True And chkObservado.Checked = True Then
        '    MsgBox("Operación no válida, el dedo se encuentra marcado como amputado.", MsgBoxStyle.Exclamation)
        '    chkObservado.Checked = False
        'End If
    End Sub
End Class