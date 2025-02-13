Namespace Mantenimiento.Clasificacion
    Public Class frmCategorizacionPopup
#Region "Propiedades_publicas"
        Public Property _Codigo() As Integer = -1
        Public Property _FichaId() As Integer = -1
        Public Property _CatFichaCol() As Entity.Registro.Carceleta.Clasificacion.CategoriaFichaCol_BE
        Public Property _TipoFicha As Type.Enumeracion.Clasificacion.enmTipoFicha = Type.Enumeracion.Clasificacion.enmTipoFicha.Ninguno
#End Region
#Region "Propiedades_privada"
        Private Property CategoriaNombre() As String
            Get
                Return txtCategoria.Text
            End Get
            Set(value As String)
                txtCategoria.Text = value
            End Set
        End Property
        Private Property ValorMaximo() As Integer
            Get
                Return If(txtValMax.Text.Length = 0, 0, Integer.Parse(txtValMax.Text))
            End Get
            Set(value As Integer)
                txtValMax.Text = value
            End Set
        End Property
        Private Property ValorMinimo() As Integer
            Get
                Return If(txtValMin.Text.Length = 0, 0, Integer.Parse(txtValMin.Text))
            End Get
            Set(value As Integer)
                txtValMin.Text = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()
            If Me._Codigo > 0 Then
                Dim entCat As New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE

                entCat = (New Bussines.Clasificacion.CategoriaFicha).Listar(Me._Codigo)
                With entCat
                    Me.CategoriaNombre = .CategoriaNombre
                    Me.ValorMinimo = .ValorMinimo
                    Me.ValorMaximo = .ValorMaximo
                End With
            End If
        End Sub
#End Region
#Region "Accion"
        Private Function Agrabar() As Boolean
            If Me.CategoriaNombre.Length = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ingrese nombre de la categoria")
                txtCategoria.Focus()
                Return False
            End If

            If Me._TipoFicha <> Type.Enumeracion.Clasificacion.enmTipoFicha.Final Or Me.ValorMinimo > 0 Then 'para la ficha los valores pueden ser ambos cero.
                If Me.ValorMinimo <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Debe ingresar valor minimo válido")
                    txtValMin.Focus()
                    Return False
                End If

                If Me.ValorMaximo <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Debe ingresar valor máximo válido")
                    txtValMax.Focus()
                    Return False
                End If

                For Each obj As Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE In _CatFichaCol
                    If Me.ValorMinimo >= obj.ValorMinimo And Me.ValorMinimo <= obj.ValorMaximo And obj.Codigo <> Me._Codigo Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                            "Error, el Valor mínimo actual no puede ser igual o estar dentro del intervalo de valores de otra categoria")
                        txtValMin.Focus()
                        Return False
                    End If

                    If Me.ValorMaximo >= obj.ValorMinimo And Me.ValorMaximo <= obj.ValorMaximo And obj.Codigo <> Me._Codigo Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                            "Error, el Valor máximo actual no puede ser igual o estar dentro del intervalo de valores de otra categoria")
                        txtValMin.Focus()
                        Return False
                    End If
                Next
            End If

            Dim outErrSms As String = ""
            Dim entCat As New Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE

            With entCat
                .Codigo = Me._Codigo
                .FichaId = Me._FichaId
                .CategoriaNombre = Me.CategoriaNombre
                .ValorMinimo = Me.ValorMinimo
                .ValorMaximo = Me.ValorMaximo
            End With

            Dim id As Integer = -1

            id = (New Bussines.Clasificacion.CategoriaFicha).Grabar(entCat, outErrSms)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outErrSms)
                Return False
            End If

            Return True
        End Function
#End Region
        Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmCategorizacionPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Listar()
        End Sub

        Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
            If Agrabar() = False Then Exit Sub

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub frmCategorizacionPopup_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then Me.Close()
        End Sub
    End Class
End Namespace