Namespace Tratamiento.TallerAsistencia.Planilla
    Public Class frmRegistromonto

#Region "Propiedades"
        Public Property _Codigo() As Integer = -1
        'Public Property _Monto As String

        Public Property _Monto() As String
            Get
                Return txtTotal.Text
            End Get
            Set(ByVal value As String)
                txtTotal.Text = value
            End Set
        End Property

#End Region

#Region "Accion"
        Private Function Validar() As Boolean
            _Monto = _Monto.Replace(",", ".")
            If IsNumeric(_Monto) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El valor del monto no es numérico, verifique.")
                txtTotal.Focus()
                Return False
            End If
            Dim conta As Integer = 0
            Dim val As String = ""
            For i As Integer = 0 To CStr(_Monto).Length - 1
                val = CStr(_Monto).Substring(i, 1)
                If val = "," Or val = "." Then
                    conta += 1
                    val = ""
                End If
            Next
            If conta > 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El valor del monto no es numérico, verifique.")
                txtTotal.Focus()
                Return False
            End If
            If Me.txtTotal.Text = 0 Or Me.txtTotal.Text = "0,00" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El valor del monto no puede ser 0.00")
                txtTotal.Focus()
                Return False
            End If

            Return True

        End Function

        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim objbss As New Bussines.Tratamiento.TallerAsistencia.PlanillaDetalle
            Dim obj As New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle

            With obj
                obj.Codigo = Me._Codigo
                obj.IngresoTotal = Me._Monto
            End With

            intValue = objbss.Grabar_Monto(obj)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region


        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub frmRegistromonto_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            txtTotal.Focus()
        End Sub


        Private Sub frmRegistromonto_Load(sender As Object, e As EventArgs) Handles Me.Load

        End Sub

        Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                AGrabar()
            Else
                If InStr(1, "0123456789.," & Chr(8), e.KeyChar) = 0 Then
                    e.KeyChar = ""
                Else
                    If e.KeyChar = "." And e.KeyChar = "," And InStr(1, txtTotal.Text, ".") > 0 Then e.KeyChar = ""
                End If
            End If
        End Sub

    End Class

End Namespace
