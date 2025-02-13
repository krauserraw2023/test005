Namespace Mantenimiento.Tratamiento.Clasificacion
    Public Class frmMantResultadoPopup
        Private objBss As Bussines.Mantenimiento.Tratamiento.Clasificacion.Resultado = Nothing
        Private objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE = Nothing
#Region "Propiedades_Publicas"
        Public Property _Codigo As Short = -1
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
        Private Property Nombre() As String
            Get
                Return txtNombre.Text
            End Get
            Set(value As String)
                txtNombre.Text = value
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
        Private Property UtilizaTabla As Boolean
            Get
                Return Me.chkTabla.Checked
            End Get
            Set(value As Boolean)
                Me.chkTabla.Checked = value
            End Set
        End Property
        Private Property TablaNombre As String
            Get
                Return Me.txtNombreTabla.Text
            End Get
            Set(value As String)
                Me.txtNombreTabla.Text = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Mantenimiento.Tratamiento.Clasificacion.Resultado
            objEnt = New Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE

            objEnt = objBss.Listar(Me._Codigo)
            With objEnt
                'Me.NumeroOrden = .NumeroOrden
                'Me.Nombre = .Nombre
                Me.Descripcion = .Descripcion
                Me.UtilizaTabla = .TieneValorTabla
                Me.Nombre = .NombreTabla
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Agrabar() As Boolean

            If Me.NumeroOrden <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese un número de orden secuencial")
                txtNumOrd.Focus()
                Return False
            End If

            If Me.Nombre.Length = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre")
                txtNombre.Focus()
                Return False
            End If

            If Me.UtilizaTabla = True Then
                If Me.TablaNombre.Trim = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre de la tabla")
                    txtNombreTabla.Focus()
                    Return False
                End If
            End If

            Return True
        End Function
#End Region

        Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click

            If Agrabar() = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK                
            End If

        End Sub

        Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click

            Me.Close()

        End Sub

        Private Sub frmMantVariablePopup_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If

        End Sub

        Private Sub frmMantVariablePopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Listar()
        End Sub

    End Class
End Namespace