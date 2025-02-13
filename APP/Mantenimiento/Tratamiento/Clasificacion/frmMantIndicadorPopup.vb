Namespace Mantenimiento.Clasificacion
    Public Class frmManValoresPopup
#Region "Propiedades_publicas"
        Public Property _Codigo() As Integer = -1
        Public Property _FichaId() As Integer = -1
        Public Property _VariableID() As Integer = -1
        Public Property _IndicadorCol() As Entity.Registro.Carceleta.Clasificacion.MaestroIndicadorCol_BE
#End Region
#Region "Propiedades_privadas"
        Private Property NumeroOrden() As Integer
            Get
                Return If(txtNumOrd.Text.Length = 0, 0, Integer.Parse(txtNumOrd.Text))
            End Get
            Set(value As Integer)
                txtNumOrd.Text = value
            End Set
        End Property
        Private Property Puntaje() As Integer
            Get
                Return If(txtPuntaje.Text.Length = 0, 0, Integer.Parse(txtPuntaje.Text))
            End Get
            Set(value As Integer)
                txtPuntaje.Text = value
            End Set
        End Property
        Private Property Descripcion() As String
            Get
                Return txtIndicador.Text
            End Get
            Set(value As String)
                txtIndicador.Text = value
            End Set
        End Property
#End Region
#Region "listar"
        Private Sub Listar()
            If Me._Codigo > 0 Then

                Dim entCat As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE

                entCat = (New Bussines.Clasificacion.MaestroIndicador).Listar(Me._Codigo)
                With entCat
                    Me._VariableID = .VariableID
                    Me._FichaId = .FichaId
                    Me.Descripcion = .Descripcion
                    Me.Puntaje = .Puntaje
                    Me.NumeroOrden = .Secuencia
                End With
            End If

            If Me._Codigo < 0 And Me._IndicadorCol.Count = 0 Then txtNumOrd.Text = 1

        End Sub
#End Region
#Region "Accion"
        Private Function Agrabar() As Boolean
            If Me.Descripcion.Length = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ingrese nombre del indicador")
                txtIndicador.Focus()
                Return False
            End If

            If Me.NumeroOrden <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ingrese el número de orden")
                txtNumOrd.Focus()
                Return False
            End If

            If Me.Puntaje <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ingrese un valor válido para el puntaje")
                txtPuntaje.Focus()
                Return False
            End If

            For Each obj As Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE In Me._IndicadorCol
                If obj.Secuencia = Integer.Parse(txtNumOrd.Text) And obj.Codigo <> Me._Codigo Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Número de orden duplicado, debe cambiar a otro número")
                    txtNumOrd.Focus()
                    Return False
                End If

                If obj.Descripcion = txtIndicador.Text.Trim And obj.Codigo <> Me._Codigo Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("El nombre del indicador ya existe")
                    txtIndicador.Focus()
                    Return False
                End If
            Next

            Dim outErrSms As String = ""
            Dim entCat As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE
            With entCat
                .Codigo = Me._Codigo
                .FichaId = Me._FichaId
                .VariableID = Me._VariableID
                .Descripcion = Me.Descripcion
                .Puntaje = Me.Puntaje
                .Secuencia = Me.NumeroOrden
            End With

            Dim id As Integer = -1

            id = (New Bussines.Clasificacion.MaestroIndicador).Grabar(entCat, outErrSms)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outErrSms)
                Return False
            End If
            Return True
        End Function
#End Region
        Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
            If Agrabar() = False Then Exit Sub
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmManValoresPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Listar()
        End Sub

        Private Sub frmManValoresPopup_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then Me.Close()
        End Sub
    End Class
End Namespace