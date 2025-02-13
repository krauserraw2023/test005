Namespace Mantenimiento.Tratamiento.Clasificacion
    Public Class frmMantResultadoPopupDet
        Private objBss As Bussines.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet = Nothing
        Private objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE = Nothing
#Region "Propiedades_publicas"
        Public Property _Codigo() As Short = -1
        Public Property _IDFichaResultado As Short = -1        
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
        Private Property PuntajeInicial() As Short
            Get
                Return If(txtPuntajeIni.Text.Length = 0, 0, Integer.Parse(txtPuntajeIni.Text))
            End Get
            Set(value As Short)
                Me.txtPuntajeIni.Text = value
            End Set
        End Property
        Private Property PuntajeFinal() As Short
            Get
                Return If(txtPuntajeFin.Text.Length = 0, 0, Integer.Parse(txtPuntajeFin.Text))
            End Get
            Set(value As Short)
                Me.txtPuntajeFin.Text = value
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
        Private Property Tabla() As Integer
            Get
                Return Me.cbbTabla.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbTabla.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet
            objEnt = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE

            objEnt = objBss.Listar(Me._Codigo)
            With objEnt
                'Me.NumeroOrden = .NumeroOrden
                Me.PuntajeInicial = .PuntajeInicial
                Me.PuntajeFinal = .PuntajeFinal
                'Me.Nombre = .Nombre
                Me.Tabla = .IDTabla
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            If Me.NumeroOrden <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese un número de orden secuencial válido.")
                txtNumOrd.Focus()
                Return False
            End If

            If Me.PuntajeInicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese puntaje inicial.")
                Me.txtPuntajeIni.Focus()
                Return False
            End If

            If Me.PuntajeFinal <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese puntaje final.")
                Me.txtPuntajeFin.Focus()
                Return False
            End If

            If Me.Nombre.Trim.Length = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ingrese el nombre.")
                Me.txtNombre.Focus()
                Return False
            End If

            value = True

            Return value

        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim outErrSms As String = ""
            objEnt = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE

            With objEnt
                .Codigo = Me._Codigo
                '.NumeroOrden = Me.NumeroOrden
                .PuntajeInicial = Me.PuntajeInicial
                .PuntajeFinal = Me.PuntajeFinal
                '.Nombre = Me.Nombre
                .IDTabla = Me.Tabla
            End With

            Dim intvalue As Short = -1
            objBss = New Bussines.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet
            intvalue = objBss.Grabar(objEnt, outErrSms)

            If intvalue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If outErrSms.Trim.Length > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outErrSms)
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La operacion no se ha realizado correctamente. Intentelo nuevamente")
                End If
            End If

        End Sub
#End Region

        Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click

            AGrabar()

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