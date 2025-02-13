Public Class frmSelectTipoDedo
    Public indiceDedoSel As Integer = 0
    Dim blEsManoDerecha As Boolean = False

    Public Sub New(esManoDerecha As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        blEsManoDerecha = esManoDerecha
        If blEsManoDerecha Then
            rdbMed_izq.Visible = False
            rdbInd_izq.Visible = False
            rdbPul_izq.Visible = False
        Else
            rdbMed_der.Visible = False
            rdbInd_der.Visible = False
            rdbPul_der.Visible = False
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If blEsManoDerecha Then
            If rdbMed_der.Checked Then indiceDedoSel = 8
            If rdbInd_der.Checked Then indiceDedoSel = 7
            If rdbPul_der.Checked Then indiceDedoSel = 6
        Else
            If rdbMed_izq.Checked Then indiceDedoSel = 3
            If rdbInd_izq.Checked Then indiceDedoSel = 4
            If rdbPul_izq.Checked Then indiceDedoSel = 5

        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSelectTipoDedo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class