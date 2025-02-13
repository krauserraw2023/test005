Namespace Mantenimiento.Clasificacion
    Public Class frmMantVariablePopup
#Region "Propiedades_publicas"
        Public Property _Codigo() As Integer = -1
        Public Property _FichaId() As Integer = -1
        Public Property _VariableCol() As Entity.Registro.Carceleta.Clasificacion.MaestroVariableCol_BE
#End Region
#Region "Propiedades_privada"
        Private Property NumeroOrden() As Integer
            Get
                Return If(txtNumOrd.Text.Length = 0, 0, Integer.Parse(txtNumOrd.Text))
            End Get
            Set(value As Integer)
                txtNumOrd.Text = value
            End Set
        End Property
        Private Property VariableNombre() As String
            Get
                Return txtVariable.Text
            End Get
            Set(value As String)
                txtVariable.Text = value
            End Set
        End Property
        Private Property Descripcion() As String
            Get
                Return txtDescripcion.Text
            End Get
            Set(value As String)
                txtDescripcion.Text = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()
            If _Codigo < 0 And Me._VariableCol.Count = 0 Then txtNumOrd.Text = 1

            If _Codigo > 0 Then
                Dim entVar As New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE

                entVar = (New Bussines.Clasificacion.MaestroVariable).Listar(Me._Codigo)

                With entVar
                    Me.NumeroOrden = .NumeroOrden
                    Me.VariableNombre = .Nombre
                    Me.Descripcion = .Descripcion
                End With
            End If

        End Sub
#End Region
        '#Region "Accion"
        Private Function Agrabar() As Boolean

            If Me.VariableNombre.Length = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ingrese el nombre de la variable.")
                txtVariable.Focus()
                Return False
            End If

            If Me.NumeroOrden <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ingrese un número de orden secuencial válido para la visualización ordenada en los reportes.")
                txtNumOrd.Focus()
                Return False
            End If

            For Each obj As Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE In Me._VariableCol
                If obj.NumeroOrden = Integer.Parse(txtNumOrd.Text) And obj.Codigo <> Me._Codigo Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Número de orden duplicado, debe cambiar a otro número")
                    txtNumOrd.Focus()
                    Return False
                End If

                If obj.Nombre = txtVariable.Text.Trim And obj.Codigo <> Me._Codigo Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("El nombre de la variable ya existe")
                    txtVariable.Focus()
                    Return False
                End If
            Next

            Dim outErrSms As String = ""
            Dim entCat As New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE

            With entCat
                .Codigo = Me._Codigo
                .FichaID = Me._FichaId
                .NumeroOrden = Me.NumeroOrden
                .Nombre = Me.VariableNombre
                .Descripcion = Me.Descripcion
            End With

            Dim id As Integer = -1

            id = (New Bussines.Clasificacion.MaestroVariable).Grabar(entCat, outErrSms)

            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outErrSms)
                Return False
            End If

            Return True
        End Function
        '#End Region

        Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
            If Agrabar() = False Then Exit Sub
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmMantVariablePopup_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
            If e.KeyCode = Keys.Escape Then Me.Close()
        End Sub

        Private Sub frmMantVariablePopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Listar()
        End Sub

    End Class
End Namespace